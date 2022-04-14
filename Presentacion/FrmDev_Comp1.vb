Public Class FrmDev_Comp1
    Private formulario As New FrmDev_Comp2
    Dim id_dev_Comp As Integer
    Dim tabla_dev_Comp As DataTable
    Dim tabla_detalle_tabla_dev_Comp As DataTable
    'Dim tabla_detalle_Mat_Prima As DataTable

    Public Sub listar_Dev_Comp(ByVal _Fecha_Ing_Ini As String,
                            ByVal _Fecha_Ing_Fin As String,
                              ByVal _distrito As String
                                                       )
        mesajeerror.ForeColor = Color.Blue
        ' Me.TXTESTADO2.ForeColor = Color.Red


        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            'If servidor.consultar("[dbo].[pa_listar_guias]", Numero, remitente).Tables.Count > 0 Then
            '    tabla_guias = servidor.consultar("[dbo].[pa_listar_guias]", Numero, remitente).Tables(0)
            'End If

            tabla_dev_Comp = servidor.consultar("[dbo].[pa_Listar_Devolucion_Comp_de_Pago]",
                                     _Fecha_Ing_Ini,
                                       _Fecha_Ing_Fin,
                                    _distrito
                                       ).Tables(0)
            If tabla_dev_Comp Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim NroFilas As Integer = tabla_dev_Comp.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    dgvlista.DataSource = tabla_dev_Comp
                    '   MessageBox.Show("Materia Prima, no se encuentra registrada", "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MessageBox.Show("No hay personas para mostrar", "Persona", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    mesajeerror.Text = "NO HAY DEVOLUCION DE TIPO DE COMPROBANTES DE PAGO CON LOS CRITERIOS DE BUSQUEDA SELECCIONADOS O INGRESADOS"
                    mesajeerror.ForeColor = Color.Red

                Else
                    dgvlista.DataSource = tabla_dev_Comp
                    servidor.cerrarconexion()
                    mesajeerror.Text = "Guía de Remisión – Remitente Tiene " + NroFilas.ToString + " Devolucion(ES) de Tipo de Comprobantes de Pago"

                    Try
                        'POSICIONA CURSOR EN ULTIMA FILA
                        dgvlista.ClearSelection()
                        dgvlista.CurrentCell = dgvlista.Rows(dgvlista.RowCount - 1).Cells(2)
                        'Me.dgvlista.Refresh()
                    Catch ex As Exception

                    End Try


                End If
                dgvlista.Columns("Id Dev Comp").Visible = False
                dgvlista.Columns("Id_Ubigeo").Visible = False
                dgvlista.Columns("Id_Ope").Visible = False
                dgvlista.Columns("Tipo Operacion").Visible = False
                dgvlista.Columns("Departamento").Visible = False
                'Me.dgvlista.Columns("Tipo Operacion").Visible = False



            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



        '   Try
        '    'POSICIONA CURSOR EN ULTIMA FILA
        '    Me.dgvlista.ClearSelection()
        '    Me.dgvlista.CurrentCell = Me.dgvlista.Rows(Me.dgvlista.RowCount - 1).Cells(1)
        '    'Me.dgvlista.Refresh()
        'Catch ex As Exception

        'End Try

    End Sub
    Public Sub listar_detalle_Dev_Comp(ByVal id_Dev_Comp As Integer)
        mesajeerror2.ForeColor = Color.Blue

        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            tabla_detalle_tabla_dev_Comp = servidor.consultar("[dbo].[pa_Listar_Detalle_Devolucion_Comp_de_Pago]", id_Dev_Comp).Tables(0)
            If tabla_detalle_tabla_dev_Comp Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim NroFilas As Integer = tabla_detalle_tabla_dev_Comp.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    dgvlistaDetalle.DataSource = tabla_detalle_tabla_dev_Comp
                Else
                    dgvlistaDetalle.DataSource = tabla_detalle_tabla_dev_Comp
                    servidor.cerrarconexion()
                    mesajeerror2.Text = "Devolución de Comprobantes de Pago Tiene " + NroFilas.ToString + " Detalle(S)"
                End If
                Try
                    'POSICIONA CURSOR EN ULTIMA FILA
                    dgvlistaDetalle.ClearSelection()
                    dgvlistaDetalle.CurrentCell = dgvlistaDetalle.Rows(dgvlistaDetalle.RowCount - 1).Cells(2)
                    'Me.dgvlista.Refresh()
                Catch ex As Exception

                End Try

                dgvlistaDetalle.Columns("Id_Detalle_Dev_Comp").Visible = False
                dgvlistaDetalle.Columns("Id_Devolucion_Comp").Visible = False
                dgvlistaDetalle.Columns("Id_Detalle_Env_Comp").Visible = False
                'Me.dgvlistaDetalle.Columns("Estado").Visible = False
                'Me.dgvlistaDetalle.Columns("Id_Envio_Comp").Visible = False
                'Me.dgvdetalle.
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Me.dgvdetalle.Columns("cantidad")

    End Sub
    Private Sub FrmDev_Comp1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmDev_Comp1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REM Obtenenemos la cadena de coneccion al servidor
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        listar_Dev_Comp("", "", "")
    End Sub
    Private Sub dgvlista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick
        Try
            indice = e.RowIndex
            id_dev_Comp = dgvlista.Item("Id Dev Comp", indice).Value
            listar_detalle_Dev_Comp(id_dev_Comp)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellEnter
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
    End Sub


    Private Sub dgvlista_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvlistaDetalle.RowsAdded
        BtnModificar.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False)) ': mesajeerror.Text = ""
        btnEliminar.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False))
        'Me.btnImprimir.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False)) ': mesajeerror.Text = ""

    End Sub

    Private Sub dgvlista_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvlistaDetalle.RowsRemoved
        BtnModificar.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False)) ': mesajeerror.Text = ""
        btnEliminar.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False))
        'Me.btnImprimir.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False)) ': mesajeerror.Text = ""
    End Sub


    Private Sub dgvlista_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgvlistaDetalle.VisibleChanged
        BtnModificar.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False)) ': mesajeerror.Text = ""
        btnEliminar.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False))
        'Me.btnImprimir.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False)) ' : mesajeerror.Text = ""
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim f As New FrmDev_Comp2
        'f.CbEstado.SelectedIndex = 0
        f.Nivel = "N"
        f.id_Dev_Comp = 0
        f.ShowDialog()
        listar_Dev_Comp("", "", "")
        dgvlistaDetalle.DataSource = Nothing
        f.dgvlista.Rows.Clear()
        'f.dgvlista.DataSource = Nothing
        ' f.dgvlista.Refresh()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If indice = -1 Then
            MessageBox.Show("Seleccione Registro por favor.", "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim f As New FrmDev_Comp2
        f.btneliminar.Enabled = True
        f.btnQuitar.Enabled = False


        f.id_Dev_Comp = CInt(dgvlista.Item("Id Dev Comp", indice).Value.ToString())
        f.direccion.Text = CStr(dgvlista.Item("Direccion", indice).Value.ToString())
        f.Fecha_Ingreso.Value = CDate(dgvlista.Item("Fecha de Devolucion", indice).Value.ToString())
        f.txtDescrip.Text = CStr(dgvlista.Item("Descripcion", indice).Value.ToString())

        f.id_Ubigeo = CInt(dgvlista.Item("Id_Ubigeo", indice).Value)
        f.departamento.Text = CStr(dgvlista.Item("Departamento", indice).Value.ToString.Trim)
        f.provincia.Text = CStr(dgvlista.Item("Provincia", indice).Value.ToString.Trim)
        f.distrito.Text = CStr(dgvlista.Item("Distrito", indice).Value.ToString.Trim)

        f.id_ope = CInt(dgvlista.Item("Id_Ope", indice).Value.ToString())
        f.TxtTipoOperac.Text = CStr(dgvlista.Item("Tipo Operacion", indice).Value.ToString())
        f.TxtOpe.Text = CStr(dgvlista.Item("Operacion", indice).Value.ToString())



        ' Dim k As Integer = 0
        For i As Integer = 0 To dgvlistaDetalle.Rows.Count - 1
            'If CBool(dgvdetmaquila.Item("SELECCIONAR", i).Value) = True Then
            f.dgvlista.Rows.Add()

            'f.dgvlista.Item("A", i).Value = 1
            f.dgvlista.Item("A", i).Value = dgvlistaDetalle.Item("Id_Detalle_Dev_Comp", i).Value
            f.dgvlista.Item("B", i).Value = dgvlistaDetalle.Item("Id_Devolucion_Comp", i).Value
            f.dgvlista.Item("C", i).Value = dgvlistaDetalle.Item("Id_Detalle_Env_Comp", i).Value
            f.dgvlista.Item("D", i).Value = dgvlistaDetalle.Item("Comisionista", i).Value
            f.dgvlista.Item("E", i).Value = dgvlistaDetalle.Item("Remitente", i).Value
            f.dgvlista.Item("F", i).Value = dgvlistaDetalle.Item("Comprobante de Pago", i).Value
            f.dgvlista.Item("G", i).Value = dgvlistaDetalle.Item("Serie", i).Value
            f.dgvlista.Item("H", i).Value = dgvlistaDetalle.Item("Numero", i).Value
            f.dgvlista.Item("I", i).Value = dgvlistaDetalle.Item("Estado", i).Value
            ' f.dgvlista.Item("J", i).Value = Me.dgvlistaDetalle.Item("Estado Tolva", i).Value

            '  k += 0
            ' End If

        Next

        f.Nivel = "M"

        f.ShowDialog()

        indice = -1

        listar_Dev_Comp("", "", "")


        dgvlistaDetalle.DataSource = Nothing
        'dgvdetmaquila.DataSource = Nothing
        'dgvproduccion.DataSource = Nothing
        'Me.BtnModificar.Enabled = False
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If check_fila_grilla(dgvlistaDetalle) = False Then
            MessageBox.Show("Haga check en la columna Seleccionar por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If MessageBox.Show("¿Desea eliminar el detalle Devolucion?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then
                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    For i As Integer = 0 To dgvlistaDetalle.Rows.Count - 1
                        If CBool(dgvlistaDetalle.Item(0, i).Value) = True Then
                            Dim cod1 As Integer = Convert.ToInt32(dgvlistaDetalle.Item("Id_Detalle_Dev_Comp", i).Value)
                            Dim cod2 As Integer = Convert.ToInt32(dgvlistaDetalle.Item("Id_Detalle_Env_Comp", i).Value)
                            Dim cod3 As Integer = Convert.ToInt32(dgvlistaDetalle.Item("Id_Devolucion_Comp", i).Value)
                            Dim estado As String = Convert.ToString(dgvlistaDetalle.Item("Estado", i).Value)
                            servidor.ejecutar("[dbo].[pa_mantenimiento_Detalle_Devolucion_Comp_de_Pago]",
                              False,
                              rpta,
                              mensaje,
                               cod1,
                                estado,
                                 cod2,
                                cod3,
                              "E",
                              0, "")
                        End If
                    Next
                    If rpta = 1 Then
                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        'Me.__mensaje.Value = __mesajeerror
                        'Me.__pagina.Value = "listapersonas.aspx"
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        servidor.cancelarconexiontrans()
                        __mesajeerror = mensaje
                        'Me.__pagina.Value = "listapersonas.aspx"
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    __mesajeerror = servidor.getMensageError
                    'Me.mesajeerror.Text = __mesajeerror
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            'indice = -1
        End If
        listar_detalle_Dev_Comp(id_dev_Comp)
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        listar_Dev_Comp(IIf(CbFechaIng.Checked = True, Year(dtpfinic.Value).ToString + "-" + Month(dtpfinic.Value).ToString + "-" + dtpfinic.Value.Day.ToString, ""),
               IIf(CbFechaIng.Checked = True, Year(dtpffin.Value).ToString + "-" + Month(dtpffin.Value).ToString + "-" + dtpffin.Value.Day.ToString, ""),
         IIf(TxtDistrito.Text.Trim <> "", TxtDistrito.Text.Trim, ""))



        dgvlistaDetalle.DataSource = Nothing
    End Sub
    Private Sub CbFechaIng_CheckedChanged(sender As Object, e As EventArgs) Handles CbFechaIng.CheckedChanged
        dtpfinic.Enabled = CbFechaIng.Checked : dtpffin.Enabled = CbFechaIng.Checked
        dtpfinic.Value = DateSerial(Now.Date.Year, Now.Month, 1)
        ' dtpfin.Value = DateTime.Now
        dtpffin.Value = DateTime.Now
        dtpfinic.Focus()
    End Sub

    Private Sub CboDistrito_CheckedChanged(sender As Object, e As EventArgs) Handles CboDistrito.CheckedChanged
        TxtDistrito.Enabled = CboDistrito.Checked : TxtDistrito.Text = "" : TxtDistrito.Focus()
    End Sub

    Private Sub TxtDistrito_Enter(sender As Object, e As EventArgs) Handles TxtDistrito.Enter
        Try
            Dim f As New frmListarUbigeo
            f.ShowDialog()
            TxtDistrito.Text = CStr(f.dgvlista.Item("Distrito", indice).Value.ToString.Trim)
            'Me.btnConsultar.Focus()
            'Me.TxtRemitente.BackColor = Color.Azure
        Catch ex As Exception
            MessageBox.Show("Seleccione Distrito a Buscar", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


End Class
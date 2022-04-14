Public Class FrmIng_Comp1
    Private formulario As New FrmIng_Comp2
    Dim id_ING_Comp As Integer
    Dim tabla_Ing_Comp As DataTable
    Dim tabla_detalle_tabla_Ing_Comp As DataTable
    'Dim tabla_detalle_Mat_Prima As DataTable

    Public Sub listar_Ing_Comp(ByVal _Remitente As String, _
                            ByVal _Tipo_Comp As String, _
                            ByVal _Fecha_Ing_Ini As String, _
                            ByVal _Fecha_Ing_Fin As String
                            )
        mesajeerror.ForeColor = Color.Blue
        TXTESTADO2.ForeColor = Color.Red
        

        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            'If servidor.consultar("[dbo].[pa_listar_guias]", Numero, remitente).Tables.Count > 0 Then
            '    tabla_guias = servidor.consultar("[dbo].[pa_listar_guias]", Numero, remitente).Tables(0)
            'End If

            tabla_Ing_Comp = servidor.consultar("[dbo].[pa_Listar_Ingreso_Comp_de_Pago]", _
                                        _Remitente, _
                                       _Tipo_Comp, _
                                       _Fecha_Ing_Ini, _
                                       _Fecha_Ing_Fin
                                        ).Tables(0)
            If tabla_Ing_Comp Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim NroFilas As Integer = tabla_Ing_Comp.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    dgvlista.DataSource = tabla_Ing_Comp
                    '   MessageBox.Show("Materia Prima, no se encuentra registrada", "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MessageBox.Show("No hay personas para mostrar", "Persona", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    mesajeerror.Text = "NO HAY INGRESO DE TIPO DE COMPROBANTES DE PAGO CON LOS CRITERIOS DE BUSQUEDA SELECCIONADOS O INGRESADOS"
                    mesajeerror.ForeColor = Color.Red

                Else
                    dgvlista.DataSource = tabla_Ing_Comp
                    servidor.cerrarconexion()
                    mesajeerror.Text = "Guía de Remisión – Remitente Tiene " + NroFilas.ToString + " Ingreso(S) de Tipo de Comprobantes de Pago"

                    Try
                        'POSICIONA CURSOR EN ULTIMA FILA
                        dgvlista.ClearSelection()
                        dgvlista.CurrentCell = dgvlista.Rows(dgvlista.RowCount - 1).Cells(2)
                        'Me.dgvlista.Refresh()
                    Catch ex As Exception

                    End Try


                End If
                dgvlista.Columns("Id Ing Comp").Visible = False
                dgvlista.Columns("Id Ope").Visible = False
                dgvlista.Columns("Id Remitente").Visible = False
                dgvlista.Columns("Id Tipo Comp").Visible = False
                dgvlista.Columns("Tipo Operacion").Visible = False
                'Me.dgvlista.Columns("Fecha Ingreso").Visible = False
                'Me.dgvlista.Columns("Fecha Dcto").DefaultCellStyle.Format = "dd/MM/yyyy"
                'Me.dgvlista.Columns("Tipo de Operacion").Visible = False
                'Me.dgvlista.Columns("Zona").Visible = False


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
    Public Sub listar_detalle_Mat_Prima(ByVal id_ING_Comp As Integer)
        mesajeerror2.ForeColor = Color.Blue
       
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            tabla_detalle_tabla_Ing_Comp = servidor.consultar("[dbo].[pa_Listar_Detalle_Ingreso_Comp_de_Pago]", id_ING_Comp).Tables(0)
            If tabla_detalle_tabla_Ing_Comp Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim NroFilas As Integer = tabla_detalle_tabla_Ing_Comp.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    dgvlistaDetalle.DataSource = tabla_detalle_tabla_Ing_Comp
                Else
                    dgvlistaDetalle.DataSource = tabla_detalle_tabla_Ing_Comp
                    servidor.cerrarconexion()
                    mesajeerror2.Text = "Ingreso de Comprobantes de Pago Tiene " + NroFilas.ToString + " Detalle(S)"
                End If
                Try
                    'POSICIONA CURSOR EN ULTIMA FILA
                    dgvlistaDetalle.ClearSelection()
                    dgvlistaDetalle.CurrentCell = dgvlistaDetalle.Rows(dgvlistaDetalle.RowCount - 1).Cells(2)
                    'Me.dgvlista.Refresh()
                Catch ex As Exception

                End Try

                dgvlistaDetalle.Columns("Id_Detalle_Ing_Comp").Visible = False
                dgvlistaDetalle.Columns("Id_Ing_Comp").Visible = False
                'Me.dgvlistaDetalle.Columns("Humedad").Visible = False

                'Me.dgvdetalle.
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Me.dgvdetalle.Columns("cantidad")

    End Sub
    Private Sub FrmIng_Comp1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub dgvlista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick
        Try
            indice = e.RowIndex
            id_ING_Comp = dgvlista.Item("Id Ing Comp", indice).Value
            listar_detalle_Mat_Prima(id_ING_Comp)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FrmIng_Comp1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub FrmIng_Comp1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        REM Obtenenemos la cadena de coneccion al servidor
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        listar_Ing_Comp("", "", "", "")
       
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
        ' Me.btnImprimir.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False)) ': mesajeerror.Text = ""

    End Sub

    Private Sub dgvlista_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvlistaDetalle.RowsRemoved
        BtnModificar.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False)) ': mesajeerror.Text = ""
        btnEliminar.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False))
        ' Me.btnImprimir.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False)) ': mesajeerror.Text = ""
    End Sub


    Private Sub dgvlista_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvlistaDetalle.VisibleChanged
        BtnModificar.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False)) ': mesajeerror.Text = ""
        btnEliminar.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False))
        ' Me.btnImprimir.Enabled = CBool(IIf(dgvlistaDetalle.Rows.Count > 0, True, False)) ' : mesajeerror.Text = ""
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As System.EventArgs) Handles btnNuevo.Click
        Dim f As New FrmIng_Comp2
        f.btneliminar.Enabled = False
        f.btnQuitar.Enabled = True
        'f.CbEstado.SelectedIndex = 0
        f.Nivel = "N"
        f.id_ing_Comp = 0
        f.ShowDialog()
        listar_Ing_Comp("", "", "", "")
        dgvlistaDetalle.DataSource = Nothing
        'f.dgvlista.DataSource = Nothing
        ' f.dgvlista.Refresh()
    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As System.EventArgs) Handles BtnModificar.Click
        If indice = -1 Then
            MessageBox.Show("Seleccione Ingreso de Comprobantes de Pago por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        Try
            Dim f As New FrmIng_Comp2
            f.id_ing_Comp = CInt(dgvlista.Item("Id Ing Comp", indice).Value.ToString())
            f.Fecha_Ingreso.Value = CDate(dgvlista.Item("Fecha Ingreso", indice).Value.ToString())
            f.id_remitente = CInt(dgvlista.Item("ID Remitente", indice).Value.ToString())
            f.NombreRemitente.Text = CStr(dgvlista.Item("Empresa", indice).Value.ToString())
            f.id_ope = CInt(dgvlista.Item("Id Ope", indice).Value.ToString())
            f.TxtTipoOperac.Text = CStr(dgvlista.Item("Tipo Operacion", indice).Value.ToString())
            f.TxtOpe.Text = CStr(dgvlista.Item("Operacion", indice).Value.ToString())
            f.id_tipo_Comp = CInt(dgvlista.Item("Id Tipo Comp", indice).Value.ToString())
            f.TxtTipoComp.Text = CStr(dgvlista.Item("Comprobante de Pago", indice).Value.ToString())

            f.btneliminar.Enabled = True
            f.btnQuitar.Enabled = False
            'f.NombreRemitente.Text = "."
            'f.TxtOpe.Text = "."
            'f.TxtTipoComp.Text = "."

            f.Text = "Modificar Ingreso de Comprobantes de Pago " '& _TIPO_COMPROBANTE_DOC & " DE " & _OPERACION_DOC


            For i As Integer = 0 To dgvlistaDetalle.Rows.Count - 1

                f.dgvlista.Rows.Add()


                'descripcion del bien.
                f.dgvlista.Item("C", i).Value = dgvlistaDetalle.Item("Serie", i).Value
                'Variedad.
                f.dgvlista.Item("D", i).Value = dgvlistaDetalle.Item("Numero", i).Value
                'costo unitario del bien.
                f.dgvlista.Item("G", i).Value = dgvlistaDetalle.Item("Estado", i).Value
                f.dgvlista.Item("IDDETALLEINGCOMP", i).Value = dgvlistaDetalle.Item("Id_Detalle_Ing_Comp", i).Value
                'f.dgvlista.Item("IDINGCOMP", i).Value = Me.dgvlistaDetalle.Item("Id_Ing_Comp", i).Value
            Next

            f.Nivel = "M"

            f.ShowDialog()

            indice = -1
            ' f.dgvlista.Rows.Clear()
            dgvlistaDetalle.DataSource = Nothing
            listar_Ing_Comp("", "", "", "")
        Catch ex As Exception
            MessageBox.Show("Seleccione Ingreso de Comprobantes de Pago por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dgvlistaDetalle.DataSource = Nothing
        End Try

        'dgvlistaDetalle.DataSource = Nothing
        'f.id_ing_Comp = -1
        'f.id_remitente = -1
        'f.NombreRemitente.Text = ""
        'f.id_ope = -1
        'f.TxtTipoOperac.Text = ""
        'f.TxtOpe.Text = ""
        'f.id_tipo_Comp = -1
        'f.TxtTipoComp.Text = ""
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As System.EventArgs) Handles btnEliminar.Click
        If check_fila_grilla(dgvlistaDetalle) = False Then
            MessageBox.Show("Haga check en la columna Seleccionar por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If MessageBox.Show("¿Desea eliminar el detalle de los bienes?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then
                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    For i As Integer = 0 To dgvlistaDetalle.Rows.Count - 1
                        If CBool(dgvlistaDetalle.Item(0, i).Value) = True Then
                            servidor.ejecutar("[dbo].[pa_mantenimiento_Detalle_Ingreso_Comp_de_Pago]", _
                              False, _
                              rpta, _
                              mensaje, _
                              CInt(dgvlistaDetalle.Item("Id_Detalle_Ing_Comp", i).Value.ToString), _
                              Nothing, _
                              Nothing, _
                              Nothing, _
                              Nothing, _
                              "E", _
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
        listar_detalle_Mat_Prima(id_ING_Comp)
        ' dgvlistaDetalle.DataSource = Nothing

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As System.EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub CbFechaIng_CheckedChanged(sender As Object, e As System.EventArgs) Handles CbFechaIng.CheckedChanged
        dtpfinic.Enabled = CbFechaIng.Checked : dtpffin.Enabled = CbFechaIng.Checked
        dtpfinic.Value = DateSerial(Now.Date.Year, Now.Month, 1)
        ' dtpfin.Value = DateTime.Now
        dtpffin.Value = DateTime.Now
        dtpfinic.Focus()
    End Sub

    Private Sub CboRemitente_CheckedChanged(sender As Object, e As System.EventArgs) Handles CboRemitente.CheckedChanged
        TxtRemitente.Enabled = CboRemitente.Checked : TxtRemitente.Text = "" : TxtRemitente.Focus()
    End Sub
    Private Sub CboTipoCom_CheckedChanged(sender As Object, e As System.EventArgs) Handles CboTipoCom.CheckedChanged
        TxtTipo_Comp.Enabled = CboTipoCom.Checked : TxtTipo_Comp.Text = "" : TxtTipo_Comp.Focus()
    End Sub

  

    Private Sub btnBuscar_Click(sender As Object, e As System.EventArgs) Handles btnBuscar.Click
        listar_Ing_Comp(IIf(TxtRemitente.Text.Trim <> "", TxtRemitente.Text.Trim, ""), _
                            IIf(TxtTipo_Comp.Text.Trim <> "", TxtTipo_Comp.Text.Trim, ""), _
                           IIf(CbFechaIng.Checked = True, Year(dtpfinic.Value).ToString + "-" + Month(dtpfinic.Value).ToString + "-" + dtpfinic.Value.Day.ToString, ""), _
                    IIf(CbFechaIng.Checked = True, Year(dtpffin.Value).ToString + "-" + Month(dtpffin.Value).ToString + "-" + dtpffin.Value.Day.ToString, ""))

        dgvlistaDetalle.DataSource = Nothing
    End Sub

    Private Sub TxtRemitente_Enter(sender As Object, e As System.EventArgs) Handles TxtRemitente.Enter
        Try
            Dim f As New frmListarRemitentes
            f.ShowDialog()
            TxtRemitente.Text = CStr(f.dgvlista.Item("Remitente", indice).Value.ToString.Trim)
            'Me.btnConsultar.Focus()
            'Me.TxtRemitente.BackColor = Color.Azure
        Catch ex As Exception
            MessageBox.Show("Seleccione Empresa a Buscar", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
       
    End Sub

    Private Sub TxtRemitente_Leave(sender As Object, e As System.EventArgs) Handles TxtRemitente.Leave
        TxtRemitente.BackColor = Color.White
    End Sub

    Private Sub TxtTipo_Comp_Enter(sender As Object, e As System.EventArgs) Handles TxtTipo_Comp.Enter
        Try
            Dim f As New FrmListar_Tipo_Comp
            f.ShowDialog()
            TxtTipo_Comp.Text = CStr(f.dgvlista.Item("Tipo de Comprobante", indice).Value.ToString.Trim)
        Catch ex As Exception
            MessageBox.Show("Seleccione Tipo de Comprobante a Buscar", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub dgvlistaDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlistaDetalle.CellClick

        'Dim i As Integer
        'i = dgvlistaDetalle.CurrentRow.Index
        'txtEstado.Text = i
        'txtEstado.Text = dgvlistaDetalle.Item(4, i).Value

        'If txtEstado.Text = "ACTIVO" Then
        '    TXTESTADO2.Text = "COMPROBANTE SIN USAR, AUN EN ALMACEN"
        'ElseIf txtEstado.Text = "INACTIVO" Then
        '    TXTESTADO2.Text = "COMPROBANTE USADO O FUERA DE ALMACEN"
        'End If

    End Sub
    Private Sub dgvlistaDetalle_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlistaDetalle.CellFormatting
        Try
            If e.ColumnIndex = 4 Then
                Select Case e.Value
                    Case "COMPROBANTE SIN USAR, AUN EN ALMACEN"
                        e.CellStyle.ForeColor = Color.Blue
                        ' dgvlista.Columns("Valor Venta").DefaultCellStyle.ForeColor = Color.Blue
                    Case "COMPROBANTE USADO O FUERA DE ALMACEN"
                        e.CellStyle.ForeColor = Color.Red
                        ' dgvlista.Columns("Valor Venta").DefaultCellStyle.ForeColor = Color.Red
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvlistaDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlistaDetalle.CellContentClick
       
    End Sub
End Class
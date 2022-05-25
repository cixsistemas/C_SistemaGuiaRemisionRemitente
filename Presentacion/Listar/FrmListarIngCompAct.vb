Public Class FrmListarIngCompAct
    Dim tabla_ListarIngComp As DataTable
    Public Sub listar_Ing_Comp(ByVal _Remitente As String, _
                           ByVal _Tipo_Comp As String, _
                           ByVal _Numero As String
                           )
        mesajeerror.ForeColor = Color.Blue
        Label2.ForeColor = Color.Green
        '  Me.TXTESTADO2.ForeColor = Color.Red


        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            'If servidor.consultar("[dbo].[pa_listar_guias]", Numero, remitente).Tables.Count > 0 Then
            '    tabla_guias = servidor.consultar("[dbo].[pa_listar_guias]", Numero, remitente).Tables(0)
            'End If

            tabla_ListarIngComp = servidor.consultar("[dbo].[pa_Listar_Detalle_Ingreso_Comp_de_Pago_Estado]", _
                                        _Remitente, _
                                       _Tipo_Comp, _
                                       _Numero
                                        ).Tables(0)
            If tabla_ListarIngComp Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim NroFilas As Integer = tabla_ListarIngComp.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    dgvlista.DataSource = tabla_ListarIngComp
                    '   MessageBox.Show("Materia Prima, no se encuentra registrada", "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MessageBox.Show("No hay personas para mostrar", "Persona", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    mesajeerror.Text = "NO HAY INGRESO DE TIPO DE COMPROBANTES DE PAGO CON LOS CRITERIOS DE BUSQUEDA SELECCIONADOS O INGRESADOS"
                    mesajeerror.ForeColor = Color.Red

                Else
                    dgvlista.DataSource = tabla_ListarIngComp
                    servidor.cerrarconexion()
                    mesajeerror.Text = "Guía de Remisión – Remitente Tiene " + NroFilas.ToString + " Ingreso(S) de Tipo de Comprobantes de Pago"


                    dgvlista.Columns("Id Det Ing Comp").Visible = False
                    For I As Integer = 1 To dgvlista.Columns.Count - 1
                        dgvlista.Columns(I).ReadOnly = True
                    Next


                    'Try
                    '    'POSICIONA CURSOR EN ULTIMA FILA
                    '    Me.dgvlista.ClearSelection()
                    '    Me.dgvlista.CurrentCell = Me.dgvlista.Rows(Me.dgvlista.RowCount - 1).Cells(2)
                    '    'Me.dgvlista.Refresh()
                    'Catch ex As Exception

                    'End Try


                End If
                dgvlista.Columns("Id Det Ing Comp").Visible = False
                dgvlista.Columns("Id Ing Comp").Visible = False
                '' Me.dgvlista.Columns("Id Remitente").Visible = False
                'Me.dgvlista.Columns("Id Tipo Comp").Visible = False
                'Me.dgvlista.Columns("Tipo Operacion").Visible = False
                'Me.dgvlista.Columns("Fecha Ingreso").Visible = False
                'Me.dgvlista.Columns("Fecha Dcto").DefaultCellStyle.Format = "dd/MM/yyyy"
                'Me.dgvlista.Columns("Tipo de Operacion").Visible = False
                'Me.dgvlista.Columns("Zona").Visible = False


            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    'Private Sub Listar_Ingreso_Comp()
    '    Me.mesajeerror.ForeColor = Color.Blue
    '    Dim servidor As New clinicapacifico.clsaccesodatos
    '    servidor.cadenaconexion = Ruta
    '    If servidor.abrirconexion = True Then
    '        tabla = servidor.consultar("[dbo].[pa_Listar_Detalle_Ingreso_Comp_de_Pago_Estado]").Tables(0)
    '        If tabla Is Nothing Then
    '            __mesajeerror = servidor.getMensageError
    '            servidor.cerrarconexion()
    '            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Else
    '            Dim NroFilas As Integer = tabla.Rows.Count
    '            If NroFilas = 0 Then
    '                servidor.cerrarconexion()
    '                Me.dgvlista.DataSource = tabla
    '                Me.mesajeerror.Text = "NO HAY MATERIA PRIMA DISPONIBLE EN TOLVA PARA MOSTRAR"
    '                Me.mesajeerror.ForeColor = Color.Red

    '            Else

    '                Me.dgvlista.DataSource = tabla
    '                servidor.cerrarconexion()
    '                Me.mesajeerror.Text = "Guía de Remisión – Remitente " + NroFilas.ToString + " Registros(S) De Ingresos de Comprobantes"
    '            End If

    '            Me.dgvlista.Columns("Id Det Ing Comp").Visible = False
    '            For I As Integer = 1 To Me.dgvlista.Columns.Count - 1
    '                Me.dgvlista.Columns(I).ReadOnly = True
    '            Next

    '        End If
    '    Else
    '        __mesajeerror = servidor.getMensageError

    '        servidor.cerrarconexion()

    '        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    End If
    'End Sub

    Private Sub FrmListarIngCompAct_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmListarIngCompAct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        listar_Ing_Comp("", "", "")
    End Sub

    Private Sub btn_Acep_Click(sender As Object, e As EventArgs) Handles btn_Acep.Click

        'Close()

        If btn_Acep.Text.Trim = "ACEPTAR" Then
            If check_fila_grilla2(dgvlista, "ESTADO", "ACTIVO") = False Then
                MessageBox.Show("Seleccione lote para ser pilado." + vbCrLf + "Lote seleccionado en tolva debe estar en espera.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                Close()
            End If
        Else
            Close()
        End If

    End Sub
    Private Sub DgvLista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub

    'Private Sub dgvlista_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellDoubleClick
    '    indice = e.RowIndex
    '    Me.Close()
    'End Sub

    Private Sub dgvlista_CellLeave1(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellLeave
        indice = e.RowIndex
    End Sub
    Private Sub DgvLista_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick

    End Sub

    'Private Sub DgvLista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellDoubleClick
    '    indice = e.RowIndex
    '    Me.Close()
    'End Sub
    'Private Sub DgvLista_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellLeave
    '    indice = e.RowIndex
    'End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 2 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
        If e.ColumnIndex = 8 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
        If e.ColumnIndex = 10 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
    End Sub
    Private Sub CboRemitente_CheckedChanged(sender As Object, e As EventArgs) Handles CboRemitente.CheckedChanged
        TxtRemitente.Enabled = CboRemitente.Checked : TxtRemitente.Text = "" : TxtRemitente.Focus()
    End Sub
    Private Sub CboTipoCom_CheckedChanged(sender As Object, e As EventArgs) Handles CboTipoCom.CheckedChanged
        TxtTipo_Comp.Enabled = CboTipoCom.Checked : TxtTipo_Comp.Text = "" : TxtTipo_Comp.Focus()
    End Sub

    Private Sub CboNumero_CheckedChanged(sender As Object, e As EventArgs) Handles CboNumero.CheckedChanged
        TxtNumero.Enabled = CboNumero.Checked : TxtNumero.Text = "" : TxtNumero.Focus()
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        listar_Ing_Comp(IIf(TxtRemitente.Text.Trim <> "", TxtRemitente.Text.Trim, ""), _
                            IIf(TxtTipo_Comp.Text.Trim <> "", TxtTipo_Comp.Text.Trim, ""), _
                            IIf(TxtNumero.Text.Trim <> "", TxtNumero.Text.Trim, ""))
        ' dgvlistaDetalle.DataSource = Nothing
    End Sub

    Private Sub TxtRemitente_Enter(sender As Object, e As EventArgs) Handles TxtRemitente.Enter
        Try
            Dim f As New frmListarRemitentes
            f.ShowDialog()
            TxtRemitente.Text = CStr(f.dgvlista.Item("Remitente", indice).Value.ToString.Trim)
            'Me.btnConsultar.Focus()
            'Me.TxtRemitente.BackColor = Color.Azure
        Catch ex As Exception
            MessageBox.Show("Seleccione Empresa a Buscar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

       
    End Sub

    Private Sub TxtRemitente_Leave(sender As Object, e As EventArgs) Handles TxtRemitente.Leave
        TxtRemitente.BackColor = Color.White
    End Sub

    Private Sub TxtTipo_Comp_Enter(sender As Object, e As EventArgs) Handles TxtTipo_Comp.Enter
        Try
            Dim f As New FrmListar_Tipo_Comp
            f.ShowDialog()
            TxtTipo_Comp.Text = CStr(f.dgvlista.Item("Tipo de Comprobante", indice).Value.ToString.Trim)
        Catch ex As Exception
            MessageBox.Show("Seleccione Tipo de Comprobante a Buscar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
      
    End Sub

End Class
Public Class FrmListarEnvioCompAct
    Dim tabla_ListarEnvioComp As DataTable
    Public Sub listar_Envio_Comp(ByVal _Remitente As String, _
                               ByVal _Comisionista As String, _
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

            tabla_ListarEnvioComp = servidor.consultar("[dbo].[pa_Listar_Detalle_Envio_Comp_de_Pago_Estado]", _
                                        _Remitente, _
                                        _Comisionista, _
                                       _Tipo_Comp, _
                                       _Numero
                                        ).Tables(0)
            If tabla_ListarEnvioComp Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim NroFilas As Integer = tabla_ListarEnvioComp.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    dgvlista.DataSource = tabla_ListarEnvioComp
                    '   MessageBox.Show("Materia Prima, no se encuentra registrada", "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MessageBox.Show("No hay personas para mostrar", "Persona", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    mesajeerror.Text = "NO HAY ENVIO DE TIPO DE COMPROBANTES DE PAGO CON LOS CRITERIOS DE BUSQUEDA SELECCIONADOS O INGRESADOS"
                    mesajeerror.ForeColor = Color.Red

                Else
                    dgvlista.DataSource = tabla_ListarEnvioComp
                    servidor.cerrarconexion()
                    mesajeerror.Text = "Guía de Remisión – Remitente Tiene " + NroFilas.ToString + " Envio(S) de Tipo de Comprobantes de Pago"


                    dgvlista.Columns("Id Det Envio Comp").Visible = False
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
                dgvlista.Columns("Id Det Envio Comp").Visible = False
                dgvlista.Columns("Id_Envio_Comp").Visible = False
                dgvlista.Columns("Id_Detalle_Ing_Comp").Visible = False
                dgvlista.Columns("Id_Ing_Comp").Visible = False
                'Me.dgvlista.Columns("Tipo Operacion").Visible = False
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




    End Sub
    Private Sub FrmListarEnvioCompAct_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmListarEnvioCompAct_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        listar_Envio_Comp("", "", "", "")
    End Sub
    Private Sub btn_Acep_Click(sender As System.Object, e As System.EventArgs) Handles btn_Acep.Click

        'Close()

        If btn_Acep.Text.Trim = "ACEPTAR" Then
            If check_fila_grilla2(dgvlista, "ESTADO", "ACTIVO") = False Then
                MessageBox.Show("Seleccione lote para ser pilado." + vbCrLf + "Lote seleccionado en tolva debe estar en espera.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
    Private Sub DgvLista_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick

    End Sub

    'Private Sub DgvLista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellDoubleClick
    '    indice = e.RowIndex
    '    Me.Close()
    'End Sub
    'Private Sub DgvLista_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellLeave
    '    indice = e.RowIndex
    'End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
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
    Private Sub CboRemitente_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CboRemitente.CheckedChanged
        TxtRemitente.Enabled = CboRemitente.Checked : TxtRemitente.Text = "" : TxtRemitente.Focus()
    End Sub
    Private Sub CboTipoCom_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CboTipoCom.CheckedChanged
        TxtTipo_Comp.Enabled = CboTipoCom.Checked : TxtTipo_Comp.Text = "" : TxtTipo_Comp.Focus()
    End Sub

    Private Sub CboNumero_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CboNumero.CheckedChanged
        TxtNumero.Enabled = CboNumero.Checked : TxtNumero.Text = "" : TxtNumero.Focus()
    End Sub
    Private Sub CboComis_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CboComis.CheckedChanged
        TxtComisionista.Enabled = CboComis.Checked : TxtComisionista.Text = "" : TxtComisionista.Focus()
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        listar_Envio_Comp(IIf(TxtRemitente.Text.Trim <> "", TxtRemitente.Text.Trim, ""), _
                          IIf(TxtComisionista.Text.Trim <> "", TxtComisionista.Text.Trim, ""), _
                            IIf(TxtTipo_Comp.Text.Trim <> "", TxtTipo_Comp.Text.Trim, ""), _
                            IIf(TxtNumero.Text.Trim <> "", TxtNumero.Text.Trim, ""))
        ' dgvlistaDetalle.DataSource = Nothing
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


    Private Sub TxtComisionista_Enter(sender As Object, e As System.EventArgs) Handles TxtComisionista.Enter
        Try
            Dim f As New frmListarComisionistas
            f.ShowDialog()
            TxtComisionista.Text = CStr(f.dgvlista.Item("Comisionista", indice).Value.ToString.Trim)
            'Me.btnConsultar.Focus()
            'Me.TxtRemitente.BackColor = Color.Azure
        Catch ex As Exception
            MessageBox.Show("Seleccione Comisionista a Buscar", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
End Class
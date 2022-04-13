Public Class FrmRep_Ing_Comp
    Dim tabla_ListarIngComp As DataTable
    Public Sub listar_Ing_Comp(
                               ByVal _Fecha_Ing_Ini As String, _
                            ByVal _Fecha_Ing_Fin As String, _
                            ByVal _Remitente As String, _
                          ByVal _Tipo_Comp As String, _
                          ByVal _Numero As String
                          )
        mesajeerror.ForeColor = Color.Blue
        'Me.Label2.ForeColor = Color.Green

        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            'If servidor.consultar("[dbo].[pa_listar_guias]", Numero, remitente).Tables.Count > 0 Then
            '    tabla_guias = servidor.consultar("[dbo].[pa_listar_guias]", Numero, remitente).Tables(0)
            'End If

            tabla_ListarIngComp = servidor.consultar("[dbo].[Rep_Listar_Ingreso_Comp_de_Pago]", _
                                       _Fecha_Ing_Ini, _
                                       _Fecha_Ing_Fin, _
                                       _Remitente, _
                                                  _Tipo_Comp, _
                                                  _Numero
                                        ).Tables(0)
            If tabla_ListarIngComp Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                    mesajeerror.Text = "Guía de Remisión – Remitente Tiene " + NroFilas.ToString + " Ingreso(S) de Comprobantes de Pago"


                    'Me.dgvlista.Columns("Id Det Ing Comp").Visible = False
                    'For I As Integer = 1 To Me.dgvlista.Columns.Count - 1
                    '    Me.dgvlista.Columns(I).ReadOnly = True
                    'Next


                    Try
                        'POSICIONA CURSOR EN ULTIMA FILA
                        dgvlista.ClearSelection()
                        dgvlista.CurrentCell = dgvlista.Rows(dgvlista.RowCount - 1).Cells(2)
                        'Me.dgvlista.Refresh()
                    Catch ex As Exception

                    End Try


                End If
                dgvlista.Columns("Id Det Ing Comp").Visible = False
                dgvlista.Columns("Id Ing Comp").Visible = False
                dgvlista.Columns("Estadoo").Visible = False
                'Me.dgvlista.Columns("Id Tipo Comp").Visible = False
                'Me.dgvlista.Columns("Tipo Operacion").Visible = False
                'Me.dgvlista.Columns("Fecha Ingreso").Visible = False
                'Me.dgvlista.Columns("Fecha Dcto").DefaultCellStyle.Format = "dd/MM/yyyy"

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
    Private Sub FrmRep_Ing_Comp_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmRep_Ing_Comp_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        listar_Ing_Comp("", "", "", "", "")
    End Sub
    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellEnter
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 2 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
        'If e.ColumnIndex = 8 Then
        '    e.CellStyle.BackColor = Color.LightYellow
        'End If
        'If e.ColumnIndex = 10 Then
        '    e.CellStyle.BackColor = Color.LightYellow
        'End If

        Try
            If e.ColumnIndex = 6 Then
                Select Case e.Value
                    Case "COMPROBANTE SIN USAR, AUN EN ALMACEN"
                        e.CellStyle.ForeColor = Color.Navy
                        ' dgvlista.Columns("Valor Venta").DefaultCellStyle.ForeColor = Color.Blue
                    Case "COMPROBANTE USADO O FUERA DE ALMACEN"
                        e.CellStyle.ForeColor = Color.Red
                        ' dgvlista.Columns("Valor Venta").DefaultCellStyle.ForeColor = Color.Red
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cbFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFecha.CheckedChanged
        dtpfin.Enabled = cbFecha.Checked : dtpff.Enabled = cbFecha.Checked
        dtpfin.Value = DateSerial(Now.Date.Year, Now.Month, 1)
        ' dtpfin.Value = DateTime.Now
        dtpff.Value = DateTime.Now
        dtpfin.Focus()
    End Sub
    Private Sub CboRemitente_CheckedChanged(sender As Object, e As System.EventArgs) Handles CboRemitente.CheckedChanged
        TxtRemitente.Enabled = CboRemitente.Checked : TxtRemitente.Text = "" : TxtRemitente.Focus()
    End Sub
    Private Sub CboTipoCom_CheckedChanged(sender As Object, e As System.EventArgs) Handles CboTipoCom.CheckedChanged
        TxtTipo_Comp.Enabled = CboTipoCom.Checked : TxtTipo_Comp.Text = "" : TxtTipo_Comp.Focus()
    End Sub

    Private Sub CboNumero_CheckedChanged(sender As Object, e As System.EventArgs) Handles CboNumero.CheckedChanged
        TxtNumero.Enabled = CboNumero.Checked : TxtNumero.Text = "" : TxtNumero.Focus()
    End Sub
    Private Sub dtpfin_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles dtpfin.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub dtpff_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles dtpff.KeyPress
        saltar_ENTER(e)
        'Me.btnBuscar.Focus()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As System.EventArgs) Handles btnBuscar.Click
        listar_Ing_Comp(IIf(cbFecha.Checked = True, Year(dtpfin.Value).ToString + "-" + Month(dtpfin.Value).ToString + "-" + dtpfin.Value.Day.ToString, ""), _
                    IIf(cbFecha.Checked = True, Year(dtpff.Value).ToString + "-" + Month(dtpff.Value).ToString + "-" + dtpff.Value.Day.ToString, ""), _
            IIf(TxtRemitente.Text.Trim <> "", TxtRemitente.Text.Trim, ""), _
                            IIf(TxtTipo_Comp.Text.Trim <> "", TxtTipo_Comp.Text.Trim, ""), _
                               IIf(TxtNumero.Text.Trim <> "", TxtNumero.Text.Trim, ""))


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

    Private Sub btnImprimir_Click(sender As Object, e As System.EventArgs) Handles btnImprimir.Click
        Dim f As New frmImprimiR
        f.Nivel = "FORMULARIO_LISTA_LISTA_INGRESOS_COMPROBANTES"
        f.Tabla_Imprimir = tabla_ListarIngComp
        f.Titulo_Informe = "REPORTE DE INGRESO DE COMPROBANTES DE PAGO"
        f.ShowDialog()
    End Sub
End Class
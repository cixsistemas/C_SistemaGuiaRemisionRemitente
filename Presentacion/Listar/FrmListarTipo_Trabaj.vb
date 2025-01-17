Public Class FrmListarTipo_Trabaj
    Private formulario As New FrmTip_Trab1
    Dim tabla_Tipo_Trabaj As DataTable = Nothing

    Public Sub lista(ByVal criterio As String)
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_tipo_trabaj]", criterio).Tables.Count > 0 Then
                tabla_Tipo_Trabaj = servidor.consultar("[dbo].[pa_listar_tipo_trabaj]", criterio).Tables(0)
            End If
            If tabla_Tipo_Trabaj Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY TIPO DE TRABAJADOR PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_Tipo_Trabaj
                Dim NroFilas As Integer = tabla_Tipo_Trabaj.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY TIPO DE TRABAJADOR PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("Id Tipo Trab.").Visible = False
                    mesajeerror.Text = "Gu�a de Remisi�n � Remitente tiene " + NroFilas.ToString + " Tipo(s) de Trabajador(es)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Molinos los Angeles", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FrmListarTipo_Trabaj_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If

        'PARA REGISTRAR CON TECLA INSERT
        If e.KeyCode = Keys.Insert Then
            e.SuppressKeyPress = True

            formulario.ShowDialog()
            If formulario.Aceptar = True Then
                If MessageBox.Show("�Desea guardar Tipo de Trabajador?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim servidor As New clinicapacifico.clsaccesodatos
                    servidor.cadenaconexion = Ruta
                    If servidor.abrirconexiontrans = True Then 'abrimos conecci�n y iniciamos transacci�n.

                        Dim rpta As Integer = -1
                        Dim mensaje As String = ""
                        servidor.ejecutar("[dbo].[pa_mantenimiento_Tipo_Trabaj]", _
                        False, _
                        rpta, _
                        mensaje, _
                        formulario.id_tipo_trabaj, _
                        formulario.nombre.Text.Trim, _
                        formulario.descripcion.Text.Trim, _
                        "N", _
                        0, "")
                        If rpta > 0 Then
                            servidor.cerrarconexiontrans()
                            __mesajeerror = mensaje
                            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            servidor.cancelarconexiontrans()
                            __mesajeerror = mensaje
                            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        __mesajeerror = servidor.getMensageError
                        servidor.cerrarconexiontrans()
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If

            formulario.id_tipo_trabaj = -1
            formulario.nombre.Text = ""
            ' Me.formulario.precio_cat.Text = ""
            formulario.descripcion.Text = ""

            indice = -1
            lista(Nothing)

        End If
    End Sub


    Private Sub FrmListarTipo_Trabaj_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
    End Sub
    Private Sub dgvlista_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellDoubleClick
        indice = e.RowIndex
        Close()
    End Sub
    Private Sub dgvlista_CellLeave(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellLeave
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightCyan
        End If
    End Sub
    Private Sub txtbusca_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.TextChanged
        lista(txtbusca.Text)
        ' Aplicar_Filtro()
    End Sub
    Private Sub txtbusca_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.Leave
        txtbusca.BackColor = Color.White
    End Sub
    'Private Sub txtbusca_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Enter
    '    Me.txtbusca.BackColor = Color.Moccasin
    'End Sub

    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If


    End Sub

    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("�Desea guardar Tipo de Trabajador?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conecci�n y iniciamos transacci�n.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Tipo_Trabaj]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_tipo_trabaj, _
                    formulario.nombre.Text.Trim, _
                    formulario.descripcion.Text.Trim, _
                    "N", _
                    0, "")
                    If rpta > 0 Then
                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        servidor.cancelarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    __mesajeerror = servidor.getMensageError
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        formulario.id_tipo_trabaj = -1
        formulario.nombre.Text = ""
        ' Me.formulario.precio_cat.Text = ""
        formulario.descripcion.Text = ""

        indice = -1
        lista(Nothing)
    End Sub

End Class
Public Class FrmListarTransportista
    Private formulario As New frmemptransporte
    Dim tabla_emptransportes As DataTable = Nothing

    Public Sub lista(ByVal criterio As String)
        LBF2.ForeColor = Color.Red
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_empresa_transportes]", criterio).Tables.Count > 0 Then
                tabla_emptransportes = servidor.consultar("[dbo].[pa_listar_empresa_transportes]", criterio).Tables(0)
            End If
            If tabla_emptransportes Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY TRANSPORTISTAS PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_emptransportes
                Dim NroFilas As Integer = tabla_emptransportes.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY TRANSPORTISTAS PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("ID").Visible = False
                    dgvlista.Columns("Domicilio").Visible = False
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " TRANSPORTISTA(s)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ListarTransportista_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If

        'PARA REGISTRAR CON TECLA INSERT
        If e.KeyCode = Keys.Insert Then
            e.SuppressKeyPress = True

            formulario.ShowDialog()
            If formulario.Aceptar = True Then
                If MessageBox.Show("¿Desea guardar TRANSPORTISTA?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim servidor As New clinicapacifico.clsaccesodatos
                    servidor.cadenaconexion = Ruta
                    If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                        Dim rpta As Integer = -1
                        Dim mensaje As String = ""
                        servidor.ejecutar("[dbo].[pa_mantenimiento_empresa_transportes]", _
                        False, _
                        rpta, _
                        mensaje, _
                        formulario.id_emp_trans, _
                        formulario.nombre.Text.Trim, _
                        formulario.ruc.Text.Trim, _
                        formulario.domicilio.Text.Trim, _
                        "N", _
                        0, "")
                        If rpta > 0 Then
                            servidor.cerrarconexiontrans()
                            __mesajeerror = mensaje
                            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            servidor.cancelarconexiontrans()
                            __mesajeerror = mensaje
                            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        __mesajeerror = servidor.getMensageError
                        servidor.cerrarconexiontrans()
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If

            formulario.id_emp_trans = -1
            formulario.nombre.Text = ""
            formulario.ruc.Text = ""
            formulario.domicilio.Text = ""


            indice = -1

            lista("")

        End If
    End Sub

    Private Sub ListarTransportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()

        lista("")
    End Sub
    Private Sub dgvlista_CellClick1(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub

    Private Sub dgvlista_CellDoubleClick1(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellDoubleClick
        indice = e.RowIndex
        Close()
    End Sub

    Private Sub dgvlista_CellLeave1(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellLeave
        indice = e.RowIndex
    End Sub

    Private Sub btn_Acep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Acep.Click
        Close()
    End Sub
    Private Sub txtbusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        lista(txtbusca.Text)
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar TRANSPORTISTA?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_empresa_transportes]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_emp_trans, _
                    formulario.nombre.Text.Trim, _
                    formulario.ruc.Text.Trim, _
                    formulario.domicilio.Text.Trim, _
                    "N", _
                    0, "")
                    If rpta > 0 Then
                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        servidor.cancelarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    __mesajeerror = servidor.getMensageError
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        formulario.id_emp_trans = -1
        formulario.nombre.Text = ""
        formulario.ruc.Text = ""
        formulario.domicilio.Text = ""


        indice = -1

        lista("")
    End Sub


    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub
End Class
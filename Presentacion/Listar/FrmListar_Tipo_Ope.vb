Public Class FrmListar_Tipo_Ope
    Private formulario As New FrmTipo_Ope_2

    Dim tabla_Tipo_Operacion As DataTable = Nothing
    Public Sub lista(ByVal criterio As String)
        mesajeerror.ForeColor = Color.Blue
        LBF2.ForeColor = Color.Red
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_Listar_Tipo_Operacion]", criterio).Tables.Count > 0 Then
                tabla_Tipo_Operacion = servidor.consultar("[dbo].[pa_Listar_Tipo_Operacion]", criterio).Tables(0)
            End If
            If tabla_Tipo_Operacion Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY TIPO(s) DE OPERACION(es) PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                DgvLista.DataSource = tabla_Tipo_Operacion
                Dim NroFilas As Integer = tabla_Tipo_Operacion.Rows.Count
                If NroFilas = 0 Then
                    DgvLista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY TIPO(s) DE OPERACION(es) PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    DgvLista.Columns("Id Tipo de Operacion").Visible = False
                    'Me.dgvlista.Columns("Nombre").Visible = False
                    'Me.dgvlista.Columns("Apellido").Visible = False
                    mesajeerror.Text = "Sistema de Inventario tiene " + NroFilas.ToString + " Tipo(s) de Operacio(es)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FrmListar_Tipo_Ope_KeyDown1(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If

        If e.KeyCode = Keys.Insert Then
            e.SuppressKeyPress = True

            formulario.ShowDialog()
            If formulario.Aceptar = True Then
                If MessageBox.Show("¿Desea Guardar Tipo de Operacion?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim servidor As New clinicapacifico.clsaccesodatos
                    servidor.cadenaconexion = Ruta
                    If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                        Dim rpta As Integer = -1
                        Dim mensaje As String = ""
                        servidor.ejecutar("[dbo].[pa_mantenimiento_Tipo_Operacion]", _
                        False, _
                        rpta, _
                        mensaje, _
                        formulario.id_tipo_Operacion, _
                        formulario.TxtNombre.Text.Trim, _
                        formulario.TxtDescrip.Text.Trim, _
                       "N", _
                        0, "")
                        If rpta > 0 Then
                            servidor.cerrarconexiontrans()
                            __mesajeerror = mensaje
                            MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            servidor.cancelarconexiontrans()
                            __mesajeerror = mensaje
                            MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        __mesajeerror = servidor.getMensageError
                        servidor.cerrarconexiontrans()
                        MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If

            formulario.id_tipo_Operacion = -1
            formulario.TxtNombre.Text = ""
            'formulario.TxtHumedad.Text = "0"
            formulario.TxtDescrip.Text = ""

            indice = -1

            lista(Nothing)

        End If
    End Sub

    Private Sub FrmListar_Tipo_Ope_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
        indice = -1
    End Sub



    Private Sub DgvLista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub

    Private Sub DgvLista_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick

    End Sub

    Private Sub DgvLista_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellDoubleClick
        indice = e.RowIndex
        Close()
    End Sub
    Private Sub DgvLista_CellLeave(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellLeave
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightCyan
        End If
    End Sub
    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub

    Private Sub TxtBusca_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.TextChanged
        lista(TxtBusca.Text)
    End Sub
    Private Sub TxtBusca_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.Enter
        ' Me.TxtBusca.BackColor = Color.Azure
    End Sub

    Private Sub TxtBusca_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.Leave
        TxtBusca.BackColor = Color.White
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea Guardar Tipo de Operacion?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Tipo_Operacion]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_tipo_Operacion, _
                    formulario.TxtNombre.Text.Trim, _
                    formulario.TxtDescrip.Text.Trim, _
                   "N", _
                    0, "")
                    If rpta > 0 Then
                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        servidor.cancelarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    __mesajeerror = servidor.getMensageError
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        formulario.id_tipo_Operacion = -1
        formulario.TxtNombre.Text = ""
        'formulario.TxtHumedad.Text = "0"
        formulario.TxtDescrip.Text = ""

        indice = -1

        lista(Nothing)
    End Sub

    Private Sub btn_Acep_Click(sender As Object, e As EventArgs) Handles btn_Acep.Click
        Close()
    End Sub

   
End Class
Public Class FRMEnvase1

    Public id_envase As Integer = -1

    Public Aceptar As Boolean = False

    Private Sub valida()
        Dim ok As Boolean
        ok = nombre.Text.Trim <> ""
        'ok = Me.descripcion.Text.Trim <> ""
        btnaceptar.Enabled = ok
    End Sub

    Private Sub frmenvase1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub nombre_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nombre.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub nombre_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.TextChanged
        valida()
    End Sub

    Private Sub nombre_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.VisibleChanged
        valida()
    End Sub

    Private Sub descripcion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles descripcion.KeyDown
        saltar_Flechas(e)
    End Sub

    'ingreso nuevo
    Private Sub descripcion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles descripcion.TextChanged
        valida()
    End Sub
    Private Sub descripcion_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles descripcion.VisibleChanged
        valida()
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Aceptar = True
        Hide()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub

    Private Sub FRMEnvase1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub
    Private Sub descripcion_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles descripcion.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub nombre_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nombre.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub nombre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.Enter
        nombre.BackColor = Color.Moccasin
    End Sub
    Private Sub nombre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.Leave
        nombre.BackColor = Color.White
    End Sub
    Private Sub descripcion_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles descripcion.Enter
        descripcion.BackColor = Color.Moccasin
    End Sub
    Private Sub descripcion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles descripcion.Leave
        descripcion.BackColor = Color.White
    End Sub
End Class
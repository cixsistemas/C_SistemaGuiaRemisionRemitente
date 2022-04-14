Public Class FrmCaTegoria1
    Public id_categoria As Integer = -1
    Public Aceptar As Boolean = False

    Private Sub valida()
        Dim ok As Boolean
        ok = nombre.Text.Trim <> ""
        'ok = Me.descripcion.Text.Trim <> ""
        btnaceptar.Enabled = ok
    End Sub

    Private Sub FrmCaTegoria11_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub nombre_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nombre.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub nombre_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nombre.TextChanged
        valida()
    End Sub

    Private Sub nombre_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nombre.VisibleChanged
        valida()
    End Sub

    Private Sub descripcion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles descripcion.KeyDown
        saltar_Flechas(e)
    End Sub
    'ingreso nuevo
    Private Sub descripcion_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles descripcion.TextChanged
        valida()
    End Sub
    Private Sub descripcion_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles descripcion.VisibleChanged
        valida()
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnaceptar.Click
        Aceptar = True
        Hide()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub

    Private Sub precio_cat_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles precio_cat.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub precio_cat_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles precio_cat.TextChanged
        valida()
    End Sub

    Private Sub precio_cat_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles precio_cat.VisibleChanged
        valida()
    End Sub

    Private Sub FrmCaTegoria1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub
    Private Sub nombre_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nombre.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    e.Handled = True
        '    SendKeys.Send("{TAB}")
        'End If
        saltar_ENTER(e)
    End Sub
    Private Sub precio_cat_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles precio_cat.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub descripcion_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles descripcion.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub nombre_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles nombre.Enter
        nombre.BackColor = Color.Moccasin
    End Sub
    Private Sub nombre_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles nombre.Leave
        nombre.BackColor = Color.White
    End Sub
    Private Sub descripcion_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles descripcion.Enter
        descripcion.BackColor = Color.Moccasin
    End Sub
    Private Sub descripcion_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles descripcion.Leave
        descripcion.BackColor = Color.White
    End Sub
    Private Sub precio_cat_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles precio_cat.Enter
        precio_cat.BackColor = Color.Moccasin
    End Sub
    Private Sub precio_cat_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles precio_cat.Leave
        precio_cat.BackColor = Color.White
    End Sub
End Class
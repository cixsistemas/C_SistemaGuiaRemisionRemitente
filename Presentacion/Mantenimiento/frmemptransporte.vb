Public Class frmemptransporte

    Public id_emp_trans As Integer = -1

    Public Aceptar As Boolean = False


    Private Sub valida()
        Dim ok As Boolean
        ok = nombre.Text.Trim <> ""
        ok = ok And ruc.Text.Trim <> ""
        ok = ok And ruc.Text.Trim Like "###########"
        'ok = ok And Me.domicilio.Text.Trim <> ""
        btnaceptar.Enabled = ok
    End Sub


    Private Sub frmemptransporte_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        Aceptar = False
        Hide()
    End Sub

    Private Sub frmemptransporte_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub btnaceptar_Click_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Aceptar = True
        Hide()
    End Sub

    Private Sub btncancelar_Click_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub

    Private Sub nombre_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nombre.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub nombre_TextChanged_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.TextChanged
        valida()
    End Sub
    Private Sub nombre_VisibleChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.VisibleChanged
        valida()
    End Sub

    Private Sub ruc_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ruc.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub ruc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ruc.TextChanged
        valida()
    End Sub

    Private Sub ruc_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ruc.VisibleChanged
        valida()
    End Sub

    Private Sub domicilio_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles domicilio.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub domicilio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles domicilio.TextChanged
        valida()
    End Sub
    Private Sub domicilio_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles domicilio.VisibleChanged
        valida()
    End Sub
    Private Sub nombre_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nombre.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub ruc_KeyPress1(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ruc.KeyPress
        SoloNumeros(e, False, sender.Text)
        saltar_ENTER(e)
    End Sub
    Private Sub domicilio_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles domicilio.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub nombre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.Enter
        nombre.BackColor = Color.Moccasin
    End Sub
    Private Sub nombre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.Leave
        nombre.BackColor = Color.White
    End Sub
    Private Sub ruc_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ruc.Enter
        ruc.BackColor = Color.Moccasin
    End Sub
    Private Sub ruc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ruc.Leave
        ruc.BackColor = Color.White
    End Sub
    Private Sub domicilio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles domicilio.Enter
        domicilio.BackColor = Color.Moccasin
    End Sub
    Private Sub domicilio_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles domicilio.Leave
        domicilio.BackColor = Color.White
    End Sub
End Class
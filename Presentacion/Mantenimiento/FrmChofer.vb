Public Class FrmChofer
    Public id_chofer As Integer = -1

    Public Aceptar As Boolean = False
    Dim tabla_chofer As DataTable = Nothing

    Private Sub valida()
        Dim ok As Boolean
        ok = nombre.Text.Trim <> ""
        ok = apellido.Text.Trim <> ""
        ok = brevete.Text.Trim <> ""
        btnaceptar.Enabled = ok
    End Sub

    Private Sub FrmChofer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmChofer_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Aceptar = True
        Hide()
    End Sub
    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        Aceptar = False
        Hide()
    End Sub

    Private Sub nombre_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nombre.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nombre.TextChanged
        valida()
    End Sub
    Private Sub nombre_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.VisibleChanged
        valida()
    End Sub

    Private Sub apellido_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles apellido.KeyDown
        saltar_Flechas(e)
    End Sub


    Private Sub apellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles apellido.TextChanged
        valida()
    End Sub
    Private Sub apellido_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles apellido.VisibleChanged
        valida()
    End Sub

    Private Sub brevete_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles brevete.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub brevete_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brevete.TextChanged
        valida()
    End Sub
    Private Sub brevete_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles brevete.VisibleChanged
        valida()
    End Sub

    Private Sub telefono_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles telefono.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub telefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles telefono.TextChanged
        valida()
    End Sub
    Private Sub telefono_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles telefono.VisibleChanged
        valida()
    End Sub

    Private Sub nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nombre.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub apellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles apellido.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub brevete_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles brevete.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles telefono.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub nombre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.Enter
        nombre.BackColor = Color.Moccasin
    End Sub

    Private Sub nombre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.Leave
        nombre.BackColor = Color.White
    End Sub

    Private Sub apellido_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles apellido.Enter
        apellido.BackColor = Color.Moccasin
    End Sub

    Private Sub apellido_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles apellido.Leave
        apellido.BackColor = Color.White
    End Sub

    Private Sub brevete_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles brevete.Enter
        brevete.BackColor = Color.Moccasin
    End Sub
    Private Sub brevete_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles brevete.Leave
        brevete.BackColor = Color.White
    End Sub

    Private Sub telefono_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles telefono.Enter
        telefono.BackColor = Color.Moccasin
    End Sub
    Private Sub telefono_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles telefono.Leave
        telefono.BackColor = Color.White
    End Sub
End Class
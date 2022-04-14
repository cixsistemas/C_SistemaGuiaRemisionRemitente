Public Class FrmOpcImpPes_Med1
    Public Aceptar As Boolean = False
    Private Sub FrmOpcImpPes_Med1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RBConsorcio.ForeColor = Color.Red
        RbMolinos.ForeColor = Color.Firebrick
        RbBantemar.ForeColor = Color.RoyalBlue
        RbZelu.ForeColor = Color.Black
    End Sub


    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If RBConsorcio.Checked = True Then
            'btnAceptar.Focus()
            Aceptar = True
            Hide()
        ElseIf RbMolinos.Checked = True Then
            Aceptar = True
            Hide()
        ElseIf RbBantemar.Checked = True Then
            Aceptar = True
            Hide()
        ElseIf RbZelu.Checked = True Then
            Aceptar = True
            Hide()
        End If
    End Sub

    Private Sub RBConsorcio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RBConsorcio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub RbMolinos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RbMolinos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub RbBantemar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RbBantemar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub



    Private Sub RbZelu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RbZelu.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
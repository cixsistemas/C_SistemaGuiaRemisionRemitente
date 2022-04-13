Public Class Acercarde

    Private Sub Acercarde_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub Acercarde_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label3.ForeColor = Color.Red
        Panel2.ForeColor = Color.Blue
        Panel2.BackColor = Color.Blue
    End Sub

    Private Sub btn_Acep_Click(sender As System.Object, e As System.EventArgs) Handles btn_Acep.Click
        Close()

    End Sub
End Class
Public Class FrmTipo_Ope_2
    Public id_tipo_Operacion As Integer = -1
    ' Public id_ubigeo As Integer = -1
    Public Aceptar As Boolean = False

    Private Sub FrmTipo_Ope_2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmTipo_Ope_2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmTipo_Ope_2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub TxtNombre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.Enter
        TxtNombre.BackColor = Color.Moccasin
    End Sub

    Private Sub TxtNombre_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtNombre.KeyDown
        saltar_Flechas(e)
    End Sub


    Private Sub TxtNombre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.Leave
        TxtNombre.BackColor = Color.White
    End Sub
    Private Sub TxtDescrip_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDescrip.Enter
        TxtDescrip.BackColor = Color.Moccasin
    End Sub

    Private Sub TxtDescrip_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtDescrip.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub TxtDescrip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDescrip.Leave
        TxtDescrip.BackColor = Color.White
    End Sub
    Private Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim ok As Boolean

        ok = TxtNombre.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Tipo de Operacion, por favor.", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtNombre.Focus()
            Exit Sub
        End If

        Aceptar = True
        Hide()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Aceptar = False
        Hide()
    End Sub
    Private Sub FrmTipo_Ope_2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
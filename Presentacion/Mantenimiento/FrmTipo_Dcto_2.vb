Public Class FrmTipo_Dcto_2
    Public id_Tipo_Documento As Integer = -1
    ' Public id_ubigeo As Integer = -1
    Public Aceptar As Boolean = False

    Private Sub valida()
        Dim ok As Boolean
        ok = TxtCodigo.Text.Trim <> ""
        ok = TxtNombre.Text.Trim <> ""
        BtnAceptar.Enabled = ok
    End Sub

    Private Sub FrmTipo_Dcto_2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmTipo_Dcto_2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmTipo_Dcto_2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
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

    'Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
    '    saltar_ENTER(e)
    'End Sub

    Private Sub TxtNombre_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.TextChanged
        valida()
    End Sub

    Private Sub TxtNombre_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.VisibleChanged
        valida()
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

    'Private Sub TxtDescrip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescrip.KeyPress
    '    saltar_ENTER(e)

    'End Sub

    Private Sub TxtDescrip_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDescrip.TextChanged
        valida()
    End Sub

    Private Sub TxtDescrip_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDescrip.VisibleChanged
        valida()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim ok As Boolean

        ok = TxtCodigo.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Codigo por favor.", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCodigo.Focus()
            Exit Sub

        End If
        ok = TxtNombre.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Tipo de Documento de Identidad por favor.", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    Private Sub TxtCodigo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodigo.Enter
        TxtCodigo.BackColor = Color.Moccasin
    End Sub

    Private Sub TxtCodigo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtCodigo.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub TxtCodigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodigo.Leave
        TxtCodigo.BackColor = Color.White
    End Sub
    Private Sub TxtSiglas_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSiglas.Enter
        TxtSiglas.BackColor = Color.Moccasin
    End Sub

    Private Sub TxtSiglas_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtSiglas.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub TxtSiglas_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSiglas.Leave
        TxtSiglas.BackColor = Color.White
    End Sub
    Private Sub TxtCodigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodigo.TextChanged
        valida()
    End Sub

    Private Sub TxtCodigo_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodigo.VisibleChanged
        valida()
    End Sub
    Private Sub FrmTipo_Dcto_2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
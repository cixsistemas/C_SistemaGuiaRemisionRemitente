Public Class FrmOperacion_2
    Public id_Operacion As Integer = -1
    ' Public id_ubigeo As Integer = -1
    Public id_Tipo_Ope As Integer = -1
    Public Aceptar As Boolean = False

    Private Sub FrmOperacion_2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmOperacion_2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmOperacion_2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub TxtCodigo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodigo.Enter
        TxtCodigo.BackColor = Color.Azure
    End Sub

    Private Sub TxtCodigo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtCodigo.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub TxtCodigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodigo.Leave
        TxtCodigo.BackColor = Color.White
    End Sub

    Private Sub TxtNombre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.Enter
        TxtNombre.BackColor = Color.Azure
    End Sub

    Private Sub TxtNombre_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtNombre.KeyDown
        saltar_Flechas(e)
    End Sub


    Private Sub TxtNombre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.Leave
        TxtNombre.BackColor = Color.White
    End Sub
    Private Sub TxtDescrip_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDescrip.Enter
        TxtDescrip.BackColor = Color.Azure
    End Sub

    Private Sub TxtDescrip_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtDescrip.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub TxtDescrip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDescrip.Leave
        TxtDescrip.BackColor = Color.White
    End Sub
    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim ok As Boolean

        ok = TxtNombre.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Operacion por favor.", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtNombre.Focus()
            Exit Sub
        End If

        ok = id_Tipo_Ope <> -1
        If (ok = False) Then
            MessageBox.Show("Seleccione Tipo de Operacion por favor", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnTipoOpe.Focus()
            Exit Sub
        End If

        Aceptar = True
        Hide()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Aceptar = False
        Hide()
    End Sub
    Private Sub FrmOperacion_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnTipoOpe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTipoOpe.Click
        Try
            Dim f As New FrmListar_Tipo_Ope
            f.ShowDialog()
            If indice <> -1 Then
                id_Tipo_Ope = CInt(f.DgvLista.Item("Id Tipo de Operacion", indice).Value)
                TxtTipoOpe.Text = CStr(f.DgvLista.Item("Tipo de Operacion", indice).Value.ToString.Trim)
                indice = -1
            Else
                TxtTipoOpe.Text = ""

                indice = -1
                id_Tipo_Ope = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        TxtDescrip.Focus()
    End Sub

End Class
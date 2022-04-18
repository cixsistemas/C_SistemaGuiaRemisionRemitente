Public Class frmremitente
    Public id_remitente As Integer = -1
    Public id_ubigeo As Integer = -1
    Public Aceptar As Boolean = False

    Private Sub valida()
        Dim ok As Boolean
        ok = nombre.Text.Trim <> ""
        ok = ok And ruc.Text.Trim <> ""
        ok = ok And ruc.Text.Trim Like "###########"
        'ok = Me.direccion.Text.Trim <> ""
        'ok = Me.descripcion.Text.Trim <> ""
        btnaceptar.Enabled = ok
    End Sub


    Private Sub frmremitente_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
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

    Private Sub ruc_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ruc.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub ruc_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ruc.TextChanged
        valida()
    End Sub

    Private Sub ruc_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ruc.VisibleChanged
        valida()
    End Sub

    Private Sub direccion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles direccion.KeyDown
        saltar_Flechas(e)
    End Sub
    'ingreso nuevo
    Private Sub direccion_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles direccion.TextChanged
        valida()
    End Sub
    Private Sub direccion_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles direccion.VisibleChanged
        valida()
    End Sub

    Private Sub descripcion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles descripcion.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub descripcion_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles descripcion.TextChanged
        valida()
    End Sub
    Private Sub descripcion_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles descripcion.VisibleChanged
        valida()
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnaceptar.Click
        Dim ok As Boolean
        ok = id_ubigeo <> -1
        If (ok = False) Then
            MessageBox.Show("Seleccione Ubigeo por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnptollegada.Focus()
            Exit Sub
        End If

        Aceptar = True
        Hide()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub

    Private Sub frmremitente_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub btnptollegada_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnptollegada.Click
        Try
            Dim f As New frmListarUbigeo
            f.ShowDialog()
            If indice <> -1 Then
                id_ubigeo = CInt(f.dgvlista.Item("ID", indice).Value)
                distrito.Text = CStr(f.dgvlista.Item("Distrito", indice).Value.ToString.Trim)
                provincia.Text = CStr(f.dgvlista.Item("Provincia", indice).Value.ToString.Trim)
                departamento.Text = CStr(f.dgvlista.Item("Departamento", indice).Value.ToString.Trim)
                indice = -1
            Else
                distrito.Text = ""
                provincia.Text = ""
                departamento.Text = ""
                indice = -1
                id_ubigeo = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        descripcion.Focus()
    End Sub
    Private Sub nombre_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nombre.KeyPress
       saltar_ENTER(e)
    End Sub
    Private Sub ruc_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ruc.KeyPress
        SoloNumeros(e, False, sender.Text)
       saltar_ENTER(e)
    End Sub
    Private Sub direccion_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles direccion.KeyPress
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
    Private Sub ruc_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles ruc.Enter
        ruc.BackColor = Color.Moccasin
    End Sub
    Private Sub ruc_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles ruc.Leave
        ruc.BackColor = Color.White
    End Sub
    Private Sub descripcion_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles descripcion.Enter
        descripcion.BackColor = Color.Moccasin
    End Sub
    Private Sub descripcion_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles descripcion.Leave
        descripcion.BackColor = Color.White
    End Sub
    Private Sub direccion_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles direccion.Enter
        direccion.BackColor = Color.Moccasin
    End Sub
    Private Sub direccion_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles direccion.Leave
        direccion.BackColor = Color.White
    End Sub

    Private Sub txtCuenta_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtCuenta.Enter
        txtCuenta.BackColor = Color.Moccasin
    End Sub

    Private Sub txtCuenta_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtCuenta.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtCuenta_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub txtCuenta_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtCuenta.Leave
        txtCuenta.BackColor = Color.White
    End Sub

    Private Sub txtCuenta_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCuenta.TextChanged

    End Sub
End Class
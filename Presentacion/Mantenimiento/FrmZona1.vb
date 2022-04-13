Public Class FrmZona1
    Public id_zona As Integer = -1
    Public id_ubigeo As Integer = -1
    Public Aceptar As Boolean = False

    Private Sub valida()
        Dim ok As Boolean
        ok = nombre.Text.Trim <> ""
        'ok = ok And Me.ruc.Text.Trim <> ""
        'ok = ok And Me.ruc.Text.Trim Like "###########"
        'ok = Me.direccion.Text.Trim <> ""
        'ok = Me.descripcion.Text.Trim <> ""
        btnaceptar.Enabled = ok
    End Sub

    Private Sub FrmZona1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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

  
    Private Sub direccion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles orden.KeyDown
        saltar_Flechas(e)
    End Sub



    Private Sub direccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles orden.TextChanged
        valida()
    End Sub

    Private Sub direccion_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles orden.VisibleChanged
        valida()
    End Sub

    Private Sub descripcion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles descripcion.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub descripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles descripcion.TextChanged
        valida()
    End Sub

    Private Sub descripcion_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles descripcion.VisibleChanged
        valida()
    End Sub
    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim ok As Boolean
        ok = id_ubigeo <> -1
        If (ok = False) Then
            MessageBox.Show("Seleccione Ubigeo por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnUbigeo.Focus()
            Exit Sub
        End If

        Aceptar = True
        Hide()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub

    Private Sub btnUbigeo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbigeo.Click
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
        orden.Focus()
    End Sub

    Private Sub FrmZona1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmZona1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub nombre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.Enter
        nombre.BackColor = Color.Moccasin
    End Sub
    Private Sub nombre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.Leave
        nombre.BackColor = Color.White
    End Sub
    Private Sub orden_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles orden.Leave
        orden.BackColor = Color.White
    End Sub
    Private Sub orden_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles orden.Enter
        orden.BackColor = Color.Moccasin
    End Sub
    Private Sub descripcion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles descripcion.Leave
        descripcion.BackColor = Color.White
    End Sub
    Private Sub descripcion_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles descripcion.Enter
        descripcion.BackColor = Color.Moccasin
    End Sub

End Class
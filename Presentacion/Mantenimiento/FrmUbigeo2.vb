Public Class FrmUbigeo2
    Public id_ubigeo As Integer = -1
    ' Public id_ubigeo As Integer = -1
    Public Aceptar As Boolean = False
    Public Nivel As String = ""
    'Private Sub valida()
    '    Dim ok As Boolean
    '    ok = Me.txtcodigo.Text.Trim <> ""
    '    ok = Me.txtdepartamento.Text.Trim <> ""
    '    ok = Me.txtprovincia.Text.Trim <> ""
    '    ok = Me.txtdistrito.Text.Trim <> ""
    '    btnaceptar.Enabled = ok
    'End Sub
    Private Sub FrmUbigeo2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
        saltar_Flechas(e)
    End Sub

    Private Sub FrmUbigeo2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub FrmUbigeo2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        'Aceptar = False
        'Hide()

        'Me.txtcodigo.Focus()
    End Sub

    Private Sub txtdistrito_Enter(sender As Object, e As EventArgs) Handles txtdistrito.Enter
        txtdistrito.BackColor = Color.Moccasin
    End Sub

    Private Sub txtdistrito_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdistrito.KeyDown
        '  saltar_Flechas(e)
    End Sub

    Private Sub txtdistrito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdistrito.KeyPress
        '  saltar_ENTER(e)
    End Sub

    Private Sub txtdistrito_Leave(sender As Object, e As EventArgs) Handles txtdistrito.Leave
        txtdistrito.BackColor = Color.White
    End Sub

    Private Sub txtprovincia_Enter(sender As Object, e As EventArgs) Handles txtprovincia.Enter
        txtprovincia.BackColor = Color.Moccasin
    End Sub

    Private Sub txtprovincia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprovincia.KeyDown
        ' saltar_Flechas(e)
    End Sub

    Private Sub txtprovincia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprovincia.KeyPress
        ' saltar_ENTER(e)
    End Sub

    Private Sub txtprovincia_Leave(sender As Object, e As EventArgs) Handles txtprovincia.Leave
        txtprovincia.BackColor = Color.White
    End Sub


    Private Sub txtdepartamento_Enter(sender As Object, e As EventArgs) Handles txtdepartamento.Enter
        txtdepartamento.BackColor = Color.Moccasin
    End Sub

    Private Sub txtdepartamento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdepartamento.KeyDown
        ' saltar_Flechas(e)
    End Sub

    Private Sub txtdepartamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdepartamento.KeyPress
        '  saltar_ENTER(e)
    End Sub

    Private Sub txtdepartamento_Leave(sender As Object, e As EventArgs) Handles txtdepartamento.Leave
        txtdepartamento.BackColor = Color.White
    End Sub
    Private Sub txtcodigo_Enter(sender As Object, e As EventArgs) Handles txtcodigo.Enter
        txtcodigo.BackColor = Color.Moccasin
    End Sub

    Private Sub txtcodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigo.KeyDown
        ' saltar_Flechas(e)
    End Sub

    Private Sub txtcodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigo.KeyPress
        ' SoloNumeros(e, False, sender.Text)
    End Sub

    Private Sub txtcodigo_Leave(sender As Object, e As EventArgs) Handles txtcodigo.Leave
        txtcodigo.BackColor = Color.White
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        Dim ok As Boolean

        ok = TxtCodigo.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Codigo por favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCodigo.Focus()
            Exit Sub
        End If

        ok = txtdistrito.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Distrito por favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdistrito.Focus()
            Exit Sub
        End If

        ok = txtprovincia.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Provincia por favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtprovincia.Focus()
            Exit Sub
        End If

        ok = txtdepartamento.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Departamento por favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdepartamento.Focus()
            Exit Sub
        End If
        'Aceptar = True
        'Hide()

        If MessageBox.Show("¿DESEA " + IIf(Nivel = "N", "GUARDAR ", "MODIFICAR ") + " Ubigeo?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                Dim RPTA_DOC As Integer = -1
                Dim MSG_DOC As String = ""
                servidor.ejecutar("[dbo].[pa_mantenimiento_Ubigeos]", _
                False, _
                RPTA_DOC, _
                MSG_DOC, _
                id_ubigeo, _
                txtcodigo.Text.Trim, _
                txtdepartamento.Text.Trim, _
                txtprovincia.Text.Trim, _
                txtdistrito.Text.Trim, _
                Nivel.Trim, _
                0, "")
                If RPTA_DOC > 0 Then
                    servidor.cerrarconexiontrans()
                    __mesajeerror = MSG_DOC
                    MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Hide()
                Else
                    servidor.cancelarconexiontrans()
                    __mesajeerror = MSG_DOC
                    MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexiontrans()
                MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Aceptar = False
        Hide()
    End Sub

 
   
    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged
        ' valida()
    End Sub

    Private Sub txtdistrito_TextChanged(sender As Object, e As EventArgs) Handles txtdistrito.TextChanged
        ' valida()
    End Sub

    Private Sub txtprovincia_TextChanged(sender As Object, e As EventArgs) Handles txtprovincia.TextChanged
        ' valida()
    End Sub

    Private Sub txtdepartamento_TextChanged(sender As Object, e As EventArgs) Handles txtdepartamento.TextChanged
        '  valida()
    End Sub
End Class
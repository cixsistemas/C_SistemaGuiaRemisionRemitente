Public Class FrmTipo_Comp_2
    Public id_Tipo_Comprobante As Integer = -1
    ' Public id_ubigeo As Integer = -1
    Public Aceptar As Boolean = False
    Public Nivel As String = ""
    'Public id_Bien As Integer = -1
    'Public id_Secado As Integer
    'Public id_ope As Integer = -1

    Private Sub valida()
        Dim ok As Boolean
        ok = TxtCodigo.Text.Trim <> ""
        ok = TxtNombre.Text.Trim <> ""
        BtnAceptar.Enabled = ok
    End Sub

    Private Sub FrmTipo_Comp_2_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmTipo_Comp_2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmTipo_Comp_2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub TxtNombre_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TxtNombre.Enter
        TxtNombre.BackColor = Color.Moccasin
    End Sub

    Private Sub TxtNombre_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtNombre.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub TxtNombre_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TxtNombre.Leave
        TxtNombre.BackColor = Color.White
    End Sub

    'Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
    '    saltar_ENTER(e)
    'End Sub

    Private Sub TxtNombre_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtNombre.TextChanged
        valida()
    End Sub

    Private Sub TxtNombre_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtNombre.VisibleChanged
        valida()
    End Sub

    Private Sub TxtDescrip_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TxtDescrip.Enter
        TxtDescrip.BackColor = Color.Moccasin
    End Sub

    Private Sub TxtDescrip_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtDescrip.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub TxtDescrip_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TxtDescrip.Leave
        TxtDescrip.BackColor = Color.White
    End Sub

    'Private Sub TxtDescrip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescrip.KeyPress
    '    saltar_ENTER(e)

    'End Sub

    Private Sub TxtDescrip_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtDescrip.TextChanged
        valida()
    End Sub

    Private Sub TxtDescrip_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtDescrip.VisibleChanged
        valida()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAceptar.Click
        Dim ok As Boolean

        ok = TxtCodigo.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Codigo por favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCodigo.Focus()
            Exit Sub

        End If
        ok = TxtNombre.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Tipo de Comprobante de Pago por favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtNombre.Focus()
            Exit Sub
        End If

        'Aceptar = True
        'Hide()
        If MessageBox.Show("¿DESEA " + IIf(Nivel = "N", "GUARDAR ", "MODIFICAR ") + " Tipo de Comprobante de PAgo?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                Dim RPTA_DOC As Integer = -1
                Dim MSG_DOC As String = ""
                servidor.ejecutar("[dbo].[pa_mantenimiento_Tipo_de_Comprobante_de_Pago]", _
                False, _
                RPTA_DOC, _
                MSG_DOC, _
               id_Tipo_Comprobante, _
                    TxtCodigo.Text.Trim, _
                    TxtNombre.Text.Trim, _
                     TxtSiglas.Text.Trim, _
                  TxtDescrip.Text.Trim, _
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


    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelar.Click
        Aceptar = False
        Hide()
    End Sub

    Private Sub TxtCodigo_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TxtCodigo.Enter
        TxtCodigo.BackColor = Color.Moccasin
    End Sub

    Private Sub TxtCodigo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtCodigo.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub TxtCodigo_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TxtCodigo.Leave
        TxtCodigo.BackColor = Color.White
    End Sub

    Private Sub TxtCodigo_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtCodigo.TextChanged
        valida()
    End Sub

    Private Sub TxtCodigo_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtCodigo.VisibleChanged
        valida()
    End Sub
    Private Sub TxtSiglas_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TxtSiglas.Enter
        TxtSiglas.BackColor = Color.Moccasin
    End Sub

    Private Sub TxtSiglas_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtSiglas.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub TxtSiglas_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TxtSiglas.Leave
        TxtSiglas.BackColor = Color.White
    End Sub

    Private Sub FrmTipo_Comp_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
    End Sub
End Class
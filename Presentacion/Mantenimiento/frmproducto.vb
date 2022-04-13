Public Class frmproducto

    Dim tabla_categoria As DataTable = Nothing
    Dim tabla_logotipo As DataTable = Nothing
    Dim tabla_envasado As DataTable = Nothing

    Public Aceptar As Boolean = False
    Public Nivel As String = ""
    Public prod_id As Integer = -1
    Public id_logo As Integer = -1

    Private Sub valida()
        Dim ok As Boolean
        ok = prod_nom.Text.Trim <> ""
        ok = ok And prod_peso_uni.Text.Trim <> ""
        If (ok = True) Then
            ok = ok And IsNumeric(prod_peso_uni.Text.Trim)
        End If
        ok = ok And prod_color.Text.Trim <> ""
        ok = ok And Not cbocategoria.DataSource Is Nothing
        'ok = ok And Not Me.cbologotipo.DataSource Is Nothing
        ok = ok And Not cboenvasado.DataSource Is Nothing
        btnaceptar.Enabled = ok
    End Sub

    Public Sub lista_categoria(ByVal opcion As Integer)
        'Me.mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar]", opcion).Tables.Count > 0 Then
                tabla_categoria = servidor.consultar("[dbo].[pa_listar]", opcion).Tables(0)
            End If
            cbocategoria.DataSource = tabla_categoria
            cbocategoria.DisplayMember = "Nombre"
            cbocategoria.ValueMember = "Codigo"
            servidor.cerrarconexion()
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Public Sub lista_envasado(ByVal opcion As Integer)
        'Me.mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar]", opcion).Tables.Count > 0 Then
                tabla_envasado = servidor.consultar("[dbo].[pa_listar]", opcion).Tables(0)
            End If
            cboenvasado.DataSource = tabla_envasado
            cboenvasado.DisplayMember = "Nombre"
            cboenvasado.ValueMember = "Codigo"
            servidor.cerrarconexion()
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmproducto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub frmproducto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmproducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()

        'lista_categoria(8)
        'lista_logotipo(9)
        'lista_envasado(10)
    End Sub

    Private Sub prod_nom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prod_nom.TextChanged
        valida()
    End Sub
    Private Sub prod_nom_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles prod_nom.VisibleChanged
        valida()
    End Sub
    Private Sub prod_peso_uni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prod_peso_uni.TextChanged
        valida()
    End Sub
    Private Sub prod_peso_uni_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles prod_peso_uni.VisibleChanged
        valida()
    End Sub
    Private Sub prod_color_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prod_color.TextChanged
        valida()
    End Sub
    Private Sub prod_color_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles prod_color.VisibleChanged
        valida()
    End Sub
    Private Sub cbocategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbocategoria.SelectedIndexChanged
        valida()
    End Sub

    Private Sub cbocategoria_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbocategoria.VisibleChanged
        valida()
    End Sub

    Private Sub cbologotipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        valida()
    End Sub

    Private Sub cboenvasado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboenvasado.SelectedIndexChanged
        valida()
    End Sub

    Private Sub cboenvasado_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboenvasado.VisibleChanged
        valida()
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim ok As Boolean

        ok = id_logo <> -1
        If (ok = False) Then
            MessageBox.Show("Seleccione Logotipo por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnlogotipo.Focus()
            Exit Sub
        End If

        If MessageBox.Show("¿Desea " + IIf(Nivel = "N", "Guardar ", "Modificar ") + " Registro?", "Sistema de Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                Dim RPTA_DOC As Integer = -1
                Dim MSG_DOC As String = ""
                servidor.ejecutar("[dbo].[pa_mantenimiento_producto]",
                    False,
                RPTA_DOC,
                MSG_DOC,
                  prod_id,
                  prod_nom.Text.Trim,
                  prod_peso_uni.Text.Trim,
                  prod_color.Text.Trim,
                  Nombre_Com.Text.Trim,
                  cbocategoria.SelectedValue,
                  id_logo,
                  cboenvasado.SelectedValue,
                  Nivel.Trim,
                                0, "")
                If RPTA_DOC > 0 Then
                    servidor.cerrarconexiontrans()
                    __mesajeerror = MSG_DOC
                    MessageBox.Show(__mesajeerror, "Sistema de Control", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Hide()
                Else
                    servidor.cancelarconexiontrans()
                    __mesajeerror = MSG_DOC
                    MessageBox.Show(__mesajeerror, "Sistema de Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexiontrans()
                MessageBox.Show(__mesajeerror, "Sistema de Control", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        'Aceptar = True
        'Hide()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub

    Private Sub frmproducto_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub
    Private Sub prod_nom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles prod_nom.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub prod_peso_uni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles prod_peso_uni.KeyPress
        SoloNumeros(e, True, sender.Text)
        saltar_ENTER(e)
    End Sub
    Private Sub cbocategoria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbocategoria.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub cboenvasado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboenvasado.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub prod_color_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles prod_color.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub prod_nom_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles prod_nom.Enter
        prod_nom.BackColor = Color.Moccasin
    End Sub
    Private Sub prod_nom_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles prod_nom.Leave
        prod_nom.BackColor = Color.White
    End Sub
    Private Sub prod_peso_uni_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles prod_peso_uni.Enter
        prod_peso_uni.BackColor = Color.Moccasin
    End Sub

    Private Sub prod_peso_uni_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles prod_peso_uni.Leave
        prod_peso_uni.BackColor = Color.White
    End Sub

    Private Sub prod_color_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles prod_color.Leave
        prod_color.BackColor = Color.White
    End Sub

    Private Sub prod_color_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles prod_color.Enter
        prod_color.BackColor = Color.Moccasin
    End Sub
    Private Sub Nombre_Com_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nombre_Com.Enter
        Nombre_Com.BackColor = Color.Moccasin
    End Sub

    Private Sub Nombre_Com_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Nombre_Com.KeyDown

    End Sub

    Private Sub Nombre_Com_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nombre_Com.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub Nombre_Com_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nombre_Com.Leave
        Nombre_Com.BackColor = Color.White
    End Sub
    Private Sub btnlogotipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogotipo.Click
        Try
            Dim f As New FrmListarLogo
            f.ShowDialog()
            If indice <> -1 Then
                id_logo = CInt(f.dgvlista.Item("ID", indice).Value)
                txtlogotipo.Text = CStr(f.dgvlista.Item("Nombre Logotipo", indice).Value.ToString.Trim)
                'Me.provincia.Text = CStr(f.dgvlista.Item("Provincia", indice).Value.ToString.Trim)
                'Me.departamento.Text = CStr(f.dgvlista.Item("Departamento", indice).Value.ToString.Trim)
                indice = -1
            Else
                txtlogotipo.Text = ""
                'Me.provincia.Text = ""
                'Me.departamento.Text = ""
                indice = -1
                id_logo = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        cbocategoria.Focus()
        '  Descripcion.Focus()
    End Sub

    Private Sub Nombre_Com_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nombre_Com.TextChanged

    End Sub
End Class
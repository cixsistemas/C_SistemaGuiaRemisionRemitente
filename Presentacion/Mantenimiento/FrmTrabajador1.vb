Public Class FrmTrabajador1
    Public id_trabajador As Integer = -1

    Public Aceptar As Boolean = False
    Dim tabla_trabajador As DataTable = Nothing

    Public id_tipo_trabaj As Integer = -1
    Public id_tipo_Dcto As Integer = -1

    Private Sub btnaceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim ok As Boolean

        ok = nombre.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Nombre favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            nombre.Focus()
            Exit Sub
        End If

        ok = apellido.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Apellido favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            apellido.Focus()
            Exit Sub
        End If

        ok = id_tipo_Dcto <> -1
        If ok = False Then
            MessageBox.Show("Haga click en buscar Tipo de Documento.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnTipo_Dcto.Focus()
            Exit Sub
        End If

        ok = nro_doc.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Nro. de Documento favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            nro_doc.Focus()
            Exit Sub
        End If


        ok = id_tipo_trabaj <> -1
        If ok = False Then
            MessageBox.Show("Haga click en buscar Tipo de Trabajador.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnTipo_Trab.Focus()
            Exit Sub
        End If

        'ok = txtDireccion.Text <> ""
        'If (ok = False) Then
        '    MessageBox.Show("Ingrese Direccion favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txtDireccion.Focus()
        '    Exit Sub
        'End If

        ok = txtTelefono.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Telefono favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTelefono.Focus()
            Exit Sub
        End If


        Aceptar = True
        Hide()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmTrabajador1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter

    End Sub

    Private Sub FrmTrabajador1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmTrabajador1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
        ' saltar_Flechas(e)
    End Sub

    Private Sub btnTipo_Dcto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTipo_Dcto.Click
        Try
            Dim f As New FrmListarTipo_Dcto
            f.ShowDialog()
            If indice <> -1 Then
                id_tipo_Dcto = CInt(f.dgvlista.Item("Id Tipo Dcto", indice).Value)
                txtTipo_Dcto.Text = CStr(f.dgvlista.Item("Tipo de Dcto", indice).Value.ToString.Trim)
                ' Me.provincia.Text = CStr(f.dgvlista.Item("Provincia", indice).Value.ToString.Trim)
                'Me.departamento.Text = CStr(f.dgvlista.Item("Departamento", indice).Value.ToString.Trim)
                indice = -1
            Else
                txtTipo_Dcto.Text = ""
                'Me.provincia.Text = ""
                ' Me.departamento.Text = ""
                indice = -1
                id_tipo_Dcto = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        nro_doc.Focus()
    End Sub

    Private Sub BtnTipo_Trab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTipo_Trab.Click
        Try
            Dim f As New FrmListarTipo_Trabaj
            f.ShowDialog()
            If indice <> -1 Then
                id_tipo_trabaj = CInt(f.dgvlista.Item("Id Tipo Trab.", indice).Value)
                txttipo_trabaj.Text = CStr(f.dgvlista.Item("Tipo de Trabajador", indice).Value.ToString.Trim)
                ' Me.provincia.Text = CStr(f.dgvlista.Item("Provincia", indice).Value.ToString.Trim)
                'Me.departamento.Text = CStr(f.dgvlista.Item("Departamento", indice).Value.ToString.Trim)
                indice = -1
            Else
                txttipo_trabaj.Text = ""
                'Me.provincia.Text = ""
                ' Me.departamento.Text = ""
                indice = -1
                id_tipo_trabaj = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        txtDireccion.Focus()
    End Sub

#Region "TEXT BOX"
    Private Sub FrmTrabajador1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub nombre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.Enter
        nombre.BackColor = Color.Moccasin
    End Sub
    Private Sub nombre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles nombre.Leave
        nombre.BackColor = Color.White
    End Sub

    Private Sub nombre_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nombre.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub apellido_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles apellido.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub apellido_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles apellido.Enter
        apellido.BackColor = Color.Moccasin
    End Sub

    Private Sub apellido_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles apellido.Leave
        apellido.BackColor = Color.White
    End Sub

    Private Sub nro_doc_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nro_doc.Enter
        nro_doc.BackColor = Color.Moccasin
    End Sub
    Private Sub nro_doc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles nro_doc.Leave
        nro_doc.BackColor = Color.White
    End Sub
    Private Sub nro_doc_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nro_doc.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtDireccion_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.Enter
        txtDireccion.BackColor = Color.Moccasin
    End Sub

    Private Sub txtDireccion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.Leave
        txtDireccion.BackColor = Color.White
    End Sub
    Private Sub txtDireccion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtDireccion.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub txtTelefono_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelefono.Leave
        txtTelefono.BackColor = Color.White
    End Sub
    Private Sub txtTelefono_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelefono.Enter
        txtTelefono.BackColor = Color.Moccasin
    End Sub

    Private Sub txtTelefono_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtTelefono.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtCorreo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCorreo.Enter
        txtCorreo.BackColor = Color.Moccasin
    End Sub

    Private Sub txtCorreo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCorreo.Leave
        txtCorreo.BackColor = Color.White
    End Sub
    Private Sub txtCorreo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtCorreo.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtDescrip_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescrip.Enter
        txtDescrip.BackColor = Color.Moccasin
    End Sub
    Private Sub txtDescrip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescrip.Leave
        txtDescrip.BackColor = Color.White
    End Sub
    Private Sub txtDescrip_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtDescrip.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub nro_doc_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nro_doc.KeyPress
        SoloNumeros(e, False, sender.Text)
    End Sub
#End Region



End Class
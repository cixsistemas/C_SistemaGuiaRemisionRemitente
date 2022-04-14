Public Class FrmCliente1
    Public id_Cliente As Integer = -1

    Public Aceptar As Boolean = False
    Dim tabla_Cliente As DataTable = Nothing

    Public id_tipo_Cliente As Integer = -1
    Public id_tipo_Dcto As Integer = -1
    Public id_Zona As Integer = -1

    Private Sub btnaceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim ok As Boolean

        ok = nombre.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Nombre por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            nombre.Focus()
            Exit Sub
        End If

        ok = txtTelefono.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Telefono por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTelefono.Focus()
            Exit Sub
        End If

        ok = txtDireccion.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Direccion por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDireccion.Focus()
            Exit Sub
        End If

        ok = id_Zona <> -1
        If ok = False Then
            MessageBox.Show("Haga click en buscar Zona.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnZona.Focus()
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


        ok = id_tipo_Cliente <> -1
        If ok = False Then
            MessageBox.Show("Haga click en buscar Tipo de Cliente.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnTipo_Cliente.Focus()
            Exit Sub
        End If

        Aceptar = True
        Hide()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmCliente1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmCliente1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub
    Private Sub FrmCliente1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnZona_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnZona.Click
        Try
            Dim f As New FrmListarZona
            f.ShowDialog()
            If indice <> -1 Then
                id_Zona = CInt(f.dgvlista.Item("Id Zona", indice).Value)
                txtZona.Text = CStr(f.dgvlista.Item("Zona", indice).Value.ToString.Trim)
                txtDistrito.Text = CStr(f.dgvlista.Item("Distrito", indice).Value.ToString.Trim)
                'Me.departamento.Text = CStr(f.dgvlista.Item("Departamento", indice).Value.ToString.Trim)
                indice = -1
            Else
                txtZona.Text = ""
                txtDistrito.Text = ""
                ' Me.departamento.Text = ""
                indice = -1
                id_Zona = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        btnTipo_Dcto.Focus()
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
                txtZona.Text = ""
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

    Private Sub BtnTipo_Cliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTipo_Cliente.Click
        Try
            Dim f As New FrmListarTipo_Cliente
            f.ShowDialog()
            If indice <> -1 Then
                id_tipo_Cliente = CInt(f.dgvlista.Item("Id Tipo Cliente", indice).Value)
                txttipo_Cliente.Text = CStr(f.dgvlista.Item("Tipo Cliente", indice).Value.ToString.Trim)
                ' Me.provincia.Text = CStr(f.dgvlista.Item("Provincia", indice).Value.ToString.Trim)
                'Me.departamento.Text = CStr(f.dgvlista.Item("Departamento", indice).Value.ToString.Trim)
                indice = -1
            Else
                txttipo_Cliente.Text = ""
                'Me.provincia.Text = ""
                ' Me.departamento.Text = ""
                indice = -1
                id_tipo_Cliente = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        txtCorreo.Focus()
    End Sub

#Region "Text Box"

    Private Sub FrmCliente1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
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
    Private Sub txtLinea_Credito_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLinea_Credito.Enter
        txtLinea_Credito.BackColor = Color.Moccasin
    End Sub

    Private Sub txtLinea_Credito_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtLinea_Credito.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtLinea_Credito_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLinea_Credito.Leave
        If txtLinea_Credito.Text = "" Then
            MessageBox.Show("Ingrese Linea de Credito por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtLinea_Credito.Focus()
        Else
            'CONVIERTE EL NUMERO A FORMATO MONEDA
            txtLinea_Credito.Text = Format(CType(txtLinea_Credito.Text, Decimal), "###0.00")
        End If
        txtLinea_Credito.BackColor = Color.White
    End Sub
    Private Sub nro_doc_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nro_doc.KeyPress
        SoloNumeros(e, False, sender.Text)
    End Sub

   
#End Region

   
End Class
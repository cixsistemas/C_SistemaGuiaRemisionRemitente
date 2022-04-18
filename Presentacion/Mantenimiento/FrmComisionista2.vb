Public Class FrmComisionista2
    Public id_comisionista As Integer = -1
    ' Public id_ubigeo As Integer = -1
    Public Aceptar As Boolean = False
    Public Nivel As String = ""
    Public id_tipo_Dcto As Integer = -1
    Public id_Zona As Integer = -1
    'Public id_Bien As Integer = -1
    'Public id_Secado As Integer
    'Public id_ope As Integer = -1

    Private Sub valida()
        Dim ok As Boolean
        'ok = Me.TxtCodigo.Text.Trim <> ""
        'ok = Me.TxtNombre.Text.Trim <> ""
        BtnAceptar.Enabled = ok
    End Sub

    Private Sub FrmComisionista2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmComisionista2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmComisionista2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub FrmComisionista2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
    End Sub
    Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub
    Private Sub btnZona_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnZona.Click
        Try
            Dim f As New FrmListarZona
            ' Dim f As New FrmProveedor_1
            f.ShowDialog()

            If indice >= 0 Then

                id_Zona = CInt(f.dgvlista.Item("Id Zona", indice).Value)
                txtZona.Text = CStr(f.dgvlista.Item("Zona", indice).Value.ToString.Trim)
                txtDistrito.Text = CStr(f.dgvlista.Item("Distrito", indice).Value.ToString.Trim)
                'Me.Uni_Med.Text = CStr(f.DgvLista.Item("Unidad Medida", indice).Value.ToString.Trim)
                'Me.TxtTipoExist.Text = CStr(f.DgvLista.Item("Tipo de Existencia", indice).Value.ToString.Trim)
                'If Me.id_Personaa.Text = "" Then
                '    MessageBox.Show("Seleccione Proveedor por favor", "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        Catch ex As Exception
            'If Me.TxtOpe.Text <> "" And TxtTipoOperac.Text <> "" Then
            '    MessageBox.Show("Seleccione Operacion por favor", "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'End If
            ' BtnProv.Focus()
            '  End If
        End Try
        indice = -1
        btnTipo_Dcto.Focus()


       
    End Sub
    Private Sub btnTipo_Dcto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTipo_Dcto.Click
        Try
            Dim f As New FrmListarTipo_Dcto
            ' Dim f As New FrmProveedor_1
            f.ShowDialog()

            If indice >= 0 Then

                id_tipo_Dcto = CInt(f.dgvlista.Item("Id Tipo Dcto", indice).Value)
                txtTipo_Dcto.Text = CStr(f.dgvlista.Item("Tipo de Dcto", indice).Value.ToString.Trim)
                'Me.Uni_Med.Text = CStr(f.DgvLista.Item("Unidad Medida", indice).Value.ToString.Trim)
                'Me.TxtTipoExist.Text = CStr(f.DgvLista.Item("Tipo de Existencia", indice).Value.ToString.Trim)
                'If Me.id_Personaa.Text = "" Then
                '    MessageBox.Show("Seleccione Proveedor por favor", "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        Catch ex As Exception
            'If Me.TxtOpe.Text <> "" And TxtTipoOperac.Text <> "" Then
            '    MessageBox.Show("Seleccione Operacion por favor", "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'End If
            ' BtnProv.Focus()
            '  End If
        End Try
        indice = -1
        nro_doc.Focus()


    End Sub
#Region "Text Box"


    Private Sub nombre_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles nombre.Enter
        nombre.BackColor = Color.Moccasin
    End Sub
    Private Sub nombre_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles nombre.Leave
        nombre.BackColor = Color.White
    End Sub

    Private Sub nombre_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nombre.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub nro_doc_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles nro_doc.Enter
        nro_doc.BackColor = Color.Moccasin
    End Sub
    Private Sub nro_doc_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles nro_doc.Leave
        nro_doc.BackColor = Color.White
    End Sub
    Private Sub nro_doc_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nro_doc.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtDireccion_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtDireccion.Enter
        txtDireccion.BackColor = Color.Moccasin
    End Sub

    Private Sub txtDireccion_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtDireccion.Leave
        txtDireccion.BackColor = Color.White
    End Sub
    Private Sub txtDireccion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtDireccion.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub txtTelefono_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtTelefono.Leave
        txtTelefono.BackColor = Color.White
    End Sub
    Private Sub txtTelefono_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtTelefono.Enter
        txtTelefono.BackColor = Color.Moccasin
    End Sub

    Private Sub txtTelefono_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtTelefono.KeyDown
        saltar_Flechas(e)
    End Sub


    Private Sub txtDescrip_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtDescrip.Enter
        txtDescrip.BackColor = Color.Moccasin
    End Sub
    Private Sub txtDescrip_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtDescrip.Leave
        txtDescrip.BackColor = Color.White
    End Sub
    Private Sub txtDescrip_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtDescrip.KeyDown
        saltar_Flechas(e)
    End Sub
   
    Private Sub nro_doc_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nro_doc.KeyPress
        SoloNumeros(e, False, sender.Text)
    End Sub


#End Region

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        Dim ok As Boolean

        ok = nombre.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Nombre por favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            nombre.Focus()
            Exit Sub
        End If

        ok = txtTelefono.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Telefono por favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTelefono.Focus()
            Exit Sub
        End If

        ok = txtDireccion.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Direccion por favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDireccion.Focus()
            Exit Sub
        End If

        ok = id_Zona <> -1
        If ok = False Then
            MessageBox.Show("Haga click en buscar Zona.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnZona.Focus()
            Exit Sub
        End If

        ok = id_tipo_Dcto <> -1
        If ok = False Then
            MessageBox.Show("Haga click en buscar Tipo de Documento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnTipo_Dcto.Focus()
            Exit Sub
        End If

        ok = nro_doc.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Nro. de Documento favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            nro_doc.Focus()
            Exit Sub
        End If


      

        'Aceptar = True
        'Hide()
        If MessageBox.Show("¿DESEA " + IIf(Nivel = "N", "GUARDAR ", "MODIFICAR ") + " Comisionista?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                Dim RPTA_DOC As Integer = -1
                Dim MSG_DOC As String = ""
                servidor.ejecutar("[dbo].[pa_mantenimiento_Comisionista]", _
                False, _
                RPTA_DOC, _
                MSG_DOC, _
                 id_comisionista, _
                nombre.Text.Trim, _
                txtTelefono.Text.Trim, _
                   txtDireccion.Text.Trim, _
                   nro_doc.Text.Trim, _
                 txtDescrip.Text.Trim, _
                    id_Zona, _
                     id_tipo_Dcto, _
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


    Private Sub btnZona_Leave(sender As Object, e As EventArgs) Handles btnZona.Leave
        If txtZona.Text = "" Then
            MessageBox.Show("Busque o Seleccione Zona por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnZona.Focus()
        End If
    End Sub


    Private Sub btnTipo_Dcto_Leave(sender As Object, e As EventArgs) Handles btnTipo_Dcto.Leave
        If txtTipo_Dcto.Text = "" Then
            MessageBox.Show("Busque o Seleccione Tipo de documento por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnTipo_Dcto.Focus()
        End If
    End Sub

End Class
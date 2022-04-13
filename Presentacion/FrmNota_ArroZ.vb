Public Class FrmNota_ArroZ
    Public Id_guia As Integer = -1
    Public id_nota_Arroz As Integer = -1
    Public id_precio As Integer = -1
    Public Id_Trabajador As Integer = -1

    Public Aceptar As Boolean = False

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim ok As Boolean
        ok = Id_guia <> -1

        If (ok = False) Then
            MessageBox.Show("Seleccione Guia de Remision, por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnGuia.Focus()
            Exit Sub
        End If

        ok = id_precio <> -1
        If ok = False Then
            MessageBox.Show("Seleccione Precio de Arroz, por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btn_Precios.Focus()
            Exit Sub
        End If


        ok = ok And costo_flet.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Costo de Flete por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            costo_flet.Focus()
            Exit Sub
        End If

        Aceptar = True
        Hide()

    End Sub
    Private Sub FrmNota_ArroZ_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub

    Private Sub btnGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuia.Click
        Try
            Dim f As New FrmListarGuiaS
            f.ShowDialog()
            If indice <> -1 Then
                Id_guia = CInt(f.dgvlista.Item("ID Guia", indice).Value)
                Dim strnroguia As String = ""
                strnroguia = CStr(f.dgvlista.Item("Nro. Guia de Remision", indice).Value.ToString.Trim)
                nro_guia.Text = strnroguia.Trim
                serie_guia.Text = CStr(f.dgvlista.Item("Serie", indice).Value.ToString.Trim)
                fecha_emision_guia.Text = CStr(f.dgvlista.Item("Fecha emision", indice).Value.ToString.Trim)
                txtremitente.Text = CStr(f.dgvlista.Item("Remitente", indice).Value.ToString.Trim)

                txttransportista.Text = CStr(f.dgvlista.Item("Empresa", indice).Value.ToString.Trim)
                txtRuc.Text = CStr(f.dgvlista.Item("ruc", indice).Value.ToString.Trim)

                nroplaca_camion.Text = CStr(f.dgvlista.Item("Nro. placa Camion", indice).Value.ToString.Trim)
                nroplaca_carreta.Text = CStr(f.dgvlista.Item("Nro. Placa Carreta", indice).Value.ToString.Trim)

                txtnombre.Text = CStr(f.dgvlista.Item("Nombre Chofer", indice).Value.ToString.Trim)
                txtapellido.Text = CStr(f.dgvlista.Item("Apellido Chofer", indice).Value.ToString.Trim)
                txtBrevete.Text = CStr(f.dgvlista.Item("Brevete", indice).Value.ToString.Trim)
                txtTelef.Text = CStr(f.dgvlista.Item("Telefono Chofer", indice).Value.ToString.Trim)

                Total.Text = CStr(f.dgvlista.Item("TOTAL", indice).Value.ToString.Trim)
                toneladas.Text = CDbl(f.dgvlista.Item("TOTAL", indice).Value)

                toneladas.Text = Val(Total.Text / 1000)
                txt_Ton_Sug.Text = Val(Total.Text / 1000)

                indice = -1
            Else
                serie_guia.Text = ""
                nro_guia.Text = ""

                txttransportista.Text = ""
                txtRuc.Text = ""

                nroplaca_camion.Text = ""
                nroplaca_carreta.Text = ""

                txtnombre.Text = ""
                txtapellido.Text = ""
                txtBrevete.Text = ""
                txtTelef.Text = ""

                toneladas.Text = ""

                indice = -1
                Id_guia = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        btn_Precios.Focus()
    End Sub


    Private Sub btn_Precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Precios.Click
        Try
            Dim f As New FrmListarPagoDetrac
            f.ShowDialog()
            If indice <> -1 Then
                id_precio = CInt(f.dgvlista.Item("Id Pago Detrac.", indice).Value)
                Fecha_Precio.Text = CStr(f.dgvlista.Item("Fecha Precios", indice).Value.ToString.Trim)
                'Me.superior.Text = CStr(f.dgvdetalle.Item("Precio", indice).Value.ToString.Trim)

                indice = -1
            Else

                indice = -1
                id_precio = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        btnTrabaj.Focus()
    End Sub
    Private Sub btnTrabaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrabaj.Click
        Try
            Dim f As New FrmListarTrabajador
            f.ShowDialog()
            If indice <> -1 Then
                Id_Trabajador = CInt(f.dgvlista.Item("Id Trabajador", indice).Value)
                txtTrabajador.Text = CStr(f.dgvlista.Item("Nombre Completo", indice).Value.ToString.Trim)
                ' Me.Destinatario.Text = CStr(f.dgvlista.Item("Nombre Completo", indice).Value.ToString.Trim)


                indice = -1
            Else

                indice = -1
                Id_Trabajador = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        BtnCliente.Focus()
    End Sub
    Private Sub BtnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCliente.Click
        Try
            Dim f As New FrmListarCliente
            f.ShowDialog()
            If indice <> -1 Then
                'Me.Id_Trabajador = CInt(f.dgvlista.Item("Id Trabajador", indice).Value)
                Destinatario.Text = CStr(f.dgvlista.Item("Cliente", indice).Value.ToString.Trim)
                ' Me.Destinatario.Text = CStr(f.dgvlista.Item("Nombre Completo", indice).Value.ToString.Trim)


                indice = -1
            Else

                indice = -1
                '  Id_Trabajador = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        telefono.Focus()
    End Sub

    Private Sub FrmNota_ArroZ_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub Destinatario_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Destinatario.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub Destinatario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Destinatario.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub telefono_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles telefono.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles telefono.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub direccion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles direccion.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub direccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles direccion.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub costo_flet_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles costo_flet.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub costo_flet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles costo_flet.KeyPress
        SoloNumeros(e, False, sender.Text)
        saltar_ENTER(e)
    End Sub

    Private Sub a_cuenta_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles a_cuenta.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub a_cuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles a_cuenta.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub Comentario_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Comentario.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub Comentario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Comentario.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub observacion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles observacion.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub observacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles observacion.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub Destinatario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Destinatario.Leave
        Destinatario.BackColor = Color.White
    End Sub
    Private Sub Destinatario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Destinatario.Enter
        Destinatario.BackColor = Color.Moccasin
    End Sub
    Private Sub telefono_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles telefono.Leave
        telefono.BackColor = Color.White
    End Sub
    Private Sub telefono_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles telefono.Enter
        telefono.BackColor = Color.Moccasin
    End Sub
    Private Sub direccion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles direccion.Leave
        direccion.BackColor = Color.White
    End Sub
    Private Sub direccion_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles direccion.Enter
        direccion.BackColor = Color.Moccasin
    End Sub

    Private Sub costo_flet_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles costo_flet.Leave
        costo_flet.BackColor = Color.White
    End Sub
    Private Sub costo_flet_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles costo_flet.Enter
        costo_flet.BackColor = Color.Moccasin
    End Sub
    Private Sub a_cuenta_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles a_cuenta.Leave
        a_cuenta.BackColor = Color.White
    End Sub
    Private Sub a_cuenta_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles a_cuenta.Enter
        a_cuenta.BackColor = Color.Moccasin
    End Sub
    Private Sub Comentario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Comentario.Leave
        Comentario.BackColor = Color.White
    End Sub
    Private Sub Comentario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Comentario.Enter
        Comentario.BackColor = Color.Moccasin
    End Sub
    Private Sub observacion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles observacion.Leave
        observacion.BackColor = Color.White
    End Sub
    Private Sub observacion_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles observacion.Enter
        observacion.BackColor = Color.Moccasin
    End Sub
    Private Sub toneladas_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles toneladas.Enter
        toneladas.BackColor = Color.Moccasin
    End Sub

    Private Sub toneladas_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles toneladas.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub toneladas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles toneladas.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub toneladas_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles toneladas.Leave
        toneladas.BackColor = Color.White
    End Sub


End Class
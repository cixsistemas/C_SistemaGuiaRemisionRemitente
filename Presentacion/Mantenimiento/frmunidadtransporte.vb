Public Class frmunidadtransporte

    Public Aceptar As Boolean = False
    Public id_vehi As Integer = -1

    Dim tabla_emptransporte As DataTable = Nothing
    Public id_transportista As Integer = -1


    Private Sub valida()
        Dim ok As Boolean
        ok = marca.Text.Trim <> ""
        ok = ok And nroplaca.Text.Trim <> ""
        btnaceptar.Enabled = ok
    End Sub


    Private Sub frmunidadtransporte_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub frmunidadtransporte_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        'lista_emptransporte(3)
    End Sub

    Private Sub frmunidadtransporte_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub Pes_Veh_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Pes_Veh.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub Pes_Veh_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Pes_Veh.Leave
        Try
            Pes_Veh.Text = Format(CType(Pes_Veh.Text, Decimal), "#,##0")
        Catch ex As Exception
            Pes_Veh.Text = ""
        End Try
        Pes_Veh.BackColor = Color.White
    End Sub
    Private Sub Pes_Veh_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Pes_Veh.Enter
        Pes_Veh.BackColor = Color.Moccasin
    End Sub

    Private Sub Descripcion_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Descripcion.Enter
        Descripcion.BackColor = Color.Moccasin
    End Sub
    Private Sub Descripcion_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Descripcion.Leave
        Descripcion.BackColor = Color.White
    End Sub

    Private Sub Peso_neto1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Peso_neto1.Enter
        Peso_neto1.BackColor = Color.Moccasin
    End Sub
    Private Sub Peso_neto1_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Peso_neto1.Leave
        Try
            Peso_neto1.Text = Format(CType(Peso_neto1.Text, Decimal), "#,##0")
        Catch ex As Exception
            Peso_neto1.Text = ""
        End Try
        Peso_neto1.BackColor = Color.White
    End Sub
    Private Sub peso_neto2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles peso_neto2.Enter
        peso_neto2.BackColor = Color.Moccasin
    End Sub
    Private Sub peso_neto2_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles peso_neto2.Leave
        Try
            peso_neto2.Text = Format(CType(peso_neto2.Text, Decimal), "#,##0")
        Catch ex As Exception
            peso_neto2.Text = ""
        End Try
        peso_neto2.BackColor = Color.White
    End Sub
    Private Sub Peso_neto1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Peso_neto1.TextChanged
        valida()
    End Sub

    Private Sub Peso_neto1_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Peso_neto1.VisibleChanged
        valida()
    End Sub

 

    Private Sub peso_neto2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles peso_neto2.TextChanged
        valida()
    End Sub

    Private Sub peso_neto2_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles peso_neto2.VisibleChanged
        valida()
    End Sub
    Private Sub btnaceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnaceptar.Click
        Dim okk As Boolean
        okk = Peso_neto1.Text.Trim <> ""
        If (okk = False) Then
            MessageBox.Show("Ingrese Peso Neto de Remolque, 0 mayor que 0 por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Peso_neto1.Focus()
            Exit Sub
        End If

        okk = peso_neto2.Text.Trim <> ""
        If (okk = False) Then
            MessageBox.Show("Ingrese Peso Neto de Semi-Remolque, 0 mayor que 0 por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            peso_neto2.Focus()
            Exit Sub
        End If

        okk = Peso_Bonif.Text.Trim <> ""
        If (okk = False) Then
            MessageBox.Show("Ingrese Peso Bonificacion, 0 mayor que 0 por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Peso_Bonif.Focus()
            Exit Sub
        End If

        Aceptar = True
        Hide()
    End Sub
    Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub
    Private Sub cboemptransporte_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        valida()
    End Sub
    Private Sub marca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles marca.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub marca_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles marca.TextChanged
        valida()
    End Sub
    Private Sub marca_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles marca.VisibleChanged
        valida()
    End Sub

    Private Sub nroplaca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nroplaca.KeyDown
        saltar_Flechas(e)

    End Sub
    Private Sub nroplaca_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles nroplaca.TextChanged
        valida()
    End Sub
    Private Sub nroplaca_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nroplaca.VisibleChanged
        valida()
    End Sub

    Private Sub nrocertificado_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nrocertificado.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub nrocertificado_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nrocertificado.TextChanged
        valida()
    End Sub
    Private Sub nrocertificado_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nrocertificado.VisibleChanged
        valida()
    End Sub

    Private Sub marca2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles marca2.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub marca2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles marca2.TextChanged
        valida()
    End Sub

    Private Sub marca2_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles marca2.VisibleChanged
        valida()
    End Sub

    Private Sub nroplaca2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nroplaca2.KeyDown
        saltar_Flechas(e)
    End Sub


    Private Sub nroplaca2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nroplaca2.TextChanged
        valida()
    End Sub

    Private Sub nroplaca2_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nroplaca2.VisibleChanged
        valida()
    End Sub

    Private Sub nrocertificado2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nrocertificado2.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub nrocertificado2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nrocertificado2.TextChanged
        valida()
    End Sub

    Private Sub nrocertificado2_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nrocertificado2.VisibleChanged
        valida()
    End Sub

    Private Sub cboemptransporte_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        saltar_ENTER(e)
    End Sub
    Private Sub marca_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles marca.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub nroplaca_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nroplaca.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub largo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles largo.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub largo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles largo.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub alto_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles alto.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub alto_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles alto.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub ancho_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ancho.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub ancho_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ancho.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub nrocertificado_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nrocertificado.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub Peso_neto1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Peso_neto1.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
    Private Sub marca2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles marca2.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub nroplaca2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nroplaca2.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub largo2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles largo2.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub largo2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles largo2.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub alto2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles alto2.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub alto2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles alto2.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub ancho2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ancho2.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub ancho2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ancho2.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub peso_neto2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles peso_neto2.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
    Private Sub nrocertificado2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nrocertificado2.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub Conf_Vehi_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Conf_Vehi.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub Conf_Vehi_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Conf_Vehi.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub Pes_Veh_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Pes_Veh.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub Descripcion_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Descripcion.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub marca_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles marca.Enter
        marca.BackColor = Color.Moccasin
    End Sub
    Private Sub marca_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles marca.Leave
        marca.BackColor = Color.White
    End Sub

    Private Sub nroplaca_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles nroplaca.Enter
        nroplaca.BackColor = Color.Moccasin
    End Sub
    Private Sub nroplaca_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles nroplaca.Leave
        nroplaca.BackColor = Color.White
    End Sub
    Private Sub nrocertificado_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles nrocertificado.Enter
        nrocertificado.BackColor = Color.Moccasin
    End Sub
    Private Sub nrocertificado_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles nrocertificado.Leave
        nrocertificado.BackColor = Color.White
    End Sub
    Private Sub largo_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles largo.Enter
        largo.BackColor = Color.Moccasin
    End Sub

    Private Sub largo_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles largo.Leave
        largo.BackColor = Color.White
    End Sub
    Private Sub alto_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles alto.Enter
        alto.BackColor = Color.Moccasin
    End Sub
    Private Sub alto_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles alto.Leave
        alto.BackColor = Color.White
    End Sub
    Private Sub ancho_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles ancho.Enter
        ancho.BackColor = Color.Moccasin
    End Sub
    Private Sub ancho_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles ancho.Leave
        ancho.BackColor = Color.White
    End Sub
    Private Sub marca2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles marca2.Enter
        marca2.BackColor = Color.Moccasin
    End Sub
    Private Sub marca2_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles marca2.Leave
        marca2.BackColor = Color.White
    End Sub

    Private Sub nroplaca2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles nroplaca2.Enter
        nroplaca2.BackColor = Color.Moccasin
    End Sub
    Private Sub nroplaca2_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles nroplaca2.Leave
        nroplaca2.BackColor = Color.White
    End Sub
    Private Sub nrocertificado2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles nrocertificado2.Enter
        nrocertificado2.BackColor = Color.Moccasin
    End Sub
    Private Sub nrocertificado2_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles nrocertificado2.Leave
        nrocertificado2.BackColor = Color.White
    End Sub
    Private Sub largo2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles largo2.Enter
        largo2.BackColor = Color.Moccasin
    End Sub

    Private Sub largo2_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles largo2.Leave
        largo2.BackColor = Color.White
    End Sub
    Private Sub alto2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles alto2.Enter
        alto2.BackColor = Color.Moccasin
    End Sub
    Private Sub alto2_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles alto2.Leave
        alto2.BackColor = Color.White
    End Sub
    Private Sub ancho2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles ancho2.Enter
        ancho2.BackColor = Color.Moccasin
    End Sub
    Private Sub ancho2_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles ancho2.Leave
        ancho2.BackColor = Color.White
    End Sub

    Private Sub Conf_Vehi_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Conf_Vehi.Enter
        Conf_Vehi.BackColor = Color.Moccasin
    End Sub
    Private Sub Conf_Vehi_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Conf_Vehi.Leave
        Conf_Vehi.BackColor = Color.White
    End Sub


    Private Sub Peso_neto1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Peso_neto1.KeyDown
        saltar_Flechas(e)
    End Sub


    Private Sub peso_neto2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles peso_neto2.KeyDown
        saltar_Flechas(e)
    End Sub


    Private Sub Descripcion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Descripcion.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub btnTransport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTransport.Click
        Try
            Dim f As New FrmListarTransportista
            f.ShowDialog()
            If indice <> -1 Then
                id_transportista = CInt(f.dgvlista.Item("ID", indice).Value)
                Transportista.Text = CStr(f.dgvlista.Item("empresa", indice).Value.ToString.Trim)
                'Me.provincia.Text = CStr(f.dgvlista.Item("Provincia", indice).Value.ToString.Trim)
                'Me.departamento.Text = CStr(f.dgvlista.Item("Departamento", indice).Value.ToString.Trim)
                indice = -1
            Else
                Transportista.Text = ""
                'Me.provincia.Text = ""
                'Me.departamento.Text = ""
                indice = -1
                id_transportista = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        marca.Focus()
        '  Descripcion.Focus()
    End Sub

    Private Sub Peso_Bonif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Peso_Bonif.KeyPress

        saltar_ENTER(e)
    End Sub

    Private Sub Peso_Bonif_Leave(sender As Object, e As EventArgs) Handles Peso_Bonif.Leave
        alto2.BackColor = Color.White
    End Sub

    Private Sub Peso_Bonif_Enter(sender As Object, e As EventArgs) Handles Peso_Bonif.Enter
        Conf_Vehi.BackColor = Color.Moccasin
    End Sub

    Private Sub Peso_Bonif_KeyDown(sender As Object, e As KeyEventArgs) Handles Peso_Bonif.KeyDown
        saltar_Flechas(e)
    End Sub
End Class
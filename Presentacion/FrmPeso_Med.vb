Public Class FrmPeso_Med
    Public Id_guia As Integer = -1
    Public Id_peso_med As Integer = -1
    Public Aceptar As Boolean = False

    Private Sub FrmPeso_Med_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmPeso_Med_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnaceptar.Click
        Dim ok As Boolean
        ok = Id_guia <> -1
        If (ok = False) Then
            MessageBox.Show("Seleccione Guia de Remision-Remitente por favor.", "Guía de remisión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnGuia.Focus()
            Exit Sub
        End If
        Aceptar = True
        Hide()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub

    Private Sub btnGuia_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGuia.Click
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

                ' Me.id_remitente = CInt(f.dgvlista.Item("ID", indice).Value)
                'Dim strremitente As String = ""
                NombreDestinatario.Text = CStr(f.dgvlista.Item("Destinatario", indice).Value.ToString.Trim)
                'strremitente = CStr(f.dgvlista.Item("Remitente", indice).Value.ToString.Trim)
                'Me.NombreRemitente.Text = strremitente.Trim
                ruc.Text = CStr(f.dgvlista.Item("RUC Destinatario", indice).Value.ToString.Trim)
                direccion.Text = CStr(f.dgvlista.Item("Direccion Destinatario", indice).Value.ToString.Trim)

                distrito.Text = CStr(f.dgvlista.Item("Distrito", indice).Value.ToString.Trim)
                provincia.Text = CStr(f.dgvlista.Item("Provincia", indice).Value.ToString.Trim)
                departamento.Text = CStr(f.dgvlista.Item("Departamento", indice).Value.ToString.Trim)

                nroplaca_camion.Text = CStr(f.dgvlista.Item("Nro. placa Camion", indice).Value.ToString.Trim)
                nroplaca_carreta.Text = CStr(f.dgvlista.Item("Nro. Placa Carreta", indice).Value.ToString.Trim)
                largo.Text = CStr(f.dgvlista.Item("Largo Camion", indice).Value.ToString.Trim)
                ancho.Text = CStr(f.dgvlista.Item("Ancho Camion", indice).Value.ToString.Trim)
                alto.Text = CStr(f.dgvlista.Item("Alto Camion", indice).Value.ToString.Trim)
                peso_neto1.Text = CDbl(f.dgvlista.Item("Peso Neto Remolque", indice).Value)

                largo2.Text = CStr(f.dgvlista.Item("Largo Carreta", indice).Value.ToString.Trim)
                ancho2.Text = CStr(f.dgvlista.Item("Ancho Carreta", indice).Value.ToString.Trim)
                alto2.Text = CStr(f.dgvlista.Item("Alto Carreta", indice).Value.ToString.Trim)
                peso_neto2.Text = CDbl(f.dgvlista.Item("Peso Neto Semi-Remolque", indice).Value)

                Conf_Vehi.Text = CStr(f.dgvlista.Item("Configuracion Vehicular", indice).Value.ToString.Trim)
                Pes_Veh.Text = CStr(f.dgvlista.Item("Peso Bruto Vehicular", indice).Value.ToString.Trim)

                ' Me.Pes_Transp.Text = CDbl(f.dgvlista.Item("Peso Bruto Transportado", indice).Value)
                TxtBonificacion.Text = CStr(f.dgvlista.Item("Descripcion", indice).Value.ToString.Trim)

                Total.Text = CStr(f.dgvlista.Item("TOTAL", indice).Value.ToString.Trim)
                indice = -1
                'Me.Pes_Veh.Text = Me.peso_neto1.Text + Me.peso_neto2.Text + Me.Total.Text

            Else

                serie_guia.Text = ""
                nro_guia.Text = ""

                NombreDestinatario.Text = ""
                ruc.Text = ""
                direccion.Text = ""
                distrito.Text = ""
                provincia.Text = ""
                departamento.Text = ""

                nroplaca_camion.Text = ""
                nroplaca_carreta.Text = ""
                largo.Text = ""
                ancho.Text = ""
                alto.Text = ""
                largo2.Text = ""
                ancho2.Text = ""
                alto2.Text = ""
                Conf_Vehi.Text = ""
                Pes_Veh.Text = ""


                indice = -1
                Id_guia = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        observacion.Focus()
    End Sub

    Private Sub Pes_Transp_Enter1(ByVal sender As Object, ByVal e As EventArgs) Handles Pes_Transp.Enter
        Pes_Transp.BackColor = Color.Moccasin
    End Sub

    Private Sub Pes_Transp_KeyPress1(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Pes_Transp.KeyPress
        ' SoloNumeros(e, True, sender.Text)
    End Sub

    Private Sub Pes_Transp_Leave1(ByVal sender As Object, ByVal e As EventArgs) Handles Pes_Transp.Leave
        'Try
        '    'Me.Pes_Transp.Text = Format(CType(Me.Pes_Transp.Text, Decimal), "#,##0.00")
        '    Me.Pes_Transp.Text = Format(CType(Me.Pes_Transp.Text, Decimal), "#,##0")
        'Catch ex As Exception
        '    Me.Pes_Transp.Text = ""
        'End Try
        'Me.Pes_Transp.BackColor = Color.White
    End Sub

    Private Sub observacion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles observacion.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub observacion_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles observacion.KeyPress
       saltar_ENTER(e)
        'btnaceptar.Focus()
    End Sub

    Private Sub observacion_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles observacion.Leave
        observacion.BackColor = Color.White
    End Sub

    Private Sub observacion_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles observacion.Enter
        observacion.BackColor = Color.Moccasin
    End Sub

    Private Sub FrmPeso_Med_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
End Class


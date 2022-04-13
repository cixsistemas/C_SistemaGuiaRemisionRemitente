Public Class frmguia

    Public id_guia As Integer = -1
    Public id_remitente As Integer = -1
    Public prod_id As Integer = -1
    ' Public id_emp_trans As Integer = -1
    Public ubigeo_pto_partida As Integer = -1
    Public ubigeo_pto_llegada As Integer = -1
    Public id_Destinatario As Integer = -1
    Public id_vehi As Integer = -1
    Public id_chofer As Integer = -1
    Public id_det_guia_ As Integer = -1

    Public id_MotivoTras As Integer = -1
    Public Aceptar As Boolean

    Private operacion As String = ""

    Dim tabla_motivotras As DataTable
    Private INDICE2 As Integer = -1
    

    Private Sub frmguia_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub frmguia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        'lista(7)
    End Sub

    Private Sub BtnMotivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnMotivo.Click
        Try
            Dim f As New FrmListarMotivo
            f.ShowDialog()
            If indice <> -1 Then
                id_MotivoTras = CInt(f.dgvlista.Item("ID", indice).Value)
                TxtMotivo.Text = CStr(f.dgvlista.Item("Nombre", indice).Value.ToString.Trim)
                indice = -1
            Else
                TxtMotivo.Text = ""
                indice = -1
                id_MotivoTras = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        btnnuevo_examen.Focus()

        If TxtMotivo.Text = "VENTA" Then
            TxtPrec_Venta.Enabled = True
            TxtIGV.Enabled = True
        End If
    End Sub
    Private Sub btnremitente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnremitente.Click

        Try
            Dim f As New frmListarRemitentes
            f.ShowDialog()
            If indice <> -1 Then
                id_remitente = CInt(f.dgvlista.Item("ID", indice).Value)
                Dim strremitente As String = ""
                strremitente = CStr(f.dgvlista.Item("Remitente", indice).Value.ToString.Trim)
                NombreRemitente.Text = strremitente.Trim
                ruc.Text = CStr(f.dgvlista.Item("ruc", indice).Value.ToString.Trim)
                indice = -1
            Else
                NombreRemitente.Text = ""
                ruc.Text = ""
                indice = -1
                id_remitente = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        fecha_emision_guia.Focus()
    End Sub
    Private Sub btnChofer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChofer.Click
        Try
            Dim f As New FrmListarChofer
            f.ShowDialog()
            If indice <> -1 Then
                id_chofer = CInt(f.dgvlista.Item("ID", indice).Value)
                Nro_licencia_conductor.Text = CStr(f.dgvlista.Item("Brevete", indice).Value.ToString.Trim)
                indice = -1
            Else
                Nro_licencia_conductor.Text = ""
                indice = -1
                id_chofer = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        Nro_constancia_deposito.Focus()
    End Sub

    Private Sub btnProducto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProducto.Click
        Try
            Dim f As New FrmListarProducto
            f.ShowDialog()
            If indice <> -1 Then
                prod_id = CInt(f.dgvlista.Item("ID", indice).Value)
                Dim strproducto As String = ""
                strproducto = CStr(f.dgvlista.Item("Producto", indice).Value.ToString.Trim)
                NombreProducto.Text = strproducto.Trim.ToUpper
                prod_peso_uni.Text = CStr(f.dgvlista.Item("Peso", indice).Value.ToString.Trim)
                indice = -1
            Else
                NombreProducto.Text = ""
                prod_peso_uni.Text = ""
                indice = -1
                prod_id = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        cantidad_sacos.Focus()
    End Sub

    Private Sub btnptopartida_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnptopartida.Click
        Try
            Dim f As New frmListarUbigeo
            f.ShowDialog()
            If indice <> -1 Then
                ubigeo_pto_partida = CInt(f.dgvlista.Item("ID", indice).Value)
                distritoptop.Text = CStr(f.dgvlista.Item("Distrito", indice).Value.ToString.Trim)
                provinciaptop.Text = CStr(f.dgvlista.Item("Provincia", indice).Value.ToString.Trim)
                departamentoptop.Text = CStr(f.dgvlista.Item("Departamento", indice).Value.ToString.Trim)
                indice = -1
            Else
                distritoptop.Text = ""
                provinciaptop.Text = ""
                departamentoptop.Text = ""
                indice = -1
                ubigeo_pto_partida = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        direccion_pto_llegadaa.Focus()
    End Sub

    Private Sub btnptollegada_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnptollegada.Click
        Try
            Dim f As New frmListarUbigeo
            f.ShowDialog()
            If indice <> -1 Then
                ubigeo_pto_llegada = CInt(f.dgvlista.Item("ID", indice).Value)
                distritoptoll.Text = CStr(f.dgvlista.Item("Distrito", indice).Value.ToString.Trim)
                provinciaptoll.Text = CStr(f.dgvlista.Item("Provincia", indice).Value.ToString.Trim)
                departamentoptoll.Text = CStr(f.dgvlista.Item("Departamento", indice).Value.ToString.Trim)
                indice = -1
            Else
                distritoptoll.Text = ""
                provinciaptoll.Text = ""
                departamentoptoll.Text = ""
                indice = -1
                ubigeo_pto_llegada = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        btnDestinatario.Focus()
    End Sub

    Private Sub btnDestinatario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDestinatario.Click
        Try
            Dim f As New frmListardestinatarios
            f.ShowDialog()
            If indice <> -1 Then
                id_Destinatario = CInt(f.dgvlista.Item("ID", indice).Value)
                destinatario.Text = CStr(f.dgvlista.Item("RAZON SOCIAL", indice).Value.ToString.Trim)
                rucdes.Text = CStr(f.dgvlista.Item("RUC", indice).Value.ToString.Trim)
                nombre_tip_doc.Text = CStr(f.dgvlista.Item("TIPO DOC", indice).Value.ToString.Trim)
                nro_doc.Text = CStr(f.dgvlista.Item("NRO DOC", indice).Value.ToString.Trim)
                indice = -1
            Else
                rucdes.Text = ""
                destinatario.Text = ""
                nombre_tip_doc.Text = ""
                nro_doc.Text = ""
                indice = -1
                id_Destinatario = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        btnTransporte.Focus()
    End Sub

    Private Sub btnTransporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTransporte.Click
        Try
            Dim f As New FrmListarUnidTransp
            f.ShowDialog()
            If indice <> -1 Then
                id_vehi = CInt(f.dgvlista.Item("ID", indice).Value)
                marca_camion.Text = CStr(f.dgvlista.Item("marca Camion", indice).Value.ToString.Trim)
                nroplaca_camion.Text = CStr(f.dgvlista.Item("Nro. placa Camion", indice).Value.ToString.Trim)
                nrocertificado_camion.Text = CStr(f.dgvlista.Item("Nro. certificado Camion", indice).Value.ToString.Trim)
                marca_carreta.Text = CStr(f.dgvlista.Item("Marca Carreta", indice).Value.ToString.Trim)
                nroplaca_carreta.Text = CStr(f.dgvlista.Item("Nro. Placa Carreta", indice).Value.ToString.Trim)
                nrocertificado_carreta.Text = CStr(f.dgvlista.Item("Nro. Certificado Carreta", indice).Value.ToString.Trim)
                NombreEmpTransporte.Text = CStr(f.dgvlista.Item("Empresa Transporte", indice).Value.ToString.Trim)
                RucEmpTransporte.Text = CStr(f.dgvlista.Item("RUC Emp Transporte", indice).Value.ToString.Trim)

                indice = -1
                Nro_licencia_conductor.Focus()
            Else
                marca_camion.Text = ""
                nroplaca_camion.Text = ""
                nrocertificado_camion.Text = ""
                marca_carreta.Text = ""
                nroplaca_carreta.Text = ""
                nrocertificado_carreta.Text = ""
                NombreEmpTransporte.Text = ""
                RucEmpTransporte.Text = ""
                indice = -1
                id_vehi = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        btnChofer.Focus()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        If operacion = "" Then
            MessageBox.Show("Seleccione nuevo ó editar.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim ok As Boolean
        ok = prod_id <> -1
        If ok = False Then
            MessageBox.Show("Haga click en buscar producto.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ok = prod_peso_uni.Text.Trim <> ""
        If ok = False Then
            MessageBox.Show("Haga click en buscar producto.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ok = cantidad_sacos.Text.Trim <> "" And Val(cantidad_sacos.Text.Trim) > 0
        If ok = False Then
            MessageBox.Show("Ingrese cantidad sacos producto Mayor a 0.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cantidad_sacos.Focus()
            Exit Sub
        End If

        ok = TxtPrec_Venta.Text.Trim <> "" 'And Val(Me.cantidad_sacos.Text.Trim) > 0
        If ok = False Then
            MessageBox.Show("Ingrese Precio de Venta Igual o Mayor a 0.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtPrec_Venta.Focus()
            Exit Sub
        End If

        ok = TxtIGV.Text.Trim <> "" 'And Val(Me.cantidad_sacos.Text.Trim) > 0
        If ok = False Then
            MessageBox.Show("Ingrese IGV Igual o Mayor a 0.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtIGV.Focus()
            Exit Sub
        End If


        If operacion = "N" Then
            Detalle.Rows.Add()
            Detalle.Item("id_det_guia", Detalle.Rows.Count - 1).Value = "-1"
            Detalle.Item("id_prod", Detalle.Rows.Count - 1).Value = prod_id
            Detalle.Item("sacos_cantidad", Detalle.Rows.Count - 1).Value = Val(cantidad_sacos.Text.Trim)
            Detalle.Item("unidad_medida", Detalle.Rows.Count - 1).Value = "Sacos"
            Detalle.Item("Descripcion", Detalle.Rows.Count - 1).Value = NombreProducto.Text.Trim
            Detalle.Item("Peso", Detalle.Rows.Count - 1).Value = Val(cantidad_sacos.Text.Trim) * Val(prod_peso_uni.Text.Trim)
            Detalle.Item("x", Detalle.Rows.Count - 1).Value = Val(prod_peso_uni.Text.Trim)
            Detalle.Item("Precio_Venta", Detalle.Rows.Count - 1).Value = Val(TxtPrec_Venta.Text.Trim)
            Detalle.Item("IGV", Detalle.Rows.Count - 1).Value = Val(TxtIGV.Text.Trim)
            'Me.LblTotal.Text = CDbl(Me.LblTotal.Text) + Detalle.Item("Peso", Detalle.Rows.Count - 1).Value
        ElseIf operacion = "M" Then

            Detalle.Item("id_det_guia", INDICE2).Value = id_det_guia_
            Detalle.Item("id_prod", INDICE2).Value = prod_id
            Detalle.Item("sacos_cantidad", INDICE2).Value = CDbl(cantidad_sacos.Text.Trim)
            Detalle.Item("unidad_medida", INDICE2).Value = "Sacos"
            Detalle.Item("Descripcion", INDICE2).Value = NombreProducto.Text.Trim
            Detalle.Item("Peso", INDICE2).Value = CDbl(cantidad_sacos.Text.Trim) * CDbl(prod_peso_uni.Text.Trim)
            Detalle.Item("x", INDICE2).Value = CDbl(prod_peso_uni.Text.Trim)
            Detalle.Item("Precio_Venta", INDICE2).Value = CDbl(TxtPrec_Venta.Text.Trim)
            Detalle.Item("IGV", INDICE2).Value = CDbl(TxtIGV.Text.Trim)
            'Detalle.Item("id_det_guia", indice).Value = id_det_guia_
            'Detalle.Item("id_prod", indice).Value = Me.prod_id
            'Detalle.Item("sacos_cantidad", indice).Value = Val(cantidad_sacos.Text.Trim)
            'Detalle.Item("unidad_medida", indice).Value = "Sacos"
            'Detalle.Item("Descripcion", indice).Value = NombreProducto.Text.Trim
            'Detalle.Item("Peso", indice).Value = Val(cantidad_sacos.Text.Trim) * Val(prod_peso_uni.Text.Trim)
            'Detalle.Item("x", indice).Value = Val(prod_peso_uni.Text.Trim)

            '' Me.LblTotal.Text = CDbl(Me.LblTotal.Text) + Detalle.Item("Peso", Detalle.Rows.Count - 1).Value

        End If

        limpiaproducto()
        activar2(False)
        operacion = ""
        indice = -1

        btnnuevo_examen.Focus()
    End Sub

    Public Sub limpiaproducto()
        id_det_guia_ = -1
        NombreProducto.Text = ""
        prod_id = -1
        prod_peso_uni.Text = ""
        cantidad_sacos.Text = ""
        TxtPrec_Venta.Text = "0"
        TxtIGV.Text = "0"
    End Sub

    Private Sub btnnuevo_examen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevo_examen.Click
        operacion = "N"
        indice = -1
        activar2(True)

        btnProducto.Focus()
    End Sub

    Private Sub btneditar_hpm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btneditar_hpm.Click

        If indice = -1 Then
            MessageBox.Show("Seleccione producto para editarlo", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        id_det_guia_ = CInt(Detalle.Item("id_det_guia", INDICE2).Value)
        prod_id = CStr(Detalle.Item("id_prod", INDICE2).Value)
        NombreProducto.Text = CStr(Detalle.Item("Descripcion", INDICE2).Value)
        prod_peso_uni.Text = CDbl(Detalle.Item("x", INDICE2).Value)
        cantidad_sacos.Text = CStr(Detalle.Item("sacos_cantidad", INDICE2).Value)
        TxtPrec_Venta.Text = CStr(Detalle.Item("Precio_Venta", INDICE2).Value)
        TxtIGV.Text = CStr(Detalle.Item("IGV", INDICE2).Value)
        'Me.LblTotal.Text = CDbl(Me.LblTotal.Text) - Detalle.Item("Peso", Detalle.Rows.Count - 1).Value
        activar2(True)
        operacion = "M"

        If TxtMotivo.Text = "VENTA" Then
            TxtPrec_Venta.Enabled = True
            TxtIGV.Enabled = True
        End If

    End Sub

    Private Sub Detalle_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles Detalle.CellClick
        INDICE2 = e.RowIndex

    End Sub

    Private Sub btnquitar_hpm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnquitar_hpm.Click
        If check_fila_grilla(Detalle) = False Then
            MessageBox.Show("Haga check en la columna Seleccionar por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            quitar_fila_grilla(Detalle, "Seleccionar", "Detalle de Guia no se puede quitar. Solo se pueden quitar elementos agregados recientemente.")
        End If
        ' Me.LblTotal.Text = CDbl(Me.LblTotal.Text) - Detalle.Item("Peso", Detalle.Rows.Count - 1).Value
        operacion = ""
        indice = -1
    End Sub

    Private Sub Detalle_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles Detalle.RowsAdded
        btnquitar_hpm.Enabled = CBool(IIf(Detalle.Rows.Count > 0, True, False))
        btneditar_hpm.Enabled = CBool(IIf(Detalle.Rows.Count > 0, True, False))
    End Sub

    Private Sub Detalle_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles Detalle.RowsRemoved
        btnquitar_hpm.Enabled = CBool(IIf(Detalle.Rows.Count > 0, True, False))
        btneditar_hpm.Enabled = CBool(IIf(Detalle.Rows.Count > 0, True, False))
    End Sub

    Private Sub Detalle_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detalle.VisibleChanged
        btnquitar_hpm.Enabled = CBool(IIf(Detalle.Rows.Count > 0, True, False))
        btneditar_hpm.Enabled = CBool(IIf(Detalle.Rows.Count > 0, True, False))
    End Sub

    Private Sub activar2(ByVal activa As Boolean)
        btnProducto.Enabled = activa
        cantidad_sacos.Enabled = activa
        btnAgregar.Enabled = activa
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaceptar.Click

        Dim ok As Boolean

        'ok = ok And serie_guia.Text.Trim <> ""
        'If (ok = False) Then
        '    MessageBox.Show("Ingrese nro. serie por favor.", "Guía de remisión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    serie_guia.Focus()
        '    Exit Sub
        'End If

        'ok = ok And nro_guia.Text.Trim <> ""
        'If (ok = False) Then
        '    MessageBox.Show("Ingrese número guia por favor.", "Guía de remisión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    nro_guia.Focus()
        '    Exit Sub
        'End If

        ok = id_remitente <> -1
        If (ok = False) Then
            MessageBox.Show("Seleccione remitente por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnremitente.Focus()
            Exit Sub
        End If

        'ok = ok And ruc.Text.Trim <> ""
        'If (ok = False) Then
        '    MessageBox.Show("Seleccione remitente por favor.", "Guía de remisión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If

        ok = ok And ubigeo_pto_partida <> -1
        If (ok = False) Then
            MessageBox.Show("Seleccione punto de partida por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnptopartida.Focus()
            Exit Sub
        End If


        ok = ok And ubigeo_pto_llegada <> -1
        If (ok = False) Then
            MessageBox.Show("Seleccione punto de llegada por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnptollegada.Focus()
            Exit Sub
        End If

        ok = ok And id_Destinatario <> -1
        If (ok = False) Then
            MessageBox.Show("Seleccione destinatario por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnDestinatario.Focus()
            Exit Sub
        End If

        ok = ok And id_vehi <> -1
        If (ok = False) Then
            MessageBox.Show("Seleccione unidad de transporte por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnTransporte.Focus()
            Exit Sub
        End If

        ok = id_chofer <> -1
        If (ok = False) Then
            MessageBox.Show("Seleccione Brevete por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnChofer.Focus()
            Exit Sub
        End If

        ok = ok And Nro_constancia_deposito.Text.Trim <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Número constancia deposito por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Nro_constancia_deposito.Focus()
            Exit Sub
        End If

        ok = ok And Detalle.Rows.Count <> 0
        If (ok = False) Then
            MessageBox.Show("Seleccione productos por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnnuevo_examen.Focus()
            Exit Sub
        End If

        'ok = ok And Monto_deposito.Text <> ""
        'If (ok = False) Then
        '    MessageBox.Show("Ingrese monto deposito por favor.", "Guía de remisión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Monto_deposito.Focus()
        '    Exit Sub
        'End If

        'ok = ok And Monto_deposito2.Text <> ""
        'If (ok = False) Then
        '    MessageBox.Show("Ingrese monto deposito por favor.", "Guía de remisión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Monto_deposito2.Focus()
        '    Exit Sub
        'End If

        'ok = ok And check_fila_grilla(dgvmotivo) = True
        'If (ok = False) Then
        '    MessageBox.Show("Haga check en la columna Seleccionar por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If

        Aceptar = True
        Hide()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub

    Private Sub dgvmotivo_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvmotivo.CellContentClick
        seleciona_solo_una_fila_grilla(sender)
    End Sub


    Private Sub Monto_deposito_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Monto_deposito.Leave
        If Monto_deposito.Text = "" Then
            MessageBox.Show("Ingrese monto deposito mayor o igual a 0, por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Monto_deposito.Focus()
        Else
            'CONVIERTE EL NUMERO A FORMATO MONEDA
            Monto_deposito.Text = Format(CType(Monto_deposito.Text, Decimal), "###0.00")
        End If
        Monto_deposito.BackColor = Color.White
    End Sub
    Private Sub Monto_deposito_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Monto_deposito.Enter
        Monto_deposito.BackColor = Color.Moccasin
    End Sub
    Private Sub Monto_deposito2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Monto_deposito2.Leave
        If Monto_deposito2.Text = "" Then
            MessageBox.Show("Ingrese Monto deposito mayor o igual a 0, por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Monto_deposito2.Focus()
        Else
            'CONVIERTE EL NUMERO A FORMATO MONEDA
            Monto_deposito2.Text = Format(CType(Monto_deposito2.Text, Decimal), "###0.00")
        End If
        Monto_deposito2.BackColor = Color.White
    End Sub
    Private Sub frmguia_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        '    'cerrar formulario con tecla ESC
        '    If (e.KeyCode = Keys.Escape) Then
        '        Me.Close()
        '    End If
    End Sub
    Private Sub serie_guia_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles serie_guia.Leave
        If serie_guia.Text = "" Then
            MessageBox.Show("Ingrese Nro. serie por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            serie_guia.Focus()
        Else
            serie_guia.Text = Format(CType(serie_guia.Text, Decimal), "000")
        End If
        serie_guia.BackColor = Color.White
    End Sub
    Private Sub serie_guia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles serie_guia.Enter
        serie_guia.BackColor = Color.Moccasin
    End Sub
    Private Sub nro_guia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nro_guia.Enter
        nro_guia.BackColor = Color.Moccasin
    End Sub
    Private Sub nro_guia_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles nro_guia.Leave
        If nro_guia.Text = "" Then
            MessageBox.Show("Ingrese Número Guia por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            nro_guia.Focus()
        Else
            nro_guia.Text = Format(CType(nro_guia.Text, Decimal), "000000")
        End If
        nro_guia.BackColor = Color.White
    End Sub
    Private Sub direccion_pto_partida_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles direccion_pto_partida.Enter
        direccion_pto_partida.BackColor = Color.Moccasin
    End Sub
    Private Sub direccion_pto_partida_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles direccion_pto_partida.Leave
        direccion_pto_partida.BackColor = Color.White
    End Sub
   
    Private Sub Nro_constancia_deposito_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nro_constancia_deposito.Enter
        Nro_constancia_deposito.BackColor = Color.Moccasin
    End Sub
    Private Sub Nro_constancia_deposito_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nro_constancia_deposito.Leave
        Nro_constancia_deposito.BackColor = Color.White
    End Sub
    Private Sub Nro_constancia_deposito2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nro_constancia_deposito2.Enter
        Nro_constancia_deposito2.BackColor = Color.Moccasin
    End Sub
    Private Sub Nro_constancia_deposito2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nro_constancia_deposito2.Leave
        Nro_constancia_deposito2.BackColor = Color.White
    End Sub
    Private Sub Monto_deposito2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Monto_deposito2.Enter
        Monto_deposito2.BackColor = Color.Moccasin
    End Sub
    Private Sub Nro_licencia_conductor_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nro_licencia_conductor.Leave
        Nro_licencia_conductor.BackColor = Color.White
    End Sub
    Private Sub Nro_licencia_conductor_Enter1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nro_licencia_conductor.Enter
        Nro_licencia_conductor.BackColor = Color.Moccasin
    End Sub
    Private Sub serie_guia_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles serie_guia.KeyPress
        SoloNumeros(e, False, sender.Text)
        saltar_ENTER(e)
    End Sub
    Private Sub nro_guia_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nro_guia.KeyPress
        SoloNumeros(e, False, sender.Text)
        saltar_ENTER(e)
    End Sub
    Private Sub fecha_emision_guia_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles fecha_emision_guia.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub fecha_inicio_traslado_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles fecha_inicio_traslado.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub direccion_pto_partida_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles direccion_pto_partida.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub direccion_pto_llegada_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        saltar_ENTER(e)
    End Sub
    Private Sub Nro_constancia_deposito_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Nro_constancia_deposito.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub Monto_deposito_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Monto_deposito.KeyPress
        SoloNumeros(e, True, sender.Text)
        saltar_ENTER(e)
    End Sub
    Private Sub Nro_constancia_deposito2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Nro_constancia_deposito2.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub Monto_deposito2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Monto_deposito2.KeyPress
        SoloNumeros(e, True, sender.Text)
        saltar_ENTER(e)
    End Sub
    Private Sub dgvmotivo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles dgvmotivo.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub cantidad_sacos_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles cantidad_sacos.KeyPress
        SoloNumeros(e, False, sender.Text)
        saltar_ENTER(e)
    End Sub
    Private Sub cantidad_sacos_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cantidad_sacos.Enter
        cantidad_sacos.BackColor = Color.Moccasin
    End Sub
    Private Sub cantidad_sacos_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cantidad_sacos.Leave
        cantidad_sacos.BackColor = Color.White
    End Sub

    Private Sub direccion_pto_llegadaa_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles direccion_pto_llegadaa.Enter
        direccion_pto_llegadaa.BackColor = Color.Moccasin
    End Sub

    Private Sub direccion_pto_llegadaa_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles direccion_pto_llegadaa.KeyDown

    End Sub

    Private Sub direccion_pto_llegadaa_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles direccion_pto_llegadaa.KeyPress
        saltar_ENTER(e)
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub direccion_pto_llegadaa_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles direccion_pto_llegadaa.Leave
        direccion_pto_llegadaa.BackColor = Color.White
    End Sub

    Private Sub TxtPrec_Venta_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPrec_Venta.Enter
        TxtPrec_Venta.BackColor = Color.Moccasin
    End Sub

    Private Sub TxtPrec_Venta_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtPrec_Venta.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub TxtPrec_Venta_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPrec_Venta.Leave
        TxtPrec_Venta.BackColor = Color.White
    End Sub

    Private Sub TxtIGV_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIGV.Enter
        TxtIGV.BackColor = Color.Moccasin
    End Sub

    Private Sub TxtIGV_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtIGV.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub TxtIGV_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIGV.Leave
        TxtIGV.BackColor = Color.White
    End Sub

   
    Private Sub TxtIGV_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIGV.TextChanged

    End Sub
End Class
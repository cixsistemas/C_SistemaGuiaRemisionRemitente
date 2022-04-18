Public Class FrmPago_Detra1
    Public id_PAGO As Integer = -1
    Public id_CATEGORIA As Integer = -1
    Public id_det_PAGO_ As Integer = -1
    Public id_remitente As Integer = -1
    Public Aceptar As Boolean
    Private operacion As String = ""
    Private INDICE2 As Integer = -1

    

    Private Sub FrmPago_Detra1_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmPago_Detra1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub


    Private Sub FrmPago_Detra1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()

      
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAgregar.Click

        If operacion = "" Then
            MessageBox.Show("Seleccione nuevo ó editar.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim ok As Boolean
        ok = id_CATEGORIA <> -1
        If ok = False Then
            MessageBox.Show("Haga click en buscar Categoria.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' btnnuevo_examen.Focus()
            btnCategoria.Focus()
            Exit Sub
        End If

        ok = txtprecio.Text.Trim <> "" And Val(txtprecio.Text.Trim) > 0
        If ok = False Then
            MessageBox.Show("Ingrese Precio.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtprecio.Focus()
            Exit Sub
        End If

        ok = cantidad_sacos.Text.Trim <> "" And Val(cantidad_sacos.Text.Trim) > 0
        If ok = False Then
            MessageBox.Show("Ingrese Cantidad sacos Producto.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cantidad_sacos.Focus()
            Exit Sub
        End If

        If operacion = "N" Then
            Detalle_Cat.Rows.Add()
            Detalle_Cat.Item("id_det_Pago", Detalle_Cat.Rows.Count - 1).Value = "-1"
            Detalle_Cat.Item("id_cat", Detalle_Cat.Rows.Count - 1).Value = id_CATEGORIA
            Detalle_Cat.Item("sacos_cantidad", Detalle_Cat.Rows.Count - 1).Value = Val(cantidad_sacos.Text.Trim)
            Detalle_Cat.Item("Descripcion", Detalle_Cat.Rows.Count - 1).Value = NombreCATEGORIA.Text.Trim
            Detalle_Cat.Item("Precio", Detalle_Cat.Rows.Count - 1).Value = Val(txtprecio.Text.Trim)
            Detalle_Cat.Item("Ivap", Detalle_Cat.Rows.Count - 1).Value = Val(txtivap.Text.Trim)
            Detalle_Cat.Item("Total", Detalle_Cat.Rows.Count - 1).Value = Val(cantidad_sacos.Text.Trim) * Val(txtprecio.Text.Trim) * Val(txtivap.Text.Trim)
            'Me.LblTotal.Text = CDbl(Me.LblTotal.Text) + Detalle.Item("Peso", Detalle.Rows.Count - 1).Value

        ElseIf operacion = "M" Then

            
            'Detalle_Cat.Item("id_det_Pago", indice).Value = id_det_PAGO_
            Detalle_Cat.Item("id_det_Pago", INDICE2).Value = id_det_PAGO_
            Detalle_Cat.Item("id_cat", INDICE2).Value = txtIdCat.Text 'Me.id_CATEGORIA
            Detalle_Cat.Item("sacos_cantidad", INDICE2).Value = CInt(cantidad_sacos.Text.Trim)
            Detalle_Cat.Item("Descripcion", INDICE2).Value = CStr(NombreCATEGORIA.Text.Trim)
            Detalle_Cat.Item("Precio", INDICE2).Value = CDbl(txtprecio.Text.Trim)
            Detalle_Cat.Item("Ivap", INDICE2).Value = CDbl(txtivap.Text.Trim)
            Detalle_Cat.Item("Total", INDICE2).Value = CDbl(cantidad_sacos.Text.Trim) * CDbl(txtprecio.Text.Trim) * CDbl(txtivap.Text.Trim)
            'Me.LblTotal.Text = CDbl(Me.LblTotal.Text) + Detalle.Item("Peso", Detalle.Rows.Count - 1).Value


        End If

        limpiaproducto()
        activar2(False)
        operacion = ""
        INDICE2 = -1

        btnnuevo_examen.Focus()
    End Sub
    Public Sub limpiaproducto()
        id_det_PAGO_ = -1
        NombreCATEGORIA.Text = ""
        id_CATEGORIA = -1
        txtprecio.Text = ""
        cantidad_sacos.Text = ""
    End Sub

    Private Sub btnnuevo_examen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnnuevo_examen.Click
        operacion = "N"
        indice = -1
        activar2(True)

        btnCategoria.Focus()
    End Sub
    Private Sub btnRemitente_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemitente.Click
        Try
            Dim f As New frmListarRemitentes
            f.ShowDialog()
            If indice <> -1 Then
                id_remitente = CInt(f.dgvlista.Item("Id", indice).Value)
                Dim strremitente As String = ""
                strremitente = CStr(f.dgvlista.Item("Remitente", indice).Value.ToString.Trim)
                remitente.Text = strremitente.Trim
                ruc.Text = CStr(f.dgvlista.Item("RUC", indice).Value.ToString.Trim)
                cuenta.Text = CStr(f.dgvlista.Item("Cuenta Detraccion", indice).Value.ToString.Trim)
                indice = -1
            Else
                remitente.Text = ""
                ruc.Text = ""
                cuenta.Text = ""
                indice = -1
                id_remitente = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        btnnuevo_examen.Focus()
        ' fecha_emision_guia.Focus()

       

    End Sub
    Private Sub btnCategoria_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCategoria.Click
        Try
            Dim f As New FrmListarCat
            f.ShowDialog()
            If indice <> -1 Then
                id_CATEGORIA = CInt(f.dgvlista.Item("ID", indice).Value)
                txtIdCat.Text = CInt(f.dgvlista.Item("ID", indice).Value)
                Dim strCATEGORIA As String = ""
                strCATEGORIA = CStr(f.dgvlista.Item("Nombre Categoria", indice).Value.ToString.Trim)
                NombreCATEGORIA.Text = strCATEGORIA.Trim
                ' Me.ruc.Text = CStr(f.dgvlista.Item("ruc", indice).Value.ToString.Trim)
                indice = -1
            Else
                NombreCATEGORIA.Text = ""
                ' Me.ruc.Text = ""
                indice = -1
                id_CATEGORIA = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        txtprecio.Focus()


        Try
            If NombreCATEGORIA.Text = "SUPERIOR" Then
                cantidad_sacos.Text = txtTot_Sup.Text
            ElseIf NombreCATEGORIA.Text = "DESPUNTADO" Then
                cantidad_sacos.Text = txtDespTotal.Text
            ElseIf NombreCATEGORIA.Text = "EXTRA" Then
                cantidad_sacos.Text = txtTot_Ext.Text
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnaceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnaceptar.Click

        Dim ok As Boolean

        ok = Detalle_Cat.Rows.Count <> 0
        If (ok = False) Then
            MessageBox.Show("Seleccione Categorias por favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnnuevo_examen.Focus()
            Exit Sub
        End If

        Aceptar = True
        Hide()

    End Sub
    Private Sub Detalle_Cat_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles Detalle_Cat.CellClick
        INDICE2 = e.RowIndex
    End Sub

    Private Sub Detalle_Cat_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles Detalle_Cat.RowsAdded
        btnquitar_hpm.Enabled = CBool(IIf(Detalle_Cat.Rows.Count > 0, True, False))
        btneditar_hpm.Enabled = CBool(IIf(Detalle_Cat.Rows.Count > 0, True, False))
    End Sub

    Private Sub Detalle_Cat_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles Detalle_Cat.RowsRemoved
        btnquitar_hpm.Enabled = CBool(IIf(Detalle_Cat.Rows.Count > 0, True, False))
        btneditar_hpm.Enabled = CBool(IIf(Detalle_Cat.Rows.Count > 0, True, False))
    End Sub

    Private Sub Detalle_Cat_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Detalle_Cat.VisibleChanged
        btnquitar_hpm.Enabled = CBool(IIf(Detalle_Cat.Rows.Count > 0, True, False))
        btneditar_hpm.Enabled = CBool(IIf(Detalle_Cat.Rows.Count > 0, True, False))
    End Sub

    Private Sub activar2(ByVal activa As Boolean)
        btnCategoria.Enabled = activa
        cantidad_sacos.Enabled = activa
        txtprecio.Enabled = activa
        txtivap.Enabled = activa
        btnAgregar.Enabled = activa
    End Sub
    Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub

    Private Sub btneditar_hpm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btneditar_hpm.Click

       
        Try
            id_det_PAGO_ = CInt(Detalle_Cat.Item("id_det_pago", INDICE2).Value)
            id_CATEGORIA = CInt(Detalle_Cat.Item("id_cat", INDICE2).Value)
            NombreCATEGORIA.Text = CStr(Detalle_Cat.Item("Descripcion", INDICE2).Value)
            txtprecio.Text = CDbl(Detalle_Cat.Item("precio", INDICE2).Value)
            cantidad_sacos.Text = CStr(Detalle_Cat.Item("sacos_cantidad", INDICE2).Value)
            txtivap.Text = CStr(Detalle_Cat.Item("Ivap", INDICE2).Value)
            'Me.LblTotal.Text = CDbl(Me.LblTotal.Text) - Detalle.Item("Peso", Detalle.Rows.Count - 1).Value
            activar2(True)
            operacion = "M"
        Catch ex As Exception
            If indice = -1 Then
                MessageBox.Show("Seleccione Categoria para editarlo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End Try
       

    End Sub
    Private Sub btnquitar_hpm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnquitar_hpm.Click
        If check_fila_grilla(Detalle_Cat) = False Then
            MessageBox.Show("Haga check en la columna Seleccionar por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            quitar_fila_grilla(Detalle_Cat, "Seleccionar", "Detalle de Guia no se puede quitar. Solo se pueden quitar elementos agregados recientemente.")
        End If
        ' Me.LblTotal.Text = CDbl(Me.LblTotal.Text) - Detalle.Item("Peso", Detalle.Rows.Count - 1).Value
        operacion = ""
        indice = -1
    End Sub
    Private Sub fecha_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles fecha.KeyPress
        saltar_ENTER(e)

    End Sub

    Private Sub txtDescripcion_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtDescripcion.Enter
        txtDescripcion.BackColor = Color.Moccasin
    End Sub
    Private Sub txtDescripcion_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtDescripcion.Leave
        txtDescripcion.BackColor = Color.White
    End Sub
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        saltar_ENTER(e)

    End Sub
    Private Sub cantidad_sacos_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles cantidad_sacos.Leave
        cantidad_sacos.BackColor = Color.White
    End Sub
    Private Sub cantidad_sacos_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles cantidad_sacos.Enter
        cantidad_sacos.BackColor = Color.Moccasin
    End Sub

    Private Sub cantidad_sacos_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles cantidad_sacos.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub

    Private Sub txtivap_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtivap.Enter
        txtivap.BackColor = Color.Moccasin
    End Sub
    Private Sub txtivap_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtivap.Leave
        txtivap.BackColor = Color.White
    End Sub
    Private Sub txtivap_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtivap.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub txtprecio_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtprecio.Enter
        txtprecio.BackColor = Color.Moccasin
    End Sub
    Private Sub txtprecio_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtprecio.Leave
        txtprecio.BackColor = Color.White
    End Sub
    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtprecio.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
#Region "SUMA DE SUPERIOR"

    Private Sub txtTot_Sup_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtTot_Sup.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Up Then
            SendKeys.Send("+{TAB}")
        End If
    End Sub

    Private Sub txtTot_Sup_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtTot_Sup.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
    Private Sub txtTot_Sup_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTot_Sup.TextChanged
        txtTot_Sup.Text = Val(txtsup1.Text) + Val(txtsup2.Text) + Val(txtsup3.Text) + Val(txtsup4.Text) + Val(txtsup5.Text)
        txt_TOTAL.Text = Val(txtTot_Ext.Text) + Val(txtTot_Sup.Text) + Val(txtDespTotal.Text)
    End Sub

    Private Sub txtsup1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtsup1.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            'ElseIf e.KeyData = Keys.Up Then
            '    SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtsup1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtsup1.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
    Private Sub txtsup1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtsup1.TextChanged
        txtTot_Sup.Text = Val(txtsup1.Text) + Val(txtsup2.Text) + Val(txtsup3.Text) + Val(txtsup4.Text) + Val(txtsup5.Text)
    End Sub

    Private Sub txtsup2_KeyDown1(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtsup2.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtsup2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtsup2.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
    Private Sub txtsup2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtsup2.TextChanged
        txtTot_Sup.Text = Val(txtsup1.Text) + Val(txtsup2.Text) + Val(txtsup3.Text) + Val(txtsup4.Text) + Val(txtsup5.Text)
    End Sub

    Private Sub txtsup3_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtsup3.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtsup3_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtsup3.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
    Private Sub txtsup3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtsup3.TextChanged
        txtTot_Sup.Text = Val(txtsup1.Text) + Val(txtsup2.Text) + Val(txtsup3.Text) + Val(txtsup4.Text) + Val(txtsup5.Text)
    End Sub

    Private Sub txtsup4_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtsup4.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtsup4_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtsup4.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
    Private Sub txtsup4_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtsup4.TextChanged
        txtTot_Sup.Text = Val(txtsup1.Text) + Val(txtsup2.Text) + Val(txtsup3.Text) + Val(txtsup4.Text) + Val(txtsup5.Text)
    End Sub

    Private Sub txtsup5_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtsup5.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtsup5_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtsup5.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
    Private Sub txtsup5_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtsup5.TextChanged
        txtTot_Sup.Text = Val(txtsup1.Text) + Val(txtsup2.Text) + Val(txtsup3.Text) + Val(txtsup4.Text) + Val(txtsup5.Text)
    End Sub
#End Region

#Region "SUMA DE DESPUNTADO"

    Private Sub txtDespTotal_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtDespTotal.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtDespTotal_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtDespTotal.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub

    Private Sub txtDespTotal_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDespTotal.TextChanged
        txtDespTotal.Text = Val(txtdesp1.Text) + Val(txtdesp2.Text) + Val(txtdesp3.Text) + Val(txtdesp4.Text) + Val(txtdesp5.Text)
        txt_TOTAL.Text = Val(txtTot_Ext.Text) + Val(txtTot_Sup.Text) + Val(txtDespTotal.Text)
    End Sub

    Private Sub txtdesp1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtdesp1.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtdesp1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdesp1.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
    Private Sub txtdesp1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtdesp1.TextChanged
        txtDespTotal.Text = Val(txtdesp1.Text) + Val(txtdesp2.Text) + Val(txtdesp3.Text) + Val(txtdesp4.Text) + Val(txtdesp5.Text)
    End Sub

    Private Sub txtdesp2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtdesp2.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtdesp2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdesp2.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
    Private Sub txtdesp2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtdesp2.TextChanged
        txtDespTotal.Text = Val(txtdesp1.Text) + Val(txtdesp2.Text) + Val(txtdesp3.Text) + Val(txtdesp4.Text) + Val(txtdesp5.Text)
    End Sub

    Private Sub txtdesp3_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtdesp3.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtdesp3_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdesp3.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
    Private Sub txtdesp3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtdesp3.TextChanged
        txtDespTotal.Text = Val(txtdesp1.Text) + Val(txtdesp2.Text) + Val(txtdesp3.Text) + Val(txtdesp4.Text) + Val(txtdesp5.Text)
    End Sub

    Private Sub txtdesp4_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtdesp4.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtdesp4_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdesp4.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub

    Private Sub txtdesp4_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtdesp4.TextChanged
        txtDespTotal.Text = Val(txtdesp1.Text) + Val(txtdesp2.Text) + Val(txtdesp3.Text) + Val(txtdesp4.Text) + Val(txtdesp5.Text)
    End Sub

    Private Sub txtdesp5_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtdesp5.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtdesp5_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdesp5.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub

    Private Sub txtdesp5_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtdesp5.TextChanged
        txtDespTotal.Text = Val(txtdesp1.Text) + Val(txtdesp2.Text) + Val(txtdesp3.Text) + Val(txtdesp4.Text) + Val(txtdesp5.Text)
    End Sub
#End Region

#Region "SUMA DE EXTRA"

    Private Sub txtExt1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtExt1.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtExt1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtExt1.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
    Private Sub txtExt1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtExt1.TextChanged
        txtTot_Ext.Text = Val(txtExt1.Text) + Val(txtExt2.Text) + Val(txtExt3.Text) + Val(txtExt4.Text)
        txt_TOTAL.Text = Val(txtTot_Ext.Text) + Val(txtTot_Sup.Text) + Val(txtDespTotal.Text)
    End Sub

    Private Sub txtExt2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtExt2.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtExt2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtExt2.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub

    Private Sub txtExt2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtExt2.TextChanged
        txtTot_Ext.Text = Val(txtExt1.Text) + Val(txtExt2.Text) + Val(txtExt3.Text) + Val(txtExt4.Text)
    End Sub

    Private Sub txtExt3_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtExt3.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtExt3_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtExt3.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub

    Private Sub txtExt3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtExt3.TextChanged
        txtTot_Ext.Text = Val(txtExt1.Text) + Val(txtExt2.Text) + Val(txtExt3.Text) + Val(txtExt4.Text)
    End Sub

    Private Sub txtExt4_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtExt4.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtExt4_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtExt4.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub

    Private Sub txtExt4_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtExt4.TextChanged
        txtTot_Ext.Text = Val(txtExt1.Text) + Val(txtExt2.Text) + Val(txtExt3.Text) + Val(txtExt4.Text)
    End Sub

    Private Sub txtTot_Ext_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtTot_Ext.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtTot_Ext_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtTot_Ext.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
    Private Sub txtTot_Ext_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTot_Ext.TextChanged
        txtTot_Ext.Text = Val(txtExt1.Text) + Val(txtExt2.Text) + Val(txtExt3.Text) + Val(txtExt4.Text)
        txt_TOTAL.Text = Val(txtTot_Ext.Text) + Val(txtTot_Sup.Text) + Val(txtDespTotal.Text)
    End Sub
#End Region

    Private Sub txt_TOTAL_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_TOTAL.KeyPress
        saltar_ENTER(e)
        SoloNumeros(e, False, sender.Text)
    End Sub

    
    Private Sub txt_TOTAL_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txt_TOTAL.TextChanged
        txt_TOTAL.Text = Val(txtTot_Ext.Text) + Val(txtTot_Sup.Text) + Val(txtDespTotal.Text)
    End Sub

  
    Private Sub btnCALC_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCALC.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "CALC.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub BTN_PAGINA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTN_PAGINA.Click
        Process.Start("http://www.minagri.gob.pe/portal/boletin-de-arroz/arroz-2018")
    End Sub

    Private Sub Fecha_Emis_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Fecha_Emis.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub Detalle_Cat_Leave(sender As Object, e As EventArgs) Handles Detalle_Cat.Leave
        'If CInt(Detalle_Cat.Item("id_cat", indice).Value) = "" Then
        '    Dim f As New FrmListarCat
        '    f.ShowDialog()
        '    ' CInt(Detalle_Cat.Item("id_cat", indice).Value) = CInt(f.dgvlista.Item("ID", indice).Value)
        'End If


    End Sub

    Private Sub Detalle_Cat_Enter(sender As Object, e As EventArgs) Handles Detalle_Cat.Enter
        'If CInt(Detalle_Cat.Item("id_cat", indice).Value) = "" Then
        '    Dim f As New FrmListarCat
        '    f.ShowDialog()
        '    ' CInt(Detalle_Cat.Item("id_cat", indice).Value) = CInt(f.dgvlista.Item("ID", indice).Value)
        'End If
    End Sub
End Class

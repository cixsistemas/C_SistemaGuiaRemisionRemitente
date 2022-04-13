Public Class FrmIng_Comp2
    Public id_ing_Comp As Integer
    ' Public id_ubigeo As Integer = -1
    Public Aceptar As Boolean = False
    Public Nivel As String = ""
    Public id_remitente As Integer = -1
    Public id_ope As Integer = -1
    Public id_tipo_Comp As Integer = -1
    Dim Opc As String = "Nuevo"
    Dim T As Integer
    Dim i As Integer
    Private Sub FrmIng_Comp2_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmIng_Comp2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmIng_Comp2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        ' saltar_Flechas()
    End Sub

    Private Sub FrmIng_Comp2_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As System.EventArgs) Handles btnAgregar.Click

        Dim ok As Boolean

        ok = id_remitente <> -1
        If ok = False Then
            MessageBox.Show("Seleccione Remitente, por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnremitente.Focus()
            Exit Sub
        End If


        ok = id_ope <> -1
        If ok = False Then
            MessageBox.Show("Seleccione en Operacion, por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnOperacion.Focus()
            Exit Sub
        End If

        ok = id_tipo_Comp <> -1
        If ok = False Then
            MessageBox.Show("Seleccione Tipo de Comprobante, por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnTipoComp.Focus()
            Exit Sub
        End If

        ok = TxtSerie.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Serie de Comprobante, por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtSerie.Focus()
            Exit Sub
        End If

        ok = TxtNumero.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Numero de Comprobante por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtNumero.Focus()
            Exit Sub
        End If

        ok = TxtNumero2.Text <> ""
        If (ok = False) Then
            MessageBox.Show("Ingrese Numero de Comprobante por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtNumero2.Focus()
            Exit Sub
        End If

        If TxtNumero2.Text < TxtNumero.Text Then
            MessageBox.Show("Hasta debe ser Mayor a Desde.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtNumero2.Focus()
        End If

        Select Case Opc

            Case "Nuevo"
                'ok = False
                'For i As Integer = 0 To Me.dgvlista.Rows.Count - 1
                '    If dgvlista.Item("IDBIEN", i).Value.ToString Like Me.Txtid_bien.Text.Trim Then
                '        ok = True
                '    End If
                'Next

                'If ok = True Then
                '    MessageBox.Show("Materia prima ya existe en la lista", "Sistema de inventarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Exit Sub
                'End If

                T = TxtNumero2.Text
                For i = TxtNumero.Text To T
                    dgvlista.Rows.Add()
                    dgvlista.Item("IDDETALLEINGCOMP", dgvlista.Rows.Count - 1).Value = -1
                    'dgvlista.Item("IDDETALLEINGCOMP", dgvlista.Rows.Count - 1).Value = Me.id_remitente
                    dgvlista.Item("C", dgvlista.Rows.Count - 1).Value = TxtSerie.Text
                    'dgvlista.Item("C", dgvlista.Rows.Count - 1).Value = dgvlista.Text & T & " * " & i & " = " & T * i & vbCrLf
                    dgvlista.Item("D", dgvlista.Rows.Count - 1).Value = i
                    dgvlista.Item("G", dgvlista.Rows.Count - 1).Value = "ACTIVO"
                    'dgvlista.Text = dgvlista.Text & T & " * " & i & " = " & T * i & vbCrLf
                    ' labeltabla.Text = T = T * i & vbCrLf
                Next i

                

                'Case "Editar"

                '    dgvlista.Item("IDINGCOMP", indice).Value = id_ing_Comp
                '    dgvlista.Item("IDREMITENTE", indice).Value = Me.id_remitente
                '    dgvlista.Item("IDOPE", indice).Value = Me.id_ope
                '    dgvlista.Item("IDTIPOCOMP", indice).Value = Me.id_tipo_Comp
                '    dgvlista.Item("A", indice).Value = (Me.NombreRemitente.Text)
                '    dgvlista.Item("B", indice).Value = (Me.TxtTipoComp.Text)
                '    dgvlista.Item("C", indice).Value = Me.TxtSerie.Text
                '    'dgvlista.Item("C", dgvlista.Rows.Count - 1).Value = dgvlista.Text & T & " * " & i & " = " & T * i & vbCrLf
                '    dgvlista.Item("D", indice).Value = i
                '    dgvlista.Item("E", indice).Value = (Me.Fecha_Ingreso.Value.Date)
                '    dgvlista.Item("G", indice).Value = (Me.CbEstado.Text)
                '    dgvlista.Item("F", indice).Value = Me.txtDescrip.Text.Trim
                '    dgvlista.Item("H", indice).Value = Me.TxtOpe.Text.Trim
                '    Me.Opc = "Nuevo"

        End Select

      
        TxtSerie.Text = ""
        TxtNumero.Text = ""
        TxtNumero2.Text = ""
        MessageBox.Show("Comprobantes se han cargado correctamente", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ' ' dgvlista.DataSource = Nothing
        '   ' dgvlista.Refresh()
        indice = -1
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As System.EventArgs) Handles btnEditar.Click
        If indice = -1 Then
            MessageBox.Show("Seleccione fila por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            'Me.Txtid_bien.Text = dgvlista.Item("IDBIEN", indice).Value.ToString()
            NombreRemitente.Text = CStr(dgvlista.Item("A", indice).Value.ToString())
            TxtTipoComp.Text = CStr(dgvlista.Item("B", indice).Value.ToString())
            TxtSerie.Text = CStr(dgvlista.Item("C", indice).Value.ToString().Replace(",", "."))
            TxtNumero.Text = CStr(dgvlista.Item("D", indice).Value.ToString().Replace(",", "."))
            Fecha_Ingreso.Value = CDate(dgvlista.Item("E", indice).Value.ToString())
            ' Me.CbEstado.Text = dgvlista.Item("G", indice).Value.ToString()
            txtDescrip.Text = dgvlista.Item("F", indice).Value.ToString()
            TxtOpe.Text = dgvlista.Item("H", indice).Value.ToString()
            'Me.Uni_Med.Text = dgvlista.Item("G", indice).Value.ToString()
            'Me.CboEnvase.Text = dgvlista.Item("K", indice).Value.ToString()


        End If

        Opc = "Editar"
    End Sub
    Private Sub btnQuitar_Click(sender As Object, e As System.EventArgs) Handles btnQuitar.Click
        Try
            dgvlista.Rows.Remove(dgvlista.CurrentRow)
        Catch ex As Exception
            MessageBox.Show("No hay Registro para quitar", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


        'If check_fila_grilla(dgvlista) = False Then
        '    MessageBox.Show("Seleccione registro", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'Else
        '    ' Me.dgvlista.Rows.Remove(Me.dgvlista.CurrentRow)
        '    quitar_fila_grilla(dgvlista, "SELECCIONAR", "Solo se Puede quitar registros ingresados recientemente")
        'End If
    End Sub
    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub

    Private Sub btnremitente_Click(sender As Object, e As System.EventArgs) Handles btnremitente.Click
        Try
            Dim f As New frmListarRemitentes
            f.ShowDialog()
            If indice >= 0 Then
                id_remitente = CInt(f.dgvlista.Item("ID", indice).Value)
                NombreRemitente.Text = CStr(f.dgvlista.Item("Remitente", indice).Value.ToString.Trim)
            End If
        Catch ex As Exception
            'If Me.NombreRemitente.Text <> "" Then
            '    MessageBox.Show("Seleccione Remitente por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If
        End Try
        indice = -1
        BtnOperacion.Focus()
    End Sub

    Private Sub BtnOperacion_Click(sender As Object, e As System.EventArgs) Handles BtnOperacion.Click
        Try
            Dim f As New FrmListar_Operacion_Ent
            ' Dim f As New FrmProveedor_1
            f.ShowDialog()

            If indice >= 0 Then
                id_ope = CInt(f.dgvlista.Item("Id Operacion", indice).Value)
                TxtOpe.Text = CStr(f.dgvlista.Item("Operacion", indice).Value.ToString.Trim)
                TxtTipoOperac.Text = CStr(f.dgvlista.Item("Tipo de Operacion", indice).Value.ToString.Trim)
            End If
        Catch ex As Exception
            'If Me.TxtOpe.Text <> "" And TxtTipoOperac.Text <> "" Then
            '    MessageBox.Show("Seleccione Operacion por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If

        End Try
        indice = -1
       
        BtnTipoComp.Focus()
    End Sub
    Private Sub BtnTipoComp_Click(sender As Object, e As System.EventArgs) Handles BtnTipoComp.Click
        Try
            Dim f As New FrmListar_Tipo_Comp
            ' Dim f As New FrmProveedor_1
            f.ShowDialog()

            If indice >= 0 Then

                id_tipo_Comp = CInt(f.DgvLista.Item("Id Tipo de Comprobante", indice).Value)
                TxtTipoComp.Text = CStr(f.DgvLista.Item("Tipo de Comprobante", indice).Value.ToString.Trim)
                'If Me.id_Personaa.Text = "" Then
                '    MessageBox.Show("Seleccione Proveedor por favor", "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        Catch ex As Exception
            'If Me.id_Personaa.Text <> "" And NOMBRE_CLIENTE_PROVEEDOR.Text <> "" Then
            '    MessageBox.Show("Seleccione Proveedor por favor", "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' End If
            ' BtnProv.Focus()
            '  End If
        End Try
        indice = -1

        TxtSerie.Focus()
    End Sub
    Private Sub BtnOperacion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnOperacion.Leave
        If TxtOpe.Text = "" And TxtOpe.Text = "" Then
            MessageBox.Show("Busque o Seleccione Operacion por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnOperacion.Focus()
        End If

    End Sub

    Private Sub btnremitente_Leave(sender As Object, e As System.EventArgs) Handles btnremitente.Leave
        If NombreRemitente.Text = "" Then
            MessageBox.Show("Busque o Seleccione Remitente por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnremitente.Focus()
        End If
    End Sub

 
    Private Sub BtnTipoComp_Leave(sender As Object, e As System.EventArgs) Handles BtnTipoComp.Leave
        If TxtTipoComp.Text = "" Then
            MessageBox.Show("Busque o Seleccione Tipo de Comprobante de Pago por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnTipoComp.Focus()
        End If
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As System.EventArgs) Handles btnaceptar.Click
        Dim ok As Boolean

        ok = dgvlista.Rows.Count > 0
        If ok = False Then
            MessageBox.Show("Registre el Ingreso de Tipo de Comprobantes de Pago, por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Aceptar = True
        'Hide()


        If MessageBox.Show("¿DESEA " + IIf(Nivel = "N", "GUARDAR ", "MODIFICAR ") + " Ingreso de Comprobantes de Pago?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ' If MessageBox.Show("¿Desea Guardar MAteria Prima?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                Dim RPTA_DOC As Integer = -1
                Dim MSG_DOC As String = ""
                servidor.ejecutar("[dbo].[pa_mantenimiento_Ingreso_Comp_de_Pago]", _
                False, _
                RPTA_DOC, _
                MSG_DOC, _
                id_ing_Comp, _
                CDate(Fecha_Ingreso.Value.ToShortDateString), _
                txtDescrip.Text.Trim, _
                id_remitente, _
                 id_ope, _
                id_tipo_Comp, _
                Nivel.Trim, _
                0, "")

                If RPTA_DOC > 0 Then
                    Dim RPTA_DET_DOC As Integer = -1
                    Dim MSG_DET_DOC As String = ""
                    For i As Integer = 0 To dgvlista.Rows.Count - 1
                        servidor.ejecutar("[dbo].[pa_mantenimiento_Detalle_Ingreso_Comp_de_Pago]", _
                        False, _
                        RPTA_DET_DOC, _
                        MSG_DET_DOC, _
                          CInt(dgvlista.Item("IDDETALLEINGCOMP", i).Value.ToString()), _
                            CStr(dgvlista.Item("C", i).Value.ToString()), _
                            CStr(dgvlista.Item("D", i).Value.ToString()), _
                             CStr(dgvlista.Item("G", i).Value.ToString()), _
                            IIf(Nivel = "N", RPTA_DOC, id_ing_Comp), _
                        Nivel.Trim, _
                        0, "")
                    Next
                    If RPTA_DET_DOC > 0 Then
                        servidor.cerrarconexiontrans()
                        __mesajeerror = MSG_DET_DOC
                        MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Hide()
                    Else
                        servidor.cancelarconexiontrans()
                        __mesajeerror = MSG_DET_DOC
                        MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    servidor.cancelarconexiontrans()
                    __mesajeerror = MSG_DOC
                    MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexiontrans()
                MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If


       

        'Me.id_remitente = -1
        'Me.NombreRemitente.Text = ""
        'id_ope = -1
        'id_tipo_Comp = -1
        ''Me.Cantidad.Text = "0"
        'Me.TxtTipoComp.Text = ""
        'Me.TxtTipoOperac.Text = ""
        'Me.TxtOpe.Text = ""
        'TxtSerie.Text = ""
        'TxtNumero.Text = ""
        'TxtNumero2.Text = ""
        'dgvlista.DataSource = Nothing
        'dgvlista.Refresh()
        'indice = -1
    End Sub

#Region "TextBox"
    Private Sub TxtSerie_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSerie.Enter
        TxtSerie.BackColor = Color.Moccasin
    End Sub

    Private Sub TxtSerie_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtSerie.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub TxtSerie_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtSerie.KeyPress
        SoloNumeros(e, False, sender.Text)
        saltar_ENTER(e)
    End Sub
    Private Sub TxtSerie_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSerie.Leave
        'If TxtSerie.Text = "" Then
        '    MessageBox.Show("Ingrese Número Serie por favor.", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    TxtSerie.Focus()
        'Else
        '    TxtSerie.Text = Format(CType(Me.TxtSerie.Text, Decimal), "000")
        'End If
        TxtSerie.BackColor = Color.White
    End Sub
    Private Sub TxtNumero_Enter(sender As Object, e As System.EventArgs) Handles TxtNumero.Enter
        TxtNumero.BackColor = Color.Moccasin
    End Sub

    Private Sub TxtNumero_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNumero.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub TxtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumero.KeyPress
        SoloNumeros(e, False, sender.Text)
        saltar_ENTER(e)
    End Sub

    Private Sub TxtNumero_Leave(sender As Object, e As System.EventArgs) Handles TxtNumero.Leave
        TxtNumero.BackColor = Color.White
    End Sub

    Private Sub TxtNumero2_Enter(sender As Object, e As System.EventArgs) Handles TxtNumero2.Enter
        TxtNumero2.BackColor = Color.Moccasin
    End Sub

    Private Sub TxtNumero2_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNumero2.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub TxtNumero2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumero2.KeyPress
        SoloNumeros(e, False, sender.Text)
        saltar_ENTER(e)
    End Sub

    Private Sub TxtNumero2_Leave(sender As Object, e As System.EventArgs) Handles TxtNumero2.Leave
        TxtNumero2.BackColor = Color.White
    End Sub

    Private Sub Fecha_Ingreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Fecha_Ingreso.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub CbEstado_KeyPress(sender As Object, e As KeyPressEventArgs)
        saltar_ENTER(e)
    End Sub

    Private Sub txtDescrip_Enter(sender As Object, e As System.EventArgs) Handles txtDescrip.Enter
        txtDescrip.BackColor = Color.Moccasin
    End Sub

    Private Sub txtDescrip_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescrip.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtDescrip_Leave(sender As Object, e As System.EventArgs) Handles txtDescrip.Leave
        txtDescrip.BackColor = Color.White
    End Sub
    Private Sub txtDescrip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescrip.KeyPress
        saltar_ENTER(e)
    End Sub
#End Region

  
    Private Sub btncancelar_Click(sender As Object, e As System.EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub

   
    Private Sub btneliminar_Click(sender As Object, e As System.EventArgs) Handles btneliminar.Click

        Try
            If check_fila_grilla(dgvlista) = False Then
                MessageBox.Show("Seleccione registro", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                '    'Verificamos el stock de la materia prima
                '    'If _OPERACION_DOC = "SALIDA" Then 'ENTRADA, SALIDA.
                'ElseIf TxtTipoOperac.Text = "ENTRADA" Then 'ENTRADA, SALIDA.
                '    '    If (Verificar_Stock_Bien(CInt(Txtid_bien.Text), CInt(Cantidad.Text)) = False) Then
                '    '        MessageBox.Show("Cantidad ingresada supera al stock de la materia prima.", "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    '        Exit Sub
                '    '    End If
                '    'End If

                'APARECE ERRORRRRRRRR
                For i As Integer = 0 To dgvlista.Rows.Count - 1
                    If CBool(dgvlista.Item(0, i).Value) = True Then
                        Dim id As Integer = CInt(dgvlista.Item("IDDETALLEINGCOMP", i).Value.ToString())
                        If id = -1 Then
                            MessageBox.Show("Registro no se puede eliminar.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        Else

                            If MessageBox.Show("¿DESEA ELIMINAR INGRESO DE DETALLE DE COMPROBANTTES DE PAGO?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                                Dim servidor As New clinicapacifico.clsaccesodatos

                                servidor.cadenaconexion = Ruta

                                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                                    Dim RPTA_RET As Integer = -1

                                    Dim MSG_RET As String = ""

                                    servidor.ejecutar("[dbo].[pa_mantenimiento_Detalle_Ingreso_Comp_de_Pago]", _
                                    False, _
                                    RPTA_RET, _
                                    MSG_RET, _
                                     CInt(dgvlista.Item("IDDETALLEINGCOMP", i).Value.ToString), _
                              Nothing, _
                              Nothing, _
                              Nothing, _
                              Nothing, _
                                    "E", _
                                    0, "")

                                    If RPTA_RET > 0 Then

                                        servidor.cerrarconexiontrans()

                                        __mesajeerror = MSG_RET

                                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                        quitar_fila_grilla2(dgvlista, "SELECCIONAR")

                                    Else

                                        servidor.cancelarconexiontrans()

                                        __mesajeerror = MSG_RET

                                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                                    End If

                                Else

                                    __mesajeerror = servidor.getMensageError

                                    servidor.cerrarconexiontrans()

                                    MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                End If

                            End If

                            quitar_check_fila_grilla(dgvlista)

                        End If

                    End If

                Next

            End If
        Catch ex As Exception

        End Try


    End Sub


    Private Sub dgvlista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick

    End Sub

    Private Sub dgvlista_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        Try
            If e.ColumnIndex = 5 Then
                Select Case e.Value
                    Case "COMPROBANTE SIN USAR, AUN EN ALMACEN"
                        e.CellStyle.ForeColor = Color.Blue
                        ' dgvlista.Columns("Valor Venta").DefaultCellStyle.ForeColor = Color.Blue
                    Case "COMPROBANTE USADO O FUERA DE ALMACEN"
                        e.CellStyle.ForeColor = Color.Red
                        ' dgvlista.Columns("Valor Venta").DefaultCellStyle.ForeColor = Color.Red
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
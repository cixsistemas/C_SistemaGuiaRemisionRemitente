Public Class frmguias
    Private formulario As New frmguia
    Dim idguia As Integer
    Dim tabla_guias As DataTable
    Dim tabla_detalle_guias As DataTable

    Public Sub listar_detalle_guias(ByVal idguia As Integer)
        'Me.mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            tabla_detalle_guias = servidor.consultar("[dbo].[pa_listar_detalle_guias]", idguia).Tables(0)
            If tabla_detalle_guias Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Guía de remisión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim NroFilas As Integer = tabla_detalle_guias.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    dgvdetalle.DataSource = tabla_detalle_guias
                Else
                    dgvdetalle.DataSource = tabla_detalle_guias
                    servidor.cerrarconexion()
                    ' Me.mesajeerror.Text = "LA CLINICA EL PACIFICO TIENE " + NroFilas.ToString + " MEDICO(S)"
                End If
                dgvdetalle.Columns("ID Detalle").Visible = False
                dgvdetalle.Columns("ID Guia").Visible = False
                dgvdetalle.Columns("ID Producro").Visible = False
                dgvdetalle.Columns("Numero").Visible = False
                dgvdetalle.Columns("Emisión").Visible = False
                dgvdetalle.Columns("Traslado").Visible = False
                dgvdetalle.Columns("Partida").Visible = False
                dgvdetalle.Columns("ID Partida").Visible = False
                dgvdetalle.Columns("Pto. partida").Visible = False
                dgvdetalle.Columns("ID Destinatario").Visible = False
                dgvdetalle.Columns("Razon social").Visible = False
                dgvdetalle.Columns("Ruc Destinatario").Visible = False
                dgvdetalle.Columns("LLegada").Visible = False
                dgvdetalle.Columns("ID. llegada").Visible = False
                dgvdetalle.Columns("Pto. llegada").Visible = False
                dgvdetalle.Columns("ID Vehiculo").Visible = False
                dgvdetalle.Columns("Marca Camion").Visible = False
                dgvdetalle.Columns("Nro. placa Camion").Visible = False
                dgvdetalle.Columns("Nro. certificado Camion").Visible = False
                dgvdetalle.Columns("Marca Carreta").Visible = False
                dgvdetalle.Columns("Nro. placa Carreta").Visible = False
                dgvdetalle.Columns("Nro. certificado Carreta").Visible = False
                dgvdetalle.Columns("Nro Deposito").Visible = False
                dgvdetalle.Columns("Monto").Visible = False
                dgvdetalle.Columns("Nro Depositoo").Visible = False
                dgvdetalle.Columns("Montoo").Visible = False
                dgvdetalle.Columns("ID Traslado").Visible = False
                dgvdetalle.Columns("Motivo Traslado").Visible = False
                dgvdetalle.Columns("ID Remitente").Visible = False
                dgvdetalle.Columns("Remitente").Visible = False
                dgvdetalle.Columns("ruc").Visible = False
                ' Me.dgvdetalle.Columns("ID Empresa Trasporte").Visible = False
                dgvdetalle.Columns("Empresa Transporte").Visible = False
                dgvdetalle.Columns("RUC Emp Transporte").Visible = False
                dgvdetalle.Columns("Domicilio Transportista").Visible = False
                'Me.dgvdetalle.Columns("descripcion").Visible = False
                dgvdetalle.Columns("pajilla").Visible = False
                dgvdetalle.Columns("ID Chofer").Visible = False
                dgvdetalle.Columns("Brevete").Visible = False
                dgvdetalle.Columns("Chofer").Visible = False
                ' Me.dgvdetalle.Columns("Apellido Chofer").Visible = False
                dgvdetalle.Columns("Telefono Chofer").Visible = False
                dgvdetalle.Columns("Categoria").Visible = False
                dgvdetalle.Columns("Distrito").Visible = False
                dgvdetalle.Columns("Provincia").Visible = False
                dgvdetalle.Columns("Departamento").Visible = False
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Me.dgvdetalle.Columns("cantidad")

    End Sub

    Public Sub listar_guias(ByVal Opcion As String, ByVal Numero As String, ByVal remitente As String)
        'Me.mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            'If servidor.consultar("[dbo].[pa_listar_guias]", Numero, remitente).Tables.Count > 0 Then
            '    tabla_guias = servidor.consultar("[dbo].[pa_listar_guias]", Numero, remitente).Tables(0)
            'End If

            tabla_guias = servidor.consultar("[dbo].[pa_listar_guias]", Opcion, Numero, remitente).Tables(0)
            If tabla_guias Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Guía de remisión-Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim NroFilas As Integer = tabla_guias.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    dgvlista.DataSource = tabla_guias
                    MessageBox.Show("Guía de Remisión, no se encuentra registrada", "Guía de Remisión-Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MessageBox.Show("No hay personas para mostrar", "Persona", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    dgvlista.DataSource = tabla_guias
                    servidor.cerrarconexion()

                    ''POSICIONA CURSOR EN ULTIMA FILA
                    'dgvlista.ClearSelection()
                    'dgvlista.CurrentCell = dgvlista.Rows(dgvlista.RowCount - 1).Cells(1)
                    ''Me.dgvlista.Refresh()

                End If
                dgvlista.Columns("ID").Visible = False
                dgvlista.Columns("ID Partida").Visible = False
                dgvlista.Columns("ID Destinatario").Visible = False
                dgvlista.Columns("ID. llegada").Visible = False
                dgvlista.Columns("ID Vehiculo").Visible = False
                dgvlista.Columns("ID Traslado").Visible = False
                dgvlista.Columns("ID Remitente").Visible = False
                dgvlista.Columns("ruc Destinatario").Visible = False
                'Me.dgvlista.Columns("tipo doc. cliente").Visible = False
                dgvlista.Columns("nro. doc. Destinatario").Visible = False
                'Me.dgvlista.Columns("ID Empresa Trasporte").Visible = False
                dgvlista.Columns("ID Chofer").Visible = False
                ' Me.dgvlista.Columns("ID Chofer").Visible = False
                dgvlista.Columns("Chofer").Visible = False
                dgvlista.Columns("ruc").Visible = False
                dgvlista.Columns("RUC Emp Transporte").Visible = False
                dgvlista.Columns("Domicilio Transportista").Visible = False
                dgvlista.Columns("Empresa Transporte").Visible = False
                dgvlista.Columns("Nro. certificado camion").Visible = False
                dgvlista.Columns("Nro. certificado carreta").Visible = False
                dgvlista.Columns("Marca camion").Visible = False
                dgvlista.Columns("Marca carreta").Visible = False
                dgvlista.Columns("Emisión").DefaultCellStyle.Format = "dd/MM/yyyy"
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        ''POSICIONA CURSOR EN ULTIMA FILA
        'Me.dgvlista.ClearSelection()
        'Me.dgvlista.CurrentCell = Me.dgvlista.Rows(Me.dgvlista.RowCount - 1).Cells(1)
        ''Me.dgvlista.Refresh()
    End Sub

    Private Sub frmguias_KeyDown1(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub


    Private Sub frmguiass_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        REM Obtenenemos la cadena de coneccion al servidor
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        listar_guias("1", "", "")
    End Sub

    'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    '    Dim valor As String = Me.nroguia.Text.Trim
    '    listar_guias(valor)
    'End Sub


    Private Sub btnactualizar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnactualizar.Click
        'ACTUALIZAR DATA GRID
        listar_guias("1", "", "")
        listar_detalle_guias(idguia)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
        '   Me.formulario.lista(7)
        'Me.formulario.direccion_pto_llegadaa.SelectedIndex = 0
        formulario.ShowDialog() 'presentamos formulario.
        If formulario.Aceptar = True Then
            'preguntamos si el usuario quiere o no guardar programación médica.
            If MessageBox.Show("¿Desea guardar Guía de Remisión-Remitente?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                ' asignamos ruta coneccion con el servidor de la base de datos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    'Dim id_mot_traslado As Integer
                    'For i As Integer = 0 To formulario.dgvmotivo.Rows.Count - 1

                    '    If CBool(formulario.dgvmotivo.Item(0, i).Value) = True Then
                    '        id_mot_traslado = CInt(formulario.dgvmotivo.Item(1, i).Value)
                    '        Exit For
                    '    End If
                    'Next

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_cabecera_guia]",
                    False,
                    rpta,
                    mensaje,
                    formulario.id_guia,
                    formulario.serie_guia.Text.Trim,
                    formulario.nro_guia.Text.Trim,
                    formulario.fecha_emision_guia.Value.Date,
                    formulario.fecha_inicio_traslado.Value.Date,
                    formulario.direccion_pto_partida.Text.Trim,
                    formulario.ubigeo_pto_partida,
                    formulario.id_Destinatario,
                    formulario.direccion_pto_llegadaa.Text.Trim,
                    IIf(formulario.ubigeo_pto_llegada = -1, Nothing, formulario.ubigeo_pto_llegada),
                    formulario.id_vehi,
                    formulario.id_chofer,
                    formulario.Nro_constancia_deposito.Text.Trim,
                    formulario.Monto_deposito.Text,
                    formulario.Nro_constancia_deposito2.Text.Trim,
                    formulario.Monto_deposito2.Text,
                  formulario.id_MotivoTras,
                    formulario.id_remitente,
                    "N",
                    0, "")
                    If rpta > 0 Then
                        Dim rptaham As Integer = -1
                        Dim mensajeham As String = ""
                        For i As Integer = 0 To formulario.Detalle.Rows.Count - 1
                            servidor.ejecutar("[dbo].[pa_mantenimiento_detalle_guia]",
                                                                                False,
                                                                                rptaham,
                                                                                mensajeham,
                                                                                Nothing,
                                                                                rpta,
                                                                                CInt(formulario.Detalle.Item("id_prod", i).Value),
                                                                                CInt(formulario.Detalle.Item("sacos_cantidad", i).Value),
                                                                                CStr(formulario.Detalle.Item("unidad_medida", i).Value),
                                                                                CDbl(formulario.Detalle.Item("x", i).Value),
                                                                                CDbl(formulario.Detalle.Item("Precio_Venta", i).Value),
                                                                                CDbl(formulario.Detalle.Item("IGV", i).Value),
                                                                                "N",
                                                                                0, "")

                        Next

                        If rptaham = 0 Then
                            servidor.cancelarconexiontrans()
                            __mesajeerror = mensajeham
                            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Else
                    __mesajeerror = servidor.getMensageError
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        formulario.id_guia = -1
        formulario.id_remitente = -1
        formulario.NombreRemitente.Text = ""
        formulario.ruc.Text = ""
        'Me.formulario.serie_guia.Text = ""
        ' Me.formulario.nro_guia.Text = ""
        formulario.fecha_emision_guia.Value = Now
        formulario.fecha_inicio_traslado.Value = Now
        formulario.ubigeo_pto_partida = -1
        'Me.formulario.direccion_pto_partida.Text = ""
        formulario.distritoptop.Text = ""
        formulario.provinciaptop.Text = ""
        formulario.departamentoptop.Text = ""
        formulario.ubigeo_pto_llegada = -1
        'Me.formulario.direccion_pto_llegada.Text = ""
        formulario.distritoptoll.Text = ""
        formulario.provinciaptoll.Text = ""
        formulario.departamentoptoll.Text = ""
        formulario.id_Destinatario = -1
        formulario.destinatario.Text = ""
        formulario.rucdes.Text = ""
        formulario.nombre_tip_doc.Text = ""
        formulario.nro_doc.Text = ""
        formulario.id_vehi = -1
        formulario.marca_camion.Text = ""
        formulario.nroplaca_camion.Text = ""
        formulario.nrocertificado_camion.Text = ""
        formulario.marca_carreta.Text = ""
        formulario.nroplaca_carreta.Text = ""
        formulario.nrocertificado_carreta.Text = ""
        formulario.id_chofer = -1
        formulario.Nro_licencia_conductor.Text = ""
        formulario.Nro_constancia_deposito.Text = "."
        ' Me.formulario.Monto_deposito.Text = ""
        formulario.Nro_constancia_deposito2.Text = ""
        'Me.formulario.Monto_deposito2.Text = ""
        ' Me.formulario.id_emp_trans = -1
        formulario.NombreEmpTransporte.Text = ""
        formulario.RucEmpTransporte.Text = ""
        ' Me.formulario.LblTotal.Text = ""

        formulario.id_MotivoTras = -1
        formulario.TxtMotivo.Text = ""
        formulario.NombreProducto.Text = ""
        formulario.prod_peso_uni.Text = ""
        formulario.cantidad_sacos.Text = ""
        formulario.TxtPrec_Venta.Text = "0"
        formulario.TxtIGV.Text = "0"

        formulario.Detalle.Rows.Clear()
        indice = -1
        '        ''formulario = Nothing
        '        lista(0, Nothing)

        listar_guias("1", "", "")
    End Sub

    Private Sub btnmodificar_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnModificar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Guía de Remisión", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' Me.formulario.btnquitar_hpm.Visible = False

        formulario.id_guia = CInt(dgvlista.Item("ID", indice).Value)
        formulario.id_remitente = CInt(dgvlista.Item("ID Remitente", indice).Value)
        formulario.NombreRemitente.Text = CStr(dgvlista.Item("Remitente", indice).Value)
        formulario.ruc.Text = CStr(dgvlista.Item("ruc", indice).Value)
        Dim nroguia As String = CStr(dgvlista.Item("Numero", indice).Value)
        Dim posguion As Integer = nroguia.LastIndexOf("-")
        formulario.serie_guia.Text = nroguia.Substring(0, posguion)
        formulario.nro_guia.Text = nroguia.Substring(posguion + 1)
        formulario.fecha_emision_guia.Value = CDate(dgvlista.Item("Emisión", indice).Value)
        formulario.fecha_inicio_traslado.Value = CDate(dgvlista.Item("Traslado", indice).Value)

        formulario.ubigeo_pto_partida = CInt(dgvlista.Item("ID Partida", indice).Value)
        formulario.direccion_pto_partida.Text = CStr(dgvlista.Item("Partida", indice).Value)

        Dim ptopartida As String = CStr(dgvlista.Item("Pto. partida", indice).Value)
        formulario.distritoptop.Text = ptopartida.Substring(0, ptopartida.IndexOf("/"))
        ptopartida = ptopartida.Substring(ptopartida.IndexOf("/") + 1)
        formulario.provinciaptop.Text = ptopartida.Substring(0, ptopartida.IndexOf("/"))
        ptopartida = ptopartida.Substring(ptopartida.IndexOf("/") + 1)
        formulario.departamentoptop.Text = ptopartida


        If dgvlista.Item("ID. llegada", indice).Value.ToString.Trim = "" Then
            formulario.ubigeo_pto_llegada = -1
        Else
            formulario.ubigeo_pto_llegada = CInt(dgvlista.Item("ID. llegada", indice).Value)
            'Me.formulario.direccion_pto_llegada.Text = CStr(dgvlista.Item("LLegada", indice).Value)

            Dim ptollegada As String = CStr(dgvlista.Item("Pto. llegada", indice).Value)
            formulario.distritoptoll.Text = ptollegada.Substring(0, ptollegada.IndexOf("/"))
            ptollegada = ptollegada.Substring(ptollegada.IndexOf("/") + 1)
            formulario.provinciaptoll.Text = ptollegada.Substring(0, ptollegada.IndexOf("/"))
            ptollegada = ptollegada.Substring(ptollegada.IndexOf("/") + 1)
            formulario.departamentoptoll.Text = ptollegada
        End If

        formulario.direccion_pto_llegadaa.Text = CStr(dgvlista.Item("LLegada", indice).Value.ToString)

        formulario.id_Destinatario = CInt(dgvlista.Item("ID Destinatario", indice).Value)
        formulario.destinatario.Text = CStr(dgvlista.Item("Razon social", indice).Value)
        'Me.formulario.rucdes.Text = CStr(dgvlista.Item("Ruc Cliente", indice).Value)
        Try
            formulario.rucdes.Text = CStr(dgvlista.Item("Ruc Cliente", indice).Value)
        Catch ex As Exception
            formulario.rucdes.Text = ""
        End Try
        'Me.formulario.nombre_tip_doc.Text = CStr(dgvlista.Item("Tipo Doc. Cliente", indice).Value)
        'Me.formulario.nro_doc.Text = CStr(dgvlista.Item("Nro. Doc. Cliente", indice).Value)
        Try
            formulario.nombre_tip_doc.Text = CStr(dgvlista.Item("Tipo Doc. Cliente", indice).Value)
            formulario.nro_doc.Text = CStr(dgvlista.Item("Nro. Doc. Cliente", indice).Value)
        Catch ex As Exception
            formulario.nombre_tip_doc.Text = ""
            formulario.nro_doc.Text = ""
        End Try


        formulario.id_vehi = CInt(dgvlista.Item("ID Vehiculo", indice).Value)
        formulario.marca_camion.Text = CStr(dgvlista.Item("Marca Camion", indice).Value)
        formulario.nroplaca_camion.Text = CStr(dgvlista.Item("Nro. placa Camion", indice).Value)
        formulario.nrocertificado_camion.Text = CStr(dgvlista.Item("Nro. certificado Camion", indice).Value)
        formulario.marca_carreta.Text = CStr(dgvlista.Item("Marca Carreta", indice).Value)
        formulario.nroplaca_carreta.Text = CStr(dgvlista.Item("Nro. placa Carreta", indice).Value)
        formulario.nrocertificado_carreta.Text = CStr(dgvlista.Item("Nro. certificado Carreta", indice).Value)

        formulario.NombreEmpTransporte.Text = CStr(dgvlista.Item("Empresa Transporte", indice).Value)
        formulario.RucEmpTransporte.Text = CStr(dgvlista.Item("RUC Emp Transporte", indice).Value)


        formulario.id_chofer = CInt(dgvlista.Item("ID Chofer", indice).Value)
        formulario.Nro_licencia_conductor.Text = CStr(dgvlista.Item("Brevete", indice).Value)

        formulario.Nro_constancia_deposito.Text = CStr(dgvlista.Item("Nro Deposito", indice).Value)
        formulario.Monto_deposito.Text = CDbl(dgvlista.Item("Monto", indice).Value)


        'Soluciona el error del NRO DE CONSTANCIA y MONTO DE DEPOSITO vacio en la guia
        formulario.Nro_constancia_deposito2.Text = CStr(dgvlista.Item("Nro Depositoo", indice).Value)
        formulario.Monto_deposito2.Text = CStr(dgvlista.Item("Montoo", indice).Value)
        'Try
        '    Me.formulario.Nro_constancia_deposito2.Text = CStr(dgvlista.Item("Nro Depositoo", indice).Value)
        '    Me.formulario.Monto_deposito2.Text = CDbl(dgvlista.Item("Montoo", indice).Value)
        'Catch ex As Exception
        '    Me.formulario.Nro_constancia_deposito2.Text = ""
        '    Me.formulario.Monto_deposito2.Text = ""
        'End Try


        'Me.formulario.id_emp_trans = CInt(dgvlista.Item("ID Empresa Trasporte", indice).Value)
        ' Me.formulario.NombreEmpTransporte.Text = CStr(dgvlista.Item("Empresa Transporte", indice).Value)
        ' Me.formulario.RucEmpTransporte.Text = CStr(dgvlista.Item("RUC Emp Transporte", indice).Value)

        formulario.id_MotivoTras = CInt(dgvlista.Item("ID Traslado", indice).Value)
        formulario.TxtMotivo.Text = CStr(dgvlista.Item("Motivo Traslado", indice).Value)



        For i As Integer = 0 To dgvdetalle.Rows.Count - 1
            formulario.Detalle.Rows.Add()
            formulario.Detalle.Item("id_det_guia", formulario.Detalle.Rows.Count - 1).Value = dgvdetalle.Item("ID Detalle", i).Value
            formulario.Detalle.Item("id_prod", formulario.Detalle.Rows.Count - 1).Value = dgvdetalle.Item("ID Producro", i).Value
            formulario.Detalle.Item("sacos_cantidad", formulario.Detalle.Rows.Count - 1).Value = dgvdetalle.Item("Cantidad", i).Value
            formulario.Detalle.Item("unidad_medida", formulario.Detalle.Rows.Count - 1).Value = dgvdetalle.Item("Unidad_Medida", i).Value
            formulario.Detalle.Item("Descripcion", formulario.Detalle.Rows.Count - 1).Value = dgvdetalle.Item("Descripción", i).Value
            formulario.Detalle.Item("Peso", formulario.Detalle.Rows.Count - 1).Value = dgvdetalle.Item("Sub Total", i).Value
            formulario.Detalle.Item("x", formulario.Detalle.Rows.Count - 1).Value = dgvdetalle.Item("Peso", i).Value
            formulario.Detalle.Item("Precio_Venta", formulario.Detalle.Rows.Count - 1).Value = dgvdetalle.Item("Precio_Venta", i).Value
            formulario.Detalle.Item("IGV", formulario.Detalle.Rows.Count - 1).Value = dgvdetalle.Item("IGV", i).Value

        Next

        'Me.formulario.lista(7)

        'formulario.dgvmotivo.Item("Selecciona", 1).Value = True

        'Dim idmotivo As Integer = CInt(dgvlista.Item("ID Traslado", indice).Value)

        'For i As Integer = 0 To formulario.dgvmotivo.Rows.Count - 1
        '    'MsgBox(formulario.dgvlista.Item(1, i).Value.ToString & " " & idmotivo.ToString)
        '    If CInt(formulario.dgvmotivo.Item(1, i).Value) = idmotivo Then
        '        formulario.dgvmotivo.Item("Selecciona", i).Value = True
        '        Exit For
        '    End If
        'Next
        dgvdetalle.DataSource = Nothing
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            'preguntamos si el usuario quiere o no.
            If MessageBox.Show("¿Desea guardar Guía de Remisión?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                ' asignamos ruta coneccion con el servidor de la base de datos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    'Dim id_mot_traslado As Integer
                    'For i As Integer = 0 To formulario.dgvmotivo.Rows.Count - 1

                    '    If CBool(formulario.dgvmotivo.Item(0, i).Value) = True Then
                    '        id_mot_traslado = CInt(formulario.dgvmotivo.Item(1, i).Value)
                    '        Exit For
                    '    End If
                    'Next

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_cabecera_guia]",
                    False,
                    rpta,
                    mensaje,
                    formulario.id_guia,
                    formulario.serie_guia.Text.Trim,
                    formulario.nro_guia.Text.Trim,
                    formulario.fecha_emision_guia.Value.Date,
                    formulario.fecha_inicio_traslado.Value.Date,
                    formulario.direccion_pto_partida.Text.Trim,
                    formulario.ubigeo_pto_partida,
                    formulario.id_Destinatario,
                    formulario.direccion_pto_llegadaa.Text.Trim,
                    IIf(formulario.ubigeo_pto_llegada = -1, Nothing, formulario.ubigeo_pto_llegada),
                    formulario.id_vehi,
                    formulario.id_chofer,
                    formulario.Nro_constancia_deposito.Text.Trim,
                    formulario.Monto_deposito.Text,
                    formulario.Nro_constancia_deposito2.Text.Trim,
                    formulario.Monto_deposito2.Text,
                      formulario.id_MotivoTras,
                    formulario.id_remitente,
                    "M",
                    0, "")
                    If rpta > 0 Then
                        Dim rptaham As Integer = -1
                        Dim mensajeham As String = ""
                        For i As Integer = 0 To formulario.Detalle.Rows.Count - 1
                            servidor.ejecutar("[dbo].[pa_mantenimiento_detalle_guia]",
                                                                                False,
                                                                                rptaham,
                                                                                mensajeham,
                                                                                CInt(formulario.Detalle.Item("id_det_guia", i).Value),
                                                                                formulario.id_guia,
                                                                                CInt(formulario.Detalle.Item("id_prod", i).Value),
                                                                                CInt(formulario.Detalle.Item("sacos_cantidad", i).Value),
                                                                                CStr(formulario.Detalle.Item("unidad_medida", i).Value),
                                                                                CDbl(formulario.Detalle.Item("x", i).Value),
                                                                                 CDbl(formulario.Detalle.Item("Precio_Venta", i).Value),
                                                                                CDbl(formulario.Detalle.Item("IGV", i).Value),
                                                                                "M",
                                                                                0, "")

                        Next

                        If rptaham = 0 Then
                            servidor.cancelarconexiontrans()
                            __mesajeerror = mensajeham
                            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Else
                    __mesajeerror = servidor.getMensageError
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        formulario.id_guia = -1
        formulario.id_remitente = -1
        formulario.NombreRemitente.Text = ""
        formulario.ruc.Text = ""
        formulario.serie_guia.Text = "000"
        formulario.nro_guia.Text = "0000"
        formulario.fecha_emision_guia.Value = Now
        formulario.fecha_inicio_traslado.Value = Now
        formulario.ubigeo_pto_partida = -1
        formulario.direccion_pto_partida.Text = "CAR. LAMBAYEQUE KM 778"
        formulario.distritoptop.Text = ""
        formulario.provinciaptop.Text = ""
        formulario.departamentoptop.Text = ""
        formulario.ubigeo_pto_llegada = -1
        formulario.direccion_pto_llegadaa.Text = "MERCADO LIBRE-"
        formulario.distritoptoll.Text = ""
        formulario.provinciaptoll.Text = ""
        formulario.departamentoptoll.Text = ""
        formulario.id_Destinatario = -1
        formulario.destinatario.Text = ""
        formulario.rucdes.Text = ""
        formulario.nombre_tip_doc.Text = ""
        formulario.nro_doc.Text = ""
        formulario.id_vehi = -1
        formulario.marca_camion.Text = ""
        formulario.nroplaca_camion.Text = ""
        formulario.nrocertificado_camion.Text = ""
        formulario.marca_carreta.Text = ""
        formulario.nroplaca_carreta.Text = ""
        formulario.nrocertificado_carreta.Text = ""
        formulario.id_chofer = -1
        formulario.Nro_licencia_conductor.Text = ""
        formulario.Nro_constancia_deposito.Text = ""
        formulario.Monto_deposito.Text = "0.00"
        formulario.Nro_constancia_deposito2.Text = ""
        formulario.Monto_deposito2.Text = "0.00"
        ' Me.formulario.id_emp_trans = -1
        formulario.NombreEmpTransporte.Text = ""
        formulario.RucEmpTransporte.Text = ""

        formulario.id_MotivoTras = -1
        formulario.TxtMotivo.Text = ""
        formulario.NombreProducto.Text = ""
        formulario.prod_peso_uni.Text = ""
        formulario.cantidad_sacos.Text = ""
        formulario.TxtPrec_Venta.Text = "0"
        formulario.TxtIGV.Text = "0"

        formulario.Detalle.Rows.Clear()
        indice = -1
        '        ''formulario = Nothing
        '        lista(0, Nothing)

        listar_guias("1", "", "")


    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminar.Click
        If check_fila_grilla(dgvdetalle) = False Then
            MessageBox.Show("Haga check en la columna Seleccionar por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If MessageBox.Show("¿Desea eliminar el detalle de los bienes?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then
                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    For i As Integer = 0 To dgvdetalle.Rows.Count - 1
                        If CBool(dgvdetalle.Item(0, i).Value) = True Then
                            servidor.ejecutar("[dbo].[pa_mantenimiento_detalle_guia]",
                              False,
                              rpta,
                              mensaje,
                              CInt(dgvdetalle.Item("ID Detalle", i).Value.ToString),
                              Nothing,
                              Nothing,
                              Nothing,
                              Nothing,
                              Nothing,
                               Nothing,
                              Nothing,
                              "E",
                              0, "")
                        End If
                    Next
                    If rpta = 1 Then
                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        'Me.__mensaje.Value = __mesajeerror
                        'Me.__pagina.Value = "listapersonas.aspx"
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        servidor.cancelarconexiontrans()
                        __mesajeerror = mensaje
                        'Me.__pagina.Value = "listapersonas.aspx"
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    __mesajeerror = servidor.getMensageError
                    'Me.mesajeerror.Text = __mesajeerror
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            'indice = -1
        End If
        listar_detalle_guias(idguia)
    End Sub
    Private Sub nroguia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nroguia.KeyPress
        SoloNumeros(e, False, sender.Text)
    End Sub
    'Private Sub nroguia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nroguia.Enter
    '    Me.nroguia.BackColor = Color.Moccasin
    'End Sub
    Private Sub nroguia_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles nroguia.Leave
        nroguia.BackColor = Color.White
    End Sub
    Private Sub nroguia_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nroguia.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub btnCerrar_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub nroguia_TextChanged_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles nroguia.TextChanged
        Dim valor As String = nroguia.Text.Trim
        listar_guias("1", valor, "")
        dgvdetalle.DataSource = Nothing

        'listar_guias(Me.nroguia.Text, Nothing)
    End Sub

    Private Sub txtdest_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtdest.Leave
        txtdest.BackColor = Color.White
    End Sub

    Private Sub txtdest_TextChanged_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtdest.TextChanged
        'Dim valor As String = Me.txtdest.Text
        'listar_guias(Nothing, valor)
        'dgvdetalle.DataSource = Nothing

        listar_guias("1", "", txtdest.Text)
    End Sub

    Private Sub dgvdetalle_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles dgvdetalle.CellContentClick

    End Sub

    Private Sub dgvdetalle_RowsAdded1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvdetalle.RowsAdded
        ' Me.BtnModificar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        'Me.btnImprimir2.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvdetalle_RowsRemoved1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvdetalle.RowsRemoved
        ' Me.BtnModificar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        'Me.btnImprimir2.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvdetalle_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgvdetalle.VisibleChanged
        '  Me.BtnModificar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        'Me.btnImprimir2.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvlista_CellContentClick_1(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick
        Try
            indice = e.RowIndex
            idguia = dgvlista.Item("ID", indice).Value
            listar_detalle_guias(idguia)
        Catch ex As Exception
        End Try


    End Sub

    Private Sub dgvlista_CellFormatting1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
    End Sub



    Private Sub cbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles cbTodos.CheckedChanged
        If cbTodos.Checked = True Then
            listar_guias("2", "", "")
        Else
            listar_guias("1", "", "")
        End If

    End Sub

    REM ============================================================================
#Region "IMPRIMIR"
    Private Sub btnImprimir_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnImprimir.Click
        Dim fu As New frmOpcImpGuia
        fu.ShowDialog()
        'If fu.rbps.Checked = True Then
        '    For i As Integer = 0 To fu.cblps.Items.Count - 1
        '        If fu.cblps.GetItemChecked(i) = True Then
        '            MsgBox(fu.cblps.GetItemText(i))
        '        End If
        '    Next
        'End If
        'MsgBox(fu.rbps.Checked.ToString)
        'Exit Sub

        If fu.RBAng.Checked Then
            Dim ptopartida As String = CStr(dgvlista.Item("Pto. partida", indice).Value)
            Dim distritoptop As String = ptopartida.Substring(0, ptopartida.IndexOf("/"))
            ptopartida = ptopartida.Substring(ptopartida.IndexOf("/") + 1)
            Dim provinciaptop As String = ptopartida.Substring(0, ptopartida.IndexOf("/"))
            ptopartida = ptopartida.Substring(ptopartida.IndexOf("/") + 1)
            Dim departamentoptop As String = ptopartida

            Dim pp() As String = {distritoptop, provinciaptop, departamentoptop}
            If fu.rbps.Checked = True Then
                For i As Integer = 0 To fu.cblps.Items.Count - 1
                    If fu.cblps.GetItemChecked(i) = True Then
                        REM MsgBox(fu.cblps.GetItemText(i))
                        pp(i) = ""
                    End If
                Next
            End If
            'MsgBox(distritoptop + provinciaptop + departamentoptop)
            Dim ptollegada As String
            Dim distritoptoll As String
            Dim provinciaptoll As String
            Dim departamentoptoll As String
            If dgvlista.Item("ID. llegada", indice).Value.ToString.Trim <> "" Then
                ptollegada = CStr(dgvlista.Item("Pto. llegada", indice).Value)

                distritoptoll = ptollegada.Substring(0, ptollegada.IndexOf("/"))
                ptollegada = ptollegada.Substring(ptollegada.IndexOf("/") + 1)
                provinciaptoll = ptollegada.Substring(0, ptollegada.IndexOf("/"))
                ptollegada = ptollegada.Substring(ptollegada.IndexOf("/") + 1)
                departamentoptoll = ptollegada
            Else
                ptollegada = ""
                distritoptoll = ""
                provinciaptoll = ""
                departamentoptoll = ""
            End If


            Dim ll() As String = {distritoptoll, provinciaptoll, departamentoptoll}
            If fu.rbpll.Checked = True Then
                For i As Integer = 0 To fu.cblpll.Items.Count - 1
                    If fu.cblpll.GetItemChecked(i) = True Then
                        REM MsgBox(fu.cblps.GetItemText(i))
                        ll(i) = ""
                    End If
                Next
            End If

            Dim rucdes As String
            'Dim rucdes As String = CStr(dgvlista.Item("Ruc Cliente", indice).Value)
            Try
                rucdes = CStr(dgvlista.Item("Ruc Cliente", indice).Value)
            Catch ex As Exception
                rucdes = ""
            End Try
            Dim nombre_tip_doc As String
            Dim nro_doc As String
            Try
                nombre_tip_doc = CStr(dgvlista.Item("Tipo Doc. Cliente", indice).Value)
                nro_doc = CStr(dgvlista.Item("Nro. Doc. Cliente", indice).Value)
            Catch ex As Exception
                nombre_tip_doc = ""
                nro_doc = ""
            End Try
            'Dim nombre_tip_doc As String = CStr(dgvlista.Item("Tipo Doc. Cliente", indice).Value)
            'Dim nro_doc As String = CStr(dgvlista.Item("Nro. Doc. Cliente", indice).Value)
            Dim parametros(1) As String
            If fu.rbemisor.Checked = True Then
                parametros(0) = fu.rbemisor.Tag
            End If
            If fu.rbdestino.Checked = True Then
                parametros(0) = fu.rbdestino.Tag
            End If
            If fu.rbsunat.Checked = True Then
                parametros(0) = fu.rbsunat.Tag
            End If
            Dim f As New frmImprimiR
            f.Nivel = "FORMULARIO_LISTA_GUIAS"
            f.Tabla_Imprimir = tabla_detalle_guias
            f.__PuntoPartida = pp
            f.__PuntoLLegada = ll
            f.RUC_Destinatario = rucdes
            f.__Parametros = parametros
            f.Tipo_Nro_Doc_Identidad = nombre_tip_doc + " " + nro_doc
            'f.DataSet_Imprimir = mids
            f.Titulo_Informe = "REPORTE GUIA REMISION -- CONSORCIO LOS ANGELES"
            f.ShowDialog()
            'End If

        ElseIf fu.RBang2.Checked Then
            Dim ptopartida As String = CStr(dgvlista.Item("Pto. partida", indice).Value)
            Dim distritoptop As String = ptopartida.Substring(0, ptopartida.IndexOf("/"))
            ptopartida = ptopartida.Substring(ptopartida.IndexOf("/") + 1)
            Dim provinciaptop As String = ptopartida.Substring(0, ptopartida.IndexOf("/"))
            ptopartida = ptopartida.Substring(ptopartida.IndexOf("/") + 1)
            Dim departamentoptop As String = ptopartida

            Dim pp() As String = {distritoptop, provinciaptop, departamentoptop}
            If fu.rbps.Checked = True Then
                For i As Integer = 0 To fu.cblps.Items.Count - 1
                    If fu.cblps.GetItemChecked(i) = True Then
                        REM MsgBox(fu.cblps.GetItemText(i))
                        pp(i) = ""
                    End If
                Next
            End If
            'MsgBox(distritoptop + provinciaptop + departamentoptop)
            Dim ptollegada As String
            Dim distritoptoll As String
            Dim provinciaptoll As String
            Dim departamentoptoll As String
            If dgvlista.Item("ID. llegada", indice).Value.ToString.Trim <> "" Then
                ptollegada = CStr(dgvlista.Item("Pto. llegada", indice).Value)

                distritoptoll = ptollegada.Substring(0, ptollegada.IndexOf("/"))
                ptollegada = ptollegada.Substring(ptollegada.IndexOf("/") + 1)
                provinciaptoll = ptollegada.Substring(0, ptollegada.IndexOf("/"))
                ptollegada = ptollegada.Substring(ptollegada.IndexOf("/") + 1)
                departamentoptoll = ptollegada
            Else
                ptollegada = ""
                distritoptoll = ""
                provinciaptoll = ""
                departamentoptoll = ""
            End If


            Dim ll() As String = {distritoptoll, provinciaptoll, departamentoptoll}
            If fu.rbpll.Checked = True Then
                For i As Integer = 0 To fu.cblpll.Items.Count - 1
                    If fu.cblpll.GetItemChecked(i) = True Then
                        REM MsgBox(fu.cblps.GetItemText(i))
                        ll(i) = ""
                    End If
                Next
            End If

            Dim rucdes As String
            Try
                rucdes = CStr(dgvlista.Item("Ruc Cliente", indice).Value)
            Catch ex As Exception
                rucdes = ""
            End Try
            Dim nombre_tip_doc As String
            Dim nro_doc As String
            Try
                nombre_tip_doc = CStr(dgvlista.Item("Tipo Doc. Cliente", indice).Value)
                nro_doc = CStr(dgvlista.Item("Nro. Doc. Cliente", indice).Value)
            Catch ex As Exception
                nombre_tip_doc = ""
                nro_doc = ""
            End Try
            Dim parametros(1) As String
            If fu.rbemisor.Checked = True Then
                parametros(0) = fu.rbemisor.Tag
            End If
            If fu.rbdestino.Checked = True Then
                parametros(0) = fu.rbdestino.Tag
            End If
            If fu.rbsunat.Checked = True Then
                parametros(0) = fu.rbsunat.Tag
            End If

            Dim f As New frmImprimiR
            f.Nivel = "FORMULARIO_LISTA_GUIAS2"
            f.Tabla_Imprimir = tabla_detalle_guias
            f.__PuntoPartida = pp
            f.__PuntoLLegada = ll
            f.RUC_Destinatario = rucdes
            f.__Parametros = parametros
            f.Tipo_Nro_Doc_Identidad = nombre_tip_doc + " " + nro_doc
            f.Titulo_Informe = "REPORTE GUIA REMISION -- CONSORCIO LOS ANGELES 2"
            f.ShowDialog()


            '********* IMPRIMIR GUIAS DE MOLINOS LOS ANGELES SRL ****************
        ElseIf fu.RbMolino.Checked Then
            Dim ptopartida As String = CStr(dgvlista.Item("Pto. partida", indice).Value)
            Dim distritoptop As String = ptopartida.Substring(0, ptopartida.IndexOf("/"))
            ptopartida = ptopartida.Substring(ptopartida.IndexOf("/") + 1)
            Dim provinciaptop As String = ptopartida.Substring(0, ptopartida.IndexOf("/"))
            ptopartida = ptopartida.Substring(ptopartida.IndexOf("/") + 1)
            Dim departamentoptop As String = ptopartida

            Dim pp() As String = {distritoptop, provinciaptop, departamentoptop}
            If fu.rbps.Checked = True Then
                For i As Integer = 0 To fu.cblps.Items.Count - 1
                    If fu.cblps.GetItemChecked(i) = True Then
                        REM MsgBox(fu.cblps.GetItemText(i))
                        pp(i) = ""
                    End If
                Next
            End If
            'MsgBox(distritoptop + provinciaptop + departamentoptop)
            Dim ptollegada As String
            Dim distritoptoll As String
            Dim provinciaptoll As String
            Dim departamentoptoll As String
            If dgvlista.Item("ID. llegada", indice).Value.ToString.Trim <> "" Then
                ptollegada = CStr(dgvlista.Item("Pto. llegada", indice).Value)

                distritoptoll = ptollegada.Substring(0, ptollegada.IndexOf("/"))
                ptollegada = ptollegada.Substring(ptollegada.IndexOf("/") + 1)
                provinciaptoll = ptollegada.Substring(0, ptollegada.IndexOf("/"))
                ptollegada = ptollegada.Substring(ptollegada.IndexOf("/") + 1)
                departamentoptoll = ptollegada
            Else
                ptollegada = ""
                distritoptoll = ""
                provinciaptoll = ""
                departamentoptoll = ""
            End If


            Dim ll() As String = {distritoptoll, provinciaptoll, departamentoptoll}
            If fu.rbpll.Checked = True Then
                For i As Integer = 0 To fu.cblpll.Items.Count - 1
                    If fu.cblpll.GetItemChecked(i) = True Then
                        REM MsgBox(fu.cblps.GetItemText(i))
                        ll(i) = ""
                    End If
                Next
            End If

            Dim rucdes As String
            Try
                rucdes = CStr(dgvlista.Item("Ruc Cliente", indice).Value)
            Catch ex As Exception
                rucdes = ""
            End Try
            Dim nombre_tip_doc As String
            Dim nro_doc As String
            Try
                nombre_tip_doc = CStr(dgvlista.Item("Tipo Doc. Cliente", indice).Value)
                nro_doc = CStr(dgvlista.Item("Nro. Doc. Cliente", indice).Value)
            Catch ex As Exception
                nombre_tip_doc = ""
                nro_doc = ""
            End Try
            Dim parametros(1) As String
            If fu.rbemisor.Checked = True Then
                parametros(0) = fu.rbemisor.Tag
            End If
            If fu.rbdestino.Checked = True Then
                parametros(0) = fu.rbdestino.Tag
            End If
            If fu.rbsunat.Checked = True Then
                parametros(0) = fu.rbsunat.Tag
            End If

            Dim f As New frmImprimiR
            f.Nivel = "FORMULARIO_LISTA_GUIAS_MOLINOS"
            f.Tabla_Imprimir = tabla_detalle_guias
            f.__PuntoPartida = pp
            f.__PuntoLLegada = ll
            f.RUC_Destinatario = rucdes
            f.__Parametros = parametros
            f.Tipo_Nro_Doc_Identidad = nombre_tip_doc + " " + nro_doc
            f.Titulo_Informe = "REPORTE GUIA REMISION -- MOLINOS LOS ANGELES S.R.L."
            f.ShowDialog()

            '*********  IMPRIMIR GUIAS DE ZELU
        ElseIf fu.RbMagllogri.Checked Then
            Dim ptopartida As String = CStr(dgvlista.Item("Pto. partida", indice).Value)
            Dim distritoptop As String = ptopartida.Substring(0, ptopartida.IndexOf("/"))
            ptopartida = ptopartida.Substring(ptopartida.IndexOf("/") + 1)
            Dim provinciaptop As String = ptopartida.Substring(0, ptopartida.IndexOf("/"))
            ptopartida = ptopartida.Substring(ptopartida.IndexOf("/") + 1)
            Dim departamentoptop As String = ptopartida

            Dim pp() As String = {distritoptop, provinciaptop, departamentoptop}
            If fu.rbps.Checked = True Then
                For i As Integer = 0 To fu.cblps.Items.Count - 1
                    If fu.cblps.GetItemChecked(i) = True Then
                        REM MsgBox(fu.cblps.GetItemText(i))
                        pp(i) = ""
                    End If
                Next
            End If
            'MsgBox(distritoptop + provinciaptop + departamentoptop)
            Dim ptollegada As String
            Dim distritoptoll As String
            Dim provinciaptoll As String
            Dim departamentoptoll As String
            If dgvlista.Item("ID. llegada", indice).Value.ToString.Trim <> "" Then
                ptollegada = CStr(dgvlista.Item("Pto. llegada", indice).Value)

                distritoptoll = ptollegada.Substring(0, ptollegada.IndexOf("/"))
                ptollegada = ptollegada.Substring(ptollegada.IndexOf("/") + 1)
                provinciaptoll = ptollegada.Substring(0, ptollegada.IndexOf("/"))
                ptollegada = ptollegada.Substring(ptollegada.IndexOf("/") + 1)
                departamentoptoll = ptollegada
            Else
                ptollegada = ""
                distritoptoll = ""
                provinciaptoll = ""
                departamentoptoll = ""
            End If


            Dim ll() As String = {distritoptoll, provinciaptoll, departamentoptoll}
            If fu.rbpll.Checked = True Then
                For i As Integer = 0 To fu.cblpll.Items.Count - 1
                    If fu.cblpll.GetItemChecked(i) = True Then
                        REM MsgBox(fu.cblps.GetItemText(i))
                        ll(i) = ""
                    End If
                Next
            End If

            Dim rucdes As String
            Try
                rucdes = CStr(dgvlista.Item("Ruc Cliente", indice).Value)
            Catch ex As Exception
                rucdes = ""
            End Try
            Dim nombre_tip_doc As String
            Dim nro_doc As String
            Try
                nombre_tip_doc = CStr(dgvlista.Item("Tipo Doc. Cliente", indice).Value)
                nro_doc = CStr(dgvlista.Item("Nro. Doc. Cliente", indice).Value)
            Catch ex As Exception
                nombre_tip_doc = ""
                nro_doc = ""
            End Try
            Dim parametros(1) As String
            If fu.rbemisor.Checked = True Then
                parametros(0) = fu.rbemisor.Tag
            End If
            If fu.rbdestino.Checked = True Then
                parametros(0) = fu.rbdestino.Tag
            End If
            If fu.rbsunat.Checked = True Then
                parametros(0) = fu.rbsunat.Tag
            End If
            Dim f As New frmImprimiR
            f.Nivel = "FORMULARIO_LISTA_GUIAS_ZELU"
            f.Tabla_Imprimir = tabla_detalle_guias
            f.__PuntoPartida = pp
            f.__PuntoLLegada = ll
            f.RUC_Destinatario = rucdes
            f.__Parametros = parametros
            f.Tipo_Nro_Doc_Identidad = nombre_tip_doc + " " + nro_doc
            f.Titulo_Informe = "REPORTE GUIA REMISION -- ZELU"
            f.ShowDialog()




            '********* FIN GUIAS DE MAGLLOGRI -------- *************

            '*********  IMPRIMIR GUIAS DE BANTEMAR
        ElseIf fu.RbBantemar.Checked Then
            Dim ptopartida As String = CStr(dgvlista.Item("Pto. partida", indice).Value)
            Dim distritoptop As String = ptopartida.Substring(0, ptopartida.IndexOf("/"))
            ptopartida = ptopartida.Substring(ptopartida.IndexOf("/") + 1)
            Dim provinciaptop As String = ptopartida.Substring(0, ptopartida.IndexOf("/"))
            ptopartida = ptopartida.Substring(ptopartida.IndexOf("/") + 1)
            Dim departamentoptop As String = ptopartida

            Dim pp() As String = {distritoptop, provinciaptop, departamentoptop}
            If fu.rbps.Checked = True Then
                For i As Integer = 0 To fu.cblps.Items.Count - 1
                    If fu.cblps.GetItemChecked(i) = True Then
                        REM MsgBox(fu.cblps.GetItemText(i))
                        pp(i) = ""
                    End If
                Next
            End If
            'MsgBox(distritoptop + provinciaptop + departamentoptop)
            Dim ptollegada As String
            Dim distritoptoll As String
            Dim provinciaptoll As String
            Dim departamentoptoll As String
            If dgvlista.Item("ID. llegada", indice).Value.ToString.Trim <> "" Then
                ptollegada = CStr(dgvlista.Item("Pto. llegada", indice).Value)

                distritoptoll = ptollegada.Substring(0, ptollegada.IndexOf("/"))
                ptollegada = ptollegada.Substring(ptollegada.IndexOf("/") + 1)
                provinciaptoll = ptollegada.Substring(0, ptollegada.IndexOf("/"))
                ptollegada = ptollegada.Substring(ptollegada.IndexOf("/") + 1)
                departamentoptoll = ptollegada
            Else
                ptollegada = ""
                distritoptoll = ""
                provinciaptoll = ""
                departamentoptoll = ""
            End If


            Dim ll() As String = {distritoptoll, provinciaptoll, departamentoptoll}
            If fu.rbpll.Checked = True Then
                For i As Integer = 0 To fu.cblpll.Items.Count - 1
                    If fu.cblpll.GetItemChecked(i) = True Then
                        REM MsgBox(fu.cblps.GetItemText(i))
                        ll(i) = ""
                    End If
                Next
            End If

            Dim rucdes As String
            Try
                rucdes = CStr(dgvlista.Item("Ruc Cliente", indice).Value)
            Catch ex As Exception
                rucdes = ""
            End Try
            Dim nombre_tip_doc As String
            Dim nro_doc As String
            Try
                nombre_tip_doc = CStr(dgvlista.Item("Tipo Doc. Cliente", indice).Value)
                nro_doc = CStr(dgvlista.Item("Nro. Doc. Cliente", indice).Value)
            Catch ex As Exception
                nombre_tip_doc = ""
                nro_doc = ""
            End Try
            Dim parametros(1) As String
            If fu.rbemisor.Checked = True Then
                parametros(0) = fu.rbemisor.Tag
            End If
            If fu.rbdestino.Checked = True Then
                parametros(0) = fu.rbdestino.Tag
            End If
            If fu.rbsunat.Checked = True Then
                parametros(0) = fu.rbsunat.Tag
            End If

            Dim f As New frmImprimiR
            f.Nivel = "FORMULARIO_LISTA_GUIAS_BANTEMAR"
            f.Tabla_Imprimir = tabla_detalle_guias
            f.__PuntoPartida = pp
            f.__PuntoLLegada = ll
            f.RUC_Destinatario = rucdes
            f.__Parametros = parametros
            f.Tipo_Nro_Doc_Identidad = nombre_tip_doc + " " + nro_doc
            f.Titulo_Informe = "REPORTE GUIA REMISION -- BANTEMAR"
            f.ShowDialog()


        End If
    End Sub
#End Region
    REM ============================================================================
End Class
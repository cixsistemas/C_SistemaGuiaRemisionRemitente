Public Class FrmPeso_Med2
    Private formulario As New FrmPeso_Med
    Dim Id_peso_med2 As Integer

    Dim tabla_peso_med As DataTable = Nothing

    Public Sub lista(ByVal criterio As String)
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_peso_med]", criterio).Tables.Count > 0 Then
                tabla_peso_med = servidor.consultar("[dbo].[pa_listar_peso_med]", criterio).Tables(0)
            End If
            If tabla_peso_med Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY CONSTANCIA DE VERIFICACIÓN DE PESOS Y MEDIDAS PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_peso_med
                Dim NroFilas As Integer = tabla_peso_med.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY CONSTANCIA DE VERIFICACIÓN DE PESOS Y MEDIDAS PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("ID Guia").Visible = False
                    dgvlista.Columns("Id Peso Medida").Visible = False
                    dgvlista.Columns("RUC Destinatario").Visible = False
                    dgvlista.Columns("direccion").Visible = False
                    dgvlista.Columns("distrito").Visible = False
                    dgvlista.Columns("provincia").Visible = False
                    dgvlista.Columns("departamento").Visible = False
                    dgvlista.Columns("Representante legal").Visible = False
                    dgvlista.Columns("TOTAL").Visible = False
                    dgvlista.Columns("Fecha").DefaultCellStyle.Format = "dd/MM/yyyy"
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Constancia(s) de Verificacion de Pesos y Medidas"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Try
            'POSICIONA CURSOR EN ULTIMA FILA
            dgvlista.ClearSelection()
            dgvlista.CurrentCell = dgvlista.Rows(dgvlista.RowCount - 1).Cells(2)
            'Me.dgvlista.Refresh()
        Catch ex As Exception
            '  MessageBox.Show("Guía de Remisión, No se encuentra registrada", "Guía de Remisión-Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub FrmPeso_Med22_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub


    Private Sub FrmPeso_Med22_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
        txtbusca.Focus()
    End Sub

    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellEnter
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 4 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
    End Sub
    Private Sub dgvlista_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvlista.RowsAdded
        btnmodificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvlista_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvlista.RowsRemoved
        btnmodificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvlista_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvlista.VisibleChanged
        btnmodificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar Constancia de Verificacion de Pesos y Medidas?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_peso_med]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.Id_peso_med, _
                    formulario.Id_guia, _
                    formulario.fecha_emision_guia.Value, _
                    formulario.observacion.Text.Trim, _
                    "N", _
                    0, "")
                    If rpta > 0 Then
                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        servidor.cancelarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    __mesajeerror = servidor.getMensageError
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        formulario.Id_peso_med = -1
        formulario.fecha_emision_guia.Value = Now
        formulario.observacion.Text = ""

        formulario.Id_guia = -1
        formulario.serie_guia.Text = ""
        formulario.nro_guia.Text = ""
        formulario.Total.Text = ""

        formulario.NombreDestinatario.Text = ""
        formulario.ruc.Text = ""
        formulario.distrito.Text = ""
        formulario.provincia.Text = ""
        formulario.departamento.Text = ""
        formulario.direccion.Text = ""

        formulario.nroplaca_camion.Text = ""
        formulario.nroplaca_carreta.Text = ""
        formulario.largo.Text = ""
        formulario.ancho.Text = ""
        formulario.alto.Text = ""
        formulario.peso_neto1.Text = ""
        formulario.largo2.Text = ""
        formulario.ancho2.Text = ""
        formulario.alto2.Text = ""
        formulario.peso_neto2.Text = ""
        formulario.Conf_Vehi.Text = ""
        formulario.Pes_Veh.Text = ""
        formulario.Pes_Transp.Text = ""

        indice = -1
        lista(Nothing)



    End Sub

    Private Sub btnmodificar_Click_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Constancia de Verificacion de Pesos y Medidas", "Molino los Angeles", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        formulario.Id_peso_med = CInt(dgvlista.Item("Id Peso Medida", indice).Value)
        formulario.fecha_emision_guia.Value = CDate(dgvlista.Item("Fecha", indice).Value)
        'Me.formulario.Pes_Transp.Text = CStr(dgvlista.Item("Peso Bruto Transportado", indice).Value.ToString.Trim)
        formulario.observacion.Text = CStr(dgvlista.Item("Observacion", indice).Value.ToString.Trim)


        formulario.Id_guia = CInt(dgvlista.Item("ID Guia", indice).Value)
        formulario.serie_guia.Text = CStr(dgvlista.Item("Serie", indice).Value.ToString.Trim)
        formulario.nro_guia.Text = CStr(dgvlista.Item("Nro. Guia de Remision", indice).Value.ToString.Trim)

        formulario.NombreDestinatario.Text = CStr(dgvlista.Item("Destinatario", indice).Value.ToString.Trim)
        formulario.ruc.Text = CStr(dgvlista.Item("RUC Destinatario", indice).Value.ToString.Trim)
        formulario.direccion.Text = CStr(dgvlista.Item("direccion", indice).Value.ToString.Trim)
        formulario.distrito.Text = CStr(dgvlista.Item("distrito", indice).Value.ToString.Trim)
        formulario.provincia.Text = CStr(dgvlista.Item("provincia", indice).Value.ToString.Trim)
        formulario.departamento.Text = CStr(dgvlista.Item("departamento", indice).Value.ToString.Trim)

        ' Me.formulario.id_vehi = CInt(dgvlista.Item("Id Vehiculo", indice).Value)
        formulario.nroplaca_camion.Text = CStr(dgvlista.Item("Nro. placa Camion", indice).Value.ToString.Trim)
        formulario.nroplaca_carreta.Text = CStr(dgvlista.Item("Nro. Placa Carreta", indice).Value.ToString.Trim)
        formulario.largo.Text = CStr(dgvlista.Item("Largo Camion", indice).Value.ToString.Trim)
        formulario.ancho.Text = CStr(dgvlista.Item("Ancho Camion", indice).Value.ToString.Trim)
        formulario.alto.Text = CStr(dgvlista.Item("Alto Camion", indice).Value.ToString.Trim)
        formulario.peso_neto1.Text = CDbl(dgvlista.Item("Peso Neto Remolque", indice).Value)
        formulario.largo2.Text = CStr(dgvlista.Item("Largo Carreta", indice).Value.ToString.Trim)
        formulario.ancho2.Text = CStr(dgvlista.Item("Ancho Carreta", indice).Value.ToString.Trim)
        formulario.alto2.Text = CStr(dgvlista.Item("Alto Carreta", indice).Value.ToString.Trim)
        formulario.peso_neto2.Text = CDbl(dgvlista.Item("Peso Neto Semi-Remolque", indice).Value)
        formulario.Conf_Vehi.Text = CStr(dgvlista.Item("Configuracion Vehicular", indice).Value.ToString.Trim)
        formulario.Pes_Veh.Text = CStr(dgvlista.Item("Peso Bruto Vehicular", indice).Value.ToString.Trim)
        formulario.TxtBonificacion.Text = CStr(dgvlista.Item("Descripcion", indice).Value.ToString.Trim)

        formulario.Total.Text = CStr(dgvlista.Item("TOTAL", indice).Value.ToString.Trim)
        formulario.Pes_Transp.Text = CDbl(dgvlista.Item("Peso Bruto Transportado", indice).Value)
        ' Me.formulario.Pes_Transp.Text = CStr(dgvlista.Item("Peso Bruto Transportado", indice).Value.ToString.Trim)

        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar Constancia de Verificacion de Pesos y Medidas?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.
                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_peso_med]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.Id_peso_med, _
                    formulario.Id_guia, _
                    formulario.fecha_emision_guia.Value, _
                    formulario.observacion.Text.Trim, _
                    "M", _
                    0, "")
                    If rpta > 0 Then
                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        servidor.cancelarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    __mesajeerror = servidor.getMensageError
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        formulario.Id_peso_med = -1
        formulario.fecha_emision_guia.Value = Now
        formulario.observacion.Text = ""
        formulario.Total.Text = ""

        formulario.Id_guia = -1
        formulario.serie_guia.Text = ""
        formulario.nro_guia.Text = ""
        formulario.NombreDestinatario.Text = ""
        formulario.ruc.Text = ""
        formulario.distrito.Text = ""
        formulario.provincia.Text = ""
        formulario.departamento.Text = ""
        formulario.direccion.Text = ""

        'Me.formulario.id_vehi = -1
        formulario.nroplaca_camion.Text = ""
        formulario.nroplaca_carreta.Text = ""
        formulario.largo.Text = ""
        formulario.ancho.Text = ""
        formulario.alto.Text = ""
        formulario.peso_neto1.Text = ""
        formulario.largo2.Text = ""
        formulario.ancho2.Text = ""
        formulario.alto2.Text = ""
        formulario.peso_neto2.Text = ""
        formulario.Conf_Vehi.Text = ""
        formulario.Pes_Veh.Text = ""
        formulario.Pes_Transp.Text = ""

        txtbusca.Text = ""

        indice = -1

        lista(Nothing)
    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Constancia de Verificacion de Pesos y Medidas", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If MessageBox.Show("¿Desea eliminar Constancia de Verificacion de Pesos y Medidas?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then
                Dim rpta As Integer = -1
                Dim mensaje As String = ""
                servidor.ejecutar("[dbo].[pa_mantenimiento_peso_med]", _
                  False, _
                  rpta, _
                  mensaje, _
                  CInt(dgvlista.Item("Id Peso Medida", indice).Value), _
                  Nothing, _
                  Nothing, _
                  Nothing, _
                 "E", _
               0, "")
                If rpta = 1 Then
                    servidor.cerrarconexiontrans()
                    __mesajeerror = mensaje
                    MessageBox.Show(__mesajeerror, "Molino los Angeles", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    servidor.cancelarconexiontrans()
                    __mesajeerror = mensaje
                    MessageBox.Show(__mesajeerror, "Molino los Angeles", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexiontrans()
                MessageBox.Show(__mesajeerror, "Molino los Angeles", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        indice = -1

        lista(Nothing)
    End Sub

    Private Sub btncerrar_Click_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub


    Private Sub btnImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim FORMULARIO2 As New FrmOpcImpPes_Med1
        FORMULARIO2.ShowDialog()

        If FORMULARIO2.RBConsorcio.Checked Then
            Dim Id_peso_med As Integer = CInt(dgvlista.Item("Id Peso Medida", indice).Value)
            Dim Peso_med As New Imp_Ind
            Dim f As New frmImprimiR
            f.Nivel = "FORMULARIO_LISTA_PESO_MEDIDAS"
            f.Tabla_Imprimir = Peso_med.consultarpeso_med(Id_peso_med)
            f.Titulo_Informe = "REPORTE DE PESOS Y MEDIDAS ---> (CONSORCIO LOS ANGELES)"
            f.ShowDialog()

        ElseIf FORMULARIO2.RbMolinos.Checked Then
            Dim Id_peso_med As Integer = CInt(dgvlista.Item("Id Peso Medida", indice).Value)
            Dim Peso_med As New Imp_Ind
            Dim f As New frmImprimiR
            f.Nivel = "FORMULARIO_LISTA_PESO_MEDIDAS_MOLINOS"
            f.Tabla_Imprimir = Peso_med.consultarpeso_med(Id_peso_med)
            f.Titulo_Informe = "REPORTE DE PESOS Y MEDIDAS ---> (MOLINOS LOS ANGELES SRL)"
            f.ShowDialog()

        ElseIf FORMULARIO2.RbBantemar.Checked Then
            Dim Id_peso_med As Integer = CInt(dgvlista.Item("Id Peso Medida", indice).Value)
            Dim Peso_med As New Imp_Ind
            Dim f As New frmImprimiR
            f.Nivel = "FORMULARIO_LISTA_PESO_MEDIDAS_BANTEMAR"
            f.Tabla_Imprimir = Peso_med.consultarpeso_med(Id_peso_med)
            f.Titulo_Informe = "REPORTE DE PESOS Y MEDIDAS ---> (BANTEMAR)"
            f.ShowDialog()

        ElseIf FORMULARIO2.RbZelu.Checked Then
            Dim Id_peso_med As Integer = CInt(dgvlista.Item("Id Peso Medida", indice).Value)
            Dim Peso_med As New Imp_Ind
            Dim f As New frmImprimiR
            f.Nivel = "FORMULARIO_LISTA_PESO_MEDIDAS_ZELU"
            f.Tabla_Imprimir = Peso_med.consultarpeso_med(Id_peso_med)
            f.Titulo_Informe = "REPORTE DE PESOS Y MEDIDAS ---> (ZELU)"
            f.ShowDialog()

        End If
    End Sub

    Private Sub txtbusca_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtbusca.KeyPress
        SoloNumeros(e, False, sender.Text)
    End Sub

    Private Sub txtbusca_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        lista(txtbusca.Text)
        'SoloNumeros(e, False, sender.Text)
    End Sub
    'Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbusca.KeyDown
    '    saltar_Flechas(e)
    'End Sub
    Private Sub txtbusca_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Leave
        txtbusca.BackColor = Color.White
    End Sub
    'Private Sub txtbusca_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Enter
    '    Me.txtbusca.BackColor = Color.Moccasin
    'End Sub

    Private Sub dgvlista_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dgvlista.KeyDown
        'PARA MODIFICAR REGISTRO CON TECLA ENTER
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If (indice = -1) Then
                MessageBox.Show("Seleccione Constancia de Verificacion de Pesos y Medidas", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            formulario.Id_peso_med = CInt(dgvlista.Item("Id Peso Medida", indice).Value)
            formulario.fecha_emision_guia.Value = CDate(dgvlista.Item("Fecha", indice).Value)
            'Me.formulario.Pes_Transp.Text = CStr(dgvlista.Item("Peso Bruto Transportado", indice).Value.ToString.Trim)
            formulario.observacion.Text = CStr(dgvlista.Item("Observacion", indice).Value.ToString.Trim)


            formulario.Id_guia = CInt(dgvlista.Item("ID Guia", indice).Value)
            formulario.serie_guia.Text = CStr(dgvlista.Item("Serie", indice).Value.ToString.Trim)
            formulario.nro_guia.Text = CStr(dgvlista.Item("Nro. Guia de Remision", indice).Value.ToString.Trim)

            formulario.NombreDestinatario.Text = CStr(dgvlista.Item("Destinatario", indice).Value.ToString.Trim)
            formulario.ruc.Text = CStr(dgvlista.Item("RUC Destinatario", indice).Value.ToString.Trim)
            formulario.direccion.Text = CStr(dgvlista.Item("direccion", indice).Value.ToString.Trim)
            formulario.distrito.Text = CStr(dgvlista.Item("distrito", indice).Value.ToString.Trim)
            formulario.provincia.Text = CStr(dgvlista.Item("provincia", indice).Value.ToString.Trim)
            formulario.departamento.Text = CStr(dgvlista.Item("departamento", indice).Value.ToString.Trim)

            ' Me.formulario.id_vehi = CInt(dgvlista.Item("Id Vehiculo", indice).Value)
            formulario.nroplaca_camion.Text = CStr(dgvlista.Item("Nro. placa Camion", indice).Value.ToString.Trim)
            formulario.nroplaca_carreta.Text = CStr(dgvlista.Item("Nro. Placa Carreta", indice).Value.ToString.Trim)
            formulario.largo.Text = CStr(dgvlista.Item("Largo Camion", indice).Value.ToString.Trim)
            formulario.ancho.Text = CStr(dgvlista.Item("Ancho Camion", indice).Value.ToString.Trim)
            formulario.alto.Text = CStr(dgvlista.Item("Alto Camion", indice).Value.ToString.Trim)
            formulario.peso_neto1.Text = CDbl(dgvlista.Item("Peso Neto Remolque", indice).Value)
            formulario.largo2.Text = CStr(dgvlista.Item("Largo Carreta", indice).Value.ToString.Trim)
            formulario.ancho2.Text = CStr(dgvlista.Item("Ancho Carreta", indice).Value.ToString.Trim)
            formulario.alto2.Text = CStr(dgvlista.Item("Alto Carreta", indice).Value.ToString.Trim)
            formulario.peso_neto2.Text = CDbl(dgvlista.Item("Peso Neto Semi-Remolque", indice).Value)
            formulario.Conf_Vehi.Text = CStr(dgvlista.Item("Configuracion Vehicular", indice).Value.ToString.Trim)
            formulario.Pes_Veh.Text = CStr(dgvlista.Item("Peso Bruto Vehicular", indice).Value.ToString.Trim)

            formulario.Total.Text = CStr(dgvlista.Item("TOTAL", indice).Value.ToString.Trim)
            formulario.Pes_Transp.Text = CDbl(dgvlista.Item("Peso Bruto Transportado", indice).Value)
            ' Me.formulario.Pes_Transp.Text = CStr(dgvlista.Item("Peso Bruto Transportado", indice).Value.ToString.Trim)

            formulario.ShowDialog()
            If formulario.Aceptar = True Then
                If MessageBox.Show("¿Desea guardar Constancia de Verificacion de Pesos y Medidas?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim servidor As New clinicapacifico.clsaccesodatos
                    servidor.cadenaconexion = Ruta
                    If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.
                        Dim rpta As Integer = -1
                        Dim mensaje As String = ""
                        servidor.ejecutar("[dbo].[pa_mantenimiento_peso_med]", _
                        False, _
                        rpta, _
                        mensaje, _
                        formulario.Id_peso_med, _
                        formulario.Id_guia, _
                        formulario.fecha_emision_guia.Value, _
                        formulario.observacion.Text.Trim, _
                        "M", _
                        0, "")
                        If rpta > 0 Then
                            servidor.cerrarconexiontrans()
                            __mesajeerror = mensaje
                            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            servidor.cancelarconexiontrans()
                            __mesajeerror = mensaje
                            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        __mesajeerror = servidor.getMensageError
                        servidor.cerrarconexiontrans()
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If

            formulario.Id_peso_med = -1
            formulario.fecha_emision_guia.Value = Now
            formulario.observacion.Text = ""
            formulario.Total.Text = ""

            formulario.Id_guia = -1
            formulario.serie_guia.Text = ""
            formulario.nro_guia.Text = ""
            formulario.NombreDestinatario.Text = ""
            formulario.ruc.Text = ""
            formulario.distrito.Text = ""
            formulario.provincia.Text = ""
            formulario.departamento.Text = ""
            formulario.direccion.Text = ""

            'Me.formulario.id_vehi = -1
            formulario.nroplaca_camion.Text = ""
            formulario.nroplaca_carreta.Text = ""
            formulario.largo.Text = ""
            formulario.ancho.Text = ""
            formulario.alto.Text = ""
            formulario.peso_neto1.Text = ""
            formulario.largo2.Text = ""
            formulario.ancho2.Text = ""
            formulario.alto2.Text = ""
            formulario.peso_neto2.Text = ""
            formulario.Conf_Vehi.Text = ""
            formulario.Pes_Veh.Text = ""
            formulario.Pes_Transp.Text = ""

            txtbusca.Text = ""

            indice = -1

            lista(Nothing)

        End If
    End Sub


    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub
End Class
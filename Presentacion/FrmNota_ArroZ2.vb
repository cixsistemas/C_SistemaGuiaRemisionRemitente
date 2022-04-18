Public Class FrmNota_ArroZ2
    Private formulario As New FrmNota_ArroZ
    '  Private formulario2 As New FrmPrec_Cat
    Dim Id_nota_arroz As Integer
    Dim tabla_Nota_Arroz As DataTable
    Dim tabla_detalle_guias As DataTable
    Public Sub listar_Nota_Arroz(ByVal Numero As String)
        'Me.mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            tabla_Nota_Arroz = servidor.consultar("[dbo].[pa_listar_nota_Envio_Arroz]", Numero).Tables(0)
            If tabla_Nota_Arroz Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                Dim NroFilas As Integer = tabla_Nota_Arroz.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    dgvlista.DataSource = tabla_Nota_Arroz
                Else
                    dgvlista.DataSource = tabla_Nota_Arroz
                    servidor.cerrarconexion()
                End If
                dgvlista.Columns("Id Nota Arroz").Visible = False
                dgvlista.Columns("Id Guia").Visible = False
                dgvlista.Columns("Id Pago Detrac.").Visible = False
                dgvlista.Columns("Id Trabajador").Visible = False
                dgvlista.Columns("RUC").Visible = False
                dgvlista.Columns("Domicilio Transportista").Visible = False
                dgvlista.Columns("Brevete").Visible = False
                '  Me.dgvlista.Columns("Apellido Chofer").Visible = False
                dgvlista.Columns("Telefono Chofer").Visible = False
                'Me.dgvlista.Columns("observacion").Visible = False
                dgvlista.Columns("Telefono Destinatario").Visible = False
                dgvlista.Columns("Comentario").Visible = False
                dgvlista.Columns("Fecha").DefaultCellStyle.Format = "dd/MM/yyyy"
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Try
        '    'POSICIONA CURSOR EN ULTIMA FILA
        '    dgvlista.ClearSelection()
        '    dgvlista.CurrentCell = dgvlista.Rows(dgvlista.RowCount - 1).Cells(4)
        '    'Me.dgvlista.Refresh()
        'Catch ex As Exception
        '    MessageBox.Show("Guía de Remisión, No se encuentra registrada", "Guía de Remisión-Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try
    End Sub
    Public Sub listar_detalle_guias(ByVal idguia As Integer)
        'Me.mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            tabla_detalle_guias = servidor.consultar("[dbo].[pa_listar_detalle_guias_Nota_Arroz]", idguia).Tables(0)
            If tabla_detalle_guias Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim NroFilas As Integer = tabla_detalle_guias.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    dgvdetalle.DataSource = tabla_detalle_guias

                Else
                    dgvdetalle.DataSource = tabla_detalle_guias
                    servidor.cerrarconexion()
                End If
                dgvdetalle.Columns("ID Detalle").Visible = False
                dgvdetalle.Columns("ID Guia").Visible = False
                dgvdetalle.Columns("Id Nota Arroz").Visible = False
                dgvdetalle.Columns("Id Chofer").Visible = False
                dgvdetalle.Columns("Id Vehiculo").Visible = False
                dgvdetalle.Columns("Id Transportista").Visible = False
                dgvdetalle.Columns("Id Producto").Visible = False
                dgvdetalle.Columns("Id Logo").Visible = False
                dgvdetalle.Columns("Id Categoria").Visible = False
                dgvdetalle.Columns("Id Detalle Pago").Visible = False
                dgvdetalle.Columns("Id Pago Detrac.").Visible = False
                dgvdetalle.Columns("Id Trabajador").Visible = False
                dgvdetalle.Columns("Trabajador").Visible = False
                dgvdetalle.Columns("fecha").Visible = False
                dgvdetalle.Columns("empresa").Visible = False
                dgvdetalle.Columns("RUC").Visible = False
                dgvdetalle.Columns("Nro. Placa Remolque").Visible = False
                dgvdetalle.Columns("Nro. Placa Semi - Remolque").Visible = False
                dgvdetalle.Columns("Domicilio Transportista").Visible = False
                dgvdetalle.Columns("Nombre Chofer").Visible = False
                dgvdetalle.Columns("Apellido Chofer").Visible = False
                dgvdetalle.Columns("Telefono Chofer").Visible = False
                dgvdetalle.Columns("Brevete").Visible = False
                dgvdetalle.Columns("Telefono Destinatario").Visible = False
                dgvdetalle.Columns("Nro. Serie").Visible = False
                dgvdetalle.Columns("Numero").Visible = False
                dgvdetalle.Columns("Comentario").Visible = False
                dgvdetalle.Columns("observacion").Visible = False
                dgvdetalle.Columns("A cuenta").Visible = False
                dgvdetalle.Columns("Costo Flete").Visible = False
                dgvdetalle.Columns("Direccion Destinatario").Visible = False
                dgvdetalle.Columns("Destinatario").Visible = False
                dgvdetalle.Columns("Toneladas").Visible = False
                dgvdetalle.Columns("Logotipo").Visible = False
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FrmNota_ArroZ22_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub


    Private Sub FrmNota_ArroZ22_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        REM Obtenenemos la cadena de coneccion al servidor
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        listar_Nota_Arroz(Nothing)
    End Sub

    Private Sub dgvlista_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick
        Try
            indice = e.RowIndex
            Id_nota_arroz = dgvlista.Item("ID Nota Arroz", indice).Value
            listar_detalle_guias(Id_nota_arroz)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 6 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
    End Sub

    'Private Sub dgvdetalle_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvdetalle.CellFormatting
    '    If e.ColumnIndex = 20 Then
    '        e.CellStyle.BackColor = Color.PowderBlue
    '    End If
    'End Sub
    Private Sub dgvdetalle_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles dgvdetalle.RowsAdded
        BtnModificar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        ' Me.btnImprimir2.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
    End Sub
    Private Sub dgvdetalle_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvdetalle.RowsRemoved
        BtnModificar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        ' Me.btnImprimir2.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
    End Sub
    Private Sub Ddgvdetalle_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgvdetalle.VisibleChanged
        BtnModificar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        '  Me.btnImprimir2.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar Nota de Envio?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_nota_Arroz]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_nota_Arroz, _
                    formulario.Id_guia, _
                    formulario.id_precio, _
                    formulario.Id_Trabajador, _
                   formulario.fecha_emision_guia.Value.Date, _
                    formulario.Destinatario.Text.Trim, _
                      formulario.telefono.Text.Trim, _
                     formulario.direccion.Text.Trim, _
                        formulario.costo_flet.Text, _
                       formulario.a_cuenta.Text, _
                       formulario.toneladas.Text, _
                        formulario.observacion.Text.Trim, _
                         formulario.Comentario.Text.Trim, _
                    "N", _
                    0, "")
                    If rpta > 0 Then
                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        servidor.cancelarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    __mesajeerror = servidor.getMensageError
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        ' formulario.toneladas.Text = Val(formulario.toneladas.Text) / 1000

        formulario.id_nota_Arroz = -1
        formulario.fecha_emision_guia.Value = Now
        formulario.Destinatario.Text = ""
        formulario.telefono.Text = ""
        formulario.costo_flet.Text = ""
        formulario.toneladas.Text = ""
        formulario.a_cuenta.Text = "1000.00"
        formulario.Total.Text = ""

        formulario.Id_guia = -1
        formulario.serie_guia.Text = ""
        formulario.nro_guia.Text = ""
        formulario.txtremitente.Text = ""

        formulario.Id_Trabajador = -1
        formulario.txtTrabajador.Text = ""

        formulario.nroplaca_camion.Text = ""
        formulario.nroplaca_carreta.Text = ""
        formulario.txttransportista.Text = ""
        formulario.txtRuc.Text = ""
        formulario.txtnombre.Text = ""
        formulario.txtapellido.Text = ""
        formulario.txtBrevete.Text = ""
        formulario.txtTelef.Text = ""
        indice = -1
        listar_Nota_Arroz(Nothing)
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnModificar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Nota de Envio - Venta de Arroz", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        formulario.id_nota_Arroz = CInt(dgvlista.Item("ID Nota Arroz", indice).Value)
        formulario.fecha_emision_guia.Value = CDate(dgvlista.Item("Fecha", indice).Value)
        formulario.Destinatario.Text = CStr(dgvlista.Item("Destinatario", indice).Value.ToString.Trim)
        formulario.telefono.Text = CStr(dgvlista.Item("Telefono Destinatario", indice).Value.ToString.Trim)
        formulario.costo_flet.Text = CDbl(dgvlista.Item("Costo Flete", indice).Value)
        formulario.toneladas.Text = CDbl(dgvlista.Item("Toneladas", indice).Value)
        formulario.a_cuenta.Text = CDbl(dgvlista.Item("A Cuenta", indice).Value)
        formulario.direccion.Text = CStr(dgvlista.Item("Direccion Destinatario", indice).Value.ToString.Trim)
        formulario.observacion.Text = CStr(dgvlista.Item("observacion", indice).Value.ToString.Trim)
        formulario.Comentario.Text = CStr(dgvlista.Item("Comentario", indice).Value.ToString.Trim)

        ' Me.formulario.Total.Text = CDbl(dgvlista.Item("Total A Pagar", indice).Value)

        formulario.Id_guia = CInt(dgvlista.Item("ID Guia", indice).Value)
        formulario.serie_guia.Text = CStr(dgvlista.Item("Nro. Serie", indice).Value.ToString.Trim)
        formulario.nro_guia.Text = CStr(dgvlista.Item("Numero", indice).Value.ToString.Trim)
        formulario.txtremitente.Text = CStr(dgvlista.Item("Remitente", indice).Value.ToString.Trim)

        formulario.id_precio = CInt(dgvlista.Item("Id Pago Detrac.", indice).Value)
        formulario.Fecha_Precio.Text = CStr(dgvlista.Item("Fecha", indice).Value.ToString.Trim)

        formulario.Id_Trabajador = CInt(dgvlista.Item("Id Trabajador", indice).Value)
        formulario.txtTrabajador.Text = CStr(dgvlista.Item("Trabajador", indice).Value.ToString.Trim)

        'Me.formulario.Total.Text = CStr(dgvlista.Item("TOTAL", indice).Value.ToString.Trim)
        formulario.nroplaca_camion.Text = CStr(dgvlista.Item("Nro. Placa Remolque", indice).Value.ToString.Trim)
        formulario.nroplaca_carreta.Text = CStr(dgvlista.Item("Nro. Placa Semi - Remolque", indice).Value.ToString.Trim)
        formulario.txttransportista.Text = CStr(dgvlista.Item("Empresa", indice).Value.ToString.Trim)
        formulario.txtRuc.Text = CStr(dgvlista.Item("RUC", indice).Value.ToString.Trim)
        formulario.txtnombre.Text = CStr(dgvlista.Item("Chofer", indice).Value.ToString.Trim)
        'Me.formulario.txtapellido.Text = CStr(dgvlista.Item("Apellido Chofer", indice).Value.ToString.Trim)
        formulario.txtBrevete.Text = CStr(dgvlista.Item("Brevete", indice).Value.ToString.Trim)
        formulario.txtTelef.Text = CStr(dgvlista.Item("Telefono Chofer", indice).Value.ToString.Trim)

        'For i As Integer = 0 To dgvdetalle.Rows.Count - 1
        '    Me.formulario.Detalle.Item("sacos_cantidad", Me.formulario.Detalle.Rows.Count - 1).Value = dgvdetalle.Item("Cantidad", i).Value
        'Next

        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea Guardar Nota de Envio - Venta de Arroz?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.
                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_nota_Arroz]", _
                    False, _
                    rpta, _
                    mensaje, _
                   formulario.id_nota_Arroz, _
                    formulario.Id_guia, _
                     formulario.id_precio, _
                     formulario.Id_Trabajador, _
                   formulario.fecha_emision_guia.Value.Date, _
                    formulario.Destinatario.Text.Trim, _
                      formulario.telefono.Text.Trim, _
                     formulario.direccion.Text.Trim, _
                        formulario.costo_flet.Text, _
                       formulario.a_cuenta.Text, _
                        formulario.toneladas.Text, _
                        formulario.observacion.Text.Trim, _
                         formulario.Comentario.Text.Trim, _
                    "M", _
                    0, "")
                    If rpta > 0 Then
                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        servidor.cancelarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    __mesajeerror = servidor.getMensageError
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        formulario.id_nota_Arroz = -1
        formulario.fecha_emision_guia.Value = Now
        formulario.Destinatario.Text = ""
        formulario.telefono.Text = ""
        formulario.costo_flet.Text = ""
        formulario.toneladas.Text = ""
        formulario.a_cuenta.Text = "1000.00"
        formulario.Total.Text = ""

        formulario.Id_Trabajador = -1
        formulario.txtTrabajador.Text = ""

        formulario.Id_guia = -1
        formulario.serie_guia.Text = ""
        formulario.nro_guia.Text = ""
        formulario.txtremitente.Text = ""
        formulario.nroplaca_camion.Text = ""
        formulario.nroplaca_carreta.Text = ""
        formulario.txttransportista.Text = ""
        formulario.txtRuc.Text = ""
        formulario.txtnombre.Text = ""
        formulario.txtapellido.Text = ""
        formulario.txtBrevete.Text = ""
        formulario.txtTelef.Text = ""

        ' Me.txtbusca.Text = ""
        indice = -1
        listar_Nota_Arroz(Nothing)
        dgvdetalle.DataSource = Nothing
    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Nota de Envio - Venta de Arroz", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If MessageBox.Show("¿Desea eliminar Nota de Envio - Venta de Arroz?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then
                Dim rpta As Integer = -1
                Dim mensaje As String = ""

                servidor.ejecutar("[dbo].[pa_mantenimiento_nota_Arroz]", _
                  False, _
                  rpta, _
                  mensaje, _
                  CInt(dgvlista.Item("Id Nota Arroz", indice).Value), _
                  Nothing, _
                  Nothing, _
                  Nothing, _
                  Nothing, _
                  Nothing, _
                  Nothing, _
                  Nothing, _
                  Nothing, _
                  Nothing, _
                  Nothing, _
                   Nothing, _
                  Nothing, _
                  "E", _
               0, "")
                If rpta = 1 Then
                    servidor.cerrarconexiontrans()
                    __mesajeerror = mensaje
                    MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    servidor.cancelarconexiontrans()
                    __mesajeerror = mensaje
                    MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Else
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexiontrans()
                MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        indice = -1
        listar_Nota_Arroz(Nothing)
    End Sub

    Private Sub btncerrar_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimir.Click
        Dim f As New frmImprimiR
        f.Nivel = "FORMULARIO_LISTA_NOTA_ENVIO_ARROZ"
        f.Tabla_Imprimir = tabla_detalle_guias
        f.Titulo_Informe = "REPORTE DE NOTA DE ENVIO - VENTA DE ARROZ"
        f.ShowDialog()

        'If indice = -1 Then
        '    MessageBox.Show("Seleccione Nota de Envio - Venta de Pajilla a Imprimir", "Molinos Los Angeles", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'Else
        '    Dim Id_nota_arroz As Integer = CInt(Me.dgvlista.Item("ID Nota Arroz", indice).Value)
        '    Dim Nota_Arroz As New Imp_Ind
        '    Dim f As New frmImprimir
        '    f.Nivel = "FORMULARIO_LISTA_NOTA_ENVIO_ARROZ"
        '    f.Tabla_Imprimir = Nota_Arroz.consultarNota_Arroz(Id_nota_arroz)
        '    f.Titulo_Informe = "REPORTE DE NOTA DE ENVIO - VENTA DE ARROZ ---> (MOLINOS LOS ANGELES)"
        '    f.ShowDialog()
        'End If
    End Sub

    Private Sub txtbusca_KeyPress1(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtbusca.KeyPress
        SoloNumeros(e, False, sender.Text)
    End Sub

    Private Sub txtbusca_Leave1(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.Leave
        txtbusca.BackColor = Color.White
    End Sub

    Private Sub txtbusca_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.TextChanged
        Dim valor As String = txtbusca.Text.Trim
        listar_Nota_Arroz(valor)
        dgvdetalle.DataSource = Nothing
    End Sub

    Private Sub Pag_Minist_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Pag_Minist.LinkClicked
        Process.Start("http://www.minagri.gob.pe/portal/boletin-de-arroz/arroz-2016")
    End Sub

    Private Sub Cons_Ruc_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Cons_Ruc.LinkClicked
        Process.Start("http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias")
    End Sub

    Private Sub dgvdetalle_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvdetalle.CellContentClick
        txtLogotipo.Text = dgvdetalle.CurrentRow.Cells("Logotipo").Value.ToString()
    End Sub
End Class
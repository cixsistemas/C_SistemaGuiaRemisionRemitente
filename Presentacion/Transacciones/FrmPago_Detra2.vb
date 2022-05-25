Public Class FrmPago_Detra2
    Private formulario As New FrmPago_Detra1
    ' Dim idpagodet As Integer
    Dim idpago As Integer
    Dim tabla_pago As DataTable
    Dim tabla_detalle_pago As DataTable

    Public Sub listar_pago_det(ByVal fechainicio As Object, ByVal fechafin As Object)
        'Me.mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            tabla_pago = servidor.consultar("[dbo].[pa_listar_pago]", fechainicio, fechafin).Tables(0)
            If tabla_pago Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                Dim NroFilas As Integer = tabla_pago.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    dgvlista.DataSource = tabla_pago
                Else
                    dgvlista.DataSource = tabla_pago
                    servidor.cerrarconexion()
                End If
                dgvlista.Columns("Id Pago Detrac.").Visible = False
                dgvlista.Columns("Id Remitente").Visible = False
                dgvlista.Columns("Fecha Precios").DefaultCellStyle.Format = "dd/MM/yyyy"
                dgvlista.Columns("Fecha Emision").DefaultCellStyle.Format = "dd/MM/yyyy"
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Try
            'POSICIONA CURSOR EN ULTIMA FILA
            dgvlista.ClearSelection()
            dgvlista.CurrentCell = dgvlista.Rows(dgvlista.RowCount - 1).Cells(1)
            'Me.dgvlista.Refresh()
        Catch ex As Exception
            MessageBox.Show("Pago de Detracción, No se encuentra registrada", "Guía de Remisión-Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvdetalle.DataSource = Nothing
            txtTotSacos.Text = ""
            txtTotal.Text = ""
        End Try
    End Sub
    Public Sub listar_detalle_pago_det(ByVal idpago As Integer)
        'Me.mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            tabla_detalle_pago = servidor.consultar("[dbo].[pa_listar_detalle_pago]", idpago).Tables(0)
            If tabla_detalle_pago Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim NroFilas As Integer = tabla_detalle_pago.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    dgvdetalle.DataSource = tabla_detalle_pago
                Else
                    dgvdetalle.DataSource = tabla_detalle_pago
                    servidor.cerrarconexion()
                    ' Me.mesajeerror.Text = "LA CLINICA EL PACIFICO TIENE " + NroFilas.ToString + " MEDICO(S)"
                End If
                dgvdetalle.Columns("Id Pago Detrac.").Visible = False
                dgvdetalle.Columns("Id Detalle Pago Detrac").Visible = False
                dgvdetalle.Columns("Id Categoria").Visible = False
                dgvdetalle.Columns("Fecha").Visible = False

            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Me.dgvdetalle.Columns("cantidad")

    End Sub

    Private Sub FrmPago_Detra22_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmPago_Detra22_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        REM Obtenenemos la cadena de coneccion al servidor
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        listar_pago_det(Nothing, Nothing)
    End Sub

    Private Sub dgvlista_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick
        Try
            indice = e.RowIndex
            idpago = dgvlista.Item("Id Pago Detrac.", indice).Value
            listar_detalle_pago_det(idpago)

            Dim sumadebe As Single
            Dim sumadebe2 As Single
            Dim Col As Integer = dgvdetalle.Columns(9).Index
            Dim Col_2 As Integer = dgvdetalle.Columns(7).Index
            For Each row As DataGridViewRow In dgvdetalle.Rows
                sumadebe += Val(row.Cells(Col).Value)
                sumadebe2 += Val(row.Cells(Col_2).Value)
            Next
            txtTotal.Text = sumadebe
            txtTotSacos.Text = sumadebe2

        Catch ex As Exception
        End Try

        'Dim sumadebe As Single
        'Dim sumadebe2 As Single
        'Dim Col As Integer = Me.dgvdetalle.Columns(9).Index
        'Dim Col_2 As Integer = Me.dgvdetalle.Columns(7).Index
        'For Each row As DataGridViewRow In Me.dgvdetalle.Rows
        '    sumadebe += Val(row.Cells(Col).Value)
        '    sumadebe2 += Val(row.Cells(Col_2).Value)
        'Next
        'Me.txtTotal.Text = sumadebe
        'Me.txtTotSacos.Text = sumadebe2

    End Sub


    Private Sub dgvdetalle_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles dgvdetalle.RowsAdded
        btnmodificar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        '  Me.btnImprimir.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        'Me.btnImprimir2.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvdetalle_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvdetalle.RowsRemoved
        btnmodificar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        ' Me.btnImprimir.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        'Me.btnImprimir2.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
    End Sub

    Private Sub Ddgvdetalle_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgvdetalle.VisibleChanged
        btnmodificar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
        '  Me.btnImprimir.Enabled = CBool(IIf(dgvdetalle.Rows.Count > 0, True, False))
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog() 'presentamos formulario.
        If formulario.Aceptar = True Then
            'preguntamos si el usuario quiere o no guardar programación médica.
            If MessageBox.Show("¿Desea guardar Pago de Detracción?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                ' asignamos ruta coneccion con el servidor de la base de datos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.


                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Pago_Detrac]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_PAGO, _
                    formulario.fecha.Value.Date, _
                    formulario.txtDescripcion.Text.Trim, _
                    formulario.Fecha_Emis.Value.Date, _
                    formulario.id_remitente, _
                    "N", _
                    0, "")
                    If rpta > 0 Then
                        Dim rptaham As Integer = -1
                        Dim mensajeham As String = ""
                        For i As Integer = 0 To formulario.Detalle_Cat.Rows.Count - 1
                            servidor.ejecutar("[dbo].[pa_mantenimiento_detalle_Pago_Cat]", _
                                                                                False, _
                                                                                rptaham, _
                                                                                mensajeham, _
                                                                                Nothing, _
                                                                                rpta, _
                                                                                CInt(formulario.Detalle_Cat.Item("id_cat", i).Value), _
                                                                                CDbl(formulario.Detalle_Cat.Item("Precio", i).Value), _
                                                                                CInt(formulario.Detalle_Cat.Item("sacos_cantidad", i).Value), _
                                                                                CDbl(formulario.Detalle_Cat.Item("Ivap", i).Value), _
                                                                                "N", _
                                                                                0, "")

                        Next

                        If rptaham = 0 Then
                            servidor.cancelarconexiontrans()
                            __mesajeerror = mensajeham
                            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Else
                    __mesajeerror = servidor.getMensageError
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        formulario.id_PAGO = -1
        formulario.fecha.Value = Now
        formulario.Fecha_Emis.Value = Now
        formulario.txtDescripcion.Text = ""
        formulario.txtprecio.Text = ""
        formulario.cantidad_sacos.Text = ""

        formulario.txtsup1.Text = ""
        formulario.txtsup2.Text = ""
        formulario.txtsup3.Text = ""
        formulario.txtsup4.Text = ""
        formulario.txtsup5.Text = ""
        formulario.txtTot_Sup.Text = ""

        formulario.txtdesp1.Text = ""
        formulario.txtdesp2.Text = ""
        formulario.txtdesp3.Text = ""
        formulario.txtdesp4.Text = ""
        formulario.txtdesp5.Text = ""
        formulario.txtDespTotal.Text = ""

        formulario.txtExt1.Text = ""
        formulario.txtExt2.Text = ""
        formulario.txtExt3.Text = ""
        formulario.txtExt4.Text = ""
        formulario.txtTot_Ext.Text = ""

        formulario.txt_TOTAL.Text = ""

        formulario.id_remitente = -1
        formulario.remitente.Text = ""
        formulario.ruc.Text = ""
        formulario.cuenta.Text = ""

        formulario.Detalle_Cat.Rows.Clear()
        indice = -1

        listar_pago_det(Nothing, Nothing)
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnModificar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Pago de Detracción", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        formulario.id_PAGO = CInt(dgvlista.Item("Id Pago Detrac.", indice).Value)
        formulario.fecha.Value = CDate(dgvlista.Item("Fecha Precios", indice).Value)
        formulario.txtDescripcion.Text = CStr(dgvlista.Item("Descripcion", indice).Value)
        formulario.Fecha_Emis.Value = CDate(dgvlista.Item("Fecha Emision", indice).Value)

        formulario.id_remitente = CInt(dgvlista.Item("ID Remitente", indice).Value)
        formulario.remitente.Text = CStr(dgvlista.Item("Remitente", indice).Value)
        formulario.ruc.Text = CStr(dgvlista.Item("RUC", indice).Value.ToString.Trim)
        formulario.cuenta.Text = CStr(dgvlista.Item("Cuenta Detraccion", indice).Value.ToString.Trim)

        For i As Integer = 0 To dgvdetalle.Rows.Count - 1
            formulario.Detalle_Cat.Rows.Add()
            formulario.Detalle_Cat.Item("id_det_pago", formulario.Detalle_Cat.Rows.Count - 1).Value = dgvdetalle.Item("Id Detalle Pago Detrac", i).Value
            formulario.Detalle_Cat.Item("id_cat", formulario.Detalle_Cat.Rows.Count - 1).Value = dgvdetalle.Item("Id Categoria", i).Value
            formulario.Detalle_Cat.Item("Descripcion", formulario.Detalle_Cat.Rows.Count - 1).Value = dgvdetalle.Item("Categoria", i).Value
            formulario.Detalle_Cat.Item("Precio", formulario.Detalle_Cat.Rows.Count - 1).Value = dgvdetalle.Item("Precio", i).Value
            formulario.Detalle_Cat.Item("sacos_cantidad", formulario.Detalle_Cat.Rows.Count - 1).Value = dgvdetalle.Item("Cantidad", i).Value
            formulario.Detalle_Cat.Item("Ivap", formulario.Detalle_Cat.Rows.Count - 1).Value = dgvdetalle.Item("Ivap", i).Value
            formulario.Detalle_Cat.Item("Total", formulario.Detalle_Cat.Rows.Count - 1).Value = dgvdetalle.Item("Precio x Categoria", i).Value
        Next

        dgvdetalle.DataSource = Nothing
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            'preguntamos si el usuario quiere o no.
            If MessageBox.Show("¿Desea Guardar Pago de Detracción?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                ' asignamos ruta coneccion con el servidor de la base de datos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.


                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Pago_Detrac]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_PAGO, _
                    formulario.fecha.Value.Date, _
                    formulario.txtDescripcion.Text.Trim, _
                    formulario.Fecha_Emis.Value.Date, _
                     formulario.id_remitente, _
                    "M", _
                    0, "")
                    If rpta > 0 Then
                        Dim rptaham As Integer = -1
                        Dim mensajeham As String = ""
                        For i As Integer = 0 To formulario.Detalle_Cat.Rows.Count - 1
                            servidor.ejecutar("[dbo].[pa_mantenimiento_detalle_Pago_Cat]", _
                                                                                False, _
                                                                                rptaham, _
                                                                                mensajeham, _
                                                                                 CInt(formulario.Detalle_Cat.Item("id_det_pago", i).Value), _
                                                                                  formulario.id_PAGO, _
                                                                                CInt(formulario.Detalle_Cat.Item("id_cat", i).Value), _
                                                                                CDbl(formulario.Detalle_Cat.Item("Precio", i).Value), _
                                                                                CInt(formulario.Detalle_Cat.Item("sacos_cantidad", i).Value), _
                                                                                CDbl(formulario.Detalle_Cat.Item("Ivap", i).Value), _
                                                                                "M", _
                                                                                0, "")

                        Next

                        If rptaham = 0 Then
                            servidor.cancelarconexiontrans()
                            __mesajeerror = mensajeham
                            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Else
                    __mesajeerror = servidor.getMensageError
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        formulario.id_PAGO = -1
        formulario.fecha.Value = Now
        formulario.txtDescripcion.Text = ""
        formulario.txtprecio.Text = ""
        formulario.cantidad_sacos.Text = ""

        formulario.txtsup1.Text = ""
        formulario.txtsup2.Text = ""
        formulario.txtsup3.Text = ""
        formulario.txtsup4.Text = ""
        formulario.txtsup5.Text = ""
        formulario.txtTot_Sup.Text = ""

        formulario.txtdesp1.Text = ""
        formulario.txtdesp2.Text = ""
        formulario.txtdesp3.Text = ""
        formulario.txtdesp4.Text = ""
        formulario.txtdesp5.Text = ""
        formulario.txtDespTotal.Text = ""

        formulario.txtExt1.Text = ""
        formulario.txtExt2.Text = ""
        formulario.txtExt3.Text = ""
        formulario.txtExt4.Text = ""
        formulario.txtTot_Ext.Text = ""

        formulario.txt_TOTAL.Text = ""

        formulario.id_remitente = -1
        formulario.remitente.Text = ""
        formulario.ruc.Text = ""
        formulario.cuenta.Text = ""
        formulario.Detalle_Cat.Rows.Clear()
        indice = -1

        listar_pago_det(Nothing, Nothing)
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminar.Click
        If check_fila_grilla(dgvdetalle) = False Then
            MessageBox.Show("Haga check en la columna Seleccionar por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If MessageBox.Show("¿Desea eliminar el Detalle de Pago de Detracción?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then
                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    For i As Integer = 0 To dgvdetalle.Rows.Count - 1
                        If CBool(dgvdetalle.Item(0, i).Value) = True Then
                            servidor.ejecutar("[dbo].[pa_mantenimiento_detalle_Pago_Cat]", _
                              False, _
                              rpta, _
                              mensaje, _
                              CInt(dgvdetalle.Item("Id Detalle Pago Detrac", i).Value.ToString), _
                              Nothing, _
                              Nothing, _
                              Nothing, _
                              Nothing, _
                              Nothing, _
                             "E", _
                              0, "")
                        End If
                    Next
                    If rpta = 1 Then
                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        'Me.__mensaje.Value = __mesajeerror
                        'Me.__pagina.Value = "listapersonas.aspx"
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        servidor.cancelarconexiontrans()
                        __mesajeerror = mensaje
                        'Me.__pagina.Value = "listapersonas.aspx"
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    __mesajeerror = servidor.getMensageError
                    'Me.mesajeerror.Text = __mesajeerror
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            'indice = -1
        End If
        listar_detalle_pago_det(idpago)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        If cbFecha.Checked = True Then
            listar_pago_det(CDate(dtpfin.Value.ToShortDateString), CDate(dtpff.Value.ToString))
        Else
            listar_pago_det(Nothing, Nothing)
            'dgvdetalle.DataSource = Nothing
            'listar_detalle_pago_det(Nothing)
        End If
    End Sub
    Private Sub cbFecha_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFecha.CheckedChanged
        dtpfin.Enabled = cbFecha.Checked : dtpff.Enabled = cbFecha.Checked
        dtpfin.Value = DateSerial(Now.Date.Year, Now.Month, 1)
        dtpff.Value = DateTime.Now
        dtpfin.Focus()
    End Sub
    Private Sub dtpfin_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles dtpfin.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub dtpff_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles dtpff.KeyPress
        saltar_ENTER(e)
        'Me.btnBuscar.Focus()
    End Sub


    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub dgvdetalle_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvdetalle.CellContentClick

    End Sub

    Private Sub dgvdetalle_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dgvdetalle.CellFormatting
        Try
            'If e.ColumnIndex = 5 Then
            '    e.CellStyle.BackColor = Color.PowderBlue
            'End If

            If e.ColumnIndex = 5 Then
                e.CellStyle.BackColor = Color.LightYellow
                dgvdetalle.Columns("Cantidad").DefaultCellStyle.ForeColor = Color.Blue
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_PAGINA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTN_PAGINA.Click
        Process.Start("http://www.minagri.gob.pe/portal/boletin-de-arroz/arroz-2016")
    End Sub

    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        Try
            If e.ColumnIndex = 1 Then
                e.CellStyle.BackColor = Color.LightYellow
            End If

          

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTotal_Click(sender As Object, e As EventArgs) Handles txtTotal.Click

    End Sub
End Class
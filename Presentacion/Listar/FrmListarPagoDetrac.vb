Public Class FrmListarPagoDetrac
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
                MessageBox.Show(__mesajeerror, "Guía de remisión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

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
                dgvlista.Columns("RUC").Visible = False
                dgvlista.Columns("Cuenta Detraccion").Visible = False
                dgvlista.Columns("Fecha Emision").Visible = False
                dgvlista.Columns("Descripcion").Visible = False

            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de remisión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Try
            'POSICIONA CURSOR EN ULTIMA FILA
            dgvlista.ClearSelection()
            dgvlista.CurrentCell = dgvlista.Rows(dgvlista.RowCount - 2).Cells(1)
            'Me.dgvlista.Refresh()
        Catch ex As Exception
            MessageBox.Show("Pago de Detracción, No se encuentra registrada", "Guía de Remisión-Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvdetalle.DataSource = Nothing
            'Me.txtTotSacos.Text = ""
            'Me.txtTotal.Text = ""
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
                MessageBox.Show(__mesajeerror, "Guía de remisión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                dgvdetalle.Columns("Cantidad").Visible = False
                dgvdetalle.Columns("Ivap").Visible = False
                dgvdetalle.Columns("Precio x Categoria").Visible = False

            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de remisión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Me.dgvdetalle.Columns("cantidad")

    End Sub


    Private Sub FrmListarPagoDetraci_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Obtenenemos la cadena de coneccion al servidor
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        listar_pago_det(Nothing, Nothing)
    End Sub

    Private Sub FrmListarPagoDetraci_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If

        'PARA REGISTRAR CON TECLA INSERT
        If e.KeyCode = Keys.Insert Then
            e.SuppressKeyPress = True

            formulario.ShowDialog() 'presentamos formulario.
            If formulario.Aceptar = True Then
                'preguntamos si el usuario quiere o no guardar programación médica.
                If MessageBox.Show("¿Desea guardar Pago de Detraccion?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
                        formulario.fecha.Value, _
                        formulario.txtDescripcion.Text.Trim, _
                        formulario.Fecha_Emis.Value, _
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
            formulario.Detalle_Cat.Rows.Clear()
            indice = -1

            listar_pago_det(Nothing, Nothing)

        End If
    End Sub

    Private Sub dgvlista_CellClick1(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick

    End Sub
    Private Sub dgvlista_CellLeave1(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellLeave
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellContentClick_1(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick
        indice = e.RowIndex
    End Sub

    Private Sub dgvlista_CellDoubleClick1(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellDoubleClick
        indice = e.RowIndex
        Close()
    End Sub

    'Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellEnter
    '    indice = e.RowIndex
    '    'Me.Close()
    'End Sub

    Private Sub dgvlista_CellFormatting1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightCyan
        End If
    End Sub
    Private Sub dgvlista_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs)
        Try
            indice = e.RowIndex
            idpago = dgvlista.Item("Id Pago Detrac.", indice).Value
            listar_detalle_pago_det(idpago)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btn_Acep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Acep.Click
        Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog() 'presentamos formulario.
        If formulario.Aceptar = True Then
            'preguntamos si el usuario quiere o no guardar programación médica.
            If MessageBox.Show("¿Desea guardar Pago de Detraccion?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
                    formulario.fecha.Value, _
                    formulario.txtDescripcion.Text.Trim, _
                    formulario.Fecha_Emis.Value, _
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
        formulario.Detalle_Cat.Rows.Clear()
        indice = -1

        listar_pago_det(Nothing, Nothing)
    End Sub

    Private Sub btnbusca_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbusca.Click
        If cbFecha.Checked = True Then
            listar_pago_det(CDate(dtpfin.Value.ToShortDateString), CDate(dtpff.Value.ToString))
        Else
            listar_pago_det(Nothing, Nothing)
            'dgvdetalle.DataSource = Nothing
            'listar_detalle_pago_det(Nothing)
        End If
    End Sub

    Private Sub cbFecha_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFecha.CheckedChanged
        dtpfin.Enabled = cbFecha.Checked : dtpff.Enabled = cbFecha.Checked
        dtpfin.Value = DateSerial(Now.Date.Year, Now.Month, 1)
        dtpff.Value = DateTime.Now
        dtpfin.Focus()
    End Sub
End Class
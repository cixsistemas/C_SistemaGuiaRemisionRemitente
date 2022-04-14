Public Class FrmCliente2
    Private formulario As New FrmCliente1

    Dim tabla_Cliente As DataTable = Nothing

    Public Sub lista(ByVal criterio As String)
        LBF2.ForeColor = Color.Red
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_Cliente]", criterio).Tables.Count > 0 Then
                tabla_Cliente = servidor.consultar("[dbo].[pa_listar_Cliente]", criterio).Tables(0)
            End If
            If tabla_Cliente Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY CLIENTES PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_Cliente
                Dim NroFilas As Integer = tabla_Cliente.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY CLIENTES PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("Id Cliente").Visible = False
                    dgvlista.Columns("Id Tipo Cliente").Visible = False
                    dgvlista.Columns("Id Zona").Visible = False
                    dgvlista.Columns("Id Tipo Dcto").Visible = False
                    dgvlista.Columns("Id Ubigeo").Visible = False
                    'Me.dgvlista.Columns("Fecha Nac.").DefaultCellStyle.Format = "dd/MM/yyyy"
                    'Me.dgvlista.Columns("Fecha Ingreso").DefaultCellStyle.Format = "dd/MM/yyyy"
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Cliente(s)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Molinos los Angeles", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub FrmCliente2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESCAPE
        'If (e.KeyCode = Keys.Enter) Then
        '    Me.Close()
        'End If
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If


        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If
    End Sub


    Private Sub FrmCliente2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
    End Sub

    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellEnter
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
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

    Private Sub dgvlista_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgvlista.VisibleChanged
        btnmodificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvlista_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick
        'indice = e.RowIndex
    End Sub

    Private Sub txtbusca_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.TextChanged
        lista(txtbusca.Text)
    End Sub
    Private Sub txtbusca_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.Leave
        txtbusca.BackColor = Color.White
    End Sub
    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea Guardar Cliente?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Cliente]", _
                    False, _
                    rpta, _
                    mensaje, _
                   formulario.id_Cliente, _
                    formulario.nombre.Text.Trim, _
                    formulario.txtTelefono.Text.Trim, _
                    formulario.txtDireccion.Text.Trim, _
                    formulario.txtCorreo.Text.Trim, _
                     formulario.nro_doc.Text.Trim, _
                    formulario.txtLinea_Credito.Text, _
                    formulario.txtDescrip.Text.Trim, _
                    formulario.id_Zona, _
                     formulario.id_tipo_Dcto, _
                      formulario.id_tipo_Cliente, _
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

        formulario.id_Cliente = -1
        formulario.nombre.Text = ""
        formulario.txtTelefono.Text = ""
        formulario.txtCorreo.Text = ""
        formulario.txtDireccion.Text = ""
        formulario.nro_doc.Text = "0"
        formulario.txtLinea_Credito.Text = "0"
        formulario.txtDescrip.Text = ""

        formulario.id_Zona = -1
        formulario.txtZona.Text = ""
        formulario.txtDistrito.Text = ""

        formulario.id_tipo_Cliente = -1
        formulario.txttipo_Cliente.Text = ""

        formulario.id_tipo_Dcto = -1
        formulario.txtTipo_Dcto.Text = ""

        indice = -1
        lista(Nothing)
    End Sub


    Private Sub BtnModificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnModificar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Cliente", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        formulario.id_Cliente = CInt(dgvlista.Item("Id Cliente", indice).Value)
        formulario.nombre.Text = CStr(dgvlista.Item("Cliente", indice).Value)

        formulario.txtTelefono.Text = CStr(dgvlista.Item("Telefono", indice).Value.ToString.Trim)
        formulario.txtDireccion.Text = CStr(dgvlista.Item("Direccion", indice).Value.ToString.Trim)
        formulario.txtCorreo.Text = CStr(dgvlista.Item("Correo", indice).Value.ToString.Trim)
        formulario.txtLinea_Credito.Text = CDbl(dgvlista.Item("Linea de Credito", indice).Value)
        formulario.txtDescrip.Text = CStr(dgvlista.Item("Descripcion", indice).Value.ToString.Trim)

        formulario.id_Zona = CInt(dgvlista.Item("Id Zona", indice).Value)
        formulario.txtZona.Text = CStr(dgvlista.Item("Zona", indice).Value.ToString.Trim)
        formulario.txtDistrito.Text = CStr(dgvlista.Item("Distrito", indice).Value.ToString.Trim)

        formulario.id_tipo_Dcto = CInt(dgvlista.Item("Id Tipo Dcto", indice).Value)
        formulario.txtTipo_Dcto.Text = CStr(dgvlista.Item("Tipo Dcto", indice).Value.ToString.Trim)
        formulario.nro_doc.Text = CStr(dgvlista.Item("Nro Dcto", indice).Value.ToString.Trim)

        formulario.id_tipo_Cliente = CInt(dgvlista.Item("Id Tipo Cliente", indice).Value)
        formulario.txttipo_Cliente.Text = CStr(dgvlista.Item("Tipo de Cliente", indice).Value.ToString.Trim)





        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar Cliente?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Cliente]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_Cliente, _
                    formulario.nombre.Text.Trim, _
                    formulario.txtTelefono.Text.Trim, _
                    formulario.txtDireccion.Text.Trim, _
                    formulario.txtCorreo.Text.Trim, _
                     formulario.nro_doc.Text.Trim, _
                    formulario.txtLinea_Credito.Text, _
                    formulario.txtDescrip.Text.Trim, _
                    formulario.id_Zona, _
                     formulario.id_tipo_Dcto, _
                      formulario.id_tipo_Cliente, _
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

       formulario.id_Cliente = -1
        formulario.nombre.Text = ""
        formulario.txtTelefono.Text = ""
        formulario.txtCorreo.Text = ""
        formulario.txtDireccion.Text = ""
        formulario.nro_doc.Text = "0"
        formulario.txtLinea_Credito.Text = "0"
        formulario.txtDescrip.Text = ""

        formulario.id_Zona = -1
        formulario.txtZona.Text = ""
        formulario.txtDistrito.Text = ""

        formulario.id_tipo_Cliente = -1
        formulario.txttipo_Cliente.Text = ""

        formulario.id_tipo_Dcto = -1
        formulario.txtTipo_Dcto.Text = ""

        indice = -1

        lista(Nothing)
    End Sub
    Private Sub dgvlista_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dgvlista.KeyDown
        'PARA MODIFICAR REGISTRO CON TECLA ENTER
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If (indice = -1) Then
                MessageBox.Show("Seleccione Cliente", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            formulario.id_Cliente = CInt(dgvlista.Item("Id Cliente", indice).Value)
            formulario.nombre.Text = CStr(dgvlista.Item("Cliente", indice).Value)

            formulario.txtTelefono.Text = CStr(dgvlista.Item("Telefono", indice).Value.ToString.Trim)
            formulario.txtDireccion.Text = CStr(dgvlista.Item("Direccion", indice).Value.ToString.Trim)
            formulario.txtCorreo.Text = CStr(dgvlista.Item("Correo", indice).Value.ToString.Trim)
            formulario.txtLinea_Credito.Text = CDbl(dgvlista.Item("Linea de Credito", indice).Value)
            formulario.txtDescrip.Text = CStr(dgvlista.Item("Descripcion", indice).Value.ToString.Trim)

            formulario.id_Zona = CInt(dgvlista.Item("Id Zona", indice).Value)
            formulario.txtZona.Text = CStr(dgvlista.Item("Zona", indice).Value.ToString.Trim)
            formulario.txtDistrito.Text = CStr(dgvlista.Item("Distrito", indice).Value.ToString.Trim)

            formulario.id_tipo_Dcto = CInt(dgvlista.Item("Id Tipo Dcto", indice).Value)
            formulario.txtTipo_Dcto.Text = CStr(dgvlista.Item("Tipo Dcto", indice).Value.ToString.Trim)
            formulario.nro_doc.Text = CStr(dgvlista.Item("Nro Dcto", indice).Value.ToString.Trim)

            formulario.id_tipo_Cliente = CInt(dgvlista.Item("Id Tipo Cliente", indice).Value)
            formulario.txttipo_Cliente.Text = CStr(dgvlista.Item("Tipo de Cliente", indice).Value.ToString.Trim)





            formulario.ShowDialog()
            If formulario.Aceptar = True Then
                If MessageBox.Show("¿Desea guardar Cliente?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim servidor As New clinicapacifico.clsaccesodatos
                    servidor.cadenaconexion = Ruta
                    If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                        Dim rpta As Integer = -1
                        Dim mensaje As String = ""
                        servidor.ejecutar("[dbo].[pa_mantenimiento_Cliente]", _
                        False, _
                        rpta, _
                        mensaje, _
                        formulario.id_Cliente, _
                        formulario.nombre.Text.Trim, _
                        formulario.txtTelefono.Text.Trim, _
                        formulario.txtDireccion.Text.Trim, _
                        formulario.txtCorreo.Text.Trim, _
                         formulario.nro_doc.Text.Trim, _
                        formulario.txtLinea_Credito.Text, _
                        formulario.txtDescrip.Text.Trim, _
                        formulario.id_Zona, _
                         formulario.id_tipo_Dcto, _
                          formulario.id_tipo_Cliente, _
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

            formulario.id_Cliente = -1
            formulario.nombre.Text = ""
            formulario.txtTelefono.Text = ""
            formulario.txtCorreo.Text = ""
            formulario.txtDireccion.Text = ""
            formulario.nro_doc.Text = ""
            formulario.txtLinea_Credito.Text = ""
            formulario.txtDescrip.Text = ""

            formulario.id_Zona = -1
            formulario.txtZona.Text = ""
            formulario.txtDistrito.Text = ""

            formulario.id_tipo_Cliente = -1
            formulario.txttipo_Cliente.Text = ""

            formulario.id_tipo_Dcto = -1
            formulario.txtTipo_Dcto.Text = ""

            indice = -1

            lista(Nothing)
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Cliente", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If MessageBox.Show("¿Desea eliminar Cliente?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then
                Dim rpta As Integer = -1
                Dim mensaje As String = ""

                servidor.ejecutar("[dbo].[pa_mantenimiento_Cliente]", _
                  False, _
                  rpta, _
                  mensaje, _
                  CInt(dgvlista.Item("Id Cliente", indice).Value), _
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

    Private Sub btnImprimir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimir.Click

    End Sub
End Class
Public Class FrmTrabajador2
    Private formulario As New FrmTrabajador1

    Dim tabla_trabajador As DataTable = Nothing

    Public Sub lista(ByVal criterio As String)
        LBF2.ForeColor = Color.Red
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_trabajador]", criterio).Tables.Count > 0 Then
                tabla_trabajador = servidor.consultar("[dbo].[pa_listar_trabajador]", criterio).Tables(0)
            End If
            If tabla_trabajador Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY TRABAJADORES PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_trabajador
                Dim NroFilas As Integer = tabla_trabajador.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY TRABAJADORES PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("Id Trabajador").Visible = False
                    dgvlista.Columns("Id Tipo Trabaj").Visible = False
                    dgvlista.Columns("Id Tipo Dcto").Visible = False
                    dgvlista.Columns("Nombres").Visible = False
                    dgvlista.Columns("Apellidos").Visible = False
                    dgvlista.Columns("Fecha Nac.").DefaultCellStyle.Format = "dd/MM/yyyy"
                    dgvlista.Columns("Fecha Ingreso").DefaultCellStyle.Format = "dd/MM/yyyy"
                    mesajeerror.Text = "Gu�a de Remisi�n � Remitente tiene " + NroFilas.ToString + " Trabajador(es)"
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

    Private Sub FrmTrabajador22_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub FrmTrabajador22_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
    End Sub

    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellEnter
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
    End Sub

    Private Sub dgvlista_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles dgvlista.RowsAdded
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

    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("�Desea Guardar Trabajador?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conecci�n y iniciamos transacci�n.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Trabajador]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_trabajador, _
                    formulario.nombre.Text.Trim, _
                    formulario.apellido.Text.Trim, _
                    formulario.nro_doc.Text.Trim, _
                    formulario.txtDireccion.Text.Trim, _
                    formulario.txtTelefono.Text.Trim, _
                    formulario.txtCorreo.Text.Trim, _
                    formulario.Fecha_Nacimiento.Value.Date, _
                     formulario.Fecha_Ingreso.Value.Date, _
                    formulario.txtDescrip.Text.Trim, _
                    formulario.id_tipo_trabaj, _
                     formulario.id_tipo_Dcto, _
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

        formulario.id_trabajador = -1
        formulario.nombre.Text = ""
        formulario.apellido.Text = ""
        formulario.nro_doc.Text = ""
        formulario.txtDireccion.Text = ""
        formulario.txtTelefono.Text = ""
        formulario.txtCorreo.Text = ""
        formulario.Fecha_Nacimiento.Value = Now
        formulario.Fecha_Ingreso.Value = Now
        formulario.txtDescrip.Text = ""
        formulario.id_tipo_trabaj = -1
        formulario.txttipo_trabaj.Text = ""
        formulario.id_tipo_Dcto = -1
        formulario.nro_doc.Text = ""


        indice = -1

        lista(Nothing)
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnModificar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Chofer", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        formulario.id_trabajador = CInt(dgvlista.Item("Id Trabajador", indice).Value)
        formulario.nombre.Text = CStr(dgvlista.Item("Nombres", indice).Value)
        formulario.apellido.Text = CStr(dgvlista.Item("Apellidos", indice).Value.ToString.Trim)

        formulario.id_tipo_Dcto = CInt(dgvlista.Item("Id Tipo Dcto", indice).Value)
        formulario.txtTipo_Dcto.Text = CStr(dgvlista.Item("Tipo de Documento", indice).Value.ToString.Trim)
        formulario.nro_doc.Text = CStr(dgvlista.Item("Nro Dcto", indice).Value.ToString.Trim)

        formulario.id_tipo_trabaj = CInt(dgvlista.Item("Id Tipo Trabaj", indice).Value)
        formulario.txttipo_trabaj.Text = CStr(dgvlista.Item("Tipo de Trabajador", indice).Value.ToString.Trim)

        formulario.txtDireccion.Text = CStr(dgvlista.Item("Direccion", indice).Value.ToString.Trim)
        formulario.txtTelefono.Text = CStr(dgvlista.Item("Telefono", indice).Value.ToString.Trim)
        formulario.txtCorreo.Text = CStr(dgvlista.Item("Correo", indice).Value.ToString.Trim)

        formulario.Fecha_Nacimiento.Value = CDate(dgvlista.Item("Fecha Nac.", indice).Value)
        formulario.Fecha_Ingreso.Value = CDate(dgvlista.Item("Fecha Ingreso", indice).Value)


        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("�Desea guardar Trabajador?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conecci�n y iniciamos transacci�n.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Trabajador]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_trabajador, _
                    formulario.nombre.Text.Trim, _
                    formulario.apellido.Text.Trim, _
                    formulario.nro_doc.Text.Trim, _
                    formulario.txtDireccion.Text.Trim, _
                    formulario.txtTelefono.Text.Trim, _
                    formulario.txtCorreo.Text.Trim, _
                    formulario.Fecha_Nacimiento.Value.Date, _
                     formulario.Fecha_Ingreso.Value.Date, _
                    formulario.txtDescrip.Text.Trim, _
                    formulario.id_tipo_trabaj, _
                     formulario.id_tipo_Dcto, _
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

        formulario.id_trabajador = -1
        formulario.nombre.Text = ""
        formulario.apellido.Text = ""
        formulario.nro_doc.Text = ""
        formulario.txtDireccion.Text = ""
        formulario.txtTelefono.Text = ""
        formulario.txtCorreo.Text = ""
        formulario.Fecha_Nacimiento.Value = Now
        formulario.Fecha_Ingreso.Value = Now
        formulario.txtDescrip.Text = ""
        formulario.id_tipo_trabaj = -1
        formulario.txttipo_trabaj.Text = ""
        formulario.id_tipo_Dcto = -1
        formulario.nro_doc.Text = ""
        indice = -1

        lista(Nothing)
    End Sub

    Private Sub dgvlista_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dgvlista.KeyDown
        'PARA MODIFICAR REGISTRO CON TECLA ENTER
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If (indice = -1) Then
                MessageBox.Show("Seleccione Chofer", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            formulario.id_trabajador = CInt(dgvlista.Item("Id Trabajador", indice).Value)
            formulario.nombre.Text = CStr(dgvlista.Item("Nombres", indice).Value)
            formulario.apellido.Text = CStr(dgvlista.Item("Apellidos", indice).Value.ToString.Trim)

            formulario.id_tipo_Dcto = CInt(dgvlista.Item("Id Tipo Dcto", indice).Value)
            formulario.txtTipo_Dcto.Text = CStr(dgvlista.Item("Tipo de Documento", indice).Value.ToString.Trim)
            formulario.nro_doc.Text = CStr(dgvlista.Item("Nro Dcto", indice).Value.ToString.Trim)

            formulario.id_tipo_trabaj = CInt(dgvlista.Item("Id Tipo Trabaj", indice).Value)
            formulario.txttipo_trabaj.Text = CStr(dgvlista.Item("Tipo de Trabajador", indice).Value.ToString.Trim)

            formulario.txtDireccion.Text = CStr(dgvlista.Item("Direccion", indice).Value.ToString.Trim)
            formulario.txtTelefono.Text = CStr(dgvlista.Item("Telefono", indice).Value.ToString.Trim)
            formulario.txtCorreo.Text = CStr(dgvlista.Item("Correo", indice).Value.ToString.Trim)

            formulario.Fecha_Nacimiento.Value = CDate(dgvlista.Item("Fecha Nac.", indice).Value)
            formulario.Fecha_Ingreso.Value = CDate(dgvlista.Item("Fecha Ingreso", indice).Value)


            formulario.ShowDialog()
            If formulario.Aceptar = True Then
                If MessageBox.Show("�Desea guardar CHOFER?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim servidor As New clinicapacifico.clsaccesodatos
                    servidor.cadenaconexion = Ruta
                    If servidor.abrirconexiontrans = True Then 'abrimos conecci�n y iniciamos transacci�n.

                        Dim rpta As Integer = -1
                        Dim mensaje As String = ""
                        servidor.ejecutar("[dbo].[pa_mantenimiento_Trabajador]", _
                        False, _
                        rpta, _
                        mensaje, _
                        formulario.id_trabajador, _
                        formulario.nombre.Text.Trim, _
                        formulario.apellido.Text.Trim, _
                        formulario.nro_doc.Text.Trim, _
                        formulario.txtDireccion.Text.Trim, _
                        formulario.txtTelefono.Text.Trim, _
                        formulario.txtCorreo.Text.Trim, _
                        formulario.Fecha_Nacimiento.Value.Date, _
                         formulario.Fecha_Ingreso.Value.Date, _
                        formulario.txtDescrip.Text.Trim, _
                        formulario.id_tipo_trabaj, _
                         formulario.id_tipo_Dcto, _
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

            formulario.id_trabajador = -1
            formulario.nombre.Text = ""
            formulario.apellido.Text = ""
            formulario.nro_doc.Text = ""
            formulario.txtDireccion.Text = ""
            formulario.txtTelefono.Text = ""
            formulario.txtCorreo.Text = ""
            formulario.Fecha_Nacimiento.Value = Now
            formulario.Fecha_Ingreso.Value = Now
            formulario.txtDescrip.Text = ""
            formulario.id_tipo_trabaj = -1
            formulario.txttipo_trabaj.Text = ""
            formulario.id_tipo_Dcto = -1
            formulario.nro_doc.Text = ""
            indice = -1

            lista(Nothing)

        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Trabajador", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If MessageBox.Show("�Desea eliminar Trabajador?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then
                Dim rpta As Integer = -1
                Dim mensaje As String = ""

                servidor.ejecutar("[dbo].[pa_mantenimiento_Trabajador]", _
                  False, _
                  rpta, _
                  mensaje, _
                  CInt(dgvlista.Item("Id Trabajador", indice).Value), _
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
End Class
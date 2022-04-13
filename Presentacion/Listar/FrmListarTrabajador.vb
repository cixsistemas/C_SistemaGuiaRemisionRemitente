Public Class FrmListarTrabajador
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
                    dgvlista.Columns("Fecha Nac.").Visible = False
                    dgvlista.Columns("Fecha Ingreso").Visible = False
                    dgvlista.Columns("Correo").Visible = False
                    dgvlista.Columns("Descripcion").Visible = False
                    'Me.dgvlista.Columns("Fecha Nac.").DefaultCellStyle.Format = "dd/MM/yyyy"
                    'Me.dgvlista.Columns("Fecha Ingreso").DefaultCellStyle.Format = "dd/MM/yyyy"
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Trabajador(es)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Molinos los Angeles", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FrmListarTrabajador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
    End Sub

    Private Sub dgvlista_CellClick1(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub

    Private Sub dgvlista_CellDoubleClick1(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellDoubleClick
        indice = e.RowIndex
        Close()
    End Sub

    Private Sub dgvlista_CellLeave1(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellLeave
        indice = e.RowIndex
    End Sub

    Private Sub btn_Acep_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Acep.Click
        Close()
    End Sub
    Private Sub txtbusca_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        lista(txtbusca.Text)
    End Sub

    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar Chofer?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

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
                    formulario.Fecha_Nacimiento.Value, _
                     formulario.Fecha_Ingreso.Value, _
                    formulario.txtDescrip.Text.Trim, _
                    formulario.id_tipo_trabaj, _
                     formulario.id_tipo_Dcto, _
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

    Private Sub FrmListarTrabajador_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown

        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If


        'PARA REGISTRAR CON TECLA INSERT
        If e.KeyCode = Keys.Insert Then
            e.SuppressKeyPress = True

            formulario.ShowDialog()
            If formulario.Aceptar = True Then
                If MessageBox.Show("¿Desea guardar Chofer?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim servidor As New clinicapacifico.clsaccesodatos
                    servidor.cadenaconexion = Ruta
                    If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

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
                        formulario.Fecha_Nacimiento.Value, _
                         formulario.Fecha_Ingreso.Value, _
                        formulario.txtDescrip.Text.Trim, _
                        formulario.id_tipo_trabaj, _
                         formulario.id_tipo_Dcto, _
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
End Class
Public Class FrmListarCliente
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

    Private Sub btn_Acep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Acep.Click
        Close()
    End Sub

    Private Sub FrmListarCliente_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If

        'PARA REGISTRAR CON TECLA INSERT
        If e.KeyCode = Keys.Insert Then
            e.SuppressKeyPress = True
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

    Private Sub FrmListarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
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
    End Sub

    Private Sub txtbusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        lista(txtbusca.Text)
        ' Aplicar_Filtro()
    End Sub
    'Private Sub txtbusca_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Leave
    '    Me.txtbusca.BackColor = Color.White
    'End Sub
    'Private Sub txtbusca_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Enter
    '    Me.txtbusca.BackColor = Color.Moccasin
    'End Sub

    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub

    Private Sub dgvlista_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick

    End Sub

    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightCyan
        End If
    End Sub
End Class
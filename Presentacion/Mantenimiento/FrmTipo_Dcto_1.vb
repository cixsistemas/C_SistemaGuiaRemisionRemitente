Public Class FrmTipo_Dcto_1
    Private formulario As New FrmTipo_Dcto_2

    Dim tabla_Tipo_Documento As DataTable = Nothing
    Public Sub lista(ByVal criterio As String)
        mesajeerror.ForeColor = Color.Blue
        LBF2.ForeColor = Color.Red
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_tipo_Dcto]", criterio).Tables.Count > 0 Then
                tabla_Tipo_Documento = servidor.consultar("[dbo].[pa_listar_tipo_Dcto]", criterio).Tables(0)
            End If
            If tabla_Tipo_Documento Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY TIPO DE DOCUMENTO DE IDENTIDAD PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                DgvLista.DataSource = tabla_Tipo_Documento
                Dim NroFilas As Integer = tabla_Tipo_Documento.Rows.Count
                If NroFilas = 0 Then
                    DgvLista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY TIPO DE DOCUMENTO DE INDENTIDAD PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("Id Tipo Dcto").Visible = False
                    'Me.dgvlista.Columns("Nombre").Visible = False
                    'Me.dgvlista.Columns("Apellido").Visible = False
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Tipo(s) de Documento(s) de Identidad"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub FrmTipo_Dcto_1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If
    End Sub


    Private Sub FrmTipo_Dcto_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
    End Sub

    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellEnter
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 2 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
    End Sub
    Private Sub dgvlista_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvlista.RowsAdded
        btnmodificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        'Me.btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvlista_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvlista.RowsRemoved
        btnmodificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        ' Me.btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvlista_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvlista.VisibleChanged
        btnmodificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        'Me.btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvlista_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick
        'indice = e.RowIndex
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea Guardar Tipo de Documento de Identidad?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Tipo_de_Documento_de_Identidad]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_Tipo_Documento, _
                     formulario.TxtCodigo.Text.Trim, _
                    formulario.TxtNombre.Text.Trim, _
                    formulario.TxtSiglas.Text.Trim, _
                   formulario.TxtDescrip.Text.Trim, _
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

        formulario.id_Tipo_Documento = -1
        formulario.TxtNombre.Text = ""
        formulario.TxtCodigo.Text = ""
        formulario.TxtDescrip.Text = ""

        indice = -1

        lista(Nothing)
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Tipo de Documento de Identidad", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        formulario.id_Tipo_Documento = CInt(dgvlista.Item("Id Tipo Dcto", indice).Value)
        formulario.TxtCodigo.Text = CStr(DgvLista.Item("Codigo", indice).Value)
        formulario.TxtNombre.Text = CStr(dgvlista.Item("Tipo de Dcto", indice).Value.ToString.Trim)
        formulario.TxtSiglas.Text = CStr(DgvLista.Item("Siglas", indice).Value.ToString.Trim)
        formulario.TxtDescrip.Text = CStr(DgvLista.Item("Descripcion", indice).Value.ToString.Trim)


        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea Guardar Tipo de Documento de Identidad?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.
                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Tipo_de_Documento_de_Identidad]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_Tipo_Documento, _
                     formulario.TxtCodigo.Text.Trim, _
                    formulario.TxtNombre.Text.Trim, _
                    formulario.TxtSiglas.Text.Trim, _
                   formulario.TxtDescrip.Text.Trim, _
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

        formulario.id_Tipo_Documento = -1
        formulario.TxtNombre.Text = ""
        formulario.TxtCodigo.Text = ""
        formulario.TxtDescrip.Text = ""

        indice = -1

        lista(Nothing)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Tipo de Documento de Identidad", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MessageBox.Show("¿Desea Eliminar Tipo de Documento de Identidad?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then
                Dim rpta As Integer = -1
                Dim mensaje As String = ""
                servidor.ejecutar("[dbo].[pa_mantenimiento_Tipo_de_Documento_de_Identidad]", _
                  False, _
                  rpta, _
                  mensaje, _
                  CInt(dgvlista.Item("Id Tipo de Documento", indice).Value), _
                  Nothing, _
                  Nothing, _
                  Nothing, _
                 "E", _
                  0, "")
                If rpta = 1 Then
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
        indice = -1
        lista(Nothing)
    End Sub
    Private Sub TxtBusca_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Enter
        ' Me.TxtBusca.BackColor = Color.Azure
    End Sub

    Private Sub TxtBusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            DgvLista.Focus()
        End If
    End Sub

    Private Sub TxtBusca_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Leave
        TxtBusca.BackColor = Color.White
    End Sub

    Private Sub TxtBusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        lista(TxtBusca.Text)
    End Sub
End Class
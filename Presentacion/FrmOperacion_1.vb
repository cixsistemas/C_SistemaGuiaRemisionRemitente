Public Class FrmOperacion_1
    Private formulario As New FrmOperacion_2

    Dim tabla_Operacion As DataTable = Nothing
    Public Sub lista(ByVal Tipo_Operacion As Integer, ByVal Criterio As String)
        LBF2.ForeColor = Color.Red
        LBF3.ForeColor = Color.Red
        LBF4.ForeColor = Color.Red
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_Listar_Operacion]", Tipo_Operacion, Criterio).Tables.Count > 0 Then
                tabla_Operacion = servidor.consultar("[dbo].[pa_Listar_Operacion]", Tipo_Operacion, Criterio).Tables(0)
            End If
            If tabla_Operacion Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY OPERACION(es) PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_Operacion
                Dim NroFilas As Integer = tabla_Operacion.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY OPERACION(es) PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("Id Operacion").Visible = False
                    dgvlista.Columns("Id Tipo de Operacion").Visible = False
                    'Me.dgvlista.Columns("Apellido").Visible = False
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Operacion(es)"
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
    Private Sub FrmOperacion_1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            RbEntrada.Checked = True
        End If
        If e.KeyCode = Keys.F3 Then
            e.SuppressKeyPress = True
            RbSalida.Checked = True
        End If
        If e.KeyCode = Keys.F4 Then
            e.SuppressKeyPress = True
            RbTodos.Checked = True
        End If
    End Sub

    Private Sub FrmOperacion_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(4, Nothing)
        RbTodos.Checked = True
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

    Private Sub dgvlista_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick
        'indice = e.RowIndex
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea Guardar Operacion?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Operacion]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_Operacion, _
                    formulario.TxtCodigo.Text.Trim, _
                    formulario.TxtNombre.Text.Trim, _
                    formulario.TxtDescrip.Text.Trim, _
                    formulario.id_Tipo_Ope, _
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

        formulario.id_Operacion = -1
        formulario.TxtCodigo.Text = ""
        formulario.TxtNombre.Text = ""
        'formulario.TxtHumedad.Text = "0"
        formulario.TxtDescrip.Text = ""
        formulario.id_Tipo_Ope = -1
        formulario.TxtTipoOpe.Text = ""

        indice = -1

        lista(4, Nothing)
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Operacion", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        formulario.id_Operacion = CInt(DgvLista.Item("Id Operacion", indice).Value)
        formulario.TxtCodigo.Text = CStr(DgvLista.Item("Codigo", indice).Value)
        formulario.TxtNombre.Text = CStr(DgvLista.Item("Operacion", indice).Value)
        formulario.TxtDescrip.Text = CStr(DgvLista.Item("Descripcion", indice).Value.ToString.Trim)
        formulario.id_Tipo_Ope = CInt(DgvLista.Item("Id Tipo de Operacion", indice).Value)
        formulario.TxtTipoOpe.Text = CStr(DgvLista.Item("Tipo de Operacion", indice).Value.ToString.Trim)

        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea Guardar Operacion?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.
                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Operacion]", _
                    False, _
                    rpta, _
                    mensaje, _
                  formulario.id_Operacion, _
                    formulario.TxtCodigo.Text.Trim, _
                    formulario.TxtNombre.Text.Trim, _
                    formulario.TxtDescrip.Text.Trim, _
                    formulario.id_Tipo_Ope, _
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

        formulario.id_Operacion = -1
        formulario.TxtCodigo.Text = ""
        formulario.TxtNombre.Text = ""
        'formulario.TxtHumedad.Text = "0"
        formulario.TxtDescrip.Text = ""
        formulario.id_Tipo_Ope = -1
        formulario.TxtTipoOpe.Text = ""

        indice = -1

        lista(4, Nothing)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Operacion", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MessageBox.Show("¿Desea Eliminar Operacion?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then
                Dim rpta As Integer = -1
                Dim mensaje As String = ""
                servidor.ejecutar("[dbo].[pa_mantenimiento_Operacion]", _
                  False, _
                  rpta, _
                  mensaje, _
                  CInt(dgvlista.Item("Id Operacion", indice).Value), _
                  Nothing, _
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
        lista(4, Nothing)
    End Sub

    Private Sub TxtBusca_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Enter
        '  Me.TxtBusca.BackColor = Color.Azure
    End Sub

    Private Sub TxtBusca_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Leave
        TxtBusca.BackColor = Color.White
    End Sub

    Private Sub TxtBusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        Dim criterio As String = TxtBusca.Text.Trim
        ' Dim TIPO_OPERACION As String = Me.TextBox1.Text
        If RbEntrada.Checked = True Then
            'Me.txtbusca.Focus()
            lista(1, TxtBusca.Text)
            'ElseIf rbApellido.Checked = True Then
            '    ' Me.txtbusca.Focus()
            '    lista(2, Me.txtbusca.Text)
        ElseIf RbSalida.Checked = True Then
            lista(2, TxtBusca.Text)
            'Me.txtbusca.Focus()
        ElseIf RbTodos.Checked = True Then
            lista(3, TxtBusca.Text)
            'Me.txtbusca.Focus()
        End If
    End Sub
    Private Sub TxtBusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            DgvLista.Focus()
        End If
    End Sub

    Private Sub RbEntrada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbEntrada.CheckedChanged
        TxtBusca.Text = ""
        TxtBusca.Focus()
        lista(1, TxtBusca.Text)
    End Sub

    Private Sub RbSalida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbSalida.CheckedChanged
        TxtBusca.Text = ""
        TxtBusca.Focus()
        lista(2, TxtBusca.Text)
    End Sub

    Private Sub RbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbTodos.CheckedChanged
        TxtBusca.Text = ""
        TxtBusca.Focus()
        lista(3, TxtBusca.Text)
    End Sub
End Class
Public Class FrmChofer2
    Private formulario As New FrmChofer

    Dim tabla_chofer As DataTable = Nothing
    Public Sub lista(ByVal opcion As Integer, ByVal criterio As String, ByVal Brevete As String)
        mesajeerror.ForeColor = Color.Blue
        LBF2.ForeColor = Color.Red
        LBF3.ForeColor = Color.Red
        LBF4.ForeColor = Color.Red

        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_chofer]", opcion, criterio, Brevete).Tables.Count > 0 Then
                tabla_chofer = servidor.consultar("[dbo].[pa_listar_chofer]", opcion, criterio, Brevete).Tables(0)
            End If
            If tabla_chofer Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY CHOFER(es) PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_chofer
                Dim NroFilas As Integer = tabla_chofer.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY CHOFER(es) PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("ID").Visible = False
                    dgvlista.Columns("Nombre").Visible = False
                    dgvlista.Columns("Apellido").Visible = False
                    dgvlista.Columns("Chofer").Visible = False
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Chofer(es)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FrmChofer22_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESCAPE
        'If (e.KeyCode = Keys.Enter) Then
        '    Me.Close()
        'End If
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If


        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            rbNombre.Checked = True
            txtbusca.Focus()
        End If
        If e.KeyCode = Keys.F3 Then
            e.SuppressKeyPress = True
            rbbrevete.Checked = True
            txtbusca.Focus()
        End If
        If e.KeyCode = Keys.F4 Then
            e.SuppressKeyPress = True
            RbTodos.Checked = True
            txtbusca.Focus()
        End If
    End Sub


    Private Sub FrmChofer22_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(1, "", "")
        'Me.rbbrevete.Checked = True
        rbNombre.Checked = True
        ' Me.cbobusca.SelectedIndex = 0
    End Sub

    Private Sub activa(ByVal estado As Boolean)
        txtbusca.Enabled = estado
        ' Me.btnbusca.Enabled = estado
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
    Private Sub btnNuevo_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar Chofer?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_chofer]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_chofer, _
                    formulario.nombre.Text.Trim, _
                    formulario.apellido.Text.Trim, _
                    formulario.brevete.Text.Trim, _
                    formulario.telefono.Text.Trim, _
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

        formulario.id_chofer = -1
        formulario.nombre.Text = ""
        formulario.apellido.Text = ""
        formulario.brevete.Text = ""
        formulario.telefono.Text = ""

        indice = -1

        lista(1, "", "")
    End Sub

    Private Sub btnmodificar_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles BtnModificar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Chofer", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        formulario.id_chofer = CInt(dgvlista.Item("ID", indice).Value)
        formulario.nombre.Text = CStr(dgvlista.Item("Nombre", indice).Value)
        formulario.apellido.Text = CStr(dgvlista.Item("Apellido", indice).Value.ToString.Trim)
        formulario.brevete.Text = CStr(dgvlista.Item("Brevete", indice).Value.ToString.Trim)
        formulario.telefono.Text = CStr(dgvlista.Item("Telefono", indice).Value.ToString.Trim)


        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar CHOFER?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_chofer]", _
                    False, _
                    rpta, _
                    mensaje, _
                     formulario.id_chofer, _
                    formulario.nombre.Text.Trim, _
                    formulario.apellido.Text.Trim, _
                    formulario.brevete.Text.Trim, _
                    formulario.telefono.Text.Trim, _
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

        formulario.id_chofer = -1
        formulario.nombre.Text = ""
        formulario.apellido.Text = ""
        formulario.brevete.Text = ""
        formulario.telefono.Text = ""

        indice = -1

        lista(1, "", "")
    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Chofer", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea eliminar Chofer?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then
                Dim rpta As Integer = -1
                Dim mensaje As String = ""

                servidor.ejecutar("[dbo].[pa_mantenimiento_chofer]", _
                  False, _
                  rpta, _
                  mensaje, _
                  CInt(dgvlista.Item("ID", indice).Value), _
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
        lista(1, "", "")
    End Sub

    Private Sub btnImprimir_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimir.Click
        Dim f As New frmImprimiR
        f.Nivel = "FORMULARIO_LISTA_CHOFERES"
        f.Tabla_Imprimir = tabla_chofer
        'f.Tabla_Imprimir = ("Select * from P_VENTA where IdOrden="dgvlista.CurrentRow.Cells(0).Value)
        f.Titulo_Informe = "REPORTE DE CHOFERES"
        f.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub
    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellEnter
        indice = e.RowIndex
    End Sub
    'Private Sub dgvlista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellDoubleClick
    '    indice = e.RowIndex
    '    Close()
    'End Sub
    'Private Sub dgvlista_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellLeave
    '    indice = e.RowIndex
    'End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If rbNombre.Checked = True And e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightYellow
            'ElseIf rbapellido.Checked = True And e.ColumnIndex = 2 Then
            '    e.CellStyle.BackColor = Color.LightYellow
        ElseIf rbbrevete.Checked = True And e.ColumnIndex = 4 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
    End Sub
    'Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbusca.KeyDown
    '    saltar_Flechas(e)
    'End Sub

    Private Sub rbNombre_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbNombre.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub
  

    Private Sub rbbrevete_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbbrevete.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub RbTodos_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RbTodos.CheckedChanged
        txtbusca.Text = ""
        'Me.txtbusca.Focus()
    End Sub
    Private Sub txtbusca_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.Leave
        txtbusca.BackColor = Color.White
    End Sub
    'Private Sub txtbusca_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Enter
    '    Me.txtbusca.BackColor = Color.Moccasin
    'End Sub

    Private Sub txtbusca_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.TextChanged
        Dim criterio As String = txtbusca.Text.Trim
        ' Dim indice As Integer = rbdepartamento.Checked = True
        If rbNombre.Checked = True Then
            'Me.txtbusca.Focus()
            lista(1, txtbusca.Text, "")
            'ElseIf rbApellido.Checked = True Then
            '    ' Me.txtbusca.Focus()
            '    lista(2, Me.txtbusca.Text)
            'ElseIf rbapellido.Checked = True Then
            '    lista(2, Me.txtbusca.Text)
            '    'Me.txtbusca.Focus()
        ElseIf rbbrevete.Checked = True Then
            lista(1, "", txtbusca.Text)
            'Me.txtbusca.Focus()
        ElseIf RbTodos.Checked = True Then
            lista(1, "", "")
            'Me.txtbusca.Focus()
        End If
    End Sub

    Private Sub dgvlista_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dgvlista.KeyDown
        'PARA MODIFICAR REGISTRO CON TECLA ENTER
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If (indice = -1) Then
                MessageBox.Show("Seleccione Chofer", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            formulario.id_chofer = CInt(dgvlista.Item("ID", indice).Value)
            formulario.nombre.Text = CStr(dgvlista.Item("Nombre", indice).Value)
            formulario.apellido.Text = CStr(dgvlista.Item("Apellido", indice).Value.ToString.Trim)
            formulario.brevete.Text = CStr(dgvlista.Item("Brevete", indice).Value.ToString.Trim)
            formulario.telefono.Text = CStr(dgvlista.Item("Telefono", indice).Value.ToString.Trim)


            formulario.ShowDialog()
            If formulario.Aceptar = True Then
                If MessageBox.Show("¿Desea guardar CHOFER?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim servidor As New clinicapacifico.clsaccesodatos
                    servidor.cadenaconexion = Ruta
                    If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                        Dim rpta As Integer = -1
                        Dim mensaje As String = ""
                        servidor.ejecutar("[dbo].[pa_mantenimiento_chofer]", _
                        False, _
                        rpta, _
                        mensaje, _
                         formulario.id_chofer, _
                        formulario.nombre.Text.Trim, _
                        formulario.apellido.Text.Trim, _
                        formulario.brevete.Text.Trim, _
                        formulario.telefono.Text.Trim, _
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

            formulario.id_chofer = -1
            formulario.nombre.Text = ""
            formulario.apellido.Text = ""
            formulario.brevete.Text = ""
            formulario.telefono.Text = ""

            indice = -1

            lista(1, "", "")

        End If
    End Sub


    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub
End Class
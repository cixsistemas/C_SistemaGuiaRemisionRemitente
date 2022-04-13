Public Class FrmListarChofer
    Private formulario As New FrmChofer
    Dim tabla_chofer As DataTable = Nothing

    Public Sub lista(ByVal opcion As Integer, ByVal criterio As String, ByVal Brevete As String)
        LBF2.ForeColor = Color.Red
        LBF3.ForeColor = Color.Red
        LBF4.ForeColor = Color.Red

        mesajeerror.ForeColor = Color.Blue
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
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Chofer(es)"
                    mesajeerror.ForeColor = Color.Black
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FrmListarChofers_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If
        'If (e.KeyCode = Keys.Escape) Then
        '    Me.Close()
        'End If
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

        'PARA NUEVO REGISTRO CON TECLA ENTER
        If e.KeyCode = Keys.Insert Then
            e.SuppressKeyPress = True

            Insertar()

        End If
    End Sub


    Private Sub FrmListarChofers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(2, "", "")
        ' Me.rbapellido.Checked = True
        '  Me.rbNombre.Checked = True
        rbNombre.Checked = True
        ' Me.txtbusca.Focus()
    End Sub


    Private Sub btn_Acep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Acep.Click
        Close()
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

    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If rbNombre.Checked = True And e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightCyan
            'ElseIf rbapellido.Checked = True And e.ColumnIndex = 2 Then
            '    e.CellStyle.BackColor = Color.LightCyan
        ElseIf rbbrevete.Checked = True And e.ColumnIndex = 4 Then
            e.CellStyle.BackColor = Color.LightCyan
        End If
        'If e.ColumnIndex = 3 Then
        '    e.CellStyle.BackColor = Color.LightCyan
        'End If
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Insertar()
    End Sub
    Private Sub Insertar()
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar Chofer?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_chofer]",
                    False,
                    rpta,
                    mensaje,
                    formulario.id_chofer,
                    formulario.nombre.Text.Trim,
                    formulario.apellido.Text.Trim,
                    formulario.brevete.Text.Trim,
                    formulario.telefono.Text.Trim,
                    "N",
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

        formulario.id_chofer = -1
        formulario.nombre.Text = ""
        formulario.apellido.Text = ""
        formulario.brevete.Text = ""
        formulario.telefono.Text = ""

        indice = -1

        lista(2, "", "")
    End Sub
    Private Sub rbNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombre.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub
    Private Sub rbapellido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub rbbrevete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbbrevete.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub RbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbTodos.CheckedChanged
        txtbusca.Text = ""
        'Me.txtbusca.Focus()
    End Sub

    Private Sub txtbusca_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        Dim criterio As String = txtbusca.Text.Trim
        ' Dim indice As Integer = rbdepartamento.Checked = True
        If rbNombre.Checked = True Then
            'Me.txtbusca.Focus()
            lista(2, txtbusca.Text, "")
            'ElseIf rbApellido.Checked = True Then
            '    ' Me.txtbusca.Focus()
            '    lista(2, Me.txtbusca.Text)
            'ElseIf rbapellido.Checked = True Then
            '    lista(2, Me.txtbusca.Text)
            '    'Me.txtbusca.Focus()
        ElseIf rbbrevete.Checked = True Then
            lista(2, "", txtbusca.Text)
            'Me.txtbusca.Focus()
        ElseIf RbTodos.Checked = True Then
            lista(2, "", "")
            'Me.txtbusca.Focus()
        End If
    End Sub

    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub
End Class
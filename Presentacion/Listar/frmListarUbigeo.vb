Public Class frmListarUbigeo
    Dim tabla_ubigeo As DataTable
    Public Sub lista(ByVal opcion As Integer, ByVal criterio As String)
        mesajeerror.ForeColor = Color.Blue
        LBF2.ForeColor = Color.Red
        LBF3.ForeColor = Color.Red
        LBF4.ForeColor = Color.Red
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            tabla_ubigeo = servidor.consultar("[dbo].[pa_Listar_Ubigeos]", opcion, criterio).Tables(0)
            If tabla_ubigeo Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Ubigeo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim NroFilas As Integer = tabla_ubigeo.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    dgvlista.DataSource = tabla_ubigeo
                    'MessageBox.Show("No hay personas para mostrar", "Persona", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    mesajeerror.Text = "NO HAY UBIGEOS PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.DataSource = tabla_ubigeo
                    servidor.cerrarconexion()
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " UBIGEO(s)"
                    mesajeerror.ForeColor = Color.Black
                End If
                dgvlista.Columns("Id").Visible = False
                dgvlista.Columns("Codigo").Visible = False
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Ubigeo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub activa(ByVal estado As Boolean)
        txtbusca.Enabled = estado
        '  Me.btnbusca.Enabled = estado
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
        If rbdepartamento.Checked = True And e.ColumnIndex = 4 Then
            e.CellStyle.BackColor = Color.LightCyan
        ElseIf rbprovincia.Checked = True And e.ColumnIndex = 3 Then
            e.CellStyle.BackColor = Color.LightCyan
        ElseIf rbdistrito.Checked = True And e.ColumnIndex = 2 Then
            e.CellStyle.BackColor = Color.LightCyan
        End If
       
    End Sub
    Private Sub btn_Acep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Acep.Click
        Close()
    End Sub

    Private Sub frmListarUbigeo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            rbdistrito.Checked = True
            txtbusca.Focus()
        End If
        If e.KeyCode = Keys.F3 Then
            e.SuppressKeyPress = True
            rbprovincia.Checked = True
            txtbusca.Focus()
        End If
        If e.KeyCode = Keys.F4 Then
            e.SuppressKeyPress = True
            rbdepartamento.Checked = True
            txtbusca.Focus()
        End If
    End Sub

    Private Sub frmListarUbigeo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(4, Nothing)
        rbdistrito.Checked = True
        indice = -1
        '  Me.txtbusca.Focus()
    End Sub

    Private Sub txtbusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        Dim criterio As String = txtbusca.Text.Trim
        ' Dim indice As Integer = rbdepartamento.Checked = True
        If rbdepartamento.Checked = True Then
            'Me.txtbusca.Focus()
            lista(1, txtbusca.Text)
        ElseIf rbprovincia.Checked = True Then
            ' Me.txtbusca.Focus()
            lista(2, txtbusca.Text)
        ElseIf rbdistrito.Checked = True Then
            lista(3, txtbusca.Text)
            'Me.txtbusca.Focus()
        End If
    End Sub
    Private Sub rbdepartamento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdepartamento.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub rbprovincia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbprovincia.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub rbdistrito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdistrito.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    'Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbusca.KeyDown
    '    If e.KeyData = Keys.Right Then
    '        SendKeys.Send("{TAB}")
    '    End If
    'End Sub

    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub
End Class
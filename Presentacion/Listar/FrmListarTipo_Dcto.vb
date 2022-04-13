Public Class FrmListarTipo_Dcto
    Private formulario As New FrmTip_Trab1
    Dim tabla_Tipo_Dcto As DataTable = Nothing

    Public Sub lista(ByVal criterio As String)
        LBF2.ForeColor = Color.Red
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_tipo_Dcto]", criterio).Tables.Count > 0 Then
                tabla_Tipo_Dcto = servidor.consultar("[dbo].[pa_listar_tipo_Dcto]", criterio).Tables(0)
            End If
            If tabla_Tipo_Dcto Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY TIPO DE DOCUMENTO PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_Tipo_Dcto
                Dim NroFilas As Integer = tabla_Tipo_Dcto.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY TIPO DE DOCUMENTO PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("Id Tipo Dcto").Visible = False
                    dgvlista.Columns("Codigo").Visible = False
                    dgvlista.Columns("Siglas").Visible = False
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Tipo(s) de Documento(s)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Molinos los Angeles", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FrmListarTipo_Dcto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
        indice = -1
    End Sub
    Private Sub dgvlista_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellDoubleClick
        indice = e.RowIndex
        Close()
    End Sub
    Private Sub dgvlista_CellLeave(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellLeave
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightCyan
        End If
    End Sub
    Private Sub FrmListarTipo_Dcto_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If
    End Sub

    Private Sub txtbusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        lista(txtbusca.Text)
        ' Aplicar_Filtro()
    End Sub
    Private Sub txtbusca_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Leave
        txtbusca.BackColor = Color.White
    End Sub
    'Private Sub txtbusca_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Enter
    '    Me.txtbusca.BackColor = Color.Moccasin
    'End Sub

    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub

    Private Sub btn_Acep_Click(sender As System.Object, e As System.EventArgs) Handles btn_Acep.Click
        If indice = -1 Then
            MessageBox.Show("Seleccione fila por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtbusca.Focus()
        Else
            Close()
        End If
        'Close()
    End Sub
End Class
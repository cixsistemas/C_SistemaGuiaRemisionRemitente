Public Class frmListarComisionistas
    Private formulario As New FrmComisionista2

    Dim tabla_comisionista As DataTable = Nothing
    Public Sub lista(ByVal criterio As String)
        LBF2.ForeColor = Color.Red
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_Listar_Comisionista]", criterio).Tables.Count > 0 Then
                tabla_comisionista = servidor.consultar("[dbo].[pa_Listar_Comisionista]", criterio).Tables(0)
            End If
            If tabla_comisionista Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY COMISIONISTA PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_comisionista
                Dim NroFilas As Integer = tabla_comisionista.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY COMISIONISTA PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("Id Comisionista").Visible = False
                    dgvlista.Columns("Id Tipo Dcto").Visible = False
                    dgvlista.Columns("Id Zona").Visible = False
                    dgvlista.Columns("Telefono").Visible = False
                    dgvlista.Columns("Tipo Dcto").Visible = False
                    dgvlista.Columns("Distrito").Visible = False
                    dgvlista.Columns("Descripcion").Visible = False
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Comisionista(s)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub frmListarComisionistas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If
    End Sub

    Private Sub frmListarComisionistas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
        txtbusca.Focus()
        indice = -1
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

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Dim f As New FrmComisionista2
        f.Nivel = "N"
        f.id_comisionista = 0
        f.ShowDialog()
        lista(Nothing)
    End Sub
End Class
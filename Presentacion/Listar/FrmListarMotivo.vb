Public Class FrmListarMotivo
    Dim tabla_MotivoTras As DataTable
    'Private formulario As New frmdestinatario1

    Public Sub lista(ByVal criterio As String)
        LBF2.ForeColor = Color.Red
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_Motivo_Tras]", criterio).Tables.Count > 0 Then
                tabla_MotivoTras = servidor.consultar("[dbo].[pa_listar_Motivo_Tras]", criterio).Tables(0)
            End If
            If tabla_MotivoTras Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY MOTIVOS DE TRASLADO PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_MotivoTras
                Dim NroFilas As Integer = tabla_MotivoTras.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY MOTIVOS DE TRASLADO PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    '  Me.dgvlista.Columns("id_mot_traslado").Visible = False
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Motivo(s) de Traslado(s)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'Try
        '    'POSICIONA CURSOR EN ULTIMA FILA
        '    Me.dgvlista.ClearSelection()
        '    Me.dgvlista.CurrentCell = Me.dgvlista.Rows(Me.dgvlista.RowCount - 2).Cells(1)
        '    'Me.dgvlista.Refresh()
        'Catch ex As Exception
        '    'MessageBox.Show("Gastos, no se encuentra registrada", "Guía de Remisión-Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try

    End Sub

    'Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellEnter
    '    indice = e.RowIndex
    'End Sub
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

    Private Sub btn_Acep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Acep.Click
        Close()
    End Sub

    Private Sub FrmListarMotivo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If


        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If
    End Sub

    Private Sub FrmListarMotivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
    End Sub
    Private Sub txtbusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        lista(txtbusca.Text)
    End Sub

    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub
End Class
Public Class FrmListarGuiaS
    Private formulario As New frmguia
    Dim idguia As Integer
    Dim tabla_guias As DataTable

    Public Sub listar_guias(ByVal Numero As String)
        LBF2.ForeColor = Color.Red
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            tabla_guias = servidor.consultar("[dbo].[pa_listar_guias_Peso_Nota]", Numero).Tables(0)
            If tabla_guias Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
                MessageBox.Show(__mesajeerror, "Guía de remisión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim NroFilas As Integer = tabla_guias.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    dgvlista.DataSource = tabla_guias
                    '  MessageBox.Show("Guía de Remisión, No se encuentra registrada", "Guía de Remisión-Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mesajeerror.Text = "No hay Guía de Remisión – Remitente para mostrar"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.DataSource = tabla_guias
                    servidor.cerrarconexion()
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Guia(s)"
                    mesajeerror.ForeColor = Color.Black
                End If
                dgvlista.Columns("ID Guia").Visible = False
                dgvlista.Columns("Domicilio").Visible = False
                dgvlista.Columns("ruc").Visible = False
                ' Me.dgvlista.Columns("Ruc Remitente").Visible = False
                'Me.dgvlista.Columns("direccion").Visible = False
                dgvlista.Columns("distrito").Visible = False
                dgvlista.Columns("provincia").Visible = False
                dgvlista.Columns("departamento").Visible = False
                'Me.dgvlista.Columns("Descripcion").Visible = False
                dgvlista.Columns("Nombre Chofer").Visible = False
                dgvlista.Columns("Apellido Chofer").Visible = False
                dgvlista.Columns("Telefono Chofer").Visible = False
                dgvlista.Columns("largo camion").Visible = False
                dgvlista.Columns("alto camion").Visible = False
                dgvlista.Columns("ancho camion").Visible = False
                dgvlista.Columns("Peso Neto Remolque").Visible = False
                dgvlista.Columns("largo carreta").Visible = False
                dgvlista.Columns("ancho carreta").Visible = False
                dgvlista.Columns("alto carreta").Visible = False
                dgvlista.Columns("Peso Neto Semi-Remolque").Visible = False
                dgvlista.Columns("configuracion vehicular").Visible = False
                dgvlista.Columns("Peso bruto vehicular").Visible = False
                dgvlista.Columns("Fecha Emision").DefaultCellStyle.Format = "dd/MM/yyyy"
                dgvlista.Columns("Descripcion").Visible = False
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Try
            'POSICIONA CURSOR EN ULTIMA FILA
            dgvlista.ClearSelection()
            dgvlista.CurrentCell = dgvlista.Rows(dgvlista.RowCount - 2).Cells(1)
            'Me.dgvlista.Refresh()
        Catch ex As Exception
            MessageBox.Show("Guía, no se encuentra registrada", "Guía de Remisión-Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.Close()
        End Try

    End Sub

    Private Sub FrmListarGuiaSs_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'Cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Enter) Then
            Close()
            'ElseIf (e.KeyCode = Keys.Escape) Then
            '    Me.Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If
    End Sub


    Private Sub FrmListarGuiaSs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Obtenenemos la cadena de coneccion al servidor
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        listar_guias(Nothing)
        txtbusca.Focus()
    End Sub

    Private Sub txtbusca_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtbusca.KeyPress
        ' saltar(e)
        SoloNumeros(e, False, sender.Text)
    End Sub
    Private Sub txtbusca_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        listar_guias(txtbusca.Text)
    End Sub
    Private Sub dgvlista_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick
        indice = e.RowIndex
        idguia = dgvlista.Item("ID GUIA", indice).Value
        'listar_detalle_guias(idguia)
    End Sub

    Private Sub btn_Acep_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Acep.Click
        Close()
    End Sub

    Private Sub dgvlista_CellClick1(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    'Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellEnter
    '    indice = e.RowIndex
    '    'Me.Close()
    'End Sub
    Private Sub dgvlista_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellDoubleClick
        indice = e.RowIndex
        Close()
    End Sub
    Private Sub dgvlista_CellLeave(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellLeave
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 3 Then
            e.CellStyle.BackColor = Color.LightCyan
        End If
    End Sub

    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub
End Class
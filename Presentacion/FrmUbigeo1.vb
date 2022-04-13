Public Class FrmUbigeo1
    Dim tabla_ubigeo As DataTable

    Public Sub lista(ByVal opcion As Integer, ByVal criterio As String)
        mesajeerror.ForeColor = Color.Blue
        LBF2.ForeColor = Color.Red
        LBF3.ForeColor = Color.Red
        LBF4.ForeColor = Color.Red

        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_ubigeos]", opcion, criterio).Tables.Count > 0 Then
                tabla_ubigeo = servidor.consultar("[dbo].[pa_listar_ubigeos]", opcion, criterio).Tables(0)
            End If
            If tabla_ubigeo Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY UBIGEO(s) PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_ubigeo
                Dim NroFilas As Integer = tabla_ubigeo.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY UBIGEO(s) PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("ID").Visible = False
                    'Me.dgvlista.Columns("Nombre").Visible = False
                    'Me.dgvlista.Columns("Apellido").Visible = False
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " UBIGEO(s)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub activa(ByVal estado As Boolean)
        txtbusca.Enabled = estado
        ' Me.btnbusca.Enabled = estado
    End Sub

    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub

    Private Sub dgvlista_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellDoubleClick
        indice = e.RowIndex
        Close()
    End Sub
    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellEnter
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellLeave(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellLeave
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If rbdepartamento.Checked = True And e.ColumnIndex = 4 Then
            e.CellStyle.BackColor = Color.LightYellow
        ElseIf rbprovincia.Checked = True And e.ColumnIndex = 3 Then
            e.CellStyle.BackColor = Color.LightYellow
        ElseIf rbdistrito.Checked = True And e.ColumnIndex = 2 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If

    End Sub

    Private Sub FrmUbigeo1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
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


    Private Sub FrmUbigeo1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(4, Nothing)
        rbdistrito.Checked = True
        '  Me.cbobusca.SelectedIndex = 0
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
    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub
    Private Sub txtbusca_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Leave
        txtbusca.BackColor = Color.White
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

    Private Sub dgvlista_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick

    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Dim f As New FrmUbigeo2
        f.Nivel = "N"
        ' f.txtcodigo.Text = 0
        f.txtcodigo.Focus()
        f.id_ubigeo = 0
        f.ShowDialog()
        lista(4, Nothing)
    End Sub


    Private Sub BtnModificar_Click(sender As System.Object, e As System.EventArgs) Handles BtnModificar.Click
        Dim f As New FrmUbigeo2
        If (indice = -1) Then
            MessageBox.Show("Seleccione Ubigeo", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        '  f.id_ubigeo = CInt(dgvlista.Item("id", indice).Value)
        f.id_ubigeo = CInt(dgvlista.Item("ID", indice).Value)
        f.txtcodigo.Text = CStr(dgvlista.Item("Codigo", indice).Value.ToString.Trim)
        f.txtdepartamento.Text = CStr(dgvlista.Item("Departamento", indice).Value.ToString.Trim)
        f.txtprovincia.Text = CStr(dgvlista.Item("Provincia", indice).Value.ToString.Trim)
        f.txtdistrito.Text = CStr(dgvlista.Item("Distrito", indice).Value.ToString.Trim)

        f.Nivel = "M"
        f.ShowDialog()
        indice = -1
       lista(4, Nothing)
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Ubigeo", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea eliminar Ubigeo?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then
                Dim rpta As Integer = -1
                Dim mensaje As String = ""

                servidor.ejecutar("[dbo].[pa_mantenimiento_Ubigeos]", _
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
    Private Sub btnImprimir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim f As New FRMIMPRIMIR
        f.Nivel = "FORMULARIO_LISTA_UBIGEOS"
        f.Tabla_Imprimir = tabla_ubigeo
        'f.Tabla_Imprimir = ("Select * from P_VENTA where IdOrden="dgvlista.CurrentRow.Cells(0).Value)
        f.Titulo_Informe = "REPORTE DE UBIGEOS"
        f.ShowDialog()
    End Sub
    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub


   
End Class
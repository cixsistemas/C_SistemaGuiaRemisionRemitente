Public Class FrmTipo_Comp_1
    Private formulario As New FrmTipo_Comp_2

    Dim tabla_Tipo_Comprobante As DataTable = Nothing
    Public Sub lista(ByVal criterio As String)
        LBF2.ForeColor = Color.Red
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_Listar_Tipo_de_Comprobante_de_Pago]", criterio).Tables.Count > 0 Then
                tabla_Tipo_Comprobante = servidor.consultar("[dbo].[pa_Listar_Tipo_de_Comprobante_de_Pago]", criterio).Tables(0)
            End If
            If tabla_Tipo_Comprobante Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY TIPO DE COMPROBANTE DE PAGO PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_Tipo_Comprobante
                Dim NroFilas As Integer = tabla_Tipo_Comprobante.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY TIPO DE COMPROBANTE DE PAGO PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("Id Tipo de Comprobante").Visible = False
                    'Me.dgvlista.Columns("Nombre").Visible = False
                    'Me.dgvlista.Columns("Apellido").Visible = False
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Tipo(s) de Comprobante(s) de Pago(s)"
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

    Private Sub FrmTipo_Comp_1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If
    End Sub

    Private Sub FrmTipo_Comp_1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
        txtbusca.Focus()
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
        BtnModificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False)) ': mesajeerror.Text = ""
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False)) ': mesajeerror.Text = ""

    End Sub

    Private Sub dgvlista_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvlista.RowsRemoved
        BtnModificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False)) ': mesajeerror.Text = ""
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False)) ': mesajeerror.Text = ""
    End Sub


    Private Sub dgvlista_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvlista.VisibleChanged
        BtnModificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False)) ': mesajeerror.Text = ""
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False)) ' : mesajeerror.Text = ""
    End Sub


    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Dim f As New FrmTipo_Comp_2

        ' f.TxtNro_Secado.Text = generar_numero_secado()
        'f.TxtNro_Lote.Text = generar_numero_Lote()

        ' f.Nro_Lote.Text = generar_numero_lote()

        'f.CboTipo_Secado.SelectedIndex = 1

        f.Nivel = "N"

        f.id_Tipo_Comprobante = 0

        f.ShowDialog()

        lista(Nothing)
    End Sub
    Private Sub BtnModificar_Click(sender As System.Object, e As System.EventArgs) Handles BtnModificar.Click
        Dim f As New FrmTipo_Comp_2


        If (indice = -1) Then
            MessageBox.Show("Seleccione Tipo de Comprobante de Pago", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        f.id_Tipo_Comprobante = CInt(dgvlista.Item("Id Tipo de Comprobante", indice).Value)
        f.TxtCodigo.Text = CStr(dgvlista.Item("Codigo", indice).Value)
        f.TxtNombre.Text = CStr(dgvlista.Item("Tipo de Comprobante", indice).Value.ToString.Trim)
        f.TxtSiglas.Text = CStr(dgvlista.Item("Siglas", indice).Value.ToString.Trim)
        f.TxtDescrip.Text = CStr(dgvlista.Item("Descripcion", indice).Value.ToString.Trim)

        f.Nivel = "M"
        f.ShowDialog()
        indice = -1
        lista(Nothing)

    End Sub


    Private Sub TxtBusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            DgvLista.Focus()
        End If
    End Sub
    Private Sub TxtBusca_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Enter
        'Me.TxtBusca.BackColor = Color.Azure
    End Sub

    Private Sub TxtBusca_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Leave
        TxtBusca.BackColor = Color.White
    End Sub

    Private Sub TxtBusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        lista(TxtBusca.Text)
    End Sub


End Class
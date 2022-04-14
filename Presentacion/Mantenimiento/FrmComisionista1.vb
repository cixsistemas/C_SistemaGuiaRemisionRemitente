Public Class FrmComisionista1
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
    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub FrmComisionista1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If
    End Sub

    Private Sub FrmComisionista1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub FrmComisionista1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
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
        If e.ColumnIndex = 1 Then
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


    Private Sub btnNuevo_Click(sender As Object, e As System.EventArgs) Handles btnNuevo.Click
        Dim f As New FrmComisionista2


        f.Nivel = "N"

        f.id_comisionista = 0

        f.ShowDialog()

        lista(Nothing)
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As System.EventArgs) Handles BtnModificar.Click
        Dim f As New FrmComisionista2

        If (indice = -1) Then
            MessageBox.Show("Seleccione Cliente", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        f.id_comisionista = CInt(dgvlista.Item("Id Comisionista", indice).Value)
        f.nombre.Text = CStr(dgvlista.Item("Comisionista", indice).Value)

        f.txtTelefono.Text = CStr(dgvlista.Item("Telefono", indice).Value.ToString.Trim)
        f.txtDireccion.Text = CStr(dgvlista.Item("Direccion", indice).Value.ToString.Trim)
        f.txtDescrip.Text = CStr(dgvlista.Item("Descripcion", indice).Value.ToString.Trim)

        f.id_Zona = CInt(dgvlista.Item("Id Zona", indice).Value)
        f.txtZona.Text = CStr(dgvlista.Item("Zona", indice).Value.ToString.Trim)
        f.txtDistrito.Text = CStr(dgvlista.Item("Distrito", indice).Value.ToString.Trim)

        f.id_tipo_Dcto = CInt(dgvlista.Item("Id Tipo Dcto", indice).Value)
        f.txtTipo_Dcto.Text = CStr(dgvlista.Item("Tipo Dcto", indice).Value.ToString.Trim)
        f.nro_doc.Text = CStr(dgvlista.Item("Nro Documento", indice).Value.ToString.Trim)


        f.Nivel = "M"
        f.ShowDialog()
        indice = -1
        lista(Nothing)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As System.EventArgs) Handles btnEliminar.Click

        If (indice = -1) Then
            MessageBox.Show("Seleccione Cliente", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If MessageBox.Show("¿Desea eliminar Comisionista?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then
                Dim rpta As Integer = -1
                Dim mensaje As String = ""

                servidor.ejecutar("[dbo].[pa_mantenimiento_Comisionista]", _
                  False, _
                  rpta, _
                  mensaje, _
                  CInt(dgvlista.Item("Id Comisionista", indice).Value), _
                  Nothing, _
                  Nothing, _
                  Nothing, _
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

    Private Sub TxtBusca_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        lista(TxtBusca.Text)
    End Sub


    Private Sub btnImprimir_Click(sender As Object, e As System.EventArgs) Handles btnImprimir.Click
        Dim f As New frmImprimiR
        f.Nivel = "FORMULARIO_LISTA_COMISIONISTAS"
        f.Tabla_Imprimir = tabla_comisionista
        'f.Tabla_Imprimir = ("Select * from P_VENTA where IdOrden="dgvlista.CurrentRow.Cells(0).Value)
        f.Titulo_Informe = "REPORTE DE COMISIONISTAS"
        f.ShowDialog()
    End Sub
End Class
Public Class FrmRepCont_Gui_FT
    Private formulario As New frmListarRemitentes
    Dim tabla_Control_GuiaFT As DataTable = Nothing
    Public Sub lista(ByVal fechainicio As Object, ByVal fechafin As Object, ByVal Numero As Object, ByVal Remitente As Object)
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[Rep_ContGuiaFT]", fechainicio, fechafin, Numero, Remitente).Tables.Count > 0 Then
                tabla_Control_GuiaFT = servidor.consultar("[dbo].[Rep_ContGuiaFT]", fechainicio, fechafin, Numero, Remitente).Tables(0)
            End If
            If tabla_Control_GuiaFT Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY REGISTROS PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_Control_GuiaFT
                Dim NroFilas As Integer = tabla_Control_GuiaFT.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY REGISTROS PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red

                Else

                    ' Me.dgvlista.Columns("ID Guia").Visible = False
                    ' Me.dgvlista.Columns("Monto Total").Visible = False
                    dgvlista.Columns("fecha").DefaultCellStyle.Format = "dd/MM/yyyy"

                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Registros"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        Try
            'POSICIONA CURSOR EN ULTIMA FILA
            dgvlista.ClearSelection()
            dgvlista.CurrentCell = dgvlista.Rows(dgvlista.RowCount - 1).Cells(2)
            'Me.dgvlista.Refresh()
        Catch ex As Exception
            ' MessageBox.Show("Nota de Envio, no se encuentra registrada", "Guía de Remisión-Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub FrmRepCont_Gui_FT_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmRepCont_Gui_FT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing, Nothing, Nothing, Nothing)
    End Sub
    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellEnter
        indice = e.RowIndex
    End Sub
    Private Sub cbNro_Guia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNro_Guia.CheckedChanged
        txtnro_Guia.Enabled = cbNro_Guia.Checked : txtnro_Guia.Text = "" : txtnro_Guia.Focus()
    End Sub

    Private Sub cbEmpresa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRemitente.CheckedChanged
        txtRemitente.Enabled = cbRemitente.Checked : txtRemitente.Text = "" : txtRemitente.Focus()
    End Sub

    Private Sub cbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFecha.CheckedChanged
        dtpfin.Enabled = cbFecha.Checked : dtpff.Enabled = cbFecha.Checked
        dtpfin.Value = DateSerial(Now.Date.Year, Now.Month, 1)
        ' dtpfin.Value = DateTime.Now
        dtpff.Value = DateTime.Now
        dtpfin.Focus()
    End Sub

    Private Sub txtEmpresa_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRemitente.Enter
        Dim f As New frmListarRemitentes
        f.ShowDialog()
        txtRemitente.Text = CStr(f.dgvlista.Item("Remitente", indice).Value.ToString.Trim)
        btnConsultar.Focus()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        'FECHA
        If cbFecha.Checked = True And cbNro_Guia.Checked = False And cbRemitente.Checked = False Then
            lista(CDate(dtpfin.Value.ToShortDateString), CDate(dtpff.Value.ToString), Nothing, Nothing)
            'FECHA, NUMERO  
        ElseIf cbFecha.Checked = True And cbNro_Guia.Checked = True And cbRemitente.Checked = False Then
            lista(CDate(dtpfin.Value.ToShortDateString), CDate(dtpff.Value.ToString), txtnro_Guia.Text, Nothing)
            'FECHA, REMITENTE
        ElseIf cbFecha.Checked = True And cbNro_Guia.Checked = False And cbRemitente.Checked = True Then
            lista(CDate(dtpfin.Value.ToShortDateString), CDate(dtpff.Value.ToString), Nothing, txtRemitente.Text)
            'FECHA, NUMERO  , REMITENTE
        ElseIf cbFecha.Checked = True And cbNro_Guia.Checked = True And cbRemitente.Checked = True Then
            lista(CDate(dtpfin.Value.ToShortDateString), CDate(dtpff.Value.ToString), txtnro_Guia.Text, txtRemitente.Text)
            'NUMERO
        ElseIf cbFecha.Checked = False And cbNro_Guia.Checked = False And cbRemitente.Checked = False Then
            lista(Nothing, Nothing, txtnro_Guia.Text, Nothing)
            ' NUMERO  , REMITENTE
        ElseIf cbFecha.Checked = False And cbNro_Guia.Checked = True And cbRemitente.Checked = True Then
            lista(Nothing, Nothing, txtnro_Guia.Text, txtRemitente.Text)
            '  REMITENTE
        ElseIf cbFecha.Checked = False And cbNro_Guia.Checked = False And cbRemitente.Checked = True Then
            lista(Nothing, Nothing, Nothing, txtRemitente.Text)
        Else
            lista(Nothing, Nothing, Nothing, Nothing)
        End If
    End Sub

    Private Sub dtpfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpfin.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub dtpff_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpff.KeyPress
        saltar_ENTER(e)
        'Me.btnBuscar.Focus()
    End Sub

    Private Sub txtnro_Guia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnro_Guia.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim f As New frmImprimiR
        f.Nivel = "FORMULARIO_LISTA_CONTROL_GUIA_FT"
        f.Tabla_Imprimir = tabla_Control_GuiaFT
        f.Titulo_Informe = "REPORTE DE FACTURAS ENVIADAS"
        f.ShowDialog()
    End Sub
End Class
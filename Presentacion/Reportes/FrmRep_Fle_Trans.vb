Public Class FrmRep_Fle_Trans
    Dim Id_nota_arroz As Integer
    Dim tabla_Nota_Arroz As DataTable
    Dim tabla_detalle_guias As DataTable
    Public Sub lista(ByVal fechainicio As Object, ByVal fechafin As Object, ByVal Numero As Object, ByVal Transportista As Object)
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[Rep_Fle_Transp]", fechainicio, fechafin, Numero, Transportista).Tables.Count > 0 Then
                tabla_Nota_Arroz = servidor.consultar("[dbo].[Rep_Fle_Transp]", fechainicio, fechafin, Numero, Transportista).Tables(0)
            End If
            If tabla_Nota_Arroz Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY REGISTROS PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_Nota_Arroz
                Dim NroFilas As Integer = tabla_Nota_Arroz.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY REGISTROS PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red

                Else

                    dgvlista.Columns("Id Nota Arroz").Visible = False
                    dgvlista.Columns("Id Guia").Visible = False
                    dgvlista.Columns("Id Pago Detrac.").Visible = False
                    dgvlista.Columns("RUC").Visible = False
                    dgvlista.Columns("Destinatario").Visible = False
                    dgvlista.Columns("Direccion Destinatario").Visible = False
                    dgvlista.Columns("Telefono Destinatario").Visible = False
                    dgvlista.Columns("Domicilio Transportista").Visible = False
                    'Me.dgvlista.Columns("Nombre Chofer").Visible = False
                    'Me.dgvlista.Columns("Apellido Chofer").Visible = False
                    dgvlista.Columns("Telefono Chofer").Visible = False
                    dgvlista.Columns("observacion").Visible = False
                    dgvlista.Columns("Comentario").Visible = False
                    dgvlista.Columns("A Cuenta").Visible = False
                    dgvlista.Columns("Fecha").DefaultCellStyle.Format = "dd/MM/yyyy"

                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Fletes"
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
            dgvlista.CurrentCell = dgvlista.Rows(dgvlista.RowCount - 1).Cells(3)
            'Me.dgvlista.Refresh()
        Catch ex As Exception
            ' MessageBox.Show("Nota de Envio, no se encuentra registrada", "Guía de Remisión-Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub FrmRep_Fle_Trans_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmRep_Fle_Trans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing, Nothing, Nothing, Nothing)
    End Sub
    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        indice = e.RowIndex
    End Sub
    Private Sub cbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFecha.CheckedChanged
        dtpfin.Enabled = cbFecha.Checked : dtpff.Enabled = cbFecha.Checked
        dtpfin.Value = DateSerial(Now.Date.Year, Now.Month, 1)
        ' dtpfin.Value = DateTime.Now
        dtpff.Value = DateTime.Now
        dtpfin.Focus()
    End Sub

    Private Sub txtEmpresa_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTransportista.Enter
        Dim f As New FrmListarTransportista
        f.ShowDialog()
        txtTransportista.Text = CStr(f.dgvlista.Item("Empresa", indice).Value.ToString.Trim)
        btnConsultar.Focus()
    End Sub
    Private Sub cbTransportista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTransportista.CheckedChanged
        txtTransportista.Enabled = cbTransportista.Checked : txtTransportista.Text = "" : txtTransportista.Focus()
    End Sub
    Private Sub cbNro_Guia_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNro_Guia.CheckedChanged
        txtnro_Guia.Enabled = cbNro_Guia.Checked : txtnro_Guia.Text = "" : txtnro_Guia.Focus()
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


    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        'FECHA
        If cbFecha.Checked = True And cbNro_Guia.Checked = False And cbTransportista.Checked = False Then
            lista(CDate(dtpfin.Value.ToShortDateString), CDate(dtpff.Value.ToString), Nothing, Nothing)
            'FECHA, NUMERO  
        ElseIf cbFecha.Checked = True And cbNro_Guia.Checked = True And cbTransportista.Checked = False Then
            lista(CDate(dtpfin.Value.ToShortDateString), CDate(dtpff.Value.ToString), txtnro_Guia.Text, Nothing)
            'FECHA, TRANSPORTISTA
        ElseIf cbFecha.Checked = True And cbNro_Guia.Checked = False And cbTransportista.Checked = True Then
            lista(CDate(dtpfin.Value.ToShortDateString), CDate(dtpff.Value.ToString), Nothing, txtTransportista.Text)
            'FECHA, NUMERO  , TRANSPORTISTA
        ElseIf cbFecha.Checked = True And cbNro_Guia.Checked = True And cbTransportista.Checked = True Then
            lista(CDate(dtpfin.Value.ToShortDateString), CDate(dtpff.Value.ToString), txtnro_Guia.Text, txtTransportista.Text)
            'NUMERO
        ElseIf cbFecha.Checked = False And cbNro_Guia.Checked = False And cbTransportista.Checked = False Then
            lista(Nothing, Nothing, txtnro_Guia.Text, Nothing)
            ' NUMERO  , TRANSPORTISTA
        ElseIf cbFecha.Checked = False And cbNro_Guia.Checked = True And cbTransportista.Checked = True Then
            lista(Nothing, Nothing, txtnro_Guia.Text, txtTransportista.Text)
            '  TRANSPORTISTA
        ElseIf cbFecha.Checked = False And cbNro_Guia.Checked = False And cbTransportista.Checked = True Then
            lista(Nothing, Nothing, Nothing, txtTransportista.Text)
        Else
            lista(Nothing, Nothing, Nothing, Nothing)
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim f As New frmImprimiR
        f.Nivel = "FORMULARIO_LISTA_FLETE_TRANSPORTISTA"
        f.Tabla_Imprimir = tabla_Nota_Arroz
        f.Titulo_Informe = "REPORTE DE FLETE x TRANSPORTISTA"
        f.ShowDialog()
    End Sub

    Private Sub txtTransportista_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransportista.TextChanged

    End Sub
End Class
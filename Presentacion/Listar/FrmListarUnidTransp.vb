Public Class FrmListarUnidTransp
    Private formulario As New frmunidadtransporte
    Dim tabla_unidadtransportes As DataTable = Nothing
    Public Sub lista(ByVal opcion As Integer, ByVal criterio As String)
        LBF2.ForeColor = Color.Red
        LBF3.ForeColor = Color.Red
        LBF4.ForeColor = Color.Red
        LBF5.ForeColor = Color.Red
        LBF6.ForeColor = Color.Red
        LBF7.ForeColor = Color.Red

        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[PaListarUnidadTransporte]", opcion, criterio).Tables.Count > 0 Then
                tabla_unidadtransportes = servidor.consultar("[dbo].[PaListarUnidadTransporte]", opcion, criterio).Tables(0)
            End If
            If tabla_unidadtransportes Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY UNIDADES DE TRANSPORTES PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_unidadtransportes
                Dim NroFilas As Integer = tabla_unidadtransportes.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY UNIDADES DE TRANSPORTES PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("ID").Visible = False
                    dgvlista.Columns("Domicilio").Visible = False
                    dgvlista.Columns("RUC Emp Transporte").Visible = False
                    dgvlista.Columns("Descripcion").Visible = False
                    dgvlista.Columns("Id Transportista").Visible = False
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Unidad(es) de Tranporte(s)"
                    mesajeerror.ForeColor = Color.Black
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub FrmListarUnidTransps_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            rbplac_Rem.Checked = True
        End If
        If e.KeyCode = Keys.F3 Then
            e.SuppressKeyPress = True
            rbmar_rem.Checked = True
        End If
        If e.KeyCode = Keys.F4 Then
            e.SuppressKeyPress = True
            RbPlac_Sem.Checked = True
        End If
        If e.KeyCode = Keys.F5 Then
            e.SuppressKeyPress = True
            RbMar_Semi.Checked = True
        End If
        If e.KeyCode = Keys.F6 Then
            e.SuppressKeyPress = True
            rbEmpresa.Checked = True
        End If
        If e.KeyCode = Keys.F7 Then
            e.SuppressKeyPress = True
            RbTodos.Checked = True
        End If

        'PARA REGISTRAR CON TECLA INSERT
        If e.KeyCode = Keys.Insert Then
            e.SuppressKeyPress = True

            Insertar()

        End If
    End Sub


    Private Sub FrmListarUnidTransps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(6, Nothing)
        rbplac_Rem.Checked = True
    End Sub

    Private Sub btn_Acep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Acep.Click
        Close()
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
        If rbEmpresa.Checked = True And e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightCyan
        ElseIf rbmar_rem.Checked = True And e.ColumnIndex = 3 Then
            e.CellStyle.BackColor = Color.LightCyan
        ElseIf rbplac_Rem.Checked = True And e.ColumnIndex = 4 Then
            e.CellStyle.BackColor = Color.LightCyan
        ElseIf RbMar_Semi.Checked = True And e.ColumnIndex = 6 Then
            e.CellStyle.BackColor = Color.LightCyan
        ElseIf RbPlac_Sem.Checked = True And e.ColumnIndex = 7 Then
            e.CellStyle.BackColor = Color.LightCyan
        End If

        'If e.ColumnIndex = 3 Then
        '    e.CellStyle.BackColor = Color.LightCyan
        'End If
        'If e.ColumnIndex = 4 Then
        '    e.CellStyle.BackColor = Color.LightCyan
        'End If
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Insertar()
    End Sub

    Private Sub txtbusca_KeyDown1(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        saltar_Flechas(e)
    End Sub

    REM ========================================================================
#Region "INSERTAR"
    Private Sub Insertar()
        ' Me.formulario.lista_emptransporte(3)
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar unidad de transporte?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_unidad_transporte]",
                    False,
                    rpta,
                    mensaje,
                    formulario.id_vehi,
                    formulario.marca.Text.Trim,
                    formulario.nroplaca.Text.Trim,
                    formulario.nrocertificado.Text.Trim,
                    formulario.marca2.Text.Trim,
                    formulario.nroplaca2.Text.Trim,
                    formulario.nrocertificado2.Text.Trim,
                    formulario.largo.Text.Trim,
                    formulario.ancho.Text.Trim,
                    formulario.alto.Text.Trim,
                    formulario.Peso_neto1.Text.Trim,
                    formulario.largo2.Text.Trim,
                    formulario.ancho2.Text.Trim,
                    formulario.alto2.Text.Trim,
                    formulario.peso_neto2.Text.Trim,
                    formulario.Conf_Vehi.Text.Trim,
                    formulario.Pes_Veh.Text.Trim,
                    formulario.Peso_Bonif.Text.Trim,
                    formulario.Descripcion.Text.Trim,
                    formulario.id_transportista,
                    "N",
                    0, "")
                    If rpta > 0 Then
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
        End If

        formulario.id_vehi = -1
        formulario.marca.Text = ""
        formulario.nroplaca.Text = ""
        formulario.nrocertificado.Text = ""
        formulario.marca2.Text = ""
        formulario.nroplaca2.Text = ""
        formulario.nrocertificado2.Text = ""
        formulario.largo.Text = ""
        formulario.ancho.Text = ""
        formulario.alto.Text = ""
        formulario.Peso_neto1.Text = "0"
        formulario.largo2.Text = ""
        formulario.ancho2.Text = ""
        formulario.alto2.Text = ""
        formulario.peso_neto2.Text = "0"
        formulario.Conf_Vehi.Text = ""
        formulario.Pes_Veh.Text = ""
        formulario.Descripcion.Text = ""
        'Me.formulario.cboemptransporte.DataSource = Nothing
        formulario.id_transportista = -1

        indice = -1

        lista(6, Nothing)

    End Sub
#End Region
    REM ========================================================================

    REM ========================================================================
#Region "TEXTBOX"

    Private Sub txtbusca_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        Dim criterio As String = txtbusca.Text.Trim

        If rbEmpresa.Checked = True Then
            lista(1, txtbusca.Text)
        ElseIf rbmar_rem.Checked = True Then
            lista(2, txtbusca.Text)
        ElseIf rbplac_Rem.Checked = True Then
            lista(3, txtbusca.Text)
        ElseIf RbMar_Semi.Checked = True Then
            lista(4, txtbusca.Text)
        ElseIf RbPlac_Sem.Checked = True Then
            lista(5, txtbusca.Text)
        ElseIf RbTodos.Checked = True Then
            lista(6, txtbusca.Text)

        End If
    End Sub
    Private Sub RbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbTodos.CheckedChanged
        txtbusca.Text = ""
        'Me.txtbusca.Focus()
    End Sub

    Private Sub rbEmpresa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEmpresa.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub rbmar_rem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbmar_rem.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub rbplac_Rem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbplac_Rem.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub RbMar_Semi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbMar_Semi.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub RbPlac_Sem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbPlac_Sem.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub
#End Region
    REM ========================================================================
End Class
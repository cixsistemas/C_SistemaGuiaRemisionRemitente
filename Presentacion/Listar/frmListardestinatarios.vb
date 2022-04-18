Public Class frmListardestinatarios
    Dim tabla_cliente As DataTable
    Private formulario As New frmdestinatario
    Dim Dv As New DataView
    Dim CadenaBuscar As String 'Cadena para el Filtrado
    Public Sub lista(ByVal criterio As String)
        LBF2.ForeColor = Color.Red
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_Destinatario]", criterio).Tables.Count > 0 Then
                tabla_cliente = servidor.consultar("[dbo].[pa_listar_Destinatario]", criterio).Tables(0)
            End If
            If tabla_cliente Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = mensajeSinRegistros
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_cliente
                Dim NroFilas As Integer = tabla_cliente.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = mensajeSinRegistros
                    mesajeerror.ForeColor = Color.Red
                Else
                    'AGREGADO EL DIA 13-04-2022
                    Dv.Table = tabla_cliente ' Enlazamos el dataview con la tabla devuelta
                    ''=======================================================
                    dgvlista.Columns("ID").Visible = False
                    dgvlista.Columns("razonsocial").Visible = False
                    mesajeerror.Text = "Sistema tiene " + NroFilas.ToString + " registro(s)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellEnter
    '    indice = e.RowIndex
    'End Sub
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

    Private Sub btn_Acep_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Acep.Click
        Close()
    End Sub

    Private Sub frmListardestinatario_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If

        'PARA REGISTRAR CON TECLA INSERT
        If e.KeyCode = Keys.Insert Then
            e.SuppressKeyPress = True

            nuevo()
        End If
    End Sub


    Private Sub frmListardestinatarios_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        'lista(5)
        lista(Nothing)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        nuevo()
    End Sub

    Private Sub txtbusca_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.TextChanged
        'lista(txtbusca.Text)
        '' Aplicar_Filtro()
        CadenaBuscar = "razonsocial like '%" + txtbusca.Text.Trim + "%'"
        Dv.RowFilter = CadenaBuscar
        dgvlista.DataSource = Dv
        dgvlista.Update()
    End Sub

    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub

    Private Sub dgvlista_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick

    End Sub

    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightCyan
        End If
    End Sub

#Region "NUEVO"
    Public Sub nuevo()
        formulario.lista_tipodoc(11)
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim ruc As Object
                    Dim cbotipodoc As Object
                    Dim nro_doc As Object

                    If formulario.ruc.Text.Trim = "" Then
                        ruc = Nothing
                    Else
                        ruc = formulario.ruc.Text.Trim
                    End If

                    If formulario.nro_doc.Text.Trim = "" Then
                        cbotipodoc = Nothing
                        nro_doc = Nothing
                    Else
                        cbotipodoc = formulario.cbotipodoc.SelectedValue
                        nro_doc = formulario.nro_doc.Text.Trim
                    End If

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Destinatario]",
                    False,
                    rpta,
                    mensaje,
                    formulario.id_Destinatario,
                    formulario.razonsocial.Text.Trim,
                    ruc,
                    cbotipodoc,
                    nro_doc,
                    formulario.Direccion.Text.Trim,
                    formulario.Rep_Legal.Text.Trim,
                    formulario.id_ubigeo,
                     "N",
                    0, "")
                    If rpta > 0 Then
                        servidor.cerrarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        servidor.cancelarconexiontrans()
                        __mesajeerror = mensaje
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    __mesajeerror = servidor.getMensageError
                    servidor.cerrarconexiontrans()
                    MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        formulario.id_Destinatario = -1
        formulario.razonsocial.Text = ""
        formulario.ruc.Text = ""
        formulario.nro_doc.Text = ""
        formulario.cbotipodoc.DataSource = Nothing
        formulario.Direccion.Text = ""
        formulario.Rep_Legal.Text = ""
        formulario.id_ubigeo = -1
        formulario.distrito.Text = ""
        formulario.provincia.Text = ""
        formulario.departamento.Text = ""
        indice = -1

        lista(Nothing)
    End Sub
#End Region
End Class
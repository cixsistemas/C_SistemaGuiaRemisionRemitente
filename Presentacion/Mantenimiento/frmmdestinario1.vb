Public Class frmmdestinario1
    Private formulario As New frmmdestinario2
    Dim tabla_cliente As DataTable = Nothing
    Dim Dv As New DataView
    Dim CadenaBuscar As String 'Cadena para el Filtrado

    Public Sub lista(ByVal criterio As String)
        Label2.ForeColor = Color.Red
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

    Private Sub frmmdestinario_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If
    End Sub
    Private Sub frmmdestinario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
        'Me.cbobusca.SelectedIndex = 0
    End Sub
    Private Sub activa(ByVal estado As Boolean)
        txtbusca.Enabled = estado
        'Me.btnbusca.Enabled = estado
    End Sub





    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        formulario.lista_tipodoc(11)
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar Destinatario?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        modificarRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Destinatario", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If MessageBox.Show("¿Desea eliminar Destinatario?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then
                Dim rpta As Integer = -1
                Dim mensaje As String = ""

                servidor.ejecutar("[dbo].[pa_mantenimiento_Destinatario]",
                  False,
                  rpta,
                  mensaje,
                  CInt(dgvlista.Item("ID", indice).Value),
                  Nothing,
                  Nothing,
                  Nothing,
                  Nothing,
                   Nothing,
                  Nothing,
                   Nothing,
                 "E",
                  0, "")
                If rpta = 1 Then
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

        indice = -1

        lista(Nothing)
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim f As New frmImprimiR
        f.Nivel = "FORMULARIO_LISTA_Destinatario"
        f.Tabla_Imprimir = tabla_cliente
        f.Titulo_Informe = "REPORTE DE DESTINATARIOS"
        f.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
    Private Sub txtbusca_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.TextChanged
        'lista(txtbusca.Text)
        '' Aplicar_Filtro()
        CadenaBuscar = "razonsocial like '%" + txtbusca.Text.Trim + "%'"
        Dv.RowFilter = CadenaBuscar
        dgvlista.DataSource = Dv
        dgvlista.Update()
    End Sub

    Private Sub dgvlista_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dgvlista.KeyDown
        'PARA MODIFICAR REGISTRO CON TECLA ENTER
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            modificarRegistro()
        End If
    End Sub


    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub

    '================================================================
#Region "TRANSACCIONES"
    Private Sub modificarRegistro()
        If (indice = -1) Then
            MessageBox.Show("Seleccione Destinatario", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        formulario.id_Destinatario = CInt(dgvlista.Item("ID", indice).Value)
        formulario.razonsocial.Text = CStr(dgvlista.Item("RAZON SOCIAL", indice).Value)
        formulario.ruc.Text = CStr(dgvlista.Item("ruc", indice).Value.ToString.Trim)
        formulario.lista_tipodoc(11)
        If dgvlista.Item("TIPO DOC", indice).Value.ToString.Trim <> "" Then
            formulario.cbotipodoc.Text = CStr(dgvlista.Item("TIPO DOC", indice).Value)
        End If
        formulario.nro_doc.Text = CStr(dgvlista.Item("NRO DOC", indice).Value.ToString.Trim)

        formulario.Direccion.Text = CStr(dgvlista.Item("Direccion", indice).Value.ToString.Trim)

        formulario.Rep_Legal.Text = CStr(dgvlista.Item("Representante legal", indice).Value.ToString.Trim)

        formulario.id_ubigeo = CInt(dgvlista.Item("ID UBIGEO", indice).Value)
        formulario.distrito.Text = CStr(dgvlista.Item("distrito", indice).Value.ToString.Trim)
        formulario.provincia.Text = CStr(dgvlista.Item("provincia", indice).Value.ToString.Trim)
        formulario.departamento.Text = CStr(dgvlista.Item("departamento", indice).Value.ToString.Trim)

        'Exit Sub

        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar Destinatario?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
                    "M",
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
    '================================================================

    '================================================================
#Region "DATAGRIDVIEW"
    Private Sub dgvlista_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles dgvlista.RowsAdded
        btnmodificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvlista_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvlista.RowsRemoved
        btnmodificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvlista_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgvlista.VisibleChanged
        btnmodificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub


    'Private Sub dgvlista_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellContentClick
    '    indice = e.RowIndex
    'End Sub

    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
    End Sub
    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellEnter
        indice = e.RowIndex
    End Sub
#End Region
    '================================================================

End Class
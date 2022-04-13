Public Class frmmdestinario1
    Private formulario As New frmdestinatario

    Dim tabla_cliente As DataTable = Nothing
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
                mesajeerror.Text = "NO HAY DESTINATARIOS PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_cliente
                Dim NroFilas As Integer = tabla_cliente.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY DESTINATARIOS PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("ID").Visible = False
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Destinatario(s)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub frmmdestinario_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
        'Me.cbobusca.SelectedIndex = 0
    End Sub
    Private Sub activa(ByVal estado As Boolean)
        txtbusca.Enabled = estado
        'Me.btnbusca.Enabled = estado
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
        BtnModificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub


    'Private Sub dgvlista_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellContentClick
    '    indice = e.RowIndex
    'End Sub

    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
    End Sub
    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellEnter
        indice = e.RowIndex
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As System.EventArgs) Handles btnNuevo.Click
        formulario.lista_tipodoc(11)
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar Destinatario?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Destinatario]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_Destinatario, _
                    formulario.razonsocial.Text.Trim, _
                    ruc, _
                    cbotipodoc, _
                    nro_doc, _
                    formulario.Direccion.Text.Trim, _
                    formulario.Rep_Legal.Text.Trim, _
                    formulario.id_ubigeo, _
                     "N", _
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

    Private Sub btnmodificar_Click(sender As Object, e As System.EventArgs) Handles btnmodificar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Destinatario", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
            If MessageBox.Show("¿Desea guardar Destinatario?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Destinatario]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_Destinatario, _
                    formulario.razonsocial.Text.Trim, _
                    ruc, _
                    cbotipodoc, _
                    nro_doc, _
                     formulario.Direccion.Text.Trim, _
                      formulario.Rep_Legal.Text.Trim, _
                    formulario.id_ubigeo, _
                    "M", _
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

    Private Sub btnEliminar_Click(sender As Object, e As System.EventArgs) Handles btnEliminar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione Destinatario", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If MessageBox.Show("¿Desea eliminar Destinatario?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then
                Dim rpta As Integer = -1
                Dim mensaje As String = ""

                servidor.ejecutar("[dbo].[pa_mantenimiento_Destinatario]", _
                  False, _
                  rpta, _
                  mensaje, _
                  CInt(dgvlista.Item("ID", indice).Value), _
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

    Private Sub btnImprimir_Click(sender As Object, e As System.EventArgs) Handles btnImprimir.Click
        Dim f As New frmImprimiR
        f.Nivel = "FORMULARIO_LISTA_Destinatario"
        f.Tabla_Imprimir = tabla_cliente
        f.Titulo_Informe = "REPORTE DE DESTINATARIOS"
        f.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
    Private Sub txtbusca_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        lista(txtbusca.Text)
        ' Aplicar_Filtro()
    End Sub
    'Private Sub txtbusca_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Leave
    '    Me.txtbusca.BackColor = Color.White
    'End Sub
    'Private Sub txtbusca_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Enter
    '    Me.txtbusca.BackColor = Color.Moccasin
    'End Sub

    Private Sub dgvlista_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dgvlista.KeyDown
        'PARA MODIFICAR REGISTRO CON TECLA ENTER
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If (indice = -1) Then
                MessageBox.Show("Seleccione Destinatario", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                If MessageBox.Show("¿Desea guardar Destinatario?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
                        servidor.ejecutar("[dbo].[pa_mantenimiento_Destinatario]", _
                        False, _
                        rpta, _
                        mensaje, _
                        formulario.id_Destinatario, _
                        formulario.razonsocial.Text.Trim, _
                        ruc, _
                        cbotipodoc, _
                        nro_doc, _
                         formulario.Direccion.Text.Trim, _
                          formulario.Rep_Legal.Text.Trim, _
                        formulario.id_ubigeo, _
                        "M", _
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
        End If
    End Sub


    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub
End Class
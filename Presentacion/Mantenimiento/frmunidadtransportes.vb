Public Class frmunidadtransportes
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
            If servidor.consultar("[dbo].[pa_listar_unidad_transportes]", opcion, criterio).Tables.Count > 0 Then
                tabla_unidadtransportes = servidor.consultar("[dbo].[pa_listar_unidad_transportes]", opcion, criterio).Tables(0)
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
                    dgvlista.Columns("Id Transportista").Visible = False

                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " unidad(es) de tranporte(s)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Try
            'POSICIONA CURSOR EN ULTIMA FILA
            dgvlista.ClearSelection()
            dgvlista.CurrentCell = dgvlista.Rows(dgvlista.RowCount - 1).Cells(1)
            'Me.dgvlista.Refresh()
        Catch ex As Exception
            ' MessageBox.Show("Unidad de Transporte, no esta registrada", "Guía de Remisión-Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub frmunidadtransportess_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESCAPE
        'If (e.KeyCode = Keys.Enter) Then
        '    Me.Close()
        If (e.KeyCode = Keys.Escape) Then
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
    End Sub


    Private Sub frmunidadtransportess_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(6, Nothing)
        rbplac_Rem.Checked = True
        'Me.cbobusca.SelectedIndex = 0
    End Sub

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

    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellEnter
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If rbEmpresa.Checked = True And e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightYellow
        ElseIf rbmar_rem.Checked = True And e.ColumnIndex = 3 Then
            e.CellStyle.BackColor = Color.LightYellow
        ElseIf rbplac_Rem.Checked = True And e.ColumnIndex = 4 Then
            e.CellStyle.BackColor = Color.LightYellow
        ElseIf RbMar_Semi.Checked = True And e.ColumnIndex = 6 Then
            e.CellStyle.BackColor = Color.LightYellow
        ElseIf RbPlac_Sem.Checked = True And e.ColumnIndex = 7 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        'Me.formulario.lista_emptransporte(3)
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar unidad de transporte?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_unidad_transporte]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_vehi, _
                    formulario.marca.Text.Trim, _
                    formulario.nroplaca.Text.Trim, _
                    formulario.nrocertificado.Text.Trim, _
                    formulario.marca2.Text.Trim, _
                    formulario.nroplaca2.Text.Trim, _
                    formulario.nrocertificado2.Text.Trim, _
                    formulario.largo.Text.Trim, _
                    formulario.ancho.Text.Trim, _
                    formulario.alto.Text.Trim, _
                    formulario.Peso_neto1.Text.Trim, _
                    formulario.largo2.Text.Trim, _
                    formulario.ancho2.Text.Trim, _
                    formulario.alto2.Text.Trim, _
                    formulario.peso_neto2.Text.Trim, _
                    formulario.Conf_Vehi.Text.Trim, _
                    formulario.Pes_Veh.Text.Trim, _
                    formulario.Peso_Bonif.Text.Trim, _
                    formulario.Descripcion.Text.Trim, _
                   formulario.id_transportista, _
                    "N", _
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
        formulario.Peso_Bonif.Text = ""
        formulario.Descripcion.Text = ""
        ' Me.formulario.cboemptransporte.DataSource = Nothing
        formulario.id_transportista = -1
        formulario.Transportista.Text = ""
        indice = -1

        lista(6, Nothing)
    End Sub

    Private Sub btnmodificar_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles BtnModificar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione unidad de transporte", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        formulario.id_vehi = CInt(dgvlista.Item("ID", indice).Value)
        formulario.marca.Text = CStr(dgvlista.Item("Marca Camion", indice).Value)
        formulario.nroplaca.Text = CStr(dgvlista.Item("Nro. placa Camion", indice).Value.ToString.Trim)
        formulario.nrocertificado.Text = CStr(dgvlista.Item("Nro. certificado Camion", indice).Value.ToString.Trim)

        formulario.marca2.Text = CStr(dgvlista.Item("Marca Carreta", indice).Value.ToString.Trim)
        formulario.nroplaca2.Text = CStr(dgvlista.Item("Nro. Placa Carreta", indice).Value.ToString.Trim)
        formulario.nrocertificado2.Text = CStr(dgvlista.Item("Nro. Certificado Carreta", indice).Value.ToString.Trim)
        formulario.largo.Text = CStr(dgvlista.Item("Largo Camion", indice).Value.ToString.Trim)
        formulario.ancho.Text = CStr(dgvlista.Item("Ancho Camion", indice).Value.ToString.Trim)
        formulario.alto.Text = CStr(dgvlista.Item("Alto Camion", indice).Value.ToString.Trim)
        Try
            formulario.Peso_neto1.Text = CDbl(dgvlista.Item("Peso Neto Remolque", indice).Value)
            ' Me.formulario.Peso_neto1.Text = CStr(dgvlista.Item("Peso Neto Remolque", indice).Value.ToString.Trim)
        Catch ex As Exception
            formulario.Peso_neto1.Text = ""
        End Try
        ' Me.formulario.Peso_neto1.Text = CDbl(dgvlista.Item("Peso Neto Remolque", indice).Value)
        formulario.largo2.Text = CStr(dgvlista.Item("Largo Carreta", indice).Value.ToString.Trim)
        formulario.ancho2.Text = CStr(dgvlista.Item("Ancho Carreta", indice).Value.ToString.Trim)
        formulario.alto2.Text = CStr(dgvlista.Item("Alto Carreta", indice).Value.ToString.Trim)
        Try
            formulario.peso_neto2.Text = CDbl(dgvlista.Item("Peso Neto Semi-Remolque", indice).Value)
            ' Me.formulario.peso_neto2.Text = CStr(dgvlista.Item("Peso Neto Semi-Remolque", indice).Value.ToString.Trim)
        Catch ex As Exception
            formulario.peso_neto2.Text = ""
        End Try
        'Me.formulario.peso_neto2.Text = CDbl(dgvlista.Item("Peso Neto Semi-Remolque", indice).Value)
        formulario.Conf_Vehi.Text = CStr(dgvlista.Item("Configuracion Vehicular", indice).Value.ToString.Trim)
        formulario.Pes_Veh.Text = CStr(dgvlista.Item("Peso Vehicular", indice).Value.ToString.Trim)
        formulario.Peso_Bonif.Text = CStr(dgvlista.Item("Peso Bonificacion", indice).Value.ToString.Trim)
        formulario.Descripcion.Text = CStr(dgvlista.Item("Descripcion", indice).Value.ToString.Trim)
        ' Me.formulario.lista_emptransporte(3)
        ' Me.formulario.cboemptransporte.Text = CStr(dgvlista.Item("Empresa Transporte", indice).Value)

        formulario.id_transportista = CInt(dgvlista.Item("Id Transportista", indice).Value)
        formulario.Transportista.Text = CStr(dgvlista.Item("EMPRESA TRANSPORTE", indice).Value.ToString.Trim)
        ' Me.formulario.lista_emptransporte(3)

        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar unidad de transporte?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_unidad_transporte]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_vehi, _
                    formulario.marca.Text.Trim, _
                    formulario.nroplaca.Text.Trim, _
                    formulario.nrocertificado.Text.Trim, _
                    formulario.marca2.Text.Trim, _
                    formulario.nroplaca2.Text.Trim, _
                    formulario.nrocertificado2.Text.Trim, _
                    formulario.largo.Text.Trim, _
                    formulario.ancho.Text.Trim, _
                    formulario.alto.Text.Trim, _
                    formulario.Peso_neto1.Text.Trim, _
                    formulario.largo2.Text.Trim, _
                    formulario.ancho2.Text.Trim, _
                    formulario.alto2.Text.Trim, _
                    formulario.peso_neto2.Text.Trim, _
                    formulario.Conf_Vehi.Text.Trim, _
                    formulario.Pes_Veh.Text.Trim, _
                     formulario.Peso_Bonif.Text.Trim, _
                    formulario.Descripcion.Text.Trim, _
                   formulario.id_transportista, _
                    "M", _
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
        formulario.Peso_Bonif.Text = ""
        formulario.Descripcion.Text = ""
        formulario.id_transportista = -1
        formulario.Transportista.Text = ""

        indice = -1

        lista(6, Nothing)
    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione unidad de transporte", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If MessageBox.Show("¿Desea eliminar unidad de transporte?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then
                Dim rpta As Integer = -1
                Dim mensaje As String = ""

                servidor.ejecutar("[dbo].[pa_mantenimiento_unidad_transporte]", _
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
                  Nothing, _
                  Nothing, _
                  Nothing, _
                  Nothing, _
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
                    MessageBox.Show(__mesajeerror, "Molino los Angeles", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    servidor.cancelarconexiontrans()
                    __mesajeerror = mensaje
                    MessageBox.Show(__mesajeerror, "Molino los Angeles", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Else
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexiontrans()
                MessageBox.Show(__mesajeerror, "Molino los Angeles", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        indice = -1
        lista(6, Nothing)
    End Sub

    Private Sub btnImprimir_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimir.Click
        Dim f As New frmImprimiR
        f.Nivel = "FORMULARIO_LISTA_UNIDAD_TRANSPORTES"
        f.Tabla_Imprimir = tabla_unidadtransportes
        f.Titulo_Informe = "REPORTE DE UNIDAD DE TRANSPORTES"
        f.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub
    'Private Sub txtbusca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbusca.KeyPress
    '    If e.KeyChar = ChrW(Keys.Enter) Then
    '        e.Handled = True
    '        SendKeys.Send("{TAB}")
    '    End If
    'End Sub

    Private Sub txtbusca_KeyDown1(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtbusca_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.TextChanged
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
    Private Sub RbTodos_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RbTodos.CheckedChanged
        txtbusca.Text = ""
        'Me.txtbusca.Focus()
    End Sub

    Private Sub rbEmpresa_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbEmpresa.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub rbmar_rem_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbmar_rem.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub rbplac_Rem_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbplac_Rem.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub RbMar_Semi_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RbMar_Semi.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub RbPlac_Sem_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RbPlac_Sem.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub dgvlista_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dgvlista.KeyDown
        'PARA MODIFICAR REGISTRO CON TECLA ENTER
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If (indice = -1) Then
                MessageBox.Show("Seleccione unidad de transporte", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            formulario.id_vehi = CInt(dgvlista.Item("ID", indice).Value)
            formulario.marca.Text = CStr(dgvlista.Item("Marca Camion", indice).Value)
            formulario.nroplaca.Text = CStr(dgvlista.Item("Nro. placa Camion", indice).Value.ToString.Trim)
            formulario.nrocertificado.Text = CStr(dgvlista.Item("Nro. certificado Camion", indice).Value.ToString.Trim)

            formulario.marca2.Text = CStr(dgvlista.Item("Marca Carreta", indice).Value.ToString.Trim)
            formulario.nroplaca2.Text = CStr(dgvlista.Item("Nro. Placa Carreta", indice).Value.ToString.Trim)
            formulario.nrocertificado2.Text = CStr(dgvlista.Item("Nro. Certificado Carreta", indice).Value.ToString.Trim)
            formulario.largo.Text = CStr(dgvlista.Item("Largo Camion", indice).Value.ToString.Trim)
            formulario.ancho.Text = CStr(dgvlista.Item("Ancho Camion", indice).Value.ToString.Trim)
            formulario.alto.Text = CStr(dgvlista.Item("Alto Camion", indice).Value.ToString.Trim)
            Try
                formulario.Peso_neto1.Text = CDbl(dgvlista.Item("Peso Neto Remolque", indice).Value)
                ' Me.formulario.Peso_neto1.Text = CStr(dgvlista.Item("Peso Neto Remolque", indice).Value.ToString.Trim)
            Catch ex As Exception
                formulario.Peso_neto1.Text = ""
            End Try
            ' Me.formulario.Peso_neto1.Text = CDbl(dgvlista.Item("Peso Neto Remolque", indice).Value)
            formulario.largo2.Text = CStr(dgvlista.Item("Largo Carreta", indice).Value.ToString.Trim)
            formulario.ancho2.Text = CStr(dgvlista.Item("Ancho Carreta", indice).Value.ToString.Trim)
            formulario.alto2.Text = CStr(dgvlista.Item("Alto Carreta", indice).Value.ToString.Trim)
            Try
                formulario.peso_neto2.Text = CDbl(dgvlista.Item("Peso Neto Semi-Remolque", indice).Value)
                ' Me.formulario.peso_neto2.Text = CStr(dgvlista.Item("Peso Neto Semi-Remolque", indice).Value.ToString.Trim)
            Catch ex As Exception
                formulario.peso_neto2.Text = ""
            End Try
            'Me.formulario.peso_neto2.Text = CDbl(dgvlista.Item("Peso Neto Semi-Remolque", indice).Value)
            formulario.Conf_Vehi.Text = CStr(dgvlista.Item("Configuracion Vehicular", indice).Value.ToString.Trim)
            formulario.Pes_Veh.Text = CStr(dgvlista.Item("Peso Vehicular", indice).Value.ToString.Trim)
            formulario.Descripcion.Text = CStr(dgvlista.Item("Descripcion", indice).Value.ToString.Trim)
            ' Me.formulario.lista_emptransporte(3)
            ' Me.formulario.cboemptransporte.Text = CStr(dgvlista.Item("Empresa Transporte", indice).Value)

            formulario.id_transportista = CInt(dgvlista.Item("Id Transportista", indice).Value)
            formulario.Transportista.Text = CStr(dgvlista.Item("EMPRESA TRANSPORTE", indice).Value.ToString.Trim)
            ' Me.formulario.lista_emptransporte(3)

            formulario.ShowDialog()
            If formulario.Aceptar = True Then
                If MessageBox.Show("¿Desea guardar unidad de transporte?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim servidor As New clinicapacifico.clsaccesodatos
                    servidor.cadenaconexion = Ruta
                    If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                        Dim rpta As Integer = -1
                        Dim mensaje As String = ""
                        servidor.ejecutar("[dbo].[pa_mantenimiento_unidad_transporte]", _
                        False, _
                        rpta, _
                        mensaje, _
                        formulario.id_vehi, _
                        formulario.marca.Text.Trim, _
                        formulario.nroplaca.Text.Trim, _
                        formulario.nrocertificado.Text.Trim, _
                        formulario.marca2.Text.Trim, _
                        formulario.nroplaca2.Text.Trim, _
                        formulario.nrocertificado2.Text.Trim, _
                        formulario.largo.Text.Trim, _
                        formulario.ancho.Text.Trim, _
                        formulario.alto.Text.Trim, _
                        formulario.Peso_neto1.Text.Trim, _
                        formulario.largo2.Text.Trim, _
                        formulario.ancho2.Text.Trim, _
                        formulario.alto2.Text.Trim, _
                        formulario.peso_neto2.Text.Trim, _
                        formulario.Conf_Vehi.Text.Trim, _
                        formulario.Pes_Veh.Text.Trim, _
                        formulario.Descripcion.Text.Trim, _
                       formulario.id_transportista, _
                        "M", _
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
            formulario.id_transportista = -1
            formulario.Transportista.Text = ""

            indice = -1

            lista(6, Nothing)

        End If
    End Sub


    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub

End Class
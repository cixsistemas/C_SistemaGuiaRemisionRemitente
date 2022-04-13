Public Class FrmCategoria2
    Private formulario As New FrmCaTegoria1
    Dim tabla_CATEGORIA As DataTable = Nothing

    Public Sub lista(ByVal criterio As String)
        mesajeerror.ForeColor = Color.Blue
        LBF2.ForeColor = Color.Red
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_categoria]", criterio).Tables.Count > 0 Then
                tabla_CATEGORIA = servidor.consultar("[dbo].[pa_listar_categoria]", criterio).Tables(0)
            End If
            If tabla_CATEGORIA Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY CATEGORIAS PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_CATEGORIA
                Dim NroFilas As Integer = tabla_CATEGORIA.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY CATEGORIAS PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("ID").Visible = False
                    dgvlista.Columns("Precio Categoria").Visible = False
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " CATEGORIA(s)"
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

    Private Sub FrmCategoria22_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If
    End Sub

    Private Sub FrmCategoria22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(Nothing)
    End Sub
    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellEnter
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightYellow
        End If
    End Sub

    Private Sub dgvlista_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvlista.RowsAdded
        btnmodificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        ' Me.btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvlista_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvlista.RowsRemoved
        btnmodificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        ' Me.btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvlista_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvlista.VisibleChanged
        btnmodificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        ' Me.btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvlista_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick
        'indice = e.RowIndex
    End Sub

    Private Sub txtbusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        lista(txtbusca.Text)
    End Sub


    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione CATEGORIA", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        formulario.id_categoria = CInt(dgvlista.Item("ID", indice).Value)
        formulario.nombre.Text = CStr(dgvlista.Item("Nombre Categoria", indice).Value)
        formulario.precio_cat.Text = CStr(dgvlista.Item("Precio Categoria", indice).Value.ToString.Trim)
        formulario.descripcion.Text = CStr(dgvlista.Item("Descripcion Categoria", indice).Value.ToString.Trim)


        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar CATEGORIA?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.
                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_categoria]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_categoria, _
                    formulario.nombre.Text.Trim, _
                    formulario.precio_cat.Text.Trim, _
                    formulario.descripcion.Text.Trim, _
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

        formulario.nombre.Text = ""
        formulario.precio_cat.Text = ""
        formulario.descripcion.Text = ""

        indice = -1

        lista(Nothing)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione CATEGORIA", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If MessageBox.Show("¿Desea eliminar CATEGORIA?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then
                Dim rpta As Integer = -1
                Dim mensaje As String = ""

                servidor.ejecutar("[dbo].[pa_mantenimiento_categoria]", _
                  False, _
                  rpta, _
                  mensaje, _
                  CInt(dgvlista.Item("ID", indice).Value), _
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

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea guardar CATEGORIA?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_categoria]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_categoria, _
                    formulario.nombre.Text.Trim, _
                    formulario.precio_cat.Text.Trim, _
                    formulario.descripcion.Text.Trim, _
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

        formulario.id_categoria = -1
        formulario.nombre.Text = ""
        formulario.precio_cat.Text = ""
        formulario.descripcion.Text = ""

        indice = -1
        lista(Nothing)
    End Sub



    'Private Sub txtbusca_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Enter
    '    Me.txtbusca.BackColor = Color.Moccasin
    'End Sub

    'Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbusca.KeyDown
    '    saltar_Flechas(e)
    'End Sub

    Private Sub txtbusca_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Leave
        txtbusca.BackColor = Color.White
    End Sub

    Private Sub dgvlista_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dgvlista.KeyDown
        'PARA MODIFICAR REGISTRO CON TECLA ENTER
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True


            If (indice = -1) Then
                MessageBox.Show("Seleccione CATEGORIA", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            formulario.id_categoria = CInt(dgvlista.Item("ID", indice).Value)
            formulario.nombre.Text = CStr(dgvlista.Item("Nombre Categoria", indice).Value)
            formulario.precio_cat.Text = CStr(dgvlista.Item("Precio Categoria", indice).Value.ToString.Trim)
            formulario.descripcion.Text = CStr(dgvlista.Item("Descripcion Categoria", indice).Value.ToString.Trim)


            formulario.ShowDialog()
            If formulario.Aceptar = True Then
                If MessageBox.Show("¿Desea guardar CATEGORIA?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim servidor As New clinicapacifico.clsaccesodatos
                    servidor.cadenaconexion = Ruta
                    If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.
                        Dim rpta As Integer = -1
                        Dim mensaje As String = ""
                        servidor.ejecutar("[dbo].[pa_mantenimiento_categoria]", _
                        False, _
                        rpta, _
                        mensaje, _
                        formulario.id_categoria, _
                        formulario.nombre.Text.Trim, _
                        formulario.precio_cat.Text.Trim, _
                        formulario.descripcion.Text.Trim, _
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

            formulario.nombre.Text = ""
            formulario.precio_cat.Text = ""
            formulario.descripcion.Text = ""

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
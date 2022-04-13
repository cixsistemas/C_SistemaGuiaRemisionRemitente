Public Class frmproductos
    Private formulario As New frmproducto

    Dim tabla_producto As DataTable = Nothing

    Public Sub lista(ByVal opcion As Integer, ByVal criterio As String)
        LBF2.ForeColor = Color.Red
        LBF3.ForeColor = Color.Red
        LBF4.ForeColor = Color.Red
        LBF5.ForeColor = Color.Red
        LBF6.ForeColor = Color.Red
        LBF7.ForeColor = Color.Red
        LbF8.ForeColor = Color.Red

        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_productos]", opcion, criterio).Tables.Count > 0 Then
                tabla_producto = servidor.consultar("[dbo].[pa_listar_productos]", opcion, criterio).Tables(0)
            End If
            If tabla_producto Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY PRODUCTOS PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_producto
                Dim NroFilas As Integer = tabla_producto.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY PRODUCTOS PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("ID").Visible = False
                    dgvlista.Columns("Productox").Visible = False
                    dgvlista.Columns("Categoria").Visible = False
                    dgvlista.Columns("Id Logo").Visible = False
                    mesajeerror.Text = "Sistema tiene " + NroFilas.ToString + " Producto(S)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub activa(ByVal estado As Boolean)
        txtbusca.Enabled = estado
        ' Me.btnbusca.Enabled = estado
    End Sub

    Private Sub frmlproductoSs_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If


        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            rbProducto.Checked = True
        End If
        If e.KeyCode = Keys.F3 Then
            e.SuppressKeyPress = True
            RbNom_Com.Checked = True
        End If
        If e.KeyCode = Keys.F4 Then
            e.SuppressKeyPress = True
            rbcolor.Checked = True
        End If
        If e.KeyCode = Keys.F5 Then
            e.SuppressKeyPress = True
            rbcat.Checked = True
        End If
        If e.KeyCode = Keys.F6 Then
            e.SuppressKeyPress = True
            Rblogo.Checked = True
        End If
        If e.KeyCode = Keys.F7 Then
            e.SuppressKeyPress = True
            Rbenvase.Checked = True
        End If

        If e.KeyCode = Keys.F8 Then
            e.SuppressKeyPress = True
            RbTodos.Checked = True
        End If
    End Sub

    Private Sub frmlproductoSs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(7, Nothing)
        rbProducto.Checked = True
    End Sub

    Private Sub dgvlista_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvlista.RowsAdded
        BtnModificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvlista_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvlista.RowsRemoved
        BtnModificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
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
    Private Sub dgvlista_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellEnter
        indice = e.RowIndex
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        'Dim f As New _FrmCuentaFin2
        formulario.Nivel = "N"
        formulario.prod_id = -1
        formulario.prod_nom.Text = ""
        formulario.prod_peso_uni.Text = ""
        formulario.prod_color.Text = ""
        formulario.Nombre_Com.Text = ""
        formulario.cbocategoria.DataSource = Nothing
        formulario.id_logo = -1
        formulario.txtlogotipo.Text = ""
        formulario.cboenvasado.DataSource = Nothing

        lista(7, Nothing)

        formulario.lista_categoria(8)
        ' Me.formulario.lista_logotipo(9)
        formulario.lista_envasado(10)

        formulario.ShowDialog()


    End Sub

    Private Sub btnmodificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        UpdateRegistro()
    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione producto", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If MessageBox.Show("¿Desea eliminar producto?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then
                Dim rpta As Integer = -1
                Dim mensaje As String = ""
                servidor.ejecutar("[dbo].[pa_mantenimiento_producto]",
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
        lista(7, Nothing)
    End Sub

    Private Sub btnImprimir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim f As New frmImprimiR
            f.Nivel = "FORMULARIO_LISTA_PRODUCTOS"
            f.Tabla_Imprimir = tabla_producto
            f.Titulo_Informe = "REPORTE DE PRODUCTOS"
            f.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub
    'Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbusca.KeyDown
    '    If e.KeyData = Keys.Right Then
    '        SendKeys.Send("{TAB}")
    '    End If
    'End Sub
    Private Sub txtbusca_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Leave
        txtbusca.BackColor = Color.White
    End Sub
    'Private Sub txtbusca_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.Enter
    '    Me.txtbusca.BackColor = Color.Moccasin
    'End Sub
    Private Sub RbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbTodos.CheckedChanged
        txtbusca.Text = ""
        'Me.txtbusca.Focus()
    End Sub



    Private Sub rbProducto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbProducto.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub
    Private Sub RbNom_Com_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbNom_Com.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub
    Private Sub rbcolor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcolor.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub rbcat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcat.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub Rblogo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rblogo.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub RbPlac_Sem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rbenvase.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub txtbusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        Dim criterio As String = txtbusca.Text.Trim

        If rbProducto.Checked = True Then
            lista(1, txtbusca.Text)
        ElseIf RbNom_Com.Checked = True Then
            lista(2, txtbusca.Text)
        ElseIf rbcolor.Checked = True Then
            lista(3, txtbusca.Text)
        ElseIf rbcat.Checked = True Then
            lista(4, txtbusca.Text)
        ElseIf Rblogo.Checked = True Then
            lista(5, txtbusca.Text)
        ElseIf Rbenvase.Checked = True Then
            lista(6, txtbusca.Text)
        ElseIf RbTodos.Checked = True Then
            lista(7, txtbusca.Text)

        End If
    End Sub

    Private Sub dgvlista_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dgvlista.KeyDown
        'PARA MODIFICAR REGISTRO CON TECLA ENTER
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            UpdateRegistro()


        End If
    End Sub


    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub

    Public Sub UpdateRegistro()
        If (indice = -1) Then
            MessageBox.Show("Seleccione producto", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        formulario.prod_id = CInt(dgvlista.Item("ID", indice).Value)
        formulario.prod_nom.Text = CStr(dgvlista.Item("Productox", indice).Value)
        formulario.prod_peso_uni.Text = CStr(dgvlista.Item("Peso", indice).Value)
        formulario.prod_color.Text = CStr(dgvlista.Item("Color", indice).Value)
        formulario.Nombre_Com.Text = CStr(dgvlista.Item("Nombre Comercial", indice).Value.ToString.Trim)
        formulario.lista_categoria(8)
        formulario.cbocategoria.Text = CStr(dgvlista.Item("Categoria", indice).Value)
        'Me.formulario.lista_logotipo(9)

        formulario.id_logo = CInt(dgvlista.Item("Id Logo", indice).Value)
        formulario.txtlogotipo.Text = CStr(dgvlista.Item("Logotipo", indice).Value.ToString.Trim)
        formulario.lista_envasado(10)
        formulario.cboenvasado.Text = CStr(dgvlista.Item("Envasado", indice).Value)
        formulario.Nivel = "M"
        formulario.ShowDialog()


        indice = -1
        lista(7, Nothing)
    End Sub

End Class
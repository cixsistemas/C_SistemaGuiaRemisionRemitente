Public Class frmproductos
    Private formulario As New frmproducto

    Dim tabla_producto As DataTable = Nothing
    Dim Dv As New DataView
    Dim CadenaBuscar As String 'Cadena para el Filtrado
    Public Sub lista(ByVal opcion As Integer, ByVal criterio As String, ByVal Activo As String)
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
            If servidor.consultar("[dbo].[pa_listar_productos]", opcion, criterio, Activo).Tables.Count > 0 Then
                tabla_producto = servidor.consultar("[dbo].[pa_listar_productos]", opcion, criterio, Activo).Tables(0)
            End If
            If tabla_producto Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY REGISTROS PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_producto
                Dim NroFilas As Integer = tabla_producto.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY REGISTROS PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    'AGREGADO EL DIA 13-04-2022
                    Dv.Table = tabla_producto ' Enlazamos el dataview con la tabla devuelta
                    ''=======================================================
                    dgvlista.Columns("ID").Visible = False
                    dgvlista.Columns("Productox").Visible = False
                    dgvlista.Columns("Categoria").Visible = False
                    dgvlista.Columns("Id Logo").Visible = False
                    dgvlista.Columns("productoSinDetalle").Visible = False
                    mesajeerror.Text = "Sistema tiene " + NroFilas.ToString + " Registro(S)"
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

        If e.KeyCode = Keys.Insert Then
            e.SuppressKeyPress = True
            InsertarRegistro()
        End If

    End Sub

    Private Sub frmlproductoSs_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(7, Nothing, cbActivo.Checked)
        rbProducto.Checked = True
        cbActivo.Checked = True

    End Sub


    Private Sub txtbusca_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.Leave
        txtbusca.BackColor = Color.White
    End Sub

    Private Sub txtbusca_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.TextChanged
        Dim criterio As String = txtbusca.Text.Trim

        If rbProducto.Checked = True Then
            CadenaBuscar = "producto like '%" + txtbusca.Text.Trim + "%'"
            Dv.RowFilter = CadenaBuscar
            dgvlista.DataSource = Dv
            dgvlista.Update()
            'lista(1, txtbusca.Text)
        ElseIf RbNom_Com.Checked = True Then
            CadenaBuscar = "Comercial like '%" + txtbusca.Text.Trim + "%'"
            Dv.RowFilter = CadenaBuscar
            dgvlista.DataSource = Dv
            dgvlista.Update()
            ' lista(2, txtbusca.Text)
        ElseIf rbcolor.Checked = True Then
            CadenaBuscar = "Color like '%" + txtbusca.Text.Trim + "%'"
            Dv.RowFilter = CadenaBuscar
            dgvlista.DataSource = Dv
            dgvlista.Update()
            'lista(3, txtbusca.Text)
        ElseIf rbcat.Checked = True Then
            CadenaBuscar = "categoria like '%" + txtbusca.Text.Trim + "%'"
            Dv.RowFilter = CadenaBuscar
            dgvlista.DataSource = Dv
            dgvlista.Update()
            'lista(4, txtbusca.Text)
        ElseIf Rblogo.Checked = True Then
            CadenaBuscar = "logotipo like '%" + txtbusca.Text.Trim + "%'"
            Dv.RowFilter = CadenaBuscar
            dgvlista.DataSource = Dv
            dgvlista.Update()
            'lista(5, txtbusca.Text)
        ElseIf Rbenvase.Checked = True Then
            CadenaBuscar = "envasado like '%" + txtbusca.Text.Trim + "%'"
            Dv.RowFilter = CadenaBuscar
            dgvlista.DataSource = Dv
            dgvlista.Update()
            'lista(6, txtbusca.Text)
        ElseIf RbTodos.Checked = True Then
            txtbusca.Text = ""
            ''CadenaBuscar = "producto like '%" + txtbusca.Text.Trim + "%'"
            ''Dv.RowFilter = CadenaBuscar
            ''dgvlista.DataSource = Dv
            ''dgvlista.Update()
            lista(7, txtbusca.Text, cbActivo.Checked)

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

    '================================================================
#Region "TRANSACCIONES"
    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        InsertarRegistro()
    End Sub

    Private Sub btnmodificar_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles BtnModificar.Click
        UpdateRegistro()
    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminar.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione producto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If MessageBox.Show("¿Desea eliminar producto?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
        lista(7, Nothing, cbActivo.Checked)
    End Sub
    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        If (indice = -1) Then
            MessageBox.Show("Seleccione producto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If MessageBox.Show("¿Desea desactivar producto?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
                  Nothing,
                  False,
                  "A",
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
        lista(7, Nothing, cbActivo.Checked)
    End Sub
    Private Sub btnImprimir_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimir.Click
        Try
            Dim f As New frmImprimiR
            f.Nivel = "FORMULARIO_LISTA_PRODUCTOS"
            f.Tabla_Imprimir = tabla_producto
            f.Titulo_Informe = "REPORTE DE PRODUCTOS"
            f.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Public Sub UpdateRegistro()
        If (indice = -1) Then
            MessageBox.Show("Seleccione producto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'MessageBox.Show(Convert.ToString(indice))
        ''formulario.prod_nom.Text = Convert.ToString(dgvlista.Rows(indice).Cells("Productox").Value.ToString())
        formulario.cbProdSinDetalle.Enabled = False
        formulario.prod_nom.Focus()
        formulario.prod_id = CInt(dgvlista.Item("ID", indice).Value)
        formulario.prod_nom.Text = CStr(dgvlista.Item("Productox", indice).Value)
        formulario.prod_peso_uni.Text = CStr(dgvlista.Item("Peso", indice).Value)
        formulario.prod_color.Text = CStr(dgvlista.Item("Color", indice).Value)
        formulario.Nombre_Com.Text = CStr(dgvlista.Item("Comercial", indice).Value.ToString.Trim)
        formulario.lista_categoria(8)
        formulario.cbocategoria.Text = CStr(dgvlista.Item("Categoria", indice).Value)
        'Me.formulario.lista_logotipo(9)

        formulario.id_logo = CInt(dgvlista.Item("Id Logo", indice).Value)
        formulario.txtlogotipo.Text = CStr(dgvlista.Item("Logotipo", indice).Value.ToString.Trim)
        formulario.lista_envasado(10)
        formulario.cboenvasado.Text = CStr(dgvlista.Item("Envasado", indice).Value)
        formulario.cbProdSinDetalle.Checked = CBool(dgvlista.Item("productoSinDetalle", indice).Value)
        formulario.cbActivoMant.Checked = CBool(dgvlista.Item("Activo", indice).Value)

        formulario.Nivel = "M"



        formulario.ShowDialog()
        indice = -1

        formulario.prod_id = -1
        formulario.prod_nom.Text = ""
        formulario.prod_peso_uni.Text = ""
        formulario.prod_color.Text = ""
        formulario.Nombre_Com.Text = ""
        formulario.cbocategoria.DataSource = Nothing
        formulario.id_logo = -1
        formulario.txtlogotipo.Text = ""
        formulario.cboenvasado.DataSource = Nothing
        formulario.lista_categoria(8)
        ' Me.formulario.lista_logotipo(9)
        formulario.lista_envasado(10)
        'formulario.cbProdSinDetalle.Checked = True

        lista(7, "", cbActivo.Checked)
    End Sub

    Public Sub InsertarRegistro()
        formulario.prod_nom.Focus()
        'Dim f As New _FrmCuentaFin2
        formulario.cbProdSinDetalle.Checked = True
        'BLOQUEAR CONTROLES CUANDO ESTA SELECCIONADO PRODUCTO SIN DETALLE
        'formulario.prod_peso_uni.Enabled = False
        'formulario.prod_peso_uni.Text = 0
        formulario.btnlogotipo.Enabled = False
        formulario.txtlogotipo.Enabled = False
        formulario.txtlogotipo.Text = "."
        formulario.id_logo = 84
        formulario.cbocategoria.Enabled = False
        formulario.cbocategoria.SelectedValue = 8
        formulario.cboenvasado.Enabled = False
        formulario.cboenvasado.SelectedValue = 6
        formulario.prod_color.Enabled = False
        formulario.prod_color.Text = "."
        formulario.Nombre_Com.Enabled = False
        formulario.Nombre_Com.Text = "."
        'formulario.lblPeso.Visible = False
        formulario.lblLogo.Visible = False
        formulario.lblCategoria.Visible = False
        formulario.lblEnvasado.Visible = False
        formulario.lblColor.Visible = False
        formulario.lblNombreComercial.Visible = False
        '=============================================================

        formulario.Nivel = "N"
        formulario.prod_id = -1
        formulario.prod_nom.Text = ""
        formulario.prod_peso_uni.Text = ""
        formulario.prod_color.Text = ""
        formulario.Nombre_Com.Text = ""
        'formulario.cbocategoria.DataSource = Nothing
        'formulario.cbocategoria.SelectedValue = 0
        formulario.id_logo = -1
        formulario.txtlogotipo.Text = ""
        'formulario.cboenvasado.DataSource = Nothing
        'formulario.cboenvasado.SelectedValue = 0


        formulario.lista_categoria(8)
        ' Me.formulario.lista_logotipo(9)
        formulario.lista_envasado(10)

        formulario.ShowDialog()
        lista(7, "", cbActivo.Checked)
    End Sub
#End Region
    '================================================================

    '================================================================
#Region "RADIOBUTTON"
    Private Sub rbProducto_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbProducto.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub
    Private Sub RbNom_Com_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RbNom_Com.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub
    Private Sub rbcolor_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbcolor.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub rbcat_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbcat.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub Rblogo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Rblogo.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub

    Private Sub RbPlac_Sem_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Rbenvase.CheckedChanged
        txtbusca.Text = ""
        txtbusca.Focus()
    End Sub
    Private Sub RbTodos_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RbTodos.CheckedChanged
        txtbusca.Text = ""
        'Me.txtbusca.Focus()
    End Sub
#End Region
    '================================================================

    '================================================================
#Region "DATAGRIDVIEW"
    Private Sub dgvlista_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles dgvlista.RowsAdded
        BtnModificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub

    Private Sub dgvlista_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvlista.RowsRemoved
        BtnModificar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnEliminar.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
        btnImprimir.Enabled = CBool(IIf(dgvlista.Rows.Count > 0, True, False))
    End Sub


    Private Sub dgvlista_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgvlista.VisibleChanged
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


#End Region
    '================================================================



    Private Sub cbActivo_CheckedChanged(sender As Object, e As EventArgs) Handles cbActivo.CheckedChanged
        'If cbActivo.Checked = True Then
        lista(7, "", cbActivo.Checked)
        'End If
    End Sub
End Class
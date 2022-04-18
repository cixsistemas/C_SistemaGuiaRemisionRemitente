Public Class FrmListarProducto
    Private formulario As New frmproducto
    Dim tabla_producto As DataTable = Nothing
    Dim Dv As New DataView
    Dim CadenaBuscar As String 'Cadena para el Filtrado
    Public Sub lista(ByVal opcion As Integer, ByVal criterio As String)
        LBF2.ForeColor = Color.Red
        LBF3.ForeColor = Color.Red
        LBF4.ForeColor = Color.Red
        LBF5.ForeColor = Color.Red
        LBF6.ForeColor = Color.Red
        LBF7.ForeColor = Color.Red
        LbF8.ForeColor = Color.Red

        mesajeerror.ForeColor = Color.Black
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_productos]", opcion, criterio).Tables.Count > 0 Then
                tabla_producto = servidor.consultar("[dbo].[pa_listar_productos]", opcion, criterio).Tables(0)
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
                    dgvlista.Columns("Id Logo").Visible = False
                    dgvlista.Columns("productoSinDetalle").Visible = False
                    mesajeerror.Text = "Sistema tiene " + NroFilas.ToString + " registro(S)"
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

    Private Sub FrmListarProductos_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If
        'If (e.KeyCode = Keys.Escape) Then
        '    Me.Close()
        'End If

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
    Private Sub FrmListarProductos_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        ' Me.cbobusca.SelectedIndex = 0
        'activa(False)
        lista(7, Nothing)
        rbProducto.Checked = True
    End Sub

    Private Sub btn_Acep_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Acep.Click
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
    Private Sub RbTodos_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RbTodos.CheckedChanged
        txtbusca.Text = ""
        'Me.txtbusca.Focus()
    End Sub


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
            lista(7, txtbusca.Text)

        End If
    End Sub


    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
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
End Class
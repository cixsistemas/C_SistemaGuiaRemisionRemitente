Public Class FrmListar_Operacion_Ent
    Private formulario As New FrmOperacion_2

    Dim tabla_Operacion As DataTable = Nothing
    Public Sub lista(ByVal Tipo_Operacion As Integer, ByVal Criterio As String)
        LBF2.ForeColor = Color.Red
        LBF3.ForeColor = Color.Red
        LBF4.ForeColor = Color.Red
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_Operacion_Entrada]", Tipo_Operacion, Criterio).Tables.Count > 0 Then
                tabla_Operacion = servidor.consultar("[dbo].[pa_listar_Operacion_Entrada]", Tipo_Operacion, Criterio).Tables(0)
            End If
            If tabla_Operacion Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY OPERACION(es) PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_Operacion
                Dim NroFilas As Integer = tabla_Operacion.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY OPERACION(es) PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    dgvlista.Columns("Id Operacion").Visible = False
                    dgvlista.Columns("Id Tipo de Operacion").Visible = False
                    'Me.dgvlista.Columns("Apellido").Visible = False
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Operacion(es)"
                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub FrmListar_Operacion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            RbEntrada.Checked = True
        End If
        If e.KeyCode = Keys.F3 Then
            e.SuppressKeyPress = True
            RbSalida.Checked = True
        End If
        If e.KeyCode = Keys.F4 Then
            e.SuppressKeyPress = True
            RbTodos.Checked = True
        End If

        If e.KeyCode = Keys.Insert Then
            e.SuppressKeyPress = True

            formulario.ShowDialog()
            If formulario.Aceptar = True Then
                If MessageBox.Show("¿Desea Guardar Operacion?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim servidor As New clinicapacifico.clsaccesodatos
                    servidor.cadenaconexion = Ruta
                    If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                        Dim rpta As Integer = -1
                        Dim mensaje As String = ""
                        servidor.ejecutar("[dbo].[pa_mantenimiento_Operacion]", _
                        False, _
                        rpta, _
                        mensaje, _
                        formulario.id_Operacion, _
                        formulario.TxtCodigo.Text.Trim, _
                        formulario.TxtNombre.Text.Trim, _
                        formulario.TxtDescrip.Text.Trim, _
                        formulario.id_Tipo_Ope, _
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

            formulario.id_Operacion = -1
            formulario.TxtCodigo.Text = ""
            formulario.TxtNombre.Text = ""
            'formulario.TxtHumedad.Text = "0"
            formulario.TxtDescrip.Text = ""
            formulario.id_Tipo_Ope = -1
            formulario.TxtTipoOpe.Text = ""

            indice = -1

            lista(3, Nothing)

        End If
    End Sub

    Private Sub FrmListar_Operacion_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        lista(3, Nothing)
        RbEntrada.Checked = True
        indice = -1
        'Dim f As FrmMateria_Prima_2
        'If f.
        ' Me.TxtBusca.Focus()
    End Sub
    
    Private Sub DgvLista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellClick
        indice = e.RowIndex
    End Sub

    Private Sub DgvLista_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick

    End Sub

    Private Sub DgvLista_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellDoubleClick
        indice = e.RowIndex
        Close()
    End Sub
    Private Sub DgvLista_CellLeave(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvlista.CellLeave
        indice = e.RowIndex
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightCyan
        End If
    End Sub
    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub

    Private Sub TxtBusca_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.TextChanged
        Dim criterio As String = TxtBusca.Text.Trim
        ' Dim TIPO_OPERACION As String = Me.TextBox1.Text
        If RbEntrada.Checked = True Then
            'Me.txtbusca.Focus()
            lista(1, TxtBusca.Text)
            'ElseIf rbApellido.Checked = True Then
            '    ' Me.txtbusca.Focus()
            '    lista(2, Me.txtbusca.Text)
        ElseIf RbSalida.Checked = True Then
            lista(2, TxtBusca.Text)
            'Me.txtbusca.Focus()
        ElseIf RbTodos.Checked = True Then
            lista(3, Nothing)
            'Me.txtbusca.Focus()
        End If

        ' lista(3, TxtBusca.Text)
    End Sub
    Private Sub TxtBusca_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.Enter
        '   Me.TxtBusca.BackColor = Color.Azure
    End Sub

    Private Sub TxtBusca_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtbusca.Leave
        TxtBusca.BackColor = Color.White
    End Sub
    Private Sub btn_Acep_Click(sender As Object, e As EventArgs) Handles btn_Acep.Click
        If indice = -1 Then
            MessageBox.Show("Seleccione fila por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtbusca.Focus()
        Else
            Close()
        End If
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea Guardar Operacion?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_Operacion]", _
                    False, _
                    rpta, _
                    mensaje, _
                    formulario.id_Operacion, _
                    formulario.TxtCodigo.Text.Trim, _
                    formulario.TxtNombre.Text.Trim, _
                    formulario.TxtDescrip.Text.Trim, _
                    formulario.id_Tipo_Ope, _
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

        formulario.id_Operacion = -1
        formulario.TxtCodigo.Text = ""
        formulario.TxtNombre.Text = ""
        'formulario.TxtHumedad.Text = "0"
        formulario.TxtDescrip.Text = ""
        formulario.id_Tipo_Ope = -1
        formulario.TxtTipoOpe.Text = ""

        indice = -1

        lista(3, Nothing)
    End Sub

    Private Sub RbEntrada_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RbEntrada.CheckedChanged
        TxtBusca.Text = ""
        TxtBusca.Focus()
        lista(1, TxtBusca.Text)
    End Sub

    Private Sub RbSalida_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RbSalida.CheckedChanged
        TxtBusca.Text = ""
        TxtBusca.Focus()
        lista(2, TxtBusca.Text)
    End Sub

    Private Sub RbTodos_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RbTodos.CheckedChanged
        TxtBusca.Text = ""
        TxtBusca.Focus()
        lista(3, TxtBusca.Text)
    End Sub


End Class
Public Class FrmDev_Comp2
    Public id_Dev_Comp As Integer
    Public Aceptar As Boolean = False
    Public Nivel As String = ""
    'Public id_Comisionista As Integer = -1
    Public id_ope As Integer = -1
    Public id_Ubigeo As Integer = -1
    Dim Opc As String = "Nuevo"
    Private Sub FrmDev_Comp2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmDev_Comp2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmDev_Comp2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
    End Sub
    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim ok As Boolean
        ok = id_ope <> -1
        If ok = False Then
            MessageBox.Show("Seleccione en Operacion, por favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnOperacion.Focus()
            Exit Sub
        End If

        ok = id_Ubigeo <> -1
        If ok = False Then
            MessageBox.Show("Seleccione Ubigeo, por favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnubigeo.Focus()
            Exit Sub
        End If



        Dim f As New FrmListarEnvioCompAct
        f.btn_Acep.Text = "Aceptar"
        f.ShowDialog()

        REM verificamos si ya existe el articulo en la lista
        ' Dim ok As Boolean


        Try
            For i As Integer = 0 To dgvlista.Rows.Count - 1
                If dgvlista.Item("C", i).Value = f.dgvlista.Item("Id Det Envio Comp", indice).Value Then
                    MessageBox.Show("Envio de Tipo de Comprobante ya existe en la Lista", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Next
        Catch ex As Exception
        End Try

        'ok = False
        'For i As Integer = 0 To Me.dgvlista.Rows.Count - 1
        '    If dgvlista.Item("B", i).Value = f.dgvlista.Item("Id Secado", indice).Value Then
        '        ok = True
        '    End If
        'Next

        'If ok = True Then
        '    MessageBox.Show("Materia prima ya existe en la lista", "Sistema de inventarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If


        For i As Integer = 0 To f.dgvlista.Rows.Count - 1
            If CBool(f.dgvlista.Item(0, i).Value) = True Then
                '        'If CBool(dgvlista.Item(0, i).Value) = True Then 'verifica si se ha seleccionado uno o mas registros
                dgvlista.Rows.Add()
                'Me.dgvlista.Item("A", Me.dgvlista.Rows.Count - 1).Value = -1
                dgvlista.Item("A", dgvlista.Rows.Count - 1).Value = -1
                'Me.dgvlista.Item("B", Me.dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Id_Detalle_Env_Comp", i).Value
                dgvlista.Item("B", dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Id_Envio_Comp", i).Value
                dgvlista.Item("C", dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Id Det Envio Comp", i).Value
                dgvlista.Item("D", dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Comisionista", i).Value
                dgvlista.Item("E", dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Remitente", i).Value
                dgvlista.Item("F", dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Tipo de Comprobante de Pago", i).Value
                dgvlista.Item("G", dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Serie", i).Value
                dgvlista.Item("H", dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Numero", i).Value
                dgvlista.Item("I", dgvlista.Rows.Count - 1).Value = "" 'f.dgvlista.Item("Estado", i).Value
                'Me.dgvlista.Item("G", Me.dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Tendido Peso (Kg)", i).Value
            End If
            ''End If
        Next


    End Sub


    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            dgvlista.Rows.Remove(dgvlista.CurrentRow)
        Catch ex As Exception
            MessageBox.Show("No hay Registro para quitar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


        'If check_fila_grilla(dgvlista) = False Then
        '    MessageBox.Show("Seleccione registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'Else
        '    ' Me.dgvlista.Rows.Remove(Me.dgvlista.CurrentRow)
        '    quitar_fila_grilla(dgvlista, "SELECCIONAR", "Solo se Puede quitar registros ingresados recientemente")
        'End If
    End Sub
    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        indice = e.RowIndex
    End Sub




    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        Dim ok As Boolean

        ok = dgvlista.Item("I", dgvlista.Rows.Count - 1).Value <> ""
        If ok = False Then
            MessageBox.Show("Registre Estado, por favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Me.dgvlista.Item("I", Me.dgvlista.Rows.Count - 1).Value.Focus()
            Exit Sub
        End If

        ok = dgvlista.Rows.Count > 0
        If ok = False Then
            MessageBox.Show("Complete Campos faltantes en el detalle, por favor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Aceptar = True
        'Hide()


        If MessageBox.Show("¿DESEA " + IIf(Nivel = "N", "GUARDAR ", "MODIFICAR ") + " Devolución de Comprobantes de Pago?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ' If MessageBox.Show("¿Desea Guardar MAteria Prima?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                Dim RPTA_DOC As Integer = -1
                Dim MSG_DOC As String = ""
                servidor.ejecutar("[dbo].[pa_mantenimiento_Devolucion_Comp_de_Pago]",
                False,
                RPTA_DOC,
                MSG_DOC,
                id_Dev_Comp,
                CDate(Fecha_Ingreso.Value.ToShortDateString),
                 direccion.Text.Trim,
                txtDescrip.Text.Trim,
                id_Ubigeo,
                id_ope,
                Nivel.Trim,
                0, "")

                If RPTA_DOC > 0 Then
                    Dim RPTA_DET_DOC As Integer = -1
                    Dim MSG_DET_DOC As String = ""
                    For i As Integer = 0 To dgvlista.Rows.Count - 1
                        'Dim cod1 As Integer = Convert.ToInt32(Me.dgvlista.Item("C", i).Value)
                        servidor.ejecutar("[dbo].[pa_mantenimiento_Detalle_Devolucion_Comp_de_Pago]",
                        False,
                        RPTA_DET_DOC,
                        MSG_DET_DOC,
                          CInt(dgvlista.Item("A", i).Value.ToString()),
                          CStr(dgvlista.Item("I", i).Value.ToString()),
                          CInt(dgvlista.Item("C", i).Value.ToString()),
                          IIf(Nivel = "N", RPTA_DOC, id_Dev_Comp),
                        Nivel.Trim,
                        0, "")
                    Next
                    If RPTA_DET_DOC > 0 Then
                        servidor.cerrarconexiontrans()
                        __mesajeerror = MSG_DET_DOC
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Hide()
                    Else
                        servidor.cancelarconexiontrans()
                        __mesajeerror = MSG_DET_DOC
                        MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    servidor.cancelarconexiontrans()
                    __mesajeerror = MSG_DOC
                    MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexiontrans()
                MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub dgvlista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick

    End Sub

    Private Sub dgvlista_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 9 Then
            e.CellStyle.BackColor = Color.LightYellow
            e.CellStyle.ForeColor = Color.Blue
        End If
        'If e.ColumnIndex = 5 Then
        '    e.CellStyle.BackColor = Color.LightYellow
        'End If
    End Sub
    Private Sub BtnOperacion_Click(sender As Object, e As EventArgs) Handles BtnOperacion.Click
        Try
            Dim f As New FrmListar_Operacion_Ent
            f.ShowDialog()

            If indice >= 0 Then
                id_ope = CInt(f.dgvlista.Item("Id Operacion", indice).Value)
                TxtOpe.Text = CStr(f.dgvlista.Item("Operacion", indice).Value.ToString.Trim)
                TxtTipoOperac.Text = CStr(f.dgvlista.Item("Tipo de Operacion", indice).Value.ToString.Trim)
            End If
        Catch ex As Exception
            'If Me.TxtOpe.Text <> "" And TxtTipoOperac.Text <> "" Then
            '    MessageBox.Show("Seleccione Operacion por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If

        End Try
        indice = -1

        Fecha_Ingreso.Focus()
    End Sub
    Private Sub btnubigeo_Click(sender As Object, e As EventArgs) Handles btnubigeo.Click



        Try
            Dim f As New frmListarUbigeo
            f.ShowDialog()

            If indice >= 0 Then
                id_Ubigeo = CInt(f.dgvlista.Item("ID", indice).Value)
                distrito.Text = CStr(f.dgvlista.Item("Distrito", indice).Value.ToString.Trim)
                provincia.Text = CStr(f.dgvlista.Item("Provincia", indice).Value.ToString.Trim)
                departamento.Text = CStr(f.dgvlista.Item("Departamento", indice).Value.ToString.Trim)
            End If
        Catch ex As Exception
            'If Me.TxtOpe.Text <> "" And TxtTipoOperac.Text <> "" Then
            '    MessageBox.Show("Seleccione Operacion por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If

        End Try
        indice = -1

        txtDescrip.Focus()
    End Sub
    Private Sub direccion_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles direccion.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub direccion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles direccion.KeyDown
        saltar_Flechas(e)
    End Sub
    Private Sub direccion_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles direccion.Enter
        direccion.BackColor = Color.Moccasin
    End Sub
    Private Sub direccion_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles direccion.Leave
        direccion.BackColor = Color.White
    End Sub
    Private Sub Fecha_Ingreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Fecha_Ingreso.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub txtDescrip_Enter(sender As Object, e As EventArgs) Handles txtDescrip.Enter
        txtDescrip.BackColor = Color.Moccasin
    End Sub

    Private Sub txtDescrip_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescrip.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtDescrip_Leave(sender As Object, e As EventArgs) Handles txtDescrip.Leave
        txtDescrip.BackColor = Color.White
    End Sub
    Private Sub txtDescrip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescrip.KeyPress
        saltar_ENTER(e)
    End Sub
End Class
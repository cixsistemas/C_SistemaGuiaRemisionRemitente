Public Class FrmEnv_Comp2
    Public id_Env_Comp As Integer
    ' Public id_ubigeo As Integer = -1
    Public Aceptar As Boolean = False
    Public Nivel As String = ""
    Public id_Comisionista As Integer = -1
    Public id_ope As Integer = -1
    Public id_zona As Integer = -1
    Dim Opc As String = "Nuevo"

    Private Sub FrmEnv_Comp2_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs)
        Aceptar = False
        Hide()
    End Sub

    Private Sub FrmEnv_Comp2_KeyDown(sender As Object, e As KeyEventArgs)
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub FrmEnv_Comp2_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
    End Sub

    Private Sub FrmEnv_Comp2_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
    End Sub
    Private Sub btnAgregar_Click_1(sender As Object, e As System.EventArgs) Handles btnAgregar.Click
        Dim ok As Boolean
        ok = id_ope <> -1
        If ok = False Then
            MessageBox.Show("Seleccione en Operacion, por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnOperacion.Focus()
            Exit Sub
        End If

        ok = id_zona <> -1
        If ok = False Then
            MessageBox.Show("Seleccione Remitente, por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnZona.Focus()
            Exit Sub
        End If

        ok = id_Comisionista <> -1
        If ok = False Then
            MessageBox.Show("Seleccione Tipo de Comprobante, por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnComisionista.Focus()
            Exit Sub
        End If

        Dim f As New FrmListarIngCompAct
        f.btn_Acep.Text = "Aceptar"
        f.ShowDialog()

        REM verificamos si ya existe el articulo en la lista
        ' Dim ok As Boolean


        Try
            For i As Integer = 0 To dgvlista.Rows.Count - 1
                If dgvlista.Item("D", i).Value = f.dgvlista.Item("Id Det Ing Comp", indice).Value Then
                    MessageBox.Show("Envio de Tipo de Comprobante ya existe en la Lista", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                dgvlista.Item("B", dgvlista.Rows.Count - 1).Value = -1
                'Me.dgvlista.Item("B", Me.dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Id_Detalle_Env_Comp", i).Value
                dgvlista.Item("C", dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Id Ing Comp", i).Value
                dgvlista.Item("D", dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Id Det Ing Comp", i).Value
                dgvlista.Item("E", dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Remitente", i).Value
                dgvlista.Item("F", dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Tipo de Comprobante de Pago", i).Value
                dgvlista.Item("G", dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Serie", i).Value
                dgvlista.Item("H", dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Numero", i).Value
                dgvlista.Item("I", dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Estado", i).Value
                'Me.dgvlista.Item("G", Me.dgvlista.Rows.Count - 1).Value = f.dgvlista.Item("Tendido Peso (Kg)", i).Value
            End If
            ''End If
        Next

      
    End Sub
   
   
    Private Sub btnQuitar_Click(sender As Object, e As System.EventArgs) Handles btnQuitar.Click
        Try
            dgvlista.Rows.Remove(dgvlista.CurrentRow)
        Catch ex As Exception
            MessageBox.Show("No hay Registro para quitar", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


        'If check_fila_grilla(dgvlista) = False Then
        '    MessageBox.Show("Seleccione registro", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'Else
        '    ' Me.dgvlista.Rows.Remove(Me.dgvlista.CurrentRow)
        '    quitar_fila_grilla(dgvlista, "SELECCIONAR", "Solo se Puede quitar registros ingresados recientemente")
        'End If
    End Sub
    Private Sub dgvlista_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        indice = e.RowIndex
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As System.EventArgs) Handles btnaceptar.Click
        Dim ok As Boolean

        ok = dgvlista.Rows.Count > 0
        If ok = False Then
            MessageBox.Show("Registre el Ingreso de Tipo de Comprobantes de Pago, por favor.", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Aceptar = True
        'Hide()


        If MessageBox.Show("¿DESEA " + IIf(Nivel = "N", "GUARDAR ", "MODIFICAR ") + " Envio de Comprobantes de Pago?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ' If MessageBox.Show("¿Desea Guardar MAteria Prima?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim servidor As New clinicapacifico.clsaccesodatos
            servidor.cadenaconexion = Ruta
            If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                Dim RPTA_DOC As Integer = -1
                Dim MSG_DOC As String = ""
                servidor.ejecutar("[dbo].[pa_mantenimiento_Envio_Comp_de_Pago]", _
                False, _
                RPTA_DOC, _
                MSG_DOC, _
                id_Env_Comp, _
                CDate(Fecha_Ingreso.Value.ToShortDateString), _
                txtDescrip.Text.Trim, _
                id_Comisionista, _
                 id_zona, _
                id_ope, _
                Nivel.Trim, _
                0, "")

                If RPTA_DOC > 0 Then
                    Dim RPTA_DET_DOC As Integer = -1
                    Dim MSG_DET_DOC As String = ""
                    For i As Integer = 0 To dgvlista.Rows.Count - 1
                        servidor.ejecutar("[dbo].[pa_mantenimiento_Detalle_Envio_Comp_de_Pago]", _
                        False, _
                        RPTA_DET_DOC, _
                        MSG_DET_DOC, _
                          CInt(dgvlista.Item("B", i).Value.ToString()), _
                          CStr(dgvlista.Item("I", i).Value.ToString()), _
                           CInt(dgvlista.Item("D", i).Value.ToString()), _
                            IIf(Nivel = "N", RPTA_DOC, id_Env_Comp), _
                        Nivel.Trim, _
                        0, "")
                    Next
                    If RPTA_DET_DOC > 0 Then
                        servidor.cerrarconexiontrans()
                        __mesajeerror = MSG_DET_DOC
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Hide()
                    Else
                        servidor.cancelarconexiontrans()
                        __mesajeerror = MSG_DET_DOC
                        MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    servidor.cancelarconexiontrans()
                    __mesajeerror = MSG_DOC
                    MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexiontrans()
                MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If




        'Me.id_remitente = -1
        'Me.NombreRemitente.Text = ""
        'id_ope = -1
        'id_tipo_Comp = -1
        ''Me.Cantidad.Text = "0"
        'Me.TxtTipoComp.Text = ""
        'Me.TxtTipoOperac.Text = ""
        'Me.TxtOpe.Text = ""
        'TxtSerie.Text = ""
        'TxtNumero.Text = ""
        'TxtNumero2.Text = ""
        'dgvlista.DataSource = Nothing
        'dgvlista.Refresh()
        'indice = -1
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As System.EventArgs) Handles btneliminar.Click
        If check_fila_grilla(dgvlista) = False Then
            MessageBox.Show("Seleccione registro", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            For i As Integer = 0 To dgvlista.Rows.Count - 1
                If CBool(dgvlista.Item(0, i).Value) = True Then
                    Dim id As Integer = CInt(dgvlista.Item("B", i).Value.ToString())
                    If id = -1 Then
                        MessageBox.Show("Registro no se puede eliminar.", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    Else

                        If MessageBox.Show("¿DESEA ELIMINAR DETALLE RETIRO?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                            Dim servidor As New clinicapacifico.clsaccesodatos
                            servidor.cadenaconexion = Ruta
                            If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.
                                Dim RPTA_RET As Integer = -1
                                Dim MSG_RET As String = ""
                                servidor.ejecutar("[dbo].[pa_mantenimiento_Detalle_Envio_Comp_de_Pago]", _
                                False, _
                                RPTA_RET, _
                                MSG_RET, _
                               CInt(dgvlista.Item("B", i).Value.ToString), _
                                Nothing, _
                                 Nothing, _
                                Nothing, _
                               "E", _
                                0, "")

                                If RPTA_RET > 0 Then

                                    servidor.cerrarconexiontrans()

                                    __mesajeerror = MSG_RET

                                    MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    quitar_fila_grilla2(dgvlista, "SELECCIONAR")

                                Else

                                    servidor.cancelarconexiontrans()

                                    __mesajeerror = MSG_RET

                                    MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                                End If

                            Else

                                __mesajeerror = servidor.getMensageError

                                servidor.cerrarconexiontrans()

                                MessageBox.Show(__mesajeerror, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            End If

                        End If

                        quitar_check_fila_grilla(dgvlista)

                    End If

                End If

            Next

        End If


    End Sub

    Private Sub BtnOperacion_Click(sender As Object, e As System.EventArgs) Handles BtnOperacion.Click
        Try
            Dim f As New FrmListar_Operacion_Sal
            f.ShowDialog()

            If indice >= 0 Then
                id_ope = CInt(f.dgvlista.Item("Id Operacion", indice).Value)
                TxtOpe.Text = CStr(f.dgvlista.Item("Operacion", indice).Value.ToString.Trim)
                TxtTipoOperac.Text = CStr(f.dgvlista.Item("Tipo de Operacion", indice).Value.ToString.Trim)
            End If
        Catch ex As Exception
            'If Me.TxtOpe.Text <> "" And TxtTipoOperac.Text <> "" Then
            '    MessageBox.Show("Seleccione Operacion por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If

        End Try
        indice = -1

        btnZona.Focus()
    End Sub

    Private Sub btnZona_Click(sender As Object, e As System.EventArgs) Handles btnZona.Click
        Try
            Dim f As New FrmListarZona
            ' Dim f As New FrmProveedor_1
            f.ShowDialog()

            If indice >= 0 Then
                id_zona = CInt(f.dgvlista.Item("Id Zona", indice).Value)
                txtZona.Text = CStr(f.dgvlista.Item("Zona", indice).Value.ToString.Trim)
                txtDistrito.Text = CStr(f.dgvlista.Item("Distrito", indice).Value.ToString.Trim)
            End If
        Catch ex As Exception
            'If Me.TxtOpe.Text <> "" And TxtTipoOperac.Text <> "" Then
            '    MessageBox.Show("Seleccione Operacion por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If

        End Try
        indice = -1

        btnComisionista.Focus()
      
    End Sub

    Private Sub btnComisionista_Click(sender As Object, e As System.EventArgs) Handles btnComisionista.Click
        Try
            Dim f As New frmListarComisionistas
            ' Dim f As New FrmProveedor_1
            f.ShowDialog()

            If indice >= 0 Then
                id_Comisionista = CInt(f.dgvlista.Item("Id Comisionista", indice).Value)
                TxtComisionista.Text = CStr(f.dgvlista.Item("Comisionista", indice).Value.ToString.Trim)
            End If
        Catch ex As Exception
            'If Me.TxtOpe.Text <> "" And TxtTipoOperac.Text <> "" Then
            '    MessageBox.Show("Seleccione Operacion por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If

        End Try
        indice = -1

        Fecha_Ingreso.Focus()
    End Sub

   
   
    Private Sub dgvlista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

   

    Private Sub btncancelar_Click(sender As Object, e As System.EventArgs) Handles btncancelar.Click
        Aceptar = False
        Hide()
    End Sub
    Private Sub Fecha_Ingreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Fecha_Ingreso.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub txtDescrip_Enter(sender As Object, e As System.EventArgs) Handles txtDescrip.Enter
        txtDescrip.BackColor = Color.Moccasin
    End Sub

    Private Sub txtDescrip_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescrip.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub txtDescrip_Leave(sender As Object, e As System.EventArgs) Handles txtDescrip.Leave
        txtDescrip.BackColor = Color.White
    End Sub
    Private Sub txtDescrip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescrip.KeyPress
        saltar_ENTER(e)
    End Sub
End Class
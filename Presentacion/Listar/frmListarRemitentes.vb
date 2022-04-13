Public Class frmListarRemitentes
    Dim tabla_remitente As DataTable = Nothing
    Private formulario As New frmremitente
    Dim Dv As New DataView
    Dim CadenaBuscar As String 'Cadena para el Filtrado

    Public Sub lista(ByVal criterio As String)
        LBF2.ForeColor = Color.Red
        mesajeerror.ForeColor = Color.Blue
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            If servidor.consultar("[dbo].[pa_listar_remitentes]", criterio).Tables.Count > 0 Then
                tabla_remitente = servidor.consultar("[dbo].[pa_listar_remitentes]", criterio).Tables(0)
            End If
            If tabla_remitente Is Nothing Then
                servidor.cerrarconexion()
                mesajeerror.Text = "NO HAY REMITENTES PARA MOSTRAR"
                mesajeerror.ForeColor = Color.Red
            Else
                dgvlista.DataSource = tabla_remitente
                Dim NroFilas As Integer = tabla_remitente.Rows.Count
                If NroFilas = 0 Then
                    dgvlista.DataSource = Nothing
                    mesajeerror.Text = "NO HAY REMITENTES PARA MOSTRAR"
                    mesajeerror.ForeColor = Color.Red
                Else
                    'Representa una vista personalizada y enlazable a datos de un DataTable para ordenar
                    ', filtrar, buscar, editar y navegar. DataView no almacena datos, 
                    'sino que representa una vista conectada de su DataTable correspondiente . 
                    'Los cambios en los datos de DataView afectarán a DataTable . 
                    'Los cambios en los datos de DataTable afectarán a todos los DataView asociados con él.

                    'AGREGADO EL DIA 13-04-2022
                    Dv.Table = tabla_remitente ' Enlazamos el dataview con la tabla devuelta
                    ''=======================================================
                    dgvlista.Columns("ID").Visible = False
                    dgvlista.Columns("ID UBIGEO").Visible = False
                    'Me.dgvlista.Columns("Cuenta Detraccion").Visible = False
                    dgvlista.Columns("direccion").Visible = False
                    dgvlista.Columns("distrito").Visible = False
                    dgvlista.Columns("provincia").Visible = False
                    dgvlista.Columns("departamento").Visible = False
                    dgvlista.Columns("descripcion").Visible = False
                    mesajeerror.Text = "Guía de Remisión – Remitente tiene " + NroFilas.ToString + " Remitente(s)"

                End If
                servidor.cerrarconexion()
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub frmListarRemitente_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ENTER
        If (e.KeyCode = Keys.Enter) Then
            Close()
        End If

        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            txtbusca.Focus()
        End If

        'PARA REGISTRAR CON TECLA INSERT
        If e.KeyCode = Keys.Insert Then
            e.SuppressKeyPress = True

            Insertar()

        End If
    End Sub


    Private Sub frmListarRemitente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        'lista(1)
        lista(Nothing)
        indice = -1
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
    Private Sub btn_Acep_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Acep.Click
        If indice = -1 Then
            MessageBox.Show("Seleccione fila por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtbusca.Focus()
        Else
            Close()
        End If
        'Close()
    End Sub



    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Insertar()
    End Sub

    Private Sub txtbusca_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbusca.TextChanged
        CadenaBuscar = "Remitente like '%" + txtbusca.Text.Trim + "%'"
        Dv.RowFilter = CadenaBuscar
        dgvlista.DataSource = Dv
        dgvlista.Update()
    End Sub
    Private Sub txtbusca_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtbusca.KeyDown
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
            dgvlista.Focus()
        End If
    End Sub
    Private Sub dgvlista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlista.CellFormatting
        If e.ColumnIndex = 1 Then
            e.CellStyle.BackColor = Color.LightCyan
        End If
    End Sub

#Region "INSERTAR"
    Public Sub Insertar()
        formulario.ShowDialog()
        If formulario.Aceptar = True Then
            If MessageBox.Show("¿Desea Guardar Remitente?", "Guía de Remisión – Remitente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim servidor As New clinicapacifico.clsaccesodatos
                servidor.cadenaconexion = Ruta
                If servidor.abrirconexiontrans = True Then 'abrimos conección y iniciamos transacción.

                    Dim rpta As Integer = -1
                    Dim mensaje As String = ""
                    servidor.ejecutar("[dbo].[pa_mantenimiento_remitente]",
                    False,
                    rpta,
                    mensaje,
                    formulario.id_remitente,
                    formulario.nombre.Text.Trim,
                    formulario.ruc.Text.Trim,
                    formulario.txtCuenta.Text.Trim,
                    formulario.direccion.Text.Trim,
                    formulario.descripcion.Text.Trim,
                    formulario.id_ubigeo,
                    "N",
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

        formulario.id_remitente = -1
        formulario.nombre.Text = ""
        formulario.ruc.Text = ""
        formulario.txtCuenta.Text = ""

        formulario.id_ubigeo = -1
        formulario.distrito.Text = ""
        formulario.provincia.Text = ""
        formulario.departamento.Text = ""

        formulario.direccion.Text = ""
        formulario.descripcion.Text = ""


        indice = -1

        lista(Nothing)
    End Sub
#End Region

End Class
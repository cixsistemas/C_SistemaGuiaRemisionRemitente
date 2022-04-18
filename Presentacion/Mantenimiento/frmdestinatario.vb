Public Class frmdestinatario

    Public id_Destinatario As Integer = -1
    Public id_ubigeo As Integer = -1
  Public Aceptar As Boolean = False

  Dim tabla_tipodoc As DataTable = Nothing

  Private Sub valida()
    Dim ok As Boolean
    ok = razonsocial.Text.Trim <> ""
    If ruc.Text.Trim = "" And nro_doc.Text.Trim = "" Then
      ok = ok And False
    Else
      If ruc.Text.Trim <> "" Then
        ok = ok And ruc.Text.Trim Like "###########"
      End If
      If nro_doc.Text.Trim <> "" Then
        ok = ok And Not cbotipodoc.DataSource Is Nothing
        ok = ok And nro_doc.Text.Trim Like "########"
      End If
    End If

    btnaceptar.Enabled = ok
  End Sub

  Public Sub lista_tipodoc(ByVal opcion As Integer)
    'Me.mesajeerror.ForeColor = Color.Blue
    Dim servidor As New clinicapacifico.clsaccesodatos
    servidor.cadenaconexion = Ruta
    If servidor.abrirconexion = True Then
      If servidor.consultar("[dbo].[pa_listar]", opcion).Tables.Count > 0 Then
        tabla_tipodoc = servidor.consultar("[dbo].[pa_listar]", opcion).Tables(0)
      End If
      cbotipodoc.DataSource = tabla_tipodoc
      cbotipodoc.DisplayMember = "Nombre"
      cbotipodoc.ValueMember = "Codigo"
      servidor.cerrarconexion()
    Else
      __mesajeerror = servidor.getMensageError
      servidor.cerrarconexion()
            MessageBox.Show(__mesajeerror, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub frmcliente_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
    Aceptar = False
    Hide()
    End Sub

    Private Sub frmcliente_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Ruta = ConfigurationManager.AppSettings("CadenaConeccion").ToString()
        'lista_tipodoc(11)

    End Sub

    Private Sub cbotipodoc_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbotipodoc.SelectedIndexChanged
        nro_doc.Text = ""
        nro_doc.Focus()
        valida()
    End Sub



  Private Sub activa(ByVal estado As Boolean)
    nro_doc.Text = ""
    nro_doc.Enabled = estado
    cbotipodoc.Enabled = estado
    End Sub

    Private Sub ruc_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ruc.KeyDown
        saltar_Flechas(e)
    End Sub


  Private Sub ruc_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ruc.TextChanged
    If ruc.Text.Trim <> "" Then
      activa(False)
    Else
      activa(True)
    End If
    valida()
  End Sub

  Private Sub ruc_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ruc.VisibleChanged
    'If ruc.Text.Trim <> "" Then
    '    activa(False)
    'Else
    '    activa(True)
    'End If
    valida()
    End Sub

    Private Sub nro_doc_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nro_doc.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub nro_doc_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nro_doc.TextChanged
        If nro_doc.Text.Trim <> "" Then
            ruc.Text = ""
            ruc.Enabled = False
        Else
            ruc.Text = ""
            ruc.Enabled = True
        End If
        valida()
    End Sub

  Private Sub nro_doc_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nro_doc.VisibleChanged
    valida()
  End Sub

  Private Sub btnaceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnaceptar.Click
    Aceptar = True
    Hide()
  End Sub

  Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncancelar.Click
    Aceptar = False
    Hide()
    End Sub

    Private Sub razonsocial_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles razonsocial.KeyDown
        saltar_Flechas(e)
    End Sub

    Private Sub razonsocial_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles razonsocial.TextChanged
        valida()
    End Sub

  Private Sub razonsocial_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles razonsocial.VisibleChanged
    valida()
  End Sub

  Private Sub cbotipodoc_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbotipodoc.VisibleChanged
    valida()
    End Sub

    Private Sub frmdestinatario_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub
    Private Sub razonsocial_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles razonsocial.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub ruc_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ruc.KeyPress
        SoloNumeros(e, False, sender.Text)
        saltar_ENTER(e)
    End Sub
    Private Sub cbotipodoc_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles cbotipodoc.KeyPress
        saltar_ENTER(e)
    End Sub
    Private Sub nro_doc_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nro_doc.KeyPress
        SoloNumeros(e, False, sender.Text)
        saltar_ENTER(e)
    End Sub

    Private Sub razonsocial_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles razonsocial.Leave
        razonsocial.BackColor = Color.White
    End Sub
    Private Sub razonsocial_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles razonsocial.Enter
        razonsocial.BackColor = Color.Moccasin
    End Sub

    Private Sub ruc_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles ruc.Enter
        ruc.BackColor = Color.Moccasin
    End Sub
    Private Sub ruc_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles ruc.Leave
        ruc.BackColor = Color.White
    End Sub

    Private Sub btnUbigeo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUbigeo.Click
        Try
            Dim f As New frmListarUbigeo
            f.ShowDialog()
            If indice <> -1 Then
                id_ubigeo = CInt(f.dgvlista.Item("ID", indice).Value)
                distrito.Text = CStr(f.dgvlista.Item("Distrito", indice).Value.ToString.Trim)
                provincia.Text = CStr(f.dgvlista.Item("Provincia", indice).Value.ToString.Trim)
                departamento.Text = CStr(f.dgvlista.Item("Departamento", indice).Value.ToString.Trim)
                indice = -1
            Else
                distrito.Text = ""
                provincia.Text = ""
                departamento.Text = ""
                indice = -1
                id_ubigeo = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        btnaceptar.Focus()
    End Sub

    Private Sub Direccion_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Direccion.Enter
        Direccion.BackColor = Color.Moccasin
    End Sub

    Private Sub Direccion_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Direccion.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub Direccion_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Direccion.Leave
        Direccion.BackColor = Color.White
    End Sub

    Private Sub Direccion_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Direccion.TextChanged

    End Sub

    Private Sub Rep_Legal_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Rep_Legal.Enter
        Rep_Legal.BackColor = Color.Moccasin
    End Sub

    Private Sub Rep_Legal_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Rep_Legal.KeyPress
        saltar_ENTER(e)
    End Sub

    Private Sub Rep_Legal_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Rep_Legal.Leave
        Rep_Legal.BackColor = Color.White
    End Sub

    Private Sub Rep_Legal_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Rep_Legal.TextChanged

    End Sub
End Class
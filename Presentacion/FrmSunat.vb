Option Explicit On
Imports System.Xml
Imports MSXML2

Public Class FrmSunat
    Dim xDat As String
    Dim xRazSoc As String, xEst As String, xCon As String, xDir As String
    Dim xRazSocX As Long, xEstX As Long, xConX As Long, xDirX As Long
    Dim xRazSocY As Long, xEstY As Long, xConY As Long, xDirY As Long


    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConsultar.Click
        If Trim(txtRuc.Text) = "" Then
            MsgBox("Ingrese número del RUC")
            txtRuc.Focus()
            Exit Sub
        End If
        If IsNumeric(txtRuc.Text) = True Then
            If Len(txtRuc.Text) < 11 Then
                Limpiar()
                MsgBox("Ingrese los 11 números del RUC")
                txtRuc.Focus()
                Exit Sub
            End If
            If Val(Mid(Trim(txtRuc.Text), 2, 9)) = 0 Or Trim(txtRuc.Text) = "23333333333" Then
                Limpiar()
                MsgBox("Verificar número del RUC")
                txtRuc.Focus()
                Exit Sub
            End If
            If Verificar_ruc(txtRuc.Text) = False Then
                Limpiar()
                MsgBox("El número del RUC no es válido")
                txtRuc.Focus()
                Exit Sub
            End If
            RUC(txtRuc.Text)
            OTRO(txtRuc.Text)
        Else
            Limpiar()
            MsgBox("Solo se aceptan números")
            txtRuc.Focus()
        End If
        'btnlimpiar.Focus()
    End Sub
    Private Sub Limpiar()
        xRazSoc = ""
        xEst = ""
        xCon = ""
        xDir = ""
        txtRazSoc.Text = ""
        txtEst.Text = ""
        txtCon.Text = ""
        txtDir.Text = ""
        ' txtRuc.Text = ""
    End Sub

    Function Verificar_ruc(ByVal xNum As String) As Boolean
        Dim li_suma, li_residuo, li_diferencia, li_compara As Integer
        li_suma = (CInt(Mid(xNum, 1, 1)) * 5) + (CInt(Mid(xNum, 2, 1)) * 4) + (CInt(Mid(xNum, 3, 1)) * 3) + (CInt(Mid(xNum, 4, 1)) * 2) + (CInt(Mid(xNum, 5, 1)) * 7) + (CInt(Mid(xNum, 6, 1)) * 6) + (CInt(Mid(xNum, 7, 1)) * 5) + (CInt(Mid(xNum, 8, 1)) * 4) + (CInt(Mid(xNum, 9, 1)) * 3) + (CInt(Mid(xNum, 10, 1)) * 2)
        li_compara = CInt(Mid(xNum, 11, 1))
        li_residuo = li_suma Mod 11
        li_diferencia = Int(11 - li_residuo)
        If li_diferencia > 9 Then li_diferencia = li_diferencia - 10
        If li_diferencia <> li_compara Then
            Verificar_ruc = False
        Else
            Verificar_ruc = True
        End If
    End Function
    Private Sub RUC(ByVal xNum As String)
        On Error Resume Next
        Dim xWml As New XMLHTTP
        xWml.open("POST", "http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRuc&razSoc=&nroRuc=10015569943&nrodoc=&contexto=rrrrrrr&tQuery=on&search1=10015569943&codigo=&tipdoc=1&search2=&coddpto=&codprov=&coddist=&search3=" & xNum, False)
        ' xWml.open("POST", "http://www.sunat.gob.pe/w/wapS01Alias?ruc=" & xNum, False)
        'xWml.open("POST", "http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias" & xNum, False)

        xWml.send()
        If xWml.status = 200 Then
            Limpiar()
            xDat = xWml.responseText
            If Len(xDat) <= 635 Then

                MsgBox("El numero Ruc ingresado no existe en la Base de datos de la SUNAT")
                xWml = Nothing
                txtRuc.Focus()
                Exit Sub
            End If

            xDat = Replace(xDat, "N&#xFA;mero Ruc. </b> " & xNum & " - ", "RazonSocial:")
            xDat = Replace(xDat, "Estado.</b>", "Estado:")
            xDat = Replace(xDat, "Agente Retenci&#xF3;n IGV.", "ARIGV:")
            xDat = Replace(xDat, "Situaci&#xF3;n.<b> ", "Situacion:")
            xDat = Replace(xDat, "Direcci&#xF3;n.</b><br/>", "Direccion:")
            xDat = Replace(xDat, "     ", " ")
            xDat = Replace(xDat, "    ", " ")
            xDat = Replace(xDat, "   ", " ")
            xDat = Replace(xDat, "  ", " ")
            xDat = Replace(xDat, "( ", "(")
            xDat = Replace(xDat, " )", ")")

            xRazSocX = InStr(1, xDat, "RazonSocial:", vbTextCompare)
            xRazSocY = InStr(1, xDat, " <br/></small>", vbTextCompare)
            xRazSocX = xRazSocX + 12
            xRazSoc = Mid(xDat, xRazSocX, (xRazSocY - xRazSocX))

            xEstX = InStr(1, xDat, "Estado:", vbTextCompare)
            xEstY = InStr(1, xDat, "ARIGV:", vbTextCompare)
            xEstX = xEstX + 7
            xEst = Mid(xDat, xEstX, ((xEstY - 34) - xEstX))

            xConX = InStr(1, xDat, "Situacion:", vbTextCompare)
            xConY = InStr(1, xDat, "</b></small><br/>", vbTextCompare)
            xDirY = xConX - 23
            xConX = xConX + 10
            xCon = Mid(xDat, xConX, (xConY - xConX))

            xDirX = InStr(1, xDat, "Direccion:", vbTextCompare)
            xDirX = xDirX + 10
            xDir = Mid(xDat, xDirX, (xDirY - xDirX))

            xRazSoc = Replace(xRazSoc, "&#209;", "Ñ")
            xRazSoc = Replace(xRazSoc, "&#xD1;", "Ñ")
            xRazSoc = Replace(xRazSoc, "&#193;", "Á")
            xRazSoc = Replace(xRazSoc, "&#201;", "É")
            xRazSoc = Replace(xRazSoc, "&#205;", "Í")
            xRazSoc = Replace(xRazSoc, "&#211;", "Ó")
            xRazSoc = Replace(xRazSoc, "&#218;", "Ú")
            xRazSoc = Replace(xRazSoc, "&#xC1;", "Á")
            xRazSoc = Replace(xRazSoc, "&#xC9;", "É")
            xRazSoc = Replace(xRazSoc, "&#xCD;", "Í")
            xRazSoc = Replace(xRazSoc, "&#xD3;", "Ó")
            xRazSoc = Replace(xRazSoc, "&#xDA;", "Ú")

            xDir = Replace(xDir, "&#209;", "Ñ")
            xDir = Replace(xDir, "&#xD1;", "Ñ")
            xDir = Replace(xDir, "&#193;", "Á")
            xDir = Replace(xDir, "&#201;", "É")
            xDir = Replace(xDir, "&#205;", "Í")
            xDir = Replace(xDir, "&#211;", "Ó")
            xDir = Replace(xDir, "&#218;", "Ú")
            xDir = Replace(xDir, "&#xC1;", "Á")
            xDir = Replace(xDir, "&#xC9;", "É")
            xDir = Replace(xDir, "&#xCD;", "Í")
            xDir = Replace(xDir, "&#xD3;", "Ó")
            xDir = Replace(xDir, "&#xDA;", "Ú")

            txtRazSoc.Text = xRazSoc
            txtEst.Text = xEst
            txtCon.Text = xCon
            txtDir.Text = xDir
        Else

            Limpiar()
            MsgBox("No responde el servicio de la SUNAT")
        End If
        xWml = Nothing
    End Sub
    Private Sub OTRO(ByVal xNum As String)
        On Error Resume Next
        Dim xWml As New XMLHTTP
        'xWml.open("POST", "http://www.sunat.gob.pe/w/wapS01Alias?ruc=" & xNum, False)
        xWml.open("POST", "http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRuc&razSoc=&nroRuc=10015569943&nrodoc=&contexto=rrrrrrr&tQuery=on&search1=10015569943&codigo=&tipdoc=1&search2=&coddpto=&codprov=&coddist=&search3=" & xNum, False)
        xWml.send()
        If xWml.Status = 200 Then
            Limpiar()
            xDat = xWml.responseText
            If Len(xDat) <= 635 Then

                MsgBox("El numero Ruc ingresado no existe en la Base de datos de la SUNAT")
                xWml = Nothing
                txtRuc.Focus()
                Exit Sub

            End If

            Dim xTabla() As String

            xDat = Replace(xDat, "     ", " ")
            xDat = Replace(xDat, "    ", " ")
            xDat = Replace(xDat, "   ", " ")
            xDat = Replace(xDat, "  ", " ")
            xDat = Replace(xDat, "( ", "(")
            xDat = Replace(xDat, " )", ")")

            xTabla = Split(xDat, "<small>")

            xTabla(1) = Replace(xTabla(1), "<b>N&#xFA;mero Ruc. </b> " & xNum & " - ", "")
            xTabla(1) = Replace(xTabla(1), " <br/></small>", "")

            xTabla(4) = Replace(xTabla(4), "<b>Estado.</b>", "")
            xTabla(4) = Replace(xTabla(4), "</small><br/>", "")

            xTabla(7) = Replace(xTabla(7), "<b>Direcci&#xF3;n.</b><br/>", "")
            xTabla(7) = Replace(xTabla(7), "</small><br/>", "")

            xTabla(8) = Replace(xTabla(8), "Situaci&#xF3;n.<b> ", "")
            xTabla(8) = Replace(xTabla(8), "</b></small><br/>", "")

            xRazSoc = CStr(xTabla(1))
            xEst = CStr(xTabla(4))
            xDir = CStr(xTabla(7))
            xCon = CStr(xTabla(8))

            xRazSoc = Replace(xRazSoc, "&#209;", "Ñ")
            xRazSoc = Replace(xRazSoc, "&#xD1;", "Ñ")
            xRazSoc = Replace(xRazSoc, "&#193;", "Á")
            xRazSoc = Replace(xRazSoc, "&#201;", "É")
            xRazSoc = Replace(xRazSoc, "&#205;", "Í")
            xRazSoc = Replace(xRazSoc, "&#211;", "Ó")
            xRazSoc = Replace(xRazSoc, "&#218;", "Ú")
            xRazSoc = Replace(xRazSoc, "&#xC1;", "Á")
            xRazSoc = Replace(xRazSoc, "&#xC9;", "É")
            xRazSoc = Replace(xRazSoc, "&#xCD;", "Í")
            xRazSoc = Replace(xRazSoc, "&#xD3;", "Ó")
            xRazSoc = Replace(xRazSoc, "&#xDA;", "Ú")

            xRazSoc = Mid(xRazSoc, 1, Len(xRazSoc) - 3)

            xDir = Replace(xDir, "&#209;", "Ñ")
            xDir = Replace(xDir, "&#xD1;", "Ñ")
            xDir = Replace(xDir, "&#193;", "Á")
            xDir = Replace(xDir, "&#201;", "É")
            xDir = Replace(xDir, "&#205;", "Í")
            xDir = Replace(xDir, "&#211;", "Ó")
            xDir = Replace(xDir, "&#218;", "Ú")
            xDir = Replace(xDir, "&#xC1;", "Á")
            xDir = Replace(xDir, "&#xC9;", "É")
            xDir = Replace(xDir, "&#xCD;", "Í")
            xDir = Replace(xDir, "&#xD3;", "Ó")
            xDir = Replace(xDir, "&#xDA;", "Ú")

            xEst = Mid(xEst, 1, Len(xEst) - 6)
            xCon = Mid(xCon, 1, Len(xCon) - 3)
            xDir = Mid(xDir, 1, Len(xDir) - 3)

            txtRazSoc.Text = xRazSoc
            txtEst.Text = xEst
            txtCon.Text = xCon
            txtDir.Text = xDir
        Else

            Limpiar()
            MsgBox("No responde el servicio de la SUNAT")
        End If
        xWml = Nothing
    End Sub

    Private Sub btnlimpiar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnlimpiar.Click
        Limpiar()
        txtRuc.Text = ""
        txtRuc.Focus()
    End Sub

    Private Sub FrmSunat_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub


    Private Sub txtRuc_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtRuc.KeyPress
        SoloNumeros(e, False, sender.Text)
       saltar_ENTER(e)
    End Sub
    Private Sub txtRuc_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtRuc.Leave
        txtRuc.BackColor = Color.White
    End Sub
    Private Sub txtRuc_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtRuc.Enter
        txtRuc.BackColor = Color.Moccasin
    End Sub
End Class
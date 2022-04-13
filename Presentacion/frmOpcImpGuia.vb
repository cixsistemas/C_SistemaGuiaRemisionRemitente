Public Class frmOpcImpGuia
    Public Aceptar As Boolean = False
    Private Sub frmumision_Activated(ByVal sender As Object, ByVal e As System.EventArgs)
        rbps.Checked = False
        rbpll.Checked = False
    End Sub
    Private Sub frmumision_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub
    Private Sub Aceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Aceptarr.Click
        Dim ok As Boolean = False
        If rbps.Checked = True Then
            For i As Integer = 0 To cblps.Items.Count - 1
                If cblps.GetItemChecked(i) = True Then
                    ok = True
                End If
            Next
        End If
        'VALIDA QUE ESTE SELECCIONADO ALGUN PUNTO DE SALIDA A OMITIR
        'If ok = False And Me.rbps.Checked = True Then
        '    MsgBox("Seleccione items a omitir del pto. de salida.", MsgBoxStyle.Exclamation, "Guia de remision")
        '    'Me.rbps.Checked = True
        'End If
        ok = False
        If rbpll.Checked = True Then
            For i As Integer = 0 To cblpll.Items.Count - 1
                If cblpll.GetItemChecked(i) = True Then
                    ok = True
                End If
            Next
        End If
        If ok = False And rbpll.Checked = True Then
            MsgBox("Seleccione items a omitir del pto. de llegada.", MsgBoxStyle.Exclamation, "Guia de remision")
            'Me.rbps.Checked = True
            Exit Sub
        End If
        If rbdestino.Checked = False And rbemisor.Checked = False And rbsunat.Checked = False Then
            MsgBox("Seleccione opciones para Imprimir guia.", MsgBoxStyle.Exclamation, "Guias de Remision")
            Exit Sub
        End If

        If RBAng.Checked = True Then
            Aceptar = True
            Hide()
            ' Close()
        ElseIf RBang2.Checked = True Then
            Aceptar = True
            Hide()
        ElseIf RbMolino.Checked = True Then
            Aceptar = True
            Hide()

        ElseIf RbMagllogri.Checked = True Then
            Aceptar = True
            Hide()
       

        ElseIf RbBantemar.Checked = True Then
            Aceptar = True
            Hide()
        End If
    End Sub

    Private Sub RbMagllogri3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RbMagllogri2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RbMolino_CheckedChanged(sender As Object, e As System.EventArgs) Handles RbMolino.CheckedChanged

    End Sub
End Class
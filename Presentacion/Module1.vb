Module Module1
    Public CodBibliotecario, Biblio, Usuario As String
    Public RepLector, RepPor, RepTipo As String
    Public RepAno, RepMes, RepDia, RepNum As Integer
    Public ban As Boolean = False
    Public Sesion As Boolean = False
    Public Q_Eje As String
    Public FechaIng As String
    'Public FechaIng As DateTime
    Public tabla As DataTable = Nothing
    Public BanCon, NoMostrar As Boolean

    Public Sub seleciona_solo_una_fila_grilla(ByVal grilla As DataGridView)
        For i As Integer = 0 To grilla.Rows.Count - 1
            If CBool(grilla.Item(0, i).Value) = True Then
                grilla.Item(0, i).Value = False
            End If
        Next
    End Sub

    Public Function check_fila_grilla(ByVal grilla As DataGridView) As Boolean
        Dim ok As Boolean = False
        For i As Integer = 0 To grilla.Rows.Count - 1
            If CBool(grilla.Item(0, i).Value) = True Then
                ok = True
                Exit For
            End If
        Next
        Return ok
    End Function
    Public Function check_fila_grilla2(ByVal grilla As DataGridView, ByVal columna As String, ByVal condicion As String) As Boolean
        Dim ok As Boolean = False
        For i As Integer = 0 To grilla.Rows.Count - 1
            If CBool(grilla.Item(0, i).Value) = True Then
                Dim valor As String = CStr(grilla.Item(columna, 0).Value).Trim
                If valor = condicion Then
                    ok = True
                Else
                    ok = False
                    Exit For
                End If
            End If
        Next
        Return ok
    End Function    ''ORIGINAL
    Public Sub quitar_fila_grilla(ByVal grilla As DataGridView, ByVal columna As String, ByVal msgerror As String)
        Dim ok As Boolean = True
        Dim filas As Integer = grilla.Rows.Count - 1
        Do While filas >= 0 And filas < grilla.Rows.Count
            If CBool(grilla.Item(columna, filas).Value) = True Then
                If CInt(grilla.Item(1, filas).Value) = -1 Then
                    grilla.Rows.RemoveAt(filas)
                Else
                    ok = False
                End If
            End If
            filas = filas - 1
        Loop

        If ok = False Then
            MessageBox.Show(msgerror, "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        ok = True

    End Sub
    Public Sub quitar_fila_grilla2(ByVal grilla As DataGridView, ByVal columna As String)
        Dim filas As Integer = grilla.Rows.Count - 1
        Do While filas >= 0 And filas < grilla.Rows.Count
            If CBool(grilla.Item(columna, filas).Value) = True Then
                grilla.Rows.RemoveAt(filas)
            End If
            filas = filas - 1
        Loop
    End Sub
    Public Function quitar_check_fila_grilla(ByVal grilla As DataGridView) As Boolean
        Dim ok As Boolean = False
        For i As Integer = 0 To grilla.Rows.Count - 1
            If CBool(grilla.Item(0, i).Value) = True Then
                grilla.Item(0, i).Value = False
            End If
        Next
        Return ok
    End Function
    Public Sub SoloNumeros(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal Punto As Boolean, ByVal Texto As String)
        Select Case Asc(e.KeyChar)
            Case 8
            Case 46
                If Punto = False Then
                    e.Handled = True
                Else
                    If InStr(1, Texto, ".", vbTextCompare) Then
                        e.Handled = True
                    End If
                End If
            Case Is < 48, Is > 57
                e.Handled = True
        End Select
    End Sub
    Public Sub saltar_Flechas(ByVal e As KeyEventArgs)
        'PASAR DE UN CONTROL A OTRO CON FLECHAS
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Up Then
            SendKeys.Send("+{TAB}")
        End If
    End Sub

    Public Sub saltar_ENTER(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'PASAR DE UN CONTROL A OTRO CON ENTER
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Module

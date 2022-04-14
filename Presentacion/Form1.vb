Public Class Form1
    Dim T As Integer
    Dim i As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Me.Text = "Tabla"
        ''T = Val(InputBox("¿Qué tabla quiere conocer?" & vbCrLf & _
        ''"(Introduzca un número de 1 a 10)", "¿Número?"))
        ' '' LabelTabla.Font = New Font("Arial", 10, FontStyle.Bold)
        ' ''LabelTabla.TextAlign = ContentAlignment.MiddleCenter
        ' '' LabelTabla.Text = "TABLA DEL " & T & vbCrLf & vbCrLf
        ''For i = 1 To 10
        ''    dgvlista.Text = dgvlista.Text & T & " * " & i & " = " & T * i & vbCrLf
        ''    ' labeltabla.Text = T = T * i & vbCrLf
        ''Next i

        'Me.Text = "Tabla"
        'T = Val(InputBox("¿Qué tabla quiere conocer?" & vbCrLf & _
        '"(Introduzca un número de 1 a 10)", "¿Número?"))
        'dgvlista.Font = New Font("Arial", 10, FontStyle.Bold)
        '' dgvlista.TextAlign = ContentAlignment.MiddleCenter
        'dgvlista.Text = "TABLA DEL " & T & vbCrLf & vbCrLf

        'T = TextBox1.Text
        'For i = 1 To 10
        '    dgvlista.Rows.Add()
        '    'dgvlista.Item("C", dgvlista.Rows.Count - 1).Value = dgvlista.Text & T & " * " & i & " = " & T * i & vbCrLf
        '    dgvlista.Item("D", dgvlista.Rows.Count - 1).Value = i
        '    'dgvlista.Text = dgvlista.Text & T & " * " & i & " = " & T * i & vbCrLf
        '    ' labeltabla.Text = T = T * i & vbCrLf
        'Next i
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        T = TextBox1.Text
        For i = 1 To T
            dgvlista.Rows.Add()
            'dgvlista.Item("C", dgvlista.Rows.Count - 1).Value = dgvlista.Text & T & " * " & i & " = " & T * i & vbCrLf
            dgvlista.Item("D", dgvlista.Rows.Count - 1).Value = i
            'dgvlista.Text = dgvlista.Text & T & " * " & i & " = " & T * i & vbCrLf
            ' labeltabla.Text = T = T * i & vbCrLf
        Next i
        MessageBox.Show("Busque o Seleccione Tipo de documento por favor", "Guía de Remisión – Remitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class
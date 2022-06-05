<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipo_Dcto_2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipo_Dcto_2))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtDescrip = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSiglas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(217, 240)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 40)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Image = CType(resources.GetObject("BtnAceptar.Image"), System.Drawing.Image)
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(110, 240)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(97, 40)
        Me.BtnAceptar.TabIndex = 28
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'TxtDescrip
        '
        Me.TxtDescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescrip.Location = New System.Drawing.Point(152, 187)
        Me.TxtDescrip.Multiline = True
        Me.TxtDescrip.Name = "TxtDescrip"
        Me.TxtDescrip.Size = New System.Drawing.Size(251, 36)
        Me.TxtDescrip.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Descripcion:"
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(152, 100)
        Me.TxtNombre.MaxLength = 2000
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(265, 22)
        Me.TxtNombre.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Dcto de Identidad:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(152, 61)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(139, 22)
        Me.TxtCodigo.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Codigo:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ingrese Tipo de Documento de Identidad a Registrar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtSiglas
        '
        Me.TxtSiglas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSiglas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSiglas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSiglas.Location = New System.Drawing.Point(152, 148)
        Me.TxtSiglas.Name = "TxtSiglas"
        Me.TxtSiglas.Size = New System.Drawing.Size(93, 22)
        Me.TxtSiglas.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Siglas:"
        '
        'FrmTipo_Dcto_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 296)
        Me.Controls.Add(Me.TxtSiglas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtDescrip)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTipo_Dcto_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Tipo de Documento de Identidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSiglas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

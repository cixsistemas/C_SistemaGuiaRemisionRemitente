<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChofer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChofer))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.apellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.brevete = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombres:"
        '
        'nombre
        '
        Me.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(6, 64)
        Me.nombre.MaxLength = 250
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(347, 21)
        Me.nombre.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ingrese Datos de Chofer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Apellidos:"
        '
        'apellido
        '
        Me.apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.apellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellido.Location = New System.Drawing.Point(6, 123)
        Me.apellido.MaxLength = 250
        Me.apellido.Name = "apellido"
        Me.apellido.Size = New System.Drawing.Size(347, 21)
        Me.apellido.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Brevete:"
        '
        'brevete
        '
        Me.brevete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.brevete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.brevete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brevete.Location = New System.Drawing.Point(6, 178)
        Me.brevete.MaxLength = 50
        Me.brevete.Name = "brevete"
        Me.brevete.Size = New System.Drawing.Size(212, 21)
        Me.brevete.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Telefono:"
        '
        'telefono
        '
        Me.telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono.Location = New System.Drawing.Point(7, 234)
        Me.telefono.MaxLength = 50
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(211, 21)
        Me.telefono.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(364, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(173, 273)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(113, 47)
        Me.btnaceptar.TabIndex = 15
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.ForeColor = System.Drawing.Color.Blue
        Me.cancelar.Image = CType(resources.GetObject("cancelar.Image"), System.Drawing.Image)
        Me.cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancelar.Location = New System.Drawing.Point(298, 273)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(118, 47)
        Me.cancelar.TabIndex = 16
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cancelar.UseVisualStyleBackColor = False
        '
        'FrmChofer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(565, 331)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.brevete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.apellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmChofer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar chofer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents brevete As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents telefono As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents cancelar As System.Windows.Forms.Button
End Class

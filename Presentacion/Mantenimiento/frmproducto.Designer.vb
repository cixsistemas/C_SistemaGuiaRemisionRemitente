<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmproducto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.prod_nom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.prod_peso_uni = New System.Windows.Forms.TextBox()
        Me.prod_color = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbocategoria = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboenvasado = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnlogotipo = New System.Windows.Forms.Button()
        Me.txtlogotipo = New System.Windows.Forms.TextBox()
        Me.Nombre_Com = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(923, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Datos del Producto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'prod_nom
        '
        Me.prod_nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prod_nom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.prod_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prod_nom.Location = New System.Drawing.Point(14, 74)
        Me.prod_nom.Name = "prod_nom"
        Me.prod_nom.Size = New System.Drawing.Size(315, 21)
        Me.prod_nom.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(345, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Peso unitario (kg):"
        '
        'prod_peso_uni
        '
        Me.prod_peso_uni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prod_peso_uni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prod_peso_uni.Location = New System.Drawing.Point(348, 74)
        Me.prod_peso_uni.Name = "prod_peso_uni"
        Me.prod_peso_uni.Size = New System.Drawing.Size(110, 21)
        Me.prod_peso_uni.TabIndex = 2
        '
        'prod_color
        '
        Me.prod_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prod_color.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.prod_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prod_color.Location = New System.Drawing.Point(485, 131)
        Me.prod_color.Name = "prod_color"
        Me.prod_color.Size = New System.Drawing.Size(397, 21)
        Me.prod_color.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(485, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Color:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Categoria:"
        '
        'cbocategoria
        '
        Me.cbocategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbocategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocategoria.FormattingEnabled = True
        Me.cbocategoria.Location = New System.Drawing.Point(12, 132)
        Me.cbocategoria.Name = "cbocategoria"
        Me.cbocategoria.Size = New System.Drawing.Size(183, 23)
        Me.cbocategoria.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(483, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Logotipo:"
        '
        'cboenvasado
        '
        Me.cboenvasado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboenvasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboenvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboenvasado.FormattingEnabled = True
        Me.cboenvasado.Location = New System.Drawing.Point(222, 132)
        Me.cboenvasado.Name = "cboenvasado"
        Me.cboenvasado.Size = New System.Drawing.Size(249, 23)
        Me.cboenvasado.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(222, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Envasado:"
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(701, 172)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(113, 50)
        Me.btnaceptar.TabIndex = 8
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Blue
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(820, 172)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(121, 50)
        Me.btncancelar.TabIndex = 9
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnlogotipo
        '
        Me.btnlogotipo.BackColor = System.Drawing.Color.Gainsboro
        Me.btnlogotipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogotipo.Image = CType(resources.GetObject("btnlogotipo.Image"), System.Drawing.Image)
        Me.btnlogotipo.Location = New System.Drawing.Point(894, 55)
        Me.btnlogotipo.Name = "btnlogotipo"
        Me.btnlogotipo.Size = New System.Drawing.Size(43, 40)
        Me.btnlogotipo.TabIndex = 3
        Me.btnlogotipo.UseVisualStyleBackColor = False
        '
        'txtlogotipo
        '
        Me.txtlogotipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlogotipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlogotipo.Enabled = False
        Me.txtlogotipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlogotipo.Location = New System.Drawing.Point(483, 74)
        Me.txtlogotipo.Name = "txtlogotipo"
        Me.txtlogotipo.Size = New System.Drawing.Size(400, 21)
        Me.txtlogotipo.TabIndex = 13
        '
        'Nombre_Com
        '
        Me.Nombre_Com.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nombre_Com.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nombre_Com.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre_Com.Location = New System.Drawing.Point(14, 192)
        Me.Nombre_Com.MaxLength = 150
        Me.Nombre_Com.Name = "Nombre_Com"
        Me.Nombre_Com.Size = New System.Drawing.Size(326, 21)
        Me.Nombre_Com.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Nombre Comercial:"
        '
        'frmproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(950, 234)
        Me.Controls.Add(Me.Nombre_Com)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtlogotipo)
        Me.Controls.Add(Me.btnlogotipo)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.cboenvasado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbocategoria)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.prod_color)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.prod_peso_uni)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.prod_nom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmproducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents prod_nom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents prod_peso_uni As System.Windows.Forms.TextBox
    Friend WithEvents prod_color As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbocategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboenvasado As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnlogotipo As System.Windows.Forms.Button
    Friend WithEvents txtlogotipo As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_Com As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class

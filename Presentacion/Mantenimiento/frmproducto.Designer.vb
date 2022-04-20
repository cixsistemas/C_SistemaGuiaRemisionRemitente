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
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.prod_peso_uni = New System.Windows.Forms.TextBox()
        Me.prod_color = New System.Windows.Forms.TextBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.cbocategoria = New System.Windows.Forms.ComboBox()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.cboenvasado = New System.Windows.Forms.ComboBox()
        Me.lblEnvasado = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnlogotipo = New System.Windows.Forms.Button()
        Me.txtlogotipo = New System.Windows.Forms.TextBox()
        Me.Nombre_Com = New System.Windows.Forms.TextBox()
        Me.lblNombreComercial = New System.Windows.Forms.Label()
        Me.cbProdSinDetalle = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(976, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Datos del Producto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Producto:"
        '
        'prod_nom
        '
        Me.prod_nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prod_nom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.prod_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prod_nom.Location = New System.Drawing.Point(19, 91)
        Me.prod_nom.Margin = New System.Windows.Forms.Padding(4)
        Me.prod_nom.Name = "prod_nom"
        Me.prod_nom.Size = New System.Drawing.Size(976, 24)
        Me.prod_nom.TabIndex = 0
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.Location = New System.Drawing.Point(20, 124)
        Me.lblPeso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(161, 24)
        Me.lblPeso.TabIndex = 3
        Me.lblPeso.Text = "Peso unitario (kg):"
        '
        'prod_peso_uni
        '
        Me.prod_peso_uni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prod_peso_uni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prod_peso_uni.Location = New System.Drawing.Point(23, 148)
        Me.prod_peso_uni.Margin = New System.Windows.Forms.Padding(4)
        Me.prod_peso_uni.Name = "prod_peso_uni"
        Me.prod_peso_uni.Size = New System.Drawing.Size(242, 24)
        Me.prod_peso_uni.TabIndex = 2
        Me.prod_peso_uni.Text = "0"
        '
        'prod_color
        '
        Me.prod_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prod_color.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.prod_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prod_color.Location = New System.Drawing.Point(643, 214)
        Me.prod_color.Margin = New System.Windows.Forms.Padding(4)
        Me.prod_color.Name = "prod_color"
        Me.prod_color.Size = New System.Drawing.Size(287, 24)
        Me.prod_color.TabIndex = 6
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(643, 190)
        Me.lblColor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(60, 24)
        Me.lblColor.TabIndex = 5
        Me.lblColor.Text = "Color:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.Location = New System.Drawing.Point(20, 188)
        Me.lblCategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(95, 24)
        Me.lblCategoria.TabIndex = 7
        Me.lblCategoria.Text = "Categoria:"
        '
        'cbocategoria
        '
        Me.cbocategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbocategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocategoria.FormattingEnabled = True
        Me.cbocategoria.Location = New System.Drawing.Point(21, 214)
        Me.cbocategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.cbocategoria.Name = "cbocategoria"
        Me.cbocategoria.Size = New System.Drawing.Size(243, 26)
        Me.cbocategoria.TabIndex = 4
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.Location = New System.Drawing.Point(301, 124)
        Me.lblLogo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(88, 24)
        Me.lblLogo.TabIndex = 9
        Me.lblLogo.Text = "Logotipo:"
        '
        'cboenvasado
        '
        Me.cboenvasado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboenvasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboenvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboenvasado.FormattingEnabled = True
        Me.cboenvasado.Location = New System.Drawing.Point(301, 214)
        Me.cboenvasado.Margin = New System.Windows.Forms.Padding(4)
        Me.cboenvasado.Name = "cboenvasado"
        Me.cboenvasado.Size = New System.Drawing.Size(331, 26)
        Me.cboenvasado.TabIndex = 5
        '
        'lblEnvasado
        '
        Me.lblEnvasado.AutoSize = True
        Me.lblEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnvasado.Location = New System.Drawing.Point(301, 188)
        Me.lblEnvasado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnvasado.Name = "lblEnvasado"
        Me.lblEnvasado.Size = New System.Drawing.Size(99, 24)
        Me.lblEnvasado.TabIndex = 11
        Me.lblEnvasado.Text = "Envasado:"
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(676, 254)
        Me.btnaceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(151, 62)
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
        Me.btncancelar.Location = New System.Drawing.Point(834, 254)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(161, 62)
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
        Me.btnlogotipo.Location = New System.Drawing.Point(938, 124)
        Me.btnlogotipo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlogotipo.Name = "btnlogotipo"
        Me.btnlogotipo.Size = New System.Drawing.Size(57, 49)
        Me.btnlogotipo.TabIndex = 3
        Me.btnlogotipo.UseVisualStyleBackColor = False
        '
        'txtlogotipo
        '
        Me.txtlogotipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlogotipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlogotipo.Enabled = False
        Me.txtlogotipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlogotipo.Location = New System.Drawing.Point(305, 148)
        Me.txtlogotipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlogotipo.Name = "txtlogotipo"
        Me.txtlogotipo.Size = New System.Drawing.Size(625, 24)
        Me.txtlogotipo.TabIndex = 13
        Me.txtlogotipo.Text = "."
        '
        'Nombre_Com
        '
        Me.Nombre_Com.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nombre_Com.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nombre_Com.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre_Com.Location = New System.Drawing.Point(19, 282)
        Me.Nombre_Com.Margin = New System.Windows.Forms.Padding(4)
        Me.Nombre_Com.MaxLength = 150
        Me.Nombre_Com.Name = "Nombre_Com"
        Me.Nombre_Com.Size = New System.Drawing.Size(434, 24)
        Me.Nombre_Com.TabIndex = 7
        '
        'lblNombreComercial
        '
        Me.lblNombreComercial.AutoSize = True
        Me.lblNombreComercial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreComercial.Location = New System.Drawing.Point(19, 257)
        Me.lblNombreComercial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreComercial.Name = "lblNombreComercial"
        Me.lblNombreComercial.Size = New System.Drawing.Size(174, 24)
        Me.lblNombreComercial.TabIndex = 14
        Me.lblNombreComercial.Text = "Nombre Comercial:"
        '
        'cbProdSinDetalle
        '
        Me.cbProdSinDetalle.AutoSize = True
        Me.cbProdSinDetalle.Checked = True
        Me.cbProdSinDetalle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbProdSinDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProdSinDetalle.ForeColor = System.Drawing.Color.Red
        Me.cbProdSinDetalle.Location = New System.Drawing.Point(19, 36)
        Me.cbProdSinDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.cbProdSinDetalle.Name = "cbProdSinDetalle"
        Me.cbProdSinDetalle.Size = New System.Drawing.Size(180, 22)
        Me.cbProdSinDetalle.TabIndex = 15
        Me.cbProdSinDetalle.Text = "Producto sin detalle"
        Me.cbProdSinDetalle.UseVisualStyleBackColor = True
        '
        'frmproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(1020, 329)
        Me.Controls.Add(Me.cbProdSinDetalle)
        Me.Controls.Add(Me.Nombre_Com)
        Me.Controls.Add(Me.lblNombreComercial)
        Me.Controls.Add(Me.txtlogotipo)
        Me.Controls.Add(Me.btnlogotipo)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.cboenvasado)
        Me.Controls.Add(Me.lblEnvasado)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.cbocategoria)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.prod_color)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.prod_peso_uni)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.prod_nom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents prod_peso_uni As System.Windows.Forms.TextBox
    Friend WithEvents prod_color As System.Windows.Forms.TextBox
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents cbocategoria As System.Windows.Forms.ComboBox
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents cboenvasado As System.Windows.Forms.ComboBox
    Friend WithEvents lblEnvasado As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnlogotipo As System.Windows.Forms.Button
    Friend WithEvents txtlogotipo As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_Com As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreComercial As System.Windows.Forms.Label
    Friend WithEvents cbProdSinDetalle As CheckBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmdestinario2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmdestinario2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.razonsocial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ruc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbotipodoc = New System.Windows.Forms.ComboBox()
        Me.nro_doc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.btnUbigeo = New System.Windows.Forms.Button()
        Me.departamento = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.provincia = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.distrito = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Rep_Legal = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Datos de Destinatario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'razonsocial
        '
        Me.razonsocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.razonsocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.razonsocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.razonsocial.Location = New System.Drawing.Point(12, 71)
        Me.razonsocial.Name = "razonsocial"
        Me.razonsocial.Size = New System.Drawing.Size(373, 22)
        Me.razonsocial.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre ó razón social:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nro. RUC:"
        '
        'ruc
        '
        Me.ruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ruc.Location = New System.Drawing.Point(12, 128)
        Me.ruc.MaxLength = 11
        Me.ruc.Name = "ruc"
        Me.ruc.Size = New System.Drawing.Size(213, 20)
        Me.ruc.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo documento:"
        '
        'cbotipodoc
        '
        Me.cbotipodoc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbotipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipodoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbotipodoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotipodoc.FormattingEnabled = True
        Me.cbotipodoc.Location = New System.Drawing.Point(16, 186)
        Me.cbotipodoc.Name = "cbotipodoc"
        Me.cbotipodoc.Size = New System.Drawing.Size(182, 24)
        Me.cbotipodoc.TabIndex = 6
        '
        'nro_doc
        '
        Me.nro_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nro_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nro_doc.Location = New System.Drawing.Point(210, 187)
        Me.nro_doc.MaxLength = 8
        Me.nro_doc.Name = "nro_doc"
        Me.nro_doc.Size = New System.Drawing.Size(186, 22)
        Me.nro_doc.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(212, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nro. doc.:"
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(156, 397)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(112, 46)
        Me.btnaceptar.TabIndex = 14
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Blue
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(274, 397)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(125, 46)
        Me.btncancelar.TabIndex = 16
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(231, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 15)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Ingrese 11 numeros."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(405, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 15)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Ingrese 8 numeros."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(391, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 16)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Direccion:"
        '
        'Direccion
        '
        Me.Direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.Location = New System.Drawing.Point(12, 242)
        Me.Direccion.MaxLength = 150
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(373, 22)
        Me.Direccion.TabIndex = 10
        '
        'btnUbigeo
        '
        Me.btnUbigeo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnUbigeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbigeo.Image = CType(resources.GetObject("btnUbigeo.Image"), System.Drawing.Image)
        Me.btnUbigeo.Location = New System.Drawing.Point(429, 279)
        Me.btnUbigeo.Name = "btnUbigeo"
        Me.btnUbigeo.Size = New System.Drawing.Size(41, 45)
        Me.btnUbigeo.TabIndex = 12
        Me.btnUbigeo.UseVisualStyleBackColor = False
        '
        'departamento
        '
        Me.departamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.departamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departamento.ForeColor = System.Drawing.SystemColors.Highlight
        Me.departamento.Location = New System.Drawing.Point(288, 292)
        Me.departamento.Name = "departamento"
        Me.departamento.Size = New System.Drawing.Size(123, 32)
        Me.departamento.TabIndex = 112
        Me.departamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(285, 279)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Departamento"
        '
        'provincia
        '
        Me.provincia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.provincia.ForeColor = System.Drawing.SystemColors.Highlight
        Me.provincia.Location = New System.Drawing.Point(151, 292)
        Me.provincia.Name = "provincia"
        Me.provincia.Size = New System.Drawing.Size(123, 32)
        Me.provincia.TabIndex = 110
        Me.provincia.Text = " "
        Me.provincia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(151, 279)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "Provincia"
        '
        'distrito
        '
        Me.distrito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.distrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.distrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distrito.ForeColor = System.Drawing.SystemColors.Highlight
        Me.distrito.Location = New System.Drawing.Point(13, 292)
        Me.distrito.Name = "distrito"
        Me.distrito.Size = New System.Drawing.Size(123, 32)
        Me.distrito.TabIndex = 108
        Me.distrito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 279)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "Distrito"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 339)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 16)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "Representante Legal:"
        '
        'Rep_Legal
        '
        Me.Rep_Legal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Rep_Legal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Rep_Legal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rep_Legal.Location = New System.Drawing.Point(12, 358)
        Me.Rep_Legal.MaxLength = 150
        Me.Rep_Legal.Name = "Rep_Legal"
        Me.Rep_Legal.Size = New System.Drawing.Size(373, 22)
        Me.Rep_Legal.TabIndex = 13
        '
        'frmdestinatario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(536, 457)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Rep_Legal)
        Me.Controls.Add(Me.btnUbigeo)
        Me.Controls.Add(Me.departamento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.provincia)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.distrito)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.nro_doc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbotipodoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ruc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.razonsocial)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmdestinatario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Destinatario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents razonsocial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ruc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbotipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents nro_doc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
    Friend WithEvents btnUbigeo As System.Windows.Forms.Button
    Friend WithEvents departamento As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents provincia As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents distrito As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Rep_Legal As System.Windows.Forms.TextBox
End Class

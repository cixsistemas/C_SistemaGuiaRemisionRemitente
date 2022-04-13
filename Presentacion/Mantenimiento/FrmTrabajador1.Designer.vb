<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrabajador1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrabajador1))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.apellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nro_doc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTipo_Dcto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTipo_Dcto = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.BtnTipo_Trab = New System.Windows.Forms.Button()
        Me.txttipo_trabaj = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Fecha_Nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Fecha_Ingreso = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(377, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Apellidos:"
        '
        'apellido
        '
        Me.apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.apellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellido.Location = New System.Drawing.Point(377, 64)
        Me.apellido.MaxLength = 250
        Me.apellido.Name = "apellido"
        Me.apellido.Size = New System.Drawing.Size(347, 21)
        Me.apellido.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombres:"
        '
        'nombre
        '
        Me.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(11, 64)
        Me.nombre.MaxLength = 250
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(347, 21)
        Me.nombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(738, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ingrese Datos de Trabajador"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nro_doc
        '
        Me.nro_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nro_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nro_doc.Location = New System.Drawing.Point(293, 120)
        Me.nro_doc.MaxLength = 12
        Me.nro_doc.Name = "nro_doc"
        Me.nro_doc.Size = New System.Drawing.Size(186, 22)
        Me.nro_doc.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(295, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Nro. doc.:"
        '
        'txtTipo_Dcto
        '
        Me.txtTipo_Dcto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTipo_Dcto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipo_Dcto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo_Dcto.ForeColor = System.Drawing.Color.Navy
        Me.txtTipo_Dcto.Location = New System.Drawing.Point(12, 119)
        Me.txtTipo_Dcto.Name = "txtTipo_Dcto"
        Me.txtTipo_Dcto.Size = New System.Drawing.Size(203, 25)
        Me.txtTipo_Dcto.TabIndex = 137
        Me.txtTipo_Dcto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Tipo de Dcto."
        '
        'btnTipo_Dcto
        '
        Me.btnTipo_Dcto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnTipo_Dcto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipo_Dcto.Image = CType(resources.GetObject("btnTipo_Dcto.Image"), System.Drawing.Image)
        Me.btnTipo_Dcto.Location = New System.Drawing.Point(230, 99)
        Me.btnTipo_Dcto.Name = "btnTipo_Dcto"
        Me.btnTipo_Dcto.Size = New System.Drawing.Size(41, 45)
        Me.btnTipo_Dcto.TabIndex = 5
        Me.btnTipo_Dcto.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Direccion:"
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(12, 173)
        Me.txtDireccion.MaxLength = 250
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(347, 21)
        Me.txtDireccion.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(377, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 142
        Me.Label7.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(377, 173)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(347, 21)
        Me.txtTelefono.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 16)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "Correo Electronico:"
        '
        'txtCorreo
        '
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(11, 227)
        Me.txtCorreo.MaxLength = 150
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(347, 21)
        Me.txtCorreo.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 16)
        Me.Label9.TabIndex = 146
        Me.Label9.Text = "Descripcion:"
        '
        'txtDescrip
        '
        Me.txtDescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrip.Location = New System.Drawing.Point(12, 282)
        Me.txtDescrip.MaxLength = 250
        Me.txtDescrip.Multiline = True
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(347, 48)
        Me.txtDescrip.TabIndex = 21
        '
        'BtnTipo_Trab
        '
        Me.BtnTipo_Trab.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnTipo_Trab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTipo_Trab.Image = CType(resources.GetObject("BtnTipo_Trab.Image"), System.Drawing.Image)
        Me.BtnTipo_Trab.Location = New System.Drawing.Point(709, 99)
        Me.BtnTipo_Trab.Name = "BtnTipo_Trab"
        Me.BtnTipo_Trab.Size = New System.Drawing.Size(41, 45)
        Me.BtnTipo_Trab.TabIndex = 9
        Me.BtnTipo_Trab.UseVisualStyleBackColor = False
        '
        'txttipo_trabaj
        '
        Me.txttipo_trabaj.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txttipo_trabaj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttipo_trabaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipo_trabaj.ForeColor = System.Drawing.Color.Navy
        Me.txttipo_trabaj.Location = New System.Drawing.Point(491, 119)
        Me.txttipo_trabaj.Name = "txttipo_trabaj"
        Me.txttipo_trabaj.Size = New System.Drawing.Size(203, 25)
        Me.txttipo_trabaj.TabIndex = 150
        Me.txttipo_trabaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(491, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 15)
        Me.Label11.TabIndex = 149
        Me.Label11.Text = "Tipo de Trabajador:"
        '
        'Fecha_Nacimiento
        '
        Me.Fecha_Nacimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Fecha_Nacimiento.ForeColor = System.Drawing.Color.Black
        Me.Fecha_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_Nacimiento.Location = New System.Drawing.Point(377, 228)
        Me.Fecha_Nacimiento.Name = "Fecha_Nacimiento"
        Me.Fecha_Nacimiento.Size = New System.Drawing.Size(89, 20)
        Me.Fecha_Nacimiento.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(377, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 16)
        Me.Label12.TabIndex = 153
        Me.Label12.Text = "Fecha de Nacimiento:"
        '
        'Fecha_Ingreso
        '
        Me.Fecha_Ingreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Fecha_Ingreso.ForeColor = System.Drawing.Color.Black
        Me.Fecha_Ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_Ingreso.Location = New System.Drawing.Point(552, 228)
        Me.Fecha_Ingreso.Name = "Fecha_Ingreso"
        Me.Fecha_Ingreso.Size = New System.Drawing.Size(89, 20)
        Me.Fecha_Ingreso.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(549, 206)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 16)
        Me.Label13.TabIndex = 155
        Me.Label13.Text = "Fecha de Ingreso:"
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(503, 282)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(112, 48)
        Me.btnaceptar.TabIndex = 23
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
        Me.btncancelar.Location = New System.Drawing.Point(627, 282)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(125, 48)
        Me.btncancelar.TabIndex = 25
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'FrmTrabajador1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(762, 348)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Fecha_Ingreso)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Fecha_Nacimiento)
        Me.Controls.Add(Me.BtnTipo_Trab)
        Me.Controls.Add(Me.txttipo_trabaj)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDescrip)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.btnTipo_Dcto)
        Me.Controls.Add(Me.txtTipo_Dcto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nro_doc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.apellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmTrabajador1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Trabajador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nro_doc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTipo_Dcto As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnTipo_Dcto As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents BtnTipo_Trab As System.Windows.Forms.Button
    Friend WithEvents txttipo_trabaj As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Fecha_Nacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Fecha_Ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
End Class

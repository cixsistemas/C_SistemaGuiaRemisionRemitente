<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComisionista2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComisionista2))
        Me.txtDistrito = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.nro_doc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnTipo_Dcto = New System.Windows.Forms.Button()
        Me.txtTipo_Dcto = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnZona = New System.Windows.Forms.Button()
        Me.txtZona = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDistrito
        '
        Me.txtDistrito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDistrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDistrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistrito.ForeColor = System.Drawing.Color.Navy
        Me.txtDistrito.Location = New System.Drawing.Point(563, 123)
        Me.txtDistrito.Name = "txtDistrito"
        Me.txtDistrito.Size = New System.Drawing.Size(180, 25)
        Me.txtDistrito.TabIndex = 195
        Me.txtDistrito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(563, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 15)
        Me.Label13.TabIndex = 194
        Me.Label13.Text = "Distrito:"
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(262, 231)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(112, 48)
        Me.btnaceptar.TabIndex = 180
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
        Me.btncancelar.Location = New System.Drawing.Point(386, 231)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(125, 48)
        Me.btncancelar.TabIndex = 181
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(487, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 16)
        Me.Label12.TabIndex = 193
        Me.Label12.Text = "Descripcion:"
        '
        'txtDescrip
        '
        Me.txtDescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrip.Location = New System.Drawing.Point(490, 177)
        Me.txtDescrip.MaxLength = 250
        Me.txtDescrip.Multiline = True
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(317, 48)
        Me.txtDescrip.TabIndex = 178
        '
        'nro_doc
        '
        Me.nro_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nro_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nro_doc.Location = New System.Drawing.Point(283, 176)
        Me.nro_doc.MaxLength = 20
        Me.nro_doc.Name = "nro_doc"
        Me.nro_doc.Size = New System.Drawing.Size(186, 22)
        Me.nro_doc.TabIndex = 173
        Me.nro_doc.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(285, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 188
        Me.Label8.Text = "Nro. doc.:"
        '
        'btnTipo_Dcto
        '
        Me.btnTipo_Dcto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnTipo_Dcto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipo_Dcto.Image = CType(resources.GetObject("btnTipo_Dcto.Image"), System.Drawing.Image)
        Me.btnTipo_Dcto.Location = New System.Drawing.Point(231, 155)
        Me.btnTipo_Dcto.Name = "btnTipo_Dcto"
        Me.btnTipo_Dcto.Size = New System.Drawing.Size(41, 45)
        Me.btnTipo_Dcto.TabIndex = 172
        Me.btnTipo_Dcto.UseVisualStyleBackColor = False
        '
        'txtTipo_Dcto
        '
        Me.txtTipo_Dcto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTipo_Dcto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipo_Dcto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo_Dcto.ForeColor = System.Drawing.Color.Navy
        Me.txtTipo_Dcto.Location = New System.Drawing.Point(13, 175)
        Me.txtTipo_Dcto.Name = "txtTipo_Dcto"
        Me.txtTipo_Dcto.Size = New System.Drawing.Size(203, 25)
        Me.txtTipo_Dcto.TabIndex = 187
        Me.txtTipo_Dcto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 15)
        Me.Label6.TabIndex = 186
        Me.Label6.Text = "Tipo de Dcto."
        '
        'btnZona
        '
        Me.btnZona.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZona.Image = CType(resources.GetObject("btnZona.Image"), System.Drawing.Image)
        Me.btnZona.Location = New System.Drawing.Point(747, 103)
        Me.btnZona.Name = "btnZona"
        Me.btnZona.Size = New System.Drawing.Size(41, 45)
        Me.btnZona.TabIndex = 171
        Me.btnZona.UseVisualStyleBackColor = False
        '
        'txtZona
        '
        Me.txtZona.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtZona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZona.ForeColor = System.Drawing.Color.Navy
        Me.txtZona.Location = New System.Drawing.Point(378, 123)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(180, 25)
        Me.txtZona.TabIndex = 185
        Me.txtZona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(378, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 184
        Me.Label4.Text = "Zona"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 183
        Me.Label5.Text = "Direccion:"
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(13, 124)
        Me.txtDireccion.MaxLength = 150
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(347, 21)
        Me.txtDireccion.TabIndex = 170
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(381, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 182
        Me.Label7.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(381, 72)
        Me.txtTelefono.MaxLength = 100
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(347, 21)
        Me.txtTelefono.TabIndex = 169
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "Nombres:"
        '
        'nombre
        '
        Me.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(12, 72)
        Me.nombre.MaxLength = 250
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(347, 21)
        Me.nombre.TabIndex = 168
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(768, 23)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Ingrese Datos de Comisionista"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmComisionista2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 297)
        Me.Controls.Add(Me.txtDistrito)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDescrip)
        Me.Controls.Add(Me.nro_doc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnTipo_Dcto)
        Me.Controls.Add(Me.txtTipo_Dcto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnZona)
        Me.Controls.Add(Me.txtZona)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmComisionista2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Comisionista"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDistrito As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents nro_doc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnTipo_Dcto As System.Windows.Forms.Button
    Friend WithEvents txtTipo_Dcto As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnZona As System.Windows.Forms.Button
    Friend WithEvents txtZona As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmremitente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmremitente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ruc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.btnptollegada = New System.Windows.Forms.Button()
        Me.departamento = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.provincia = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.distrito = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese Datos de Remitente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'nombre
        '
        Me.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(12, 55)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(460, 22)
        Me.nombre.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(204, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 15)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Ingrese 11 numeros."
        '
        'ruc
        '
        Me.ruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ruc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ruc.Location = New System.Drawing.Point(12, 110)
        Me.ruc.MaxLength = 11
        Me.ruc.Name = "ruc"
        Me.ruc.Size = New System.Drawing.Size(186, 22)
        Me.ruc.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Nro. RUC:"
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(128, 371)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(115, 45)
        Me.btnaceptar.TabIndex = 7
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
        Me.btncancelar.Location = New System.Drawing.Point(252, 371)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(123, 45)
        Me.btncancelar.TabIndex = 8
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Direccion:"
        '
        'direccion
        '
        Me.direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.direccion.Location = New System.Drawing.Point(12, 209)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(460, 20)
        Me.direccion.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Descripcion:"
        '
        'descripcion
        '
        Me.descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descripcion.Location = New System.Drawing.Point(12, 327)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(460, 22)
        Me.descripcion.TabIndex = 6
        '
        'btnptollegada
        '
        Me.btnptollegada.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnptollegada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnptollegada.Image = CType(resources.GetObject("btnptollegada.Image"), System.Drawing.Image)
        Me.btnptollegada.Location = New System.Drawing.Point(431, 248)
        Me.btnptollegada.Name = "btnptollegada"
        Me.btnptollegada.Size = New System.Drawing.Size(41, 45)
        Me.btnptollegada.TabIndex = 5
        Me.btnptollegada.UseVisualStyleBackColor = False
        '
        'departamento
        '
        Me.departamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.departamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departamento.ForeColor = System.Drawing.SystemColors.Highlight
        Me.departamento.Location = New System.Drawing.Point(290, 261)
        Me.departamento.Name = "departamento"
        Me.departamento.Size = New System.Drawing.Size(123, 32)
        Me.departamento.TabIndex = 105
        Me.departamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(287, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "Departamento"
        '
        'provincia
        '
        Me.provincia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.provincia.ForeColor = System.Drawing.SystemColors.Highlight
        Me.provincia.Location = New System.Drawing.Point(153, 261)
        Me.provincia.Name = "provincia"
        Me.provincia.Size = New System.Drawing.Size(123, 32)
        Me.provincia.TabIndex = 103
        Me.provincia.Text = " "
        Me.provincia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(153, 248)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "Provincia"
        '
        'distrito
        '
        Me.distrito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.distrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.distrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distrito.ForeColor = System.Drawing.SystemColors.Highlight
        Me.distrito.Location = New System.Drawing.Point(15, 261)
        Me.distrito.Name = "distrito"
        Me.distrito.Size = New System.Drawing.Size(123, 32)
        Me.distrito.TabIndex = 101
        Me.distrito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 248)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "Distrito"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 16)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Cuenta de Detraccion:"
        '
        'txtCuenta
        '
        Me.txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuenta.Location = New System.Drawing.Point(12, 163)
        Me.txtCuenta.MaxLength = 20
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(208, 20)
        Me.txtCuenta.TabIndex = 3
        '
        'frmremitente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(484, 435)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.btnptollegada)
        Me.Controls.Add(Me.departamento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.provincia)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.distrito)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ruc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmremitente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remitente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ruc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnptollegada As System.Windows.Forms.Button
    Friend WithEvents departamento As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents provincia As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents distrito As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmZona1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmZona1))
        Me.btnUbigeo = New System.Windows.Forms.Button()
        Me.departamento = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.provincia = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.distrito = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.orden = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUbigeo
        '
        Me.btnUbigeo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnUbigeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbigeo.Image = CType(resources.GetObject("btnUbigeo.Image"), System.Drawing.Image)
        Me.btnUbigeo.Location = New System.Drawing.Point(430, 103)
        Me.btnUbigeo.Name = "btnUbigeo"
        Me.btnUbigeo.Size = New System.Drawing.Size(41, 45)
        Me.btnUbigeo.TabIndex = 110
        Me.btnUbigeo.UseVisualStyleBackColor = False
        '
        'departamento
        '
        Me.departamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.departamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departamento.ForeColor = System.Drawing.SystemColors.Highlight
        Me.departamento.Location = New System.Drawing.Point(289, 116)
        Me.departamento.Name = "departamento"
        Me.departamento.Size = New System.Drawing.Size(123, 32)
        Me.departamento.TabIndex = 123
        Me.departamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(286, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "Departamento"
        '
        'provincia
        '
        Me.provincia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.provincia.ForeColor = System.Drawing.SystemColors.Highlight
        Me.provincia.Location = New System.Drawing.Point(152, 116)
        Me.provincia.Name = "provincia"
        Me.provincia.Size = New System.Drawing.Size(123, 32)
        Me.provincia.TabIndex = 121
        Me.provincia.Text = " "
        Me.provincia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(152, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "Provincia"
        '
        'distrito
        '
        Me.distrito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.distrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.distrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distrito.ForeColor = System.Drawing.SystemColors.Highlight
        Me.distrito.Location = New System.Drawing.Point(14, 116)
        Me.distrito.Name = "distrito"
        Me.distrito.Size = New System.Drawing.Size(123, 32)
        Me.distrito.TabIndex = 119
        Me.distrito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 118
        Me.Label14.Text = "Distrito"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Orden Zona:"
        '
        'orden
        '
        Me.orden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.orden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.orden.Location = New System.Drawing.Point(14, 189)
        Me.orden.Name = "orden"
        Me.orden.Size = New System.Drawing.Size(198, 20)
        Me.orden.TabIndex = 112
        Me.orden.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Nombre:"
        '
        'nombre
        '
        Me.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(13, 55)
        Me.nombre.MaxLength = 50
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(460, 22)
        Me.nombre.TabIndex = 108
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 18)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Ingrese Datos de Zona"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Descripcion:"
        '
        'descripcion
        '
        Me.descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descripcion.Location = New System.Drawing.Point(14, 243)
        Me.descripcion.MaxLength = 250
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(460, 22)
        Me.descripcion.TabIndex = 125
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(127, 280)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(115, 45)
        Me.btnaceptar.TabIndex = 126
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
        Me.btncancelar.Location = New System.Drawing.Point(251, 280)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(123, 45)
        Me.btncancelar.TabIndex = 127
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'FrmZona1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(492, 340)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnUbigeo)
        Me.Controls.Add(Me.departamento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.provincia)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.distrito)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.orden)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmZona1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Zona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUbigeo As System.Windows.Forms.Button
    Friend WithEvents departamento As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents provincia As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents distrito As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents orden As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
End Class

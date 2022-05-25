<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnv_Comp2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEnv_Comp2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnOperacion = New System.Windows.Forms.Button()
        Me.TxtTipoOperac = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtOpe = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDistrito = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnZona = New System.Windows.Forms.Button()
        Me.txtZona = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnComisionista = New System.Windows.Forms.Button()
        Me.TxtComisionista = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.Fecha_Ingreso = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvlista = New System.Windows.Forms.DataGridView()
        Me.SELECCIONAR = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.I = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(820, 23)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Ingrese Datos de Envio de Comprobantes de Pago"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnOperacion
        '
        Me.BtnOperacion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOperacion.Image = CType(resources.GetObject("BtnOperacion.Image"), System.Drawing.Image)
        Me.BtnOperacion.Location = New System.Drawing.Point(345, 48)
        Me.BtnOperacion.Name = "BtnOperacion"
        Me.BtnOperacion.Size = New System.Drawing.Size(41, 45)
        Me.BtnOperacion.TabIndex = 2
        Me.BtnOperacion.UseVisualStyleBackColor = False
        '
        'TxtTipoOperac
        '
        Me.TxtTipoOperac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtTipoOperac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTipoOperac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTipoOperac.ForeColor = System.Drawing.Color.Blue
        Me.TxtTipoOperac.Location = New System.Drawing.Point(12, 61)
        Me.TxtTipoOperac.Name = "TxtTipoOperac"
        Me.TxtTipoOperac.Size = New System.Drawing.Size(155, 32)
        Me.TxtTipoOperac.TabIndex = 202
        Me.TxtTipoOperac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(11, 40)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(156, 21)
        Me.Label23.TabIndex = 203
        Me.Label23.Text = "Tipo Operacion"
        '
        'TxtOpe
        '
        Me.TxtOpe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtOpe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOpe.ForeColor = System.Drawing.Color.Blue
        Me.TxtOpe.Location = New System.Drawing.Point(182, 61)
        Me.TxtOpe.Name = "TxtOpe"
        Me.TxtOpe.Size = New System.Drawing.Size(155, 32)
        Me.TxtOpe.TabIndex = 200
        Me.TxtOpe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(181, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 21)
        Me.Label8.TabIndex = 201
        Me.Label8.Text = "Operacion:"
        '
        'txtDistrito
        '
        Me.txtDistrito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDistrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDistrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistrito.ForeColor = System.Drawing.Color.Blue
        Me.txtDistrito.Location = New System.Drawing.Point(607, 68)
        Me.txtDistrito.Name = "txtDistrito"
        Me.txtDistrito.Size = New System.Drawing.Size(180, 25)
        Me.txtDistrito.TabIndex = 208
        Me.txtDistrito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(607, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 15)
        Me.Label13.TabIndex = 207
        Me.Label13.Text = "Distrito:"
        '
        'btnZona
        '
        Me.btnZona.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZona.Image = CType(resources.GetObject("btnZona.Image"), System.Drawing.Image)
        Me.btnZona.Location = New System.Drawing.Point(791, 48)
        Me.btnZona.Name = "btnZona"
        Me.btnZona.Size = New System.Drawing.Size(41, 45)
        Me.btnZona.TabIndex = 4
        Me.btnZona.UseVisualStyleBackColor = False
        '
        'txtZona
        '
        Me.txtZona.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtZona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZona.ForeColor = System.Drawing.Color.Blue
        Me.txtZona.Location = New System.Drawing.Point(422, 68)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(180, 25)
        Me.txtZona.TabIndex = 206
        Me.txtZona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(422, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 205
        Me.Label4.Text = "Zona"
        '
        'btnComisionista
        '
        Me.btnComisionista.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnComisionista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComisionista.Image = CType(resources.GetObject("btnComisionista.Image"), System.Drawing.Image)
        Me.btnComisionista.Location = New System.Drawing.Point(230, 113)
        Me.btnComisionista.Name = "btnComisionista"
        Me.btnComisionista.Size = New System.Drawing.Size(41, 45)
        Me.btnComisionista.TabIndex = 6
        Me.btnComisionista.UseVisualStyleBackColor = False
        '
        'TxtComisionista
        '
        Me.TxtComisionista.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtComisionista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtComisionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComisionista.ForeColor = System.Drawing.Color.Blue
        Me.TxtComisionista.Location = New System.Drawing.Point(12, 133)
        Me.TxtComisionista.Name = "TxtComisionista"
        Me.TxtComisionista.Size = New System.Drawing.Size(203, 25)
        Me.TxtComisionista.TabIndex = 211
        Me.TxtComisionista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 210
        Me.Label6.Text = "Comisionista"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(422, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 15)
        Me.Label12.TabIndex = 223
        Me.Label12.Text = "Descripcion:"
        '
        'txtDescrip
        '
        Me.txtDescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrip.Location = New System.Drawing.Point(425, 137)
        Me.txtDescrip.MaxLength = 250
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(362, 21)
        Me.txtDescrip.TabIndex = 10
        '
        'Fecha_Ingreso
        '
        Me.Fecha_Ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_Ingreso.Location = New System.Drawing.Point(318, 142)
        Me.Fecha_Ingreso.Name = "Fecha_Ingreso"
        Me.Fecha_Ingreso.Size = New System.Drawing.Size(96, 20)
        Me.Fecha_Ingreso.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(315, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 221
        Me.Label3.Text = "Fec. Envio"
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(318, 399)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(112, 48)
        Me.btnaceptar.TabIndex = 18
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
        Me.btncancelar.Location = New System.Drawing.Point(446, 399)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(125, 48)
        Me.btncancelar.TabIndex = 20
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.ForeColor = System.Drawing.Color.Red
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.Location = New System.Drawing.Point(716, 253)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(116, 30)
        Me.btneliminar.TabIndex = 16
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnQuitar.Image = CType(resources.GetObject("btnQuitar.Image"), System.Drawing.Image)
        Me.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitar.Location = New System.Drawing.Point(716, 217)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(116, 30)
        Me.btnQuitar.TabIndex = 14
        Me.btnQuitar.Tag = "Puede seleccinar y quitar con tecla --> SUPR"
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(716, 181)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 30)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Comprobante"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToDeleteRows = False
        Me.dgvlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvlista.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SELECCIONAR, Me.B, Me.C, Me.D, Me.E, Me.F, Me.G, Me.H, Me.I})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlista.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvlista.Location = New System.Drawing.Point(12, 181)
        Me.dgvlista.Name = "dgvlista"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlista.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvlista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlista.Size = New System.Drawing.Size(685, 206)
        Me.dgvlista.TabIndex = 230
        '
        'SELECCIONAR
        '
        Me.SELECCIONAR.HeaderText = "Seleccionar"
        Me.SELECCIONAR.Name = "SELECCIONAR"
        Me.SELECCIONAR.Visible = False
        Me.SELECCIONAR.Width = 69
        '
        'B
        '
        Me.B.HeaderText = "Id Det Env Comp"
        Me.B.Name = "B"
        Me.B.ReadOnly = True
        Me.B.Visible = False
        Me.B.Width = 113
        '
        'C
        '
        Me.C.HeaderText = "Id Ing Com"
        Me.C.Name = "C"
        Me.C.ReadOnly = True
        Me.C.Visible = False
        Me.C.Width = 83
        '
        'D
        '
        Me.D.HeaderText = "Id Det Ing Comp"
        Me.D.Name = "D"
        Me.D.ReadOnly = True
        Me.D.Visible = False
        Me.D.Width = 109
        '
        'E
        '
        Me.E.HeaderText = "Remitente"
        Me.E.Name = "E"
        Me.E.ReadOnly = True
        Me.E.Width = 80
        '
        'F
        '
        Me.F.HeaderText = "Comprobante de Pago"
        Me.F.Name = "F"
        Me.F.ReadOnly = True
        Me.F.Width = 104
        '
        'G
        '
        Me.G.HeaderText = "Serie"
        Me.G.Name = "G"
        Me.G.ReadOnly = True
        Me.G.Width = 56
        '
        'H
        '
        Me.H.HeaderText = "Numero"
        Me.H.Name = "H"
        Me.H.ReadOnly = True
        Me.H.Width = 69
        '
        'I
        '
        Me.I.HeaderText = "Estado"
        Me.I.Name = "I"
        Me.I.ReadOnly = True
        Me.I.Width = 65
        '
        'FrmEnv_Comp2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 459)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDescrip)
        Me.Controls.Add(Me.Fecha_Ingreso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnComisionista)
        Me.Controls.Add(Me.TxtComisionista)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDistrito)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnZona)
        Me.Controls.Add(Me.txtZona)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnOperacion)
        Me.Controls.Add(Me.TxtTipoOperac)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TxtOpe)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEnv_Comp2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Envio de Comprobantes de Pago"
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnOperacion As System.Windows.Forms.Button
    Friend WithEvents TxtTipoOperac As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtOpe As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDistrito As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnZona As System.Windows.Forms.Button
    Friend WithEvents txtZona As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnComisionista As System.Windows.Forms.Button
    Friend WithEvents TxtComisionista As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_Ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents SELECCIONAR As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents B As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents E As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents G As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents H As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents I As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

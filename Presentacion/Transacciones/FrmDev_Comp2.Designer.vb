<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDev_Comp2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDev_Comp2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnOperacion = New System.Windows.Forms.Button()
        Me.TxtTipoOperac = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtOpe = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnubigeo = New System.Windows.Forms.Button()
        Me.departamento = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.provincia = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.distrito = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Fecha_Ingreso = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.dgvlista = New System.Windows.Forms.DataGridView()
        Me.SELECCIONAR = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.I = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(848, 23)
        Me.Label1.TabIndex = 180
        Me.Label1.Text = "Ingrese Datos de Devolución de Comprobantes de Pago"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnOperacion
        '
        Me.BtnOperacion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOperacion.Image = CType(resources.GetObject("BtnOperacion.Image"), System.Drawing.Image)
        Me.BtnOperacion.Location = New System.Drawing.Point(338, 46)
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
        Me.TxtTipoOperac.Location = New System.Drawing.Point(12, 59)
        Me.TxtTipoOperac.Name = "TxtTipoOperac"
        Me.TxtTipoOperac.Size = New System.Drawing.Size(155, 32)
        Me.TxtTipoOperac.TabIndex = 207
        Me.TxtTipoOperac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(11, 38)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(156, 21)
        Me.Label23.TabIndex = 208
        Me.Label23.Text = "Tipo Operacion"
        '
        'TxtOpe
        '
        Me.TxtOpe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtOpe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOpe.ForeColor = System.Drawing.Color.Blue
        Me.TxtOpe.Location = New System.Drawing.Point(175, 59)
        Me.TxtOpe.Name = "TxtOpe"
        Me.TxtOpe.Size = New System.Drawing.Size(155, 32)
        Me.TxtOpe.TabIndex = 205
        Me.TxtOpe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(174, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 21)
        Me.Label8.TabIndex = 206
        Me.Label8.Text = "Operacion:"
        '
        'btnubigeo
        '
        Me.btnubigeo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnubigeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnubigeo.Image = CType(resources.GetObject("btnubigeo.Image"), System.Drawing.Image)
        Me.btnubigeo.Location = New System.Drawing.Point(420, 114)
        Me.btnubigeo.Name = "btnubigeo"
        Me.btnubigeo.Size = New System.Drawing.Size(41, 45)
        Me.btnubigeo.TabIndex = 8
        Me.btnubigeo.UseVisualStyleBackColor = False
        '
        'departamento
        '
        Me.departamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.departamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departamento.ForeColor = System.Drawing.Color.Blue
        Me.departamento.Location = New System.Drawing.Point(287, 127)
        Me.departamento.Name = "departamento"
        Me.departamento.Size = New System.Drawing.Size(123, 32)
        Me.departamento.TabIndex = 215
        Me.departamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(284, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 214
        Me.Label10.Text = "Departamento"
        '
        'provincia
        '
        Me.provincia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.provincia.ForeColor = System.Drawing.Color.Blue
        Me.provincia.Location = New System.Drawing.Point(150, 127)
        Me.provincia.Name = "provincia"
        Me.provincia.Size = New System.Drawing.Size(123, 32)
        Me.provincia.TabIndex = 213
        Me.provincia.Text = " "
        Me.provincia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(150, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 212
        Me.Label12.Text = "Provincia"
        '
        'distrito
        '
        Me.distrito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.distrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.distrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distrito.ForeColor = System.Drawing.Color.Blue
        Me.distrito.Location = New System.Drawing.Point(12, 127)
        Me.distrito.Name = "distrito"
        Me.distrito.Size = New System.Drawing.Size(123, 32)
        Me.distrito.TabIndex = 211
        Me.distrito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 210
        Me.Label14.Text = "Distrito"
        '
        'Fecha_Ingreso
        '
        Me.Fecha_Ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_Ingreso.Location = New System.Drawing.Point(402, 63)
        Me.Fecha_Ingreso.Name = "Fecha_Ingreso"
        Me.Fecha_Ingreso.Size = New System.Drawing.Size(106, 20)
        Me.Fecha_Ingreso.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(399, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 223
        Me.Label3.Text = "Fec. Devolución"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(528, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 225
        Me.Label4.Text = "Direccion:"
        '
        'direccion
        '
        Me.direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.direccion.Location = New System.Drawing.Point(528, 65)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(375, 20)
        Me.direccion.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(525, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "Descripcion:"
        '
        'txtDescrip
        '
        Me.txtDescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrip.Location = New System.Drawing.Point(528, 127)
        Me.txtDescrip.MaxLength = 250
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(375, 21)
        Me.txtDescrip.TabIndex = 10
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
        Me.dgvlista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SELECCIONAR, Me.A, Me.B, Me.C, Me.D, Me.E, Me.F, Me.G, Me.H, Me.I})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlista.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvlista.Location = New System.Drawing.Point(12, 182)
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
        Me.dgvlista.Size = New System.Drawing.Size(769, 206)
        Me.dgvlista.TabIndex = 231
        '
        'SELECCIONAR
        '
        Me.SELECCIONAR.HeaderText = "Seleccionar"
        Me.SELECCIONAR.Name = "SELECCIONAR"
        Me.SELECCIONAR.Visible = False
        Me.SELECCIONAR.Width = 69
        '
        'A
        '
        Me.A.HeaderText = "Id Det Dev Comp"
        Me.A.Name = "A"
        Me.A.ReadOnly = True
        Me.A.Visible = False
        Me.A.Width = 114
        '
        'B
        '
        Me.B.HeaderText = "Id Env Comp"
        Me.B.Name = "B"
        Me.B.ReadOnly = True
        Me.B.Visible = False
        Me.B.Width = 93
        '
        'C
        '
        Me.C.HeaderText = "Id Det Env Comp"
        Me.C.Name = "C"
        Me.C.ReadOnly = True
        Me.C.Visible = False
        Me.C.Width = 113
        '
        'D
        '
        Me.D.HeaderText = "Comisionista"
        Me.D.Name = "D"
        Me.D.Width = 90
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
        Me.I.Items.AddRange(New Object() {"EMITIDO", "ANULADO", "EN BLANCO", "PERDIDO"})
        Me.I.Name = "I"
        Me.I.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.I.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.I.Width = 65
        '
        'btneliminar
        '
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.ForeColor = System.Drawing.Color.Red
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.Location = New System.Drawing.Point(787, 254)
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
        Me.btnQuitar.Location = New System.Drawing.Point(787, 218)
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
        Me.btnAgregar.Location = New System.Drawing.Point(787, 182)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 30)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Comprobante"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(363, 419)
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
        Me.btncancelar.Location = New System.Drawing.Point(480, 419)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(125, 48)
        Me.btncancelar.TabIndex = 20
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'FrmDev_Comp2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 479)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescrip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.Fecha_Ingreso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnubigeo)
        Me.Controls.Add(Me.departamento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.provincia)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.distrito)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BtnOperacion)
        Me.Controls.Add(Me.TxtTipoOperac)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TxtOpe)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDev_Comp2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Devolución de Comprobantes de Pago"
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
    Friend WithEvents btnubigeo As System.Windows.Forms.Button
    Friend WithEvents departamento As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents provincia As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents distrito As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Fecha_Ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents SELECCIONAR As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents A As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents B As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents E As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents G As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents H As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents I As System.Windows.Forms.DataGridViewComboBoxColumn
End Class

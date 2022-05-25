<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPago_Detra1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPago_Detra1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.btnquitar_hpm = New System.Windows.Forms.Button()
        Me.btneditar_hpm = New System.Windows.Forms.Button()
        Me.btnnuevo_examen = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCategoria = New System.Windows.Forms.Button()
        Me.NombreCATEGORIA = New System.Windows.Forms.Label()
        Me.cantidad_sacos = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtivap = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Detalle_Cat = New System.Windows.Forms.DataGridView()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.txtTot_Sup = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtsup5 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtsup4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtsup3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtsup2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtsup1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.txtDespTotal = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtdesp5 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtdesp4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtdesp3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtdesp2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtdesp1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.txtTot_Ext = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtExt4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtExt3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtExt2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtExt1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.btnRemitente = New System.Windows.Forms.Button()
        Me.cuenta = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ruc = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.remitente = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.txt_TOTAL = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnCALC = New DevComponents.DotNetBar.ButtonX()
        Me.BTN_PAGINA = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fecha_Emis = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdCat = New System.Windows.Forms.Label()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id_det_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sacos_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ivap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Detalle_Cat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(122, 9)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(98, 20)
        Me.fecha.TabIndex = 0
        '
        'btnquitar_hpm
        '
        Me.btnquitar_hpm.BackColor = System.Drawing.Color.Gainsboro
        Me.btnquitar_hpm.Enabled = False
        Me.btnquitar_hpm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquitar_hpm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquitar_hpm.ForeColor = System.Drawing.Color.DarkRed
        Me.btnquitar_hpm.Location = New System.Drawing.Point(478, 325)
        Me.btnquitar_hpm.Name = "btnquitar_hpm"
        Me.btnquitar_hpm.Size = New System.Drawing.Size(71, 28)
        Me.btnquitar_hpm.TabIndex = 72
        Me.btnquitar_hpm.Text = "Quitar"
        Me.btnquitar_hpm.UseVisualStyleBackColor = False
        '
        'btneditar_hpm
        '
        Me.btneditar_hpm.BackColor = System.Drawing.Color.Gainsboro
        Me.btneditar_hpm.Enabled = False
        Me.btneditar_hpm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar_hpm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditar_hpm.ForeColor = System.Drawing.Color.DarkRed
        Me.btneditar_hpm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneditar_hpm.Location = New System.Drawing.Point(478, 293)
        Me.btneditar_hpm.Name = "btneditar_hpm"
        Me.btneditar_hpm.Size = New System.Drawing.Size(70, 28)
        Me.btneditar_hpm.TabIndex = 71
        Me.btneditar_hpm.Text = "Editar"
        Me.btneditar_hpm.UseVisualStyleBackColor = False
        '
        'btnnuevo_examen
        '
        Me.btnnuevo_examen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnnuevo_examen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo_examen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo_examen.ForeColor = System.Drawing.Color.DarkRed
        Me.btnnuevo_examen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevo_examen.Location = New System.Drawing.Point(477, 262)
        Me.btnnuevo_examen.Name = "btnnuevo_examen"
        Me.btnnuevo_examen.Size = New System.Drawing.Size(70, 28)
        Me.btnnuevo_examen.TabIndex = 9
        Me.btnnuevo_examen.Text = "Nuevo"
        Me.btnnuevo_examen.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.DarkRed
        Me.btnAgregar.Location = New System.Drawing.Point(477, 216)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(69, 28)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnCategoria
        '
        Me.btnCategoria.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCategoria.Enabled = False
        Me.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoria.Image = CType(resources.GetObject("btnCategoria.Image"), System.Drawing.Image)
        Me.btnCategoria.Location = New System.Drawing.Point(201, 154)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(46, 46)
        Me.btnCategoria.TabIndex = 4
        Me.btnCategoria.UseVisualStyleBackColor = False
        '
        'NombreCATEGORIA
        '
        Me.NombreCATEGORIA.ForeColor = System.Drawing.Color.Blue
        Me.NombreCATEGORIA.Location = New System.Drawing.Point(76, 161)
        Me.NombreCATEGORIA.Name = "NombreCATEGORIA"
        Me.NombreCATEGORIA.Size = New System.Drawing.Size(119, 36)
        Me.NombreCATEGORIA.TabIndex = 77
        Me.NombreCATEGORIA.Text = "             "
        '
        'cantidad_sacos
        '
        Me.cantidad_sacos.Enabled = False
        Me.cantidad_sacos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad_sacos.Location = New System.Drawing.Point(336, 170)
        Me.cantidad_sacos.Name = "cantidad_sacos"
        Me.cantidad_sacos.Size = New System.Drawing.Size(63, 20)
        Me.cantidad_sacos.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(334, 152)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(61, 13)
        Me.Label26.TabIndex = 76
        Me.Label26.Text = "Cantidad:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(253, 154)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 13)
        Me.Label19.TabIndex = 74
        Me.Label19.Text = "Precio"
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(253, 170)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(77, 20)
        Me.txtprecio.TabIndex = 5
        '
        'txtivap
        '
        Me.txtivap.Enabled = False
        Me.txtivap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtivap.Location = New System.Drawing.Point(408, 170)
        Me.txtivap.Name = "txtivap"
        Me.txtivap.Size = New System.Drawing.Size(63, 20)
        Me.txtivap.TabIndex = 7
        Me.txtivap.Text = "0.0385"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(411, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Ivap:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(5, 162)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "Categoria:"
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(142, 370)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(118, 43)
        Me.btnaceptar.TabIndex = 84
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.MediumBlue
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(266, 370)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(119, 43)
        Me.btncancelar.TabIndex = 85
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Descripcion:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(329, 15)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(212, 39)
        Me.txtDescripcion.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Fecha de Precio:"
        '
        'Detalle_Cat
        '
        Me.Detalle_Cat.AllowUserToAddRows = False
        Me.Detalle_Cat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Detalle_Cat.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detalle_Cat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Detalle_Cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Detalle_Cat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar, Me.id_det_pago, Me.id_cat, Me.Descripcion, Me.Precio, Me.sacos_cantidad, Me.Ivap, Me.Total})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Detalle_Cat.DefaultCellStyle = DataGridViewCellStyle2
        Me.Detalle_Cat.Location = New System.Drawing.Point(5, 216)
        Me.Detalle_Cat.Name = "Detalle_Cat"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detalle_Cat.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Detalle_Cat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Detalle_Cat.Size = New System.Drawing.Size(468, 128)
        Me.Detalle_Cat.TabIndex = 89
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(3, 0)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(235, 23)
        Me.LabelX1.TabIndex = 90
        Me.LabelX1.Text = "Casserita (Naranja, amarillo, verde y fucsia)"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(3, 25)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(90, 23)
        Me.LabelX2.TabIndex = 91
        Me.LabelX2.Text = "Doña Lory"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(3, 51)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(120, 23)
        Me.LabelX3.TabIndex = 92
        Me.LabelX3.Text = "Doña Carlota"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Navy
        Me.LabelX4.Location = New System.Drawing.Point(3, 104)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(120, 23)
        Me.LabelX4.TabIndex = 93
        Me.LabelX4.Text = "Jacinta"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.Navy
        Me.LabelX5.Location = New System.Drawing.Point(3, 77)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(152, 23)
        Me.LabelX5.TabIndex = 94
        Me.LabelX5.Text = "Tierras Norteñas"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX11)
        Me.GroupPanel1.Controls.Add(Me.txtTot_Sup)
        Me.GroupPanel1.Controls.Add(Me.txtsup5)
        Me.GroupPanel1.Controls.Add(Me.txtsup4)
        Me.GroupPanel1.Controls.Add(Me.txtsup3)
        Me.GroupPanel1.Controls.Add(Me.txtsup2)
        Me.GroupPanel1.Controls.Add(Me.txtsup1)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(570, 2)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(328, 172)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 95
        Me.GroupPanel1.Text = "Superior"
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.Color.Crimson
        Me.LabelX11.Location = New System.Drawing.Point(153, 128)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(101, 23)
        Me.LabelX11.TabIndex = 103
        Me.LabelX11.Text = "Total Superior:"
        '
        'txtTot_Sup
        '
        Me.txtTot_Sup.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtTot_Sup.Border.Class = "TextBoxBorder"
        Me.txtTot_Sup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTot_Sup.FocusHighlightEnabled = True
        Me.txtTot_Sup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTot_Sup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtTot_Sup, True)
        Me.txtTot_Sup.Location = New System.Drawing.Point(260, 128)
        Me.txtTot_Sup.Name = "txtTot_Sup"
        Me.txtTot_Sup.ReadOnly = True
        Me.txtTot_Sup.Size = New System.Drawing.Size(53, 21)
        Me.txtTot_Sup.TabIndex = 102
        '
        'txtsup5
        '
        Me.txtsup5.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtsup5.Border.Class = "TextBoxBorder"
        Me.txtsup5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtsup5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsup5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtsup5, True)
        Me.txtsup5.Location = New System.Drawing.Point(260, 100)
        Me.txtsup5.Name = "txtsup5"
        Me.txtsup5.Size = New System.Drawing.Size(53, 21)
        Me.txtsup5.TabIndex = 101
        '
        'txtsup4
        '
        Me.txtsup4.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtsup4.Border.Class = "TextBoxBorder"
        Me.txtsup4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtsup4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsup4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtsup4, True)
        Me.txtsup4.Location = New System.Drawing.Point(260, 77)
        Me.txtsup4.Name = "txtsup4"
        Me.txtsup4.Size = New System.Drawing.Size(53, 21)
        Me.txtsup4.TabIndex = 100
        '
        'txtsup3
        '
        Me.txtsup3.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtsup3.Border.Class = "TextBoxBorder"
        Me.txtsup3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtsup3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsup3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtsup3, True)
        Me.txtsup3.Location = New System.Drawing.Point(260, 54)
        Me.txtsup3.Name = "txtsup3"
        Me.txtsup3.Size = New System.Drawing.Size(53, 21)
        Me.txtsup3.TabIndex = 99
        '
        'txtsup2
        '
        Me.txtsup2.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtsup2.Border.Class = "TextBoxBorder"
        Me.txtsup2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtsup2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsup2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtsup2, True)
        Me.txtsup2.Location = New System.Drawing.Point(260, 31)
        Me.txtsup2.Name = "txtsup2"
        Me.txtsup2.Size = New System.Drawing.Size(53, 21)
        Me.txtsup2.TabIndex = 98
        '
        'txtsup1
        '
        Me.txtsup1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtsup1.Border.Class = "TextBoxBorder"
        Me.txtsup1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtsup1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsup1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtsup1, True)
        Me.txtsup1.Location = New System.Drawing.Point(260, 7)
        Me.txtsup1.Name = "txtsup1"
        Me.txtsup1.Size = New System.Drawing.Size(53, 21)
        Me.txtsup1.TabIndex = 97
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.LabelX12)
        Me.GroupPanel2.Controls.Add(Me.txtDespTotal)
        Me.GroupPanel2.Controls.Add(Me.txtdesp5)
        Me.GroupPanel2.Controls.Add(Me.txtdesp4)
        Me.GroupPanel2.Controls.Add(Me.txtdesp3)
        Me.GroupPanel2.Controls.Add(Me.txtdesp2)
        Me.GroupPanel2.Controls.Add(Me.txtdesp1)
        Me.GroupPanel2.Controls.Add(Me.LabelX6)
        Me.GroupPanel2.Controls.Add(Me.LabelX7)
        Me.GroupPanel2.Controls.Add(Me.LabelX8)
        Me.GroupPanel2.Controls.Add(Me.LabelX9)
        Me.GroupPanel2.Controls.Add(Me.LabelX10)
        Me.GroupPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(571, 178)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(327, 175)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 96
        Me.GroupPanel2.Text = "Despuntado"
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.ForeColor = System.Drawing.Color.Crimson
        Me.LabelX12.Location = New System.Drawing.Point(152, 126)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(101, 23)
        Me.LabelX12.TabIndex = 104
        Me.LabelX12.Text = "Total Despuntado:"
        '
        'txtDespTotal
        '
        Me.txtDespTotal.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtDespTotal.Border.Class = "TextBoxBorder"
        Me.txtDespTotal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDespTotal.FocusHighlightEnabled = True
        Me.txtDespTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDespTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDespTotal, True)
        Me.txtDespTotal.Location = New System.Drawing.Point(259, 127)
        Me.txtDespTotal.Name = "txtDespTotal"
        Me.txtDespTotal.Size = New System.Drawing.Size(53, 21)
        Me.txtDespTotal.TabIndex = 107
        '
        'txtdesp5
        '
        Me.txtdesp5.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtdesp5.Border.Class = "TextBoxBorder"
        Me.txtdesp5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdesp5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesp5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtdesp5, True)
        Me.txtdesp5.Location = New System.Drawing.Point(259, 102)
        Me.txtdesp5.Name = "txtdesp5"
        Me.txtdesp5.Size = New System.Drawing.Size(53, 21)
        Me.txtdesp5.TabIndex = 106
        '
        'txtdesp4
        '
        Me.txtdesp4.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtdesp4.Border.Class = "TextBoxBorder"
        Me.txtdesp4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdesp4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesp4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtdesp4, True)
        Me.txtdesp4.Location = New System.Drawing.Point(259, 79)
        Me.txtdesp4.Name = "txtdesp4"
        Me.txtdesp4.Size = New System.Drawing.Size(53, 21)
        Me.txtdesp4.TabIndex = 105
        '
        'txtdesp3
        '
        Me.txtdesp3.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtdesp3.Border.Class = "TextBoxBorder"
        Me.txtdesp3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdesp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesp3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtdesp3, True)
        Me.txtdesp3.Location = New System.Drawing.Point(259, 54)
        Me.txtdesp3.Name = "txtdesp3"
        Me.txtdesp3.Size = New System.Drawing.Size(53, 21)
        Me.txtdesp3.TabIndex = 104
        '
        'txtdesp2
        '
        Me.txtdesp2.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtdesp2.Border.Class = "TextBoxBorder"
        Me.txtdesp2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdesp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesp2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtdesp2, True)
        Me.txtdesp2.Location = New System.Drawing.Point(259, 28)
        Me.txtdesp2.Name = "txtdesp2"
        Me.txtdesp2.Size = New System.Drawing.Size(53, 21)
        Me.txtdesp2.TabIndex = 103
        '
        'txtdesp1
        '
        Me.txtdesp1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtdesp1.Border.Class = "TextBoxBorder"
        Me.txtdesp1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdesp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesp1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtdesp1, True)
        Me.txtdesp1.Location = New System.Drawing.Point(259, 2)
        Me.txtdesp1.Name = "txtdesp1"
        Me.txtdesp1.Size = New System.Drawing.Size(53, 21)
        Me.txtdesp1.TabIndex = 102
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelX6.ForeColor = System.Drawing.Color.Navy
        Me.LabelX6.Location = New System.Drawing.Point(3, 0)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(152, 23)
        Me.LabelX6.TabIndex = 90
        Me.LabelX6.Text = "Generoso Sabor"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelX7.ForeColor = System.Drawing.Color.Navy
        Me.LabelX7.Location = New System.Drawing.Point(3, 104)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(152, 23)
        Me.LabelX7.TabIndex = 94
        Me.LabelX7.Text = "OTROS"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelX8.ForeColor = System.Drawing.Color.Navy
        Me.LabelX8.Location = New System.Drawing.Point(3, 52)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(90, 23)
        Me.LabelX8.TabIndex = 91
        Me.LabelX8.Text = "Nutriarroz"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelX9.ForeColor = System.Drawing.Color.Navy
        Me.LabelX9.Location = New System.Drawing.Point(3, 26)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(120, 23)
        Me.LabelX9.TabIndex = 93
        Me.LabelX9.Text = "Graneadito"
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelX10.ForeColor = System.Drawing.Color.Navy
        Me.LabelX10.Location = New System.Drawing.Point(3, 78)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(120, 23)
        Me.LabelX10.TabIndex = 92
        Me.LabelX10.Text = "Valles Dorados"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.CanvasColor = System.Drawing.Color.Chartreuse
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.LabelX13)
        Me.GroupPanel3.Controls.Add(Me.txtTot_Ext)
        Me.GroupPanel3.Controls.Add(Me.txtExt4)
        Me.GroupPanel3.Controls.Add(Me.txtExt3)
        Me.GroupPanel3.Controls.Add(Me.txtExt2)
        Me.GroupPanel3.Controls.Add(Me.txtExt1)
        Me.GroupPanel3.Controls.Add(Me.LabelX20)
        Me.GroupPanel3.Controls.Add(Me.LabelX17)
        Me.GroupPanel3.Controls.Add(Me.LabelX18)
        Me.GroupPanel3.Controls.Add(Me.LabelX19)
        Me.GroupPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(573, 356)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(327, 143)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 97
        Me.GroupPanel3.Text = "Extra"
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.ForeColor = System.Drawing.Color.Crimson
        Me.LabelX13.Location = New System.Drawing.Point(152, 98)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(101, 23)
        Me.LabelX13.TabIndex = 112
        Me.LabelX13.Text = "Total Extra:"
        '
        'txtTot_Ext
        '
        Me.txtTot_Ext.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtTot_Ext.Border.Class = "TextBoxBorder"
        Me.txtTot_Ext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTot_Ext.FocusHighlightEnabled = True
        Me.txtTot_Ext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTot_Ext.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtTot_Ext, True)
        Me.txtTot_Ext.Location = New System.Drawing.Point(259, 98)
        Me.txtTot_Ext.Name = "txtTot_Ext"
        Me.txtTot_Ext.Size = New System.Drawing.Size(53, 21)
        Me.txtTot_Ext.TabIndex = 111
        '
        'txtExt4
        '
        Me.txtExt4.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtExt4.Border.Class = "TextBoxBorder"
        Me.txtExt4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtExt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExt4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtExt4, True)
        Me.txtExt4.Location = New System.Drawing.Point(259, 73)
        Me.txtExt4.Name = "txtExt4"
        Me.txtExt4.Size = New System.Drawing.Size(53, 21)
        Me.txtExt4.TabIndex = 110
        '
        'txtExt3
        '
        Me.txtExt3.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtExt3.Border.Class = "TextBoxBorder"
        Me.txtExt3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtExt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExt3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtExt3, True)
        Me.txtExt3.Location = New System.Drawing.Point(259, 50)
        Me.txtExt3.Name = "txtExt3"
        Me.txtExt3.Size = New System.Drawing.Size(53, 21)
        Me.txtExt3.TabIndex = 109
        '
        'txtExt2
        '
        Me.txtExt2.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtExt2.Border.Class = "TextBoxBorder"
        Me.txtExt2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtExt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExt2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtExt2, True)
        Me.txtExt2.Location = New System.Drawing.Point(259, 26)
        Me.txtExt2.Name = "txtExt2"
        Me.txtExt2.Size = New System.Drawing.Size(53, 21)
        Me.txtExt2.TabIndex = 108
        '
        'txtExt1
        '
        Me.txtExt1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtExt1.Border.Class = "TextBoxBorder"
        Me.txtExt1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtExt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExt1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtExt1, True)
        Me.txtExt1.Location = New System.Drawing.Point(259, 1)
        Me.txtExt1.Name = "txtExt1"
        Me.txtExt1.Size = New System.Drawing.Size(53, 21)
        Me.txtExt1.TabIndex = 107
        '
        'LabelX20
        '
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelX20.ForeColor = System.Drawing.Color.Navy
        Me.LabelX20.Location = New System.Drawing.Point(3, 52)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(90, 23)
        Me.LabelX20.TabIndex = 99
        Me.LabelX20.Text = "Premier"
        '
        'LabelX17
        '
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelX17.ForeColor = System.Drawing.Color.Navy
        Me.LabelX17.Location = New System.Drawing.Point(3, 1)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(152, 23)
        Me.LabelX17.TabIndex = 90
        Me.LabelX17.Text = "Claudio Naranja"
        '
        'LabelX18
        '
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelX18.ForeColor = System.Drawing.Color.Navy
        Me.LabelX18.Location = New System.Drawing.Point(3, 77)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(152, 23)
        Me.LabelX18.TabIndex = 94
        Me.LabelX18.Text = "OTROS"
        '
        'LabelX19
        '
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelX19.ForeColor = System.Drawing.Color.Navy
        Me.LabelX19.Location = New System.Drawing.Point(3, 27)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(90, 23)
        Me.LabelX19.TabIndex = 91
        Me.LabelX19.Text = "Angeles"
        '
        'btnRemitente
        '
        Me.btnRemitente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRemitente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemitente.Image = CType(resources.GetObject("btnRemitente.Image"), System.Drawing.Image)
        Me.btnRemitente.Location = New System.Drawing.Point(460, 89)
        Me.btnRemitente.Name = "btnRemitente"
        Me.btnRemitente.Size = New System.Drawing.Size(50, 50)
        Me.btnRemitente.TabIndex = 3
        Me.btnRemitente.UseVisualStyleBackColor = False
        '
        'cuenta
        '
        Me.cuenta.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuenta.ForeColor = System.Drawing.Color.OliveDrab
        Me.cuenta.Location = New System.Drawing.Point(319, 110)
        Me.cuenta.Name = "cuenta"
        Me.cuenta.Size = New System.Drawing.Size(123, 32)
        Me.cuenta.TabIndex = 112
        Me.cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(320, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 13)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Cuenta de Detraccion"
        '
        'ruc
        '
        Me.ruc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ruc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ruc.ForeColor = System.Drawing.Color.OliveDrab
        Me.ruc.Location = New System.Drawing.Point(188, 110)
        Me.ruc.Name = "ruc"
        Me.ruc.Size = New System.Drawing.Size(123, 32)
        Me.ruc.TabIndex = 110
        Me.ruc.Text = " "
        Me.ruc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(192, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "RUC"
        '
        'remitente
        '
        Me.remitente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.remitente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.remitente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remitente.ForeColor = System.Drawing.Color.OliveDrab
        Me.remitente.Location = New System.Drawing.Point(7, 110)
        Me.remitente.Name = "remitente"
        Me.remitente.Size = New System.Drawing.Size(169, 32)
        Me.remitente.TabIndex = 108
        Me.remitente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "Remitente"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green
        '
        'txt_TOTAL
        '
        Me.txt_TOTAL.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txt_TOTAL.Border.Class = "TextBoxBorder"
        Me.txt_TOTAL.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_TOTAL.FocusHighlightEnabled = True
        Me.txt_TOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TOTAL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txt_TOTAL, True)
        Me.txt_TOTAL.Location = New System.Drawing.Point(837, 505)
        Me.txt_TOTAL.Name = "txt_TOTAL"
        Me.txt_TOTAL.Size = New System.Drawing.Size(53, 21)
        Me.txt_TOTAL.TabIndex = 113
        '
        'btnCALC
        '
        Me.btnCALC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCALC.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCALC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCALC.Image = CType(resources.GetObject("btnCALC.Image"), System.Drawing.Image)
        Me.btnCALC.Location = New System.Drawing.Point(2, 463)
        Me.btnCALC.Name = "btnCALC"
        Me.btnCALC.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnCALC.Size = New System.Drawing.Size(132, 58)
        Me.btnCALC.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.btnCALC.TabIndex = 114
        Me.btnCALC.Text = "<b>CALCULADORA</b>"
        '
        'BTN_PAGINA
        '
        Me.BTN_PAGINA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_PAGINA.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.BTN_PAGINA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PAGINA.Image = CType(resources.GetObject("BTN_PAGINA.Image"), System.Drawing.Image)
        Me.BTN_PAGINA.Location = New System.Drawing.Point(142, 463)
        Me.BTN_PAGINA.Name = "BTN_PAGINA"
        Me.BTN_PAGINA.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.BTN_PAGINA.Size = New System.Drawing.Size(132, 58)
        Me.BTN_PAGINA.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.BTN_PAGINA.TabIndex = 115
        Me.BTN_PAGINA.Text = "<b>MINISTERIO DE AGRICULTURA</b>"
        '
        'LabelX14
        '
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.ForeColor = System.Drawing.Color.Crimson
        Me.LabelX14.Location = New System.Drawing.Point(730, 505)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(101, 23)
        Me.LabelX14.TabIndex = 113
        Me.LabelX14.Text = "Total Sacos:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(553, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 520)
        Me.Panel1.TabIndex = 116
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Fecha de Emision:"
        '
        'Fecha_Emis
        '
        Me.Fecha_Emis.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_Emis.Location = New System.Drawing.Point(122, 41)
        Me.Fecha_Emis.Name = "Fecha_Emis"
        Me.Fecha_Emis.Size = New System.Drawing.Size(98, 20)
        Me.Fecha_Emis.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(294, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "S/"
        '
        'txtIdCat
        '
        Me.txtIdCat.ForeColor = System.Drawing.Color.Blue
        Me.txtIdCat.Location = New System.Drawing.Point(11, 185)
        Me.txtIdCat.Name = "txtIdCat"
        Me.txtIdCat.Size = New System.Drawing.Size(57, 24)
        Me.txtIdCat.TabIndex = 120
        Me.txtIdCat.Text = "             "
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Selecciona"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Seleccionar.Width = 85
        '
        'id_det_pago
        '
        Me.id_det_pago.HeaderText = "ID"
        Me.id_det_pago.Name = "id_det_pago"
        Me.id_det_pago.Visible = False
        Me.id_det_pago.Width = 43
        '
        'id_cat
        '
        Me.id_cat.HeaderText = "Codigo"
        Me.id_cat.Name = "id_cat"
        Me.id_cat.Visible = False
        Me.id_cat.Width = 65
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 88
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 62
        '
        'sacos_cantidad
        '
        Me.sacos_cantidad.HeaderText = "Cantidad"
        Me.sacos_cantidad.Name = "sacos_cantidad"
        Me.sacos_cantidad.Width = 74
        '
        'Ivap
        '
        Me.Ivap.HeaderText = "Ivap"
        Me.Ivap.Name = "Ivap"
        Me.Ivap.Width = 53
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 56
        '
        'FrmPago_Detra1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(906, 533)
        Me.Controls.Add(Me.txtIdCat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Fecha_Emis)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_PAGINA)
        Me.Controls.Add(Me.btnCALC)
        Me.Controls.Add(Me.txt_TOTAL)
        Me.Controls.Add(Me.LabelX14)
        Me.Controls.Add(Me.btnRemitente)
        Me.Controls.Add(Me.cuenta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ruc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.remitente)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupPanel3)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.Detalle_Cat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtivap)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.btnCategoria)
        Me.Controls.Add(Me.NombreCATEGORIA)
        Me.Controls.Add(Me.cantidad_sacos)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnquitar_hpm)
        Me.Controls.Add(Me.btneditar_hpm)
        Me.Controls.Add(Me.btnnuevo_examen)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.fecha)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmPago_Detra1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Pago-Detraccion"
        CType(Me.Detalle_Cat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnquitar_hpm As System.Windows.Forms.Button
    Friend WithEvents btneditar_hpm As System.Windows.Forms.Button
    Friend WithEvents btnnuevo_examen As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnCategoria As System.Windows.Forms.Button
    Friend WithEvents NombreCATEGORIA As System.Windows.Forms.Label
    Friend WithEvents cantidad_sacos As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents txtivap As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Detalle_Cat As System.Windows.Forms.DataGridView
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnRemitente As System.Windows.Forms.Button
    Friend WithEvents cuenta As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ruc As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents remitente As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtsup5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtsup4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtsup3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtsup2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtsup1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdesp5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdesp4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdesp3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdesp2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdesp1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtExt4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtExt3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtExt2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtExt1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTot_Sup As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDespTotal As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents txtTot_Ext As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_TOTAL As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCALC As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_PAGINA As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Fecha_Emis As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIdCat As System.Windows.Forms.Label
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id_det_pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sacos_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ivap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

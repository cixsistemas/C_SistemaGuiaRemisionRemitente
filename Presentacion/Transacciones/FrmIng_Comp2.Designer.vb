<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIng_Comp2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIng_Comp2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NombreRemitente = New System.Windows.Forms.Label()
        Me.btnremitente = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTipoComp = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnTipoComp = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.Fecha_Ingreso = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvlista = New System.Windows.Forms.DataGridView()
        Me.SELECCIONAR = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDDETALLEINGCOMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDINGCOMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.TxtNumero2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtOpe = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtTipoOperac = New System.Windows.Forms.Label()
        Me.BtnOperacion = New System.Windows.Forms.Button()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(826, 23)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "Ingrese Datos de Ingreso de Comprobantes de Pago"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NombreRemitente
        '
        Me.NombreRemitente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NombreRemitente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreRemitente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreRemitente.ForeColor = System.Drawing.Color.Blue
        Me.NombreRemitente.Location = New System.Drawing.Point(25, 66)
        Me.NombreRemitente.Name = "NombreRemitente"
        Me.NombreRemitente.Size = New System.Drawing.Size(321, 32)
        Me.NombreRemitente.TabIndex = 199
        Me.NombreRemitente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnremitente
        '
        Me.btnremitente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnremitente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnremitente.Image = CType(resources.GetObject("btnremitente.Image"), System.Drawing.Image)
        Me.btnremitente.Location = New System.Drawing.Point(368, 51)
        Me.btnremitente.Name = "btnremitente"
        Me.btnremitente.Size = New System.Drawing.Size(41, 45)
        Me.btnremitente.TabIndex = 0
        Me.btnremitente.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Empresa:"
        '
        'TxtTipoComp
        '
        Me.TxtTipoComp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtTipoComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTipoComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTipoComp.ForeColor = System.Drawing.Color.Blue
        Me.TxtTipoComp.Location = New System.Drawing.Point(23, 138)
        Me.TxtTipoComp.Name = "TxtTipoComp"
        Me.TxtTipoComp.Size = New System.Drawing.Size(203, 32)
        Me.TxtTipoComp.TabIndex = 201
        Me.TxtTipoComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 21)
        Me.Label2.TabIndex = 202
        Me.Label2.Text = "Tipo de Comprobante"
        '
        'BtnTipoComp
        '
        Me.BtnTipoComp.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnTipoComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTipoComp.Image = CType(resources.GetObject("BtnTipoComp.Image"), System.Drawing.Image)
        Me.BtnTipoComp.Location = New System.Drawing.Point(235, 125)
        Me.BtnTipoComp.Name = "BtnTipoComp"
        Me.BtnTipoComp.Size = New System.Drawing.Size(41, 45)
        Me.BtnTipoComp.TabIndex = 4
        Me.BtnTipoComp.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(360, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 206
        Me.Label6.Text = "Numero"
        '
        'TxtNumero
        '
        Me.TxtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumero.Location = New System.Drawing.Point(361, 148)
        Me.TxtNumero.MaxLength = 7
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(73, 22)
        Me.TxtNumero.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(297, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 205
        Me.Label5.Text = "Serie:"
        '
        'TxtSerie
        '
        Me.TxtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSerie.Location = New System.Drawing.Point(297, 148)
        Me.TxtSerie.MaxLength = 4
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(49, 22)
        Me.TxtSerie.TabIndex = 6
        '
        'Fecha_Ingreso
        '
        Me.Fecha_Ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_Ingreso.Location = New System.Drawing.Point(528, 152)
        Me.Fecha_Ingreso.Name = "Fecha_Ingreso"
        Me.Fecha_Ingreso.Size = New System.Drawing.Size(96, 20)
        Me.Fecha_Ingreso.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(525, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 208
        Me.Label3.Text = "Fec. Ingreso"
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
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
        Me.dgvlista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SELECCIONAR, Me.IDDETALLEINGCOMP, Me.IDINGCOMP, Me.C, Me.D, Me.G})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlista.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvlista.Location = New System.Drawing.Point(20, 201)
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
        Me.dgvlista.Size = New System.Drawing.Size(529, 208)
        Me.dgvlista.TabIndex = 209
        '
        'SELECCIONAR
        '
        Me.SELECCIONAR.HeaderText = "Seleccionar"
        Me.SELECCIONAR.Name = "SELECCIONAR"
        Me.SELECCIONAR.Width = 69
        '
        'IDDETALLEINGCOMP
        '
        Me.IDDETALLEINGCOMP.HeaderText = "ID DET ING COMP"
        Me.IDDETALLEINGCOMP.Name = "IDDETALLEINGCOMP"
        Me.IDDETALLEINGCOMP.Visible = False
        Me.IDDETALLEINGCOMP.Width = 124
        '
        'IDINGCOMP
        '
        Me.IDINGCOMP.HeaderText = "ID ING COMP"
        Me.IDINGCOMP.Name = "IDINGCOMP"
        Me.IDINGCOMP.Visible = False
        Me.IDINGCOMP.Width = 99
        '
        'C
        '
        Me.C.HeaderText = "Serie"
        Me.C.Name = "C"
        Me.C.Width = 56
        '
        'D
        '
        Me.D.HeaderText = "Numero"
        Me.D.Name = "D"
        Me.D.Width = 69
        '
        'G
        '
        Me.G.HeaderText = "Estado"
        Me.G.Name = "G"
        Me.G.Width = 65
        '
        'btneliminar
        '
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.ForeColor = System.Drawing.Color.Red
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.Location = New System.Drawing.Point(567, 273)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(91, 30)
        Me.btneliminar.TabIndex = 213
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
        Me.btnQuitar.Location = New System.Drawing.Point(567, 237)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(91, 30)
        Me.btnQuitar.TabIndex = 212
        Me.btnQuitar.Tag = "Puede seleccinar y quitar con tecla --> SUPR"
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(692, 273)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(91, 30)
        Me.btnEditar.TabIndex = 211
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        Me.btnEditar.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(567, 201)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(91, 30)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(636, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 15)
        Me.Label12.TabIndex = 217
        Me.Label12.Text = "Descripcion:"
        '
        'txtDescrip
        '
        Me.txtDescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrip.Location = New System.Drawing.Point(639, 133)
        Me.txtDescrip.MaxLength = 250
        Me.txtDescrip.Multiline = True
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(207, 39)
        Me.txtDescrip.TabIndex = 16
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(567, 355)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(112, 48)
        Me.btnaceptar.TabIndex = 218
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
        Me.btncancelar.Location = New System.Drawing.Point(703, 355)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(125, 48)
        Me.btncancelar.TabIndex = 219
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'TxtNumero2
        '
        Me.TxtNumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNumero2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumero2.Location = New System.Drawing.Point(440, 148)
        Me.TxtNumero2.MaxLength = 7
        Me.TxtNumero2.Name = "TxtNumero2"
        Me.TxtNumero2.Size = New System.Drawing.Size(73, 22)
        Me.TxtNumero2.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(437, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 220
        Me.Label9.Text = "Numero"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(360, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 16)
        Me.Label10.TabIndex = 221
        Me.Label10.Text = "Desde"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(437, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 16)
        Me.Label11.TabIndex = 222
        Me.Label11.Text = "Hasta"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(612, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 21)
        Me.Label8.TabIndex = 196
        Me.Label8.Text = "Operacion:"
        '
        'TxtOpe
        '
        Me.TxtOpe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtOpe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOpe.ForeColor = System.Drawing.Color.Blue
        Me.TxtOpe.Location = New System.Drawing.Point(613, 66)
        Me.TxtOpe.Name = "TxtOpe"
        Me.TxtOpe.Size = New System.Drawing.Size(155, 32)
        Me.TxtOpe.TabIndex = 195
        Me.TxtOpe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(442, 45)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(156, 21)
        Me.Label23.TabIndex = 198
        Me.Label23.Text = "Tipo Operacion"
        '
        'TxtTipoOperac
        '
        Me.TxtTipoOperac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtTipoOperac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTipoOperac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTipoOperac.ForeColor = System.Drawing.Color.Blue
        Me.TxtTipoOperac.Location = New System.Drawing.Point(443, 66)
        Me.TxtTipoOperac.Name = "TxtTipoOperac"
        Me.TxtTipoOperac.Size = New System.Drawing.Size(155, 32)
        Me.TxtTipoOperac.TabIndex = 197
        Me.TxtTipoOperac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnOperacion
        '
        Me.BtnOperacion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOperacion.Image = CType(resources.GetObject("BtnOperacion.Image"), System.Drawing.Image)
        Me.BtnOperacion.Location = New System.Drawing.Point(787, 53)
        Me.BtnOperacion.Name = "BtnOperacion"
        Me.BtnOperacion.Size = New System.Drawing.Size(41, 45)
        Me.BtnOperacion.TabIndex = 2
        Me.BtnOperacion.UseVisualStyleBackColor = False
        '
        'FrmIng_Comp2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 426)
        Me.Controls.Add(Me.BtnOperacion)
        Me.Controls.Add(Me.NombreRemitente)
        Me.Controls.Add(Me.TxtTipoOperac)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnremitente)
        Me.Controls.Add(Me.TxtOpe)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtNumero2)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDescrip)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.Fecha_Ingreso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNumero)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSerie)
        Me.Controls.Add(Me.BtnTipoComp)
        Me.Controls.Add(Me.TxtTipoComp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIng_Comp2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Ingreso de Comprobantes de Pago"
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnremitente As System.Windows.Forms.Button
    Friend WithEvents TxtTipoComp As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnTipoComp As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_Ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents TxtNumero2 As System.Windows.Forms.TextBox
    Friend WithEvents NombreRemitente As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtOpe As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtTipoOperac As System.Windows.Forms.Label
    Friend WithEvents BtnOperacion As System.Windows.Forms.Button
    Friend WithEvents SELECCIONAR As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IDDETALLEINGCOMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDINGCOMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents G As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

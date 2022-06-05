<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproductos
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmproductos))
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.txtbusca = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbActivo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.gbob = New System.Windows.Forms.GroupBox()
        Me.LbF8 = New DevComponents.DotNetBar.LabelX()
        Me.LBF7 = New DevComponents.DotNetBar.LabelX()
        Me.LBF6 = New DevComponents.DotNetBar.LabelX()
        Me.LBF5 = New DevComponents.DotNetBar.LabelX()
        Me.LBF4 = New DevComponents.DotNetBar.LabelX()
        Me.LBF3 = New DevComponents.DotNetBar.LabelX()
        Me.LBF2 = New DevComponents.DotNetBar.LabelX()
        Me.RbNom_Com = New System.Windows.Forms.RadioButton()
        Me.Rbenvase = New System.Windows.Forms.RadioButton()
        Me.Rblogo = New System.Windows.Forms.RadioButton()
        Me.RbTodos = New System.Windows.Forms.RadioButton()
        Me.rbcat = New System.Windows.Forms.RadioButton()
        Me.rbProducto = New System.Windows.Forms.RadioButton()
        Me.rbcolor = New System.Windows.Forms.RadioButton()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.mesajeerror = New DevComponents.DotNetBar.LabelX()
        Me.dgvlista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btnAnular = New DevComponents.DotNetBar.ButtonX()
        Me.BtnCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnModificar = New DevComponents.DotNetBar.ButtonX()
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.gbob.SuspendLayout()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'txtbusca
        '
        '
        '
        '
        Me.txtbusca.Border.Class = "TextBoxBorder"
        Me.txtbusca.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbusca.DisabledBackColor = System.Drawing.Color.White
        Me.txtbusca.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.txtbusca, True)
        Me.txtbusca.Location = New System.Drawing.Point(81, 50)
        Me.txtbusca.Name = "txtbusca"
        Me.txtbusca.Size = New System.Drawing.Size(745, 23)
        Me.txtbusca.TabIndex = 0
        '
        'cbActivo
        '
        Me.cbActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.cbActivo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbActivo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActivo.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.cbActivo, True)
        Me.cbActivo.Location = New System.Drawing.Point(837, 52)
        Me.cbActivo.Name = "cbActivo"
        Me.cbActivo.Size = New System.Drawing.Size(100, 23)
        Me.cbActivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbActivo.TabIndex = 237
        Me.cbActivo.Text = "Activo"
        Me.cbActivo.TextColor = System.Drawing.Color.Red
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(177, Byte), Integer)))
        '
        'gbob
        '
        Me.gbob.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.gbob.Controls.Add(Me.cbActivo)
        Me.gbob.Controls.Add(Me.LbF8)
        Me.gbob.Controls.Add(Me.LBF7)
        Me.gbob.Controls.Add(Me.LBF6)
        Me.gbob.Controls.Add(Me.LBF5)
        Me.gbob.Controls.Add(Me.LBF4)
        Me.gbob.Controls.Add(Me.LBF3)
        Me.gbob.Controls.Add(Me.LBF2)
        Me.gbob.Controls.Add(Me.RbNom_Com)
        Me.gbob.Controls.Add(Me.txtbusca)
        Me.gbob.Controls.Add(Me.Rbenvase)
        Me.gbob.Controls.Add(Me.Rblogo)
        Me.gbob.Controls.Add(Me.RbTodos)
        Me.gbob.Controls.Add(Me.rbcat)
        Me.gbob.Controls.Add(Me.rbProducto)
        Me.gbob.Controls.Add(Me.rbcolor)
        Me.gbob.Controls.Add(Me.LabelX2)
        Me.gbob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbob.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbob.ForeColor = System.Drawing.Color.Black
        Me.gbob.Location = New System.Drawing.Point(5, 11)
        Me.gbob.Name = "gbob"
        Me.gbob.Size = New System.Drawing.Size(973, 83)
        Me.gbob.TabIndex = 2
        Me.gbob.TabStop = False
        Me.gbob.Text = "Seleccione opciones de busqueda:"
        '
        'LbF8
        '
        Me.LbF8.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.LbF8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LbF8.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbF8.ForeColor = System.Drawing.Color.Black
        Me.LbF8.Location = New System.Drawing.Point(847, 18)
        Me.LbF8.Name = "LbF8"
        Me.LbF8.Size = New System.Drawing.Size(33, 23)
        Me.LbF8.TabIndex = 236
        Me.LbF8.Text = " [F8]"
        Me.LbF8.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LBF7
        '
        Me.LBF7.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.LBF7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBF7.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBF7.ForeColor = System.Drawing.Color.Black
        Me.LBF7.Location = New System.Drawing.Point(739, 18)
        Me.LBF7.Name = "LBF7"
        Me.LBF7.Size = New System.Drawing.Size(33, 23)
        Me.LBF7.TabIndex = 235
        Me.LBF7.Text = " [F7]"
        Me.LBF7.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LBF6
        '
        Me.LBF6.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.LBF6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBF6.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBF6.ForeColor = System.Drawing.Color.Black
        Me.LBF6.Location = New System.Drawing.Point(616, 19)
        Me.LBF6.Name = "LBF6"
        Me.LBF6.Size = New System.Drawing.Size(33, 23)
        Me.LBF6.TabIndex = 234
        Me.LBF6.Text = " [F6]"
        Me.LBF6.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LBF5
        '
        Me.LBF5.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.LBF5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBF5.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBF5.ForeColor = System.Drawing.Color.Black
        Me.LBF5.Location = New System.Drawing.Point(497, 20)
        Me.LBF5.Name = "LBF5"
        Me.LBF5.Size = New System.Drawing.Size(33, 23)
        Me.LBF5.TabIndex = 233
        Me.LBF5.Text = " [F5]"
        Me.LBF5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LBF4
        '
        Me.LBF4.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.LBF4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBF4.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBF4.ForeColor = System.Drawing.Color.Black
        Me.LBF4.Location = New System.Drawing.Point(372, 20)
        Me.LBF4.Name = "LBF4"
        Me.LBF4.Size = New System.Drawing.Size(33, 23)
        Me.LBF4.TabIndex = 220
        Me.LBF4.Text = " [F4]"
        Me.LBF4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LBF3
        '
        Me.LBF3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.LBF3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBF3.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBF3.ForeColor = System.Drawing.Color.Black
        Me.LBF3.Location = New System.Drawing.Point(268, 20)
        Me.LBF3.Name = "LBF3"
        Me.LBF3.Size = New System.Drawing.Size(33, 23)
        Me.LBF3.TabIndex = 219
        Me.LBF3.Text = " [F3]"
        Me.LBF3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LBF2
        '
        Me.LBF2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.LBF2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBF2.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBF2.ForeColor = System.Drawing.Color.Black
        Me.LBF2.Location = New System.Drawing.Point(91, 19)
        Me.LBF2.Name = "LBF2"
        Me.LBF2.Size = New System.Drawing.Size(33, 23)
        Me.LBF2.TabIndex = 218
        Me.LBF2.Text = " [F2]"
        Me.LBF2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'RbNom_Com
        '
        Me.RbNom_Com.AutoSize = True
        Me.RbNom_Com.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RbNom_Com.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbNom_Com.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNom_Com.ForeColor = System.Drawing.Color.Black
        Me.RbNom_Com.Location = New System.Drawing.Point(131, 23)
        Me.RbNom_Com.Name = "RbNom_Com"
        Me.RbNom_Com.Size = New System.Drawing.Size(140, 21)
        Me.RbNom_Com.TabIndex = 9
        Me.RbNom_Com.TabStop = True
        Me.RbNom_Com.Tag = "Nombre Comercial"
        Me.RbNom_Com.Text = "Nombre Comercial"
        Me.RbNom_Com.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbNom_Com.UseVisualStyleBackColor = False
        '
        'Rbenvase
        '
        Me.Rbenvase.AutoSize = True
        Me.Rbenvase.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Rbenvase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rbenvase.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbenvase.ForeColor = System.Drawing.Color.Black
        Me.Rbenvase.Location = New System.Drawing.Point(661, 20)
        Me.Rbenvase.Name = "Rbenvase"
        Me.Rbenvase.Size = New System.Drawing.Size(83, 21)
        Me.Rbenvase.TabIndex = 8
        Me.Rbenvase.TabStop = True
        Me.Rbenvase.Tag = "Envasado"
        Me.Rbenvase.Text = "Envasado"
        Me.Rbenvase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Rbenvase.UseVisualStyleBackColor = False
        '
        'Rblogo
        '
        Me.Rblogo.AutoSize = True
        Me.Rblogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Rblogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rblogo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rblogo.ForeColor = System.Drawing.Color.Black
        Me.Rblogo.Location = New System.Drawing.Point(541, 20)
        Me.Rblogo.Name = "Rblogo"
        Me.Rblogo.Size = New System.Drawing.Size(81, 21)
        Me.Rblogo.TabIndex = 7
        Me.Rblogo.TabStop = True
        Me.Rblogo.Tag = "Logotipo"
        Me.Rblogo.Text = "Logotipo"
        Me.Rblogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Rblogo.UseVisualStyleBackColor = False
        '
        'RbTodos
        '
        Me.RbTodos.AutoSize = True
        Me.RbTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RbTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbTodos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodos.ForeColor = System.Drawing.Color.Black
        Me.RbTodos.Location = New System.Drawing.Point(787, 20)
        Me.RbTodos.Name = "RbTodos"
        Me.RbTodos.Size = New System.Drawing.Size(62, 21)
        Me.RbTodos.TabIndex = 6
        Me.RbTodos.TabStop = True
        Me.RbTodos.Tag = "Todos"
        Me.RbTodos.Text = "Todos"
        Me.RbTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbTodos.UseVisualStyleBackColor = False
        '
        'rbcat
        '
        Me.rbcat.AutoSize = True
        Me.rbcat.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.rbcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbcat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcat.ForeColor = System.Drawing.Color.Black
        Me.rbcat.Location = New System.Drawing.Point(419, 21)
        Me.rbcat.Name = "rbcat"
        Me.rbcat.Size = New System.Drawing.Size(84, 21)
        Me.rbcat.TabIndex = 5
        Me.rbcat.TabStop = True
        Me.rbcat.Tag = "Categoria"
        Me.rbcat.Text = "Categoria"
        Me.rbcat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbcat.UseVisualStyleBackColor = False
        '
        'rbProducto
        '
        Me.rbProducto.AutoSize = True
        Me.rbProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.rbProducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.rbProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbProducto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbProducto.ForeColor = System.Drawing.Color.Black
        Me.rbProducto.Location = New System.Drawing.Point(15, 22)
        Me.rbProducto.Name = "rbProducto"
        Me.rbProducto.Size = New System.Drawing.Size(81, 21)
        Me.rbProducto.TabIndex = 2
        Me.rbProducto.TabStop = True
        Me.rbProducto.Tag = "Producto"
        Me.rbProducto.Text = "Producto"
        Me.rbProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbProducto.UseVisualStyleBackColor = False
        '
        'rbcolor
        '
        Me.rbcolor.AutoSize = True
        Me.rbcolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.rbcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbcolor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcolor.ForeColor = System.Drawing.Color.Black
        Me.rbcolor.Location = New System.Drawing.Point(317, 22)
        Me.rbcolor.Name = "rbcolor"
        Me.rbcolor.Size = New System.Drawing.Size(58, 21)
        Me.rbcolor.TabIndex = 4
        Me.rbcolor.TabStop = True
        Me.rbcolor.Tag = "Color"
        Me.rbcolor.Text = "Color"
        Me.rbcolor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbcolor.UseVisualStyleBackColor = False
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(15, 48)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(59, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Buscar:"
        '
        'mesajeerror
        '
        Me.mesajeerror.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.mesajeerror.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mesajeerror.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mesajeerror.ForeColor = System.Drawing.Color.Black
        Me.mesajeerror.Location = New System.Drawing.Point(12, 435)
        Me.mesajeerror.Name = "mesajeerror"
        Me.mesajeerror.Size = New System.Drawing.Size(960, 23)
        Me.mesajeerror.TabIndex = 179
        Me.mesajeerror.Text = "LabelX2"
        Me.mesajeerror.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlista.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvlista.EnableHeadersVisualStyles = False
        Me.dgvlista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvlista.Location = New System.Drawing.Point(12, 105)
        Me.dgvlista.Name = "dgvlista"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlista.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvlista.Size = New System.Drawing.Size(960, 317)
        Me.dgvlista.TabIndex = 178
        '
        'btnAnular
        '
        Me.btnAnular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAnular.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnAnular.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.Image = Global.Presentacion.My.Resources.Resources.desactivar
        Me.btnAnular.Location = New System.Drawing.Point(506, 469)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(128, 41)
        Me.btnAnular.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAnular.TabIndex = 185
        Me.btnAnular.Text = "&Desactivar"
        Me.btnAnular.TextColor = System.Drawing.Color.Black
        '
        'BtnCerrar
        '
        Me.BtnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(810, 469)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(128, 41)
        Me.BtnCerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnCerrar.TabIndex = 184
        Me.BtnCerrar.Text = "&Cerrar"
        Me.BtnCerrar.TextColor = System.Drawing.Color.Black
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(664, 469)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(128, 41)
        Me.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnImprimir.TabIndex = 183
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextColor = System.Drawing.Color.Black
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(354, 469)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(128, 41)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 182
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.TextColor = System.Drawing.Color.Black
        '
        'BtnModificar
        '
        Me.BtnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(201, 469)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(128, 41)
        Me.BtnModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnModificar.TabIndex = 181
        Me.BtnModificar.Text = "&Modificar"
        Me.BtnModificar.TextColor = System.Drawing.Color.Black
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(62, 469)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(121, 41)
        Me.btnNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevo.TabIndex = 180
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextColor = System.Drawing.Color.Black
        '
        'frmproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 522)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.mesajeerror)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.gbob)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmproductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.gbob.ResumeLayout(False)
        Me.gbob.PerformLayout()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents gbob As System.Windows.Forms.GroupBox
    Friend WithEvents Rbenvase As System.Windows.Forms.RadioButton
    Friend WithEvents Rblogo As System.Windows.Forms.RadioButton
    Friend WithEvents RbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbcat As System.Windows.Forms.RadioButton
    Friend WithEvents rbProducto As System.Windows.Forms.RadioButton
    Friend WithEvents rbcolor As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtbusca As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mesajeerror As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgvlista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents RbNom_Com As System.Windows.Forms.RadioButton
    Friend WithEvents LbF8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnAnular As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbActivo As DevComponents.DotNetBar.Controls.CheckBoxX
End Class

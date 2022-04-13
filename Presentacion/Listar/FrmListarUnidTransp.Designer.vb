<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarUnidTransp
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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListarUnidTransp))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.txtbusca = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.gbob = New System.Windows.Forms.GroupBox()
        Me.RbPlac_Sem = New System.Windows.Forms.RadioButton()
        Me.RbMar_Semi = New System.Windows.Forms.RadioButton()
        Me.RbTodos = New System.Windows.Forms.RadioButton()
        Me.rbplac_Rem = New System.Windows.Forms.RadioButton()
        Me.rbEmpresa = New System.Windows.Forms.RadioButton()
        Me.rbmar_rem = New System.Windows.Forms.RadioButton()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.dgvlista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Acep = New DevComponents.DotNetBar.ButtonX()
        Me.mesajeerror = New DevComponents.DotNetBar.LabelX()
        Me.LBF2 = New DevComponents.DotNetBar.LabelX()
        Me.LBF3 = New DevComponents.DotNetBar.LabelX()
        Me.LBF4 = New DevComponents.DotNetBar.LabelX()
        Me.LBF5 = New DevComponents.DotNetBar.LabelX()
        Me.LBF6 = New DevComponents.DotNetBar.LabelX()
        Me.LBF7 = New DevComponents.DotNetBar.LabelX()
        Me.gbob.SuspendLayout()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(177, Byte), Integer)))
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'txtbusca
        '
        Me.txtbusca.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtbusca.Border.Class = "TextBoxBorder"
        Me.txtbusca.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbusca.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusca.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtbusca, True)
        Me.txtbusca.Location = New System.Drawing.Point(80, 49)
        Me.txtbusca.Name = "txtbusca"
        Me.txtbusca.Size = New System.Drawing.Size(877, 23)
        Me.txtbusca.TabIndex = 0
        '
        'gbob
        '
        Me.gbob.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.gbob.Controls.Add(Me.LBF7)
        Me.gbob.Controls.Add(Me.LBF6)
        Me.gbob.Controls.Add(Me.LBF5)
        Me.gbob.Controls.Add(Me.LBF4)
        Me.gbob.Controls.Add(Me.LBF3)
        Me.gbob.Controls.Add(Me.LBF2)
        Me.gbob.Controls.Add(Me.txtbusca)
        Me.gbob.Controls.Add(Me.RbPlac_Sem)
        Me.gbob.Controls.Add(Me.RbMar_Semi)
        Me.gbob.Controls.Add(Me.RbTodos)
        Me.gbob.Controls.Add(Me.rbplac_Rem)
        Me.gbob.Controls.Add(Me.rbEmpresa)
        Me.gbob.Controls.Add(Me.rbmar_rem)
        Me.gbob.Controls.Add(Me.LabelX2)
        Me.gbob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbob.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbob.ForeColor = System.Drawing.Color.Black
        Me.gbob.Location = New System.Drawing.Point(13, 12)
        Me.gbob.Name = "gbob"
        Me.gbob.Size = New System.Drawing.Size(975, 83)
        Me.gbob.TabIndex = 2
        Me.gbob.TabStop = False
        Me.gbob.Text = "Seleccione opciones de busqueda:"
        '
        'RbPlac_Sem
        '
        Me.RbPlac_Sem.AutoSize = True
        Me.RbPlac_Sem.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RbPlac_Sem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbPlac_Sem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPlac_Sem.ForeColor = System.Drawing.Color.Black
        Me.RbPlac_Sem.Location = New System.Drawing.Point(317, 23)
        Me.RbPlac_Sem.Name = "RbPlac_Sem"
        Me.RbPlac_Sem.Size = New System.Drawing.Size(143, 21)
        Me.RbPlac_Sem.TabIndex = 8
        Me.RbPlac_Sem.TabStop = True
        Me.RbPlac_Sem.Tag = "Placa Semi-Remolque"
        Me.RbPlac_Sem.Text = "Placa Semi-Remolq"
        Me.RbPlac_Sem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbPlac_Sem.UseVisualStyleBackColor = False
        '
        'RbMar_Semi
        '
        Me.RbMar_Semi.AutoSize = True
        Me.RbMar_Semi.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RbMar_Semi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbMar_Semi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbMar_Semi.ForeColor = System.Drawing.Color.Black
        Me.RbMar_Semi.Location = New System.Drawing.Point(500, 23)
        Me.RbMar_Semi.Name = "RbMar_Semi"
        Me.RbMar_Semi.Size = New System.Drawing.Size(148, 21)
        Me.RbMar_Semi.TabIndex = 7
        Me.RbMar_Semi.TabStop = True
        Me.RbMar_Semi.Tag = "Marca Semi-Remolque"
        Me.RbMar_Semi.Text = "Marca Semi-Remolq"
        Me.RbMar_Semi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbMar_Semi.UseVisualStyleBackColor = False
        '
        'RbTodos
        '
        Me.RbTodos.AutoSize = True
        Me.RbTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RbTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbTodos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodos.ForeColor = System.Drawing.Color.Black
        Me.RbTodos.Location = New System.Drawing.Point(864, 23)
        Me.RbTodos.Name = "RbTodos"
        Me.RbTodos.Size = New System.Drawing.Size(63, 21)
        Me.RbTodos.TabIndex = 6
        Me.RbTodos.TabStop = True
        Me.RbTodos.Tag = "Todos"
        Me.RbTodos.Text = "Todos"
        Me.RbTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbTodos.UseVisualStyleBackColor = False
        '
        'rbplac_Rem
        '
        Me.rbplac_Rem.AutoSize = True
        Me.rbplac_Rem.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.rbplac_Rem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbplac_Rem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbplac_Rem.ForeColor = System.Drawing.Color.Black
        Me.rbplac_Rem.Location = New System.Drawing.Point(15, 23)
        Me.rbplac_Rem.Name = "rbplac_Rem"
        Me.rbplac_Rem.Size = New System.Drawing.Size(108, 21)
        Me.rbplac_Rem.TabIndex = 5
        Me.rbplac_Rem.TabStop = True
        Me.rbplac_Rem.Tag = "Placa Remolque"
        Me.rbplac_Rem.Text = "Placa Remolq"
        Me.rbplac_Rem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbplac_Rem.UseVisualStyleBackColor = False
        '
        'rbEmpresa
        '
        Me.rbEmpresa.AutoSize = True
        Me.rbEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.rbEmpresa.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.rbEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEmpresa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEmpresa.ForeColor = System.Drawing.Color.Black
        Me.rbEmpresa.Location = New System.Drawing.Point(700, 23)
        Me.rbEmpresa.Name = "rbEmpresa"
        Me.rbEmpresa.Size = New System.Drawing.Size(107, 21)
        Me.rbEmpresa.TabIndex = 2
        Me.rbEmpresa.TabStop = True
        Me.rbEmpresa.Tag = "Empresa Transporte"
        Me.rbEmpresa.Text = "Transportista"
        Me.rbEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbEmpresa.UseVisualStyleBackColor = False
        '
        'rbmar_rem
        '
        Me.rbmar_rem.AutoSize = True
        Me.rbmar_rem.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.rbmar_rem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbmar_rem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbmar_rem.ForeColor = System.Drawing.Color.Black
        Me.rbmar_rem.Location = New System.Drawing.Point(164, 23)
        Me.rbmar_rem.Name = "rbmar_rem"
        Me.rbmar_rem.Size = New System.Drawing.Size(113, 21)
        Me.rbmar_rem.TabIndex = 4
        Me.rbmar_rem.TabStop = True
        Me.rbmar_rem.Tag = "Marca Remolque"
        Me.rbmar_rem.Text = "Marca Remolq"
        Me.rbmar_rem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbmar_rem.UseVisualStyleBackColor = False
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
        'dgvlista
        '
        Me.dgvlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlista.DefaultCellStyle = DataGridViewCellStyle26
        Me.dgvlista.EnableHeadersVisualStyles = False
        Me.dgvlista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvlista.Location = New System.Drawing.Point(13, 101)
        Me.dgvlista.Name = "dgvlista"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlista.RowHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.dgvlista.Size = New System.Drawing.Size(975, 327)
        Me.dgvlista.TabIndex = 3
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(516, 487)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(122, 41)
        Me.btnNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevo.TabIndex = 148
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextColor = System.Drawing.Color.Black
        '
        'btn_Acep
        '
        Me.btn_Acep.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Acep.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btn_Acep.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Acep.Image = CType(resources.GetObject("btn_Acep.Image"), System.Drawing.Image)
        Me.btn_Acep.Location = New System.Drawing.Point(375, 487)
        Me.btn_Acep.Name = "btn_Acep"
        Me.btn_Acep.Size = New System.Drawing.Size(108, 40)
        Me.btn_Acep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Acep.TabIndex = 147
        Me.btn_Acep.Text = "Aceptar"
        Me.btn_Acep.TextColor = System.Drawing.Color.Black
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
        Me.mesajeerror.Location = New System.Drawing.Point(13, 448)
        Me.mesajeerror.Name = "mesajeerror"
        Me.mesajeerror.Size = New System.Drawing.Size(969, 23)
        Me.mesajeerror.TabIndex = 146
        Me.mesajeerror.Text = "LabelX2"
        Me.mesajeerror.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.LBF2.Location = New System.Drawing.Point(121, 21)
        Me.LBF2.Name = "LBF2"
        Me.LBF2.Size = New System.Drawing.Size(33, 23)
        Me.LBF2.TabIndex = 231
        Me.LBF2.Text = " [F2]"
        Me.LBF2.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.LBF3.Location = New System.Drawing.Point(275, 22)
        Me.LBF3.Name = "LBF3"
        Me.LBF3.Size = New System.Drawing.Size(33, 23)
        Me.LBF3.TabIndex = 232
        Me.LBF3.Text = " [F3]"
        Me.LBF3.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.LBF4.Location = New System.Drawing.Point(459, 22)
        Me.LBF4.Name = "LBF4"
        Me.LBF4.Size = New System.Drawing.Size(33, 23)
        Me.LBF4.TabIndex = 233
        Me.LBF4.Text = " [F4]"
        Me.LBF4.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.LBF5.Location = New System.Drawing.Point(643, 21)
        Me.LBF5.Name = "LBF5"
        Me.LBF5.Size = New System.Drawing.Size(33, 23)
        Me.LBF5.TabIndex = 234
        Me.LBF5.Text = " [F5]"
        Me.LBF5.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.LBF6.Location = New System.Drawing.Point(804, 21)
        Me.LBF6.Name = "LBF6"
        Me.LBF6.Size = New System.Drawing.Size(33, 23)
        Me.LBF6.TabIndex = 235
        Me.LBF6.Text = " [F6]"
        Me.LBF6.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.LBF7.Location = New System.Drawing.Point(924, 22)
        Me.LBF7.Name = "LBF7"
        Me.LBF7.Size = New System.Drawing.Size(33, 23)
        Me.LBF7.TabIndex = 236
        Me.LBF7.Text = " [F7]"
        Me.LBF7.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'FrmListarUnidTransp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 540)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btn_Acep)
        Me.Controls.Add(Me.mesajeerror)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.gbob)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmListarUnidTransp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar Unidad de Transporte"
        Me.gbob.ResumeLayout(False)
        Me.gbob.PerformLayout()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents gbob As System.Windows.Forms.GroupBox
    Friend WithEvents RbPlac_Sem As System.Windows.Forms.RadioButton
    Friend WithEvents RbMar_Semi As System.Windows.Forms.RadioButton
    Friend WithEvents RbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbplac_Rem As System.Windows.Forms.RadioButton
    Friend WithEvents rbEmpresa As System.Windows.Forms.RadioButton
    Friend WithEvents rbmar_rem As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgvlista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Acep As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mesajeerror As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtbusca As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LBF2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF7 As DevComponents.DotNetBar.LabelX
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDev_Comp1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDev_Comp1))
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.TxtDistrito = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtpffin = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtpfinic = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.dgvlista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.CboDistrito = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CbFechaIng = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.mesajeerror2 = New DevComponents.DotNetBar.LabelX()
        Me.dgvlistaDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.mesajeerror = New DevComponents.DotNetBar.LabelX()
        Me.BtnCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnModificar = New DevComponents.DotNetBar.ButtonX()
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX()
        CType(Me.dtpffin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpfinic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvlistaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'TxtDistrito
        '
        '
        '
        '
        Me.TxtDistrito.Border.Class = "TextBoxBorder"
        Me.TxtDistrito.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtDistrito.DisabledBackColor = System.Drawing.Color.White
        Me.TxtDistrito.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtDistrito, True)
        Me.TxtDistrito.Location = New System.Drawing.Point(277, 56)
        Me.TxtDistrito.Name = "TxtDistrito"
        Me.TxtDistrito.Size = New System.Drawing.Size(200, 22)
        Me.TxtDistrito.TabIndex = 273
        '
        'dtpffin
        '
        Me.dtpffin.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.dtpffin.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpffin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpffin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtpffin.ButtonDropDown.Visible = True
        Me.dtpffin.Enabled = False
        Me.dtpffin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpffin.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.dtpffin, True)
        Me.dtpffin.IsPopupCalendarOpen = False
        Me.dtpffin.Location = New System.Drawing.Point(138, 57)
        '
        '
        '
        '
        '
        '
        Me.dtpffin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpffin.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtpffin.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpffin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpffin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpffin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpffin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpffin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpffin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpffin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpffin.MonthCalendar.DisplayMonth = New Date(2016, 12, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtpffin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpffin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpffin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpffin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpffin.MonthCalendar.TodayButtonVisible = True
        Me.dtpffin.Name = "dtpffin"
        Me.dtpffin.Size = New System.Drawing.Size(119, 23)
        Me.dtpffin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpffin.TabIndex = 267
        '
        'dtpfinic
        '
        Me.dtpfinic.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.dtpfinic.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpfinic.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpfinic.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtpfinic.ButtonDropDown.Visible = True
        Me.dtpfinic.Enabled = False
        Me.dtpfinic.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfinic.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.dtpfinic, True)
        Me.dtpfinic.IsPopupCalendarOpen = False
        Me.dtpfinic.Location = New System.Drawing.Point(12, 57)
        '
        '
        '
        '
        '
        '
        Me.dtpfinic.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpfinic.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtpfinic.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpfinic.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpfinic.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpfinic.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpfinic.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpfinic.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpfinic.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpfinic.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpfinic.MonthCalendar.DisplayMonth = New Date(2016, 12, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtpfinic.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpfinic.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpfinic.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpfinic.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpfinic.MonthCalendar.TodayButtonVisible = True
        Me.dtpfinic.Name = "dtpfinic"
        Me.dtpfinic.Size = New System.Drawing.Size(119, 23)
        Me.dtpfinic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpfinic.TabIndex = 265
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(177, Byte), Integer)))
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
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlista.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvlista.EnableHeadersVisualStyles = False
        Me.dgvlista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvlista.Location = New System.Drawing.Point(12, 93)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlista.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvlista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlista.Size = New System.Drawing.Size(820, 135)
        Me.dgvlista.TabIndex = 274
        '
        'CboDistrito
        '
        Me.CboDistrito.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.CboDistrito.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CboDistrito.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDistrito.ForeColor = System.Drawing.Color.Black
        Me.CboDistrito.Location = New System.Drawing.Point(277, 26)
        Me.CboDistrito.Name = "CboDistrito"
        Me.CboDistrito.Size = New System.Drawing.Size(119, 23)
        Me.CboDistrito.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboDistrito.TabIndex = 272
        Me.CboDistrito.Text = "Distrito"
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(711, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnBuscar.Size = New System.Drawing.Size(121, 53)
        Me.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.btnBuscar.TabIndex = 271
        Me.btnBuscar.Text = "<b>BUSCAR</b>"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(138, 27)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(119, 23)
        Me.LabelX2.TabIndex = 268
        Me.LabelX2.Text = "Fecha Fin"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(12, 27)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(119, 23)
        Me.LabelX1.TabIndex = 266
        Me.LabelX1.Text = "Fecha Inicio"
        '
        'CbFechaIng
        '
        Me.CbFechaIng.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.CbFechaIng.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CbFechaIng.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbFechaIng.ForeColor = System.Drawing.Color.Black
        Me.CbFechaIng.Location = New System.Drawing.Point(12, 7)
        Me.CbFechaIng.Name = "CbFechaIng"
        Me.CbFechaIng.Size = New System.Drawing.Size(139, 23)
        Me.CbFechaIng.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CbFechaIng.TabIndex = 264
        Me.CbFechaIng.Text = "Fecha de Devolucion"
        '
        'mesajeerror2
        '
        Me.mesajeerror2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.mesajeerror2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mesajeerror2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mesajeerror2.ForeColor = System.Drawing.Color.Black
        Me.mesajeerror2.Location = New System.Drawing.Point(15, 432)
        Me.mesajeerror2.Name = "mesajeerror2"
        Me.mesajeerror2.Size = New System.Drawing.Size(817, 23)
        Me.mesajeerror2.TabIndex = 277
        Me.mesajeerror2.Text = ". ."
        Me.mesajeerror2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dgvlistaDetalle
        '
        Me.dgvlistaDetalle.AllowUserToAddRows = False
        Me.dgvlistaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlistaDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvlistaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlistaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlistaDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvlistaDetalle.EnableHeadersVisualStyles = False
        Me.dgvlistaDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvlistaDetalle.Location = New System.Drawing.Point(15, 267)
        Me.dgvlistaDetalle.Name = "dgvlistaDetalle"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlistaDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvlistaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlistaDetalle.Size = New System.Drawing.Size(817, 159)
        Me.dgvlistaDetalle.TabIndex = 276
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Width = 71
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
        Me.mesajeerror.Location = New System.Drawing.Point(15, 238)
        Me.mesajeerror.Name = "mesajeerror"
        Me.mesajeerror.Size = New System.Drawing.Size(817, 23)
        Me.mesajeerror.TabIndex = 275
        Me.mesajeerror.Text = "LabelX2"
        Me.mesajeerror.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BtnCerrar
        '
        Me.BtnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(654, 462)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(128, 41)
        Me.BtnCerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnCerrar.TabIndex = 282
        Me.BtnCerrar.Text = "&Cerrar"
        Me.BtnCerrar.TextColor = System.Drawing.Color.Black
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(508, 462)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(128, 41)
        Me.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnImprimir.TabIndex = 281
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextColor = System.Drawing.Color.Black
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(358, 462)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(128, 41)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 280
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.TextColor = System.Drawing.Color.Black
        '
        'BtnModificar
        '
        Me.BtnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(205, 462)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(128, 41)
        Me.BtnModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnModificar.TabIndex = 279
        Me.BtnModificar.Text = "&Modificar"
        Me.BtnModificar.TextColor = System.Drawing.Color.Black
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(63, 461)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(121, 41)
        Me.btnNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevo.TabIndex = 278
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextColor = System.Drawing.Color.Black
        '
        'FrmDev_Comp1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 517)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.mesajeerror2)
        Me.Controls.Add(Me.dgvlistaDetalle)
        Me.Controls.Add(Me.mesajeerror)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.TxtDistrito)
        Me.Controls.Add(Me.CboDistrito)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.dtpffin)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.dtpfinic)
        Me.Controls.Add(Me.CbFechaIng)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDev_Comp1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolución de Comprobantes de Pago"
        CType(Me.dtpffin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpfinic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvlistaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents dgvlista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TxtDistrito As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CboDistrito As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpffin As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpfinic As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents CbFechaIng As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents mesajeerror2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgvlistaDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents mesajeerror As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
End Class

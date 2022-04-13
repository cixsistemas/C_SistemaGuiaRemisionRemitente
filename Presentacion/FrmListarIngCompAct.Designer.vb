<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarIngCompAct
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListarIngCompAct))
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.TxtTipo_Comp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtRemitente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtNumero = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.dgvlista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.mesajeerror = New DevComponents.DotNetBar.LabelX()
        Me.btn_Acep = New DevComponents.DotNetBar.ButtonX()
        Me.CboTipoCom = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CboRemitente = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CboNumero = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pboximagen = New System.Windows.Forms.PictureBox()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboximagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'TxtTipo_Comp
        '
        Me.TxtTipo_Comp.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TxtTipo_Comp.Border.Class = "TextBoxBorder"
        Me.TxtTipo_Comp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtTipo_Comp.Enabled = False
        Me.TxtTipo_Comp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtTipo_Comp, True)
        Me.TxtTipo_Comp.Location = New System.Drawing.Point(262, 41)
        Me.TxtTipo_Comp.Name = "TxtTipo_Comp"
        Me.TxtTipo_Comp.Size = New System.Drawing.Size(227, 22)
        Me.TxtTipo_Comp.TabIndex = 259
        '
        'TxtRemitente
        '
        Me.TxtRemitente.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TxtRemitente.Border.Class = "TextBoxBorder"
        Me.TxtRemitente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtRemitente.Enabled = False
        Me.TxtRemitente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtRemitente, True)
        Me.TxtRemitente.Location = New System.Drawing.Point(12, 41)
        Me.TxtRemitente.Name = "TxtRemitente"
        Me.TxtRemitente.Size = New System.Drawing.Size(234, 22)
        Me.TxtRemitente.TabIndex = 257
        '
        'TxtNumero
        '
        Me.TxtNumero.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TxtNumero.Border.Class = "TextBoxBorder"
        Me.TxtNumero.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtNumero.Enabled = False
        Me.TxtNumero.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtNumero, True)
        Me.TxtNumero.Location = New System.Drawing.Point(504, 41)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(83, 22)
        Me.TxtNumero.TabIndex = 261
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(177, Byte), Integer)))
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToDeleteRows = False
        Me.dgvlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlista.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvlista.EnableHeadersVisualStyles = False
        Me.dgvlista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvlista.Location = New System.Drawing.Point(12, 106)
        Me.dgvlista.Name = "dgvlista"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlista.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvlista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlista.Size = New System.Drawing.Size(751, 273)
        Me.dgvlista.TabIndex = 237
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
        Me.mesajeerror.Location = New System.Drawing.Point(12, 385)
        Me.mesajeerror.Name = "mesajeerror"
        Me.mesajeerror.Size = New System.Drawing.Size(751, 23)
        Me.mesajeerror.TabIndex = 254
        Me.mesajeerror.Text = ". ."
        Me.mesajeerror.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btn_Acep
        '
        Me.btn_Acep.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Acep.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btn_Acep.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Acep.Image = CType(resources.GetObject("btn_Acep.Image"), System.Drawing.Image)
        Me.btn_Acep.Location = New System.Drawing.Point(328, 416)
        Me.btn_Acep.Name = "btn_Acep"
        Me.btn_Acep.Size = New System.Drawing.Size(118, 42)
        Me.btn_Acep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Acep.TabIndex = 255
        Me.btn_Acep.Text = "CERRAR"
        '
        'CboTipoCom
        '
        Me.CboTipoCom.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.CboTipoCom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CboTipoCom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoCom.ForeColor = System.Drawing.Color.Black
        Me.CboTipoCom.Location = New System.Drawing.Point(262, 11)
        Me.CboTipoCom.Name = "CboTipoCom"
        Me.CboTipoCom.Size = New System.Drawing.Size(119, 23)
        Me.CboTipoCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboTipoCom.TabIndex = 258
        Me.CboTipoCom.Text = "Tipo de Comp."
        '
        'CboRemitente
        '
        Me.CboRemitente.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.CboRemitente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CboRemitente.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboRemitente.ForeColor = System.Drawing.Color.Black
        Me.CboRemitente.Location = New System.Drawing.Point(12, 11)
        Me.CboRemitente.Name = "CboRemitente"
        Me.CboRemitente.Size = New System.Drawing.Size(119, 23)
        Me.CboRemitente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboRemitente.TabIndex = 256
        Me.CboRemitente.Text = "Empresa"
        '
        'CboNumero
        '
        Me.CboNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.CboNumero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CboNumero.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboNumero.ForeColor = System.Drawing.Color.Black
        Me.CboNumero.Location = New System.Drawing.Point(504, 12)
        Me.CboNumero.Name = "CboNumero"
        Me.CboNumero.Size = New System.Drawing.Size(83, 23)
        Me.CboNumero.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboNumero.TabIndex = 260
        Me.CboNumero.Text = "Serie"
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(631, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnBuscar.Size = New System.Drawing.Size(121, 53)
        Me.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.btnBuscar.TabIndex = 272
        Me.btnBuscar.Text = "<b>BUSCAR</b>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(448, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 13)
        Me.Label2.TabIndex = 274
        Me.Label2.Text = "Presione Barra Espaciadora para seleccionar Registro"
        '
        'pboximagen
        '
        Me.pboximagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pboximagen.ForeColor = System.Drawing.Color.Black
        Me.pboximagen.Image = CType(resources.GetObject("pboximagen.Image"), System.Drawing.Image)
        Me.pboximagen.Location = New System.Drawing.Point(417, 73)
        Me.pboximagen.Name = "pboximagen"
        Me.pboximagen.Size = New System.Drawing.Size(25, 25)
        Me.pboximagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboximagen.TabIndex = 273
        Me.pboximagen.TabStop = False
        '
        'FrmListarIngCompAct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 470)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pboximagen)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.TxtNumero)
        Me.Controls.Add(Me.CboNumero)
        Me.Controls.Add(Me.TxtTipo_Comp)
        Me.Controls.Add(Me.CboTipoCom)
        Me.Controls.Add(Me.TxtRemitente)
        Me.Controls.Add(Me.CboRemitente)
        Me.Controls.Add(Me.btn_Acep)
        Me.Controls.Add(Me.mesajeerror)
        Me.Controls.Add(Me.dgvlista)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListarIngCompAct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Comprobantes Ingresados (ACTIVOS)"
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboximagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents dgvlista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents mesajeerror As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_Acep As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TxtNumero As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CboNumero As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TxtTipo_Comp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CboTipoCom As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TxtRemitente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CboRemitente As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pboximagen As System.Windows.Forms.PictureBox
End Class

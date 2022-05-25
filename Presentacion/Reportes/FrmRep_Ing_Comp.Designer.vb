<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRep_Ing_Comp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRep_Ing_Comp))
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.TxtRemitente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtTipo_Comp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtNumero = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.dtpff = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFecha = New System.Windows.Forms.CheckBox()
        Me.CboRemitente = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CboTipoCom = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CboNumero = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.dgvlista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.mesajeerror = New DevComponents.DotNetBar.LabelX()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'TxtRemitente
        '
        '
        '
        '
        Me.TxtRemitente.Border.Class = "TextBoxBorder"
        Me.TxtRemitente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtRemitente.DisabledBackColor = System.Drawing.Color.White
        Me.TxtRemitente.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtRemitente, True)
        Me.TxtRemitente.Location = New System.Drawing.Point(238, 52)
        Me.TxtRemitente.Name = "TxtRemitente"
        Me.TxtRemitente.Size = New System.Drawing.Size(203, 26)
        Me.TxtRemitente.TabIndex = 198
        '
        'TxtTipo_Comp
        '
        '
        '
        '
        Me.TxtTipo_Comp.Border.Class = "TextBoxBorder"
        Me.TxtTipo_Comp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtTipo_Comp.DisabledBackColor = System.Drawing.Color.White
        Me.TxtTipo_Comp.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtTipo_Comp, True)
        Me.TxtTipo_Comp.Location = New System.Drawing.Point(457, 52)
        Me.TxtTipo_Comp.Name = "TxtTipo_Comp"
        Me.TxtTipo_Comp.Size = New System.Drawing.Size(182, 26)
        Me.TxtTipo_Comp.TabIndex = 253
        '
        'TxtNumero
        '
        '
        '
        '
        Me.TxtNumero.Border.Class = "TextBoxBorder"
        Me.TxtNumero.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtNumero.DisabledBackColor = System.Drawing.Color.White
        Me.TxtNumero.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtNumero, True)
        Me.TxtNumero.Location = New System.Drawing.Point(654, 53)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(83, 26)
        Me.TxtNumero.TabIndex = 263
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(177, Byte), Integer)))
        '
        'dtpff
        '
        Me.dtpff.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.dtpff.Enabled = False
        Me.dtpff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpff.ForeColor = System.Drawing.Color.Black
        Me.dtpff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpff.Location = New System.Drawing.Point(118, 53)
        Me.dtpff.Name = "dtpff"
        Me.dtpff.Size = New System.Drawing.Size(99, 24)
        Me.dtpff.TabIndex = 194
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(115, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 196
        Me.Label2.Text = "Fecha fin"
        '
        'dtpfin
        '
        Me.dtpfin.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.dtpfin.Enabled = False
        Me.dtpfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfin.ForeColor = System.Drawing.Color.Black
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(12, 53)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(99, 24)
        Me.dtpfin.TabIndex = 193
        Me.dtpfin.Value = New Date(2016, 12, 26, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 195
        Me.Label1.Text = "Fecha inicio"
        '
        'cbFecha
        '
        Me.cbFecha.AutoSize = True
        Me.cbFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFecha.ForeColor = System.Drawing.Color.Black
        Me.cbFecha.Location = New System.Drawing.Point(12, 12)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(144, 22)
        Me.cbFecha.TabIndex = 192
        Me.cbFecha.Text = "Fecha de Ingreso"
        Me.cbFecha.UseVisualStyleBackColor = False
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
        Me.CboRemitente.Location = New System.Drawing.Point(238, 22)
        Me.CboRemitente.Name = "CboRemitente"
        Me.CboRemitente.Size = New System.Drawing.Size(119, 23)
        Me.CboRemitente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboRemitente.TabIndex = 197
        Me.CboRemitente.Text = "Remitente"
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
        Me.CboTipoCom.Location = New System.Drawing.Point(457, 22)
        Me.CboTipoCom.Name = "CboTipoCom"
        Me.CboTipoCom.Size = New System.Drawing.Size(154, 23)
        Me.CboTipoCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboTipoCom.TabIndex = 252
        Me.CboTipoCom.Text = "Comprobante de Pago"
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
        Me.CboNumero.Location = New System.Drawing.Point(654, 24)
        Me.CboNumero.Name = "CboNumero"
        Me.CboNumero.Size = New System.Drawing.Size(83, 23)
        Me.CboNumero.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboNumero.TabIndex = 262
        Me.CboNumero.Text = "Serie"
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(754, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnBuscar.Size = New System.Drawing.Size(121, 53)
        Me.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.btnBuscar.TabIndex = 264
        Me.btnBuscar.Text = "<b>BUSCAR</b>"
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToOrderColumns = True
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
        Me.dgvlista.Location = New System.Drawing.Point(15, 93)
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
        Me.dgvlista.Size = New System.Drawing.Size(853, 268)
        Me.dgvlista.TabIndex = 265
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(365, 406)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(128, 47)
        Me.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnImprimir.TabIndex = 267
        Me.btnImprimir.Text = "<b>&Reporte</b>"
        Me.btnImprimir.TextColor = System.Drawing.Color.Black
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
        Me.mesajeerror.Location = New System.Drawing.Point(15, 373)
        Me.mesajeerror.Name = "mesajeerror"
        Me.mesajeerror.Size = New System.Drawing.Size(853, 23)
        Me.mesajeerror.TabIndex = 266
        Me.mesajeerror.Text = "LabelX2"
        Me.mesajeerror.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'FrmRep_Ing_Comp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 458)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.mesajeerror)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.TxtNumero)
        Me.Controls.Add(Me.CboNumero)
        Me.Controls.Add(Me.TxtTipo_Comp)
        Me.Controls.Add(Me.CboTipoCom)
        Me.Controls.Add(Me.TxtRemitente)
        Me.Controls.Add(Me.CboRemitente)
        Me.Controls.Add(Me.dtpff)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpfin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbFecha)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmRep_Ing_Comp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Ingreso de Comprobantes"
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents dtpff As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbFecha As System.Windows.Forms.CheckBox
    Friend WithEvents TxtRemitente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CboRemitente As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TxtTipo_Comp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CboTipoCom As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TxtNumero As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CboNumero As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvlista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mesajeerror As DevComponents.DotNetBar.LabelX
End Class

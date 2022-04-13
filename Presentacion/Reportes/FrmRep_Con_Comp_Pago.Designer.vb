<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRep_Con_Comp_Pago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRep_Con_Comp_Pago))
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.TxtTipo_Comp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtRemitente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtComisionista = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.dtpff = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFecha = New System.Windows.Forms.CheckBox()
        Me.CboTipoCom = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CboRemitente = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CboComis = New DevComponents.DotNetBar.Controls.CheckBoxX()
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
        Me.TxtTipo_Comp.Location = New System.Drawing.Point(229, 48)
        Me.TxtTipo_Comp.Name = "TxtTipo_Comp"
        Me.TxtTipo_Comp.Size = New System.Drawing.Size(182, 22)
        Me.TxtTipo_Comp.TabIndex = 255
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
        Me.TxtRemitente.Location = New System.Drawing.Point(426, 48)
        Me.TxtRemitente.Name = "TxtRemitente"
        Me.TxtRemitente.Size = New System.Drawing.Size(203, 22)
        Me.TxtRemitente.TabIndex = 257
        '
        'TxtComisionista
        '
        Me.TxtComisionista.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TxtComisionista.Border.Class = "TextBoxBorder"
        Me.TxtComisionista.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtComisionista.Enabled = False
        Me.TxtComisionista.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtComisionista, True)
        Me.TxtComisionista.Location = New System.Drawing.Point(648, 48)
        Me.TxtComisionista.Name = "TxtComisionista"
        Me.TxtComisionista.Size = New System.Drawing.Size(164, 22)
        Me.TxtComisionista.TabIndex = 265
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
        Me.dtpff.Location = New System.Drawing.Point(121, 53)
        Me.dtpff.Name = "dtpff"
        Me.dtpff.Size = New System.Drawing.Size(99, 21)
        Me.dtpff.TabIndex = 199
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(118, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "Fecha fin"
        '
        'dtpfin
        '
        Me.dtpfin.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.dtpfin.Enabled = False
        Me.dtpfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfin.ForeColor = System.Drawing.Color.Black
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(15, 53)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(99, 21)
        Me.dtpfin.TabIndex = 198
        Me.dtpfin.Value = New Date(2016, 12, 26, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 200
        Me.Label1.Text = "Fecha inicio"
        '
        'cbFecha
        '
        Me.cbFecha.AutoSize = True
        Me.cbFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFecha.ForeColor = System.Drawing.Color.Black
        Me.cbFecha.Location = New System.Drawing.Point(15, 12)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(121, 19)
        Me.cbFecha.TabIndex = 197
        Me.cbFecha.Text = "Fecha de Ingreso"
        Me.cbFecha.UseVisualStyleBackColor = False
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
        Me.CboTipoCom.Location = New System.Drawing.Point(229, 18)
        Me.CboTipoCom.Name = "CboTipoCom"
        Me.CboTipoCom.Size = New System.Drawing.Size(169, 23)
        Me.CboTipoCom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboTipoCom.TabIndex = 254
        Me.CboTipoCom.Text = "Comprobante de Pago"
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
        Me.CboRemitente.Location = New System.Drawing.Point(426, 18)
        Me.CboRemitente.Name = "CboRemitente"
        Me.CboRemitente.Size = New System.Drawing.Size(119, 23)
        Me.CboRemitente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboRemitente.TabIndex = 256
        Me.CboRemitente.Text = "Remitente"
        '
        'CboComis
        '
        Me.CboComis.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.CboComis.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CboComis.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboComis.ForeColor = System.Drawing.Color.Black
        Me.CboComis.Location = New System.Drawing.Point(648, 18)
        Me.CboComis.Name = "CboComis"
        Me.CboComis.Size = New System.Drawing.Size(119, 23)
        Me.CboComis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboComis.TabIndex = 264
        Me.CboComis.Text = "Comisionista"
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(859, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnBuscar.Size = New System.Drawing.Size(121, 53)
        Me.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.btnBuscar.TabIndex = 266
        Me.btnBuscar.Text = "<b>BUSCAR</b>"
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToOrderColumns = True
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlista.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvlista.EnableHeadersVisualStyles = False
        Me.dgvlista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvlista.Location = New System.Drawing.Point(11, 89)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlista.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvlista.RowHeadersVisible = False
        Me.dgvlista.Size = New System.Drawing.Size(976, 327)
        Me.dgvlista.TabIndex = 282
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(430, 458)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(128, 47)
        Me.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnImprimir.TabIndex = 285
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
        Me.mesajeerror.Location = New System.Drawing.Point(14, 426)
        Me.mesajeerror.Name = "mesajeerror"
        Me.mesajeerror.Size = New System.Drawing.Size(973, 23)
        Me.mesajeerror.TabIndex = 284
        Me.mesajeerror.Text = "LabelX2"
        Me.mesajeerror.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'FrmRep_Con_Comp_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 510)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.mesajeerror)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.TxtComisionista)
        Me.Controls.Add(Me.CboComis)
        Me.Controls.Add(Me.TxtRemitente)
        Me.Controls.Add(Me.CboRemitente)
        Me.Controls.Add(Me.TxtTipo_Comp)
        Me.Controls.Add(Me.CboTipoCom)
        Me.Controls.Add(Me.dtpff)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpfin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbFecha)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmRep_Con_Comp_Pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte  de Control de Comprobantes de Pago"
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
    Friend WithEvents TxtTipo_Comp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CboTipoCom As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TxtRemitente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CboRemitente As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TxtComisionista As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CboComis As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvlista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mesajeerror As DevComponents.DotNetBar.LabelX
End Class

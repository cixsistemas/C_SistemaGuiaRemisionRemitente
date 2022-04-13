<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepCont_Gui_FT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepCont_Gui_FT))
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.txtRemitente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtnro_Guia = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbNro_Guia = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.cbRemitente = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnConsultar = New DevComponents.DotNetBar.ButtonX()
        Me.dtpff = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFecha = New System.Windows.Forms.CheckBox()
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
        'txtRemitente
        '
        Me.txtRemitente.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtRemitente.Border.Class = "TextBoxBorder"
        Me.txtRemitente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRemitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemitente.Enabled = False
        Me.txtRemitente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtRemitente, True)
        Me.txtRemitente.Location = New System.Drawing.Point(335, 52)
        Me.txtRemitente.MaxLength = 100
        Me.txtRemitente.Name = "txtRemitente"
        Me.txtRemitente.Size = New System.Drawing.Size(199, 22)
        Me.txtRemitente.TabIndex = 188
        '
        'txtnro_Guia
        '
        Me.txtnro_Guia.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtnro_Guia.Border.Class = "TextBoxBorder"
        Me.txtnro_Guia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnro_Guia.Enabled = False
        Me.txtnro_Guia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtnro_Guia, True)
        Me.txtnro_Guia.Location = New System.Drawing.Point(233, 52)
        Me.txtnro_Guia.MaxLength = 7
        Me.txtnro_Guia.Name = "txtnro_Guia"
        Me.txtnro_Guia.Size = New System.Drawing.Size(83, 22)
        Me.txtnro_Guia.TabIndex = 192
        '
        'cbNro_Guia
        '
        Me.cbNro_Guia.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.cbNro_Guia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbNro_Guia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNro_Guia.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.cbNro_Guia, True)
        Me.cbNro_Guia.Location = New System.Drawing.Point(233, 8)
        Me.cbNro_Guia.Name = "cbNro_Guia"
        Me.cbNro_Guia.Size = New System.Drawing.Size(83, 23)
        Me.cbNro_Guia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbNro_Guia.TabIndex = 186
        Me.cbNro_Guia.Text = "Nro. Guia"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(177, Byte), Integer)))
        '
        'cbRemitente
        '
        Me.cbRemitente.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.cbRemitente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbRemitente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRemitente.ForeColor = System.Drawing.Color.Black
        Me.cbRemitente.Location = New System.Drawing.Point(337, 8)
        Me.cbRemitente.Name = "cbRemitente"
        Me.cbRemitente.Size = New System.Drawing.Size(100, 23)
        Me.cbRemitente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbRemitente.TabIndex = 187
        Me.cbRemitente.Text = "Remitente"
        '
        'btnConsultar
        '
        Me.btnConsultar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnConsultar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.Location = New System.Drawing.Point(581, 21)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnConsultar.Size = New System.Drawing.Size(121, 53)
        Me.btnConsultar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.btnConsultar.TabIndex = 189
        Me.btnConsultar.Text = "<b>BUSCAR</b>"
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
        Me.dtpff.Size = New System.Drawing.Size(99, 21)
        Me.dtpff.TabIndex = 185
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(115, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 191
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
        Me.dtpfin.Size = New System.Drawing.Size(99, 21)
        Me.dtpfin.TabIndex = 184
        Me.dtpfin.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 190
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
        Me.cbFecha.Size = New System.Drawing.Size(125, 19)
        Me.cbFecha.TabIndex = 183
        Me.cbFecha.Text = "Fecha de Emision"
        Me.cbFecha.UseVisualStyleBackColor = False
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
        Me.dgvlista.Location = New System.Drawing.Point(6, 98)
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
        Me.dgvlista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlista.Size = New System.Drawing.Size(690, 240)
        Me.dgvlista.TabIndex = 193
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(278, 377)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(128, 47)
        Me.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnImprimir.TabIndex = 195
        Me.btnImprimir.Text = "&Reporte"
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
        Me.mesajeerror.Location = New System.Drawing.Point(6, 344)
        Me.mesajeerror.Name = "mesajeerror"
        Me.mesajeerror.Size = New System.Drawing.Size(690, 23)
        Me.mesajeerror.TabIndex = 194
        Me.mesajeerror.Text = "LabelX2"
        Me.mesajeerror.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'FrmRepCont_Gui_FT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 436)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.mesajeerror)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.txtRemitente)
        Me.Controls.Add(Me.cbRemitente)
        Me.Controls.Add(Me.txtnro_Guia)
        Me.Controls.Add(Me.cbNro_Guia)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dtpff)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpfin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbFecha)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmRepCont_Gui_FT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas Enviadas"
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents txtRemitente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbRemitente As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtnro_Guia As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbNro_Guia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btnConsultar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dtpff As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbFecha As System.Windows.Forms.CheckBox
    Friend WithEvents dgvlista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mesajeerror As DevComponents.DotNetBar.LabelX
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarTransportista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListarTransportista))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.txtbusca = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvlista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.mesajeerror = New DevComponents.DotNetBar.LabelX()
        Me.btn_Acep = New DevComponents.DotNetBar.ButtonX()
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.LBF2 = New DevComponents.DotNetBar.LabelX()
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
        Me.txtbusca.Location = New System.Drawing.Point(260, 10)
        Me.txtbusca.Name = "txtbusca"
        Me.txtbusca.Size = New System.Drawing.Size(292, 23)
        Me.txtbusca.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 16)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Ingrese Transportista a buscar:"
        '
        'dgvlista
        '
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
        Me.dgvlista.Location = New System.Drawing.Point(8, 54)
        Me.dgvlista.Name = "dgvlista"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlista.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvlista.Size = New System.Drawing.Size(544, 273)
        Me.dgvlista.TabIndex = 118
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
        Me.mesajeerror.Location = New System.Drawing.Point(8, 343)
        Me.mesajeerror.Name = "mesajeerror"
        Me.mesajeerror.Size = New System.Drawing.Size(544, 23)
        Me.mesajeerror.TabIndex = 119
        Me.mesajeerror.Text = "LabelX2"
        Me.mesajeerror.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btn_Acep
        '
        Me.btn_Acep.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Acep.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btn_Acep.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Acep.Image = CType(resources.GetObject("btn_Acep.Image"), System.Drawing.Image)
        Me.btn_Acep.Location = New System.Drawing.Point(147, 381)
        Me.btn_Acep.Name = "btn_Acep"
        Me.btn_Acep.Size = New System.Drawing.Size(107, 40)
        Me.btn_Acep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Acep.TabIndex = 120
        Me.btn_Acep.Text = "Aceptar"
        Me.btn_Acep.TextColor = System.Drawing.Color.Black
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(288, 381)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(121, 41)
        Me.btnNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevo.TabIndex = 121
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextColor = System.Drawing.Color.Black
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
        Me.LBF2.Location = New System.Drawing.Point(223, 9)
        Me.LBF2.Name = "LBF2"
        Me.LBF2.Size = New System.Drawing.Size(33, 23)
        Me.LBF2.TabIndex = 225
        Me.LBF2.Text = " [F2]"
        Me.LBF2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'FrmListarTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 436)
        Me.Controls.Add(Me.LBF2)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btn_Acep)
        Me.Controls.Add(Me.mesajeerror)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.txtbusca)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmListarTransportista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar Transportista"
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbusca As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dgvlista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents mesajeerror As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Acep As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LBF2 As DevComponents.DotNetBar.LabelX
End Class

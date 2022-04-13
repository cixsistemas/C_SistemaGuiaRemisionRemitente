<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpcImpPes_Med1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpcImpPes_Med1))
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RbZelu = New System.Windows.Forms.RadioButton()
        Me.RbBantemar = New System.Windows.Forms.RadioButton()
        Me.RbMolinos = New System.Windows.Forms.RadioButton()
        Me.RBConsorcio = New System.Windows.Forms.RadioButton()
        Me.BtnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(177, Byte), Integer)))
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.GroupPanel1.Controls.Add(Me.RbZelu)
        Me.GroupPanel1.Controls.Add(Me.RbBantemar)
        Me.GroupPanel1.Controls.Add(Me.RbMolinos)
        Me.GroupPanel1.Controls.Add(Me.RBConsorcio)
        Me.GroupPanel1.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 22)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(350, 171)
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
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "Seleccione Opcion a Imprimir"
        '
        'RbZelu
        '
        Me.RbZelu.AutoSize = True
        Me.RbZelu.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RbZelu.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbZelu.ForeColor = System.Drawing.Color.Black
        Me.RbZelu.Location = New System.Drawing.Point(7, 83)
        Me.RbZelu.Name = "RbZelu"
        Me.RbZelu.Size = New System.Drawing.Size(60, 24)
        Me.RbZelu.TabIndex = 163
        Me.RbZelu.TabStop = True
        Me.RbZelu.Text = "Zelu"
        Me.RbZelu.UseVisualStyleBackColor = False
        '
        'RbBantemar
        '
        Me.RbBantemar.AutoSize = True
        Me.RbBantemar.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RbBantemar.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbBantemar.ForeColor = System.Drawing.Color.Black
        Me.RbBantemar.Location = New System.Drawing.Point(243, 40)
        Me.RbBantemar.Name = "RbBantemar"
        Me.RbBantemar.Size = New System.Drawing.Size(99, 24)
        Me.RbBantemar.TabIndex = 162
        Me.RbBantemar.TabStop = True
        Me.RbBantemar.Text = "Bantemar"
        Me.RbBantemar.UseVisualStyleBackColor = False
        '
        'RbMolinos
        '
        Me.RbMolinos.AutoSize = True
        Me.RbMolinos.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RbMolinos.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbMolinos.ForeColor = System.Drawing.Color.Black
        Me.RbMolinos.Location = New System.Drawing.Point(134, 40)
        Me.RbMolinos.Name = "RbMolinos"
        Me.RbMolinos.Size = New System.Drawing.Size(87, 24)
        Me.RbMolinos.TabIndex = 159
        Me.RbMolinos.TabStop = True
        Me.RbMolinos.Text = "Molinos"
        Me.RbMolinos.UseVisualStyleBackColor = False
        '
        'RBConsorcio
        '
        Me.RBConsorcio.AutoSize = True
        Me.RBConsorcio.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RBConsorcio.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBConsorcio.ForeColor = System.Drawing.Color.Black
        Me.RBConsorcio.Location = New System.Drawing.Point(7, 38)
        Me.RBConsorcio.Name = "RBConsorcio"
        Me.RBConsorcio.Size = New System.Drawing.Size(102, 24)
        Me.RBConsorcio.TabIndex = 146
        Me.RBConsorcio.TabStop = True
        Me.RBConsorcio.Text = "Consorcio"
        Me.RBConsorcio.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Image = CType(resources.GetObject("BtnAceptar.Image"), System.Drawing.Image)
        Me.BtnAceptar.Location = New System.Drawing.Point(119, 214)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(135, 48)
        Me.BtnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnAceptar.TabIndex = 213
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.TextColor = System.Drawing.Color.Black
        '
        'FrmOpcImpPes_Med1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 287)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmOpcImpPes_Med1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones a Imprimir (Pesos y Medidas)"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RbZelu As System.Windows.Forms.RadioButton
    Friend WithEvents RbBantemar As System.Windows.Forms.RadioButton
    Friend WithEvents RbMolinos As System.Windows.Forms.RadioButton
    Friend WithEvents RBConsorcio As System.Windows.Forms.RadioButton
    Friend WithEvents BtnAceptar As DevComponents.DotNetBar.ButtonX
End Class

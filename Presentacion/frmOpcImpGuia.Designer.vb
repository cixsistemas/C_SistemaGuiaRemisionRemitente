<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcImpGuia
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpcImpGuia))
        Me.cblpll = New System.Windows.Forms.CheckedListBox()
        Me.cblps = New System.Windows.Forms.CheckedListBox()
        Me.rbpll = New System.Windows.Forms.RadioButton()
        Me.rbps = New System.Windows.Forms.RadioButton()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rbsunat = New System.Windows.Forms.RadioButton()
        Me.rbemisor = New System.Windows.Forms.RadioButton()
        Me.rbdestino = New System.Windows.Forms.RadioButton()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RbMolino = New System.Windows.Forms.RadioButton()
        Me.RbBantemar = New System.Windows.Forms.RadioButton()
        Me.RbMagllogri = New System.Windows.Forms.RadioButton()
        Me.RBAng = New System.Windows.Forms.RadioButton()
        Me.RBang2 = New System.Windows.Forms.RadioButton()
        Me.Aceptarr = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cblpll
        '
        Me.cblpll.FormattingEnabled = True
        Me.cblpll.Items.AddRange(New Object() {"Distrito", "Provincia", "Departamento"})
        Me.cblpll.Location = New System.Drawing.Point(222, 28)
        Me.cblpll.Name = "cblpll"
        Me.cblpll.Size = New System.Drawing.Size(172, 64)
        Me.cblpll.TabIndex = 7
        '
        'cblps
        '
        Me.cblps.FormattingEnabled = True
        Me.cblps.Items.AddRange(New Object() {"Distrito", "Provincia", "Departamento"})
        Me.cblps.Location = New System.Drawing.Point(14, 29)
        Me.cblps.Name = "cblps"
        Me.cblps.Size = New System.Drawing.Size(174, 64)
        Me.cblps.TabIndex = 6
        '
        'rbpll
        '
        Me.rbpll.AutoSize = True
        Me.rbpll.Location = New System.Drawing.Point(222, 5)
        Me.rbpll.Name = "rbpll"
        Me.rbpll.Size = New System.Drawing.Size(172, 17)
        Me.rbpll.TabIndex = 5
        Me.rbpll.TabStop = True
        Me.rbpll.Text = "Seleccione pto. llegada a omitir"
        Me.rbpll.UseVisualStyleBackColor = True
        '
        'rbps
        '
        Me.rbps.AutoSize = True
        Me.rbps.Location = New System.Drawing.Point(13, 5)
        Me.rbps.Name = "rbps"
        Me.rbps.Size = New System.Drawing.Size(165, 17)
        Me.rbps.TabIndex = 4
        Me.rbps.TabStop = True
        Me.rbps.Text = "Seleccione pto. salida a omitir"
        Me.rbps.UseVisualStyleBackColor = True
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.rbsunat)
        Me.GroupPanel1.Controls.Add(Me.rbemisor)
        Me.GroupPanel1.Controls.Add(Me.rbdestino)
        Me.GroupPanel1.Location = New System.Drawing.Point(349, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(94, 95)
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
        Me.GroupPanel1.TabIndex = 8
        Me.GroupPanel1.Text = "Opciones"
        Me.GroupPanel1.Visible = False
        '
        'rbsunat
        '
        Me.rbsunat.AutoSize = True
        Me.rbsunat.Checked = True
        Me.rbsunat.Location = New System.Drawing.Point(8, 52)
        Me.rbsunat.Name = "rbsunat"
        Me.rbsunat.Size = New System.Drawing.Size(62, 17)
        Me.rbsunat.TabIndex = 13
        Me.rbsunat.TabStop = True
        Me.rbsunat.Tag = "SUNAT"
        Me.rbsunat.Text = "SUNAT"
        Me.rbsunat.UseVisualStyleBackColor = True
        '
        'rbemisor
        '
        Me.rbemisor.AutoSize = True
        Me.rbemisor.Location = New System.Drawing.Point(7, 29)
        Me.rbemisor.Name = "rbemisor"
        Me.rbemisor.Size = New System.Drawing.Size(73, 17)
        Me.rbemisor.TabIndex = 12
        Me.rbemisor.Tag = "REMITENTE"
        Me.rbemisor.Text = "Remitente"
        Me.rbemisor.UseVisualStyleBackColor = True
        '
        'rbdestino
        '
        Me.rbdestino.AutoSize = True
        Me.rbdestino.Location = New System.Drawing.Point(7, 6)
        Me.rbdestino.Name = "rbdestino"
        Me.rbdestino.Size = New System.Drawing.Size(81, 17)
        Me.rbdestino.TabIndex = 11
        Me.rbdestino.Tag = "DESTINATARIO"
        Me.rbdestino.Text = "Destinatario"
        Me.rbdestino.UseVisualStyleBackColor = True
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.ControlLight
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.GroupPanel2.Controls.Add(Me.RbMolino)
        Me.GroupPanel2.Controls.Add(Me.RbBantemar)
        Me.GroupPanel2.Controls.Add(Me.RbMagllogri)
        Me.GroupPanel2.Controls.Add(Me.RBAng)
        Me.GroupPanel2.Controls.Add(Me.RBang2)
        Me.GroupPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(18, 107)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(380, 179)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 9
        Me.GroupPanel2.Text = "Seleccione Opcion a Imprimir"
        '
        'RbMolino
        '
        Me.RbMolino.AutoSize = True
        Me.RbMolino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbMolino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RbMolino.Location = New System.Drawing.Point(3, 47)
        Me.RbMolino.Name = "RbMolino"
        Me.RbMolino.Size = New System.Drawing.Size(80, 20)
        Me.RbMolino.TabIndex = 162
        Me.RbMolino.TabStop = True
        Me.RbMolino.Text = "Molinos"
        Me.RbMolino.UseVisualStyleBackColor = True
        '
        'RbBantemar
        '
        Me.RbBantemar.AutoSize = True
        Me.RbBantemar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbBantemar.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RbBantemar.Location = New System.Drawing.Point(4, 79)
        Me.RbBantemar.Name = "RbBantemar"
        Me.RbBantemar.Size = New System.Drawing.Size(92, 20)
        Me.RbBantemar.TabIndex = 161
        Me.RbBantemar.TabStop = True
        Me.RbBantemar.Text = "Bantemar"
        Me.RbBantemar.UseVisualStyleBackColor = True
        '
        'RbMagllogri
        '
        Me.RbMagllogri.AutoSize = True
        Me.RbMagllogri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbMagllogri.ForeColor = System.Drawing.Color.Black
        Me.RbMagllogri.Location = New System.Drawing.Point(4, 114)
        Me.RbMagllogri.Name = "RbMagllogri"
        Me.RbMagllogri.Size = New System.Drawing.Size(56, 20)
        Me.RbMagllogri.TabIndex = 158
        Me.RbMagllogri.TabStop = True
        Me.RbMagllogri.Text = "Zelu"
        Me.RbMagllogri.UseVisualStyleBackColor = True
        '
        'RBAng
        '
        Me.RBAng.AutoSize = True
        Me.RBAng.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBAng.ForeColor = System.Drawing.Color.Red
        Me.RBAng.Location = New System.Drawing.Point(4, 14)
        Me.RBAng.Name = "RBAng"
        Me.RBAng.Size = New System.Drawing.Size(96, 20)
        Me.RBAng.TabIndex = 146
        Me.RBAng.TabStop = True
        Me.RBAng.Text = "Consorcio"
        Me.RBAng.UseVisualStyleBackColor = True
        '
        'RBang2
        '
        Me.RBang2.AutoSize = True
        Me.RBang2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBang2.ForeColor = System.Drawing.Color.Red
        Me.RBang2.Location = New System.Drawing.Point(125, 14)
        Me.RBang2.Name = "RBang2"
        Me.RBang2.Size = New System.Drawing.Size(108, 20)
        Me.RBang2.TabIndex = 149
        Me.RBang2.TabStop = True
        Me.RBang2.Text = "Consorcio 2"
        Me.RBang2.UseVisualStyleBackColor = True
        '
        'Aceptarr
        '
        Me.Aceptarr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Aceptarr.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Aceptarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptarr.Location = New System.Drawing.Point(146, 292)
        Me.Aceptarr.Name = "Aceptarr"
        Me.Aceptarr.Size = New System.Drawing.Size(121, 47)
        Me.Aceptarr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Aceptarr.TabIndex = 10
        Me.Aceptarr.Text = "Aceptar"
        '
        'frmOpcImpGuia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(411, 348)
        Me.Controls.Add(Me.Aceptarr)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.cblpll)
        Me.Controls.Add(Me.cblps)
        Me.Controls.Add(Me.rbpll)
        Me.Controls.Add(Me.rbps)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmOpcImpGuia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones a Imprimir Guia de Remision"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cblpll As System.Windows.Forms.CheckedListBox
    Friend WithEvents cblps As System.Windows.Forms.CheckedListBox
    Friend WithEvents rbpll As System.Windows.Forms.RadioButton
    Friend WithEvents rbps As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbsunat As System.Windows.Forms.RadioButton
    Friend WithEvents rbemisor As System.Windows.Forms.RadioButton
    Friend WithEvents rbdestino As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RBAng As System.Windows.Forms.RadioButton
    Friend WithEvents RBang2 As System.Windows.Forms.RadioButton
    Friend WithEvents Aceptarr As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RbMagllogri As System.Windows.Forms.RadioButton
    Friend WithEvents RbBantemar As System.Windows.Forms.RadioButton
    Friend WithEvents RbMolino As System.Windows.Forms.RadioButton
End Class

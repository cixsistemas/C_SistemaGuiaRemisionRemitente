<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acercarde
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acercarde))
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.pboximagen = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.radialMenu2 = New DevComponents.DotNetBar.RadialMenu()
        Me.RadialMenuItem1 = New DevComponents.DotNetBar.RadialMenuItem()
        Me.btn_Acep = New DevComponents.DotNetBar.ButtonX()
        CType(Me.pboximagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        'pboximagen
        '
        Me.pboximagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pboximagen.ForeColor = System.Drawing.Color.Black
        Me.pboximagen.Image = CType(resources.GetObject("pboximagen.Image"), System.Drawing.Image)
        Me.pboximagen.Location = New System.Drawing.Point(12, 12)
        Me.pboximagen.Name = "pboximagen"
        Me.pboximagen.Size = New System.Drawing.Size(371, 160)
        Me.pboximagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboximagen.TabIndex = 83
        Me.pboximagen.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 136)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guía de Remisión-Remitente (Version 1.0)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Cel. 950567068"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(18, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 15)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Abraham Neria C."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 15)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Analisis y Desarrollo por:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(12, 322)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(377, 10)
        Me.Panel2.TabIndex = 86
        '
        'radialMenu2
        '
        Me.radialMenu2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.radialMenu2.Diameter = 200
        Me.radialMenu2.ForeColor = System.Drawing.Color.Black
        Me.radialMenu2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.RadialMenuItem1})
        Me.radialMenu2.Location = New System.Drawing.Point(29, 338)
        Me.radialMenu2.Name = "radialMenu2"
        Me.radialMenu2.Size = New System.Drawing.Size(28, 28)
        Me.radialMenu2.TabIndex = 87
        Me.radialMenu2.Text = "radialMenu2"
        Me.radialMenu2.Visible = False
        '
        'RadialMenuItem1
        '
        Me.RadialMenuItem1.Name = "RadialMenuItem1"
        Me.RadialMenuItem1.Text = "Item 1"
        '
        'btn_Acep
        '
        Me.btn_Acep.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Acep.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btn_Acep.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Acep.Image = CType(resources.GetObject("btn_Acep.Image"), System.Drawing.Image)
        Me.btn_Acep.Location = New System.Drawing.Point(248, 340)
        Me.btn_Acep.Name = "btn_Acep"
        Me.btn_Acep.Size = New System.Drawing.Size(131, 53)
        Me.btn_Acep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Acep.TabIndex = 133
        Me.btn_Acep.Text = "Aceptar"
        Me.btn_Acep.TextColor = System.Drawing.Color.Black
        '
        'Acercarde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 415)
        Me.Controls.Add(Me.btn_Acep)
        Me.Controls.Add(Me.radialMenu2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pboximagen)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Acercarde"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acerca de "
        CType(Me.pboximagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents pboximagen As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents radialMenu2 As DevComponents.DotNetBar.RadialMenu
    Friend WithEvents RadialMenuItem1 As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents btn_Acep As DevComponents.DotNetBar.ButtonX
End Class

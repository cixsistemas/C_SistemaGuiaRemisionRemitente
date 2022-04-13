<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChofer2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChofer2))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.txtbusca = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.gbob = New System.Windows.Forms.GroupBox()
        Me.LBF4 = New DevComponents.DotNetBar.LabelX()
        Me.LBF3 = New DevComponents.DotNetBar.LabelX()
        Me.LBF2 = New DevComponents.DotNetBar.LabelX()
        Me.RbTodos = New System.Windows.Forms.RadioButton()
        Me.rbbrevete = New System.Windows.Forms.RadioButton()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.BtnCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnModificar = New DevComponents.DotNetBar.ButtonX()
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.mesajeerror = New DevComponents.DotNetBar.LabelX()
        Me.dgvlista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.gbob.SuspendLayout()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.txtbusca.Location = New System.Drawing.Point(88, 46)
        Me.txtbusca.Name = "txtbusca"
        Me.txtbusca.Size = New System.Drawing.Size(571, 23)
        Me.txtbusca.TabIndex = 0
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(177, Byte), Integer)))
        '
        'gbob
        '
        Me.gbob.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.gbob.Controls.Add(Me.LBF4)
        Me.gbob.Controls.Add(Me.LBF3)
        Me.gbob.Controls.Add(Me.LBF2)
        Me.gbob.Controls.Add(Me.txtbusca)
        Me.gbob.Controls.Add(Me.RbTodos)
        Me.gbob.Controls.Add(Me.rbbrevete)
        Me.gbob.Controls.Add(Me.rbNombre)
        Me.gbob.Controls.Add(Me.LabelX2)
        Me.gbob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbob.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbob.ForeColor = System.Drawing.Color.Black
        Me.gbob.Location = New System.Drawing.Point(12, 7)
        Me.gbob.Name = "gbob"
        Me.gbob.Size = New System.Drawing.Size(682, 83)
        Me.gbob.TabIndex = 3
        Me.gbob.TabStop = False
        Me.gbob.Text = "Seleccione opciones de busqueda:"
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
        Me.LBF4.Location = New System.Drawing.Point(410, 19)
        Me.LBF4.Name = "LBF4"
        Me.LBF4.Size = New System.Drawing.Size(33, 23)
        Me.LBF4.TabIndex = 220
        Me.LBF4.Text = " [F4]"
        Me.LBF4.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.LBF3.Location = New System.Drawing.Point(286, 19)
        Me.LBF3.Name = "LBF3"
        Me.LBF3.Size = New System.Drawing.Size(33, 23)
        Me.LBF3.TabIndex = 219
        Me.LBF3.Text = " [F3]"
        Me.LBF3.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.LBF2.Location = New System.Drawing.Point(166, 19)
        Me.LBF2.Name = "LBF2"
        Me.LBF2.Size = New System.Drawing.Size(33, 23)
        Me.LBF2.TabIndex = 218
        Me.LBF2.Text = " [F2]"
        Me.LBF2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'RbTodos
        '
        Me.RbTodos.AutoSize = True
        Me.RbTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RbTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbTodos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodos.ForeColor = System.Drawing.Color.Black
        Me.RbTodos.Location = New System.Drawing.Point(341, 21)
        Me.RbTodos.Name = "RbTodos"
        Me.RbTodos.Size = New System.Drawing.Size(63, 21)
        Me.RbTodos.TabIndex = 6
        Me.RbTodos.TabStop = True
        Me.RbTodos.Tag = "Todos"
        Me.RbTodos.Text = "Todos"
        Me.RbTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbTodos.UseVisualStyleBackColor = False
        '
        'rbbrevete
        '
        Me.rbbrevete.AutoSize = True
        Me.rbbrevete.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.rbbrevete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbbrevete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbbrevete.ForeColor = System.Drawing.Color.Black
        Me.rbbrevete.Location = New System.Drawing.Point(212, 20)
        Me.rbbrevete.Name = "rbbrevete"
        Me.rbbrevete.Size = New System.Drawing.Size(71, 21)
        Me.rbbrevete.TabIndex = 5
        Me.rbbrevete.TabStop = True
        Me.rbbrevete.Tag = "Brevete"
        Me.rbbrevete.Text = "Brevete"
        Me.rbbrevete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbbrevete.UseVisualStyleBackColor = False
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.rbNombre.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.rbNombre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbNombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombre.ForeColor = System.Drawing.Color.Black
        Me.rbNombre.Location = New System.Drawing.Point(15, 20)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(154, 21)
        Me.rbNombre.TabIndex = 2
        Me.rbNombre.TabStop = True
        Me.rbNombre.Tag = "Nombre"
        Me.rbNombre.Text = "Nombres y Apellidos"
        Me.rbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbNombre.UseVisualStyleBackColor = False
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
        'BtnCerrar
        '
        Me.BtnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(574, 393)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(120, 41)
        Me.BtnCerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnCerrar.TabIndex = 184
        Me.BtnCerrar.Text = "&Cerrar"
        Me.BtnCerrar.TextColor = System.Drawing.Color.Black
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(432, 393)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(126, 41)
        Me.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnImprimir.TabIndex = 183
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextColor = System.Drawing.Color.Black
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(287, 393)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(126, 41)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 182
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.TextColor = System.Drawing.Color.Black
        '
        'BtnModificar
        '
        Me.BtnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(139, 393)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(126, 41)
        Me.BtnModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnModificar.TabIndex = 181
        Me.BtnModificar.Text = "&Modificar"
        Me.BtnModificar.TextColor = System.Drawing.Color.Black
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(4, 393)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(115, 41)
        Me.btnNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevo.TabIndex = 180
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextColor = System.Drawing.Color.Black
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
        Me.mesajeerror.Location = New System.Drawing.Point(12, 361)
        Me.mesajeerror.Name = "mesajeerror"
        Me.mesajeerror.Size = New System.Drawing.Size(686, 23)
        Me.mesajeerror.TabIndex = 179
        Me.mesajeerror.Text = "LabelX2"
        Me.mesajeerror.TextAlignment = System.Drawing.StringAlignment.Center
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
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlista.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvlista.EnableHeadersVisualStyles = False
        Me.dgvlista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvlista.Location = New System.Drawing.Point(12, 101)
        Me.dgvlista.Name = "dgvlista"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlista.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvlista.Size = New System.Drawing.Size(682, 244)
        Me.dgvlista.TabIndex = 178
        '
        'FrmChofer2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 447)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.mesajeerror)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.gbob)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmChofer2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chofer"
        Me.gbob.ResumeLayout(False)
        Me.gbob.PerformLayout()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents gbob As System.Windows.Forms.GroupBox
    Friend WithEvents RbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbbrevete As System.Windows.Forms.RadioButton
    Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mesajeerror As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgvlista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtbusca As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LBF4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF2 As DevComponents.DotNetBar.LabelX
End Class

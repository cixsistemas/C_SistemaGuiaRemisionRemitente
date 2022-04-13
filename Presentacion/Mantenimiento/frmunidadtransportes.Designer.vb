<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmunidadtransportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmunidadtransportes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.txtbusca = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.gbob = New System.Windows.Forms.GroupBox()
        Me.LBF7 = New DevComponents.DotNetBar.LabelX()
        Me.LBF6 = New DevComponents.DotNetBar.LabelX()
        Me.LBF5 = New DevComponents.DotNetBar.LabelX()
        Me.LBF4 = New DevComponents.DotNetBar.LabelX()
        Me.LBF3 = New DevComponents.DotNetBar.LabelX()
        Me.LBF2 = New DevComponents.DotNetBar.LabelX()
        Me.RbPlac_Sem = New System.Windows.Forms.RadioButton()
        Me.RbMar_Semi = New System.Windows.Forms.RadioButton()
        Me.RbTodos = New System.Windows.Forms.RadioButton()
        Me.rbplac_Rem = New System.Windows.Forms.RadioButton()
        Me.rbEmpresa = New System.Windows.Forms.RadioButton()
        Me.rbmar_rem = New System.Windows.Forms.RadioButton()
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
        Me.txtbusca.Location = New System.Drawing.Point(80, 48)
        Me.txtbusca.Name = "txtbusca"
        Me.txtbusca.Size = New System.Drawing.Size(821, 23)
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
        Me.gbob.Controls.Add(Me.LBF7)
        Me.gbob.Controls.Add(Me.LBF6)
        Me.gbob.Controls.Add(Me.LBF5)
        Me.gbob.Controls.Add(Me.LBF4)
        Me.gbob.Controls.Add(Me.LBF3)
        Me.gbob.Controls.Add(Me.LBF2)
        Me.gbob.Controls.Add(Me.txtbusca)
        Me.gbob.Controls.Add(Me.RbPlac_Sem)
        Me.gbob.Controls.Add(Me.RbMar_Semi)
        Me.gbob.Controls.Add(Me.RbTodos)
        Me.gbob.Controls.Add(Me.rbplac_Rem)
        Me.gbob.Controls.Add(Me.rbEmpresa)
        Me.gbob.Controls.Add(Me.rbmar_rem)
        Me.gbob.Controls.Add(Me.LabelX2)
        Me.gbob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbob.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbob.ForeColor = System.Drawing.Color.Black
        Me.gbob.Location = New System.Drawing.Point(10, 8)
        Me.gbob.Name = "gbob"
        Me.gbob.Size = New System.Drawing.Size(907, 83)
        Me.gbob.TabIndex = 2
        Me.gbob.TabStop = False
        Me.gbob.Text = "Seleccione opciones de busqueda:"
        '
        'LBF7
        '
        Me.LBF7.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.LBF7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBF7.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBF7.ForeColor = System.Drawing.Color.Black
        Me.LBF7.Location = New System.Drawing.Point(868, 20)
        Me.LBF7.Name = "LBF7"
        Me.LBF7.Size = New System.Drawing.Size(33, 23)
        Me.LBF7.TabIndex = 235
        Me.LBF7.Text = " [F7]"
        Me.LBF7.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LBF6
        '
        Me.LBF6.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.LBF6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBF6.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBF6.ForeColor = System.Drawing.Color.Black
        Me.LBF6.Location = New System.Drawing.Point(775, 21)
        Me.LBF6.Name = "LBF6"
        Me.LBF6.Size = New System.Drawing.Size(33, 23)
        Me.LBF6.TabIndex = 234
        Me.LBF6.Text = " [F6]"
        Me.LBF6.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LBF5
        '
        Me.LBF5.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        '
        '
        Me.LBF5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LBF5.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBF5.ForeColor = System.Drawing.Color.Black
        Me.LBF5.Location = New System.Drawing.Point(637, 21)
        Me.LBF5.Name = "LBF5"
        Me.LBF5.Size = New System.Drawing.Size(33, 23)
        Me.LBF5.TabIndex = 233
        Me.LBF5.Text = " [F5]"
        Me.LBF5.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.LBF4.Location = New System.Drawing.Point(453, 21)
        Me.LBF4.Name = "LBF4"
        Me.LBF4.Size = New System.Drawing.Size(33, 23)
        Me.LBF4.TabIndex = 232
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
        Me.LBF3.Location = New System.Drawing.Point(271, 21)
        Me.LBF3.Name = "LBF3"
        Me.LBF3.Size = New System.Drawing.Size(33, 23)
        Me.LBF3.TabIndex = 231
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
        Me.LBF2.Location = New System.Drawing.Point(116, 21)
        Me.LBF2.Name = "LBF2"
        Me.LBF2.Size = New System.Drawing.Size(33, 23)
        Me.LBF2.TabIndex = 230
        Me.LBF2.Text = " [F2]"
        Me.LBF2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'RbPlac_Sem
        '
        Me.RbPlac_Sem.AutoSize = True
        Me.RbPlac_Sem.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RbPlac_Sem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbPlac_Sem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPlac_Sem.ForeColor = System.Drawing.Color.Black
        Me.RbPlac_Sem.Location = New System.Drawing.Point(309, 23)
        Me.RbPlac_Sem.Name = "RbPlac_Sem"
        Me.RbPlac_Sem.Size = New System.Drawing.Size(143, 21)
        Me.RbPlac_Sem.TabIndex = 8
        Me.RbPlac_Sem.TabStop = True
        Me.RbPlac_Sem.Tag = "Placa Semi-Remolque"
        Me.RbPlac_Sem.Text = "Placa Semi-Remolq"
        Me.RbPlac_Sem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbPlac_Sem.UseVisualStyleBackColor = False
        '
        'RbMar_Semi
        '
        Me.RbMar_Semi.AutoSize = True
        Me.RbMar_Semi.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RbMar_Semi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbMar_Semi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbMar_Semi.ForeColor = System.Drawing.Color.Black
        Me.RbMar_Semi.Location = New System.Drawing.Point(495, 22)
        Me.RbMar_Semi.Name = "RbMar_Semi"
        Me.RbMar_Semi.Size = New System.Drawing.Size(148, 21)
        Me.RbMar_Semi.TabIndex = 7
        Me.RbMar_Semi.TabStop = True
        Me.RbMar_Semi.Tag = "Marca Semi-Remolque"
        Me.RbMar_Semi.Text = "Marca Semi-Remolq"
        Me.RbMar_Semi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbMar_Semi.UseVisualStyleBackColor = False
        '
        'RbTodos
        '
        Me.RbTodos.AutoSize = True
        Me.RbTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RbTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbTodos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTodos.ForeColor = System.Drawing.Color.Black
        Me.RbTodos.Location = New System.Drawing.Point(817, 21)
        Me.RbTodos.Name = "RbTodos"
        Me.RbTodos.Size = New System.Drawing.Size(63, 21)
        Me.RbTodos.TabIndex = 6
        Me.RbTodos.TabStop = True
        Me.RbTodos.Tag = "Todos"
        Me.RbTodos.Text = "Todos"
        Me.RbTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbTodos.UseVisualStyleBackColor = False
        '
        'rbplac_Rem
        '
        Me.rbplac_Rem.AutoSize = True
        Me.rbplac_Rem.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.rbplac_Rem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbplac_Rem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbplac_Rem.ForeColor = System.Drawing.Color.Black
        Me.rbplac_Rem.Location = New System.Drawing.Point(6, 22)
        Me.rbplac_Rem.Name = "rbplac_Rem"
        Me.rbplac_Rem.Size = New System.Drawing.Size(108, 21)
        Me.rbplac_Rem.TabIndex = 5
        Me.rbplac_Rem.TabStop = True
        Me.rbplac_Rem.Tag = "Placa Remolque"
        Me.rbplac_Rem.Text = "Placa Remolq"
        Me.rbplac_Rem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbplac_Rem.UseVisualStyleBackColor = False
        '
        'rbEmpresa
        '
        Me.rbEmpresa.AutoSize = True
        Me.rbEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.rbEmpresa.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.rbEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEmpresa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEmpresa.ForeColor = System.Drawing.Color.Black
        Me.rbEmpresa.Location = New System.Drawing.Point(674, 22)
        Me.rbEmpresa.Name = "rbEmpresa"
        Me.rbEmpresa.Size = New System.Drawing.Size(107, 21)
        Me.rbEmpresa.TabIndex = 2
        Me.rbEmpresa.TabStop = True
        Me.rbEmpresa.Tag = "Empresa Transporte"
        Me.rbEmpresa.Text = "Transportista"
        Me.rbEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbEmpresa.UseVisualStyleBackColor = False
        '
        'rbmar_rem
        '
        Me.rbmar_rem.AutoSize = True
        Me.rbmar_rem.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.rbmar_rem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbmar_rem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbmar_rem.ForeColor = System.Drawing.Color.Black
        Me.rbmar_rem.Location = New System.Drawing.Point(157, 23)
        Me.rbmar_rem.Name = "rbmar_rem"
        Me.rbmar_rem.Size = New System.Drawing.Size(113, 21)
        Me.rbmar_rem.TabIndex = 4
        Me.rbmar_rem.TabStop = True
        Me.rbmar_rem.Tag = "Marca Remolque"
        Me.rbmar_rem.Text = "Marca Remolq"
        Me.rbmar_rem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbmar_rem.UseVisualStyleBackColor = False
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
        Me.BtnCerrar.Location = New System.Drawing.Point(680, 496)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(128, 41)
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
        Me.btnImprimir.Location = New System.Drawing.Point(534, 496)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(128, 41)
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
        Me.btnEliminar.Location = New System.Drawing.Point(384, 496)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(128, 41)
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
        Me.BtnModificar.Location = New System.Drawing.Point(231, 496)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(128, 41)
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
        Me.btnNuevo.Location = New System.Drawing.Point(89, 496)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(121, 41)
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
        Me.mesajeerror.Location = New System.Drawing.Point(10, 462)
        Me.mesajeerror.Name = "mesajeerror"
        Me.mesajeerror.Size = New System.Drawing.Size(901, 23)
        Me.mesajeerror.TabIndex = 179
        Me.mesajeerror.Text = "LabelX2"
        Me.mesajeerror.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
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
        Me.dgvlista.Location = New System.Drawing.Point(12, 101)
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
        Me.dgvlista.Size = New System.Drawing.Size(899, 347)
        Me.dgvlista.TabIndex = 178
        '
        'frmunidadtransportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 544)
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
        Me.Name = "frmunidadtransportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unidad de Transporte"
        Me.gbob.ResumeLayout(False)
        Me.gbob.PerformLayout()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents gbob As System.Windows.Forms.GroupBox
    Friend WithEvents RbPlac_Sem As System.Windows.Forms.RadioButton
    Friend WithEvents RbMar_Semi As System.Windows.Forms.RadioButton
    Friend WithEvents RbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbplac_Rem As System.Windows.Forms.RadioButton
    Friend WithEvents rbEmpresa As System.Windows.Forms.RadioButton
    Friend WithEvents rbmar_rem As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mesajeerror As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgvlista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtbusca As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LBF7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LBF2 As DevComponents.DotNetBar.LabelX
End Class

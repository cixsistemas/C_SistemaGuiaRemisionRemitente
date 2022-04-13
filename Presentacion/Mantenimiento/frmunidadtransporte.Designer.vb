<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmunidadtransporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmunidadtransporte))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.marca = New System.Windows.Forms.TextBox()
        Me.nroplaca = New System.Windows.Forms.TextBox()
        Me.nrocertificado = New System.Windows.Forms.TextBox()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.nrocertificado2 = New System.Windows.Forms.TextBox()
        Me.nroplaca2 = New System.Windows.Forms.TextBox()
        Me.marca2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.largo = New System.Windows.Forms.TextBox()
        Me.ancho = New System.Windows.Forms.TextBox()
        Me.alto = New System.Windows.Forms.TextBox()
        Me.alto2 = New System.Windows.Forms.TextBox()
        Me.ancho2 = New System.Windows.Forms.TextBox()
        Me.largo2 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Conf_Vehi = New System.Windows.Forms.TextBox()
        Me.Pes_Veh = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Descripcion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Peso_neto1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.peso_neto2 = New System.Windows.Forms.TextBox()
        Me.btnTransport = New System.Windows.Forms.Button()
        Me.Transportista = New System.Windows.Forms.Label()
        Me.Peso_Bonif = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(825, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese Datos Unidad de Transporte"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Transportista"
        '
        'marca
        '
        Me.marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.marca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marca.Location = New System.Drawing.Point(12, 103)
        Me.marca.Name = "marca"
        Me.marca.Size = New System.Drawing.Size(380, 22)
        Me.marca.TabIndex = 2
        '
        'nroplaca
        '
        Me.nroplaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nroplaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nroplaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nroplaca.Location = New System.Drawing.Point(21, 158)
        Me.nroplaca.Name = "nroplaca"
        Me.nroplaca.Size = New System.Drawing.Size(326, 22)
        Me.nroplaca.TabIndex = 3
        '
        'nrocertificado
        '
        Me.nrocertificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nrocertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nrocertificado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nrocertificado.Location = New System.Drawing.Point(21, 215)
        Me.nrocertificado.Name = "nrocertificado"
        Me.nrocertificado.Size = New System.Drawing.Size(326, 22)
        Me.nrocertificado.TabIndex = 8
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(613, 496)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(110, 48)
        Me.btnaceptar.TabIndex = 20
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Blue
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(729, 496)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(114, 48)
        Me.btncancelar.TabIndex = 21
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'nrocertificado2
        '
        Me.nrocertificado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nrocertificado2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nrocertificado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nrocertificado2.Location = New System.Drawing.Point(21, 422)
        Me.nrocertificado2.Name = "nrocertificado2"
        Me.nrocertificado2.Size = New System.Drawing.Size(326, 22)
        Me.nrocertificado2.TabIndex = 15
        '
        'nroplaca2
        '
        Me.nroplaca2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nroplaca2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nroplaca2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nroplaca2.Location = New System.Drawing.Point(19, 369)
        Me.nroplaca2.Name = "nroplaca2"
        Me.nroplaca2.Size = New System.Drawing.Size(326, 22)
        Me.nroplaca2.TabIndex = 10
        '
        'marca2
        '
        Me.marca2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.marca2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.marca2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marca2.Location = New System.Drawing.Point(14, 312)
        Me.marca2.Name = "marca2"
        Me.marca2.Size = New System.Drawing.Size(380, 22)
        Me.marca2.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Location = New System.Drawing.Point(414, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 386)
        Me.Panel1.TabIndex = 95
        '
        'largo
        '
        Me.largo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.largo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.largo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.largo.Location = New System.Drawing.Point(452, 93)
        Me.largo.Name = "largo"
        Me.largo.Size = New System.Drawing.Size(114, 22)
        Me.largo.TabIndex = 4
        '
        'ancho
        '
        Me.ancho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ancho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ancho.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancho.Location = New System.Drawing.Point(453, 189)
        Me.ancho.Name = "ancho"
        Me.ancho.Size = New System.Drawing.Size(113, 22)
        Me.ancho.TabIndex = 6
        '
        'alto
        '
        Me.alto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.alto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.alto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alto.Location = New System.Drawing.Point(452, 143)
        Me.alto.Name = "alto"
        Me.alto.Size = New System.Drawing.Size(114, 22)
        Me.alto.TabIndex = 5
        '
        'alto2
        '
        Me.alto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.alto2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.alto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alto2.Location = New System.Drawing.Point(452, 359)
        Me.alto2.Name = "alto2"
        Me.alto2.Size = New System.Drawing.Size(114, 22)
        Me.alto2.TabIndex = 12
        '
        'ancho2
        '
        Me.ancho2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ancho2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ancho2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancho2.Location = New System.Drawing.Point(453, 406)
        Me.ancho2.Name = "ancho2"
        Me.ancho2.Size = New System.Drawing.Size(113, 22)
        Me.ancho2.TabIndex = 13
        '
        'largo2
        '
        Me.largo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.largo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.largo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.largo2.Location = New System.Drawing.Point(453, 311)
        Me.largo2.Name = "largo2"
        Me.largo2.Size = New System.Drawing.Size(113, 22)
        Me.largo2.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Location = New System.Drawing.Point(15, 269)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(703, 13)
        Me.Panel2.TabIndex = 108
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 487)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 15)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Conf. Vehicular:"
        '
        'Conf_Vehi
        '
        Me.Conf_Vehi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conf_Vehi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Conf_Vehi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conf_Vehi.Location = New System.Drawing.Point(12, 506)
        Me.Conf_Vehi.Name = "Conf_Vehi"
        Me.Conf_Vehi.Size = New System.Drawing.Size(101, 22)
        Me.Conf_Vehi.TabIndex = 16
        '
        'Pes_Veh
        '
        Me.Pes_Veh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pes_Veh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pes_Veh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pes_Veh.Location = New System.Drawing.Point(123, 506)
        Me.Pes_Veh.Name = "Pes_Veh"
        Me.Pes_Veh.Size = New System.Drawing.Size(101, 22)
        Me.Pes_Veh.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(121, 487)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 15)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Peso Bruto Veh.:"
        '
        'Descripcion
        '
        Me.Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.Location = New System.Drawing.Point(395, 506)
        Me.Descripcion.Multiline = True
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(212, 41)
        Me.Descripcion.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(396, 487)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(194, 15)
        Me.Label17.TabIndex = 113
        Me.Label17.Text = "Descripcion (Bon. Vehicular):"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(633, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 115
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(633, 288)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(212, 143)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 116
        Me.PictureBox2.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 15)
        Me.Label18.TabIndex = 117
        Me.Label18.Text = "Marca Remolque:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 15)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Nro. placa Remolque:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 15)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Nro. certificado Remolque:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(439, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 15)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "Alto Remolque:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(440, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 15)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "Ancho Remolque:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(439, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 15)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "Largo Remolque:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 15)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Nro. placa Semiremolque:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(207, 15)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "Nro. certificado Semiremolque:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 15)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "Marca Semiremolque:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(433, 339)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 15)
        Me.Label12.TabIndex = 128
        Me.Label12.Text = "Alto Semiremolque:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(434, 386)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 15)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "Ancho Semiremolque:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(434, 292)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 15)
        Me.Label14.TabIndex = 126
        Me.Label14.Text = "Largo Semiremolque:"
        '
        'Peso_neto1
        '
        Me.Peso_neto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Peso_neto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Peso_neto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Peso_neto1.Location = New System.Drawing.Point(452, 238)
        Me.Peso_neto1.Name = "Peso_neto1"
        Me.Peso_neto1.Size = New System.Drawing.Size(114, 22)
        Me.Peso_neto1.TabIndex = 7
        Me.Peso_neto1.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(443, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 15)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "Peso Neto Remolque:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(438, 435)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(185, 15)
        Me.Label19.TabIndex = 132
        Me.Label19.Text = "Peso Neto Semi-Remolque:"
        '
        'peso_neto2
        '
        Me.peso_neto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.peso_neto2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.peso_neto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.peso_neto2.Location = New System.Drawing.Point(454, 455)
        Me.peso_neto2.Name = "peso_neto2"
        Me.peso_neto2.Size = New System.Drawing.Size(112, 22)
        Me.peso_neto2.TabIndex = 14
        Me.peso_neto2.Text = "0"
        '
        'btnTransport
        '
        Me.btnTransport.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransport.Image = CType(resources.GetObject("btnTransport.Image"), System.Drawing.Image)
        Me.btnTransport.Location = New System.Drawing.Point(367, 42)
        Me.btnTransport.Name = "btnTransport"
        Me.btnTransport.Size = New System.Drawing.Size(41, 45)
        Me.btnTransport.TabIndex = 0
        Me.btnTransport.UseVisualStyleBackColor = False
        '
        'Transportista
        '
        Me.Transportista.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Transportista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Transportista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transportista.ForeColor = System.Drawing.Color.Navy
        Me.Transportista.Location = New System.Drawing.Point(12, 42)
        Me.Transportista.Name = "Transportista"
        Me.Transportista.Size = New System.Drawing.Size(349, 34)
        Me.Transportista.TabIndex = 135
        Me.Transportista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Peso_Bonif
        '
        Me.Peso_Bonif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Peso_Bonif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Peso_Bonif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Peso_Bonif.Location = New System.Drawing.Point(253, 506)
        Me.Peso_Bonif.Name = "Peso_Bonif"
        Me.Peso_Bonif.Size = New System.Drawing.Size(101, 22)
        Me.Peso_Bonif.TabIndex = 18
        Me.Peso_Bonif.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(251, 487)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 15)
        Me.Label20.TabIndex = 137
        Me.Label20.Text = "Peso Bonificacion:"
        '
        'frmunidadtransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(857, 559)
        Me.Controls.Add(Me.Peso_Bonif)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Transportista)
        Me.Controls.Add(Me.btnTransport)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.peso_neto2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Peso_neto1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Pes_Veh)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Conf_Vehi)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.alto2)
        Me.Controls.Add(Me.ancho2)
        Me.Controls.Add(Me.largo2)
        Me.Controls.Add(Me.alto)
        Me.Controls.Add(Me.ancho)
        Me.Controls.Add(Me.largo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.nrocertificado2)
        Me.Controls.Add(Me.nroplaca2)
        Me.Controls.Add(Me.marca2)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.nrocertificado)
        Me.Controls.Add(Me.nroplaca)
        Me.Controls.Add(Me.marca)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmunidadtransporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unidad de transporte"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents marca As System.Windows.Forms.TextBox
    Friend WithEvents nroplaca As System.Windows.Forms.TextBox
    Friend WithEvents nrocertificado As System.Windows.Forms.TextBox
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents nrocertificado2 As System.Windows.Forms.TextBox
    Friend WithEvents nroplaca2 As System.Windows.Forms.TextBox
    Friend WithEvents marca2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents largo As System.Windows.Forms.TextBox
    Friend WithEvents ancho As System.Windows.Forms.TextBox
    Friend WithEvents alto As System.Windows.Forms.TextBox
    Friend WithEvents alto2 As System.Windows.Forms.TextBox
    Friend WithEvents ancho2 As System.Windows.Forms.TextBox
    Friend WithEvents largo2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Conf_Vehi As System.Windows.Forms.TextBox
    Friend WithEvents Pes_Veh As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Peso_neto1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents peso_neto2 As System.Windows.Forms.TextBox
    Friend WithEvents btnTransport As System.Windows.Forms.Button
    Friend WithEvents Transportista As System.Windows.Forms.Label
    Friend WithEvents Peso_Bonif As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class

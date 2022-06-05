<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmguia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmguia))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.serie_guia = New System.Windows.Forms.TextBox()
        Me.nro_guia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ruc = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnptopartida = New System.Windows.Forms.Button()
        Me.departamentoptop = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.provinciaptop = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.distritoptop = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.direccion_pto_partida = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.direccion_pto_llegadaa = New System.Windows.Forms.ComboBox()
        Me.btnptollegada = New System.Windows.Forms.Button()
        Me.departamentoptoll = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.provinciaptoll = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.distritoptoll = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.fecha_emision_guia = New System.Windows.Forms.DateTimePicker()
        Me.fecha_inicio_traslado = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.nro_doc = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.nombre_tip_doc = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnDestinatario = New System.Windows.Forms.Button()
        Me.rucdes = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.destinatario = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Nro_licencia_conductor = New System.Windows.Forms.Label()
        Me.btnChofer = New System.Windows.Forms.Button()
        Me.nrocertificado_carreta = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.nroplaca_carreta = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.marca_carreta = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.marca_camion = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.nrocertificado_camion = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnTransporte = New System.Windows.Forms.Button()
        Me.nroplaca_camion = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.prod_peso_uni = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cantidad_sacos = New System.Windows.Forms.TextBox()
        Me.NombreProducto = New System.Windows.Forms.Label()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.Detalle = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id_det_guia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sacos_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad_medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.NombreEmpTransporte = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.RucEmpTransporte = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Nro_constancia_deposito = New System.Windows.Forms.TextBox()
        Me.Monto_deposito = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btnnuevo_examen = New System.Windows.Forms.Button()
        Me.btneditar_hpm = New System.Windows.Forms.Button()
        Me.btnquitar_hpm = New System.Windows.Forms.Button()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Selecciona = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgvmotivo = New System.Windows.Forms.DataGridView()
        Me.Monto_deposito2 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Nro_constancia_deposito2 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TxtMotivo = New System.Windows.Forms.Label()
        Me.BtnMotivo = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NombreRemitente = New System.Windows.Forms.Label()
        Me.btnremitente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPrec_Venta = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtIGV = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvmotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(715, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Serie"
        '
        'serie_guia
        '
        Me.serie_guia.BackColor = System.Drawing.SystemColors.Window
        Me.serie_guia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.serie_guia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serie_guia.Location = New System.Drawing.Point(718, 52)
        Me.serie_guia.MaxLength = 4
        Me.serie_guia.Name = "serie_guia"
        Me.serie_guia.Size = New System.Drawing.Size(47, 20)
        Me.serie_guia.TabIndex = 1
        Me.serie_guia.Text = "000"
        '
        'nro_guia
        '
        Me.nro_guia.BackColor = System.Drawing.SystemColors.Window
        Me.nro_guia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nro_guia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nro_guia.Location = New System.Drawing.Point(772, 51)
        Me.nro_guia.MaxLength = 7
        Me.nro_guia.Name = "nro_guia"
        Me.nro_guia.Size = New System.Drawing.Size(122, 20)
        Me.nro_guia.TabIndex = 2
        Me.nro_guia.Text = "000000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(768, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Número"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(765, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "R.U.C."
        '
        'ruc
        '
        Me.ruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ruc.ForeColor = System.Drawing.Color.Red
        Me.ruc.Location = New System.Drawing.Point(810, 9)
        Me.ruc.Name = "ruc"
        Me.ruc.Size = New System.Drawing.Size(80, 21)
        Me.ruc.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnptopartida)
        Me.GroupBox2.Controls.Add(Me.departamentoptop)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.provinciaptop)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.distritoptop)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.direccion_pto_partida)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(413, 109)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos punto partida"
        '
        'btnptopartida
        '
        Me.btnptopartida.BackColor = System.Drawing.Color.Gainsboro
        Me.btnptopartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnptopartida.Image = CType(resources.GetObject("btnptopartida.Image"), System.Drawing.Image)
        Me.btnptopartida.Location = New System.Drawing.Point(374, 21)
        Me.btnptopartida.Name = "btnptopartida"
        Me.btnptopartida.Size = New System.Drawing.Size(36, 32)
        Me.btnptopartida.TabIndex = 8
        Me.btnptopartida.UseVisualStyleBackColor = False
        '
        'departamentoptop
        '
        Me.departamentoptop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.departamentoptop.ForeColor = System.Drawing.Color.Blue
        Me.departamentoptop.Location = New System.Drawing.Point(278, 64)
        Me.departamentoptop.Name = "departamentoptop"
        Me.departamentoptop.Size = New System.Drawing.Size(123, 32)
        Me.departamentoptop.TabIndex = 15
        Me.departamentoptop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(278, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Departamento"
        '
        'provinciaptop
        '
        Me.provinciaptop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.provinciaptop.ForeColor = System.Drawing.Color.Blue
        Me.provinciaptop.Location = New System.Drawing.Point(143, 64)
        Me.provinciaptop.Name = "provinciaptop"
        Me.provinciaptop.Size = New System.Drawing.Size(123, 32)
        Me.provinciaptop.TabIndex = 13
        Me.provinciaptop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(143, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Provincia"
        '
        'distritoptop
        '
        Me.distritoptop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.distritoptop.ForeColor = System.Drawing.Color.Blue
        Me.distritoptop.Location = New System.Drawing.Point(6, 64)
        Me.distritoptop.Name = "distritoptop"
        Me.distritoptop.Size = New System.Drawing.Size(123, 32)
        Me.distritoptop.TabIndex = 11
        Me.distritoptop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Distrito"
        '
        'direccion_pto_partida
        '
        Me.direccion_pto_partida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.direccion_pto_partida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion_pto_partida.Location = New System.Drawing.Point(74, 21)
        Me.direccion_pto_partida.Name = "direccion_pto_partida"
        Me.direccion_pto_partida.Size = New System.Drawing.Size(294, 20)
        Me.direccion_pto_partida.TabIndex = 7
        Me.direccion_pto_partida.Text = "CAR. LAMBAYEQUE KM 778"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Direccción:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.direccion_pto_llegadaa)
        Me.GroupBox3.Controls.Add(Me.btnptollegada)
        Me.GroupBox3.Controls.Add(Me.departamentoptoll)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.provinciaptoll)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.distritoptoll)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(441, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(457, 111)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos punto llegada"
        '
        'direccion_pto_llegadaa
        '
        Me.direccion_pto_llegadaa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion_pto_llegadaa.FormattingEnabled = True
        Me.direccion_pto_llegadaa.Location = New System.Drawing.Point(70, 25)
        Me.direccion_pto_llegadaa.Name = "direccion_pto_llegadaa"
        Me.direccion_pto_llegadaa.Size = New System.Drawing.Size(342, 21)
        Me.direccion_pto_llegadaa.TabIndex = 9
        Me.direccion_pto_llegadaa.Text = "MERCADO LIBRE-"
        '
        'btnptollegada
        '
        Me.btnptollegada.BackColor = System.Drawing.Color.Gainsboro
        Me.btnptollegada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnptollegada.Image = CType(resources.GetObject("btnptollegada.Image"), System.Drawing.Image)
        Me.btnptollegada.Location = New System.Drawing.Point(418, 27)
        Me.btnptollegada.Name = "btnptollegada"
        Me.btnptollegada.Size = New System.Drawing.Size(33, 32)
        Me.btnptollegada.TabIndex = 10
        Me.btnptollegada.UseVisualStyleBackColor = False
        '
        'departamentoptoll
        '
        Me.departamentoptoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.departamentoptoll.ForeColor = System.Drawing.Color.Blue
        Me.departamentoptoll.Location = New System.Drawing.Point(308, 69)
        Me.departamentoptoll.Name = "departamentoptoll"
        Me.departamentoptoll.Size = New System.Drawing.Size(140, 32)
        Me.departamentoptoll.TabIndex = 15
        Me.departamentoptoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(305, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Departamento"
        '
        'provinciaptoll
        '
        Me.provinciaptoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.provinciaptoll.ForeColor = System.Drawing.Color.Blue
        Me.provinciaptoll.Location = New System.Drawing.Point(164, 69)
        Me.provinciaptoll.Name = "provinciaptoll"
        Me.provinciaptoll.Size = New System.Drawing.Size(135, 32)
        Me.provinciaptoll.TabIndex = 13
        Me.provinciaptoll.Text = " "
        Me.provinciaptoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(166, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Provincia"
        '
        'distritoptoll
        '
        Me.distritoptoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.distritoptoll.ForeColor = System.Drawing.Color.Blue
        Me.distritoptoll.Location = New System.Drawing.Point(14, 69)
        Me.distritoptoll.Name = "distritoptoll"
        Me.distritoptoll.Size = New System.Drawing.Size(133, 32)
        Me.distritoptoll.TabIndex = 11
        Me.distritoptoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Distrito"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Direccción:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Fec. emisión:"
        '
        'fecha_emision_guia
        '
        Me.fecha_emision_guia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_emision_guia.Location = New System.Drawing.Point(86, 58)
        Me.fecha_emision_guia.Name = "fecha_emision_guia"
        Me.fecha_emision_guia.Size = New System.Drawing.Size(100, 20)
        Me.fecha_emision_guia.TabIndex = 5
        '
        'fecha_inicio_traslado
        '
        Me.fecha_inicio_traslado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_inicio_traslado.Location = New System.Drawing.Point(312, 59)
        Me.fecha_inicio_traslado.Name = "fecha_inicio_traslado"
        Me.fecha_inicio_traslado.Size = New System.Drawing.Size(98, 20)
        Me.fecha_inicio_traslado.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(195, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Fec. inicio traslado:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.nro_doc)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.nombre_tip_doc)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.btnDestinatario)
        Me.GroupBox4.Controls.Add(Me.rucdes)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.destinatario)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(15, 193)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(413, 102)
        Me.GroupBox4.TabIndex = 100
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Destinatario"
        '
        'nro_doc
        '
        Me.nro_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nro_doc.ForeColor = System.Drawing.Color.Blue
        Me.nro_doc.Location = New System.Drawing.Point(258, 74)
        Me.nro_doc.Name = "nro_doc"
        Me.nro_doc.Size = New System.Drawing.Size(146, 18)
        Me.nro_doc.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(258, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Nro. doc."
        '
        'nombre_tip_doc
        '
        Me.nombre_tip_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nombre_tip_doc.ForeColor = System.Drawing.Color.Blue
        Me.nombre_tip_doc.Location = New System.Drawing.Point(100, 74)
        Me.nombre_tip_doc.Name = "nombre_tip_doc"
        Me.nombre_tip_doc.Size = New System.Drawing.Size(152, 18)
        Me.nombre_tip_doc.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(100, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Tipo documento:"
        '
        'btnDestinatario
        '
        Me.btnDestinatario.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDestinatario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDestinatario.Image = CType(resources.GetObject("btnDestinatario.Image"), System.Drawing.Image)
        Me.btnDestinatario.Location = New System.Drawing.Point(374, 25)
        Me.btnDestinatario.Name = "btnDestinatario"
        Me.btnDestinatario.Size = New System.Drawing.Size(36, 35)
        Me.btnDestinatario.TabIndex = 12
        Me.btnDestinatario.UseVisualStyleBackColor = False
        '
        'rucdes
        '
        Me.rucdes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rucdes.ForeColor = System.Drawing.Color.Blue
        Me.rucdes.Location = New System.Drawing.Point(6, 74)
        Me.rucdes.Name = "rucdes"
        Me.rucdes.Size = New System.Drawing.Size(88, 18)
        Me.rucdes.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 13)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "RUC:"
        '
        'destinatario
        '
        Me.destinatario.Enabled = False
        Me.destinatario.Location = New System.Drawing.Point(85, 25)
        Me.destinatario.Name = "destinatario"
        Me.destinatario.Size = New System.Drawing.Size(283, 20)
        Me.destinatario.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 25)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 13)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Razon Social:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Nro_licencia_conductor)
        Me.GroupBox5.Controls.Add(Me.btnChofer)
        Me.GroupBox5.Controls.Add(Me.nrocertificado_carreta)
        Me.GroupBox5.Controls.Add(Me.Label37)
        Me.GroupBox5.Controls.Add(Me.nroplaca_carreta)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.marca_carreta)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Controls.Add(Me.marca_camion)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.nrocertificado_camion)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.btnTransporte)
        Me.GroupBox5.Controls.Add(Me.nroplaca_camion)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(440, 194)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(463, 123)
        Me.GroupBox5.TabIndex = 101
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Unidad transporte/Conductor"
        '
        'Nro_licencia_conductor
        '
        Me.Nro_licencia_conductor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nro_licencia_conductor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nro_licencia_conductor.ForeColor = System.Drawing.Color.DarkGreen
        Me.Nro_licencia_conductor.Location = New System.Drawing.Point(291, 94)
        Me.Nro_licencia_conductor.Name = "Nro_licencia_conductor"
        Me.Nro_licencia_conductor.Size = New System.Drawing.Size(101, 20)
        Me.Nro_licencia_conductor.TabIndex = 91
        Me.Nro_licencia_conductor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnChofer
        '
        Me.btnChofer.BackColor = System.Drawing.Color.Gainsboro
        Me.btnChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChofer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnChofer.Image = CType(resources.GetObject("btnChofer.Image"), System.Drawing.Image)
        Me.btnChofer.Location = New System.Drawing.Point(424, 86)
        Me.btnChofer.Name = "btnChofer"
        Me.btnChofer.Size = New System.Drawing.Size(33, 32)
        Me.btnChofer.TabIndex = 14
        Me.btnChofer.UseVisualStyleBackColor = False
        '
        'nrocertificado_carreta
        '
        Me.nrocertificado_carreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nrocertificado_carreta.ForeColor = System.Drawing.Color.Blue
        Me.nrocertificado_carreta.Location = New System.Drawing.Point(135, 98)
        Me.nrocertificado_carreta.Name = "nrocertificado_carreta"
        Me.nrocertificado_carreta.Size = New System.Drawing.Size(123, 20)
        Me.nrocertificado_carreta.TabIndex = 25
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(132, 84)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(149, 13)
        Me.Label37.TabIndex = 24
        Me.Label37.Text = "Certificado de SemiRemolque:"
        '
        'nroplaca_carreta
        '
        Me.nroplaca_carreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nroplaca_carreta.ForeColor = System.Drawing.Color.Blue
        Me.nroplaca_carreta.Location = New System.Drawing.Point(140, 61)
        Me.nroplaca_carreta.Name = "nroplaca_carreta"
        Me.nroplaca_carreta.Size = New System.Drawing.Size(100, 20)
        Me.nroplaca_carreta.TabIndex = 23
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(143, 46)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(111, 13)
        Me.Label36.TabIndex = 22
        Me.Label36.Text = "Placa SemiRemolque:"
        '
        'marca_carreta
        '
        Me.marca_carreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.marca_carreta.ForeColor = System.Drawing.Color.Blue
        Me.marca_carreta.Location = New System.Drawing.Point(308, 23)
        Me.marca_carreta.Name = "marca_carreta"
        Me.marca_carreta.Size = New System.Drawing.Size(105, 20)
        Me.marca_carreta.TabIndex = 21
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(195, 22)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(114, 13)
        Me.Label35.TabIndex = 20
        Me.Label35.Text = "Marca SemiRemolque:"
        '
        'marca_camion
        '
        Me.marca_camion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.marca_camion.ForeColor = System.Drawing.Color.Blue
        Me.marca_camion.Location = New System.Drawing.Point(90, 23)
        Me.marca_camion.Name = "marca_camion"
        Me.marca_camion.Size = New System.Drawing.Size(105, 20)
        Me.marca_camion.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(285, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(154, 15)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Licencia de Conductor:"
        '
        'nrocertificado_camion
        '
        Me.nrocertificado_camion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nrocertificado_camion.ForeColor = System.Drawing.Color.Blue
        Me.nrocertificado_camion.Location = New System.Drawing.Point(5, 99)
        Me.nrocertificado_camion.Name = "nrocertificado_camion"
        Me.nrocertificado_camion.Size = New System.Drawing.Size(124, 20)
        Me.nrocertificado_camion.TabIndex = 18
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 84)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(126, 13)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Certificado de Remolque:"
        '
        'btnTransporte
        '
        Me.btnTransporte.BackColor = System.Drawing.Color.Gainsboro
        Me.btnTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransporte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTransporte.Image = CType(resources.GetObject("btnTransporte.Image"), System.Drawing.Image)
        Me.btnTransporte.Location = New System.Drawing.Point(424, 19)
        Me.btnTransporte.Name = "btnTransporte"
        Me.btnTransporte.Size = New System.Drawing.Size(33, 33)
        Me.btnTransporte.TabIndex = 13
        Me.btnTransporte.UseVisualStyleBackColor = False
        '
        'nroplaca_camion
        '
        Me.nroplaca_camion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nroplaca_camion.ForeColor = System.Drawing.Color.Blue
        Me.nroplaca_camion.Location = New System.Drawing.Point(4, 62)
        Me.nroplaca_camion.Name = "nroplaca_camion"
        Me.nroplaca_camion.Size = New System.Drawing.Size(100, 20)
        Me.nroplaca_camion.TabIndex = 11
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 46)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 13)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "Placa Remolque:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(2, 23)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(91, 13)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Marca Remolque:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(556, 341)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 13)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Peso:"
        '
        'prod_peso_uni
        '
        Me.prod_peso_uni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prod_peso_uni.ForeColor = System.Drawing.Color.Blue
        Me.prod_peso_uni.Location = New System.Drawing.Point(556, 357)
        Me.prod_peso_uni.Name = "prod_peso_uni"
        Me.prod_peso_uni.Size = New System.Drawing.Size(58, 20)
        Me.prod_peso_uni.TabIndex = 21
        Me.prod_peso_uni.Text = "                 "
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(635, 342)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 13)
        Me.Label26.TabIndex = 22
        Me.Label26.Text = "Cantidad:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Maroon
        Me.btnAgregar.Location = New System.Drawing.Point(818, 384)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(76, 28)
        Me.btnAgregar.TabIndex = 70
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'cantidad_sacos
        '
        Me.cantidad_sacos.Enabled = False
        Me.cantidad_sacos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad_sacos.Location = New System.Drawing.Point(633, 358)
        Me.cantidad_sacos.Name = "cantidad_sacos"
        Me.cantidad_sacos.Size = New System.Drawing.Size(62, 20)
        Me.cantidad_sacos.TabIndex = 67
        '
        'NombreProducto
        '
        Me.NombreProducto.ForeColor = System.Drawing.Color.MediumBlue
        Me.NombreProducto.Location = New System.Drawing.Point(11, 16)
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.Size = New System.Drawing.Size(401, 60)
        Me.NombreProducto.TabIndex = 26
        Me.NombreProducto.Text = "             "
        '
        'btnProducto
        '
        Me.btnProducto.BackColor = System.Drawing.Color.Gainsboro
        Me.btnProducto.Enabled = False
        Me.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducto.Image = CType(resources.GetObject("btnProducto.Image"), System.Drawing.Image)
        Me.btnProducto.Location = New System.Drawing.Point(511, 344)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(33, 33)
        Me.btnProducto.TabIndex = 63
        Me.btnProducto.UseVisualStyleBackColor = False
        '
        'Detalle
        '
        Me.Detalle.AllowUserToAddRows = False
        Me.Detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Detalle.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar, Me.id_det_guia, Me.id_prod, Me.sacos_cantidad, Me.unidad_medida, Me.Descripcion, Me.x, Me.Peso, Me.Precio_Venta, Me.IGV})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Detalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.Detalle.Location = New System.Drawing.Point(15, 391)
        Me.Detalle.Name = "Detalle"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Detalle.Size = New System.Drawing.Size(789, 128)
        Me.Detalle.TabIndex = 28
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Selecciona"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Seleccionar.Width = 85
        '
        'id_det_guia
        '
        Me.id_det_guia.HeaderText = "ID"
        Me.id_det_guia.Name = "id_det_guia"
        Me.id_det_guia.Visible = False
        Me.id_det_guia.Width = 43
        '
        'id_prod
        '
        Me.id_prod.HeaderText = "Codigo"
        Me.id_prod.Name = "id_prod"
        Me.id_prod.Visible = False
        Me.id_prod.Width = 65
        '
        'sacos_cantidad
        '
        Me.sacos_cantidad.HeaderText = "Cantidad"
        Me.sacos_cantidad.Name = "sacos_cantidad"
        Me.sacos_cantidad.Width = 74
        '
        'unidad_medida
        '
        Me.unidad_medida.HeaderText = "Unidad"
        Me.unidad_medida.Name = "unidad_medida"
        Me.unidad_medida.Visible = False
        Me.unidad_medida.Width = 66
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 88
        '
        'x
        '
        Me.x.HeaderText = "Kilos"
        Me.x.Name = "x"
        Me.x.Width = 54
        '
        'Peso
        '
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.Width = 56
        '
        'Precio_Venta
        '
        Me.Precio_Venta.HeaderText = "Precio_Venta"
        Me.Precio_Venta.Name = "Precio_Venta"
        Me.Precio_Venta.Width = 96
        '
        'IGV
        '
        Me.IGV.HeaderText = "IGV"
        Me.IGV.Name = "IGV"
        Me.IGV.Width = 50
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(263, 553)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(79, 13)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "Motivo traslado"
        Me.Label23.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(17, 554)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(95, 15)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "Transportista:"
        '
        'NombreEmpTransporte
        '
        Me.NombreEmpTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreEmpTransporte.ForeColor = System.Drawing.Color.Blue
        Me.NombreEmpTransporte.Location = New System.Drawing.Point(18, 590)
        Me.NombreEmpTransporte.Name = "NombreEmpTransporte"
        Me.NombreEmpTransporte.Size = New System.Drawing.Size(134, 42)
        Me.NombreEmpTransporte.TabIndex = 33
        Me.NombreEmpTransporte.Text = "                    "
        Me.NombreEmpTransporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(18, 573)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 13)
        Me.Label29.TabIndex = 32
        Me.Label29.Text = "Nombre"
        '
        'RucEmpTransporte
        '
        Me.RucEmpTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RucEmpTransporte.ForeColor = System.Drawing.Color.Blue
        Me.RucEmpTransporte.Location = New System.Drawing.Point(158, 592)
        Me.RucEmpTransporte.Name = "RucEmpTransporte"
        Me.RucEmpTransporte.Size = New System.Drawing.Size(99, 40)
        Me.RucEmpTransporte.TabIndex = 35
        Me.RucEmpTransporte.Text = "                    "
        Me.RucEmpTransporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(155, 576)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(30, 13)
        Me.Label30.TabIndex = 34
        Me.Label30.Text = "RUC"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(13, 530)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(122, 13)
        Me.Label28.TabIndex = 37
        Me.Label28.Text = "Nro. constacia deposito:"
        '
        'Nro_constancia_deposito
        '
        Me.Nro_constancia_deposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nro_constancia_deposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nro_constancia_deposito.Location = New System.Drawing.Point(136, 528)
        Me.Nro_constancia_deposito.Name = "Nro_constancia_deposito"
        Me.Nro_constancia_deposito.Size = New System.Drawing.Size(127, 20)
        Me.Nro_constancia_deposito.TabIndex = 15
        Me.Nro_constancia_deposito.Text = "."
        '
        'Monto_deposito
        '
        Me.Monto_deposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Monto_deposito.Location = New System.Drawing.Point(316, 528)
        Me.Monto_deposito.Name = "Monto_deposito"
        Me.Monto_deposito.Size = New System.Drawing.Size(89, 20)
        Me.Monto_deposito.TabIndex = 16
        Me.Monto_deposito.Text = "0.00"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(271, 527)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 13)
        Me.Label31.TabIndex = 39
        Me.Label31.Text = "Monto:"
        '
        'btnnuevo_examen
        '
        Me.btnnuevo_examen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnnuevo_examen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo_examen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo_examen.ForeColor = System.Drawing.Color.Maroon
        Me.btnnuevo_examen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevo_examen.Location = New System.Drawing.Point(818, 430)
        Me.btnnuevo_examen.Name = "btnnuevo_examen"
        Me.btnnuevo_examen.Size = New System.Drawing.Size(77, 28)
        Me.btnnuevo_examen.TabIndex = 19
        Me.btnnuevo_examen.Text = "Nuevo"
        Me.btnnuevo_examen.UseVisualStyleBackColor = False
        '
        'btneditar_hpm
        '
        Me.btneditar_hpm.BackColor = System.Drawing.Color.Gainsboro
        Me.btneditar_hpm.Enabled = False
        Me.btneditar_hpm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar_hpm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditar_hpm.ForeColor = System.Drawing.Color.Maroon
        Me.btneditar_hpm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneditar_hpm.Location = New System.Drawing.Point(819, 461)
        Me.btneditar_hpm.Name = "btneditar_hpm"
        Me.btneditar_hpm.Size = New System.Drawing.Size(77, 28)
        Me.btneditar_hpm.TabIndex = 20
        Me.btneditar_hpm.Text = "Editar"
        Me.btneditar_hpm.UseVisualStyleBackColor = False
        '
        'btnquitar_hpm
        '
        Me.btnquitar_hpm.BackColor = System.Drawing.Color.Gainsboro
        Me.btnquitar_hpm.Enabled = False
        Me.btnquitar_hpm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquitar_hpm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquitar_hpm.ForeColor = System.Drawing.Color.Maroon
        Me.btnquitar_hpm.Location = New System.Drawing.Point(819, 493)
        Me.btnquitar_hpm.Name = "btnquitar_hpm"
        Me.btnquitar_hpm.Size = New System.Drawing.Size(78, 28)
        Me.btnquitar_hpm.TabIndex = 21
        Me.btnquitar_hpm.Text = "Quitar"
        Me.btnquitar_hpm.UseVisualStyleBackColor = False
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(781, 548)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(118, 43)
        Me.btnaceptar.TabIndex = 22
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.MediumBlue
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(781, 599)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(119, 38)
        Me.btncancelar.TabIndex = 23
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Selecciona
        '
        Me.Selecciona.HeaderText = "Selecciona"
        Me.Selecciona.Name = "Selecciona"
        Me.Selecciona.Width = 66
        '
        'dgvmotivo
        '
        Me.dgvmotivo.AllowUserToAddRows = False
        Me.dgvmotivo.AllowUserToDeleteRows = False
        Me.dgvmotivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvmotivo.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmotivo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvmotivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmotivo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selecciona})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvmotivo.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvmotivo.Location = New System.Drawing.Point(266, 567)
        Me.dgvmotivo.Name = "dgvmotivo"
        Me.dgvmotivo.RowHeadersVisible = False
        Me.dgvmotivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmotivo.Size = New System.Drawing.Size(76, 66)
        Me.dgvmotivo.TabIndex = 50
        Me.dgvmotivo.Visible = False
        '
        'Monto_deposito2
        '
        Me.Monto_deposito2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Monto_deposito2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Monto_deposito2.Location = New System.Drawing.Point(711, 525)
        Me.Monto_deposito2.Name = "Monto_deposito2"
        Me.Monto_deposito2.Size = New System.Drawing.Size(93, 20)
        Me.Monto_deposito2.TabIndex = 18
        Me.Monto_deposito2.Text = "0.00"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(663, 529)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(46, 13)
        Me.Label32.TabIndex = 87
        Me.Label32.Text = "Montoo:"
        '
        'Nro_constancia_deposito2
        '
        Me.Nro_constancia_deposito2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nro_constancia_deposito2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nro_constancia_deposito2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Nro_constancia_deposito2.Location = New System.Drawing.Point(540, 527)
        Me.Nro_constancia_deposito2.Name = "Nro_constancia_deposito2"
        Me.Nro_constancia_deposito2.Size = New System.Drawing.Size(118, 20)
        Me.Nro_constancia_deposito2.TabIndex = 17
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(411, 529)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(128, 13)
        Me.Label33.TabIndex = 85
        Me.Label33.Text = "Nro. constacia depositoo:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(345, 566)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(94, 13)
        Me.Label34.TabIndex = 108
        Me.Label34.Text = "Motivo traslado"
        '
        'TxtMotivo
        '
        Me.TxtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMotivo.ForeColor = System.Drawing.Color.Blue
        Me.TxtMotivo.Location = New System.Drawing.Point(348, 583)
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(186, 50)
        Me.TxtMotivo.TabIndex = 107
        Me.TxtMotivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnMotivo
        '
        Me.BtnMotivo.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMotivo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnMotivo.Image = CType(resources.GetObject("BtnMotivo.Image"), System.Drawing.Image)
        Me.BtnMotivo.Location = New System.Drawing.Point(551, 583)
        Me.BtnMotivo.Name = "BtnMotivo"
        Me.BtnMotivo.Size = New System.Drawing.Size(37, 32)
        Me.BtnMotivo.TabIndex = 19
        Me.BtnMotivo.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.NombreProducto)
        Me.GroupBox6.Location = New System.Drawing.Point(21, 301)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(418, 84)
        Me.GroupBox6.TabIndex = 109
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre:"
        '
        'NombreRemitente
        '
        Me.NombreRemitente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreRemitente.ForeColor = System.Drawing.Color.Blue
        Me.NombreRemitente.Location = New System.Drawing.Point(59, 17)
        Me.NombreRemitente.Name = "NombreRemitente"
        Me.NombreRemitente.Size = New System.Drawing.Size(323, 23)
        Me.NombreRemitente.TabIndex = 3
        Me.NombreRemitente.Text = "         "
        Me.NombreRemitente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnremitente
        '
        Me.btnremitente.BackColor = System.Drawing.Color.Gainsboro
        Me.btnremitente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnremitente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremitente.Location = New System.Drawing.Point(388, 13)
        Me.btnremitente.Name = "btnremitente"
        Me.btnremitente.Size = New System.Drawing.Size(75, 27)
        Me.btnremitente.TabIndex = 4
        Me.btnremitente.Text = "Remitente"
        Me.btnremitente.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnremitente)
        Me.GroupBox1.Controls.Add(Me.NombreRemitente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 49)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Remitente"
        '
        'TxtPrec_Venta
        '
        Me.TxtPrec_Venta.Enabled = False
        Me.TxtPrec_Venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrec_Venta.Location = New System.Drawing.Point(709, 358)
        Me.TxtPrec_Venta.Name = "TxtPrec_Venta"
        Me.TxtPrec_Venta.Size = New System.Drawing.Size(70, 20)
        Me.TxtPrec_Venta.TabIndex = 68
        Me.TxtPrec_Venta.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(711, 342)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 110
        Me.Label17.Text = "Prec. Venta"
        '
        'TxtIGV
        '
        Me.TxtIGV.Enabled = False
        Me.TxtIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIGV.Location = New System.Drawing.Point(789, 358)
        Me.TxtIGV.Name = "TxtIGV"
        Me.TxtIGV.Size = New System.Drawing.Size(62, 20)
        Me.TxtIGV.TabIndex = 69
        Me.TxtIGV.Text = "0"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(791, 342)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(25, 13)
        Me.Label38.TabIndex = 112
        Me.Label38.Text = "IGV"
        '
        'frmguia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(906, 642)
        Me.Controls.Add(Me.TxtIGV)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.TxtPrec_Venta)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.TxtMotivo)
        Me.Controls.Add(Me.BtnMotivo)
        Me.Controls.Add(Me.Monto_deposito2)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Nro_constancia_deposito2)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnquitar_hpm)
        Me.Controls.Add(Me.btneditar_hpm)
        Me.Controls.Add(Me.btnnuevo_examen)
        Me.Controls.Add(Me.dgvmotivo)
        Me.Controls.Add(Me.Monto_deposito)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Nro_constancia_deposito)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.RucEmpTransporte)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.NombreEmpTransporte)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Detalle)
        Me.Controls.Add(Me.btnProducto)
        Me.Controls.Add(Me.cantidad_sacos)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.prod_peso_uni)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.fecha_inicio_traslado)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.fecha_emision_guia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ruc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nro_guia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.serie_guia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmguia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Guía de Remisión – Remitente"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvmotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents serie_guia As System.Windows.Forms.TextBox
    Friend WithEvents nro_guia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ruc As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents direccion_pto_partida As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents departamentoptop As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents provinciaptop As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents distritoptop As System.Windows.Forms.Label
    Friend WithEvents btnptopartida As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnptollegada As System.Windows.Forms.Button
    Friend WithEvents departamentoptoll As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents provinciaptoll As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents distritoptoll As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents fecha_emision_guia As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha_inicio_traslado As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDestinatario As System.Windows.Forms.Button
    Friend WithEvents rucdes As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents destinatario As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents nombre_tip_doc As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents nro_doc As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents nrocertificado_camion As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnTransporte As System.Windows.Forms.Button
    Friend WithEvents nroplaca_camion As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents marca_camion As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents prod_peso_uni As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents cantidad_sacos As System.Windows.Forms.TextBox
    Friend WithEvents NombreProducto As System.Windows.Forms.Label
    Friend WithEvents btnProducto As System.Windows.Forms.Button
    Friend WithEvents Detalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents NombreEmpTransporte As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents RucEmpTransporte As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Nro_constancia_deposito As System.Windows.Forms.TextBox
    Friend WithEvents Monto_deposito As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btnnuevo_examen As System.Windows.Forms.Button
    Friend WithEvents btneditar_hpm As System.Windows.Forms.Button
    Friend WithEvents btnquitar_hpm As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Selecciona As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgvmotivo As System.Windows.Forms.DataGridView
    Friend WithEvents Monto_deposito2 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Nro_constancia_deposito2 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents nroplaca_carreta As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents marca_carreta As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents nrocertificado_carreta As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents btnChofer As System.Windows.Forms.Button
    Friend WithEvents Nro_licencia_conductor As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TxtMotivo As System.Windows.Forms.Label
    Friend WithEvents BtnMotivo As System.Windows.Forms.Button
    Friend WithEvents direccion_pto_llegadaa As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NombreRemitente As System.Windows.Forms.Label
    Friend WithEvents btnremitente As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPrec_Venta As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtIGV As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id_det_guia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_prod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sacos_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unidad_medida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents x As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Peso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio_Venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGV As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

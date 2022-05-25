<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNota_ArroZ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNota_ArroZ))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtremitente = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.nro_guia = New System.Windows.Forms.Label()
        Me.serie_guia = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnGuia = New System.Windows.Forms.Button()
        Me.fecha_emision_guia = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.Label()
        Me.txttransportista = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.nroplaca_carreta = New System.Windows.Forms.Label()
        Me.nroplaca_camion = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTelef = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBrevete = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.a_cuenta = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.toneladas = New System.Windows.Forms.TextBox()
        Me.costo_flet = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Destinatario = New System.Windows.Forms.TextBox()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.observacion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Comentario = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_Ton_Sug = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btn_Precios = New System.Windows.Forms.Button()
        Me.Fecha_Precio = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_Prec = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnTrabaj = New System.Windows.Forms.Button()
        Me.txtTrabajador = New System.Windows.Forms.Label()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtremitente)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.nro_guia)
        Me.GroupBox4.Controls.Add(Me.serie_guia)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(329, 98)
        Me.GroupBox4.TabIndex = 155
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Guia de Remisión-Remitente"
        '
        'txtremitente
        '
        Me.txtremitente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtremitente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremitente.ForeColor = System.Drawing.Color.Firebrick
        Me.txtremitente.Location = New System.Drawing.Point(68, 65)
        Me.txtremitente.Name = "txtremitente"
        Me.txtremitente.Size = New System.Drawing.Size(255, 21)
        Me.txtremitente.TabIndex = 145
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(10, 67)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 13)
        Me.Label25.TabIndex = 144
        Me.Label25.Text = "Remitente:"
        '
        'nro_guia
        '
        Me.nro_guia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nro_guia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nro_guia.ForeColor = System.Drawing.Color.Firebrick
        Me.nro_guia.Location = New System.Drawing.Point(69, 35)
        Me.nro_guia.Name = "nro_guia"
        Me.nro_guia.Size = New System.Drawing.Size(94, 21)
        Me.nro_guia.TabIndex = 143
        '
        'serie_guia
        '
        Me.serie_guia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.serie_guia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serie_guia.ForeColor = System.Drawing.Color.Firebrick
        Me.serie_guia.Location = New System.Drawing.Point(12, 35)
        Me.serie_guia.Name = "serie_guia"
        Me.serie_guia.Size = New System.Drawing.Size(49, 21)
        Me.serie_guia.TabIndex = 142
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Serie"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(68, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Número"
        '
        'btnGuia
        '
        Me.btnGuia.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuia.Image = CType(resources.GetObject("btnGuia.Image"), System.Drawing.Image)
        Me.btnGuia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuia.Location = New System.Drawing.Point(343, 13)
        Me.btnGuia.Name = "btnGuia"
        Me.btnGuia.Size = New System.Drawing.Size(152, 49)
        Me.btnGuia.TabIndex = 0
        Me.btnGuia.Text = "Guia de Remisión Remitente"
        Me.btnGuia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuia.UseVisualStyleBackColor = False
        '
        'fecha_emision_guia
        '
        Me.fecha_emision_guia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_emision_guia.Location = New System.Drawing.Point(569, 28)
        Me.fecha_emision_guia.Name = "fecha_emision_guia"
        Me.fecha_emision_guia.Size = New System.Drawing.Size(100, 20)
        Me.fecha_emision_guia.TabIndex = 157
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(501, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "Fecha de Emisión:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtRuc)
        Me.GroupBox1.Controls.Add(Me.txttransportista)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 97)
        Me.GroupBox1.TabIndex = 159
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Transportista"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Transportista"
        '
        'txtRuc
        '
        Me.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.ForeColor = System.Drawing.Color.Maroon
        Me.txtRuc.Location = New System.Drawing.Point(97, 66)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(169, 23)
        Me.txtRuc.TabIndex = 140
        Me.txtRuc.Text = "         "
        Me.txtRuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txttransportista
        '
        Me.txttransportista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttransportista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttransportista.ForeColor = System.Drawing.Color.Maroon
        Me.txttransportista.Location = New System.Drawing.Point(97, 17)
        Me.txttransportista.Name = "txttransportista"
        Me.txttransportista.Size = New System.Drawing.Size(216, 41)
        Me.txttransportista.TabIndex = 136
        Me.txttransportista.Text = "         "
        Me.txttransportista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 114
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Ruc"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.nroplaca_carreta)
        Me.GroupBox2.Controls.Add(Me.nroplaca_camion)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Location = New System.Drawing.Point(350, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 97)
        Me.GroupBox2.TabIndex = 160
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Unidad de Transporte"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 29)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(139, 16)
        Me.Label22.TabIndex = 146
        Me.Label22.Text = "Nro. placa Remolque:"
        '
        'nroplaca_carreta
        '
        Me.nroplaca_carreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nroplaca_carreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nroplaca_carreta.ForeColor = System.Drawing.Color.Maroon
        Me.nroplaca_carreta.Location = New System.Drawing.Point(180, 63)
        Me.nroplaca_carreta.Name = "nroplaca_carreta"
        Me.nroplaca_carreta.Size = New System.Drawing.Size(117, 23)
        Me.nroplaca_carreta.TabIndex = 140
        Me.nroplaca_carreta.Text = "         "
        Me.nroplaca_carreta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nroplaca_camion
        '
        Me.nroplaca_camion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nroplaca_camion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nroplaca_camion.ForeColor = System.Drawing.Color.Maroon
        Me.nroplaca_camion.Location = New System.Drawing.Point(180, 26)
        Me.nroplaca_camion.Name = "nroplaca_camion"
        Me.nroplaca_camion.Size = New System.Drawing.Size(117, 23)
        Me.nroplaca_camion.TabIndex = 136
        Me.nroplaca_camion.Text = "         "
        Me.nroplaca_camion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(10, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 16)
        Me.Label19.TabIndex = 114
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 66)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(164, 16)
        Me.Label18.TabIndex = 116
        Me.Label18.Text = "Nro. placa Semiremolque:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTelef)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtapellido)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtBrevete)
        Me.GroupBox3.Controls.Add(Me.txtnombre)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 215)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(589, 88)
        Me.GroupBox3.TabIndex = 161
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Chofer"
        '
        'txtTelef
        '
        Me.txtTelef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelef.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtTelef.Location = New System.Drawing.Point(289, 48)
        Me.txtTelef.Name = "txtTelef"
        Me.txtTelef.Size = New System.Drawing.Size(128, 23)
        Me.txtTelef.TabIndex = 150
        Me.txtTelef.Text = "         "
        Me.txtTelef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(228, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "Telefono"
        '
        'txtapellido
        '
        Me.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtapellido.Location = New System.Drawing.Point(518, 15)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(54, 23)
        Me.txtapellido.TabIndex = 148
        Me.txtapellido.Text = "         "
        Me.txtapellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.txtapellido.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(445, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 147
        Me.Label10.Text = "Apellido"
        Me.Label10.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Nombre"
        '
        'txtBrevete
        '
        Me.txtBrevete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrevete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrevete.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtBrevete.Location = New System.Drawing.Point(69, 48)
        Me.txtBrevete.Name = "txtBrevete"
        Me.txtBrevete.Size = New System.Drawing.Size(128, 23)
        Me.txtBrevete.TabIndex = 140
        Me.txtBrevete.Text = "         "
        Me.txtBrevete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnombre
        '
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtnombre.Location = New System.Drawing.Point(69, 19)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(348, 23)
        Me.txtnombre.TabIndex = 136
        Me.txtnombre.Text = "         "
        Me.txtnombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 114
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Brevete"
        '
        'Total
        '
        Me.Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Total.Location = New System.Drawing.Point(569, 70)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(101, 22)
        Me.Total.TabIndex = 163
        Me.Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(501, 51)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(77, 16)
        Me.Label26.TabIndex = 162
        Me.Label26.Text = "Toneladas:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(200, 475)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 16)
        Me.Label12.TabIndex = 188
        Me.Label12.Text = "(SOLES)"
        '
        'a_cuenta
        '
        Me.a_cuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a_cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_cuenta.Location = New System.Drawing.Point(109, 471)
        Me.a_cuenta.Name = "a_cuenta"
        Me.a_cuenta.Size = New System.Drawing.Size(85, 20)
        Me.a_cuenta.TabIndex = 16
        Me.a_cuenta.Text = "1000.00"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(11, 475)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(62, 16)
        Me.Label27.TabIndex = 186
        Me.Label27.Text = "A Cuenta"
        '
        'toneladas
        '
        Me.toneladas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.toneladas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toneladas.Location = New System.Drawing.Point(281, 443)
        Me.toneladas.Name = "toneladas"
        Me.toneladas.Size = New System.Drawing.Size(85, 20)
        Me.toneladas.TabIndex = 14
        Me.toneladas.Text = "0"
        '
        'costo_flet
        '
        Me.costo_flet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.costo_flet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costo_flet.Location = New System.Drawing.Point(109, 440)
        Me.costo_flet.Name = "costo_flet"
        Me.costo_flet.Size = New System.Drawing.Size(85, 20)
        Me.costo_flet.TabIndex = 12
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 444)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 16)
        Me.Label21.TabIndex = 183
        Me.Label21.Text = "Costo de Flete"
        '
        'telefono
        '
        Me.telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono.Location = New System.Drawing.Point(556, 366)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(110, 20)
        Me.telefono.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(491, 367)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 16)
        Me.Label20.TabIndex = 181
        Me.Label20.Text = "Telefono"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 378)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 16)
        Me.Label17.TabIndex = 180
        Me.Label17.Text = "Destinatario"
        '
        'Destinatario
        '
        Me.Destinatario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Destinatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Destinatario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Destinatario.Location = New System.Drawing.Point(109, 372)
        Me.Destinatario.Name = "Destinatario"
        Me.Destinatario.Size = New System.Drawing.Size(251, 20)
        Me.Destinatario.TabIndex = 2
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(544, 452)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(120, 49)
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
        Me.btncancelar.ForeColor = System.Drawing.Color.Blue
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(544, 507)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(120, 48)
        Me.btncancelar.TabIndex = 24
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'observacion
        '
        Me.observacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.observacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.observacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.observacion.Location = New System.Drawing.Point(109, 504)
        Me.observacion.Name = "observacion"
        Me.observacion.Size = New System.Drawing.Size(272, 21)
        Me.observacion.TabIndex = 18
        Me.observacion.Text = "FT/"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 506)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 16)
        Me.Label13.TabIndex = 191
        Me.Label13.Text = "Observacion:"
        '
        'Comentario
        '
        Me.Comentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Comentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Comentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comentario.Location = New System.Drawing.Point(109, 534)
        Me.Comentario.Name = "Comentario"
        Me.Comentario.Size = New System.Drawing.Size(374, 21)
        Me.Comentario.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 537)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 193
        Me.Label14.Text = "Comentario:"
        '
        'direccion
        '
        Me.direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion.Location = New System.Drawing.Point(109, 408)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(367, 21)
        Me.direccion.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 410)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 16)
        Me.Label15.TabIndex = 195
        Me.Label15.Text = "Direccion:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(201, 444)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 16)
        Me.Label16.TabIndex = 197
        Me.Label16.Text = "Toneladas"
        '
        'txt_Ton_Sug
        '
        Me.txt_Ton_Sug.AutoSize = True
        Me.txt_Ton_Sug.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ton_Sug.ForeColor = System.Drawing.Color.Red
        Me.txt_Ton_Sug.Location = New System.Drawing.Point(384, 444)
        Me.txt_Ton_Sug.Name = "txt_Ton_Sug"
        Me.txt_Ton_Sug.Size = New System.Drawing.Size(0, 16)
        Me.txt_Ton_Sug.TabIndex = 198
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(415, 444)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(113, 16)
        Me.Label23.TabIndex = 199
        Me.Label23.Text = "  Tn. Sugeridas"
        '
        'btn_Precios
        '
        Me.btn_Precios.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_Precios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Precios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Precios.Image = CType(resources.GetObject("btn_Precios.Image"), System.Drawing.Image)
        Me.btn_Precios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Precios.Location = New System.Drawing.Point(13, 309)
        Me.btn_Precios.Name = "btn_Precios"
        Me.btn_Precios.Size = New System.Drawing.Size(142, 46)
        Me.btn_Precios.TabIndex = 2
        Me.btn_Precios.Text = "Precios de Arroz"
        Me.btn_Precios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Precios.UseVisualStyleBackColor = False
        '
        'Fecha_Precio
        '
        Me.Fecha_Precio.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.Fecha_Precio.Enabled = False
        Me.Fecha_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_Precio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_Precio.Location = New System.Drawing.Point(164, 331)
        Me.Fecha_Precio.Name = "Fecha_Precio"
        Me.Fecha_Precio.Size = New System.Drawing.Size(112, 24)
        Me.Fecha_Precio.TabIndex = 201
        '
        'Fecha_Prec
        '
        Me.Fecha_Prec.AutoSize = True
        Me.Fecha_Prec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_Prec.Location = New System.Drawing.Point(161, 315)
        Me.Fecha_Prec.Name = "Fecha_Prec"
        Me.Fecha_Prec.Size = New System.Drawing.Size(110, 13)
        Me.Fecha_Prec.TabIndex = 202
        Me.Fecha_Prec.Text = "Fecha de Precios:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(387, 507)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(128, 16)
        Me.Label24.TabIndex = 203
        Me.Label24.Text = "Facturas a enviar"
        '
        'btnTrabaj
        '
        Me.btnTrabaj.BackColor = System.Drawing.Color.Gainsboro
        Me.btnTrabaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrabaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrabaj.Image = CType(resources.GetObject("btnTrabaj.Image"), System.Drawing.Image)
        Me.btnTrabaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrabaj.Location = New System.Drawing.Point(287, 307)
        Me.btnTrabaj.Name = "btnTrabaj"
        Me.btnTrabaj.Size = New System.Drawing.Size(114, 47)
        Me.btnTrabaj.TabIndex = 4
        Me.btnTrabaj.Text = "Trabajador"
        Me.btnTrabaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTrabaj.UseVisualStyleBackColor = False
        '
        'txtTrabajador
        '
        Me.txtTrabajador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrabajador.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtTrabajador.Location = New System.Drawing.Point(407, 315)
        Me.txtTrabajador.Name = "txtTrabajador"
        Me.txtTrabajador.Size = New System.Drawing.Size(253, 23)
        Me.txtTrabajador.TabIndex = 205
        Me.txtTrabajador.Text = "         "
        Me.txtTrabajador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCliente
        '
        Me.BtnCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCliente.Image = CType(resources.GetObject("BtnCliente.Image"), System.Drawing.Image)
        Me.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCliente.Location = New System.Drawing.Point(369, 360)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(97, 42)
        Me.BtnCliente.TabIndex = 6
        Me.BtnCliente.Text = "Cliente"
        Me.BtnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCliente.UseVisualStyleBackColor = False
        '
        'FrmNota_ArroZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(676, 564)
        Me.Controls.Add(Me.BtnCliente)
        Me.Controls.Add(Me.txtTrabajador)
        Me.Controls.Add(Me.btnTrabaj)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Fecha_Precio)
        Me.Controls.Add(Me.Fecha_Prec)
        Me.Controls.Add(Me.btn_Precios)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txt_Ton_Sug)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Comentario)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.observacion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.a_cuenta)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.toneladas)
        Me.Controls.Add(Me.costo_flet)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Destinatario)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fecha_emision_guia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnGuia)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmNota_ArroZ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Nota de Envio - Venta de Arroz"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents nro_guia As System.Windows.Forms.Label
    Friend WithEvents serie_guia As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnGuia As System.Windows.Forms.Button
    Friend WithEvents fecha_emision_guia As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.Label
    Friend WithEvents txttransportista As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents nroplaca_carreta As System.Windows.Forms.Label
    Friend WithEvents nroplaca_camion As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelef As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtapellido As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBrevete As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents a_cuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents toneladas As System.Windows.Forms.TextBox
    Friend WithEvents costo_flet As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Destinatario As System.Windows.Forms.TextBox
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents observacion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Comentario As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_Ton_Sug As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtremitente As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btn_Precios As System.Windows.Forms.Button
    Friend WithEvents Fecha_Precio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_Prec As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnTrabaj As System.Windows.Forms.Button
    Friend WithEvents txtTrabajador As System.Windows.Forms.Label
    Friend WithEvents BtnCliente As System.Windows.Forms.Button
End Class

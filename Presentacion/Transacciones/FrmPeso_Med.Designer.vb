<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPeso_Med
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPeso_Med))
        Me.fecha_emision_guia = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.departamento = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.provincia = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.distrito = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ruc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NombreDestinatario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.observacion = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.peso_neto2 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.peso_neto1 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Conf_Vehi = New System.Windows.Forms.Label()
        Me.Pes_Veh = New System.Windows.Forms.Label()
        Me.ancho2 = New System.Windows.Forms.Label()
        Me.alto2 = New System.Windows.Forms.Label()
        Me.largo2 = New System.Windows.Forms.Label()
        Me.nroplaca_carreta = New System.Windows.Forms.Label()
        Me.ancho = New System.Windows.Forms.Label()
        Me.alto = New System.Windows.Forms.Label()
        Me.largo = New System.Windows.Forms.Label()
        Me.nroplaca_camion = New System.Windows.Forms.Label()
        Me.Pes_Transp = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGuia = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.nro_guia = New System.Windows.Forms.Label()
        Me.serie_guia = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtBonificacion = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'fecha_emision_guia
        '
        Me.fecha_emision_guia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_emision_guia.Location = New System.Drawing.Point(505, 13)
        Me.fecha_emision_guia.Name = "fecha_emision_guia"
        Me.fecha_emision_guia.Size = New System.Drawing.Size(100, 20)
        Me.fecha_emision_guia.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(405, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fecha de Emisión:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.departamento)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.provincia)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.distrito)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.direccion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ruc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NombreDestinatario)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 141)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Destinatario"
        '
        'departamento
        '
        Me.departamento.BackColor = System.Drawing.Color.White
        Me.departamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departamento.ForeColor = System.Drawing.Color.Blue
        Me.departamento.Location = New System.Drawing.Point(295, 96)
        Me.departamento.Name = "departamento"
        Me.departamento.Size = New System.Drawing.Size(123, 32)
        Me.departamento.TabIndex = 111
        Me.departamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(292, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "Departamento"
        '
        'provincia
        '
        Me.provincia.BackColor = System.Drawing.Color.White
        Me.provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.provincia.ForeColor = System.Drawing.Color.Blue
        Me.provincia.Location = New System.Drawing.Point(158, 96)
        Me.provincia.Name = "provincia"
        Me.provincia.Size = New System.Drawing.Size(123, 32)
        Me.provincia.TabIndex = 109
        Me.provincia.Text = " "
        Me.provincia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(158, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Provincia"
        '
        'distrito
        '
        Me.distrito.BackColor = System.Drawing.Color.White
        Me.distrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.distrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distrito.ForeColor = System.Drawing.Color.Blue
        Me.distrito.Location = New System.Drawing.Point(20, 96)
        Me.distrito.Name = "distrito"
        Me.distrito.Size = New System.Drawing.Size(123, 32)
        Me.distrito.TabIndex = 107
        Me.distrito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "Distrito"
        '
        'direccion
        '
        Me.direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.direccion.ForeColor = System.Drawing.Color.Blue
        Me.direccion.Location = New System.Drawing.Point(73, 53)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(323, 23)
        Me.direccion.TabIndex = 12
        Me.direccion.Text = "         "
        Me.direccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Direccción:"
        '
        'ruc
        '
        Me.ruc.BackColor = System.Drawing.Color.White
        Me.ruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ruc.ForeColor = System.Drawing.Color.Blue
        Me.ruc.Location = New System.Drawing.Point(447, 16)
        Me.ruc.Name = "ruc"
        Me.ruc.Size = New System.Drawing.Size(102, 21)
        Me.ruc.TabIndex = 9
        Me.ruc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(402, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "R.U.C."
        '
        'NombreDestinatario
        '
        Me.NombreDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreDestinatario.ForeColor = System.Drawing.Color.Blue
        Me.NombreDestinatario.Location = New System.Drawing.Point(73, 20)
        Me.NombreDestinatario.Name = "NombreDestinatario"
        Me.NombreDestinatario.Size = New System.Drawing.Size(323, 23)
        Me.NombreDestinatario.TabIndex = 3
        Me.NombreDestinatario.Text = "         "
        Me.NombreDestinatario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(25, 533)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 16)
        Me.Label21.TabIndex = 134
        Me.Label21.Text = "Observacion:"
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Blue
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(205, 570)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(123, 47)
        Me.btnaceptar.TabIndex = 3
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Blue
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(338, 570)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(124, 47)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'observacion
        '
        Me.observacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.observacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.observacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.observacion.Location = New System.Drawing.Point(132, 533)
        Me.observacion.Name = "observacion"
        Me.observacion.Size = New System.Drawing.Size(482, 22)
        Me.observacion.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.TxtBonificacion)
        Me.GroupBox2.Controls.Add(Me.peso_neto2)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.peso_neto1)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Conf_Vehi)
        Me.GroupBox2.Controls.Add(Me.Pes_Veh)
        Me.GroupBox2.Controls.Add(Me.ancho2)
        Me.GroupBox2.Controls.Add(Me.alto2)
        Me.GroupBox2.Controls.Add(Me.largo2)
        Me.GroupBox2.Controls.Add(Me.nroplaca_carreta)
        Me.GroupBox2.Controls.Add(Me.ancho)
        Me.GroupBox2.Controls.Add(Me.alto)
        Me.GroupBox2.Controls.Add(Me.largo)
        Me.GroupBox2.Controls.Add(Me.nroplaca_camion)
        Me.GroupBox2.Controls.Add(Me.Pes_Transp)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 238)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(608, 285)
        Me.GroupBox2.TabIndex = 140
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Unidad de Transporte"
        '
        'peso_neto2
        '
        Me.peso_neto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.peso_neto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.peso_neto2.ForeColor = System.Drawing.Color.Crimson
        Me.peso_neto2.Location = New System.Drawing.Point(447, 159)
        Me.peso_neto2.Name = "peso_neto2"
        Me.peso_neto2.Size = New System.Drawing.Size(123, 22)
        Me.peso_neto2.TabIndex = 151
        Me.peso_neto2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(424, 135)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(176, 16)
        Me.Label24.TabIndex = 150
        Me.Label24.Text = "Peso Neto Semi-Remolque:"
        '
        'peso_neto1
        '
        Me.peso_neto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.peso_neto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.peso_neto1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.peso_neto1.Location = New System.Drawing.Point(447, 66)
        Me.peso_neto1.Name = "peso_neto1"
        Me.peso_neto1.Size = New System.Drawing.Size(123, 22)
        Me.peso_neto1.TabIndex = 149
        Me.peso_neto1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(429, 47)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(141, 16)
        Me.Label23.TabIndex = 148
        Me.Label23.Text = "Peso Neto Remolque:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(139, 16)
        Me.Label22.TabIndex = 146
        Me.Label22.Text = "Nro. placa Remolque:"
        '
        'Conf_Vehi
        '
        Me.Conf_Vehi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conf_Vehi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conf_Vehi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Conf_Vehi.Location = New System.Drawing.Point(13, 217)
        Me.Conf_Vehi.Name = "Conf_Vehi"
        Me.Conf_Vehi.Size = New System.Drawing.Size(92, 22)
        Me.Conf_Vehi.TabIndex = 145
        Me.Conf_Vehi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pes_Veh
        '
        Me.Pes_Veh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pes_Veh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pes_Veh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Pes_Veh.Location = New System.Drawing.Point(180, 218)
        Me.Pes_Veh.Name = "Pes_Veh"
        Me.Pes_Veh.Size = New System.Drawing.Size(109, 22)
        Me.Pes_Veh.TabIndex = 144
        Me.Pes_Veh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ancho2
        '
        Me.ancho2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ancho2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancho2.ForeColor = System.Drawing.Color.Crimson
        Me.ancho2.Location = New System.Drawing.Point(153, 159)
        Me.ancho2.Name = "ancho2"
        Me.ancho2.Size = New System.Drawing.Size(123, 22)
        Me.ancho2.TabIndex = 143
        Me.ancho2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'alto2
        '
        Me.alto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.alto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alto2.ForeColor = System.Drawing.Color.Crimson
        Me.alto2.Location = New System.Drawing.Point(299, 159)
        Me.alto2.Name = "alto2"
        Me.alto2.Size = New System.Drawing.Size(123, 22)
        Me.alto2.TabIndex = 142
        Me.alto2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'largo2
        '
        Me.largo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.largo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.largo2.ForeColor = System.Drawing.Color.Crimson
        Me.largo2.Location = New System.Drawing.Point(13, 159)
        Me.largo2.Name = "largo2"
        Me.largo2.Size = New System.Drawing.Size(123, 22)
        Me.largo2.TabIndex = 141
        Me.largo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nroplaca_carreta
        '
        Me.nroplaca_carreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nroplaca_carreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nroplaca_carreta.ForeColor = System.Drawing.Color.Crimson
        Me.nroplaca_carreta.Location = New System.Drawing.Point(180, 105)
        Me.nroplaca_carreta.Name = "nroplaca_carreta"
        Me.nroplaca_carreta.Size = New System.Drawing.Size(159, 23)
        Me.nroplaca_carreta.TabIndex = 140
        Me.nroplaca_carreta.Text = "         "
        Me.nroplaca_carreta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ancho
        '
        Me.ancho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ancho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancho.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.ancho.Location = New System.Drawing.Point(153, 66)
        Me.ancho.Name = "ancho"
        Me.ancho.Size = New System.Drawing.Size(123, 22)
        Me.ancho.TabIndex = 139
        Me.ancho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'alto
        '
        Me.alto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.alto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alto.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.alto.Location = New System.Drawing.Point(298, 66)
        Me.alto.Name = "alto"
        Me.alto.Size = New System.Drawing.Size(123, 22)
        Me.alto.TabIndex = 138
        Me.alto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'largo
        '
        Me.largo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.largo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.largo.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.largo.Location = New System.Drawing.Point(9, 66)
        Me.largo.Name = "largo"
        Me.largo.Size = New System.Drawing.Size(123, 22)
        Me.largo.TabIndex = 137
        Me.largo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nroplaca_camion
        '
        Me.nroplaca_camion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nroplaca_camion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nroplaca_camion.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.nroplaca_camion.Location = New System.Drawing.Point(180, 19)
        Me.nroplaca_camion.Name = "nroplaca_camion"
        Me.nroplaca_camion.Size = New System.Drawing.Size(159, 23)
        Me.nroplaca_camion.TabIndex = 136
        Me.nroplaca_camion.Text = "         "
        Me.nroplaca_camion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pes_Transp
        '
        Me.Pes_Transp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pes_Transp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pes_Transp.Enabled = False
        Me.Pes_Transp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pes_Transp.Location = New System.Drawing.Point(336, 218)
        Me.Pes_Transp.Name = "Pes_Transp"
        Me.Pes_Transp.Size = New System.Drawing.Size(101, 22)
        Me.Pes_Transp.TabIndex = 135
        Me.Pes_Transp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(330, 199)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(186, 16)
        Me.Label20.TabIndex = 134
        Me.Label20.Text = "Peso Bruto Transportado:"
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(177, 199)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 16)
        Me.Label16.TabIndex = 131
        Me.Label16.Text = "Peso Bruto Vehicular:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 108)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(164, 16)
        Me.Label18.TabIndex = 116
        Me.Label18.Text = "Nro. placa Semiremolque:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 199)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 16)
        Me.Label15.TabIndex = 129
        Me.Label15.Text = "Configuracion Vehicular:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(150, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 16)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Ancho Remolque:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(298, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 16)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Alto Semiremolque:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 16)
        Me.Label17.TabIndex = 117
        Me.Label17.Text = "Largo Remolque:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(148, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(140, 16)
        Me.Label13.TabIndex = 125
        Me.Label13.Text = "Ancho Semiremolque:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(297, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 121
        Me.Label11.Text = "Alto Remolque:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 16)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "Largo Semiremolque:"
        '
        'btnGuia
        '
        Me.btnGuia.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuia.Image = CType(resources.GetObject("btnGuia.Image"), System.Drawing.Image)
        Me.btnGuia.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnGuia.Location = New System.Drawing.Point(242, 13)
        Me.btnGuia.Name = "btnGuia"
        Me.btnGuia.Size = New System.Drawing.Size(150, 49)
        Me.btnGuia.TabIndex = 0
        Me.btnGuia.Text = "Guia de Remision Remitente"
        Me.btnGuia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuia.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.nro_guia)
        Me.GroupBox3.Controls.Add(Me.serie_guia)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 72)
        Me.GroupBox3.TabIndex = 142
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Guia de Remision - Remitente"
        '
        'nro_guia
        '
        Me.nro_guia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nro_guia.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nro_guia.ForeColor = System.Drawing.Color.Firebrick
        Me.nro_guia.Location = New System.Drawing.Point(74, 39)
        Me.nro_guia.Name = "nro_guia"
        Me.nro_guia.Size = New System.Drawing.Size(94, 21)
        Me.nro_guia.TabIndex = 143
        '
        'serie_guia
        '
        Me.serie_guia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.serie_guia.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serie_guia.ForeColor = System.Drawing.Color.Firebrick
        Me.serie_guia.Location = New System.Drawing.Point(17, 39)
        Me.serie_guia.Name = "serie_guia"
        Me.serie_guia.Size = New System.Drawing.Size(49, 21)
        Me.serie_guia.TabIndex = 142
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Serie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Número"
        '
        'Total
        '
        Me.Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Total.Location = New System.Drawing.Point(488, 50)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(123, 22)
        Me.Total.TabIndex = 153
        Me.Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(405, 53)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(77, 16)
        Me.Label26.TabIndex = 152
        Me.Label26.Text = "Toneladas:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(10, 254)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(162, 16)
        Me.Label25.TabIndex = 153
        Me.Label25.Text = "Bonificacion Vehicular"
        '
        'TxtBonificacion
        '
        Me.TxtBonificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBonificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBonificacion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.TxtBonificacion.Location = New System.Drawing.Point(178, 251)
        Me.TxtBonificacion.Name = "TxtBonificacion"
        Me.TxtBonificacion.Size = New System.Drawing.Size(416, 23)
        Me.TxtBonificacion.TabIndex = 152
        Me.TxtBonificacion.Text = "         "
        Me.TxtBonificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmPeso_Med
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(631, 627)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnGuia)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.observacion)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fecha_emision_guia)
        Me.Controls.Add(Me.Label8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmPeso_Med"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Constancia de Verificacion de Pesos y Medidas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fecha_emision_guia As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NombreDestinatario As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ruc As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents direccion As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents departamento As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents provincia As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents distrito As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents observacion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Conf_Vehi As System.Windows.Forms.Label
    Friend WithEvents Pes_Veh As System.Windows.Forms.Label
    Friend WithEvents ancho2 As System.Windows.Forms.Label
    Friend WithEvents alto2 As System.Windows.Forms.Label
    Friend WithEvents largo2 As System.Windows.Forms.Label
    Friend WithEvents nroplaca_carreta As System.Windows.Forms.Label
    Friend WithEvents ancho As System.Windows.Forms.Label
    Friend WithEvents alto As System.Windows.Forms.Label
    Friend WithEvents largo As System.Windows.Forms.Label
    Friend WithEvents nroplaca_camion As System.Windows.Forms.Label
    Friend WithEvents Pes_Transp As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnGuia As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents nro_guia As System.Windows.Forms.Label
    Friend WithEvents serie_guia As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents peso_neto1 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents peso_neto2 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtBonificacion As System.Windows.Forms.Label
End Class

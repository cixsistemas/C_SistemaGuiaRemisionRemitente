'Imports Negocio
Public Class FMenuGuia

    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotaDeEnvioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesoMedidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimienttoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DestinatarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemitenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnidadDeTransporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SunatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagoDeDetraccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FleteTransportistaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlGuiasFacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContenidoDelSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TrabajadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbigeoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TablasSunatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDeComprobanteDePagoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TipoDeDctoDeIdentidadTabla2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrabajadorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TipoDeTrabajadorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TipoDeClienteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TipoDeOperacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnidadDeTransporteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TransportistaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ChoferToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OperacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnvioDeComprobantesDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EnvaseToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EnvaseToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ComisionistaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevoluciónDeComprobantesDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IngresoDeComprobantesDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnvioDeComprobantesDePagoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DevoluciónDeComprobantesDePagoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ControlDeComprobantesDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents toolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelUsuario As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusFish As ToolStripStatusLabel
    Friend WithEvents DNIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMenuGuia))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagoDeDetraccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesoMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaDeEnvioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvioDeComprobantesDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevoluciónDeComprobantesDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MantenimienttoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvaseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvaseToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.UnidadDeTransporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransportistaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadDeTransporteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChoferToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.DestinatarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemitenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrabajadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrabajadorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeTrabajadorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ComisionistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbigeoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeOperacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.TablasSunatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeDctoDeIdentidadTabla2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeComprobanteDePagoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FleteTransportistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlGuiasFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.IngresoDeComprobantesDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvioDeComprobantesDePagoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevoluciónDeComprobantesDePagoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeComprobantesDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UtilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SunatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DNIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContenidoDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusFish = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 150
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.ToolStripSeparator2, Me.MantenimienttoToolStripMenuItem, Me.ToolStripSeparator1, Me.ReportesToolStripMenuItem, Me.ToolStripSeparator3, Me.UtilidadToolStripMenuItem, Me.ToolStripSeparator6, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(915, 28)
        Me.MenuStrip1.TabIndex = 60
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagoDeDetraccionToolStripMenuItem, Me.ToolStripSeparator10, Me.MenuPrincipalToolStripMenuItem, Me.PesoMedidaToolStripMenuItem, Me.NotaDeEnvioToolStripMenuItem, Me.ToolStripSeparator15, Me.FacturaToolStripMenuItem, Me.EnvioDeComprobantesDePagoToolStripMenuItem, Me.DevoluciónDeComprobantesDePagoToolStripMenuItem, Me.ToolStripSeparator7, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Image = CType(resources.GetObject("SistemaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.SistemaToolStripMenuItem.Text = "&Transacciones"
        '
        'PagoDeDetraccionToolStripMenuItem
        '
        Me.PagoDeDetraccionToolStripMenuItem.Image = CType(resources.GetObject("PagoDeDetraccionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PagoDeDetraccionToolStripMenuItem.Name = "PagoDeDetraccionToolStripMenuItem"
        Me.PagoDeDetraccionToolStripMenuItem.Size = New System.Drawing.Size(307, 26)
        Me.PagoDeDetraccionToolStripMenuItem.Text = "&Pago de Detracción"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(304, 6)
        '
        'MenuPrincipalToolStripMenuItem
        '
        Me.MenuPrincipalToolStripMenuItem.Image = CType(resources.GetObject("MenuPrincipalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenuPrincipalToolStripMenuItem.Name = "MenuPrincipalToolStripMenuItem"
        Me.MenuPrincipalToolStripMenuItem.Size = New System.Drawing.Size(307, 26)
        Me.MenuPrincipalToolStripMenuItem.Text = "&Guia de Remisión-Remitente"
        '
        'PesoMedidaToolStripMenuItem
        '
        Me.PesoMedidaToolStripMenuItem.Image = CType(resources.GetObject("PesoMedidaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PesoMedidaToolStripMenuItem.Name = "PesoMedidaToolStripMenuItem"
        Me.PesoMedidaToolStripMenuItem.Size = New System.Drawing.Size(307, 26)
        Me.PesoMedidaToolStripMenuItem.Text = "&Pesos y Medidas"
        '
        'NotaDeEnvioToolStripMenuItem
        '
        Me.NotaDeEnvioToolStripMenuItem.Image = CType(resources.GetObject("NotaDeEnvioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NotaDeEnvioToolStripMenuItem.Name = "NotaDeEnvioToolStripMenuItem"
        Me.NotaDeEnvioToolStripMenuItem.Size = New System.Drawing.Size(307, 26)
        Me.NotaDeEnvioToolStripMenuItem.Text = "&Nota de envio"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(304, 6)
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.Image = CType(resources.GetObject("FacturaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(307, 26)
        Me.FacturaToolStripMenuItem.Text = "&Ingreso de Comprobantes de Pago"
        '
        'EnvioDeComprobantesDePagoToolStripMenuItem
        '
        Me.EnvioDeComprobantesDePagoToolStripMenuItem.Image = CType(resources.GetObject("EnvioDeComprobantesDePagoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnvioDeComprobantesDePagoToolStripMenuItem.Name = "EnvioDeComprobantesDePagoToolStripMenuItem"
        Me.EnvioDeComprobantesDePagoToolStripMenuItem.Size = New System.Drawing.Size(307, 26)
        Me.EnvioDeComprobantesDePagoToolStripMenuItem.Text = "&Envio de Comprobantes de Pago"
        '
        'DevoluciónDeComprobantesDePagoToolStripMenuItem
        '
        Me.DevoluciónDeComprobantesDePagoToolStripMenuItem.Image = CType(resources.GetObject("DevoluciónDeComprobantesDePagoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DevoluciónDeComprobantesDePagoToolStripMenuItem.Name = "DevoluciónDeComprobantesDePagoToolStripMenuItem"
        Me.DevoluciónDeComprobantesDePagoToolStripMenuItem.Size = New System.Drawing.Size(307, 26)
        Me.DevoluciónDeComprobantesDePagoToolStripMenuItem.Text = "&Devolución de Comprobantes de Pago"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(304, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(307, 26)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 24)
        '
        'MantenimienttoToolStripMenuItem
        '
        Me.MantenimienttoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoToolStripMenuItem, Me.ToolStripSeparator4, Me.UnidadDeTransporteToolStripMenuItem, Me.ToolStripSeparator8, Me.DestinatarioToolStripMenuItem, Me.RemitenteToolStripMenuItem, Me.ToolStripSeparator9, Me.TrabajadorToolStripMenuItem, Me.ToolStripSeparator5, Me.ClienteToolStripMenuItem, Me.ToolStripSeparator14, Me.ComisionistaToolStripMenuItem, Me.ToolStripSeparator13, Me.ZonaToolStripMenuItem, Me.UbigeoToolStripMenuItem, Me.TipoDeOperacionToolStripMenuItem, Me.ToolStripSeparator12, Me.TablasSunatToolStripMenuItem})
        Me.MantenimienttoToolStripMenuItem.Image = CType(resources.GetObject("MantenimienttoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MantenimienttoToolStripMenuItem.Name = "MantenimienttoToolStripMenuItem"
        Me.MantenimienttoToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.MantenimienttoToolStripMenuItem.Text = "&Mantenimiento"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoToolStripMenuItem1, Me.EnvaseToolStripMenuItem1, Me.EnvaseToolStripMenuItem2, Me.CategoriaToolStripMenuItem1})
        Me.ProductoToolStripMenuItem.Image = CType(resources.GetObject("ProductoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.ProductoToolStripMenuItem.Text = "&Producto"
        '
        'ProductoToolStripMenuItem1
        '
        Me.ProductoToolStripMenuItem1.Name = "ProductoToolStripMenuItem1"
        Me.ProductoToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.ProductoToolStripMenuItem1.Text = "&Producto"
        '
        'EnvaseToolStripMenuItem1
        '
        Me.EnvaseToolStripMenuItem1.Name = "EnvaseToolStripMenuItem1"
        Me.EnvaseToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.EnvaseToolStripMenuItem1.Text = "&Logotipo"
        '
        'EnvaseToolStripMenuItem2
        '
        Me.EnvaseToolStripMenuItem2.Name = "EnvaseToolStripMenuItem2"
        Me.EnvaseToolStripMenuItem2.Size = New System.Drawing.Size(133, 22)
        Me.EnvaseToolStripMenuItem2.Text = "&Envase"
        '
        'CategoriaToolStripMenuItem1
        '
        Me.CategoriaToolStripMenuItem1.Name = "CategoriaToolStripMenuItem1"
        Me.CategoriaToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.CategoriaToolStripMenuItem1.Text = "&Categoria"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(187, 6)
        '
        'UnidadDeTransporteToolStripMenuItem
        '
        Me.UnidadDeTransporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransportistaToolStripMenuItem1, Me.UnidadDeTransporteToolStripMenuItem1, Me.ChoferToolStripMenuItem1})
        Me.UnidadDeTransporteToolStripMenuItem.Image = CType(resources.GetObject("UnidadDeTransporteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UnidadDeTransporteToolStripMenuItem.Name = "UnidadDeTransporteToolStripMenuItem"
        Me.UnidadDeTransporteToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.UnidadDeTransporteToolStripMenuItem.Text = "Transporte"
        '
        'TransportistaToolStripMenuItem1
        '
        Me.TransportistaToolStripMenuItem1.Name = "TransportistaToolStripMenuItem1"
        Me.TransportistaToolStripMenuItem1.Size = New System.Drawing.Size(205, 22)
        Me.TransportistaToolStripMenuItem1.Text = "&Transportista"
        '
        'UnidadDeTransporteToolStripMenuItem1
        '
        Me.UnidadDeTransporteToolStripMenuItem1.Name = "UnidadDeTransporteToolStripMenuItem1"
        Me.UnidadDeTransporteToolStripMenuItem1.Size = New System.Drawing.Size(205, 22)
        Me.UnidadDeTransporteToolStripMenuItem1.Text = "&Unidad de Transporte"
        '
        'ChoferToolStripMenuItem1
        '
        Me.ChoferToolStripMenuItem1.Name = "ChoferToolStripMenuItem1"
        Me.ChoferToolStripMenuItem1.Size = New System.Drawing.Size(205, 22)
        Me.ChoferToolStripMenuItem1.Text = "&Chofer"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(187, 6)
        '
        'DestinatarioToolStripMenuItem
        '
        Me.DestinatarioToolStripMenuItem.Image = CType(resources.GetObject("DestinatarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DestinatarioToolStripMenuItem.Name = "DestinatarioToolStripMenuItem"
        Me.DestinatarioToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.DestinatarioToolStripMenuItem.Text = "&Destinatario"
        '
        'RemitenteToolStripMenuItem
        '
        Me.RemitenteToolStripMenuItem.Image = CType(resources.GetObject("RemitenteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemitenteToolStripMenuItem.Name = "RemitenteToolStripMenuItem"
        Me.RemitenteToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.RemitenteToolStripMenuItem.Text = "&Remitente"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(187, 6)
        '
        'TrabajadorToolStripMenuItem
        '
        Me.TrabajadorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrabajadorToolStripMenuItem1, Me.TipoDeTrabajadorToolStripMenuItem1})
        Me.TrabajadorToolStripMenuItem.Image = CType(resources.GetObject("TrabajadorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TrabajadorToolStripMenuItem.Name = "TrabajadorToolStripMenuItem"
        Me.TrabajadorToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.TrabajadorToolStripMenuItem.Text = "&Trabajador"
        '
        'TrabajadorToolStripMenuItem1
        '
        Me.TrabajadorToolStripMenuItem1.Name = "TrabajadorToolStripMenuItem1"
        Me.TrabajadorToolStripMenuItem1.Size = New System.Drawing.Size(190, 22)
        Me.TrabajadorToolStripMenuItem1.Text = "&Trabajador"
        '
        'TipoDeTrabajadorToolStripMenuItem1
        '
        Me.TipoDeTrabajadorToolStripMenuItem1.Name = "TipoDeTrabajadorToolStripMenuItem1"
        Me.TipoDeTrabajadorToolStripMenuItem1.Size = New System.Drawing.Size(190, 22)
        Me.TipoDeTrabajadorToolStripMenuItem1.Text = "&Tipo de Trabajador"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(187, 6)
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem1, Me.TipoDeClienteToolStripMenuItem1})
        Me.ClienteToolStripMenuItem.Image = CType(resources.GetObject("ClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.ClienteToolStripMenuItem.Text = "&Cliente"
        '
        'ClienteToolStripMenuItem1
        '
        Me.ClienteToolStripMenuItem1.Name = "ClienteToolStripMenuItem1"
        Me.ClienteToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.ClienteToolStripMenuItem1.Text = "&Cliente"
        '
        'TipoDeClienteToolStripMenuItem1
        '
        Me.TipoDeClienteToolStripMenuItem1.Name = "TipoDeClienteToolStripMenuItem1"
        Me.TipoDeClienteToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.TipoDeClienteToolStripMenuItem1.Text = "&Tipo de Cliente"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(187, 6)
        '
        'ComisionistaToolStripMenuItem
        '
        Me.ComisionistaToolStripMenuItem.Image = CType(resources.GetObject("ComisionistaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ComisionistaToolStripMenuItem.Name = "ComisionistaToolStripMenuItem"
        Me.ComisionistaToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.ComisionistaToolStripMenuItem.Text = "&Comisionista"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(187, 6)
        '
        'ZonaToolStripMenuItem
        '
        Me.ZonaToolStripMenuItem.Image = CType(resources.GetObject("ZonaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ZonaToolStripMenuItem.Name = "ZonaToolStripMenuItem"
        Me.ZonaToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.ZonaToolStripMenuItem.Text = "&Zona"
        '
        'UbigeoToolStripMenuItem
        '
        Me.UbigeoToolStripMenuItem.Image = CType(resources.GetObject("UbigeoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UbigeoToolStripMenuItem.Name = "UbigeoToolStripMenuItem"
        Me.UbigeoToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.UbigeoToolStripMenuItem.Text = "&Ubigeo"
        '
        'TipoDeOperacionToolStripMenuItem
        '
        Me.TipoDeOperacionToolStripMenuItem.Image = CType(resources.GetObject("TipoDeOperacionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TipoDeOperacionToolStripMenuItem.Name = "TipoDeOperacionToolStripMenuItem"
        Me.TipoDeOperacionToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.TipoDeOperacionToolStripMenuItem.Text = "&Tipo de Operacion"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(187, 6)
        '
        'TablasSunatToolStripMenuItem
        '
        Me.TablasSunatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoDeDctoDeIdentidadTabla2ToolStripMenuItem, Me.TipoDeComprobanteDePagoToolStripMenuItem1, Me.OperacionToolStripMenuItem})
        Me.TablasSunatToolStripMenuItem.Image = CType(resources.GetObject("TablasSunatToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TablasSunatToolStripMenuItem.Name = "TablasSunatToolStripMenuItem"
        Me.TablasSunatToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.TablasSunatToolStripMenuItem.Text = "&Tablas Sunat"
        '
        'TipoDeDctoDeIdentidadTabla2ToolStripMenuItem
        '
        Me.TipoDeDctoDeIdentidadTabla2ToolStripMenuItem.Name = "TipoDeDctoDeIdentidadTabla2ToolStripMenuItem"
        Me.TipoDeDctoDeIdentidadTabla2ToolStripMenuItem.Size = New System.Drawing.Size(321, 22)
        Me.TipoDeDctoDeIdentidadTabla2ToolStripMenuItem.Text = "&Tipo de Dcto. de Identidad (Tabla 2)"
        '
        'TipoDeComprobanteDePagoToolStripMenuItem1
        '
        Me.TipoDeComprobanteDePagoToolStripMenuItem1.Name = "TipoDeComprobanteDePagoToolStripMenuItem1"
        Me.TipoDeComprobanteDePagoToolStripMenuItem1.Size = New System.Drawing.Size(321, 22)
        Me.TipoDeComprobanteDePagoToolStripMenuItem1.Text = "&Tipo de Comprobante de Pago (Tabla 10)"
        '
        'OperacionToolStripMenuItem
        '
        Me.OperacionToolStripMenuItem.Name = "OperacionToolStripMenuItem"
        Me.OperacionToolStripMenuItem.Size = New System.Drawing.Size(321, 22)
        Me.OperacionToolStripMenuItem.Text = "&Operacion (Tabla 12)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 24)
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturaVentaToolStripMenuItem, Me.FleteTransportistaToolStripMenuItem, Me.ControlGuiasFacturasToolStripMenuItem, Me.ToolStripSeparator16, Me.IngresoDeComprobantesDePagoToolStripMenuItem, Me.EnvioDeComprobantesDePagoToolStripMenuItem1, Me.DevoluciónDeComprobantesDePagoToolStripMenuItem1, Me.ControlDeComprobantesDePagoToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Image = CType(resources.GetObject("ReportesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.ReportesToolStripMenuItem.Text = "&Reportes"
        '
        'FacturaVentaToolStripMenuItem
        '
        Me.FacturaVentaToolStripMenuItem.Name = "FacturaVentaToolStripMenuItem"
        Me.FacturaVentaToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.FacturaVentaToolStripMenuItem.Text = "&Envios x Remitente"
        '
        'FleteTransportistaToolStripMenuItem
        '
        Me.FleteTransportistaToolStripMenuItem.Name = "FleteTransportistaToolStripMenuItem"
        Me.FleteTransportistaToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.FleteTransportistaToolStripMenuItem.Text = "&Flete-Transportista"
        '
        'ControlGuiasFacturasToolStripMenuItem
        '
        Me.ControlGuiasFacturasToolStripMenuItem.Name = "ControlGuiasFacturasToolStripMenuItem"
        Me.ControlGuiasFacturasToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.ControlGuiasFacturasToolStripMenuItem.Text = "&Facturas Enviadas "
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(300, 6)
        '
        'IngresoDeComprobantesDePagoToolStripMenuItem
        '
        Me.IngresoDeComprobantesDePagoToolStripMenuItem.Name = "IngresoDeComprobantesDePagoToolStripMenuItem"
        Me.IngresoDeComprobantesDePagoToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.IngresoDeComprobantesDePagoToolStripMenuItem.Text = "&Ingreso de Comprobantes de Pago"
        '
        'EnvioDeComprobantesDePagoToolStripMenuItem1
        '
        Me.EnvioDeComprobantesDePagoToolStripMenuItem1.Name = "EnvioDeComprobantesDePagoToolStripMenuItem1"
        Me.EnvioDeComprobantesDePagoToolStripMenuItem1.Size = New System.Drawing.Size(303, 22)
        Me.EnvioDeComprobantesDePagoToolStripMenuItem1.Text = "&Envio de Comprobantes de Pago"
        '
        'DevoluciónDeComprobantesDePagoToolStripMenuItem1
        '
        Me.DevoluciónDeComprobantesDePagoToolStripMenuItem1.Name = "DevoluciónDeComprobantesDePagoToolStripMenuItem1"
        Me.DevoluciónDeComprobantesDePagoToolStripMenuItem1.Size = New System.Drawing.Size(303, 22)
        Me.DevoluciónDeComprobantesDePagoToolStripMenuItem1.Text = "&Devolución de Comprobantes de Pago"
        '
        'ControlDeComprobantesDePagoToolStripMenuItem
        '
        Me.ControlDeComprobantesDePagoToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.ControlDeComprobantesDePagoToolStripMenuItem.Name = "ControlDeComprobantesDePagoToolStripMenuItem"
        Me.ControlDeComprobantesDePagoToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.ControlDeComprobantesDePagoToolStripMenuItem.Text = "&Control de Comprobantes de Pago"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 24)
        '
        'UtilidadToolStripMenuItem
        '
        Me.UtilidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.SunatToolStripMenuItem, Me.DNIToolStripMenuItem})
        Me.UtilidadToolStripMenuItem.Image = CType(resources.GetObject("UtilidadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UtilidadToolStripMenuItem.Name = "UtilidadToolStripMenuItem"
        Me.UtilidadToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.UtilidadToolStripMenuItem.Text = "&Utilitarios"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Image = CType(resources.GetObject("CalculadoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.CalculadoraToolStripMenuItem.Text = "&Calculadora"
        '
        'SunatToolStripMenuItem
        '
        Me.SunatToolStripMenuItem.Image = CType(resources.GetObject("SunatToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SunatToolStripMenuItem.Name = "SunatToolStripMenuItem"
        Me.SunatToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.SunatToolStripMenuItem.Text = "&Sunat"
        '
        'DNIToolStripMenuItem
        '
        Me.DNIToolStripMenuItem.Name = "DNIToolStripMenuItem"
        Me.DNIToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.DNIToolStripMenuItem.Text = "DNI"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 24)
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContenidoDelSistemaToolStripMenuItem, Me.ToolStripSeparator11, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Image = CType(resources.GetObject("AyudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.AyudaToolStripMenuItem.Text = "&Ayuda"
        '
        'ContenidoDelSistemaToolStripMenuItem
        '
        Me.ContenidoDelSistemaToolStripMenuItem.Image = CType(resources.GetObject("ContenidoDelSistemaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContenidoDelSistemaToolStripMenuItem.Name = "ContenidoDelSistemaToolStripMenuItem"
        Me.ContenidoDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.ContenidoDelSistemaToolStripMenuItem.Text = "&Contenido del Sistema"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(208, 6)
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Image = CType(resources.GetObject("AcercaDeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.AcercaDeToolStripMenuItem.Text = "&Acerca de"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabelUsuario, Me.ToolStripStatusFish})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 384)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(915, 27)
        Me.StatusStrip1.TabIndex = 73
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.AutoSize = False
        Me.toolStripStatusLabel1.BackColor = System.Drawing.Color.Black
        Me.toolStripStatusLabel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.toolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(223, 22)
        Me.toolStripStatusLabel1.Spring = True
        Me.toolStripStatusLabel1.Text = "    "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.AutoSize = False
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(223, 22)
        Me.ToolStripStatusLabel3.Spring = True
        Me.ToolStripStatusLabel3.Text = "    "
        '
        'ToolStripStatusLabelUsuario
        '
        Me.ToolStripStatusLabelUsuario.AutoSize = False
        Me.ToolStripStatusLabelUsuario.BackColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabelUsuario.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabelUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabelUsuario.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabelUsuario.Name = "ToolStripStatusLabelUsuario"
        Me.ToolStripStatusLabelUsuario.Size = New System.Drawing.Size(223, 22)
        Me.ToolStripStatusLabelUsuario.Spring = True
        Me.ToolStripStatusLabelUsuario.Text = "    "
        '
        'ToolStripStatusFish
        '
        Me.ToolStripStatusFish.AutoSize = False
        Me.ToolStripStatusFish.BackColor = System.Drawing.Color.Black
        Me.ToolStripStatusFish.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusFish.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusFish.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusFish.Name = "ToolStripStatusFish"
        Me.ToolStripStatusFish.Size = New System.Drawing.Size(223, 22)
        Me.ToolStripStatusFish.Spring = True
        '
        'FMenuGuia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(915, 411)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FMenuGuia"
        Me.Text = "SISTEMA DE IMPRESION DE DOCUMENTOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Dim cLec As New cLector
    'Dim cBita As New cBitacora


    Private Sub FMenuBib_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ''    Me.Text = "SISTEMA DE GUIA DE REMISON-REMITENTE << CONTADOR -- " + cLec.Mostrar_Lector_Usuario(Usuario) + " >>"
        ''Me.StatusStrip1.Items(0).Text = "  Fecha: " & Format(Now, "dd/MM/yyyy")
        toolStripStatusLabel1.Text = Format(Now, "LONG DATE")
        ToolStripStatusFish.Text = "><))))°> ... o0O ... <°((((><"

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel3.Text = "    Hora: " & TimeString
    End Sub

    Private Sub FMenuBib_Closed(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Closed
    End Sub



    Private Sub BtnSesion_Click(ByVal sender As Object, ByVal e As EventArgs)
        'If MessageBox.Show("Esta seguro que desea cerrar sesión", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '  FechaIng = Format(Now, "dd/MM/yyyy hh:mm:ss")
        '  cBita.Registrar_Salida_Bitacora(FechaIng)
        '  Me.Text = "SISTEMA DE GUIA DE REMISION-REMITENTE << CONTADOR >>"
        '  Dim FingSis As New FIngresoSistema
        '  Sesion = True
        '  MessageBox.Show("Ha cerrado sesión correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '  FingSis.ShowDialog()
        'End If
    End Sub

    Private Sub FMenuBib_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
        'If Sesion = False Then
        '  Me.Text = "SISTEMA DE GUIA DE REMISON-REMITENTE << CONTADOR -- " + cLec.Mostrar_Lector_Usuario(Usuario) + " >>"
        'End If
    End Sub

    Private Sub MenuPrincipalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuPrincipalToolStripMenuItem.Click
        Dim mRegPro As New frmguias
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub PesoMedidaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PesoMedidaToolStripMenuItem.Click
        Dim FMantpeso_med As New FrmPeso_Med2
        FMantpeso_med.MdiParent = Me
        FMantpeso_med.Show()
    End Sub

    Private Sub NotaDeEnvioToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles NotaDeEnvioToolStripMenuItem.Click
        Dim Fnot_paj As New FrmNota_ArroZ2
        Fnot_paj.MdiParent = Me
        Fnot_paj.Show()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub LogotipoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProductoToolStripMenuItem.Click

    End Sub
    Private Sub EnvaseToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
    Private Sub TransportistaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim mRegPro As New frmlemptransportes
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub UnidadDeTransporteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UnidadDeTransporteToolStripMenuItem.Click

    End Sub

    Private Sub ChoferToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim FMantchofer As New FrmChofer2
        FMantchofer.MdiParent = Me
        FMantchofer.Show()
    End Sub

    Private Sub DestinatarioToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DestinatarioToolStripMenuItem.Click
        Dim mRegPro As New frmmdestinario1
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub RemitenteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RemitenteToolStripMenuItem.Click
        Dim mRegPro As New frmlremitenteS
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub SunatToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SunatToolStripMenuItem.Click
        Dim FSunat As New FrmSunat
        FSunat.MdiParent = Me
        FSunat.Show()
    End Sub

    Private Sub PagoDeDetraccionToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PagoDeDetraccionToolStripMenuItem.Click
        Dim FPago As New FrmPago_Detra2
        FPago.MdiParent = Me
        FPago.Show()
    End Sub
    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Process.Start(Application.StartupPath + "\\CCalc.exe")
    End Sub

    Private Sub FacturaVentaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FacturaVentaToolStripMenuItem.Click
        Dim FRep As New FrmRepEnvioxEmp
        FRep.MdiParent = Me
        FRep.Show()
    End Sub

    Private Sub FleteTransportistaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FleteTransportistaToolStripMenuItem.Click
        Dim FRep As New FrmRep_Fle_Trans
        FRep.MdiParent = Me
        FRep.Show()
    End Sub

    Private Sub ControlGuiasFacturasToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ControlGuiasFacturasToolStripMenuItem.Click
        Dim FRep As New FrmRepCont_Gui_FT
        FRep.MdiParent = Me
        FRep.Show()
    End Sub

    Private Sub TipoDeTrabajadorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim mRegPro As New FrmTip_Trab2
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub TrabajadorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TrabajadorToolStripMenuItem.Click

    End Sub

    Private Sub TipoDeClienteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim mRegPro As New FrmTip_Cliente2
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub ZonaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ZonaToolStripMenuItem.Click
        Dim mRegPro As New FrmZona2
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClienteToolStripMenuItem.Click

    End Sub

    Private Sub DNIRENIECToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start("https://cel.reniec.gob.pe/valreg/valreg.do?accion=ini")
    End Sub


    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim mRegPro As New Acercarde
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub FacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaToolStripMenuItem.Click
        Dim mRegPro As New FrmIng_Comp1
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub UbigeoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbigeoToolStripMenuItem.Click
        Dim mRegPro As New FrmUbigeo1
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub TipoDeComprobanteDePagoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoDeComprobanteDePagoToolStripMenuItem1.Click
        Dim mRegPro As New FrmTipo_Comp_1
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub TipoDeDctoDeIdentidadTabla2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeDctoDeIdentidadTabla2ToolStripMenuItem.Click
        Dim mRegPro As New FrmTipo_Dcto_1
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub TrabajadorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TrabajadorToolStripMenuItem1.Click
        Dim mRegPro As New FrmTrabajador2
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub TipoDeTrabajadorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoDeTrabajadorToolStripMenuItem1.Click
        Dim mRegPro As New FrmTip_Trab2
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem1.Click
        Dim mRegPro As New FrmCliente2
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub TipoDeClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoDeClienteToolStripMenuItem1.Click
        Dim mRegPro As New FrmTip_Cliente2
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub TipoDeOperacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeOperacionToolStripMenuItem.Click
        Dim mRegPro As New FrmTipo_oPE_1
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub UnidadDeTransporteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UnidadDeTransporteToolStripMenuItem1.Click
        Dim mRegPro As New frmunidadtransportes
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub TransportistaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransportistaToolStripMenuItem1.Click
        Dim mRegPro As New frmlemptransportes
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub ChoferToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChoferToolStripMenuItem1.Click
        Dim mRegPro As New FrmChofer2
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub OperacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperacionToolStripMenuItem.Click
        Dim mRegPro As New FrmOperacion_1
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub ProductoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem1.Click
        Dim mRegPro As New frmproductos
        mRegPro.MdiParent = Me
        mRegPro.Show()
    End Sub

    Private Sub EnvaseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EnvaseToolStripMenuItem1.Click
        Dim mRegLogo As New FrmLoGo2
        mRegLogo.MdiParent = Me
        mRegLogo.Show()
    End Sub

    Private Sub EnvaseToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EnvaseToolStripMenuItem2.Click
        Dim mRegEnvas As New FrmEnvase2
        mRegEnvas.MdiParent = Me
        mRegEnvas.Show()
    End Sub

    Private Sub CategoriaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem1.Click
        Dim mRegCat As New FrmCategoria2
        mRegCat.MdiParent = Me
        mRegCat.Show()
    End Sub

    Private Sub ComisionistaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComisionistaToolStripMenuItem.Click
        Dim mRegCat As New FrmComisionista1
        mRegCat.MdiParent = Me
        mRegCat.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub EnvioDeComprobantesDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnvioDeComprobantesDePagoToolStripMenuItem.Click
        Dim mRegCat As New FrmEnv_Comp1
        mRegCat.MdiParent = Me
        mRegCat.Show()
    End Sub

    Private Sub DevoluciónDeComprobantesDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevoluciónDeComprobantesDePagoToolStripMenuItem.Click
        Dim mRegCat As New FrmDev_Comp1
        mRegCat.MdiParent = Me
        mRegCat.Show()
    End Sub

    Private Sub IngresoDeComprobantesDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeComprobantesDePagoToolStripMenuItem.Click
        Dim mRegCat As New FrmRep_Ing_Comp
        mRegCat.MdiParent = Me
        mRegCat.Show()
    End Sub

    Private Sub EnvioDeComprobantesDePagoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EnvioDeComprobantesDePagoToolStripMenuItem1.Click
        Dim mRegCat As New FrmRep_Envio_Comp
        mRegCat.MdiParent = Me
        mRegCat.Show()
    End Sub

    Private Sub DevoluciónDeComprobantesDePagoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DevoluciónDeComprobantesDePagoToolStripMenuItem1.Click
        Dim mRegCat As New FrmRep_Dev_Comp
        mRegCat.MdiParent = Me
        mRegCat.Show()
    End Sub

    Private Sub ControlDeComprobantesDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeComprobantesDePagoToolStripMenuItem.Click
        Dim mRegCat As New FrmRep_Con_Comp_Pago
        mRegCat.MdiParent = Me
        mRegCat.Show()
    End Sub
End Class

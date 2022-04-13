<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimiR
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImprimiR))
        Me.crvImprimir = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvImprimir
        '
        Me.crvImprimir.ActiveViewIndex = -1
        Me.crvImprimir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.crvImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.crvImprimir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvImprimir.Location = New System.Drawing.Point(0, 0)
        Me.crvImprimir.Name = "crvImprimir"
        Me.crvImprimir.SelectionFormula = ""
        Me.crvImprimir.ShowGroupTreeButton = False
        Me.crvImprimir.Size = New System.Drawing.Size(903, 703)
        Me.crvImprimir.TabIndex = 0
        Me.crvImprimir.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crvImprimir.ViewTimeSelectionFormula = ""
        '
        'frmImprimiR
        '
        Me.AccessibleDescription = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 703)
        Me.Controls.Add(Me.crvImprimir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmImprimiR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "frmImprimir"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvImprimir As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

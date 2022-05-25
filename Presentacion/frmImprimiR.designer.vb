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
        Me.btnExportarWord = New System.Windows.Forms.Button()
        Me.btnExportarPdf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'crvImprimir
        '
        Me.crvImprimir.ActiveViewIndex = -1
        Me.crvImprimir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.crvImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.crvImprimir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvImprimir.Location = New System.Drawing.Point(0, 0)
        Me.crvImprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.crvImprimir.Name = "crvImprimir"
        Me.crvImprimir.SelectionFormula = ""
        Me.crvImprimir.ShowGroupTreeButton = False
        Me.crvImprimir.Size = New System.Drawing.Size(864, 551)
        Me.crvImprimir.TabIndex = 0
        Me.crvImprimir.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel
        Me.crvImprimir.ToolPanelWidth = 267
        Me.crvImprimir.ViewTimeSelectionFormula = ""
        '
        'btnExportarWord
        '
        Me.btnExportarWord.BackColor = System.Drawing.Color.White
        Me.btnExportarWord.Image = Global.Presentacion.My.Resources.Resources.word
        Me.btnExportarWord.Location = New System.Drawing.Point(50, 80)
        Me.btnExportarWord.Name = "btnExportarWord"
        Me.btnExportarWord.Size = New System.Drawing.Size(69, 56)
        Me.btnExportarWord.TabIndex = 1
        Me.btnExportarWord.UseVisualStyleBackColor = False
        '
        'btnExportarPdf
        '
        Me.btnExportarPdf.BackColor = System.Drawing.Color.White
        Me.btnExportarPdf.Image = Global.Presentacion.My.Resources.Resources.pdf
        Me.btnExportarPdf.Location = New System.Drawing.Point(153, 80)
        Me.btnExportarPdf.Name = "btnExportarPdf"
        Me.btnExportarPdf.Size = New System.Drawing.Size(69, 56)
        Me.btnExportarPdf.TabIndex = 2
        Me.btnExportarPdf.UseVisualStyleBackColor = False
        '
        'frmImprimiR
        '
        Me.AccessibleDescription = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 551)
        Me.Controls.Add(Me.btnExportarPdf)
        Me.Controls.Add(Me.btnExportarWord)
        Me.Controls.Add(Me.crvImprimir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmImprimiR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "frmImprimir"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvImprimir As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnExportarWord As Button
    Friend WithEvents btnExportarPdf As Button
End Class

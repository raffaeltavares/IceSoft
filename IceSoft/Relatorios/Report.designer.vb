<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReport
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReport))
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnAnterior = New System.Windows.Forms.ToolStripButton()
        Me.btnProxima = New System.Windows.Forms.ToolStripButton()
        Me.btnZoomMenos = New System.Windows.Forms.ToolStripButton()
        Me.btnZoom = New System.Windows.Forms.ToolStripButton()
        Me.btnPdf = New System.Windows.Forms.ToolStripButton()
        Me.btnSair = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(2, 41)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(830, 590)
        Me.PrintPreviewControl1.TabIndex = 0
        Me.PrintPreviewControl1.Zoom = 1.0R
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowCurrentPage = True
        Me.PrintDialog1.AllowPrintToFile = False
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 15)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "..."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnImprimir, Me.btnAnterior, Me.btnProxima, Me.btnZoomMenos, Me.btnZoom, Me.btnPdf, Me.btnSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(834, 38)
        Me.ToolStrip1.TabIndex = 38
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnImprimir
        '
        Me.btnImprimir.AutoSize = False
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(35, 35)
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnAnterior
        '
        Me.btnAnterior.AutoSize = False
        Me.btnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(35, 35)
        Me.btnAnterior.Text = "Anterior"
        '
        'btnProxima
        '
        Me.btnProxima.AutoSize = False
        Me.btnProxima.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnProxima.Image = CType(resources.GetObject("btnProxima.Image"), System.Drawing.Image)
        Me.btnProxima.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProxima.Name = "btnProxima"
        Me.btnProxima.Size = New System.Drawing.Size(35, 35)
        Me.btnProxima.Text = "Próxima"
        '
        'btnZoomMenos
        '
        Me.btnZoomMenos.AutoSize = False
        Me.btnZoomMenos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnZoomMenos.Image = CType(resources.GetObject("btnZoomMenos.Image"), System.Drawing.Image)
        Me.btnZoomMenos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnZoomMenos.Name = "btnZoomMenos"
        Me.btnZoomMenos.Size = New System.Drawing.Size(35, 35)
        Me.btnZoomMenos.Text = "Zoom"
        '
        'btnZoom
        '
        Me.btnZoom.AutoSize = False
        Me.btnZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnZoom.Image = CType(resources.GetObject("btnZoom.Image"), System.Drawing.Image)
        Me.btnZoom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnZoom.Name = "btnZoom"
        Me.btnZoom.Size = New System.Drawing.Size(35, 35)
        Me.btnZoom.Text = "Zoom"
        '
        'btnPdf
        '
        Me.btnPdf.AutoSize = False
        Me.btnPdf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPdf.Image = CType(resources.GetObject("btnPdf.Image"), System.Drawing.Image)
        Me.btnPdf.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPdf.Name = "btnPdf"
        Me.btnPdf.Size = New System.Drawing.Size(35, 35)
        Me.btnPdf.Text = "Pdf"
        Me.btnPdf.Visible = False
        '
        'btnSair
        '
        Me.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(34, 35)
        Me.btnSair.Text = "Sair"
        '
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 633)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(800, 560)
        Me.Name = "FrmReport"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Relatório"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnImprimir As ToolStripButton
    Friend WithEvents btnAnterior As ToolStripButton
    Friend WithEvents btnProxima As ToolStripButton
    Friend WithEvents btnZoomMenos As ToolStripButton
    Friend WithEvents btnZoom As ToolStripButton
    Friend WithEvents btnSair As ToolStripButton
    Friend WithEvents btnPdf As ToolStripButton
End Class

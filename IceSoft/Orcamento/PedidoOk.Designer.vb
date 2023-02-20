<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPedidoOk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GrValor = New System.Windows.Forms.GroupBox()
        Me.lbTipoPagto = New System.Windows.Forms.Label()
        Me.LbTroco = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbVlReceb = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbValor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPedido = New System.Windows.Forms.Label()
        Me.GrValor.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrValor
        '
        Me.GrValor.BackColor = System.Drawing.Color.Transparent
        Me.GrValor.Controls.Add(Me.lbTipoPagto)
        Me.GrValor.Controls.Add(Me.LbTroco)
        Me.GrValor.Controls.Add(Me.Label6)
        Me.GrValor.Controls.Add(Me.lbVlReceb)
        Me.GrValor.Controls.Add(Me.Label4)
        Me.GrValor.Controls.Add(Me.LbValor)
        Me.GrValor.Controls.Add(Me.Label1)
        Me.GrValor.Location = New System.Drawing.Point(12, 112)
        Me.GrValor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrValor.Name = "GrValor"
        Me.GrValor.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrValor.Size = New System.Drawing.Size(519, 149)
        Me.GrValor.TabIndex = 45
        Me.GrValor.TabStop = False
        Me.GrValor.Text = "Total do pedido"
        '
        'lbTipoPagto
        '
        Me.lbTipoPagto.AutoSize = True
        Me.lbTipoPagto.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipoPagto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTipoPagto.Location = New System.Drawing.Point(312, 27)
        Me.lbTipoPagto.Name = "lbTipoPagto"
        Me.lbTipoPagto.Size = New System.Drawing.Size(27, 26)
        Me.lbTipoPagto.TabIndex = 8
        Me.lbTipoPagto.Text = "..."
        '
        'LbTroco
        '
        Me.LbTroco.AutoSize = True
        Me.LbTroco.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTroco.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbTroco.Location = New System.Drawing.Point(354, 80)
        Me.LbTroco.Name = "LbTroco"
        Me.LbTroco.Size = New System.Drawing.Size(23, 26)
        Me.LbTroco.TabIndex = 7
        Me.LbTroco.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(283, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 26)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Troco:"
        '
        'lbVlReceb
        '
        Me.lbVlReceb.AutoSize = True
        Me.lbVlReceb.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVlReceb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbVlReceb.Location = New System.Drawing.Point(172, 80)
        Me.lbVlReceb.Name = "lbVlReceb"
        Me.lbVlReceb.Size = New System.Drawing.Size(23, 26)
        Me.lbVlReceb.TabIndex = 5
        Me.lbVlReceb.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Valor recebido:"
        '
        'LbValor
        '
        Me.LbValor.AutoSize = True
        Me.LbValor.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbValor.Location = New System.Drawing.Point(171, 27)
        Me.LbValor.Name = "LbValor"
        Me.LbValor.Size = New System.Drawing.Size(29, 33)
        Me.LbValor.TabIndex = 3
        Me.LbValor.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Valor total:"
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizar.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFinalizar.Location = New System.Drawing.Point(12, 269)
        Me.btnFinalizar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(519, 69)
        Me.btnFinalizar.TabIndex = 46
        Me.btnFinalizar.Text = "Fechar    "
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 42)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Pedido Gravado"
        '
        'txtPedido
        '
        Me.txtPedido.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedido.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtPedido.Location = New System.Drawing.Point(50, 61)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.Size = New System.Drawing.Size(435, 31)
        Me.txtPedido.TabIndex = 48
        Me.txtPedido.Text = "..."
        Me.txtPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmPedidoOk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(543, 342)
        Me.Controls.Add(Me.txtPedido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.GrValor)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPedidoOk"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pedido Ok"
        Me.GrValor.ResumeLayout(False)
        Me.GrValor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrValor As GroupBox
    Friend WithEvents LbValor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbTipoPagto As Label
    Friend WithEvents LbTroco As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbVlReceb As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPedido As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFinalizar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.GrValor = New System.Windows.Forms.GroupBox()
        Me.LbValor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.LbData = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtValorReceb = New System.Windows.Forms.TextBox()
        Me.txtPedido = New System.Windows.Forms.Label()
        Me.GrValor.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSair.Location = New System.Drawing.Point(20, 267)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(180, 68)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'GrValor
        '
        Me.GrValor.BackColor = System.Drawing.Color.Transparent
        Me.GrValor.Controls.Add(Me.LbValor)
        Me.GrValor.Controls.Add(Me.Label1)
        Me.GrValor.Location = New System.Drawing.Point(20, 96)
        Me.GrValor.Name = "GrValor"
        Me.GrValor.Size = New System.Drawing.Size(439, 74)
        Me.GrValor.TabIndex = 42
        Me.GrValor.TabStop = False
        Me.GrValor.Text = "Total do pedido"
        '
        'LbValor
        '
        Me.LbValor.AutoSize = True
        Me.LbValor.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbValor.Location = New System.Drawing.Point(166, 27)
        Me.LbValor.Name = "LbValor"
        Me.LbValor.Size = New System.Drawing.Size(29, 33)
        Me.LbValor.TabIndex = 3
        Me.LbValor.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 27)
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
        Me.btnFinalizar.Location = New System.Drawing.Point(208, 267)
        Me.btnFinalizar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(251, 68)
        Me.btnFinalizar.TabIndex = 3
        Me.btnFinalizar.Text = "Confirmar Pagamento"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'LbData
        '
        Me.LbData.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LbData.Location = New System.Drawing.Point(24, 54)
        Me.LbData.Name = "LbData"
        Me.LbData.Size = New System.Drawing.Size(435, 32)
        Me.LbData.TabIndex = 39
        Me.LbData.Text = "..."
        Me.LbData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CbTipo
        '
        Me.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Items.AddRange(New Object() {"1-Dinheiro", "2-Cartão de Débito", "3-Cartão de Crédito"})
        Me.CbTipo.Location = New System.Drawing.Point(178, 183)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(267, 27)
        Me.CbTipo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 186)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 19)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Forma de Pagamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 228)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 19)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Valor Recebido: "
        '
        'TxtValorReceb
        '
        Me.TxtValorReceb.Location = New System.Drawing.Point(177, 225)
        Me.TxtValorReceb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtValorReceb.Name = "TxtValorReceb"
        Me.TxtValorReceb.Size = New System.Drawing.Size(98, 27)
        Me.TxtValorReceb.TabIndex = 2
        '
        'txtPedido
        '
        Me.txtPedido.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedido.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtPedido.Location = New System.Drawing.Point(24, 9)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.Size = New System.Drawing.Size(435, 36)
        Me.txtPedido.TabIndex = 46
        Me.txtPedido.Text = "..."
        Me.txtPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmFinalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(483, 347)
        Me.Controls.Add(Me.txtPedido)
        Me.Controls.Add(Me.TxtValorReceb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbTipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.GrValor)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.LbData)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFinalizar"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Finalizar Pedido"
        Me.GrValor.ResumeLayout(False)
        Me.GrValor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSair As Button
    Friend WithEvents GrValor As GroupBox
    Friend WithEvents LbValor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents LbData As Label
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtValorReceb As TextBox
    Friend WithEvents txtPedido As Label
End Class

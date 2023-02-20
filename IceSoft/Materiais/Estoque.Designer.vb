<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstoque))
        Me.txtMaterial = New System.Windows.Forms.Label()
        Me.txtQtEntrada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.GrValor = New System.Windows.Forms.GroupBox()
        Me.LbQt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.LbData = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDataEntrada = New System.Windows.Forms.TextBox()
        Me.GrValor.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMaterial
        '
        Me.txtMaterial.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterial.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtMaterial.Location = New System.Drawing.Point(23, 10)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(435, 36)
        Me.txtMaterial.TabIndex = 53
        Me.txtMaterial.Text = "..."
        Me.txtMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQtEntrada
        '
        Me.txtQtEntrada.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtEntrada.Location = New System.Drawing.Point(232, 187)
        Me.txtQtEntrada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQtEntrada.Name = "txtQtEntrada"
        Me.txtQtEntrada.Size = New System.Drawing.Size(132, 27)
        Me.txtQtEntrada.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 190)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 19)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Quantidade a Entrar: "
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSair.Location = New System.Drawing.Point(19, 268)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(180, 68)
        Me.btnSair.TabIndex = 49
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'GrValor
        '
        Me.GrValor.BackColor = System.Drawing.Color.Transparent
        Me.GrValor.Controls.Add(Me.LbQt)
        Me.GrValor.Controls.Add(Me.Label1)
        Me.GrValor.Location = New System.Drawing.Point(19, 97)
        Me.GrValor.Name = "GrValor"
        Me.GrValor.Size = New System.Drawing.Size(439, 74)
        Me.GrValor.TabIndex = 51
        Me.GrValor.TabStop = False
        Me.GrValor.Text = "Total do pedido"
        '
        'LbQt
        '
        Me.LbQt.AutoSize = True
        Me.LbQt.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbQt.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbQt.Location = New System.Drawing.Point(207, 27)
        Me.LbQt.Name = "LbQt"
        Me.LbQt.Size = New System.Drawing.Size(29, 33)
        Me.LbQt.TabIndex = 3
        Me.LbQt.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Estoque Atual: "
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.LimeGreen
        Me.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnOk.Location = New System.Drawing.Point(207, 268)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(251, 68)
        Me.btnOk.TabIndex = 48
        Me.btnOk.Text = "Confirmar Entrada"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'LbData
        '
        Me.LbData.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LbData.Location = New System.Drawing.Point(23, 55)
        Me.LbData.Name = "LbData"
        Me.LbData.Size = New System.Drawing.Size(435, 32)
        Me.LbData.TabIndex = 50
        Me.LbData.Text = "..."
        Me.LbData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 228)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 19)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Data da entrada: "
        '
        'txtDataEntrada
        '
        Me.txtDataEntrada.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataEntrada.Location = New System.Drawing.Point(232, 222)
        Me.txtDataEntrada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDataEntrada.Name = "txtDataEntrada"
        Me.txtDataEntrada.Size = New System.Drawing.Size(132, 27)
        Me.txtDataEntrada.TabIndex = 55
        '
        'FrmEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(476, 346)
        Me.Controls.Add(Me.txtDataEntrada)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaterial)
        Me.Controls.Add(Me.txtQtEntrada)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.GrValor)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.LbData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Entrada de estoque"
        Me.GrValor.ResumeLayout(False)
        Me.GrValor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMaterial As Label
    Friend WithEvents txtQtEntrada As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSair As Button
    Friend WithEvents GrValor As GroupBox
    Friend WithEvents LbQt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents LbData As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDataEntrada As TextBox
End Class

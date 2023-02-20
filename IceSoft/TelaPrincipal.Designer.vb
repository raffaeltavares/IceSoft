<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaPrincipal))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnFornecedores = New System.Windows.Forms.Button()
        Me.btnMateriais = New System.Windows.Forms.Button()
        Me.btnProdutos = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnPrecos = New System.Windows.Forms.Button()
        Me.btnOrcamento = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbUser = New System.Windows.Forms.Label()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.LbDescription = New System.Windows.Forms.Label()
        Me.btnPedidos = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnNfe = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LbCopyRight = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LbLicenca = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnLogof = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnFornecedores
        '
        Me.btnFornecedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFornecedores.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFornecedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFornecedores.Location = New System.Drawing.Point(58, 305)
        Me.btnFornecedores.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnFornecedores.Name = "btnFornecedores"
        Me.btnFornecedores.Size = New System.Drawing.Size(200, 156)
        Me.btnFornecedores.TabIndex = 4
        Me.btnFornecedores.Text = "Fornecedores F6"
        Me.btnFornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFornecedores.UseVisualStyleBackColor = True
        '
        'btnMateriais
        '
        Me.btnMateriais.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMateriais.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriais.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMateriais.Location = New System.Drawing.Point(283, 305)
        Me.btnMateriais.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnMateriais.Name = "btnMateriais"
        Me.btnMateriais.Size = New System.Drawing.Size(200, 156)
        Me.btnMateriais.TabIndex = 5
        Me.btnMateriais.Text = "Matéria Prima F7"
        Me.btnMateriais.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMateriais.UseVisualStyleBackColor = True
        '
        'btnProdutos
        '
        Me.btnProdutos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProdutos.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProdutos.Location = New System.Drawing.Point(508, 305)
        Me.btnProdutos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnProdutos.Name = "btnProdutos"
        Me.btnProdutos.Size = New System.Drawing.Size(200, 156)
        Me.btnProdutos.TabIndex = 6
        Me.btnProdutos.Text = "Produtos F8"
        Me.btnProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProdutos.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClientes.Location = New System.Drawing.Point(463, 142)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(184, 138)
        Me.btnClientes.TabIndex = 2
        Me.btnClientes.Text = "Clientes F4"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnPrecos
        '
        Me.btnPrecos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrecos.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrecos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrecos.Location = New System.Drawing.Point(261, 142)
        Me.btnPrecos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnPrecos.Name = "btnPrecos"
        Me.btnPrecos.Size = New System.Drawing.Size(184, 138)
        Me.btnPrecos.TabIndex = 1
        Me.btnPrecos.Text = "Catalogo F3"
        Me.btnPrecos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrecos.UseVisualStyleBackColor = True
        '
        'btnOrcamento
        '
        Me.btnOrcamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrcamento.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrcamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOrcamento.Location = New System.Drawing.Point(58, 142)
        Me.btnOrcamento.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnOrcamento.Name = "btnOrcamento"
        Me.btnOrcamento.Size = New System.Drawing.Size(184, 138)
        Me.btnOrcamento.TabIndex = 0
        Me.btnOrcamento.Text = "Novo Pedido F2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnOrcamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOrcamento.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(769, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuário:"
        '
        'LbUser
        '
        Me.LbUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbUser.AutoSize = True
        Me.LbUser.BackColor = System.Drawing.Color.Transparent
        Me.LbUser.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUser.Location = New System.Drawing.Point(836, 16)
        Me.LbUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbUser.Name = "LbUser"
        Me.LbUser.Size = New System.Drawing.Size(21, 19)
        Me.LbUser.TabIndex = 8
        Me.LbUser.Text = "..."
        '
        'btnConfig
        '
        Me.btnConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfig.Location = New System.Drawing.Point(689, 10)
        Me.btnConfig.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(36, 34)
        Me.btnConfig.TabIndex = 7
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'LbDescription
        '
        Me.LbDescription.AutoSize = True
        Me.LbDescription.BackColor = System.Drawing.Color.Transparent
        Me.LbDescription.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LbDescription.Location = New System.Drawing.Point(11, 90)
        Me.LbDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbDescription.Name = "LbDescription"
        Me.LbDescription.Size = New System.Drawing.Size(27, 26)
        Me.LbDescription.TabIndex = 11
        Me.LbDescription.Text = "..."
        '
        'btnPedidos
        '
        Me.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPedidos.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPedidos.Location = New System.Drawing.Point(664, 142)
        Me.btnPedidos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(184, 138)
        Me.btnPedidos.TabIndex = 3
        Me.btnPedidos.Text = "Pedidos F5"
        Me.btnPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPedidos.UseVisualStyleBackColor = True
        '
        'BtnNfe
        '
        Me.BtnNfe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNfe.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNfe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNfe.Location = New System.Drawing.Point(732, 305)
        Me.BtnNfe.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnNfe.Name = "BtnNfe"
        Me.BtnNfe.Size = New System.Drawing.Size(200, 156)
        Me.BtnNfe.TabIndex = 16
        Me.BtnNfe.Text = "Nota Fiscal eletrônica"
        Me.BtnNfe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNfe.UseVisualStyleBackColor = True
        Me.BtnNfe.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LbCopyRight, Me.ToolStripStatusLabel1, Me.LbLicenca})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 615)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1023, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LbCopyRight
        '
        Me.LbCopyRight.Name = "LbCopyRight"
        Me.LbCopyRight.Size = New System.Drawing.Size(16, 17)
        Me.LbCopyRight.Text = "..."
        Me.LbCopyRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(53, 17)
        Me.ToolStripStatusLabel1.Text = "Licença: "
        '
        'LbLicenca
        '
        Me.LbLicenca.Name = "LbLicenca"
        Me.LbLicenca.Size = New System.Drawing.Size(16, 17)
        Me.LbLicenca.Text = "..."
        '
        'btnLogof
        '
        Me.btnLogof.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogof.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogof.Location = New System.Drawing.Point(729, 10)
        Me.btnLogof.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnLogof.Name = "btnLogof"
        Me.btnLogof.Size = New System.Drawing.Size(36, 34)
        Me.btnLogof.TabIndex = 8
        Me.btnLogof.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 637)
        Me.Controls.Add(Me.btnLogof)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BtnNfe)
        Me.Controls.Add(Me.btnPedidos)
        Me.Controls.Add(Me.LbDescription)
        Me.Controls.Add(Me.btnConfig)
        Me.Controls.Add(Me.LbUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOrcamento)
        Me.Controls.Add(Me.btnPrecos)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnProdutos)
        Me.Controls.Add(Me.btnMateriais)
        Me.Controls.Add(Me.btnFornecedores)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnFornecedores As System.Windows.Forms.Button
    Friend WithEvents btnMateriais As System.Windows.Forms.Button
    Friend WithEvents btnProdutos As System.Windows.Forms.Button
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents btnPrecos As System.Windows.Forms.Button
    Friend WithEvents btnOrcamento As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LbUser As System.Windows.Forms.Label
    Friend WithEvents btnConfig As System.Windows.Forms.Button
    Friend WithEvents LbDescription As System.Windows.Forms.Label
    Friend WithEvents btnPedidos As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BtnNfe As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LbCopyRight As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents LbLicenca As ToolStripStatusLabel
    Friend WithEvents btnLogof As Button
End Class

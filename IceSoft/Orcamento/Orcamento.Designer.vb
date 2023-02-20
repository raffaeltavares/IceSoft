<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrcamento
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrcamento))
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DtvOrca = New System.Windows.Forms.DataGridView()
        Me.preview = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precototal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Img = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cObs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CChk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnRemoverCliente = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.LbCodClient = New System.Windows.Forms.Label()
        Me.LbNomeCliente = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbVendedor = New System.Windows.Forms.Label()
        Me.LbData = New System.Windows.Forms.Label()
        Me.TxtPedido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrValor = New System.Windows.Forms.GroupBox()
        Me.LbValor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbCPF = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.DtvOrca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GrValor.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinalizar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizar.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinalizar.Location = New System.Drawing.Point(496, 476)
        Me.btnFinalizar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(192, 68)
        Me.btnFinalizar.TabIndex = 3
        Me.btnFinalizar.Text = "Finalizar Pedido"
        Me.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(4, 66)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(170, 52)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Adicionar Produto F2"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DtvOrca
        '
        Me.DtvOrca.AllowUserToAddRows = False
        Me.DtvOrca.AllowUserToDeleteRows = False
        Me.DtvOrca.AllowUserToResizeRows = False
        Me.DtvOrca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtvOrca.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DtvOrca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtvOrca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.preview, Me.Codigo, Me.Descricao, Me.Quant, Me.PrecoUnit, Me.Precototal, Me.Img, Me.cObs, Me.cDel, Me.CChk})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtvOrca.DefaultCellStyle = DataGridViewCellStyle3
        Me.DtvOrca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DtvOrca.Location = New System.Drawing.Point(1, 124)
        Me.DtvOrca.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DtvOrca.MultiSelect = False
        Me.DtvOrca.Name = "DtvOrca"
        Me.DtvOrca.RowHeadersWidth = 10
        Me.DtvOrca.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtvOrca.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.DtvOrca.RowTemplate.Height = 50
        Me.DtvOrca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtvOrca.ShowCellErrors = False
        Me.DtvOrca.ShowRowErrors = False
        Me.DtvOrca.Size = New System.Drawing.Size(690, 338)
        Me.DtvOrca.TabIndex = 22
        '
        'preview
        '
        Me.preview.Description = "Modificar imagem manualmente"
        Me.preview.Frozen = True
        Me.preview.HeaderText = "Prev."
        Me.preview.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.preview.Name = "preview"
        Me.preview.ReadOnly = True
        Me.preview.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.preview.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.preview.ToolTipText = "Modificar imagem manualmente"
        Me.preview.Visible = False
        Me.preview.Width = 50
        '
        'Codigo
        '
        Me.Codigo.Frozen = True
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'Descricao
        '
        Me.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Descricao.DefaultCellStyle = DataGridViewCellStyle1
        Me.Descricao.HeaderText = "Descrição"
        Me.Descricao.Name = "Descricao"
        Me.Descricao.ReadOnly = True
        '
        'Quant
        '
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Quant.DefaultCellStyle = DataGridViewCellStyle2
        Me.Quant.HeaderText = "Quant"
        Me.Quant.Name = "Quant"
        Me.Quant.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Quant.Width = 70
        '
        'PrecoUnit
        '
        Me.PrecoUnit.HeaderText = "Preço Unit."
        Me.PrecoUnit.Name = "PrecoUnit"
        Me.PrecoUnit.ReadOnly = True
        '
        'Precototal
        '
        Me.Precototal.HeaderText = "Preço Total"
        Me.Precototal.Name = "Precototal"
        Me.Precototal.ReadOnly = True
        '
        'Img
        '
        Me.Img.HeaderText = "Img"
        Me.Img.Name = "Img"
        Me.Img.Visible = False
        '
        'cObs
        '
        Me.cObs.HeaderText = "Obs"
        Me.cObs.Name = "cObs"
        Me.cObs.Visible = False
        '
        'cDel
        '
        Me.cDel.HeaderText = "x"
        Me.cDel.Image = Global.IceSoft.My.Resources.Resources.redcross
        Me.cDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.cDel.Name = "cDel"
        Me.cDel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cDel.ToolTipText = "Remover Item"
        Me.cDel.Width = 40
        '
        'CChk
        '
        Me.CChk.FalseValue = "0"
        Me.CChk.HeaderText = "Select"
        Me.CChk.IndeterminateValue = "0"
        Me.CChk.Name = "CChk"
        Me.CChk.TrueValue = "1"
        Me.CChk.Visible = False
        '
        'btnRemoverCliente
        '
        Me.btnRemoverCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRemoverCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoverCliente.Location = New System.Drawing.Point(650, 82)
        Me.btnRemoverCliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemoverCliente.Name = "btnRemoverCliente"
        Me.btnRemoverCliente.Size = New System.Drawing.Size(36, 36)
        Me.btnRemoverCliente.TabIndex = 2
        Me.btnRemoverCliente.UseVisualStyleBackColor = True
        Me.btnRemoverCliente.Visible = False
        '
        'btnCliente
        '
        Me.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCliente.Location = New System.Drawing.Point(177, 66)
        Me.btnCliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(108, 52)
        Me.btnCliente.TabIndex = 1
        Me.btnCliente.Text = "Cliente F3"
        Me.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'LbCodClient
        '
        Me.LbCodClient.AutoSize = True
        Me.LbCodClient.Location = New System.Drawing.Point(663, 70)
        Me.LbCodClient.Name = "LbCodClient"
        Me.LbCodClient.Size = New System.Drawing.Size(16, 15)
        Me.LbCodClient.TabIndex = 7
        Me.LbCodClient.Text = "..."
        Me.LbCodClient.Visible = False
        '
        'LbNomeCliente
        '
        Me.LbNomeCliente.AutoSize = True
        Me.LbNomeCliente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomeCliente.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbNomeCliente.Location = New System.Drawing.Point(377, 69)
        Me.LbNomeCliente.Name = "LbNomeCliente"
        Me.LbNomeCliente.Size = New System.Drawing.Size(21, 19)
        Me.LbNomeCliente.TabIndex = 0
        Me.LbNomeCliente.Text = "..."
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnPrint)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.LbVendedor)
        Me.GroupBox3.Controls.Add(Me.LbData)
        Me.GroupBox3.Controls.Add(Me.TxtPedido)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(673, 53)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pedido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(364, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usuário:"
        '
        'LbVendedor
        '
        Me.LbVendedor.AutoSize = True
        Me.LbVendedor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbVendedor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbVendedor.Location = New System.Drawing.Point(433, 21)
        Me.LbVendedor.Name = "LbVendedor"
        Me.LbVendedor.Size = New System.Drawing.Size(21, 19)
        Me.LbVendedor.TabIndex = 2
        Me.LbVendedor.Text = "..."
        '
        'LbData
        '
        Me.LbData.AutoSize = True
        Me.LbData.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbData.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbData.Location = New System.Drawing.Point(132, 22)
        Me.LbData.Name = "LbData"
        Me.LbData.Size = New System.Drawing.Size(21, 19)
        Me.LbData.TabIndex = 1
        Me.LbData.Text = "..."
        '
        'TxtPedido
        '
        Me.TxtPedido.BackColor = System.Drawing.SystemColors.Control
        Me.TxtPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPedido.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPedido.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtPedido.Location = New System.Drawing.Point(12, 16)
        Me.TxtPedido.Name = "TxtPedido"
        Me.TxtPedido.ReadOnly = True
        Me.TxtPedido.Size = New System.Drawing.Size(107, 31)
        Me.TxtPedido.TabIndex = 0
        Me.TxtPedido.TabStop = False
        Me.TxtPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(307, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cliente:"
        '
        'GrValor
        '
        Me.GrValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrValor.BackColor = System.Drawing.Color.Transparent
        Me.GrValor.Controls.Add(Me.LbValor)
        Me.GrValor.Controls.Add(Me.Label1)
        Me.GrValor.Location = New System.Drawing.Point(4, 476)
        Me.GrValor.Name = "GrValor"
        Me.GrValor.Size = New System.Drawing.Size(300, 68)
        Me.GrValor.TabIndex = 37
        Me.GrValor.TabStop = False
        Me.GrValor.Text = "Total do pedido"
        '
        'LbValor
        '
        Me.LbValor.AutoSize = True
        Me.LbValor.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbValor.Location = New System.Drawing.Point(151, 19)
        Me.LbValor.Name = "LbValor"
        Me.LbValor.Size = New System.Drawing.Size(29, 33)
        Me.LbValor.TabIndex = 3
        Me.LbValor.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Valor total:"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowCurrentPage = True
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.BackColor = System.Drawing.Color.Tomato
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(311, 476)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(182, 68)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Cancelar e Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(329, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 19)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "CPF:"
        '
        'lbCPF
        '
        Me.lbCPF.AutoSize = True
        Me.lbCPF.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCPF.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbCPF.Location = New System.Drawing.Point(377, 92)
        Me.lbCPF.Name = "lbCPF"
        Me.lbCPF.Size = New System.Drawing.Size(21, 19)
        Me.lbCPF.TabIndex = 39
        Me.lbCPF.Text = "..."
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Remover"
        Me.DataGridViewImageColumn1.Image = Global.IceSoft.My.Resources.Resources.cancel
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.ToolTipText = "Remover Item"
        Me.DataGridViewImageColumn1.Width = 40
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Location = New System.Drawing.Point(630, 13)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(36, 36)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'FrmOrcamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(692, 556)
        Me.Controls.Add(Me.lbCPF)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LbCodClient)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.GrValor)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.LbNomeCliente)
        Me.Controls.Add(Me.btnRemoverCliente)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DtvOrca)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmOrcamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gerar Pedido"
        CType(Me.DtvOrca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GrValor.ResumeLayout(False)
        Me.GrValor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemoverCliente As System.Windows.Forms.Button
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LbNomeCliente As System.Windows.Forms.Label
    Friend WithEvents GrValor As System.Windows.Forms.GroupBox
    Friend WithEvents LbData As System.Windows.Forms.Label
    Friend WithEvents TxtPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LbVendedor As System.Windows.Forms.Label
    Friend WithEvents LbValor As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtvOrca As System.Windows.Forms.DataGridView
    Friend WithEvents LbCodClient As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents btnSair As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbCPF As Label
    Friend WithEvents preview As DataGridViewImageColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descricao As DataGridViewTextBoxColumn
    Friend WithEvents Quant As DataGridViewTextBoxColumn
    Friend WithEvents PrecoUnit As DataGridViewTextBoxColumn
    Friend WithEvents Precototal As DataGridViewTextBoxColumn
    Friend WithEvents Img As DataGridViewTextBoxColumn
    Friend WithEvents cObs As DataGridViewTextBoxColumn
    Friend WithEvents cDel As DataGridViewImageColumn
    Friend WithEvents CChk As DataGridViewCheckBoxColumn
    Friend WithEvents btnPrint As Button
End Class

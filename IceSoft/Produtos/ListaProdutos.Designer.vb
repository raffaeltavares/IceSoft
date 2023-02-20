<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaProdutos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaProdutos))
        Me.DtvProdutos = New System.Windows.Forms.DataGridView()
        Me.preview = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Custo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalBruto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tributos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MContribuicaoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MContribuicaoR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imagem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ChkMostrar = New System.Windows.Forms.CheckBox()
        Me.PLoading = New System.Windows.Forms.Panel()
        Me.LbPercent = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnDel = New System.Windows.Forms.ToolStripButton()
        Me.btnDuplicar = New System.Windows.Forms.ToolStripButton()
        Me.btnAtualizar = New System.Windows.Forms.ToolStripButton()
        Me.btnImport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.CbCategoria = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFiltro = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSair = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DtvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PLoading.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtvProdutos
        '
        Me.DtvProdutos.AllowUserToAddRows = False
        Me.DtvProdutos.AllowUserToDeleteRows = False
        Me.DtvProdutos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtvProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DtvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtvProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.preview, Me.Codigo, Me.Descricao, Me.Categoria, Me.Custo, Me.TotalBruto, Me.Preco, Me.Tributos, Me.MContribuicaoP, Me.MContribuicaoR, Me.Imagem})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtvProdutos.DefaultCellStyle = DataGridViewCellStyle1
        Me.DtvProdutos.Location = New System.Drawing.Point(0, 38)
        Me.DtvProdutos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DtvProdutos.Name = "DtvProdutos"
        Me.DtvProdutos.RowHeadersWidth = 10
        Me.DtvProdutos.RowTemplate.Height = 50
        Me.DtvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtvProdutos.Size = New System.Drawing.Size(1063, 575)
        Me.DtvProdutos.TabIndex = 7
        '
        'preview
        '
        Me.preview.Frozen = True
        Me.preview.HeaderText = "Preview"
        Me.preview.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.preview.Name = "preview"
        Me.preview.ReadOnly = True
        Me.preview.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.preview.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.preview.Width = 60
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Descricao
        '
        Me.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descricao.HeaderText = "Descrição"
        Me.Descricao.Name = "Descricao"
        Me.Descricao.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Visible = False
        '
        'Custo
        '
        Me.Custo.HeaderText = "Vl. Custo"
        Me.Custo.Name = "Custo"
        Me.Custo.ReadOnly = True
        '
        'TotalBruto
        '
        Me.TotalBruto.HeaderText = "Vl. Bruto"
        Me.TotalBruto.Name = "TotalBruto"
        '
        'Preco
        '
        Me.Preco.HeaderText = "Vl. Liquido"
        Me.Preco.Name = "Preco"
        Me.Preco.ReadOnly = True
        '
        'Tributos
        '
        Me.Tributos.HeaderText = "Vl. Tributos"
        Me.Tributos.Name = "Tributos"
        Me.Tributos.ReadOnly = True
        '
        'MContribuicaoP
        '
        Me.MContribuicaoP.HeaderText = "Ganho %"
        Me.MContribuicaoP.Name = "MContribuicaoP"
        Me.MContribuicaoP.ReadOnly = True
        '
        'MContribuicaoR
        '
        Me.MContribuicaoR.HeaderText = "Ganho R$"
        Me.MContribuicaoR.Name = "MContribuicaoR"
        Me.MContribuicaoR.ReadOnly = True
        '
        'Imagem
        '
        Me.Imagem.HeaderText = "Imagem"
        Me.Imagem.Name = "Imagem"
        Me.Imagem.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "*.xlsx"
        Me.OpenFileDialog1.Title = "Importar Materiais"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.StripAmpersands = True
        Me.ToolTip1.ToolTipTitle = "Informações do Produto"
        '
        'ChkMostrar
        '
        Me.ChkMostrar.AutoSize = True
        Me.ChkMostrar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ChkMostrar.Location = New System.Drawing.Point(625, 12)
        Me.ChkMostrar.Name = "ChkMostrar"
        Me.ChkMostrar.Size = New System.Drawing.Size(264, 19)
        Me.ChkMostrar.TabIndex = 38
        Me.ChkMostrar.Text = "Mostrar informações do produto em janela"
        Me.ChkMostrar.UseVisualStyleBackColor = False
        '
        'PLoading
        '
        Me.PLoading.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PLoading.Controls.Add(Me.LbPercent)
        Me.PLoading.Controls.Add(Me.PictureBox1)
        Me.PLoading.Location = New System.Drawing.Point(452, 323)
        Me.PLoading.Name = "PLoading"
        Me.PLoading.Size = New System.Drawing.Size(56, 75)
        Me.PLoading.TabIndex = 39
        Me.PLoading.Visible = False
        '
        'LbPercent
        '
        Me.LbPercent.AutoSize = True
        Me.LbPercent.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPercent.Location = New System.Drawing.Point(23, 56)
        Me.LbPercent.Name = "LbPercent"
        Me.LbPercent.Size = New System.Drawing.Size(13, 14)
        Me.LbPercent.TabIndex = 6
        Me.LbPercent.Text = "..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IceSoft.My.Resources.Resources.ajax_loader
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEditar, Me.btnDel, Me.btnDuplicar, Me.btnAtualizar, Me.btnImport, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.CbCategoria, Me.ToolStripSeparator3, Me.ToolStripLabel3, Me.txtFiltro, Me.ToolStripSeparator4, Me.btnSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1064, 35)
        Me.ToolStrip1.TabIndex = 41
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(34, 32)
        Me.btnAdd.Text = "Adicionar"
        '
        'btnEditar
        '
        Me.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(34, 32)
        Me.btnEditar.Text = "Editar"
        '
        'btnDel
        '
        Me.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDel.Image = CType(resources.GetObject("btnDel.Image"), System.Drawing.Image)
        Me.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(34, 32)
        Me.btnDel.Text = "Remover"
        '
        'btnDuplicar
        '
        Me.btnDuplicar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDuplicar.Image = CType(resources.GetObject("btnDuplicar.Image"), System.Drawing.Image)
        Me.btnDuplicar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDuplicar.Name = "btnDuplicar"
        Me.btnDuplicar.Size = New System.Drawing.Size(34, 32)
        Me.btnDuplicar.Text = "Duplicar"
        '
        'btnAtualizar
        '
        Me.btnAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAtualizar.Image = CType(resources.GetObject("btnAtualizar.Image"), System.Drawing.Image)
        Me.btnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(34, 32)
        Me.btnAtualizar.Text = "Atualizar Preços"
        '
        'btnImport
        '
        Me.btnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(34, 32)
        Me.btnImport.Text = "Importar"
        Me.btnImport.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 35)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(72, 32)
        Me.ToolStripLabel2.Text = "CATEGORIA:"
        '
        'CbCategoria
        '
        Me.CbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.CbCategoria.Name = "CbCategoria"
        Me.CbCategoria.Size = New System.Drawing.Size(121, 35)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 35)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(73, 32)
        Me.ToolStripLabel3.Text = "PESQUISAR: "
        '
        'txtFiltro
        '
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(100, 35)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 35)
        '
        'btnSair
        '
        Me.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(34, 32)
        Me.btnSair.Text = "Sair"
        '
        'Timer1
        '
        '
        'ListaProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1064, 617)
        Me.Controls.Add(Me.ChkMostrar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PLoading)
        Me.Controls.Add(Me.DtvProdutos)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ListaProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastro de Produtos"
        CType(Me.DtvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PLoading.ResumeLayout(False)
        Me.PLoading.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtvProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ChkMostrar As System.Windows.Forms.CheckBox
    Friend WithEvents PLoading As System.Windows.Forms.Panel
    Friend WithEvents LbPercent As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnDel As ToolStripButton
    Friend WithEvents btnDuplicar As ToolStripButton
    Friend WithEvents btnImport As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents CbCategoria As ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents txtFiltro As ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btnSair As ToolStripButton
    Friend WithEvents btnAtualizar As ToolStripButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents preview As DataGridViewImageColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descricao As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Custo As DataGridViewTextBoxColumn
    Friend WithEvents TotalBruto As DataGridViewTextBoxColumn
    Friend WithEvents Preco As DataGridViewTextBoxColumn
    Friend WithEvents Tributos As DataGridViewTextBoxColumn
    Friend WithEvents MContribuicaoP As DataGridViewTextBoxColumn
    Friend WithEvents MContribuicaoR As DataGridViewTextBoxColumn
    Friend WithEvents Imagem As DataGridViewTextBoxColumn
End Class

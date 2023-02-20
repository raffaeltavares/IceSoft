<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatalogoProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CatalogoProdutos))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descrição = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Categoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Linha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Preço = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Path = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.RdGrade = New System.Windows.Forms.RadioButton()
        Me.RdLista = New System.Windows.Forms.RadioButton()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PLoading = New System.Windows.Forms.Panel()
        Me.LbPercent = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ChkMostrar = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PicPreview = New System.Windows.Forms.PictureBox()
        Me.PLoading.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Descrição, Me.Categoria, Me.Linha, Me.Preço, Me.Path})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.LargeImageList = Me.ImgList
        Me.ListView1.Location = New System.Drawing.Point(286, 61)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(553, 490)
        Me.ListView1.SmallImageList = Me.ImgList
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Codigo
        '
        Me.Codigo.Text = "Codigo"
        Me.Codigo.Width = 150
        '
        'Descrição
        '
        Me.Descrição.Text = "Descrição"
        Me.Descrição.Width = 350
        '
        'Categoria
        '
        Me.Categoria.DisplayIndex = 4
        Me.Categoria.Text = "Categoria"
        Me.Categoria.Width = 80
        '
        'Linha
        '
        Me.Linha.Text = "Linha"
        Me.Linha.Width = 80
        '
        'Preço
        '
        Me.Preço.DisplayIndex = 2
        Me.Preço.Text = "Preço"
        Me.Preço.Width = 100
        '
        'Path
        '
        Me.Path.Text = "Imagem"
        Me.Path.Width = 150
        '
        'ImgList
        '
        Me.ImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.ImgList.ImageSize = New System.Drawing.Size(50, 50)
        Me.ImgList.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(763, 9)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(76, 43)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "FILTRAR:"
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Location = New System.Drawing.Point(13, 32)
        Me.TxtFiltro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(161, 23)
        Me.TxtFiltro.TabIndex = 0
        '
        'RdGrade
        '
        Me.RdGrade.Appearance = System.Windows.Forms.Appearance.Button
        Me.RdGrade.Location = New System.Drawing.Point(181, 20)
        Me.RdGrade.Name = "RdGrade"
        Me.RdGrade.Size = New System.Drawing.Size(35, 35)
        Me.RdGrade.TabIndex = 3
        Me.RdGrade.TabStop = True
        Me.RdGrade.UseVisualStyleBackColor = True
        '
        'RdLista
        '
        Me.RdLista.Appearance = System.Windows.Forms.Appearance.Button
        Me.RdLista.Location = New System.Drawing.Point(216, 20)
        Me.RdLista.Name = "RdLista"
        Me.RdLista.Size = New System.Drawing.Size(35, 35)
        Me.RdLista.TabIndex = 4
        Me.RdLista.TabStop = True
        Me.RdLista.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PLoading
        '
        Me.PLoading.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PLoading.Controls.Add(Me.LbPercent)
        Me.PLoading.Controls.Add(Me.PictureBox1)
        Me.PLoading.Location = New System.Drawing.Point(494, 270)
        Me.PLoading.Name = "PLoading"
        Me.PLoading.Size = New System.Drawing.Size(56, 75)
        Me.PLoading.TabIndex = 37
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
        Me.PictureBox1.Image = Global.IceSoft.My.Resources.Resources.ajax_loading_2x
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ChkMostrar
        '
        Me.ChkMostrar.AutoSize = True
        Me.ChkMostrar.Location = New System.Drawing.Point(263, 36)
        Me.ChkMostrar.Name = "ChkMostrar"
        Me.ChkMostrar.Size = New System.Drawing.Size(117, 19)
        Me.ChkMostrar.TabIndex = 39
        Me.ChkMostrar.Text = "Mostrar Imagem"
        Me.ChkMostrar.UseVisualStyleBackColor = True
        Me.ChkMostrar.Visible = False
        '
        'Timer1
        '
        '
        'PicPreview
        '
        Me.PicPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicPreview.BackColor = System.Drawing.SystemColors.Window
        Me.PicPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PicPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicPreview.Location = New System.Drawing.Point(0, 61)
        Me.PicPreview.Name = "PicPreview"
        Me.PicPreview.Size = New System.Drawing.Size(289, 490)
        Me.PicPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicPreview.TabIndex = 40
        Me.PicPreview.TabStop = False
        '
        'CatalogoProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(841, 552)
        Me.Controls.Add(Me.PLoading)
        Me.Controls.Add(Me.PicPreview)
        Me.Controls.Add(Me.ChkMostrar)
        Me.Controls.Add(Me.RdLista)
        Me.Controls.Add(Me.RdGrade)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFiltro)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CatalogoProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tabela de Produtos"
        Me.PLoading.ResumeLayout(False)
        Me.PLoading.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Descrição As System.Windows.Forms.ColumnHeader
    Friend WithEvents Preço As System.Windows.Forms.ColumnHeader
    Friend WithEvents RdGrade As System.Windows.Forms.RadioButton
    Friend WithEvents RdLista As System.Windows.Forms.RadioButton
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Linha As System.Windows.Forms.ColumnHeader
    Friend WithEvents Categoria As System.Windows.Forms.ColumnHeader
    Friend WithEvents Path As System.Windows.Forms.ColumnHeader
    Public WithEvents ImgList As System.Windows.Forms.ImageList
    Friend WithEvents PLoading As System.Windows.Forms.Panel
    Friend WithEvents LbPercent As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ChkMostrar As System.Windows.Forms.CheckBox
    Friend WithEvents PicPreview As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As Timer
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produto
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOkm = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.DtvComponentes = New System.Windows.Forms.DataGridView()
        Me.TabGeral = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValorLiquido = New System.Windows.Forms.TextBox()
        Me.CbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtLucroPercent = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtLucroReal = New System.Windows.Forms.TextBox()
        Me.LbAdicional = New System.Windows.Forms.Label()
        Me.TxtTotalTributos = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LbImposto = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Lbcomissao = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtAdicional = New System.Windows.Forms.MaskedTextBox()
        Me.TxtLiquido = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtBruto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCusto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtImposto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMultiplicador = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtComissao = New System.Windows.Forms.MaskedTextBox()
        Me.LbPar2 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.CbCFOP3 = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.CbCFOP2 = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CbCFOP1 = New System.Windows.Forms.ComboBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CbProdEspecifico = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.txtNCM = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtCEST = New System.Windows.Forms.TextBox()
        Me.txtEANTrib = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtUnComercial = New System.Windows.Forms.TextBox()
        Me.txtEAN = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cQtde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValorUni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValCusto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValorTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DtvComponentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGeral.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescricao
        '
        Me.txtDescricao.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(81, 62)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(416, 27)
        Me.txtDescricao.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descrição"
        '
        'btnOkm
        '
        Me.btnOkm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOkm.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOkm.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOkm.Location = New System.Drawing.Point(540, 441)
        Me.btnOkm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOkm.Name = "btnOkm"
        Me.btnOkm.Size = New System.Drawing.Size(72, 56)
        Me.btnOkm.TabIndex = 10
        Me.btnOkm.Text = "OK"
        Me.btnOkm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOkm.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(615, 441)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 56)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(81, 28)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(152, 27)
        Me.txtCodigo.TabIndex = 1
        '
        'DtvComponentes
        '
        Me.DtvComponentes.AllowUserToAddRows = False
        Me.DtvComponentes.AllowUserToDeleteRows = False
        Me.DtvComponentes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DtvComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtvComponentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCodigo, Me.cDescricao, Me.cQtde, Me.cValorUni, Me.cValCusto, Me.cValorTotal, Me.cCategoria})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtvComponentes.DefaultCellStyle = DataGridViewCellStyle2
        Me.DtvComponentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DtvComponentes.Location = New System.Drawing.Point(3, 23)
        Me.DtvComponentes.Name = "DtvComponentes"
        Me.DtvComponentes.RowHeadersWidth = 5
        Me.DtvComponentes.RowTemplate.Height = 24
        Me.DtvComponentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtvComponentes.Size = New System.Drawing.Size(645, 192)
        Me.DtvComponentes.TabIndex = 8
        '
        'TabGeral
        '
        Me.TabGeral.Controls.Add(Me.TabPage3)
        Me.TabGeral.Controls.Add(Me.TabPage4)
        Me.TabGeral.Controls.Add(Me.TabPage5)
        Me.TabGeral.Location = New System.Drawing.Point(11, 12)
        Me.TabGeral.Name = "TabGeral"
        Me.TabGeral.SelectedIndex = 0
        Me.TabGeral.Size = New System.Drawing.Size(677, 424)
        Me.TabGeral.TabIndex = 26
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.txtValorLiquido)
        Me.TabPage3.Controls.Add(Me.CbCategoria)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.btnDel)
        Me.TabPage3.Controls.Add(Me.btnAdd)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.txtDescricao)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.txtCodigo)
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(669, 392)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Dados gerais"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DtvComponentes)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 168)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(651, 218)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Componentes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(269, 135)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 23)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Valor liquido"
        '
        'txtValorLiquido
        '
        Me.txtValorLiquido.BackColor = System.Drawing.SystemColors.Control
        Me.txtValorLiquido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorLiquido.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorLiquido.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtValorLiquido.Location = New System.Drawing.Point(381, 131)
        Me.txtValorLiquido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValorLiquido.Name = "txtValorLiquido"
        Me.txtValorLiquido.ReadOnly = True
        Me.txtValorLiquido.Size = New System.Drawing.Size(119, 31)
        Me.txtValorLiquido.TabIndex = 30
        Me.txtValorLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorLiquido.WordWrap = False
        '
        'CbCategoria
        '
        Me.CbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCategoria.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCategoria.FormattingEnabled = True
        Me.CbCategoria.Location = New System.Drawing.Point(330, 28)
        Me.CbCategoria.Name = "CbCategoria"
        Me.CbCategoria.Size = New System.Drawing.Size(167, 27)
        Me.CbCategoria.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(253, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 19)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Categoria"
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.Location = New System.Drawing.Point(122, 122)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(96, 40)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "Apagar"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(10, 122)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(106, 40)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Adicionar"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(507, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 28)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(669, 392)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Dados complementares"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtLucroPercent)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.TxtLucroReal)
        Me.GroupBox1.Controls.Add(Me.LbAdicional)
        Me.GroupBox1.Controls.Add(Me.TxtTotalTributos)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.LbImposto)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Lbcomissao)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TxtAdicional)
        Me.GroupBox1.Controls.Add(Me.TxtLiquido)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TxtBruto)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtCusto)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxtImposto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtMultiplicador)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtComissao)
        Me.GroupBox1.Controls.Add(Me.LbPar2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 365)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formação de custo"
        '
        'TxtLucroPercent
        '
        Me.TxtLucroPercent.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLucroPercent.Location = New System.Drawing.Point(127, 328)
        Me.TxtLucroPercent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtLucroPercent.Name = "TxtLucroPercent"
        Me.TxtLucroPercent.ReadOnly = True
        Me.TxtLucroPercent.Size = New System.Drawing.Size(68, 27)
        Me.TxtLucroPercent.TabIndex = 41
        Me.TxtLucroPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(196, 211)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(26, 19)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "R$"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(11, 333)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 19)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Ganho (%)"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(196, 183)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(26, 19)
        Me.Label25.TabIndex = 48
        Me.Label25.Text = "R$"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(196, 152)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(26, 19)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "R$"
        '
        'TxtLucroReal
        '
        Me.TxtLucroReal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLucroReal.Location = New System.Drawing.Point(127, 296)
        Me.TxtLucroReal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtLucroReal.Name = "TxtLucroReal"
        Me.TxtLucroReal.ReadOnly = True
        Me.TxtLucroReal.Size = New System.Drawing.Size(68, 27)
        Me.TxtLucroReal.TabIndex = 39
        Me.TxtLucroReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LbAdicional
        '
        Me.LbAdicional.AutoSize = True
        Me.LbAdicional.BackColor = System.Drawing.Color.Transparent
        Me.LbAdicional.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAdicional.Location = New System.Drawing.Point(218, 211)
        Me.LbAdicional.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbAdicional.Name = "LbAdicional"
        Me.LbAdicional.Size = New System.Drawing.Size(21, 19)
        Me.LbAdicional.TabIndex = 43
        Me.LbAdicional.Text = "..."
        '
        'TxtTotalTributos
        '
        Me.TxtTotalTributos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalTributos.Location = New System.Drawing.Point(127, 264)
        Me.TxtTotalTributos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtTotalTributos.Name = "TxtTotalTributos"
        Me.TxtTotalTributos.ReadOnly = True
        Me.TxtTotalTributos.Size = New System.Drawing.Size(68, 27)
        Me.TxtTotalTributos.TabIndex = 37
        Me.TxtTotalTributos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(11, 300)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 19)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Ganho (R$)"
        '
        'LbImposto
        '
        Me.LbImposto.AutoSize = True
        Me.LbImposto.BackColor = System.Drawing.Color.Transparent
        Me.LbImposto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImposto.Location = New System.Drawing.Point(218, 152)
        Me.LbImposto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbImposto.Name = "LbImposto"
        Me.LbImposto.Size = New System.Drawing.Size(21, 19)
        Me.LbImposto.TabIndex = 42
        Me.LbImposto.Text = "..."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(11, 267)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 19)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Total Custos R$"
        '
        'Lbcomissao
        '
        Me.Lbcomissao.AutoSize = True
        Me.Lbcomissao.BackColor = System.Drawing.Color.Transparent
        Me.Lbcomissao.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbcomissao.Location = New System.Drawing.Point(218, 183)
        Me.Lbcomissao.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbcomissao.Name = "Lbcomissao"
        Me.Lbcomissao.Size = New System.Drawing.Size(21, 19)
        Me.Lbcomissao.TabIndex = 39
        Me.Lbcomissao.Text = "..."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(11, 212)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 19)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Adicional %"
        '
        'TxtAdicional
        '
        Me.TxtAdicional.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdicional.Location = New System.Drawing.Point(127, 208)
        Me.TxtAdicional.Name = "TxtAdicional"
        Me.TxtAdicional.Size = New System.Drawing.Size(68, 27)
        Me.TxtAdicional.TabIndex = 35
        Me.TxtAdicional.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtLiquido
        '
        Me.TxtLiquido.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLiquido.Location = New System.Drawing.Point(127, 118)
        Me.TxtLiquido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtLiquido.Name = "TxtLiquido"
        Me.TxtLiquido.ReadOnly = True
        Me.TxtLiquido.Size = New System.Drawing.Size(68, 27)
        Me.TxtLiquido.TabIndex = 33
        Me.TxtLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 122)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 19)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "T. Líquido R$"
        '
        'TxtBruto
        '
        Me.TxtBruto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBruto.Location = New System.Drawing.Point(127, 57)
        Me.TxtBruto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBruto.Name = "TxtBruto"
        Me.TxtBruto.ReadOnly = True
        Me.TxtBruto.Size = New System.Drawing.Size(68, 27)
        Me.TxtBruto.TabIndex = 27
        Me.TxtBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 61)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 19)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "T. Bruto R$"
        '
        'TxtCusto
        '
        Me.TxtCusto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCusto.Location = New System.Drawing.Point(127, 27)
        Me.TxtCusto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCusto.Name = "TxtCusto"
        Me.TxtCusto.ReadOnly = True
        Me.TxtCusto.Size = New System.Drawing.Size(68, 27)
        Me.TxtCusto.TabIndex = 25
        Me.TxtCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 31)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 19)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "T. Custo R$"
        '
        'TxtImposto
        '
        Me.TxtImposto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImposto.Location = New System.Drawing.Point(127, 149)
        Me.TxtImposto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtImposto.Name = "TxtImposto"
        Me.TxtImposto.Size = New System.Drawing.Size(68, 27)
        Me.TxtImposto.TabIndex = 23
        Me.TxtImposto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 153)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 19)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Imposto %"
        '
        'txtMultiplicador
        '
        Me.txtMultiplicador.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMultiplicador.Location = New System.Drawing.Point(127, 88)
        Me.txtMultiplicador.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMultiplicador.Name = "txtMultiplicador"
        Me.txtMultiplicador.Size = New System.Drawing.Size(68, 27)
        Me.txtMultiplicador.TabIndex = 19
        Me.txtMultiplicador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 92)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Markup X"
        '
        'txtComissao
        '
        Me.txtComissao.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComissao.Location = New System.Drawing.Point(127, 179)
        Me.txtComissao.Name = "txtComissao"
        Me.txtComissao.Size = New System.Drawing.Size(68, 27)
        Me.txtComissao.TabIndex = 2
        Me.txtComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LbPar2
        '
        Me.LbPar2.AutoSize = True
        Me.LbPar2.BackColor = System.Drawing.Color.Transparent
        Me.LbPar2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPar2.Location = New System.Drawing.Point(11, 183)
        Me.LbPar2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbPar2.Name = "LbPar2"
        Me.LbPar2.Size = New System.Drawing.Size(87, 19)
        Me.LbPar2.TabIndex = 16
        Me.LbPar2.Text = "Comissão %"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox3)
        Me.TabPage5.Controls.Add(Me.GroupBox2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 28)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(669, 392)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "..."
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.CbCFOP3)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.CbCFOP2)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.CbCFOP1)
        Me.GroupBox3.Controls.Add(Me.Label103)
        Me.GroupBox3.Location = New System.Drawing.Point(289, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(366, 254)
        Me.GroupBox3.TabIndex = 100
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Regras do CFOP"
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Maroon
        Me.Label35.Location = New System.Drawing.Point(20, 168)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(332, 52)
        Me.Label35.TabIndex = 101
        Me.Label35.Text = "Os códigos CFOP de Venda e Remessa poderão variar de acordo com a UF do destinatá" &
    "rio."
        '
        'CbCFOP3
        '
        Me.CbCFOP3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCFOP3.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCFOP3.FormattingEnabled = True
        Me.CbCFOP3.Location = New System.Drawing.Point(199, 103)
        Me.CbCFOP3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CbCFOP3.Name = "CbCFOP3"
        Me.CbCFOP3.Size = New System.Drawing.Size(110, 26)
        Me.CbCFOP3.TabIndex = 99
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(20, 108)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(169, 18)
        Me.Label34.TabIndex = 100
        Me.Label34.Text = "* CFOP de Faturamento"
        '
        'CbCFOP2
        '
        Me.CbCFOP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCFOP2.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCFOP2.FormattingEnabled = True
        Me.CbCFOP2.Location = New System.Drawing.Point(199, 64)
        Me.CbCFOP2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CbCFOP2.Name = "CbCFOP2"
        Me.CbCFOP2.Size = New System.Drawing.Size(110, 26)
        Me.CbCFOP2.TabIndex = 97
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(20, 69)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(139, 18)
        Me.Label29.TabIndex = 98
        Me.Label29.Text = "* CFOP de Remessa"
        '
        'CbCFOP1
        '
        Me.CbCFOP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCFOP1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCFOP1.FormattingEnabled = True
        Me.CbCFOP1.Location = New System.Drawing.Point(199, 26)
        Me.CbCFOP1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CbCFOP1.Name = "CbCFOP1"
        Me.CbCFOP1.Size = New System.Drawing.Size(110, 26)
        Me.CbCFOP1.TabIndex = 95
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(20, 31)
        Me.Label103.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(126, 18)
        Me.Label103.TabIndex = 96
        Me.Label103.Text = "* CFOP de Venda"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CbProdEspecifico)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label62)
        Me.GroupBox2.Controls.Add(Me.txtNCM)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.txtCEST)
        Me.GroupBox2.Controls.Add(Me.txtEANTrib)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.txtUnComercial)
        Me.GroupBox2.Controls.Add(Me.txtEAN)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 254)
        Me.GroupBox2.TabIndex = 99
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações fixas"
        '
        'CbProdEspecifico
        '
        Me.CbProdEspecifico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbProdEspecifico.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProdEspecifico.FormattingEnabled = True
        Me.CbProdEspecifico.Location = New System.Drawing.Point(131, 194)
        Me.CbProdEspecifico.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CbProdEspecifico.Name = "CbProdEspecifico"
        Me.CbProdEspecifico.Size = New System.Drawing.Size(107, 26)
        Me.CbProdEspecifico.TabIndex = 97
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(12, 199)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(130, 18)
        Me.Label28.TabIndex = 98
        Me.Label28.Text = "Produto específico"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(12, 31)
        Me.Label62.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(53, 18)
        Me.Label62.TabIndex = 83
        Me.Label62.Text = "* NCM"
        '
        'txtNCM
        '
        Me.txtNCM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNCM.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNCM.Location = New System.Drawing.Point(131, 29)
        Me.txtNCM.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtNCM.Name = "txtNCM"
        Me.txtNCM.Size = New System.Drawing.Size(107, 25)
        Me.txtNCM.TabIndex = 84
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(12, 64)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(40, 18)
        Me.Label33.TabIndex = 85
        Me.Label33.Text = "CEST"
        '
        'txtCEST
        '
        Me.txtCEST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCEST.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCEST.Location = New System.Drawing.Point(131, 62)
        Me.txtCEST.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtCEST.Name = "txtCEST"
        Me.txtCEST.Size = New System.Drawing.Size(107, 25)
        Me.txtCEST.TabIndex = 86
        '
        'txtEANTrib
        '
        Me.txtEANTrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEANTrib.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEANTrib.Location = New System.Drawing.Point(131, 161)
        Me.txtEANTrib.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtEANTrib.Name = "txtEANTrib"
        Me.txtEANTrib.Size = New System.Drawing.Size(107, 25)
        Me.txtEANTrib.TabIndex = 92
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(12, 97)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(100, 18)
        Me.Label32.TabIndex = 87
        Me.Label32.Text = "Un. Comercial"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(12, 163)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(69, 18)
        Me.Label30.TabIndex = 91
        Me.Label30.Text = "EAN Trib."
        '
        'txtUnComercial
        '
        Me.txtUnComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnComercial.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnComercial.Location = New System.Drawing.Point(131, 95)
        Me.txtUnComercial.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtUnComercial.Name = "txtUnComercial"
        Me.txtUnComercial.Size = New System.Drawing.Size(107, 25)
        Me.txtUnComercial.TabIndex = 88
        '
        'txtEAN
        '
        Me.txtEAN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEAN.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEAN.Location = New System.Drawing.Point(131, 128)
        Me.txtEAN.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtEAN.Name = "txtEAN"
        Me.txtEAN.Size = New System.Drawing.Size(107, 25)
        Me.txtEAN.TabIndex = 90
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(12, 130)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(37, 18)
        Me.Label31.TabIndex = 89
        Me.Label31.Text = "EAN"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Imagem"
        Me.OpenFileDialog1.Title = "Arquivo de imagem"
        '
        'Codigo
        '
        Me.cCodigo.HeaderText = "Codigo"
        Me.cCodigo.Name = "Codigo"
        Me.cCodigo.ReadOnly = True
        Me.cCodigo.Width = 60
        '
        'Descricao
        '
        Me.cDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cDescricao.HeaderText = "Descricao"
        Me.cDescricao.Name = "Descricao"
        Me.cDescricao.ReadOnly = True
        '
        'Qtde
        '
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cQtde.DefaultCellStyle = DataGridViewCellStyle1
        Me.cQtde.HeaderText = "Qt."
        Me.cQtde.Name = "Qtde"
        Me.cQtde.Width = 70
        '
        'ValorUni
        '
        Me.cValorUni.HeaderText = "Vl. Unit."
        Me.cValorUni.Name = "ValorUni"
        Me.cValorUni.ReadOnly = True
        '
        'cValCusto
        '
        Me.cValCusto.HeaderText = "Vl. Custo"
        Me.cValCusto.Name = "cValCusto"
        '
        'ValorTotal
        '
        Me.cValorTotal.HeaderText = "Vl. Total"
        Me.cValorTotal.Name = "ValorTotal"
        Me.cValorTotal.ReadOnly = True
        '
        'Categoria
        '
        Me.cCategoria.HeaderText = "Categoria"
        Me.cCategoria.Name = "Categoria"
        Me.cCategoria.Visible = False
        '
        'FrmProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(704, 507)
        Me.Controls.Add(Me.TabGeral)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnOkm)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmProduto"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dados do Produto"
        CType(Me.DtvComponentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGeral.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOkm As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DtvComponentes As System.Windows.Forms.DataGridView
    Friend WithEvents TabGeral As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtComissao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbPar2 As System.Windows.Forms.Label
    Friend WithEvents txtMultiplicador As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtImposto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtBruto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtCusto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtLiquido As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtAdicional As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtLucroPercent As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtLucroReal As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalTributos As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LbAdicional As System.Windows.Forms.Label
    Friend WithEvents LbImposto As System.Windows.Forms.Label
    Friend WithEvents Lbcomissao As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtValorLiquido As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CbCFOP3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents CbCFOP2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents CbCFOP1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CbProdEspecifico As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents txtNCM As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtCEST As System.Windows.Forms.TextBox
    Friend WithEvents txtEANTrib As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtUnComercial As System.Windows.Forms.TextBox
    Friend WithEvents txtEAN As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cCodigo As DataGridViewTextBoxColumn
    Friend WithEvents cDescricao As DataGridViewTextBoxColumn
    Friend WithEvents cQtde As DataGridViewTextBoxColumn
    Friend WithEvents cValorUni As DataGridViewTextBoxColumn
    Friend WithEvents cValCusto As DataGridViewTextBoxColumn
    Friend WithEvents cValorTotal As DataGridViewTextBoxColumn
    Friend WithEvents cCategoria As DataGridViewTextBoxColumn
End Class

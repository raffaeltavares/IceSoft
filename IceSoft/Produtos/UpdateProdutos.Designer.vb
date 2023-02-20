<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateProdutos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkTab = New System.Windows.Forms.RadioButton()
        Me.ChkPtVirgula = New System.Windows.Forms.RadioButton()
        Me.TxtDescrDet = New System.Windows.Forms.TextBox()
        Me.TxtDirImagens = New System.Windows.Forms.TextBox()
        Me.TxtImagem = New System.Windows.Forms.TextBox()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.TxtLinha = New System.Windows.Forms.TextBox()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.TxtAcabamento = New System.Windows.Forms.TextBox()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ChkDescri = New System.Windows.Forms.CheckBox()
        Me.ChkCategoria = New System.Windows.Forms.CheckBox()
        Me.ChkLinha = New System.Windows.Forms.CheckBox()
        Me.ChkAcabamento = New System.Windows.Forms.CheckBox()
        Me.ChkDescriDet = New System.Windows.Forms.CheckBox()
        Me.ChkImagem = New System.Windows.Forms.CheckBox()
        Me.ChkDirImgs = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDire = New System.Windows.Forms.Button()
        Me.GrImgs = New System.Windows.Forms.GroupBox()
        Me.RdBmp = New System.Windows.Forms.RadioButton()
        Me.RdPng = New System.Windows.Forms.RadioButton()
        Me.RdJpeg = New System.Windows.Forms.RadioButton()
        Me.RdJpg = New System.Windows.Forms.RadioButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEAN = New System.Windows.Forms.TextBox()
        Me.ChkCFOPVenda = New System.Windows.Forms.CheckBox()
        Me.ChkEANTrib = New System.Windows.Forms.CheckBox()
        Me.ChkEAN = New System.Windows.Forms.CheckBox()
        Me.ChkUnCom = New System.Windows.Forms.CheckBox()
        Me.ChkCEST = New System.Windows.Forms.CheckBox()
        Me.ChkNCM = New System.Windows.Forms.CheckBox()
        Me.txtEANTrib = New System.Windows.Forms.TextBox()
        Me.txtCFOPVenda = New System.Windows.Forms.TextBox()
        Me.txtCEST = New System.Windows.Forms.TextBox()
        Me.txtUnComercial = New System.Windows.Forms.TextBox()
        Me.txtNCM = New System.Windows.Forms.TextBox()
        Me.ChkCFOPFat = New System.Windows.Forms.CheckBox()
        Me.txtCFOPFat = New System.Windows.Forms.TextBox()
        Me.ChkMarkup = New System.Windows.Forms.CheckBox()
        Me.txtMarkup = New System.Windows.Forms.TextBox()
        Me.ChkCFOPRem = New System.Windows.Forms.CheckBox()
        Me.txtCFOPRem = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GrImgs.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ChkTab)
        Me.GroupBox1.Controls.Add(Me.ChkPtVirgula)
        Me.GroupBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 56)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de separador"
        Me.GroupBox1.Visible = False
        '
        'ChkTab
        '
        Me.ChkTab.AutoSize = True
        Me.ChkTab.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTab.Location = New System.Drawing.Point(121, 21)
        Me.ChkTab.Name = "ChkTab"
        Me.ChkTab.Size = New System.Drawing.Size(49, 19)
        Me.ChkTab.TabIndex = 2
        Me.ChkTab.TabStop = True
        Me.ChkTab.Text = "TAB"
        Me.ChkTab.UseVisualStyleBackColor = True
        '
        'ChkPtVirgula
        '
        Me.ChkPtVirgula.AutoSize = True
        Me.ChkPtVirgula.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPtVirgula.Location = New System.Drawing.Point(44, 21)
        Me.ChkPtVirgula.Name = "ChkPtVirgula"
        Me.ChkPtVirgula.Size = New System.Drawing.Size(28, 19)
        Me.ChkPtVirgula.TabIndex = 1
        Me.ChkPtVirgula.TabStop = True
        Me.ChkPtVirgula.Text = ";"
        Me.ChkPtVirgula.UseVisualStyleBackColor = True
        '
        'TxtDescrDet
        '
        Me.TxtDescrDet.Enabled = False
        Me.TxtDescrDet.Location = New System.Drawing.Point(157, 232)
        Me.TxtDescrDet.Name = "TxtDescrDet"
        Me.TxtDescrDet.Size = New System.Drawing.Size(82, 22)
        Me.TxtDescrDet.TabIndex = 11
        '
        'TxtDirImagens
        '
        Me.TxtDirImagens.Enabled = False
        Me.TxtDirImagens.Location = New System.Drawing.Point(157, 349)
        Me.TxtDirImagens.Name = "TxtDirImagens"
        Me.TxtDirImagens.Size = New System.Drawing.Size(344, 22)
        Me.TxtDirImagens.TabIndex = 15
        '
        'TxtImagem
        '
        Me.TxtImagem.Enabled = False
        Me.TxtImagem.Location = New System.Drawing.Point(157, 260)
        Me.TxtImagem.Name = "TxtImagem"
        Me.TxtImagem.Size = New System.Drawing.Size(82, 22)
        Me.TxtImagem.TabIndex = 13
        '
        'TxtCategoria
        '
        Me.TxtCategoria.Enabled = False
        Me.TxtCategoria.Location = New System.Drawing.Point(157, 149)
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(82, 22)
        Me.TxtCategoria.TabIndex = 5
        '
        'TxtLinha
        '
        Me.TxtLinha.Enabled = False
        Me.TxtLinha.Location = New System.Drawing.Point(157, 176)
        Me.TxtLinha.Name = "TxtLinha"
        Me.TxtLinha.Size = New System.Drawing.Size(82, 22)
        Me.TxtLinha.TabIndex = 7
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Enabled = False
        Me.TxtDescricao.Location = New System.Drawing.Point(157, 123)
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(82, 22)
        Me.TxtDescricao.TabIndex = 3
        '
        'TxtAcabamento
        '
        Me.TxtAcabamento.Enabled = False
        Me.TxtAcabamento.Location = New System.Drawing.Point(157, 203)
        Me.TxtAcabamento.Name = "TxtAcabamento"
        Me.TxtAcabamento.Size = New System.Drawing.Size(82, 22)
        Me.TxtAcabamento.TabIndex = 9
        '
        'btnImport
        '
        Me.btnImport.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnImport.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnImport.Location = New System.Drawing.Point(346, 387)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(112, 43)
        Me.btnImport.TabIndex = 18
        Me.btnImport.Text = "Importar"
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.btnCancel.Location = New System.Drawing.Point(464, 387)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 43)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ChkDescri
        '
        Me.ChkDescri.AutoSize = True
        Me.ChkDescri.BackColor = System.Drawing.Color.Transparent
        Me.ChkDescri.Location = New System.Drawing.Point(36, 123)
        Me.ChkDescri.Name = "ChkDescri"
        Me.ChkDescri.Size = New System.Drawing.Size(83, 19)
        Me.ChkDescri.TabIndex = 2
        Me.ChkDescri.Text = "Descrição"
        Me.ChkDescri.UseVisualStyleBackColor = False
        '
        'ChkCategoria
        '
        Me.ChkCategoria.AutoSize = True
        Me.ChkCategoria.BackColor = System.Drawing.Color.Transparent
        Me.ChkCategoria.Location = New System.Drawing.Point(36, 151)
        Me.ChkCategoria.Name = "ChkCategoria"
        Me.ChkCategoria.Size = New System.Drawing.Size(83, 19)
        Me.ChkCategoria.TabIndex = 4
        Me.ChkCategoria.Text = "Categoria"
        Me.ChkCategoria.UseVisualStyleBackColor = False
        '
        'ChkLinha
        '
        Me.ChkLinha.AutoSize = True
        Me.ChkLinha.BackColor = System.Drawing.Color.Transparent
        Me.ChkLinha.Location = New System.Drawing.Point(36, 179)
        Me.ChkLinha.Name = "ChkLinha"
        Me.ChkLinha.Size = New System.Drawing.Size(58, 19)
        Me.ChkLinha.TabIndex = 6
        Me.ChkLinha.Text = "Linha"
        Me.ChkLinha.UseVisualStyleBackColor = False
        '
        'ChkAcabamento
        '
        Me.ChkAcabamento.AutoSize = True
        Me.ChkAcabamento.BackColor = System.Drawing.Color.Transparent
        Me.ChkAcabamento.Location = New System.Drawing.Point(36, 207)
        Me.ChkAcabamento.Name = "ChkAcabamento"
        Me.ChkAcabamento.Size = New System.Drawing.Size(101, 19)
        Me.ChkAcabamento.TabIndex = 8
        Me.ChkAcabamento.Text = "Acabamento"
        Me.ChkAcabamento.UseVisualStyleBackColor = False
        '
        'ChkDescriDet
        '
        Me.ChkDescriDet.AutoSize = True
        Me.ChkDescriDet.BackColor = System.Drawing.Color.Transparent
        Me.ChkDescriDet.Location = New System.Drawing.Point(36, 235)
        Me.ChkDescriDet.Name = "ChkDescriDet"
        Me.ChkDescriDet.Size = New System.Drawing.Size(110, 19)
        Me.ChkDescriDet.TabIndex = 10
        Me.ChkDescriDet.Text = "Descrição Det."
        Me.ChkDescriDet.UseVisualStyleBackColor = False
        '
        'ChkImagem
        '
        Me.ChkImagem.AutoSize = True
        Me.ChkImagem.BackColor = System.Drawing.Color.Transparent
        Me.ChkImagem.Location = New System.Drawing.Point(36, 263)
        Me.ChkImagem.Name = "ChkImagem"
        Me.ChkImagem.Size = New System.Drawing.Size(73, 19)
        Me.ChkImagem.TabIndex = 12
        Me.ChkImagem.Text = "Imagem"
        Me.ChkImagem.UseVisualStyleBackColor = False
        '
        'ChkDirImgs
        '
        Me.ChkDirImgs.AutoSize = True
        Me.ChkDirImgs.BackColor = System.Drawing.Color.Transparent
        Me.ChkDirImgs.Location = New System.Drawing.Point(36, 352)
        Me.ChkDirImgs.Name = "ChkDirImgs"
        Me.ChkDirImgs.Size = New System.Drawing.Size(99, 19)
        Me.ChkDirImgs.TabIndex = 14
        Me.ChkDirImgs.Text = "Dir. Imagens"
        Me.ChkDirImgs.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(154, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Nº da Coluna"
        '
        'btnDire
        '
        Me.btnDire.Enabled = False
        Me.btnDire.Location = New System.Drawing.Point(507, 348)
        Me.btnDire.Name = "btnDire"
        Me.btnDire.Size = New System.Drawing.Size(40, 23)
        Me.btnDire.TabIndex = 16
        Me.btnDire.Text = "..."
        Me.btnDire.UseVisualStyleBackColor = True
        '
        'GrImgs
        '
        Me.GrImgs.BackColor = System.Drawing.Color.Transparent
        Me.GrImgs.Controls.Add(Me.RdBmp)
        Me.GrImgs.Controls.Add(Me.RdPng)
        Me.GrImgs.Controls.Add(Me.RdJpeg)
        Me.GrImgs.Controls.Add(Me.RdJpg)
        Me.GrImgs.Enabled = False
        Me.GrImgs.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrImgs.Location = New System.Drawing.Point(245, 102)
        Me.GrImgs.Name = "GrImgs"
        Me.GrImgs.Size = New System.Drawing.Size(93, 208)
        Me.GrImgs.TabIndex = 17
        Me.GrImgs.TabStop = False
        Me.GrImgs.Text = "Extensão"
        '
        'RdBmp
        '
        Me.RdBmp.AutoSize = True
        Me.RdBmp.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdBmp.Location = New System.Drawing.Point(20, 133)
        Me.RdBmp.Name = "RdBmp"
        Me.RdBmp.Size = New System.Drawing.Size(55, 19)
        Me.RdBmp.TabIndex = 4
        Me.RdBmp.TabStop = True
        Me.RdBmp.Text = ".Bmp"
        Me.RdBmp.UseVisualStyleBackColor = True
        '
        'RdPng
        '
        Me.RdPng.AutoSize = True
        Me.RdPng.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdPng.Location = New System.Drawing.Point(20, 102)
        Me.RdPng.Name = "RdPng"
        Me.RdPng.Size = New System.Drawing.Size(51, 19)
        Me.RdPng.TabIndex = 3
        Me.RdPng.TabStop = True
        Me.RdPng.Text = ".Png"
        Me.RdPng.UseVisualStyleBackColor = True
        '
        'RdJpeg
        '
        Me.RdJpeg.AutoSize = True
        Me.RdJpeg.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdJpeg.Location = New System.Drawing.Point(20, 74)
        Me.RdJpeg.Name = "RdJpeg"
        Me.RdJpeg.Size = New System.Drawing.Size(56, 19)
        Me.RdJpeg.TabIndex = 2
        Me.RdJpeg.TabStop = True
        Me.RdJpeg.Text = ".Jpeg"
        Me.RdJpeg.UseVisualStyleBackColor = True
        '
        'RdJpg
        '
        Me.RdJpg.AutoSize = True
        Me.RdJpg.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdJpg.Location = New System.Drawing.Point(20, 46)
        Me.RdJpg.Name = "RdJpg"
        Me.RdJpg.Size = New System.Drawing.Size(49, 19)
        Me.RdJpg.TabIndex = 1
        Me.RdJpg.TabStop = True
        Me.RdJpg.Text = ".Jpg"
        Me.RdJpg.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(33, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 15)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Nº da Coluna Código"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(36, 89)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(82, 22)
        Me.TxtCodigo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(462, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Nº da Coluna"
        '
        'txtEAN
        '
        Me.txtEAN.Enabled = False
        Me.txtEAN.Location = New System.Drawing.Point(465, 203)
        Me.txtEAN.Name = "txtEAN"
        Me.txtEAN.Size = New System.Drawing.Size(82, 22)
        Me.txtEAN.TabIndex = 75
        '
        'ChkCFOPVenda
        '
        Me.ChkCFOPVenda.AutoSize = True
        Me.ChkCFOPVenda.BackColor = System.Drawing.Color.Transparent
        Me.ChkCFOPVenda.Location = New System.Drawing.Point(344, 263)
        Me.ChkCFOPVenda.Name = "ChkCFOPVenda"
        Me.ChkCFOPVenda.Size = New System.Drawing.Size(100, 19)
        Me.ChkCFOPVenda.TabIndex = 78
        Me.ChkCFOPVenda.Text = "CFOP Venda"
        Me.ChkCFOPVenda.UseVisualStyleBackColor = False
        '
        'ChkEANTrib
        '
        Me.ChkEANTrib.AutoSize = True
        Me.ChkEANTrib.BackColor = System.Drawing.Color.Transparent
        Me.ChkEANTrib.Location = New System.Drawing.Point(344, 235)
        Me.ChkEANTrib.Name = "ChkEANTrib"
        Me.ChkEANTrib.Size = New System.Drawing.Size(81, 19)
        Me.ChkEANTrib.TabIndex = 76
        Me.ChkEANTrib.Text = "EAN Trib."
        Me.ChkEANTrib.UseVisualStyleBackColor = False
        '
        'ChkEAN
        '
        Me.ChkEAN.AutoSize = True
        Me.ChkEAN.BackColor = System.Drawing.Color.Transparent
        Me.ChkEAN.Location = New System.Drawing.Point(344, 207)
        Me.ChkEAN.Name = "ChkEAN"
        Me.ChkEAN.Size = New System.Drawing.Size(52, 19)
        Me.ChkEAN.TabIndex = 74
        Me.ChkEAN.Text = "EAN"
        Me.ChkEAN.UseVisualStyleBackColor = False
        '
        'ChkUnCom
        '
        Me.ChkUnCom.AutoSize = True
        Me.ChkUnCom.BackColor = System.Drawing.Color.Transparent
        Me.ChkUnCom.Location = New System.Drawing.Point(344, 179)
        Me.ChkUnCom.Name = "ChkUnCom"
        Me.ChkUnCom.Size = New System.Drawing.Size(107, 19)
        Me.ChkUnCom.TabIndex = 72
        Me.ChkUnCom.Text = "Un. Comercial"
        Me.ChkUnCom.UseVisualStyleBackColor = False
        '
        'ChkCEST
        '
        Me.ChkCEST.AutoSize = True
        Me.ChkCEST.BackColor = System.Drawing.Color.Transparent
        Me.ChkCEST.Location = New System.Drawing.Point(344, 151)
        Me.ChkCEST.Name = "ChkCEST"
        Me.ChkCEST.Size = New System.Drawing.Size(54, 19)
        Me.ChkCEST.TabIndex = 70
        Me.ChkCEST.Text = "CEST"
        Me.ChkCEST.UseVisualStyleBackColor = False
        '
        'ChkNCM
        '
        Me.ChkNCM.AutoSize = True
        Me.ChkNCM.BackColor = System.Drawing.Color.Transparent
        Me.ChkNCM.Location = New System.Drawing.Point(344, 123)
        Me.ChkNCM.Name = "ChkNCM"
        Me.ChkNCM.Size = New System.Drawing.Size(55, 19)
        Me.ChkNCM.TabIndex = 68
        Me.ChkNCM.Text = "NCM"
        Me.ChkNCM.UseVisualStyleBackColor = False
        '
        'txtEANTrib
        '
        Me.txtEANTrib.Enabled = False
        Me.txtEANTrib.Location = New System.Drawing.Point(465, 232)
        Me.txtEANTrib.Name = "txtEANTrib"
        Me.txtEANTrib.Size = New System.Drawing.Size(82, 22)
        Me.txtEANTrib.TabIndex = 77
        '
        'txtCFOPVenda
        '
        Me.txtCFOPVenda.Enabled = False
        Me.txtCFOPVenda.Location = New System.Drawing.Point(465, 260)
        Me.txtCFOPVenda.Name = "txtCFOPVenda"
        Me.txtCFOPVenda.Size = New System.Drawing.Size(82, 22)
        Me.txtCFOPVenda.TabIndex = 79
        '
        'txtCEST
        '
        Me.txtCEST.Enabled = False
        Me.txtCEST.Location = New System.Drawing.Point(465, 149)
        Me.txtCEST.Name = "txtCEST"
        Me.txtCEST.Size = New System.Drawing.Size(82, 22)
        Me.txtCEST.TabIndex = 71
        '
        'txtUnComercial
        '
        Me.txtUnComercial.Enabled = False
        Me.txtUnComercial.Location = New System.Drawing.Point(465, 176)
        Me.txtUnComercial.Name = "txtUnComercial"
        Me.txtUnComercial.Size = New System.Drawing.Size(82, 22)
        Me.txtUnComercial.TabIndex = 73
        '
        'txtNCM
        '
        Me.txtNCM.Enabled = False
        Me.txtNCM.Location = New System.Drawing.Point(465, 121)
        Me.txtNCM.Name = "txtNCM"
        Me.txtNCM.Size = New System.Drawing.Size(82, 22)
        Me.txtNCM.TabIndex = 69
        '
        'ChkCFOPFat
        '
        Me.ChkCFOPFat.AutoSize = True
        Me.ChkCFOPFat.BackColor = System.Drawing.Color.Transparent
        Me.ChkCFOPFat.Location = New System.Drawing.Point(344, 291)
        Me.ChkCFOPFat.Name = "ChkCFOPFat"
        Me.ChkCFOPFat.Size = New System.Drawing.Size(82, 19)
        Me.ChkCFOPFat.TabIndex = 83
        Me.ChkCFOPFat.Text = "CFOP Fat."
        Me.ChkCFOPFat.UseVisualStyleBackColor = False
        '
        'txtCFOPFat
        '
        Me.txtCFOPFat.Enabled = False
        Me.txtCFOPFat.Location = New System.Drawing.Point(465, 288)
        Me.txtCFOPFat.Name = "txtCFOPFat"
        Me.txtCFOPFat.Size = New System.Drawing.Size(82, 22)
        Me.txtCFOPFat.TabIndex = 84
        '
        'ChkMarkup
        '
        Me.ChkMarkup.AutoSize = True
        Me.ChkMarkup.BackColor = System.Drawing.Color.Transparent
        Me.ChkMarkup.Location = New System.Drawing.Point(36, 291)
        Me.ChkMarkup.Name = "ChkMarkup"
        Me.ChkMarkup.Size = New System.Drawing.Size(71, 19)
        Me.ChkMarkup.TabIndex = 81
        Me.ChkMarkup.Text = "Markup"
        Me.ChkMarkup.UseVisualStyleBackColor = False
        '
        'txtMarkup
        '
        Me.txtMarkup.Enabled = False
        Me.txtMarkup.Location = New System.Drawing.Point(157, 288)
        Me.txtMarkup.Name = "txtMarkup"
        Me.txtMarkup.Size = New System.Drawing.Size(82, 22)
        Me.txtMarkup.TabIndex = 82
        '
        'ChkCFOPRem
        '
        Me.ChkCFOPRem.AutoSize = True
        Me.ChkCFOPRem.BackColor = System.Drawing.Color.Transparent
        Me.ChkCFOPRem.Location = New System.Drawing.Point(344, 319)
        Me.ChkCFOPRem.Name = "ChkCFOPRem"
        Me.ChkCFOPRem.Size = New System.Drawing.Size(89, 19)
        Me.ChkCFOPRem.TabIndex = 85
        Me.ChkCFOPRem.Text = "CFOP Rem."
        Me.ChkCFOPRem.UseVisualStyleBackColor = False
        '
        'txtCFOPRem
        '
        Me.txtCFOPRem.Enabled = False
        Me.txtCFOPRem.Location = New System.Drawing.Point(465, 316)
        Me.txtCFOPRem.Name = "txtCFOPRem"
        Me.txtCFOPRem.Size = New System.Drawing.Size(82, 22)
        Me.txtCFOPRem.TabIndex = 86
        '
        'FrmUpdateProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 431)
        Me.Controls.Add(Me.ChkCFOPRem)
        Me.Controls.Add(Me.txtCFOPRem)
        Me.Controls.Add(Me.ChkCFOPFat)
        Me.Controls.Add(Me.txtCFOPFat)
        Me.Controls.Add(Me.ChkMarkup)
        Me.Controls.Add(Me.txtMarkup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEAN)
        Me.Controls.Add(Me.ChkCFOPVenda)
        Me.Controls.Add(Me.ChkEANTrib)
        Me.Controls.Add(Me.ChkEAN)
        Me.Controls.Add(Me.ChkUnCom)
        Me.Controls.Add(Me.ChkCEST)
        Me.Controls.Add(Me.ChkNCM)
        Me.Controls.Add(Me.txtEANTrib)
        Me.Controls.Add(Me.txtCFOPVenda)
        Me.Controls.Add(Me.txtCEST)
        Me.Controls.Add(Me.txtUnComercial)
        Me.Controls.Add(Me.txtNCM)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GrImgs)
        Me.Controls.Add(Me.btnDire)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChkDirImgs)
        Me.Controls.Add(Me.TxtAcabamento)
        Me.Controls.Add(Me.ChkImagem)
        Me.Controls.Add(Me.ChkDescriDet)
        Me.Controls.Add(Me.ChkAcabamento)
        Me.Controls.Add(Me.ChkLinha)
        Me.Controls.Add(Me.ChkCategoria)
        Me.Controls.Add(Me.ChkDescri)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtDescrDet)
        Me.Controls.Add(Me.TxtDirImagens)
        Me.Controls.Add(Me.TxtImagem)
        Me.Controls.Add(Me.TxtCategoria)
        Me.Controls.Add(Me.TxtLinha)
        Me.Controls.Add(Me.TxtDescricao)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnCancel)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUpdateProdutos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atualizar dados dos produtos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrImgs.ResumeLayout(False)
        Me.GrImgs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkTab As System.Windows.Forms.RadioButton
    Friend WithEvents ChkPtVirgula As System.Windows.Forms.RadioButton
    Friend WithEvents TxtDescrDet As System.Windows.Forms.TextBox
    Friend WithEvents TxtDirImagens As System.Windows.Forms.TextBox
    Friend WithEvents TxtImagem As System.Windows.Forms.TextBox
    Friend WithEvents TxtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents TxtLinha As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents TxtAcabamento As System.Windows.Forms.TextBox
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ChkDescri As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCategoria As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLinha As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAcabamento As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDescriDet As System.Windows.Forms.CheckBox
    Friend WithEvents ChkImagem As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDirImgs As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDire As System.Windows.Forms.Button
    Friend WithEvents GrImgs As System.Windows.Forms.GroupBox
    Friend WithEvents RdBmp As System.Windows.Forms.RadioButton
    Friend WithEvents RdPng As System.Windows.Forms.RadioButton
    Friend WithEvents RdJpeg As System.Windows.Forms.RadioButton
    Friend WithEvents RdJpg As System.Windows.Forms.RadioButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEAN As System.Windows.Forms.TextBox
    Friend WithEvents ChkCFOPVenda As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEANTrib As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEAN As System.Windows.Forms.CheckBox
    Friend WithEvents ChkUnCom As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCEST As System.Windows.Forms.CheckBox
    Friend WithEvents ChkNCM As System.Windows.Forms.CheckBox
    Friend WithEvents txtEANTrib As System.Windows.Forms.TextBox
    Friend WithEvents txtCFOPVenda As System.Windows.Forms.TextBox
    Friend WithEvents txtCEST As System.Windows.Forms.TextBox
    Friend WithEvents txtUnComercial As System.Windows.Forms.TextBox
    Friend WithEvents txtNCM As System.Windows.Forms.TextBox
    Friend WithEvents ChkCFOPFat As System.Windows.Forms.CheckBox
    Friend WithEvents txtCFOPFat As System.Windows.Forms.TextBox
    Friend WithEvents ChkMarkup As System.Windows.Forms.CheckBox
    Friend WithEvents txtMarkup As System.Windows.Forms.TextBox
    Friend WithEvents ChkCFOPRem As System.Windows.Forms.CheckBox
    Friend WithEvents txtCFOPRem As System.Windows.Forms.TextBox
End Class

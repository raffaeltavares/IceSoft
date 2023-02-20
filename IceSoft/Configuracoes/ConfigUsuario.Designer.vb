<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfigUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigUsuario))
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtSenhaAtual = New System.Windows.Forms.TextBox()
        Me.txtNovaSenha = New System.Windows.Forms.TextBox()
        Me.txtRedSenha = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.txtTelefone2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefone1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtRg = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtNomeComp = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.GrPessoal = New System.Windows.Forms.GroupBox()
        Me.PcFoto = New System.Windows.Forms.PictureBox()
        Me.GrSenha = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GrPessoal.SuspendLayout()
        CType(Me.PcFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrSenha.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(149, 32)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(120, 27)
        Me.txtNome.TabIndex = 11
        '
        'txtSenhaAtual
        '
        Me.txtSenhaAtual.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenhaAtual.Location = New System.Drawing.Point(149, 74)
        Me.txtSenhaAtual.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSenhaAtual.Name = "txtSenhaAtual"
        Me.txtSenhaAtual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaAtual.Size = New System.Drawing.Size(120, 27)
        Me.txtSenhaAtual.TabIndex = 14
        '
        'txtNovaSenha
        '
        Me.txtNovaSenha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNovaSenha.Location = New System.Drawing.Point(433, 30)
        Me.txtNovaSenha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNovaSenha.Name = "txtNovaSenha"
        Me.txtNovaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNovaSenha.Size = New System.Drawing.Size(136, 27)
        Me.txtNovaSenha.TabIndex = 12
        '
        'txtRedSenha
        '
        Me.txtRedSenha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRedSenha.Location = New System.Drawing.Point(433, 74)
        Me.txtRedSenha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRedSenha.Name = "txtRedSenha"
        Me.txtRedSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRedSenha.Size = New System.Drawing.Size(136, 27)
        Me.txtRedSenha.TabIndex = 13
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(643, 431)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 55)
        Me.btnOk.TabIndex = 15
        Me.btnOk.Text = "OK"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(723, 431)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 55)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nome usuário *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Senha Atual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(295, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nova Senha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(295, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 19)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Redigite a Senha"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Location = New System.Drawing.Point(259, 13)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(115, 22)
        Me.RadioButton1.TabIndex = 17
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Administrador"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(412, 13)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(69, 22)
        Me.RadioButton2.TabIndex = 18
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Padrão"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'txtTelefone2
        '
        Me.txtTelefone2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone2.Location = New System.Drawing.Point(365, 162)
        Me.txtTelefone2.Mask = "(99) 0000-00000"
        Me.txtTelefone2.Name = "txtTelefone2"
        Me.txtTelefone2.Size = New System.Drawing.Size(119, 27)
        Me.txtTelefone2.TabIndex = 9
        Me.txtTelefone2.Visible = False
        '
        'txtTelefone1
        '
        Me.txtTelefone1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone1.Location = New System.Drawing.Point(146, 162)
        Me.txtTelefone1.Mask = "(99) 0000-00000"
        Me.txtTelefone1.Name = "txtTelefone1"
        Me.txtTelefone1.Size = New System.Drawing.Size(119, 27)
        Me.txtTelefone1.TabIndex = 8
        '
        'txtRg
        '
        Me.txtRg.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRg.Location = New System.Drawing.Point(475, 41)
        Me.txtRg.Mask = "00.000.000-0"
        Me.txtRg.Name = "txtRg"
        Me.txtRg.Size = New System.Drawing.Size(134, 27)
        Me.txtRg.TabIndex = 2
        Me.txtRg.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(83, 195)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 19)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "E-mail "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(275, 165)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 19)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Telefone 2"
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(54, 165)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 19)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Telefone1 *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 79)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 19)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Endereço"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(439, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 19)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "RG"
        Me.Label5.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(435, 79)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 19)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Bairro"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 43)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 19)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Nome Completo *"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(146, 192)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(338, 27)
        Me.txtEmail.TabIndex = 10
        '
        'txtEndereco
        '
        Me.txtEndereco.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(146, 76)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(283, 27)
        Me.txtEndereco.TabIndex = 3
        '
        'txtBairro
        '
        Me.txtBairro.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(494, 76)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(115, 27)
        Me.txtBairro.TabIndex = 4
        '
        'txtNomeComp
        '
        Me.txtNomeComp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeComp.Location = New System.Drawing.Point(146, 40)
        Me.txtNomeComp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNomeComp.Name = "txtNomeComp"
        Me.txtNomeComp.Size = New System.Drawing.Size(283, 27)
        Me.txtNomeComp.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(79, 115)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 19)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Cidade"
        '
        'txtCidade
        '
        Me.txtCidade.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(146, 112)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(146, 27)
        Me.txtCidade.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(310, 115)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 19)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Estado"
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(373, 112)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(56, 27)
        Me.txtEstado.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(439, 115)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 19)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "CEP"
        '
        'txtCep
        '
        Me.txtCep.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCep.Location = New System.Drawing.Point(494, 112)
        Me.txtCep.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(115, 27)
        Me.txtCep.TabIndex = 7
        '
        'GrPessoal
        '
        Me.GrPessoal.BackColor = System.Drawing.Color.Transparent
        Me.GrPessoal.Controls.Add(Me.PcFoto)
        Me.GrPessoal.Controls.Add(Me.Label12)
        Me.GrPessoal.Controls.Add(Me.Label15)
        Me.GrPessoal.Controls.Add(Me.txtNomeComp)
        Me.GrPessoal.Controls.Add(Me.txtCep)
        Me.GrPessoal.Controls.Add(Me.txtBairro)
        Me.GrPessoal.Controls.Add(Me.Label14)
        Me.GrPessoal.Controls.Add(Me.txtEndereco)
        Me.GrPessoal.Controls.Add(Me.txtEstado)
        Me.GrPessoal.Controls.Add(Me.txtEmail)
        Me.GrPessoal.Controls.Add(Me.Label13)
        Me.GrPessoal.Controls.Add(Me.Label11)
        Me.GrPessoal.Controls.Add(Me.txtCidade)
        Me.GrPessoal.Controls.Add(Me.Label5)
        Me.GrPessoal.Controls.Add(Me.txtTelefone2)
        Me.GrPessoal.Controls.Add(Me.Label6)
        Me.GrPessoal.Controls.Add(Me.txtTelefone1)
        Me.GrPessoal.Controls.Add(Me.Label8)
        Me.GrPessoal.Controls.Add(Me.txtRg)
        Me.GrPessoal.Controls.Add(Me.Label9)
        Me.GrPessoal.Controls.Add(Me.Label10)
        Me.GrPessoal.Location = New System.Drawing.Point(28, 56)
        Me.GrPessoal.Name = "GrPessoal"
        Me.GrPessoal.Size = New System.Drawing.Size(793, 234)
        Me.GrPessoal.TabIndex = 40
        Me.GrPessoal.TabStop = False
        Me.GrPessoal.Text = "Informações Gerais"
        '
        'PcFoto
        '
        Me.PcFoto.BackColor = System.Drawing.Color.White
        Me.PcFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PcFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PcFoto.Location = New System.Drawing.Point(615, 40)
        Me.PcFoto.Name = "PcFoto"
        Me.PcFoto.Size = New System.Drawing.Size(172, 178)
        Me.PcFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcFoto.TabIndex = 40
        Me.PcFoto.TabStop = False
        Me.PcFoto.Visible = False
        '
        'GrSenha
        '
        Me.GrSenha.BackColor = System.Drawing.Color.Transparent
        Me.GrSenha.Controls.Add(Me.Label1)
        Me.GrSenha.Controls.Add(Me.txtNome)
        Me.GrSenha.Controls.Add(Me.txtSenhaAtual)
        Me.GrSenha.Controls.Add(Me.txtNovaSenha)
        Me.GrSenha.Controls.Add(Me.Label4)
        Me.GrSenha.Controls.Add(Me.txtRedSenha)
        Me.GrSenha.Controls.Add(Me.Label3)
        Me.GrSenha.Controls.Add(Me.Label2)
        Me.GrSenha.Location = New System.Drawing.Point(28, 300)
        Me.GrSenha.Name = "GrSenha"
        Me.GrSenha.Size = New System.Drawing.Size(793, 124)
        Me.GrSenha.TabIndex = 41
        Me.GrSenha.TabStop = False
        Me.GrSenha.Text = "Informações de Acesso"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Imagem"
        Me.OpenFileDialog1.Title = "Arquivo de imagem"
        '
        'FrmConfigUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(847, 508)
        Me.Controls.Add(Me.GrSenha)
        Me.Controls.Add(Me.GrPessoal)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConfigUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados do usuário"
        Me.GrPessoal.ResumeLayout(False)
        Me.GrPessoal.PerformLayout()
        CType(Me.PcFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrSenha.ResumeLayout(False)
        Me.GrSenha.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtSenhaAtual As System.Windows.Forms.TextBox
    Friend WithEvents txtNovaSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtRedSenha As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtTelefone2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTelefone1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtRg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeComp As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCep As System.Windows.Forms.TextBox
    Friend WithEvents GrPessoal As System.Windows.Forms.GroupBox
    Friend WithEvents GrSenha As System.Windows.Forms.GroupBox
    Friend WithEvents PcFoto As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class

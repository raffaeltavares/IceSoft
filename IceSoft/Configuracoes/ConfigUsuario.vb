'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows

Public Class ConfigUsuario

    Public Tipo As String
    Public vl As Integer
    Public senhaatual As String
    Public imgloc As String
    Public modo As Integer = 1


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If modo = 1 Then
            For Each dr As DataRow In UsuariosDS.Tables(0).Rows
                If dr.Item(0).ToString = Me.txtNome.Text Then
                    MsgBox("Nome de usuário já utilizado! Digite outro nome.", MsgBoxStyle.Information)
                    Me.DialogResult = Forms.DialogResult.None
                    txtNome.BackColor = Color.OrangeRed
                    Exit Sub
                End If
            Next
        End If

        If RadioButton1.Checked = True Then
            Tipo = "Administrador"
        ElseIf RadioButton2.Checked = True Then
            Tipo = "Padrao"
        End If

        Cadastrar(vl)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmConfigUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Tipo = "Padrao" Then
            RadioButton1.Visible = False
            RadioButton2.Visible = False
        Else
            RadioButton1.Visible = True
            RadioButton2.Visible = True
        End If

        If vl = 1 Then
            GrPessoal.Enabled = False
            GrSenha.Enabled = True
        ElseIf vl = 2 Then
            GrPessoal.Enabled = True
            GrSenha.Enabled = False
        Else
            GrPessoal.Enabled = True
            GrSenha.Enabled = True
        End If

        'If IO.File.Exists(xres & "fundo-geral.jpg") Then
        '    Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
        '    Me.BackgroundImage = back1
        'End If

        If IO.File.Exists(xres & "accept_database.png") Then
            Dim img As New Bitmap(xres & "accept_database.png")
            Me.btnOk.Image = img
        End If

        If IO.File.Exists(xres & "cancel.png") Then
            Dim img As New Bitmap(xres & "cancel.png")
            Me.btnCancel.Image = img
        End If

        If Tipo = "Administrador" Then
            RadioButton1.Checked = True
        ElseIf Tipo = "Padrao" Then
            RadioButton2.Checked = True
        End If

        If vl = 0 Then
            txtSenhaAtual.Visible = False
        ElseIf vl = 1 Then
            txtSenhaAtual.Visible = True
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            txtNome.Enabled = False
        End If

    End Sub

    Public Sub Cadastrar(ByVal v As Integer)

        If v = 0 Then
            If LTrim(RTrim(txtNome.Text)) = Nothing Or LTrim(RTrim(txtNomeComp.Text)) = Nothing Or LTrim(RTrim(txtTelefone1.Text)) = Nothing Then
                MsgBox("Todos os campos com * devem ser preenchidos!", MsgBoxStyle.Exclamation)

            End If
        ElseIf v = 1 Then
            If senhaatual <> txtSenhaAtual.Text Then
                MsgBox("Senha digitada não confere com o registro!")
                Exit Sub
            Else
                If txtNovaSenha.Text <> txtRedSenha.Text Then
                    MsgBox("As senhas digitadas não correspondem!")
                    Exit Sub
                End If
            End If
            EditSenha()
        ElseIf v = 2 Then
            If LTrim(RTrim(txtNome.Text)) = Nothing Or LTrim(RTrim(txtNomeComp.Text)) = Nothing Or LTrim(RTrim(txtTelefone1.Text)) = Nothing Then
                MsgBox("Todos os campos com * devem ser preenchidos!", MsgBoxStyle.Exclamation)
            Else
                EditDados()
            End If

        End If

    End Sub

    Private Sub EditSenha()


        Try
            conexão.Close()
            conexão.Open()
            'Dim sqlCom As String = "UPDATE fornecedores  SET [Razão Social] = '@Razao', [Nome Fantasia] = '@Fantasia', [CNPJ] = '@Cnpj', [Endereço] = '@Endereco', [Contato] = '@Contato', [Telefone] = '@Telefone', [Telefone 2] = '@Telefone2', [E-mail] = '@Email' WHERE [Codigo] = @Codigo"

            Dim sqlCom As String = "UPDATE usuarios  SET [Senha] = '" & Me.txtNovaSenha.Text & "' WHERE [User] = '" & Me.txtNome.Text & "' "
            Dim MyCommand As New OleDbCommand(sqlCom, conexão)
            Dim Ra As Integer = MyCommand.ExecuteNonQuery

            conexão.Close()
            Close()

            'MsgBox("EDITOU REGISTRO")
        Catch ex As Exception
            MsgBox(ex.Message)
            conexão.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub EditDados()

        Try
            conexão.Close()
            conexão.Open()
            'Dim sqlCom As String = "UPDATE fornecedores  SET [Razão Social] = '@Razao', [Nome Fantasia] = '@Fantasia', [CNPJ] = '@Cnpj', [Endereço] = '@Endereco', [Contato] = '@Contato', [Telefone] = '@Telefone', [Telefone 2] = '@Telefone2', [E-mail] = '@Email' WHERE [Codigo] = @Codigo"

            Dim sqlCom As String = "UPDATE usuarios  SET [Nome] = '" & Me.txtNomeComp.Text & "', [RG] = '" & Me.txtRg.Text & "', [Telefone1] = '" & Me.txtTelefone1.Text & "', [Telefone2] = '" & Me.txtTelefone2.Text & "', [Email] = '" & Me.txtEmail.Text & "', [Endereco] = '" & Me.txtEndereco.Text & "', [Bairro] = '" & Me.txtBairro.Text & "', [Cidade] = '" & Me.txtCidade.Text & "', [Estado] = '" & Me.txtEstado.Text & "', [CEP] = '" & Me.txtCep.Text & "', [Foto] = '" & imgloc & "' WHERE [User] = '" & Me.txtNome.Text & "' "
            Dim MyCommand As New OleDbCommand(sqlCom, conexão)
            Dim Ra As Integer = MyCommand.ExecuteNonQuery

            conexão.Close()
            Close()

            'MsgBox("EDITOU REGISTRO")
        Catch ex As Exception
            MsgBox(ex.Message)
            conexão.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub PcFoto_MouseHover(sender As Object, e As EventArgs) Handles PcFoto.MouseHover
        Dim ttp As New ToolTip
        ttp.ShowAlways = False
        ttp.IsBalloon = True
        ttp.ToolTipIcon = ToolTipIcon.Info
        ttp.UseFading = True
        ttp.Show("Clique para definir uma imagem.", Me.PcFoto)
    End Sub

    Private Sub PcFoto_Click(sender As Object, e As EventArgs) Handles PcFoto.Click
        OpenFileDialog1.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        imgLoc = OpenFileDialog1.FileName
        PcFoto.Image = Image.FromFile(imgloc)
    End Sub


End Class
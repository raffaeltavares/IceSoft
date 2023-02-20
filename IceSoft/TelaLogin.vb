'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.Data.OleDb
Imports System.Windows

Public Class TelaLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        dbase = dblocal(My.Application.Info.DirectoryPath & "\database.dat")
        ConnString = "Provider=Microsoft.ACE.OleDb.12.0; Data Source=" & dbase & ""
        conexão = New OleDbConnection(ConnString)

        Try

            For Each dr0 In UsuariosDS.Tables(0).Rows

                If Me.UsernameTextBox.Text = dr0.Item(0).ToString Then
                    Usuario = dr0.Item(0).ToString

                    If Me.PasswordTextBox.Text = dr0.Item(1).ToString Then

                        MainInstance = New TelaPrincipal
                        Me.Hide()
                        MainInstance.ShowDialog()
                        GoTo FIM
                        conexão.Close()

                    Else
                        MsgBox("2 - Usuário ou senha incorreta! " & vbNewLine & "Acesso negado!", MsgBoxStyle.Critical)
                        Exit Sub
                    End If

                End If


PROXIMO:
            Next

            MsgBox("1 - Usuário ou senha incorreta! " & vbNewLine & "Acesso negado!", MsgBoxStyle.Critical)
            Exit Sub
            'MsgBox("Digitado: " & Me.UsernameTextBox.Text & "  Dado: " & reader1(0))

        Catch ex As Exception
            conexão.Close()
            MsgBox(ex.Message)
            Exit Sub
            Dispose()
        End Try
        ' Create the command.

FIM:

        Me.Close()


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        ExitProgram("IceSoft")
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Text = "Login - Sistema de cadastro e vendas"
        If IO.File.Exists(xres & "fundo-geral.jpg") Then
            Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
            Me.BackgroundImage = back1
        End If

        If IO.File.Exists(xres & "logotipo.png") Then
            Dim logo As New Bitmap(xres & "logotipo.png")
            Me.LogoPictureBox.Image = logo
        End If

        dbase = dblocal(My.Application.Info.DirectoryPath & "\database.dat")
        ConnString = "Provider=Microsoft.ACE.OleDb.12.0; Data Source=" & dbase & ";Jet OLEDB:Database Password=jesus@cristo#senhor"
        conexão = New OleDbConnection(ConnString)

    End Sub

    Private Sub AddUser(Optional novo As Boolean = False)

        Dim FormUsuario As New ConfigUsuario
        FormUsuario.vl = 0
        FormUsuario.Tipo = "Padrao"

        'FormUsuario.Tipo = "Administrador"

        FormUsuario.txtSenhaAtual.Visible = False
        FormUsuario.Label2.Visible = False

        FormUsuario.ShowDialog()

        Try
            If FormUsuario.DialogResult = Windows.Forms.DialogResult.OK Then

                Dim Nome As String = FormUsuario.txtNome.Text
                Dim Senha As String = FormUsuario.txtNovaSenha.Text
                Dim RedSenha As String = FormUsuario.txtRedSenha.Text
                Dim UserTipo As String = FormUsuario.Tipo
                Dim NomeComp As String = FormUsuario.txtNomeComp.Text
                Dim RG As String = FormUsuario.txtRg.Text
                Dim Tel1 As String = FormUsuario.txtTelefone1.Text
                Dim Tel2 As String = FormUsuario.txtTelefone2.Text
                Dim Email As String = FormUsuario.txtEmail.Text
                Dim Endereco As String = FormUsuario.txtEndereco.Text
                Dim Bairro As String = FormUsuario.txtBairro.Text
                Dim Cidade As String = FormUsuario.txtCidade.Text
                Dim Estado As String = FormUsuario.txtEstado.Text
                Dim CEP As String = FormUsuario.txtCep.Text
                Dim Foto As String = FormUsuario.imgloc

                conexão.Close()
                conexão.Open()
                'Dim variavel As String
                'variavel = "VALUES ('" & Codigo & "','" & Razao & "','" & Fantasia & "','" & Cnpj & "','" & Endereco & "','" & Contato & "','" & Telefone & "','" & Telefone2 & "','" & Email & "'"
                'MsgBox(variavel)

                Dim sqlCom As String = "INSERT INTO usuarios ([User],[Senha],[Tipo],[Nome],[RG],[Telefone1],[Telefone2],[Email],[Endereco],[Bairro],[Cidade],[Estado],[CEP],[Foto]) VALUES ('" & Nome & "','" & Senha & "','" & UserTipo & "','" & NomeComp & "','" & RG & "','" & Tel1 & "','" & Tel2 & "','" & Email & "','" & Endereco & "','" & Bairro & "','" & Cidade & "','" & Estado & "','" & CEP & "','" & Foto & "')"
                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim Ra As Integer = MyCommand.ExecuteNonQuery

                conexão.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try


        conexão.Close()

    End Sub

    Private Sub FrmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ExitProgram("IceSoft")
    End Sub

End Class

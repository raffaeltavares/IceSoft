'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows

Public Class FrmConfigPadrao

    Public poradmin As Boolean
    Public nomeuser As String

    Private Sub FrmConfigPadrao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If IO.File.Exists(xres & "fundo-geral.jpg") Then
        '    Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
        '    Me.BackgroundImage = back1
        'End If

        If IO.File.Exists(xres & "edit.png") Then
            Dim back3 As New Bitmap(xres & "edit.png")
            Me.btnPessoal.Image = back3
        End If

        If IO.File.Exists(xres & "edit.png") Then
            Dim back3 As New Bitmap(xres & "edit.png")
            Me.btnSenha.Image = back3
        End If

    End Sub

    Public Sub Editar(ByVal action As Integer)

        Dim FormUsuario As New ConfigUsuario
        FormUsuario.vl = action
        FormUsuario.modo = 2
        'If VerificaUser(Usuario) = "Padrao" Then
        '    FormUsuario.Tipo = "Padrao"
        'End If

        conexão.Close()
        conexão.Open()

        'MsgBox(varCodigo)
        Dim sqlCom As String = "SELECT * FROM usuarios WHERE [User]='" & nomeuser & "'"
        'Dim MyCommand As New OleDbCommand(sqlCom, conexão)
        'Dim Ra As Integer = MyCommand.ExecuteNonQuery

        Try
            ' Create the command.
            Dim reader1 As OleDbDataReader
            Dim command As OleDbCommand = conexão.CreateCommand()
            command.CommandText = sqlCom
            reader1 = command.ExecuteReader()

            reader1.Read()

            FormUsuario.txtNome.Text = reader1(0)
            FormUsuario.senhaatual = reader1(1)
            FormUsuario.Tipo = reader1(2)
            FormUsuario.txtNomeComp.Text = reader1(3)
            FormUsuario.txtRg.Text = reader1(4)
            FormUsuario.txtTelefone1.Text = reader1(5)
            FormUsuario.txtTelefone2.Text = reader1(6)
            FormUsuario.txtEmail.Text = reader1(7)
            FormUsuario.txtEndereco.Text = reader1(8)
            FormUsuario.txtBairro.Text = reader1(9)
            FormUsuario.txtCidade.Text = reader1(10)
            FormUsuario.txtEstado.Text = reader1(11)
            FormUsuario.txtCep.Text = reader1(12)

            If Not IsDBNull(reader1(13)) = True Then
                If File.Exists(reader1(13)) Then
                    FormUsuario.imgloc = reader1(13)
                    FormUsuario.PcFoto.Image = Image.FromFile(FormUsuario.imgloc)
                End If
            Else
                FormUsuario.imgloc = " "
            End If


            FormUsuario.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message & "  Erro ao executar o Read ---" & vbNewLine & ex.ToString)
            Me.Dispose()
        End Try

        conexão.Close()

    End Sub

    Private Sub btnSenha_Click(sender As Object, e As EventArgs) Handles btnSenha.Click
        Me.Hide()
        Editar(1)
        Close()
    End Sub

    Private Sub btnPessoal_Click(sender As Object, e As EventArgs) Handles btnPessoal.Click
        Me.Hide()
        Editar(2)
        Close()
    End Sub


End Class
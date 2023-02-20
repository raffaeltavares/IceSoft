'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data.OleDb
Imports System.Windows
Imports System.Text


Public Class FrmCliente

    Public vl As Integer
    Public tp As Integer


    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If IO.File.Exists(xres & "fundo-geral.jpg") Then
        '    Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
        '    Me.BackgroundImage = back1
        'End If

        If IO.File.Exists(xres & "accept_database.png") Then
            Dim back2 As New Bitmap(xres & "accept_database.png")
            Me.btnOk.Image = back2
        End If

        If IO.File.Exists(xres & "cancel.png") Then
            Dim back3 As New Bitmap(xres & "cancel.png")
            Me.Button2.Image = back3
        End If


        'MsgBox(vl)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Cadastrar(vl)

    End Sub

    Private Sub Cadastrar(ByVal v As Integer)

        If v = 0 Then

        Else
            Editando()
        End If

    End Sub

    Private Sub Editando()

        Try
            conexão.Close()
            conexão.Open()
            'Dim sqlCom As String = "UPDATE fornecedores  SET [Razão Social] = '@Razao', [Nome Fantasia] = '@Fantasia', [CNPJ] = '@Cnpj', [Endereço] = '@Endereco', [Contato] = '@Contato', [Telefone] = '@Telefone', [Telefone 2] = '@Telefone2', [E-mail] = '@Email' WHERE [Codigo] = @Codigo"

            Dim sqlCom As String = "UPDATE clientes  SET [Nome] = '" & Me.txtNome.Text & "', [CPF] = '" & RemoveCaracteres(Me.txtCpf.Text) & "', " &
                "[Email] = '" & Me.TxtEmail.Text & "', [Telefone] = '" & RemoveCaracteres(Me.txtTelefone.Text) & "' WHERE [Codigo] = " & lblChave.Text & ""
            Dim MyCommand As New OleDbCommand(sqlCom, conexão)
            Dim Ra As Integer = MyCommand.ExecuteNonQuery

            conexão.Close()
            Close()

            'MsgBox("EDITOU REGISTRO")
        Catch ex As Exception
            MsgBox(ex.Message)
            conexão.Close()
            Close()
        End Try
    End Sub

End Class
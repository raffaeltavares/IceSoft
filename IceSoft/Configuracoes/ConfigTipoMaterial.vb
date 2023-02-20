'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows

Public Class FrmConfigCateg

    Public vlcat As Integer
    Public Ctipo As String


    Private Sub FrmConfigCateg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If vlcat = 1 Then
        '    GroupBox1.Enabled = False
        '    txtCategoria.ReadOnly = True
        'Else
        '    GroupBox1.Enabled = True
        '    txtCategoria.ReadOnly = False
        'End If

        'If IO.File.Exists(xres & "fundo-geral.jpg") Then
        '    Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
        '    Me.BackgroundImage = back1
        'End If

        If IO.File.Exists(xres & "accept_database.png") Then
            Dim back1 As New Bitmap(xres & "accept_database.png")
            Me.Button1.Image = back1
        End If

        If IO.File.Exists(xres & "cancel.png") Then
            Dim back1 As New Bitmap(xres & "cancel.png")
            Me.Button2.Image = back1
        End If

        If Ctipo = "g" Then
            radM2.Checked = True
        ElseIf Ctipo = "ml" Then
            radML.Checked = True
        ElseIf Ctipo = "u" Then
            radUnit.Checked = True
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Function TipoCategoria() As String

        TipoCategoria = Nothing

        If radM2.Checked = True Then
            TipoCategoria = "g"
        ElseIf radML.Checked = True Then
            TipoCategoria = "ml"
        ElseIf radUnit.Checked = True Then
            TipoCategoria = "u"
        End If

        Return TipoCategoria

    End Function

    Public Sub Cadastrar(ByVal v As Integer)

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

            Dim sqlCom As String = "UPDATE categorias  SET [Nome] = '" & Me.txtCategoria.Text & "', [Unidade] = '" & TipoCategoria() & "', [Markup] = " & Replace(CDbl(TxtChave.Text), ",", ".") & "  WHERE [id] = " & Me.LbId.Text & " "
            Dim MyCommand As New OleDbCommand(sqlCom, conexão)
            Dim Ra As Integer = MyCommand.ExecuteNonQuery

            conexão.Close()
            Close()


            Dim frm As New ProcessoImportacao
            frm.nomecat = Me.LbId.Text
            frm.nchave = CDbl(TxtChave.Text)
            frm.Processo = 6
            frm.ShowDialog()

            'MsgBox("EDITOU REGISTRO")
        Catch ex As Exception
            MsgBox(ex.Message)
            conexão.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Trim(txtCategoria.Text) = "" Then
            MsgBox("Não é permitido cadastrar uma categoria sem nome! ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Cadastrar(vlcat)
    End Sub


End Class
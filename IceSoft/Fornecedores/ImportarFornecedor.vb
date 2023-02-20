'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows

Public Class FrmImportFornecedor

    Private Sub FrmImportFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists(xres & "fundo-geral.jpg") Then
            Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
            Me.BackgroundImage = back1
        End If

        TxtRazao.Text = 1
        TxtFantasia.Text = 2
        TxtCNPJ.Text = 3
        TxtEndereco.Text = 4
        TxtContato.Text = 5
        TxtTelefone1.Text = 6
        TxtTelefone2.Text = 7
        TextEmail.Text = 8

        ChkPontoVirg.Checked = True


    End Sub

    Private Function Separador() As String

        Separador = Nothing

        If ChkPontoVirg.Checked = True Then
            Separador = ";"
        End If
        If ChkTAB.Checked = True Then
            Separador = vbTab
        End If

        Return Separador
    End Function

    Private Function GerarCodigo(ByVal nometabela As String) As Integer

        Dim i As Integer = 0

        Dim ole1 As String = "SELECT * FROM " & nometabela & ""
        Dim OleCom1 As New OleDbCommand(ole1, conexão)
        Dim oleAdapter1 As New OleDbDataAdapter(OleCom1)
        Dim ds1 As New DataSet()
        Dim dr As DataRow

        oleAdapter1.Fill(ds1, nometabela)
        Dim j As Integer = ds1.Tables(nometabela).Rows.Count
        'MsgBox("Numero de linhas" & j)

        If j = 0 Then
            i = i + 1
            'MsgBox("Identificou Num de linhas menor que: " & 1)
            GerarCodigo = i

        Else

            Do Until i > j
                i = i + 1

                'MsgBox("Lendo linha: " & i & " - de: " & j)
                For Each dr In ds1.Tables(nometabela).Rows
                    If dr.Item(0).ToString = i Then
                        'MsgBox("Existe!")
                        GoTo EXISTE
                    End If
                Next

                'MsgBox("Vai gerar: " & i)
                GerarCodigo = i
                Exit Do

EXISTE:
            Loop


        End If

        Return GerarCodigo
    End Function

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub


    Private Sub TxtRazao_TextChanged(sender As Object, e As EventArgs) Handles TxtRazao.TextChanged
        If LTrim(RTrim(TxtRazao.Text)) = Nothing Then
            TxtRazao.Text = 0
        End If
    End Sub

    Private Sub TxtFantasia_TextChanged(sender As Object, e As EventArgs) Handles TxtFantasia.TextChanged
        If LTrim(RTrim(TxtFantasia.Text)) = Nothing Then
            TxtFantasia.Text = 0
        End If
    End Sub

    Private Sub TxtCNPJ_TextChanged(sender As Object, e As EventArgs) Handles TxtCNPJ.TextChanged
        If LTrim(RTrim(TxtCNPJ.Text)) = Nothing Then
            TxtCNPJ.Text = 0
        End If
    End Sub

    Private Sub TxtEndereco_TextChanged(sender As Object, e As EventArgs) Handles TxtEndereco.TextChanged
        If LTrim(RTrim(TxtEndereco.Text)) = Nothing Then
            TxtEndereco.Text = 0
        End If
    End Sub

    Private Sub TxtTelefone1_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefone1.TextChanged
        If LTrim(RTrim(TxtTelefone1.Text)) = Nothing Then
            TxtTelefone1.Text = 0
        End If
    End Sub

    Private Sub TxtTelefone2_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefone2.TextChanged
        If LTrim(RTrim(TxtTelefone2.Text)) = Nothing Then
            TxtTelefone2.Text = 0
        End If
    End Sub

    Private Sub TextEmail_TextChanged(sender As Object, e As EventArgs) Handles TextEmail.TextChanged
        If LTrim(RTrim(TextEmail.Text)) = Nothing Then
            TextEmail.Text = 0
        End If
    End Sub

    Private Sub TxtContato_TextChanged(sender As Object, e As EventArgs) Handles TxtContato.TextChanged
        If LTrim(RTrim(TxtContato.Text)) = Nothing Then
            TxtContato.Text = 0
        End If
    End Sub

    Private Sub ChkPontoVirg_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPontoVirg.CheckedChanged
        Separador()
    End Sub

    Private Sub ChkVirgula_CheckedChanged(sender As Object, e As EventArgs)
        Separador()
    End Sub

    Private Sub ChkTAB_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTAB.CheckedChanged
        Separador()
    End Sub


End Class
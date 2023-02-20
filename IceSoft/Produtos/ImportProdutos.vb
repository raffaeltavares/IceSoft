'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data.OleDb
Imports System.Windows

Public Class FrmImportProd

    Private Sub FrmImportProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IO.File.Exists(xres & "fundo-geral.jpg") Then
            Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
            Me.BackgroundImage = back1
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Me.Close()
    End Sub

    Private Sub txtColunas_TextChanged(sender As Object, e As EventArgs) Handles txtColunas.TextChanged
        If txtColunas.Text = "" Then
            txtColunas.Text = 1
        End If
    End Sub

    Private Sub txtLinhas_TextChanged(sender As Object, e As EventArgs) Handles txtMateriais.TextChanged
        If txtMateriais.Text = "" Then
            txtMateriais.Text = 0
        End If
    End Sub

    Private Sub txtLinhas_TextKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMateriais.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtColunas_TextKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColunas.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class
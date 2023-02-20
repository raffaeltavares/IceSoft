'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows

Public Class FrmTipoProd

    Public vl As Integer
    Public nome As String

    Private Sub FrmTipoProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IO.File.Exists(xres & "fundo-geral.jpg") Then
            Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
            Me.BackgroundImage = back1
        End If

        If IO.File.Exists(xres & "accept_database.png") Then
            Dim back1 As New Bitmap(xres & "accept_database.png")
            Me.Button1.Image = back1
        End If

        If IO.File.Exists(xres & "cancel.png") Then
            Dim back1 As New Bitmap(xres & "cancel.png")
            Me.Button2.Image = back1
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    
End Class
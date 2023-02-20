'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows

Public Class FrmPedidoOk

    Public file As String
    Public status As String

    Private Sub FrmAddPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If IO.File.Exists(xres & "checkmark3.png") Then
        '    Dim back3 As New Bitmap(xres & "checkmark3.png")
        '    Me.btnFinalizar.Image = back3

        'End If

    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Close()
    End Sub

End Class
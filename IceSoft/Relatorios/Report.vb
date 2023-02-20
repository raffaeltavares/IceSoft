Imports System.Drawing
Imports System.IO


'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Public Class FrmReport

    Dim registro As Integer
    Dim Zoom As Double = 1.25
    Dim page As Integer = 0

    'Public modo As Integer = 0

    Public Indice As Integer = 0
    Public LinhaAtual As Integer = 0
    Private paginaatual As Integer = 1
    Public soma As Boolean = False
    Private _client As String
    Private _detalhe As String
    Private _codmat As String
    Private _descmat As String
    Private _basemat As String
    Private _altumat As String
    Private _espmat As String
    Private _data As String

    Private curview As Integer = 0
    Public qtchapas As Integer = 0


#Region "Properties"

    Public Property Cliente() As String
        Get
            Return _client
        End Get
        Set(value As String)
            _client = value
        End Set
    End Property

    Public Property Detalhe() As String
        Get
            Return _detalhe
        End Get
        Set(value As String)
            _detalhe = value
        End Set
    End Property

    Public Property Data() As String
        Get
            Return _data
        End Get
        Set(value As String)
            _data = value
        End Set
    End Property


    Public Property Codigo() As String
        Get
            Return _codmat
        End Get
        Set(value As String)
            _codmat = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return _descmat
        End Get
        Set(value As String)
            _descmat = value
        End Set
    End Property

    Public Property BaseMat() As String
        Get
            Return _basemat
        End Get
        Set(value As String)
            _basemat = value
        End Set
    End Property

    Public Property AlturaMat() As String
        Get
            Return _altumat
        End Get
        Set(value As String)
            _altumat = value
        End Set
    End Property

    Public Property EspeMat() As String
        Get
            Return _espmat
        End Get
        Set(value As String)
            _espmat = value
        End Set
    End Property


#End Region
   

    Private Sub FrmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'MsgBox(printpages)

        If IO.File.Exists(xres & "print.png") Then
            Dim back2 As New Bitmap(xres & "print.png")
            Me.btnImprimir.Image = back2
        End If

        If IO.File.Exists(xres & "back.png") Then
            Dim back3 As New Bitmap(xres & "back.png")
            Me.btnAnterior.Image = back3
        End If

        If IO.File.Exists(xres & "next.png") Then
            Dim back4 As New Bitmap(xres & "next.png")
            Me.btnProxima.Image = back4
        End If

        If IO.File.Exists(xres & "zoom.png") Then
            Dim back5 As New Bitmap(xres & "zoom.png")
            Me.btnZoom.Image = back5
        End If

        If IO.File.Exists(xres & "zoom-.png") Then
            Dim back5 As New Bitmap(xres & "zoom-.png")
            Me.btnZoomMenos.Image = back5
        End If


        If IO.File.Exists(xres & "pdf.png") Then
            Dim back6 As New Bitmap(xres & "pdf.png")
            Me.btnPdf.Image = back6
        End If

        If IO.File.Exists(xres & "exit.png") Then
            Dim back7 As New Bitmap(xres & "exit.png")
            Me.btnSair.Image = back7
        End If

        Label1.Text = "Página: " & page + 1 & " de " & printpages
        Update()

        'SetLanguage(Me)


    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        'If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
        'Me.PrintDialog1.Document.Print()
        DialogResult = DialogResult.OK
        Close()
        'End If

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If (page + 1) > 1 Then
            page -= 1
            PrintPreviewControl1.StartPage = page
            PrintPreviewControl1.Update()
            Label1.Text = "Página: " & page + 1 & " de " & printpages
        End If
    End Sub

    Private Sub btnProxima_Click(sender As Object, e As EventArgs) Handles btnProxima.Click
        If (page + 1) < printpages Then
            page += 1
            PrintPreviewControl1.StartPage = page
            PrintPreviewControl1.Update()
            Label1.Text = "Página: " & page + 1 & " de " & printpages
        End If

    End Sub

    Private Sub btnZoom_Click(sender As Object, e As EventArgs) Handles btnZoom.Click

        PrintPreviewControl1.Zoom = Zoom
        Zoom += 0.25

        If Zoom > 1.5 Then
            Zoom = 0.25
        End If

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnZoomMenos.Click

        Zoom -= 0.25
        If Zoom <= 0.25 Then
            Zoom = 0.25
        End If
        PrintPreviewControl1.Zoom = Zoom

    End Sub


    Private Sub btnPdf_Click(sender As Object, e As EventArgs) Handles btnPdf.Click


        'Dim sfd As SaveFileDialog = New SaveFileDialog()
        'sfd.Title = "Save As PDF"
        'sfd.Filter = "(*.pdf)|*.pdf"
        'sfd.InitialDirectory = "C:\"

        'If sfd.ShowDialog() = DialogResult.OK Then

        '    Dim doc As iTextSharp.text.Document = New iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 188.0F, 88.0F, 5.0F, 10.0F)
        '    Dim PdfWriter As iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))

        '    doc.Open()
        '    Dim cb As iTextSharp.text.pdf.PdfContentByte = PdfWriter.DirectContent
        '    pdPlanos_PrintPageCorte(doc, cb)
        '    doc.Close()

        'End If


    End Sub


    Private Function ScaleSetPrint(w As Single, h As Single) As Single
        ScaleSetPrint = 1

        Dim valor As Single = 0

        If w > h Then
            valor = (780 * 100) / w
            ScaleSetPrint = valor / 100
        Else
            valor = (550 * 100) / h
            ScaleSetPrint = valor / 100
        End If

        Return ScaleSetPrint
    End Function

    Private Function ScaleSetLogo(w As Single, h As Single) As Single
        ScaleSetLogo = 1

        Dim valor As Single = 0

        If w > h Then
            valor = (250 * 100) / w
            ScaleSetLogo = valor / 100

            If h * ScaleSetLogo > 60 Then
                valor = (60 * 100) / h
                ScaleSetLogo = valor / 100
            End If

        Else
            valor = (60 * 100) / h
            ScaleSetLogo = valor / 100

            If w * ScaleSetLogo > 250 Then
                valor = (250 * 100) / w
                ScaleSetLogo = valor / 100
            End If

        End If

        Return ScaleSetLogo
    End Function



End Class

Imports System.IO
Imports System.Threading

Public Class ToolCustom

    Public Shared Time As Integer
    Public Shared Delay As Integer
    Private Op As Double = 0.0
    Public Shared Codigo As String
    Public Shared Descricao As String
    Public Shared Categoria As String
    Public Shared Linha As String
    Public Shared Preco As String
    Public Shared Detalhe As String
    Public Shared Imagem As String

    Private Sub ToolCustom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Opacity = 0

        Me.LbCodigo.Text = Codigo
        Me.LbDescricao.Text = Descricao
        Me.LbCategoria.Text = Categoria
        Me.LbLinha.Text = Linha
        Me.LbPreco.Text = Preco

        If File.Exists(Imagem) Then
            PictureBox1.Image = Image.FromFile(Imagem)
        Else
            PictureBox1.Image = Image.FromFile(xres & "especial.png")
        End If

        'Loading()
        'Exiting()
        Timer1.Enabled = True
        Timer1.Interval = Time
        Timer1.Start()

    End Sub

    Public Sub Loading()
        Me.Opacity = Op
        While Op < 100.0
            Application.DoEvents()
            Thread.Sleep(500)
            Op += 10.0
            Me.Opacity = Op
            Update()

        End While

    End Sub

    Public Sub Exiting()
        Me.Opacity = Op
        While Op > 0
            Application.DoEvents()
            Thread.Sleep(500)
            Op -= 10
            Me.Opacity = Op
            Update()
        End While
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Enabled = False
        Dispose()
    End Sub


End Class
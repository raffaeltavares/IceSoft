'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data.OleDb
Imports System.Windows
Imports System.Drawing.Printing


Public Class DadosProduto

    Private RelatorioTitulo As String
    Public imgloc As String
    Public ProdutoAtual As Produto
    Public modo As Integer = 0

    Private Sub FrmDadosProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IO.File.Exists(xres & "checkmark3.png") Then
            Dim back3 As New Bitmap(xres & "checkmark3.png")
            Me.btnAdd.Image = back3
        End If

        If modo = 0 Then
            Me.btnAdd.Visible = False
            Me.Label2.Visible = False
            Me.txtQtd.Visible = False
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)

        Dim frmprint As New FrmReport
        'define o titulo do relatorio
        RelatorioTitulo = "Dados do Produto"
        'define os objetos printdocument e os eventos associados
        Dim pd As Printing.PrintDocument = New Printing.PrintDocument()
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf Me.pdProduto_PrintPage)

        frmprint.PrintPreviewControl1.Document = pd
        frmprint.ShowDialog()


    End Sub

    Private Sub pdProduto_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        Dim logo As String = Nothing

        Dim ole1 As String = "SELECT * FROM config"
        Dim OleCom1 As New OleDbCommand(ole1, conexão)
        Dim oleAdapter1 As New OleDbDataAdapter(OleCom1)
        Dim ds1 As New DataSet()
        oleAdapter1.Fill(ds1, "config")
        For Each dr As DataRow In ds1.Tables(0).Rows
            If dr.Item(0).ToString = "logo" Then
                logo = dr.Item(1).ToString
                Exit For
            End If
        Next

        'Variaveis das linhas
        Dim LinhasPorPagina As Single = 0
        Dim PosicaoDaLinha As Single = 0
        Dim LinhaAtual As Integer = 0
        Dim paginaatual As Integer = 1

        'Variaveis das margens
        Dim MargemEsquerda As Single = e.MarginBounds.Left
        Dim MargemSuperior As Single = e.MarginBounds.Top + 100
        Dim MargemDireita As Single = e.MarginBounds.Right
        Dim MargemInferior As Single = e.MarginBounds.Bottom
        Dim CanetaDaImpressora As Pen = New Pen(Color.Black, 1)
        Dim codigo As Integer
        Dim nome As String

        'Variaveis das fontes
        Dim FonteNegrito As Font
        Dim FonteTitulo As Font
        Dim FonteSubTitulo As Font
        Dim FonteRodape As Font
        Dim FonteNormal As Font

        'define efeitos em fontes
        FonteNegrito = New Font("Eras Medium ITC", 11, FontStyle.Bold)
        FonteTitulo = New Font("Eras Medium ITC", 13, FontStyle.Bold)
        FonteSubTitulo = New Font("Eras Medium ITC", 12, FontStyle.Bold)
        FonteRodape = New Font("Eras Medium ITC", 11)
        FonteNormal = New Font("Eras Medium ITC", 11)

        'define valores para linha atual e para linha da impressao
        LinhaAtual = 0
        Dim L As Integer = 0

        'Cabecalho
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
        'nome da empresa
        e.Graphics.DrawString(LbCodigo.Text, FonteTitulo, Brushes.Blue, MargemEsquerda + 250, 80, New StringFormat())

        'Imagem
        If File.Exists(logo) Then
            e.Graphics.DrawImage(Image.FromFile(logo), 100, 63)
        End If

        e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today, FonteSubTitulo, Brushes.Black, MargemEsquerda + 250, 120, New StringFormat())

        'campos a serem impressos: Codigo e Nome
        e.Graphics.DrawString("Cod.", FonteNegrito, Brushes.Black, MargemEsquerda + 100, 170, New StringFormat())
        e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 200, 170, New StringFormat())
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)

        LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)

        'Aqui sao lidos os dados
        'While (LinhaAtual < LinhasPorPagina)

        'inicia a impressao
        PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
        e.Graphics.DrawString(LbDescricao.Text.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 100, PosicaoDaLinha, New StringFormat())
        e.Graphics.DrawString(LbPreco.Text, FonteNormal, Brushes.Black, MargemEsquerda + 200, PosicaoDaLinha, New StringFormat())
        'LinhaAtual += 1

        'End While
        'Rodape
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
        e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
        LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
        LinhaAtual += 1
        e.Graphics.DrawString("Pagina : " & paginaatual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())

        'Incrementa o n£mero da pagina
        paginaatual += 1

        'verifica se continua imprimindo
        If (LinhaAtual > LinhasPorPagina) Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    


End Class
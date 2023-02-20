'Copyright (c) 2021 Rafael Rodrigo Tavares de Santana


Imports System.IO
Imports System.Data.OleDb
Imports System.Windows

Public Class CatalogoProdutos

    Public ProdutoAtual As Produto

    Private LinhaAtual As Integer = 0
    Private paginaatual As Integer = 1
    Private Pages As Integer
    Public modo As Integer = 0

    Dim item1 As ListViewItem
    Dim img As Image
    Dim k As Integer
    Dim Prss As Integer = 0
    Dim Percent As Integer = 0
    Dim ProgBar As Integer = 0
    Private preview As Bitmap = Nothing

    Private Sub FrmListaProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        PicPreview.Width = (Me.Width / 100) * 0.1
        ListView1.Width = (Me.Width / 100) * 99.9
        ListView1.Left = PicPreview.Width

        PLoading.Left = (Me.Width / 2) - (PLoading.Width / 2)
        PLoading.Top = (Me.Height / 2) - (PLoading.Height / 2)

        If IO.File.Exists(xres & "exit.png") Then
            Dim back5 As New Bitmap(xres & "exit.png")
            Me.btnSair.Image = back5
        End If

        If IO.File.Exists(xres & "list.png") Then
            Dim back7 As New Bitmap(xres & "list.png")
            Me.RdLista.Image = back7
        End If

        If IO.File.Exists(xres & "grid.png") Then
            Dim back8 As New Bitmap(xres & "grid.png")
            Me.RdGrade.Image = back8
        End If

        Timer1.Interval = 500

        PreencherLista("")

    End Sub


    Private Sub PreencherLista(filtroTxt As String)

        k = 0
        'trd.Abort()

        PLoading.Visible = True

        ListView1.SmallImageList.ImageSize = New System.Drawing.Size(50, 50)
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(50, 50)
        ListView1.FullRowSelect = True

        RdLista.Checked = True
        ListView1.Items.Clear()

        PreencherImagens()
        'MsgBox("Limpou lista")

        conexão.Close()
        conexão.Open()

        Dim item1 As ListViewItem

        'Dim contTipo() As String = filtroTipo.Split("-")
        'Dim iTipo As String = If(contTipo.Count > 1, Trim(contTipo(0)), "SEM FILTRO")

        Try

            conexão.Close()
            conexão.Open()
            Dim dt As DataRow
            Dim cCol As Integer = 0

            ListView1.BeginUpdate()
            ProgBar = ProdutosDS.Tables(0).Rows.Count

            For Each dt In ProdutosDS.Tables(0).Rows
                cCol = 0

                Dim flagFiltro As Boolean = True

                If filtroTxt <> "" Then
                    flagFiltro = False
                    If LCase(Trim(dt(0))).Contains(LCase(filtroTxt)) Or
                            LCase(Trim(dt(1))).Contains(LCase(filtroTxt)) Then
                        flagFiltro = True
                    End If
                End If

                If flagFiltro = True Then

                    Dim Codigo As String = dt.Item(0).ToString
                    Dim Descricao As String = If(IsDBNull(dt.Item(1).ToString) = False, dt.Item(1).ToString, "")
                    Dim Categoria As String = If(IsDBNull(dt.Item(2).ToString) = False, dt.Item(2).ToString, "")
                    Dim Imagem As String = If(IsDBNull(dt.Item(3).ToString) = False, dt.Item(3).ToString, "")
                    Dim Custo As Double = If(IsDBNull(dt.Item(4).ToString) = False, CDbl(dt.Item(4).ToString()), 0.0)
                    Dim Bruto As Double = If(IsDBNull(dt.Item(5).ToString) = False, CDbl(dt.Item(5).ToString()), 0.0)
                    Dim Liquido As Double = If(IsDBNull(dt.Item(7).ToString) = False, CDbl(dt.Item(7).ToString()), 0.0)
                    Dim Tributos As Double = If(IsDBNull(dt.Item(12).ToString) = False, CDbl(dt.Item(12).ToString()), 0.0)
                    Dim LucroPercent As Double = If(IsDBNull(dt.Item(14).ToString) = False, CDbl(dt.Item(14).ToString()), 0.0)
                    Dim LucroReal As Double = If(IsDBNull(dt.Item(13).ToString) = False, CDbl(dt.Item(13).ToString()), 0.0)

                    Dim img As Image
                    If File.Exists(Imagem) = True Then
                        img = Image.FromFile(Imagem)
                    Else
                        img = My.Resources.ESPECIAL
                    End If

                    item1 = New ListViewItem(Codigo, ImgList.Images.IndexOfKey(Imagem))
                    item1.SubItems.Add(Descricao)
                    item1.SubItems.Add(Categoria)
                    item1.SubItems.Add("R$ " & Liquido)
                    'item1.SubItems.Add(dt.Item(5).ToString)

                    'MsgBox("inclui os itens no listview")
                    ListView1.Items.AddRange(New ListViewItem() {item1})
                    'ImageList1.Images.Add(img)
                    item1 = Nothing

                    k += 1

                    Application.DoEvents()

                    Prss = Prss + 1
                    Percent = (Prss * 100) / ProgBar
                    LbPercent.Text = Percent & " %"

                    'DtvProdutos.Rows.Add(img, Codigo, Descricao, Categoria, "R$ " & Custo, "R$ " & Bruto, "R$ " & Liquido, "R$ " & Tributos, LucroPercent & " %", "R$ " & LucroReal)
                End If

CONT1:
                'System.Windows.Forms.Application.DoEvents()

            Next

            ListView1.EndUpdate()

            conexão.Close()

            Timer1.Stop()

        Catch ex As Exception
            MsgBox("Preencher lista:  " & ex.Message)
        End Try

        PLoading.Visible = False

        ''DtvProdutos.Visible = True
        'flagSelect = True

    End Sub

    Public Sub PreencherImagens()

        ImgList.Images.Clear()
        'MsgBox("Vai iniciar a coleção de imagens")

        For Each thumb As DataRow In ProdutosDS.Tables(0).Rows
            Application.DoEvents()
            If File.Exists(thumb.Item(3).ToString) = True Then
                mm = Image.FromFile(thumb.Item(3).ToString).GetThumbnailImage(50, 50, Nothing, New IntPtr)
            Else
                mm = Image.FromFile(xres & "especial.png").GetThumbnailImage(50, 50, Nothing, New IntPtr)
            End If
            ImgList.Images.Add(thumb.Item(3).ToString, mm)
        Next

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Visualizar()
    End Sub


    Private Sub Visualizar()

        Dim FormularioProduto As New DadosProduto
        FormularioProduto.modo = modo

        conexão.Close()
        conexão.Open()

        Dim i As Integer = ListView1.FocusedItem.Index
        Dim varCodigo As String = ListView1.Items.Item(i).Text
        'MsgBox(varCodigo)
        Dim sqlCom As String = "SELECT * FROM produtos WHERE [Codigo]='" & varCodigo & "'"
        Dim reader1 As OleDbDataReader
        Dim command As OleDbCommand = conexão.CreateCommand()
        command.CommandText = sqlCom

        Try
            ' Create the command.

            reader1 = command.ExecuteReader()
            While reader1.Read()
                ProdutoAtual = New Produto
                With ProdutoAtual

                    .Codigo = reader1(0)
                    .Descricao = reader1(1)
                    .Qt = 1
                    .Valor = reader1(7)

                    FormularioProduto.LbCodigo.Text = reader1(0)
                    FormularioProduto.LbDescricao.Text = reader1(1)
                    FormularioProduto.LbPreco.Text = reader1(7)

                    If Not IsDBNull(reader1(11)) Then
                        Dim ComponentesText As String = ""

                        FormularioProduto.LbEspecificacoes.Text = reader1(18)
                    End If

                    If Not IsDBNull(reader1(11)) Then
                        Dim ComponentesText As String = reader1(11)
                        Dim Itens() = ComponentesText.Split("&&")
                        If Itens.Length > 0 Then
                            For i = 0 To Itens.Length - 1
                                Dim Part() = Itens(i).Split(";")
                                If Part.Length > 1 Then
                                    Dim nCom = New Componentes
                                    With nCom
                                        .Codigo = Part(0)
                                        .Descricao = Part(1)
                                        .Qt = Part(2)
                                        .Valor = Part(3)
                                        .TotalCusto = Part(4)
                                        .TotalBruto = Part(5)
                                        .Categoria = Part(6)
                                    End With
                                    ProdutoAtual.ListaComponentes.Add(nCom)
                                End If
                            Next
                        End If
                    End If

                    If IO.File.Exists(reader1(3)) Then
                        FormularioProduto.PictureBox1.Image = Image.FromFile(reader1(3))
                        FormularioProduto.imgloc = reader1(3)
                        .Img = Image.FromFile(reader1(3))
                    End If

                    FormularioProduto.txtQtd.Text = .Qt
                    If FormularioProduto.ShowDialog() = DialogResult.OK Then
                        'MsgBox("Result Ok")
                        .Qt = FormularioProduto.txtQtd.Text

                        Me.DialogResult = DialogResult.OK
                        Me.Close()

                    End If

                End With

            End While

            conexão.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
        End Try

    End Sub

    Private Sub RdGrade_CheckedChanged(sender As Object, e As EventArgs) Handles RdGrade.CheckedChanged

        If RdGrade.Checked = True Then
            ListView1.View = View.LargeIcon
        End If

    End Sub

    Private Sub RdLista_CheckedChanged(sender As Object, e As EventArgs) Handles RdLista.CheckedChanged

        If RdLista.Checked = True Then
            ListView1.View = View.Details
        End If

    End Sub


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)

        Pages = 1

        Dim frmprint As New FrmReport
        Dim pd As Printing.PrintDocument = New Printing.PrintDocument()
        AddHandler pd.PrintPage, AddressOf Me.pdProduto_PrintPage
        'pd.Print()

        frmprint.PrintPreviewControl1.Document = pd
        pd.DocumentName = "Lista de produtos"
        frmprint.ShowDialog()
        'pd.Dispose()
        LinhaAtual = 0
        paginaatual = 1

        If frmprint.DialogResult = Forms.DialogResult.OK Then

            Pages = 1

            PrintDialog1.Document = pd
            If PrintDialog1.ShowDialog = Forms.DialogResult.OK Then

                pd.DocumentName = "Lista de produtos"
                pd.PrintController = PrintDialog1.Document.PrintController
                pd.Print()

            End If
        End If

        LinhaAtual = 0
        paginaatual = 1

    End Sub

    Public Sub pdProduto_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        Dim Local As String = "São Paulo"

        Dim logo As String = Nothing
        Dim nomeemp As String = Nothing
        Dim endemp As String = Nothing
        Dim cepemp As String = Nothing
        Dim telemp As String = Nothing
        Dim emailemp As String = Nothing

        Dim cabecalho As String = Nothing


        Dim RowsCounting As Integer = ListView1.Items.Count

        Dim Li As String = Nothing
        Dim ContLinha() As String = Nothing



LerDb:
        For Each dr As DataRow In ConfigDS.Tables(0).Rows
            If dr.Item(0).ToString = "logo" Then
                logo = dr.Item(1).ToString
                'Exit For
            End If
            If dr.Item(0).ToString = "nome" Then
                nomeemp = dr.Item(1).ToString
                'Exit For
            End If
            If dr.Item(0).ToString = "endereco" Then
                endemp = dr.Item(1).ToString
                'Exit For
            End If
            If dr.Item(0).ToString = "cep" Then
                cepemp = dr.Item(1).ToString
                'Exit For
            End If
            If dr.Item(0).ToString = "telefone1" Then
                telemp = dr.Item(1).ToString
                'Exit For
            End If
            If dr.Item(0).ToString = "e-mail" Then
                emailemp = dr.Item(1).ToString
                'Exit For
            End If
            If dr.Item(0).ToString = "cabecalho" Then
                cabecalho = dr.Item(2).ToString
                'Exit For
            End If
        Next


        'Variaveis das linhas
        Dim LinhasPorPagina As Single = 0
        Dim PosicaoDaLinha As Single = 0


        'Variaveis das margens
        Dim MargemEsquerda As Single = e.MarginBounds.Left - 80
        Dim MargemSuperior As Single = e.MarginBounds.Top + 100
        Dim MargemDireita As Single = e.MarginBounds.Right - 80
        Dim MargemInferior As Single = e.MarginBounds.Bottom


        Dim CanetaDaImpressora As Pen = New Pen(Color.Black, 1)
        'Dim codigo As Integer
        'Dim nome As String

        'Variaveis das fontes
        Dim FonteNegrito As Font
        Dim FonteTitulo As Font
        Dim FonteSubTitulo As Font
        Dim FonteRodape As Font
        Dim FonteNormal As Font

        'define efeitos em fontes
        FonteNegrito = New Font("Arial Narrow", 8, FontStyle.Bold)
        FonteTitulo = New Font("Arial Narrow", 10, FontStyle.Bold)
        FonteSubTitulo = New Font("Arial Narrow", 9, FontStyle.Bold)
        FonteRodape = New Font("Calibri", 8)
        FonteNormal = New Font("Arial Narrow", 8)

        'define valores para linha atual e para linha da impressao
        'LinhaAtual = 0
        Dim L As Integer = 0
        Dim rect1 As Rectangle

        'Cabecalho
        'e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
        'e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)

        'nome da empresa
        'e.Graphics.DrawString(LbNomeCliente.Text, FonteTitulo, Brushes.Blue, MargemEsquerda + 250, 80, New StringFormat())
        Dim pt As Point
        Dim posy As Integer = 10
        Dim posx As Integer = 20
        'Imagem
        If File.Exists(logo) Then
            rect1 = New Rectangle(posx, posy, 250, 60)
            pt = New Point(posx, posy)
            e.Graphics.DrawImage(Image.FromFile(logo), rect1)
        End If

        e.Graphics.DrawString(Local & ", " & DateTime.Now.Day.ToString & " de " & MonthName(DateTime.Now.Month) & " de  " & DateTime.Now.Year.ToString, FonteNormal, Brushes.Black, posx + 600, 50, New StringFormat())

        posy += 10

        'If paginaatual = 1 Then

        '    posy = posy + 40
        '    'Cabeçalho
        '    'e.Graphics.DrawString("Lista de produtos", FonteNormal, Brushes.Black, posx, posy, New StringFormat())
        '    'posy = posy + 35
        '    'e.Graphics.DrawString("Item", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
        '    'e.Graphics.DrawString("Código", FonteNegrito, Brushes.Black, posx + 50, posy, New StringFormat())
        '    'e.Graphics.DrawString("Descrição", FonteNegrito, Brushes.Black, posx + 150, posy, New StringFormat())
        '    'e.Graphics.DrawString("Categoria", FonteNegrito, Brushes.Black, posx + 480, posy, New StringFormat())
        '    ''.Graphics.DrawString("Qtde", FonteNegrito, Brushes.Black, posx + 560, posy, New StringFormat())
        '    'e.Graphics.DrawString("Vl. Unitário", FonteNegrito, Brushes.Black, posx + 710, posy, New StringFormat())
        '    ''e.Graphics.DrawString("Vl. Total", FonteNegrito, Brushes.Black, posx + 710, posy, New StringFormat())
        '    'posy = posy + 20
        '    'e.Graphics.DrawLine(CanetaDaImpressora, posx, posy, posx + 780, posy)
        '    'posy = posy + 3
        '    '' e.Graphics.DrawString("Linha: " & Seção, FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
        '    'posy = posy + 17
        '    'e.Graphics.DrawLine(CanetaDaImpressora, posx, posy, posx + 780, posy)
        '    'PosicaoDaLinha = posy + 3

        'End If

CONTINUA:

        '//Rodapé
        Dim str As String = Nothing
        Dim lent As Integer = 0
        e.Graphics.DrawLine(CanetaDaImpressora, posx, MargemInferior, posx + 780, MargemInferior)
        str = nomeemp
        lent = str.Length * 5
        e.Graphics.DrawString(nomeemp, FonteRodape, Brushes.Black, (e.PageBounds.Width / 2) - (lent / 2), MargemInferior, New StringFormat())
        MargemInferior = MargemInferior + 17
        str = endemp & " - " & cepemp
        lent = str.Length * 5
        e.Graphics.DrawString(endemp & " - " & cepemp, FonteRodape, Brushes.Black, (e.PageBounds.Width / 2) - (lent / 2), MargemInferior, New StringFormat())
        MargemInferior = MargemInferior + 17
        str = telemp & " - " & emailemp
        lent = str.Length * 5
        e.Graphics.DrawString(telemp & " - " & emailemp, FonteRodape, Brushes.Black, (e.PageBounds.Width / 2) - (lent / 2), MargemInferior, New StringFormat())

        'LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
        'LinhaAtual += 1
        e.Graphics.DrawString("Pagina : " & paginaatual, FonteRodape, Brushes.Black, posx + 700, MargemInferior, New StringFormat())


        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Near
        stringFormat.LineAlignment = StringAlignment.Center

        Dim imgs As Image = Nothing
        'LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 12)

        Dim linha As Integer = 1

        Dim dtb As DataTable = ProdutosDS.Tables(0)

        Dim Codigo As String = Nothing
        Dim Descri As String = Nothing
        Dim Seção As String = Nothing
        Dim Categ As String = Nothing
        Dim Preço As String = Nothing
        Dim Imag As String = Nothing

        posy = posy + 35

        'Aqui sao lidos os dados
        'While (LinhaAtual < dtb.Rows.Count)
        For Each lv As ListViewItem In ListView1.Items
            'inicia a impressao
            'For Each dtr As DataGridViewRow In DtvOrca.Rows
            'Codigo = TabelaProdutosDS.Tables("tabela_produtos").Rows(LinhaAtual).Item("Codigo").ToString
            'Descri = TabelaProdutosDS.Tables("tabela_produtos").Rows(LinhaAtual).Item("Descricao").ToString
            'Categ = TabelaProdutosDS.Tables("tabela_produtos").Rows(LinhaAtual).Item("Categoria").ToString
            'Preço = TabelaProdutosDS.Tables("tabela_produtos").Rows(LinhaAtual).Item("Bruto_Mult").ToString
            'Imag = TabelaProdutosDS.Tables("tabela_produtos").Rows(LinhaAtual).Item("Img").ToString
            'Seção = TabelaProdutosDS.Tables("tabela_produtos").Rows(LinhaAtual).Item("Linha").ToString
            If lv.Index = LinhaAtual Then
                Codigo = lv.SubItems.Item(0).Text
                Descri = lv.SubItems.Item(1).Text
                Categ = lv.SubItems.Item(2).Text
                Preço = lv.SubItems.Item(4).Text
                'Imag = ImageList1.Images.Item(lv.Index)
                'MsgBox(Imag)
                Seção = lv.SubItems.Item(3).Text

                If linha > 1 Then
                    PosicaoDaLinha += 100 '= posy + (linha * 100)
                Else

                    posy = posy + 40
                    'Cabeçalho
                    e.Graphics.DrawString("Lista de produtos", FonteNormal, Brushes.Black, posx, posy, New StringFormat())
                    posy = posy + 35

                    e.Graphics.DrawString("Item", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
                    e.Graphics.DrawString("Código", FonteNegrito, Brushes.Black, posx + 50, posy, New StringFormat())
                    e.Graphics.DrawString("Descrição", FonteNegrito, Brushes.Black, posx + 150, posy, New StringFormat())
                    e.Graphics.DrawString("Categoria", FonteNegrito, Brushes.Black, posx + 480, posy, New StringFormat())
                    e.Graphics.DrawString("Linha", FonteNegrito, Brushes.Black, posx + 580, posy, New StringFormat())
                    e.Graphics.DrawString("Vl. Unitário", FonteNegrito, Brushes.Black, posx + 710, posy, New StringFormat())
                    'e.Graphics.DrawString("Vl. Total", FonteNegrito, Brushes.Black, posx + 710, posy, New StringFormat())
                    posy = posy + 20
                    e.Graphics.DrawLine(CanetaDaImpressora, posx, posy, posx + 780, posy)
                    posy = posy + 3
                    ' e.Graphics.DrawString("Linha: " & Seção, FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
                    posy = posy + 17
                    e.Graphics.DrawLine(CanetaDaImpressora, posx, posy, posx + 780, posy)
                    PosicaoDaLinha = posy + 3

                End If

                'FonteTitulo.GetHeight(e.Graphics)

                '//Item
                rect1 = New Rectangle(posx, PosicaoDaLinha, 50, 80)
                e.Graphics.DrawString(LinhaAtual + 1, FonteNormal, Brushes.Black, rect1, stringFormat)

                '//Imagem e Código
                'If File.Exists(Imag) Then
                '    imgs = Image.FromFile(Imag)
                'Else
                '    imgs = My.Resources.image
                'End If

                imgs = ImgList.Images.Item(lv.Index)
                rect1 = New Rectangle(posx + 30, PosicaoDaLinha, 80, 80)
                e.Graphics.DrawImage(imgs, rect1)
                'e.Graphics.DrawImage(ResizeImage(imgs), New Point(posx, PosicaoDaLinha))
                e.Graphics.DrawString(Codigo, FonteNormal, Brushes.Black, posx + 35, PosicaoDaLinha + 80, New StringFormat())

                '//Descrição
                rect1 = New Rectangle(posx + 130, PosicaoDaLinha, 320, 80)
                e.Graphics.DrawString(Descri, FonteNormal, Brushes.Black, rect1, stringFormat)
                'e.Graphics.DrawString(DtvOrca.Item(2, LinhaAtual).Value, FonteNormal, Brushes.Black, posx + 110, PosicaoDaLinha, New StringFormat())

                '//Categoria
                rect1 = New Rectangle(posx + 480, PosicaoDaLinha, 150, 80)
                e.Graphics.DrawString(Categ, FonteNormal, Brushes.Black, rect1, stringFormat)
                'e.Graphics.DrawString(DtvOrca.Item(3, LinhaAtual).Value, FonteNormal, Brushes.Black, posx + 400, PosicaoDaLinha, New StringFormat())

                '//Linha
                rect1 = New Rectangle(posx + 590, PosicaoDaLinha, 150, 80)
                e.Graphics.DrawString(Seção, FonteNormal, Brushes.Black, rect1, stringFormat)
                'e.Graphics.DrawString(Seção, FonteNormal, Brushes.Black, posx + 520, PosicaoDaLinha, New StringFormat())

                '//Preço unitario
                rect1 = New Rectangle(posx + 710, PosicaoDaLinha, 150, 80)
                e.Graphics.DrawString("R$ " & Preço, FonteNormal, Brushes.Black, rect1, stringFormat)
                'e.Graphics.DrawString("R$ " & DtvOrca.Item(5, LinhaAtual).Value, FonteNormal, Brushes.Black, posx + 620, PosicaoDaLinha, New StringFormat())

                'rect1 = New Rectangle(posx + 710, PosicaoDaLinha, 150, 80)
                'e.Graphics.DrawString("R$ " & DtvOrca.Item(6, LinhaAtual).Value, FonteNormal, Brushes.Black, rect1, stringFormat)
                'e.Graphics.DrawString("R$ " & DtvOrca.Item(6, LinhaAtual).Value, FonteNormal, Brushes.Black, posx + 700, PosicaoDaLinha, New StringFormat())

                'Next
                'MsgBox("Posição Linha: " & PosicaoDaLinha + 65 & " Linha atual: " & LinhaAtual & vbNewLine & "Page height: " & e.PageBounds.Height & vbNewLine & "MArgem inf: " & e.MarginBounds.Bottom)
                If (PosicaoDaLinha + 100 > e.PageBounds.Height - 100) Then
                    'Incrementa o n£mero da pagina

                    paginaatual = paginaatual + 1
                    Pages = Pages + 1
                    'MsgBox(Pages)
                    printpages = Pages

                    e.HasMorePages = True
                    LinhaAtual = LinhaAtual + 1
                    GoTo PULA
                Else
                    e.HasMorePages = False
                End If

                linha = linha + 1
                LinhaAtual = LinhaAtual + 1

            End If

SEGUE:
        Next
        'End While


PULA:

    End Sub

    Private Sub TxtFiltro_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltro.TextChanged
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PreencherLista(TxtFiltro.Text)
    End Sub

    Private Sub ListView1_ItemMouseHover(sender As Object, e As ListViewItemMouseHoverEventArgs) Handles ListView1.ItemMouseHover


        'If ChkMostrar.Checked = True And e.Item.Index >= 0 Then
        '    If ToolCustom.Timer1.Enabled = True Then
        '        ToolCustom.Timer1.Dispose()
        '        ToolCustom.Dispose()
        '    End If

        '    ToolCustom.Time = 5000
        '    ToolCustom.Codigo = e.Item.SubItems(0).Text
        '    ToolCustom.Descricao = e.Item.SubItems(1).Text
        '    ToolCustom.Categoria = e.Item.SubItems(2).Text
        '    ToolCustom.Linha = e.Item.SubItems(3).Text
        '    ToolCustom.Preco = e.Item.SubItems(4).Text
        '    ToolCustom.Imagem = e.Item.SubItems(5).Text
        '    ToolCustom.Location = System.Windows.Forms.Cursor.Position
        '    ToolCustom.Show()
        'End If


    End Sub

    Private Sub ChkMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMostrar.CheckedChanged
        If ChkMostrar.Checked = True Then
            PicPreview.Width = (Me.Width / 100) * 30
            ListView1.Width = (Me.Width / 100) * 70
            ListView1.Left = PicPreview.Width
        Else
            PicPreview.Width = (Me.Width / 100) * 0.1
            ListView1.Width = (Me.Width / 100) * 99.9
            ListView1.Left = PicPreview.Width
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

        Try
            preview = Nothing
            PicPreview.Image = Nothing

            'preview = New Bitmap()

            If ChkMostrar.Checked = True Then

                If File.Exists(ListView1.Items.Item(ListView1.FocusedItem.Index).SubItems(5).Text) Then
                    preview = Bitmap.FromFile(ListView1.Items.Item(ListView1.FocusedItem.Index).SubItems(5).Text)
                Else
                    preview = Bitmap.FromFile(xres & "especial.png")
                End If

                PicPreview.Image = preview
            End If

            PicPreview.Refresh()
            PicPreview.Update()

        Catch ex As Exception
            IsNothing(ex)
            'MsgBox(ex.Message & vbNewLine & ex.ToString)
        End Try

    End Sub

    Private Sub CatalogoProdutos_MaximizedBoundsChanged(sender As Object, e As EventArgs) Handles Me.MaximizedBoundsChanged
        If ChkMostrar.Checked = True Then
            PicPreview.Width = (Me.Width / 100) * 30
            ListView1.Width = (Me.Width / 100) * 70
            ListView1.Left = PicPreview.Width
        Else
            PicPreview.Width = (Me.Width / 100) * 0.1
            ListView1.Width = (Me.Width / 100) * 99.9
            ListView1.Left = PicPreview.Width
        End If
    End Sub

    Private Sub CatalogoProdutos_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If ChkMostrar.Checked = True Then
            PicPreview.Width = (Me.Width / 100) * 30
            ListView1.Width = (Me.Width / 100) * 70
            ListView1.Left = PicPreview.Width
        Else
            PicPreview.Width = (Me.Width / 100) * 0.1
            ListView1.Width = (Me.Width / 100) * 99.9
            ListView1.Left = PicPreview.Width
        End If
    End Sub

    Private Sub ListView1_KeyUp(sender As Object, e As KeyEventArgs) Handles ListView1.KeyUp
        If e.KeyValue = Keys.Enter Then
            Visualizar()
        End If
    End Sub

    Private Sub CatalogoProdutos_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub

End Class
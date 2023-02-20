'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows


Public Class ListaPedidos

    Private flagSelect As Boolean = False
    Private paginaatual As Integer = 1
    Private soma As Boolean = False
    Private LinhaAtual As Integer = 0

    Private Sub FrmHistorico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        PLoading.Left = (Me.Width / 2) - (PLoading.Width / 2)
        PLoading.Top = (Me.Height / 2) - (PLoading.Height / 2)

        'If IO.File.Exists(xres & "fundo-geral.jpg") Then
        '    Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
        '    Me.BackgroundImage = back1
        'End If

        If IO.File.Exists(xres & "relatorio.png") Then
            Dim back5 As New Bitmap(xres & "relatorio.png")
            Me.btnReport.Image = back5
        End If

        'If IO.File.Exists(xres & "exit.png") Then
        '    Dim back5 As New Bitmap(xres & "exit.png")
        '    Me.btnSair.Image = back5
        'End If

        If VerificaUser(Usuario) = "Padrao" Then
            DtvHistorico.Columns(5).Visible = False
            DtvHistorico.Columns(6).Visible = False
            DtvHistorico.Columns(7).Visible = False
            DtvHistorico.Columns(10).Visible = False
            btnReport.Enabled = False
            CbTipo.Items.Add("ULTIMO DIA")
            CbTipo.Items.Add("ULTIMOS 30 DIAS")
        Else
            'DtvHistorico.Columns(5).Visible = True
            'DtvHistorico.Columns(6).Visible = True
            'DtvHistorico.Columns(10).Visible = True
            CbTipo.Items.Add("ULTIMO DIA")
            CbTipo.Items.Add("ULTIMOS 30 DIAS")
            CbTipo.Items.Add("INTERVALO")
            CbTipo.Items.Add("TODOS")
        End If


        PreecherUsers()

        CbUsuarios.SelectedIndex = 0
        CbTipoPagto.SelectedIndex = 0
        CbTipo.SelectedIndex = 0

        Select Case CbTipo.SelectedIndex
            Case 0, 1, 3
                Label3.Visible = False
                Label4.Visible = False
                DateTimePicker1.Visible = False
                DateTimePicker2.Visible = False
            Case 2
                Label3.Visible = True
                Label4.Visible = True
                DateTimePicker1.Visible = True
                DateTimePicker2.Visible = True
        End Select

        PreencherLista("", CbUsuarios.SelectedItem)

        flagSelect = True

    End Sub


    Private Sub PreecherUsers()
        CbUsuarios.Items.Clear()
        CbUsuarios.Items.Add("TODOS")
        For Each dt In UsuariosDS.Tables(0).Rows
            CbUsuarios.Items.Add(dt.Item(0).ToString)
        Next
        CbUsuarios.SelectedIndex = 0
    End Sub

    Private Sub PreencherLista(filtroTxt As String, filtroUser As String)

        flagSelect = False
        PLoading.Visible = True
        DtvHistorico.Rows.Clear()
        System.Windows.Forms.Application.DoEvents()

        Try

            conexão.Close()
            conexão.Open()
            Dim dt As DataRow
            Dim cCol As Integer = 0

            For Each dt In PedidosDS.Tables(0).Rows
                cCol = 0

                Dim flagUser As Boolean = True
                Dim flagPgto As Boolean = True
                Dim flagTipo As Boolean = True
                Dim flagFiltro As Boolean = True

                If filtroUser <> "TODOS" And filtroUser <> "" Then
                    flagUser = False
                    If filtroUser = dt.Item(1).ToString Then
                        flagUser = True
                    End If
                End If

                If CbTipoPagto.SelectedIndex > 0 Then
                    flagPgto = False
                    If CbTipoPagto.SelectedIndex = dt.Item(9).ToString Then
                        flagPgto = True
                    End If
                End If

                If CbTipo.SelectedIndex <> 3 Then
                    flagTipo = False
                    Dim nw As Date = DateTime.Today
                    Dim hj As Date = DateTime.Now
                    Dim tmp As Date = CDate(dt.Item(2).ToString)
                    'Dim tmp As Date = CDate(dt.Item(2).ToString.Substring(0, dt.Item(2).ToString.IndexOf(" ")))

                    Select Case CbTipo.SelectedIndex
                        Case 0
                            'MsgBox("hj: " & nw & "  tmp: " & tmp)
                            If tmp >= nw And tmp <= nw.AddHours(23.99) Then
                                flagTipo = True
                            End If
                        Case 1
                            If tmp <= hj.AddHours(23.99) And tmp >= hj.AddDays(-30) Then
                                flagTipo = True
                            End If
                        Case 2
                            If tmp <= DateTimePicker2.Value And tmp >= DateTimePicker1.Value Then
                                flagTipo = True
                            End If
                    End Select
                End If

                If filtroTxt <> "" Then
                    flagFiltro = False
                    If LCase(Trim(dt(0))).Contains(LCase(filtroTxt)) Or
                            LCase(Trim(dt(1))).Contains(LCase(filtroTxt)) Or
                            LCase(Trim(dt(2))).Contains(LCase(filtroTxt)) Or
                            LCase(Trim(dt(3))).Contains(LCase(filtroTxt)) Then
                        flagFiltro = True
                    End If
                End If

                If flagUser = True And flagPgto = True And flagTipo = True And flagFiltro = True Then

                    Dim Id As String = dt.Item(0).ToString
                    Dim User As String = If(IsDBNull(dt.Item(1).ToString) = False, dt.Item(1).ToString, "")
                    Dim Data As String = If(IsDBNull(dt.Item(2).ToString) = False, dt.Item(2).ToString, "")
                    Dim Cliente As String = If(IsDBNull(dt.Item(3).ToString) = False, dt.Item(3).ToString, "")
                    Dim Valor As Double = If(IsDBNull(dt.Item(4).ToString) = False, CDbl(dt.Item(4).ToString()), 0.0)
                    Dim CustoMateriais As Double = If(IsDBNull(dt.Item(5).ToString) = False, CDbl(dt.Item(5).ToString()), 0.0)
                    Dim CustosAdcionais As Double = If(IsDBNull(dt.Item(6).ToString) = False, CDbl(dt.Item(6).ToString()), 0.0)
                    Dim Ganho As Double = If(IsDBNull(dt.Item(7).ToString) = False, CDbl(dt.Item(7).ToString()), 0.0)
                    Dim TipoPgto As Integer = If(IsDBNull(dt.Item(9).ToString) = False, dt.Item(9).ToString, 0)
                    'Dim Obs As String = If(IsDBNull(dt.Item(2).ToString) = False, dt.Item(2).ToString, "")

                    Dim TipoPgtoTxt As String = ""
                    Select Case TipoPgto
                        Case 1
                            TipoPgtoTxt = "Dinheiro"
                        Case 2
                            TipoPgtoTxt = "Cartão Débito"
                        Case 3
                            TipoPgtoTxt = "Cartão Crédito"
                        Case Else
                            TipoPgtoTxt = "Cancelado"
                    End Select

                    DtvHistorico.Rows.Add(Id, User, Data, Cliente, "R$ " & Valor, "R$ " & CustoMateriais, "R$ " & CustosAdcionais, "R$ " & Ganho, TipoPgtoTxt)

                End If

CONT1:
                'System.Windows.Forms.Application.DoEvents()

            Next

            conexão.Close()

            Timer1.Stop()

        Catch ex As Exception
            MsgBox("Preencher lista:  " & ex.Message)
        End Try

        DtvHistorico.Visible = True
        flagSelect = True
        PLoading.Visible = False

    End Sub



    Private Sub btnSair_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub TxtFiltro_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltro.TextChanged
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub CbUser_ClickSelectedIndexChanged(sender As Object, e As EventArgs) Handles CbUsuarios.SelectedIndexChanged
        If flagSelect = True Then
            PreencherLista(TxtFiltro.Text, CbUsuarios.SelectedItem)
        End If
    End Sub

    Private Sub CbTipoPgto_ClickSelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTipoPagto.SelectedIndexChanged
        If flagSelect = True Then
            PreencherLista(TxtFiltro.Text, CbUsuarios.SelectedItem)
        End If
    End Sub

    Private Sub CbTipo_ClickSelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTipo.SelectedIndexChanged
        If flagSelect = True Then
            Select Case CbTipo.SelectedIndex
                Case 0, 1, 3
                    Label3.Visible = False
                    Label4.Visible = False
                    DateTimePicker1.Visible = False
                    DateTimePicker2.Visible = False
                Case 2
                    Label3.Visible = True
                    Label4.Visible = True
                    DateTimePicker1.Visible = True
                    DateTimePicker2.Visible = True
            End Select
            PreencherLista(TxtFiltro.Text, CbUsuarios.SelectedItem)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If flagSelect = True Then
            PreencherLista(TxtFiltro.Text, CbUsuarios.SelectedItem)
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker2.MinDate = DateTimePicker1.Value

        If flagSelect = True Then
            PreencherLista(TxtFiltro.Text, CbUsuarios.SelectedItem)
        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If flagSelect = True Then
            PreencherLista(TxtFiltro.Text, CbUsuarios.SelectedItem)
        End If
    End Sub


    Public Sub Inicializa()

        Dim i As Integer = 0
        If Not DtvHistorico.CurrentCell Is Nothing Then
            i = DtvHistorico.CurrentRow.Index
        Else
            MsgBox("selecione algum pedido!", MsgBoxStyle.Exclamation)
        End If
        'Dim frm As New FrmPrevPedido

        'frm.LbPedido.Text = DtvHistorico.Item(0, i).Value
        'frm.ped = DtvHistorico.Item(0, i).Value
        'frm.LbVendedor.Text = DtvHistorico.Item(1, i).Value
        'frm.LbData.Text = DtvHistorico.Item(2, i).Value
        'frm.LbCodCliente.Text = DtvHistorico.Item(3, i).Value
        'frm.LbNomeCliente.Text = DtvHistorico.Item(4, i).Value
        'frm.LbFrete.Text = DtvHistorico.Item(5, i).Value
        'frm.LbPercent.Text = DtvHistorico.Item(6, i).Value
        'frm.LbDesconto.Text = DtvHistorico.Item(7, i).Value
        'frm.LbValor.Text = DtvHistorico.Item(8, i).Value
        'frm.VerificaStatus(DtvHistorico.Item(9, i).Value)
        'frm.TxtObs.Text = DtvHistorico.Item(10, i).Value
        'frm.arquivoped = DtvHistorico.Item(11, i).Value

        'If frm.RdProducao.Checked = True Or frm.RdEntrega.Checked = True Or frm.RdFechado.Checked = True Or frm.RdCancelado.Checked = True Then
        '    frm.btnEditar.Enabled = False
        'End If

        'frm.ShowDialog()
        'Me.Hide()
        'Dim NovoFrm As New FrmHistorico
        'NovoFrm.ShowDialog()

    End Sub

    Private Sub DtvHistorico_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtvHistorico.CellContentClick

        If e.ColumnIndex = 9 Then

            Try

                Dim frm As New FrmOrcamento()
                frm.modo = 1
                Globals.ListaProdutos = New List(Of Produto)

                conexão.Close()
                conexão.Open()
                Dim sqlCom As String = "SELECT * FROM pedidos WHERE [id]=" & DtvHistorico.Item(0, e.RowIndex).Value & " "
                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim MyAdapter As New OleDbDataAdapter(MyCommand)
                Dim ds As New DataSet
                MyAdapter.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then

                    frm.TxtPedido.Text = ds.Tables(0).Rows(0).Item(0)
                    frm.LbVendedor.Text = ds.Tables(0).Rows(0).Item(1)
                    frm.LbData.Text = ds.Tables(0).Rows(0).Item(2)
                    frm.LbCodClient.Text = ds.Tables(0).Rows(0).Item(3)

                    Select Case ds.Tables(0).Rows(0).Item(9)
                        Case 1
                            frm.fPagto = "Dinheiro"
                        Case 2
                            frm.fPagto = "Cartão de Débito"
                        Case 3
                            frm.fPagto = "Cartão de Crédito"
                    End Select

                    If ds.Tables(0).Rows(0).Item(3) <> -1 Then
                        Dim sqlCom1 As String = "SELECT * FROM clientes WHERE [Codigo]=" & ds.Tables(0).Rows(0).Item(3) & " "
                        Dim MyCommand1 As New OleDbCommand(sqlCom1, conexão)
                        Dim MyAdapter1 As New OleDbDataAdapter(MyCommand1)
                        Dim ds1 As New DataSet
                        MyAdapter1.Fill(ds1)
                        If ds1.Tables(0).Rows.Count > 0 Then
                            frm.LbNomeCliente.Text = ds1.Tables(0).Rows(0).Item(2)
                            frm.lbCPF.Text = ds1.Tables(0).Rows(0).Item(3)
                        End If
                    End If

                    If Not IsDBNull(ds.Tables(0).Rows(0).Item(11)) Then
                        Dim ComponentesText As String = ds.Tables(0).Rows(0).Item(11)
                        Dim Itens() = ComponentesText.Split("&&")
                        If Itens.Length > 0 Then
                            For i = 0 To Itens.Length - 1
                                Dim Part() = Itens(i).Split(";")
                                If Part.Length > 1 Then
                                    Dim ProdutoAtual = New Produto With {
                                        .Codigo = Part(0),
                                        .Descricao = Part(1),
                                        .Qt = Part(2),
                                        .Valor = Part(3)
                                    }
                                    Globals.ListaProdutos.Add(ProdutoAtual)
                                    frm.DtvOrca.Rows.Add(Nothing, ProdutoAtual.Codigo, ProdutoAtual.Descricao, ProdutoAtual.Qt, ProdutoAtual.Valor.ToString("0.00"), (ProdutoAtual.Qt * ProdutoAtual.Valor).ToString("0.00"))

                                End If
                            Next
                        End If
                    End If

                    frm.ShowDialog()

                End If
                'Dim Ra As Integer = MyCommand.ExecuteNonQuery()

                conexão.Close()
            Catch ex As Exception
                conexão.Close() '& vbCr & ex.StackTrace
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
            End Try

        End If

        If e.ColumnIndex = 10 Then

            Dim dr As DialogResult = MsgBox("Você está prestes a remover um pedido! " & vbCr & "Deseja continuar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Atenção")
            If dr = DialogResult.Yes Then
                Try
                    conexão.Close()
                    conexão.Open()
                    Dim sqlCom As String = "DELETE * FROM pedidos WHERE [id]=" & DtvHistorico.Item(0, e.RowIndex).Value & " "
                    Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                    Dim Ra As Integer = MyCommand.ExecuteNonQuery
                    conexão.Close()

                    PreencherLista(TxtFiltro.Text, CbUsuarios.SelectedItem)

                Catch ex As Exception
                    conexão.Close()
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
                End Try
            End If

        End If

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click


        LinhaAtual = 0
        paginaatual = 1
        soma = False

        If DtvHistorico.Rows.Count = 0 Then
            MsgBox("Não há dados para exibir!", MsgBoxStyle.Information, "Atenção")
            Exit Sub
        End If

        Dim frmprint As New FrmReport

        Dim pd As Printing.PrintDocument = New Printing.PrintDocument()
        AddHandler pd.PrintPage, AddressOf Me.pdRelatorio_PrintPage

        frmprint.PrintPreviewControl1.Document = pd
        pd.DocumentName = "Relatório dos Pedidos"
        frmprint.ShowDialog()

        LinhaAtual = 0
        paginaatual = 1
        soma = False
        'p = 0

        If frmprint.DialogResult = Windows.Forms.DialogResult.OK Then
            PrintDialog1.Document = pd
            If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

                pd.DocumentName = "Relatório dos Pedidos"
                pd.PrintController = PrintDialog1.Document.PrintController
                pd.Print()

            End If
        End If

        LinhaAtual = 0
        paginaatual = 1
        soma = False

    End Sub

    Public Sub pdRelatorio_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        Try

            Dim Local As String = municipio
            Dim RowsCounting As Integer = DtvHistorico.Rows.Count
            Dim ValorTotal As Single = 0
            Dim CustoMateriais As Single = 0
            Dim CustosAdicinais As Single = 0
            Dim Ganho As Single = 0

            Dim Li As String = Nothing
            Dim ContLinha() As String = Nothing

            'Variaveis das linhas
            Dim LinhasPorPagina As Single = 0
            Dim PosicaoDaLinha As Single = 0


            'Variaveis das margens
            Dim MargemEsquerda As Single = e.MarginBounds.Left - 80
            Dim MargemSuperior As Single = e.MarginBounds.Top + 100
            Dim MargemDireita As Single = e.MarginBounds.Right - 80
            Dim MargemInferior As Single = e.MarginBounds.Bottom

            Dim CanetaDaImpressora As Pen = New Pen(Color.Black, 1)

            'Variaveis das fontes
            Dim FonteNegrito As Font
            Dim FonteTitulo As Font
            Dim FonteSubTitulo As Font
            Dim FonteRodape As Font
            Dim FonteNormal As Font
            Dim FonteEnfase As Font

            'define efeitos em fontes
            FonteNegrito = New Font("Calibri", 10, FontStyle.Bold)
            FonteTitulo = New Font("Calibri", 14, FontStyle.Bold)
            FonteSubTitulo = New Font("Calibri", 11, FontStyle.Bold)
            FonteEnfase = New Font("Calibri", 11)
            FonteRodape = New Font("Calibri", 10)
            FonteNormal = New Font("Calibri", 10)

            'define valores para linha atual e para linha da impressao
            Dim L As Integer = 0
            Dim rect1 As Rectangle

            'nome da empresa
            Dim pt As Point
            Dim posy As Integer = 10
            Dim posx As Integer = 20


            'Imagem
            If File.Exists(logo) Then
                pt = New Point(posx, posy)
                Dim img As Bitmap = Bitmap.FromFile(logo)

                rect1 = New Rectangle(posx, posy, img.Width * ScaleSetLogo(img.Width, img.Height), img.Height * ScaleSetLogo(img.Width, img.Height))
                e.Graphics.DrawImage(img, rect1)

            End If

            Dim stringFormat1 As New StringFormat()
            stringFormat1.Alignment = StringAlignment.Far

            rect1 = New Rectangle(posx + 300, 60, 480, 34)
            e.Graphics.DrawString(Local & ", " & DateTime.Now.Day.ToString & " de " & MonthName(DateTime.Now.Month) & " de  " & DateTime.Now.Year.ToString, FonteNormal, Brushes.Black, rect1, stringFormat1)


            stringFormat1.Alignment = StringAlignment.Center
            stringFormat1.LineAlignment = StringAlignment.Center

            rect1 = New Rectangle(posx + (e.PageBounds.Width / 2) - 150, posy, 300, 30)
            e.Graphics.DrawString("Relatório dos Pedidos", FonteTitulo, Brushes.Black, rect1, stringFormat1)

            posy += 10
            'MsgBox("Posição da linha: " & posy)
            If paginaatual = 1 Then

                posy += 80

                Select Case CbTipo.SelectedIndex
                    Case 0
                        e.Graphics.DrawString("Período: ", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
                        e.Graphics.DrawString("Ultimo dia", FonteNormal, Brushes.Black, posx + 80, posy, New StringFormat())
                    Case 1
                        e.Graphics.DrawString("Período: ", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
                        e.Graphics.DrawString("Ultimos 30 dias", FonteNormal, Brushes.Black, posx + 80, posy, New StringFormat())
                    Case 2
                        e.Graphics.DrawString("De: ", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
                        e.Graphics.DrawString(DateTimePicker1.Text, FonteNormal, Brushes.Black, posx + 80, posy, New StringFormat())
                        e.Graphics.DrawString("Até: ", FonteNegrito, Brushes.Black, posx + 200, posy, New StringFormat())
                        e.Graphics.DrawString(DateTimePicker2.Text, FonteNormal, Brushes.Black, posx + 280, posy, New StringFormat())
                    Case 3
                        e.Graphics.DrawString("Período: ", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
                        e.Graphics.DrawString("Todos os Pedidos", FonteNormal, Brushes.Black, posx + 100, posy, New StringFormat())
                End Select
                posy += 18

                If CbUsuarios.SelectedIndex <> 0 Then
                    e.Graphics.DrawString("Usuário: ", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
                    e.Graphics.DrawString(CbUsuarios.SelectedItem, FonteNormal, Brushes.Black, posx + 80, posy, New StringFormat())
                Else
                    e.Graphics.DrawString("Usuário: ", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
                    e.Graphics.DrawString("Todos os usuários", FonteNormal, Brushes.Black, posx + 80, posy, New StringFormat())
                End If

                posy += 18
            End If

CONTINUA:

            '//Rodapé
            Dim stringFormat As StringFormat = New StringFormat()
            stringFormat.Alignment = StringAlignment.Center

            MargemInferior += 30

            Dim rectxt As System.Drawing.Rectangle
            Dim sz As System.Drawing.Size = New System.Drawing.Size(600, 17)

            e.Graphics.DrawLine(CanetaDaImpressora, posx, MargemInferior, posx + 780, MargemInferior)

            rectxt = New System.Drawing.Rectangle(New System.Drawing.Point((e.PageBounds.Width / 2) - (sz.Width / 2), MargemInferior), sz)
            e.Graphics.DrawString(razao, FonteRodape, Brushes.Black, rectxt, stringFormat)
            MargemInferior += 18

            rectxt = New System.Drawing.Rectangle(New System.Drawing.Point((e.PageBounds.Width / 2) - (sz.Width / 2), MargemInferior), sz)
            e.Graphics.DrawString(endereco & ", " & numero & " - " & municipio & " - " & uf, FonteRodape, Brushes.Black, rectxt, stringFormat)
            MargemInferior += 18

            rectxt = New System.Drawing.Rectangle(New System.Drawing.Point((e.PageBounds.Width / 2) - (sz.Width / 2), MargemInferior), sz)
            e.Graphics.DrawString(tel1 & " - " & email, FonteRodape, Brushes.Black, rectxt, stringFormat)

            'LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            'LinhaAtual += 1
            e.Graphics.DrawString("Pagina : " & paginaatual, FonteRodape, Brushes.Black, posx + 700, MargemInferior, New StringFormat())

            stringFormat.Alignment = StringAlignment.Near
            stringFormat.LineAlignment = StringAlignment.Center

            Dim imgs As Image = Nothing

            Dim linha As Integer = 1
            Dim flagInicio As Boolean = False
            'Aqui sao lidos os dados

            While (LinhaAtual < DtvHistorico.Rows.Count)
                'MsgBox("Posição da linha 'posy': " & posy & " Variável 'PosiçãoDaLinha': " & PosicaoDaLinha)
                'inicia a impressao
                ValorTotal += CSng(DtvHistorico.Item(4, LinhaAtual).Value.ToString.Replace("R$ ", ""))
                CustoMateriais += CSng(DtvHistorico.Item(5, LinhaAtual).Value.ToString.Replace("R$ ", ""))
                CustosAdicinais += CSng(DtvHistorico.Item(6, LinhaAtual).Value.ToString.Replace("R$ ", ""))
                Ganho += CSng(DtvHistorico.Item(7, LinhaAtual).Value.ToString.Replace("R$ ", ""))

                If flagInicio = False Then
                    flagInicio = True
                    If LinhaAtual > 1 Then
                        PosicaoDaLinha += 105
                    Else
                        PosicaoDaLinha = posy + 35
                    End If
                    linha = 1
                    posy = PosicaoDaLinha
                    'Campos a serem impressos: Codigo, Descrição, Acabamento, Quantidade, Vl unitario e Vl Total
                    e.Graphics.DrawLine(CanetaDaImpressora, posx, posy, posx + 780, posy)

                    e.Graphics.DrawString("Pedido", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
                    e.Graphics.DrawString("Data", FonteNegrito, Brushes.Black, posx + 50, posy, New StringFormat())
                    e.Graphics.DrawString("Vl. Total", FonteNegrito, Brushes.Black, posx + 200, posy, New StringFormat())
                    e.Graphics.DrawString("C. Materiais", FonteNegrito, Brushes.Black, posx + 300, posy, New StringFormat())
                    e.Graphics.DrawString("C. Adicionais", FonteNegrito, Brushes.Black, posx + 400, posy, New StringFormat())
                    e.Graphics.DrawString("Ganho", FonteNegrito, Brushes.Black, posx + 500, posy, New StringFormat())
                    e.Graphics.DrawString("Forma Pagto", FonteNegrito, Brushes.Black, posx + 600, posy, New StringFormat())
                    posy += 20
                    e.Graphics.DrawLine(CanetaDaImpressora, posx, posy, posx + 780, posy)
                    PosicaoDaLinha = posy + 3

                    GoTo SEGUE

                Else
                    If linha > 1 Then
                        PosicaoDaLinha += 25
                    Else
                        posy += 25
                    End If
                End If


                Dim penTemp As New Pen(Brushes.Black, 1)
                penTemp.DashStyle = Drawing2D.DashStyle.Dot

                '//Pedido
                rect1 = New Rectangle(posx, PosicaoDaLinha, 50, 25)
                e.Graphics.DrawString(DtvHistorico.Item(0, LinhaAtual).Value, FonteNormal, Brushes.Black, rect1, stringFormat)

                '/Data
                rect1 = New Rectangle(posx + 50, PosicaoDaLinha, 150, 25)
                e.Graphics.DrawString(DtvHistorico.Item(2, LinhaAtual).Value, FonteNormal, Brushes.Black, rect1, stringFormat)
                e.Graphics.DrawLine(penTemp, New Point(rect1.X - 2, rect1.Y), New Point(rect1.X - 2, rect1.Y + rect1.Height))

                '//Vl. total
                rect1 = New Rectangle(posx + 200, PosicaoDaLinha, 98, 25)
                e.Graphics.DrawString(DtvHistorico.Item(4, LinhaAtual).Value, FonteNormal, Brushes.Black, rect1, stringFormat)
                e.Graphics.DrawLine(penTemp, New Point(rect1.X - 2, rect1.Y), New Point(rect1.X - 2, rect1.Y + rect1.Height))

                '//C. Materiais
                rect1 = New Rectangle(posx + 300, PosicaoDaLinha, 98, 25)
                e.Graphics.DrawString(DtvHistorico.Item(5, LinhaAtual).Value, FonteNormal, Brushes.Black, rect1, stringFormat)
                e.Graphics.DrawLine(penTemp, New Point(rect1.X - 2, rect1.Y), New Point(rect1.X - 2, rect1.Y + rect1.Height))

                '//C. Adicionais
                rect1 = New Rectangle(posx + 400, PosicaoDaLinha, 98, 25)
                e.Graphics.DrawString(DtvHistorico.Item(6, LinhaAtual).Value, FonteNormal, Brushes.Black, rect1, stringFormat)
                e.Graphics.DrawLine(penTemp, New Point(rect1.X - 2, rect1.Y), New Point(rect1.X - 2, rect1.Y + rect1.Height))

                '//Ganho
                rect1 = New Rectangle(posx + 500, PosicaoDaLinha, 98, 25)
                e.Graphics.DrawString(DtvHistorico.Item(7, LinhaAtual).Value, FonteNormal, Brushes.Black, rect1, stringFormat)
                e.Graphics.DrawLine(penTemp, New Point(rect1.X - 2, rect1.Y), New Point(rect1.X - 2, rect1.Y + rect1.Height))

                '//Pagto
                rect1 = New Rectangle(posx + 600, PosicaoDaLinha, 170, 25)
                e.Graphics.DrawString(DtvHistorico.Item(8, LinhaAtual).Value, FonteNormal, Brushes.Black, rect1, stringFormat)
                e.Graphics.DrawLine(penTemp, New Point(rect1.X - 2, rect1.Y), New Point(rect1.X - 2, rect1.Y + rect1.Height))

                linha += 1
                LinhaAtual += 1

                'MsgBox("Posição Linha: " & PosicaoDaLinha + 65 & " Linha atual: " & LinhaAtual & vbNewLine & "Page height: " & e.PageBounds.Height & vbNewLine & "MArgem inf: " & e.MarginBounds.Bottom)
                If PosicaoDaLinha + 120 > e.PageBounds.Height Then
                    'Incrementa o n£mero da pagina
                    paginaatual = paginaatual + 1
                    printpages = paginaatual
                    e.HasMorePages = True
                    GoTo PULA

                End If
SEGUE:

            End While

            If LinhaAtual = RowsCounting Then
                PosicaoDaLinha += 35
                'MsgBox(PosicaoDaLinha + 500 & " > " & e.PageBounds.Height - 100)
                If soma = False Then

                    e.Graphics.DrawLine(CanetaDaImpressora, posx, PosicaoDaLinha, posx + 780, PosicaoDaLinha)
                    e.Graphics.DrawString("Total dos Pedidos: ", FonteSubTitulo, Brushes.Black, posx, PosicaoDaLinha + 3, New StringFormat())
                    e.Graphics.DrawString("R$ " & ValorTotal, FonteEnfase, Brushes.Black, posx + 200, PosicaoDaLinha + 3, New StringFormat())
                    PosicaoDaLinha += 25

                    e.Graphics.DrawString("Custo Total dos Materiais: ", FonteSubTitulo, Brushes.Black, posx, PosicaoDaLinha + 3, New StringFormat())
                    e.Graphics.DrawString("R$ " & CustoMateriais, FonteEnfase, Brushes.Black, posx + 200, PosicaoDaLinha + 3, New StringFormat())
                    PosicaoDaLinha += 25

                    e.Graphics.DrawString("Custos Adicionais: ", FonteSubTitulo, Brushes.Black, posx, PosicaoDaLinha + 3, New StringFormat())
                    e.Graphics.DrawString("R$ " & CustosAdicinais, FonteEnfase, Brushes.Black, posx + 200, PosicaoDaLinha + 3, New StringFormat())
                    PosicaoDaLinha += 25

                    e.Graphics.DrawString("Ganho Total: ", FonteSubTitulo, Brushes.Black, posx, PosicaoDaLinha + 3, New StringFormat())
                    e.Graphics.DrawString("R$ " & Ganho, FonteEnfase, Brushes.Black, posx + 200, PosicaoDaLinha + 3, New StringFormat())
                    PosicaoDaLinha += 25
                    e.Graphics.DrawLine(CanetaDaImpressora, posx, PosicaoDaLinha, posx + 780, PosicaoDaLinha)

                    soma = True
                End If

                PosicaoDaLinha += 30

            End If

PULA:
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try

    End Sub

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
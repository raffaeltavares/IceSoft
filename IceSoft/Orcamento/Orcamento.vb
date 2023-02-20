'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.Data.OleDb
Imports System.Windows


Public Class FrmOrcamento

    Public modo As Integer = 0

    Private Valor As Double = 0.0
    Private CustoMateriais As Double = 0.0
    Private CustosAdicionais As Double = 0.0
    Private Ganho As Double = 0.0
    Public fPagto As String
    Private paginaatual As Integer = 1
    Private soma As Boolean = False
    Private LinhaAtual As Integer = 0


    Private Sub FrmOrcamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        'If IO.File.Exists(xres & "fundo-geral.jpg") Then
        '    Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
        '    Me.BackgroundImage = back1
        'End If

        If IO.File.Exists(xres & "delete.png") Then
            Dim back2 As New Bitmap(xres & "delete.png")
            Me.btnRemoverCliente.Image = back2
        End If


        If IO.File.Exists(xres & "print.png") Then
            Dim back2 As New Bitmap(xres & "print.png")
            Me.btnPrint.Image = back2
        End If

        If IO.File.Exists(xres & "add_file.png") Then
            Dim back3 As New Bitmap(xres & "add_file.png")
            Me.btnAdd.Image = back3
        End If

        If IO.File.Exists(xres & "checkmark3.png") Then
            Dim back6 As New Bitmap(xres & "checkmark3.png")
            Me.btnFinalizar.Image = back6
        End If

        If IO.File.Exists(xres & "client.png") Then
            Dim back7 As New Bitmap(xres & "client.png")
            Me.btnCliente.Image = back7
        End If

        If IO.File.Exists(xres & "redcross3.png") Then
            Dim back6 As New Bitmap(xres & "redcross3.png")
            Me.btnSair.Image = back6
        End If

        If modo = 1 Then

            btnFinalizar.Text = "Fechar"
            btnSair.Visible = False
            btnRemoverCliente.Visible = False

            btnAdd.Enabled = False
            btnCliente.Enabled = False

            DtvOrca.Columns(3).ReadOnly = True
            DtvOrca.Columns(8).Visible = False

            If LbCodClient.Text <> -1 Then
                Label4.Visible = True
                Label3.Visible = True
                LbNomeCliente.Visible = True
                lbCPF.Visible = True
            Else
                Label4.Visible = False
                Label3.Visible = False
                LbNomeCliente.Visible = False
                lbCPF.Visible = False
            End If

        Else

            btnFinalizar.Text = "Finalizar Pedido"
            btnSair.Visible = True

            LbVendedor.Text = Usuario
            LbData.Text = My.Computer.Clock.LocalTime
            TxtPedido.Text = GerarCodigo()
            LbCodClient.Text = -1

            Label4.Visible = False
            Label3.Visible = False
            LbNomeCliente.Visible = False
            lbCPF.Visible = False
            btnRemoverCliente.Visible = False

            Globals.ListaProdutos = New List(Of Produto)

        End If

        Recalcular()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Dim ms As DialogResult = MsgBox("Deseja cancelar e sair do formulário? As informaçõees serão perdidas.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Sair do pedido")
        If ms = Forms.DialogResult.Yes Then

            Try
                conexão.Close()
                conexão.Open()
                Dim sqlCom As String = "DELETE * FROM pedidos WHERE [id]=" & TxtPedido.Text & " "
                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim Ra As Integer = MyCommand.ExecuteNonQuery
                conexão.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
            End Try

            Me.Close()
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim frm As New CatalogoProdutos
        frm.modo = 1
        If frm.ShowDialog() = DialogResult.OK Then

            Dim lprod As Produto = Globals.ListaProdutos.Find(Function(c) c.Codigo = frm.ProdutoAtual.Codigo)
            If Not IsNothing(lprod) Then

                lprod.Qt += frm.ProdutoAtual.Qt
                For i = 0 To DtvOrca.Rows.Count - 1
                    If DtvOrca.Item(1, i).Value = lprod.Codigo Then
                        DtvOrca.Item(3, i).Value = lprod.Qt
                        DtvOrca.Item(5, i).Value = lprod.Qt * lprod.Valor
                    End If
                Next

            Else

                Globals.ListaProdutos.Add(frm.ProdutoAtual)
                DtvOrca.Rows.Add(frm.ProdutoAtual.Img, frm.ProdutoAtual.Codigo, frm.ProdutoAtual.Descricao, frm.ProdutoAtual.Qt, frm.ProdutoAtual.Valor.ToString("0.00"), (frm.ProdutoAtual.Qt * frm.ProdutoAtual.Valor).ToString("0.00"))

            End If

        End If
        Recalcular()

    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click

        Dim frm As New FrmBuscaCliente()
        frm.mode = 0
        If frm.ShowDialog() = DialogResult.OK Then

            Me.LbCodClient.Text = frm.ClienteAtual.Id
            Me.LbNomeCliente.Text = frm.ClienteAtual.Nome
            Me.lbCPF.Text = frm.ClienteAtual.CPF

            Label4.Visible = True
            Label3.Visible = True
            LbNomeCliente.Visible = True
            lbCPF.Visible = True

            btnRemoverCliente.Visible = True

        End If

    End Sub

    Public Function ThumbnailCallback() As Boolean
        Return False
    End Function


    Private Sub Recalcular()

        Valor = 0.0
        CustoMateriais = 0.0
        CustosAdicionais = 0.0
        Ganho = 0.0

        For x = 0 To Globals.ListaProdutos.Count - 1
            Dim Prod As Produto = Globals.ListaProdutos(x)
            For y = 0 To Prod.ListaComponentes.Count - 1
                Dim comp As Componentes = Prod.ListaComponentes(y)
                CustoMateriais += comp.TotalCusto
                Application.DoEvents()
            Next
            Valor += Prod.Valor * Prod.Qt
            Application.DoEvents()
        Next

        Valor = Math.Round(Valor, 2)
        CustoMateriais = Math.Round(CustoMateriais, 2)

        Dim vl_impostos As Single = CalcPercentual(Valor, imposto)
        Dim vl_comissao As Single = CalcPercentual(Valor, comissao)
        Dim vl_adicional As Single = CalcPercentual(Valor, adicional)
        CustosAdicionais = Math.Round(vl_impostos + vl_comissao + vl_adicional, 2)
        Ganho = Valor - CustosAdicionais - CustoMateriais

        LbValor.Text = "R$ " & Valor '.ToString("0.00")

    End Sub

    Private Sub btnRemoverCliente_Click(sender As Object, e As EventArgs) Handles btnRemoverCliente.Click

        Dim dr As DialogResult = MsgBox("Remover cliente do pedido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
        If dr = DialogResult.Yes Then

            Me.LbCodClient.Text = -1
            Me.LbNomeCliente.Text = "..."
            Me.lbCPF.Text = "..."

            Label4.Visible = False
            Label3.Visible = False
            LbNomeCliente.Visible = False
            lbCPF.Visible = False

            btnRemoverCliente.Visible = False

        End If

    End Sub

    Public Shared Function ResizeImage(ByVal InputImage As Image) As Image
        Return New Bitmap(InputImage, New Size(50, 50))
    End Function


    Private Sub btnGerar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If modo = 1 Then
            Me.Close()
        Else
            GravarPedido()
        End If
    End Sub

    Private Sub GravarPedido()

        Dim ComponentesText As String = ""
        If DtvOrca.Rows.Count > 0 Then

            For r = 0 To DtvOrca.Rows.Count - 1

                Dim StrComp As String = ""
                Dim CodigoComp As String = DtvOrca.Item(1, r).Value
                Dim Descri As String = DtvOrca.Item(2, r).Value
                Dim Quant As Double = DtvOrca.Item(3, r).Value
                Dim ValorComp As Double = DtvOrca.Item(4, r).Value
                Dim TotalComp As Double = DtvOrca.Item(5, r).Value

                If r = 0 Then
                    StrComp = CodigoComp & ";" & Descri & ";" & Quant & ";" & ValorComp & ";" & TotalComp
                Else
                    StrComp = "&&" & CodigoComp & ";" & Descri & ";" & Quant & ";" & ValorComp & ";" & TotalComp
                End If

                ComponentesText += StrComp

            Next

        Else
            MsgBox("Adicione algum produto a este pedido!", MsgBoxStyle.Exclamation, "Atenção")
            Exit Sub
        End If

finalizar:

        Dim frm As New FrmFinalizar
        frm.txtPedido.Text = "Pedido: " & Me.TxtPedido.Text
        frm.LbData.Text = Me.LbData.Text
        frm.LbValor.Text = "R$ " & Valor
        frm.CbTipo.SelectedIndex = 0
        fPagto = frm.CbTipo.SelectedItem

        frm.ShowDialog()
        If frm.DialogResult = Forms.DialogResult.OK Then

            If frm.CbTipo.SelectedIndex = 0 Then
                Dim vlReceb As Single = frm.TxtValorReceb.Text
                If vlReceb < Valor Then
                    MsgBox("O valor recebido é insuficiente!" & vbCr & "Não é possível prosseguir com a operação.", MsgBoxStyle.Exclamation, "Atenção")
                    GoTo finalizar
                End If
            End If

            Dim pgtoText() As String = frm.CbTipo.SelectedItem.ToString.Split("-")
            Dim pgto As Integer = If(pgtoText.Length > 1, pgtoText(0), 1)
            Dim flagOk As Boolean = False

            Try

                conexão.Close()
                conexão.Open()
                Dim sqlCom1 As String = "UPDATE pedidos SET " &
                    "[Cliente]=" & LbCodClient.Text & ", " &
                    "[Status]='fechado', " &
                    "[Valor]=" & Replace(Valor, ",", ".") & ", " &
                    "[custoMateriais]=" & Replace(CustoMateriais, ",", ".") & ", " &
                    "[custosAdicionais]=" & Replace(CustosAdicionais, ",", ".") & ", " &
                    "[ganho]=" & Replace(Ganho, ",", ".") & ", " &
                    "[pagto]=" & pgto & ", " &
                    "[content]='" & ComponentesText & "' WHERE [id]=" & TxtPedido.Text & ""
                Dim MyCommand1 As New OleDbCommand(sqlCom1, conexão)
                Dim Ra1 As Integer = MyCommand1.ExecuteNonQuery
                conexão.Close()

                flagOk = True

            Catch ex As Exception
                conexão.Close()

                flagOk = False
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")

            End Try

            If flagOk = True Then

                Try

                    conexão.Close()
                    conexão.Open()
                    For x = 0 To Globals.ListaProdutos.Count - 1
                        Dim Prod As Produto = Globals.ListaProdutos(x)
                        For y = 0 To Prod.ListaComponentes.Count - 1
                            Dim comp As Componentes = Prod.ListaComponentes(y)
                            Dim sqlCom1 As String = "UPDATE materiaprima SET " &
                                "[estoque]=[estoque]-" & comp.Qt * Prod.Qt & ", " &
                                "[valorEstoque]=[estoque]*[valorFinal] WHERE [Codigo]='" & comp.Codigo & "'"
                            Dim MyCommand1 As New OleDbCommand(sqlCom1, conexão)
                            Dim Ra1 As Integer = MyCommand1.ExecuteNonQuery
                            Application.DoEvents()
                        Next
                        Application.DoEvents()
                    Next
                    conexão.Close()
                    flagOk = True

                Catch ex As Exception
                    conexão.Close()

                    flagOk = False
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")

                End Try

            Else
                MsgBox("Operação Cancelada!", MsgBoxStyle.Exclamation, "Falha no processamento")
            End If


            If flagOk = True Then

                Dim frmOk As New FrmPedidoOk
                frmOk.txtPedido.Text = "Pedido: " & Me.TxtPedido.Text
                frmOk.LbValor.Text = LbValor.Text
                frmOk.lbTipoPagto.Text = frm.CbTipo.SelectedItem

                If frm.CbTipo.SelectedIndex = 0 Then

                    frmOk.Label4.Visible = True
                    frmOk.lbVlReceb.Visible = True
                    frmOk.lbVlReceb.Text = "R$ " & CDbl(frm.TxtValorReceb.Text).ToString("0.00")

                    frmOk.Label6.Visible = True
                    frmOk.LbTroco.Visible = True
                    frmOk.LbTroco.Text = "R$ " & CDbl(CDbl(frm.TxtValorReceb.Text) - CDbl(LbValor.Text)).ToString("0.00")

                Else

                    frmOk.Label4.Visible = True
                    frmOk.lbVlReceb.Visible = True
                    frmOk.lbVlReceb.Text = LbValor.Text

                    frmOk.Label6.Visible = False
                    frmOk.LbTroco.Visible = False

                End If

                frmOk.ShowDialog()
                StartReport()

                Me.Close()

            Else

                Try
                    conexão.Close()
                    conexão.Open()
                    Dim sqlCom As String = "DELETE * FROM pedidos WHERE [id]=" & TxtPedido.Text & " "
                    Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                    Dim Ra As Integer = MyCommand.ExecuteNonQuery
                    conexão.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
                End Try

                MsgBox("Operação Cancelada!", MsgBoxStyle.Exclamation, "Falha no processamento")
            End If

        End If

    End Sub

    Private Function CalcPercentual(ByVal valor As Double, ByVal taxa As Double) As Double
        CalcPercentual = CDbl(taxa) * (valor / 100)
        Return CalcPercentual
    End Function


    Private Function GerarCodigo() As Integer

        Dim i As Integer = numseq + 1

        Dim sqlStr As String = "SELECT MAX(id) FROM pedidos"
        Dim sqlCom As New OleDbCommand(sqlStr, conexão)
        Dim sqlAdap As New OleDbDataAdapter(sqlCom)
        Dim ds As New DataSet()
        sqlAdap.Fill(ds, "pedidos")

        If ds.Tables("pedidos").Rows.Count > 0 Then
            'MsgBox("Existe Pedidos na Tabela, Qt: " & ds.Tables("pedidos").Rows.Count)
            If Not IsDBNull(ds.Tables("pedidos").Rows(0).Item(0)) Then
                i = ds.Tables("pedidos").Rows(0).Item(0) + 1
            End If
            'Else
            'MsgBox("Não Existe Pedidos na Tabela, Qt: " & ds.Tables("pedidos").Rows.Count)
        End If

        Try
            conexão.Close()
            conexão.Open()
            sqlStr = "INSERT INTO pedidos ([id],[usuario],[data],[cliente],[valor],[custoMateriais],[custosAdicionais],[ganho],[status],[pagto],[obs],[content]) VALUES (" & i & ",'" & Usuario & "','" & LbData.Text & "',0,0,0,0,0,'aberto',0,'','')"
            Dim MyCommand As New OleDbCommand(sqlStr, conexão)
            Dim Ra As Integer = MyCommand.ExecuteNonQuery
            'If Ra <> 0 Then
            '    MsgBox(Ra & " registros foram afetados!" & vbCr & sqlStr, MsgBoxStyle.Information)
            'Else
            '    MsgBox("Nada foi inserido na tabela!" & vbCr & sqlStr, MsgBoxStyle.Information)
            'End If
            conexão.Close()
        Catch ex As Exception
            MsgBox("Não foi possível gerar o pedido!" & vbNewLine & ex.Message, MsgBoxStyle.Critical)
            Me.Dispose()
        End Try

        Return i
    End Function

    Private Function VerificaVendedor(ByVal User As String) As String

        Dim nome As String = Nothing
        Dim ole5 As String = "SELECT * FROM usuarios"
        Dim OleCom5 As New OleDbCommand(ole5, conexão)
        Dim oleAdapter5 As New OleDbDataAdapter(OleCom5)
        Dim ds5 As New DataSet()
        oleAdapter5.Fill(ds5, "usuarios")
        Dim dr5 As DataRow

        For Each dr5 In ds5.Tables(0).Rows
            If dr5.Item(0).ToString = User Then
                nome = dr5.Item(3).ToString
            End If
        Next

        Return nome
    End Function

    Private Sub DtvOrcamento_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DtvOrca.DataError
    End Sub


    Private Sub DtvOrca_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DtvOrca.CellEndEdit

        If e.ColumnIndex = 3 Then

            DtvOrca.Item(6, e.RowIndex).Value = CDbl(DtvOrca.Item(5, e.RowIndex).Value) * CDbl(DtvOrca.Item(4, e.RowIndex).Value)

        End If

        Recalcular()

    End Sub

    Delegate Sub SetColumnIndex(ByVal i As Integer)

    Private Sub Mymethod(ByVal columnIndex As Integer)
        Me.DtvOrca.CurrentCell = Me.DtvOrca.CurrentRow.Cells(columnIndex)
        Me.DtvOrca.BeginEdit(True)
    End Sub

    Private Sub FrmOrcamento_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing

        'Try
        '    conexão.Close()
        '    conexão.Open()
        '    Dim sqlCom As String = "DELETE * FROM pedidos WHERE id='" & TxtPedido.Text & "'"
        '    Dim MyCommand As New OleDbCommand(sqlCom, conexão)
        '    Dim Ra As Integer = MyCommand.ExecuteNonQuery
        '    conexão.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
        'End Try

    End Sub

    Private Sub DtvOrca_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtvOrca.CellContentClick
        If e.ColumnIndex = 8 Then
            Dim dr = MsgBox("Remover esse item do orçmento?", MsgBoxStyle.YesNo, "Mensagem")
            If dr = MsgBoxResult.Yes Then
                Dim inx = Globals.ListaProdutos.FindIndex(Function(c) c.Codigo = DtvOrca.Item(1, e.RowIndex).Value)
                If inx > -1 Then
                    DtvOrca.Rows.RemoveAt(e.RowIndex)
                    Globals.ListaProdutos.RemoveAt(inx)
                End If
                Recalcular()
            End If
        End If
    End Sub

    Private Sub DtvOrca_KeyDown(sender As Object, e As KeyEventArgs) Handles DtvOrca.KeyDown
        If Not IsNothing(DtvOrca.CurrentRow) Then
            Dim row = DtvOrca.CurrentRow.Index
            If e.KeyCode = Keys.Enter Then
                e.Handled = False
                Dim dr = MsgBox("Remover o item '" & DtvOrca.Item(1, row).Value & "' do orçmento?", MsgBoxStyle.YesNo, "Mensagem")
                If dr = MsgBoxResult.Yes Then
                    Dim inx = Globals.ListaProdutos.FindIndex(Function(c) c.Codigo = DtvOrca.Item(1, row).Value)
                    If inx > -1 Then
                        DtvOrca.Rows.RemoveAt(row)
                        Globals.ListaProdutos.RemoveAt(inx)
                    End If
                    Recalcular()
                End If
            End If
        End If
    End Sub


    Public Sub StartReport()

        LinhaAtual = 0
        paginaatual = 1
        soma = False

        'If DtvHistorico.Rows.Count = 0 Then
        '    MsgBox("Não há dados para exibir!", MsgBoxStyle.Information, "Atenção")
        '    Exit Sub
        'End If

        Dim frmprint As New FrmReport

        Dim pd As Printing.PrintDocument = New Printing.PrintDocument()
        pd.DefaultPageSettings.PaperSize = New Printing.PaperSize("Comanda", 420, 480)
        AddHandler pd.PrintPage, AddressOf Me.pdRelatorio_PrintPage

        frmprint.PrintPreviewControl1.Document = pd
        pd.DocumentName = "Ticket do Pedido"
        frmprint.ShowDialog()

        LinhaAtual = 0
        paginaatual = 1
        soma = False
        'p = 0

        If frmprint.DialogResult = Windows.Forms.DialogResult.OK Then
            PrintDialog1.Document = pd
            If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

                pd.DocumentName = "Ticket do Pedido"
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
            Dim RowsCounting As Integer = DtvOrca.Rows.Count
            'Dim ValorTotal As Single = 0
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
            Dim MargemInferior As Single = MargemSuperior 'e.MarginBounds.Bottom

            Dim CanetaDaImpressora As Pen = New Pen(Color.Black, 1)
            CanetaDaImpressora.DashStyle = Drawing2D.DashStyle.Dot

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
            'If File.Exists(logo) Then
            '    pt = New Point(posx, posy)
            '    Dim img As Bitmap = Bitmap.FromFile(logo)

            '    rect1 = New Rectangle(posx, posy, img.Width * ScaleSetLogo(img.Width, img.Height), img.Height * ScaleSetLogo(img.Width, img.Height))
            '    e.Graphics.DrawImage(img, rect1)

            'End If

            Dim stringFormat1 As New StringFormat()
            stringFormat1.Alignment = StringAlignment.Center
            stringFormat1.LineAlignment = StringAlignment.Center

            rect1 = New Rectangle((e.PageBounds.Width / 2) - 200, posy, 400, 30)
            e.Graphics.DrawString("Ticket do Pedido", FonteTitulo, Brushes.Black, rect1, stringFormat1)
            posy += 35

            rect1 = New Rectangle((e.PageBounds.Width / 2) - 200, posy, 400, 30)
            e.Graphics.DrawString("Pedido: " & TxtPedido.Text, FonteTitulo, Brushes.Black, rect1, stringFormat1)
            posy += 23


            'MsgBox("Posição da linha: " & posy)
            'If paginaatual = 1 Then

            '    posy += 80

            '    Select Case CbTipo.SelectedIndex
            '        Case 0
            '            e.Graphics.DrawString("Período: ", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
            '            e.Graphics.DrawString("Ultimo dia", FonteNormal, Brushes.Black, posx + 80, posy, New StringFormat())
            '        Case 1
            '            e.Graphics.DrawString("Período: ", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
            '            e.Graphics.DrawString("Ultimos 30 dias", FonteNormal, Brushes.Black, posx + 80, posy, New StringFormat())
            '        Case 2
            '            e.Graphics.DrawString("De: ", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
            '            e.Graphics.DrawString(DateTimePicker1.Text, FonteNormal, Brushes.Black, posx + 80, posy, New StringFormat())
            '            e.Graphics.DrawString("Até: ", FonteNegrito, Brushes.Black, posx + 200, posy, New StringFormat())
            '            e.Graphics.DrawString(DateTimePicker2.Text, FonteNormal, Brushes.Black, posx + 280, posy, New StringFormat())
            '        Case 3
            '            e.Graphics.DrawString("Período: ", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
            '            e.Graphics.DrawString("Todos os Pedidos", FonteNormal, Brushes.Black, posx + 100, posy, New StringFormat())
            '    End Select
            '    posy += 18

            '    If CbUsuarios.SelectedIndex <> 0 Then
            '        e.Graphics.DrawString("Usuário: ", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
            '        e.Graphics.DrawString(CbUsuarios.SelectedItem, FonteNormal, Brushes.Black, posx + 80, posy, New StringFormat())
            '    Else
            '        e.Graphics.DrawString("Usuário: ", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
            '        e.Graphics.DrawString("Todos os usuários", FonteNormal, Brushes.Black, posx + 80, posy, New StringFormat())
            '    End If

            '    posy += 18
            'End If

CONTINUA:

            '//Rodapé
            Dim stringFormat As StringFormat = New StringFormat()
            stringFormat.Alignment = StringAlignment.Center

            MargemInferior = posy

            Dim rectxt As System.Drawing.Rectangle
            Dim sz As System.Drawing.Size = New System.Drawing.Size(600, 17)

            e.Graphics.DrawLine(CanetaDaImpressora, posx, MargemInferior, posx + 380, MargemInferior)

            rectxt = New System.Drawing.Rectangle(New System.Drawing.Point((e.PageBounds.Width / 2) - (sz.Width / 2), MargemInferior), sz)
            e.Graphics.DrawString(razao, FonteRodape, Brushes.Black, rectxt, stringFormat)
            MargemInferior += 18

            rectxt = New System.Drawing.Rectangle(New System.Drawing.Point((e.PageBounds.Width / 2) - (sz.Width / 2), MargemInferior), sz)
            e.Graphics.DrawString("CNPJ: " & cnpj, FonteRodape, Brushes.Black, rectxt, stringFormat)
            MargemInferior += 18

            rectxt = New System.Drawing.Rectangle(New System.Drawing.Point((e.PageBounds.Width / 2) - (sz.Width / 2), MargemInferior), sz)
            e.Graphics.DrawString(endereco & ", " & numero & " - " & municipio & " - " & uf, FonteRodape, Brushes.Black, rectxt, stringFormat)
            MargemInferior += 18

            rectxt = New System.Drawing.Rectangle(New System.Drawing.Point((e.PageBounds.Width / 2) - (sz.Width / 2), MargemInferior), sz)
            e.Graphics.DrawString(tel1 & " - " & email, FonteRodape, Brushes.Black, rectxt, stringFormat)

            MargemInferior += 20
            e.Graphics.DrawLine(CanetaDaImpressora, posx, MargemInferior, posx + 380, MargemInferior)
            'LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            'LinhaAtual += 1
            'e.Graphics.DrawString("Pagina : " & paginaatual, FonteRodape, Brushes.Black, posx + 700, MargemInferior, New StringFormat())
            posy = MargemInferior

            rect1 = New Rectangle((e.PageBounds.Width / 2) - 200, posy, 400, 30)
            e.Graphics.DrawString(Local & ", " & DateTime.Now.Day.ToString & " de " & MonthName(DateTime.Now.Month) & " de  " & DateTime.Now.Year.ToString, FonteNormal, Brushes.Black, rect1, stringFormat1)

            stringFormat.Alignment = StringAlignment.Near
            stringFormat.LineAlignment = StringAlignment.Center

            Dim imgs As Image = Nothing

            Dim linha As Integer = 1
            Dim flagInicio As Boolean = False
            'Aqui sao lidos os dados

            While (LinhaAtual < DtvOrca.Rows.Count)
                'MsgBox("Posição da linha 'posy': " & posy & " Variável 'PosiçãoDaLinha': " & PosicaoDaLinha)
                'inicia a impressao
                'ValorTotal += CSng(DtvOrca.Item(5, LinhaAtual).Value.ToString.Replace("R$ ", ""))

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
                    e.Graphics.DrawLine(CanetaDaImpressora, posx, posy, posx + 380, posy)

                    e.Graphics.DrawString("Codigo", FonteNegrito, Brushes.Black, posx, posy, New StringFormat())
                    e.Graphics.DrawString("Descrição", FonteNegrito, Brushes.Black, posx + 50, posy, New StringFormat())
                    e.Graphics.DrawString("Qt.", FonteNegrito, Brushes.Black, posx + 200, posy, New StringFormat())
                    e.Graphics.DrawString("Vl. Unit", FonteNegrito, Brushes.Black, posx + 260, posy, New StringFormat())
                    e.Graphics.DrawString("Vl. Total", FonteNegrito, Brushes.Black, posx + 320, posy, New StringFormat())
                    posy += 20
                    e.Graphics.DrawLine(CanetaDaImpressora, posx, posy, posx + 380, posy)
                    PosicaoDaLinha = posy + 3

                    GoTo SEGUE

                Else
                    If linha > 1 Then
                        PosicaoDaLinha += 30
                    Else
                        posy += 30
                    End If
                End If


                Dim penTemp As New Pen(Brushes.Black, 1)
                penTemp.DashStyle = Drawing2D.DashStyle.Dot

                '//Codigo
                rect1 = New Rectangle(posx, PosicaoDaLinha, 50, 25)
                e.Graphics.DrawString(DtvOrca.Item(1, LinhaAtual).Value, FonteNormal, Brushes.Black, rect1, stringFormat)

                '/Descrição
                rect1 = New Rectangle(posx + 50, PosicaoDaLinha, 150, 30)
                e.Graphics.DrawString(DtvOrca.Item(2, LinhaAtual).Value, FonteNormal, Brushes.Black, rect1, stringFormat)
                e.Graphics.DrawLine(penTemp, New Point(rect1.X - 2, rect1.Y), New Point(rect1.X - 2, rect1.Y + rect1.Height))

                '//Qt.
                rect1 = New Rectangle(posx + 200, PosicaoDaLinha, 58, 25)
                e.Graphics.DrawString(DtvOrca.Item(3, LinhaAtual).Value, FonteNormal, Brushes.Black, rect1, stringFormat)
                e.Graphics.DrawLine(penTemp, New Point(rect1.X - 2, rect1.Y), New Point(rect1.X - 2, rect1.Y + rect1.Height))

                '//Vl. unitário
                rect1 = New Rectangle(posx + 260, PosicaoDaLinha, 58, 25)
                e.Graphics.DrawString(DtvOrca.Item(4, LinhaAtual).Value, FonteNormal, Brushes.Black, rect1, stringFormat)
                e.Graphics.DrawLine(penTemp, New Point(rect1.X - 2, rect1.Y), New Point(rect1.X - 2, rect1.Y + rect1.Height))

                '//Vl. total
                rect1 = New Rectangle(posx + 310, PosicaoDaLinha, 68, 25)
                e.Graphics.DrawString(DtvOrca.Item(5, LinhaAtual).Value, FonteNormal, Brushes.Black, rect1, stringFormat)
                e.Graphics.DrawLine(penTemp, New Point(rect1.X - 2, rect1.Y), New Point(rect1.X - 2, rect1.Y + rect1.Height))


                linha += 1
                LinhaAtual += 1

                'MsgBox("Posição Linha: " & PosicaoDaLinha + 65 & " Linha atual: " & LinhaAtual & vbNewLine & "Page height: " & e.PageBounds.Height & vbNewLine & "MArgem inf: " & e.MarginBounds.Bottom)
                If PosicaoDaLinha + 120 > e.PageBounds.Height Then

                    e.PageSettings.PaperSize.Height += 120
                    'Incrementa o n£mero da pagina
                    'paginaatual = paginaatual + 1
                    'printpages = paginaatual
                    'e.HasMorePages = True
                    'GoTo PULA

                End If
SEGUE:

            End While

            If LinhaAtual = RowsCounting Then
                PosicaoDaLinha += 35
                'MsgBox(PosicaoDaLinha + 500 & " > " & e.PageBounds.Height - 100)
                If soma = False Then

                    e.Graphics.DrawLine(CanetaDaImpressora, posx, PosicaoDaLinha, posx + 380, PosicaoDaLinha)
                    e.Graphics.DrawString("Total do pedido: ", FonteSubTitulo, Brushes.Black, posx, PosicaoDaLinha + 3, New StringFormat())
                    e.Graphics.DrawString("R$ " & Valor, FonteEnfase, Brushes.Black, posx + 200, PosicaoDaLinha + 3, New StringFormat())
                    PosicaoDaLinha += 25

                    e.Graphics.DrawString("Forma de Pagamento: ", FonteSubTitulo, Brushes.Black, posx, PosicaoDaLinha + 3, New StringFormat())
                    e.Graphics.DrawString(fPagto, FonteEnfase, Brushes.Black, posx + 200, PosicaoDaLinha + 3, New StringFormat())
                    PosicaoDaLinha += 25

                    'e.Graphics.DrawString("Custos Adicionais: ", FonteSubTitulo, Brushes.Black, posx, PosicaoDaLinha + 3, New StringFormat())
                    'e.Graphics.DrawString("R$ " & CustosAdicinais, FonteEnfase, Brushes.Black, posx + 200, PosicaoDaLinha + 3, New StringFormat())
                    'PosicaoDaLinha += 25

                    'e.Graphics.DrawString("Ganho Total: ", FonteSubTitulo, Brushes.Black, posx, PosicaoDaLinha + 3, New StringFormat())
                    'e.Graphics.DrawString("R$ " & Ganho, FonteEnfase, Brushes.Black, posx + 200, PosicaoDaLinha + 3, New StringFormat())
                    'PosicaoDaLinha += 25
                    e.Graphics.DrawLine(CanetaDaImpressora, posx, PosicaoDaLinha, posx + 380, PosicaoDaLinha)

                    soma = True
                End If

                PosicaoDaLinha += 30

            End If

PULA:
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        StartReport()
    End Sub

End Class
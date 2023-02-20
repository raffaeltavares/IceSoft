'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows

Public Class ListaProdutos

    Dim TipoArq As Integer
    Dim Modo As Integer
    Dim Prev As Image

    Dim Prss As Integer = 0
    Dim Percent As Integer = 0
    Dim ProgBar As Integer = 0
    Private flagSelect As Boolean = False


    Private Sub FrmListaProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        PLoading.Left = (Me.Width / 2) - (PLoading.Width / 2)
        PLoading.Top = (Me.Height / 2) - (PLoading.Height / 2)

        'If IO.File.Exists(xres & "fundo-geral.jpg") Then
        '    Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
        '    Me.BackgroundImage = back1
        'End If

        If IO.File.Exists(xres & "add_file.png") Then
            Dim back2 As New Bitmap(xres & "add_file.png")
            Me.btnAdd.Image = back2
        End If

        If IO.File.Exists(xres & "edit.png") Then
            Dim back3 As New Bitmap(xres & "edit.png")
            Me.btnEditar.Image = back3
        End If

        If IO.File.Exists(xres & "delete.png") Then
            Dim back4 As New Bitmap(xres & "delete.png")
            Me.btnDel.Image = back4
        End If

        If IO.File.Exists(xres & "exit.png") Then
            Dim back5 As New Bitmap(xres & "exit.png")
            Me.btnSair.Image = back5
        End If

        If IO.File.Exists(xres & "copy.png") Then
            Dim back6 As New Bitmap(xres & "copy.png")
            Me.btnDuplicar.Image = back6
        End If

        If IO.File.Exists(xres & "import.png") Then
            Dim back7 As New Bitmap(xres & "import.png")
            Me.btnImport.Image = back7
        End If

        'If IO.File.Exists(xres & "search.png") Then
        '    Dim back2 As New Bitmap(xres & "search.png")
        '    Me.btnPesquisar.Image = back2
        'End If

        If IO.File.Exists(xres & "Refresh_icon.png") Then
            Dim back2 As New Bitmap(xres & "Refresh_icon.png")
            Me.btnAtualizar.Image = back2
        End If

        Timer1.Interval = 500

        PreencherCombos("categoria_produtos", CbCategoria)
        PreencherLista("", "")

        flagSelect = True

    End Sub

    Private Sub PreencherLista(filtroTxt As String, filtroTipo As String)

        flagSelect = False
        DtvProdutos.Rows.Clear()
        System.Windows.Forms.Application.DoEvents()

        Dim contTipo() As String = filtroTipo.Split("-")
        Dim iTipo As String = If(contTipo.Count > 1, Trim(contTipo(0)), "SEM FILTRO")

        Try

            conexão.Close()
            conexão.Open()
            Dim dt As DataRow
            Dim cCol As Integer = 0

            For Each dt In ProdutosDS.Tables(0).Rows
                cCol = 0

                Dim flagTipo As Boolean = True
                Dim flagFiltro As Boolean = True

                If iTipo <> "SEM FILTRO" And iTipo <> "" Then
                    flagTipo = False
                    If iTipo = dt.Item(2).ToString Then
                        flagTipo = True
                    End If
                End If

                If filtroTxt <> "" Then
                    flagFiltro = False
                    If LCase(Trim(dt(0))).Contains(LCase(filtroTxt)) Or
                            LCase(Trim(dt(1))).Contains(LCase(filtroTxt)) Then
                        flagFiltro = True
                    End If
                End If

                If flagTipo = True And flagFiltro = True Then

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
                        img = My.Resources.especial
                    End If

                    DtvProdutos.Rows.Add(img, Codigo, Descricao, Categoria, "R$ " & Custo, "R$ " & Bruto, "R$ " & Liquido, "R$ " & Tributos, LucroPercent & " %", "R$ " & LucroReal)
                End If

CONT1:
                'System.Windows.Forms.Application.DoEvents()

            Next

            conexão.Close()

            Timer1.Stop()

        Catch ex As Exception
            MsgBox("Preencher lista:  " & ex.Message)
        End Try

        DtvProdutos.Visible = True
        flagSelect = True

    End Sub


    Private Sub PreencherCombos(ByVal nometabela As String, ByVal cb As ToolStripComboBox)

        cb.Items.Clear()
        cb.Items.Add("SEM FILTRO")
        For Each dt In CategoriasProdutosDS.Tables(0).Rows
            cb.Items.Add(dt.Item(0).ToString & "-" & dt.Item(1).ToString)
        Next
        cb.SelectedItem = "SEM FILTRO"

    End Sub

    Private Sub PreencherCombos(ByVal nometabela As String, ByVal cb As ComboBox)

        cb.Items.Clear()
        Dim ole1 As String = "SELECT * FROM " & nometabela & ""
        Dim OleCom1 As New OleDbCommand(ole1, conexão)
        Dim oleAdapter1 As New OleDbDataAdapter(OleCom1)
        Dim ds1 As New DataSet()
        oleAdapter1.Fill(ds1, nometabela)
        Dim dt As DataRow
        cb.Items.Add("SEM FILTRO")
        For Each dt In ds1.Tables(nometabela).Rows
            cb.Items.Add(dt.Item(0).ToString & "-" & dt.Item(1).ToString)
        Next
        cb.SelectedItem = "SEM FILTRO"


    End Sub


    Private Sub AddProduto()

        'MsgBox("Entrei na rotina")
        Dim FormularioProduto As New Produto
        FormularioProduto.vl = 0
        FormularioProduto.PreencherCategorias()
        FormularioProduto.PreencherListaCfop()
        FormularioProduto.ShowDialog()

        Try

            If FormularioProduto.DialogResult = Windows.Forms.DialogResult.OK Then
                'MsgBox("Vai criar as variaveis")

                Dim Codigo As String = FormularioProduto.txtCodigo.Text
                Dim Descricao As String = FormularioProduto.txtDescricao.Text
                Dim Categoria As String = FormularioProduto.CategoriaAtual
                'Dim Linha As String = FormularioProduto.CbLinha.Text
                'Dim Acabamento As String = FormularioProduto.CbAcabamento.Text

                Dim Custo As Double = CDbl(FormularioProduto.TxtCusto.Text)
                Dim Bruto As Double = CDbl(FormularioProduto.TxtBruto.Text)
                Dim Multiplicador As Double = CDbl(FormularioProduto.txtMultiplicador.Text)
                'Dim TotalBruto As Double = Decimal.Ceiling(CDbl(FormularioProduto.TxtTotalBruto.Text))
                'Dim Desconto As Double = Decimal.Ceiling(CDbl(FormularioProduto.TxtDesconto.Text))
                Dim Liquido As Double = CDbl(FormularioProduto.TxtLiquido.Text)

                Dim Imposto As Double = CDbl(FormularioProduto.TxtImposto.Text)
                Dim Comissao As Double = CDbl(FormularioProduto.txtComissao.Text)
                Dim Adicional As Double = CDbl(FormularioProduto.TxtAdicional.Text)
                ' DescDet As String = FormularioProduto.txtDescDetalhada.Text

                Dim Tributos As Double = CDbl(FormularioProduto.TxtTotalTributos.Text)
                Dim LucroReal As Double = CDbl(FormularioProduto.TxtLucroReal.Text)
                Dim LucroPercent As Double = CDbl(FormularioProduto.TxtLucroPercent.Text)

                Dim NCM As String = FormularioProduto.txtNCM.Text
                Dim CEST As String = FormularioProduto.txtCEST.Text
                Dim UnidCom As String = FormularioProduto.txtUnComercial.Text
                Dim EAN As String = FormularioProduto.txtEAN.Text
                Dim EANTrib As String = FormularioProduto.txtEANTrib.Text
                Dim ProdEsp As String = FormularioProduto.CbProdEspecifico.SelectedItem
                Dim CFOP1 As String = FormularioProduto.CbCFOP1.SelectedItem
                Dim CFOP2 As String = FormularioProduto.CbCFOP2.SelectedItem
                Dim CFOP3 As String = FormularioProduto.CbCFOP3.SelectedItem

                Dim ComponentesText As String = ""
                If FormularioProduto.DtvComponentes.Rows.Count > 0 Then
                    For r = 0 To FormularioProduto.DtvComponentes.Rows.Count - 1

                        Dim StrComp As String = ""
                        Dim CodigoComp As String = LTrim(RTrim(FormularioProduto.DtvComponentes.Item(0, r).Value))
                        Dim Descri As String = LTrim(RTrim(FormularioProduto.DtvComponentes.Item(1, r).Value))
                        Dim Quant As Double = CDbl(FormularioProduto.DtvComponentes.Item(2, r).Value)
                        Dim ValorComp As Double = CDbl(FormularioProduto.DtvComponentes.Item(3, r).Value)
                        Dim TotalComp As Double = CDbl(FormularioProduto.DtvComponentes.Item(4, r).Value)
                        Dim Total As Double = CDbl(FormularioProduto.DtvComponentes.Item(5, r).Value)
                        Dim Categ As String = FormularioProduto.DtvComponentes.Item(6, r).Value
                        If r = 0 Then
                            StrComp = CodigoComp & ";" & Descri & ";" & Quant & ";" & ValorComp & ";" & TotalComp & ";" & Total & ";" & Categ
                        Else
                            StrComp = "&&" & CodigoComp & ";" & Descri & ";" & Quant & ";" & ValorComp & ";" & TotalComp & ";" & Total & ";" & Categ
                        End If
                        ComponentesText += StrComp
                    Next
                End If


                Dim Prev As String = Nothing
                If IO.File.Exists(FormularioProduto.imgLoc) Then
                    Prev = FormularioProduto.imgLoc
                End If

                conexão.Close()
                conexão.Open()
                'Dim variavel As String
                'variavel = "VALUES ('" & Codigo & "','" & Descricao & "','" & Categoria & "','" & unidade & "','" & Fornecedor & "','" & Valor & "','" & Frete & "','" & IPI & "','" & Param1 & "','" & Param2 & "','" & Param3 & "','" & ValorFinal & "','" & Prev & "'"
                'MsgBox(variavel)
                'MsgBox("Vai inserir")

                Dim sqlCom As String = "INSERT INTO produtos ([Codigo],[Descricao],[Categoria],[Img],[Custo]," &
                    "[Bruto],[Multiplicador],[Liquido],[Imposto],[Comissao],[Adicional]," &
                    "[Componentes],[Tributos],[LucroReal],[LucroPercent],[NCM],[CEST],[UnidCom],[EAN],[EANTrib],[ProdEsp],[CFOP1],[CFOP2],[CFOP3])" &
                    " VALUES ('" & Codigo & "','" & Descricao & "','" & Categoria & "','" & Prev & "'," &
                    Custo & "," & Bruto & "," & Multiplicador & "," & Liquido & "," & Imposto & "," &
                    Comissao & "," & Adicional & ",'" & ComponentesText & "'," & Tributos & "," &
                    LucroReal & "," & LucroPercent & ",'" & NCM & "','" & CEST & "','" & UnidCom & "','" & EAN & "','" & EANTrib & "','" & ProdEsp & "','" &
                    CFOP1 & "','" & CFOP2 & "','" & CFOP3 & "')"

                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim Ra As Integer = MyCommand.ExecuteNonQuery
                'MsgBox("inseriu")


                Hide()
                Dim frmNovo As New ListaProdutos
                conexão.Close()

                frmNovo.ShowDialog()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
        End Try


    End Sub

    Private Sub EditProduto()


        Dim FormularioProduto As New Produto
        FormularioProduto.vl = 1
        FormularioProduto.PreencherCategorias()
        FormularioProduto.PreencherListaCfop()

        conexão.Close()
        conexão.Open()
        Dim i As Integer

        Try
            i = DtvProdutos.CurrentRow.Index
        Catch ex As Exception
            MsgBox(ex.Message & ": Não é possível editar um registro vazio!")
            Exit Sub
        End Try

        Dim varCodigo As Object = DtvProdutos.Item(1, i).Value
        'MsgBox(varCodigo)
        Dim sqlCom As String = "SELECT * FROM produtos WHERE [Codigo]='" & varCodigo & "'"
        Dim reader1 As OleDbDataReader
        Dim command As OleDbCommand = conexão.CreateCommand()
        command.CommandText = sqlCom

        Try
            ' Create the command.

            reader1 = command.ExecuteReader()
            reader1.Read()

            FormularioProduto.txtCodigo.Text = If(IsDBNull(reader1(0)), "", reader1(0))
            FormularioProduto.txtDescricao.Text = If(IsDBNull(reader1(1)), "", reader1(1))
            FormularioProduto.CategoriaAtual = If(IsDBNull(reader1(2)), -1, reader1(2))

            If Not IsDBNull(reader1(3)) Then
                If IO.File.Exists(reader1(3)) Then
                    FormularioProduto.imgLoc = reader1(3)
                    FormularioProduto.PictureBox1.Image = Image.FromFile(FormularioProduto.imgLoc)
                End If
            Else
                FormularioProduto.imgLoc = ""
                FormularioProduto.PictureBox1.Image = My.Resources.especial
            End If

            FormularioProduto.TxtCusto.Text = If(IsDBNull(reader1(4)), 0, reader1(4))
            FormularioProduto.TxtBruto.Text = If(IsDBNull(reader1(5)), 0, reader1(5))
            FormularioProduto.txtMultiplicador.Text = If(IsDBNull(reader1(6)), 0, reader1(6))
            FormularioProduto.TxtLiquido.Text = If(IsDBNull(reader1(7)), 0, reader1(7))

            FormularioProduto.TxtImposto.Text = If(IsDBNull(reader1(8)), 0, reader1(8))
            FormularioProduto.txtComissao.Text = If(IsDBNull(reader1(9)), 0, reader1(9))
            FormularioProduto.TxtAdicional.Text = If(IsDBNull(reader1(10)), 0, reader1(10))

            If Not IsDBNull(reader1(11)) Then
                Dim ComponentesText As String = reader1(11)
                Dim Itens() = ComponentesText.Split("&&")
                If Itens.Length > 0 Then
                    For i = 0 To Itens.Length - 1
                        Dim Part() = Itens(i).Split(";")
                        If Part.Length > 1 Then
                            'MsgBox("Part: " & i)
                            FormularioProduto.DtvComponentes.Rows.Add(Part(0), Part(1), Part(2), Part(3), Part(4), Part(5), Part(6))
                        End If
                    Next
                End If
            End If

            FormularioProduto.TxtTotalTributos.Text = If(IsDBNull(reader1(12)), 0, reader1(12))
            FormularioProduto.TxtLucroReal.Text = If(IsDBNull(reader1(13)), 0, reader1(13))
            FormularioProduto.TxtLucroPercent.Text = If(IsDBNull(reader1(14)), 0, reader1(14))

            'FormularioProduto.txtNCM.Text = If(IsDBNull(reader1(15)), "", reader1(15))
            'FormularioProduto.txtCEST.Text = If(IsDBNull(reader1(16)), "", reader1(16))
            'FormularioProduto.txtUnComercial.Text = If(IsDBNull(reader1(17)), "", reader1(17))
            'FormularioProduto.txtEAN.Text = If(IsDBNull(reader1(18)), "", reader1(18))
            'FormularioProduto.txtEANTrib.Text = If(IsDBNull(reader1(19)), "", reader1(19))
            'FormularioProduto.CbProdEspecifico.SelectedItem = If(IsDBNull(reader1(20)), "", reader1(20))
            'FormularioProduto.CbCFOP1.SelectedIndex = If(IsDBNull(reader1(21)), 0, GetCfop(reader1(21), FormularioProduto.CbCFOP1))
            'FormularioProduto.CbCFOP2.SelectedIndex = If(IsDBNull(reader1(22)), 0, GetCfop(reader1(22), FormularioProduto.CbCFOP2))
            'FormularioProduto.CbCFOP3.SelectedIndex = If(IsDBNull(reader1(23)), 0, GetCfop(reader1(23), FormularioProduto.CbCFOP3))

            FormularioProduto.txtCodigo.ReadOnly = True
            FormularioProduto.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
            Me.Dispose()
        End Try

        Hide()
        FormularioProduto.txtCodigo.ReadOnly = False
        Dim frmNovo As New ListaProdutos
        conexão.Close()
        frmNovo.ShowDialog()

    End Sub

    Private Sub ApagarProduto()


        Dim i As Integer = DtvProdutos.CurrentRow.Index
        Dim varCodigo As String = DtvProdutos.Item(1, i).Value

        Dim msgb As MsgBoxResult = MsgBox("Deseja excluir o produto " & varCodigo & "?  " & vbNewLine &
               "Descrição: " & DtvProdutos.Item(2, i).Value, MsgBoxStyle.YesNo)
        If msgb = MsgBoxResult.Yes Then

            'Deleta os dados  em Componentes relacionados a este produto

            Try
                conexão.Close()
                conexão.Open()
                Dim sqlCom As String = "DELETE * FROM produtos WHERE [Codigo]='" & varCodigo & "'"
                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim Ra As Integer = MyCommand.ExecuteNonQuery

                Me.Hide()
                Dim frmNovo As New ListaProdutos
                conexão.Close()
                frmNovo.ShowDialog()

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
                Me.Hide()
                Dim frmNovo As New ListaProdutos
                conexão.Close()
                frmNovo.ShowDialog()

            End Try



        Else
            conexão.Close()
            Exit Sub

        End If



    End Sub

    Private Sub DuplicaProduto()


        Dim FormularioProduto As New Produto
        FormularioProduto.vl = 2
        FormularioProduto.PreencherCategorias()
        FormularioProduto.PreencherListaCfop()


        conexão.Close()
        conexão.Open()
        Dim i As Integer


        Try
            i = DtvProdutos.CurrentRow.Index
        Catch ex As Exception
            MsgBox(ex.Message & ": Não é possível duplicar um registro vazio!")
            Exit Sub
        End Try

        Dim varCodigo As Object = DtvProdutos.Item(1, i).Value
        Dim sqlCom As String = "SELECT * FROM produtos WHERE [Codigo]='" & varCodigo & "'"

        Try
            ' Create the command.
            Dim reader1 As OleDbDataReader
            Dim command As OleDbCommand = conexão.CreateCommand()
            command.CommandText = sqlCom
            reader1 = command.ExecuteReader()

            reader1.Read()

            FormularioProduto.txtCodigo.Text = If(IsDBNull(reader1(0)), "", reader1(0))
            FormularioProduto.txtDescricao.Text = If(IsDBNull(reader1(1)), "", reader1(1))
            FormularioProduto.CategoriaAtual = If(IsDBNull(reader1(2)), -1, reader1(2))

            If Not IsDBNull(reader1(3)) Then
                If IO.File.Exists(reader1(3)) Then
                    FormularioProduto.imgLoc = reader1(3)
                    FormularioProduto.PictureBox1.Image = Image.FromFile(FormularioProduto.imgLoc)
                End If
            Else
                FormularioProduto.imgLoc = ""
                FormularioProduto.PictureBox1.Image = My.Resources.ESPECIAL
            End If

            FormularioProduto.TxtCusto.Text = If(IsDBNull(reader1(4)), 0, reader1(4))
            FormularioProduto.TxtBruto.Text = If(IsDBNull(reader1(5)), 0, reader1(5))
            FormularioProduto.txtMultiplicador.Text = If(IsDBNull(reader1(6)), 0, reader1(6))
            FormularioProduto.TxtLiquido.Text = If(IsDBNull(reader1(7)), 0, reader1(7))

            FormularioProduto.TxtImposto.Text = If(IsDBNull(reader1(8)), 0, reader1(8))
            FormularioProduto.txtComissao.Text = If(IsDBNull(reader1(9)), 0, reader1(9))
            FormularioProduto.TxtAdicional.Text = If(IsDBNull(reader1(10)), 0, reader1(10))


            If Not IsDBNull(reader1(11)) Then
                Dim ComponentesText As String = reader1(11)
                Dim Itens() = ComponentesText.Split("&&")
                If Itens.Count > 0 Then
                    For i = 0 To Itens.Count - 1
                        Dim Part() = Itens(i).Split(";")
                        If Part.Count > 1 Then
                            FormularioProduto.DtvComponentes.Rows.Add(Part(0), Part(1), Part(2), Part(3), Part(4), Part(5), Part(6))
                        End If
                    Next
                End If
            End If

            FormularioProduto.TxtTotalTributos.Text = If(IsDBNull(reader1(12)), 0, reader1(12))
            FormularioProduto.TxtLucroReal.Text = If(IsDBNull(reader1(13)), 0, reader1(13))
            FormularioProduto.TxtLucroPercent.Text = If(IsDBNull(reader1(14)), 0, reader1(14))

            'FormularioProduto.txtNCM.Text = If(IsDBNull(reader1(15)), "", reader1(15))
            'FormularioProduto.txtCEST.Text = If(IsDBNull(reader1(16)), "", reader1(16))
            'FormularioProduto.txtUnComercial.Text = If(IsDBNull(reader1(17)), "", reader1(17))
            'FormularioProduto.txtEAN.Text = If(IsDBNull(reader1(18)), "", reader1(18))
            'FormularioProduto.txtEANTrib.Text = If(IsDBNull(reader1(19)), "", reader1(19))
            'FormularioProduto.CbProdEspecifico.SelectedItem = If(IsDBNull(reader1(20)), "", reader1(20))
            'FormularioProduto.CbCFOP1.SelectedIndex = If(IsDBNull(reader1(21)), 0, GetCfop(reader1(21), FormularioProduto.CbCFOP1))
            'FormularioProduto.CbCFOP2.SelectedIndex = If(IsDBNull(reader1(22)), 0, GetCfop(reader1(22), FormularioProduto.CbCFOP2))
            'FormularioProduto.CbCFOP3.SelectedIndex = If(IsDBNull(reader1(23)), 0, GetCfop(reader1(23), FormularioProduto.CbCFOP3))

            'FormularioProduto.txtCodigo.ReadOnly = True

            FormularioProduto.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
            Me.Dispose()
        End Try

        FormularioProduto.txtCodigo.ReadOnly = False

        Hide()
        Dim frmNovo As New ListaProdutos
        conexão.Close()
        frmNovo.ShowDialog()

    End Sub

    Private Function GetCfop(valor As String, cb As ComboBox) As Integer
        GetCfop = 0
        Dim count As Integer = 0
        Dim It As String = Nothing
        Try
            If valor <> "" Then
                Dim valor2 As Integer = CInt(valor.Replace(".", ""))
                For Each item As String In cb.Items
                    'MsgBox(item)
                    If item.Contains(".") Then
                        It = item.Replace(".", "").Replace(Chr(10), "")
                        'MsgBox(It(0))
                        If CInt(It) = CInt(valor) Then
                            'MsgBox("Item Cb: " & item & "  - Extraxt: '" & Trim(It(0)) & "'  - Valor: '" & valor & "'")
                            GetCfop = count
                            GoTo FIM
                        End If
                    End If
                    count += 1
                    Application.DoEvents()
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace & vbNewLine)
        End Try
FIM:

        Return GetCfop
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddProduto()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditProduto()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ApagarProduto()
    End Sub

    Private Sub btnDuplicar_Click(sender As Object, e As EventArgs) Handles btnDuplicar.Click
        DuplicaProduto()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub


    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        Dim frm As New ProcessoImportacao
        If Modo = 1 Then
            frm.Processo = 3
        ElseIf Modo = 2 Then
            frm.Processo = 5
        End If
        frm.Modo = Modo
        frm.tipoarq = TipoArq
        frm.nomearq = OpenFileDialog1.FileName
        frm.ShowDialog()
        Atualizar()

        Me.Hide()
        Dim frmNovo As New ListaProdutos
        conexão.Close()
        frmNovo.ShowDialog()

    End Sub

    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click

        OpenFileDialog1.Filter = "(Text Files)|*.txt;*.csv|Txt | *.txt|Csv | *.csv"
        TipoArq = 2
        Modo = 0
        OpenFileDialog1.ShowDialog()

    End Sub


    Private Sub TxtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub CbCategoria_ClickSelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCategoria.SelectedIndexChanged
        If flagSelect = True Then
            PreencherLista(txtFiltro.Text, CbCategoria.SelectedItem)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If flagSelect = True Then
            PreencherLista(txtFiltro.Text, CbCategoria.SelectedItem)
        End If
    End Sub

    Private Sub DtvProdutos_CellMouseMove(sender As Object, e As DataGridViewCellEventArgs) Handles DtvProdutos.CellMouseEnter
        'MsgBox(e.RowIndex)

        If ChkMostrar.Checked = True And e.RowIndex >= 0 Then
            If ToolCustom.Timer1.Enabled = True Then
                ToolCustom.Timer1.Dispose()
                ToolCustom.Dispose()
            End If

            ToolCustom.Time = 5000
            ToolCustom.Codigo = DtvProdutos.Item(1, e.RowIndex).Value
            ToolCustom.Descricao = DtvProdutos.Item(2, e.RowIndex).Value
            ToolCustom.Categoria = DtvProdutos.Item(4, e.RowIndex).Value
            ToolCustom.Linha = DtvProdutos.Item(5, e.RowIndex).Value
            ToolCustom.Preco = DtvProdutos.Item(9, e.RowIndex).Value
            ToolCustom.Imagem = DtvProdutos.Item(10, e.RowIndex).Value
            ToolCustom.Location = System.Windows.Forms.Cursor.Position
            ToolCustom.Show()
        End If


    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click

        Dim dr As DialogResult = MsgBox("Este procedimento atualizará os produtos com os valores atuais dos materiais cadastrados! Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If dr = Forms.DialogResult.Yes Then
            Atualizar()
        End If

    End Sub

    Private Sub Atualizar()

        Dim frm As New ProcessoImportacao
        frm.Processo = 7
        frm.ShowDialog()
        PreencherLista(txtFiltro.Text, CbCategoria.SelectedItem)

    End Sub


End Class
'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows
Imports System.Threading

Public Class ProcessoImportacao

    Public Processo As Integer
    Public nomearq As String
    Public tipoarq As Integer
    Public nomeplanilha As String
    Public Modo As Integer
    Public nomecat As String
    Public nchave As Double
    Public nomemat As String
    Public valmat As Double

    Public Class Material
        Public Property Codigo() As String
        Public Property Valor() As Single
    End Class
    Private ListaMaterial As List(Of Material)

    Public Class Categoria
        Public Property Id() As Integer
        Public Property Markup() As Single
    End Class
    Private ListaCategorias As List(Of Categoria)


    Private Sub FrmProcessando_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Stop()
        Select Case Processo
            Case 1
                ObterLista(nomearq)
            Case 2
                ObterLista2(nomearq)
            Case 3
                'ObterLista3(nomearq)
            Case 4
                'ObterLista4()
            Case 5
                'ObterLista5(nomearq)
            Case 6
                'ObterLista6(nomecat, nchave, 1)
            Case 7
                'ObterLista7()
        End Select
        Timer1.Dispose()
        Me.Close()

    End Sub

    Public Sub ObterLista(ByVal nomearq As String)

        Dim frm As New VisualizaArquivoImportado
        frm.tipo = 1
        frm.arqu = nomearq
        frm.GroupBox1.Visible = True

        Dim dresult0 As DialogResult = frm.ShowDialog()

        Dim dr As DataRow
        Dim Prss As Integer = 0
        Dim Percent As Integer = 0

        Dim Codigo As String = " "
        Dim Descricao As String = " "
        Dim Fornecedor As String = " "
        Dim Categoria As String = " "
        Dim Valor As Double = 0
        Dim IPI As Double = 0
        Dim Frete As Double = 0
        Dim ValorFinal As Double = 0
        Dim Param1 As Double = 0
        Dim Param2 As Double = 0
        Dim Param3 As Double = 0
        Dim Preview As String = " "
        Dim unidade As String = " "
        Dim veio As Integer = 0
        Dim CodForn As String = " "
        Dim Data As String = My.Computer.Clock.LocalTime
        Dim Estoque As Double = 0
        Dim ValorEst As Double = 0

        Try

            'MsgBox("Passou tela! Result = " & dresult0.ToString(), MsgBoxStyle.Exclamation)

            If dresult0 = DialogResult.OK Then

                Dim Icodigo As Integer = frm.TxtCodigo.Text - 1
                Dim Idescricao As Integer = frm.TxtDescricao.Text - 1
                Dim Ifornecedor As Integer = frm.TxtFornecedor.Text - 1
                Dim Icategoria As Integer = frm.TxtCategoria.Text - 1
                Dim Ivalor As Integer = frm.TxtValor.Text - 1
                Dim Iipi As Integer = frm.TxtIPI.Text - 1
                Dim Ifrete As Integer = frm.TxtFrete.Text - 1
                Dim Ivalorfinal As Integer = frm.TxtValorFinal.Text - 1
                Dim Iparam1 As Integer = frm.TxtParam1.Text - 1
                Dim Iparam2 As Integer = frm.TxtParam2.Text - 1
                Dim Iparam3 As Integer = frm.TxtParam3.Text - 1
                Dim Ipreview As Integer = frm.TxtPreview.Text - 1
                Dim ICodForn As Integer = frm.TxtCodForn.Text - 1
                Dim IData As Integer = frm.TxtData.Text - 1
                Dim IEstoque As Integer = frm.TxtEstoque.Text - 1
                Dim IValorEst As Integer = frm.TxtValorEstoque.Text - 1


                Dim dresult As DialogResult = MsgBox("Deseja atualizar registros existentes?" & vbNewLine & "Adicionar e atualizar registros: SIM" &
                                                     vbNewLine & "Apenas adicionar registros novos: NÃO", MsgBoxStyle.YesNoCancel)

                If dresult = DialogResult.Yes Then

                    Dim contlinha() As String
                    Dim linha As String
                    Dim linhas() As String = IO.File.ReadAllLines(nomearq, System.Text.Encoding.Default)

                    Progbar.Visible = True
                    Progbar.Maximum = linhas.Count
                    Progbar.Value = 0

                    Dim Separador As String = Nothing

                    If frm.ChkPtVirgula.Checked = True Then
                        Separador = ";"
                    End If
                    If frm.ChkTab.Checked = True Then
                        Separador = vbTab
                    End If

                    'Exit Sub
                    For Each linha In linhas
                        Dim ln As String = Replace(linha, Chr(10), "")
                        contlinha = ln.Split(Separador)

                        If Icodigo >= 0 Then
                            LbRegistro.Text = "Registro: " & contlinha(Icodigo)
                            If Icodigo >= 0 Then
                                Codigo = contlinha(Icodigo)
                                If IsDBNull(Codigo) Then
                                    MsgBox("Um dos registros contem o campo código vazio! " & vbNewLine & "Não é possível adicionar um registro vazio")
                                    Exit Sub
                                End If
                                'MsgBox("Razão ok")
                            End If

                            If Idescricao >= 0 Then
                                Descricao = contlinha(Idescricao)
                                'MsgBox("Fantasia ok")
                            End If
                            If Ifornecedor >= 0 Then
                                Fornecedor = contlinha(Ifornecedor)
                                'MsgBox("CNPJ ok")
                            End If
                            If Icategoria >= 0 Then
                                'MsgBox("Icategoria = " & Icategoria)
                                Categoria = contlinha(Icategoria)
                                If IsDBNull(Categoria) Then
                                    MsgBox("Um dos registros contem o campo categoria vazio! " & vbNewLine & "Não é possível adicionar um registro vazio")
                                    GoTo PROX1
                                End If

                                For Each dr In CategoriasDS.Tables("categorias").Rows
                                    If dr.Item(0).ToString = Categoria Then
                                        unidade = dr.Item(1).ToString
                                    End If
                                Next
                                'MsgBox("Endereço ok")
                            End If

                            If Ivalor >= 0 Then
                                'MsgBox("Ivalor = " & Ivalor)
                                Valor = CDbl(Replace(contlinha(Ivalor), "R$", " "))
                                'MsgBox("Contato ok")
                            End If
                            If Iipi >= 0 Then
                                'MsgBox("Iipi = " & Iipi)
                                IPI = CDbl(Replace(contlinha(Iipi), "%", " ")) * 100
                                'MsgBox("Telefone1 ok")
                            End If
                            If Ifrete >= 0 Then
                                'MsgBox("Ifrete = " & Ifrete)
                                Frete = CDbl(Replace(contlinha(Ifrete), "%", " ")) * 100
                                'MsgBox("Telefone2 ok")
                            End If
                            If Ivalorfinal >= 0 Then
                                'MsgBox("Ivalorfinal = " & Ivalorfinal)
                                ValorFinal = CDbl(Replace(contlinha(Ivalorfinal), "R$", " "))
                            End If

                            If Iparam1 >= 0 Then
                                'MsgBox("É: " & LTrim(RTrim(LCase(contlinha(Iparam1)))) & " -- " & Categoria)
                                If LCase(RTrim(LTrim(contlinha(Iparam1)))) = "peça" And LCase(RTrim(LTrim(Categoria))) = "chapas_mdp" Then
                                    Param1 = 2750
                                    Param2 = 1830
                                    Param3 = (Param1 * Param2) / 1000000
                                    'MsgBox("É: " & LTrim(RTrim(LCase(contlinha(Iparam1)))) & " -- " & Categoria)
                                ElseIf LCase(RTrim(LTrim(contlinha(Iparam1)))) = "peça" And LCase(RTrim(LTrim(Categoria))) <> "chapas_mdp" Then
                                    Param1 = 1
                                    Param2 = 0
                                    Param3 = 0
                                ElseIf LTrim(RTrim(LCase(contlinha(Iparam1)))) = "metro" Then
                                    Param1 = 1
                                    Param2 = 0
                                    Param3 = 0
                                ElseIf LTrim(RTrim(LCase(contlinha(Iparam1)))) = "cento" Then
                                    Param1 = 100
                                    Param2 = 0
                                    Param3 = 0
                                    ValorFinal = CDbl(Replace(contlinha(Ivalor), "R$", " ")) / Param1
                                ElseIf LTrim(RTrim(LCase(contlinha(Iparam1)))) = "milheiro" Then
                                    Param1 = 1000
                                    Param2 = 0
                                    Param3 = 0
                                    ValorFinal = CDbl(Replace(contlinha(Ivalor), "R$", " ")) / Param1
                                ElseIf LTrim(RTrim(LCase(contlinha(Iparam1)))) = "litro" Then
                                    Param1 = 1000
                                    Param2 = 0
                                    Param3 = 0
                                    ValorFinal = CDbl(Replace(contlinha(Ivalor), "R$", " ")) / Param1
                                ElseIf LTrim(RTrim(LCase(contlinha(Iparam1)))) = "kg" Then
                                    Param1 = 1000
                                    Param2 = 0
                                    Param3 = 0
                                    ValorFinal = CDbl(Replace(contlinha(Ivalor), "R$", " ")) / Param1
                                Else
                                    Param1 = 1
                                    Param2 = 0
                                    Param3 = 0
                                End If
                                'Param1 = CDbl(contlinha(Iparam1))
                                'MsgBox("E-mail ok")
                            End If

                            If Iparam2 >= 0 Then
                                Param2 = contlinha(Iparam2)
                                'MsgBox("E-mail ok")
                            End If

                            If Iparam3 >= 0 Then
                                Param3 = contlinha(Iparam3)
                                'MsgBox("E-mail ok")
                            End If

                            If Ipreview >= 0 Then
                                Preview = contlinha(Ipreview)
                                'MsgBox("E-mail ok")
                            End If

                            If ICodForn >= 0 Then
                                'MsgBox("ICodForn = " & ICodForn)
                                CodForn = contlinha(ICodForn)
                                'MsgBox("E-mail ok")
                            End If

                            If IData >= 0 Then
                                'MsgBox("IData = " & IData)
                                If LTrim(RTrim(contlinha(IData))) <> "" Then
                                    Data = contlinha(IData)
                                Else
                                    Data = My.Computer.Clock.LocalTime
                                End If
                                'MsgBox("E-mail ok")
                            End If

                            If IEstoque >= 0 Then
                                'MsgBox("IEstoque = " & IEstoque)
                                Estoque = contlinha(IEstoque)
                                'MsgBox("E-mail ok")
                            End If

                            If IValorEst >= 0 Then
                                'MsgBox("IValorEst = " & IValorEst)
                                ValorEst = contlinha(IValorEst)
                                'MsgBox("E-mail ok")
                            End If

                            'MsgBox("" & Codigo.Replace(",", ".") & "','" & Descricao.Replace(",", ".") & "','" & Fornecedor.Replace(",", ".") & "','" & Categoria.Replace(",", ".") & "','" & unidade.Replace(",", ".") & "'," & Replace(Valor, ",", ".") & "," & Replace(IPI, ",", ".") & "," & Replace(Frete, ",", ".") & "," & Replace(ValorFinal, ",", ".") & "," & Replace(Param1, ",", ".") & "," & Replace(Param2, ",", ".") & "," & Replace(Param3, ",", ".") & ",'" & Preview.Replace(",", ".") & "'," & veio.Replace(",", ".") & ",'" & CodForn.Replace(",", ".") & "','" & Data.Replace(",", ".") & "'," & Replace(Estoque, ",", ".") & "," & Replace(ValorEst, ",", "."))
                            'For Each dr In MateriaisDS.Tables(0).Rows
                            '    If dr.Item(0).ToString = Codigo Then
                            Try
                                conexão.Close()
                                conexão.Open()
                                Dim sqlCom As String = "UPDATE materiaprima SET [Descricao] = '" & Replace(Descricao, ",", ".") & "'," &
                                                    "[Fornecedor] = '" & Replace(Fornecedor, ",", ".") & "', " &
                                                    "[Categoria] = '" & Replace(Categoria, ",", ".") & "', " &
                                                    "[Unidade] = '" & Replace(unidade, ",", ".") & "', " &
                                                    "[Preco] = " & Replace(Valor, ",", ".") & ", " &
                                                    "[IPI] = " & Replace(IPI, ",", ".") & ", " &
                                                    "[FRETE] = " & Replace(Frete, ",", ".") & ", " &
                                                    "[Valor final] = " & Replace(ValorFinal, ",", ".") & ", " &
                                                    "[Parametro1] = " & Replace(Param1, ",", ".") & ", " &
                                                    "[Parametro2] = " & Replace(Param2, ",", ".") & ", " &
                                                    "[Parametro3] = " & Replace(Param3, ",", ".") & ", " &
                                                    "[Img] = '" & Replace(Preview, ",", ".") & "', " &
                                                    "[Veio] = " & Replace(veio, ",", ".") & ", " &
                                                    "[CodFornecedor] = '" & Replace(CodForn, ",", ".") & "', " &
                                                    "[Data] = '" & Replace(Data, ",", ".") & "', " &
                                                    "[Qtde] = " & Replace(Estoque, ",", ".") & ", " &
                                                    "[ValorEstoque] = " & Replace(ValorEst, ",", ".") &
                                                    " WHERE [Codigo] = '" & Codigo & "'"

                                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                                Dim Ra As Integer = MyCommand.ExecuteNonQuery
                                conexão.Close()

                                GoTo PROX1
                                'MsgBox("EDITOU REGISTRO")
                            Catch ex As Exception
                                'MsgBox("Erro ao atualizar: " & ex.Message
                                MsgBox("Erro ao atualizar: " & vbNewLine &
                                                "[Descricao] = '" & Replace(Descricao, ",", ".") & "'," & vbNewLine &
                                                "[Fornecedor] = '" & Replace(Fornecedor, ",", ".") & "', " & vbNewLine &
                                                "[Categoria] = '" & Replace(Categoria, ",", ".") & "', " & vbNewLine &
                                                "[Unidade] = '" & Replace(unidade, ",", ".") & "', " & vbNewLine &
                                                "[Preco] = " & Replace(Valor, ",", ".") & ", " & vbNewLine &
                                                "[IPI] = " & Replace(IPI, ",", ".") & ", " & vbNewLine &
                                                "[FRETE] = " & Replace(Frete, ",", ".") & ", " & vbNewLine &
                                                "[Valor final] = " & Replace(ValorFinal, ",", ".") & ", " & vbNewLine &
                                                "[Parametro1] = " & Replace(Param1, ",", ".") & ", " & vbNewLine &
                                                "[Parametro2] = " & Replace(Param2, ",", ".") & ", " & vbNewLine &
                                                "[Parametro3] = " & Replace(Param3, ",", ".") & ", " & vbNewLine &
                                                "[Img] = '" & Replace(Preview, ",", ".") & "', " & vbNewLine &
                                                "[Veio] = " & Replace(veio, ",", ".") & ", " & vbNewLine &
                                                "[CodFornecedor] = '" & Replace(CodForn, ",", ".") & "', " & vbNewLine &
                                                "[Data] = '" & Replace(Data, ",", ".") & "', " & vbNewLine &
                                                "[Qtde] = " & Replace(Estoque, ",", ".") & ", " & vbNewLine &
                                                "[ValorEstoque] = " & Replace(ValorEst, ",", ".") & vbNewLine &
                                                " WHERE [Codigo] = '" & Codigo & "'" & vbNewLine &
                                                ex.Message)
                                conexão.Close()
                                'Close()
                            End Try

                            '    End If
                            '    Application.DoEvents()
                            'Next

                            Try
                                conexão.Close()
                                conexão.Open()
                                Dim sqlCom1 As String = "INSERT INTO materiaprima (" &
                                                                        "[Codigo]," &
                                                                        "[Descricao]," &
                                                                        "[Fornecedor]," &
                                                                        "[Categoria]," &
                                                                        "[Unidade]," &
                                                                        "[Preco]," &
                                                                        "[IPI]," &
                                                                        "[Frete]," &
                                                                        "[Valor final]," &
                                                                        "[Parametro1]," &
                                                                        "[Parametro2]," &
                                                                        "[Parametro3]," &
                                                                        "[Img]," &
                                                                        "[Veio]," &
                                                                        "[CodFornecedor]," &
                                                                        "[Data]," &
                                                                        "[Qtde]," &
                                                                        "[ValorEstoque]) " &
                                                                        "VALUES ( " &
                                                                        "'" & Replace(Codigo, ",", ".") & "', " &
                                                                        "'" & Replace(Descricao, ",", ".") & "', " &
                                                                        "'" & Replace(Fornecedor, ",", ".") & "', " &
                                                                        "'" & Replace(Categoria, ",", ".") & "'," &
                                                                        "'" & Replace(unidade, ",", ".") & "'," &
                                                                        "" & Replace(Valor, ",", ".") & "," &
                                                                        "" & Replace(IPI, ",", ".") & "," &
                                                                        "" & Replace(Frete, ",", ".") & "," &
                                                                        "" & Replace(ValorFinal, ",", ".") & "," &
                                                                        "" & Replace(Param1, ",", ".") & "," &
                                                                        "" & Replace(Param2, ",", ".") & "," &
                                                                        "" & Replace(Param3, ",", ".") & "," &
                                                                        "'" & Replace(Preview, ",", ".") & "'," &
                                                                        "" & Replace(veio, ",", ".") & "," &
                                                                        "'" & Replace(CodForn, ",", ".") & "'," &
                                                                        "'" & Replace(Data, ",", ".") & "'," &
                                                                        "" & Replace(Estoque, ",", ".") & "," &
                                                                        "" & Replace(ValorEst, ",", ".") & ")"
                                'MsgBox(sqlCom)
                                Dim MyCommand1 As New OleDbCommand(sqlCom1, conexão)
                                Dim Ra1 As Integer = MyCommand1.ExecuteNonQuery
                                conexão.Close()
                            Catch ex As Exception
                                conexão.Close()
                                'MsgBox("Erro ao inserir: " & ex.Message & vbNewLine & ex.ToString)
                                MsgBox("Erro ao inserir: " & vbNewLine &
                                    "'" & Replace(Codigo, ",", ".") & "', " & vbNewLine &
                                    "'" & Replace(Descricao, ",", ".") & "', " & vbNewLine &
                                    "'" & Replace(Fornecedor, ",", ".") & "', " & vbNewLine &
                                    "'" & Replace(Categoria, ",", ".") & "'," & vbNewLine &
                                    "'" & Replace(unidade, ",", ".") & "'," & vbNewLine &
                                    "" & Replace(Valor, ",", ".") & "," & vbNewLine &
                                    "" & Replace(IPI, ",", ".") & "," & vbNewLine &
                                    "" & Replace(Frete, ",", ".") & "," & vbNewLine &
                                    "" & Replace(ValorFinal, ",", ".") & "," & vbNewLine &
                                    "" & Replace(Param1, ",", ".") & "," & vbNewLine &
                                    "" & Replace(Param2, ",", ".") & "," & vbNewLine &
                                    "" & Replace(Param3, ",", ".") & "," & vbNewLine &
                                    "'" & Replace(Preview, ",", ".") & "'," & vbNewLine &
                                    "" & Replace(veio, ",", ".") & "," & vbNewLine &
                                    "'" & Replace(CodForn, ",", ".") & "'," & vbNewLine &
                                    "'" & Replace(Data, ",", ".") & "'," & vbNewLine &
                                    "" & Replace(Estoque, ",", ".") & "," & vbNewLine &
                                    "" & Replace(ValorEst, ",", ".") & vbNewLine &
                                    ex.Message)
                            End Try
PROX1:
                            Prss = Prss + 1
                            Progbar.Value = Prss
                            Percent = (Prss * 100) / Progbar.Maximum
                            LbPercent.Text = Percent & " %"

                        End If

                        Application.DoEvents()

                    Next


                ElseIf dresult = DialogResult.No Then

                    Dim contlinha() As String
                    Dim linha As String
                    Dim linhas() As String = IO.File.ReadAllLines(nomearq, System.Text.Encoding.Default)


                    Progbar.Visible = True
                    Progbar.Maximum = linhas.Count
                    Progbar.Step = 1
                    Progbar.Value = 0

                    Dim Separador As String = Nothing

                    If frm.ChkPtVirgula.Checked = True Then
                        Separador = ";"
                    End If
                    If frm.ChkTab.Checked = True Then
                        Separador = vbTab
                    End If

                    'MsgBox(Separador)
                    'MsgBox(Irazao & " ; " & Ifantasia & " ; " & Icnpj & " ; " & Iend & " ; " & Icontato & " ; " & Itel1 & " ; " & Itel2 & " ; " & Iemail)

                    For Each linha In linhas
                        Dim ln As String = Replace(linha, Chr(10), "")
                        contlinha = ln.Split(Separador)

                        If Icodigo >= 0 Then
                            LbRegistro.Text = "Registro: " & contlinha(Icodigo)

                            If Icodigo >= 0 Then
                                'Codigo = contlinha(Icodigo)
                                If IsDBNull(Codigo) Then
                                    MsgBox("Um dos registros contem o campo código vazio! " & vbNewLine & "Não é possível adicionar um registro vazio")
                                    Exit Sub
                                End If
                                'MsgBox("Razão ok")
                            End If
                            If Idescricao >= 0 Then
                                Descricao = contlinha(Idescricao)
                                'MsgBox("Fantasia ok")
                            End If
                            If Ifornecedor >= 0 Then
                                Fornecedor = contlinha(Ifornecedor)
                                'MsgBox("CNPJ ok")
                            End If
                            If Icategoria >= 0 Then
                                Categoria = contlinha(Icategoria)
                                If IsDBNull(Categoria) Then
                                    MsgBox("Um dos registros contem o campo categoria vazio! " & vbNewLine & "Não é possível adicionar um registro vazio")
                                    Exit Sub
                                End If

                                For Each dr In CategoriasDS.Tables("categorias").Rows
                                    If dr.Item(0).ToString = Categoria Then
                                        unidade = dr.Item(1).ToString
                                    End If
                                Next
                                'MsgBox("Endereço ok")
                            End If
                            If Ivalor >= 0 Then
                                Valor = CDbl(Replace(contlinha(Ivalor), "R$", " "))
                                'MsgBox("Contato ok")
                            End If
                            If Iipi >= 0 Then
                                IPI = CDbl(Replace(contlinha(Iipi), "%", " ")) * 100
                                'MsgBox("Telefone1 ok")
                            End If
                            If Ifrete >= 0 Then
                                Frete = CDbl(Replace(contlinha(Ifrete), "%", " ")) * 100
                                'MsgBox("Telefone2 ok")
                            End If
                            If Ivalorfinal >= 0 Then
                                ValorFinal = CDbl(Replace(contlinha(Ivalorfinal), "R$", " "))
                            End If

                            If Iparam1 >= 0 Then
                                'MsgBox("É: " & LTrim(RTrim(LCase(contlinha(Iparam1)))) & " -- " & Categoria)
                                If LTrim(RTrim(LCase(contlinha(Iparam1)))) = "peca" Or LTrim(RTrim(LCase(contlinha(Iparam1)))) = "peça" And Categoria = "Chapas_MDP" Then
                                    Param1 = 2750
                                    Param2 = 1830
                                    Param3 = (Param1 * Param2) / 1000000
                                ElseIf LTrim(RTrim(LCase(contlinha(Iparam1)))) = "peca" Or LTrim(RTrim(LCase(contlinha(Iparam1)))) = "peça" And Categoria <> "Chapas_MDP" Then
                                    Param1 = 1
                                    Param2 = 0
                                    Param3 = 0
                                ElseIf LTrim(RTrim(LCase(contlinha(Iparam1)))) = "metro" Then
                                    Param1 = 1
                                    Param2 = 0
                                    Param3 = 0
                                ElseIf LTrim(RTrim(LCase(contlinha(Iparam1)))) = "cento" Then
                                    Param1 = 100
                                    Param2 = 0
                                    Param3 = 0
                                    ValorFinal = CDbl(Replace(contlinha(Ivalor), "R$", " ")) / Param1
                                ElseIf LTrim(RTrim(LCase(contlinha(Iparam1)))) = "milheiro" Then
                                    Param1 = 1000
                                    Param2 = 0
                                    Param3 = 0
                                    ValorFinal = CDbl(Replace(contlinha(Ivalor), "R$", " ")) / Param1
                                ElseIf LTrim(RTrim(LCase(contlinha(Iparam1)))) = "litro" Then
                                    Param1 = 1000
                                    Param2 = 0
                                    Param3 = 0
                                    ValorFinal = CDbl(Replace(contlinha(Ivalor), "R$", " ")) / Param1
                                ElseIf LTrim(RTrim(LCase(contlinha(Iparam1)))) = "kg" Then
                                    Param1 = 1000
                                    Param2 = 0
                                    Param3 = 0
                                    ValorFinal = CDbl(Replace(contlinha(Ivalor), "R$", " ")) / Param1
                                Else
                                    Param1 = 1
                                    Param2 = 0
                                    Param3 = 0
                                End If
                                'Param1 = CDbl(contlinha(Iparam1))
                                'MsgBox("E-mail ok")
                            End If

                            If Iparam2 >= 0 Then
                                Param2 = CDbl(contlinha(Iparam2))
                                'MsgBox("E-mail ok")
                            End If

                            If Iparam3 >= 0 Then
                                Param3 = CDbl(contlinha(Iparam3))
                                'MsgBox("E-mail ok")
                            End If

                            If Ipreview >= 0 Then
                                Preview = contlinha(Ipreview)
                                'MsgBox("E-mail ok")
                            End If

                            If ICodForn >= 0 Then
                                CodForn = contlinha(ICodForn)
                                'MsgBox("E-mail ok")
                            End If

                            If IData >= 0 Then
                                Data = contlinha(IData)
                                'MsgBox("E-mail ok")
                            End If

                            If IEstoque >= 0 Then
                                Estoque = contlinha(IEstoque)
                                'MsgBox("E-mail ok")
                            End If

                            If IValorEst >= 0 Then
                                ValorEst = contlinha(IValorEst)
                                'MsgBox("E-mail ok")
                            End If

                            For Each dr In MateriaisDS.Tables(0).Rows
                                If dr.Item(0).ToString = Codigo Then
                                    GoTo PROX2
                                End If
                            Next

                            Try
                                conexão.Close()
                                conexão.Open()
                                Dim sqlCom1 As String = "INSERT INTO materiaprima (" &
                                                                        "[Codigo]," &
                                                                        "[Descricao]," &
                                                                        "[Fornecedor]," &
                                                                        "[Categoria]," &
                                                                        "[Unidade]," &
                                                                        "[Preco]," &
                                                                        "[IPI]," &
                                                                        "[Frete]," &
                                                                        "[Valor final]," &
                                                                        "[Parametro1]," &
                                                                        "[Parametro2]," &
                                                                        "[Parametro3]," &
                                                                        "[Img]," &
                                                                        "[Veio]," &
                                                                        "[CodFornecedor]," &
                                                                        "[Data]," &
                                                                        "[Qtde]," &
                                                                        "[ValorEstoque]) " &
                                                                        "VALUES ( " &
                                                                        "'" & Replace(Codigo, ",", ".") & "', " &
                                                                        "'" & Replace(Descricao, ",", ".") & "', " &
                                                                        "'" & Replace(Fornecedor, ",", ".") & "', " &
                                                                        "'" & Replace(Categoria, ",", ".") & "'," &
                                                                        "'" & Replace(unidade, ",", ".") & "'," &
                                                                        "" & Replace(Valor, ",", ".") & "," &
                                                                        "" & Replace(IPI, ",", ".") & "," &
                                                                        "" & Replace(Frete, ",", ".") & "," &
                                                                        "" & Replace(ValorFinal, ",", ".") & "," &
                                                                        "" & Replace(Param1, ",", ".") & "," &
                                                                        "" & Replace(Param2, ",", ".") & "," &
                                                                        "" & Replace(Param3, ",", ".") & "," &
                                                                        "'" & Replace(Preview, ",", ".") & "'," &
                                                                        "" & Replace(veio, ",", ".") & "," &
                                                                        "'" & Replace(CodForn, ",", ".") & "'," &
                                                                        "'" & Replace(Data, ",", ".") & "'," &
                                                                        "" & Replace(Estoque, ",", ".") & "," &
                                                                        "" & Replace(ValorEst, ",", ".") & ")"
                                'MsgBox(sqlCom)
                                Dim MyCommand1 As New OleDbCommand(sqlCom1, conexão)
                                Dim Ra1 As Integer = MyCommand1.ExecuteNonQuery
                                conexão.Close()
                            Catch ex As Exception
                                conexão.Close()
                                'MsgBox("Erro ao inserir: " & ex.Message & vbNewLine & ex.ToString)
                                MsgBox("Erro ao inserir: " & vbNewLine &
                                    "'" & Replace(Codigo, ",", ".") & "', " & vbNewLine &
                                    "'" & Replace(Descricao, ",", ".") & "', " & vbNewLine &
                                    "'" & Replace(Fornecedor, ",", ".") & "', " & vbNewLine &
                                    "'" & Replace(Categoria, ",", ".") & "'," & vbNewLine &
                                    "'" & Replace(unidade, ",", ".") & "'," & vbNewLine &
                                    "" & Replace(Valor, ",", ".") & "," & vbNewLine &
                                    "" & Replace(IPI, ",", ".") & "," & vbNewLine &
                                    "" & Replace(Frete, ",", ".") & "," & vbNewLine &
                                    "" & Replace(ValorFinal, ",", ".") & "," & vbNewLine &
                                    "" & Replace(Param1, ",", ".") & "," & vbNewLine &
                                    "" & Replace(Param2, ",", ".") & "," & vbNewLine &
                                    "" & Replace(Param3, ",", ".") & "," & vbNewLine &
                                    "'" & Replace(Preview, ",", ".") & "'," & vbNewLine &
                                    "" & Replace(veio, ",", ".") & "," & vbNewLine &
                                    "'" & Replace(CodForn, ",", ".") & "'," & vbNewLine &
                                    "'" & Replace(Data, ",", ".") & "'," & vbNewLine &
                                    "" & Replace(Estoque, ",", ".") & "," & vbNewLine &
                                    "" & Replace(ValorEst, ",", ".") & vbNewLine &
                                    ex.Message)
                            End Try
PROX2:
                            Prss = Prss + 1
                            Progbar.Value = Prss
                            Percent = (Prss * 100) / Progbar.Maximum
                            LbPercent.Text = Percent & " %"

                        End If

                        Application.DoEvents()
                    Next


                End If

                'Else
                'MsgBox("Nada...", MsgBoxStyle.Question)
            End If

        Catch ex As Exception
            MsgBox(ex.Message & vbCr & ex.StackTrace, MsgBoxStyle.Critical, "Alerta!")
        End Try


    End Sub

    Public Sub ObterLista2(ByVal nomearq As String)

        Dim frm As New FrmImportFornecedor

        frm.GroupBox1.Visible = True

        frm.ShowDialog()

        Try

            If frm.DialogResult = Forms.DialogResult.OK Then

                Dim Irazao As Integer = frm.TxtRazao.Text - 1
                Dim Ifantasia As Integer = frm.TxtFantasia.Text - 1
                Dim Icnpj As Integer = frm.TxtCNPJ.Text - 1
                Dim Iend As Integer = frm.TxtEndereco.Text - 1
                Dim Icontato As Integer = frm.TxtContato.Text - 1
                Dim Itel1 As Integer = frm.TxtTelefone1.Text - 1
                Dim Itel2 As Integer = frm.TxtTelefone2.Text - 1
                Dim Iemail As Integer = frm.TextEmail.Text - 1
                Dim codigo As Integer = 0

                Dim Razao As String = Nothing
                Dim fantasia As String = Nothing
                Dim CNPJ As String = Nothing
                Dim Endereco As String = Nothing
                Dim Contato As String = Nothing
                Dim Telefone As String = Nothing
                Dim Telefone2 As String = Nothing
                Dim Email As String = Nothing

                Dim contlinha() As String
                Dim linha As String
                Dim linhas() As String = IO.File.ReadAllLines(nomearq)

                Dim Separador As String = Nothing

                If frm.ChkPontoVirg.Checked = True Then
                    Separador = ";"
                End If
                If frm.ChkTAB.Checked = True Then
                    Separador = vbTab
                End If

                For Each linha In linhas
                    contlinha = linha.Split(Separador)
                    codigo = GerarCodigo("fornecedores")

                    If Irazao >= 0 Then
                        Razao = contlinha(Irazao)
                        'MsgBox("Razão ok")
                    End If
                    If Ifantasia >= 0 Then
                        fantasia = contlinha(Ifantasia)
                        'MsgBox("Fantasia ok")
                    End If
                    If Icnpj >= 0 Then
                        CNPJ = contlinha(Icnpj)
                        'MsgBox("CNPJ ok")
                    End If
                    If Iend >= 0 Then
                        Endereco = contlinha(Iend)
                        'MsgBox("Endereço ok")
                    End If
                    If Icontato >= 0 Then
                        Contato = contlinha(Icontato)
                        'MsgBox("Contato ok")
                    End If
                    If Itel1 >= 0 Then
                        Telefone = contlinha(Itel1)
                        'MsgBox("Telefone1 ok")
                    End If
                    If Itel2 >= 0 Then
                        Telefone2 = contlinha(Itel2)
                        'MsgBox("Telefone2 ok")
                    End If
                    If Iemail >= 0 Then
                        Email = contlinha(Iemail)
                        'MsgBox("E-mail ok")
                    End If


                    conexão.Close()
                    conexão.Open()
                    Dim sqlCom As String = "INSERT INTO fornecedores ([Codigo],[Razão Social],[Nome Fantasia],[CNPJ],[Endereço],[Contato],[Telefone],[Telefone 2],[E-mail]) VALUES ('" & codigo & "','" & Razao.Replace(",", ".") & "','" & fantasia.Replace(",", ".") & "','" & CNPJ.Replace(",", ".") & "','" & Endereco.Replace(",", ".") & "','" & Contato.Replace(",", ".") & "','" & Telefone.Replace(",", ".") & "','" & Telefone2.Replace(",", ".") & "','" & Email.Replace(",", ".") & "')"
                    Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                    Dim Ra As Integer = MyCommand.ExecuteNonQuery
                    conexão.Close()

                    Application.DoEvents()

                Next


            End If

            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message & "  -> " & ex.ToString)
        End Try

    End Sub

    Private Function GerarCodigo(ByVal nometabela As String) As Integer

        Dim i As Integer = 0

        Dim ole1 As String = "SELECT * FROM " & nometabela & ""
        Dim OleCom1 As New OleDbCommand(ole1, conexão)
        Dim oleAdapter1 As New OleDbDataAdapter(OleCom1)
        Dim ds1 As New DataSet()
        Dim dr As DataRow

        oleAdapter1.Fill(ds1, nometabela)
        Dim j As Integer = ds1.Tables(nometabela).Rows.Count
        'MsgBox("Numero de linhas" & j)

        If j = 0 Then
            i = i + 1
            'MsgBox("Identificou Num de linhas menor que: " & 1)
            GerarCodigo = i

        Else

            Do Until i > j
                i = i + 1

                'MsgBox("Lendo linha: " & i & " - de: " & j)
                For Each dr In ds1.Tables(nometabela).Rows
                    If dr.Item(0).ToString = i Then
                        'MsgBox("Existe!")
                        GoTo EXISTE
                    End If
                Next

                'MsgBox("Vai gerar: " & i)
                GerarCodigo = i
                Exit Do

EXISTE:
            Loop


        End If

        Return GerarCodigo
    End Function

    Private Function CalcPercentual(ByVal valor As Double, ByVal taxa As Double) As Double
        CalcPercentual = CDbl(taxa) * (valor / 100)
        Return CalcPercentual
    End Function

    Private Function Qtdes(ByVal valor As Double, ByVal material As String) As Double
        For Each dr As DataRow In MateriaisDS.Tables(0).Rows
            If dr.Item(0).ToString = material And dr.Item(4).ToString = "m2" Then
                Qtdes = CDbl(valor * 100) / CDbl(dr.Item(11))
            End If
        Next
        Return Qtdes
    End Function

    Public Sub ObterLista5(ByVal nomearq As String)

        Dim frm As New FrmUpdateProdutos
        frm.GroupBox1.Visible = True
        frm.ShowDialog()

        Dim dr As DataRow
        Dim Prss As Integer = 0
        Dim Percent As Integer = 0

        Dim Icodigo As Integer = frm.TxtCodigo.Text - 1
        Dim Idescricao As Integer = frm.TxtDescricao.Text - 1
        Dim Icategoria As Integer = frm.TxtCategoria.Text - 1
        Dim Ilinha As Integer = frm.TxtLinha.Text - 1
        Dim Iacabamento As Integer = frm.TxtAcabamento.Text - 1
        Dim Idescrdet As Integer = frm.TxtDescrDet.Text - 1
        Dim Iimagem As Integer = frm.TxtImagem.Text - 1

        Dim Imarkup As Integer = frm.txtMarkup.Text - 1
        Dim Incm As Integer = frm.txtNCM.Text - 1
        Dim Icest As Integer = frm.txtCEST.Text - 1
        Dim Iuncom As Integer = frm.txtUnComercial.Text - 1
        Dim Iean As Integer = frm.txtEAN.Text - 1
        Dim Ieantrib As Integer = frm.txtEANTrib.Text - 1
        Dim Icfopvenda As Integer = frm.txtCFOPVenda.Text - 1
        Dim Icfopfat As Integer = frm.txtCFOPFat.Text - 1
        Dim Icfoprem As Integer = frm.txtCFOPRem.Text - 1


        Dim Descricao2 As String = String.Empty
        Dim Categoria2 As String = String.Empty
        Dim Linha2 As String = String.Empty
        Dim Acabamento2 As String = String.Empty
        Dim Imagens2 As String = String.Empty
        Dim DescrDet2 As String = String.Empty
        Dim markup2 As String = 1
        Dim ncm2 As String = String.Empty
        Dim cest2 As String = String.Empty
        Dim uncom2 As String = String.Empty
        Dim ean2 As String = String.Empty
        Dim eantrib2 As String = String.Empty
        Dim cfopvenda2 As String = String.Empty
        Dim cfopfat2 As String = String.Empty
        Dim cfoprem2 As String = String.Empty

        Dim Codigo As String = " "
        Dim Acabamento As String = " "
        Dim Descricao As String = " "
        Dim Linha As String = " "
        Dim Categoria As String = " "
        Dim DescrDet As String = " "
        Dim Imagens As String = " "

        Dim markup As String = " "
        Dim ncm As String = " "
        Dim cest As String = " "
        Dim uncom As String = " "
        Dim ean As String = " "
        Dim eantrib As String = " "
        Dim cfopvenda As String = " "
        Dim cfopfat As String = " "
        Dim cfoprem As String = " "

        If frm.DialogResult = Forms.DialogResult.OK Then

            Select Case tipoarq
                Case 1
                    Dim conexao_Excel As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & nomearq & ";Extended Properties=Excel 12.0;"
                    Dim conx As New OleDbConnection(conexao_Excel)

                    Dim oleDbCom As String = "SELECT * FROM [" & nomeplanilha & "$]"
                    'MsgBox(oleDbCom)
                    Dim Comm_Excel As New OleDbCommand(oleDbCom, conx)
                    Dim da As New OleDbDataAdapter(Comm_Excel)
                    Dim dt As New DataSet()
                    da.Fill(dt, nomeplanilha)
                    Dim con As Integer = 0

                    Progbar.Visible = True
                    Progbar.Maximum = dt.Tables(nomeplanilha).Rows.Count
                    Progbar.Step = 1
                    Progbar.Value = 0

                    For Each dtr As DataRow In dt.Tables(nomeplanilha).Rows
                        LbRegistro.Text = "Registro: " & dtr.Item(Icodigo).ToString
                        'con = con + 1
                        'LbRegistro.Text = con & " Registros processados"
                        'LTrim(RTrim(dtr.Item(Idescrdet).ToString)) <> "" And LTrim(RTrim(dtr.Item(Icategoria).ToString)) <> ""
                        If Icodigo >= 0 Then

                            If Icodigo >= 0 Then
                                If IsDBNull(dtr.Item(Icodigo).ToString) Or LTrim(RTrim(dtr.Item(Icodigo).ToString)) = "" Then
                                    GoTo PROX0
                                Else
                                    Codigo = dtr.Item(Icodigo).ToString
                                End If
                                'MsgBox("Fantasia ok")
                            End If


                            If Idescricao >= 0 Then
                                If IsDBNull(dtr.Item(Idescricao).ToString) Then
                                    Descricao = " "
                                Else
                                    Descricao = dtr.Item(Idescricao).ToString
                                End If
                                'MsgBox("Fantasia ok")
                            End If

                            If Ilinha >= 0 Then
                                If IsDBNull(dtr.Item(Ilinha).ToString) Then
                                    'MsgBox("Um dos registros contem o campo código vazio! " & vbNewLine & "Não é possível adicionar um registro vazio")
                                    'GoTo PROX0
                                    Linha = " "
                                Else
                                    Linha = dtr.Item(Ilinha).ToString
                                End If
                                'MsgBox("Razão ok")
                            End If

                            If Iacabamento >= 0 Then
                                If IsDBNull(dtr.Item(Iacabamento).ToString) Then
                                    Acabamento = " "
                                Else
                                    Acabamento = dtr.Item(Iacabamento).ToString
                                End If
                                'MsgBox("CNPJ ok")
                            End If

                            If Icategoria >= 0 Then
                                If IsDBNull(dtr.Item(Icategoria).ToString) Then
                                    Categoria = " "
                                Else
                                    Categoria = dtr.Item(Icategoria).ToString
                                End If
                                'MsgBox("Endereço ok")
                            End If

                            If Idescrdet >= 0 Then
                                If IsDBNull(dtr.Item(Idescrdet).ToString) Then
                                    DescrDet = " "
                                Else
                                    DescrDet = dtr.Item(Idescrdet).ToString
                                End If
                                'MsgBox("E-mail ok")
                            End If


                            If Iimagem >= 0 Then

                                If frm.ChkDirImgs.Checked = True Then
                                    Imagens = frm.TxtDirImagens.Text & "\" & Codigo & frm.Imgs
                                    'MsgBox(Imagens)
                                End If

                                If IsDBNull(dtr.Item(Iimagem).ToString) Then
                                    Imagens = " "
                                Else
                                    Imagens = dtr.Item(Iimagem).ToString
                                End If
                                'MsgBox("E-mail ok")
                            Else
                                If frm.ChkDirImgs.Checked = True Then
                                    Imagens = frm.TxtDirImagens.Text & "\" & Codigo & frm.Imgs
                                    'MsgBox(Imagens)
                                End If
                            End If


                            If Imarkup >= 0 Then
                                If IsDBNull(dtr.Item(Imarkup).ToString) Then
                                    markup = 1
                                Else
                                    markup = dtr.Item(Imarkup).ToString
                                End If
                                'MsgBox("E-mail ok")
                            End If

                            If Incm >= 0 Then
                                If IsDBNull(dtr.Item(Incm).ToString) Then
                                    ncm = " "
                                Else
                                    ncm = dtr.Item(Incm).ToString
                                End If
                                'MsgBox("E-mail ok")
                            End If

                            If Icest >= 0 Then
                                If IsDBNull(dtr.Item(Icest).ToString) Then
                                    cest = " "
                                Else
                                    cest = dtr.Item(Icest).ToString
                                End If
                                'MsgBox("E-mail ok")
                            End If

                            If Iuncom >= 0 Then
                                If IsDBNull(dtr.Item(Iuncom).ToString) Then
                                    uncom = " "
                                Else
                                    uncom = dtr.Item(Iuncom).ToString
                                End If
                                'MsgBox("E-mail ok")
                            End If

                            If Iean >= 0 Then
                                If IsDBNull(dtr.Item(Iean).ToString) Then
                                    ean = " "
                                Else
                                    ean = dtr.Item(Iean).ToString
                                End If
                                'MsgBox("E-mail ok")
                            End If

                            If Ieantrib >= 0 Then
                                If IsDBNull(dtr.Item(Ieantrib).ToString) Then
                                    eantrib = " "
                                Else
                                    eantrib = dtr.Item(Ieantrib).ToString
                                End If
                                'MsgBox("E-mail ok")
                            End If

                            If Icfopvenda >= 0 Then
                                If IsDBNull(dtr.Item(Icfopvenda).ToString) Then
                                    cfopvenda = " "
                                Else
                                    cfopvenda = dtr.Item(Icfopvenda).ToString
                                End If
                                'MsgBox("E-mail ok")
                            End If

                            If Icfopfat >= 0 Then
                                If IsDBNull(dtr.Item(Icfopfat).ToString) Then
                                    cfopfat = " "
                                Else
                                    cfopfat = dtr.Item(Icfopfat).ToString
                                End If
                                'MsgBox("E-mail ok")
                            End If

                            If Icfoprem >= 0 Then
                                If IsDBNull(dtr.Item(Icfoprem).ToString) Then
                                    cfoprem = " "
                                Else
                                    cfoprem = dtr.Item(Icfoprem).ToString
                                End If
                                'MsgBox("E-mail ok")
                            End If

                            'MsgBox("Verificar se tem registro = " & Codigo)

                            'If GetRegistro(Codigo) = True Then
                            'MsgBox("Tem registro", MsgBoxStyle.Information)

                            'If Descricao = " " Then
                            '    Descricao = Descricao2
                            'End If
                            'If Categoria = " " Then
                            '    Categoria = Categoria2
                            'End If
                            'If Linha = " " Then
                            '    Linha = Linha2
                            'End If
                            'If Acabamento = " " Then
                            '    Acabamento = Acabamento2
                            'End If
                            'If Imagens = " " Then
                            '    Imagens = Imagens2
                            'End If
                            'If DescrDet = " " Then
                            '    DescrDet = DescrDet2
                            'End If


                            'If markup = " " Then
                            '    markup = markup2
                            'End If
                            'If ncm = " " Then
                            '    ncm = ncm2
                            'End If
                            'If cest = " " Then
                            '    cest = cest2
                            'End If
                            'If uncom = " " Then
                            '    uncom = uncom2
                            'End If
                            'If ean = " " Then
                            '    ean = ean2
                            'End If
                            'If eantrib = " " Then
                            '    eantrib = eantrib2
                            'End If
                            'If cfopvenda = " " Then
                            '    cfopvenda = cfopvenda2
                            'End If
                            'If cfopfat = " " Then
                            '    cfopfat = cfopfat2
                            'End If
                            'If cfoprem = " " Then
                            '    cfoprem = cfoprem2
                            'End If

                            'UpdateRegistro(Codigo, Descricao, Categoria, Acabamento, Linha, Imagens, DescrDet, markup, ncm, cest, uncom, ean, eantrib, cfopvenda, cfopfat, cfoprem)
                            'End If

                            Try
                                conexão.Close()
                                conexão.Open()
                                Dim sqlCom As String = "UPDATE produtos SET " & If(Idescricao >= 0, "[Descricao] = '" & Replace(Descricao, ",", ".") & "'", "") & If(Icategoria >= 0, ",", "") &
                                                        If(Icategoria >= 0, "[Categoria] = '" & Replace(Categoria, ",", ".") & "'", "") & If(Ilinha >= 0, ",", "") &
                                                        If(Ilinha >= 0, "[Linha] = '" & Replace(Linha, ",", ".") & "'", "") & If(Iacabamento >= 0, ",", "") &
                                                        If(Iacabamento >= 0, "[Acabamentos] = '" & Replace(Acabamento, ",", ".") & "'", "") & If(Idescrdet >= 0, ",", "") &
                                                        If(Idescrdet >= 0, "[DescDetalhada] = '" & Replace(DescrDet, ",", ".") & "'", "") & If(Iimagem >= 0, ",", "") &
                                                        If(Iimagem >= 0, "[Img] = '" & Replace(Imagens, ",", ".") & "'", "") & If(Imarkup >= 0, ",", "") &
                                                        If(Imarkup >= 0, "[Multiplicador] = " & Replace(markup, ",", ".") & "", "") & If(Incm >= 0, ",", "") &
                                                        If(Incm >= 0, "[NCM] = '" & Replace(ncm, ",", ".") & "'", "") & If(Icest >= 0, ",", "") &
                                                        If(Icest >= 0, "[CEST] = '" & Replace(cest, ",", ".") & "'", "") & If(Iuncom >= 0, ",", "") &
                                                        If(Iuncom >= 0, "[UnidCom] = '" & Replace(uncom, ",", ".") & "'", "") & If(Iean >= 0, ",", "") &
                                                        If(Iean >= 0, "[EAN] = '" & Replace(ean, ",", ".") & "'", "") & If(Ieantrib >= 0, ",", "") &
                                                        If(Ieantrib >= 0, "[EANTrib] = '" & Replace(eantrib, ",", ".") & "'", "") & If(Icfopvenda >= 0, ",", "") &
                                                        If(Icfopvenda >= 0, "[CFOP1] = '" & Replace(cfopvenda, ",", ".") & "'", "") & If(Icfopfat >= 0, ",", "") &
                                                        If(Icfopfat >= 0, "[CFOP2] = '" & Replace(cfopfat, ",", ".") & "'", "") & If(Icfoprem >= 0, ",", "") &
                                                        If(Icfoprem >= 0, "[CFOP3] = '" & Replace(cfoprem, ",", ".") & "' ", " ") &
                                                        " WHERE [Codigo] = '" & Codigo & "'"
                                'MsgBox(sqlCom)
                                Dim MyCommand As New OleDbCommand(sqlCom.Replace("SET ,", "SET "), conexão)
                                Dim Ra As Integer = MyCommand.ExecuteNonQuery
                                conexão.Close()
                            Catch ex As Exception
                                MsgBox("Erro em Update: " & ex.Message &
                                       "UPDATE produtos SET " & If(Idescricao >= 0, "[Descricao] = '" & Replace(Descricao, ",", ".") & "'", "") & If(Icategoria >= 0, ",", "") &
                                                        If(Icategoria >= 0, "[Categoria] = '" & Replace(Categoria, ",", ".") & "'", "") & If(Ilinha >= 0, ",", "") &
                                                        If(Ilinha >= 0, "[Linha] = '" & Replace(Linha, ",", ".") & "'", "") & If(Iacabamento >= 0, ",", "") &
                                                        If(Iacabamento >= 0, "[Acabamentos] = '" & Replace(Acabamento, ",", ".") & "'", "") & If(Idescrdet >= 0, ",", "") &
                                                        If(Idescrdet >= 0, "[DescDetalhada] = '" & Replace(DescrDet, ",", ".") & "'", "") & If(Iimagem >= 0, ",", "") &
                                                        If(Iimagem >= 0, "[Img] = '" & Replace(Imagens, ",", ".") & "'", "") & If(Imarkup >= 0, ",", "") &
                                                        If(Imarkup >= 0, "[Multiplicador] = " & Replace(markup, ",", ".") & "", "") & If(Incm >= 0, ",", "") &
                                                        If(Incm >= 0, "[NCM] = '" & Replace(ncm, ",", ".") & "'", "") & If(Icest >= 0, ",", "") &
                                                        If(Icest >= 0, "[CEST] = '" & Replace(cest, ",", ".") & "'", "") & If(Iuncom >= 0, ",", "") &
                                                        If(Iuncom >= 0, "[UnidCom] = '" & Replace(uncom, ",", ".") & "'", "") & If(Iean >= 0, ",", "") &
                                                        If(Iean >= 0, "[EAN] = '" & Replace(ean, ",", ".") & "'", "") & If(Ieantrib >= 0, ",", "") &
                                                        If(Ieantrib >= 0, "[EANTrib] = '" & Replace(eantrib, ",", ".") & "'", "") & If(Icfopvenda >= 0, ",", "") &
                                                        If(Icfopvenda >= 0, "[CFOP1] = '" & Replace(cfopvenda, ",", ".") & "'", "") & If(Icfopfat >= 0, ",", "") &
                                                        If(Icfopfat >= 0, "[CFOP2] = '" & Replace(cfopfat, ",", ".") & "'", "") & If(Icfoprem >= 0, ",", "") &
                                                        If(Icfoprem >= 0, "[CFOP3] = '" & Replace(cfoprem, ",", ".") & "' ", " ") &
                                                        " WHERE [Codigo] = '" & Codigo & "'")
                                Try
                                    conexão.Close()
                                    conexão.Open()
                                    Dim sqlCom As String = "INSERT INTO produtos (" & If(Icodigo >= 0, "[Codigo]", "") & If(Idescricao >= 0, ",", "") &
                                                            If(Idescricao >= 0, "[Descricao]", "") & If(Icategoria >= 0, ",", "") &
                                                            If(Icategoria >= 0, "[Categoria]", "") & If(Ilinha >= 0, ",", "") &
                                                            If(Ilinha >= 0, "[Linha]", "") & If(Iacabamento >= 0, ",", "") &
                                                            If(Iacabamento >= 0, "[Acabamentos]", "") & If(Idescrdet >= 0, ",", "") &
                                                            If(Idescrdet >= 0, "[DescDetalhada]", "") & If(Iimagem >= 0, ",", "") &
                                                            If(Iimagem >= 0, "[Img]", "") & If(Imarkup >= 0 Or Incm >= 0, ",", "") &
                                                            If(Imarkup >= 0, "[Multiplicador]", "") & If(Incm >= 0, ",", "") &
                                                            If(Incm >= 0, "[NCM]", "") & If(Icest >= 0, ",", "") &
                                                            If(Icest >= 0, "[CEST]", "") & If(Iuncom >= 0, ",", "") &
                                                            If(Iuncom >= 0, "[UnidCom]", "") & If(Iean >= 0, ",", "") &
                                                            If(Iean >= 0, "[EAN]", "") & If(Ieantrib >= 0, ",", "") &
                                                            If(Ieantrib >= 0, "[EANTrib]", "") & If(Icfopvenda >= 0, ",", "") &
                                                            If(Icfopvenda >= 0, "[CFOP1]", "") & If(Icfopfat >= 0, ",", "") &
                                                            If(Icfopfat >= 0, "[CFOP2]", "") & If(Icfoprem >= 0, ",", "") &
                                                            If(Icfoprem >= 0, "[CFOP3]", "") & ") VALUES (" &
                                                            If(Icodigo >= 0, "'" & Replace(Codigo, ",", ".") & "'", "") & If(Idescricao >= 0, ",", "") &
                                                            If(Idescricao >= 0, "'" & Replace(Descricao, ",", ".") & "'", "") & If(Icategoria >= 0, ",", "") &
                                                            If(Icategoria >= 0, "'" & Replace(Categoria, ",", ".") & "'", "") & If(Ilinha >= 0, ",", "") &
                                                            If(Ilinha >= 0, "'" & Replace(Linha, ",", ".") & "'", "") & If(Iacabamento >= 0, ",", "") &
                                                            If(Iacabamento >= 0, "'" & Replace(Acabamento, ",", ".") & "'", "") & If(Idescrdet >= 0, ",", "") &
                                                            If(Idescrdet >= 0, "'" & Replace(DescrDet, ",", ".") & "'", "") & If(Iimagem >= 0, ",", "") &
                                                            If(Iimagem >= 0, "'" & Replace(Imagens, ",", ".") & "'", "") & If(Imarkup >= 0, ",", "") &
                                                            If(Imarkup >= 0, "" & Replace(markup, ",", ".") & "", "") & If(Incm >= 0, ",", "") &
                                                            If(Incm >= 0, "'" & Replace(ncm, ",", ".") & "'", "") & If(Icest >= 0, ",", "") &
                                                            If(Icest >= 0, "'" & Replace(cest, ",", ".") & "'", "") & If(Iuncom >= 0, ",", "") &
                                                            If(Iuncom >= 0, "'" & Replace(uncom, ",", ".") & "'", "") & If(Iean >= 0, ",", "") &
                                                            If(Iean >= 0, "'" & Replace(ean, ",", ".") & "'", "") & If(Ieantrib >= 0, ",", "") &
                                                            If(Ieantrib >= 0, "'" & Replace(eantrib, ",", ".") & "'", "") & If(Icfopvenda >= 0, ",", "") &
                                                            If(Icfopvenda >= 0, "'" & Replace(cfopvenda, ",", ".") & "'", "") & If(Icfopfat >= 0, ",", "") &
                                                            If(Icfopfat >= 0, "'" & Replace(cfopfat, ",", ".") & "'", "") & If(Icfoprem >= 0, ",", "") &
                                                            If(Icfoprem >= 0, "'" & Replace(cfoprem, ",", ".") & "')", ")")
                                    'MsgBox(sqlCom)
                                    Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                                    Dim Ra As Integer = MyCommand.ExecuteNonQuery
                                    conexão.Close()
                                Catch ex1 As Exception
                                    MsgBox("Erro ao atualizar: " & vbNewLine &
                                                              "INSERT [Descricao] = '" & Replace(Descricao, ",", ".") & "'," & vbNewLine &
                                                            "[Categoria] = '" & Replace(Categoria, ",", ".") & "'," & vbNewLine &
                                                            "[Linha] = '" & Replace(Linha, ",", ".") & "'," & vbNewLine &
                                                            "[Acabamentos] = '" & Replace(Acabamento, ",", ".") & "'," & vbNewLine &
                                                            "[DescDetalhada] = '" & Replace(DescrDet, ",", ".") & "'," & vbNewLine &
                                                            "[Img] = '" & Replace(Imagens, ",", ".") & "'," & vbNewLine &
                                                            "[Multiplicador] = " & Replace(markup, ",", ".") & "," & vbNewLine &
                                                            "[NCM] = '" & Replace(ncm, ",", ".") & "'," & vbNewLine &
                                                            "[CEST] = '" & Replace(cest, ",", ".") & "'," & vbNewLine &
                                                            "[UnidCom] = '" & Replace(uncom, ",", ".") & "'," & vbNewLine &
                                                            "[EAN] = '" & Replace(ean, ",", ".") & "'," & vbNewLine &
                                                            "[EANTrib] = '" & Replace(eantrib, ",", ".") & "'," & vbNewLine &
                                                            "[CFOP1] = '" & Replace(cfopvenda, ",", ".") & "'," & vbNewLine &
                                                            "[CFOP2] = '" & Replace(cfopfat, ",", ".") & "'," & vbNewLine &
                                                            "[CFOP3] = '" & Replace(cfoprem, ",", ".") & "'" & vbNewLine &
                                                             ex1.Message)
                                    conexão.Close()
                                End Try
                            End Try



PROX0:
                            Application.DoEvents()
                            Prss = Prss + 1
                            Progbar.Value = Prss
                            Percent = (Prss * 100) / Progbar.Maximum
                            LbPercent.Text = Percent & " %"

                        End If

                    Next

            End Select

        End If



    End Sub

    Private Sub UpdateItem(cod As String, col As String, valor As String)

        Try
            conexão.Close()
            conexão.Open()
            Dim sqlCom As String = "UPDATE produtos SET [" & col & "] = '" & Replace(valor, ",", ".") & "'," & _
                   "WHERE [Codigo] = '" & cod & "'"
            'MsgBox(sqlCom)
            Dim MyCommand As New OleDbCommand(sqlCom, conexão)
            Dim Ra As Integer = MyCommand.ExecuteNonQuery
            conexão.Close()
        Catch ex As Exception
            MsgBox("Erro ao atualizar: " & vbNewLine & _
                                      "[" & col & "] = '" & Replace(valor, ",", ".") & "'," & vbNewLine & _
                                      "WHERE [Codigo] = '" & cod & "'" & vbNewLine & _
                                     ex.Message)
            conexão.Close()
        End Try

    End Sub


    Public Sub ObterLista6(id As Integer, novachave As Double, modo As Integer)

        Me.Label1.Text = "Atualizando preços..."

        Dim Percent As Integer = 0
        Dim Prss As Integer = 0

        Dim Codigo As String

        Dim Custo As Double = 0
        Dim Bruto As Double = 0
        Dim TotalBruto As Double = 0
        Dim Liquido As Double = 0

        Dim mMultiplicador As Double = 1
        Dim mImposto As Double = 0
        Dim mComissao As Double = 0
        Dim mAdicional As Double = 0

        Dim Tributos As Double = 0
        Dim LucroReal As Double = 0
        Dim LucroPercent As Double = 0


        Dim Vcomissao As Double = 0
        Dim Vimposto As Double = 0
        Dim Vadicional As Double = 0
        Dim TotalTributos As Double = 0
        'MsgBox(c)

        Progbar.Visible = True
        Progbar.Maximum = ProdutosDS.Tables(0).Rows.Count
        Progbar.Step = 1
        Progbar.Value = 0

        conexão.Close()
        conexão.Open()

        LbRegistro.Text = "Aplicando chave aos componentes ..."
        Prss = Prss
        Progbar.Value = Prss
        Percent = (Prss * 100) / Progbar.Maximum
        LbPercent.Text = Percent & " %"

        Application.DoEvents()

        conexão.Close()
        conexão.Open()

        For Each dt In ProdutosDS.Tables(0).Rows
            'Dim ListaComponentes = New List(Of Componentes)
            Dim ComponentesTxt As String = ""
            Dim vcusto As Double = 0
            Dim vtotal As Double = 0

            If Not IsDBNull(dt(11)) Then
                Dim Itens() = dt(11).ToString.Split("&&")
                If Itens.Length > 0 Then
                    For i = 0 To Itens.Length - 1
                        Dim vl() = Itens(i).Split(";")
                        If vl.Length > 1 Then
                            Dim cp = New Componentes With {
                                .Codigo = vl(0),
                                .Descricao = vl(1),
                                .Qt = vl(2),
                                .Valor = vl(3),
                                .TotalCusto = vl(4),
                                .TotalBruto = vl(5),
                                .Categoria = vl(6)
                            }

                            cp.TotalCusto = Math.Round(cp.TotalCusto, 2)
                            cp.TotalBruto = Math.Round(cp.TotalCusto * nchave, 2)

                            vcusto += cp.TotalCusto
                            vtotal += cp.TotalBruto

                            Dim StrComp As String = ""
                            If i = 0 Then
                                StrComp = cp.Codigo & ";" & cp.Descricao & ";" & cp.Qt & ";" & cp.Valor & ";" & cp.TotalCusto & ";" & cp.TotalBruto & ";" & cp.Categoria
                            Else
                                StrComp = "&&" & cp.Codigo & ";" & cp.Descricao & ";" & cp.Qt & ";" & cp.Valor & ";" & cp.TotalCusto & ";" & cp.TotalBruto & ";" & cp.Categoria
                            End If
                            ComponentesTxt += StrComp
                        End If
                    Next
                End If
            End If

            Custo = vcusto
            Bruto = vtotal
            mMultiplicador = dt(6)
            mComissao = dt(9)
            mImposto = dt(8)
            mAdicional = dt(10)

            If mComissao = 0 Then
                mComissao = comissao
            End If

            If mImposto = 0 Then
                mImposto = imposto
            End If

            If mAdicional = 0 Then
                mAdicional = adicional
            End If

PROXIMO:

            TotalBruto = Math.Round(Bruto * mMultiplicador, 2)
            Liquido = TotalBruto

            Vimposto = Math.Round(CalcPercentual(Liquido, mImposto), 2)
            Vcomissao = Math.Round(CalcPercentual(Liquido, mComissao), 2)
            Vadicional = Math.Round(CalcPercentual(Liquido, mAdicional), 2)

            'MsgBox("Etapa: colocar valores nos labels")

            TotalTributos = Math.Round(Custo + Vcomissao + Vimposto + Vadicional, 2)

            LucroReal = Liquido - TotalTributos
            If LucroReal > 0 Then
                LucroPercent = Math.Round((LucroReal / Liquido) * 100, 2)
            Else
                LucroPercent = 0
            End If

            Dim sqlCom As String = "UPDATE produtos SET [Custo]=" & Replace(Custo, ",", ".") &
                ",[Bruto]=" & Replace(Bruto, ",", ".") & ",[Multiplicador]=" & Replace(mMultiplicador, ",", ".") &
                ",[Liquido]=" & Replace(Liquido, ",", ".") & ",[Componentes]='" & ComponentesTxt &
                "',[Tributos]=" & Replace(TotalTributos, ",", ".") & ",[LucroReal]=" & Replace(LucroReal, ",", ".") & ",[LucroPercent]=" & Replace(LucroPercent, ",", ".") &
                " WHERE [Codigo]='" & dt(0) & "'"

            'MsgBox(sqlCom & vbNewLine & conexão.ConnectionString)
            Dim MyCommand As New OleDbCommand(sqlCom, conexão)
            Dim Ra As Integer = MyCommand.ExecuteNonQuery()

            LbRegistro.Text = "Aplicando ao Registro: " & dt(0)
            Prss = Prss + 1
            Progbar.Value = Prss
            Percent = (Prss * 100) / Progbar.Maximum
            LbPercent.Text = Percent & " %"

            Application.DoEvents()
        Next
        conexão.Close()

        MsgBox("Os preços dos produtos foram atualizados com sucesso!", MsgBoxStyle.Information)
        Me.Close()

    End Sub

    Public Sub ObterLista7()

        Me.Label1.Text = "Atualizando preços..."

        Dim Percent As Integer = 0
        Dim Prss As Integer = 0

        Dim Codigo As String

        Dim Custo As Double = 0
        Dim Bruto As Double = 0
        Dim TotalBruto As Double = 0
        Dim Liquido As Double = 0

        Dim mMultiplicador As Double = 1
        Dim mImposto As Double = 0
        Dim mComissao As Double = 0
        Dim mAdicional As Double = 0

        Dim Tributos As Double = 0
        Dim LucroReal As Double = 0
        Dim LucroPercent As Double = 0


        Dim Vcomissao As Double = 0
        Dim Vimposto As Double = 0
        Dim Vadicional As Double = 0
        Dim TotalTributos As Double = 0
        'MsgBox(c)
        ListaMaterial = New List(Of Material)
        For Each dm In MateriaisDS.Tables(0).Rows
            Dim NMat = New Material With {
                .Codigo = dm(0),
                .Valor = dm(8)
            }
            ListaMaterial.Add(NMat)
            Application.DoEvents()
        Next

        ListaCategorias = New List(Of Categoria)
        For Each dc In CategoriasDS.Tables(0).Rows
            Dim NCat = New Categoria With {
                .Id = dc(0),
                .Markup = dc(3)
            }
            ListaCategorias.Add(NCat)
            Application.DoEvents()
        Next

        Progbar.Visible = True
        Progbar.Maximum = ProdutosDS.Tables(0).Rows.Count
        Progbar.Step = 1
        Progbar.Value = 0

        conexão.Close()
        conexão.Open()

        LbRegistro.Text = "Aplicando chave aos componentes ..."
        Prss = Prss
        Progbar.Value = Prss
        Percent = (Prss * 100) / Progbar.Maximum
        LbPercent.Text = Percent & " %"

        Application.DoEvents()

        conexão.Close()
        conexão.Open()


        For Each dt In ProdutosDS.Tables(0).Rows
            'Dim ListaComponentes = New List(Of Componentes)
            Dim ComponentesTxt As String = ""
            Dim vcusto As Double = 0
            Dim vtotal As Double = 0

            If Not IsDBNull(dt(11)) Then
                Dim Itens() = dt(11).ToString.Split("&&")
                If Itens.Length > 0 Then
                    For i = 0 To Itens.Length - 1
                        Dim vl() = Itens(i).Split(";")
                        If vl.Length > 1 Then
                            Dim cp = New Componentes With {
                                .Codigo = vl(0),
                                .Descricao = vl(1),
                                .Qt = vl(2),
                                .Valor = vl(3),
                                .TotalCusto = vl(4),
                                .TotalBruto = vl(5),
                                .Categoria = vl(6)
                            }
                            Dim gMat = ListaMaterial.Find(Function(c) c.Codigo = cp.Codigo)
                            If Not IsNothing(gMat) Then
                                cp.Valor = gMat.Valor
                            End If

                            cp.TotalCusto = Math.Round(cp.Valor * cp.Qt, 2)

                            Dim gCat = ListaCategorias.Find(Function(c) c.Id = cp.Categoria)
                            If Not IsNothing(gCat) Then
                                cp.TotalBruto = Math.Round(cp.TotalCusto * gCat.Markup, 2)
                            End If

                            vcusto += Math.Round(cp.TotalCusto, 2)
                            vtotal += Math.Round(cp.TotalBruto, 2)

                            Dim StrComp As String = ""
                            If i = 0 Then
                                StrComp = cp.Codigo & ";" & cp.Descricao & ";" & cp.Qt & ";" & cp.Valor & ";" & cp.TotalCusto & ";" & cp.TotalBruto & ";" & cp.Categoria
                            Else
                                StrComp = "&&" & cp.Codigo & ";" & cp.Descricao & ";" & cp.Qt & ";" & cp.Valor & ";" & cp.TotalCusto & ";" & cp.TotalBruto & ";" & cp.Categoria
                            End If
                            ComponentesTxt += StrComp
                        End If
                    Next
                End If
            End If

            Custo = vcusto
            Bruto = vtotal
            mMultiplicador = dt(6)
            mComissao = dt(9)
            mImposto = dt(8)
            mAdicional = dt(10)

            If mComissao = 0 Then
                mComissao = comissao
            End If

            If mImposto = 0 Then
                mImposto = imposto
            End If

            If mAdicional = 0 Then
                mAdicional = adicional
            End If

PROXIMO:

            TotalBruto = Math.Round(Bruto * mMultiplicador, 2)
            Liquido = TotalBruto

            Vimposto = Math.Round(CalcPercentual(Liquido, mImposto), 2)
            Vcomissao = Math.Round(CalcPercentual(Liquido, mComissao), 2)
            Vadicional = Math.Round(CalcPercentual(Liquido, mAdicional), 2)

            'MsgBox("Etapa: colocar valores nos labels")

            TotalTributos = Math.Round(Custo + Vcomissao + Vimposto + Vadicional, 2)

            LucroReal = Liquido - TotalTributos
            If LucroReal > 0 Then
                LucroPercent = Math.Round((LucroReal / Liquido) * 100, 2)
            Else
                LucroPercent = 0
            End If

            Dim sqlCom As String = "UPDATE produtos SET [Custo]=" & Replace(Custo, ",", ".") &
                ",[Bruto]=" & Replace(Bruto, ",", ".") & ",[Multiplicador]=" & Replace(mMultiplicador, ",", ".") &
                ",[Liquido]=" & Replace(Liquido, ",", ".") & ",[Componentes]='" & ComponentesTxt &
                "',[Tributos]=" & Replace(TotalTributos, ",", ".") & ",[LucroReal]=" & Replace(LucroReal, ",", ".") & ",[LucroPercent]=" & Replace(LucroPercent, ",", ".") &
                " WHERE [Codigo]='" & dt(0) & "'"

            'MsgBox(sqlCom & vbNewLine & conexão.ConnectionString)
            Dim MyCommand As New OleDbCommand(sqlCom, conexão)
            Dim Ra As Integer = MyCommand.ExecuteNonQuery()

            LbRegistro.Text = "Aplicando ao Registro: " & dt(0)
            Prss = Prss + 1
            Progbar.Value = Prss
            Percent = (Prss * 100) / Progbar.Maximum
            LbPercent.Text = Percent & " %"

            Application.DoEvents()
        Next
        conexão.Close()

        MsgBox("Os preços dos produtos foram atualizados com sucesso!", MsgBoxStyle.Information)
        Me.Close()

    End Sub


End Class
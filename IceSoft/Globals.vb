#Region "Programa"
'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana



#End Region

Imports System.IO
Imports System.Data.OleDb

Module Globals

    Public dbase As String = dblocal(My.Application.Info.DirectoryPath & "\database.dat")
    Public ConnString As String = "Provider=Microsoft.ACE.OleDb.12.0; Data Source=" & dbase & ""
    Public conexão As New OleDbConnection(ConnString)

    Public Lista(,) As String

    Public xres As String = My.Application.Info.DirectoryPath & "\xres\"
    Public pedidos As String = My.Application.Info.DirectoryPath & "\pedidos\"
    Public DirImg As String = My.Application.Info.DirectoryPath & "\imgs\"

    Public ProductName As String = "IceSoft"
    Public CopyRight As String = "Developed by Rafael Tavares"
    Public DescriptionSys As String = "Sistema de Cadastro e Vendas de sorvetes"
    Public Licenca As String
    Public Ativado As Boolean = False

    Public Usuario As String
    Public Privilegios As String
    Public Data As String

    Public MdlVersao As String = "[IceSoft V.1.0]"
    Public MdlFimArq As String = "[EndFile]"

    Public SP As String = "="
    Public MdlPedido As String = "[Pedido]"
    Public MdlData As String = "[Data]"
    Public MdlVendedor As String = "[Vendedor]"
    Public MdlOrdem As String = "[Ordem]"
    Public MdlNfe As String = "[Nfe]"

    Public MdlCodigoCliente As String = "[CodCliente]"

    Public MdlNomeCliente As String = "[NomeCliente]"
    Public MdlFantasia As String = "[Fantasia]"
    Public MdlSocio As String = "[Socio]"
    Public MdlCnpj As String = "[Cnpj]"
    Public MdlIe As String = "[Ie]"
    Public MdlPais As String = "[Pais]"

    Public MdlContato As String = "[Contato]"
    Public MdlTel As String = "[Telefone]"
    Public MdlEmail As String = "[Email]"

    Public MdlTipoEnd As String = "[TipoEnd]"
    Public MdlEndereco As String = "[Endereco]"
    Public MdlNumero As String = "[Numero]"
    Public MdlBairro As String = "[Bairro]"
    Public MdlCidade As String = "[Cidade]"
    Public MdlUF As String = "[UF]"
    Public MdlCep As String = "[Cep]"

    Public MdlEndereco2 As String = "[Endereco2]"
    Public MdlNumero2 As String = "[Numero2]"
    Public MdlBairro2 As String = "[Bairro2]"
    Public MdlCidade2 As String = "[Cidade2]"
    Public MdlUF2 As String = "[UF2]"
    Public MdlCep2 As String = "[Cep2]"

    Public MdlEndereco3 As String = "[Endereco3]"
    Public MdlNumero3 As String = "[Numero3]"
    Public MdlBairro3 As String = "[Bairro3]"
    Public MdlCidade3 As String = "[Cidade3]"
    Public MdlUF3 As String = "[UF3]"
    Public MdlCep3 As String = "[Cep3]"

    Public MdlPecas As String = "[Pecas]"

    Public MdlFrete As String = "[Frete]"
    Public MdlDesconto As String = "[Desconto]"
    Public MdlDescPercent As String = "[Desc%]"
    Public MdlValor As String = "[Valor]"

    Public MdlObs As String = "[Obs]"
    Public MdlObsPedido As String = "[ObsPedido]"

    Public MdlAlteracao As String = "[Alteracao]"

    Public printpages As Integer = 1
    Public ApRun As Boolean = True

    'Public ImgList As New ImageList
    Public mm As Image

    Public Varqped As String
    Public Varquivo(,) As String
    Public VarquivoNfe(,) As String
    Public Varqclient() As String
    Public Varqendereco() As String
    Public Varqendereco2() As String
    Public Varqendereco3() As String
    Public Varqcontato() As String
    Public Varqobs As String
    Public Varqempresa() As String
    Public Varqsecoes() As String

    Public MainInstance As TelaPrincipal
    Public LoginInstance As TelaLogin


    Public razao As String = ""
    Public cnpj As String = ""
    Public tel1 As String = ""
    Public tel2 As String = ""
    Public email As String = ""
    Public endereco As String = ""
    Public numero As String = ""
    Public cep As String = ""
    Public logo As String = ""
    Public fantasia As String = ""
    Public bairro As String = ""
    Public complemento As String = ""
    Public numseq As Integer = 0
    Public pais As String = ""
    Public uf As String = ""
    Public municipio As String = ""

    Public imposto As Single = 0.0
    Public frete As Single = 0.0
    Public montagem As Single = 0.0
    Public comissao As Single = 0.0
    Public rt As Single = 0.0
    Public adicional As Single = 0.0
    Public desconto As Single = 0.0
    Public markup As Single = 0.0
    Public cabecalho As String = ""
    Public obs As String = ""
    Public iniciais As String = ""

    Public ListaProdutos As List(Of Produto)


    Public Function FornecedoresDS() As DataSet

        Dim ole As String = "SELECT * FROM fornecedores"
        Dim OleCom As New OleDbCommand(ole, conexão)
        Dim oleAdapter As New OleDbDataAdapter(OleCom)
        Dim ds As New DataSet()
        oleAdapter.Fill(ds)

        Return ds
    End Function

    Public Function MateriaisDS() As DataSet

        Dim ole As String = "SELECT * FROM materiaprima"
        Dim OleCom As New OleDbCommand(ole, conexão)
        Dim oleAdapter As New OleDbDataAdapter(OleCom)
        Dim ds As New DataSet()
        oleAdapter.Fill(ds)

        Return ds
    End Function

    Public Function ProdutosDS() As DataSet

        Dim ole As String = "SELECT * FROM produtos"
        Dim OleCom As New OleDbCommand(ole, conexão)
        Dim oleAdapter As New OleDbDataAdapter(OleCom)
        Dim ds As New DataSet()
        oleAdapter.Fill(ds)

        Return ds
    End Function

    Public Function CategoriasProdutosDS() As DataSet

        Dim ole1 As String = "SELECT * FROM categoria_produtos"
        Dim OleCom1 As New OleDbCommand(ole1, conexão)
        Dim oleAdapter1 As New OleDbDataAdapter(OleCom1)
        Dim ds1 As New DataSet()
        oleAdapter1.Fill(ds1)

        Return ds1
    End Function

    Public Function UsuariosDS() As DataSet

        Dim ole As String = "SELECT * FROM usuarios"
        Dim OleCom As New OleDbCommand(ole, conexão)
        Dim oleAdapter As New OleDbDataAdapter(OleCom)
        Dim ds As New DataSet()
        oleAdapter.Fill(ds)

        Return ds
    End Function

    Public Function ClientesDS() As DataSet

        Dim ole As String = "SELECT * FROM clientes"
        Dim OleCom As New OleDbCommand(ole, conexão)
        Dim oleAdapter As New OleDbDataAdapter(OleCom)
        Dim ds As New DataSet()
        oleAdapter.Fill(ds)

        Return ds
    End Function

    Public Function CategoriasDS() As DataSet

        Dim ole As String = "SELECT * FROM categorias"
        Dim OleCom As New OleDbCommand(ole, conexão)
        Dim oleAdapter As New OleDbDataAdapter(OleCom)
        Dim ds As New DataSet()
        oleAdapter.Fill(ds)

        Return ds
    End Function

    Public Function PedidosDS() As DataSet

        Dim ole As String = "SELECT * FROM pedidos ORDER BY ID ASC"
        Dim OleCom As New OleDbCommand(ole, conexão)
        Dim oleAdapter As New OleDbDataAdapter(OleCom)
        Dim ds As New DataSet()
        oleAdapter.Fill(ds)

        Return ds
    End Function

    Public Function ConfigDS() As DataSet

        Dim ole As String = "SELECT * FROM config"
        Dim OleCom As New OleDbCommand(ole, conexão)
        Dim oleAdapter As New OleDbDataAdapter(OleCom)
        Dim ds As New DataSet()
        oleAdapter.Fill(ds)

        Return ds
    End Function


    Public Function dblocal(ByVal arquivo As String) As String

        If IO.File.Exists(arquivo) Then
            Dim sr As New StreamReader(arquivo)
            Dim loc As String = Trim(sr.ReadToEnd().Replace(Chr(10), "").Replace(vbCr, "")) : sr.Close()

            Dim tmp As String = loc
            If Not loc.Contains("\") Then
                tmp = My.Application.Info.DirectoryPath & "\" & loc
            End If

            Return loc
        Else
            Return My.Application.Info.DirectoryPath & "\cadastro.accdb"
        End If

    End Function

    Public Function VerificaUser(ByVal nome As String) As String
        VerificaUser = Nothing

        For Each dr As DataRow In UsuariosDS.Tables(0).Rows
            If dr.Item(0).ToString() = nome Then
                VerificaUser = dr.Item(2).ToString
            End If
        Next
        Return VerificaUser
    End Function

    Public Function GetConfig(cod As String) As String
        GetConfig = ""

        conexão.Close()
        conexão.Open()
        Dim ole As String = "SELECT * FROM confignfe WHERE [Codigo]='" & cod & "'"
        Dim OleCom As OleDbCommand = conexão.CreateCommand
        Dim reader As OleDbDataReader

        Try
            OleCom.CommandText = ole
            reader = OleCom.ExecuteReader()
            Application.DoEvents()
            If reader.Read Then
                GetConfig = reader(1).ToString
                'MsgBox(" Item: " & cod & " - Valor obtido: " & GetConfig)
                conexão.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try

        Return GetConfig
    End Function

    Public Function GetConfig2(cod As String) As String
        GetConfig2 = ""

        conexão.Close()
        conexão.Open()
        Dim ole As String = "SELECT * FROM config WHERE [Código]='" & cod & "'"
        Dim OleCom As OleDbCommand = conexão.CreateCommand
        Dim reader As OleDbDataReader

        Try
            OleCom.CommandText = ole
            reader = OleCom.ExecuteReader()
            Application.DoEvents()
            If reader.Read Then
                GetConfig2 = reader(1).ToString
                'MsgBox(" Item: " & cod & " - Valor obtido: " & GetConfig)
                conexão.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try

        Return GetConfig2
    End Function

    Public Function GetProduto(cod As String, valor As String) As String
        GetProduto = ""

        conexão.Close()
        conexão.Open()
        Dim ole As String = "SELECT * FROM tabela_produtos WHERE [Codigo]='" & cod & "'"
        Dim OleCom As OleDbCommand = conexão.CreateCommand
        Dim reader As OleDbDataReader

        Try
            OleCom.CommandText = ole
            reader = OleCom.ExecuteReader()
            Application.DoEvents()
            If reader.Read() Then

                If valor = "Codigo" Then
                    GetProduto = reader(0).ToString
                End If

                If valor = "Bruto_Mult" Then
                    GetProduto = reader(9).ToString
                End If

                If valor = "NCM" Then
                    GetProduto = reader(22).ToString
                End If

                If valor = "CEST" Then
                    GetProduto = reader(23).ToString
                End If
                If valor = "UnidCom" Then
                    GetProduto = reader(24).ToString
                End If

                If valor = "EAN" Then
                    GetProduto = reader(25).ToString
                End If

                If valor = "EANTrib" Then
                    GetProduto = reader(26).ToString
                End If

                If valor = "ProdEsp" Then
                    GetProduto = reader(27).ToString
                End If

                If valor = "CFOP1" Then
                    GetProduto = reader(28).ToString
                End If

                If valor = "Descricao" Then
                    GetProduto = reader(1).ToString
                End If

                'MsgBox(" Item: " & cod & " - Valor obtido: " & GetConfig)
                conexão.Close()
            End If

        Catch ex As Exception
            GetProduto = ""
            conexão.Close()
            'MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try

        Return GetProduto
    End Function

    Public Function GetProduto2(cod As String, valor As Integer) As String
        GetProduto2 = If(valor = 8, 1, "")

        'Select Case conexão.State
        '    Case ConnectionState.Closed
        '        conexão.Open()
        'End Select

        Dim ole As String = "SELECT * FROM produtos WHERE [Codigo]='" & cod & "'"
        'Dim OleCom As OleDbCommand = conexão.CreateCommand
        'Dim reader As OleDbDataReader
        Dim OleCom As New OleDbCommand(ole, conexão)
        Dim oleAdapter As New OleDbDataAdapter(OleCom)
        Dim ds As New DataSet()
        oleAdapter.Fill(ds, "prod")

        Try
            'OleCom.CommandText = ole
            'reader = OleCom.ExecuteReader()
            For Each reader As DataRow In ds.Tables("prod").Rows
                Application.DoEvents()
                'If reader.Read() Then
                GetProduto2 = reader(valor).ToString
                'reader.Close()
                'MsgBox(" Item: " & cod & " - Valor obtido: " & GetConfig)
                'conexão.Close()
                ' End If
                Exit For
            Next

        Catch ex As Exception
            GetProduto2 = If(valor = 8, 1, "")
            'conexão.Close()
            'MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try

        Return GetProduto2
    End Function

    Public Sub GetAllConfig()

        Try
            ' Create the command.

            For Each dr5 In ConfigDS.Tables(0).Rows

                If dr5.Item(0).ToString = "nome" Then
                    razao = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "cnpj" Then
                    cnpj = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "telefone1" Then
                    tel1 = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "telefone2" Then
                    tel2 = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "e-mail" Then
                    email = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "endereco" Then
                    endereco = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "cep" Then
                    cep = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "logo" Then
                    logo = dr5.Item(1).ToString
                End If

                '=================================

                If dr5.Item(0).ToString = "fantasia" Then
                    fantasia = dr5.Item(1).ToString
                End If


                If dr5.Item(0).ToString = "bairro" Then
                    bairro = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "complemento" Then
                    complemento = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "numero" Then
                    numero = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "pais" Then
                    pais = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "uf" Then
                    uf = LTrim(RTrim(dr5.Item(1).ToString))
                End If

                If dr5.Item(0).ToString = "municipio" Then
                    municipio = LTrim(RTrim(dr5.Item(1).ToString))
                End If

                '====================================================

                If dr5.Item(0).ToString = "imposto" Then
                    imposto = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "frete" Then
                    frete = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "montagem" Then
                    montagem = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "comissao" Then
                    comissao = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "rt" Then
                    rt = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "adicional" Then
                    adicional = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "desconto" Then
                    desconto = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "multiplicador" Then
                    markup = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "cabecalho" Then
                    cabecalho = dr5.Item(2).ToString
                End If

                If dr5.Item(0).ToString = "obs" Then
                    obs = dr5.Item(2).ToString
                End If

                If dr5.Item(0).ToString = "iniciais" Then
                    iniciais = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "numseq" Then
                    numseq = dr5.Item(1).ToString
                End If

                Application.DoEvents()

            Next

        Catch ex As Exception
            MsgBox(ex.Message & "  Erro ao ler dados em config")
        End Try



    End Sub

    Public Sub ExitProgram(nome As String)
        Dim Processos() As Process = System.Diagnostics.Process.GetProcessesByName(nome)
        For Each x As Process In Processos
            x.Kill()
        Next
    End Sub

    Public Function RemoveCaracteres(text As String)
        If Not IsNothing(text) Then
            Dim novoText As String = text.Replace(".", "").Replace(",", "").Replace("-", "").Replace("/", "").Replace("(", "").Replace(")", "").Replace(" ", "")
            Return novoText
        Else
            Return ""
        End If
    End Function

    Public Function CalcPercentual(ByVal valor As Double, ByVal taxa As Double) As Double
        Return CDbl(taxa) * (valor / 100)
    End Function

End Module


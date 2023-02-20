'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows
Imports NFe

Public Class FrmConfig

    Public imgloc As String


    Private Sub FrmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '---Tela geral
        'If IO.File.Exists(xres & "fundo-geral.jpg") Then
        '    Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
        '    Me.BackgroundImage = back1
        'End If

        If IO.File.Exists(xres & "accept_database.png") Then
            Dim img As New Bitmap(xres & "accept_database.png")
            Me.btnSalvar.Image = img
        End If

        If IO.File.Exists(xres & "cancel.png") Then
            Dim img As New Bitmap(xres & "cancel.png")
            Me.btnCancel.Image = img
        End If

        '---Usuários
        If IO.File.Exists(xres & "add_file.png") Then
            Dim img As New Bitmap(xres & "add_file.png")
            Me.btnAdd.Image = img
        End If

        If IO.File.Exists(xres & "edit.png") Then
            Dim img As New Bitmap(xres & "edit.png")
            Me.btnSenha.Image = img
        End If

        If IO.File.Exists(xres & "delete.png") Then
            Dim img As New Bitmap(xres & "delete.png")
            Me.btnApagar.Image = img
        End If

        '---Classificações
        If IO.File.Exists(xres & "add_file.png") Then
            Dim img As New Bitmap(xres & "add_file.png")
            Me.btnCategAdd.Image = img
        End If

        If IO.File.Exists(xres & "edit.png") Then
            Dim img As New Bitmap(xres & "edit.png")
            Me.btnCategEdit.Image = img
        End If

        If IO.File.Exists(xres & "delete.png") Then
            Dim img As New Bitmap(xres & "delete.png")
            Me.btnCategDelet.Image = img
        End If
        '---------------------------------------------

        '---------------------------------------------
        If IO.File.Exists(xres & "add_file.png") Then
            Dim img As New Bitmap(xres & "add_file.png")
            Me.btnTipoProdAdd.Image = img
        End If

        If IO.File.Exists(xres & "edit.png") Then
            Dim img As New Bitmap(xres & "edit.png")
            Me.btnTipoProdEdit.Image = img
        End If

        If IO.File.Exists(xres & "delete.png") Then
            Dim img As New Bitmap(xres & "delete.png")
            Me.btnTipoProdDelet.Image = img
        End If
        '---------------------------------------------

        If IO.File.Exists(xres & "settings-icon-2.png") Then
            Dim setings As New Bitmap(xres & "settings-icon-2.png")
            'Me.btnConfig.Image = setings
        End If


        CarregarPais(CbPais)

        PreencherUsuarios()

        PreencherTipoMats()

        PreencherTipoProd()


        LerDados()

        LerUF()
        LerMun()


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        AddUser(False)
        PreencherUsuarios()
        Update()

    End Sub

    Private Sub btnSenha_Click(sender As Object, e As EventArgs) Handles btnSenha.Click

        EditUser()
        PreencherUsuarios()
        Update()

    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click

        ApagarRegistro("usuarios", DtvUsuarios, "User")
        PreencherUsuarios()
        Update()

    End Sub



    Private Sub btnCategAdd_Click(sender As Object, e As EventArgs) Handles btnCategAdd.Click
        AddCategoria()
        PreencherTipoMats()

        Update()

    End Sub

    Private Sub btnCategEdit_Click(sender As Object, e As EventArgs) Handles btnCategEdit.Click
        EditCategoria()
        PreencherTipoMats()

        Update()

    End Sub

    Private Sub btnCategDelet_Click(sender As Object, e As EventArgs) Handles btnCategDelet.Click

        ApagarRegistro("categorias", DtvCategorias, "id")
        PreencherTipoMats()

        Update()

    End Sub


    '---------Rotinas abaixo-----------

    Private Sub AddUser(Optional novo As Boolean = False)

        Dim FormUsuario As New ConfigUsuario
        FormUsuario.vl = 0

        If novo = True Then
            FormUsuario.RadioButton2.Checked = True
            FormUsuario.RadioButton1.Visible = False
            FormUsuario.RadioButton2.Visible = False
        Else
            Dim ds = UsuariosDS().Tables(0)
            If ds.Rows.Count = 0 Then
                FormUsuario.RadioButton1.Checked = True
                FormUsuario.RadioButton1.Visible = False
                FormUsuario.RadioButton2.Visible = False
            End If
        End If


        FormUsuario.txtSenhaAtual.Visible = False
        FormUsuario.Label2.Visible = False

        FormUsuario.ShowDialog()

        Try
            If FormUsuario.DialogResult = Windows.Forms.DialogResult.OK Then

                Dim Nome As String = FormUsuario.txtNome.Text
                Dim Senha As String = FormUsuario.txtNovaSenha.Text
                Dim RedSenha As String = FormUsuario.txtRedSenha.Text
                Dim UserTipo As String = FormUsuario.Tipo
                Dim NomeComp As String = FormUsuario.txtNomeComp.Text
                Dim RG As String = FormUsuario.txtRg.Text
                Dim Tel1 As String = FormUsuario.txtTelefone1.Text
                Dim Tel2 As String = FormUsuario.txtTelefone2.Text
                Dim Email As String = FormUsuario.txtEmail.Text
                Dim Endereco As String = FormUsuario.txtEndereco.Text
                Dim Bairro As String = FormUsuario.txtBairro.Text
                Dim Cidade As String = FormUsuario.txtCidade.Text
                Dim Estado As String = FormUsuario.txtEstado.Text
                Dim CEP As String = FormUsuario.txtCep.Text
                Dim Foto As String = FormUsuario.imgloc

                conexão.Close()
                conexão.Open()
                'Dim variavel As String
                'variavel = "VALUES ('" & Codigo & "','" & Razao & "','" & Fantasia & "','" & Cnpj & "','" & Endereco & "','" & Contato & "','" & Telefone & "','" & Telefone2 & "','" & Email & "'"
                'MsgBox(variavel)

                Dim sqlCom As String = "INSERT INTO usuarios ([User],[Senha],[Tipo],[Nome],[RG],[Telefone1],[Telefone2],[Email],[Endereco],[Bairro],[Cidade],[Estado],[CEP],[Foto]) VALUES ('" & Nome & "','" & Senha & "','" & UserTipo & "','" & NomeComp & "','" & RG & "','" & Tel1 & "','" & Tel2 & "','" & Email & "','" & Endereco & "','" & Bairro & "','" & Cidade & "','" & Estado & "','" & CEP & "','" & Foto & "')"
                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim Ra As Integer = MyCommand.ExecuteNonQuery

                conexão.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try


        conexão.Close()

    End Sub

    Private Sub EditUser()

        Dim frm As New FrmConfigPadrao
        frm.poradmin = True
        Dim i As Integer
        Try
            i = DtvUsuarios.CurrentRow.Index
        Catch ex As Exception
            MsgBox(ex.Message & ": Não é possível editar um registro vazio!")
            Exit Sub
        End Try
        frm.nomeuser = DtvUsuarios.Item(0, i).Value
        frm.ShowDialog()

    End Sub

    Private Sub AddCategoria()


        Dim FormCategoria As New FrmConfigCateg
        FormCategoria.vlcat = 0
        FormCategoria.Ctipo = "u"
        FormCategoria.ShowDialog()

        Try
            If FormCategoria.DialogResult = Windows.Forms.DialogResult.OK Then

                Dim Codigo As String = FormCategoria.txtCategoria.Text
                Dim TipoC As String = FormCategoria.TipoCategoria
                Dim Chave As Double = CDbl(FormCategoria.TxtChave.Text)

                conexão.Close()
                conexão.Open()
                'Dim variavel As String
                'variavel = "VALUES ('" & Codigo & "','" & Razao & "','" & Fantasia & "','" & Cnpj & "','" & Endereco & "','" & Contato & "','" & Telefone & "','" & Telefone2 & "','" & Email & "'"
                'MsgBox(variavel)

                Dim sqlCom As String = "INSERT INTO categorias ([Código],[Unidade],[Chave]) VALUES ('" & Codigo & "','" & TipoC & "'," & Replace(Chave, ",", ".") & ")"
                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim Ra As Integer = MyCommand.ExecuteNonQuery

                conexão.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        conexão.Close()

    End Sub

    Private Sub EditCategoria()

        Dim FormCateg As New FrmConfigCateg
        FormCateg.vlcat = 1

        conexão.Close()
        conexão.Open()
        Dim i As Integer

        Try
            i = DtvCategorias.CurrentRow.Index
        Catch ex As Exception
            MsgBox(ex.Message & ": Não é possível editar um registro vazio!")
            Exit Sub
        End Try

        Dim varCodigo As Object = DtvCategorias.Item(0, i).Value
        'MsgBox(varCodigo)
        Dim sqlCom As String = "SELECT * FROM categorias WHERE [id]=" & varCodigo & " "
        'Dim MyCommand As New OleDbCommand(sqlCom, conexão)
        'Dim Ra As Integer = MyCommand.ExecuteNonQuery

        Try
            ' Create the command.
            Dim reader1 As OleDbDataReader
            Dim command As OleDbCommand = conexão.CreateCommand()
            command.CommandText = sqlCom
            reader1 = command.ExecuteReader()

            reader1.Read()

            FormCateg.LbId.Text = reader1(0)
            FormCateg.txtCategoria.Text = reader1(1)
            FormCateg.Ctipo = reader1(2)
            FormCateg.TxtChave.Text = reader1(3)

            FormCateg.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message & "  Erro ao executar o Read")
            Me.Dispose()
        End Try

        conexão.Close()

    End Sub

    Private Sub ApagarRegistro(ByVal nometabela As String, ByVal dtv As DataGridView, ByVal col As String)

        Try


            If dtv.SelectedRows.Count > 1 Then

                conexão.Close()
                conexão.Open()

                Dim msgb As MsgBoxResult = MsgBox("Tem certeza que deseja excluir os registros selecionados?  ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Atenção")

                If msgb = MsgBoxResult.Yes Then

                    For Each dw As DataGridViewRow In dtv.SelectedRows

                        'MsgBox("DELETE * FROM " & nometabela & " WHERE [" & col & "] = '" & dw.Cells(0).Value & "' ")
                        Dim sqlCom As String = "DELETE * FROM " & nometabela & " WHERE [" & col & "] = '" & dw.Cells(0).Value & "' "
                        Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                        Dim Ra As Integer = MyCommand.ExecuteNonQuery

                    Next

                    conexão.Close()
                Else

                    conexão.Close()
                    Exit Sub

                End If


            Else

                conexão.Close()
                conexão.Open()
                Dim i As Integer = dtv.CurrentRow.Index
                Dim varCodigo As String = dtv.Item(0, i).Value

                Dim msgb As MsgBoxResult = MsgBox("Tem certeza que deseja excluir o registro '" & varCodigo & "'?  ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Atenção")

                If msgb = MsgBoxResult.Yes Then

                    Dim sqlCom As String = "DELETE * FROM " & nometabela & " WHERE [" & col & "] = '" & varCodigo & "' "
                    Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                    Dim Ra As Integer = MyCommand.ExecuteNonQuery

                    conexão.Close()
                Else

                    conexão.Close()
                    Exit Sub

                End If

            End If


        Catch ex As Exception

            MsgBox(ex.Message & ", Erro ao deletar")
            conexão.Close()
            Exit Sub

        End Try


    End Sub

    Private Sub PreencherUsuarios()

        DtvUsuarios.Rows.Clear()
        For Each dt In UsuariosDS.Tables(0).Rows
            DtvUsuarios.Rows.Add(dt(0), dt(2), dt(3), dt(5))
        Next

    End Sub

    Private Sub PreencherTipoMats()

        DtvCategorias.Rows.Clear()
        For Each dt In CategoriasDS.Tables(0).Rows
            Dim unid As String = ""
            Select Case dt(2)
                Case "g"
                    unid = "Gramas"
                Case "ml"
                    unid = "Mililitros"
                Case "u"
                    unid = "Unidades"
            End Select
            DtvCategorias.Rows.Add(dt(0), dt(1), unid, dt(3))
        Next

    End Sub

    Private Sub PreencherTipoProd()

        DtvTipoProdutos.Rows.Clear()
        For Each dt In CategoriasProdutosDS.Tables(0).Rows
            DtvTipoProdutos.Rows.Add(dt(0), dt(1), dt(2))
        Next

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        OpenFileDialog1.ShowDialog()

        Try
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
            imgloc = PictureBox1.ImageLocation
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GravarDados()

        Try

            If lblDataBase.Text <> "..." Or lblDataBase.Text <> Nothing Then
                Dim arquivo As String = My.Application.Info.DirectoryPath & "\database.dat"
                If IO.File.Exists(arquivo) = True Then
                    IO.File.Delete(arquivo)
                End If
                Dim linha As String = Me.lblDataBase.Text
                Dim sw As New StreamWriter(arquivo)
                sw.WriteLine(linha)
                sw.Close()
                sw.Dispose()
            Else
                MsgBox("O caminho do banco de dados não é válido!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            conexão.Close()
            conexão.Open()

            Dim sqlCom As String = Nothing
            Dim MyCommand As OleDbCommand
            Dim Ra As Integer = 0
            'Dim sqlCom As String = "UPDATE fornecedores  SET [Razão Social] = '@Razao', [Nome Fantasia] = '@Fantasia', [CNPJ] = '@Cnpj', [Endereço] = '@Endereco', [Contato] = '@Contato', [Telefone] = '@Telefone', [Telefone 2] = '@Telefone2', [E-mail] = '@Email' WHERE [Codigo] = @Codigo"

            sqlCom = "UPDATE config SET [Dados] = '" & Me.txtRazao.Text & "' WHERE [Código] = 'nome'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.txtCnpj.Text & "' WHERE [Código] = 'cnpj'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.txtTel1.Text & "' WHERE [Código] = 'telefone1'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.txtTel2.Text & "' WHERE [Código] = 'telefone2'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.txtTelEmail.Text & "' WHERE [Código] = 'e-mail'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.txtEndereco.Text & "' WHERE [Código] = 'endereco'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.txtCep.Text & "' WHERE [Código] = 'cep'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & imgloc & "' WHERE [Código] = 'logo'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.txtImposto.Text & "' WHERE [Código] = 'imposto'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.txtRt.Text & "' WHERE [Código] = 'rt'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.txtFrete.Text & "' WHERE [Código] = 'frete'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.txtMontagem.Text & "' WHERE [Código] = 'montagem'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.txtComissao.Text & "' WHERE [Código] = 'comissao'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.TxtMultiplicador.Text & "' WHERE [Código] = 'multiplicador'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.TxtDesconto.Text & "' WHERE [Código] = 'desconto'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.txtAdicional.Text & "' WHERE [Código] = 'adicional'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            'sqlCom = "UPDATE config SET [DadosExt] = '" & Me.TxtCabecalho.Text & "' WHERE [Código] = 'cabecalho'"
            'MyCommand = New OleDbCommand(sqlCom, conexão)
            'Ra = MyCommand.ExecuteNonQuery

            'sqlCom = "UPDATE config SET [DadosExt] = '" & Me.TxtObs.Text & "' WHERE [Código] = 'obs'"
            'MyCommand = New OleDbCommand(sqlCom, conexão)
            'Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.TxtIniciais.Text & "' WHERE [Código] = 'iniciais'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & Me.TxtNumero.Text & "' WHERE [Código] = 'numseq'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery


            '=================================

            sqlCom = "UPDATE config SET [Dados] = '" & txtFantasia.Text & "' WHERE [Código] = 'fantasia'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & txtBairro.Text & "' WHERE [Código] = 'bairro'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & txtComplemento.Text & "' WHERE [Código] = 'complemento'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & txtNum.Text & "' WHERE [Código] = 'numero'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & CbPais.SelectedItem & "' WHERE [Código] = 'pais'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & CbUf.SelectedItem & "' WHERE [Código] = 'uf'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & CbMunicipio.SelectedItem & "' WHERE [Código] = 'municipio'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & txtNFeIE.Text & "' WHERE [Código] = 'ie'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & txtNFeSubTrib.Text & "' WHERE [Código] = 'iesubtrib'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & txtNFeIM.Text & "' WHERE [Código] = 'im'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & txtNFeCNAE.Text & "' WHERE [Código] = 'cnae'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            sqlCom = "UPDATE config SET [Dados] = '" & CbNfeRegimeTrib.SelectedItem & "' WHERE [Código] = 'regimetrib'"
            MyCommand = New OleDbCommand(sqlCom, conexão)
            Ra = MyCommand.ExecuteNonQuery

            '====================================================

            'sqlCom = "UPDATE confignfe SET [Valor] = '" & CbTipoAmb.SelectedIndex + 1 & "' WHERE [Codigo] = 'tpamb'"
            'MyCommand = New OleDbCommand(sqlCom, conexão)
            'Ra = MyCommand.ExecuteNonQuery

            'sqlCom = "UPDATE confignfe SET [Valor] = '" & imgloc & "' WHERE [Codigo] = 'logo'"
            'MyCommand = New OleDbCommand(sqlCom, conexão)
            'Ra = MyCommand.ExecuteNonQuery

            'sqlCom = "UPDATE config SET [Dados] = '" & txtNumSeq.text & "' WHERE [Código] = 'numseqnfe'"
            'MyCommand = New OleDbCommand(sqlCom, conexão)
            'Ra = MyCommand.ExecuteNonQuery

            conexão.Close()

            MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information)

            Close()

            'MsgBox("EDITOU REGISTRO")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conexão.Close()
            Close()
        End Try

    End Sub

    Private Sub LerUF()
        Dim dr5 As DataRow
        Try
            ' Create the command.
            For Each dr5 In ConfigDS.Tables(0).Rows
                If dr5.Item(0).ToString = "uf" Then
                    'MsgBox(LTrim(RTrim(dr5.Item(1).ToString)))
                    CbUf.SelectedItem = LTrim(RTrim(dr5.Item(1).ToString))
                End If
            Next
        Catch ex As Exception
            MsgBox("Erro ao carregar UF. " & ex.Message)
        End Try
    End Sub

    Private Sub LerMun()
        Dim dr5 As DataRow

        Try
            ' Create the command.
            For Each dr5 In ConfigDS.Tables(0).Rows
                If dr5.Item(0).ToString = "municipio" Then
                    'MsgBox(LTrim(RTrim(dr5.Item(1).ToString)))
                    CbMunicipio.SelectedItem = LTrim(RTrim(dr5.Item(1).ToString))
                End If
            Next

        Catch ex As Exception
            MsgBox("Erro ao carregar Municipio. " & ex.Message)
        End Try

    End Sub

    Private Sub LerDados()

        Dim dr5 As DataRow

        Try
            ' Create the command.

            For Each dr5 In ConfigDS.Tables(0).Rows

                If dr5.Item(0).ToString = "nome" Then
                    txtRazao.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "cnpj" Then
                    txtCnpj.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "telefone1" Then
                    txtTel1.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "telefone2" Then
                    txtTel2.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "e-mail" Then
                    txtTelEmail.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "endereco" Then
                    txtEndereco.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "cep" Then
                    txtCep.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "logo" Then
                    If IO.File.Exists(dr5.Item(1).ToString) = True Then
                        imgloc = dr5.Item(1).ToString
                        PictureBox1.Image = Image.FromFile(imgloc)
                        PictureBox1.Update()
                    End If
                End If

                '=================================

                If dr5.Item(0).ToString = "fantasia" Then
                    txtFantasia.Text = dr5.Item(1).ToString
                End If


                If dr5.Item(0).ToString = "bairro" Then
                    txtBairro.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "complemento" Then
                    txtComplemento.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "numero" Then
                    txtNum.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "pais" Then
                    CbPais.SelectedItem = dr5.Item(1).ToString
                End If

                'If dr5.Item(0).ToString = "uf" Then
                '    'MsgBox(LTrim(RTrim(dr5.Item(1).ToString)))
                '    CbUf.SelectedItem = LTrim(RTrim(dr5.Item(1).ToString))
                'End If

                'If dr5.Item(0).ToString = "municipio" Then
                '    'MsgBox(LTrim(RTrim(dr5.Item(1).ToString)))
                '    CbMunicipio.SelectedItem = LTrim(RTrim(dr5.Item(1).ToString))
                'End If

                If dr5.Item(0).ToString = "ie" Then
                    txtNFeIE.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "iesubtrib" Then
                    txtNFeSubTrib.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "im" Then
                    txtNFeIM.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "cnae" Then
                    txtNFeCNAE.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "regimetrib" Then
                    CbNfeRegimeTrib.SelectedItem = dr5.Item(1).ToString
                End If

                '====================================================

                If dr5.Item(0).ToString = "imposto" Then
                    txtImposto.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "frete" Then
                    txtFrete.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "montagem" Then
                    txtMontagem.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "comissao" Then
                    txtComissao.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "rt" Then
                    txtRt.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "adicional" Then
                    txtAdicional.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "desconto" Then
                    TxtDesconto.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "multiplicador" Then
                    TxtMultiplicador.Text = dr5.Item(1).ToString
                End If

                'If dr5.Item(0).ToString = "cabecalho" Then
                '    TxtCabecalho.Text = dr5.Item(2).ToString
                'End If

                'If dr5.Item(0).ToString = "obs" Then
                '    TxtObs.Text = dr5.Item(2).ToString
                'End If

                If dr5.Item(0).ToString = "iniciais" Then
                    TxtIniciais.Text = dr5.Item(1).ToString
                End If

                If dr5.Item(0).ToString = "numseq" Then
                    TxtNumero.Text = dr5.Item(1).ToString
                End If


                If dr5.Item(0).ToString = "numseqnfe" Then
                    'txtNumSeq.Text = dr5.Item(1).ToString
                End If

            Next

            'Dim tpamb As Integer = CInt(GetConfig("tpamb"))
            'CbTipoAmb.SelectedIndex = tpamb - 1


            If IO.File.Exists(My.Application.Info.DirectoryPath & "\database.dat") Then
                Dim arquivo As String = My.Application.Info.DirectoryPath & "\database.dat"
                Dim sr As New StreamReader(arquivo)
                Dim local As String
                local = sr.ReadToEnd()
                Me.lblDataBase.Text = local

                sr.Dispose()

            Else
                Me.lblDataBase.Text = "..."
            End If



        Catch ex As Exception
            MsgBox(ex.Message & "  Erro ao ler dados em config")
            Me.Dispose()
        End Try

        conexão.Close()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        GravarDados()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog2.Filter = "Access Database files (*.accdb) |*.accdb|(*.mdb) |*.mdb| All files (*.*)|*.*"
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            Try
                lblDataBase.Text = OpenFileDialog2.FileName
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub btnTipoProdAdd_Click(sender As Object, e As EventArgs) Handles btnTipoProdAdd.Click
        Dim FormTipoProduto As New FrmTipoProd
        FormTipoProduto.ShowDialog()

        Try
            If FormTipoProduto.DialogResult = Windows.Forms.DialogResult.OK Then

                Dim Nome As String = FormTipoProduto.TextBox1.Text

                conexão.Close()
                conexão.Open()
                'Dim variavel As String
                'variavel = "VALUES ('" & Codigo & "','" & Razao & "','" & Fantasia & "','" & Cnpj & "','" & Endereco & "','" & Contato & "','" & Telefone & "','" & Telefone2 & "','" & Email & "'"
                'MsgBox(variavel)

                Dim sqlCom As String = "INSERT INTO categoria_produtos ([Nome]) VALUES ('" & Nome & "')"
                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim Ra As Integer = MyCommand.ExecuteNonQuery

                conexão.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        conexão.Close()

        PreencherTipoProd()

    End Sub

    Private Sub btnTipoProdDelet_Click(sender As Object, e As EventArgs) Handles btnTipoProdDelet.Click
        ApagarRegistro("categoria_produtos", DtvTipoProdutos, "id")
        PreencherTipoProd()
    End Sub

    Private Sub btnExcAll_Click(sender As Object, e As EventArgs)
        Try
            conexão.Close()
            conexão.Open()
            Dim str1 As String = "DELETE FROM Temp"
            Dim Comm As New OleDbCommand(str1, conexão)
            Dim Ra As Integer = Comm.ExecuteNonQuery
            conexão.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CbPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPais.SelectedIndexChanged
        CarregarEstado(GetPaisSelecionado(CbPais.SelectedItem), CbUf)
    End Sub

    Private Sub CbUF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbUf.SelectedIndexChanged
        CarregarCidades(GetEstadoSelecionado(CbUf.SelectedItem), CbMunicipio)
    End Sub



    Public Sub CarregarPais(cbx As ComboBox)

        Try
            cbx.Items.Clear()

            CbPais.Items.Clear()
            CbMunicipio.Items.Clear()
            CbUf.Items.Clear()

            Dim sr1 As New StreamReader(My.Application.Info.DirectoryPath & "\pais.dat")
            Dim listPais As String() = sr1.ReadToEnd().Split(vbCr)
            Dim pais As String = Nothing
            Dim delimit As String() = Nothing
            sr1.Close()


            For Each pais In listPais
                'MsgBox("País: " & pais)
                If Trim(pais) <> Nothing Then
                    delimit = pais.Split(";")
                    cbx.Items.Add(delimit(1))
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try


    End Sub

    Private Sub CarregarEstado(pais As Integer, cbx As ComboBox)

        Try

            cbx.Items.Clear()

            Dim encoding As Encoding = encoding.GetEncoding("ISO-8859-1")
            Dim sr2 As New StreamReader(My.Application.Info.DirectoryPath & "\estado.dat", encoding)
            Dim listEstado As String() = sr2.ReadToEnd().Split(vbCr)
            Dim estado As String = Nothing
            Dim delimit As String() = Nothing
            sr2.Close()

            'MsgBox(listEstado.Count)

            For Each estado In listEstado
                'MsgBox("Estado: " & estado)
                If Trim(estado) <> Nothing Then
                    delimit = estado.Split(";")
                    'MsgBox("delimt " & delimit.Count)
                    If delimit(3) = pais Then
                        cbx.Items.Add(delimit(2))
                    End If
                End If
            Next

            cbx.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace)

        End Try

    End Sub

    Private Sub CarregarCidades(estado As Integer, cbx As ComboBox)

        Dim linha As String = Nothing

        Try
            cbx.Items.Clear()

            Dim encoding As Encoding = encoding.GetEncoding("ISO-8859-1")
            Dim sr3 As New StreamReader(My.Application.Info.DirectoryPath & "\cidade.dat", encoding)
            Dim listCidade As String() = sr3.ReadToEnd().Split(vbCr)

            Dim cidade As String = Nothing
            Dim delimit As String() = Nothing
            sr3.Close()
            'MsgBox(listCidade.Count())


            For Each cidade In listCidade
                If Trim(cidade) <> Nothing Then
                    linha = cidade
                    delimit = cidade.Split(";")

                    If LTrim(RTrim(delimit(1))) = LTrim(RTrim(estado)) Then
                        'MsgBox("ESTADO SELECIONADO: " & estado & vbNewLine & _
                        '  "Cidade: " & Trim(delimit(0)) & "; Estado: " & Trim(delimit(1)) & "; Cod Mun: " & CInt(Trim(delimit(2))).ToString("00000"))
                        'MsgBox("Achou estado: " & delimit(2))
                        cbx.Items.Add(delimit(0))
                    End If
                End If
            Next

            cbx.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace & " Linha: " & linha)
        End Try

    End Sub


    Private Function GetPaisSelecionado(nome As String) As Integer

        GetPaisSelecionado = 0

        Dim sr1 As New StreamReader(My.Application.Info.DirectoryPath & "\pais.dat")
        Dim listPais As String() = sr1.ReadToEnd().Split(vbCr)
        Dim pais As String = Nothing
        Dim delimit As String() = Nothing
        sr1.Close()

        For Each pais In listPais
            If Trim(pais) <> Nothing Then
                delimit = pais.Split(";")
                If Trim(delimit(1)) = Trim(nome) Then
                    GetPaisSelecionado = CInt(LTrim(RTrim(delimit(0))))
                    Exit For
                End If
            End If
        Next

        Return GetPaisSelecionado
    End Function

    Private Function GetEstadoSelecionado(nome As String) As Integer

        GetEstadoSelecionado = 0

        Dim sr1 As New StreamReader(My.Application.Info.DirectoryPath & "\estado.dat")
        Dim listEstado As String() = sr1.ReadToEnd().Split(vbCr)
        Dim Estado As String = Nothing
        Dim delimit As String() = Nothing
        sr1.Close()

        For Each Estado In listEstado
            If Trim(Estado) <> Nothing Then
                delimit = Estado.Split(";")
                If Trim(delimit(2)) = Trim(nome) Then
                    'MsgBox(delimit(0))
                    GetEstadoSelecionado = CInt(LTrim(RTrim(delimit(4))))
                    Exit For
                End If
            End If
        Next

        Return GetEstadoSelecionado
    End Function

    Private Function GetIndiceItem(cbx As ComboBox, valor As String) As Integer
        GetIndiceItem = 0
        Dim count As Integer = 0
        For Each item As String In cbx.Items
            If item.Substring(0, item.Length - 1) = valor Then
                GetIndiceItem = count
            End If
            count += 1
        Next
        count = 0
        Return GetIndiceItem
    End Function


    Public Function ObterItemCombo(valor As String) As String
        ObterItemCombo = 0

        Dim It() As String = Nothing

        Try
            It = valor.Split("-")
            If It.Count > 1 Then
                ObterItemCombo = Trim(It(0))
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace & vbNewLine)
        End Try

        Return ObterItemCombo
    End Function

End Class
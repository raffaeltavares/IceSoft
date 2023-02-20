'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows

Public Class ListaMateriais

    Private TipoArq As Integer
    Private flagSelect As Boolean = False

    Private Sub FrmListaMateriais_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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

        If IO.File.Exists(xres & "import.png") Then
            Dim back7 As New Bitmap(xres & "import.png")
            Me.btnEstoque.Image = back7
        End If

        If IO.File.Exists(xres & "exit.png") Then
            Dim back5 As New Bitmap(xres & "exit.png")
            Me.btnSair.Image = back5
        End If

        If IO.File.Exists(xres & "copy.png") Then
            Dim back6 As New Bitmap(xres & "copy.png")
            Me.btnDuplicar.Image = back6
        End If

        Timer1.Interval = 500

        PreencherCombos("categorias", CbCategoria)
        PreencherCombos("fornecedores", CbFornecedor)
        PreencherLista("", "", "")

    End Sub

    Private Sub TxtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub CbFornecedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbFornecedor.SelectedIndexChanged
        PreencherLista(txtFiltro.Text, CbFornecedor.SelectedItem, CbCategoria.SelectedItem)
    End Sub

    Private Sub CbCategoria_ClickSelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCategoria.SelectedIndexChanged
        If flagSelect = True Then
            PreencherLista(txtFiltro.Text, CbFornecedor.SelectedItem, CbCategoria.SelectedItem)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If flagSelect = True Then
            PreencherLista(txtFiltro.Text, CbFornecedor.SelectedItem, CbCategoria.SelectedItem)
        End If
    End Sub

    Private Sub PreencherLista(filtroTxt As String, filtroMarca As String, filtroTipo As String)

        flagSelect = False
        DtvMateriais.Rows.Clear()
        System.Windows.Forms.Application.DoEvents()

        Dim contTipo() As String = filtroTipo.Split("-")
        Dim contMarca() As String = filtroMarca.Split("-")

        Dim iTipo As String = If(contTipo.Count > 1, Trim(contTipo(0)), "SEM FILTRO")
        Dim iMarca As String = If(contMarca.Count > 1, Trim(contMarca(0)), "SEM FILTRO")

        Try

            conexão.Close()
            conexão.Open()
            Dim dt As DataRow
            Dim cCol As Integer = 0

            For Each dt In MateriaisDS.Tables(0).Rows
                cCol = 0

                Dim flagMarca As Boolean = True
                Dim flagTipo As Boolean = True
                Dim flagFiltro As Boolean = True
                If iMarca <> "SEM FILTRO" And iMarca <> "" Then
                    flagMarca = False
                    If iMarca = Trim(dt.Item(2).ToString) Then
                        flagMarca = True
                    End If
                End If

                If iTipo <> "SEM FILTRO" And iTipo <> "" Then
                    flagTipo = False
                    If iTipo = dt.Item(3).ToString Then
                        flagTipo = True
                    End If
                End If

                If filtroTxt <> "" Then
                    flagFiltro = False
                    If LCase(Trim(dt(0))).Contains(LCase(filtroTxt)) Or
                            LCase(Trim(dt(1))).Contains(LCase(filtroTxt)) Or
                            LCase(Trim(dt(10))).Contains(LCase(filtroTxt)) Or
                            LCase(Trim(dt(11))).Contains(LCase(filtroTxt)) Then
                        flagFiltro = True
                    End If
                End If

                If flagMarca = True And flagTipo = True And flagFiltro = True Then

                    Dim Codigo As String = dt.Item(0).ToString
                    Dim Descricao As String = If(IsDBNull(dt.Item(1).ToString) = False, dt.Item(1).ToString, "")
                    Dim Categoria As String = If(IsDBNull(dt.Item(3).ToString) = False, dt.Item(3).ToString, "")
                    Dim unidade As String = If(IsDBNull(dt.Item(4).ToString) = False, dt.Item(4).ToString, "")
                    Dim Fornecedor As String = If(IsDBNull(dt.Item(2).ToString) = False, dt.Item(2).ToString, "")
                    Dim Valor As Double = If(IsDBNull(dt.Item(5).ToString) = False, CDbl(dt.Item(5).ToString()), 0.0)
                    Dim Frete As Double = If(IsDBNull(dt.Item(7).ToString) = False, CDbl(dt.Item(7).ToString()), 0.0)
                    Dim IPI As Double = If(IsDBNull(dt.Item(6).ToString) = False, CDbl(dt.Item(6).ToString()), 0.0)
                    Dim Volume As Double = If(IsDBNull(dt.Item(9).ToString) = False, CDbl(dt.Item(7).ToString()), 0.0)
                    Dim ValorFinal As Double = If(IsDBNull(dt.Item(8).ToString) = False, CDbl(dt.Item(8).ToString()), 0.0)
                    Dim CodFornecedor As String = If(IsDBNull(dt.Item(10).ToString) = False, dt.Item(10).ToString, "")
                    Dim Data As String = If(IsDBNull(dt.Item(11).ToString) = False, dt.Item(11).ToString, "")
                    Dim Qtde As Double = If(IsDBNull(dt.Item(12).ToString) = False, CDbl(dt.Item(12).ToString()), 0.0)
                    Dim ValorQde As Double = If(IsDBNull(dt.Item(13).ToString) = False, CDbl(dt.Item(13).ToString()), 0.0)

                    Dim txtEstoque As String = Qtde
                    Select Case unidade
                        Case "g"
                            txtEstoque = Qtde / 1000 & " kg"
                        Case "ml"
                            txtEstoque = Qtde / 1000 & " L"
                        Case "u"
                            txtEstoque = Qtde & " un"
                    End Select

                    DtvMateriais.Rows.Add(Codigo, Descricao, CodFornecedor, "R$ " & Valor, "R$ " & ValorFinal, Data, txtEstoque, "R$ " & ValorQde)
                End If

CONT1:
                'System.Windows.Forms.Application.DoEvents()

            Next

            conexão.Close()

            Timer1.Stop()

        Catch ex As Exception
            MsgBox("Preencher lista: " & ex.Message)
        End Try

        DtvMateriais.Visible = True
        flagSelect = True

    End Sub

    Private Sub PreencherCombos(ByVal nometabela As String, ByVal cb As ToolStripComboBox)

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


    Private Sub AddMaterial()

        Dim FormularioMaterial As Material = New Material()
        FormularioMaterial.vl = 0
        FormularioMaterial.TxtData.Text = DateTime.Today.ToString("dd/MM/yyyy")
        FormularioMaterial.PreencherCategorias()
        FormularioMaterial.PreencherFornecedores()
        FormularioMaterial.ShowDialog()

        If FormularioMaterial.DialogResult = Windows.Forms.DialogResult.OK Then
            'MsgBox("Vai criar as variaveis")

            Dim Codigo As String = FormularioMaterial.txtCodigo.Text
            Dim Descricao As String = FormularioMaterial.txtDescricao.Text
            Dim Categoria As String = FormularioMaterial.CategAtual
            Dim unidade As String = FormularioMaterial.lblUnidade.Text
            Dim Fornecedor As String = FormularioMaterial.FornecAtual
            Dim Valor As String = Replace(FormularioMaterial.txtValor.Text, ",", ".")
            Dim Frete As String = Replace(FormularioMaterial.txtFrete.Text, ",", ".")
            Dim IPI As String = Replace(FormularioMaterial.txtIPI.Text, ",", ".")
            Dim Volume As String = Replace(FormularioMaterial.txtPar1.Text, ",", ".")
            Dim ValorFinal As String = Replace(FormularioMaterial.txtValorFinal.Text, ",", ".")
            Dim CodFornecedor As String = FormularioMaterial.TxtCodFornecedor.Text
            Dim Data As String = FormularioMaterial.TxtData.Text
            Dim Qtde As String = Replace(FormularioMaterial.TxtQtd.Text, ",", ".")
            Dim ValorQde As String = Replace(FormularioMaterial.TxtValorQtd.Text, ",", ".")

            Try

                conexão.Close()
                conexão.Open()

                Dim sqlCom As String = "INSERT INTO materiaprima (" &
                                                    "[Codigo]," &
                                                    "[Descricao]," &
                                                    "[Fornecedor]," &
                                                    "[Categoria]," &
                                                    "[Unidade]," &
                                                    "[Preco]," &
                                                    "[imposto]," &
                                                    "[FRETE]," &
                                                    "[valorFinal]," &
                                                    "[volume]," &
                                                    "[CodFornecedor]," &
                                                    "[Data]," &
                                                    "[estoque]," &
                                                    "[ValorEstoque])" &
                                                    "VALUES (" &
                                                    "'" & Codigo & "'," &
                                                    "'" & Descricao & "'," &
                                                    "'" & Fornecedor & "'," &
                                                    "'" & Categoria & "'," &
                                                    "'" & unidade & "'," &
                                                    "" & Valor & "," &
                                                    "" & IPI & "," &
                                                    "" & Frete & "," &
                                                    "" & ValorFinal & "," &
                                                    "" & Volume & "," &
                                                    "'" & CodFornecedor & "'," &
                                                    "'" & Data & "'," &
                                                    "" & Qtde & "," &
                                                    "" & ValorQde & ")"

                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim Ra As Integer = MyCommand.ExecuteNonQuery
                'MsgBox("inseriu")
                conexão.Close()

                Me.Hide()

                Dim frmNovo As New ListaMateriais
                frmNovo.ShowDialog()

            Catch ex As Exception
                conexão.Close()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
            End Try

            Me.Dispose()

        End If

    End Sub

    Private Sub EditMaterial()


        Dim FormularioMaterial As New Material
        FormularioMaterial.vl = 1
        FormularioMaterial.PreencherCategorias()
        FormularioMaterial.PreencherFornecedores()

        conexão.Close()
        conexão.Open()
        Dim i As Integer

        Try
            i = DtvMateriais.CurrentRow.Index
        Catch ex As Exception
            MsgBox(ex.Message & ": Não é possível editar um registro vazio!")
            Exit Sub
        End Try

        Dim varCodigo As Object = DtvMateriais.Item(0, i).Value
        'MsgBox(varCodigo)
        Dim sqlCom As String = "SELECT * FROM materiaprima WHERE [Codigo]='" & DtvMateriais.Item(0, i).Value & "'"
        'Dim MyCommand As New OleDbCommand(sqlCom, conexão)
        'Dim Ra As Integer = MyCommand.ExecuteNonQuery

        Try
            ' Create the command.
            Dim reader1 As OleDbDataReader
            Dim command As OleDbCommand = conexão.CreateCommand()
            command.CommandText = sqlCom
            reader1 = command.ExecuteReader()

            reader1.Read()

            FormularioMaterial.txtCodigo.Text = reader1(0)
            FormularioMaterial.txtDescricao.Text = reader1(1)

            FormularioMaterial.FornecAtual = reader1(2)
            FormularioMaterial.CategAtual = reader1(3)

            FormularioMaterial.lblUnidade.Text = reader1(4)
            FormularioMaterial.txtValor.Text = reader1(5)
            FormularioMaterial.txtIPI.Text = reader1(6)
            FormularioMaterial.txtFrete.Text = reader1(7)
            FormularioMaterial.txtValorFinal.Text = reader1(8)
            FormularioMaterial.txtPar1.Text = reader1(9)
            If Not IsDBNull(reader1(10)) Then
                FormularioMaterial.TxtCodFornecedor.Text = reader1(10)
            End If
            If Not IsDBNull(reader1(11)) Then
                FormularioMaterial.TxtData.Text = reader1(11)
            Else
                FormularioMaterial.TxtData.Text = DateTime.Today.ToString("dd/MM/yyyy")
            End If
            If Not IsDBNull(reader1(12)) Then
                FormularioMaterial.TxtQtd.Text = reader1(12)
            End If
            If Not IsDBNull(reader1(13)) Then
                FormularioMaterial.TxtValorQtd.Text = reader1(13)
            End If

            FormularioMaterial.txtCodigo.ReadOnly = True
            FormularioMaterial.ShowDialog()

        Catch ex As Exception
            MsgBox("Erro em Editar " & ex.Message & vbNewLine & ex.ToString)
            Me.Dispose()
        End Try

        conexão.Close()
        FormularioMaterial.txtCodigo.ReadOnly = False

        Me.Hide()

        Dim frmNovo As New ListaMateriais
        frmNovo.ShowDialog()

    End Sub

    Private Sub ApagarMaterial()

        Try


            conexão.Close()
            conexão.Open()
            Dim i As Integer = DtvMateriais.CurrentRow.Index
            Dim varCodigo As String = DtvMateriais.Item(0, i).Value

            Dim msgb As MsgBoxResult = MsgBox("Tem certeza que deseja excluir o material " & varCodigo & "?  " & vbNewLine & _
                   "Descrição: " & DtvMateriais.Item(1, i).Value, MsgBoxStyle.YesNo)
            If msgb = MsgBoxResult.Yes Then

                Dim sqlCom As String = "DELETE * FROM materiaprima WHERE [Codigo]='" & varCodigo & "'"
                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim Ra As Integer = MyCommand.ExecuteNonQuery
                Me.Hide()
                Dim frmNovo As New ListaMateriais
                conexão.Close()
                frmNovo.ShowDialog()

            Else

                conexão.Close()
                Exit Sub

            End If


        Catch ex As Exception

            MsgBox(ex.Message)
            Dim frmNovo As New ListaMateriais
            conexão.Close()
            frmNovo.ShowDialog()

        End Try


    End Sub

    Private Sub DuplicaMaterial()


        Dim FormularioMaterial As New Material
        FormularioMaterial.vl = 2
        FormularioMaterial.PreencherCategorias()
        FormularioMaterial.PreencherFornecedores()

        conexão.Close()
        conexão.Open()
        Dim i As Integer

        Try
            i = DtvMateriais.CurrentRow.Index
        Catch ex As Exception
            MsgBox(ex.Message & ": Não é possível duplicar um registro vazio!")
            Exit Sub
        End Try

        Dim varCodigo As Object = DtvMateriais.Item(0, i).Value
        'MsgBox(varCodigo)
        Dim sqlCom As String = "SELECT * FROM materiaprima WHERE [Codigo]='" & DtvMateriais.Item(0, i).Value & "'"
        'Dim MyCommand As New OleDbCommand(sqlCom, conexão)
        'Dim Ra As Integer = MyCommand.ExecuteNonQuery

        Try
            ' Create the command.
            Dim reader1 As OleDbDataReader
            Dim command As OleDbCommand = conexão.CreateCommand()
            command.CommandText = sqlCom
            reader1 = command.ExecuteReader()

            reader1.Read()

            'FormularioMaterial.txtCodigo.Text = reader1(0)
            FormularioMaterial.txtDescricao.Text = reader1(1)

            FormularioMaterial.FornecAtual = reader1(2)
            FormularioMaterial.CategAtual = reader1(3)

            FormularioMaterial.lblUnidade.Text = reader1(4)
            FormularioMaterial.txtValor.Text = reader1(5)
            FormularioMaterial.txtIPI.Text = reader1(6)
            FormularioMaterial.txtFrete.Text = reader1(7)
            FormularioMaterial.txtValorFinal.Text = reader1(8)
            FormularioMaterial.txtPar1.Text = reader1(9)
            If Not IsDBNull(reader1(10)) Then
                FormularioMaterial.TxtCodFornecedor.Text = reader1(10)
            End If

            FormularioMaterial.TxtData.Text = DateTime.Today.ToString("dd/MM/yyyy")

            'If Not IsDBNull(reader1(11)) Then
            '    FormularioMaterial.TxtData.Text = reader1(11)
            'Else
            '    FormularioMaterial.TxtData.Text = DateTime.Today.ToString("dd/MM/yyyy")
            'End If

            If Not IsDBNull(reader1(12)) Then
                FormularioMaterial.TxtQtd.Text = reader1(12)
            End If
            If Not IsDBNull(reader1(13)) Then
                FormularioMaterial.TxtValorQtd.Text = reader1(13)
            End If

            Me.Hide()
            FormularioMaterial.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
            Me.Dispose()
        End Try

        conexão.Close()

        Dim frmNovo As New ListaMateriais
        frmNovo.ShowDialog()
        Me.Dispose()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddMaterial()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditMaterial()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ApagarMaterial()
    End Sub

    Private Sub btnDuplicar_Click(sender As Object, e As EventArgs) Handles btnDuplicar.Click
        DuplicaMaterial()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnEstoque.Click

        If Not IsNothing(DtvMateriais.CurrentRow) Then
            Dim row As Integer = DtvMateriais.CurrentRow.Index

            Dim frm As New FrmEstoque
            frm.Codigo = DtvMateriais.Item(0, row).Value
            frm.Descricao = DtvMateriais.Item(1, row).Value
            frm.Valor = CDbl(DtvMateriais.Item(4, row).Value.ToString.Replace("R$ ", ""))
            frm.Data = DtvMateriais.Item(5, row).Value
            frm.Estoque = If(DtvMateriais.Item(6, row).Value.ToString.Contains("un"),
            CDbl(DtvMateriais.Item(6, row).Value.ToString.Replace(" kg", "").Replace(" un", "").Replace(" l", "")),
            CDbl(DtvMateriais.Item(6, row).Value.ToString.Replace(" kg", "").Replace(" un", "").Replace(" l", "")) * 1000)

            If DtvMateriais.Item(6, row).Value.ToString.Contains("un") Then
                frm.unid = "u"
            ElseIf DtvMateriais.Item(6, row).Value.ToString.Contains("kg") Then
                frm.unid = "g"
            Else
                frm.unid = "ml"
            End If


            frm.ShowDialog()

            If frm.DialogResult = DialogResult.OK Then

                Try

                    conexão.Close()
                    conexão.Open()
                    Dim sqlCom As String = "UPDATE materiaprima SET [data]=" & frm.DataEntrada & ", " &
                        "[estoque]=" & CDbl(frm.Estoque + frm.Entrada).ToString.Replace(",", ".") & ", " &
                        "[ValorEstoque] = " & CDbl((frm.Estoque + frm.Entrada) * frm.Valor).ToString.Replace(",", ".") & " WHERE [Codigo] = '" & frm.Codigo & "' "
                    Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                    Dim Ra As Integer = MyCommand.ExecuteNonQuery
                    conexão.Close()

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Erro inesperado")
                    conexão.Close()
                End Try

                PreencherLista(txtFiltro.Text, CbFornecedor.SelectedItem, CbCategoria.SelectedItem)


            End If

        End If

        'Dim frm As New FrmTipoImport
        'frm.GrImport.Visible = False
        'frm.ShowDialog()
        'If frm.DialogResult = Forms.DialogResult.OK Then
        '    If frm.TIPOS = 1 Then
        '        OpenFileDialog1.Filter = "(Excel Files)|*.xls;*.xlsx |Xls, | *.xls|Xlsx, | *.xlsx"
        '        TipoArq = 1
        '    ElseIf frm.TIPOS = 2 Then
        '        OpenFileDialog1.Filter = "(Text Files)|*.txt; *.csv|Txt, | *.txt|Csv, | *.csv"
        '        TipoArq = 2
        '    End If
        '    OpenFileDialog1.ShowDialog()
        'End If

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        Dim frm As New ProcessoImportacao
        frm.Processo = 1
        frm.tipoarq = TipoArq
        frm.nomearq = OpenFileDialog1.FileName
        frm.ShowDialog()

        Me.Hide()
        Dim frmNovo As New ListaMateriais
        conexão.Close()
        frmNovo.ShowDialog()
    End Sub

End Class
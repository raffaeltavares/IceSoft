'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows

Public Class FrmListaFornecedores

    Private TipoArq As Integer

    Private Sub FrmListaFornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            Dim back6 As New Bitmap(xres & "import.png")
            Me.btnImport.Image = back6
        End If

        If IO.File.Exists(xres & "exit.png") Then
            Dim back5 As New Bitmap(xres & "exit.png")
            Me.btnSair.Image = back5
        End If

        PreencherLista("")

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        AddFornecedor()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditFornecedor()

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ApagarFornecedor()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

    '---------Rotinas abaixo-----------

    Private Sub AddFornecedor()


        Dim FormularioDadosFornecedor As New FrmFornecedor
        FormularioDadosFornecedor.vl = 0
        Dim Code As Integer = GerarCodigo("fornecedores")
        FormularioDadosFornecedor.CarregarEstado(1, FormularioDadosFornecedor.CbUf)

        FormularioDadosFornecedor.lblChave.Text = Code
        FormularioDadosFornecedor.CbTipoDoc.SelectedIndex = 0

        FormularioDadosFornecedor.ShowDialog()
        Try
            If FormularioDadosFornecedor.DialogResult = Windows.Forms.DialogResult.OK Then

                Dim Codigo As String = FormularioDadosFornecedor.lblChave.Text
                Dim Razao As String = FormularioDadosFornecedor.txtRazao.Text
                Dim Fantasia As String = FormularioDadosFornecedor.txtFantasia.Text
                Dim Cnpj As String = RemoveCaracteres(FormularioDadosFornecedor.txtCnpj.Text)
                Dim Contato As String = FormularioDadosFornecedor.txtContato.Text
                Dim Telefone As String = RemoveCaracteres(FormularioDadosFornecedor.txtTelefone.Text)
                Dim Telefone2 As String = RemoveCaracteres(FormularioDadosFornecedor.txtTelefone2.Text)
                Dim Email As String = FormularioDadosFornecedor.txtEmail.Text
                Dim Endereco As String = FormularioDadosFornecedor.txtEndereco.Text
                Dim Numero As String = FormularioDadosFornecedor.txtNum.Text
                Dim Pagto As String = FormularioDadosFornecedor.TxtPagto.Text
                Dim Uf As String = FormularioDadosFornecedor.CbUf.SelectedItem
                Dim Muni As String = FormularioDadosFornecedor.CbMunicipio.SelectedItem
                Dim Ie As String = FormularioDadosFornecedor.txtNFeIE.Text
                Dim isento As String = FormularioDadosFornecedor.isento
                Dim TipoDoc As String = FormularioDadosFornecedor.CbTipoDoc.SelectedItem

                conexão.Close()
                conexão.Open()
                'Dim variavel As String
                'variavel = "VALUES ('" & Codigo & "','" & Razao & "','" & Fantasia & "','" & Cnpj & "','" & Endereco & "','" & Contato & "','" & Telefone & "','" & Telefone2 & "','" & Email & "'"
                'MsgBox(variavel)

                Dim sqlCom As String = "INSERT INTO fornecedores ([RazaoSocial],[NomeFantasia],[CNPJ],[Endereco],[Numero],[Contato],[Telefone1],[Telefone2],[Email],[Pagto],[UF],[Municipio],[IE],[Isento],[Tipo]) VALUES ('" & Razao & "','" & Fantasia & "','" & Cnpj & "','" & Endereco & "','" & Numero & "','" & Contato & "','" & Telefone & "','" & Telefone2 & "','" & Email & "','" & Pagto & "','" & Uf & "','" & Muni & "','" & Ie & "'," & isento & ",'" & TipoDoc & "')"
                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim Ra As Integer = MyCommand.ExecuteNonQuery

                Hide()
                Dim frmNovo As New FrmListaFornecedores
                conexão.Close()

                frmNovo.ShowDialog()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub EditFornecedor()


        Dim FormularioDadosFornecedor As New FrmFornecedor
        FormularioDadosFornecedor.vl = 1
        FormularioDadosFornecedor.CarregarEstado(1, FormularioDadosFornecedor.CbUf)

        conexão.Close()
        conexão.Open()
        Dim i As Integer

        Try
            i = DtvFornecedores.CurrentRow.Index
        Catch ex As Exception
            MsgBox(ex.Message & ": Não é possível editar um registro vazio!")
            Exit Sub
        End Try

        Dim varCodigo As Object = DtvFornecedores.Item(0, i).Value
        'MsgBox(varCodigo)
        Dim sqlCom As String = "SELECT * FROM fornecedores WHERE [Codigo]=" & DtvFornecedores.Item(0, i).Value & " "
        'Dim MyCommand As New OleDbCommand(sqlCom, conexão)
        'Dim Ra As Integer = MyCommand.ExecuteNonQuery

        Try
            ' Create the command.
            Dim reader1 As OleDbDataReader
            Dim command As OleDbCommand = conexão.CreateCommand()
            command.CommandText = sqlCom
            reader1 = command.ExecuteReader()

            reader1.Read()

            FormularioDadosFornecedor.lblChave.Text = reader1(0)
            If Not IsDBNull(reader1(1)) Then FormularioDadosFornecedor.txtRazao.Text = reader1(1)
            If Not IsDBNull(reader1(2)) Then FormularioDadosFornecedor.txtFantasia.Text = reader1(2)
            If Not IsDBNull(reader1(3)) Then FormularioDadosFornecedor.txtCnpj.Text = reader1(3)
            If Not IsDBNull(reader1(4)) Then FormularioDadosFornecedor.txtEndereco.Text = reader1(4)
            If Not IsDBNull(reader1(5)) Then FormularioDadosFornecedor.txtNum.Text = reader1(5)
            If Not IsDBNull(reader1(6)) Then FormularioDadosFornecedor.txtContato.Text = reader1(6)
            If Not IsDBNull(reader1(7)) Then FormularioDadosFornecedor.txtTelefone.Text = reader1(7)
            If Not IsDBNull(reader1(8)) Then FormularioDadosFornecedor.txtTelefone2.Text = reader1(8)
            If Not IsDBNull(reader1(9)) Then FormularioDadosFornecedor.txtEmail.Text = reader1(9)
            If Not IsDBNull(reader1(10)) Then FormularioDadosFornecedor.TxtPagto.Text = reader1(10)

            If Not IsDBNull(reader1(11)) Then FormularioDadosFornecedor.CbUf.SelectedItem = reader1(11)
            If Not IsDBNull(reader1(12)) Then FormularioDadosFornecedor.CbMunicipio.SelectedItem = reader1(12)
            If Not IsDBNull(reader1(13)) Then FormularioDadosFornecedor.txtNFeIE.Text = reader1(13)
            If Not IsDBNull(reader1(14)) Then FormularioDadosFornecedor.isento = reader1(14)

            If Not IsDBNull(reader1(15)) Then FormularioDadosFornecedor.CbTipoDoc.SelectedItem = reader1(15)

            Hide()
            FormularioDadosFornecedor.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Dispose()
        End Try

        Dim frmNovo As New FrmListaFornecedores
        conexão.Close()
        frmNovo.ShowDialog()

    End Sub

    Private Sub ApagarFornecedor()

        Try


            conexão.Close()
            conexão.Open()
            Dim i As Integer = DtvFornecedores.CurrentRow.Index
            Dim varCodigo As String = DtvFornecedores.Item(0, i).Value

            Dim msgb As MsgBoxResult = MsgBox("Tem certeza que deseja excluir o fornecedor " & varCodigo & "?  " & vbNewLine & _
                   "Descrição: " & DtvFornecedores.Item(1, i).Value, MsgBoxStyle.YesNo)
            If msgb = MsgBoxResult.Yes Then

                Dim sqlCom As String = "DELETE * FROM fornecedores WHERE Codigo = " & varCodigo & ""
                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim Ra As Integer = MyCommand.ExecuteNonQuery
                Me.Hide()
                Dim frmNovo As New FrmListaFornecedores
                conexão.Close()
                frmNovo.ShowDialog()

            Else

                conexão.Close()
                Exit Sub

            End If


        Catch ex As Exception

            MsgBox(ex.Message)
            Dim frmNovo As New FrmListaFornecedores
            conexão.Close()
            frmNovo.ShowDialog()

        End Try


    End Sub

    Private Sub PreencherLista(filtro As String)

        Try

            DtvFornecedores.Rows.Clear()
            Dim ole As String = "SELECT * FROM fornecedores"
            If Trim(filtro) <> "" Then
                ole = "SELECT * FROM fornecedores WHERE ([RazaoSocial] LIKE '%" & LCase(filtro) & "%' OR [NomeFantasia] LIKE '%" & LCase(filtro) & "%' OR [CNPJ] LIKE '%" & LCase(filtro) & "%')"
            End If
            Dim OleCom As New OleDbCommand(ole, conexão)
            Dim oleAdapter As New OleDbDataAdapter(OleCom)
            Dim ds As New DataSet()
            oleAdapter.Fill(ds)

            For Each dr As DataRow In ds.Tables(0).Rows
                DtvFornecedores.Rows.Add(dr.Item(0).ToString, dr.Item(1).ToString, dr.Item(2).ToString, dr.Item(3).ToString, dr.Item(7).ToString)
            Next

            Timer1.Stop()
        Catch ex As Exception
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
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

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImport.Click

        Dim frm As New FrmTipoImport
        frm.ShowDialog()
        If frm.DialogResult = Forms.DialogResult.OK Then
            If frm.TIPOS = 1 Then
                OpenFileDialog1.Filter = "(Excel Files)|*.xls;*.xlsx;*.csv|Xls, | *.xls|Xlsx, | *.xlsx|Csv, | *.csv"
                TipoArq = 1
            ElseIf frm.TIPOS = 2 Then
                OpenFileDialog1.Filter = "(Notepad Files)|*.txt|Txt, | *.txt"
                TipoArq = 2
            End If
            OpenFileDialog1.ShowDialog()
        End If

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim frm As New ProcessoImportacao
        frm.Processo = 2
        frm.tipoarq = TipoArq
        frm.nomearq = OpenFileDialog1.FileName
        frm.ShowDialog()

        Hide()
        Dim frmNovo As New FrmListaFornecedores
        conexão.Close()
        frmNovo.ShowDialog()
    End Sub

    Private Sub TxtFiltro_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltro.TextChanged

        Timer1.Stop()
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PreencherLista(TxtFiltro.Text)
    End Sub

End Class
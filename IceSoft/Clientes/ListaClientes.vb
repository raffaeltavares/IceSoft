'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows


Public Class ListaClientes

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

        If VerificaUser(Usuario) = "Padrao" Then
            btnDel.Enabled = False
        Else
            btnDel.Enabled = True
        End If

        Timer1.Interval = 500

        PreencherLista("")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        AddCliente()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditCliente()

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ApagarCliente()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub


    '---------Rotinas abaixo-----------

    Private Sub AddCliente()


        Dim FormCliente As New FrmCliente
        FormCliente.vl = 0
        'Dim Code As Integer = GerarCodigo("clientes")

        'FormCliente.lblChave.Text = Code
        FormCliente.lbResponsavel.Text = Usuario
        FormCliente.ShowDialog()

        Try
            If FormCliente.DialogResult = Windows.Forms.DialogResult.OK Then

                Dim Codigo As String = FormCliente.lblChave.Text
                Dim Resp As String = FormCliente.lbResponsavel.Text
                Dim Nome As String = FormCliente.txtNome.Text
                Dim CPF As String = RemoveCaracteres(FormCliente.txtCpf.Text)
                Dim Telefone As String = RemoveCaracteres(FormCliente.txtTelefone.Text)
                Dim Email As String = FormCliente.TxtEmail.Text
                Dim Data As String = FormCliente.txtData.Text

                conexão.Close()
                conexão.Open()
                'Dim variavel As String
                'variavel = "VALUES ('" & Codigo & "','" & Razao & "','" & Fantasia & "','" & Cnpj & "','" & Endereco & "','" & Contato & "','" & Telefone & "','" & Telefone2 & "','" & Email & "'"
                'MsgBox(variavel)

                Dim sqlCom As String = "INSERT INTO clientes ([RespCad],[Nome],[CPF],[Telefone],[Email],[data]) VALUES ('" & Resp & "','" & Nome & "','" & CPF & "','" & Telefone & "','" & Email & "','" & Data & "' )"
                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim Ra As Integer = MyCommand.ExecuteNonQuery

                Hide()
                Dim frmNovo As New ListaClientes
                conexão.Close()

                frmNovo.ShowDialog()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub EditCliente()


        Dim FormCliente As New FrmCliente
        FormCliente.vl = 1

        conexão.Close()
        conexão.Open()
        Dim i As Integer
        Dim ccodigo As String = Nothing
        Dim municipio As String = Nothing
        Dim Uf As String = Nothing
        Dim crow As Integer = 0
        Dim cbxMun As DataGridViewComboBoxCell
        Dim cbxUf As DataGridViewComboBoxCell

        Try
            i = DtvClientes.CurrentRow.Index
        Catch ex As Exception
            MsgBox(ex.Message & ": Não é possível editar um registro vazio!")
            Exit Sub
        End Try

        Dim varCodigo As Object = DtvClientes.Item(0, i).Value
        'MsgBox(varCodigo)
        Dim sqlCom As String = "SELECT * FROM clientes WHERE [Codigo]=" & DtvClientes.Item(0, i).Value & " "

        Try
            ' Create the command.
            Dim reader1 As OleDbDataReader
            Dim command As OleDbCommand = conexão.CreateCommand()
            command.CommandText = sqlCom
            reader1 = command.ExecuteReader()

            reader1.Read()

            ccodigo = reader1(0)
            FormCliente.lblChave.Text = reader1(0)
            FormCliente.lbResponsavel.Text = If(IsDBNull(reader1(1)), "", reader1(1))
            FormCliente.txtNome.Text = If(IsDBNull(reader1(2)), "", reader1(2))
            FormCliente.txtCpf.Text = If(IsDBNull(reader1(3)), "", reader1(3))
            FormCliente.txtTelefone.Text = If(IsDBNull(reader1(4)), "", reader1(4))
            FormCliente.TxtEmail.Text = If(IsDBNull(reader1(5)), "", reader1(5))
            FormCliente.txtData.Text = If(IsDBNull(reader1(6)), "", reader1(6))

            'MsgBox(reader1(0) & " - " & reader1(1) & " - " & reader1(2) & " - " & reader1(3) & " - " & reader1(4) & " - " & reader1(5) & " - " & reader1(6) & " - ")

            conexão.Close()
            Hide()
            FormCliente.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Dispose()
        End Try

        Dim frmNovo As New ListaClientes
        conexão.Close()
        frmNovo.ShowDialog()

    End Sub

    Private Sub ApagarCliente()

        Try


            conexão.Close()
            conexão.Open()
            Dim i As Integer = DtvClientes.CurrentRow.Index
            Dim varCodigo As String = DtvClientes.Item(0, i).Value

            Dim msgb As MsgBoxResult = MsgBox("Tem certeza que deseja excluir o Cliente " & varCodigo & "?  " & vbNewLine &
                   "Descrição: " & DtvClientes.Item(1, i).Value, MsgBoxStyle.YesNo)
            If msgb = MsgBoxResult.Yes Then

                Dim sqlCom As String = "DELETE * FROM clientes WHERE Codigo = " & varCodigo & ""
                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim Ra As Integer = MyCommand.ExecuteNonQuery

                Me.Hide()
                Dim frmNovo As New ListaClientes
                conexão.Close()
                frmNovo.ShowDialog()

            Else

                conexão.Close()
                Exit Sub

            End If


        Catch ex As Exception

            MsgBox(ex.Message)
            Dim frmNovo As New ListaClientes
            conexão.Close()
            frmNovo.ShowDialog()

        End Try


    End Sub

    Private Sub PreencherLista(filtro As String)

        Try

            DtvClientes.Rows.Clear()

            Dim ole As String = "SELECT * FROM clientes WHERE ([Nome] LIKE '%" & LCase(filtro) & "%' OR [CPF] LIKE '%" & LCase(filtro) & "%' OR [Telefone] LIKE '%" & LCase(filtro) & "%')"
            Dim OleCom As New OleDbCommand(ole, conexão)
            Dim oleAdapter As New OleDbDataAdapter(OleCom)
            Dim ds As New DataSet()
            oleAdapter.Fill(ds, "clientes")

            For Each dr As DataRow In ds.Tables("clientes").Rows
                DtvClientes.Rows.Add(dr.Item(0).ToString, dr.Item(1).ToString, dr.Item(2).ToString, dr.Item(3).ToString,
                                         dr.Item(4).ToString, dr.Item(5).ToString, dr.Item(6).ToString)
            Next

            Timer1.Stop()
        Catch ex As Exception
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PreencherLista(TxtFiltro.Text)
    End Sub

    Private Function GerarCodigo(ByVal nometabela As String) As Integer

        Dim i As Integer = 1

        Dim ole1 As String = "SELECT MAX(Codigo) FROM " & nometabela & ""
        Dim OleCom1 As New OleDbCommand(ole1, conexão)
        Dim oleAdapter1 As New OleDbDataAdapter(OleCom1)
        Dim ds1 As New DataSet()
        Dim dr As DataRow
        oleAdapter1.Fill(ds1)

        If ds1.Tables(0).Rows.Count > 0 Then
            Dim j As Integer = ds1.Tables(0).Rows(0).Item(0)
            Return j + 1
        Else
            Return i
        End If

    End Function

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImport.Click

        'OpenFileDialog1.ShowDialog()
        'Dim frm As New FrmImportFornecedor
        'frm.ObterLista(OpenFileDialog1.FileName)

    End Sub

    Private Sub TxtFiltro_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltro.TextChanged
        Timer1.Stop()
        Timer1.Start()
    End Sub

End Class
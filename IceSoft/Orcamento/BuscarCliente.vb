'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows

Public Class FrmBuscaCliente

    Public Linha As Integer
    Public mode As Integer = 0
    Public ClienteAtual As Cliente


    Public Class Cliente
        Public Id As Integer = 0
        Public Nome As String = ""
        Public CPF As String = ""
        Public Telefone As String = ""
        Public Email As String = ""
        Public Data As String = ""
    End Class

    Private Sub FrmAddCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        'If IO.File.Exists(xres & "fundo-geral.jpg") Then
        '    Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
        '    Me.BackgroundImage = back1
        'End If

        If IO.File.Exists(xres & "add_file.png") Then
            Dim back2 As New Bitmap(xres & "add_file.png")
            Me.btnAdicionar.Image = back2
        End If

        If IO.File.Exists(xres & "exit.png") Then
            Dim back5 As New Bitmap(xres & "exit.png")
            Me.btnSair.Image = back5
        End If

        Timer1.Interval = 500

        PreencherLista("")

    End Sub

    Private Sub PreencherLista(filtro As String)

        Try

            DtvClientes.Rows.Clear()

            Dim ole As String = "SELECT * FROM clientes WHERE ([Nome] LIKE '%" & LCase(filtro) & "%' OR [CPF] LIKE '%" & LCase(filtro) & "%' OR [Telefone] LIKE '%" & LCase(filtro) & "%')"
            Dim OleCom As New OleDbCommand(ole, conexão)
            Dim oleAdapter As New OleDbDataAdapter(OleCom)
            Dim ds As New DataSet()
            oleAdapter.Fill(ds)

            For Each dr As DataRow In ds.Tables(0).Rows
                DtvClientes.Rows.Add(dr.Item(0).ToString, dr.Item(1).ToString, dr.Item(2).ToString, dr.Item(3).ToString,
                                         dr.Item(4).ToString, dr.Item(5).ToString, dr.Item(6).ToString)
            Next

            Timer1.Stop()
        Catch ex As Exception
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub


    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub TxtFiltro_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltro.TextChanged

        Timer1.Stop()
        Timer1.Start()

    End Sub

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

                Dim sqlCom As String = "INSERT INTO clientes ([RespCad],[Nome],[CPF],[Telefone],[Email],[data]) VALUES ('" & Resp & "','" & Nome & "','" & CPF & "','" & Telefone & "','" & Email & "','" & Data & "' )"
                Dim MyCommand As New OleDbCommand(sqlCom, conexão)
                Dim Ra As Integer = MyCommand.ExecuteNonQuery
                Hide()


                Dim sqlStr As String = "SELECT MAX(Codigo) FROM clientes"
                Dim sqlCom0 As New OleDbCommand(sqlStr, conexão)
                Dim sqlAdap As New OleDbDataAdapter(sqlCom0)
                Dim ds As New DataSet()
                sqlAdap.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    ClienteAtual = New Cliente
                    With ClienteAtual
                        .Id = ds.Tables(0).Rows(0).Item(0)
                        .Nome = Nome
                        .CPF = CPF
                        .Telefone = Telefone
                        .Email = Email
                        .Data = Data
                    End With
                End If
                conexão.Close()
                'Dim frmNovo As New FrmAddCliente
                'frmNovo.ShowDialog()

                Me.DialogResult = DialogResult.OK
                Me.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
        End Try


    End Sub

    Private Function GerarCodigo() As Integer

        Dim i As Integer = 0

        Dim ole1 As String = "SELECT * FROM clientes"
        Dim OleCom1 As New OleDbCommand(ole1, conexão)
        Dim oleAdapter1 As New OleDbDataAdapter(OleCom1)
        Dim ds1 As New DataSet()
        Dim dr As DataRow

        oleAdapter1.Fill(ds1)
        Dim j As Integer = ds1.Tables(0).Rows.Count
        'MsgBox("Numero de linhas" & j)

        If j = 0 Then
            i = i + 1
            'MsgBox("Identificou Num de linhas menor que: " & 1)
            GerarCodigo = i

        Else

            Do Until i > j
                i = i + 1

                'MsgBox("Lendo linha: " & i & " - de: " & j)
                For Each dr In ds1.Tables(0).Rows
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


    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        AddCliente()
    End Sub

    Private Sub DtvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtvClientes.CellContentClick
        If e.ColumnIndex = 7 Then
            ClienteAtual = New Cliente
            With ClienteAtual
                .Id = DtvClientes.Item(0, e.RowIndex).Value
                .Nome = DtvClientes.Item(2, e.RowIndex).Value
                .CPF = DtvClientes.Item(3, e.RowIndex).Value
                .Telefone = DtvClientes.Item(4, e.RowIndex).Value
                .Email = DtvClientes.Item(5, e.RowIndex).Value
                .Data = DtvClientes.Item(6, e.RowIndex).Value
            End With
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PreencherLista(TxtFiltro.Text)
    End Sub

    Private Sub DtvOrca_KeyDown(sender As Object, e As KeyEventArgs) Handles DtvClientes.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
        If Not IsNothing(DtvClientes.CurrentRow) Then
            Dim row = DtvClientes.CurrentRow.Index
            If e.KeyCode = Keys.Enter Then
                e.Handled = False
                ClienteAtual = New Cliente
                With ClienteAtual
                    .Id = DtvClientes.Item(0, row).Value
                    .Nome = DtvClientes.Item(2, row).Value
                    .CPF = DtvClientes.Item(3, row).Value
                    .Telefone = DtvClientes.Item(4, row).Value
                    .Email = DtvClientes.Item(5, row).Value
                    .Data = DtvClientes.Item(6, row).Value
                End With
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

End Class
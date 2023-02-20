'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data.OleDb
Imports System.Windows
Imports System.Text

Public Class FrmFornecedor

    Public vl As Integer
    Public isento As Integer = 0

    Private Sub FrmFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If IO.File.Exists(xres & "fundo-geral.jpg") Then
        '    Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
        '    Me.BackgroundImage = back1
        'End If

        If IO.File.Exists(xres & "accept_database.png") Then
            Dim back2 As New Bitmap(xres & "accept_database.png")
            Me.btnOk.Image = back2
        End If

        If IO.File.Exists(xres & "cancel.png") Then
            Dim back3 As New Bitmap(xres & "cancel.png")
            Me.Button2.Image = back3
        End If

        If isento = 0 Then
            txtNFeIE.Enabled = True
            chkIsento.Checked = True
        Else
            txtNFeIE.Text = ""
            txtNFeIE.Enabled = False
            chkIsento.Checked = False
        End If

        'MsgBox(vl)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Cadastrar(vl)

    End Sub

    Private Sub Cadastrar(ByVal v As Integer)

        If v = 0 Then

        Else
            Editando()
        End If

    End Sub

    Private Sub Editando()

        Try

            conexão.Close()
            conexão.Open()

            Dim sqlCom As String = "UPDATE fornecedores  SET [RazaoSocial] = '" & Me.txtRazao.Text & "', [NomeFantasia] = '" & Me.txtFantasia.Text & "', " &
                "[CNPJ] = '" & RemoveCaracteres(Me.txtCnpj.Text) & "', [Endereco] = '" & Me.txtEndereco.Text.Replace(",", "-") & "', [Numero] = '" & Me.txtNum.Text & "', [Contato] = '" & Me.txtContato.Text & "', " &
                "[Telefone1] = '" & RemoveCaracteres(Me.txtTelefone.Text) & "', [Telefone2] = '" & RemoveCaracteres(Me.txtTelefone2.Text) & "', [Email] = '" & Me.txtEmail.Text & "', [Pagto] = '" & Me.TxtPagto.Text & "', " &
                "[UF] = '" & Me.CbUf.SelectedItem & "', [Municipio] = '" & Me.CbMunicipio.SelectedItem & "', [IE] = '" & Me.txtNFeIE.Text & "', [Isento] = " & isento & " WHERE [Codigo] = " & Me.lblChave.Text & " "
            Dim MyCommand As New OleDbCommand(sqlCom, conexão)
            Dim Ra As Integer = MyCommand.ExecuteNonQuery

            conexão.Close()
            Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
            conexão.Close()
        End Try

    End Sub

    Private Sub CbUF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbUf.SelectedIndexChanged
        CarregarCidades(GetEstadoSelecionado(CbUf.SelectedItem), CbMunicipio)
    End Sub

    Public Sub CarregarEstado(pais As Integer, cbx As ComboBox)

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

    Public Sub CarregarCidades(estado As Integer, cbx As ComboBox)

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


    Private Sub chkIsento_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsento.CheckedChanged

        If chkIsento.Checked = True Then
            isento = 1
        Else
            isento = 0
        End If

        If isento = 0 Then
            txtNFeIE.Enabled = True
        Else
            txtNFeIE.Text = ""
            txtNFeIE.Enabled = False
        End If

    End Sub

    Private Sub CbTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTipoDoc.SelectedIndexChanged
        If CbTipoDoc.SelectedIndex = 0 Then
            txtCnpj.Mask = "00,000,000/0000-00"
        ElseIf CbTipoDoc.SelectedIndex = 1 Then
            txtCnpj.Mask = "000,000,000-00"
        Else
            txtCnpj.Mask = ""
        End If
    End Sub


End Class
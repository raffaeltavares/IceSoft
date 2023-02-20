'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data.OleDb
Imports System.Windows


Public Class Material

    Public vl As Integer
    Public imgLoc As String
    Public valatual As Double
    Public vlfinal As Double = 0
    Public flagSelect As Boolean = False
    Private ListaCategorias As List(Of Categoria)

    Public CategAtual As Integer = -1
    Public FornecAtual As Integer = -1

    Public Class Categoria
        Public id As Integer = 0
        Public Nome As String = ""
        Public Unidade As String = ""
        Public Fator As Single = 1
    End Class

    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        ListaCategorias = New List(Of Categoria)

    End Sub

    Private Sub FrmFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If IO.File.Exists(xres & "fundo-geral.jpg") Then
        '    Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
        '    Me.BackgroundImage = back1
        'End If
        'MsgBox("Entrou no Load")


        If IO.File.Exists(xres & "accept_database.png") Then
            Dim back2 As New Bitmap(xres & "accept_database.png")
            Me.btnOkm.Image = back2
        End If

        If IO.File.Exists(xres & "cancel.png") Then
            Dim back3 As New Bitmap(xres & "cancel.png")
            Me.Button2.Image = back3
        End If

        If LTrim(RTrim(txtValor.Text)) = Nothing Then
            txtValor.Text = 0
        End If
        If LTrim(RTrim(txtIPI.Text)) = Nothing Then
            txtIPI.Text = 0
        End If
        If LTrim(RTrim(txtFrete.Text)) = Nothing Then
            txtFrete.Text = 0
        End If
        If LTrim(RTrim(txtPar1.Text)) = Nothing Then
            txtPar1.Text = 0
        End If

        If LTrim(RTrim(TxtQtd.Text)) = Nothing Then
            TxtQtd.Text = 0
            TxtValorQtd.Text = 0
        End If


        'txtValorFinal.Text = Decimal.Ceiling((txtValor.Text) + CalcIPI(CDbl(txtIPI.Text)) + CalcFrete(CDbl(txtFrete.Text)))

        flagSelect = True

        If CategAtual <> -1 Then
            If CbTipo.Items.Count > 0 Then
                For i = 0 To CbTipo.Items.Count - 1
                    Dim cont() = CbTipo.Items(i).ToString().Split("-")
                    If cont.Count > 0 Then
                        If cont(0) = CategAtual Then
                            CbTipo.SelectedIndex = i
                            Exit For
                        End If
                    End If
                Next
            End If
        Else
            If CbTipo.Items.Count > 0 Then
                CbTipo.SelectedIndex = 0
            End If
        End If

        ChangeCateg()

        If FornecAtual <> -1 Then
            If CbFornecedor.Items.Count > 0 Then
                For i = 0 To CbFornecedor.Items.Count - 1
                    Dim cont() = CbFornecedor.Items(i).ToString().Split("-")
                    If cont.Count > 0 Then
                        If cont(0) = FornecAtual Then
                            CbFornecedor.SelectedIndex = i
                            Exit For
                        End If
                    End If
                Next
            End If
        Else
            If CbFornecedor.Items.Count > 0 Then
                CbFornecedor.SelectedIndex = 0
            End If
        End If


    End Sub

    Public Sub PreencherCategorias()

        For Each dt As DataRow In CategoriasDS.Tables(0).Rows

            Dim nCat = New Categoria() With {
                .id = dt(0),
                .Nome = dt(1),
                .Unidade = dt(2),
                .Fator = dt(3)
            }

            ListaCategorias.Add(nCat)

            CbTipo.Items.Add(nCat.id & "-" & nCat.Nome)

        Next

        If CbTipo.Items.Count > 0 Then
            CbTipo.SelectedIndex = 0
        End If

    End Sub

    Public Sub PreencherFornecedores()

        For Each dt As DataRow In FornecedoresDS.Tables(0).Rows
            CbFornecedor.Items.Add(dt.Item(0).ToString & "-" & If(dt.Item(2).ToString <> "", dt.Item(2).ToString, dt.Item(1).ToString))
        Next
        If CbFornecedor.Items.Count > 0 Then
            CbFornecedor.SelectedIndex = 0
        End If

    End Sub

    Private Sub btnOkm_Click(sender As Object, e As EventArgs) Handles btnOkm.Click

        If vl = 2 Then
            Duplicando()
        ElseIf vl = 1 Then
            Editando()
        Else
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



    Private Sub Editando()

        Try

            conexão.Close()
            conexão.Open()
            Dim sqlCom As String = "UPDATE materiaprima SET [Descricao] = '" & Me.txtDescricao.Text & "', [Fornecedor] = " & FornecAtual & ", " &
                "[Categoria] = " & CategAtual & ", [Unidade] = '" & Me.lblUnidade.Text & "', [Preco] = " & Replace(Me.txtValor.Text, ",", ".") & ", [imposto] = " & Replace(Me.txtIPI.Text, ",", ".") & ", [FRETE] = " & Replace(Me.txtFrete.Text, ",", ".") & ", " &
                "[valorFinal] = " & Replace(Me.txtValorFinal.Text, ",", ".") & ", [volume] = " & Me.txtPar1.Text.Replace(",", ".") & ", [CodFornecedor] = '" & Me.TxtCodFornecedor.Text & "', [Data] = '" & Me.TxtData.Text & "', [estoque] = " & Me.TxtQtd.Text.Replace(",", ".") & ", [ValorEstoque] = " & Me.TxtValorQtd.Text.Replace(",", ".") & " WHERE [Codigo] = '" & Me.txtCodigo.Text & "' "

            Dim MyCommand As New OleDbCommand(sqlCom, conexão)
            Dim Ra As Integer = MyCommand.ExecuteNonQuery
            conexão.Close()
            Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Erro inesperado")
            conexão.Close()
        End Try

    End Sub

    Private Sub Duplicando()

        Dim Codigo As String = Me.txtCodigo.Text
        Dim Descricao As String = Me.txtDescricao.Text
        Dim Categoria As String = Me.CategAtual
        Dim unidade As String = Me.lblUnidade.Text
        Dim Fornecedor As String = Me.FornecAtual
        Dim Valor As String = Replace(Me.txtValor.Text, ",", ".")
        Dim Frete As String = Replace(Me.txtFrete.Text, ",", ".")
        Dim IPI As String = Replace(Me.txtIPI.Text, ",", ".")
        Dim Volume As String = Replace(Me.txtPar1.Text, ",", ".")
        Dim ValorFinal As String = Replace(Me.txtValorFinal.Text, ",", ".")
        Dim CodFornecedor As String = Me.TxtCodFornecedor.Text
        Dim Data As String = Me.TxtData.Text
        Dim Qtde As String = Replace(Me.TxtQtd.Text, ",", ".")
        Dim ValorQde As String = Replace(Me.TxtValorQtd.Text, ",", ".")

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
            Close()

        Catch ex As Exception
            conexão.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
        End Try


    End Sub

    Sub ChangeCateg()
        If Not IsNothing(CbTipo.SelectedItem) Then
            Dim content() As String = CbTipo.SelectedItem.ToString().Split("-")
            If content.Count > 0 Then
                Dim categ As Categoria = ListaCategorias.Find(Function(c) c.id = content(0))
                If Not IsNothing(categ) Then
                    lblUnidade.Text = categ.Unidade
                    CategAtual = categ.id

                    Select Case lblUnidade.Text
                        Case "g"
                            lbUnidadeText.Text = "Gramas por unidade"
                        Case "ml"
                            lbUnidadeText.Text = "Mililitros por unidade"
                        Case "u"
                            lbUnidadeText.Text = "Partes por unidade"
                    End Select
                End If
            End If
        End If
    End Sub

    Private Sub CbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTipo.SelectedIndexChanged

        If flagSelect = True Then
            ChangeCateg()
        End If

    End Sub


    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged

        If LTrim(RTrim(txtValor.Text)) = Nothing Then
            txtValor.Text = 0
        End If
        If LTrim(RTrim(txtIPI.Text)) = Nothing Then
            txtIPI.Text = 0
        End If
        If LTrim(RTrim(txtFrete.Text)) = Nothing Then
            txtFrete.Text = 0
        End If
        If LTrim(RTrim(txtPar1.Text)) = Nothing Then
            txtPar1.Text = 1
        Else
            If CSng(txtPar1.Text) <= 0 Then
                txtPar1.Text = 1
            End If
        End If


        Try

            vlfinal = Decimal.Ceiling((txtValor.Text) + CalcIPI(CDbl(txtIPI.Text)) + CalcFrete(CDbl(txtFrete.Text)))
            txtValorFinal.Text = vlfinal

            If txtPar1.Text <> "" And txtValor.Text <> "" Then
                Select Case lblUnidade.Text
                    Case "g"
                        txtValorFinal.Text = vlfinal / CDbl(txtPar1.Text)
                    Case "ml"
                        txtValorFinal.Text = vlfinal / CDbl(txtPar1.Text)
                    Case "u"
                        txtValorFinal.Text = vlfinal / CDbl(txtPar1.Text)
                End Select
            End If


            If LTrim(RTrim(TxtQtd.Text)) = Nothing Then
                TxtQtd.Text = 0
                TxtValorQtd.Text = 0
            Else
                If IsNumeric(TxtQtd.Text) And IsNumeric(txtValorFinal.Text) Then
                    TxtValorQtd.Text = CDbl(txtValorFinal.Text) * CDbl(TxtQtd.Text)
                Else
                    TxtValorQtd.Text = 0
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atenção")
        End Try

        Me.Update()

    End Sub

    Private Sub txtIPI_TextChanged(sender As Object, e As EventArgs) Handles txtIPI.TextChanged


        If LTrim(RTrim(txtValor.Text)) = Nothing Then
            txtValor.Text = 0
        End If
        If LTrim(RTrim(txtIPI.Text)) = Nothing Then
            txtIPI.Text = 0
        End If
        If LTrim(RTrim(txtFrete.Text)) = Nothing Then
            txtFrete.Text = 0
        End If
        If LTrim(RTrim(txtPar1.Text)) = Nothing Then
            txtPar1.Text = 1
        Else
            If CSng(txtPar1.Text) <= 0 Then
                txtPar1.Text = 1
            End If
        End If

        Try

            vlfinal = Decimal.Ceiling((txtValor.Text) + CalcIPI(CDbl(txtIPI.Text)) + CalcFrete(CDbl(txtFrete.Text)))
            txtValorFinal.Text = vlfinal

            If txtPar1.Text <> "" And txtValor.Text <> "" Then
                Select Case lblUnidade.Text
                    Case "g"
                        txtValorFinal.Text = vlfinal / CDbl(txtPar1.Text)
                    Case "ml"
                        txtValorFinal.Text = vlfinal / CDbl(txtPar1.Text)
                    Case "u"
                        txtValorFinal.Text = vlfinal / CDbl(txtPar1.Text)
                End Select
            End If


            If LTrim(RTrim(TxtQtd.Text)) = Nothing Then
                TxtQtd.Text = 0
                TxtValorQtd.Text = 0
            Else
                If IsNumeric(TxtQtd.Text) And IsNumeric(txtValorFinal.Text) Then
                    TxtValorQtd.Text = CDbl(txtValorFinal.Text) * CDbl(TxtQtd.Text)
                Else
                    TxtValorQtd.Text = 0
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atenção")
        End Try


        Me.Update()

    End Sub

    Private Sub txtFrete_TextChanged(sender As Object, e As EventArgs) Handles txtFrete.TextChanged


        If LTrim(RTrim(txtValor.Text)) = Nothing Then
            txtValor.Text = 0
        End If
        If LTrim(RTrim(txtIPI.Text)) = Nothing Then
            txtIPI.Text = 0
        End If
        If LTrim(RTrim(txtFrete.Text)) = Nothing Then
            txtFrete.Text = 0
        End If
        If LTrim(RTrim(txtPar1.Text)) = Nothing Then
            txtPar1.Text = 1
        Else
            If CSng(txtPar1.Text) <= 0 Then
                txtPar1.Text = 1
            End If
        End If

        Try

            vlfinal = Decimal.Ceiling((txtValor.Text) + CalcIPI(CDbl(txtIPI.Text)) + CalcFrete(CDbl(txtFrete.Text)))
            txtValorFinal.Text = vlfinal

            If txtPar1.Text <> "" And txtValor.Text <> "" Then
                Select Case lblUnidade.Text
                    Case "g"
                        txtValorFinal.Text = vlfinal / CDbl(txtPar1.Text)
                    Case "ml"
                        txtValorFinal.Text = vlfinal / CDbl(txtPar1.Text)
                    Case "u"
                        txtValorFinal.Text = vlfinal / CDbl(txtPar1.Text)
                End Select
            End If

            If LTrim(RTrim(TxtQtd.Text)) = Nothing Then
                TxtQtd.Text = 0
                TxtValorQtd.Text = 0
            Else
                If IsNumeric(TxtQtd.Text) And IsNumeric(txtValorFinal.Text) Then
                    TxtValorQtd.Text = CDbl(txtValorFinal.Text) * CDbl(TxtQtd.Text)
                Else
                    TxtValorQtd.Text = 0
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atenção")
        End Try


        Me.Update()

    End Sub

    Private Sub txtPar1_TextChanged(sender As Object, e As EventArgs) Handles txtPar1.TextChanged


        If LTrim(RTrim(txtValor.Text)) = Nothing Then
            txtValor.Text = 0
        End If
        If LTrim(RTrim(txtIPI.Text)) = Nothing Then
            txtIPI.Text = 0
        End If
        If LTrim(RTrim(txtFrete.Text)) = Nothing Then
            txtFrete.Text = 0
        End If
        If LTrim(RTrim(txtPar1.Text)) = Nothing Then
            txtPar1.Text = 1
        Else
            If CSng(txtPar1.Text) <= 0 Then
                txtPar1.Text = 1
            End If
        End If


        Try

            vlfinal = Decimal.Ceiling((txtValor.Text) + CalcIPI(CDbl(txtIPI.Text)) + CalcFrete(CDbl(txtFrete.Text)))
            txtValorFinal.Text = vlfinal

            If txtPar1.Text <> "" And txtValor.Text <> "" Then
                Select Case lblUnidade.Text
                    Case "g"
                        txtValorFinal.Text = vlfinal / CDbl(txtPar1.Text)
                    Case "ml"
                        txtValorFinal.Text = vlfinal / CDbl(txtPar1.Text)
                    Case "u"
                        txtValorFinal.Text = vlfinal / CDbl(txtPar1.Text)
                End Select
            End If


            If LTrim(RTrim(TxtQtd.Text)) = Nothing Then
                TxtQtd.Text = 0
                TxtValorQtd.Text = 0
            Else
                If IsNumeric(TxtQtd.Text) And IsNumeric(txtValorFinal.Text) Then
                    TxtValorQtd.Text = CDbl(txtValorFinal.Text) * CDbl(TxtQtd.Text)
                Else
                    TxtValorQtd.Text = 0
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atenção")
        End Try


        Me.Update()

    End Sub


    Private Sub txtValor_TextKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIPI_TextKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIPI.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFrete_TextKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrete.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtParam1_TextKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPar1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub


    Private Function CalcIPI(ByVal valor As Double) As Double
        CalcIPI = CDbl(txtValor.Text) * (valor / 100)
        Return CalcIPI
    End Function

    Private Function CalcFrete(ByVal valor As Double) As Double
        CalcFrete = CDbl(txtValor.Text) * (valor / 100)
        Return CalcFrete
    End Function

    Private Sub TxtQtd_TextChanged(sender As Object, e As EventArgs) Handles TxtQtd.TextChanged
        If LTrim(RTrim(TxtQtd.Text)) = Nothing Then
            TxtQtd.Text = 0
            TxtValorQtd.Text = 0
        Else
            If IsNumeric(TxtQtd.Text) And IsNumeric(txtValorFinal.Text) Then
                TxtValorQtd.Text = CDbl(txtValorFinal.Text) * CDbl(TxtQtd.Text)
            Else
                TxtValorQtd.Text = 0
            End If
        End If

    End Sub

    Private Sub TxtQtd_TextKeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQtd.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub CbFornecedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbFornecedor.SelectedIndexChanged

        If flagSelect = True Then

            If Not IsNothing(CbFornecedor.SelectedItem) Then
                Dim content() As String = CbFornecedor.SelectedItem.ToString().Split("-")
                If content.Count > 0 Then
                    FornecAtual = content(0)
                End If
            End If

        End If

    End Sub



End Class
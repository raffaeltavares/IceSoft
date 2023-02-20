'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.Text
Imports System.IO
Imports System.Data.OleDb
Imports System.Windows
Imports System.Math


Public Class Produto

    Public vl As Integer
    Public imgLoc As String = Nothing
    Public ComponentesText As String
    Public CategoriaAtual As Integer = -1

    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        ListaComponentes = New List(Of Componentes)

    End Sub

#Region "Properties"

    Public Property Codigo() As String
    Public Property Descricao() As String
    Public Property Img() As Image
    Public Property Qt() As Single
    Public Property Valor() As Single
    Public Property ListaComponentes() As List(Of Componentes)

#End Region


    Private Sub FrmProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If IO.File.Exists(xres & "fundo-geral.jpg") Then
        '    Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
        '    Me.BackgroundImage = back1
        'End If

        If IO.File.Exists(xres & "accept_database.png") Then
            Dim back2 As New Bitmap(xres & "accept_database.png")
            Me.btnOkm.Image = back2
        End If

        If IO.File.Exists(xres & "cancel.png") Then
            Dim back3 As New Bitmap(xres & "cancel.png")
            Me.Button2.Image = back3
        End If

        If IO.File.Exists(xres & "add_file.png") Then
            Dim back2 As New Bitmap(xres & "add_file.png")
            Me.btnAdd.Image = back2
        End If

        If IO.File.Exists(xres & "delete.png") Then
            Dim back3 As New Bitmap(xres & "delete.png")
            Me.btnDel.Image = back3
        End If

        If CategoriaAtual <> -1 Then
            If CbCategoria.Items.Count > 0 Then
                For i = 0 To CbCategoria.Items.Count - 1
                    Dim cont() = CbCategoria.Items(i).ToString().Split("-")
                    If cont.Count > 0 Then
                        If cont(0) = CategoriaAtual Then
                            CbCategoria.SelectedIndex = i
                            Exit For
                        End If
                    End If
                Next
            End If
        Else
            If CbCategoria.Items.Count > 0 Then
                CbCategoria.SelectedIndex = 0
            End If
        End If

        EditandoTextos()
        Recalcular()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOkm.Click

        If vl = 1 Then
            Editando()
        ElseIf vl = 2 Then
            Duplicando()
        Else
            Close()
        End If


    End Sub


    Private Sub Editando()

        Try

            ComponentesText = ""
            If Me.DtvComponentes.Rows.Count > 0 Then
                For r = 0 To Me.DtvComponentes.Rows.Count - 1

                    Dim StrComp As String = ""
                    Dim CodigoComp As String = LTrim(RTrim(Me.DtvComponentes.Item(0, r).Value))
                    Dim Descri As String = LTrim(RTrim(Me.DtvComponentes.Item(1, r).Value))
                    Dim Quant As Double = CDbl(Me.DtvComponentes.Item(2, r).Value)
                    Dim ValorComp As Double = CDbl(Me.DtvComponentes.Item(3, r).Value)
                    Dim TotalComp As Double = CDbl(Me.DtvComponentes.Item(4, r).Value)
                    Dim Total As Double = CDbl(Me.DtvComponentes.Item(5, r).Value)
                    Dim Categ As String = Me.DtvComponentes.Item(6, r).Value
                    If r = 0 Then
                        StrComp = CodigoComp & ";" & Descri & ";" & Quant & ";" & ValorComp & ";" & TotalComp & ";" & Total & ";" & Categ
                    Else
                        StrComp = "&&" & CodigoComp & ";" & Descri & ";" & Quant & ";" & ValorComp & ";" & TotalComp & ";" & Total & ";" & Categ
                    End If
                    ComponentesText += StrComp
                Next
            End If

            conexão.Close()
            conexão.Open()
            Dim sqlCom As String = "UPDATE produtos SET [Descricao]='" & Me.txtDescricao.Text & "',[Categoria]=" & CategoriaAtual &
                ",[Img]='" & Me.imgLoc & "',[Custo]=" & Replace(CDbl(Me.TxtCusto.Text), ",", ".") &
                ",[Bruto]=" & Replace(CDbl(Me.TxtBruto.Text), ",", ".") & ",[Multiplicador]=" & Replace(CDbl(Me.txtMultiplicador.Text), ",", ".") &
                ",[Liquido]=" & Replace(CDbl(Me.TxtLiquido.Text), ",", ".") & ",[Imposto]=" & Replace(CDbl(Me.TxtImposto.Text), ",", ".") &
                ",[Comissao]=" & Replace(CDbl(Me.txtComissao.Text), ",", ".") &
                ",[Adicional]=" & Replace(CDbl(Me.TxtAdicional.Text), ",", ".") & ",[Componentes]='" & ComponentesText &
                "',[Tributos]=" & Replace(CDbl(Me.TxtTotalTributos.Text), ",", ".") & ",[LucroReal]=" & Replace(CDbl(Me.TxtLucroReal.Text), ",", ".") & ",[LucroPercent]=" & Replace(CDbl(Me.TxtLucroPercent.Text), ",", ".") &
                ",[NCM]='" & Replace(Me.txtNCM.Text, ",", ".") & "',[CEST]='" & Replace(Me.txtCEST.Text, ",", ".") & "',[UnidCom]='" & Replace(Me.txtUnComercial.Text, ",", ".") &
                "',[EAN]='" & Replace(Me.txtEAN.Text, ",", ".") & "',[EANTrib]='" & Replace(Me.txtEANTrib.Text, ",", ".") &
                "',[ProdEsp]='" & Replace(Me.CbProdEspecifico.SelectedItem, ",", ".") & "',[CFOP1]='" & Replace(Me.CbCFOP1.SelectedItem, ",", ".") &
                "',[CFOP2]='" & Replace(Me.CbCFOP2.SelectedItem, ",", ".") & "',[CFOP3]='" & Replace(Me.CbCFOP3.SelectedItem, ",", ".") & "' WHERE [Codigo]='" & Me.txtCodigo.Text & "'"
            'MsgBox(sqlCom & vbNewLine & conexão.ConnectionString)
            Dim MyCommand As New OleDbCommand(sqlCom, conexão)
            Dim Ra As Integer = MyCommand.ExecuteNonQuery()
            conexão.Close()
            'MsgBox("EDITOU REGISTRO")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
            conexão.Close()
        End Try


    End Sub

    Private Sub Duplicando()

        Try


            Dim Codigo As String = Me.txtCodigo.Text
            Dim Descricao As String = Me.txtDescricao.Text
            Dim Categoria As String = CategoriaAtual

            Dim Custo As Double = CDbl(Me.TxtCusto.Text)
            Dim Bruto As Double = CDbl(Me.TxtBruto.Text)
            Dim Multiplicador As Double = CDbl(Me.txtMultiplicador.Text)
            Dim Liquido As Double = CDbl(Me.TxtLiquido.Text)
            Dim Imposto As Double = CDbl(Me.TxtImposto.Text)
            Dim Comissao As Double = CDbl(Me.txtComissao.Text)
            Dim Adicional As Double = CDbl(Me.TxtAdicional.Text)

            Dim Tributos As Double = CDbl(Me.TxtTotalTributos.Text)
            Dim LucroReal As Double = CDbl(Me.TxtLucroReal.Text)
            Dim LucroPercent As Double = CDbl(Me.TxtLucroPercent.Text)

            Dim NCM As String = Me.txtNCM.Text
            Dim CEST As String = Me.txtCEST.Text
            Dim UnidCom As String = Me.txtUnComercial.Text
            Dim EAN As String = Me.txtEAN.Text
            Dim EANTrib As String = Me.txtEANTrib.Text
            Dim ProdEsp As String = Me.CbProdEspecifico.SelectedItem
            Dim CFOP1 As String = Me.CbCFOP1.SelectedItem
            Dim CFOP2 As String = Me.CbCFOP2.SelectedItem
            Dim CFOP3 As String = Me.CbCFOP3.SelectedItem

            ComponentesText = ""
            If Me.DtvComponentes.Rows.Count > 0 Then
                For r = 0 To Me.DtvComponentes.Rows.Count - 1
                    Dim StrComp As String = ""
                    Dim CodigoComp As String = LTrim(RTrim(Me.DtvComponentes.Item(0, r).Value))
                    Dim Descri As String = LTrim(RTrim(Me.DtvComponentes.Item(1, r).Value))
                    Dim Quant As Double = CDbl(Me.DtvComponentes.Item(2, r).Value)
                    Dim ValorComp As Double = CDbl(Me.DtvComponentes.Item(3, r).Value)
                    Dim TotalComp As Double = CDbl(Me.DtvComponentes.Item(4, r).Value)
                    Dim Total As Double = CDbl(Me.DtvComponentes.Item(5, r).Value)
                    Dim Categ As String = Me.DtvComponentes.Item(6, r).Value
                    If r = 0 Then
                        StrComp = CodigoComp & ";" & Descri & ";" & Quant & ";" & ValorComp & ";" & TotalComp & ";" & Total & ";" & Categ
                    Else
                        StrComp = "&&" & CodigoComp & ";" & Descri & ";" & Quant & ";" & ValorComp & ";" & TotalComp & ";" & Total & ";" & Categ
                    End If
                    ComponentesText += StrComp
                Next
            End If


            Dim Prev As String = Nothing
            If IO.File.Exists(Me.imgLoc) Then
                Prev = Me.imgLoc
            End If

            conexão.Close()
            conexão.Open()

            Dim sqlCom As String = "INSERT INTO produtos ([Codigo],[Descricao],[Categoria],[Img],[Custo]," &
                    "[Bruto],[Multiplicador],[Liquido],[Imposto],[Comissao],[Adicional]," &
                    "[Componentes],[Tributos],[LucroReal],[LucroPercent],[NCM],[CEST],[UnidCom],[EAN],[EANTrib],[ProdEsp],[CFOP1],[CFOP2],[CFOP3])" &
                    " VALUES ('" & Codigo & "','" & Descricao & "','" & Categoria & "','" & Prev & "'," &
                    Custo.ToString.Replace(",", ".") & "," & Bruto.ToString.Replace(",", ".") & "," & Multiplicador.ToString.Replace(",", ".") & "," & Liquido.ToString.Replace(",", ".") & "," & Imposto.ToString.Replace(",", ".") & "," &
                    Comissao.ToString.Replace(",", ".") & "," & Adicional.ToString.Replace(",", ".") & ",'" & ComponentesText & "'," & Tributos.ToString.Replace(",", ".") & "," &
                    LucroReal.ToString.Replace(",", ".") & "," & LucroPercent.ToString.Replace(",", ".") & ",'" & NCM & "','" & CEST & "','" & UnidCom & "','" & EAN & "','" & EANTrib & "','" & ProdEsp & "','" &
                    CFOP1 & "','" & CFOP2 & "','" & CFOP3 & "')"

            Dim MyCommand As New OleDbCommand(sqlCom, conexão)
            Dim Ra As Integer = MyCommand.ExecuteNonQuery
            'MsgBox("inseriu")

            conexão.Close()
            Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
            conexão.Close()
        End Try

    End Sub

    Sub ChangeCateg()
        If Not IsNothing(CbCategoria.SelectedItem) Then
            Dim content() As String = CbCategoria.SelectedItem.ToString().Split("-")
            If content.Count > 0 Then
                CategoriaAtual = content(0)
            End If
        End If
    End Sub

    Private Sub txtCusto_TextChanged(sender As Object, e As EventArgs) Handles TxtCusto.TextChanged
        EditandoTextos()
        Recalcular()
    End Sub

    Private Sub TxtBruto_TextChanged(sender As Object, e As EventArgs) Handles TxtBruto.TextChanged
        EditandoTextos()
        Recalcular()
    End Sub

    Private Sub TxtDesconto_TextChanged(sender As Object, e As EventArgs)
        EditandoTextos()
        Recalcular()
    End Sub

    Private Sub TxtTotalBruto_TextChanged(sender As Object, e As EventArgs)
        EditandoTextos()
        Recalcular()
    End Sub

    Private Sub txtProducao_TextChanged(sender As Object, e As EventArgs) Handles txtMultiplicador.TextChanged
        EditandoTextos()
        Recalcular()
    End Sub

    Private Sub TxtImposto_TextChanged(sender As Object, e As EventArgs) Handles TxtImposto.TextChanged
        EditandoTextos()
        Recalcular()
    End Sub

    Private Sub txtFrete_TextChanged(sender As Object, e As EventArgs)
        EditandoTextos()
        Recalcular()
    End Sub

    Private Sub txtMontagem_Textchanged(sender As Object, e As EventArgs)
        EditandoTextos()
        Recalcular()
    End Sub

    Private Sub txtComissao_TextChanged(sender As Object, e As EventArgs) Handles txtComissao.TextChanged
        EditandoTextos()
        Recalcular()
    End Sub

    Private Sub txtRt_TextChanged(sender As Object, e As EventArgs)
        EditandoTextos()
        Recalcular()
    End Sub

    Private Sub TxtAdicional_TextChanged(sender As Object, e As EventArgs) Handles TxtAdicional.TextChanged
        EditandoTextos()
        Recalcular()
    End Sub

    Private Sub txtProducao_TextKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMultiplicador.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
            EditandoTextos()
            'Recalcular(0)
        End If
    End Sub

    Private Sub txtImposto_TextKeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtImposto.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
            EditandoTextos()
            'Recalcular(0)
        End If
    End Sub

    Private Sub txtFrete_TextKeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
            EditandoTextos()
            'Recalcular(0)
        End If
    End Sub

    Private Sub txtMontagem_TextKeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
            EditandoTextos()
            'Recalcular(0)
        End If
    End Sub

    Private Sub txtComissao_TextKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComissao.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
            EditandoTextos()
            'Recalcular(0)
        End If
    End Sub

    Private Sub txtRt_TextKeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
            EditandoTextos()
            'Recalcular(0)
        End If
    End Sub

    Private Sub txtAdicional_TextKeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAdicional.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
            EditandoTextos()
            'Recalcular(0)
        End If
    End Sub

    Private Sub txtDesconto_TextKeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
            EditandoTextos()
            'Recalcular(0)
        End If
    End Sub

    Private Sub Recalcular()

        Dim valorcusto As Double = 0
        Dim valortotal As Double = 0
        Dim vcusto As Double = 0
        Dim vtotal As Double = 0

        For Each dt As DataGridViewRow In DtvComponentes.Rows

            valorcusto = CDbl(dt.Cells(4).Value)
            valortotal = CDbl(dt.Cells(5).Value)

            vcusto += CDbl(valorcusto)
            vtotal += CDbl(valortotal)

        Next

        TxtCusto.Text = CDbl(vcusto) '.ToString("0.00")
        TxtBruto.Text = CDbl(vtotal) '.ToString("0.00")

        Dim mComiss As Double = CDbl(txtComissao.Text)
        Dim mImposto As Double = CDbl(TxtImposto.Text)
        Dim mAdicional As Double = CDbl(TxtAdicional.Text)

        If mComiss = 0 Then
            mComiss = comissao
        End If

        If mImposto = 0 Then
            mImposto = imposto
        End If

        If mAdicional = 0 Then
            mAdicional = adicional
        End If

        'MsgBox("Etapa: " & dr.Item(0).ToString)
PROXIMO:

        Dim vlliquido = (CDbl(TxtBruto.Text) * CDbl(txtMultiplicador.Text)).ToString("0.00")
        TxtLiquido.Text = vlliquido

        LbImposto.Text = (CalcPercentual(CDbl(TxtLiquido.Text), mImposto)).ToString("0.00")
        Lbcomissao.Text = (CalcPercentual(CDbl(TxtLiquido.Text), mComiss)).ToString("0.00")
        LbAdicional.Text = (CalcPercentual(CDbl(TxtLiquido.Text), mAdicional)).ToString("0.00")

        'MsgBox("Etapa: colocar valores nos labels")

        TxtTotalTributos.Text = CDbl(TxtCusto.Text) + CDbl(Lbcomissao.Text) + CDbl(LbImposto.Text) + CDbl(LbAdicional.Text).ToString("0.00")

        TxtLucroReal.Text = (CDbl(TxtLiquido.Text) - CDbl(TxtTotalTributos.Text)).ToString("0.00")
        If CDbl(TxtLucroReal.Text) > 0 Then
            TxtLucroPercent.Text = (CDbl(TxtLucroReal.Text) / CDbl(TxtLiquido.Text)).ToString("0.00") * 100
        Else
            TxtLucroPercent.Text = 0
        End If

PULA:
        txtValorLiquido.Text = (CDbl(TxtLiquido.Text)) '.ToString("0.00")
        'Update()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try

            Dim frm As New FrmBuscaMaterial
            frm.ShowDialog()

            If frm.DialogResult = Forms.DialogResult.OK Then

                Dim Codigo As String = frm.MaterialAtual.Codigo
                Dim Descri As String = frm.MaterialAtual.Descricao
                Dim Quant As Double = frm.TxQuant.Text
                Dim Categ As String = frm.MaterialAtual.Categoria
                Dim Unit As String = frm.MaterialAtual.Unidade
                Dim Valor As String = frm.MaterialAtual.Valor

                Dim Total As String = 0
                If Unit = "u" Then
                    Total = (CDbl(Valor) * CDbl(Quant)).ToString("0.00")
                End If
                If Unit = "ml" Then
                    Total = (CDbl(Valor) * CDbl(Quant)).ToString("0.00")
                End If
                If Unit = "g" Then
                    Total = (CDbl(Valor) * CDbl(Quant)).ToString("0.00")
                End If
                Dim Chave As Double = GetChave(Categ, Unit)
                Dim ValorTotal As Double = (Total * Chave).ToString("0.00")

                DtvComponentes.Rows.Add(Codigo, Descri, Quant, Valor, Total, ValorTotal, Categ)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro inesperado")
        End Try

        Recalcular()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        imgLoc = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(imgLoc)
    End Sub


    Private Sub EditandoTextos()

        If LTrim(RTrim(TxtAdicional.Text)) = Nothing Then
            TxtAdicional.Text = 0
        End If
        If LTrim(RTrim(txtMultiplicador.Text)) = Nothing Then
            txtMultiplicador.Text = 1
        End If
        If LTrim(RTrim(TxtImposto.Text)) = Nothing Then
            TxtImposto.Text = 0
        End If
        If LTrim(RTrim(txtComissao.Text)) = Nothing Then
            txtComissao.Text = 0
        End If

        If LTrim(RTrim(TxtLiquido.Text)) = Nothing Then
            TxtLiquido.Text = 0
        End If
        If LTrim(RTrim(TxtTotalTributos.Text)) = Nothing Then
            TxtTotalTributos.Text = 0
        End If
        If LTrim(RTrim(TxtLucroReal.Text)) = Nothing Then
            TxtLucroReal.Text = 0
        End If
        If LTrim(RTrim(TxtLucroPercent.Text)) = Nothing Then
            TxtLucroPercent.Text = 0
        End If
        If LTrim(RTrim(txtValorLiquido.Text)) = Nothing Then
            txtValorLiquido.Text = 0
        End If
        If LTrim(RTrim(TxtBruto.Text)) = Nothing Then
            TxtBruto.Text = 0
        End If
        If LTrim(RTrim(TxtLiquido.Text)) = Nothing Then
            TxtLiquido.Text = 0
        End If
        If LTrim(RTrim(TxtCusto.Text)) = Nothing Then
            TxtCusto.Text = 0
        End If


    End Sub

    Private Function GetChave(ByVal categoria As String, ByRef unidade As String) As Double
        GetChave = 0

        For Each dr As DataRow In CategoriasDS.Tables(0).Rows
            If dr.Item(0).ToString = categoria Then
                GetChave = dr.Item(3).ToString
                unidade = dr.Item(2).ToString
            End If
        Next

        Return GetChave
    End Function


    Public Sub PreencherCategorias()

        For Each dt As DataRow In CategoriasProdutosDS.Tables(0).Rows
            CbCategoria.Items.Add(dt(0) & "-" & dt(1))
        Next

        If CbCategoria.Items.Count > 0 Then
            CbCategoria.SelectedIndex = 0
        End If

    End Sub

    Private Sub DtvComponentes_EditingControlShowing(sender As Object, e As DataGridViewCellEventArgs) Handles DtvComponentes.CellEndEdit

        If e.ColumnIndex = 2 Then

            If IsNumeric(DtvComponentes.Item(2, e.RowIndex).Value) Then
                Dim unid As String = ""
                Dim chv As Single = GetChave(DtvComponentes.Item(6, e.RowIndex).Value, unid)

                Select Case unid
                    Case "g"
                        DtvComponentes.Item(4, e.RowIndex).Value = (CDbl(DtvComponentes.Item(3, e.RowIndex).Value) * CDbl(DtvComponentes.Item(2, e.RowIndex).Value)).ToString("0.00")
                        DtvComponentes.Item(5, e.RowIndex).Value = (CDbl(DtvComponentes.Item(4, e.RowIndex).Value) * chv).ToString("0.00")
                    Case "ml"
                        DtvComponentes.Item(4, e.RowIndex).Value = (CDbl(DtvComponentes.Item(3, e.RowIndex).Value) * CDbl(DtvComponentes.Item(2, e.RowIndex).Value)).ToString("0.00")
                        DtvComponentes.Item(5, e.RowIndex).Value = (CDbl(DtvComponentes.Item(4, e.RowIndex).Value) * chv).ToString("0.00")
                    Case "u"
                        DtvComponentes.Item(4, e.RowIndex).Value = (CDbl(DtvComponentes.Item(3, e.RowIndex).Value) * CDbl(DtvComponentes.Item(2, e.RowIndex).Value)).ToString("0.00")
                        DtvComponentes.Item(5, e.RowIndex).Value = (CDbl(DtvComponentes.Item(4, e.RowIndex).Value) * chv).ToString("0.00")
                    Case Else
                        DtvComponentes.Item(4, e.RowIndex).Value = (CDbl(DtvComponentes.Item(3, e.RowIndex).Value) * CDbl(DtvComponentes.Item(2, e.RowIndex).Value)).ToString("0.00")
                        DtvComponentes.Item(5, e.RowIndex).Value = (CDbl(DtvComponentes.Item(4, e.RowIndex).Value) * chv).ToString("0.00")
                End Select

                Recalcular()

            Else
                MsgBox("Valor inválido!", MsgBoxStyle.Exclamation, "Atenção")
            End If

        End If
    End Sub

    Public Sub PreencherListaCfop()

        CbCFOP1.Items.Clear()
        CbCFOP2.Items.Clear()
        CbCFOP3.Items.Clear()

        Dim sr As StreamReader
        Dim conteudo As String = Nothing
        Dim linhas() As String = Nothing
        Dim encoding As Encoding = encoding.GetEncoding("ISO-8859-1")
        Dim ArqCfop As String = My.Application.Info.DirectoryPath & "\pscfop.dat"

        If File.Exists(ArqCfop) Then
            sr = New StreamReader(ArqCfop, encoding)
            conteudo = sr.ReadToEnd
            sr.Close()
            linhas = conteudo.Split(vbCr)

            For Each l As String In linhas
                If l <> Nothing Then
                    CbCFOP1.Items.Add(l)
                    CbCFOP2.Items.Add(l)
                    CbCFOP3.Items.Add(l)
                End If
            Next

        End If


    End Sub

    Private Sub CbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCategoria.SelectedIndexChanged
        ChangeCateg()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If Not IsNothing(DtvComponentes.CurrentRow) Then
            Dim i = DtvComponentes.CurrentRow.Index
            DtvComponentes.Rows.RemoveAt(i)
            Recalcular()
        End If
    End Sub

End Class
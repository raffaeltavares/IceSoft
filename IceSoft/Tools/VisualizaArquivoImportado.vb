'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows
Imports System.Threading
Imports Microsoft


Public Class VisualizaArquivoImportado

    Public NomePlanilha As String
    Public arqu As String
    Public tipo As Integer = 0
    Public Separador As String = ";"

    Dim textContent As String
    Dim textLine() As String
    Dim textColumn() As String
    Dim opImport As String = My.Application.Info.DirectoryPath & "\op_import_mat.dat"
    Dim srOp As StreamReader


    Private Sub FrmFileExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IO.File.Exists(xres & "fundo-geral.jpg") Then
            Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
            Me.BackgroundImage = back1
        End If

        If IO.File.Exists(xres & "next.png") Then
            Dim back2 As New Bitmap(xres & "next.png")
            Me.btnContinuar.Image = back2
        End If

        If IO.File.Exists(opImport) Then
            srOp = New StreamReader(opImport, System.Text.Encoding.Default)
            Dim content As String = Trim(srOp.ReadToEnd().Replace(Chr(10), "")) : srOp.Close()
            If content <> "" Then
                Dim item() As String = content.Split(";")
                If item.Count > 1 Then
                    TxtCodigo.Text = item(0)
                    TxtDescricao.Text = item(1)
                    TxtFornecedor.Text = item(2)
                    TxtCategoria.Text = item(3)

                    TxtValor.Text = item(4)
                    TxtIPI.Text = item(5)
                    TxtFrete.Text = item(6)
                    TxtValorFinal.Text = item(7)
                    TxtParam1.Text = item(8)
                    TxtParam2.Text = item(9)
                    TxtParam3.Text = item(10)
                    TxtPreview.Text = item(11)

                    TxtCodForn.Text = item(12)
                    TxtData.Text = item(13)
                    TxtEstoque.Text = item(14)
                    TxtValorEstoque.Text = item(15)

                    If item(16) = 1 Then
                        ChkTab.Checked = True
                        Separador = vbTab
                    Else
                        ChkPtVirgula.Checked = True
                        Separador = ";"
                    End If

                Else
                    TxtCodigo.Text = 1
                    TxtDescricao.Text = 2
                    TxtFornecedor.Text = 3
                    TxtCategoria.Text = 4

                    TxtValor.Text = 5
                    TxtIPI.Text = 6
                    TxtFrete.Text = 7
                    TxtValorFinal.Text = 8
                    TxtParam1.Text = 9
                    TxtParam2.Text = 10
                    TxtParam3.Text = 11
                    TxtPreview.Text = 12

                    TxtCodForn.Text = 13
                    TxtData.Text = 14
                    TxtEstoque.Text = 15
                    TxtValorEstoque.Text = 16

                    ChkPtVirgula.Checked = True
                    Separador = ";"

                End If
            Else
                TxtCodigo.Text = 1
                TxtDescricao.Text = 2
                TxtFornecedor.Text = 3
                TxtCategoria.Text = 4

                TxtValor.Text = 5
                TxtIPI.Text = 6
                TxtFrete.Text = 7
                TxtValorFinal.Text = 8
                TxtParam1.Text = 9
                TxtParam2.Text = 10
                TxtParam3.Text = 11
                TxtPreview.Text = 12

                TxtCodForn.Text = 13
                TxtData.Text = 14
                TxtEstoque.Text = 15
                TxtValorEstoque.Text = 16

                ChkPtVirgula.Checked = True
                Separador = ";"

            End If
        Else
            TxtCodigo.Text = 1
            TxtDescricao.Text = 2
            TxtFornecedor.Text = 3
            TxtCategoria.Text = 4

            TxtValor.Text = 5
            TxtIPI.Text = 6
            TxtFrete.Text = 7
            TxtValorFinal.Text = 8
            TxtParam1.Text = 9
            TxtParam2.Text = 10
            TxtParam3.Text = 11
            TxtPreview.Text = 12

            TxtCodForn.Text = 13
            TxtData.Text = 14
            TxtEstoque.Text = 15
            TxtValorEstoque.Text = 16

            ChkPtVirgula.Checked = True
            Separador = ";"

        End If

        LerArquivo(arqu)

        If tipo = 0 And CbPlanilhas.Items.Count > 0 Then
            CbPlanilhas.SelectedIndex = 0
        End If

        PreviewTabela()

    End Sub

    Public Sub LerArquivo(ByVal nome As String)
        'MsgBox(nome)
        CbPlanilhas.Items.Clear()

        If tipo = 0 Then

#If Office Then

            Try

                xl.Visible = False
                'MsgBox("Passou a criação das variaveis")
                xlw = xl.Workbooks.Open(nome)
                'MsgBox("Passou a definição da variavel xlw")
                xls = xlw.Worksheets.Count
                'MsgBox("Passou a definição da variavel xls")
                lbForam.Text = "Foram encontradas " & xls & " planilhas"

                For Each Me.i In xlw.Sheets
                    CbPlanilhas.Items.Add(Me.i.Name)
                Next

                'Dim conexao_Excel As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & nome & ";Extended Properties=Excel 12.0;"
                'Dim conx As New OleDbConnection(conexao_Excel)
                xl.Workbooks.Close()

                Me.ShowDialog()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Me.Dispose()
            End Try
#Else
            MsgBox("O Microsoft Office não está instalado!", MsgBoxStyle.Critical)
            Dispose()
#End If

        Else

            Try

                CbPlanilhas.Enabled = False
                Dim sr As New StreamReader(nome, System.Text.Encoding.Default)
                textContent = sr.ReadToEnd() : sr.Close()
                textLine = textContent.Split(vbCr)
                'ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Dispose()
            End Try

        End If

    End Sub

    Public Sub SaveConfigImport()

        Try

            Dim swOp As StreamWriter = New StreamWriter(opImport)
            Dim str As String = TxtCodigo.Text & ";" &
            TxtDescricao.Text & ";" &
            TxtFornecedor.Text & ";" &
            TxtCategoria.Text & ";" &
            TxtValor.Text & ";" &
            TxtIPI.Text & ";" &
            TxtFrete.Text & ";" &
            TxtValorFinal.Text & ";" &
            TxtParam1.Text & ";" &
            TxtParam2.Text & ";" &
            TxtParam3.Text & ";" &
            TxtPreview.Text & ";" &
            TxtCodForn.Text & ";" &
            TxtData.Text & ";" &
            TxtEstoque.Text & ";" &
            TxtValorEstoque.Text & ";"
            If ChkTab.Checked = True Then
                str += "1"
            Else
                str += "0"
            End If
            swOp.WriteLine(str)
            swOp.Close()

        Catch ex As Exception
            MsgBox("Erro ao tentar salvar configuração de importação!" & vbCr & ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        SaveConfigImport()
    End Sub

    Private Sub FrmFileExcel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'DialogResult = DialogResult.Cancel
    End Sub

    Private Sub CbPlanilhas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPlanilhas.SelectedIndexChanged
        PreviewTabela()
    End Sub

    Private Sub PreviewTabela()

        PictureBox1.Visible = True

        NomePlanilha = CbPlanilhas.Text

        If tipo = 0 Then

            Try

                Dim conexao_Excel As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & arqu & ";Extended Properties=Excel 12.0 Xml;" ';
                'Dim conexao_Excel As String = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & arqu & ";Extended Properties=Excel 8.0;" ';
                Dim conx As New OleDbConnection(conexao_Excel)

                Dim oleDbCom As String = "SELECT * FROM [" & NomePlanilha & "$]"
                'MsgBox(oleDbCom)

                Dim Comm_Excel As New OleDbCommand(oleDbCom, conx)
                Dim da As New OleDbDataAdapter(Comm_Excel)
                Dim dt As New DataSet()
                da.Fill(dt)

                DtvExcel.DataSource = dt.Tables(0)
                DtvExcel.Update()

                Application.DoEvents()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Me.Dispose()
            End Try


        Else

            Try

                If Not IsNothing(textLine) Then
                    DtvExcel.Columns.Clear()

                    For x = 0 To textLine.Count - 1

                        Dim lin As String = Trim(textLine(x).Replace(Chr(10), ""))
                        If Not IsNothing(lin) Then
                            textColumn = lin.Split(Separador)

                            If x = 0 Then
                                If textColumn.Count > 0 Then
                                    For y = 0 To textColumn.Count - 1

                                        Dim num As Integer = y + 1
                                        Dim col As DataGridViewColumn = New DataGridViewColumn()
                                        With col
                                            .DataPropertyName = "col" & num
                                            .HeaderText = num
                                        End With
                                        DtvExcel.Columns.Add(col)

                                    Next
                                End If

                                Dim row As DataGridViewRow = New DataGridViewRow()
                                For y = 0 To textColumn.Count - 1
                                    Dim cell As New DataGridViewTextBoxCell
                                    cell.Value = textColumn(y)
                                    row.Cells.Add(cell)
                                Next
                                DtvExcel.Rows.Add(row)
                            Else

                                Dim row As DataGridViewRow = New DataGridViewRow()
                                For y = 0 To textColumn.Count - 1
                                    Dim cell As New DataGridViewTextBoxCell
                                    cell.Value = textColumn(y)
                                    row.Cells.Add(cell)
                                Next
                                DtvExcel.Rows.Add(row)

                            End If
                        End If

                        'Application.DoEvents()

                    Next

                End If

            Catch ex As Exception
                MsgBox(ex.Message & vbCr & ex.StackTrace, MsgBoxStyle.Exclamation, "Atenção")
            End Try

        End If

        PictureBox1.Visible = False

    End Sub

    Private Sub ChangeSeparador()

        If ChkPtVirgula.Checked = True Then
            Separador = ";"
        ElseIf ChkTab.Checked = True Then
            Separador = vbTab
        Else
            Separador = ";"
        End If

    End Sub

    Private Sub TxtRazao_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigo.TextChanged
        If LTrim(RTrim(TxtCodigo.Text)) = Nothing Then
            TxtCodigo.Text = 0
        End If
    End Sub

    Private Sub TxtFantasia_TextChanged(sender As Object, e As EventArgs) Handles TxtDescricao.TextChanged
        If LTrim(RTrim(TxtDescricao.Text)) = Nothing Then
            TxtDescricao.Text = 0
        End If
    End Sub

    Private Sub TxtCNPJ_TextChanged(sender As Object, e As EventArgs) Handles TxtFornecedor.TextChanged
        If LTrim(RTrim(TxtFornecedor.Text)) = Nothing Then
            TxtFornecedor.Text = 0
        End If
    End Sub

    Private Sub TxtEndereco_TextChanged(sender As Object, e As EventArgs) Handles TxtCategoria.TextChanged
        If LTrim(RTrim(TxtCategoria.Text)) = Nothing Then
            TxtCategoria.Text = 0
        End If
    End Sub

    Private Sub TxtTelefone1_TextChanged(sender As Object, e As EventArgs) Handles TxtIPI.TextChanged
        If LTrim(RTrim(TxtIPI.Text)) = Nothing Then
            TxtIPI.Text = 0
        End If
    End Sub

    Private Sub TxtTelefone2_TextChanged(sender As Object, e As EventArgs) Handles TxtFrete.TextChanged
        If LTrim(RTrim(TxtFrete.Text)) = Nothing Then
            TxtFrete.Text = 0
        End If
    End Sub

    Private Sub TextEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtValorFinal.TextChanged
        If LTrim(RTrim(TxtValorFinal.Text)) = Nothing Then
            TxtValorFinal.Text = 0
        End If
    End Sub

    Private Sub TxtContato_TextChanged(sender As Object, e As EventArgs) Handles TxtValor.TextChanged
        If LTrim(RTrim(TxtValor.Text)) = Nothing Then
            TxtValor.Text = 0
        End If
    End Sub

    Private Sub TxtPreview_TextChanged(sender As Object, e As EventArgs) Handles TxtPreview.TextChanged
        If LTrim(RTrim(TxtPreview.Text)) = Nothing Then
            TxtPreview.Text = 0
        End If
    End Sub

    Private Sub TxtParam1_TextChanged(sender As Object, e As EventArgs) Handles TxtParam1.TextChanged
        If LTrim(RTrim(TxtParam1.Text)) = Nothing Then
            TxtParam1.Text = 0
        End If
    End Sub

    Private Sub TxtParam2_TextChanged(sender As Object, e As EventArgs) Handles TxtParam2.TextChanged
        If LTrim(RTrim(TxtParam2.Text)) = Nothing Then
            TxtParam2.Text = 0
        End If
    End Sub

    Private Sub TxtParam3_TextChanged(sender As Object, e As EventArgs) Handles TxtParam3.TextChanged
        If LTrim(RTrim(TxtParam3.Text)) = Nothing Then
            TxtParam3.Text = 0
        End If
    End Sub

    Private Sub TxtCodForn_TextChanged(sender As Object, e As EventArgs) Handles TxtCodForn.TextChanged
        If LTrim(RTrim(TxtCodForn.Text)) = Nothing Then
            TxtCodForn.Text = 0
        End If
    End Sub

    Private Sub TxtData_TextChanged(sender As Object, e As EventArgs) Handles TxtData.TextChanged
        If LTrim(RTrim(TxtData.Text)) = Nothing Then
            TxtData.Text = 0
        End If
    End Sub

    Private Sub TxtEstoque_TextChanged(sender As Object, e As EventArgs) Handles TxtEstoque.TextChanged
        If LTrim(RTrim(TxtEstoque.Text)) = Nothing Then
            TxtEstoque.Text = 0
        End If
    End Sub

    Private Sub TxtValorEstoque_TextChanged(sender As Object, e As EventArgs) Handles TxtValorEstoque.TextChanged
        If LTrim(RTrim(TxtValorEstoque.Text)) = Nothing Then
            TxtValorEstoque.Text = 0
        End If
    End Sub

    Private Sub ChkPtVirgula_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPtVirgula.Click
        ChangeSeparador()
        PreviewTabela()
    End Sub

    Private Sub ChkTab_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTab.Click
        ChangeSeparador()
        PreviewTabela()
    End Sub

End Class
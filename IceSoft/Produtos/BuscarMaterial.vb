'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data.OleDb
Imports System.Windows

Public Class FrmBuscaMaterial

    Public Class Material
        Public Property Codigo As String
        Public Property Descricao As String
        Public Property Categoria As Integer
        Public Property Unidade As String
        Public Property Valor As Single
    End Class
    Public MaterialAtual As Material

    Private Sub FrmMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If IO.File.Exists(xres & "fundo-geral.jpg") Then
        '    Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
        '    Me.BackgroundImage = back1
        'End If
        If IO.File.Exists(xres & "next.png") Then
            Dim back2 As New Bitmap(xres & "next.png")
            Me.btnOk.Image = back2
        End If

        Timer1.Interval = 500
        PreencherLista("")

    End Sub

    Private Sub PreencherLista(filtroTxt As String)

        DtvMateriais.Rows.Clear()
        System.Windows.Forms.Application.DoEvents()

        Try

            conexão.Close()
            conexão.Open()
            Dim dt As DataRow
            Dim cCol As Integer = 0

            For Each dt In MateriaisDS.Tables(0).Rows
                cCol = 0


                Dim flagFiltro As Boolean = True
                If filtroTxt <> "" Then
                    flagFiltro = False
                    If LCase(Trim(dt(0))).Contains(LCase(filtroTxt)) Or
                            LCase(Trim(dt(1))).Contains(LCase(filtroTxt)) Or
                            LCase(Trim(dt(10))).Contains(LCase(filtroTxt)) Or
                            LCase(Trim(dt(11))).Contains(LCase(filtroTxt)) Then
                        flagFiltro = True
                    End If
                End If

                If flagFiltro = True Then

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

                    DtvMateriais.Rows.Add(Codigo, Descricao, Categoria, unidade, ValorFinal, txtEstoque)
                End If

CONT1:
                'System.Windows.Forms.Application.DoEvents()

            Next

            conexão.Close()

            Timer1.Stop()

        Catch ex As Exception
            MsgBox("Preencher lista: " & ex.Message)
        End Try

    End Sub

    Private Sub TxtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PreencherLista(txtFiltro.Text)
    End Sub

    Private Sub TxQuant_TextChanged(sender As Object, e As EventArgs) Handles TxQuant.TextChanged
        If LTrim(RTrim(TxQuant.Text)) = Nothing Then
            TxQuant.Text = 1
        End If
    End Sub

    Private Sub TxQuant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxQuant.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If Not IsNumeric(TxQuant.Text) Then
            MsgBox("Valor de quantidade inválido! ", MsgBoxStyle.Exclamation, "Atenção")
            Exit Sub
        End If

        If Not IsNothing(DtvMateriais.CurrentRow) Then
            Dim l = DtvMateriais.CurrentRow.Index
            MaterialAtual = New Material With {
                .Codigo = DtvMateriais.Item(0, l).Value,
                .Descricao = DtvMateriais.Item(1, l).Value,
                .Categoria = DtvMateriais.Item(2, l).Value,
                .Unidade = DtvMateriais.Item(3, l).Value,
                .Valor = DtvMateriais.Item(4, l).Value
                }

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MsgBox("Nenhum material selecionado!", MsgBoxStyle.Exclamation, "Atenção")
        End If
    End Sub


End Class
Public Class FrmEstoque

    Public Codigo As String
    Public Descricao As String
    Public Valor As Single
    Public Estoque As Single
    Public Data As String
    Public unid As String

    Public Entrada As Single
    Public DataEntrada As String

    Private Sub FrmEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txtMaterial.Text = Codigo & " - " & Descricao
        Me.LbData.Text = "Ultima Entrada: " & Data
        Dim txtUnid = ""
        Select Case unid
            Case "g"
                txtUnid = "Gramas"
            Case "ml"
                txtUnid = "Mililitros"
            Case "u"
                txtUnid = "Unidades"
        End Select
        Me.LbQt.Text = Estoque & " " & txtUnid

        Me.txtQtEntrada.Text = 0
        Me.txtDataEntrada.Text = DateTime.Today.ToString("dd/MM/yyyy")

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Me.Entrada = Me.txtQtEntrada.Text
        Me.DataEntrada = Me.txtDataEntrada.Text

        Me.DialogResult = DialogResult.OK
        Close()
    End Sub

End Class
Public Class FrmTipoImport
    Public TIPOS As Integer
    Public MODO As Integer

    Private Sub TipoImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click

        Select Case ComboBox1.SelectedIndex
            Case 0
                TIPOS = 1
            Case 1
                TIPOS = 2
        End Select

        If ChkMatriz.Checked = True Then
            MODO = 1
        Else
            MODO = 2
        End If

        Me.DialogResult = DialogResult.OK
        Close()

    End Sub

End Class
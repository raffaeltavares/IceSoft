Public Class FrmFinalizar

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TxtValorReceb_TextKeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValorReceb.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub CbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTipo.SelectedIndexChanged
        If CbTipo.SelectedIndex = 0 Then
            Label2.Visible = True
            TxtValorReceb.Visible = True
            TxtValorReceb.Text = 0
        Else
            Label2.Visible = False
            TxtValorReceb.Visible = False
            TxtValorReceb.Text = 0
        End If
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub


End Class
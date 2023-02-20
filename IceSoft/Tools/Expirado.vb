Public Class Expirado

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        ExitProgram("IceSoft")
    End Sub

    Private Sub btnAtivação_Click(sender As Object, e As EventArgs) Handles btnAtivação.Click
        Me.Hide()
        Dim FrmLicenca As New Licenca()
        FrmLicenca.ShowDialog()
    End Sub

End Class
#Region "Programa"
'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana



#End Region

Imports System.Threading

Public Class Inicializar

    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbCopyRight.Text = CopyRight
        LbProcessando.Text = "Iniciando o sistema..."

        Dim Fade As Double
        For Fade = 0.0 To 1.1 Step 0.1
            Me.Opacity = Fade
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next

        Timer1.Enabled = True
        Timer1.Interval = 3000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim Fade As Double
        For Fade = 1.1 To 0.0 Step 0.1
            Me.Opacity = Fade
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next

        Timer1.Dispose()
        Me.Hide()

        Dim frm As New Licenca
        frm.VerificaLicenca()

    End Sub




End Class
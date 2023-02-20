#Region "Programa"
'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana



#End Region

Imports System.Net.NetworkInformation
Imports Microsoft.Win32


Public Class Licenca

    Public idlicenca As String
    Public tempo As Date
    Public status As Integer

    Private Sub FrmLicence_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IO.File.Exists(xres & "fundo-geral.jpg") Then
            Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
            Me.BackgroundImage = back1
        End If

        If IO.File.Exists(xres & "icone_chave.png") Then
            Dim logo As New Bitmap(xres & "icone_chave.png")
            Me.PictureBox1.Image = logo
        End If

        If status = 0 Then
            LbVerLic.Text = "Licença não ativada"
        Else
            LbVerLic.Text = "Licença ativada"
        End If
        LbAddress.Text = getMacAddress()

    End Sub

    Function getMacAddress()

        Dim nics() As NetworkInterface =
              NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString

    End Function

    Private Sub SetChaveRegistro(ByVal Nome As String, ByVal Valor As String)
        Dim key As RegistryKey = Registry.LocalMachine.OpenSubKey("Software", True)
        Dim key2 As RegistryKey = key.OpenSubKey("IceSoft", True)
        Try

            If IsNothing(key2) Or IsDBNull(key2) Then
                GerarChave("IceSoft")
                SetChaveRegistro(Nome, Valor)
            Else
                key2.SetValue(Nome, Valor)
                key2.Close()
                key.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub GerarChave(ByVal Nome As String)
        'Cria uma nova chave sob  HKEY_LOCAL_MACHINE\Software
        Dim key As RegistryKey = Registry.LocalMachine.OpenSubKey("Software", True)
        ' Inclui mais uma sub chave
        Dim newkey As RegistryKey
        Try
            newkey = key.CreateSubKey(Nome, RegistryKeyPermissionCheck.Default)
            ' Atirbui o valor para a sub chave
            newkey.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub VerificaLicenca()

        'Código para verificação e validação de licença
        Dim valido As Boolean = True

        If valido Then

            Dim ds = UsuariosDS().Tables(0)
            If ds.Rows.Count > 0 Then
                Dim frm As New TelaLogin()
                frm.ShowDialog()
            Else
                Dim frm As New TelaPrincipal()
                frm.ShowDialog()
            End If
            Close()

        Else
            Show()
        End If

    End Sub


    Private Sub btnAtivar_Click(sender As Object, e As EventArgs) Handles btnAtivar.Click

        Try

            LbAddress.Text = "Tentando ativação..."

            'Código para ativação de licença

            'MsgBox("Esta chave de licença é inválida!" & vbNewLine & "Entre em contato com o desenvolvedor", MsgBoxStyle.Critical)
            'ExitProgram("IceSoft")
            'Application.Exit()

PASSOU:
            Me.Hide()
            Dim FrmLogin As New TelaLogin
            FrmLogin.ShowDialog()

        Catch ex As Exception
            MsgBox("Falha na autenticação!" & vbNewLine, MsgBoxStyle.Critical)
            ExitProgram("IceSoft")
        End Try

    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click

        If status = 0 Then
            Dim venc As Date = tempo.AddDays(30)
            Dim hoje As Date = DateTime.Today
            If hoje <= venc Then
                Me.Hide()
                MsgBox("Faltam " & venc.Subtract(hoje).Days & " dias para expirar!", MsgBoxStyle.Exclamation)
                Dim FrmLogin As New TelaLogin
                FrmLogin.ShowDialog()
            Else
                Me.Hide()
                Dim FrmExpired As New Expirado
                FrmExpired.ShowDialog()
            End If

        End If
    End Sub

End Class
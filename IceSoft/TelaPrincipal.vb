'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana



Imports System.Data.OleDb

Public Class TelaPrincipal

    Private fechar As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitGlobal()

        If VerificaUser(Usuario) = "Padrao" Then
            btnFornecedores.Visible = False
            btnMateriais.Visible = False
            btnProdutos.Visible = False
            BtnNfe.Visible = False
        End If

    End Sub

    Private Sub FrmMain_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        Select Case e.KeyValue
            Case Keys.F2
                Dim frm As New FrmOrcamento
                frm.ShowDialog()
            Case Keys.F3
                Dim frm As New CatalogoProdutos
                frm.ShowDialog()
            Case Keys.F4
                Dim frm As New ListaClientes
                frm.ShowDialog()
            Case Keys.F5
                Dim frm As New ListaPedidos
                frm.ShowDialog()
            Case Keys.F6
                If VerificaUser(Usuario) = "Padrao" Then
                    MsgBox("Acesso não permitido! contate o administrador.", MsgBoxStyle.Exclamation, "Atenção")
                Else
                    Dim frm As New FrmListaFornecedores
                    frm.ShowDialog()
                End If
            Case Keys.F7
                If VerificaUser(Usuario) = "Padrao" Then
                    MsgBox("Acesso não permitido! contate o administrador.", MsgBoxStyle.Exclamation, "Atenção")
                Else
                    Dim frm As New ListaMateriais
                    frm.ShowDialog()
                End If

            Case Keys.F8
                If VerificaUser(Usuario) = "Padrao" Then
                    MsgBox("Acesso não permitido! contate o administrador.", MsgBoxStyle.Exclamation, "Atenção")
                Else
                    Dim frm As New ListaProdutos
                    frm.ShowDialog()
                End If

            Case Keys.F9
                If VerificaUser(Usuario) = "Padrao" Then
                    Dim frm As New FrmConfigPadrao
                    frm.poradmin = False
                    frm.nomeuser = Usuario
                    frm.ShowDialog()
                Else
                    Dim frm As New FrmConfig
                    frm.ShowDialog()
                End If
                GetAllConfig()
            Case Keys.Escape
                Dim dr As DialogResult = MsgBox("Sair da sessão?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Mensagem")
                If dr = DialogResult.Yes Then
                    LoginInstance = New TelaLogin()
                    Me.Hide()
                    LoginInstance.ShowDialog()
                    Me.Dispose()
                End If
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFornecedores.Click
        Dim frm As New FrmListaFornecedores
        frm.ShowDialog()
    End Sub

    Private Sub InitGlobal()

        Me.KeyPreview = True
        Me.Text = ProductName
        LbDescription.Text = DescriptionSys
        LbUser.Text = Usuario
        LbCopyRight.Text = CopyRight

        LbLicenca.Text = GetLicense()


        If IO.File.Exists(xres & "fundo-geral.jpg") Then
            Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
            Me.BackgroundImage = back1
        End If

        If IO.File.Exists(xres & "logotipo.png") Then
            Dim logo As New Bitmap(xres & "logotipo.png")
            Me.PictureBox1.Image = logo
        End If

        If IO.File.Exists(xres & "settings-icon.png") Then
            Dim setings As New Bitmap(xres & "settings-icon.png")
            Me.btnConfig.Image = setings
        End If

        If IO.File.Exists(xres & "logoff.png") Then
            Dim setings As New Bitmap(xres & "logoff.png")
            Me.btnLogof.Image = setings
        End If

        '---------Botões
        If IO.File.Exists(xres & "caminhao2.png") Then
            Dim forn As New Bitmap(xres & "caminhao2.png")
            Me.btnFornecedores.Image = forn
        End If

        If IO.File.Exists(xres & "cadastro-mat.png") Then
            Dim mat As New Bitmap(xres & "cadastro-mat.png")
            Me.btnMateriais.Image = mat
        End If

        If IO.File.Exists(xres & "cadastro-produtos.png") Then
            Dim prod As New Bitmap(xres & "cadastro-produtos.png")
            Me.btnProdutos.Image = prod
        End If

        If IO.File.Exists(xres & "icon-clientes.png") Then
            Dim client As New Bitmap(xres & "icon-clientes.png")
            Me.btnClientes.Image = client
        End If

        If IO.File.Exists(xres & "catalogo.png") Then
            Dim preco As New Bitmap(xres & "catalogo.png")
            Me.btnPrecos.Image = preco
        End If

        If IO.File.Exists(xres & "novo-pedido.png") Then
            Dim orca As New Bitmap(xres & "novo-pedido.png")
            Me.btnOrcamento.Image = orca
        End If

        If IO.File.Exists(xres & "history.png") Then
            Dim histor As New Bitmap(xres & "history.png")
            Me.btnPedidos.Image = histor
        End If

        If IO.File.Exists(xres & "nfe.png") Then
            Dim nfe As New Bitmap(xres & "nfe.png")
            Me.BtnNfe.Image = nfe
        End If

        dbase = dblocal(My.Application.Info.DirectoryPath & "\database.dat")
        ConnString = "Provider=Microsoft.ACE.OleDb.12.0; Data Source=" & dbase & ""
        conexão = New OleDbConnection(ConnString)

        GetAllConfig()

    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click

        If VerificaUser(Usuario) = "Padrao" Then
            Dim frm As New FrmConfigPadrao
            frm.poradmin = False
            frm.nomeuser = Usuario
            frm.ShowDialog()
        Else
            Dim frm As New FrmConfig
            frm.ShowDialog()
        End If

        GetAllConfig()

    End Sub

    Private Sub btnMateriais_Click(sender As Object, e As EventArgs) Handles btnMateriais.Click
        Dim frm As New ListaMateriais
        frm.ShowDialog()
    End Sub

    Private Sub btnProdutos_Click(sender As Object, e As EventArgs) Handles btnProdutos.Click
        Dim frm As New ListaProdutos
        frm.ShowDialog()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim frm As New ListaClientes
        frm.ShowDialog()
    End Sub

    Private Sub btnPrecos_Click(sender As Object, e As EventArgs) Handles btnPrecos.Click
        Dim frm As New CatalogoProdutos
        frm.modo = 0
        frm.ShowDialog()
    End Sub

    Private Sub btnOrcamento_Click(sender As Object, e As EventArgs) Handles btnOrcamento.Click

        Dim frm As New FrmOrcamento
        frm.ShowDialog()

    End Sub

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        Dim frm As New ListaPedidos
        frm.ShowDialog()

    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        ExitProgram("IceSoft")
    End Sub

    Private Function GetLicense()

        Return "Livre"

    End Function

    Private Sub BtnNfe_Click(sender As Object, e As EventArgs) Handles BtnNfe.Click

        'Dim FrmNfe As New NFe.FrmEmissorNfe
        'FrmNfe.ShowDialog()

    End Sub

    Private Sub btnLogof_Click(sender As Object, e As EventArgs) Handles btnLogof.Click

        Dim dr As DialogResult = MsgBox("Sair da sessão?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Mensagem")
        If dr = DialogResult.Yes Then
            LoginInstance = New TelaLogin()
            Me.Hide()
            LoginInstance.ShowDialog()
            Me.Dispose()
        End If

    End Sub

End Class

'Copyright (c) 2023 Rafael Rodrigo Tavares de Santana




Imports System.IO
Imports System.Data.OleDb
Imports System.Windows


Public Class FrmUpdateProdutos

    Public Imgs As String


    Private Sub FrmUpdateProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IO.File.Exists(xres & "fundo-geral.jpg") Then
            Dim back1 As New Bitmap(xres & "fundo-geral.jpg")
            Me.BackgroundImage = back1
        End If

        TxtCodigo.Text = 1
        TxtDescricao.Text = 0
        TxtCategoria.Text = 0
        TxtLinha.Text = 0
        TxtAcabamento.Text = 0
        TxtDescrDet.Text = 0
        TxtImagem.Text = 0
        txtMarkup.Text = 0
        txtNCM.Text = 0
        txtCEST.Text = 0
        txtUnComercial.Text = 0
        txtEAN.Text = 0
        txtEANTrib.Text = 0
        txtCFOPVenda.Text = 0
        txtCFOPFat.Text = 0
        txtCFOPRem.Text = 0


    End Sub

    Private Sub ChkDescri_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDescri.CheckedChanged
        If ChkDescri.Checked = True Then
            TxtDescricao.Enabled = True
        Else
            TxtDescricao.Enabled = False
            TxtDescricao.Text = 0
        End If
    End Sub

    Private Sub ChkCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCategoria.CheckedChanged
        If ChkCategoria.Checked = True Then
            TxtCategoria.Enabled = True
        Else
            TxtCategoria.Enabled = False
            TxtCategoria.Text = 0
        End If
    End Sub

    Private Sub ChkLinha_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLinha.CheckedChanged
        If ChkLinha.Checked = True Then
            TxtLinha.Enabled = True
        Else
            TxtLinha.Enabled = False
            TxtLinha.Text = 0
        End If
    End Sub

    Private Sub ChkAcabamento_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAcabamento.CheckedChanged
        If ChkAcabamento.Checked = True Then
            TxtAcabamento.Enabled = True
        Else
            TxtAcabamento.Enabled = False
            TxtAcabamento.Text = 0
        End If
    End Sub

    Private Sub ChkDescriDet_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDescriDet.CheckedChanged
        If ChkDescriDet.Checked = True Then
            TxtDescrDet.Enabled = True
        Else
            TxtDescrDet.Enabled = False
            TxtDescrDet.Text = 0
        End If
    End Sub

    Private Sub ChkImagem_CheckedChanged(sender As Object, e As EventArgs) Handles ChkImagem.CheckedChanged
        If ChkImagem.Checked = True Then
            TxtImagem.Enabled = True
        Else
            TxtImagem.Enabled = False
            TxtImagem.Text = 0
        End If
    End Sub


    Private Sub ChkMarkup_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMarkup.CheckedChanged
        If ChkMarkup.Checked = True Then
            txtMarkup.Enabled = True
        Else
            txtMarkup.Enabled = False
            txtMarkup.Text = 0
        End If
    End Sub


    Private Sub ChkNcm_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNCM.CheckedChanged
        If ChkNCM.Checked = True Then
            txtNCM.Enabled = True
        Else
            txtNCM.Enabled = False
            txtNCM.Text = 0
        End If
    End Sub


    Private Sub ChkCest_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCEST.CheckedChanged
        If ChkCEST.Checked = True Then
            txtCEST.Enabled = True
        Else
            txtCEST.Enabled = False
            txtCEST.Text = 0
        End If
    End Sub


    Private Sub ChkUnCom_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUnCom.CheckedChanged
        If ChkUnCom.Checked = True Then
            txtUnComercial.Enabled = True
        Else
            txtUnComercial.Enabled = False
            txtUnComercial.Text = 0
        End If
    End Sub

    Private Sub ChkEan_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEAN.CheckedChanged
        If ChkEAN.Checked = True Then
            txtEAN.Enabled = True
        Else
            txtEAN.Enabled = False
            txtEAN.Text = 0
        End If
    End Sub

    Private Sub ChkEanTrib_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEANTrib.CheckedChanged
        If ChkEANTrib.Checked = True Then
            txtEANTrib.Enabled = True
        Else
            txtEANTrib.Enabled = False
            txtEANTrib.Text = 0
        End If
    End Sub

    Private Sub ChkCfopVenda_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCFOPVenda.CheckedChanged
        If ChkCFOPVenda.Checked = True Then
            txtCFOPVenda.Enabled = True
        Else
            txtCFOPVenda.Enabled = False
            txtCFOPVenda.Text = 0
        End If
    End Sub

    Private Sub ChkCfopFat_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCFOPFat.CheckedChanged
        If ChkCFOPFat.Checked = True Then
            txtCFOPFat.Enabled = True
        Else
            txtCFOPFat.Enabled = False
            txtCFOPFat.Text = 0
        End If
    End Sub

    Private Sub ChkCfopRem_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCFOPRem.CheckedChanged
        If ChkCFOPRem.Checked = True Then
            txtCFOPRem.Enabled = True
        Else
            txtCFOPRem.Enabled = False
            txtCFOPRem.Text = 0
        End If
    End Sub




    Private Sub ChkDirImgs_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDirImgs.CheckedChanged
        If ChkDirImgs.Checked = True Then
            TxtDirImagens.Enabled = True
            GrImgs.Enabled = True
            ChkImagem.Checked = False
            btnDire.Enabled = True
        Else
            TxtDirImagens.Enabled = False
            GrImgs.Enabled = False
            btnDire.Enabled = False
        End If
    End Sub

    Private Sub btnDire_Click(sender As Object, e As EventArgs) Handles btnDire.Click
        FolderBrowserDialog1.ShowDialog()
        TxtDirImagens.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub RdJpg_CheckedChanged(sender As Object, e As EventArgs) Handles RdJpg.CheckedChanged
        If RdJpg.Checked = True Then
            Imgs = ".jpg"
        End If
    End Sub

    Private Sub RdJpeg_CheckedChanged(sender As Object, e As EventArgs) Handles RdJpeg.CheckedChanged
        If RdJpeg.Checked = True Then
            Imgs = ".jpeg"
        End If
    End Sub

    Private Sub RdPng_CheckedChanged(sender As Object, e As EventArgs) Handles RdPng.CheckedChanged
        If RdPng.Checked = True Then
            Imgs = ".png"
        End If
    End Sub

    Private Sub RdBmp_CheckedChanged(sender As Object, e As EventArgs) Handles RdBmp.CheckedChanged
        If RdBmp.Checked = True Then
            Imgs = ".bmp"
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class
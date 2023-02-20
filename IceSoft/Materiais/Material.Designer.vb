<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Material
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtIPI = New System.Windows.Forms.TextBox()
        Me.txtFrete = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUnidade = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LbPar1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnOkm = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtPar1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.CbFornecedor = New System.Windows.Forms.ComboBox()
        Me.txtValorFinal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtQtd = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtValorQtd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCodFornecedor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtData = New System.Windows.Forms.MaskedTextBox()
        Me.lbUnidadeText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDescricao
        '
        Me.txtDescricao.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(102, 62)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(400, 23)
        Me.txtDescricao.TabIndex = 4
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(102, 133)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(74, 23)
        Me.txtValor.TabIndex = 6
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIPI
        '
        Me.txtIPI.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPI.Location = New System.Drawing.Point(102, 162)
        Me.txtIPI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIPI.Name = "txtIPI"
        Me.txtIPI.Size = New System.Drawing.Size(74, 23)
        Me.txtIPI.TabIndex = 7
        Me.txtIPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFrete
        '
        Me.txtFrete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrete.Location = New System.Drawing.Point(102, 191)
        Me.txtFrete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFrete.Name = "txtFrete"
        Me.txtFrete.Size = New System.Drawing.Size(74, 23)
        Me.txtFrete.TabIndex = 8
        Me.txtFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Código:"
        '
        'lblUnidade
        '
        Me.lblUnidade.AutoSize = True
        Me.lblUnidade.BackColor = System.Drawing.Color.Transparent
        Me.lblUnidade.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidade.Location = New System.Drawing.Point(340, 96)
        Me.lblUnidade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUnidade.Name = "lblUnidade"
        Me.lblUnidade.Size = New System.Drawing.Size(16, 15)
        Me.lblUnidade.TabIndex = 9
        Me.lblUnidade.Text = "..."
        Me.lblUnidade.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descrição"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Categoria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(339, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fornecedor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 136)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Valor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 165)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Imp %"
        '
        'LbPar1
        '
        Me.LbPar1.AutoSize = True
        Me.LbPar1.BackColor = System.Drawing.Color.Transparent
        Me.LbPar1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPar1.Location = New System.Drawing.Point(8, 223)
        Me.LbPar1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbPar1.Name = "LbPar1"
        Me.LbPar1.Size = New System.Drawing.Size(88, 15)
        Me.LbPar1.TabIndex = 15
        Me.LbPar1.Text = "Vol /p Unidade"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 194)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Frete %"
        '
        'btnOkm
        '
        Me.btnOkm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOkm.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOkm.Location = New System.Drawing.Point(318, 248)
        Me.btnOkm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOkm.Name = "btnOkm"
        Me.btnOkm.Size = New System.Drawing.Size(81, 49)
        Me.btnOkm.TabIndex = 12
        Me.btnOkm.Text = "OK"
        Me.btnOkm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOkm.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(403, 248)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 49)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtPar1
        '
        Me.txtPar1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPar1.Location = New System.Drawing.Point(102, 220)
        Me.txtPar1.Name = "txtPar1"
        Me.txtPar1.Size = New System.Drawing.Size(74, 23)
        Me.txtPar1.TabIndex = 9
        Me.txtPar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(102, 31)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(111, 23)
        Me.txtCodigo.TabIndex = 1
        '
        'CbTipo
        '
        Me.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Location = New System.Drawing.Point(102, 93)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(233, 23)
        Me.CbTipo.TabIndex = 5
        '
        'CbFornecedor
        '
        Me.CbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbFornecedor.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbFornecedor.FormattingEnabled = True
        Me.CbFornecedor.Location = New System.Drawing.Point(342, 31)
        Me.CbFornecedor.Name = "CbFornecedor"
        Me.CbFornecedor.Size = New System.Drawing.Size(160, 23)
        Me.CbFornecedor.TabIndex = 3
        '
        'txtValorFinal
        '
        Me.txtValorFinal.BackColor = System.Drawing.SystemColors.Control
        Me.txtValorFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorFinal.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorFinal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtValorFinal.Location = New System.Drawing.Point(191, 254)
        Me.txtValorFinal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValorFinal.Name = "txtValorFinal"
        Me.txtValorFinal.ReadOnly = True
        Me.txtValorFinal.Size = New System.Drawing.Size(96, 31)
        Me.txtValorFinal.TabIndex = 30
        Me.txtValorFinal.TabStop = False
        Me.txtValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 259)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 23)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Valor final fracionado:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Imagem"
        Me.OpenFileDialog1.Title = "Arquivo de imagem"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(370, 136)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Estoque"
        '
        'TxtQtd
        '
        Me.TxtQtd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQtd.Location = New System.Drawing.Point(426, 131)
        Me.TxtQtd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtQtd.Name = "TxtQtd"
        Me.TxtQtd.Size = New System.Drawing.Size(76, 23)
        Me.TxtQtd.TabIndex = 10
        Me.TxtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(338, 169)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 15)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Valor Estoque"
        '
        'TxtValorQtd
        '
        Me.TxtValorQtd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValorQtd.Location = New System.Drawing.Point(426, 164)
        Me.TxtValorQtd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtValorQtd.Name = "TxtValorQtd"
        Me.TxtValorQtd.ReadOnly = True
        Me.TxtValorQtd.Size = New System.Drawing.Size(75, 23)
        Me.TxtValorQtd.TabIndex = 11
        Me.TxtValorQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(362, 203)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 15)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Data ped."
        '
        'TxtCodFornecedor
        '
        Me.TxtCodFornecedor.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodFornecedor.Location = New System.Drawing.Point(219, 31)
        Me.TxtCodFornecedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCodFornecedor.Name = "TxtCodFornecedor"
        Me.TxtCodFornecedor.Size = New System.Drawing.Size(116, 23)
        Me.TxtCodFornecedor.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(216, 11)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 15)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Cod. Fornecedor"
        '
        'TxtData
        '
        Me.TxtData.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtData.Location = New System.Drawing.Point(426, 195)
        Me.TxtData.Mask = "00/00/0000"
        Me.TxtData.Name = "TxtData"
        Me.TxtData.Size = New System.Drawing.Size(76, 23)
        Me.TxtData.TabIndex = 11
        Me.TxtData.ValidatingType = GetType(Date)
        '
        'lbUnidadeText
        '
        Me.lbUnidadeText.AutoSize = True
        Me.lbUnidadeText.BackColor = System.Drawing.Color.Transparent
        Me.lbUnidadeText.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUnidadeText.Location = New System.Drawing.Point(182, 223)
        Me.lbUnidadeText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbUnidadeText.Name = "lbUnidadeText"
        Me.lbUnidadeText.Size = New System.Drawing.Size(16, 15)
        Me.lbUnidadeText.TabIndex = 33
        Me.lbUnidadeText.Text = "..."
        '
        'FrmMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(526, 308)
        Me.Controls.Add(Me.lbUnidadeText)
        Me.Controls.Add(Me.TxtData)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtCodFornecedor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LbPar1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtValorQtd)
        Me.Controls.Add(Me.txtPar1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtQtd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValorFinal)
        Me.Controls.Add(Me.CbFornecedor)
        Me.Controls.Add(Me.CbTipo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnOkm)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblUnidade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFrete)
        Me.Controls.Add(Me.txtIPI)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtDescricao)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FrmMaterial"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dados do Material"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents txtIPI As System.Windows.Forms.TextBox
    Friend WithEvents txtFrete As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUnidade As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LbPar1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnOkm As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtPar1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents CbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents CbFornecedor As System.Windows.Forms.ComboBox
    Friend WithEvents txtValorFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtQtd As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtValorQtd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtCodFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbUnidadeText As Label
End Class

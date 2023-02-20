<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportFornecedor
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtRazao = New System.Windows.Forms.TextBox()
        Me.TxtFantasia = New System.Windows.Forms.TextBox()
        Me.TxtCNPJ = New System.Windows.Forms.TextBox()
        Me.TxtEndereco = New System.Windows.Forms.TextBox()
        Me.TxtTelefone1 = New System.Windows.Forms.TextBox()
        Me.TxtTelefone2 = New System.Windows.Forms.TextBox()
        Me.TextEmail = New System.Windows.Forms.TextBox()
        Me.TxtContato = New System.Windows.Forms.TextBox()
        Me.ChkPontoVirg = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkTAB = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(144, 342)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 43)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnImport.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnImport.Location = New System.Drawing.Point(12, 342)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(126, 43)
        Me.btnImport.TabIndex = 12
        Me.btnImport.Text = "Importar"
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Razão Social"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome Fantasia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CNPJ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Endereço"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Telefone1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Telefone2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "E-mail"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nome Contato"
        '
        'TxtRazao
        '
        Me.TxtRazao.Location = New System.Drawing.Point(129, 78)
        Me.TxtRazao.Name = "TxtRazao"
        Me.TxtRazao.Size = New System.Drawing.Size(96, 22)
        Me.TxtRazao.TabIndex = 4
        '
        'TxtFantasia
        '
        Me.TxtFantasia.Location = New System.Drawing.Point(129, 106)
        Me.TxtFantasia.Name = "TxtFantasia"
        Me.TxtFantasia.Size = New System.Drawing.Size(96, 22)
        Me.TxtFantasia.TabIndex = 5
        '
        'TxtCNPJ
        '
        Me.TxtCNPJ.Location = New System.Drawing.Point(129, 134)
        Me.TxtCNPJ.Name = "TxtCNPJ"
        Me.TxtCNPJ.Size = New System.Drawing.Size(96, 22)
        Me.TxtCNPJ.TabIndex = 6
        '
        'TxtEndereco
        '
        Me.TxtEndereco.Location = New System.Drawing.Point(129, 162)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(96, 22)
        Me.TxtEndereco.TabIndex = 7
        '
        'TxtTelefone1
        '
        Me.TxtTelefone1.Location = New System.Drawing.Point(129, 218)
        Me.TxtTelefone1.Name = "TxtTelefone1"
        Me.TxtTelefone1.Size = New System.Drawing.Size(96, 22)
        Me.TxtTelefone1.TabIndex = 9
        '
        'TxtTelefone2
        '
        Me.TxtTelefone2.Location = New System.Drawing.Point(129, 246)
        Me.TxtTelefone2.Name = "TxtTelefone2"
        Me.TxtTelefone2.Size = New System.Drawing.Size(96, 22)
        Me.TxtTelefone2.TabIndex = 10
        '
        'TextEmail
        '
        Me.TextEmail.Location = New System.Drawing.Point(129, 274)
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(96, 22)
        Me.TextEmail.TabIndex = 11
        '
        'TxtContato
        '
        Me.TxtContato.Location = New System.Drawing.Point(129, 190)
        Me.TxtContato.Name = "TxtContato"
        Me.TxtContato.Size = New System.Drawing.Size(96, 22)
        Me.TxtContato.TabIndex = 8
        '
        'ChkPontoVirg
        '
        Me.ChkPontoVirg.AutoSize = True
        Me.ChkPontoVirg.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPontoVirg.Location = New System.Drawing.Point(11, 21)
        Me.ChkPontoVirg.Name = "ChkPontoVirg"
        Me.ChkPontoVirg.Size = New System.Drawing.Size(30, 20)
        Me.ChkPontoVirg.TabIndex = 1
        Me.ChkPontoVirg.TabStop = True
        Me.ChkPontoVirg.Text = ";"
        Me.ChkPontoVirg.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ChkTAB)
        Me.GroupBox1.Controls.Add(Me.ChkPontoVirg)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 56)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Separador"
        '
        'ChkTAB
        '
        Me.ChkTAB.AutoSize = True
        Me.ChkTAB.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTAB.Location = New System.Drawing.Point(155, 19)
        Me.ChkTAB.Name = "ChkTAB"
        Me.ChkTAB.Size = New System.Drawing.Size(54, 20)
        Me.ChkTAB.TabIndex = 3
        Me.ChkTAB.TabStop = True
        Me.ChkTAB.Text = "TAB"
        Me.ChkTAB.UseVisualStyleBackColor = True
        '
        'FrmImportFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 397)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtContato)
        Me.Controls.Add(Me.TextEmail)
        Me.Controls.Add(Me.TxtTelefone2)
        Me.Controls.Add(Me.TxtTelefone1)
        Me.Controls.Add(Me.TxtEndereco)
        Me.Controls.Add(Me.TxtCNPJ)
        Me.Controls.Add(Me.TxtFantasia)
        Me.Controls.Add(Me.TxtRazao)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnCancel)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImportFornecedor"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Fornecedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtRazao As System.Windows.Forms.TextBox
    Friend WithEvents TxtFantasia As System.Windows.Forms.TextBox
    Friend WithEvents TxtCNPJ As System.Windows.Forms.TextBox
    Friend WithEvents TxtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefone1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefone2 As System.Windows.Forms.TextBox
    Friend WithEvents TextEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtContato As System.Windows.Forms.TextBox
    Friend WithEvents ChkPontoVirg As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkTAB As System.Windows.Forms.RadioButton
End Class

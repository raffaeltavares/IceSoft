<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfigPadrao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfigPadrao))
        Me.btnSenha = New System.Windows.Forms.Button()
        Me.btnPessoal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSenha
        '
        Me.btnSenha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSenha.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSenha.Location = New System.Drawing.Point(203, 48)
        Me.btnSenha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSenha.Name = "btnSenha"
        Me.btnSenha.Size = New System.Drawing.Size(181, 68)
        Me.btnSenha.TabIndex = 9
        Me.btnSenha.Text = "Modificar Senha"
        Me.btnSenha.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSenha.UseVisualStyleBackColor = True
        '
        'btnPessoal
        '
        Me.btnPessoal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPessoal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPessoal.Location = New System.Drawing.Point(23, 48)
        Me.btnPessoal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPessoal.Name = "btnPessoal"
        Me.btnPessoal.Size = New System.Drawing.Size(174, 68)
        Me.btnPessoal.TabIndex = 8
        Me.btnPessoal.Text = "Editar dados Pessoais"
        Me.btnPessoal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPessoal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "O que deseja fazer?"
        '
        'FrmConfigPadrao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(403, 130)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSenha)
        Me.Controls.Add(Me.btnPessoal)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConfigPadrao"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configurações do Usuário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSenha As System.Windows.Forms.Button
    Friend WithEvents btnPessoal As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

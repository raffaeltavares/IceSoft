<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Licenca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Licenca))
        Me.LbAddress = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbVerLic = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnAtivar = New System.Windows.Forms.Button()
        Me.btnContinuar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbAddress
        '
        Me.LbAddress.AutoSize = True
        Me.LbAddress.ForeColor = System.Drawing.Color.DimGray
        Me.LbAddress.Location = New System.Drawing.Point(153, 120)
        Me.LbAddress.Name = "LbAddress"
        Me.LbAddress.Size = New System.Drawing.Size(16, 15)
        Me.LbAddress.TabIndex = 0
        Me.LbAddress.Text = "..."
        Me.LbAddress.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(15, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LbVerLic
        '
        Me.LbVerLic.AutoSize = True
        Me.LbVerLic.ForeColor = System.Drawing.Color.DimGray
        Me.LbVerLic.Location = New System.Drawing.Point(154, 85)
        Me.LbVerLic.Name = "LbVerLic"
        Me.LbVerLic.Size = New System.Drawing.Size(16, 15)
        Me.LbVerLic.TabIndex = 2
        Me.LbVerLic.Text = "..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(154, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Licença:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(157, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 22)
        Me.TextBox1.TabIndex = 5
        '
        'btnAtivar
        '
        Me.btnAtivar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAtivar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAtivar.Location = New System.Drawing.Point(15, 141)
        Me.btnAtivar.Name = "btnAtivar"
        Me.btnAtivar.Size = New System.Drawing.Size(284, 50)
        Me.btnAtivar.TabIndex = 6
        Me.btnAtivar.Text = "Ativar"
        Me.btnAtivar.UseVisualStyleBackColor = False
        '
        'btnContinuar
        '
        Me.btnContinuar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnContinuar.Location = New System.Drawing.Point(15, 197)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(284, 33)
        Me.btnContinuar.TabIndex = 7
        Me.btnContinuar.Text = "Continuar sem ativar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'FrmLicence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(318, 242)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.btnAtivar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbVerLic)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LbAddress)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLicence"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de licença"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbAddress As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LbVerLic As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnAtivar As System.Windows.Forms.Button
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
End Class

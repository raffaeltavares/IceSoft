<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcessoImportacao
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LbRegistro = New System.Windows.Forms.Label()
        Me.Progbar = New System.Windows.Forms.ProgressBar()
        Me.LbPercent = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Processando ..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IceSoft.My.Resources.Resources.ajax_loading_2x
        Me.PictureBox1.Location = New System.Drawing.Point(226, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'LbRegistro
        '
        Me.LbRegistro.Location = New System.Drawing.Point(12, 33)
        Me.LbRegistro.Name = "LbRegistro"
        Me.LbRegistro.Size = New System.Drawing.Size(208, 16)
        Me.LbRegistro.TabIndex = 2
        Me.LbRegistro.Text = "..."
        '
        'Progbar
        '
        Me.Progbar.Location = New System.Drawing.Point(42, 63)
        Me.Progbar.Name = "Progbar"
        Me.Progbar.Size = New System.Drawing.Size(234, 11)
        Me.Progbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Progbar.TabIndex = 3
        Me.Progbar.Visible = False
        '
        'LbPercent
        '
        Me.LbPercent.AutoSize = True
        Me.LbPercent.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPercent.Location = New System.Drawing.Point(12, 60)
        Me.LbPercent.Name = "LbPercent"
        Me.LbPercent.Size = New System.Drawing.Size(13, 14)
        Me.LbPercent.TabIndex = 4
        Me.LbPercent.Text = "..."
        '
        'FrmProcessando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(280, 77)
        Me.ControlBox = False
        Me.Controls.Add(Me.LbPercent)
        Me.Controls.Add(Me.Progbar)
        Me.Controls.Add(Me.LbRegistro)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProcessando"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Processando"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LbRegistro As System.Windows.Forms.Label
    Friend WithEvents Progbar As System.Windows.Forms.ProgressBar
    Friend WithEvents LbPercent As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfigCateg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfigCateg))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radUnit = New System.Windows.Forms.RadioButton()
        Me.radML = New System.Windows.Forms.RadioButton()
        Me.radM2 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtChave = New System.Windows.Forms.TextBox()
        Me.LbId = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(181, 164)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ok"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(277, 164)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 54)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(81, 25)
        Me.txtCategoria.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(297, 27)
        Me.txtCategoria.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(10, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nome"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.radUnit)
        Me.GroupBox1.Controls.Add(Me.radML)
        Me.GroupBox1.Controls.Add(Me.radM2)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 95)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(135, 117)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Calculo"
        '
        'radUnit
        '
        Me.radUnit.AutoSize = True
        Me.radUnit.Location = New System.Drawing.Point(23, 85)
        Me.radUnit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radUnit.Name = "radUnit"
        Me.radUnit.Size = New System.Drawing.Size(88, 23)
        Me.radUnit.TabIndex = 2
        Me.radUnit.TabStop = True
        Me.radUnit.Text = "Unidades"
        Me.radUnit.UseVisualStyleBackColor = True
        '
        'radML
        '
        Me.radML.AutoSize = True
        Me.radML.Location = New System.Drawing.Point(23, 54)
        Me.radML.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radML.Name = "radML"
        Me.radML.Size = New System.Drawing.Size(85, 23)
        Me.radML.TabIndex = 1
        Me.radML.TabStop = True
        Me.radML.Text = "Mililitros"
        Me.radML.UseVisualStyleBackColor = True
        '
        'radM2
        '
        Me.radM2.AutoSize = True
        Me.radM2.Location = New System.Drawing.Point(23, 23)
        Me.radM2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radM2.Name = "radM2"
        Me.radM2.Size = New System.Drawing.Size(77, 23)
        Me.radM2.TabIndex = 0
        Me.radM2.TabStop = True
        Me.radM2.Text = "Gramas"
        Me.radM2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(10, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Markup"
        '
        'TxtChave
        '
        Me.TxtChave.Location = New System.Drawing.Point(81, 60)
        Me.TxtChave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtChave.Name = "TxtChave"
        Me.TxtChave.Size = New System.Drawing.Size(92, 27)
        Me.TxtChave.TabIndex = 5
        '
        'LbId
        '
        Me.LbId.AutoSize = True
        Me.LbId.BackColor = System.Drawing.Color.Transparent
        Me.LbId.Location = New System.Drawing.Point(12, -2)
        Me.LbId.Name = "LbId"
        Me.LbId.Size = New System.Drawing.Size(21, 19)
        Me.LbId.TabIndex = 7
        Me.LbId.Text = "..."
        Me.LbId.Visible = False
        '
        'FrmConfigCateg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(396, 229)
        Me.Controls.Add(Me.LbId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtChave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConfigCateg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tipo de material"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radUnit As System.Windows.Forms.RadioButton
    Friend WithEvents radML As System.Windows.Forms.RadioButton
    Friend WithEvents radM2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtChave As System.Windows.Forms.TextBox
    Friend WithEvents LbId As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoImport
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrImport = New System.Windows.Forms.GroupBox()
        Me.ChkUpdate = New System.Windows.Forms.RadioButton()
        Me.ChkMatriz = New System.Windows.Forms.RadioButton()
        Me.GrImport.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"PLANILHA EXCEL XLS/XLSX", "ARQUIVOS DE TEXTO"})
        Me.ComboBox1.Location = New System.Drawing.Point(34, 90)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 23)
        Me.ComboBox1.TabIndex = 0
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(240, 90)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(75, 23)
        Me.btnContinuar.TabIndex = 1
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selecione o tipo de arquivo"
        '
        'GrImport
        '
        Me.GrImport.BackColor = System.Drawing.Color.Transparent
        Me.GrImport.Controls.Add(Me.ChkUpdate)
        Me.GrImport.Controls.Add(Me.ChkMatriz)
        Me.GrImport.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrImport.Location = New System.Drawing.Point(12, 12)
        Me.GrImport.Name = "GrImport"
        Me.GrImport.Size = New System.Drawing.Size(307, 57)
        Me.GrImport.TabIndex = 58
        Me.GrImport.TabStop = False
        Me.GrImport.Text = "Tipo de importação"
        '
        'ChkUpdate
        '
        Me.ChkUpdate.AutoSize = True
        Me.ChkUpdate.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUpdate.Location = New System.Drawing.Point(168, 21)
        Me.ChkUpdate.Name = "ChkUpdate"
        Me.ChkUpdate.Size = New System.Drawing.Size(129, 22)
        Me.ChkUpdate.TabIndex = 2
        Me.ChkUpdate.TabStop = True
        Me.ChkUpdate.Text = "Atualizar dados"
        Me.ChkUpdate.UseVisualStyleBackColor = True
        '
        'ChkMatriz
        '
        Me.ChkMatriz.AutoSize = True
        Me.ChkMatriz.Checked = True
        Me.ChkMatriz.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMatriz.Location = New System.Drawing.Point(11, 21)
        Me.ChkMatriz.Name = "ChkMatriz"
        Me.ChkMatriz.Size = New System.Drawing.Size(151, 22)
        Me.ChkMatriz.TabIndex = 1
        Me.ChkMatriz.TabStop = True
        Me.ChkMatriz.Text = "Matriz de materiais"
        Me.ChkMatriz.UseVisualStyleBackColor = True
        '
        'FrmTipoImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 125)
        Me.Controls.Add(Me.GrImport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTipoImport"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de arquivo"
        Me.GrImport.ResumeLayout(False)
        Me.GrImport.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrImport As System.Windows.Forms.GroupBox
    Friend WithEvents ChkUpdate As System.Windows.Forms.RadioButton
    Friend WithEvents ChkMatriz As System.Windows.Forms.RadioButton
End Class

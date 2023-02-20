<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscaMaterial
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DtvMateriais = New System.Windows.Forms.DataGridView()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCateg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUnidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEstoq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxQuant = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DtvMateriais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtvMateriais
        '
        Me.DtvMateriais.AllowUserToAddRows = False
        Me.DtvMateriais.AllowUserToDeleteRows = False
        Me.DtvMateriais.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DtvMateriais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtvMateriais.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCodigo, Me.cDescri, Me.cCateg, Me.cUnidade, Me.cValor, Me.cEstoq})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtvMateriais.DefaultCellStyle = DataGridViewCellStyle1
        Me.DtvMateriais.Location = New System.Drawing.Point(0, 66)
        Me.DtvMateriais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DtvMateriais.Name = "DtvMateriais"
        Me.DtvMateriais.ReadOnly = True
        Me.DtvMateriais.RowHeadersWidth = 10
        Me.DtvMateriais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtvMateriais.Size = New System.Drawing.Size(548, 277)
        Me.DtvMateriais.TabIndex = 2
        Me.DtvMateriais.TabStop = False
        '
        'cCodigo
        '
        Me.cCodigo.HeaderText = "Codigo"
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.ReadOnly = True
        '
        'cDescri
        '
        Me.cDescri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cDescri.HeaderText = "Descrição"
        Me.cDescri.Name = "cDescri"
        Me.cDescri.ReadOnly = True
        '
        'cCateg
        '
        Me.cCateg.HeaderText = "Categoria"
        Me.cCateg.Name = "cCateg"
        Me.cCateg.ReadOnly = True
        Me.cCateg.Visible = False
        '
        'cUnidade
        '
        Me.cUnidade.HeaderText = "Unidade"
        Me.cUnidade.Name = "cUnidade"
        Me.cUnidade.ReadOnly = True
        Me.cUnidade.Visible = False
        '
        'cValor
        '
        Me.cValor.HeaderText = "Vl. fração"
        Me.cValor.Name = "cValor"
        Me.cValor.ReadOnly = True
        '
        'cEstoq
        '
        Me.cEstoq.HeaderText = "Estoque"
        Me.cEstoq.Name = "cEstoq"
        Me.cEstoq.ReadOnly = True
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFiltro.Location = New System.Drawing.Point(76, 31)
        Me.TxtFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(132, 27)
        Me.TxtFiltro.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOk.Location = New System.Drawing.Point(424, 12)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(114, 47)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "Adicionar"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "FILTRO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(214, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Qt."
        '
        'TxQuant
        '
        Me.TxQuant.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxQuant.Location = New System.Drawing.Point(249, 31)
        Me.TxQuant.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxQuant.Name = "TxQuant"
        Me.TxQuant.Size = New System.Drawing.Size(75, 27)
        Me.TxQuant.TabIndex = 2
        '
        'Timer1
        '
        '
        'FrmBuscaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(549, 343)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxQuant)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.TxtFiltro)
        Me.Controls.Add(Me.DtvMateriais)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscaMaterial"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Materiais"
        CType(Me.DtvMateriais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtvMateriais As System.Windows.Forms.DataGridView
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxQuant As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cCodigo As DataGridViewTextBoxColumn
    Friend WithEvents cDescri As DataGridViewTextBoxColumn
    Friend WithEvents cCateg As DataGridViewTextBoxColumn
    Friend WithEvents cUnidade As DataGridViewTextBoxColumn
    Friend WithEvents cValor As DataGridViewTextBoxColumn
    Friend WithEvents cEstoq As DataGridViewTextBoxColumn
End Class

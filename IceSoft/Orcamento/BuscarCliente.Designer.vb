<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscaCliente
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.DtvClientes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCadastro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTelefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSelect = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DtvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(577, 12)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(88, 40)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "FILTRAR:"
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Location = New System.Drawing.Point(9, 30)
        Me.TxtFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(158, 23)
        Me.TxtFiltro.TabIndex = 0
        '
        'DtvClientes
        '
        Me.DtvClientes.AllowUserToAddRows = False
        Me.DtvClientes.AllowUserToDeleteRows = False
        Me.DtvClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DtvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.cCadastro, Me.cName, Me.cCPF, Me.cTelefone, Me.cEmail, Me.cData, Me.cSelect})
        Me.DtvClientes.Location = New System.Drawing.Point(1, 60)
        Me.DtvClientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DtvClientes.MultiSelect = False
        Me.DtvClientes.Name = "DtvClientes"
        Me.DtvClientes.ReadOnly = True
        Me.DtvClientes.RowHeadersWidth = 10
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DtvClientes.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DtvClientes.RowTemplate.Height = 30
        Me.DtvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtvClientes.Size = New System.Drawing.Size(674, 355)
        Me.DtvClientes.TabIndex = 2
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Select"
        Me.DataGridViewImageColumn1.Image = Global.IceSoft.My.Resources.Resources.checkmark
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 50
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionar.Location = New System.Drawing.Point(425, 12)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(146, 40)
        Me.btnAdicionar.TabIndex = 2
        Me.btnAdicionar.Text = "Adicionar Cliente"
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'cId
        '
        Me.cId.HeaderText = "ID"
        Me.cId.Name = "cId"
        Me.cId.ReadOnly = True
        Me.cId.Width = 70
        '
        'cCadastro
        '
        Me.cCadastro.HeaderText = "Cadastro"
        Me.cCadastro.Name = "cCadastro"
        Me.cCadastro.ReadOnly = True
        Me.cCadastro.Visible = False
        '
        'cName
        '
        Me.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cName.HeaderText = "Nome"
        Me.cName.Name = "cName"
        Me.cName.ReadOnly = True
        '
        'cCPF
        '
        Me.cCPF.HeaderText = "CPF"
        Me.cCPF.Name = "cCPF"
        Me.cCPF.ReadOnly = True
        Me.cCPF.Width = 150
        '
        'cTelefone
        '
        Me.cTelefone.HeaderText = "Telefone"
        Me.cTelefone.Name = "cTelefone"
        Me.cTelefone.ReadOnly = True
        Me.cTelefone.Visible = False
        '
        'cEmail
        '
        Me.cEmail.HeaderText = "Email"
        Me.cEmail.Name = "cEmail"
        Me.cEmail.ReadOnly = True
        Me.cEmail.Visible = False
        '
        'cData
        '
        Me.cData.HeaderText = "Data"
        Me.cData.Name = "cData"
        Me.cData.ReadOnly = True
        Me.cData.Visible = False
        '
        'cSelect
        '
        Me.cSelect.HeaderText = "Select"
        Me.cSelect.Image = Global.IceSoft.My.Resources.Resources.checkmark
        Me.cSelect.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.cSelect.Name = "cSelect"
        Me.cSelect.ReadOnly = True
        Me.cSelect.ToolTipText = "Selecionar"
        Me.cSelect.Width = 50
        '
        'FrmBuscaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(675, 415)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFiltro)
        Me.Controls.Add(Me.DtvClientes)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "FrmBuscaCliente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Cliente"
        CType(Me.DtvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents DtvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cId As DataGridViewTextBoxColumn
    Friend WithEvents cCadastro As DataGridViewTextBoxColumn
    Friend WithEvents cName As DataGridViewTextBoxColumn
    Friend WithEvents cCPF As DataGridViewTextBoxColumn
    Friend WithEvents cTelefone As DataGridViewTextBoxColumn
    Friend WithEvents cEmail As DataGridViewTextBoxColumn
    Friend WithEvents cData As DataGridViewTextBoxColumn
    Friend WithEvents cSelect As DataGridViewImageColumn
End Class

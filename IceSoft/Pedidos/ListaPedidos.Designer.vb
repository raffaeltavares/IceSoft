<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaPedidos
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaPedidos))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DtvHistorico = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnReport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.CbUsuarios = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.CbTipoPagto = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.TxtFiltro = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CbTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.PLoading = New System.Windows.Forms.Panel()
        Me.LbPercent = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCustoMat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCustosAdd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cGanho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Local = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cView = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cDel = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DtvHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.PLoading.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtvHistorico
        '
        Me.DtvHistorico.AllowUserToAddRows = False
        Me.DtvHistorico.AllowUserToDeleteRows = False
        Me.DtvHistorico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtvHistorico.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DtvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtvHistorico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pedido, Me.cUser, Me.Data, Me.Cliente, Me.cValor, Me.cCustoMat, Me.cCustosAdd, Me.cGanho, Me.Local, Me.cView, Me.cDel})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtvHistorico.DefaultCellStyle = DataGridViewCellStyle12
        Me.DtvHistorico.Location = New System.Drawing.Point(0, 38)
        Me.DtvHistorico.Name = "DtvHistorico"
        Me.DtvHistorico.ReadOnly = True
        Me.DtvHistorico.RowHeadersWidth = 10
        Me.DtvHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtvHistorico.Size = New System.Drawing.Size(1047, 514)
        Me.DtvHistorico.TabIndex = 23
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReport, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.CbUsuarios, Me.ToolStripSeparator5, Me.ToolStripLabel5, Me.CbTipoPagto, Me.ToolStripSeparator3, Me.ToolStripLabel3, Me.TxtFiltro, Me.ToolStripSeparator4, Me.ToolStripLabel1, Me.CbTipo, Me.ToolStripLabel4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1047, 35)
        Me.ToolStrip1.TabIndex = 42
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnReport
        '
        Me.btnReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(34, 32)
        Me.btnReport.Text = "Relatório"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 35)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(59, 32)
        Me.ToolStripLabel2.Text = "USUARIO:"
        '
        'CbUsuarios
        '
        Me.CbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.CbUsuarios.Name = "CbUsuarios"
        Me.CbUsuarios.Size = New System.Drawing.Size(100, 35)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 35)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(39, 32)
        Me.ToolStripLabel5.Text = "PGTO:"
        '
        'CbTipoPagto
        '
        Me.CbTipoPagto.AutoCompleteCustomSource.AddRange(New String() {"TODOS", "1-Dinheiro", "2-Cartão Débito", "3-Cartão Crédito"})
        Me.CbTipoPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipoPagto.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.CbTipoPagto.Items.AddRange(New Object() {"TODOS", "1-DINHEIRO", "2-CARTÃO DÉBITO", "3 -CARTÃO CRÉDITO"})
        Me.CbTipoPagto.Name = "CbTipoPagto"
        Me.CbTipoPagto.Size = New System.Drawing.Size(100, 35)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 35)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(73, 32)
        Me.ToolStripLabel3.Text = "PESQUISAR: "
        '
        'TxtFiltro
        '
        Me.TxtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFiltro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(90, 35)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 35)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(133, 32)
        Me.ToolStripLabel1.Text = "OPÇÃO DE RELATÓRIO: "
        '
        'CbTipo
        '
        Me.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(110, 35)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(0, 32)
        '
        'PLoading
        '
        Me.PLoading.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PLoading.Controls.Add(Me.LbPercent)
        Me.PLoading.Controls.Add(Me.PictureBox1)
        Me.PLoading.Location = New System.Drawing.Point(495, 240)
        Me.PLoading.Name = "PLoading"
        Me.PLoading.Size = New System.Drawing.Size(56, 75)
        Me.PLoading.TabIndex = 43
        Me.PLoading.Visible = False
        '
        'LbPercent
        '
        Me.LbPercent.AutoSize = True
        Me.LbPercent.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPercent.Location = New System.Drawing.Point(23, 56)
        Me.LbPercent.Name = "LbPercent"
        Me.LbPercent.Size = New System.Drawing.Size(13, 14)
        Me.LbPercent.TabIndex = 6
        Me.LbPercent.Text = "..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IceSoft.My.Resources.Resources.ajax_loader
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(783, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 15)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "DE:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "00/00/0000"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(937, 6)
        Me.DateTimePicker2.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(91, 23)
        Me.DateTimePicker2.TabIndex = 38
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "00/00/0000"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(811, 6)
        Me.DateTimePicker1.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(91, 23)
        Me.DateTimePicker1.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(903, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "ATÉ:"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "..."
        Me.DataGridViewImageColumn1.Image = Global.IceSoft.My.Resources.Resources.view
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 22
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "..."
        Me.DataGridViewImageColumn2.Image = Global.IceSoft.My.Resources.Resources.redcross
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 22
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Pedido
        '
        Me.Pedido.HeaderText = "Pedido"
        Me.Pedido.Name = "Pedido"
        Me.Pedido.ReadOnly = True
        '
        'cUser
        '
        Me.cUser.HeaderText = "Usuario"
        Me.cUser.Name = "cUser"
        Me.cUser.ReadOnly = True
        Me.cUser.Width = 131
        '
        'Data
        '
        Me.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        '
        'Cliente
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cliente.DefaultCellStyle = DataGridViewCellStyle7
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 80
        '
        'cValor
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cValor.DefaultCellStyle = DataGridViewCellStyle8
        Me.cValor.HeaderText = "Vl. Pedido"
        Me.cValor.Name = "cValor"
        Me.cValor.ReadOnly = True
        '
        'cCustoMat
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cCustoMat.DefaultCellStyle = DataGridViewCellStyle9
        Me.cCustoMat.HeaderText = "C. Materiais"
        Me.cCustoMat.Name = "cCustoMat"
        Me.cCustoMat.ReadOnly = True
        '
        'cCustosAdd
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cCustosAdd.DefaultCellStyle = DataGridViewCellStyle10
        Me.cCustosAdd.HeaderText = "C. Adicionais"
        Me.cCustosAdd.Name = "cCustosAdd"
        Me.cCustosAdd.ReadOnly = True
        Me.cCustosAdd.Width = 110
        '
        'cGanho
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cGanho.DefaultCellStyle = DataGridViewCellStyle11
        Me.cGanho.HeaderText = "Ganho"
        Me.cGanho.Name = "cGanho"
        Me.cGanho.ReadOnly = True
        '
        'Local
        '
        Me.Local.HeaderText = "Pgto"
        Me.Local.Name = "Local"
        Me.Local.ReadOnly = True
        Me.Local.Width = 150
        '
        'cView
        '
        Me.cView.HeaderText = "..."
        Me.cView.Image = Global.IceSoft.My.Resources.Resources.view
        Me.cView.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.cView.Name = "cView"
        Me.cView.ReadOnly = True
        Me.cView.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cView.Width = 22
        '
        'cDel
        '
        Me.cDel.HeaderText = "..."
        Me.cDel.Image = Global.IceSoft.My.Resources.Resources.redcross
        Me.cDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.cDel.Name = "cDel"
        Me.cDel.ReadOnly = True
        Me.cDel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cDel.Width = 22
        '
        'FrmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1047, 554)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PLoading)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DtvHistorico)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Histórico de pedidos"
        CType(Me.DtvHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PLoading.ResumeLayout(False)
        Me.PLoading.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtvHistorico As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnReport As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents CbUsuarios As ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents TxtFiltro As ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents CbTipo As ToolStripComboBox
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents PLoading As Panel
    Friend WithEvents LbPercent As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents CbTipoPagto As ToolStripComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Pedido As DataGridViewTextBoxColumn
    Friend WithEvents cUser As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents cValor As DataGridViewTextBoxColumn
    Friend WithEvents cCustoMat As DataGridViewTextBoxColumn
    Friend WithEvents cCustosAdd As DataGridViewTextBoxColumn
    Friend WithEvents cGanho As DataGridViewTextBoxColumn
    Friend WithEvents Local As DataGridViewTextBoxColumn
    Friend WithEvents cView As DataGridViewImageColumn
    Friend WithEvents cDel As DataGridViewImageColumn
End Class

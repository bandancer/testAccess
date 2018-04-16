<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchDpcodePage
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.export = New System.Windows.Forms.Button()
        Me.StatementAndDpcodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatementAndDpcodeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.dpcodeGrid = New System.Windows.Forms.DataGridView()
        Me.StatementAndDpcodeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillBy2ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy2ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceWithTaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SONbrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestAccessDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestAccessDataSet = New WindowsApp1.testAccessDataSet()
        Me.StatementAndDpcodeTableAdapter = New WindowsApp1.testAccessDataSetTableAdapters.statementAndDpcodeTableAdapter()
        CType(Me.StatementAndDpcodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatementAndDpcodeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpcodeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatementAndDpcodeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy2ToolStrip.SuspendLayout()
        CType(Me.TestAccessDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'export
        '
        Me.export.Location = New System.Drawing.Point(690, 405)
        Me.export.Name = "export"
        Me.export.Size = New System.Drawing.Size(75, 23)
        Me.export.TabIndex = 0
        Me.export.Text = "导出结果"
        Me.export.UseVisualStyleBackColor = True
        '
        'StatementAndDpcodeBindingSource
        '
        Me.StatementAndDpcodeBindingSource.DataMember = "statementAndDpcode"
        Me.StatementAndDpcodeBindingSource.DataSource = Me.TestAccessDataSetBindingSource
        '
        'StatementAndDpcodeBindingSource1
        '
        Me.StatementAndDpcodeBindingSource1.DataMember = "statementAndDpcode"
        Me.StatementAndDpcodeBindingSource1.DataSource = Me.TestAccessDataSetBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "分行名称"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(252, 21)
        Me.TextBox1.TabIndex = 3
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(690, 28)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(75, 23)
        Me.search.TabIndex = 4
        Me.search.Text = "查询"
        Me.search.UseVisualStyleBackColor = True
        '
        'dpcodeGrid
        '
        Me.dpcodeGrid.AllowUserToAddRows = False
        Me.dpcodeGrid.AllowUserToDeleteRows = False
        Me.dpcodeGrid.AllowUserToOrderColumns = True
        Me.dpcodeGrid.AutoGenerateColumns = False
        Me.dpcodeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dpcodeGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BankNameDataGridViewTextBoxColumn, Me.BranchNameDataGridViewTextBoxColumn, Me.SiteDataGridViewTextBoxColumn, Me.OrderDateDataGridViewTextBoxColumn, Me.ShipDateDataGridViewTextBoxColumn, Me.BatchDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.PriceWithTaxDataGridViewTextBoxColumn, Me.TaxDataGridViewTextBoxColumn, Me.SONbrDataGridViewTextBoxColumn})
        Me.dpcodeGrid.DataSource = Me.StatementAndDpcodeBindingSource2
        Me.dpcodeGrid.Location = New System.Drawing.Point(37, 73)
        Me.dpcodeGrid.Name = "dpcodeGrid"
        Me.dpcodeGrid.ReadOnly = True
        Me.dpcodeGrid.RowTemplate.Height = 23
        Me.dpcodeGrid.Size = New System.Drawing.Size(728, 326)
        Me.dpcodeGrid.TabIndex = 5
        '
        'StatementAndDpcodeBindingSource2
        '
        Me.StatementAndDpcodeBindingSource2.DataMember = "statementAndDpcode"
        Me.StatementAndDpcodeBindingSource2.DataSource = Me.TestAccessDataSetBindingSource
        '
        'FillBy2ToolStrip
        '
        Me.FillBy2ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy2ToolStripButton})
        Me.FillBy2ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy2ToolStrip.Name = "FillBy2ToolStrip"
        Me.FillBy2ToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.FillBy2ToolStrip.TabIndex = 6
        Me.FillBy2ToolStrip.Text = "FillBy2ToolStrip"
        '
        'FillBy2ToolStripButton
        '
        Me.FillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy2ToolStripButton.Name = "FillBy2ToolStripButton"
        Me.FillBy2ToolStripButton.Size = New System.Drawing.Size(36, 22)
        Me.FillBy2ToolStripButton.Text = "查询"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'BankNameDataGridViewTextBoxColumn
        '
        Me.BankNameDataGridViewTextBoxColumn.DataPropertyName = "bankName"
        Me.BankNameDataGridViewTextBoxColumn.HeaderText = "bankName"
        Me.BankNameDataGridViewTextBoxColumn.Name = "BankNameDataGridViewTextBoxColumn"
        '
        'BranchNameDataGridViewTextBoxColumn
        '
        Me.BranchNameDataGridViewTextBoxColumn.DataPropertyName = "Branch Name"
        Me.BranchNameDataGridViewTextBoxColumn.HeaderText = "Branch Name"
        Me.BranchNameDataGridViewTextBoxColumn.Name = "BranchNameDataGridViewTextBoxColumn"
        '
        'SiteDataGridViewTextBoxColumn
        '
        Me.SiteDataGridViewTextBoxColumn.DataPropertyName = "site"
        Me.SiteDataGridViewTextBoxColumn.HeaderText = "site"
        Me.SiteDataGridViewTextBoxColumn.Name = "SiteDataGridViewTextBoxColumn"
        '
        'OrderDateDataGridViewTextBoxColumn
        '
        Me.OrderDateDataGridViewTextBoxColumn.DataPropertyName = "orderDate"
        Me.OrderDateDataGridViewTextBoxColumn.HeaderText = "orderDate"
        Me.OrderDateDataGridViewTextBoxColumn.Name = "OrderDateDataGridViewTextBoxColumn"
        '
        'ShipDateDataGridViewTextBoxColumn
        '
        Me.ShipDateDataGridViewTextBoxColumn.DataPropertyName = "shipDate"
        Me.ShipDateDataGridViewTextBoxColumn.HeaderText = "shipDate"
        Me.ShipDateDataGridViewTextBoxColumn.Name = "ShipDateDataGridViewTextBoxColumn"
        '
        'BatchDataGridViewTextBoxColumn
        '
        Me.BatchDataGridViewTextBoxColumn.DataPropertyName = "batch"
        Me.BatchDataGridViewTextBoxColumn.HeaderText = "batch"
        Me.BatchDataGridViewTextBoxColumn.Name = "BatchDataGridViewTextBoxColumn"
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "productName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "productName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'PriceWithTaxDataGridViewTextBoxColumn
        '
        Me.PriceWithTaxDataGridViewTextBoxColumn.DataPropertyName = "priceWithTax"
        Me.PriceWithTaxDataGridViewTextBoxColumn.HeaderText = "priceWithTax"
        Me.PriceWithTaxDataGridViewTextBoxColumn.Name = "PriceWithTaxDataGridViewTextBoxColumn"
        '
        'TaxDataGridViewTextBoxColumn
        '
        Me.TaxDataGridViewTextBoxColumn.DataPropertyName = "tax"
        Me.TaxDataGridViewTextBoxColumn.HeaderText = "tax"
        Me.TaxDataGridViewTextBoxColumn.Name = "TaxDataGridViewTextBoxColumn"
        '
        'SONbrDataGridViewTextBoxColumn
        '
        Me.SONbrDataGridViewTextBoxColumn.DataPropertyName = "SONbr"
        Me.SONbrDataGridViewTextBoxColumn.HeaderText = "SONbr"
        Me.SONbrDataGridViewTextBoxColumn.Name = "SONbrDataGridViewTextBoxColumn"
        '
        'TestAccessDataSetBindingSource
        '
        Me.TestAccessDataSetBindingSource.DataSource = Me.TestAccessDataSet
        Me.TestAccessDataSetBindingSource.Position = 0
        '
        'TestAccessDataSet
        '
        Me.TestAccessDataSet.DataSetName = "testAccessDataSet"
        Me.TestAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatementAndDpcodeTableAdapter
        '
        Me.StatementAndDpcodeTableAdapter.ClearBeforeFill = True
        '
        'searchDpcodePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FillBy2ToolStrip)
        Me.Controls.Add(Me.dpcodeGrid)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.export)
        Me.Name = "searchDpcodePage"
        Me.Text = "查询"
        CType(Me.StatementAndDpcodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatementAndDpcodeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpcodeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatementAndDpcodeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy2ToolStrip.ResumeLayout(False)
        Me.FillBy2ToolStrip.PerformLayout()
        CType(Me.TestAccessDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents export As Button
    Friend WithEvents TestAccessDataSetBindingSource As BindingSource
    Friend WithEvents TestAccessDataSet As testAccessDataSet
    Friend WithEvents StatementAndDpcodeBindingSource As BindingSource
    Friend WithEvents StatementAndDpcodeTableAdapter As testAccessDataSetTableAdapters.statementAndDpcodeTableAdapter
    Friend WithEvents StatementAndDpcodeBindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents search As Button
    Friend WithEvents dpcodeGrid As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BankNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BranchNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SiteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShipDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BatchDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceWithTaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SONbrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatementAndDpcodeBindingSource2 As BindingSource
    Friend WithEvents FillBy2ToolStrip As ToolStrip
    Friend WithEvents FillBy2ToolStripButton As ToolStripButton
End Class

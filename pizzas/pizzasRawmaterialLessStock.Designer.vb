<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pizzasRawmaterialLessStock
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
        Me.PizzaDataSet5 = New pizzas.pizzaDataSet5()
        Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemshavingrawmaterialslessthanstockminlevelTableAdapter = New pizzas.pizzaDataSet5TableAdapters.itemshavingrawmaterialslessthanstockminlevelTableAdapter()
        Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ItemidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RawmaterialnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RawmaterialsInStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RawmaterialMinimumStockLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PizzaDataSet6 = New pizzas.pizzaDataSet6()
        Me.ItemshavingrawmaterialslessthanstockminlevelTableAdapter1 = New pizzas.pizzaDataSet6TableAdapters.itemshavingrawmaterialslessthanstockminlevelTableAdapter()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintButton = New System.Windows.Forms.Button()
        CType(Me.PizzaDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PizzaDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PizzaDataSet5
        '
        Me.PizzaDataSet5.DataSetName = "pizzaDataSet5"
        Me.PizzaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemshavingrawmaterialslessthanstockminlevelBindingSource
        '
        Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource.DataMember = "itemshavingrawmaterialslessthanstockminlevel"
        Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource.DataSource = Me.PizzaDataSet5
        '
        'ItemshavingrawmaterialslessthanstockminlevelTableAdapter
        '
        Me.ItemshavingrawmaterialslessthanstockminlevelTableAdapter.ClearBeforeFill = True
        '
        'ItemshavingrawmaterialslessthanstockminlevelBindingSource1
        '
        Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource1.DataMember = "itemshavingrawmaterialslessthanstockminlevel"
        Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource1.DataSource = Me.PizzaDataSet5
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemidDataGridViewTextBoxColumn, Me.ItemnameDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.RawmaterialnameDataGridViewTextBoxColumn, Me.RawmaterialsInStockDataGridViewTextBoxColumn, Me.RawmaterialMinimumStockLevelDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(34, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(645, 226)
        Me.DataGridView1.TabIndex = 0
        '
        'ItemidDataGridViewTextBoxColumn
        '
        Me.ItemidDataGridViewTextBoxColumn.DataPropertyName = "Item_id"
        Me.ItemidDataGridViewTextBoxColumn.HeaderText = "Item_id"
        Me.ItemidDataGridViewTextBoxColumn.Name = "ItemidDataGridViewTextBoxColumn"
        '
        'ItemnameDataGridViewTextBoxColumn
        '
        Me.ItemnameDataGridViewTextBoxColumn.DataPropertyName = "Item_name"
        Me.ItemnameDataGridViewTextBoxColumn.HeaderText = "Item_name"
        Me.ItemnameDataGridViewTextBoxColumn.Name = "ItemnameDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'RawmaterialnameDataGridViewTextBoxColumn
        '
        Me.RawmaterialnameDataGridViewTextBoxColumn.DataPropertyName = "rawmaterial_name"
        Me.RawmaterialnameDataGridViewTextBoxColumn.HeaderText = "rawmaterial_name"
        Me.RawmaterialnameDataGridViewTextBoxColumn.Name = "RawmaterialnameDataGridViewTextBoxColumn"
        '
        'RawmaterialsInStockDataGridViewTextBoxColumn
        '
        Me.RawmaterialsInStockDataGridViewTextBoxColumn.DataPropertyName = "Rawmaterials in Stock"
        Me.RawmaterialsInStockDataGridViewTextBoxColumn.HeaderText = "Rawmaterials in Stock"
        Me.RawmaterialsInStockDataGridViewTextBoxColumn.Name = "RawmaterialsInStockDataGridViewTextBoxColumn"
        '
        'RawmaterialMinimumStockLevelDataGridViewTextBoxColumn
        '
        Me.RawmaterialMinimumStockLevelDataGridViewTextBoxColumn.DataPropertyName = "Rawmaterial minimum stock level"
        Me.RawmaterialMinimumStockLevelDataGridViewTextBoxColumn.HeaderText = "Rawmaterial minimum stock level"
        Me.RawmaterialMinimumStockLevelDataGridViewTextBoxColumn.Name = "RawmaterialMinimumStockLevelDataGridViewTextBoxColumn"
        '
        'ItemshavingrawmaterialslessthanstockminlevelBindingSource2
        '
        Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource2.DataMember = "itemshavingrawmaterialslessthanstockminlevel"
        Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource2.DataSource = Me.PizzaDataSet6
        '
        'PizzaDataSet6
        '
        Me.PizzaDataSet6.DataSetName = "pizzaDataSet6"
        Me.PizzaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemshavingrawmaterialslessthanstockminlevelTableAdapter1
        '
        Me.ItemshavingrawmaterialslessthanstockminlevelTableAdapter1.ClearBeforeFill = True
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintButton.Location = New System.Drawing.Point(638, 272)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 1
        Me.PrintButton.Text = "Print Report"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'pizzasRawmaterialLessStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 307)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "pizzasRawmaterialLessStock"
        Me.Text = "pizzasRawmaterialLessStock"
        CType(Me.PizzaDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemshavingrawmaterialslessthanstockminlevelBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PizzaDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PizzaDataSet5 As pizzaDataSet5
    Friend WithEvents ItemshavingrawmaterialslessthanstockminlevelBindingSource As BindingSource
    Friend WithEvents ItemshavingrawmaterialslessthanstockminlevelTableAdapter As pizzaDataSet5TableAdapters.itemshavingrawmaterialslessthanstockminlevelTableAdapter
    Friend WithEvents ItemshavingrawmaterialslessthanstockminlevelBindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PizzaDataSet6 As pizzaDataSet6
    Friend WithEvents ItemshavingrawmaterialslessthanstockminlevelBindingSource2 As BindingSource
    Friend WithEvents ItemshavingrawmaterialslessthanstockminlevelTableAdapter1 As pizzaDataSet6TableAdapters.itemshavingrawmaterialslessthanstockminlevelTableAdapter
    Friend WithEvents ItemidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RawmaterialnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RawmaterialsInStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RawmaterialMinimumStockLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintButton As Button
End Class

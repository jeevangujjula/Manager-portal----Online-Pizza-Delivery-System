<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryForm))
        Me.InvDataGridView = New System.Windows.Forms.DataGridView()
        Me.RawmaterialidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RawmaterialnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitsInStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitsOnOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventryreportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PizzaDataSet2 = New pizzas.pizzaDataSet2()
        Me.InventryreportTableAdapter = New pizzas.pizzaDataSet2TableAdapters.inventryreportTableAdapter()
        Me.InvPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.InvDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventryreportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PizzaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InvDataGridView
        '
        Me.InvDataGridView.AutoGenerateColumns = False
        Me.InvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RawmaterialidDataGridViewTextBoxColumn, Me.RawmaterialnameDataGridViewTextBoxColumn, Me.UnitsInStockDataGridViewTextBoxColumn, Me.UnitsOnOrderDataGridViewTextBoxColumn})
        Me.InvDataGridView.DataSource = Me.InventryreportBindingSource
        Me.InvDataGridView.Location = New System.Drawing.Point(31, 26)
        Me.InvDataGridView.Name = "InvDataGridView"
        Me.InvDataGridView.Size = New System.Drawing.Size(446, 295)
        Me.InvDataGridView.TabIndex = 0
        '
        'RawmaterialidDataGridViewTextBoxColumn
        '
        Me.RawmaterialidDataGridViewTextBoxColumn.DataPropertyName = "rawmaterial_id"
        Me.RawmaterialidDataGridViewTextBoxColumn.HeaderText = "rawmaterial_id"
        Me.RawmaterialidDataGridViewTextBoxColumn.Name = "RawmaterialidDataGridViewTextBoxColumn"
        '
        'RawmaterialnameDataGridViewTextBoxColumn
        '
        Me.RawmaterialnameDataGridViewTextBoxColumn.DataPropertyName = "rawmaterial_name"
        Me.RawmaterialnameDataGridViewTextBoxColumn.HeaderText = "rawmaterial_name"
        Me.RawmaterialnameDataGridViewTextBoxColumn.Name = "RawmaterialnameDataGridViewTextBoxColumn"
        '
        'UnitsInStockDataGridViewTextBoxColumn
        '
        Me.UnitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock"
        Me.UnitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitsInStock"
        Me.UnitsInStockDataGridViewTextBoxColumn.Name = "UnitsInStockDataGridViewTextBoxColumn"
        '
        'UnitsOnOrderDataGridViewTextBoxColumn
        '
        Me.UnitsOnOrderDataGridViewTextBoxColumn.DataPropertyName = "UnitsOnOrder"
        Me.UnitsOnOrderDataGridViewTextBoxColumn.HeaderText = "UnitsOnOrder"
        Me.UnitsOnOrderDataGridViewTextBoxColumn.Name = "UnitsOnOrderDataGridViewTextBoxColumn"
        '
        'InventryreportBindingSource
        '
        Me.InventryreportBindingSource.DataMember = "inventryreport"
        Me.InventryreportBindingSource.DataSource = Me.PizzaDataSet2
        '
        'PizzaDataSet2
        '
        Me.PizzaDataSet2.DataSetName = "pizzaDataSet2"
        Me.PizzaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventryreportTableAdapter
        '
        Me.InventryreportTableAdapter.ClearBeforeFill = True
        '
        'InvPrintDocument
        '
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(401, 328)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(116, 23)
        Me.PrintButton.TabIndex = 1
        Me.PrintButton.Text = "Print report"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 351)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.InvDataGridView)
        Me.Name = "InventoryForm"
        Me.Text = "InventoryForm"
        CType(Me.InvDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventryreportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PizzaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InvDataGridView As DataGridView
    Friend WithEvents PizzaDataSet2 As pizzaDataSet2
    Friend WithEvents InventryreportBindingSource As BindingSource
    Friend WithEvents InventryreportTableAdapter As pizzaDataSet2TableAdapters.inventryreportTableAdapter
    Friend WithEvents RawmaterialidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RawmaterialnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitsInStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitsOnOrderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvPrintDocument As Printing.PrintDocument
    Friend WithEvents PrintButton As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class

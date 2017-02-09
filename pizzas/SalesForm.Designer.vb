<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemquantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PosreportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PizzaDataSet3 = New pizzas.pizzaDataSet3()
        Me.PosreportTableAdapter = New pizzas.pizzaDataSet3TableAdapters.posreportTableAdapter()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PosreportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PizzaDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomeridDataGridViewTextBoxColumn, Me.OrderdateDataGridViewTextBoxColumn, Me.OrderidDataGridViewTextBoxColumn, Me.OrderpriceDataGridViewTextBoxColumn, Me.ItemidDataGridViewTextBoxColumn, Me.ItemquantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PosreportBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(642, 247)
        Me.DataGridView1.TabIndex = 0
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "Customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "Customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        '
        'OrderdateDataGridViewTextBoxColumn
        '
        Me.OrderdateDataGridViewTextBoxColumn.DataPropertyName = "Order_date"
        Me.OrderdateDataGridViewTextBoxColumn.HeaderText = "Order_date"
        Me.OrderdateDataGridViewTextBoxColumn.Name = "OrderdateDataGridViewTextBoxColumn"
        '
        'OrderidDataGridViewTextBoxColumn
        '
        Me.OrderidDataGridViewTextBoxColumn.DataPropertyName = "Order_id"
        Me.OrderidDataGridViewTextBoxColumn.HeaderText = "Order_id"
        Me.OrderidDataGridViewTextBoxColumn.Name = "OrderidDataGridViewTextBoxColumn"
        '
        'OrderpriceDataGridViewTextBoxColumn
        '
        Me.OrderpriceDataGridViewTextBoxColumn.DataPropertyName = "Order_price"
        Me.OrderpriceDataGridViewTextBoxColumn.HeaderText = "Order_price"
        Me.OrderpriceDataGridViewTextBoxColumn.Name = "OrderpriceDataGridViewTextBoxColumn"
        '
        'ItemidDataGridViewTextBoxColumn
        '
        Me.ItemidDataGridViewTextBoxColumn.DataPropertyName = "Item_id"
        Me.ItemidDataGridViewTextBoxColumn.HeaderText = "Item_id"
        Me.ItemidDataGridViewTextBoxColumn.Name = "ItemidDataGridViewTextBoxColumn"
        '
        'ItemquantityDataGridViewTextBoxColumn
        '
        Me.ItemquantityDataGridViewTextBoxColumn.DataPropertyName = "Item_quantity"
        Me.ItemquantityDataGridViewTextBoxColumn.HeaderText = "Item_quantity"
        Me.ItemquantityDataGridViewTextBoxColumn.Name = "ItemquantityDataGridViewTextBoxColumn"
        '
        'PosreportBindingSource
        '
        Me.PosreportBindingSource.DataMember = "posreport"
        Me.PosreportBindingSource.DataSource = Me.PizzaDataSet3
        '
        'PizzaDataSet3
        '
        Me.PizzaDataSet3.DataSetName = "pizzaDataSet3"
        Me.PizzaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PosreportTableAdapter
        '
        Me.PosreportTableAdapter.ClearBeforeFill = True
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintButton.Location = New System.Drawing.Point(579, 298)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 1
        Me.PrintButton.Text = "Print Report"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'SalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 333)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "SalesForm"
        Me.Text = "SalesForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PosreportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PizzaDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PizzaDataSet3 As pizzaDataSet3
    Friend WithEvents PosreportBindingSource As BindingSource
    Friend WithEvents PosreportTableAdapter As pizzaDataSet3TableAdapters.posreportTableAdapter
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemquantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintButton As Button
End Class

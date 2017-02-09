<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAllPO
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
        Me.POidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RawmaterialidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RawmaterialquantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendoridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POdeliverydateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseorderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PizzaDataSet7 = New pizzas.pizzaDataSet7()
        Me.PurchaseorderTableAdapter = New pizzas.pizzaDataSet7TableAdapters.purchaseorderTableAdapter()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseorderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PizzaDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.POidDataGridViewTextBoxColumn, Me.RawmaterialidDataGridViewTextBoxColumn, Me.RawmaterialquantityDataGridViewTextBoxColumn, Me.VendoridDataGridViewTextBoxColumn, Me.POdateDataGridViewTextBoxColumn, Me.PaymentstatusDataGridViewTextBoxColumn, Me.POdeliverydateDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PurchaseorderBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(814, 253)
        Me.DataGridView1.TabIndex = 0
        '
        'POidDataGridViewTextBoxColumn
        '
        Me.POidDataGridViewTextBoxColumn.DataPropertyName = "PO_id"
        Me.POidDataGridViewTextBoxColumn.HeaderText = "PO_id"
        Me.POidDataGridViewTextBoxColumn.Name = "POidDataGridViewTextBoxColumn"
        '
        'RawmaterialidDataGridViewTextBoxColumn
        '
        Me.RawmaterialidDataGridViewTextBoxColumn.DataPropertyName = "rawmaterial_id"
        Me.RawmaterialidDataGridViewTextBoxColumn.HeaderText = "rawmaterial_id"
        Me.RawmaterialidDataGridViewTextBoxColumn.Name = "RawmaterialidDataGridViewTextBoxColumn"
        '
        'RawmaterialquantityDataGridViewTextBoxColumn
        '
        Me.RawmaterialquantityDataGridViewTextBoxColumn.DataPropertyName = "rawmaterial_quantity"
        Me.RawmaterialquantityDataGridViewTextBoxColumn.HeaderText = "rawmaterial_quantity"
        Me.RawmaterialquantityDataGridViewTextBoxColumn.Name = "RawmaterialquantityDataGridViewTextBoxColumn"
        '
        'VendoridDataGridViewTextBoxColumn
        '
        Me.VendoridDataGridViewTextBoxColumn.DataPropertyName = "vendor_id"
        Me.VendoridDataGridViewTextBoxColumn.HeaderText = "vendor_id"
        Me.VendoridDataGridViewTextBoxColumn.Name = "VendoridDataGridViewTextBoxColumn"
        '
        'POdateDataGridViewTextBoxColumn
        '
        Me.POdateDataGridViewTextBoxColumn.DataPropertyName = "PO_date"
        Me.POdateDataGridViewTextBoxColumn.HeaderText = "PO_date"
        Me.POdateDataGridViewTextBoxColumn.Name = "POdateDataGridViewTextBoxColumn"
        '
        'PaymentstatusDataGridViewTextBoxColumn
        '
        Me.PaymentstatusDataGridViewTextBoxColumn.DataPropertyName = "payment_status"
        Me.PaymentstatusDataGridViewTextBoxColumn.HeaderText = "payment_status"
        Me.PaymentstatusDataGridViewTextBoxColumn.Name = "PaymentstatusDataGridViewTextBoxColumn"
        '
        'POdeliverydateDataGridViewTextBoxColumn
        '
        Me.POdeliverydateDataGridViewTextBoxColumn.DataPropertyName = "PO_deliverydate"
        Me.POdeliverydateDataGridViewTextBoxColumn.HeaderText = "PO_deliverydate"
        Me.POdeliverydateDataGridViewTextBoxColumn.Name = "POdeliverydateDataGridViewTextBoxColumn"
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "Employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "Employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        '
        'PurchaseorderBindingSource
        '
        Me.PurchaseorderBindingSource.DataMember = "purchaseorder"
        Me.PurchaseorderBindingSource.DataSource = Me.PizzaDataSet7
        '
        'PizzaDataSet7
        '
        Me.PizzaDataSet7.DataSetName = "pizzaDataSet7"
        Me.PizzaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurchaseorderTableAdapter
        '
        Me.PurchaseorderTableAdapter.ClearBeforeFill = True
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintButton.Location = New System.Drawing.Point(737, 283)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 1
        Me.PrintButton.Text = "PrintButton"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ViewAllPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 318)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewAllPO"
        Me.Text = "ViewAllPO"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseorderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PizzaDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PizzaDataSet7 As pizzaDataSet7
    Friend WithEvents PurchaseorderBindingSource As BindingSource
    Friend WithEvents PurchaseorderTableAdapter As pizzaDataSet7TableAdapters.purchaseorderTableAdapter
    Friend WithEvents POidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RawmaterialidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RawmaterialquantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendoridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POdeliverydateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintButton As Button
End Class

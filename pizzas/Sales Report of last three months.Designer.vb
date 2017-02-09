<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_Report_of_last_three_months
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
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesreportbymonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PizzaDataSet6 = New pizzas.pizzaDataSet6()
        Me.SalesreportbymonthTableAdapter = New pizzas.pizzaDataSet6TableAdapters.salesreportbymonthTableAdapter()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesreportbymonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PizzaDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubtotalDataGridViewTextBoxColumn, Me.MDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SalesreportbymonthBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(21, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(244, 211)
        Me.DataGridView1.TabIndex = 0
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        '
        'MDataGridViewTextBoxColumn
        '
        Me.MDataGridViewTextBoxColumn.DataPropertyName = "m"
        Me.MDataGridViewTextBoxColumn.HeaderText = "Month Number"
        Me.MDataGridViewTextBoxColumn.Name = "MDataGridViewTextBoxColumn"
        '
        'SalesreportbymonthBindingSource
        '
        Me.SalesreportbymonthBindingSource.DataMember = "salesreportbymonth"
        Me.SalesreportbymonthBindingSource.DataSource = Me.PizzaDataSet6
        '
        'PizzaDataSet6
        '
        Me.PizzaDataSet6.DataSetName = "pizzaDataSet6"
        Me.PizzaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesreportbymonthTableAdapter
        '
        Me.SalesreportbymonthTableAdapter.ClearBeforeFill = True
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintButton.Location = New System.Drawing.Point(336, 306)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 1
        Me.PrintButton.Text = "Print report"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'Sales_Report_of_last_three_months
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 350)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Sales_Report_of_last_three_months"
        Me.Text = "Sales_Report_of_last_three_months"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesreportbymonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PizzaDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PizzaDataSet6 As pizzaDataSet6
    Friend WithEvents SalesreportbymonthBindingSource As BindingSource
    Friend WithEvents SalesreportbymonthTableAdapter As pizzaDataSet6TableAdapters.salesreportbymonthTableAdapter
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintButton As Button
End Class

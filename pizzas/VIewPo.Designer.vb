<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VIewPo
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
        Me.VendoridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoOfPOsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountonpobvndorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PizzaDataSet7 = New pizzas.pizzaDataSet7()
        Me.AmountonpobvndorsTableAdapter = New pizzas.pizzaDataSet7TableAdapters.amountonpobvndorsTableAdapter()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmountonpobvndorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PizzaDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VendoridDataGridViewTextBoxColumn, Me.NoOfPOsDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AmountonpobvndorsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(40, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(345, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'VendoridDataGridViewTextBoxColumn
        '
        Me.VendoridDataGridViewTextBoxColumn.DataPropertyName = "vendor_id"
        Me.VendoridDataGridViewTextBoxColumn.HeaderText = "vendor_id"
        Me.VendoridDataGridViewTextBoxColumn.Name = "VendoridDataGridViewTextBoxColumn"
        '
        'NoOfPOsDataGridViewTextBoxColumn
        '
        Me.NoOfPOsDataGridViewTextBoxColumn.DataPropertyName = "No_ of POs"
        Me.NoOfPOsDataGridViewTextBoxColumn.HeaderText = "No_ of POs"
        Me.NoOfPOsDataGridViewTextBoxColumn.Name = "NoOfPOsDataGridViewTextBoxColumn"
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total Amount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "Total Amount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        '
        'AmountonpobvndorsBindingSource
        '
        Me.AmountonpobvndorsBindingSource.DataMember = "amountonpobvndors"
        Me.AmountonpobvndorsBindingSource.DataSource = Me.PizzaDataSet7
        '
        'PizzaDataSet7
        '
        Me.PizzaDataSet7.DataSetName = "pizzaDataSet7"
        Me.PizzaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AmountonpobvndorsTableAdapter
        '
        Me.AmountonpobvndorsTableAdapter.ClearBeforeFill = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(247, 204)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 1
        Me.PrintButton.Text = "Print report"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'VIewPo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 239)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "VIewPo"
        Me.Text = "VIewPo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmountonpobvndorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PizzaDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PizzaDataSet7 As pizzaDataSet7
    Friend WithEvents AmountonpobvndorsBindingSource As BindingSource
    Friend WithEvents AmountonpobvndorsTableAdapter As pizzaDataSet7TableAdapters.amountonpobvndorsTableAdapter
    Friend WithEvents VendoridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoOfPOsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrintButton As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutEmpForm
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
        Me.PizzaDataSet5 = New pizzas.pizzaDataSet5()
        Me.ManagerviewsemployeedetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManagerviewsemployeedetailsTableAdapter = New pizzas.pizzaDataSet5TableAdapters.managerviewsemployeedetailsTableAdapter()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiredateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursworkedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountpaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PizzaDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagerviewsemployeedetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeidDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.BirthdateDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.HiredateDataGridViewTextBoxColumn, Me.ManagerDataGridViewTextBoxColumn, Me.DeptnameDataGridViewTextBoxColumn, Me.PaymentdateDataGridViewTextBoxColumn, Me.HoursworkedDataGridViewTextBoxColumn, Me.AmountpaidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ManagerviewsemployeedetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(31, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1240, 244)
        Me.DataGridView1.TabIndex = 0
        '
        'PizzaDataSet5
        '
        Me.PizzaDataSet5.DataSetName = "pizzaDataSet5"
        Me.PizzaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ManagerviewsemployeedetailsBindingSource
        '
        Me.ManagerviewsemployeedetailsBindingSource.DataMember = "managerviewsemployeedetails"
        Me.ManagerviewsemployeedetailsBindingSource.DataSource = Me.PizzaDataSet5
        '
        'ManagerviewsemployeedetailsTableAdapter
        '
        Me.ManagerviewsemployeedetailsTableAdapter.ClearBeforeFill = True
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'BirthdateDataGridViewTextBoxColumn
        '
        Me.BirthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.Name = "BirthdateDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'HiredateDataGridViewTextBoxColumn
        '
        Me.HiredateDataGridViewTextBoxColumn.DataPropertyName = "hire_date"
        Me.HiredateDataGridViewTextBoxColumn.HeaderText = "hire_date"
        Me.HiredateDataGridViewTextBoxColumn.Name = "HiredateDataGridViewTextBoxColumn"
        '
        'ManagerDataGridViewTextBoxColumn
        '
        Me.ManagerDataGridViewTextBoxColumn.DataPropertyName = "Manager"
        Me.ManagerDataGridViewTextBoxColumn.HeaderText = "Manager"
        Me.ManagerDataGridViewTextBoxColumn.Name = "ManagerDataGridViewTextBoxColumn"
        '
        'DeptnameDataGridViewTextBoxColumn
        '
        Me.DeptnameDataGridViewTextBoxColumn.DataPropertyName = "dept_name"
        Me.DeptnameDataGridViewTextBoxColumn.HeaderText = "dept_name"
        Me.DeptnameDataGridViewTextBoxColumn.Name = "DeptnameDataGridViewTextBoxColumn"
        '
        'PaymentdateDataGridViewTextBoxColumn
        '
        Me.PaymentdateDataGridViewTextBoxColumn.DataPropertyName = "payment_date"
        Me.PaymentdateDataGridViewTextBoxColumn.HeaderText = "payment_date"
        Me.PaymentdateDataGridViewTextBoxColumn.Name = "PaymentdateDataGridViewTextBoxColumn"
        '
        'HoursworkedDataGridViewTextBoxColumn
        '
        Me.HoursworkedDataGridViewTextBoxColumn.DataPropertyName = "Hours_worked"
        Me.HoursworkedDataGridViewTextBoxColumn.HeaderText = "Hours_worked"
        Me.HoursworkedDataGridViewTextBoxColumn.Name = "HoursworkedDataGridViewTextBoxColumn"
        '
        'AmountpaidDataGridViewTextBoxColumn
        '
        Me.AmountpaidDataGridViewTextBoxColumn.DataPropertyName = "Amount_paid"
        Me.AmountpaidDataGridViewTextBoxColumn.HeaderText = "Amount_paid"
        Me.AmountpaidDataGridViewTextBoxColumn.Name = "AmountpaidDataGridViewTextBoxColumn"
        '
        'AboutEmpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 300)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AboutEmpForm"
        Me.Text = "AboutEmpForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PizzaDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagerviewsemployeedetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PizzaDataSet5 As pizzaDataSet5
    Friend WithEvents ManagerviewsemployeedetailsBindingSource As BindingSource
    Friend WithEvents ManagerviewsemployeedetailsTableAdapter As pizzaDataSet5TableAdapters.managerviewsemployeedetailsTableAdapter
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HiredateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManagerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeptnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoursworkedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountpaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

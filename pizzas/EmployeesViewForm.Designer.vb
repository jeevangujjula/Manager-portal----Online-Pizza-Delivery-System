<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeesViewForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.viewEmpButton = New System.Windows.Forms.Button()
        Me.viewAllEmpButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.empIdTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiredateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportsToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasshashDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassnounceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecurityquestionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecurityanswerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayrollidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PizzaDataSet = New pizzas.pizzaDataSet()
        Me.EmpUpdateButton = New System.Windows.Forms.Button()
        Me.EmployeeTableAdapter = New pizzas.pizzaDataSetTableAdapters.employeeTableAdapter()
        Me.DelEmpButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PizzaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewEmpButton
        '
        Me.viewEmpButton.Location = New System.Drawing.Point(76, 86)
        Me.viewEmpButton.Name = "viewEmpButton"
        Me.viewEmpButton.Size = New System.Drawing.Size(134, 23)
        Me.viewEmpButton.TabIndex = 0
        Me.viewEmpButton.Text = "View Employee Details"
        Me.viewEmpButton.UseVisualStyleBackColor = True
        '
        'viewAllEmpButton
        '
        Me.viewAllEmpButton.Location = New System.Drawing.Point(76, 217)
        Me.viewAllEmpButton.Name = "viewAllEmpButton"
        Me.viewAllEmpButton.Size = New System.Drawing.Size(134, 23)
        Me.viewAllEmpButton.TabIndex = 1
        Me.viewAllEmpButton.Text = "View All Employees"
        Me.viewAllEmpButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee ID"
        '
        'empIdTextBox
        '
        Me.empIdTextBox.Location = New System.Drawing.Point(78, 36)
        Me.empIdTextBox.Name = "empIdTextBox"
        Me.empIdTextBox.Size = New System.Drawing.Size(132, 20)
        Me.empIdTextBox.TabIndex = 3
        '
        'DataGridView1
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeidDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.BirthdateDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.HiredateDataGridViewTextBoxColumn, Me.ReportsToDataGridViewTextBoxColumn, Me.DepartmentidDataGridViewTextBoxColumn, Me.ContactidDataGridViewTextBoxColumn, Me.UserIdDataGridViewTextBoxColumn, Me.PasshashDataGridViewTextBoxColumn, Me.PassnounceDataGridViewTextBoxColumn, Me.SecurityquestionDataGridViewTextBoxColumn, Me.SecurityanswerDataGridViewTextBoxColumn, Me.PayrollidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(234, 9)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(933, 264)
        Me.DataGridView1.TabIndex = 4
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        Me.EmployeeidDataGridViewTextBoxColumn.Width = 91
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.Width = 77
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.Width = 78
        '
        'BirthdateDataGridViewTextBoxColumn
        '
        Me.BirthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.Name = "BirthdateDataGridViewTextBoxColumn"
        Me.BirthdateDataGridViewTextBoxColumn.Width = 74
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.Width = 63
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 57
        '
        'HiredateDataGridViewTextBoxColumn
        '
        Me.HiredateDataGridViewTextBoxColumn.DataPropertyName = "hire_date"
        Me.HiredateDataGridViewTextBoxColumn.HeaderText = "hire_date"
        Me.HiredateDataGridViewTextBoxColumn.Name = "HiredateDataGridViewTextBoxColumn"
        Me.HiredateDataGridViewTextBoxColumn.Width = 76
        '
        'ReportsToDataGridViewTextBoxColumn
        '
        Me.ReportsToDataGridViewTextBoxColumn.DataPropertyName = "ReportsTo"
        Me.ReportsToDataGridViewTextBoxColumn.HeaderText = "ReportsTo"
        Me.ReportsToDataGridViewTextBoxColumn.Name = "ReportsToDataGridViewTextBoxColumn"
        Me.ReportsToDataGridViewTextBoxColumn.Width = 82
        '
        'DepartmentidDataGridViewTextBoxColumn
        '
        Me.DepartmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id"
        Me.DepartmentidDataGridViewTextBoxColumn.HeaderText = "department_id"
        Me.DepartmentidDataGridViewTextBoxColumn.Name = "DepartmentidDataGridViewTextBoxColumn"
        Me.DepartmentidDataGridViewTextBoxColumn.Width = 99
        '
        'ContactidDataGridViewTextBoxColumn
        '
        Me.ContactidDataGridViewTextBoxColumn.DataPropertyName = "contact_id"
        Me.ContactidDataGridViewTextBoxColumn.HeaderText = "contact_id"
        Me.ContactidDataGridViewTextBoxColumn.Name = "ContactidDataGridViewTextBoxColumn"
        Me.ContactidDataGridViewTextBoxColumn.Width = 82
        '
        'UserIdDataGridViewTextBoxColumn
        '
        Me.UserIdDataGridViewTextBoxColumn.DataPropertyName = "userId"
        Me.UserIdDataGridViewTextBoxColumn.HeaderText = "userId"
        Me.UserIdDataGridViewTextBoxColumn.Name = "UserIdDataGridViewTextBoxColumn"
        Me.UserIdDataGridViewTextBoxColumn.Width = 61
        '
        'PasshashDataGridViewTextBoxColumn
        '
        Me.PasshashDataGridViewTextBoxColumn.DataPropertyName = "passhash"
        Me.PasshashDataGridViewTextBoxColumn.HeaderText = "passhash"
        Me.PasshashDataGridViewTextBoxColumn.Name = "PasshashDataGridViewTextBoxColumn"
        Me.PasshashDataGridViewTextBoxColumn.Width = 77
        '
        'PassnounceDataGridViewTextBoxColumn
        '
        Me.PassnounceDataGridViewTextBoxColumn.DataPropertyName = "passnounce"
        Me.PassnounceDataGridViewTextBoxColumn.HeaderText = "passnounce"
        Me.PassnounceDataGridViewTextBoxColumn.Name = "PassnounceDataGridViewTextBoxColumn"
        Me.PassnounceDataGridViewTextBoxColumn.Width = 90
        '
        'SecurityquestionDataGridViewTextBoxColumn
        '
        Me.SecurityquestionDataGridViewTextBoxColumn.DataPropertyName = "security_question"
        Me.SecurityquestionDataGridViewTextBoxColumn.HeaderText = "security_question"
        Me.SecurityquestionDataGridViewTextBoxColumn.Name = "SecurityquestionDataGridViewTextBoxColumn"
        Me.SecurityquestionDataGridViewTextBoxColumn.Width = 114
        '
        'SecurityanswerDataGridViewTextBoxColumn
        '
        Me.SecurityanswerDataGridViewTextBoxColumn.DataPropertyName = "security_answer"
        Me.SecurityanswerDataGridViewTextBoxColumn.HeaderText = "security_answer"
        Me.SecurityanswerDataGridViewTextBoxColumn.Name = "SecurityanswerDataGridViewTextBoxColumn"
        Me.SecurityanswerDataGridViewTextBoxColumn.Width = 108
        '
        'PayrollidDataGridViewTextBoxColumn
        '
        Me.PayrollidDataGridViewTextBoxColumn.DataPropertyName = "payroll_id"
        Me.PayrollidDataGridViewTextBoxColumn.HeaderText = "payroll_id"
        Me.PayrollidDataGridViewTextBoxColumn.Name = "PayrollidDataGridViewTextBoxColumn"
        Me.PayrollidDataGridViewTextBoxColumn.Width = 76
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.PizzaDataSet
        '
        'PizzaDataSet
        '
        Me.PizzaDataSet.DataSetName = "pizzaDataSet"
        Me.PizzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpUpdateButton
        '
        Me.EmpUpdateButton.Location = New System.Drawing.Point(74, 124)
        Me.EmpUpdateButton.Name = "EmpUpdateButton"
        Me.EmpUpdateButton.Size = New System.Drawing.Size(136, 23)
        Me.EmpUpdateButton.TabIndex = 5
        Me.EmpUpdateButton.Text = "Update Employee Details"
        Me.EmpUpdateButton.UseVisualStyleBackColor = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'DelEmpButton
        '
        Me.DelEmpButton.Location = New System.Drawing.Point(76, 174)
        Me.DelEmpButton.Name = "DelEmpButton"
        Me.DelEmpButton.Size = New System.Drawing.Size(134, 23)
        Me.DelEmpButton.TabIndex = 6
        Me.DelEmpButton.Text = "Delete Employee"
        Me.DelEmpButton.UseVisualStyleBackColor = True
        '
        'EmployeesViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 318)
        Me.Controls.Add(Me.DelEmpButton)
        Me.Controls.Add(Me.EmpUpdateButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.empIdTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.viewAllEmpButton)
        Me.Controls.Add(Me.viewEmpButton)
        Me.Name = "EmployeesViewForm"
        Me.Text = "EmployeesViewForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PizzaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents viewEmpButton As Button
    Friend WithEvents viewAllEmpButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents empIdTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PizzaDataSet As pizzaDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As pizzaDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HiredateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportsToDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasshashDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PassnounceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SecurityquestionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SecurityanswerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PayrollidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpUpdateButton As Button
    Friend WithEvents DelEmpButton As Button
End Class

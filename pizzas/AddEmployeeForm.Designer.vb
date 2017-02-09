<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployeeForm
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
        Me.fnameTextBox = New System.Windows.Forms.TextBox()
        Me.lnameTextBox = New System.Windows.Forms.TextBox()
        Me.phoneTextBox = New System.Windows.Forms.TextBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.birthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.hireDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearAllButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Zip = New System.Windows.Forms.Label()
        Me.AddrLineTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.zipTextBox = New System.Windows.Forms.TextBox()
        Me.AddrtypeComboBox = New System.Windows.Forms.ComboBox()
        Me.reportsToComboBox = New System.Windows.Forms.ComboBox()
        Me.deptComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'fnameTextBox
        '
        Me.fnameTextBox.Location = New System.Drawing.Point(199, 18)
        Me.fnameTextBox.Name = "fnameTextBox"
        Me.fnameTextBox.Size = New System.Drawing.Size(135, 20)
        Me.fnameTextBox.TabIndex = 0
        '
        'lnameTextBox
        '
        Me.lnameTextBox.Location = New System.Drawing.Point(199, 44)
        Me.lnameTextBox.Name = "lnameTextBox"
        Me.lnameTextBox.Size = New System.Drawing.Size(135, 20)
        Me.lnameTextBox.TabIndex = 1
        '
        'phoneTextBox
        '
        Me.phoneTextBox.Location = New System.Drawing.Point(199, 74)
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.Size = New System.Drawing.Size(135, 20)
        Me.phoneTextBox.TabIndex = 2
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(199, 106)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(135, 20)
        Me.emailTextBox.TabIndex = 3
        '
        'birthDateTimePicker
        '
        Me.birthDateTimePicker.Location = New System.Drawing.Point(199, 189)
        Me.birthDateTimePicker.Name = "birthDateTimePicker"
        Me.birthDateTimePicker.Size = New System.Drawing.Size(190, 20)
        Me.birthDateTimePicker.TabIndex = 7
        '
        'hireDateTimePicker
        '
        Me.hireDateTimePicker.Location = New System.Drawing.Point(199, 215)
        Me.hireDateTimePicker.Name = "hireDateTimePicker"
        Me.hireDateTimePicker.Size = New System.Drawing.Size(190, 20)
        Me.hireDateTimePicker.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Firstname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Reports To"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Department Id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(68, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "BirthDate"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "HireDate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Lastname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Phone"
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(84, 397)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 13
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearAllButton
        '
        Me.ClearAllButton.Location = New System.Drawing.Point(244, 397)
        Me.ClearAllButton.Name = "ClearAllButton"
        Me.ClearAllButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearAllButton.TabIndex = 14
        Me.ClearAllButton.Text = "Clear All"
        Me.ClearAllButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Address Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(68, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Address Line"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(68, 318)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "City"
        '
        'Zip
        '
        Me.Zip.AutoSize = True
        Me.Zip.Location = New System.Drawing.Point(68, 349)
        Me.Zip.Name = "Zip"
        Me.Zip.Size = New System.Drawing.Size(22, 13)
        Me.Zip.TabIndex = 28
        Me.Zip.Text = "Zip"
        '
        'AddrLineTextBox
        '
        Me.AddrLineTextBox.Location = New System.Drawing.Point(199, 283)
        Me.AddrLineTextBox.Name = "AddrLineTextBox"
        Me.AddrLineTextBox.Size = New System.Drawing.Size(135, 20)
        Me.AddrLineTextBox.TabIndex = 10
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(199, 311)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(135, 20)
        Me.CityTextBox.TabIndex = 11
        '
        'zipTextBox
        '
        Me.zipTextBox.Location = New System.Drawing.Point(199, 342)
        Me.zipTextBox.Name = "zipTextBox"
        Me.zipTextBox.Size = New System.Drawing.Size(135, 20)
        Me.zipTextBox.TabIndex = 12
        '
        'AddrtypeComboBox
        '
        Me.AddrtypeComboBox.FormattingEnabled = True
        Me.AddrtypeComboBox.Location = New System.Drawing.Point(198, 253)
        Me.AddrtypeComboBox.Name = "AddrtypeComboBox"
        Me.AddrtypeComboBox.Size = New System.Drawing.Size(136, 21)
        Me.AddrtypeComboBox.TabIndex = 9
        '
        'reportsToComboBox
        '
        Me.reportsToComboBox.FormattingEnabled = True
        Me.reportsToComboBox.Location = New System.Drawing.Point(199, 134)
        Me.reportsToComboBox.Name = "reportsToComboBox"
        Me.reportsToComboBox.Size = New System.Drawing.Size(135, 21)
        Me.reportsToComboBox.TabIndex = 4
        '
        'deptComboBox
        '
        Me.deptComboBox.FormattingEnabled = True
        Me.deptComboBox.Location = New System.Drawing.Point(199, 161)
        Me.deptComboBox.Name = "deptComboBox"
        Me.deptComboBox.Size = New System.Drawing.Size(135, 21)
        Me.deptComboBox.TabIndex = 5
        '
        'AddEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(490, 493)
        Me.Controls.Add(Me.deptComboBox)
        Me.Controls.Add(Me.reportsToComboBox)
        Me.Controls.Add(Me.AddrtypeComboBox)
        Me.Controls.Add(Me.zipTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddrLineTextBox)
        Me.Controls.Add(Me.Zip)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ClearAllButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hireDateTimePicker)
        Me.Controls.Add(Me.birthDateTimePicker)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.phoneTextBox)
        Me.Controls.Add(Me.lnameTextBox)
        Me.Controls.Add(Me.fnameTextBox)
        Me.Name = "AddEmployeeForm"
        Me.Text = "AddEmployeeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fnameTextBox As TextBox
    Friend WithEvents lnameTextBox As TextBox
    Friend WithEvents phoneTextBox As TextBox
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents birthDateTimePicker As DateTimePicker
    Friend WithEvents hireDateTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearAllButton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Zip As Label
    Friend WithEvents AddrLineTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents zipTextBox As TextBox
    Friend WithEvents AddrtypeComboBox As ComboBox
    Friend WithEvents reportsToComboBox As ComboBox
    Friend WithEvents deptComboBox As ComboBox
End Class

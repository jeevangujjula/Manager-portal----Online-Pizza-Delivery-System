<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateEmpForm
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
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.phoneTextBox = New System.Windows.Forms.TextBox()
        Me.lnameTextBox = New System.Windows.Forms.TextBox()
        Me.fnameTextBox = New System.Windows.Forms.TextBox()
        Me.empIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ContactIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.reportstoTextBox = New System.Windows.Forms.TextBox()
        Me.deptTextbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(229, 303)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 42
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(44, 303)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 41
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Department Id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Reports To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Lastname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Firstname"
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(169, 144)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(135, 20)
        Me.emailTextBox.TabIndex = 28
        '
        'phoneTextBox
        '
        Me.phoneTextBox.Location = New System.Drawing.Point(169, 112)
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.Size = New System.Drawing.Size(135, 20)
        Me.phoneTextBox.TabIndex = 27
        '
        'lnameTextBox
        '
        Me.lnameTextBox.Location = New System.Drawing.Point(169, 82)
        Me.lnameTextBox.Name = "lnameTextBox"
        Me.lnameTextBox.Size = New System.Drawing.Size(135, 20)
        Me.lnameTextBox.TabIndex = 26
        '
        'fnameTextBox
        '
        Me.fnameTextBox.Location = New System.Drawing.Point(169, 56)
        Me.fnameTextBox.Name = "fnameTextBox"
        Me.fnameTextBox.Size = New System.Drawing.Size(135, 20)
        Me.fnameTextBox.TabIndex = 25
        '
        'empIdTextBox
        '
        Me.empIdTextBox.Location = New System.Drawing.Point(169, 28)
        Me.empIdTextBox.Name = "empIdTextBox"
        Me.empIdTextBox.ReadOnly = True
        Me.empIdTextBox.Size = New System.Drawing.Size(135, 20)
        Me.empIdTextBox.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Employee ID"
        '
        'ContactIDTextBox
        '
        Me.ContactIDTextBox.Location = New System.Drawing.Point(169, 245)
        Me.ContactIDTextBox.Name = "ContactIDTextBox"
        Me.ContactIDTextBox.Size = New System.Drawing.Size(135, 20)
        Me.ContactIDTextBox.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Contact ID"
        '
        'reportstoTextBox
        '
        Me.reportstoTextBox.Location = New System.Drawing.Point(169, 179)
        Me.reportstoTextBox.Name = "reportstoTextBox"
        Me.reportstoTextBox.Size = New System.Drawing.Size(135, 20)
        Me.reportstoTextBox.TabIndex = 47
        '
        'deptTextbox
        '
        Me.deptTextbox.Location = New System.Drawing.Point(169, 207)
        Me.deptTextbox.Name = "deptTextbox"
        Me.deptTextbox.Size = New System.Drawing.Size(135, 20)
        Me.deptTextbox.TabIndex = 48
        '
        'UpdateEmpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 371)
        Me.Controls.Add(Me.deptTextbox)
        Me.Controls.Add(Me.reportstoTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ContactIDTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.empIdTextBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.phoneTextBox)
        Me.Controls.Add(Me.lnameTextBox)
        Me.Controls.Add(Me.fnameTextBox)
        Me.Name = "UpdateEmpForm"
        Me.Text = "UpdateEmpForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClearButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents phoneTextBox As TextBox
    Friend WithEvents lnameTextBox As TextBox
    Friend WithEvents fnameTextBox As TextBox
    Friend WithEvents empIdTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ContactIDTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents reportstoTextBox As TextBox
    Friend WithEvents deptTextbox As TextBox
End Class

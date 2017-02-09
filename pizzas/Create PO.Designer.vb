<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_PO
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
        Me.RmIdTextBox = New System.Windows.Forms.TextBox()
        Me.RmQntyTextBox = New System.Windows.Forms.TextBox()
        Me.vendorIdTextBox = New System.Windows.Forms.TextBox()
        Me.empIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.PODateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PoDeliveryDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'RmIdTextBox
        '
        Me.RmIdTextBox.Location = New System.Drawing.Point(166, 28)
        Me.RmIdTextBox.Name = "RmIdTextBox"
        Me.RmIdTextBox.Size = New System.Drawing.Size(185, 20)
        Me.RmIdTextBox.TabIndex = 0
        '
        'RmQntyTextBox
        '
        Me.RmQntyTextBox.Location = New System.Drawing.Point(166, 64)
        Me.RmQntyTextBox.Name = "RmQntyTextBox"
        Me.RmQntyTextBox.Size = New System.Drawing.Size(185, 20)
        Me.RmQntyTextBox.TabIndex = 2
        '
        'vendorIdTextBox
        '
        Me.vendorIdTextBox.Location = New System.Drawing.Point(166, 99)
        Me.vendorIdTextBox.Name = "vendorIdTextBox"
        Me.vendorIdTextBox.Size = New System.Drawing.Size(185, 20)
        Me.vendorIdTextBox.TabIndex = 4
        '
        'empIdTextBox
        '
        Me.empIdTextBox.Location = New System.Drawing.Point(166, 217)
        Me.empIdTextBox.Name = "empIdTextBox"
        Me.empIdTextBox.Size = New System.Drawing.Size(185, 20)
        Me.empIdTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Rawmaterial Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Rawmaterial Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Vendor Id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "PO date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "PO delivery date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Employee ID"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(166, 268)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 20
        Me.SaveButton.Text = "Save "
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(276, 268)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 21
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'PODateTimePicker
        '
        Me.PODateTimePicker.Location = New System.Drawing.Point(166, 132)
        Me.PODateTimePicker.Name = "PODateTimePicker"
        Me.PODateTimePicker.Size = New System.Drawing.Size(185, 20)
        Me.PODateTimePicker.TabIndex = 22
        '
        'PoDeliveryDateTimePicker
        '
        Me.PoDeliveryDateTimePicker.Location = New System.Drawing.Point(166, 177)
        Me.PoDeliveryDateTimePicker.Name = "PoDeliveryDateTimePicker"
        Me.PoDeliveryDateTimePicker.Size = New System.Drawing.Size(185, 20)
        Me.PoDeliveryDateTimePicker.TabIndex = 24
        '
        'Create_PO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 356)
        Me.Controls.Add(Me.PoDeliveryDateTimePicker)
        Me.Controls.Add(Me.PODateTimePicker)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.empIdTextBox)
        Me.Controls.Add(Me.vendorIdTextBox)
        Me.Controls.Add(Me.RmQntyTextBox)
        Me.Controls.Add(Me.RmIdTextBox)
        Me.Name = "Create_PO"
        Me.Text = "Create_PO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RmIdTextBox As TextBox
    Friend WithEvents RmQntyTextBox As TextBox
    Friend WithEvents vendorIdTextBox As TextBox
    Friend WithEvents empIdTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents PODateTimePicker As DateTimePicker
    Friend WithEvents PoDeliveryDateTimePicker As DateTimePicker
End Class

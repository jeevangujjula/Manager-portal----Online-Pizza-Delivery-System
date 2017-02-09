<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveUser
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
        Me.useridTextBox = New System.Windows.Forms.TextBox()
        Me.pwdTextbox = New System.Windows.Forms.TextBox()
        Me.questionTextBox = New System.Windows.Forms.TextBox()
        Me.answerTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'useridTextBox
        '
        Me.useridTextBox.Location = New System.Drawing.Point(123, 51)
        Me.useridTextBox.Name = "useridTextBox"
        Me.useridTextBox.Size = New System.Drawing.Size(106, 20)
        Me.useridTextBox.TabIndex = 0
        '
        'pwdTextbox
        '
        Me.pwdTextbox.Location = New System.Drawing.Point(123, 90)
        Me.pwdTextbox.Name = "pwdTextbox"
        Me.pwdTextbox.Size = New System.Drawing.Size(106, 20)
        Me.pwdTextbox.TabIndex = 1
        '
        'questionTextBox
        '
        Me.questionTextBox.Location = New System.Drawing.Point(123, 130)
        Me.questionTextBox.Name = "questionTextBox"
        Me.questionTextBox.Size = New System.Drawing.Size(106, 20)
        Me.questionTextBox.TabIndex = 2
        '
        'answerTextBox
        '
        Me.answerTextBox.Location = New System.Drawing.Point(123, 172)
        Me.answerTextBox.Name = "answerTextBox"
        Me.answerTextBox.Size = New System.Drawing.Size(106, 20)
        Me.answerTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "UserId"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Security Question"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Security Answer"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(139, 213)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 9
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'SaveUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 283)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.answerTextBox)
        Me.Controls.Add(Me.questionTextBox)
        Me.Controls.Add(Me.pwdTextbox)
        Me.Controls.Add(Me.useridTextBox)
        Me.Name = "SaveUser"
        Me.Text = "SaveUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents useridTextBox As TextBox
    Friend WithEvents pwdTextbox As TextBox
    Friend WithEvents questionTextBox As TextBox
    Friend WithEvents answerTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents clearButton As Button
End Class

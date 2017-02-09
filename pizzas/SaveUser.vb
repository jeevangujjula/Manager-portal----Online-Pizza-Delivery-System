Public Class SaveUser
    Dim dbAccess As DataAccess
    Private Sub SaveUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        questionTextBox.Text = "What is your mother's maiden name?"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim isValid As Boolean
        Dim validationMessage = String.Empty
        dbAccess = New DataAccess()

        If (String.IsNullOrWhiteSpace(answerTextBox.Text)) Then
            validationMessage += "Last Name is required" & Environment.NewLine
        End If

        If (String.IsNullOrWhiteSpace(pwdTextbox.Text)) Then
            validationMessage += "Password is required" & Environment.NewLine
        ElseIf (pwdTextbox.Text.Length < 8) Then
            validationMessage += "Passwords must be at least 8 characters long"
        End If

        If (String.IsNullOrWhiteSpace(questionTextBox.Text)) Then
            validationMessage += "User ID is required" & Environment.NewLine
        ElseIf (dbAccess.UserExists(questionTextBox.Text)) Then
            validationMessage += "User ID " & questionTextBox.Text & " already exists.  Please select a different User ID." & Environment.NewLine
        End If

        Dim isValid As Boolean
        isValid = String.IsNullOrWhiteSpace(validationMessage) 'if the validation message is empty, the form is valid

        If (Not isValid) Then
            MessageBox.Show(Me, validationMessage, "Form Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (isValid) Then
            Dim user As New User()

            user.FirstName = txtFirstName.Text
            user.LastName = txtLastName.Text
            user.UserId = txtUserId.Text
            user.SetPassword(txtPassword.Text)

            _pineValley.SaveUser(user)

            MessageBox.Show(Me, "User saved successfully", "User Created", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        End If
    End Sub
End Class
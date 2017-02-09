Imports System.Text.RegularExpressions
Public Class AddEmployeeForm
    Dim dbAccess As DataAccess
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        dbAccess = New DataAccess()
        Dim regStatus As Integer = 0
        If birthDateTimePicker.Value >= Date.Today Then
            MessageBox.Show("Please select date lesser than today's date", "Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf hireDateTimePicker.Value >= Date.Today Then
            MessageBox.Show("Please select date lesser than today's date", "Hire Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'Else
        If Me.fnameTextBox.Text = "" Then
                Me.fnameTextBox.Focus()
                MsgBox("You must enter a First Name.")
                Exit Sub
            ElseIf Not Regex.Match(fnameTextBox.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
                MessageBox.Show("Please enter alphabetic characters only!", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fnameTextBox.Clear()
            fnameTextBox.Focus()
            Exit Sub
        End If
        If Me.lnameTextBox.Text = "" Then
            Me.lnameTextBox.Focus()
            MsgBox("You must enter a Last Name.")
            Exit Sub
        ElseIf Not Regex.Match(lnameTextBox.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter alphabetic characters only!", "Last Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lnameTextBox.Clear()
            lnameTextBox.Focus()
            Exit Sub
        End If
        If Me.phoneTextBox.Text = "" Then
            Me.phoneTextBox.Focus()
            MsgBox("You must enter a Phone.")
            Exit Sub
        ElseIf Not Regex.Match(phoneTextBox.Text, "\d{10}", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter the numbers only!", "Phone", MessageBoxButtons.OK, MessageBoxIcon.Information)
            phoneTextBox.Clear()
            phoneTextBox.Focus()
            Exit Sub
        End If
        If Me.emailTextBox.Text = "" Then
            Me.emailTextBox.Focus()
            MsgBox("You must enter a Email Id.")
            Exit Sub
            ' ^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$
        ElseIf Not Regex.Match(emailTextBox.Text, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter a valid email ID", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            emailTextBox.Clear()
            emailTextBox.Focus()
            Exit Sub
        End If

        Me.reportsToComboBox.TabIndex.Equals(0)
        reportsToComboBox.DroppedDown = True

        Me.deptComboBox.Focus()
        deptComboBox.DroppedDown = True

        Me.AddrtypeComboBox.Focus()
        AddrtypeComboBox.DroppedDown = True

        Me.AddrLineTextBox.Focus()
        If Me.AddrLineTextBox.Text = "" Then
            MsgBox("You must enter an Address.")
            Exit Sub
        ElseIf Not Regex.Match(AddrLineTextBox.Text, "^[a-zA-Z0-9]+$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter alphanumeric characters only!", "Address Line", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddrLineTextBox.Clear()
            AddrLineTextBox.Focus()
            Exit Sub
        End If
        If Me.CityTextBox.Text = "" Then
            Me.CityTextBox.Focus()
            MsgBox("You must enter a City.")
            Exit Sub
        ElseIf Not Regex.Match(lnameTextBox.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter alphabetic characters only!", "City", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CityTextBox.Clear()
            CityTextBox.Focus()
            Exit Sub
        End If
        If Me.zipTextBox.Text = "" Then
            Me.zipTextBox.Focus()
            MsgBox("You must enter a Zip.")
            Exit Sub
        ElseIf Not Regex.Match(zipTextBox.Text, "\d{5}", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter numbers only!", "Zip", MessageBoxButtons.OK, MessageBoxIcon.Information)
            zipTextBox.Clear()
            zipTextBox.Focus()
            Exit Sub
        End If
        ' End If

        regStatus = dbAccess.InsertEmployeeDetails(fnameTextBox.Text, lnameTextBox.Text, phoneTextBox.Text, emailTextBox.Text, reportsToComboBox.SelectedItem, deptComboBox.SelectedItem, birthDateTimePicker.Value, hireDateTimePicker.Value, AddrtypeComboBox.SelectedItem, AddrLineTextBox.Text, CityTextBox.Text, zipTextBox.Text)

        Me.Close()
    End Sub

    Private Sub AddEmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.fnameTextBox.Focus()
        AddrtypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        reportsToComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        deptComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        AddrtypeComboBox.Items.Add("Home")
        AddrtypeComboBox.Items.Add("Office")
        AddrtypeComboBox.Items.Add("Hostel")
        reportsToComboBox.Items.Add("401")
        reportsToComboBox.Items.Add("402")
        reportsToComboBox.Items.Add("403")
        reportsToComboBox.Items.Add("404")
        reportsToComboBox.Items.Add("405")
        deptComboBox.Items.Add("1")
        deptComboBox.Items.Add("2")
        deptComboBox.Items.Add("3")
        deptComboBox.Items.Add("4")

    End Sub
    Public Function validateName(ByVal name As String) As Boolean

        If Not Regex.Match(name, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")
            fnameTextBox.Focus()
            fnameTextBox.Clear()
        End If
        Return True
    End Function

    Private Sub ClearAllButton_Click(sender As Object, e As EventArgs) Handles ClearAllButton.Click
        fnameTextBox.Clear()
        lnameTextBox.Clear()
        phoneTextBox.Clear()
        emailTextBox.Clear()
        reportsToComboBox.SelectedIndex = -1
        deptComboBox.SelectedIndex = -1
        birthDateTimePicker.Text = ""
        hireDateTimePicker.Text = ""
        AddrtypeComboBox.Text = ""
        AddrLineTextBox.Clear()
        CityTextBox.Clear()
        zipTextBox.Clear()
    End Sub
End Class
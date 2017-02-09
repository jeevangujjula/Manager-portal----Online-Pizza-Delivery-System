Public Class UpdateEmpForm
    Dim dbAccess As DataAccess
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        dbAccess = New DataAccess()
        Dim detail As Integer = 0
        detail = dbAccess.UpdateEmpDetails(empIdTextBox.Text, fnameTextBox.Text, lnameTextBox.Text, phoneTextBox.Text, emailTextBox.Text, reportstoTextBox.Text, depttextbox.Text)
        Me.Close()
    End Sub

    Private Sub UpdateEmpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbAccess = New DataAccess()
        Dim dtTable As DataTable
        dtTable = dbAccess.GetEmpViewDetails(Trim(empIdTextBox.Text))
        For Each dr As DataRow In dtTable.Rows
            If ((empIdTextBox.Text.ToString() = dr.Item("employee_id"))) Then
                fnameTextBox.Text = dr.Item("Firstname").ToString()
                lnameTextBox.Text = dr.Item("Lastname").ToString()
                phoneTextBox.Text = dr.Item("Phone").ToString()
                emailTextBox.Text = dr.Item("Email").ToString()
                reportstoTextBox.Text = dr.Item("ReportsTo").ToString()
                depttextbox.Text = dr.Item("department_id").ToString()
                ContactIDTextBox.Text = dr.Item("contact_id").ToString()
            End If
        Next

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        fnameTextBox.Clear()
        lnameTextBox.Clear()
        phoneTextBox.Clear()
        emailTextBox.Clear()
        reportstoTextBox.Clear()
        deptTextbox.Clear()
        ContactIDTextBox.Clear()
    End Sub
End Class
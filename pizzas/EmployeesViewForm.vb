Public Class EmployeesViewForm
    Dim dbAccess As DataAccess
    Private Sub EmployeesViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub empIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles empIdTextBox.TextChanged

    End Sub

    Private Sub viewEmpButton_Click(sender As Object, e As EventArgs) Handles viewEmpButton.Click

        Dim i As Integer = 0
        Dim dtTable As DataTable = Nothing
        dbAccess = New DataAccess()
        DataGridView1.DataBindings.Clear()
        DataGridView1.DataSource = Nothing
        If Not Me.empIdTextBox.Text = "" Then
            dtTable = dbAccess.GetEmpViewDetails(Trim(Convert.ToInt32(empIdTextBox.Text)))
            For Each dr As DataRow In dtTable.Rows
                dtTable = dbAccess.GetEmpViewDetails(Convert.ToInt32(empIdTextBox.Text))
                i = 1
                DataGridView1.DataSource = dtTable
            Next
            If Not (i = 1) Then
                MsgBox("Employee doesn't exist with Employee ID : " & empIdTextBox.Text & vbNewLine & "Please enter a valid Employee ID.")
                empIdTextBox.Clear()
                empIdTextBox.Focus()
            End If

        Else
                Me.empIdTextBox.Focus()
            MsgBox("You must enter an Employee ID.")
            Exit Sub
        End If
    End Sub

    Private Sub viewAllEmpButton_Click(sender As Object, e As EventArgs) Handles viewAllEmpButton.Click
        Dim dtTable As DataTable = Nothing
        dbAccess = New DataAccess()
        DataGridView1.DataBindings.Clear()
        DataGridView1.DataSource = Nothing
        dtTable = dbAccess.GetAllEmpDetails()
        DataGridView1.DataSource = dtTable
    End Sub


    Private Sub EmpUpdateButton_Click(sender As Object, e As EventArgs) Handles EmpUpdateButton.Click
        Dim objref As New UpdateEmpForm
        Dim i As Integer = 0
        Dim dtTable As DataTable = Nothing
        dbAccess = New DataAccess()
        DataGridView1.DataBindings.Clear()
        DataGridView1.DataSource = Nothing
        If Not Me.empIdTextBox.Text = "" Then
            dtTable = dbAccess.GetEmpViewDetails(Trim(Convert.ToInt32(empIdTextBox.Text)))
            For Each dr As DataRow In dtTable.Rows
                i = 1
                objref.empIdTextBox.Text = empIdTextBox.Text
                objref.Show()
            Next
            If Not (i = 1) Then
                MsgBox("Employee doesn't exist with Employee ID : " & empIdTextBox.Text & vbNewLine & "Please enter a valid Employee ID.")
                empIdTextBox.Clear()
                empIdTextBox.Focus()
            End If
        Else
            Me.empIdTextBox.Focus()
            MsgBox("You must enter an Employee ID.")
            Exit Sub
        End If

    End Sub

    Private Sub DelEmpButton_Click(sender As Object, e As EventArgs) Handles DelEmpButton.Click

        Dim i As Integer = 0
        Dim dtTable As DataTable = Nothing
        dbAccess = New DataAccess()
        DataGridView1.DataBindings.Clear()
        DataGridView1.DataSource = Nothing
        If Not Me.empIdTextBox.Text = "" Then
            dtTable = dbAccess.GetEmpViewDetails(Trim(Convert.ToInt32(empIdTextBox.Text)))
            For Each dr As DataRow In dtTable.Rows
                If MsgBox("Do you want to delete Employee : " & empIdTextBox.Text, MsgBoxStyle.YesNo, "Delete Employee") = MsgBoxResult.Yes Then
                    i = 1
                    dtTable = dbAccess.DeleteEmp(Convert.ToInt32(empIdTextBox.Text))
                Else
                    Exit Sub
                End If
                MessageBox.Show("Successfully Deleted Employee : " & empIdTextBox.Text, "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Next
            If Not (i = 1) Then
                MsgBox("Employee doesn't exist with Employee ID : " & empIdTextBox.Text & vbNewLine & "Please enter a valid Employee ID.")
                empIdTextBox.Clear()
                empIdTextBox.Focus()
            End If

        Else
            Me.empIdTextBox.Focus()
            MsgBox("You must enter an Employee ID.")
            Exit Sub
        End If
    End Sub

End Class
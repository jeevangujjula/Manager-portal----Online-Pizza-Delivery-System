Public Class Create_PO
    Dim dbAccess As DataAccess
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        dbAccess = New DataAccess()
        Dim regStatus As Integer = 0
        If RmIdTextBox.Text = "" Then
            RmIdTextBox.Focus()
            MsgBox("You must enter a Rawm Material ID.")
            Exit Sub
        End If
        If RmQntyTextBox.Text = "" Then
            RmQntyTextBox.Focus()
            MsgBox("You must enter the Raw Material Quantity.")
            Exit Sub
        End If
        If vendorIdTextBox.Text = "" Then
            vendorIdTextBox.Focus()
            MsgBox("You must enter a Vendor ID.")
            Exit Sub
        End If
        empIdTextBox.Focus()
        If empIdTextBox.Text = "" Then
            MsgBox("You must enter an Employee ID.")
            Exit Sub
        End If
        regStatus = dbAccess.CreatPO(RmIdTextBox.Text, RmQntyTextBox.Text, vendorIdTextBox.Text, PODateTimePicker.Value, PoDeliveryDateTimePicker.Value, empIdTextBox.Text)

        Me.Close()
    End Sub
    'do nothing
    Private Sub Create_PO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'close the form
    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
End Class
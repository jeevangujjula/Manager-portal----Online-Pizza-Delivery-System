Public Class pizzasRawmaterialLessStock
    Dim dbAccess
    Private Sub pizzasRawmaterialLessStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtRMstock As DataTable = Nothing
        dbAccess = New DataAccess()
        DataGridView1.DataBindings.Clear()
        DataGridView1.DataSource = Nothing
        dtRMstock = dbAccess.GetPizzaswithRMlessInStock()
        DataGridView1.DataSource = dtRMstock
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintDocument1.Print()
    End Sub
End Class
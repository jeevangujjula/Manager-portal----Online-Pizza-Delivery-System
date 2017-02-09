Public Class Sales_Report_of_last_three_months
    Dim dbAccess As DataAccess
    Private Sub Sales_Report_of_last_three_months_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtSalesin3mnths As DataTable = Nothing
        dbAccess = New DataAccess()
        DataGridView1.DataBindings.Clear()
        DataGridView1.DataSource = Nothing
        dtSalesin3mnths = dbAccess.GetSalesInlastThreeMonths()
        DataGridView1.DataSource = dtSalesin3mnths

    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintDocument1.Print()
    End Sub
End Class
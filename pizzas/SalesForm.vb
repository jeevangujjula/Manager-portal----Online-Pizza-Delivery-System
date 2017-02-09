Public Class SalesForm
    Dim dbAccess As DataAccess

    Private Sub showSalesButton_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtSales As DataTable = Nothing
        dbAccess = New DataAccess()
        DataGridView1.DataBindings.Clear()
        DataGridView1.DataSource = Nothing
        dtSales = dbAccess.GetSales()
        DataGridView1.DataSource = dtSales

    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintDocument1.Print()
    End Sub
End Class
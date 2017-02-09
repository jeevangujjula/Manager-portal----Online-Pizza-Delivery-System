Public Class ViewAllPO
    Dim dbAccess As DataAccess
    Private Sub ViewAllPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'PizzaDataSet7.purchaseorder' table. You can move, or remove it, as needed.
        'Me.PurchaseorderTableAdapter.Fill(Me.PizzaDataSet7.purchaseorder)
        Dim dtAllPO As DataTable = Nothing
        dbAccess = New DataAccess()
        DataGridView1.DataBindings.Clear()
        DataGridView1.DataSource = Nothing
        dtAllPO = dbAccess.GetAllPO()
        DataGridView1.DataSource = dtAllPO
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintDocument1.Print()
    End Sub
End Class
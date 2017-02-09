Public Class VIewPo
    Dim dbAccess As DataAccess
    Private Sub VIewPo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'PizzaDataSet7.amountonpobvndors' table. You can move, or remove it, as needed.
        'Me.AmountonpobvndorsTableAdapter.Fill(Me.PizzaDataSet7.amountonpobvndors)
        Dim dtPO As DataTable = Nothing
        dbAccess = New DataAccess()
        DataGridView1.DataBindings.Clear()
        DataGridView1.DataSource = Nothing
        dtPO = dbAccess.GetPoReort()
        DataGridView1.DataSource = dtPO
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintDocument1.Print()
    End Sub
End Class
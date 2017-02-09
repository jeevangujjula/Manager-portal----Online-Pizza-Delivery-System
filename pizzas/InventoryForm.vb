Public Class InventoryForm
    Dim dbAccess As DataAccess
    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtInv As DataTable = Nothing
        dbAccess = New DataAccess()
        InvDataGridView.DataBindings.Clear()
        InvDataGridView.DataSource = Nothing
        dtInv = dbAccess.GetInventory()
        InvDataGridView.DataSource = dtInv
    End Sub
    'printable access to the inventory report
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        InvPrintDocument.Print()
    End Sub

End Class
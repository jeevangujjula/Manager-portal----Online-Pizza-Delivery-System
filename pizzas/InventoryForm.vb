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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        InvPrintDocument.Print()
    End Sub

    'Private Sub InvPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles InvPrintDocument.PrintPage
    '    Dim bm As New Bitmap(Me.InvDataGridView.Width, Me.InvDataGridView.Height)
    '    InvDataGridView.DrawToBitmap(bm, New Rectangle(0, 0, Me.InvDataGridView.Width, Me.InvDataGridView.Height))
    '    e.Graphics.DrawImage(bm, 0, 0)
    'End Sub

End Class
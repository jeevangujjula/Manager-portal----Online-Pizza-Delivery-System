Public Class ManagerHomeForm
    Private Sub ManagerHomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ViewEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewEmployeeToolStripMenuItem.Click
        EmployeesViewForm.Show()
        EmployeesViewForm.MdiParent() = Me
    End Sub


    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        AddEmployeeForm.Show()
        AddEmployeeForm.MdiParent() = Me
    End Sub

    Private Sub InventoryStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryStockToolStripMenuItem.Click
        InventoryForm.Show()
        InventoryForm.MdiParent() = Me
    End Sub

    Private Sub PizzasHavingRawmateriaslLessThanMinimumStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PizzasHavingRawmateriaslLessThanMinimumStockToolStripMenuItem.Click
        pizzasRawmaterialLessStock.Show()
        pizzasRawmaterialLessStock.MdiParent() = Me
    End Sub

    Private Sub SalesReportByCusotmersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportByCusotmersToolStripMenuItem.Click
        SalesForm.Show()
        SalesForm.MdiParent() = Me
    End Sub

    Private Sub SalesReportForToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportForToolStripMenuItem.Click
        Sales_Report_of_last_three_months.Show()
        Sales_Report_of_last_three_months.MdiParent() = Me
    End Sub

    Private Sub DeleteEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeToolStripMenuItem.Click
        EmployeesViewForm.Show()
        EmployeesViewForm.MdiParent() = Me
    End Sub

    Private Sub CreatePurchaseOrderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreatePurchaseOrderToolStripMenuItem1.Click
        Create_PO.Show()
        Create_PO.MdiParent() = Me
    End Sub

    Private Sub ViewPOByVendorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPOByVendorToolStripMenuItem.Click
        VIewPo.Show()
        VIewPo.MdiParent() = Me
    End Sub

    Private Sub ViewAllPOsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllPOsToolStripMenuItem.Click
        ViewAllPO.Show()
        ViewAllPO.MdiParent() = Me
    End Sub

    Private Sub AboutEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutEmployeeToolStripMenuItem.Click
        AboutEmpForm.Show()
        AboutEmpForm.MdiParent() = Me
    End Sub
End Class

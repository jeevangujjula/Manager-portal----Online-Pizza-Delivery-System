<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerHomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatePurchaseOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatePurchaseOrderToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPOByVendorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllPOsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PizzasHavingRawmateriaslLessThanMinimumStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportForToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportByCusotmersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewEmployeesToolStripMenuItem, Me.CreatePurchaseOrderToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.AboutEmployeeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1276, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewEmployeesToolStripMenuItem
        '
        Me.ViewEmployeesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeeToolStripMenuItem, Me.ViewEmployeeToolStripMenuItem, Me.DeleteEmployeeToolStripMenuItem})
        Me.ViewEmployeesToolStripMenuItem.Name = "ViewEmployeesToolStripMenuItem"
        Me.ViewEmployeesToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ViewEmployeesToolStripMenuItem.Text = "Employees"
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AddEmployeeToolStripMenuItem.Text = "Add Employee"
        '
        'ViewEmployeeToolStripMenuItem
        '
        Me.ViewEmployeeToolStripMenuItem.Name = "ViewEmployeeToolStripMenuItem"
        Me.ViewEmployeeToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ViewEmployeeToolStripMenuItem.Text = "View/ Update Employee"
        '
        'DeleteEmployeeToolStripMenuItem
        '
        Me.DeleteEmployeeToolStripMenuItem.Name = "DeleteEmployeeToolStripMenuItem"
        Me.DeleteEmployeeToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.DeleteEmployeeToolStripMenuItem.Text = "Delete Employee"
        '
        'CreatePurchaseOrderToolStripMenuItem
        '
        Me.CreatePurchaseOrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreatePurchaseOrderToolStripMenuItem1, Me.ViewPOByVendorToolStripMenuItem, Me.ViewAllPOsToolStripMenuItem})
        Me.CreatePurchaseOrderToolStripMenuItem.Name = "CreatePurchaseOrderToolStripMenuItem"
        Me.CreatePurchaseOrderToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.CreatePurchaseOrderToolStripMenuItem.Text = "Purchase order"
        '
        'CreatePurchaseOrderToolStripMenuItem1
        '
        Me.CreatePurchaseOrderToolStripMenuItem1.Name = "CreatePurchaseOrderToolStripMenuItem1"
        Me.CreatePurchaseOrderToolStripMenuItem1.Size = New System.Drawing.Size(260, 22)
        Me.CreatePurchaseOrderToolStripMenuItem1.Text = "Create PO"
        '
        'ViewPOByVendorToolStripMenuItem
        '
        Me.ViewPOByVendorToolStripMenuItem.Name = "ViewPOByVendorToolStripMenuItem"
        Me.ViewPOByVendorToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.ViewPOByVendorToolStripMenuItem.Text = "View total amount of PO by vendor"
        '
        'ViewAllPOsToolStripMenuItem
        '
        Me.ViewAllPOsToolStripMenuItem.Name = "ViewAllPOsToolStripMenuItem"
        Me.ViewAllPOsToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.ViewAllPOsToolStripMenuItem.Text = "View All POs"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryReportToolStripMenuItem, Me.SalesReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'InventoryReportToolStripMenuItem
        '
        Me.InventoryReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryStockToolStripMenuItem, Me.PizzasHavingRawmateriaslLessThanMinimumStockToolStripMenuItem})
        Me.InventoryReportToolStripMenuItem.Name = "InventoryReportToolStripMenuItem"
        Me.InventoryReportToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.InventoryReportToolStripMenuItem.Text = "Inventory Report"
        '
        'InventoryStockToolStripMenuItem
        '
        Me.InventoryStockToolStripMenuItem.Name = "InventoryStockToolStripMenuItem"
        Me.InventoryStockToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.InventoryStockToolStripMenuItem.Text = "Inventory (Stock<stock ordered)"
        '
        'PizzasHavingRawmateriaslLessThanMinimumStockToolStripMenuItem
        '
        Me.PizzasHavingRawmateriaslLessThanMinimumStockToolStripMenuItem.Name = "PizzasHavingRawmateriaslLessThanMinimumStockToolStripMenuItem"
        Me.PizzasHavingRawmateriaslLessThanMinimumStockToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.PizzasHavingRawmateriaslLessThanMinimumStockToolStripMenuItem.Text = "Pizzas(with rawmaterial less in stock)"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesReportForToolStripMenuItem, Me.SalesReportByCusotmersToolStripMenuItem})
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SalesReportToolStripMenuItem.Text = "Sales Report"
        '
        'SalesReportForToolStripMenuItem
        '
        Me.SalesReportForToolStripMenuItem.Name = "SalesReportForToolStripMenuItem"
        Me.SalesReportForToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.SalesReportForToolStripMenuItem.Text = "Sales Report for last 3 months"
        '
        'SalesReportByCusotmersToolStripMenuItem
        '
        Me.SalesReportByCusotmersToolStripMenuItem.Name = "SalesReportByCusotmersToolStripMenuItem"
        Me.SalesReportByCusotmersToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.SalesReportByCusotmersToolStripMenuItem.Text = "Sales Report on Cusotmers"
        '
        'AboutEmployeeToolStripMenuItem
        '
        Me.AboutEmployeeToolStripMenuItem.Name = "AboutEmployeeToolStripMenuItem"
        Me.AboutEmployeeToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.AboutEmployeeToolStripMenuItem.Text = "About Employee"
        '
        'ManagerHomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BackgroundImage = Global.pizzas.My.Resources.Resources.Home_Manager_Logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1276, 639)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ManagerHomeForm"
        Me.Text = "Manager Home Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ViewEmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportForToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportByCusotmersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PizzasHavingRawmateriaslLessThanMinimumStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreatePurchaseOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreatePurchaseOrderToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewPOByVendorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAllPOsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutEmployeeToolStripMenuItem As ToolStripMenuItem
End Class

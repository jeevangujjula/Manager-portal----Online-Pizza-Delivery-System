Public Class AboutEmpForm
    Dim dbAccess As DataAccess
    Private Sub AboutEmpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtAboutEmp As DataTable = Nothing
        dbAccess = New DataAccess()
        DataGridView1.DataBindings.Clear()
        DataGridView1.DataSource = Nothing
        dtAboutEmp = dbAccess.GetAboutEmp()
        DataGridView1.DataSource = dtAboutEmp

    End Sub
End Class
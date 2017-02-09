
Imports MySql.Data.MySqlClient
Public Class DBconnect

    'create databse connection string
    Public Shared strConnect As String
    Public Shared UserId As String
    Public Function GetConnection() As MySqlConnection
        'Connection to the server
        strConnect = "server=141.209.241.44;user id=gujju1j;password=*******;database=pizza"
        Dim oconn As MySqlConnection = New MySqlConnection(strConnect)
        Return oconn
    End Function
    'select statements exceutable function
    Public Function ExecuteSelectTable(ByVal strSQL As String) As DataTable
        Dim oconn As MySqlConnection = GetConnection()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(strSQL, oconn)
        da.Fill(dt)
        oconn.Close()
        oconn.Dispose()
        da.Dispose()
        Return dt
    End Function
    'Insert, Update, Delet executable function
    Public Function ExecuteInsUpdDel(ByVal strSQL As String,
                                 Optional ByVal ReturnID As Boolean = False) As Integer
        Dim oconn As MySqlConnection = GetConnection()
        Dim command As New MySqlCommand(strSQL, oconn)
        command.CommandType = CommandType.Text
        Dim dt As New DataTable
        oconn.Open()
        Dim retval As Integer
        Try
            If ReturnID Then
                command.ExecuteNonQuery()
                command.CommandText = "SELECT @@IDENTITY"
                retval = command.ExecuteScalar()
            Else
                retval = command.ExecuteNonQuery()
            End If

        Catch ex As Exception
            MsgBox("SQL error: " & ex.Message)
            retval = -1
        Finally
            oconn.Close()
            oconn.Dispose()
            command.Dispose()
        End Try
        Return retval  REM either number of rows affected; or ID of new row
    End Function
End Class

Imports MySql.Data.MySqlClient

Public Class panelForm3
    'Dim MysqlConn As MySqlConnection
    'Dim COMMAND As MySqlCommand

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        'MysqlConn = New MySqlConnection()
        'MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=info"

        'Try
        '    MysqlConn.Open()
        '    Dim Query As String
        '    Query = "UPDATE info.`accounts` " _
        '        & "SET username = '" & Tbx_Username.Text & "', " _
        '        & "password = '" & Tbx_Password.Text & "' " _
        '        & "WHERE id = 1"
        '    COMMAND = New MySqlCommand(Query, MysqlConn)
        '    COMMAND.ExecuteNonQuery()
        '    MessageBox.Show("Credentials are updated successfully")
        '    MysqlConn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    Tbx_Username.Text = ""
        '    Tbx_Password.Text = ""
        '    MysqlConn.Dispose()
        'End Try
    End Sub

    Private Sub Btn_Credentials_Click(sender As Object, e As EventArgs) Handles Btn_Credentials.Click
        'MysqlConn = New MySqlConnection()
        'MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=info"

        'Dim READER As MySqlDataReader

        'Try
        '    MysqlConn.Open()
        '    Dim Query As String
        '    Query = "SELECT * FROM accounts WHERE id = 1"
        '    COMMAND = New MySqlCommand(Query, MysqlConn)
        '    READER = COMMAND.ExecuteReader

        '    While READER.Read
        '        Tbx_Username.Text = READER.GetString("username")
        '        Tbx_Password.Text = READER.GetString("password")
        '    End While

        '    MysqlConn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    MysqlConn.Dispose()
        'End Try
    End Sub
End Class
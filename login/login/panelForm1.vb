Imports MySql.Data.MySqlClient

Public Class panelForm1
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub lblClock1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub panelForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDirectory()
    End Sub

    Private Sub ShowDirectory()
        'MysqlConn = New MySqlConnection()
        'MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=info"

        'Dim SDA As New MySqlDataAdapter
        'Dim dbDataSet As New DataTable
        'Dim bSource As New BindingSource

        'Try
        '    MysqlConn.Open()
        '    Dim Query As String
        '    Query = "select concat(year,proj_id) as proj_code," _
        '            & "proj_name, date_started, date_ended, client_name," _
        '            & "original_budget from directories"
        '    COMMAND = New MySqlCommand(Query, MysqlConn)
        '    SDA.SelectCommand = COMMAND
        '    SDA.Fill(dbDataSet)
        '    bSource.DataSource = dbDataSet
        '    GunaDataGridView1.DataSource = bSource
        '    SDA.Update(dbDataSet)
        '    MysqlConn.Close()

        '    GunaDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    MysqlConn.Dispose()
        'End Try
    End Sub

    Private Sub CreateBtn_Click(sender As Object, e As EventArgs)
        'Try
        '    InsertToDirectory()
        '    CreateTable()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    ShowDirectory()
        'End Try

    End Sub


    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=projects"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "drop table projects." & Tbx_ProjCode_Read.Text

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Table " & Tbx_ProjCode_Read.Text & " Deleted")
            DeleteRow()
            ShowDirectory()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
            AllClear()
        End Try
    End Sub

    Private Sub InsertToDirectory()
        'MysqlConn = New MySqlConnection()
        'MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=info"

        'Try
        '    MysqlConn.Open()
        '    Dim Query As String

        '    Query = "insert into directories(date_started,proj_name,client_name,original_budget) values(now()" & "," _
        '        & "'" & Tbx_ProjName_Write.Text & "'," & "'" & Tbx_ClientName.Text & "'," & "'" & Tbx_Budget.Text & "')"

        '    Command = New MySqlCommand(Query, MysqlConn)
        '    Command.ExecuteNonQuery()
        '    MessageBox.Show("This " & Tbx_ProjName_Write.Text & " Added to directory")
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    MysqlConn.Dispose()
        'End Try
    End Sub

    Private Sub CreateTable()
        'MysqlConn = New MySqlConnection()
        'MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=projects"

        'Dim READER As MySqlDataReader

        'Try
        '    MysqlConn.Open()
        '    Dim selectProjCodeQuery As String = "SELECT concat(year, proj_id) AS proj_code FROM info.directories ORDER BY proj_id DESC LIMIT 1"
        '    Dim Query As String
        '    Dim selectCommand As New MySqlCommand(selectProjCodeQuery, MysqlConn)
        '    READER = selectCommand.ExecuteReader()
        '    If READER.Read() Then
        '        Dim projCode As String = READER.GetString("proj_code")
        '        READER.Close()
        '        Query = "CREATE TABLE projects." & projCode & " " _
        '        & "(`record_time` DATETIME NOT  NULL, `expenditure` VARCHAR(20) NOT NULL, " _
        '        & "`category` ENUM('material', 'labor') NOT NULL, " _
        '        & "`amount` DOUBLE NOT NULL DEFAULT 0.00, " _
        '        & "`cash_flow` Enum('inward', 'outward') NOT NULL, " _
        '        & "PRIMARY KEY (`record_time`))"

        '        Command = New MySqlCommand(Query, MysqlConn)
        '        Command.ExecuteNonQuery()
        '        MessageBox.Show("Table " & Tbx_ProjCode_Read.Text & " Is created successfully...")
        '    Else
        '        MessageBox.Show("No data found in the info.directories")
        '    End If
        '    ShowDirectory()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        '    MysqlConn.Dispose()
        '    AllClear()
        'End Try
    End Sub
    Private Sub DeleteRow()
        'MysqlConn = New MySqlConnection()
        'MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=info"

        'Try
        '    MysqlConn.Open()
        '    Dim Query As String
        '    Dim READER As MySqlDataReader
        '    Query = "delete from directories where concat(year, proj_id) = '" & Tbx_ProjCode_Read.Text & "'"
        '    Command = New MySqlCommand(Query, MysqlConn)
        '    READER = Command.ExecuteReader

        '    MysqlConn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    AllClear()
        '    ShowDirectory()
        '    MysqlConn.Dispose()
        'End Try
    End Sub


    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        'MysqlConn = New MySqlConnection()
        'MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=info"

        'Dim READER As MySqlDataReader

        'Try
        '    MysqlConn.Open()
        '    Dim Query As String

        '    Query = "update directories " _
        '        & "set proj_name = '" & Tbx_ProjName_Write.Text & "'," _
        '        & "client_name = '" & Tbx_ClientName.Text & "'," _
        '        & "original_budget = " & Tbx_Budget.Text & " " _
        '        & "where concat(year,proj_id) = '" & Tbx_ProjCode_Read.Text & "'"

        '    COMMAND = New MySqlCommand(Query, MysqlConn)
        '    READER = COMMAND.ExecuteReader
        '    MessageBox.Show("This project " & Tbx_ProjName_Write.Text & "updated successfully")
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    AllClear()
        '    MysqlConn.Dispose()
        'End Try
    End Sub



    Private Sub Btn_EndProject_Click(sender As Object, e As EventArgs)
        'MysqlConn = New MySqlConnection()
        'MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=info"

        'Try
        '    MysqlConn.Open()
        '    Dim Query As String
        '    Dim READER As MySqlDataReader
        '    Query = "update directories  " _
        '            & "set date_ended = '" & Tbx_DateEnded.Text & "' " _
        '            & "where concat(year, proj_id) = " & Tbx_ProjCode_Read.Text
        '    Command = New MySqlCommand(Query, MysqlConn)
        '    READER = Command.ExecuteReader

        '    MysqlConn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    ShowDirectory()
        '    AllClear()
        '    MysqlConn.Dispose()
        'End Try
    End Sub

    Public Sub AllClear()
        'Tbx_Budget.Text = ""
        'Tbx_ClientName.Text = ""
        'Tbx_DateEnded.Text = ""
        'Tbx_ProjCode_Read.Text = ""
        'Tbx_ProjName_Write.Text = ""
        'ShowDirectory()
    End Sub

    Private Sub Btn_UndoEnd_Click(sender As Object, e As EventArgs)
        'MysqlConn = New MySqlConnection()
        'MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=info"

        'Try
        '    MysqlConn.Open()
        '    Dim Query As String
        '    Dim READER As MySqlDataReader
        '    Query = "update directories  " _
        '            & "set date_ended = NULL " _
        '            & "where concat(year, proj_id) = " & Tbx_ProjCode_Read.Text
        '    Command = New MySqlCommand(Query, MysqlConn)
        '    READER = Command.ExecuteReader

        '    MysqlConn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    AllClear()
        '    MysqlConn.Dispose()
        'End Try
    End Sub
    Private Sub Btn_Load_Click(sender As Object, e As EventArgs) Handles Btn_Load.Click
        Try
            Me.Hide()
            Form3.PanelBtn2.PerformClick()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Create_Btn_Click(sender As Object, e As EventArgs) Handles Create_Btn.Click
        'Try
        '    InsertToDirectory()
        '    CreateTable()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally

        'End Try
    End Sub


    Private Sub Btn_EndProject_Click_1(sender As Object, e As EventArgs) Handles Btn_EndProject.Click
        'MysqlConn = New MySqlConnection()
        'MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=info"

        'Try
        '    MysqlConn.Open()
        '    Dim Query As String
        '    Dim READER As MySqlDataReader
        '    Query = "update directories  " _
        '            & "set date_ended = '" & Tbx_DateEnded.Text & "' " _
        '            & "where concat(year, proj_id) = " & Tbx_ProjCode_Read.Text
        '    COMMAND = New MySqlCommand(Query, MysqlConn)
        '    READER = COMMAND.ExecuteReader

        '    MysqlConn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    ShowDirectory()
        '    AllClear()
        '    MysqlConn.Dispose()
        'End Try
    End Sub

    Private Sub Btn_UndoEnd_Click_1(sender As Object, e As EventArgs) Handles Btn_UndoEnd.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=info"

        Try
            MysqlConn.Open()
            Dim Query As String
            Dim READER As MySqlDataReader
            Query = "update directories  " _
                    & "set date_ended = NULL " _
                    & "where concat(year, proj_id) = " & Tbx_ProjCode_Read.Text
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            AllClear()
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick
        '    If e.RowIndex >= 0 Then
        '        Dim row As DataGridViewRow
        '        row = Me.GunaDataGridView1.Rows(e.RowIndex)

        '        Tbx_ProjCode_Read.Text = row.Cells("proj_code").Value.ToString
        '        Tbx_Budget.Text = row.Cells("original_budget").Value.ToString
        '        Tbx_ProjName_Write.Text = row.Cells("proj_name").Value.ToString
        '        Tbx_ClientName.Text = row.Cells("client_name").Value.ToString
        '    End If
    End Sub
End Class
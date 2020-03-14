Imports MySql.Data.MySqlClient
Public Class ManageSchoolUsers
    Dim MySqlConn As MySqlConnection
    Dim command As New MySqlCommand
    Private Sub LogOut_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim x As New Login
        Login.Show()
    End Sub

    Private Sub SuspendLabel_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim x As New AdminHome
        AdminHome.Show()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs)
        Me.Hide()
        EditBtn.Show()
    End Sub

    Private Sub AddUser_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Me.Hide()
        EditSchoolUser.Show()
        Me.Dispose()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Hide()
        ManageUsers.Show()
        Me.Dispose()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim x As New AdminHome
        AdminHome.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoadBtn.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MySqlConn.Open()
            Dim query As String = "select * from csas.send"
            command = New MySqlCommand(query, MySqlConn)
            sda.SelectCommand = command
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            sda.Update(dbdataset)
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MySqlConn.Open()
            Dim query As String = "select * from csas.send where cp_num = @search or id = @search
                or school = @search or lvl = @search"
            command = New MySqlCommand(query, MySqlConn)
            command.Parameters.Add("@search", MySqlDbType.VarChar).Value = SearchBox.Text
            sda.SelectCommand = command
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            sda.Update(dbdataset)
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub SearchBox_MouseClick(sender As Object, e As MouseEventArgs) Handles SearchBox.MouseClick
        SearchBox.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"

        Dim reader As MySqlDataReader
        Dim command As New MySqlCommand
        Try
            MySqlConn.Open()
            Dim query As String = "Delete from csas.send where id = '" & SearchBox.Text & "'"
            command = New MySqlCommand(query, MySqlConn)
            reader = command.ExecuteReader

            MessageBox.Show("Data Deleted!")
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub manageUsersBtn_Click(sender As Object, e As EventArgs)
        Me.Hide()
        ManageUsers.Show()
        Me.Dispose()
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Hide()
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub suspendClassBtn_Click(sender As Object, e As EventArgs) Handles suspendClassBtn.Click
        Me.Close()
        AdminHome.Show()
        Me.Dispose()
    End Sub
End Class
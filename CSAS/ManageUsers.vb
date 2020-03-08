Imports MySql.Data.MySqlClient
Public Class ManageUsers
    Dim MySqlConn As MySqlConnection
    Dim command As New MySqlCommand
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
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
        Dim x As New EditUser
        EditUser.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddUser_Click(sender As Object, e As EventArgs) Handles AddUser.Click
        Me.Hide()
        Dim x As New AddUser
        AddUser.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Dim x As New AdminHome
        AdminHome.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MySqlConn.Open()
            Dim query As String = "select * from csas.users"
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


End Class
﻿Imports MySql.Data.MySqlClient
Public Class ManageUsers
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
        Dim x As New EditUser
        EditUser.Show()
    End Sub

    Private Sub AddUser_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim x As New AddUser
        x.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles suspendClassesBtn.Click
        Me.Hide()
        Dim x As New AdminHome
        AdminHome.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
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

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs)
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MySqlConn.Open()
            Dim query As String = "select * from csas.users where username = @search"
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

    Private Sub SearchBox_MouseClick(sender As Object, e As MouseEventArgs)
        SearchBox.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim index As New Integer
        index = DataGridView1.CurrentCell.RowIndex
        DataGridView1.Rows.RemoveAt(index)

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
    End Sub

    Private Sub schoolUsersButton_Click(sender As Object, e As EventArgs) Handles schoolUsersButton.Click
        Me.Hide()
        ManageSchoolUsers.Show()
    End Sub

    Private Sub comUsersBtn_Click(sender As Object, e As EventArgs) Handles commUserBtn.Click
        Me.Hide()
        ManageCommUsers.Show()
    End Sub
End Class
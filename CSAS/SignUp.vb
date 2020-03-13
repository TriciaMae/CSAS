﻿Imports MySql.Data.MySqlClient
Public Class SignUp
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub FNtext_MouseDown(sender As Object, e As MouseEventArgs)
        FNtext.Text = ""


    End Sub

    Private Sub LNtext_MouseDown(sender As Object, e As MouseEventArgs)
        LNtext.Text = ""
    End Sub

    Private Sub PhoneNum(sender As Object, e As MouseEventArgs)
        NumText.Text = ""
    End Sub

    Private Sub Province_MouseDown(sender As Object, e As MouseEventArgs)
        Province.Text = ""
    End Sub

    Private Sub City_MouseDown(sender As Object, e As MouseEventArgs)
        City.Text = ""
    End Sub

    Private Sub School_MouseDown(sender As Object, e As MouseEventArgs)
        School.Text = ""
    End Sub

    Private Sub SchoolLevel_MouseDown(sender As Object, e As MouseEventArgs)
        SchoolLevel.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"
        Dim command As New MySqlCommand("insert into signup (FirstName, LastName, CP, Province, City, School, Level) values (@Fn, @Ln, @Cp, @Prov, @City, @Sch, @Lvl)", MySqlConn)
        command.Parameters.Add("@Fn", MySqlDbType.VarChar).Value = FNtext.Text
        command.Parameters.Add("@Ln", MySqlDbType.VarChar).Value = LNtext.Text
        command.Parameters.Add("@Cp", MySqlDbType.VarChar).Value = NumText.Text
        command.Parameters.Add("@Prov", MySqlDbType.VarChar).Value = Province.Text
        command.Parameters.Add("@City", MySqlDbType.VarChar).Value = City.Text
        command.Parameters.Add("@Sch", MySqlDbType.VarChar).Value = School.Text
        command.Parameters.Add("@Lvl", MySqlDbType.VarChar).Value = SchoolLevel.Text
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Sign Up Successful!")
        Else
            Me.Hide()
            Login.Show()
        End If

        Try
            MySqlConn.Open()
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub schoolUserBtn_Click(sender As Object, e As EventArgs) Handles schoolUserBtn.Click
        Me.Hide()
        SignUpSchool.Show()
    End Sub

    Private Sub commUserBtn_Click(sender As Object, e As EventArgs) Handles commUserBtn.Click
        Me.Hide()
        SignUpComm.Show()
    End Sub
End Class
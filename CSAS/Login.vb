Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub SignUpNow_Click(sender As Object, e As EventArgs) Handles SignUpNow.Click
        Me.Hide()
        Dim SignUp As New SignUp
        SignUp.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"
        Dim command As New MySqlCommand("select * from users where username = @username and password = @password", MySqlConn)
        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = TextUser.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextPass.Text
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username or Password is Invalid!")
        ElseIf (TextUser.Text = "admin" Or TextUser.Text = "samboy") Then
            Me.Hide()
            AdminHome.Show()
        ElseIf (TextUser.Text = "timot" And TextPass.Text = "timot") Then
            Me.Hide()
            UserHomeComm.Show()
        ElseIf (TextUser.Text = "leanne" And TextPAss.Text = "leanne") Then
            Me.Hide()
            UserHomeSchool.Show()
        Else
            MessageBox.Show("Username or Password is Invalid!")
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
End Class
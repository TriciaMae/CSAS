Imports MySql.Data.MySqlClient
Public Class UserHomeSchool
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Hide()
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Hide()
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub UserHomeSchool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'connecting database values to textboxes
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"
        Dim command As New MySqlCommand
        Dim reader As MySqlDataReader
        Try
            'open database connection
            MySqlConn.Open()

            'query to get all values in send table
            Dim Query As String = "select * from csas.send where id=3"

            'transfer query to mysql command 'command'
            command = New MySqlCommand(Query, MySqlConn)

            'run mysql command
            reader = command.ExecuteReader

            'populating textbox with the database values of selected table
            While reader.Read
                'connecting the data to the textbox
                FNtext.Text = reader("fname")
                LNtext.Text = reader("lname")
                NumText.Text = reader("cp_num")
                SklText.Text = reader("school")
                LvlText.Text = reader("lvl")
            End While

            'close database connection
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub updBtn_Click(sender As Object, e As EventArgs) Handles updBtn.Click
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"

        Dim reader As MySqlDataReader
        Dim command As New MySqlCommand
        Try
            MySqlConn.Open()
            Dim query As String = "update csas.send set cp_num='" & NumText.Text & "', 
            school='" & SklText.Text & "', lvl='" & LvlText.Text & "' where id=3"
            command = New MySqlCommand(query, MySqlConn)
            reader = command.ExecuteReader

            MessageBox.Show("Profile Updated!")
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub deactButton_Click(sender As Object, e As EventArgs) Handles deactButton.Click
        Me.Hide()
        Deactive2.Show()
        Me.Dispose()
    End Sub
End Class
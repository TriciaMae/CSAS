Imports MySql.Data.MySqlClient
Public Class EditSchoolUser
    Private Sub AddUserButton_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"

        Dim reader As MySqlDataReader
        Dim command As New MySqlCommand
        Try
            MySqlConn.Open()
            Dim query As String = "update csas.send set school='" & SklTxt.Text & "', 
                lvl='" & lvlTxt.Text & "', cp_num='" & CpTxt.Text & "' where id='" & FNtext.Text & "'"
            command = New MySqlCommand(query, MySqlConn)
            reader = command.ExecuteReader

            MessageBox.Show("Data Updated!")
            MySqlConn.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
            ManageSchoolUsers.Show()
            Me.Dispose()
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
        ManageSchoolUsers.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        ManageSchoolUsers.Show()
    End Sub
    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
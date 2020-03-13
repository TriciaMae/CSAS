Imports MySql.Data.MySqlClient
Public Class AddUser
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
End Class
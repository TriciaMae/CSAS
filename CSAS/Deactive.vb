Imports MySql.Data.MySqlClient
Public Class Deactive

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Hide()
        UserHomeComm.Show()
        Me.Dispose()
    End Sub

    Private Sub yesBtn_Click(sender As Object, e As EventArgs) Handles yesBtn.Click
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"

        Dim reader As MySqlDataReader
        Dim command As New MySqlCommand
        Try
            MySqlConn.Open()
            Dim query As String = "Delete from csas.comm where id = 4"
            command = New MySqlCommand(query, MySqlConn)
            reader = command.ExecuteReader

            MessageBox.Show("Account Deactivated!")
            MySqlConn.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
            Me.Dispose()
            Login.Show()
        End Try
    End Sub

    Private Sub noBtn_Click(sender As Object, e As EventArgs) Handles noBtn.Click
        Me.Hide()
        UserHomeComm.Show()
        Me.Dispose()
    End Sub
End Class
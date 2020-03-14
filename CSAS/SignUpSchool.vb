Imports MySql.Data.MySqlClient
Public Class SignUpSchool
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

    Private Sub FNtext_MouseDown(sender As Object, e As MouseEventArgs) Handles FNtext.MouseDown
        FNtext.Text = ""


    End Sub

    Private Sub LNtext_MouseDown(sender As Object, e As MouseEventArgs) Handles LNtext.MouseDown
        LNtext.Text = ""
    End Sub

    Private Sub PhoneNum(sender As Object, e As MouseEventArgs) Handles NumText.MouseDown
        NumText.Text = ""
    End Sub

    Private Sub School_MouseDown(sender As Object, e As MouseEventArgs) Handles SklText.MouseDown
        SklText.Text = ""
    End Sub

    Private Sub SchoolLevel_MouseDown(sender As Object, e As MouseEventArgs) Handles LvlTxt.MouseDown
        LvlTxt.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"

        Dim reader As MySqlDataReader
        Dim command As New MySqlCommand
        Try
            MySqlConn.Open()
            Dim query As String = "insert into csas.send (id, cp_num, school, lvl)
            values ('" & FNtext.Text & "', '" & NumText.Text & "', '" & SklText.Text & "', '" & LvlTxt.Text & "')"
            command = New MySqlCommand(query, MySqlConn)
            reader = command.ExecuteReader

            MessageBox.Show("Signup Successful!")
            MySqlConn.Close()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
            Login.Show()
            Me.Dispose()
        End Try
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        Login.Show()
    End Sub


End Class
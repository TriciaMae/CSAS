Imports MySql.Data.MySqlClient
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

    Private Sub schoolUserBtn_Click(sender As Object, e As EventArgs) Handles schoolUserBtn.Click
        Me.Hide()
        SignUpSchool.Show()
    End Sub

    Private Sub commUserBtn_Click(sender As Object, e As EventArgs) Handles commUserBtn.Click
        Me.Hide()
        SignUpComm.Show()
    End Sub
End Class
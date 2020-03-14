Imports MySql.Data.MySqlClient
Public Class ManageUsers
    Dim MySqlConn As MySqlConnection
    Dim command As New MySqlCommand
    Private Sub LogOut_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub SuspendLabel_Click(sender As Object, e As EventArgs)
        Me.Hide()
        AdminHome.Show()
        Me.Dispose()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs)
        Me.Hide()
        EditCommUser.Show()
        Me.Dispose()
    End Sub

    Private Sub AddUser_Click(sender As Object, e As EventArgs)
        Me.Hide()
        EditSchoolUser.Show()
        Me.Dispose()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Hide()
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles suspendClassesBtn.Click
        Me.Hide()
        AdminHome.Show()
        Me.Dispose()
    End Sub

    Private Sub schoolUsersButton_Click(sender As Object, e As EventArgs) Handles schoolUsersButton.Click
        Me.Hide()
        ManageSchoolUsers.Show()
        Me.Dispose()
    End Sub

    Private Sub comUsersBtn_Click(sender As Object, e As EventArgs) Handles commUserBtn.Click
        Me.Hide()
        ManageCommUsers.Show()
        Me.Dispose()
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Hide()
        Login.Show()
        Me.Dispose()
    End Sub
End Class
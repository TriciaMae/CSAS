Public Class AdminHome

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Hide()
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles manageUsersBtn.Click
        Me.Hide()
        ManageUsers.Show()
    End Sub

    Private Sub SchoolButton_Click(sender As Object, e As EventArgs) Handles SchoolButton.Click
        Me.Hide()
        School.Show()
    End Sub

    Private Sub CommunityButton_Click(sender As Object, e As EventArgs) Handles CommunityButton.Click
        Me.Hide()
        Community.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Hide()
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class
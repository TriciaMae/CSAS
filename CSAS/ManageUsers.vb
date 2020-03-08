Public Class ManageUsers
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Me.Hide()
        Dim x As New Login
        Login.Show()
    End Sub

    Private Sub SuspendLabel_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim x As New AdminHome
        AdminHome.Show()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Me.Hide()
        Dim x As New EditUser
        EditUser.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub AddUser_Click(sender As Object, e As EventArgs) Handles AddUser.Click
        Me.Hide()
        Dim x As New AddUser
        AddUser.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Dim x As New AdminHome
        AdminHome.Show()
    End Sub
End Class
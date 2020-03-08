Public Class Community
    Private Sub CancellButton_Click(sender As Object, e As EventArgs) Handles CancellButton.Click
        Me.Hide()
        Dim x As New AdminHome
        AdminHome.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim x As New AdminHome
        AdminHome.Show()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class
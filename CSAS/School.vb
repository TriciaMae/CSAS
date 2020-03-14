Imports MySql.Data.MySqlClient
Public Class School
    Private Sub CancellButton_Click(sender As Object, e As EventArgs) Handles CancellButton.Click
        Me.Hide()
        AdminHome.Show()
        Me.Dispose()
    End Sub

    Function GrpTxt()
        'grp msg function

        Using client As New Net.WebClient
            Dim MySqlConn As MySqlConnection
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"

            Dim command As New MySqlCommand
            Dim reader As MySqlDataReader
            Dim api As String = "TR-TESTC812033_T7UVR"
            Dim school As String = SklCombo.Text
            Dim lvl As String = sklLvlCombo.Text
            Dim dat As String = DateTimePicker1.Text
            Dim msg As String

            msg = "Classes are suspended in " + lvl + " in " + school + " on " + dat +
                " due to Eng. Week Day."

            Try
                'open database connection
                MySqlConn.Open()

                'Using client As New Net.WebClient
                System.Threading.Thread.Sleep(2000)
                'query for getting the data selected in the combobox
                Dim Query As String = "select cp_num from csas.send where school = '" & SklCombo.Text & "'and lvl = '" & sklLvlCombo.Text & "'"
                'transfer query to mysql command 'command'
                command = New MySqlCommand(Query, MySqlConn)

                'run mysql command
                reader = command.ExecuteReader

                'populating combobox with the database values of selected table
                While reader.Read
                    Dim parameter As New Specialized.NameValueCollection
                    Dim url As String = "https://www.itexmo.com/php_api/api.php"
                    MessageBox.Show(reader.GetString("cp_num"))
                    parameter.Add("1", reader.GetString("cp_num"))
                    parameter.Add("2", msg)
                    parameter.Add("3", api)

                    Dim rpb = client.UploadValues(url, "POST", parameter)
                    GrpTxt = (New System.Text.UTF8Encoding).GetString(rpb)
                    'End Using
                End While

                'close database connection
                MySqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.StackTrace)
            Finally
                MySqlConn.Dispose()
            End Try
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles suspendBtn.Click
        'send btn
        Dim result = GrpTxt()
        If result = 0 Then
            MsgBox("Message Sent!")
        Else
            MsgBox("Error number " & result & " was encountered")
        End If
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Hide()
        AdminHome.Show()
        Me.Dispose()
    End Sub

    Private Sub School_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'connecting database values to combobox
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"
        Dim command As New MySqlCommand
        Dim reader As MySqlDataReader
        Try
            'open database connection
            MySqlConn.Open()

            'query to get all values in send table
            Dim Query As String = "select * from csas.send"

            'transfer query to mysql command 'command'
            command = New MySqlCommand(Query, MySqlConn)

            'run mysql command
            reader = command.ExecuteReader

            'populating combobox with the database values of selected table
            While reader.Read
                'connecting the data in the school column to the combobox
                Dim skl = reader.GetString("school")
                Dim ide = reader.GetString("lvl")
                SklCombo.Items.Add(skl)
                sklLvlCombo.Items.Add(ide)
            End While

            'close database connection
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
End Class
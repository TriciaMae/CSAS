Imports MySql.Data.MySqlClient

Public Class Community

    Function GrpTxt()
        'grp msg function

        Using client As New Net.WebClient
            Dim MySqlConn As MySqlConnection
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"

            Dim command As New MySqlCommand
            Dim reader As MySqlDataReader
            Dim api As String = "TR-SUSPE578044_MST6F"
            Dim region As String = RegionCombo.Text
            Dim city As String = CityCombo.Text
            Dim prov As String = ProvCombo.Text
            Dim lvl As String = SchoolLevel.Text
            Dim dat As String = DateTimePicker1.Text
            Dim msg As String

            msg = "Classes are suspended in " + lvl + " in the city of " + city + " on " + dat

            Try
                'open database connection
                MySqlConn.Open()

                'Using client As New Net.WebClient
                System.Threading.Thread.Sleep(2000)
                'query for getting the data selected in the combobox
                Dim Query As String = "select cp from csas.tricia where region = '" & RegionCombo.Text & "' and city = '" & CityCombo.Text & "' or province = '" & ProvCombo.Text & "' and lvl = '" & SchoolLevel.Text & "'     "
                'transfer query to mysql command 'command'
                command = New MySqlCommand(Query, MySqlConn)

                'run mysql command
                reader = command.ExecuteReader

                'populating combobox with the database values of selected table
                While reader.Read
                    Dim parameter As New Specialized.NameValueCollection
                    Dim url As String = "https://www.itexmo.com/php_api/api.php"
                    MessageBox.Show(reader.GetString("cp"))
                    parameter.Add("1", reader.GetString("cp"))
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


    Private Sub CancellButton_Click(sender As Object, e As EventArgs) Handles CancellButton.Click
        Me.Hide()
        Dim x As New AdminHome
        AdminHome.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        Me.Close()
    End Sub

    Private Sub Community_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim Query As String = "select * from csas.tricia"

            'transfer query to mysql command 'command'
            command = New MySqlCommand(Query, MySqlConn)

            'run mysql command
            reader = command.ExecuteReader

            'populating combobox with the database values of selected table
            While reader.Read
                'connecting the data in the school column to the combobox
                Dim reg = reader.GetString("Region")
                Dim cit = reader.GetString("City")
                Dim prov = reader.GetString("Province")
                Dim lvl = reader.GetString("lvl")
                RegionCombo.Items.Add(reg)
                CityCombo.Items.Add(cit)
                ProvCombo.Items.Add(prov)
                SchoolLevel.Items.Add(lvl)
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
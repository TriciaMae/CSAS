<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GrpApi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrpSend = New System.Windows.Forms.Button()
        Me.GrpMsg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GrpApi
        '
        Me.GrpApi.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.GrpApi.Location = New System.Drawing.Point(379, 39)
        Me.GrpApi.Name = "GrpApi"
        Me.GrpApi.Size = New System.Drawing.Size(355, 45)
        Me.GrpApi.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(36, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "API Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.Location = New System.Drawing.Point(36, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 39)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Recipient:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Quezon City", "Manila"})
        Me.ComboBox1.Location = New System.Drawing.Point(379, 180)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(355, 39)
        Me.ComboBox1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label3.Location = New System.Drawing.Point(124, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 39)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "City"
        '
        'GrpSend
        '
        Me.GrpSend.BackColor = System.Drawing.Color.DimGray
        Me.GrpSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GrpSend.Location = New System.Drawing.Point(325, 433)
        Me.GrpSend.Name = "GrpSend"
        Me.GrpSend.Size = New System.Drawing.Size(94, 40)
        Me.GrpSend.TabIndex = 13
        Me.GrpSend.Text = "Send"
        Me.GrpSend.UseVisualStyleBackColor = False
        '
        'GrpMsg
        '
        Me.GrpMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GrpMsg.Location = New System.Drawing.Point(379, 249)
        Me.GrpMsg.Multiline = True
        Me.GrpMsg.Name = "GrpMsg"
        Me.GrpMsg.Size = New System.Drawing.Size(355, 156)
        Me.GrpMsg.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label4.Location = New System.Drawing.Point(36, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 39)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Message"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GrpSend)
        Me.Controls.Add(Me.GrpMsg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GrpApi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Send Group SMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrpApi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GrpSend As Button
    Friend WithEvents GrpMsg As TextBox
    Friend WithEvents Label4 As Label
End Class

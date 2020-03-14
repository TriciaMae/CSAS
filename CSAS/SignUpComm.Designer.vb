<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUpComm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Minimize = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SignUpLabel = New System.Windows.Forms.Label()
        Me.FNtext = New System.Windows.Forms.TextBox()
        Me.LNtext = New System.Windows.Forms.TextBox()
        Me.NumText = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RegionText = New System.Windows.Forms.TextBox()
        Me.ProvinceText = New System.Windows.Forms.TextBox()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CityText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Minimize
        '
        Me.Minimize.BackColor = System.Drawing.Color.Transparent
        Me.Minimize.BackgroundImage = Global.CSAS.My.Resources.Resources.Minimize
        Me.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Minimize.FlatAppearance.BorderSize = 0
        Me.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimize.ForeColor = System.Drawing.Color.White
        Me.Minimize.Location = New System.Drawing.Point(577, 6)
        Me.Minimize.MaximumSize = New System.Drawing.Size(20, 20)
        Me.Minimize.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Minimize.Name = "Minimize"
        Me.Minimize.Size = New System.Drawing.Size(20, 20)
        Me.Minimize.TabIndex = 2
        Me.Minimize.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.BackgroundImage = Global.CSAS.My.Resources.Resources.ExitButton
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(614, 6)
        Me.CloseButton.MaximumSize = New System.Drawing.Size(20, 20)
        Me.CloseButton.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(20, 20)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'SignUpLabel
        '
        Me.SignUpLabel.AutoSize = True
        Me.SignUpLabel.BackColor = System.Drawing.Color.Transparent
        Me.SignUpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SignUpLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.SignUpLabel.Location = New System.Drawing.Point(382, 63)
        Me.SignUpLabel.Name = "SignUpLabel"
        Me.SignUpLabel.Size = New System.Drawing.Size(110, 29)
        Me.SignUpLabel.TabIndex = 5
        Me.SignUpLabel.Text = "SIGN UP"
        '
        'FNtext
        '
        Me.FNtext.BackColor = System.Drawing.Color.White
        Me.FNtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FNtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNtext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.FNtext.Location = New System.Drawing.Point(280, 165)
        Me.FNtext.Name = "FNtext"
        Me.FNtext.Size = New System.Drawing.Size(142, 26)
        Me.FNtext.TabIndex = 6
        Me.FNtext.Text = "First Name"
        Me.FNtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LNtext
        '
        Me.LNtext.BackColor = System.Drawing.Color.White
        Me.LNtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LNtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNtext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.LNtext.Location = New System.Drawing.Point(442, 165)
        Me.LNtext.Name = "LNtext"
        Me.LNtext.Size = New System.Drawing.Size(142, 26)
        Me.LNtext.TabIndex = 7
        Me.LNtext.Text = "Last Name"
        Me.LNtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumText
        '
        Me.NumText.BackColor = System.Drawing.Color.White
        Me.NumText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.NumText.Location = New System.Drawing.Point(280, 202)
        Me.NumText.Name = "NumText"
        Me.NumText.Size = New System.Drawing.Size(304, 26)
        Me.NumText.TabIndex = 10
        Me.NumText.Text = "Phone Number"
        Me.NumText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.CSAS.My.Resources.Resources.SignupBlue
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(363, 364)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 35)
        Me.Button3.TabIndex = 17
        Me.Button3.UseVisualStyleBackColor = False
        '
        'RegionText
        '
        Me.RegionText.BackColor = System.Drawing.Color.White
        Me.RegionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RegionText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.RegionText.Location = New System.Drawing.Point(280, 240)
        Me.RegionText.Name = "RegionText"
        Me.RegionText.Size = New System.Drawing.Size(304, 26)
        Me.RegionText.TabIndex = 20
        Me.RegionText.Text = "Region"
        Me.RegionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProvinceText
        '
        Me.ProvinceText.BackColor = System.Drawing.Color.White
        Me.ProvinceText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProvinceText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinceText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ProvinceText.Location = New System.Drawing.Point(280, 279)
        Me.ProvinceText.Name = "ProvinceText"
        Me.ProvinceText.Size = New System.Drawing.Size(304, 26)
        Me.ProvinceText.TabIndex = 23
        Me.ProvinceText.Text = "Province"
        Me.ProvinceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.backBtn.FlatAppearance.BorderSize = 0
        Me.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.backBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.backBtn.Location = New System.Drawing.Point(0, 0)
        Me.backBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(136, 34)
        Me.backBtn.TabIndex = 24
        Me.backBtn.Text = "BACK TO LOGIN"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(325, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 35)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "CREATE ACCOUNT FOR COMMUNITY SUSPENSION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CityText
        '
        Me.CityText.BackColor = System.Drawing.Color.White
        Me.CityText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CityText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.CityText.Location = New System.Drawing.Point(280, 318)
        Me.CityText.Name = "CityText"
        Me.CityText.Size = New System.Drawing.Size(304, 26)
        Me.CityText.TabIndex = 26
        Me.CityText.Text = "City"
        Me.CityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SignUpComm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.LoginSignUp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.CityText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.ProvinceText)
        Me.Controls.Add(Me.RegionText)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.NumText)
        Me.Controls.Add(Me.LNtext)
        Me.Controls.Add(Me.FNtext)
        Me.Controls.Add(Me.SignUpLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Minimize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(640, 480)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "SignUpComm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minimize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents SignUpLabel As Label
    Friend WithEvents FNtext As TextBox
    Friend WithEvents LNtext As TextBox
    Friend WithEvents NumText As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents RegionText As TextBox
    Friend WithEvents ProvinceText As TextBox
    Friend WithEvents backBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CityText As TextBox
End Class

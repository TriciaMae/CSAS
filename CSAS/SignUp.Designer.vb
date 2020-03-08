<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.School = New System.Windows.Forms.TextBox()
        Me.Province = New System.Windows.Forms.TextBox()
        Me.City = New System.Windows.Forms.TextBox()
        Me.SchoolLevel = New System.Windows.Forms.TextBox()
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
        Me.FNtext.Location = New System.Drawing.Point(280, 110)
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
        Me.LNtext.Location = New System.Drawing.Point(442, 110)
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
        Me.NumText.Location = New System.Drawing.Point(280, 146)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 22)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 19)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'School
        '
        Me.School.BackColor = System.Drawing.Color.White
        Me.School.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.School.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.School.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.School.Location = New System.Drawing.Point(280, 224)
        Me.School.Name = "School"
        Me.School.Size = New System.Drawing.Size(304, 26)
        Me.School.TabIndex = 20
        Me.School.Text = "School"
        Me.School.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Province
        '
        Me.Province.BackColor = System.Drawing.Color.White
        Me.Province.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Province.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Province.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Province.Location = New System.Drawing.Point(280, 185)
        Me.Province.Name = "Province"
        Me.Province.Size = New System.Drawing.Size(142, 26)
        Me.Province.TabIndex = 21
        Me.Province.Text = "Province"
        Me.Province.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'City
        '
        Me.City.BackColor = System.Drawing.Color.White
        Me.City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.City.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.City.Location = New System.Drawing.Point(442, 185)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(142, 26)
        Me.City.TabIndex = 22
        Me.City.Text = "City"
        Me.City.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SchoolLevel
        '
        Me.SchoolLevel.BackColor = System.Drawing.Color.White
        Me.SchoolLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SchoolLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.SchoolLevel.Location = New System.Drawing.Point(280, 266)
        Me.SchoolLevel.Name = "SchoolLevel"
        Me.SchoolLevel.Size = New System.Drawing.Size(304, 26)
        Me.SchoolLevel.TabIndex = 23
        Me.SchoolLevel.Text = "School Level"
        Me.SchoolLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.LoginSignUp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.SchoolLevel)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.Province)
        Me.Controls.Add(Me.School)
        Me.Controls.Add(Me.Button1)
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
        Me.Name = "SignUp"
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
    Friend WithEvents Button1 As Button
    Friend WithEvents School As TextBox
    Friend WithEvents Province As TextBox
    Friend WithEvents City As TextBox
    Friend WithEvents SchoolLevel As TextBox
End Class

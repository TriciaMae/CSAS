<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserHomeSchool
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
        Me.profileBtn = New System.Windows.Forms.Button()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.SchoolLevel = New System.Windows.Forms.TextBox()
        Me.School = New System.Windows.Forms.TextBox()
        Me.NumText = New System.Windows.Forms.TextBox()
        Me.LNtext = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FNtext = New System.Windows.Forms.TextBox()
        Me.updBtn = New System.Windows.Forms.Button()
        Me.deactButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Minimize.Location = New System.Drawing.Point(769, 7)
        Me.Minimize.Margin = New System.Windows.Forms.Padding(4)
        Me.Minimize.MaximumSize = New System.Drawing.Size(27, 25)
        Me.Minimize.MinimumSize = New System.Drawing.Size(27, 25)
        Me.Minimize.Name = "Minimize"
        Me.Minimize.Size = New System.Drawing.Size(27, 25)
        Me.Minimize.TabIndex = 3
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
        Me.CloseButton.Location = New System.Drawing.Point(819, 7)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseButton.MaximumSize = New System.Drawing.Size(27, 25)
        Me.CloseButton.MinimumSize = New System.Drawing.Size(27, 25)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(27, 25)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'profileBtn
        '
        Me.profileBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.profileBtn.FlatAppearance.BorderSize = 0
        Me.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.profileBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profileBtn.Location = New System.Drawing.Point(45, 85)
        Me.profileBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.profileBtn.Name = "profileBtn"
        Me.profileBtn.Size = New System.Drawing.Size(145, 46)
        Me.profileBtn.TabIndex = 25
        Me.profileBtn.TabStop = False
        Me.profileBtn.Text = "MY PROFILE"
        Me.profileBtn.UseVisualStyleBackColor = False
        '
        'logoutBtn
        '
        Me.logoutBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.logoutBtn.FlatAppearance.BorderSize = 0
        Me.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutBtn.Location = New System.Drawing.Point(701, 85)
        Me.logoutBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(117, 46)
        Me.logoutBtn.TabIndex = 26
        Me.logoutBtn.TabStop = False
        Me.logoutBtn.Text = "LOG OUT"
        Me.logoutBtn.UseVisualStyleBackColor = False
        '
        'SchoolLevel
        '
        Me.SchoolLevel.BackColor = System.Drawing.Color.White
        Me.SchoolLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SchoolLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.SchoolLevel.Location = New System.Drawing.Point(421, 331)
        Me.SchoolLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.SchoolLevel.Name = "SchoolLevel"
        Me.SchoolLevel.Size = New System.Drawing.Size(342, 30)
        Me.SchoolLevel.TabIndex = 30
        Me.SchoolLevel.Text = "School Level"
        Me.SchoolLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'School
        '
        Me.School.BackColor = System.Drawing.Color.White
        Me.School.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.School.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.School.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.School.Location = New System.Drawing.Point(421, 271)
        Me.School.Margin = New System.Windows.Forms.Padding(4)
        Me.School.Name = "School"
        Me.School.Size = New System.Drawing.Size(342, 30)
        Me.School.TabIndex = 27
        Me.School.Text = "School"
        Me.School.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumText
        '
        Me.NumText.BackColor = System.Drawing.Color.White
        Me.NumText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.NumText.Location = New System.Drawing.Point(421, 212)
        Me.NumText.Margin = New System.Windows.Forms.Padding(4)
        Me.NumText.Name = "NumText"
        Me.NumText.Size = New System.Drawing.Size(342, 30)
        Me.NumText.TabIndex = 33
        Me.NumText.Text = "Phone Number"
        Me.NumText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LNtext
        '
        Me.LNtext.BackColor = System.Drawing.Color.White
        Me.LNtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LNtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNtext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.LNtext.Location = New System.Drawing.Point(117, 425)
        Me.LNtext.Margin = New System.Windows.Forms.Padding(4)
        Me.LNtext.Name = "LNtext"
        Me.LNtext.Size = New System.Drawing.Size(241, 30)
        Me.LNtext.TabIndex = 32
        Me.LNtext.Text = "Last Name"
        Me.LNtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CSAS.My.Resources.Resources.profile_128
        Me.PictureBox1.Location = New System.Drawing.Point(117, 180)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'FNtext
        '
        Me.FNtext.BackColor = System.Drawing.Color.White
        Me.FNtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FNtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNtext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.FNtext.Location = New System.Drawing.Point(117, 362)
        Me.FNtext.Margin = New System.Windows.Forms.Padding(4)
        Me.FNtext.Name = "FNtext"
        Me.FNtext.Size = New System.Drawing.Size(241, 30)
        Me.FNtext.TabIndex = 35
        Me.FNtext.Text = "First Name"
        Me.FNtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'updBtn
        '
        Me.updBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.updBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.updBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.updBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.updBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.updBtn.Location = New System.Drawing.Point(592, 396)
        Me.updBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.updBtn.Name = "updBtn"
        Me.updBtn.Size = New System.Drawing.Size(171, 58)
        Me.updBtn.TabIndex = 37
        Me.updBtn.Text = "UPDATE ACCOUNT"
        Me.updBtn.UseVisualStyleBackColor = False
        '
        'deactButton
        '
        Me.deactButton.BackColor = System.Drawing.Color.Brown
        Me.deactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.deactButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.deactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deactButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.deactButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.deactButton.Location = New System.Drawing.Point(421, 396)
        Me.deactButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.deactButton.Name = "deactButton"
        Me.deactButton.Size = New System.Drawing.Size(171, 58)
        Me.deactButton.TabIndex = 36
        Me.deactButton.Text = "DEACTIVATE ACCOUNT"
        Me.deactButton.UseVisualStyleBackColor = False
        '
        'UserHomeSchool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.Home
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(853, 591)
        Me.Controls.Add(Me.updBtn)
        Me.Controls.Add(Me.deactButton)
        Me.Controls.Add(Me.FNtext)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NumText)
        Me.Controls.Add(Me.LNtext)
        Me.Controls.Add(Me.SchoolLevel)
        Me.Controls.Add(Me.School)
        Me.Controls.Add(Me.logoutBtn)
        Me.Controls.Add(Me.profileBtn)
        Me.Controls.Add(Me.Minimize)
        Me.Controls.Add(Me.CloseButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(853, 591)
        Me.MinimumSize = New System.Drawing.Size(853, 591)
        Me.Name = "UserHomeSchool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminHome"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minimize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents profileBtn As Button
    Friend WithEvents logoutBtn As Button
    Friend WithEvents SchoolLevel As TextBox
    Friend WithEvents School As TextBox
    Friend WithEvents NumText As TextBox
    Friend WithEvents LNtext As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FNtext As TextBox
    Friend WithEvents updBtn As Button
    Friend WithEvents deactButton As Button
End Class

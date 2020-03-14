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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserHomeSchool))
        Me.Minimize = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.LvlText = New System.Windows.Forms.TextBox()
        Me.SklText = New System.Windows.Forms.TextBox()
        Me.NumText = New System.Windows.Forms.TextBox()
        Me.LNtext = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FNtext = New System.Windows.Forms.TextBox()
        Me.updBtn = New System.Windows.Forms.Button()
        Me.deactButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Minimize.Location = New System.Drawing.Point(577, 6)
        Me.Minimize.MaximumSize = New System.Drawing.Size(20, 20)
        Me.Minimize.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Minimize.Name = "Minimize"
        Me.Minimize.Size = New System.Drawing.Size(20, 20)
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
        Me.CloseButton.Location = New System.Drawing.Point(614, 6)
        Me.CloseButton.MaximumSize = New System.Drawing.Size(20, 20)
        Me.CloseButton.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(20, 20)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'logoutBtn
        '
        Me.logoutBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.logoutBtn.FlatAppearance.BorderSize = 0
        Me.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutBtn.Location = New System.Drawing.Point(526, 69)
        Me.logoutBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(88, 37)
        Me.logoutBtn.TabIndex = 26
        Me.logoutBtn.TabStop = False
        Me.logoutBtn.Text = "LOG OUT"
        Me.logoutBtn.UseVisualStyleBackColor = False
        '
        'LvlText
        '
        Me.LvlText.BackColor = System.Drawing.Color.White
        Me.LvlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LvlText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvlText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LvlText.Location = New System.Drawing.Point(316, 269)
        Me.LvlText.Name = "LvlText"
        Me.LvlText.Size = New System.Drawing.Size(257, 26)
        Me.LvlText.TabIndex = 30
        Me.LvlText.Text = "School Level"
        Me.LvlText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SklText
        '
        Me.SklText.BackColor = System.Drawing.Color.White
        Me.SklText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SklText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SklText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SklText.Location = New System.Drawing.Point(316, 220)
        Me.SklText.Name = "SklText"
        Me.SklText.Size = New System.Drawing.Size(257, 26)
        Me.SklText.TabIndex = 27
        Me.SklText.Text = "School"
        Me.SklText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumText
        '
        Me.NumText.BackColor = System.Drawing.Color.White
        Me.NumText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NumText.Location = New System.Drawing.Point(316, 172)
        Me.NumText.Name = "NumText"
        Me.NumText.Size = New System.Drawing.Size(257, 26)
        Me.NumText.TabIndex = 33
        Me.NumText.Text = "Phone Number"
        Me.NumText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LNtext
        '
        Me.LNtext.BackColor = System.Drawing.Color.White
        Me.LNtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LNtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNtext.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LNtext.Location = New System.Drawing.Point(88, 345)
        Me.LNtext.Name = "LNtext"
        Me.LNtext.Size = New System.Drawing.Size(181, 26)
        Me.LNtext.TabIndex = 32
        Me.LNtext.Text = "Last Name"
        Me.LNtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CSAS.My.Resources.Resources.profile_128
        Me.PictureBox1.Location = New System.Drawing.Point(88, 146)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'FNtext
        '
        Me.FNtext.BackColor = System.Drawing.Color.White
        Me.FNtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FNtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNtext.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FNtext.Location = New System.Drawing.Point(88, 294)
        Me.FNtext.Name = "FNtext"
        Me.FNtext.Size = New System.Drawing.Size(181, 26)
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
        Me.updBtn.Location = New System.Drawing.Point(444, 322)
        Me.updBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.updBtn.Name = "updBtn"
        Me.updBtn.Size = New System.Drawing.Size(128, 47)
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
        Me.deactButton.Location = New System.Drawing.Point(316, 322)
        Me.deactButton.Margin = New System.Windows.Forms.Padding(2)
        Me.deactButton.Name = "deactButton"
        Me.deactButton.Size = New System.Drawing.Size(128, 47)
        Me.deactButton.TabIndex = 36
        Me.deactButton.Text = "DEACTIVATE ACCOUNT"
        Me.deactButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(46, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "MY PROFILE"
        '
        'UserHomeSchool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.Home
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.updBtn)
        Me.Controls.Add(Me.deactButton)
        Me.Controls.Add(Me.FNtext)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NumText)
        Me.Controls.Add(Me.LNtext)
        Me.Controls.Add(Me.LvlText)
        Me.Controls.Add(Me.SklText)
        Me.Controls.Add(Me.logoutBtn)
        Me.Controls.Add(Me.Minimize)
        Me.Controls.Add(Me.CloseButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(640, 480)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "UserHomeSchool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminHome"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minimize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents logoutBtn As Button
    Friend WithEvents LvlText As TextBox
    Friend WithEvents SklText As TextBox
    Friend WithEvents NumText As TextBox
    Friend WithEvents LNtext As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FNtext As TextBox
    Friend WithEvents updBtn As Button
    Friend WithEvents deactButton As Button
    Friend WithEvents Label1 As Label
End Class

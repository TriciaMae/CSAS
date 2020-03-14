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
        Me.backBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.schoolUserBtn = New System.Windows.Forms.Button()
        Me.commUserBtn = New System.Windows.Forms.Button()
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
        Me.backBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(136, 34)
        Me.backBtn.TabIndex = 18
        Me.backBtn.Text = "🡨 BACK TO LOGIN"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(262, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 43)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "CREATE AN ACCOUNT FOR:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'schoolUserBtn
        '
        Me.schoolUserBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.schoolUserBtn.FlatAppearance.BorderSize = 0
        Me.schoolUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.schoolUserBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.schoolUserBtn.ForeColor = System.Drawing.Color.Black
        Me.schoolUserBtn.Location = New System.Drawing.Point(360, 176)
        Me.schoolUserBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.schoolUserBtn.Name = "schoolUserBtn"
        Me.schoolUserBtn.Size = New System.Drawing.Size(143, 75)
        Me.schoolUserBtn.TabIndex = 27
        Me.schoolUserBtn.Text = "SCHOOL SUSPENSION"
        Me.schoolUserBtn.UseVisualStyleBackColor = False
        '
        'commUserBtn
        '
        Me.commUserBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.commUserBtn.FlatAppearance.BorderSize = 0
        Me.commUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.commUserBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.commUserBtn.ForeColor = System.Drawing.Color.Black
        Me.commUserBtn.Location = New System.Drawing.Point(360, 274)
        Me.commUserBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.commUserBtn.Name = "commUserBtn"
        Me.commUserBtn.Size = New System.Drawing.Size(143, 75)
        Me.commUserBtn.TabIndex = 28
        Me.commUserBtn.Text = "COMMUNITY SUSPENSION"
        Me.commUserBtn.UseVisualStyleBackColor = False
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.LoginSignUp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.commUserBtn)
        Me.Controls.Add(Me.schoolUserBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.SignUpLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Minimize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(640, 480)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minimize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents SignUpLabel As Label
    Friend WithEvents backBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents schoolUserBtn As Button
    Friend WithEvents commUserBtn As Button
End Class

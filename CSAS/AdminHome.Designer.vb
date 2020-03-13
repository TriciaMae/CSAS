<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminHome
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
        Me.SchoolButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.manageUsersBtn = New System.Windows.Forms.Button()
        Me.CommunityButton = New System.Windows.Forms.Button()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.suspendClassesBtn = New System.Windows.Forms.Button()
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
        'SchoolButton
        '
        Me.SchoolButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.SchoolButton.FlatAppearance.BorderSize = 0
        Me.SchoolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SchoolButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolButton.Location = New System.Drawing.Point(205, 262)
        Me.SchoolButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SchoolButton.Name = "SchoolButton"
        Me.SchoolButton.Size = New System.Drawing.Size(171, 170)
        Me.SchoolButton.TabIndex = 8
        Me.SchoolButton.Text = "SCHOOL"
        Me.SchoolButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(64, 194)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Suspend Classes for:"
        '
        'manageUsersBtn
        '
        Me.manageUsersBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.manageUsersBtn.FlatAppearance.BorderSize = 0
        Me.manageUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manageUsersBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageUsersBtn.Location = New System.Drawing.Point(325, 85)
        Me.manageUsersBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.manageUsersBtn.Name = "manageUsersBtn"
        Me.manageUsersBtn.Size = New System.Drawing.Size(239, 46)
        Me.manageUsersBtn.TabIndex = 11
        Me.manageUsersBtn.Text = "MANAGE USERS"
        Me.manageUsersBtn.UseVisualStyleBackColor = False
        '
        'CommunityButton
        '
        Me.CommunityButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.CommunityButton.FlatAppearance.BorderSize = 0
        Me.CommunityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CommunityButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommunityButton.Location = New System.Drawing.Point(487, 262)
        Me.CommunityButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CommunityButton.Name = "CommunityButton"
        Me.CommunityButton.Size = New System.Drawing.Size(171, 170)
        Me.CommunityButton.TabIndex = 9
        Me.CommunityButton.Text = "COMMUNITY"
        Me.CommunityButton.UseVisualStyleBackColor = False
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
        Me.logoutBtn.TabIndex = 27
        Me.logoutBtn.TabStop = False
        Me.logoutBtn.Text = "LOG OUT"
        Me.logoutBtn.UseVisualStyleBackColor = False
        '
        'suspendClassesBtn
        '
        Me.suspendClassesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.suspendClassesBtn.FlatAppearance.BorderSize = 0
        Me.suspendClassesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.suspendClassesBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suspendClassesBtn.Location = New System.Drawing.Point(44, 85)
        Me.suspendClassesBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.suspendClassesBtn.Name = "suspendClassesBtn"
        Me.suspendClassesBtn.Size = New System.Drawing.Size(239, 46)
        Me.suspendClassesBtn.TabIndex = 28
        Me.suspendClassesBtn.Text = "SUSPEND CLASSES"
        Me.suspendClassesBtn.UseVisualStyleBackColor = False
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.Home
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(853, 591)
        Me.Controls.Add(Me.suspendClassesBtn)
        Me.Controls.Add(Me.logoutBtn)
        Me.Controls.Add(Me.manageUsersBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CommunityButton)
        Me.Controls.Add(Me.SchoolButton)
        Me.Controls.Add(Me.Minimize)
        Me.Controls.Add(Me.CloseButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(853, 591)
        Me.MinimumSize = New System.Drawing.Size(853, 591)
        Me.Name = "AdminHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminHome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minimize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents SchoolButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents manageUsersBtn As Button
    Friend WithEvents CommunityButton As Button
    Friend WithEvents logoutBtn As Button
    Friend WithEvents suspendClassesBtn As Button
End Class

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
        Me.SuspendLabel = New System.Windows.Forms.Label()
        Me.LogOut = New System.Windows.Forms.Label()
        Me.SchoolButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CommunityButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Minimize
        '
        Me.Minimize.BackColor = System.Drawing.Color.Transparent
        Me.Minimize.BackgroundImage = Global.CSAS.My.Resources.Resources.Minimize
        Me.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Minimize.FlatAppearance.BorderSize = 0
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
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(614, 6)
        Me.CloseButton.MaximumSize = New System.Drawing.Size(20, 20)
        Me.CloseButton.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(20, 20)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'SuspendLabel
        '
        Me.SuspendLabel.AutoSize = True
        Me.SuspendLabel.BackColor = System.Drawing.Color.Transparent
        Me.SuspendLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuspendLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.SuspendLabel.Location = New System.Drawing.Point(38, 76)
        Me.SuspendLabel.Name = "SuspendLabel"
        Me.SuspendLabel.Size = New System.Drawing.Size(189, 24)
        Me.SuspendLabel.TabIndex = 5
        Me.SuspendLabel.Text = "SUSPEND CLASSES"
        '
        'LogOut
        '
        Me.LogOut.AutoSize = True
        Me.LogOut.BackColor = System.Drawing.Color.Transparent
        Me.LogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.ForeColor = System.Drawing.Color.Black
        Me.LogOut.Location = New System.Drawing.Point(517, 76)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(94, 24)
        Me.LogOut.TabIndex = 7
        Me.LogOut.Text = "LOG OUT"
        '
        'SchoolButton
        '
        Me.SchoolButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.SchoolButton.FlatAppearance.BorderSize = 0
        Me.SchoolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SchoolButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolButton.Location = New System.Drawing.Point(154, 213)
        Me.SchoolButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SchoolButton.Name = "SchoolButton"
        Me.SchoolButton.Size = New System.Drawing.Size(128, 138)
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
        Me.Label1.Location = New System.Drawing.Point(48, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Suspend Classes for:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(244, 74)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 29)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "MANAGE USERS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CommunityButton
        '
        Me.CommunityButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.CommunityButton.FlatAppearance.BorderSize = 0
        Me.CommunityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CommunityButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommunityButton.Location = New System.Drawing.Point(365, 213)
        Me.CommunityButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CommunityButton.Name = "CommunityButton"
        Me.CommunityButton.Size = New System.Drawing.Size(128, 138)
        Me.CommunityButton.TabIndex = 9
        Me.CommunityButton.Text = "COMMUNITY"
        Me.CommunityButton.UseVisualStyleBackColor = False
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.Home
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CommunityButton)
        Me.Controls.Add(Me.SchoolButton)
        Me.Controls.Add(Me.LogOut)
        Me.Controls.Add(Me.SuspendLabel)
        Me.Controls.Add(Me.Minimize)
        Me.Controls.Add(Me.CloseButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(640, 480)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "AdminHome"
        Me.Text = "AdminHome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minimize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents SuspendLabel As Label
    Friend WithEvents LogOut As Label
    Friend WithEvents SchoolButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CommunityButton As Button
End Class

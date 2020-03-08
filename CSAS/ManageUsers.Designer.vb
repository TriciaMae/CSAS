<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageUsers
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
        Me.LogOut = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddUser = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeactivateUser = New System.Windows.Forms.Button()
        Me.UsersList = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.UsersList.SuspendLayout()
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
        'LogOut
        '
        Me.LogOut.AutoSize = True
        Me.LogOut.BackColor = System.Drawing.Color.Transparent
        Me.LogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.ForeColor = System.Drawing.Color.Black
        Me.LogOut.Location = New System.Drawing.Point(517, 76)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(94, 24)
        Me.LogOut.TabIndex = 10
        Me.LogOut.Text = "LOG OUT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(245, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "MANAGE USERS"
        '
        'AddUser
        '
        Me.AddUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.AddUser.FlatAppearance.BorderSize = 0
        Me.AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUser.Location = New System.Drawing.Point(472, 404)
        Me.AddUser.Margin = New System.Windows.Forms.Padding(2)
        Me.AddUser.Name = "AddUser"
        Me.AddUser.Size = New System.Drawing.Size(135, 35)
        Me.AddUser.TabIndex = 12
        Me.AddUser.Text = "ADD USER"
        Me.AddUser.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.EditButton.FlatAppearance.BorderSize = 0
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(229, 2)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(2)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(52, 28)
        Me.EditButton.TabIndex = 18
        Me.EditButton.Text = "EDIT"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'DeactivateUser
        '
        Me.DeactivateUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DeactivateUser.FlatAppearance.BorderSize = 0
        Me.DeactivateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeactivateUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeactivateUser.Location = New System.Drawing.Point(285, 34)
        Me.DeactivateUser.Margin = New System.Windows.Forms.Padding(2)
        Me.DeactivateUser.Name = "DeactivateUser"
        Me.DeactivateUser.Size = New System.Drawing.Size(94, 32)
        Me.DeactivateUser.TabIndex = 20
        Me.DeactivateUser.Text = "DEACTIVATE"
        Me.DeactivateUser.UseVisualStyleBackColor = False
        '
        'UsersList
        '
        Me.UsersList.ColumnCount = 3
        Me.UsersList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.13356!))
        Me.UsersList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.86644!))
        Me.UsersList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.UsersList.Controls.Add(Me.EditButton, 1, 0)
        Me.UsersList.Controls.Add(Me.Button1, 1, 1)
        Me.UsersList.Controls.Add(Me.Button2, 1, 2)
        Me.UsersList.Controls.Add(Me.Button4, 2, 0)
        Me.UsersList.Controls.Add(Me.DeactivateUser, 2, 1)
        Me.UsersList.Controls.Add(Me.Button5, 2, 2)
        Me.UsersList.Controls.Add(Me.Button6, 2, 3)
        Me.UsersList.Controls.Add(Me.Button3, 1, 3)
        Me.UsersList.Controls.Add(Me.Button7, 1, 4)
        Me.UsersList.Controls.Add(Me.Button8, 2, 4)
        Me.UsersList.Location = New System.Drawing.Point(122, 195)
        Me.UsersList.Margin = New System.Windows.Forms.Padding(2)
        Me.UsersList.Name = "UsersList"
        Me.UsersList.RowCount = 5
        Me.UsersList.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.UsersList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.UsersList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.UsersList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.UsersList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.UsersList.Size = New System.Drawing.Size(386, 180)
        Me.UsersList.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(229, 34)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 32)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "EDIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(229, 73)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 32)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "EDIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(285, 2)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 28)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "DEACTIVATE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(285, 73)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 32)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "DEACTIVATE"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(285, 110)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(94, 32)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "DEACTIVATE"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(229, 110)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 32)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "EDIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(229, 147)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(52, 30)
        Me.Button7.TabIndex = 27
        Me.Button7.Text = "EDIT"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(285, 147)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(94, 30)
        Me.Button8.TabIndex = 28
        Me.Button8.Text = "DEACTIVATE"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'SearchBox
        '
        Me.SearchBox.BackColor = System.Drawing.Color.White
        Me.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.SearchBox.Location = New System.Drawing.Point(466, 136)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(142, 26)
        Me.SearchBox.TabIndex = 22
        Me.SearchBox.Text = "Search here"
        Me.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(510, 195)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(27, 180)
        Me.VScrollBar1.TabIndex = 23
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(33, 71)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(198, 35)
        Me.Button9.TabIndex = 24
        Me.Button9.TabStop = False
        Me.Button9.Text = "SUSPEND CLASSES"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'ManageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.Home
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.UsersList)
        Me.Controls.Add(Me.AddUser)
        Me.Controls.Add(Me.LogOut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Minimize)
        Me.Controls.Add(Me.CloseButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(640, 480)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "ManageUsers"
        Me.Text = " "
        Me.UsersList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minimize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents LogOut As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AddUser As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeactivateUser As Button
    Friend WithEvents UsersList As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Button9 As Button
End Class

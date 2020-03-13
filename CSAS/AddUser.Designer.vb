<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUser
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
        Me.Newp = New System.Windows.Forms.TextBox()
        Me.UNtext = New System.Windows.Forms.TextBox()
        Me.CpTxt = New System.Windows.Forms.TextBox()
        Me.LNtext = New System.Windows.Forms.TextBox()
        Me.FNtext = New System.Windows.Forms.TextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SklTxt = New System.Windows.Forms.TextBox()
        Me.lvlTxt = New System.Windows.Forms.TextBox()
        Me.RegTxt = New System.Windows.Forms.TextBox()
        Me.ProvTxt = New System.Windows.Forms.TextBox()
        Me.CityTxt = New System.Windows.Forms.TextBox()
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
        Me.Minimize.Location = New System.Drawing.Point(427, 6)
        Me.Minimize.MaximumSize = New System.Drawing.Size(20, 20)
        Me.Minimize.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Minimize.Name = "Minimize"
        Me.Minimize.Size = New System.Drawing.Size(20, 20)
        Me.Minimize.TabIndex = 5
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
        Me.CloseButton.Location = New System.Drawing.Point(464, 6)
        Me.CloseButton.MaximumSize = New System.Drawing.Size(20, 20)
        Me.CloseButton.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(20, 20)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Newp
        '
        Me.Newp.BackColor = System.Drawing.Color.White
        Me.Newp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Newp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Newp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Newp.Location = New System.Drawing.Point(93, 283)
        Me.Newp.Name = "Newp"
        Me.Newp.Size = New System.Drawing.Size(304, 26)
        Me.Newp.TabIndex = 28
        Me.Newp.Text = "New Password"
        Me.Newp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UNtext
        '
        Me.UNtext.BackColor = System.Drawing.Color.White
        Me.UNtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UNtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UNtext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.UNtext.Location = New System.Drawing.Point(93, 246)
        Me.UNtext.Name = "UNtext"
        Me.UNtext.Size = New System.Drawing.Size(304, 26)
        Me.UNtext.TabIndex = 23
        Me.UNtext.Text = "Username"
        Me.UNtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CpTxt
        '
        Me.CpTxt.BackColor = System.Drawing.Color.White
        Me.CpTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CpTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.CpTxt.Location = New System.Drawing.Point(93, 100)
        Me.CpTxt.Name = "CpTxt"
        Me.CpTxt.Size = New System.Drawing.Size(304, 26)
        Me.CpTxt.TabIndex = 22
        Me.CpTxt.Text = "Phone Number"
        Me.CpTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LNtext
        '
        Me.LNtext.BackColor = System.Drawing.Color.White
        Me.LNtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LNtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNtext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.LNtext.Location = New System.Drawing.Point(255, 63)
        Me.LNtext.Name = "LNtext"
        Me.LNtext.Size = New System.Drawing.Size(142, 26)
        Me.LNtext.TabIndex = 21
        Me.LNtext.Text = "Last Name"
        Me.LNtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FNtext
        '
        Me.FNtext.BackColor = System.Drawing.Color.White
        Me.FNtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FNtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNtext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.FNtext.Location = New System.Drawing.Point(93, 63)
        Me.FNtext.Name = "FNtext"
        Me.FNtext.Size = New System.Drawing.Size(142, 26)
        Me.FNtext.TabIndex = 20
        Me.FNtext.Text = "First Name"
        Me.FNtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddBtn.FlatAppearance.BorderSize = 0
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.AddBtn.Location = New System.Drawing.Point(284, 329)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(112, 35)
        Me.AddBtn.TabIndex = 31
        Me.AddBtn.Text = "UPDATE"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Brown
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(93, 329)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SklTxt
        '
        Me.SklTxt.BackColor = System.Drawing.Color.White
        Me.SklTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SklTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SklTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.SklTxt.Location = New System.Drawing.Point(94, 174)
        Me.SklTxt.Name = "SklTxt"
        Me.SklTxt.Size = New System.Drawing.Size(304, 26)
        Me.SklTxt.TabIndex = 33
        Me.SklTxt.Text = "School"
        Me.SklTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lvlTxt
        '
        Me.lvlTxt.BackColor = System.Drawing.Color.White
        Me.lvlTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvlTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lvlTxt.Location = New System.Drawing.Point(94, 211)
        Me.lvlTxt.Name = "lvlTxt"
        Me.lvlTxt.Size = New System.Drawing.Size(304, 26)
        Me.lvlTxt.TabIndex = 34
        Me.lvlTxt.Text = "School Level"
        Me.lvlTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RegTxt
        '
        Me.RegTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.RegTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.RegTxt.Location = New System.Drawing.Point(93, 136)
        Me.RegTxt.Name = "RegTxt"
        Me.RegTxt.Size = New System.Drawing.Size(100, 24)
        Me.RegTxt.TabIndex = 35
        Me.RegTxt.Text = "Region"
        Me.RegTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProvTxt
        '
        Me.ProvTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ProvTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ProvTxt.Location = New System.Drawing.Point(199, 136)
        Me.ProvTxt.Name = "ProvTxt"
        Me.ProvTxt.Size = New System.Drawing.Size(100, 24)
        Me.ProvTxt.TabIndex = 36
        Me.ProvTxt.Text = "Province"
        Me.ProvTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CityTxt
        '
        Me.CityTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.CityTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.CityTxt.Location = New System.Drawing.Point(305, 136)
        Me.CityTxt.Name = "CityTxt"
        Me.CityTxt.Size = New System.Drawing.Size(92, 24)
        Me.CityTxt.TabIndex = 37
        Me.CityTxt.Text = "City"
        Me.CityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.PopUp1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(490, 418)
        Me.Controls.Add(Me.CityTxt)
        Me.Controls.Add(Me.ProvTxt)
        Me.Controls.Add(Me.RegTxt)
        Me.Controls.Add(Me.lvlTxt)
        Me.Controls.Add(Me.SklTxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.Newp)
        Me.Controls.Add(Me.UNtext)
        Me.Controls.Add(Me.CpTxt)
        Me.Controls.Add(Me.LNtext)
        Me.Controls.Add(Me.FNtext)
        Me.Controls.Add(Me.Minimize)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(490, 418)
        Me.MinimumSize = New System.Drawing.Size(490, 418)
        Me.Name = "AddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minimize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents Newp As TextBox
    Friend WithEvents UNtext As TextBox
    Friend WithEvents CpTxt As TextBox
    Friend WithEvents LNtext As TextBox
    Friend WithEvents FNtext As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SklTxt As TextBox
    Friend WithEvents lvlTxt As TextBox
    Friend WithEvents RegTxt As TextBox
    Friend WithEvents ProvTxt As TextBox
    Friend WithEvents CityTxt As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class School
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CancellButton = New System.Windows.Forms.Button()
        Me.LevelLabel = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeLabel = New System.Windows.Forms.Label()
        Me.SchoolLabel = New System.Windows.Forms.Label()
        Me.SklCombo = New System.Windows.Forms.ComboBox()
        Me.sklLvlCombo = New System.Windows.Forms.ComboBox()
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
        Me.Minimize.Location = New System.Drawing.Point(427, 6)
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
        Me.CloseButton.Location = New System.Drawing.Point(464, 6)
        Me.CloseButton.MaximumSize = New System.Drawing.Size(20, 20)
        Me.CloseButton.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(20, 20)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(53, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Suspend Classes for:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(267, 311)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "SUSPEND"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CancellButton
        '
        Me.CancellButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CancellButton.Location = New System.Drawing.Point(152, 311)
        Me.CancellButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CancellButton.Name = "CancellButton"
        Me.CancellButton.Size = New System.Drawing.Size(75, 37)
        Me.CancellButton.TabIndex = 29
        Me.CancellButton.Text = "CANCEL"
        Me.CancellButton.UseVisualStyleBackColor = True
        '
        'LevelLabel
        '
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.BackColor = System.Drawing.Color.Transparent
        Me.LevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelLabel.ForeColor = System.Drawing.Color.Black
        Me.LevelLabel.Location = New System.Drawing.Point(83, 160)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(118, 22)
        Me.LevelLabel.TabIndex = 27
        Me.LevelLabel.Text = "School Level:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(87, 260)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(317, 24)
        Me.DateTimePicker1.TabIndex = 26
        '
        'DateTimeLabel
        '
        Me.DateTimeLabel.AutoSize = True
        Me.DateTimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.DateTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeLabel.ForeColor = System.Drawing.Color.Black
        Me.DateTimeLabel.Location = New System.Drawing.Point(83, 232)
        Me.DateTimeLabel.Name = "DateTimeLabel"
        Me.DateTimeLabel.Size = New System.Drawing.Size(133, 22)
        Me.DateTimeLabel.TabIndex = 24
        Me.DateTimeLabel.Text = "Date and Time:"
        '
        'SchoolLabel
        '
        Me.SchoolLabel.AutoSize = True
        Me.SchoolLabel.BackColor = System.Drawing.Color.Transparent
        Me.SchoolLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolLabel.ForeColor = System.Drawing.Color.Black
        Me.SchoolLabel.Location = New System.Drawing.Point(83, 89)
        Me.SchoolLabel.Name = "SchoolLabel"
        Me.SchoolLabel.Size = New System.Drawing.Size(70, 22)
        Me.SchoolLabel.TabIndex = 23
        Me.SchoolLabel.Text = "School:"
        '
        'SklCombo
        '
        Me.SklCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.SklCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.SklCombo.FormattingEnabled = True
        Me.SklCombo.Location = New System.Drawing.Point(87, 125)
        Me.SklCombo.Name = "SklCombo"
        Me.SklCombo.Size = New System.Drawing.Size(317, 28)
        Me.SklCombo.TabIndex = 33
        Me.SklCombo.Text = "School"
        '
        'sklLvlCombo
        '
        Me.sklLvlCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.sklLvlCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.sklLvlCombo.FormattingEnabled = True
        Me.sklLvlCombo.Location = New System.Drawing.Point(87, 191)
        Me.sklLvlCombo.Name = "sklLvlCombo"
        Me.sklLvlCombo.Size = New System.Drawing.Size(317, 28)
        Me.sklLvlCombo.TabIndex = 34
        Me.sklLvlCombo.Text = "School Level"
        '
        'School
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.PopUp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(490, 399)
        Me.Controls.Add(Me.sklLvlCombo)
        Me.Controls.Add(Me.SklCombo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CancellButton)
        Me.Controls.Add(Me.LevelLabel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DateTimeLabel)
        Me.Controls.Add(Me.SchoolLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Minimize)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(490, 399)
        Me.MinimumSize = New System.Drawing.Size(490, 399)
        Me.Name = "School"
        Me.Text = "SchoolPopUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minimize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CancellButton As Button
    Friend WithEvents LevelLabel As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimeLabel As Label
    Friend WithEvents SchoolLabel As Label
    Friend WithEvents SklCombo As ComboBox
    Friend WithEvents sklLvlCombo As ComboBox
End Class

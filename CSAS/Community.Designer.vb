<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Community
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Community))
        Me.Minimize = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SchoolLevel = New System.Windows.Forms.ComboBox()
        Me.LevelLabel = New System.Windows.Forms.Label()
        Me.ProvCombo = New System.Windows.Forms.ComboBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CancellButton = New System.Windows.Forms.Button()
        Me.CityCombo = New System.Windows.Forms.ComboBox()
        Me.ProvinceLabel = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RegionCombo = New System.Windows.Forms.ComboBox()
        Me.DateTimeLabel = New System.Windows.Forms.Label()
        Me.RegionLabel = New System.Windows.Forms.Label()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(52, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 22)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Suspend Classes for:"
        '
        'SchoolLevel
        '
        Me.SchoolLevel.BackColor = System.Drawing.Color.White
        Me.SchoolLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.SchoolLevel.FormattingEnabled = True
        Me.SchoolLevel.Location = New System.Drawing.Point(88, 233)
        Me.SchoolLevel.Name = "SchoolLevel"
        Me.SchoolLevel.Size = New System.Drawing.Size(317, 26)
        Me.SchoolLevel.TabIndex = 40
        Me.SchoolLevel.Text = " School Level"
        '
        'LevelLabel
        '
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.BackColor = System.Drawing.Color.Transparent
        Me.LevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelLabel.ForeColor = System.Drawing.Color.Black
        Me.LevelLabel.Location = New System.Drawing.Point(85, 206)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(118, 22)
        Me.LevelLabel.TabIndex = 39
        Me.LevelLabel.Text = "School Level:"
        '
        'ProvCombo
        '
        Me.ProvCombo.BackColor = System.Drawing.Color.White
        Me.ProvCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ProvCombo.FormattingEnabled = True
        Me.ProvCombo.Location = New System.Drawing.Point(224, 107)
        Me.ProvCombo.Name = "ProvCombo"
        Me.ProvCombo.Size = New System.Drawing.Size(180, 26)
        Me.ProvCombo.TabIndex = 38
        Me.ProvCombo.Text = " Province"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.BackColor = System.Drawing.Color.Transparent
        Me.CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityLabel.ForeColor = System.Drawing.Color.Black
        Me.CityLabel.Location = New System.Drawing.Point(85, 142)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(46, 22)
        Me.CityLabel.TabIndex = 37
        Me.CityLabel.Text = "City:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(268, 336)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 32)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "SUSPEND"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CancellButton
        '
        Me.CancellButton.BackColor = System.Drawing.Color.Brown
        Me.CancellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancellButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.CancellButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.CancellButton.Location = New System.Drawing.Point(138, 336)
        Me.CancellButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CancellButton.Name = "CancellButton"
        Me.CancellButton.Size = New System.Drawing.Size(90, 32)
        Me.CancellButton.TabIndex = 35
        Me.CancellButton.Text = "CANCEL"
        Me.CancellButton.UseVisualStyleBackColor = False
        '
        'CityCombo
        '
        Me.CityCombo.BackColor = System.Drawing.Color.White
        Me.CityCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.CityCombo.FormattingEnabled = True
        Me.CityCombo.Location = New System.Drawing.Point(88, 168)
        Me.CityCombo.Name = "CityCombo"
        Me.CityCombo.Size = New System.Drawing.Size(316, 26)
        Me.CityCombo.TabIndex = 34
        Me.CityCombo.Text = " City"
        '
        'ProvinceLabel
        '
        Me.ProvinceLabel.AutoSize = True
        Me.ProvinceLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProvinceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinceLabel.ForeColor = System.Drawing.Color.Black
        Me.ProvinceLabel.Location = New System.Drawing.Point(221, 80)
        Me.ProvinceLabel.Name = "ProvinceLabel"
        Me.ProvinceLabel.Size = New System.Drawing.Size(85, 22)
        Me.ProvinceLabel.TabIndex = 33
        Me.ProvinceLabel.Text = "Province:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(88, 296)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(317, 24)
        Me.DateTimePicker1.TabIndex = 32
        '
        'RegionCombo
        '
        Me.RegionCombo.BackColor = System.Drawing.Color.White
        Me.RegionCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.RegionCombo.FormattingEnabled = True
        Me.RegionCombo.Location = New System.Drawing.Point(88, 107)
        Me.RegionCombo.Name = "RegionCombo"
        Me.RegionCombo.Size = New System.Drawing.Size(104, 26)
        Me.RegionCombo.TabIndex = 31
        Me.RegionCombo.Text = " Region"
        '
        'DateTimeLabel
        '
        Me.DateTimeLabel.AutoSize = True
        Me.DateTimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.DateTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeLabel.ForeColor = System.Drawing.Color.Black
        Me.DateTimeLabel.Location = New System.Drawing.Point(85, 268)
        Me.DateTimeLabel.Name = "DateTimeLabel"
        Me.DateTimeLabel.Size = New System.Drawing.Size(133, 22)
        Me.DateTimeLabel.TabIndex = 30
        Me.DateTimeLabel.Text = "Date and Time:"
        '
        'RegionLabel
        '
        Me.RegionLabel.AutoSize = True
        Me.RegionLabel.BackColor = System.Drawing.Color.Transparent
        Me.RegionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionLabel.ForeColor = System.Drawing.Color.Black
        Me.RegionLabel.Location = New System.Drawing.Point(85, 80)
        Me.RegionLabel.Name = "RegionLabel"
        Me.RegionLabel.Size = New System.Drawing.Size(72, 22)
        Me.RegionLabel.TabIndex = 29
        Me.RegionLabel.Text = "Region:"
        '
        'Community
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.PopUp1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(491, 418)
        Me.Controls.Add(Me.SchoolLevel)
        Me.Controls.Add(Me.LevelLabel)
        Me.Controls.Add(Me.ProvCombo)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CancellButton)
        Me.Controls.Add(Me.CityCombo)
        Me.Controls.Add(Me.ProvinceLabel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.RegionCombo)
        Me.Controls.Add(Me.DateTimeLabel)
        Me.Controls.Add(Me.RegionLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Minimize)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(491, 418)
        Me.MinimumSize = New System.Drawing.Size(491, 418)
        Me.Name = "Community"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Community"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minimize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SchoolLevel As ComboBox
    Friend WithEvents LevelLabel As Label
    Friend WithEvents ProvCombo As ComboBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CancellButton As Button
    Friend WithEvents CityCombo As ComboBox
    Friend WithEvents ProvinceLabel As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RegionCombo As ComboBox
    Friend WithEvents DateTimeLabel As Label
    Friend WithEvents RegionLabel As Label
End Class

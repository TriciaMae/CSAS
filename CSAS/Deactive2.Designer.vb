<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deactive2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.yesBtn = New System.Windows.Forms.Button()
        Me.noBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.youSure = New System.Windows.Forms.Label()
        Me.Minimize = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'yesBtn
        '
        Me.yesBtn.BackColor = System.Drawing.Color.Brown
        Me.yesBtn.FlatAppearance.BorderSize = 0
        Me.yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yesBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yesBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.yesBtn.Location = New System.Drawing.Point(51, 134)
        Me.yesBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.yesBtn.Name = "yesBtn"
        Me.yesBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.yesBtn.Size = New System.Drawing.Size(90, 35)
        Me.yesBtn.TabIndex = 38
        Me.yesBtn.Text = "YES"
        Me.yesBtn.UseVisualStyleBackColor = False
        '
        'noBtn
        '
        Me.noBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.noBtn.FlatAppearance.BorderSize = 0
        Me.noBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.noBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.noBtn.Location = New System.Drawing.Point(174, 134)
        Me.noBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.noBtn.Name = "noBtn"
        Me.noBtn.Size = New System.Drawing.Size(90, 35)
        Me.noBtn.TabIndex = 37
        Me.noBtn.Text = "NO"
        Me.noBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(49, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 22)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "deactivate this user account?"
        '
        'youSure
        '
        Me.youSure.AutoSize = True
        Me.youSure.BackColor = System.Drawing.Color.Transparent
        Me.youSure.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.youSure.ForeColor = System.Drawing.Color.Black
        Me.youSure.Location = New System.Drawing.Point(67, 49)
        Me.youSure.Name = "youSure"
        Me.youSure.Size = New System.Drawing.Size(209, 22)
        Me.youSure.TabIndex = 35
        Me.youSure.Text = "Are you sure you want to"
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
        Me.Minimize.Location = New System.Drawing.Point(296, 1)
        Me.Minimize.Margin = New System.Windows.Forms.Padding(1)
        Me.Minimize.MaximumSize = New System.Drawing.Size(14, 15)
        Me.Minimize.MinimumSize = New System.Drawing.Size(14, 15)
        Me.Minimize.Name = "Minimize"
        Me.Minimize.Size = New System.Drawing.Size(14, 15)
        Me.Minimize.TabIndex = 40
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
        Me.CloseButton.Location = New System.Drawing.Point(322, 2)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(1)
        Me.CloseButton.MaximumSize = New System.Drawing.Size(14, 15)
        Me.CloseButton.MinimumSize = New System.Drawing.Size(14, 15)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(14, 15)
        Me.CloseButton.TabIndex = 39
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Deactivate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSAS.My.Resources.Resources.PopUp1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 219)
        Me.Controls.Add(Me.Minimize)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.yesBtn)
        Me.Controls.Add(Me.noBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.youSure)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(340, 219)
        Me.MinimumSize = New System.Drawing.Size(340, 219)
        Me.Name = "Deactivate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deactivate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents yesBtn As Button
    Friend WithEvents noBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents youSure As Label
    Friend WithEvents Minimize As Button
    Friend WithEvents CloseButton As Button
End Class

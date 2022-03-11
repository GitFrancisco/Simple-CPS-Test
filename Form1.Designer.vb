<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ClickButton = New System.Windows.Forms.Button()
        Me.TB_Clicks = New System.Windows.Forms.TextBox()
        Me.T_TimerLeft = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_TimeLeft = New System.Windows.Forms.TextBox()
        Me.T_Function = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_CurrentSpeed = New System.Windows.Forms.TextBox()
        Me.T_CurrentSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ClickButton
        '
        Me.ClickButton.BackColor = System.Drawing.Color.Lavender
        Me.ClickButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClickButton.Location = New System.Drawing.Point(75, 139)
        Me.ClickButton.Name = "ClickButton"
        Me.ClickButton.Size = New System.Drawing.Size(215, 66)
        Me.ClickButton.TabIndex = 0
        Me.ClickButton.Text = "Click Here!"
        Me.ClickButton.UseVisualStyleBackColor = False
        '
        'TB_Clicks
        '
        Me.TB_Clicks.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.TB_Clicks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Clicks.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Clicks.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_Clicks.Location = New System.Drawing.Point(36, 48)
        Me.TB_Clicks.Name = "TB_Clicks"
        Me.TB_Clicks.ReadOnly = True
        Me.TB_Clicks.Size = New System.Drawing.Size(299, 58)
        Me.TB_Clicks.TabIndex = 1
        Me.TB_Clicks.Text = "0"
        Me.TB_Clicks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TB_Clicks.WordWrap = False
        '
        'T_TimerLeft
        '
        Me.T_TimerLeft.Interval = 10000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Time left: (seconds)"
        '
        'TB_TimeLeft
        '
        Me.TB_TimeLeft.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.TB_TimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_TimeLeft.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_TimeLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_TimeLeft.Location = New System.Drawing.Point(12, 35)
        Me.TB_TimeLeft.Name = "TB_TimeLeft"
        Me.TB_TimeLeft.ReadOnly = True
        Me.TB_TimeLeft.Size = New System.Drawing.Size(72, 29)
        Me.TB_TimeLeft.TabIndex = 3
        Me.TB_TimeLeft.Text = "10"
        Me.TB_TimeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TB_TimeLeft.WordWrap = False
        '
        'T_Function
        '
        Me.T_Function.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(154, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Clicks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(222, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Current Speed: (CPS)"
        '
        'TB_CurrentSpeed
        '
        Me.TB_CurrentSpeed.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.TB_CurrentSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_CurrentSpeed.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_CurrentSpeed.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TB_CurrentSpeed.Location = New System.Drawing.Point(263, 35)
        Me.TB_CurrentSpeed.Name = "TB_CurrentSpeed"
        Me.TB_CurrentSpeed.ReadOnly = True
        Me.TB_CurrentSpeed.Size = New System.Drawing.Size(72, 29)
        Me.TB_CurrentSpeed.TabIndex = 6
        Me.TB_CurrentSpeed.Text = "0"
        Me.TB_CurrentSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TB_CurrentSpeed.WordWrap = False
        '
        'T_CurrentSpeed
        '
        Me.T_CurrentSpeed.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(368, 233)
        Me.Controls.Add(Me.TB_CurrentSpeed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_TimeLeft)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_Clicks)
        Me.Controls.Add(Me.ClickButton)
        Me.Name = "Form1"
        Me.Text = "Simple CPS Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClickButton As Button
    Friend WithEvents TB_Clicks As TextBox
    Friend WithEvents T_TimerLeft As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_TimeLeft As TextBox
    Friend WithEvents T_Function As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_CurrentSpeed As TextBox
    Friend WithEvents T_CurrentSpeed As Timer
End Class

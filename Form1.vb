Public Class Form1
    Dim ClickCount As Integer
    Dim TimeLeft As String
    Dim CurrentSpeed As Integer


    Private Sub ClickButton_Click(sender As Object, e As EventArgs) Handles ClickButton.Click
        If ClickCount = 0 Then
            T_TimerLeft.Enabled = True
            T_Function.Enabled = True
            T_CurrentSpeed.Enabled = True
        End If

        ClickCount += 1
        TB_Clicks.Text = ClickCount
        CurrentSpeed += 1

    End Sub

    Private Sub T_TimerLeft_Tick(sender As Object, e As EventArgs) Handles T_TimerLeft.Tick
        T_TimerLeft.Enabled = False
        T_Function.Enabled = False
        T_CurrentSpeed.Enabled = False
        MsgBox("Your clicking speed was " & ClickCount / 10 & " CPS", 0, "Test Result")
        TB_Clicks.Text = 0
        ClickCount = 0
        TB_TimeLeft.Text = "10"
        TB_CurrentSpeed.Text = "0"
    End Sub

    Private Sub T_Function_Tick(sender As Object, e As EventArgs) Handles T_Function.Tick
        TB_TimeLeft.Text = TB_TimeLeft.Text - 1
        CurrentSpeed = 0
    End Sub

    Private Sub T_CurrentSpeed_Tick(sender As Object, e As EventArgs) Handles T_CurrentSpeed.Tick
        TB_CurrentSpeed.Text = CurrentSpeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class

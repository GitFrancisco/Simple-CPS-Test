Public Class Form1
    Const CPS_Click As Integer = 1
    Dim CPS_Count As Integer
    Dim Time_Left As String
    Dim CPS_CurrentSpeed As Integer

    Private Sub ClickButton_Click(sender As Object, e As EventArgs) Handles ClickButton.Click
        If CPS_Count <> 0 Then
            CPS_Count = CPS_Count + CPS_Click
            TB_Clicks.Text = CPS_Count
            CPS_CurrentSpeed = CPS_CurrentSpeed + CPS_Click
        ElseIf CPS_Count = 0 Then
            CPS_Count = CPS_Count + CPS_Click
            CPS_CurrentSpeed = CPS_CurrentSpeed + CPS_Click
            TB_Clicks.Text = CPS_Count
            T_TimerLeft.Enabled = True
            T_Function.Enabled = True
            T_CurrentSpeed.Enabled = True
        End If

    End Sub

    Private Sub T_TimerLeft_Tick(sender As Object, e As EventArgs) Handles T_TimerLeft.Tick
        T_TimerLeft.Enabled = False
        T_Function.Enabled = False
        T_CurrentSpeed.Enabled = False
        MsgBox("Your clicking speed was " & CPS_Count / 10 & " CPS", 0, "Test Result")
        TB_Clicks.Text = 0
        CPS_Count = 0
        TB_TimeLeft.Text = "10"
        TB_CurrentSpeed.Text = "0"
    End Sub

    Private Sub T_Function_Tick(sender As Object, e As EventArgs) Handles T_Function.Tick
        TB_TimeLeft.Text = TB_TimeLeft.Text - 1
        CPS_CurrentSpeed = 0
    End Sub

    Private Sub T_CurrentSpeed_Tick(sender As Object, e As EventArgs) Handles T_CurrentSpeed.Tick
        TB_CurrentSpeed.Text = CPS_CurrentSpeed
    End Sub
End Class

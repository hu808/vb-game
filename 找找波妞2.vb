Public Class 找找波妞2
    Dim t1 As Integer = 31 '30秒倒數的計數變數
    Dim i As Integer = 4 '3秒倒數的計數變數
    Dim rand As Integer = 0 '宣告存放亂數結果的變數
    Dim score As Integer = 0 '紀錄第一關分數的變數
    Dim TotalScore As Integer = 0 '紀錄第一關分數的變數
    Dim j As Integer

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer_Start.Enabled = True
        StartLabel.Visible = True
        For j = 1 To 9
            Controls("Pic" & j).Visible = False
            Controls("Box" & j).Visible = False
        Next
    End Sub

    Sub GetPoint()
        score += 50 '點擊成功得分
        PointLabel.Text = Format(score, "00000")
    End Sub

    Private Sub Pic1_Click(sender As Object, e As EventArgs) Handles Pic1.Click
        Pic1.Visible = False
        Box1.Visible = True
        GetPoint()
    End Sub
    Private Sub Pic2_Click(sender As Object, e As EventArgs) Handles Pic2.Click
        Pic2.Visible = False
        Box2.Visible = True
        GetPoint()
    End Sub
    Private Sub Pic3_Click(sender As Object, e As EventArgs) Handles Pic3.Click
        Pic3.Visible = False
        Box3.Visible = True
        GetPoint()
    End Sub
    Private Sub Pic4_Click(sender As Object, e As EventArgs) Handles Pic4.Click
        Pic4.Visible = False
        Box4.Visible = True
        GetPoint()
    End Sub
    Private Sub Pic5_Click(sender As Object, e As EventArgs) Handles Pic5.Click
        Pic5.Visible = False
        Box5.Visible = True
        GetPoint()
    End Sub
    Private Sub Pic6_Click(sender As Object, e As EventArgs) Handles Pic6.Click
        Pic6.Visible = False
        Box6.Visible = True
        GetPoint()
    End Sub
    Private Sub Pic7_Click(sender As Object, e As EventArgs) Handles Pic7.Click
        Pic7.Visible = False
        Box7.Visible = True
        GetPoint()
    End Sub
    Private Sub Pic8_Click(sender As Object, e As EventArgs) Handles Pic8.Click
        Pic8.Visible = False
        Box8.Visible = True
        GetPoint()
    End Sub
    Private Sub Pic9_Click(sender As Object, e As EventArgs) Handles Pic9.Click
        Pic9.Visible = False
        Box9.Visible = True
        GetPoint()
    End Sub

    Private Sub Timer_Start_Tick(sender As Object, e As EventArgs) Handles Timer_Start.Tick
        '按了開始遊戲之後的倒數
        StartLabel.Text = "3"
        i = i - 1
        StartLabel.Text = i

        If i = 0 Then '倒數到零的時候
            StartLabel.Text = "Start!"
            Timer_Start.Enabled = False
            Timer_100.Enabled = True
            Timer_Output.Enabled = True
        End If
    End Sub

    Private Sub Timer_100_Tick(sender As Object, e As EventArgs) Handles Timer_100.Tick
        '30秒倒數計時器
        t1 = t1 - 1
        TimeLabel.Text = Format(t1, "000")
        StartLabel.Visible = False
        If t1 = 0 Then '倒數到零的時候
            If score < 800 Then '倒數到零且挑戰失敗(未達800分)的時候
                Timer_100.Enabled = False
                Timer_Start.Enabled = False
                Timer_Output.Enabled = False
                Timer_Cover.Enabled = False
                MsgBox("挑戰失敗!!" & vbCrLf & "你的得分是" & score, , "進擊的波妞")
                If MsgBox("是否重新開始?", MsgBoxStyle.YesNo, "進擊的波妞") = vbYes Then
                    ReStart()
                Else
                    My.Forms.找找波妞2.Visible = False
                End If

            ElseIf score >= 800 And Timer_Output.Interval = 700 Then '第二關挑戰成功
                Timer_100.Enabled = False
                Timer_Start.Enabled = False
                Timer_Output.Enabled = False
                Timer_Cover.Enabled = False
                TotalScore = TotalScore + score
                If MsgBox("恭喜挑戰成功!!" & vbCrLf & "你的總得分是" & TotalScore, MsgBoxStyle.OkOnly, "進擊的波妞") = 1 Then
                    My.Forms.找找波妞2.Visible = False
                End If

            ElseIf score >= 800 And Timer_Output.Interval <> 700 Then '第一關挑戰800分成功 
                Timer_100.Enabled = False
                Timer_Start.Enabled = False
                Timer_Output.Enabled = False
                Timer_Cover.Enabled = False
                If MsgBox("恭喜挑戰成功!!" & vbCrLf & "是否要晉級?", MsgBoxStyle.YesNo, "進擊的波妞") = vbYes Then
                    TotalScore = TotalScore + score
                    score = 0
                    ReStart()
                    Timer_Output.Interval = 700
                    Timer_Cover.Interval = 700

                Else
                    If MsgBox("是否重新開始?", MsgBoxStyle.YesNo, "進擊的波妞") = vbYes Then
                        ReStart()
                    Else
                        My.Forms.找找波妞2.Visible = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Timer_Output_Tick(sender As Object, e As EventArgs) Handles Timer_Output.Tick
        '每次波妞出現
        Randomize() '初始化亂數產生器
        rand = Int(9 * Rnd()) + 1 '1~9產生一隨機數
        Controls("Pic" & rand).Visible = True
        Timer_Cover.Enabled = True
    End Sub

    Private Sub Timer_Cover_Tick(sender As Object, e As EventArgs) Handles Timer_Cover.Tick
        '波妞出現1秒後，若沒按到，會消失
        If Controls("Pic" & rand).Visible = True Then
            Controls("Pic" & rand).Visible = False
        End If
        For j = 1 To 9
            If Controls("Box" & j).Visible = True Then
                Controls("Box" & j).Visible = False
            End If
        Next
    End Sub

    Sub ReStart()
        score = 0
        PointLabel.Text = Format(score, "00000")
        i = 4
        t1 = 31
        Timer_Start.Enabled = True
        StartLabel.Visible = True
        For j = 1 To 9
            Controls("Pic" & j).Visible = False
            Controls("Pic" & j).Tag = 0
            Controls("Box" & j).Visible = False
        Next
    End Sub
End Class

Public Class 尋親之旅
    Dim count As Integer  '對幾個
    Dim level As Integer = 0 '關卡
    Dim ret
    Sub PlayLoopingBackgroundSoundResource()
        My.Computer.Audio.Play(My.Resources._11, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub 倒數_timer_Tick(sender As Object, e As EventArgs) Handles 倒數_timer.Tick
        倒數_label.Text -= 1 '
        If 倒數_label.Text < 0 Then       '當秒數小於0'
            倒數_timer.Stop()           '計時器停止倒數321'
            倒數_label.Visible = False

            gametime_Timer.Start() '計時器啟動遊戲時間倒數'

            未改_PictureBox.Visible = True
            已改_PictureBox.Visible = True
            error1_Label.Visible = True
            error2_Label.Visible = True
            error3_Label.Visible = True
            error4_Label.Visible = True
            error5_Label.Visible = True


        End If

    End Sub

    Private Sub gametime_Timer_Tick(sender As Object, e As EventArgs) Handles gametime_Timer.Tick
        gametime_label.Text -= 1
        If gametime_label.Text = 0 Then     '當秒數小於0'
            gametime_Timer.Stop()
            ret = MsgBox("時間到了,是否重玩? 是:重玩;否:回遊戲畫面", MsgBoxStyle.YesNo)
            If level = 0 Then
                If ret = MsgBoxResult.Yes Then
                    第一關()
                Else
                    Me.Close()
                    Form1.Visible = True
                End If

            ElseIf level = 1 Then

                If ret = MsgBoxResult.Yes Then
                    第二關()
                Else
                    Me.Close()
                    Form1.Visible = True
                End If

            ElseIf level = 2 Then
                If ret = MsgBoxResult.Yes Then
                    第三關()
                Else
                    Me.Close()
                    Form1.Visible = True
                End If

            ElseIf level = 3 Then
                If ret = MsgBoxResult.Yes Then
                    第四關()
                Else
                    Me.Close()
                    Form1.Visible = True
                End If
            End If
            Else
            If count = 5 Then
                gametime_Timer.Stop()
                level = level + 1
                ret = MsgBox("過關了!!是否前往下一關? 是:前往下一關;否:回遊戲畫面", MsgBoxStyle.YesNo)
                If level = 1 Then
                    If ret = MsgBoxResult.Yes Then
                        第二關()
                    Else
                        Me.Close()
                        Form1.Visible = True
                    End If

                ElseIf level = 2 Then
                    If ret = MsgBoxResult.Yes Then
                        第三關()
                    Else
                        Me.Close()
                        Form1.Visible = True
                    End If

                ElseIf level = 3 Then
                    If ret = MsgBoxResult.Yes Then
                        第四關()
                    Else
                        Me.Close()
                        Form1.Visible = True
                    End If

                ElseIf level = 4 Then
                    MsgBox("成功!!回遊戲畫面", MsgBoxResult.Yes)
                    Me.Close()
                    Form1.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub error1_Label_Click(sender As Object, e As EventArgs) Handles error1_Label.Click
        error1_PictureBox.Visible = True
        error1_Label.Visible = False
        count = count + 1
    End Sub

    Private Sub error2_Label_Click(sender As Object, e As EventArgs) Handles error2_Label.Click
        error2_PictureBox.Visible = True
        error2_Label.Visible = False
        count = count + 1
    End Sub

    Private Sub error3_Label_Click(sender As Object, e As EventArgs) Handles error3_Label.Click
        error3_PictureBox.Visible = True
        error3_Label.Visible = False
        count = count + 1
    End Sub
    Private Sub error4_Label_Click_1(sender As Object, e As EventArgs) Handles error4_Label.Click
        error4_PictureBox.Visible = True
        error4_Label.Visible = False
        count = count + 1
    End Sub

    Private Sub error5_Label_Click(sender As Object, e As EventArgs) Handles error5_Label.Click
        error5_PictureBox.Visible = True
        error5_Label.Visible = False
        count = count + 1
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Visible = False
        PlayLoopingBackgroundSoundResource()
    End Sub
    Sub reset()         'reset'
        未改_PictureBox.Visible = False
        已改_PictureBox.Visible = False
        倒數_label.Visible = True
        倒數_label.Text = 3
        gametime_label.Text = 60
        count = 0
        倒數_timer.Start()
        error1_Label.Visible = False
        error2_Label.Visible = False
        error3_Label.Visible = False
        error4_Label.Visible = False
        error5_Label.Visible = False

        error1_PictureBox.Visible = False
        error2_PictureBox.Visible = False
        error3_PictureBox.Visible = False
        error4_PictureBox.Visible = False
        error5_PictureBox.Visible = False
    End Sub
    Sub 第一關()
        level = 0
        未改_PictureBox.Image = My.Resources.未改
        已改_PictureBox.Image = My.Resources.已改


        error1_Label.Image = My.Resources._千01
        error1_Label.Location = New Point(555, 186)
        error1_Label.Size = My.Resources._千01.Size
        error1_PictureBox.Image = My.Resources._千01_1
        error1_PictureBox.Location = New Point(527, 166)

        error2_Label.Image = My.Resources._千02
        error2_Label.Location = New Point(623, 334)
        error2_Label.Size = My.Resources._千02.Size
        error2_PictureBox.Image = My.Resources._千02_1
        error2_PictureBox.Location = New Point(622, 322)

        error3_Label.Image = My.Resources._千03
        error3_Label.Location = New Point(845, 99)
        error3_Label.Size = My.Resources._千03.Size
        error3_PictureBox.Image = My.Resources._千03_1
        error3_PictureBox.Location = New Point(822, 74)

        error4_Label.Image = My.Resources._千04
        error4_Label.Location = New Point(677, 319)
        error4_Label.Size = My.Resources._千04.Size
        error4_PictureBox.Image = My.Resources._千04_1
        error4_PictureBox.Location = New Point(667, 306)

        error5_Label.Image = My.Resources._千05
        error5_Label.Location = New Point(573, 81)
        error5_Label.Size = My.Resources._千05.Size
        error5_PictureBox.Image = My.Resources._千05_1
        error5_PictureBox.Location = New Point(549, 66)
        reset()
    End Sub
    Sub 第二關()
        level = 1
        未改_PictureBox.Image = My.Resources.未改2
        已改_PictureBox.Image = My.Resources.已改2


        error1_Label.Image = My.Resources._千06
        error1_Label.Location = New Point(864, 74)
        error1_Label.Size = My.Resources._千06.Size
        error1_PictureBox.Image = My.Resources._千06_1
        error1_PictureBox.Location = New Point(864, 66)

        error2_Label.Image = My.Resources._千07
        error2_Label.Location = New Point(834, 256)
        error2_Label.Size = My.Resources._千07.Size
        error2_PictureBox.Image = My.Resources._千07_1
        error2_PictureBox.Location = New Point(820, 256)

        error3_Label.Image = My.Resources._千08
        error3_Label.Location = New Point(834, 356)
        error3_Label.Size = My.Resources._千08.Size
        error3_PictureBox.Image = My.Resources._千08_1
        error3_PictureBox.Location = New Point(832, 351)

        error4_Label.Image = My.Resources._千09
        error4_Label.Location = New Point(788, 106)
        error4_Label.Size = My.Resources._千09.Size
        error4_PictureBox.Image = My.Resources._千09_1
        error4_PictureBox.Location = New Point(772, 100)

        error5_Label.Image = My.Resources._千10
        error5_Label.Location = New Point(610, 405)
        error5_Label.Size = My.Resources._千10.Size
        error5_PictureBox.Image = My.Resources._千10_1
        error5_PictureBox.Location = New Point(603, 397)
        reset()
    End Sub
    Sub 第三關()
        level = 2
        未改_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        已改_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        未改_PictureBox.Image = My.Resources.未改7
        已改_PictureBox.Image = My.Resources.已改7


        error1_Label.Image = My.Resources._千11
        error1_Label.Location = New Point(834, 126)
        error1_Label.Size = My.Resources._千11.Size
        error1_PictureBox.Image = My.Resources._千11_1
        error1_PictureBox.Location = New Point(824, 120)

        error2_Label.Image = My.Resources._千12
        error2_Label.Location = New Point(818, 248)
        error2_Label.Size = My.Resources._千12.Size
        error2_PictureBox.Image = My.Resources._千12_1
        error2_PictureBox.Location = New Point(804, 241)

        error3_Label.Image = My.Resources._千13
        error3_Label.Location = New Point(619, 346)
        error3_Label.Size = My.Resources._千13.Size
        error3_PictureBox.Image = My.Resources._千13_1
        error3_PictureBox.Location = New Point(605, 335)

        error4_Label.Image = My.Resources._千14
        error4_Label.Location = New Point(919, 356)
        error4_Label.Size = My.Resources._千14.Size
        error4_PictureBox.Image = My.Resources._千14_1
        error4_PictureBox.Location = New Point(909, 351)

        error5_Label.Image = My.Resources._千15
        error5_Label.Location = New Point(625, 108)
        error5_Label.Size = My.Resources._千15.Size
        error5_PictureBox.Image = My.Resources._千15_1
        error5_PictureBox.Location = New Point(624, 101)
        reset()
    End Sub
    Sub 第四關()
        level = 3
        未改_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        已改_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        未改_PictureBox.Image = My.Resources.未改3
        已改_PictureBox.Image = My.Resources.已改3


        error1_Label.Image = My.Resources._千16
        error1_Label.Location = New Point(756, 410)
        error1_Label.Size = My.Resources._千16.Size
        error1_PictureBox.Image = My.Resources._千16_1
        error1_PictureBox.Location = New Point(749, 406)

        error2_Label.Image = My.Resources._千17
        error2_Label.Location = New Point(662, 161)
        error2_Label.Size = My.Resources._千17.Size
        error2_PictureBox.Image = My.Resources._千17_1
        error2_PictureBox.Location = New Point(652, 157)

        error3_Label.Image = My.Resources._千18
        error3_Label.Location = New Point(731, 329)
        error3_Label.Size = My.Resources._千18.Size
        error3_PictureBox.Image = My.Resources._千18_1
        error3_PictureBox.Location = New Point(725, 319)

        error4_Label.Image = My.Resources._千19
        error4_Label.Location = New Point(823, 191)
        error4_Label.Size = My.Resources._千19.Size
        error4_PictureBox.Image = My.Resources._千19_1
        error4_PictureBox.Location = New Point(816, 186)

        error5_Label.Image = My.Resources._千20
        error5_Label.Location = New Point(522, 289)
        error5_Label.Size = My.Resources._千20.Size
        error5_PictureBox.Image = My.Resources._千20_1
        error5_PictureBox.Location = New Point(513, 288)
        reset()
    End Sub

    Private Sub 尋親之旅_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Computer.Audio.Stop()
    End Sub
End Class
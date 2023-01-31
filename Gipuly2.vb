Public Class Gipuly2

    Dim count As Integer = 0     '計數器
    Dim score As Integer = 0     '成績
    Dim time As Integer = 90     '倒數時間


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case count
            Case 0
                check(RadioButton2)
            Case 1
                check(RadioButton1)
            Case 2
                check(RadioButton3)
            Case 3
                check(RadioButton4)
            Case 4
                check(RadioButton1)
            Case 5
                check(RadioButton2)
            Case 6
                check(RadioButton3)
            Case 7
                check(RadioButton3)
            Case 8
                check(RadioButton4)
            Case 9
                check(RadioButton1)
        End Select
    End Sub

    Sub labeltext()    '問答題題目
        Select Case count
            Case 1
                Label1.Text = "《崖上的波妞》中波妞特別喜歡吃哪一種食物？"
                RadioButton1.Text = "火腿"
                RadioButton2.Text = "魚肉"
                RadioButton3.Text = "吐司"
                RadioButton4.Text = "人肉"

            Case 2
                Label1.Text = "《霍爾的移動城堡》中女主角蘇菲經營的店鋪是？"
                RadioButton1.Text = "鞋店"
                RadioButton2.Text = "服飾店"
                RadioButton3.Text = "帽子店"
                RadioButton4.Text = "麵包店"

            Case 3
                Label1.Text = "《心之谷》中女主角月島雫所唱，男主角天澤聖司伴奏的主題曲改編自哪首經典英文老歌？"
                RadioButton1.Text = "Shape of you"
                RadioButton2.Text = "The Rose"
                RadioButton3.Text = "Yesterday"
                RadioButton4.Text = "Take Me Home, Country Roads"

            Case 4
                Label1.Text = "《神隱少女》中無臉男暴走的關鍵原因為何？"
                RadioButton1.Text = "女主角小千不接受他贈與的金子"
                RadioButton2.Text = "女主角小千拒絕了他的告白"
                RadioButton3.Text = "湯屋員工不願意給他食物吃"
                RadioButton4.Text = "男主角白龍摘下了他的面具"

            Case 5
                Label1.Text = "哪一部作品是吉卜力工作室成立後的第一部作品？"
                RadioButton1.Text = "《風之谷》"
                RadioButton2.Text = "《天空之城》"
                RadioButton3.Text = "《魔女宅急便》"
                RadioButton4.Text = "《瘋狂麥斯：憤怒道》"

            Case 6
                Label1.Text = "《神隱少女》中的男主角的名字叫什麼？"
                RadioButton1.Text = "乾龍"
                RadioButton2.Text = "青眼白龍"
                RadioButton3.Text = "白龍"
                RadioButton4.Text = "吳奇隆"

            Case 7
                Label1.Text = "《紅豬》的男主角波魯克羅素是？"
                RadioButton1.Text = "一頭豬"
                RadioButton2.Text = "一個人"
                RadioButton3.Text = "一個被變成豬的人"
                RadioButton4.Text = "一頭被變成人的豬"

            Case 8
                Label1.Text = "《風起》中男主角堀越二郎的夢想是成為？"
                RadioButton1.Text = "飛行員"
                RadioButton2.Text = "列車長"
                RadioButton3.Text = "建築設計師"
                RadioButton4.Text = "飛機設計師"

            Case 9
                Label1.Text = "哪一部不是宮崎駿所導的電影呢？"
                RadioButton1.Text = "《螢火蟲之墓》"
                RadioButton2.Text = "《風之谷》"
                RadioButton3.Text = "《魔女宅急便》"
                RadioButton4.Text = "《崖上的波妞》"


        End Select

    End Sub

    Sub rightan()      '答對時的彈跳視窗
        Select Case count
            Case 0
                MsgBox("這麼簡單~當然可以答對啦啦啦啦!")
            Case 1
                MsgBox("哇~不錯哦!至少沒有猜人肉~XD")
            Case 2
                MsgBox("答對了!你是不是也是霍爾迷阿~B-)")
            Case 3
                MsgBox("哇賽~竟然答對這題!真厲害耶~")
            Case 4
                MsgBox("好棒棒哦~答對了耶!但這是基礎題~")
            Case 5
                MsgBox("答對惹!你是不是吉卜力超級粉絲阿？")
            Case 6
                MsgBox("哈哈答對囉!不覺得他長得很像棋靈王的一個角色嗎XD")
            Case 7
                MsgBox("窩齁~答對囉~變成豬的男主角帥嗎?XD")
            Case 8
                MsgBox("嘿嘿嘿~答對囉!看來有認真看><")
            Case 9
                MsgBox("哇賽~答對了ㄟ!你是不是猜的!")
        End Select
    End Sub

    Sub wrongan()      '答錯時的彈跳視窗
        Select Case count
            Case 0
                MsgBox("這麼簡單~你...竟然答錯惹!!!")
            Case 1
                MsgBox("哇~答錯囉...你應該沒有猜人肉吧...")
            Case 2
                MsgBox("答錯了!你是不是沒認真看這齣!!!")
            Case 3
                MsgBox("ㄨㄚˊ答錯了~笑你~(但我也不會XD")
            Case 4
                MsgBox("天阿~你竟然答錯了!是有沒有童年阿~")
            Case 5
                MsgBox("答錯惹!...好啦~不怪你~因為我也不會~哈哈")
            Case 6
                MsgBox("哈哈答對囉!不覺得他長得很像棋靈王的一個角色嗎XD")
            Case 7
                MsgBox("呵呵~答錯囉~他是變成豬的男主角...")
            Case 8
                MsgBox("顆顆顆~答錯了!看來沒有認真看><")
            Case 9
                MsgBox("嘿嘿~答錯了ㄟ!我就知道你會...錯XD")
        End Select
    End Sub

    Function check(sender) As Boolean    '檢查作答答對與否
        If sender.Checked = True Then
            rightan()
            count += 1
            labeltext()
            score += 10     '答對一題+10分
            Label3.Text = Format(score, "00")
        Else
            wrongan()
            count += 1
            labeltext()
            score -= 5       '答錯一題-5分
            Label3.Text = Format(score, "00")
            time -= 3        '答錯一題-3秒
            Label2.Text = Format(time, "00")
        End If
        RadioButton1.Focus()
        Return True
    End Function


    Private Sub Gipuly2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gipuly.Visible = False
        Timer1.Start()
        My.Computer.Audio.Play(My.Resources.這是阿芬的音樂, AudioPlayMode.Background)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Format(time, "00")
        time -= 1
        If time < 0 Or count = 10 Then
            Timer1.Stop()
            MsgBox("遊戲結束!總得分為" + Label3.Text, MsgBoxStyle.OkOnly, "complete")
            Me.Close()
            Gipuly.Visible = True
        End If

    End Sub

    Private Sub Gipuly2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Computer.Audio.Stop()
    End Sub
End Class


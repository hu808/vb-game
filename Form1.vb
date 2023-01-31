Public Class Form1
    Private Sub 開始_Click(sender As Object, e As EventArgs) Handles 開始.Click
        尋親之旅.Visible = True
        尋親之旅.倒數_timer.Start()
    End Sub

    Private Sub 遊戲說明_Click(sender As Object, e As EventArgs) Handles 遊戲說明.Click
        MsgBox("千尋的父母被湯婆婆的魔法變成豬，湯婆婆要求千尋在限定的時間內，找出圖片五個不同的地方，才可將千尋的父母恢復原來的樣子，請大家幫助千尋")
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        尋親之旅.第一關()
        尋親之旅.Visible = True
        尋親之旅.倒數_timer.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        尋親之旅.第二關()
        尋親之旅.Visible = True
        尋親之旅.倒數_timer.Start()
    End Sub


    Private Sub 關卡_Button_Click(sender As Object, e As EventArgs) Handles 關卡_Button.Click
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True

        開始.Visible = False
        遊戲說明.Visible = False
        關卡_Button.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        尋親之旅.第三關()
        尋親之旅.Visible = True
        尋親之旅.倒數_timer.Start()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        尋親之旅.第四關()
        尋親之旅.Visible = True
        尋親之旅.倒數_timer.Start()
    End Sub
End Class

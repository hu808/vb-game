Public Class 宮崎駿之旅
    '蘇菲
    Private Sub sufa_MouseEnter(sender As Object, e As EventArgs) Handles sufa.MouseEnter
        fire.BringToFront()
    End Sub
    Private Sub sufa_MouseLeave(sender As Object, e As EventArgs) Handles sufa.MouseLeave
        fire.SendToBack()
    End Sub
    Private Sub sufa_MouseDown(sender As Object, e As EventArgs) Handles sufa.MouseDown
        Gipuly.Show()

    End Sub

    '宅急便
    Private Sub fly_MouseEnter(sender As Object, e As EventArgs) Handles fly.MouseEnter
        cat.BringToFront()
    End Sub
    Private Sub fly_MouseLeave(sender As Object, e As EventArgs) Handles fly.MouseLeave
        cat.SendToBack()
    End Sub
    Private Sub fly_MouseDown(sender As Object, e As EventArgs) Handles fly.MouseDown
        接物.Visible = True
    End Sub

    '千尋
    Private Sub 千_MouseEnter(sender As Object, e As EventArgs) Handles 千.MouseEnter
        龍.BringToFront()
    End Sub
    Private Sub 千_MouseLeave(sender As Object, e As EventArgs) Handles 千.MouseLeave
        龍.SendToBack()
    End Sub
    Private Sub 千_MouseDown(sender As Object, e As EventArgs) Handles 千.MouseDown
        Form1.Visible = True
    End Sub

    '波妞
    Private Sub popo_MouseEnter(sender As Object, e As EventArgs) Handles popo.MouseEnter
        波妞.BringToFront()
    End Sub
    Private Sub popo_MouseLeave(sender As Object, e As EventArgs) Handles popo.MouseLeave
        波妞.SendToBack()
    End Sub
    Private Sub popo_MouseDown(sender As Object, e As EventArgs) Handles popo.MouseDown
        找找波妞1.Visible = True
    End Sub


    Private Sub 前傳_Click(sender As Object, e As EventArgs) Handles 前傳按鈕啦.Click
        前傳.Show()
    End Sub
End Class

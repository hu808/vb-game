Public Class 接物
    Private Sub 接物_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        PictureBox2.Visible = False
    End Sub
    Private Sub 魔女說明_Click(sender As Object, e As EventArgs) Handles 魔女說明.Click
        PictureBox1.Visible = True
        PictureBox2.Visible = True
    End Sub

    Private Sub 魔女開始_Click(sender As Object, e As EventArgs) Handles 魔女開始.Click
        接物開始.Visible = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox1.Visible = False
        PictureBox2.Visible = False
    End Sub
End Class
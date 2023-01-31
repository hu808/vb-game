Public Class Gipuly

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Gipuly2.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        explain.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        explain.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub Gipuly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Visible = False
    End Sub
End Class

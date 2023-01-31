Public Class 接物開始
    Dim Y1位移 As Integer
    Dim Y2位移 As Integer
    Dim Y3位移 As Integer
    Dim Y4位移 As Integer
    Dim t2 As Integer
    Dim t3 As Integer
    Dim t4 As Integer
    Dim t5 As Integer

    Sub 位移()
        Dim B(5) As Integer
        Randomize()
        For i = 1 To 4
            B(i) = Fix(Rnd() * 20) + 10               'Fix(n)無條件捨去小數
            For j = 0 To i - 1
                If B(i) = B(j) Then
                    i = i - 1
                    Exit For
                End If
            Next j
        Next i
        Y1位移 = B(1)
        Y2位移 = B(2)
        Y3位移 = B(3)
        Y4位移 = B(4)
    End Sub

    Sub 位置()
        Dim A(5) As Integer
        Randomize()
        For i = 1 To 4
            A(i) = Fix(Rnd() * 610)                 'Fix(n)無條件捨去小數
            For j = 0 To i - 1
                If A(i) = A(j) Then
                    i = i - 1
                    Exit For
                End If
            Next j
        Next i
        t2 = A(1)
        t3 = A(2)
        t4 = A(3)
        t5 = A(4)
    End Sub

    Private Sub 接物開始_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        WL.Visible = False
        w.Visible = False
        L.Visible = False
        Timer.Enabled = False
        信封1.Enabled = False
        信封2.Enabled = False
        信封3.Enabled = False
        黑函.Enabled = False
        Label2.Text = 45

        My.Computer.Audio.Play(My.Resources.這是音樂喔__, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub 接物開始_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown





        If 魔女人.Left <= 0 Then '左邊界
            If e.KeyCode = 37 Then
                魔女人.Left = 魔女人.Left '左
                魔女人.Image = My.Resources.魔女反
            ElseIf e.KeyCode = 39 Then
                魔女人.Left = 魔女人.Left + 15 '右
                魔女人.Image = My.Resources.魔女人物
            End If
        ElseIf 魔女人.Left >= Me.ClientSize.Width - 魔女人.Size.Width Then '右邊界
            If e.KeyCode = 37 Then
                魔女人.Left = 魔女人.Left - 15 '左
                魔女人.Image = My.Resources.魔女反
            ElseIf e.KeyCode = 39 Then
                魔女人.Left = 魔女人.Left '右
                魔女人.Image = My.Resources.魔女人物
            End If
        Else
            If e.KeyCode = 37 Then
                魔女人.Left = 魔女人.Left - 15 '左
                '魔女人.Location.X = 15
                魔女人.Image = My.Resources.魔女反
            ElseIf e.KeyCode = 39 Then
                魔女人.Left = 魔女人.Left + 15 '右
                魔女人.Image = My.Resources.魔女人物
            End If
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Label2.Text = Format(Label2.Text - 1, "00")

        If Label2.Text = 0 Then
            Label2.Enabled = False
            If Label4.Text >= 25 Then
                WL.Image = My.Resources.winner
                WL.Visible = True
                w.Visible = True
                w.Text = Label4.Text
                信封1.Enabled = False
                信封2.Enabled = False
                信封3.Enabled = False
                黑函.Enabled = False
                Timer.Enabled = False
            Else
                WL.Image = My.Resources.loser
                WL.Visible = True
                L.Visible = True
                L.Text = Label4.Text
                信封1.Enabled = False
                信封2.Enabled = False
                信封3.Enabled = False
                黑函.Enabled = False
                Timer.Enabled = False
            End If

        End If
    End Sub

    Private Sub 信封1_Tick(sender As Object, e As EventArgs) Handles 信封1.Tick
        PictureBox1.Visible = True
        位移()
        PictureBox1.Top = PictureBox1.Top + Y1位移
        位置()

        If (PictureBox1.Location.Y + PictureBox1.Size.Height >= 魔女人.Location.Y) And (PictureBox1.Location.X - 42 <= 魔女人.Location.X) And (PictureBox1.Location.X + 28 >= 魔女人.Location.X) Then
            PictureBox1.Location = New Point(t2, 3)
            Label4.Text = Format(Label4.Text + 1, "000")
        ElseIf PictureBox1.Top >= Me.ClientSize.Height - PictureBox1.Size.Height Then
            PictureBox1.Location = New Point(t2, 3)
        End If
    End Sub

    Private Sub 信封2_Tick(sender As Object, e As EventArgs) Handles 信封2.Tick
        PictureBox2.Visible = True
        位移()
        PictureBox2.Top = PictureBox2.Top + Y2位移
        位置()

        If (PictureBox2.Location.Y + PictureBox2.Size.Height >= 魔女人.Location.Y) And (PictureBox2.Location.X - 42 <= 魔女人.Location.X) And (PictureBox2.Location.X + 28 >= 魔女人.Location.X) Then
            PictureBox2.Location = New Point(t3, 3)
            Label4.Text = Format(Label4.Text + 1, "000")
        ElseIf PictureBox2.Top >= Me.ClientSize.Height - PictureBox2.Size.Height Then
            PictureBox2.Location = New Point(t3, 3)
        End If
    End Sub

    Private Sub 信封3_Tick(sender As Object, e As EventArgs) Handles 信封3.Tick
        PictureBox3.Visible = True
        位移()
        PictureBox3.Top = PictureBox3.Top + Y3位移
        位置()

        If (PictureBox3.Location.Y + PictureBox3.Size.Height >= 魔女人.Location.Y) And (PictureBox3.Location.X - 42 <= 魔女人.Location.X) And (PictureBox3.Location.X + 28 >= 魔女人.Location.X) Then
            PictureBox3.Location = New Point(t4, 3)
            Label4.Text = Format(Label4.Text + 1, "000")
        ElseIf PictureBox3.Top >= Me.ClientSize.Height - PictureBox3.Size.Height Then
            PictureBox3.Location = New Point(t4, 3)
        End If
    End Sub

    Private Sub 黑函_Tick(sender As Object, e As EventArgs) Handles 黑函.Tick
        PictureBox4.Visible = True
        位移()
        PictureBox4.Top = PictureBox4.Top + Y4位移
        位置()

        If (PictureBox4.Location.Y + PictureBox4.Size.Height >= 魔女人.Location.Y) And (PictureBox4.Location.X - 42 <= 魔女人.Location.X) And (PictureBox4.Location.X + 28 >= 魔女人.Location.X) Then
            PictureBox4.Location = New Point(t5, 3)
            Label4.Text = Format(Label4.Text - 1, "000")
        ElseIf PictureBox4.Top >= Me.ClientSize.Height - PictureBox4.Size.Height Then
            PictureBox4.Location = New Point(t5, 3)
        End If
    End Sub

    Private Sub 倒數_Tick(sender As Object, e As EventArgs) Handles 倒數.Tick
        Label5.Text = Label5.Text - 1
        If Label5.Text = 0 Then
            Label6.BringToFront()
        ElseIf Label5.Text = -1 Then
            Label5.Visible = False
            Label6.Visible = False
            Label5.Tag = 1
            If Label5.Tag = 1 Then
                Timer.Enabled = True
                信封1.Enabled = True
                信封2.Enabled = True
                信封3.Enabled = True
                黑函.Enabled = True
            End If
            倒數.Enabled = False
        End If

    End Sub

    Private Sub WL_Click(sender As Object, e As EventArgs) Handles WL.Click
        WL.Visible = False
        w.Visible = False
        L.Visible = False
        Me.Close()
    End Sub

    Private Sub 接物開始_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Computer.Audio.Stop()
    End Sub
End Class
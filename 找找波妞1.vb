Public Class 找找波妞1
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        找找波妞2.Visible = True
    End Sub

    Private Sub 找找波妞1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'AxWindowsMediaPlayer1.Tag = 1 'tag=1代表有音樂
        'AxWindowsMediaPlayer1.settings.volume = 30
        My.Computer.Audio.Play(My.Resources.backmusic, AudioPlayMode.BackgroundLoop)
    End Sub

    Dim Play_State As String = "Play"
    Private Sub MusicButton_Click(sender As Object, e As EventArgs) Handles MusicButton.Click
        If Play_State = "Play" Then
            Play_State = "Stop" 'tag=0表沒音樂
            My.Computer.Audio.Stop()
            MusicButton.BackgroundImage = My.Resources.找_音符禁止
        Else
            Play_State = "Play"
            My.Computer.Audio.Play(My.Resources.backmusic, AudioPlayMode.BackgroundLoop)
            MusicButton.BackgroundImage = My.Resources.找_音符
        End If
    End Sub

    Private Sub 找找波妞1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Computer.Audio.Stop()
    End Sub
End Class
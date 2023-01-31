<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 找找波妞1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(找找波妞1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.MusicButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 15.8961!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 196)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "歡迎來到""進擊的波妞""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--遊戲規則--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "遊戲時間30秒，找到波妞並按下，即可得50分!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "若30秒內達到800分，獲得晉級資格!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "晉級後難度上升，若30秒" &
    "達到800分，則挑戰成功!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "若挑戰失敗，則遊戲結束~" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "各位挑戰者加油!!"
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.SystemColors.Info
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StartButton.Font = New System.Drawing.Font("微軟正黑體", 20.1039!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartButton.Location = New System.Drawing.Point(346, 251)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(217, 95)
        Me.StartButton.TabIndex = 2
        Me.StartButton.Text = "Game Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'MusicButton
        '
        Me.MusicButton.BackColor = System.Drawing.Color.MistyRose
        Me.MusicButton.BackgroundImage = Global.期末報告.My.Resources.Resources.找_音符
        Me.MusicButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MusicButton.Font = New System.Drawing.Font("微軟正黑體", 12.15584!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MusicButton.ForeColor = System.Drawing.Color.LightCoral
        Me.MusicButton.Location = New System.Drawing.Point(519, 15)
        Me.MusicButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MusicButton.Name = "MusicButton"
        Me.MusicButton.Size = New System.Drawing.Size(44, 51)
        Me.MusicButton.TabIndex = 3
        Me.MusicButton.UseVisualStyleBackColor = False
        '
        '找找波妞1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.期末報告.My.Resources.Resources.找_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(583, 383)
        Me.Controls.Add(Me.MusicButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "找找波妞1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "進擊的波妞"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents StartButton As Button
    Friend WithEvents MusicButton As Button
End Class

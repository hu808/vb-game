<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gipuly2
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gipuly2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.OldLace
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(449, 156)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "《龍貓》中妹妹小梅想帶哪一種食物給其母親導致她迷路？"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButton1.Location = New System.Drawing.Point(59, 189)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(221, 106)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "馬鈴薯"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(286, 189)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(231, 106)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "玉蜀黍"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(59, 301)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(221, 118)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "地瓜"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(286, 301)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(231, 118)
        Me.RadioButton4.TabIndex = 5
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "大蘿蔔"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(541, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 54)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "確 認"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.期末報告.My.Resources.Resources.score
        Me.PictureBox1.Location = New System.Drawing.Point(494, 193)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(585, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 60)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "00"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.期末報告.My.Resources.Resources.time
        Me.PictureBox2.Location = New System.Drawing.Point(541, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(123, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(574, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 41)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "00"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Gipuly2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(703, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Gipuly2"
        Me.Text = "Gipuly2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
End Class

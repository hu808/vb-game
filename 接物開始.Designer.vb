<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 接物開始
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(接物開始))
        Me.魔女人 = New System.Windows.Forms.PictureBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.信封1 = New System.Windows.Forms.Timer(Me.components)
        Me.信封2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.信封3 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.黑函 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.倒數 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WL = New System.Windows.Forms.PictureBox()
        Me.w = New System.Windows.Forms.Label()
        Me.L = New System.Windows.Forms.Label()
        CType(Me.魔女人, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '魔女人
        '
        Me.魔女人.BackColor = System.Drawing.Color.Transparent
        Me.魔女人.Image = Global.期末報告.My.Resources.Resources.魔女人物
        Me.魔女人.Location = New System.Drawing.Point(0, 485)
        Me.魔女人.Name = "魔女人"
        Me.魔女人.Size = New System.Drawing.Size(90, 100)
        Me.魔女人.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.魔女人.TabIndex = 0
        Me.魔女人.TabStop = False
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.期末報告.My.Resources.Resources.信封
        Me.PictureBox1.Location = New System.Drawing.Point(39, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.期末報告.My.Resources.Resources.信封
        Me.PictureBox2.Location = New System.Drawing.Point(239, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(76, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(691, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 44)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "時間"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(701, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 44)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "00"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(692, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 44)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "分數"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(692, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 44)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "00"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '信封1
        '
        Me.信封1.Enabled = True
        Me.信封1.Interval = 1
        '
        '信封2
        '
        Me.信封2.Enabled = True
        Me.信封2.Interval = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.期末報告.My.Resources.Resources.信封
        Me.PictureBox3.Location = New System.Drawing.Point(383, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(76, 61)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        '信封3
        '
        Me.信封3.Enabled = True
        Me.信封3.Interval = 1
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.期末報告.My.Resources.Resources.黑函
        Me.PictureBox4.Location = New System.Drawing.Point(496, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(76, 61)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        '黑函
        '
        Me.黑函.Enabled = True
        Me.黑函.Interval = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("標楷體", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(303, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 146)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "3"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '倒數
        '
        Me.倒數.Enabled = True
        Me.倒數.Interval = 1000
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(261, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(333, 146)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Start"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WL
        '
        Me.WL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WL.Image = Global.期末報告.My.Resources.Resources.loser
        Me.WL.Location = New System.Drawing.Point(151, 85)
        Me.WL.Name = "WL"
        Me.WL.Size = New System.Drawing.Size(500, 360)
        Me.WL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WL.TabIndex = 18
        Me.WL.TabStop = False
        '
        'w
        '
        Me.w.Font = New System.Drawing.Font("標楷體", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.w.ForeColor = System.Drawing.Color.Maroon
        Me.w.Image = Global.期末報告.My.Resources.Resources.w1
        Me.w.Location = New System.Drawing.Point(421, 135)
        Me.w.Name = "w"
        Me.w.Size = New System.Drawing.Size(127, 62)
        Me.w.TabIndex = 20
        Me.w.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L
        '
        Me.L.Font = New System.Drawing.Font("標楷體", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.L.Image = Global.期末報告.My.Resources.Resources.L1
        Me.L.Location = New System.Drawing.Point(346, 142)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(100, 64)
        Me.L.TabIndex = 21
        Me.L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '接物開始
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.期末報告.My.Resources.Resources.魔女遊戲背景
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(815, 597)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.w)
        Me.Controls.Add(Me.WL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.魔女人)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "接物開始"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "魔女宅急便"
        CType(Me.魔女人, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents 魔女人 As PictureBox
    Friend WithEvents Timer As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents 信封1 As Timer
    Friend WithEvents 信封2 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents 信封3 As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents 黑函 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents 倒數 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents WL As PictureBox
    Friend WithEvents w As Label
    Friend WithEvents L As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 尋親之旅
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(尋親之旅))
        Me.倒數_label = New System.Windows.Forms.Label()
        Me.倒數_timer = New System.Windows.Forms.Timer(Me.components)
        Me.start_Label = New System.Windows.Forms.Label()
        Me.時間_label = New System.Windows.Forms.Label()
        Me.gametime_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.gametime_label = New System.Windows.Forms.Label()
        Me.已改_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.error1_Label = New System.Windows.Forms.Label()
        Me.error1_PictureBox = New System.Windows.Forms.PictureBox()
        Me.error2_Label = New System.Windows.Forms.Label()
        Me.error2_PictureBox = New System.Windows.Forms.PictureBox()
        Me.error3_Label = New System.Windows.Forms.Label()
        Me.error3_PictureBox = New System.Windows.Forms.PictureBox()
        Me.error4_PictureBox = New System.Windows.Forms.PictureBox()
        Me.error5_Label = New System.Windows.Forms.Label()
        Me.error5_PictureBox = New System.Windows.Forms.PictureBox()
        Me.error4_Label = New System.Windows.Forms.Label()
        Me.未改_PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.已改_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error1_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error2_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error3_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error4_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error5_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.未改_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '倒數_label
        '
        Me.倒數_label.BackColor = System.Drawing.Color.Transparent
        Me.倒數_label.Font = New System.Drawing.Font("微軟正黑體", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.倒數_label.ForeColor = System.Drawing.Color.Red
        Me.倒數_label.Location = New System.Drawing.Point(445, 213)
        Me.倒數_label.Name = "倒數_label"
        Me.倒數_label.Size = New System.Drawing.Size(94, 108)
        Me.倒數_label.TabIndex = 0
        Me.倒數_label.Text = "3"
        '
        '倒數_timer
        '
        Me.倒數_timer.Interval = 1000
        '
        'start_Label
        '
        Me.start_Label.AutoSize = True
        Me.start_Label.BackColor = System.Drawing.Color.Transparent
        Me.start_Label.Font = New System.Drawing.Font("微軟正黑體", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.start_Label.ForeColor = System.Drawing.Color.Red
        Me.start_Label.Location = New System.Drawing.Point(400, 259)
        Me.start_Label.Name = "start_Label"
        Me.start_Label.Size = New System.Drawing.Size(0, 101)
        Me.start_Label.TabIndex = 1
        '
        '時間_label
        '
        Me.時間_label.BackColor = System.Drawing.Color.Transparent
        Me.時間_label.Enabled = False
        Me.時間_label.Font = New System.Drawing.Font("微軟正黑體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.時間_label.ForeColor = System.Drawing.SystemColors.Control
        Me.時間_label.Location = New System.Drawing.Point(12, 18)
        Me.時間_label.Name = "時間_label"
        Me.時間_label.Size = New System.Drawing.Size(112, 43)
        Me.時間_label.TabIndex = 2
        Me.時間_label.Text = "時間:"
        '
        'gametime_Timer
        '
        Me.gametime_Timer.Interval = 1000
        '
        'gametime_label
        '
        Me.gametime_label.BackColor = System.Drawing.Color.Transparent
        Me.gametime_label.Font = New System.Drawing.Font("微軟正黑體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gametime_label.ForeColor = System.Drawing.Color.Yellow
        Me.gametime_label.Location = New System.Drawing.Point(115, 18)
        Me.gametime_label.Name = "gametime_label"
        Me.gametime_label.Size = New System.Drawing.Size(136, 46)
        Me.gametime_label.TabIndex = 3
        Me.gametime_label.Text = "60"
        '
        '已改_PictureBox
        '
        Me.已改_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.已改_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.已改_PictureBox.Image = Global.期末報告.My.Resources.Resources.已改
        Me.已改_PictureBox.Location = New System.Drawing.Point(504, 66)
        Me.已改_PictureBox.Name = "已改_PictureBox"
        Me.已改_PictureBox.Size = New System.Drawing.Size(458, 440)
        Me.已改_PictureBox.TabIndex = 5
        Me.已改_PictureBox.TabStop = False
        Me.已改_PictureBox.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(551, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 12)
        Me.Label1.TabIndex = 11
        '
        'error1_Label
        '
        Me.error1_Label.Image = Global.期末報告.My.Resources.Resources._千01
        Me.error1_Label.Location = New System.Drawing.Point(555, 186)
        Me.error1_Label.Name = "error1_Label"
        Me.error1_Label.Size = New System.Drawing.Size(28, 26)
        Me.error1_Label.TabIndex = 12
        Me.error1_Label.Visible = False
        '
        'error1_PictureBox
        '
        Me.error1_PictureBox.Image = Global.期末報告.My.Resources.Resources._千01_1
        Me.error1_PictureBox.Location = New System.Drawing.Point(527, 166)
        Me.error1_PictureBox.Name = "error1_PictureBox"
        Me.error1_PictureBox.Size = New System.Drawing.Size(76, 69)
        Me.error1_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.error1_PictureBox.TabIndex = 13
        Me.error1_PictureBox.TabStop = False
        Me.error1_PictureBox.Visible = False
        '
        'error2_Label
        '
        Me.error2_Label.Image = Global.期末報告.My.Resources.Resources._千02
        Me.error2_Label.Location = New System.Drawing.Point(623, 335)
        Me.error2_Label.Name = "error2_Label"
        Me.error2_Label.Size = New System.Drawing.Size(66, 61)
        Me.error2_Label.TabIndex = 14
        Me.error2_Label.Visible = False
        '
        'error2_PictureBox
        '
        Me.error2_PictureBox.Image = Global.期末報告.My.Resources.Resources._千02_1
        Me.error2_PictureBox.Location = New System.Drawing.Point(616, 323)
        Me.error2_PictureBox.Name = "error2_PictureBox"
        Me.error2_PictureBox.Size = New System.Drawing.Size(76, 81)
        Me.error2_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.error2_PictureBox.TabIndex = 15
        Me.error2_PictureBox.TabStop = False
        Me.error2_PictureBox.Visible = False
        '
        'error3_Label
        '
        Me.error3_Label.BackColor = System.Drawing.SystemColors.Control
        Me.error3_Label.Image = Global.期末報告.My.Resources.Resources._千03
        Me.error3_Label.Location = New System.Drawing.Point(845, 99)
        Me.error3_Label.Name = "error3_Label"
        Me.error3_Label.Size = New System.Drawing.Size(32, 34)
        Me.error3_Label.TabIndex = 16
        Me.error3_Label.Visible = False
        '
        'error3_PictureBox
        '
        Me.error3_PictureBox.Image = CType(resources.GetObject("error3_PictureBox.Image"), System.Drawing.Image)
        Me.error3_PictureBox.Location = New System.Drawing.Point(835, 90)
        Me.error3_PictureBox.Name = "error3_PictureBox"
        Me.error3_PictureBox.Size = New System.Drawing.Size(51, 43)
        Me.error3_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.error3_PictureBox.TabIndex = 17
        Me.error3_PictureBox.TabStop = False
        Me.error3_PictureBox.Visible = False
        '
        'error4_PictureBox
        '
        Me.error4_PictureBox.Image = Global.期末報告.My.Resources.Resources._千04_1
        Me.error4_PictureBox.Location = New System.Drawing.Point(667, 306)
        Me.error4_PictureBox.Name = "error4_PictureBox"
        Me.error4_PictureBox.Size = New System.Drawing.Size(62, 69)
        Me.error4_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.error4_PictureBox.TabIndex = 19
        Me.error4_PictureBox.TabStop = False
        Me.error4_PictureBox.Visible = False
        '
        'error5_Label
        '
        Me.error5_Label.Image = Global.期末報告.My.Resources.Resources._千05
        Me.error5_Label.Location = New System.Drawing.Point(573, 81)
        Me.error5_Label.Name = "error5_Label"
        Me.error5_Label.Size = New System.Drawing.Size(21, 20)
        Me.error5_Label.TabIndex = 20
        Me.error5_Label.Visible = False
        '
        'error5_PictureBox
        '
        Me.error5_PictureBox.Image = Global.期末報告.My.Resources.Resources._千05_1
        Me.error5_PictureBox.Location = New System.Drawing.Point(549, 66)
        Me.error5_PictureBox.Name = "error5_PictureBox"
        Me.error5_PictureBox.Size = New System.Drawing.Size(71, 55)
        Me.error5_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.error5_PictureBox.TabIndex = 21
        Me.error5_PictureBox.TabStop = False
        Me.error5_PictureBox.Visible = False
        '
        'error4_Label
        '
        Me.error4_Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.error4_Label.Image = Global.期末報告.My.Resources.Resources._千04
        Me.error4_Label.Location = New System.Drawing.Point(677, 319)
        Me.error4_Label.Name = "error4_Label"
        Me.error4_Label.Size = New System.Drawing.Size(35, 36)
        Me.error4_Label.TabIndex = 22
        Me.error4_Label.Visible = False
        '
        '未改_PictureBox
        '
        Me.未改_PictureBox.Image = Global.期末報告.My.Resources.Resources.未改
        Me.未改_PictureBox.Location = New System.Drawing.Point(20, 66)
        Me.未改_PictureBox.Name = "未改_PictureBox"
        Me.未改_PictureBox.Size = New System.Drawing.Size(458, 440)
        Me.未改_PictureBox.TabIndex = 4
        Me.未改_PictureBox.TabStop = False
        Me.未改_PictureBox.Visible = False
        '
        '尋親之旅
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = Global.期末報告.My.Resources.Resources.背景圖
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(997, 527)
        Me.Controls.Add(Me.error4_PictureBox)
        Me.Controls.Add(Me.error4_Label)
        Me.Controls.Add(Me.error5_PictureBox)
        Me.Controls.Add(Me.error5_Label)
        Me.Controls.Add(Me.error2_PictureBox)
        Me.Controls.Add(Me.error3_PictureBox)
        Me.Controls.Add(Me.error3_Label)
        Me.Controls.Add(Me.error2_Label)
        Me.Controls.Add(Me.error1_PictureBox)
        Me.Controls.Add(Me.error1_Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.未改_PictureBox)
        Me.Controls.Add(Me.gametime_label)
        Me.Controls.Add(Me.時間_label)
        Me.Controls.Add(Me.start_Label)
        Me.Controls.Add(Me.已改_PictureBox)
        Me.Controls.Add(Me.倒數_label)
        Me.MaximizeBox = False
        Me.Name = "尋親之旅"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = """尋""親之旅"
        CType(Me.已改_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error1_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error2_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error3_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error4_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error5_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.未改_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 倒數_label As Label
    Friend WithEvents 倒數_timer As Timer
    Friend WithEvents start_Label As Label
    Friend WithEvents 時間_label As Label
    Friend WithEvents gametime_Timer As Timer
    Friend WithEvents gametime_label As Label
    Friend WithEvents 已改_PictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents error1_Label As Label
    Friend WithEvents error1_PictureBox As PictureBox
    Friend WithEvents error2_Label As Label
    Friend WithEvents error2_PictureBox As PictureBox
    Friend WithEvents error3_Label As Label
    Friend WithEvents error3_PictureBox As PictureBox
    Friend WithEvents error4_PictureBox As PictureBox
    Friend WithEvents error5_Label As Label
    Friend WithEvents error5_PictureBox As PictureBox
    Friend WithEvents error4_Label As Label
    Friend WithEvents 未改_PictureBox As PictureBox
End Class

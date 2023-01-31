<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 接物
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(接物))
        Me.魔女開始 = New System.Windows.Forms.Button()
        Me.魔女說明 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '魔女開始
        '
        Me.魔女開始.BackColor = System.Drawing.Color.Navy
        Me.魔女開始.Font = New System.Drawing.Font("華康勘亭流", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.魔女開始.ForeColor = System.Drawing.Color.Violet
        Me.魔女開始.Location = New System.Drawing.Point(55, 252)
        Me.魔女開始.Name = "魔女開始"
        Me.魔女開始.Size = New System.Drawing.Size(152, 80)
        Me.魔女開始.TabIndex = 0
        Me.魔女開始.Text = "開始遊戲"
        Me.魔女開始.UseVisualStyleBackColor = False
        '
        '魔女說明
        '
        Me.魔女說明.BackColor = System.Drawing.Color.Navy
        Me.魔女說明.Font = New System.Drawing.Font("華康勘亭流", 15.75!, System.Drawing.FontStyle.Bold)
        Me.魔女說明.ForeColor = System.Drawing.Color.Violet
        Me.魔女說明.Location = New System.Drawing.Point(321, 252)
        Me.魔女說明.Name = "魔女說明"
        Me.魔女說明.Size = New System.Drawing.Size(152, 80)
        Me.魔女說明.TabIndex = 1
        Me.魔女說明.Text = "遊戲說明"
        Me.魔女說明.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("華康雅風體W3", 66.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(21, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(502, 89)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "魔女宅急便"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.期末報告.My.Resources.Resources.aaa
        Me.PictureBox1.Location = New System.Drawing.Point(69, 171)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.期末報告.My.Resources.Resources.bbb
        Me.PictureBox2.Location = New System.Drawing.Point(319, 322)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        '接物
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.期末報告.My.Resources.Resources.魔女背景首頁
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(526, 607)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.魔女說明)
        Me.Controls.Add(Me.魔女開始)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "接物"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "魔女宅急便"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents 魔女開始 As Button
    Friend WithEvents 魔女說明 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class

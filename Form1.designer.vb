<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.開始 = New System.Windows.Forms.Button()
        Me.標題 = New System.Windows.Forms.Label()
        Me.遊戲說明 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.關卡_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '開始
        '
        Me.開始.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.開始.ForeColor = System.Drawing.Color.White
        Me.開始.Image = My.Resources.Resources.木
        Me.開始.Location = New System.Drawing.Point(294, 489)
        Me.開始.Name = "開始"
        Me.開始.Size = New System.Drawing.Size(125, 57)
        Me.開始.TabIndex = 0
        Me.開始.Text = "開始遊戲"
        Me.開始.UseVisualStyleBackColor = True
        '
        '標題
        '
        Me.標題.BackColor = System.Drawing.Color.Transparent
        Me.標題.Font = New System.Drawing.Font("標楷體", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.標題.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.標題.Location = New System.Drawing.Point(216, 26)
        Me.標題.Name = "標題"
        Me.標題.Size = New System.Drawing.Size(303, 82)
        Me.標題.TabIndex = 1
        Me.標題.Text = """尋""親之旅"
        '
        '遊戲說明
        '
        Me.遊戲說明.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.遊戲說明.ForeColor = System.Drawing.Color.White
        Me.遊戲說明.Image = My.Resources.Resources.木
        Me.遊戲說明.Location = New System.Drawing.Point(133, 489)
        Me.遊戲說明.Name = "遊戲說明"
        Me.遊戲說明.Size = New System.Drawing.Size(125, 57)
        Me.遊戲說明.TabIndex = 2
        Me.遊戲說明.Text = "遊戲說明"
        Me.遊戲說明.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = My.Resources.Resources.木
        Me.Button1.Location = New System.Drawing.Point(151, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 54)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = My.Resources.Resources.木
        Me.Button2.Location = New System.Drawing.Point(358, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 54)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = My.Resources.Resources.木
        Me.Button3.Location = New System.Drawing.Point(224, 272)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 54)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = My.Resources.Resources.木
        Me.Button4.Location = New System.Drawing.Point(458, 272)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 54)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        '關卡_Button
        '
        Me.關卡_Button.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.關卡_Button.ForeColor = System.Drawing.Color.White
        Me.關卡_Button.Image = My.Resources.Resources.木
        Me.關卡_Button.Location = New System.Drawing.Point(469, 489)
        Me.關卡_Button.Name = "關卡_Button"
        Me.關卡_Button.Size = New System.Drawing.Size(125, 57)
        Me.關卡_Button.TabIndex = 8
        Me.關卡_Button.Text = "關卡"
        Me.關卡_Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = My.Resources.Resources.千尋
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(716, 608)
        Me.Controls.Add(Me.關卡_Button)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.遊戲說明)
        Me.Controls.Add(Me.標題)
        Me.Controls.Add(Me.開始)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = """尋""親之旅"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents 開始 As Button
    Friend WithEvents 標題 As Label
    Friend WithEvents 遊戲說明 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents 關卡_Button As Button
End Class

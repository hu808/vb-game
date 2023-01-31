<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gipuly
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gipuly))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.explain = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.explain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("華康娃娃體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(460, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 65)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "開始遊戲"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("華康娃娃體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.Location = New System.Drawing.Point(624, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 65)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "遊戲說明"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("華康布丁體", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(373, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 69)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "吉 卜 力"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("華康布丁體", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(426, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(380, 69)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "拾 光 隧 道"
        '
        'explain
        '
        Me.explain.Image = CType(resources.GetObject("explain.Image"), System.Drawing.Image)
        Me.explain.Location = New System.Drawing.Point(198, 75)
        Me.explain.Name = "explain"
        Me.explain.Size = New System.Drawing.Size(445, 329)
        Me.explain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.explain.TabIndex = 4
        Me.explain.TabStop = False
        Me.explain.Visible = False
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("華康娃娃體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.Location = New System.Drawing.Point(535, 345)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 45)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "了解"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Gipuly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = My.Resources.Resources.fatcat
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(836, 460)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.explain)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Gipuly"
        Me.Text = "吉卜力拾光隧道"
        CType(Me.explain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents explain As PictureBox
    Friend WithEvents Button3 As Button
End Class

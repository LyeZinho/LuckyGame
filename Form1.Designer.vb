<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LuckyGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.rtbNicknameImput = New System.Windows.Forms.RichTextBox()
        Me.btConfirm = New System.Windows.Forms.Button()
        Me.btPlayerOneImputBox = New System.Windows.Forms.TextBox()
        Me.btNameTagPlayerOne = New System.Windows.Forms.Button()
        Me.btNameTagPlayerTwo = New System.Windows.Forms.Button()
        Me.btPlayerTwoImputBox = New System.Windows.Forms.TextBox()
        Me.btStatsDisplayPlayerOne = New System.Windows.Forms.Button()
        Me.btStatsDisplayPlayerTwo = New System.Windows.Forms.Button()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbLogo
        '
        Me.ptbLogo.Location = New System.Drawing.Point(291, 167)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(190, 160)
        Me.ptbLogo.TabIndex = 0
        Me.ptbLogo.TabStop = False
        '
        'rtbNicknameImput
        '
        Me.rtbNicknameImput.Location = New System.Drawing.Point(312, 352)
        Me.rtbNicknameImput.Name = "rtbNicknameImput"
        Me.rtbNicknameImput.Size = New System.Drawing.Size(153, 24)
        Me.rtbNicknameImput.TabIndex = 1
        Me.rtbNicknameImput.Text = "Jogador 1"
        '
        'btConfirm
        '
        Me.btConfirm.Location = New System.Drawing.Point(328, 382)
        Me.btConfirm.Name = "btConfirm"
        Me.btConfirm.Size = New System.Drawing.Size(107, 23)
        Me.btConfirm.TabIndex = 2
        Me.btConfirm.Text = "Confirm"
        Me.btConfirm.UseVisualStyleBackColor = True
        '
        'btPlayerOneImputBox
        '
        Me.btPlayerOneImputBox.Location = New System.Drawing.Point(48, 149)
        Me.btPlayerOneImputBox.Name = "btPlayerOneImputBox"
        Me.btPlayerOneImputBox.Size = New System.Drawing.Size(100, 23)
        Me.btPlayerOneImputBox.TabIndex = 3
        Me.btPlayerOneImputBox.Text = "Valor de 1 a 100"
        '
        'btNameTagPlayerOne
        '
        Me.btNameTagPlayerOne.Location = New System.Drawing.Point(37, 77)
        Me.btNameTagPlayerOne.Name = "btNameTagPlayerOne"
        Me.btNameTagPlayerOne.Size = New System.Drawing.Size(125, 57)
        Me.btNameTagPlayerOne.TabIndex = 5
        Me.btNameTagPlayerOne.Text = "PlayerNickname"
        Me.btNameTagPlayerOne.UseVisualStyleBackColor = True
        '
        'btNameTagPlayerTwo
        '
        Me.btNameTagPlayerTwo.Location = New System.Drawing.Point(609, 77)
        Me.btNameTagPlayerTwo.Name = "btNameTagPlayerTwo"
        Me.btNameTagPlayerTwo.Size = New System.Drawing.Size(131, 57)
        Me.btNameTagPlayerTwo.TabIndex = 7
        Me.btNameTagPlayerTwo.Text = "PlayerNickname"
        Me.btNameTagPlayerTwo.UseVisualStyleBackColor = True
        '
        'btPlayerTwoImputBox
        '
        Me.btPlayerTwoImputBox.Location = New System.Drawing.Point(626, 149)
        Me.btPlayerTwoImputBox.Name = "btPlayerTwoImputBox"
        Me.btPlayerTwoImputBox.Size = New System.Drawing.Size(100, 23)
        Me.btPlayerTwoImputBox.TabIndex = 6
        Me.btPlayerTwoImputBox.Text = "Valor de 1 a 100"
        '
        'btStatsDisplayPlayerOne
        '
        Me.btStatsDisplayPlayerOne.Location = New System.Drawing.Point(37, 208)
        Me.btStatsDisplayPlayerOne.Name = "btStatsDisplayPlayerOne"
        Me.btStatsDisplayPlayerOne.Size = New System.Drawing.Size(125, 197)
        Me.btStatsDisplayPlayerOne.TabIndex = 8
        Me.btStatsDisplayPlayerOne.Text = "n/a"
        Me.btStatsDisplayPlayerOne.UseVisualStyleBackColor = True
        '
        'btStatsDisplayPlayerTwo
        '
        Me.btStatsDisplayPlayerTwo.Location = New System.Drawing.Point(609, 208)
        Me.btStatsDisplayPlayerTwo.Name = "btStatsDisplayPlayerTwo"
        Me.btStatsDisplayPlayerTwo.Size = New System.Drawing.Size(131, 197)
        Me.btStatsDisplayPlayerTwo.TabIndex = 9
        Me.btStatsDisplayPlayerTwo.Text = "n/a"
        Me.btStatsDisplayPlayerTwo.UseVisualStyleBackColor = True
        '
        'LuckyGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btStatsDisplayPlayerTwo)
        Me.Controls.Add(Me.btStatsDisplayPlayerOne)
        Me.Controls.Add(Me.btNameTagPlayerTwo)
        Me.Controls.Add(Me.btPlayerTwoImputBox)
        Me.Controls.Add(Me.btNameTagPlayerOne)
        Me.Controls.Add(Me.btPlayerOneImputBox)
        Me.Controls.Add(Me.btConfirm)
        Me.Controls.Add(Me.rtbNicknameImput)
        Me.Controls.Add(Me.ptbLogo)
        Me.Name = "LuckyGame"
        Me.Text = "Form1"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents rtbNicknameImput As RichTextBox
    Friend WithEvents btConfirm As Button
    Friend WithEvents btPlayerOneImputBox As TextBox
    Friend WithEvents btNameTagPlayerOne As Button
    Friend WithEvents btNameTagPlayerTwo As Button
    Friend WithEvents btPlayerTwoImputBox As TextBox
    Friend WithEvents btStatsDisplayPlayerOne As Button
    Friend WithEvents btStatsDisplayPlayerTwo As Button
End Class

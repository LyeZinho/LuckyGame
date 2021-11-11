<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbNickname = New System.Windows.Forms.TextBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.btConfirm = New System.Windows.Forms.Button()
        Me.btPlayer1Stats = New System.Windows.Forms.Button()
        Me.btPlayer2Stats = New System.Windows.Forms.Button()
        Me.tbNumImputPlayer2 = New System.Windows.Forms.TextBox()
        Me.tbNumImputPlayer1 = New System.Windows.Forms.TextBox()
        Me.btPlayer1Confirm = New System.Windows.Forms.Button()
        Me.btPlayer2Confirm = New System.Windows.Forms.Button()
        Me.btDisplayWinner2 = New System.Windows.Forms.Button()
        Me.btDisplayWinner1 = New System.Windows.Forms.Button()
        Me.btRandomResult = New System.Windows.Forms.Button()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbNickname
        '
        Me.tbNickname.Location = New System.Drawing.Point(334, 381)
        Me.tbNickname.Name = "tbNickname"
        Me.tbNickname.Size = New System.Drawing.Size(172, 23)
        Me.tbNickname.TabIndex = 0
        Me.tbNickname.Text = "Nome Jogador 1"
        Me.tbNickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.LuckyGame.My.Resources.Resources.lucky_game_logo
        Me.pbLogo.Location = New System.Drawing.Point(265, 62)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(327, 233)
        Me.pbLogo.TabIndex = 1
        Me.pbLogo.TabStop = False
        '
        'btConfirm
        '
        Me.btConfirm.Location = New System.Drawing.Point(369, 410)
        Me.btConfirm.Name = "btConfirm"
        Me.btConfirm.Size = New System.Drawing.Size(91, 26)
        Me.btConfirm.TabIndex = 2
        Me.btConfirm.Text = "Confirm"
        Me.btConfirm.UseVisualStyleBackColor = True
        '
        'btPlayer1Stats
        '
        Me.btPlayer1Stats.Location = New System.Drawing.Point(12, 235)
        Me.btPlayer1Stats.Name = "btPlayer1Stats"
        Me.btPlayer1Stats.Size = New System.Drawing.Size(167, 169)
        Me.btPlayer1Stats.TabIndex = 3
        Me.btPlayer1Stats.Text = "N/A"
        Me.btPlayer1Stats.UseVisualStyleBackColor = True
        '
        'btPlayer2Stats
        '
        Me.btPlayer2Stats.Location = New System.Drawing.Point(631, 235)
        Me.btPlayer2Stats.Name = "btPlayer2Stats"
        Me.btPlayer2Stats.Size = New System.Drawing.Size(157, 169)
        Me.btPlayer2Stats.TabIndex = 4
        Me.btPlayer2Stats.Text = "N/A"
        Me.btPlayer2Stats.UseVisualStyleBackColor = True
        '
        'tbNumImputPlayer2
        '
        Me.tbNumImputPlayer2.Location = New System.Drawing.Point(656, 110)
        Me.tbNumImputPlayer2.Name = "tbNumImputPlayer2"
        Me.tbNumImputPlayer2.Size = New System.Drawing.Size(109, 23)
        Me.tbNumImputPlayer2.TabIndex = 5
        Me.tbNumImputPlayer2.Text = "Numero de 1 a 100"
        '
        'tbNumImputPlayer1
        '
        Me.tbNumImputPlayer1.Location = New System.Drawing.Point(28, 110)
        Me.tbNumImputPlayer1.Name = "tbNumImputPlayer1"
        Me.tbNumImputPlayer1.Size = New System.Drawing.Size(111, 23)
        Me.tbNumImputPlayer1.TabIndex = 6
        Me.tbNumImputPlayer1.Text = "Numero de 1 a 100"
        '
        'btPlayer1Confirm
        '
        Me.btPlayer1Confirm.Location = New System.Drawing.Point(12, 159)
        Me.btPlayer1Confirm.Name = "btPlayer1Confirm"
        Me.btPlayer1Confirm.Size = New System.Drawing.Size(167, 43)
        Me.btPlayer1Confirm.TabIndex = 7
        Me.btPlayer1Confirm.Text = "Confirm"
        Me.btPlayer1Confirm.UseVisualStyleBackColor = True
        '
        'btPlayer2Confirm
        '
        Me.btPlayer2Confirm.Location = New System.Drawing.Point(631, 159)
        Me.btPlayer2Confirm.Name = "btPlayer2Confirm"
        Me.btPlayer2Confirm.Size = New System.Drawing.Size(157, 43)
        Me.btPlayer2Confirm.TabIndex = 8
        Me.btPlayer2Confirm.Text = "Confirm"
        Me.btPlayer2Confirm.UseVisualStyleBackColor = True
        '
        'btDisplayWinner2
        '
        Me.btDisplayWinner2.Location = New System.Drawing.Point(631, 40)
        Me.btDisplayWinner2.Name = "btDisplayWinner2"
        Me.btDisplayWinner2.Size = New System.Drawing.Size(157, 48)
        Me.btDisplayWinner2.TabIndex = 10
        Me.btDisplayWinner2.Text = "WINNER"
        Me.btDisplayWinner2.UseVisualStyleBackColor = True
        '
        'btDisplayWinner1
        '
        Me.btDisplayWinner1.Location = New System.Drawing.Point(12, 40)
        Me.btDisplayWinner1.Name = "btDisplayWinner1"
        Me.btDisplayWinner1.Size = New System.Drawing.Size(167, 48)
        Me.btDisplayWinner1.TabIndex = 11
        Me.btDisplayWinner1.Text = "WINNER"
        Me.btDisplayWinner1.UseVisualStyleBackColor = True
        '
        'btRandomResult
        '
        Me.btRandomResult.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btRandomResult.Location = New System.Drawing.Point(343, 137)
        Me.btRandomResult.Name = "btRandomResult"
        Me.btRandomResult.Size = New System.Drawing.Size(183, 120)
        Me.btRandomResult.TabIndex = 12
        Me.btRandomResult.Text = "0"
        Me.btRandomResult.UseVisualStyleBackColor = True
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 448)
        Me.Controls.Add(Me.btRandomResult)
        Me.Controls.Add(Me.btDisplayWinner1)
        Me.Controls.Add(Me.btDisplayWinner2)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.btPlayer2Confirm)
        Me.Controls.Add(Me.btPlayer1Confirm)
        Me.Controls.Add(Me.tbNumImputPlayer1)
        Me.Controls.Add(Me.tbNumImputPlayer2)
        Me.Controls.Add(Me.btPlayer2Stats)
        Me.Controls.Add(Me.btPlayer1Stats)
        Me.Controls.Add(Me.btConfirm)
        Me.Controls.Add(Me.tbNickname)
        Me.Name = "frmGame"
        Me.Text = "LuckyGame"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNickname As TextBox
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents btConfirm As Button
    Friend WithEvents btPlayer1Stats As Button
    Friend WithEvents btPlayer2Stats As Button
    Friend WithEvents tbNumImputPlayer2 As TextBox
    Friend WithEvents tbNumImputPlayer1 As TextBox
    Friend WithEvents btPlayer1Confirm As Button
    Friend WithEvents btPlayer2Confirm As Button
    Friend WithEvents btDisplayWinner2 As Button
    Friend WithEvents btDisplayWinner1 As Button
    Friend WithEvents btRandomResult As Button
End Class

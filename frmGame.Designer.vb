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
        Me.btDisplayGameResult = New System.Windows.Forms.Button()
        Me.btDisplayWinner2 = New System.Windows.Forms.Button()
        Me.btDisplayWinner1 = New System.Windows.Forms.Button()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbNickname
        '
        Me.tbNickname.Location = New System.Drawing.Point(337, 381)
        Me.tbNickname.Name = "tbNickname"
        Me.tbNickname.Size = New System.Drawing.Size(141, 23)
        Me.tbNickname.TabIndex = 0
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.LuckyGame.My.Resources.Resources.lucky_game_logo
        Me.pbLogo.Location = New System.Drawing.Point(161, -59)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(500, 434)
        Me.pbLogo.TabIndex = 1
        Me.pbLogo.TabStop = False
        '
        'btConfirm
        '
        Me.btConfirm.Location = New System.Drawing.Point(370, 410)
        Me.btConfirm.Name = "btConfirm"
        Me.btConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btConfirm.TabIndex = 2
        Me.btConfirm.Text = "Confirm"
        Me.btConfirm.UseVisualStyleBackColor = True
        '
        'btPlayer1Stats
        '
        Me.btPlayer1Stats.Location = New System.Drawing.Point(12, 235)
        Me.btPlayer1Stats.Name = "btPlayer1Stats"
        Me.btPlayer1Stats.Size = New System.Drawing.Size(100, 169)
        Me.btPlayer1Stats.TabIndex = 3
        Me.btPlayer1Stats.Text = "N/A"
        Me.btPlayer1Stats.UseVisualStyleBackColor = True
        '
        'btPlayer2Stats
        '
        Me.btPlayer2Stats.Location = New System.Drawing.Point(688, 235)
        Me.btPlayer2Stats.Name = "btPlayer2Stats"
        Me.btPlayer2Stats.Size = New System.Drawing.Size(100, 169)
        Me.btPlayer2Stats.TabIndex = 4
        Me.btPlayer2Stats.Text = "N/A"
        Me.btPlayer2Stats.UseVisualStyleBackColor = True
        '
        'tbNumImputPlayer2
        '
        Me.tbNumImputPlayer2.Location = New System.Drawing.Point(679, 110)
        Me.tbNumImputPlayer2.Name = "tbNumImputPlayer2"
        Me.tbNumImputPlayer2.Size = New System.Drawing.Size(109, 23)
        Me.tbNumImputPlayer2.TabIndex = 5
        Me.tbNumImputPlayer2.Text = "Numero de 1 a 100"
        '
        'tbNumImputPlayer1
        '
        Me.tbNumImputPlayer1.Location = New System.Drawing.Point(12, 110)
        Me.tbNumImputPlayer1.Name = "tbNumImputPlayer1"
        Me.tbNumImputPlayer1.Size = New System.Drawing.Size(111, 23)
        Me.tbNumImputPlayer1.TabIndex = 6
        Me.tbNumImputPlayer1.Text = "Numero de 1 a 100"
        '
        'btPlayer1Confirm
        '
        Me.btPlayer1Confirm.Location = New System.Drawing.Point(12, 159)
        Me.btPlayer1Confirm.Name = "btPlayer1Confirm"
        Me.btPlayer1Confirm.Size = New System.Drawing.Size(111, 23)
        Me.btPlayer1Confirm.TabIndex = 7
        Me.btPlayer1Confirm.Text = "Confirm"
        Me.btPlayer1Confirm.UseVisualStyleBackColor = True
        '
        'btPlayer2Confirm
        '
        Me.btPlayer2Confirm.Location = New System.Drawing.Point(679, 159)
        Me.btPlayer2Confirm.Name = "btPlayer2Confirm"
        Me.btPlayer2Confirm.Size = New System.Drawing.Size(111, 23)
        Me.btPlayer2Confirm.TabIndex = 8
        Me.btPlayer2Confirm.Text = "Confirm"
        Me.btPlayer2Confirm.UseVisualStyleBackColor = True
        '
        'btDisplayGameResult
        '
        Me.btDisplayGameResult.Location = New System.Drawing.Point(266, 52)
        Me.btDisplayGameResult.Name = "btDisplayGameResult"
        Me.btDisplayGameResult.Size = New System.Drawing.Size(252, 207)
        Me.btDisplayGameResult.TabIndex = 9
        Me.btDisplayGameResult.Text = "N/A"
        Me.btDisplayGameResult.UseVisualStyleBackColor = True
        '
        'btDisplayWinner2
        '
        Me.btDisplayWinner2.Location = New System.Drawing.Point(688, 40)
        Me.btDisplayWinner2.Name = "btDisplayWinner2"
        Me.btDisplayWinner2.Size = New System.Drawing.Size(89, 48)
        Me.btDisplayWinner2.TabIndex = 10
        Me.btDisplayWinner2.Text = "WINNER"
        Me.btDisplayWinner2.UseVisualStyleBackColor = True
        '
        'btDisplayWinner1
        '
        Me.btDisplayWinner1.Location = New System.Drawing.Point(23, 40)
        Me.btDisplayWinner1.Name = "btDisplayWinner1"
        Me.btDisplayWinner1.Size = New System.Drawing.Size(89, 48)
        Me.btDisplayWinner1.TabIndex = 11
        Me.btDisplayWinner1.Text = "WINNER"
        Me.btDisplayWinner1.UseVisualStyleBackColor = True
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btDisplayWinner1)
        Me.Controls.Add(Me.btDisplayWinner2)
        Me.Controls.Add(Me.btDisplayGameResult)
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
        Me.Text = "Form1"
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
    Friend WithEvents btDisplayGameResult As Button
    Friend WithEvents btDisplayWinner2 As Button
    Friend WithEvents btDisplayWinner1 As Button
End Class

Public Class frmGame

    'login
    Dim InsertNicknamePlayer1 As String
    Dim InsertNicknamePlayer2 As String
    Dim Player1Select As Boolean = False
    Dim Player2Select As Boolean = False

    Private Sub btConfirm_Click(sender As Object, e As EventArgs) Handles btConfirm.Click

        If Player1Select = False Then
            InsertNicknamePlayer1 = tbNickname.Text
            Player1Select = True

        ElseIf Player2Select = False Then
            InsertNicknamePlayer2 = tbNickname.Text
            Player2Select = True
            If Player2Select = True And Player1Select = True Then
                tbNickname.Visible = False
                btConfirm.Visible = False
                pbLogo.Visible = False

                btDisplayWinner1.Visible = True
                btDisplayWinner2.Visible = True
                tbNumImputPlayer1.Visible = True
                tbNumImputPlayer2.Visible = True
                btPlayer1Confirm.Visible = True
                btPlayer2Confirm.Visible = True
                btPlayer1Stats.Visible = True
                btPlayer2Stats.Visible = True

            End If
        End If


    End Sub

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btDisplayWinner1.Visible = False
        btDisplayWinner2.Visible = False
        tbNumImputPlayer1.Visible = False
        tbNumImputPlayer2.Visible = False
        btPlayer1Confirm.Visible = False
        btPlayer2Confirm.Visible = False
        btPlayer1Stats.Visible = False
        btPlayer2Stats.Visible = False
    End Sub
End Class
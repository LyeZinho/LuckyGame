Public Class frmGame

    'login
    Dim InsertNicknamePlayer1 As String
    Dim InsertNicknamePlayer2 As String
    Dim Player1Select As Boolean = False
    Dim Player2Select As Boolean = False
    'Game
    Dim JogadorClass As New JogadorClass
    Dim Player1Stats As String
    Dim Player2Stats As String

    Private Sub btConfirm_Click(sender As Object, e As EventArgs) Handles btConfirm.Click

        If Player1Select = False Then
            InsertNicknamePlayer1 = tbNickname.Text
            JogadorClass.SetPlayerOneNick(InsertNicknamePlayer1)
            Player1Select = True
            tbNickname.Text = "Nome Jogador 2"

        ElseIf Player2Select = False Then
            InsertNicknamePlayer2 = tbNickname.Text
            JogadorClass.SetPlayerTwoNick(InsertNicknamePlayer2)
            Player2Select = True
            If Player2Select = True And Player1Select = True Then
                tbNickname.Visible = False
                btConfirm.Visible = False
                pbLogo.Visible = False

                tbNumImputPlayer1.Visible = True
                tbNumImputPlayer2.Visible = True
                btPlayer1Confirm.Visible = True
                btPlayer2Confirm.Visible = True
                btPlayer1Stats.Visible = True
                btPlayer2Stats.Visible = True
                btRandomResult.Visible = True

                Dim _defautStatsVaule As Integer = 0
                JogadorClass.SetPlayerOneWins(_defautStatsVaule)
                JogadorClass.SetPlayerOneDefeats(_defautStatsVaule)
                JogadorClass.SetPlayerOnePlaycount(_defautStatsVaule)



                Player1Stats = JogadorClass.primeiroJogadorNick + "
Vitorias: " +
JogadorClass.primeiroJogadorVitorias.ToString + "
Jogadas: " +
JogadorClass.primeiroJogadorJogadas.ToString + "
Derrotas: " +
JogadorClass.primeiroJogadorDerrotas.ToString

                btPlayer1Stats.Text = Player1Stats

                JogadorClass.SetPlayerTwoWins(_defautStatsVaule)
                JogadorClass.SetPlayerTwoDefeats(_defautStatsVaule)
                JogadorClass.SetPlayerTwoPlaycount(_defautStatsVaule)

                Player2Stats = JogadorClass.segundoJogadorNick + "
Vitorias: " +
JogadorClass.segundoJogadorVitorias.ToString + "
Jogadas: " +
JogadorClass.segundoJogadorJogadas.ToString + "
Derrotas: " +
JogadorClass.segundoJogadorDerrotas.ToString

                btPlayer2Stats.Text = Player2Stats
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
        btRandomResult.Visible = False
        btDisplayWinner1.Visible = False
        btDisplayWinner2.Visible = False
    End Sub
End Class
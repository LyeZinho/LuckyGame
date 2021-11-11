Public Class frmGame

    'login
    Dim InsertNicknamePlayer1 As String
    Dim InsertNicknamePlayer2 As String
    Dim Player1Select As Boolean = False
    Dim Player2Select As Boolean = False
    'Game Stats
    Dim JogadorClass As New JogadorClass
    Dim Player1Stats As String
    Dim Player2Stats As String
    'Game Gameplay
    Dim Player1Imput As Integer
    Dim Player2Imput As Integer
    Dim Player1Confirmed As Boolean = False
    Dim Player2Confirmed As Boolean = False

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

    Private Sub btPlayer1Confirm_Click(sender As Object, e As EventArgs) Handles btPlayer1Confirm.Click
        Dim _imput = tbNumImputPlayer1.Text
        btDisplayWinner1.Visible = False
        btDisplayWinner2.Visible = False

        Try
            _imput = Convert.ToInt32(_imput)
        Catch ex As Exception
            tbNumImputPlayer1.Text = "Apenas numeros"
            _imput = 0
        End Try
        If _imput > 100 Then
            _imput = 100
        ElseIf _imput < 0 Then
            _imput = 0
        End If
        tbNumImputPlayer1.Text = _imput
        Player1Imput = _imput
        btPlayer1Confirm.Text = "Confirmed"
        JogadorClass.SetPlayerTwoNum(Player1Imput)
        Player1Confirmed = True
        If Player2Confirmed = True Then
            Dim rand = JogadorClass.RandNumber()
            JogadorClass.SetRandomNumVaule(rand)
            btRandomResult.Text = rand.ToString
            Dim result = JogadorClass.ProximidadeJogo()
            JogadorClass.SetPlayerTwoPlaycount(JogadorClass.segundoJogadorJogadas + 1)
            JogadorClass.SetPlayerOnePlaycount(JogadorClass.primeiroJogadorJogadas + 1)
            If result = 2 Then
                Player2Confirmed = False
                btPlayer2Confirm.Text = "Confirm"
                btDisplayWinner1.Visible = True
                Player1Confirmed = False
                btPlayer1Confirm.Text = "Confirm"


                btDisplayWinner1.Visible = True
                JogadorClass.SetPlayerOneWins(JogadorClass.primeiroJogadorVitorias + 1)
                JogadorClass.SetPlayerTwoDefeats(JogadorClass.segundoJogadorDerrotas + 1)
                UpdatUserStats()
            ElseIf result = 1 Then
                Player2Confirmed = False
                btPlayer2Confirm.Text = "Confirm"
                btDisplayWinner1.Visible = True
                Player1Confirmed = False
                btPlayer1Confirm.Text = "Confirm"


                btDisplayWinner2.Visible = True
                JogadorClass.SetPlayerOneDefeats(JogadorClass.primeiroJogadorDerrotas + 1)
                JogadorClass.SetPlayerTwoWins(JogadorClass.segundoJogadorVitorias + 1)
                UpdatUserStats()
            End If
        End If
    End Sub

    Private Sub btPlayer2Confirm_Click(sender As Object, e As EventArgs) Handles btPlayer2Confirm.Click
        Dim _imput = tbNumImputPlayer2.Text
        btDisplayWinner1.Visible = False
        btDisplayWinner2.Visible = False

        Try
            _imput = Convert.ToInt32(_imput)
        Catch ex As Exception
            tbNumImputPlayer2.Text = "Apenas numeros"
            _imput = 0
        End Try
        If _imput > 100 Then
            _imput = 100
        ElseIf _imput < 0 Then
            _imput = 0
        End If
        tbNumImputPlayer2.Text = _imput
        Player2Imput = _imput
        btPlayer2Confirm.Text = "Confirmed"
        JogadorClass.SetPlayerOneNum(Player2Imput)
        Player1Confirmed = True
        If Player1Confirmed = True Then
            Dim rand = JogadorClass.RandNumber()
            JogadorClass.SetRandomNumVaule(rand)
            btRandomResult.Text = rand.ToString
            Dim result = JogadorClass.ProximidadeJogo()
            JogadorClass.SetPlayerTwoPlaycount(JogadorClass.segundoJogadorJogadas + 1)
            JogadorClass.SetPlayerOnePlaycount(JogadorClass.primeiroJogadorJogadas + 1)
            Player2Confirmed = False
            If result = 1 Then
                Player2Confirmed = False
                btPlayer2Confirm.Text = "Confirm"
                Player1Confirmed = False
                btPlayer1Confirm.Text = "Confirm"

                btDisplayWinner2.Visible = True
                JogadorClass.SetPlayerTwoWins(JogadorClass.segundoJogadorVitorias + 1)
                JogadorClass.SetPlayerOneDefeats(JogadorClass.primeiroJogadorDerrotas + 1)

                UpdatUserStats()
            ElseIf result = 2 Then
                Player2Confirmed = False
                btPlayer2Confirm.Text = "Confirm"
                btDisplayWinner1.Visible = True
                Player1Confirmed = False
                btPlayer1Confirm.Text = "Confirm"

                btDisplayWinner1.Visible = True
                JogadorClass.SetPlayerTwoDefeats(JogadorClass.segundoJogadorDerrotas + 1)
                JogadorClass.SetPlayerOneWins(JogadorClass.primeiroJogadorVitorias + 1)

                UpdatUserStats()
            End If
        End If
    End Sub

    Sub UpdatUserStats()
        Player1Stats = JogadorClass.primeiroJogadorNick + "
Vitorias: " +
JogadorClass.primeiroJogadorVitorias.ToString + "
Jogadas: " +
JogadorClass.primeiroJogadorJogadas.ToString + "
Derrotas: " +
JogadorClass.primeiroJogadorDerrotas.ToString

        btPlayer1Stats.Text = Player1Stats

        Player2Stats = JogadorClass.segundoJogadorNick + "
Vitorias: " +
JogadorClass.segundoJogadorVitorias.ToString + "
Jogadas: " +
JogadorClass.segundoJogadorJogadas.ToString + "
Derrotas: " +
JogadorClass.segundoJogadorDerrotas.ToString

        btPlayer2Stats.Text = Player2Stats
    End Sub


End Class
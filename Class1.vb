Imports System

Public Class JogadorClass
    Public valorAleatorioGerado As Integer

    Public primeiroJogadorNum As Integer
    Public primeiroJogadorNick As String
    Public primeiroJogadorVitorias As Short
    Public primeiroJogadorJogadas As Short

    Public segundoJogadorNum As Integer
    Public segundoJogadorNick As String
    Public segundoJogadorVitorias As Short
    Public segundoJogadorJogadas As Short

    Public jogadorNick As String
    Public jogadorVitorias As Short
    Public JogadorJogadas As Short
    Public jogadorWinRate

    Sub SetRandomNumVaule(_imput)
        valorAleatorioGerado = _imput
    End Sub
    'Nota poderia ser gerado um construtor porem
    'muitos dados seriam desnessesario serem agrupados

    Function RandNumber()
        Dim Rd As New Random()
        Return Rd.Next(1, 100)
    End Function

    'Setar valores jogador 1 Algums são inutilizados
    Sub SetPlayerOneNum(_imput As Integer)
        primeiroJogadorNum = _imput
    End Sub
    Sub SetPlayerOneNick(_imput As Integer)
        primeiroJogadorNick = _imput
    End Sub
    Sub SetPlayerOneWins(_imput As Integer)
        primeiroJogadorVitorias = _imput
    End Sub
    Sub SetPlayerOnePlaycount(_imput As Integer)
        primeiroJogadorVitorias = _imput
    End Sub

    'Setar valores jogador 2 Algums são inutilizados
    Sub SetPlayerTwoNum(_imput As Integer)
        segundoJogadorNum = _imput
    End Sub
    Sub SetPlayerTwoNick(_imput As Integer)
        segundoJogadorNick = _imput
    End Sub
    Sub SetPlayerTwoWins(_imput As Integer)
        segundoJogadorVitorias = _imput
    End Sub
    Sub SetPlayerTwoHitcount(_imput As Integer)
        segundoJogadorVitorias = _imput
    End Sub

    'Setar valores jogador
    Sub SetPlayerNick(_imput As String)
        jogadorNick = _imput
    End Sub
    Sub SetPlayerWins(_imput As Short)
        jogadorVitorias = _imput
    End Sub
    Sub SetPlayerHitcount(_imput As Short)
        JogadorJogadas = _imput
    End Sub
    Sub SetPlayerWinrate(_imput As Short)
        jogadorWinRate = _imput
    End Sub

    'Procedimentos
    Function ProximidadeJogo() As Integer
        ' Distancia = Maior - Menor
        ' 1 -> Jogador 1
        ' 2 -> Jogador 2
        Dim JogadorMaisProximo
        If Math.Abs(primeiroJogadorNum - valorAleatorioGerado) <= Math.Abs(segundoJogadorNum - valorAleatorioGerado) Then
            JogadorMaisProximo = 1
        Else
            JogadorMaisProximo = 2
        End If
        Return JogadorMaisProximo
    End Function
    'WinRate
    Function WinRate(JogadorJogadas As Short, jogadorVitorias As Short) As String
        Dim Percent As Single
        Percent = jogadorVitorias / JogadorJogadas
        Return Format(Percent, "0.0%")
    End Function

End Class
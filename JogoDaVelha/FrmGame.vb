Public Class frmGame
    'C1L1|C2L1|C3L1
    'C1L2|C2L2|C3L2
    'C1L3|C2L3|C3L3
    Dim JogadorDaVez As Boolean = False
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnC3L3.Click, btnC3L2.Click, btnC3L1.Click, btnC2L3.Click, btnC2L2.Click, btnC2L1.Click, btnC1L3.Click, btnC1L2.Click, btnC1L1.Click
        Dim btns As Button = sender

        If JogadorDaVez = False Then
            btns.Text = "X"
            JogadorDaVez = True
        Else
            btns.Text = "O"
            JogadorDaVez = False
        End If

        GanhadorHorizontal()
        btns.Enabled = False
        GanhadorVertical()
        btns.Enabled = False
        GanhadorDiagonal()
        btns.Enabled = False

    End Sub
    Sub GanhadorHorizontal()
        If btnC1L1.Text = "X" And btnC2L1.Text = "X" And btnC3L1.Text = "X" Then
            btnC1L1.Text = "X"
            btnC2L1.Text = "X"
            btnC3L1.Text = "X"
            MessageBox.Show("O jogador X ganhou!")
        End If

        If btnC1L2.Text = "X" And btnC2L2.Text = "X" And btnC3L2.Text = "X" Then
            btnC1L2.Text = "X"
            btnC2L2.Text = "X"
            btnC3L2.Text = "X"
            MessageBox.Show("O jogador X ganhou!")
        End If

        If btnC1L3.Text = "X" And btnC2L3.Text = "X" And btnC3L3.Text = "X" Then
            btnC1L3.Text = "X"
            btnC2L3.Text = "X"
            btnC3L3.Text = "X"
            MessageBox.Show("O jogador X ganhou!")
        End If

        If btnC1L1.Text = "O" And btnC2L1.Text = "O" And btnC3L1.Text = "O" Then
            btnC1L1.Text = "O"
            btnC2L1.Text = "O"
            btnC3L1.Text = "O"
            MessageBox.Show("O jogador O ganhou!")
        End If

        If btnC1L2.Text = "O" And btnC2L2.Text = "O" And btnC3L2.Text = "O" Then
            btnC1L2.Text = "O"
            btnC2L2.Text = "O"
            btnC3L2.Text = "O"
            MessageBox.Show("O jogador O ganhou!")
        End If

        If btnC1L3.Text = "O" And btnC2L3.Text = "O" And btnC3L3.Text = "O" Then
            btnC1L3.Text = "O"
            btnC2L3.Text = "O"
            btnC3L3.Text = "O"
            MessageBox.Show("O jogador O ganhou!")
        End If
    End Sub
    Sub GanhadorVertical()
        If btnC1L1.Text = "X" And btnC1L2.Text = "X" And btnC1L3.Text = "X" Then
            btnC1L1.Text = "X"
            btnC1L2.Text = "X"
            btnC1L3.Text = "X"
            MessageBox.Show("O jogador X ganhou!")
        End If

        If btnC2L1.Text = "X" And btnC2L2.Text = "X" And btnC2L3.Text = "X" Then
            btnC2L1.Text = "X"
            btnC2L2.Text = "X"
            btnC2L3.Text = "X"
            MessageBox.Show("O jogador X ganhou!")
        End If

        If btnC3L1.Text = "X" And btnC3L2.Text = "X" And btnC3L3.Text = "X" Then
            btnC3L1.Text = "X"
            btnC3L2.Text = "X"
            btnC3L3.Text = "X"
            MessageBox.Show("O jogador X ganhou!")
        End If

        If btnC1L1.Text = "O" And btnC1L2.Text = "O" And btnC1L3.Text = "O" Then
            btnC1L1.Text = "O"
            btnC1L2.Text = "O"
            btnC1L3.Text = "O"
            MessageBox.Show("O jogador O ganhou!")
        End If

        If btnC2L1.Text = "O" And btnC2L2.Text = "O" And btnC2L3.Text = "O" Then
            btnC2L1.Text = "O"
            btnC2L2.Text = "O"
            btnC2L3.Text = "O"
            MessageBox.Show("O jogador O ganhou!")
        End If

        If btnC3L1.Text = "O" And btnC3L2.Text = "O" And btnC3L3.Text = "O" Then
            btnC3L1.Text = "O"
            btnC3L2.Text = "O"
            btnC3L3.Text = "O"
            MessageBox.Show("O jogador O ganhou!")
        End If
    End Sub
    Sub GanhadorDiagonal()
        If btnC1L1.Text = "X" And btnC2L2.Text = "X" And btnC3L3.Text = "X" Then
            btnC1L1.Text = "X"
            btnC2L2.Text = "X"
            btnC3L3.Text = "X"
            MessageBox.Show("O jogador X ganhou!")
        End If

        If btnC1L3.Text = "X" And btnC2L2.Text = "X" And btnC3L1.Text = "X" Then
            btnC1L3.Text = "X"
            btnC2L2.Text = "X"
            btnC3L1.Text = "X"
            MessageBox.Show("O jogador X ganhou!")
        End If

        If btnC1L1.Text = "O" And btnC2L2.Text = "O" And btnC3L3.Text = "O" Then
            btnC1L1.Text = "O"
            btnC2L2.Text = "O"
            btnC3L3.Text = "O"
            MessageBox.Show("O jogador O ganhou!")
        End If

        If btnC1L3.Text = "O" And btnC2L2.Text = "O" And btnC3L1.Text = "O" Then
            btnC1L3.Text = "O"
            btnC2L2.Text = "O"
            btnC3L1.Text = "O"
            MessageBox.Show("O jogador O ganhou!")
        End If
    End Sub
    Private Sub btnJogar_Click(sender As Object, e As EventArgs) Handles btnJogar.Click
        MessageBox.Show("Instrução: O jogador X inicia a partida e o jogador O é o secundário. Quem marcar a repetição do simbolo na horizontal, vertical ou diagonal, vence. Boa sorte!")
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnC1L1.Enabled = True
        btnC2L1.Enabled = True
        btnC3L1.Enabled = True
        btnC1L2.Enabled = True
        btnC2L2.Enabled = True
        btnC3L2.Enabled = True
        btnC1L3.Enabled = True
        btnC2L3.Enabled = True
        btnC3L3.Enabled = True

        btnC1L1.Text = " "
        btnC2L1.Text = " "
        btnC3L1.Text = " "
        btnC1L2.Text = " "
        btnC2L2.Text = " "
        btnC3L2.Text = " "
        btnC1L3.Text = " "
        btnC2L3.Text = " "
        btnC3L3.Text = " "
    End Sub

End Class
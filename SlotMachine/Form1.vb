Public Class Form1
    'Author: Matthew Murzaku
    'Date: 9/25/2019
    'Project Name: Slot Machine
    'Purpose of Project: Random Number Generators Variables, If … Then  statements

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTry.Click
        'Assigned random numbers to variable
        Dim num1 = RandomDigit()
        Dim num2 = RandomDigit()
        Dim num3 = RandomDigit()
        '3 Slots are assigned to the variables, num1, num2, and num3 which are randomizers.
        lblSlotOne.Text = num1
        lblSlotTwo.Text = num2
        lblSlotThree.Text = num3
        'If you win the jackpot, this is what happens below:
        If num1 = num2 And num2 = num3 Then
            picConfetti.Visible = True
            btnTry.Visible = False
            btnRestart.Visible = True
            lblBalanceAmount.Text = lblBalanceAmount.Text + 500
        Else
            picConfetti.Visible = False
        End If
        'If you run out of credits, this is what happens below:
        If lblBalanceAmount.Text < 10 Then
            btnTry.Enabled = False
        End If
        'Whenever you click try, you lose 5 credits
        lblBalanceAmount.Text = lblBalanceAmount.Text - 5
        'If you don't have any credits left, you cannot bet
        If btnTry.Enabled = False Then
            btnTryAgain.Visible = True
        End If

    End Sub
    'Number randomizer below:
    Private Function RandomDigit() As Integer
        Dim num As Integer = 0
        Randomize()
        num = CInt(Rnd() * 9)

        Return num
    End Function
    'What happens when you click Restart below after you win the jackpot:
    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        btnTry.Visible = True
        picConfetti.Visible = False
        btnRestart.Visible = False

    End Sub
    'What happens when you click Restart below after you run out of credits:
    Private Sub btnTryAgain_Click(sender As Object, e As EventArgs) Handles btnTryAgain.Click
        lblBalanceAmount.Text = 50
        btnTry.Enabled = True
        btnTryAgain.Visible = False
    End Sub
End Class

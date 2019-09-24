Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTry.Click
        Dim num1 = RandomDigit()
        Dim num2 = RandomDigit()
        Dim num3 = RandomDigit()

        Label1.Text = num1
        Label2.Text = num2
        Label3.Text = num3

        If num1 = num2 And num2 = num3 Then
            Label4.Text = "You won!"
            btnTry.Visible = False
            btnRestart.Visible = True
        Else
            Label4.Text = "Sorry!"
        End If


    End Sub
    Private Function RandomDigit() As Integer
        Dim num As Integer = 0
        Randomize()
        num = CInt(Rnd() * 9)

        Return num
    End Function

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        btnTry.Visible = True
        btnRestart.Visible = False
    End Sub
End Class

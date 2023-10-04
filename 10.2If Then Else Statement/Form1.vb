Public Class Form1
	Private Sub BtnBet_Click(sender As Object, e As EventArgs) Handles BtnBet.Click
		Dim myNum As Integer
		Dim LuckyNum As Integer


		myNum = InputBox("Enter your lucky number and click OK")
		LuckyNum = TextBox2.Text



		If myNum > LuckyNum Then

			MsgBox("Your number is too big")

		ElseIf myNum < LuckyNum Then

			MsgBox("Your number is too small")

		Else

			MsgBox("Congratulations! You strike the lucky number")

		End If



	End Sub
End Class

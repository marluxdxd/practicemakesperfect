Public Class Form15
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim result As Double

        Double.TryParse(TextBox.Text, num1)
        Double.TryParse(TextBox1.Text, num2)

        If num2 = 0 Then
            Label2.Text = "Infinity"
        Else
            result = num1 / num2
            Label2.Text = "Answer: " & result
        End If


    End Sub
End Class
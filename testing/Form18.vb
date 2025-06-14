Public Class Form18
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Double

        Double.TryParse(TextBox.Text, num)

        If num < 0 OrElse num > 100 Then
            Label.Text = "invalid number"
        Else
            Label.Text = "valid number"
        End If
    End Sub
End Class
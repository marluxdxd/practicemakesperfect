Public Class Form17
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'calculate the gross pay
        Const dblRATE As Double = 10.75
        Dim dblHours As Double
        Dim dblGross As Double

        'store hours in a variable
        Double.TryParse(TextBox.Text, dblHours)

        If dblHours < 0 OrElse dblHours > 40 Then
            Label.Text = "Incorrect number input"
        Else
            dblGross = dblHours * dblRATE
            Label.Text = dblGross.ToString("C2")
        End If
    End Sub
End Class
Public Class Form16
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' calculate the gross pay
        Const dblRATE As Double = 10.75
        Dim dblHours As Double
        Dim dblGross As Double

        'Store hours in variable

        Double.TryParse(TextBox.Text, dblHours)

        If dblHours >= 0 AndAlso dblHours <= 40 Then
            'calculate and display gross pay
            dblGross = dblHours * dblRATE
            Label.Text = dblGross.ToString("C2")
        Else
            Label.Text = "Incorrect number of hours"
        End If

    End Sub
End Class
Public Class Form22
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sales As Double
        Dim commission As Double

        Double.TryParse(TextBox1.Text, sales)


        If sales <= 10000 Then

            commission = sales * 0.03
        Else
            commission = sales * 0.05

        End If

        Label1.Text = commission

    End Sub
End Class
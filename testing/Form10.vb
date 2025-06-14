Public Class Form10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decPRICE As Decimal
        Dim quantity As Integer
        Dim total As Decimal
        Dim discount As Decimal

        Decimal.TryParse(TextBox1.Text, decPRICE)
        Integer.TryParse(TextBox2.Text, quantity)

        total = decPRICE * quantity

        If quantity > 10 Then
            discount = total * 0.2D ' 20% discount for less than 10 items
        Else
            discount = total * 0.1D ' Still 10% in both cases right now
        End If

        TextBox3.Text = (total - discount).ToString("C2") ' Optional: Show as currency
    End Sub
End Class
Public Class Form27
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim decItem1 As Decimal
        Dim decItem2 As Decimal
        Dim decTotal As Decimal

        Dim savings As Decimal


        If Decimal.TryParse(item1.text, decItem1) AndAlso Decimal.TryParse(item2.text, decItem2) Then
            'Determine which price is lower
            If decItem1 < decItem2 Then
                savings = decItem1 * 0.5
                decTotal = decItem1 * 0.5 + decItem2

            Else
                savings = decItem2 * 0.5
                decTotal = decItem2 * 0.5 + decItem1

            End If

            totalAmount.Text = "Total: " & decTotal.ToString("C2")

            MessageBox.Show("You saved " & savings.ToString("C2"), "Savings")


        Else
            MessageBox.Show("Please enter valid numbers for both items.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If





    End Sub
End Class
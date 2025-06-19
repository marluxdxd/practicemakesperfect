Public Class Form28
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim order As Integer
        Dim price As Decimal
        Dim total As Decimal
        Dim discount As Decimal

        If Integer.TryParse(order1.Text, order) AndAlso Decimal.TryParse(price1.text, price) Then

            total = order * price

            Dim response = MessageBox.Show("Are you a wholesaler?", "Customer Type", MessageBoxButtons.YesNo)

            If response = DialogResult.Yes Then
                discount = total * 0.1D
            Else
                discount = 0D
            End If

            discount1.Text = discount.ToString("C")
            total1.Text = (total - discount).ToString("C2")
            output1.Text = total.ToString("C2")
        Else
            MessageBox.Show("please enter number dont leave a blank")
        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
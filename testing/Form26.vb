Public Class Form26
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim intPoundTea As Integer
        Const decPricePerPound As Integer = 250D ' Assuming the price per pound of tea is 250
        Dim result As DialogResult
        Dim decTotal As Decimal
        Dim decShippingFee As Decimal = 0D


        If Integer.TryParse(intPound.Text, intPoundTea) Then

            decTotal = intPoundTea * decPricePerPound

            result = MessageBox.Show("Charge 15 for shipping?", "Shipping", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                decShippingFee = 15D ' Add shipping cost if user agrees
            End If

            Dim finalTotal As Decimal = decTotal + decShippingFee


            ShippingFee.Text = decShippingFee.ToString("C2")
            Price.Text = decPricePerPound.ToString("C2")
            TotalAmount.Text = finalTotal.ToString("C2")



        Else
            MessageBox.Show("Please enter a valid number of pounds of tea")
        End If

    End Sub

    Private Sub intPound_TextChanged(sender As Object, e As EventArgs) Handles intPound.TextChanged
        TotalAmount.Text = String.Empty
        ShippingFee.Text = String.Empty
        Price.Text = String.Empty
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
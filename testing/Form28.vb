﻿Public Class Form28
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim order As Integer
        Dim price As Decimal
        Dim discount As Decimal
        Dim total As Decimal

        If Integer.TryParse(order1.Text, order) AndAlso Decimal.TryParse(price1.Text, price) Then
            Dim response = MessageBox.Show("Are  you a wholesaler?", "Customer Type", MessageBoxButtons.YesNo)

            total = order * price

            If response = DialogResult.Yes Then
                discount = total * 0.1D

            Else
                discount = 0D
            End If


            discount1.Text = discount.ToString("C2")
            total1.Text = (total - discount).ToString("C2")

            output1.Text = total.ToString("C2")

        Else
            MessageBox.Show("Please enter a valid number in Quantity & Product Price")
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub order1_TextChanged(sender As Object, e As EventArgs) Handles order1.TextChanged
        discount1.Text = ""
        total1.Text = ""
        output1.Text = ""
    End Sub

    Private Sub price1_TextChanged(sender As Object, e As EventArgs) Handles price1.TextChanged
        discount1.Text = ""
        total1.Text = ""
        output1.Text = ""
    End Sub
End Class
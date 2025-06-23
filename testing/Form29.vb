Public Class Form29
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim input1 As Double
        Dim input2 As Double
        Dim big As Double
        Dim small As Double
        Dim result As Double

        If Double.TryParse(num1.Text, input1) AndAlso Double.TryParse(num2.Text, input2) Then
            If input1 > input2 Then
                big = input1
                small = input2
            Else
                big = input2
                small = input1
            End If

            If small = 0 Then
                output1.Text = "Cannot divided by 0"
            Else
                result = big / small
                output1.Text = "Result: " & result.ToString()
            End If
        Else
            MessageBox.Show("Please input a valid number input1 & input2")
        End If

    End Sub
End Class
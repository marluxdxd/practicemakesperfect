Public Class Form29
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim input1 As Double
        Dim input2 As Double
        Dim bigger As Double
        Dim small As Double
        Dim result As Double
        Dim test As Double


        If Double.TryParse(num1.Text, input1) AndAlso Double.TryParse(num2.Text, input2) Then



            If input1 > input2 Then
                bigger = input1
                small = input2

            Else
                bigger = input2
                small = input1
            End If

            If small = 0 Then
                output1.Text = "Cannot divide by 0"
            Else
                result = bigger / small
                output1.Text = "Result:" & result.ToString()
            End If





        Else
            MessageBox.Show("Please input valid number in Input 1 & Input 2")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
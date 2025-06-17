Public Class Form25

    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim decSalary As Decimal
        Dim intPayGrade As Integer
        Dim raise As Decimal
        Dim newsalary As Decimal


        If Decimal.TryParse(txtSalary.Text, decSalary) AndAlso Integer.TryParse(txtPayGrade.Text, intPayGrade) Then
            If intPayGrade = 1 Or intPayGrade = 2 Or intPayGrade = 3 Then
                raise = decSalary * 0.03D
            Else
                raise = decSalary * 0.02D
            End If


            newsalary = decSalary + raise

            MessageBox.Show("Your new salary is " & vbCrLf & newsalary.ToString("C2") & vbCrLf, "New Salary", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Please enter valid numeric values for salary and pay grade.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class
Public Class Form14
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim firstnum As Double
        Dim secondnum As Double
        Dim output As Double

        'hold the value ,if the user enter'
        Integer.TryParse(TextBox1.Text, num1)
        Double.TryParse(TextBox2.Text, firstnum)
        Double.TryParse(TextBox3.Text, secondnum)

        If num1 = 1 Then
            output = firstnum * secondnum
            output = num1
            Label4.Text = output
        ElseIf num1 = 2 Then
            If secondnum = 0 Then
                Label4.Text = "Cannot divide by zero"
            Else
                output = firstnum / secondnum
                Label4.Text = output.ToString()
            End If
        Else
            ' Invalid input for num1
            MessageBox.Show("Only type 1 for Multiplication & type 2 for Division")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
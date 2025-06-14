Public Class Form21
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim letter As String

        letter = TextBox1.Text.ToUpper

        If letter = "A" Then
            Label1.Text = "Addition"
        ElseIf letter = "S" Then
            Label1.Text = "Subtraction"
        Else
            Label1.Text = "Unknown operation"

        End If

    End Sub
End Class
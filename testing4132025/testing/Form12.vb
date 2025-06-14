Public Class Form12
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim score1 As Integer
        Dim score2 As Integer

        Integer.TryParse(TextBox1.Text, score1)
        Integer.TryParse(TextBox2.Text, score2)

        If score1 > score2 Then
            Dim temp As Integer
            temp = score1
            score1 = score2
            score2 = temp


            lblMessage.Text = "lowest score: " & Convert.ToString(score1) & vbCrLf &
                              "highest score: " & Convert.ToString(score2)
        End If
    End Sub
End Class
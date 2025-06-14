Public Class Form13
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addition As Integer = 1
        Dim subtraction As Integer = 2
        Dim firstnum As Integer
        Dim secondnum As Integer
        Dim operate As Integer

        Integer.TryParse(TextBox1.Text, operate)
        Integer.TryParse(TextBox2.Text, firstnum)
        Integer.TryParse(TextBox3.Text, secondnum)


        If operate < 3 Then
            If operate = addition Then
                operate = firstnum + secondnum
                Label4.Text =
                    "Sum" & operate
            ElseIf operate = subtraction Then
                operate = firstnum - secondnum
                Label4.Text =
                    "Difference" & operate
            End If
        Else
            MessageBox.Show("only 1 and 2")
        End If
    End Sub
End Class
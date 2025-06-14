Public Class Form20
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strname As String

        strname = TextBox1.Text.ToUpper()

        If strname <> "MARLU" OrElse
              strname <> "MARLUCIA" OrElse
              strname <> "MARLUZETTE" Then


            Label1.Text = "not"
        Else
            Label1.Text = "on"
        End If
    End Sub
End Class
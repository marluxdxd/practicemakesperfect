Public Class Form11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim anualsales As Integer
        Dim anualbonus As Decimal

        Integer.TryParse(TextBox1.Text, anualsales)

        anualsales = anualsales
        If anualsales > 10000 Then
            anualbonus = anualsales * 0.02
        Else
            anualbonus = anualsales * 0.025
        End If

        TextBox2.Text = anualbonus
    End Sub
End Class
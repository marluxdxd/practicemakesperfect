Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decOwed As Decimal
        Dim decPaid As Decimal
        Dim decChangeDue As Decimal

        Dim intChangeInCents As Integer
        Dim dollars As Integer
        Dim quarters As Integer
        Dim dimes As Integer
        Dim nickels As Integer
        Dim pennies As Integer

        ' Correct parsing using Decimal
        Decimal.TryParse(TextBox1.Text, decOwed)
        Decimal.TryParse(TextBox2.Text, decPaid)

        ' Calculate change
        decChangeDue = decPaid - decOwed
        TextBox3.Text = decChangeDue.ToString("C")

        ' Convert to cents
        intChangeInCents = CInt(Math.Round(decChangeDue * 100))

        ' Breakdown
        dollars = intChangeInCents \ 100
        intChangeInCents = intChangeInCents Mod 100

        quarters = intChangeInCents \ 25
        intChangeInCents = intChangeInCents Mod 25

        dimes = intChangeInCents \ 10
        intChangeInCents = intChangeInCents Mod 10

        nickels = intChangeInCents \ 5
        intChangeInCents = intChangeInCents Mod 5

        pennies = intChangeInCents

        ' Output
        TextBox4.Text = dollars.ToString()
        TextBox5.Text = quarters.ToString()
        TextBox6.Text = dimes.ToString()
        TextBox7.Text = nickels.ToString()
        TextBox8.Text = pennies.ToString()
    End Sub
End Class

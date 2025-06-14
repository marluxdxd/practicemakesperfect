Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decCENT As Decimal
        Dim decPAID As Decimal
        Dim decCHANGEDUE As Decimal

        Dim intChangeInCents As Integer
        Dim pesos1000 As Integer
        Dim pesos500 As Integer
        Dim pesos200 As Integer
        Dim pesos100 As Integer
        Dim pesos50 As Integer
        Dim pesos20 As Integer
        Dim pesos10 As Integer
        Dim pesos1 As Integer
        Dim centavos25 As Integer
        Dim centavos1 As Integer


        Decimal.TryParse(TextBox1.Text, decCENT)
        Decimal.TryParse(TextBox2.Text, decPAID)

        decCHANGEDUE = decPAID - decCENT
        TextBox3.Text = decCHANGEDUE.ToString("C")


        ' Convert to cents (multiply by 100 to avoid decimals)
        intChangeInCents = CInt(Math.Round(decCHANGEDUE * 100))

        pesos1000 = intChangeInCents \ 100000
        intChangeInCents = intChangeInCents Mod 100000

        pesos500 = intChangeInCents \ 50000
        intChangeInCents = intChangeInCents Mod 50000

        pesos200 = intChangeInCents \ 20000
        intChangeInCents = intChangeInCents Mod 20000

        pesos100 = intChangeInCents \ 10000
        intChangeInCents = intChangeInCents Mod 10000

        pesos50 = intChangeInCents \ 5000
        intChangeInCents = intChangeInCents Mod 5000

        pesos20 = intChangeInCents \ 2000
        intChangeInCents = intChangeInCents Mod 2000

        pesos10 = intChangeInCents \ 1000
        intChangeInCents = intChangeInCents Mod 1000

        pesos1 = intChangeInCents \ 100
        intChangeInCents = intChangeInCents Mod 100

        centavos25 = intChangeInCents \ 25
        intChangeInCents = intChangeInCents Mod 25

        centavos1 = intChangeInCents \ 1
        intChangeInCents = intChangeInCents Mod 1






        TextBox4.Text = pesos1000
        TextBox5.Text = pesos500
        TextBox12.Text = pesos200
        TextBox6.Text = pesos100
        TextBox7.Text = pesos50
        TextBox9.Text = pesos20
        TextBox10.Text = pesos10
        TextBox11.Text = pesos1
        TextBox8.Text = centavos25
        TextBox13.Text = centavos1





    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
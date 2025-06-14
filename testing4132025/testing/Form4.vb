Option Explicit On
Option Strict On
Option Infer Off
Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intnumpenies As Integer
        Dim decdollars As Decimal
        Dim intquarters As Integer
        Dim intdimes As Integer
        Dim intnickels As Integer
        Dim intpennies As Integer
        Dim intremainingpennies As Integer

        Integer.TryParse(TextBox1.Text, intnumpenies)
        ' Dollars computation
        decdollars = intnumpenies \ 100
        intremainingpennies = intnumpenies Mod 100

        ' Quarters computation
        intquarters = intremainingpennies \ 25
        intremainingpennies = intremainingpennies Mod 25 ' Update remaining pennies after quarters

        ' Dimes computation
        intdimes = intremainingpennies \ 10
        intremainingpennies = intremainingpennies Mod 10

        ' Nickerls computation
        intnickels = intremainingpennies \ 5
        intpennies = intremainingpennies Mod 5


        ' Display the result in textbox & label
        TextBox2.Text = decdollars.ToString()
        Label7.Text = intremainingpennies.ToString() ' Corrected variable name
        TextBox3.Text = intquarters.ToString()
        Label8.Text = intremainingpennies.ToString() ' Corrected variable name
        TextBox4.Text = intdimes.ToString()
        Label9.Text = intremainingpennies.ToString() ' Corrected variable name
        TextBox5.Text = intnickels.ToString()
        Label10.Text = intremainingpennies.ToString() ' Corrected variable name
        TextBox6.Text = intpennies.ToString()
        Label11.Text = intremainingpennies.ToString() ' Corrected variable name
        ' Display the results
        MessageBox.Show("Dollars: " & decdollars.ToString() & vbCrLf &
                        "Quarters: " & intquarters.ToString() & vbCrLf &
                        "Dimes: " & intdimes.ToString() & vbCrLf &
                        "Nickels: " & intnickels.ToString() & vbCrLf &
                        "Pennies: " & intpennies.ToString(), "Coin Conversion")

    End Sub
End Class
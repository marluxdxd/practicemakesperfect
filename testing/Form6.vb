Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decMERCHANDISE As Decimal
        Dim decRESTAURANTS As Decimal
        Dim decGASOLINE As Decimal
        Dim dEctravel As Decimal
        Dim decservices As Decimal
        Dim decsupermarkets As Decimal
        Dim totalmonth As Decimal
        Dim totalannual As Decimal
        Dim totalpercent As Decimal


        Decimal.TryParse(TextBox1.Text, decMERCHANDISE)
        Decimal.TryParse(TextBox2.Text, decRESTAURANTS)
        Decimal.TryParse(TextBox3.Text, decGASOLINE)
        Decimal.TryParse(TextBox4.Text, dEctravel)
        Decimal.TryParse(TextBox5.Text, decservices)
        Decimal.TryParse(TextBox6.Text, decsupermarkets)
        '600
        totalmonth = decMERCHANDISE + decRESTAURANTS + decGASOLINE + dEctravel + decservices + decsupermarkets

        '600 X12 = 7200
        totalannual = totalmonth * 12
        '100 X12 = 1200   / 600X12 = 7200     
        decMERCHANDISE = (decMERCHANDISE * 12) / totalannual * 100
        decRESTAURANTS = (decRESTAURANTS * 12) / totalannual * 100
        decGASOLINE = (decGASOLINE * 12) / totalannual * 100
        dEctravel = (dEctravel * 12) / totalannual * 100
        decservices = (decservices * 12) / totalannual * 100
        decsupermarkets = (decsupermarkets * 12) / totalannual * 100

        totalpercent = decMERCHANDISE + decRESTAURANTS + decGASOLINE + dEctravel + decservices + decsupermarkets


        Label7.Text = "➕ Total Monthly Charges: " & totalmonth.ToString("C2")
        Label8.Text = "🗓 Total Annual Charges: " & totalannual.ToString("C2")
        Label9.Text = "Merchandise: " & decMERCHANDISE.ToString("N2") & "%" & vbCrLf &
                      "Restaurants: " & decRESTAURANTS.ToString("N2") & "%" & vbCrLf &
                      "Gasoline: " & decGASOLINE.ToString("N2") & "%" & vbCrLf &
                      "Travel: " & dEctravel.ToString("N2") & "%" & vbCrLf &
                      "Services: " & decservices.ToString("N2") & "%" & vbCrLf &
                      "Supermarkets: " & decsupermarkets.ToString("N2") & "%" & vbCrLf &
                      "Total: " & totalpercent.ToString("N0") & "%"

    End Sub
End Class
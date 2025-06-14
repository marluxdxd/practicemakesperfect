Option Explicit On
Option Infer On
Option Strict On
Imports System.Security.Cryptography

Public Class Form5
    Dim dblLoan As Double
    Dim dblInsurance As Double
    Dim dblOil As Double
    Dim dblMaintenance As Double
    Dim dblCarwashes As Double
    Dim dblGas As Double
    Dim dblMONTHLY As Double
    Dim dblYEARLY As Double


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Double.TryParse(TextBox1.Text.Replace("₱", ""), dblLoan)
        Double.TryParse(TextBox2.Text, dblInsurance)
        Double.TryParse(TextBox3.Text, dblOil)
        Double.TryParse(TextBox4.Text, dblMaintenance)
        Double.TryParse(TextBox4.Text, dblCarwashes)
        Double.TryParse(TextBox5.Text, dblGas)


        dblMONTHLY = (dblLoan + dblInsurance + dblOil + dblMaintenance + dblCarwashes + dblGas)
        dblYEARLY = dblMONTHLY * 12

        Label7.Text = "Monthly expenses: " & dblMONTHLY.ToString("C2")
        Label8.Text = "Yearly expenses: " & dblYEARLY.ToString("C2")








    End Sub


End Class
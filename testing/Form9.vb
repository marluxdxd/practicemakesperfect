Option Explicit On
Option Infer On
Option Strict On
Imports System.ComponentModel.DataAnnotations

Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rooms As Integer
        Dim nights As Integer
        Dim adults As Integer
        Dim children As Integer
        Const taxprice As Decimal = 0.1525D
        Dim roompay As Integer
        Dim taxpay As Decimal
        Dim resortfee As Decimal
        Dim totaldue As Decimal
        Dim capacity As Integer

        Integer.TryParse(txtrooms.Text, rooms)
        Integer.TryParse(txtnights.Text, nights)
        Integer.TryParse(txtadults.Text, adults)
        Integer.TryParse(txtchildren.Text, children)




        If Not Integer.TryParse(txtrooms.Text, rooms) OrElse
           Not Integer.TryParse(txtnights.Text, nights) OrElse
           Not Integer.TryParse(txtadults.Text, adults) OrElse
           Not Integer.TryParse(txtchildren.Text, children) Then
            MessageBox.Show("Please enter valid numbers.")
            Exit Sub
        End If

        ' Calculate total number of guests and check if it exceeds room capacity
        capacity = adults + children
        If capacity > rooms * 6 Then
            MessageBox.Show("Total number of guests exceeds room capacity (6 guests per room).")
            Exit Sub
        End If

        roompay = (rooms * nights) * 284
            taxpay = roompay * taxprice
            resortfee = (rooms * nights) * 15
            totaldue = roompay + taxpay + resortfee

            txtroompay.Text = roompay.ToString("C")
            txttaxpay.Text = taxpay.ToString("C")
            txtresortfee.Text = resortfee.ToString("C")
        txttotaldue.Text = totaldue.ToString("C")

    End Sub
End Class
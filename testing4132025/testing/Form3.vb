Public Class Form3
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decPESO As Decimal
        Const euro As Decimal = 0.016D 'IN 1 PESO.
        Const swissfranc As Decimal = 0.015 'IN 1 PESO. 
        Const southafricanrand As Decimal = 0.34D 'IN 1 PESO.


        Decimal.TryParse(TextBox1.Text, decPESO)

        TextBox2.Text = (decPESO * euro).ToString() & "€"
        TextBox3.Text = (decPESO * swissfranc).ToString() & "CHF"
        TextBox4.Text = (decPESO * southafricanrand).ToString() & "R"



    End Sub
End Class
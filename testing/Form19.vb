Public Class Form19


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declare a variable to store the customer name
        Dim strCustomer As String

        ' Assign a value to the customer variable
        strCustomer = "test"

        ' Display the uppercase version of the customer name in the label
        Label1.Text = strCustomer.ToUpper()
    End Sub
End Class
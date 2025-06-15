Public Class Form23
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim roomPRICE As Double = 284
        Dim room As Integer
        Dim nights As Integer
        Dim adults As Integer
        Dim children As Integer
        Dim intnumguest As Integer

        Const tax As Double = 0.1525
        Const intmax_per_room As Integer = 6
        Const strMSG As String = "PUNO NA ADD MO ANOTHER ROOM KAY ANG OSA KA ROOM MAX ONLY 6 PERSON"
        Dim totalroom As Double
        Dim tax1 As Double
        Dim totalresortfee As Double
        Dim totaldue As Double
        Dim dblroomrequired As Double

     'give as error if this 4 input blank or not numeric give the user error prompt individually 
            MessageBox.Show("Please enter valid numeric values for ROOM", "Input Error")
            Exit Sub
        End If

        If Not Double.TryParse(intnights.Text, nights) Then
            MessageBox.Show("Please enter valid numeric values for NIGHT", "Input Error")
            Exit Sub
        End If

        If Not Double.TryParse(intadults.Text, adults) Then
            MessageBox.Show("Please enter valid numeric values for all ADULT", "Input Error")
            Exit Sub
        End If

        If Not Double.TryParse(intchildren.Text, children) Then
            MessageBox.Show("Please enter valid numeric values for all CHILDREN", "Input Error")
            Exit Sub
        End If


        intnumguest = adults + children
        dblroomrequired = intnumguest / intmax_per_room
        ' determine whether number of reserved
        ' rooms is adequate and then either display a
        ' message or calculate and display the charges
        If room < dblroomrequired Then
            MessageBox.Show(strMSG, "Covington Resort",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)
        Else

            ' Calculate total price
            totalroom = room * nights * roomPRICE
            tax1 = totalroom * tax
            totalresortfee = room * nights * 15
            totaldue = totalroom + tax1 + totalresortfee





            ' Display results
            'test one more commit
            TextBox5.Text = totalroom.ToString("C")
            TextBox6.Text = tax1.ToString("C")
            TextBox7.Text = totalresortfee.ToString("C")
            TextBox8.Text = totaldue.ToString("C2")

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class

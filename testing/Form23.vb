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



        Double.TryParse(introoms.Text, room)
        Double.TryParse(intnights.Text, nights)
        Double.TryParse(intadults.Text, adults)
        Double.TryParse(intchildren.Text, children)


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
            'test
            TextBox5.Text = totalroom.ToString("C")
            TextBox6.Text = tax1.ToString("C")
            TextBox7.Text = totalresortfee.ToString("C")
            TextBox8.Text = totaldue.ToString("C2")

        End If



    End Sub

End Class
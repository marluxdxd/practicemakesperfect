Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        Using conn As New SqlConnection("Data Source=msi\sqlexpress;Initial Catalog=USER;Integrated Security=True")
            Dim query As String = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                conn.Open()
                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                conn.Close()

                If result > 0 Then
                    ' Open another form or grant access

                    Dim dashboard As New Form2()
                    dashboard.Show()
                    Me.Hide()



                Else
                    MessageBox.Show("Invalid username or password")
                End If
            End Using
        End Using
    End Sub

    Private Sub CurrencyCalculaltorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrencyCalculaltorToolStripMenuItem.Click
        Dim dashboard As New Form3()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub PenniesCalcultorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenniesCalcultorToolStripMenuItem.Click
        Dim dashboard As New Form4()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub CarProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarProjectToolStripMenuItem.Click
        Dim dashboard As New Form5()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub CreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreToolStripMenuItem.Click
        Dim dashboard As New Form6()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ChangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeToolStripMenuItem.Click
        Dim dashboard As New Form7()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ChangePhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePhToolStripMenuItem.Click
        Dim dashboard As New Form8()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ConversionFunctionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversionFunctionToolStripMenuItem.Click
        Dim dashboard As New Form9()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub TradingStoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TradingStoreToolStripMenuItem.Click
        Dim dashboard As New Form10()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub KettlesonBonusCalculatorP221ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KettlesonBonusCalculatorP221ToolStripMenuItem.Click
        Dim dashboard As New Form11()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub LowestHighestP224ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LowestHighestP224ToolStripMenuItem.Click
        Dim dashboard As New Form12()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub SumOrDifference224ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumOrDifference224ToolStripMenuItem.Click
        Dim dashboard As New Form13()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub YouDoIt3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouDoIt3ToolStripMenuItem.Click
        Dim dashboard As New Form14()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub YouDoIt4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouDoIt4ToolStripMenuItem.Click
        Dim dashboard As New Form15()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub LoginMdhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginMdhToolStripMenuItem.Click

    End Sub
End Class

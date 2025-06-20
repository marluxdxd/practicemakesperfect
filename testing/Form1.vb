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


    Private Sub P233ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles P233ToolStripMenuItem.Click
        Dim dashboard As New Form16()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub GrossPay2P234ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrossPay2P234ToolStripMenuItem.Click
        Dim dashboard As New Form17()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub YouDoIt5235ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouDoIt5235ToolStripMenuItem.Click
        Dim dashboard As New Form18()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub P238ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles P238ToolStripMenuItem.Click
        Dim dashboard As New Form19()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub F20PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F20PToolStripMenuItem.Click
        Dim dashboard As New Form20()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub F21PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F21PToolStripMenuItem.Click
        Dim dashboard As New Form21()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub F22P2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F22P2ToolStripMenuItem.Click
        Dim dashboard As New Form22()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub MarluToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarluToolStripMenuItem.Click
        Dim dashboard As New Form23()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub P238ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles P238ToolStripMenuItem1.Click
        Dim dashnboard As New Form24()
        dashnboard.Show()
        Me.Hide()
    End Sub

    Private Sub JonasConP238ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JonasConP238ToolStripMenuItem.Click
        Dim dashnboard As New Form25()
        dashnboard.Show()
        Me.Hide()
    End Sub

    Private Sub TeaTimeCompanyP238ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeaTimeCompanyP238ToolStripMenuItem.Click
        Dim dashboard As New Form26()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub MercyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MercyToolStripMenuItem.Click
        Dim dashboard As New Form27()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub CorondoIndustriesP265ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorondoIndustriesP265ToolStripMenuItem.Click
        Dim dashboard As New Form28()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub P265ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles P265ToolStripMenuItem.Click
        Dim dashboard As New Form29()
        dashboard.Show()
        Me.Hide()
    End Sub
End Class

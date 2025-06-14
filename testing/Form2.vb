
Option Explicit On
Option Infer On
Option Strict On

Public Class Form2

    Const decPRICEDVD As Decimal = 10D
    Const decPRICEBLURAY As Decimal = 15D
    Const strPROMPT As String = "Salesperson"
    Const strTITLE As String = "Name entry"

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Const decDIS1PRICE As Decimal = 0.3D
        Const decDIS2DISPRICE As Decimal = 0.1D
        Dim dis1 As Decimal


        Dim intDVDS As Integer
        Dim intBLURAY As Integer
        Dim decTOTALDISCS As Decimal
        Dim decTOTALSALES As Decimal

        Integer.TryParse(TextBox1.Text, intDVDS)
        Integer.TryParse(TextBox2.Text, intBLURAY)

        decTOTALDISCS = intDVDS + intBLURAY
        decTOTALSALES = (intDVDS * decPRICEDVD) + (intBLURAY * decPRICEBLURAY)

        TextBox3.Text = decTOTALDISCS.ToString("N0")
        TextBox4.Text = decTOTALSALES.ToString("C2")

        If decTOTALDISCS >= 10 Then
            decTOTALSALES = decTOTALSALES - (decTOTALSALES * decDIS1PRICE)
            dis1 = decDIS1PRICE * 100
        Else
            decTOTALSALES = decTOTALSALES - (decTOTALSALES * decDIS2DISPRICE)
            dis1 = decDIS2DISPRICE * 100
        End If
        decTOTALDISCS = decTOTALDISCS
        TextBox5.Text = dis1.ToString("N0") & "%"
        Label6.Text = "Total Amount: " & decTOTALSALES.ToString("C2")



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize Label10 and Label11 with DVD and Blu-ray prices when the form loads
        Static strName As String
        'Do
        strName = InputBox(strPROMPT, strTITLE, strName)

        ' Check if user clicked Cancel
        ' If strName = "" Then
        'MessageBox.Show("You must enter a value.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End' If
        ' Loop While strName = ""

        Label10.Text = decPRICEDVD.ToString("C2")
        Label11.Text = decPRICEBLURAY.ToString("C2")

    End Sub

    Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnights = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtrooms = New System.Windows.Forms.TextBox()
        Me.txtroompay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtadults = New System.Windows.Forms.TextBox()
        Me.txtchildren = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttaxpay = New System.Windows.Forms.TextBox()
        Me.txtresortfee = New System.Windows.Forms.TextBox()
        Me.txttotaldue = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtchildren)
        Me.GroupBox1.Controls.Add(Me.txtadults)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnights)
        Me.GroupBox1.Controls.Add(Me.txtrooms)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 316)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Number of"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txttotaldue)
        Me.GroupBox2.Controls.Add(Me.txtresortfee)
        Me.GroupBox2.Controls.Add(Me.txttaxpay)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtroompay)
        Me.GroupBox2.Location = New System.Drawing.Point(364, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 306)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Charges"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(47, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 29)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "rooms"
        '
        'txtnights
        '
        Me.txtnights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnights.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnights.Location = New System.Drawing.Point(189, 48)
        Me.txtnights.Name = "txtnights"
        Me.txtnights.Size = New System.Drawing.Size(60, 40)
        Me.txtnights.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 29)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "room"
        '
        'txtrooms
        '
        Me.txtrooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrooms.Location = New System.Drawing.Point(35, 48)
        Me.txtrooms.Name = "txtrooms"
        Me.txtrooms.Size = New System.Drawing.Size(61, 40)
        Me.txtrooms.TabIndex = 53
        '
        'txtroompay
        '
        Me.txtroompay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtroompay.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtroompay.Location = New System.Drawing.Point(150, 22)
        Me.txtroompay.Name = "txtroompay"
        Me.txtroompay.Size = New System.Drawing.Size(180, 40)
        Me.txtroompay.TabIndex = 54
        Me.txtroompay.Text = "284"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 29)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "nights"
        '
        'txtadults
        '
        Me.txtadults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtadults.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadults.Location = New System.Drawing.Point(35, 201)
        Me.txtadults.Name = "txtadults"
        Me.txtadults.Size = New System.Drawing.Size(61, 40)
        Me.txtadults.TabIndex = 55
        '
        'txtchildren
        '
        Me.txtchildren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtchildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchildren.Location = New System.Drawing.Point(189, 201)
        Me.txtchildren.Name = "txtchildren"
        Me.txtchildren.Size = New System.Drawing.Size(60, 40)
        Me.txtchildren.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 29)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "adults18+"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(184, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 29)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "children"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(201, 397)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 49)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 29)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "resort fee"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 29)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "tax"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 29)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "total due"
        '
        'txttaxpay
        '
        Me.txttaxpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttaxpay.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttaxpay.Location = New System.Drawing.Point(150, 82)
        Me.txttaxpay.Name = "txttaxpay"
        Me.txttaxpay.Size = New System.Drawing.Size(180, 40)
        Me.txttaxpay.TabIndex = 58
        '
        'txtresortfee
        '
        Me.txtresortfee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtresortfee.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresortfee.Location = New System.Drawing.Point(150, 144)
        Me.txtresortfee.Name = "txtresortfee"
        Me.txtresortfee.Size = New System.Drawing.Size(180, 40)
        Me.txtresortfee.TabIndex = 59
        '
        'txttotaldue
        '
        Me.txttotaldue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotaldue.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotaldue.Location = New System.Drawing.Point(150, 213)
        Me.txttotaldue.Name = "txttotaldue"
        Me.txttotaldue.Size = New System.Drawing.Size(180, 40)
        Me.txttotaldue.TabIndex = 60
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 475)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtnights As TextBox
    Friend WithEvents txtrooms As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtroompay As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtchildren As TextBox
    Friend WithEvents txtadults As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txttotaldue As TextBox
    Friend WithEvents txtresortfee As TextBox
    Friend WithEvents txttaxpay As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
End Class

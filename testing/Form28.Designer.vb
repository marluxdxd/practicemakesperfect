<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form28
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
        Me.test = New System.Windows.Forms.Label()
        Me.total1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.price1 = New System.Windows.Forms.TextBox()
        Me.order1 = New System.Windows.Forms.TextBox()
        Me.calculate = New System.Windows.Forms.Button()
        Me.discount1 = New System.Windows.Forms.TextBox()
        Me.output1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'test
        '
        Me.test.AutoSize = True
        Me.test.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.test.Location = New System.Drawing.Point(248, 140)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(108, 25)
        Me.test.TabIndex = 71
        Me.test.Text = "Total due:"
        '
        'total1
        '
        Me.total1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total1.Location = New System.Drawing.Point(253, 168)
        Me.total1.Name = "total1"
        Me.total1.Size = New System.Drawing.Size(141, 31)
        Me.total1.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Product price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 25)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Discount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 25)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Quantity ordered:"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(222, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 35)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'price1
        '
        Me.price1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price1.Location = New System.Drawing.Point(253, 83)
        Me.price1.Name = "price1"
        Me.price1.Size = New System.Drawing.Size(141, 31)
        Me.price1.TabIndex = 65
        '
        'order1
        '
        Me.order1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order1.Location = New System.Drawing.Point(43, 83)
        Me.order1.Name = "order1"
        Me.order1.Size = New System.Drawing.Size(141, 31)
        Me.order1.TabIndex = 64
        '
        'calculate
        '
        Me.calculate.AutoSize = True
        Me.calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate.Location = New System.Drawing.Point(104, 282)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(112, 35)
        Me.calculate.TabIndex = 63
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'discount1
        '
        Me.discount1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount1.Location = New System.Drawing.Point(43, 168)
        Me.discount1.Name = "discount1"
        Me.discount1.Size = New System.Drawing.Size(141, 31)
        Me.discount1.TabIndex = 72
        '
        'output1
        '
        Me.output1.AutoSize = True
        Me.output1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output1.Location = New System.Drawing.Point(131, 225)
        Me.output1.Name = "output1"
        Me.output1.Size = New System.Drawing.Size(72, 25)
        Me.output1.TabIndex = 73
        Me.output1.Text = "output"
        '
        'Form28
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 398)
        Me.Controls.Add(Me.output1)
        Me.Controls.Add(Me.discount1)
        Me.Controls.Add(Me.test)
        Me.Controls.Add(Me.total1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.price1)
        Me.Controls.Add(Me.order1)
        Me.Controls.Add(Me.calculate)
        Me.Name = "Form28"
        Me.Text = "Corondo Industries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents test As Label
    Friend WithEvents total1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents price1 As TextBox
    Friend WithEvents order1 As TextBox
    Friend WithEvents calculate As Button
    Friend WithEvents discount1 As TextBox
    Friend WithEvents output1 As Label
End Class

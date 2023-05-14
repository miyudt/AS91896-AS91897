<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        txttitle = New Label()
        bgdetails = New Panel()
        btnback = New Button()
        txtcredit = New Label()
        txtaddress = New Label()
        txtph = New Label()
        txtname = New Label()
        PANELEXTENDER = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        bgdetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' txttitle
        ' 
        txttitle.AutoSize = True
        txttitle.BackColor = Color.White
        txttitle.Font = New Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        txttitle.Location = New Point(17, 11)
        txttitle.Margin = New Padding(5, 0, 5, 0)
        txttitle.Name = "txttitle"
        txttitle.Size = New Size(290, 39)
        txttitle.TabIndex = 1
        txttitle.Text = "Order Summary:"
        ' 
        ' bgdetails
        ' 
        bgdetails.BackColor = Color.White
        bgdetails.Controls.Add(btnback)
        bgdetails.Controls.Add(txtcredit)
        bgdetails.Controls.Add(txtaddress)
        bgdetails.Controls.Add(txtph)
        bgdetails.Controls.Add(txtname)
        bgdetails.Controls.Add(PANELEXTENDER)
        bgdetails.Location = New Point(14, 9)
        bgdetails.Name = "bgdetails"
        bgdetails.Size = New Size(774, 429)
        bgdetails.TabIndex = 6
        ' 
        ' btnback
        ' 
        btnback.BackColor = Color.Tomato
        btnback.Location = New Point(6, 338)
        btnback.Name = "btnback"
        btnback.Size = New Size(474, 85)
        btnback.TabIndex = 12
        btnback.Text = "Go Back"
        btnback.UseVisualStyleBackColor = False
        ' 
        ' txtcredit
        ' 
        txtcredit.AutoSize = True
        txtcredit.BackColor = Color.White
        txtcredit.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        txtcredit.Location = New Point(7, 136)
        txtcredit.Margin = New Padding(5, 0, 5, 0)
        txtcredit.Name = "txtcredit"
        txtcredit.Size = New Size(105, 20)
        txtcredit.TabIndex = 19
        txtcredit.Text = "Credit Card:"
        ' 
        ' txtaddress
        ' 
        txtaddress.AutoSize = True
        txtaddress.BackColor = Color.White
        txtaddress.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        txtaddress.Location = New Point(8, 110)
        txtaddress.Margin = New Padding(5, 0, 5, 0)
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(80, 20)
        txtaddress.TabIndex = 18
        txtaddress.Text = "Address:"
        ' 
        ' txtph
        ' 
        txtph.AutoSize = True
        txtph.BackColor = Color.White
        txtph.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        txtph.Location = New Point(8, 83)
        txtph.Margin = New Padding(5, 0, 5, 0)
        txtph.Name = "txtph"
        txtph.Size = New Size(132, 20)
        txtph.TabIndex = 17
        txtph.Text = "Phone Number:"
        ' 
        ' txtname
        ' 
        txtname.AutoSize = True
        txtname.BackColor = Color.White
        txtname.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        txtname.Location = New Point(8, 58)
        txtname.Margin = New Padding(5, 0, 5, 0)
        txtname.Name = "txtname"
        txtname.Size = New Size(60, 20)
        txtname.TabIndex = 7
        txtname.Text = "Name:"
        ' 
        ' PANELEXTENDER
        ' 
        PANELEXTENDER.AutoSize = True
        PANELEXTENDER.BackColor = Color.White
        PANELEXTENDER.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        PANELEXTENDER.ForeColor = Color.White
        PANELEXTENDER.Location = New Point(12, 283)
        PANELEXTENDER.Margin = New Padding(5, 0, 5, 0)
        PANELEXTENDER.Name = "PANELEXTENDER"
        PANELEXTENDER.Size = New Size(142, 29)
        PANELEXTENDER.TabIndex = 16
        PANELEXTENDER.Text = "Credit Card:"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txttitle)
        Controls.Add(bgdetails)
        Name = "Form2"
        Text = "Form2"
        bgdetails.ResumeLayout(False)
        bgdetails.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txttitle As Label
    Friend WithEvents bgdetails As Panel
    Friend WithEvents txtname As Label
    Friend WithEvents PANELEXTENDER As Label
    Friend WithEvents txtcredit As Label
    Friend WithEvents txtaddress As Label
    Friend WithEvents txtph As Label
    Friend WithEvents btnback As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class

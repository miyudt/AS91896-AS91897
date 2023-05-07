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
        Me.txttitle = New System.Windows.Forms.Label()
        Me.bgdetails = New System.Windows.Forms.Panel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.txtcredit = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.Label()
        Me.txtph = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.Label()
        Me.PANELEXTENDER = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.bgdetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'txttitle
        '
        Me.txttitle.AutoSize = True
        Me.txttitle.BackColor = System.Drawing.Color.White
        Me.txttitle.Font = New System.Drawing.Font("Century Gothic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.txttitle.Location = New System.Drawing.Point(17, 11)
        Me.txttitle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(293, 42)
        Me.txttitle.TabIndex = 1
        Me.txttitle.Text = "Order Summary:"
        '
        'bgdetails
        '
        Me.bgdetails.BackColor = System.Drawing.Color.White
        Me.bgdetails.Controls.Add(Me.btnback)
        Me.bgdetails.Controls.Add(Me.txtcredit)
        Me.bgdetails.Controls.Add(Me.txtaddress)
        Me.bgdetails.Controls.Add(Me.txtph)
        Me.bgdetails.Controls.Add(Me.txtname)
        Me.bgdetails.Controls.Add(Me.PANELEXTENDER)
        Me.bgdetails.Location = New System.Drawing.Point(14, 9)
        Me.bgdetails.Name = "bgdetails"
        Me.bgdetails.Size = New System.Drawing.Size(774, 429)
        Me.bgdetails.TabIndex = 6
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Tomato
        Me.btnback.Location = New System.Drawing.Point(6, 338)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(474, 85)
        Me.btnback.TabIndex = 12
        Me.btnback.Text = "Go Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'txtcredit
        '
        Me.txtcredit.AutoSize = True
        Me.txtcredit.BackColor = System.Drawing.Color.White
        Me.txtcredit.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.txtcredit.Location = New System.Drawing.Point(7, 136)
        Me.txtcredit.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtcredit.Name = "txtcredit"
        Me.txtcredit.Size = New System.Drawing.Size(104, 21)
        Me.txtcredit.TabIndex = 19
        Me.txtcredit.Text = "Credit Card:"
        '
        'txtaddress
        '
        Me.txtaddress.AutoSize = True
        Me.txtaddress.BackColor = System.Drawing.Color.White
        Me.txtaddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.txtaddress.Location = New System.Drawing.Point(8, 110)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(77, 21)
        Me.txtaddress.TabIndex = 18
        Me.txtaddress.Text = "Address:"
        '
        'txtph
        '
        Me.txtph.AutoSize = True
        Me.txtph.BackColor = System.Drawing.Color.White
        Me.txtph.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.txtph.Location = New System.Drawing.Point(8, 83)
        Me.txtph.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtph.Name = "txtph"
        Me.txtph.Size = New System.Drawing.Size(131, 21)
        Me.txtph.TabIndex = 17
        Me.txtph.Text = "Phone Number:"
        '
        'txtname
        '
        Me.txtname.AutoSize = True
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.txtname.Location = New System.Drawing.Point(8, 58)
        Me.txtname.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(63, 21)
        Me.txtname.TabIndex = 7
        Me.txtname.Text = "Name:"
        '
        'PANELEXTENDER
        '
        Me.PANELEXTENDER.AutoSize = True
        Me.PANELEXTENDER.BackColor = System.Drawing.Color.White
        Me.PANELEXTENDER.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PANELEXTENDER.ForeColor = System.Drawing.Color.White
        Me.PANELEXTENDER.Location = New System.Drawing.Point(12, 283)
        Me.PANELEXTENDER.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.PANELEXTENDER.Name = "PANELEXTENDER"
        Me.PANELEXTENDER.Size = New System.Drawing.Size(159, 30)
        Me.PANELEXTENDER.TabIndex = 16
        Me.PANELEXTENDER.Text = "Credit Card:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.bgdetails)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.bgdetails.ResumeLayout(False)
        Me.bgdetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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

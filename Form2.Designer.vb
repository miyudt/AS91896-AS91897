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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.rtxreciept = New System.Windows.Forms.RichTextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Tomato
        Me.btnback.Location = New System.Drawing.Point(12, 438)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(271, 61)
        Me.btnback.TabIndex = 12
        Me.btnback.Text = "Go Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.ForestGreen
        Me.btnprint.Location = New System.Drawing.Point(15, 505)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(268, 51)
        Me.btnprint.TabIndex = 21
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'rtxreciept
        '
        Me.rtxreciept.Location = New System.Drawing.Point(12, 9)
        Me.rtxreciept.Name = "rtxreciept"
        Me.rtxreciept.Size = New System.Drawing.Size(271, 423)
        Me.rtxreciept.TabIndex = 24
        Me.rtxreciept.Text = ""
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 568)
        Me.Controls.Add(Me.rtxreciept)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnback)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnback As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents rtxreciept As RichTextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class

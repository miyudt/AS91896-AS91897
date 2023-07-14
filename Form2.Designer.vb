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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        PrintDocument1 = New Printing.PrintDocument()
        btnback = New Button()
        btnprint = New Button()
        rtxreciept = New RichTextBox()
        PrintDialog1 = New PrintDialog()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        SuspendLayout()
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' btnback
        ' 
        btnback.BackColor = Color.Tomato
        btnback.Location = New Point(12, 438)
        btnback.Name = "btnback"
        btnback.Size = New Size(271, 61)
        btnback.TabIndex = 12
        btnback.Text = "Go Back"
        btnback.UseVisualStyleBackColor = False
        ' 
        ' btnprint
        ' 
        btnprint.BackColor = Color.ForestGreen
        btnprint.Location = New Point(15, 505)
        btnprint.Name = "btnprint"
        btnprint.Size = New Size(268, 51)
        btnprint.TabIndex = 21
        btnprint.Text = "Print"
        btnprint.UseVisualStyleBackColor = False
        ' 
        ' rtxreciept
        ' 
        rtxreciept.Location = New Point(12, 9)
        rtxreciept.Name = "rtxreciept"
        rtxreciept.Size = New Size(271, 423)
        rtxreciept.TabIndex = 24
        rtxreciept.Text = ""
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(298, 568)
        Controls.Add(rtxreciept)
        Controls.Add(btnprint)
        Controls.Add(btnback)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
    End Sub
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnback As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents rtxreciept As RichTextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class

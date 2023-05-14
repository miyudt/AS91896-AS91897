<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        lblHeading = New Label()
        txtPassword = New TextBox()
        btnEnter = New Button()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Location = New Point(8, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(154, 15)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Enter Application Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(8, 31)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(154, 23)
        txtPassword.TabIndex = 1
        ' 
        ' btnEnter
        ' 
        btnEnter.Location = New Point(8, 60)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(154, 23)
        btnEnter.TabIndex = 2
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(173, 94)
        Controls.Add(btnEnter)
        Controls.Add(txtPassword)
        Controls.Add(lblHeading)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnEnter As Button
End Class

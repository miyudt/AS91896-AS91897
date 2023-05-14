<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        txtNewPass = New TextBox()
        lblNewPass = New Label()
        lblConfirmPass = New Label()
        txtConfirmPass = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' txtNewPass
        ' 
        txtNewPass.Location = New Point(12, 30)
        txtNewPass.Name = "txtNewPass"
        txtNewPass.Size = New Size(222, 23)
        txtNewPass.TabIndex = 0
        ' 
        ' lblNewPass
        ' 
        lblNewPass.AutoSize = True
        lblNewPass.Location = New Point(12, 9)
        lblNewPass.Name = "lblNewPass"
        lblNewPass.Size = New Size(87, 15)
        lblNewPass.TabIndex = 1
        lblNewPass.Text = "New Password:"
        ' 
        ' lblConfirmPass
        ' 
        lblConfirmPass.AutoSize = True
        lblConfirmPass.Location = New Point(12, 61)
        lblConfirmPass.Name = "lblConfirmPass"
        lblConfirmPass.Size = New Size(107, 15)
        lblConfirmPass.TabIndex = 3
        lblConfirmPass.Text = "Confirm Password:"
        ' 
        ' txtConfirmPass
        ' 
        txtConfirmPass.Location = New Point(12, 81)
        txtConfirmPass.Name = "txtConfirmPass"
        txtConfirmPass.Size = New Size(222, 23)
        txtConfirmPass.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(12, 111)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(107, 23)
        btnSave.TabIndex = 4
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(127, 112)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(107, 23)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(246, 146)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(lblConfirmPass)
        Controls.Add(txtConfirmPass)
        Controls.Add(lblNewPass)
        Controls.Add(txtNewPass)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents lblNewPass As Label
    Friend WithEvents lblConfirmPass As Label
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class

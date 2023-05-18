Public Class Form3
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtNewPass.Text = txtConfirmPass.Text Then
            Dim filePath As String = Form1.filePath 'path from form1 when the pass file was created
            System.IO.File.WriteAllText(filePath, txtNewPass.Text) 'write new pass to txt
            MessageBox.Show("Password updated successfully")
            Me.Hide()
        Else
            MessageBox.Show("Passwords do not match") 'declines progress
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class
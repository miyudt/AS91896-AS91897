Public Class Form4
    Dim fileReader As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(Form1.filePath) Then
            fileReader = My.Computer.FileSystem.ReadAllText(Form1.filePath) 'reads file text, not my code, from https://learn.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-read-from-text-files        If fileReader = "" Then
        Else
            Form1.Show()
            Me.Hide()
            MessageBox.Show("READ FOLLOWING:" & vbCrLf & vbCrLf & "Please click enter on the password box" & vbCrLf & vbCrLf & "Please go to the misc tab along the top of your screen and click Open Password TXT to make a password file, type the new password into the password file and then save the file. This will be the new password for the application. If this is to be changed again, this can be done through the txt or the editor in the program.")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtPassword.Text = fileReader Then
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Password")
        End If
    End Sub
End Class
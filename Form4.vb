Public Class Form4
    Dim fileReader As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(Form1.filePath) Then
            fileReader = My.Computer.FileSystem.ReadAllText(Form1.filePath) 'reads file text, not my code, from https://learn.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-read-from-text-files
            If fileReader = "" Then
                Form1.Show()
                Me.Hide()
            End If
        Else
            Form1.Show() 'code prevents form4 from breaking if no file is present
            Me.Hide()
            MessageBox.Show("The PASSWORD.txt file was removed from its directory or is corrupt, please replace immediately!" & vbCrLf & vbCrLf & "If this is a first time startup, please reference the following video (link can also be found on GItHub!) https://drive.google.com/file/d/1pOWsGH2Jw4ISlkdfv7bHdlsIiqUMuSih/view?usp=sharing") 'stops the program from crashing if no file is found
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtPassword.Text = fileReader Then
            Form1.Show() 'allows access to form1 if password correct
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Password") 'declines password if wrong
        End If
    End Sub
End Class
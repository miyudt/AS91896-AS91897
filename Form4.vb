﻿Public Class Form4
    Dim fileReader As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(Form1.filePath) Then
            fileReader = My.Computer.FileSystem.ReadAllText(Form1.filePath) 'reads file text, not my code, from https://learn.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-read-from-text-files        If fileReader = "" Then
        Else
            Form1.Show()
            Me.Hide()
            MessageBox.Show("The PASSWORD.txt file was removed from its directory or is corrupt, please replace immediately!")
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
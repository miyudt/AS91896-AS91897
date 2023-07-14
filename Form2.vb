Public Class Form2
    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Form1.Show() 'shows and hides forms
        Me.Hide()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(rtxreciept.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 20) 'adds printing function to this form
    End Sub
    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        PrintPreviewDialog1.Document = PrintDocument1 'shows dialog for printing
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class
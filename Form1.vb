Public Class Form1
    Dim PizzaOrder(1, 11)
    Public filePath As String = "PASSWORD.txt" 'defines name for txt file
    Private Sub txtphone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphone.KeyPress
        If Asc(e.KeyChar) <> 8 Then 'keeps backspace key enabled as you may need to delete numbers
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'disables all keys that are not 0-9 or backspace
                e.Handled = True 'makes sure all extra key presses are declined that are not 0-9 or backspace
            End If
        End If
    End Sub

    Private Sub txtcreditcard_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcreditcard.KeyPress
        If Asc(e.KeyChar) <> 8 Then 'keeps backspace key enabled as you may need to delete numbers
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'disables all keys that are not 0-9 or backspace
                e.Handled = True 'makes sure all extra key presses are declined that are not 0-9 or backspace
            End If
        End If
    End Sub

    Private Sub chkdelivery_CheckedChanged(sender As Object, e As EventArgs) Handles chkdelivery.CheckedChanged
        If chkdelivery.Checked = False Then 'if the tickbox is not ticked, completes the following:
            txtaddress.Hide() 'hides address
            txtcreditcard.Hide() 'hides creditcard
            lbladdress.Hide() 'hides address
            lblcreditcard.Hide() 'hides creditcard
        Else
            txtaddress.Show() 'shows address
            txtcreditcard.Show() 'shows creditcard
            lbladdress.Show() 'shows address 
            lblcreditcard.Show() 'shows creditcard
        End If
    End Sub

    Public Sub btnrevieworder_Click(sender As Object, e As EventArgs) Handles btnrevieworder.Click
        Dim TrimmedName As String = txtname.Text.Trim 'trims spaces off text
        Dim TrimmedPH As String = Val(txtphone.Text.Trim) 'trims spaces off text
        Dim TrimmedCredit As String = Val(txtcreditcard.Text.Trim) 'trims spaces off text
        Dim TrimmedAddress As String = txtaddress.Text.Trim 'trims spaces off text
        If chkdelivery.Checked = True Then
            If TrimmedName = "" Or TrimmedPH = 0 Or TrimmedAddress = "" Or TrimmedCredit = 0 Then
                MessageBox.Show("Fill In All Fields For Delivery") 'fails if all requirements are not met
            Else
                Form2.Show() 'show form 2
                Me.Hide() 'hide form 1
                PrintPizzas()
            End If
        Else
            If TrimmedName = "" Or TrimmedPH = 0 Then
                MessageBox.Show("Fill In All Fields For Pickup") 'fails if all requirements are not met
            Else
                Form2.Show() 'shows form 2
                Me.Hide() 'hides form 1
                PrintPizzas()
            End If
        End If
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        End 'ends program
    End Sub
    Private Sub OpenPasswordTXTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPasswordTXTToolStripMenuItem.Click
        filePath = System.IO.Path.Combine(Application.StartupPath, filePath) 'gets full path by combining directory and filename
        System.Diagnostics.Process.Start("notepad.exe", filePath) 'open the file with notepad, executing crashes the code ;_;
    End Sub
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Form3.Show() 'shows form3
    End Sub
    Private Sub PrintPizzas()
        Dim TrimmedName As String = txtname.Text.Trim 'trims spaces off text
        Dim TrimmedPH As String = Val(txtphone.Text.Trim) 'trims spaces off text
        Dim TrimmedCredit As String = txtcreditcard.Text.Trim 'trims spaces off text
        Dim TrimmedAddress As String = txtaddress.Text.Trim 'trims spaces off text
        PizzaOrder(1, 0) = nmudpizza1.Value 'writes array
        PizzaOrder(1, 1) = nmudpizza2.Value
        PizzaOrder(1, 2) = nmudpizza3.Value
        PizzaOrder(1, 3) = nmudpizza4.Value
        PizzaOrder(1, 4) = nmudpizza5.Value
        PizzaOrder(1, 5) = nmudpizza6.Value
        PizzaOrder(1, 6) = nmudpizza7.Value
        PizzaOrder(1, 7) = nmudpizza8.Value
        PizzaOrder(1, 8) = nmudpizza9.Value
        PizzaOrder(1, 9) = nmudpizza10.Value
        PizzaOrder(1, 10) = nmudpizza11.Value
        PizzaOrder(1, 11) = nmudpizza12.Value
        PizzaOrder(0, 0) = lblpizza1.Text
        PizzaOrder(0, 1) = lblpizza2.Text
        PizzaOrder(0, 2) = lblpizza3.Text
        PizzaOrder(0, 3) = lblpizza4.Text
        PizzaOrder(0, 4) = lblpizza5.Text
        PizzaOrder(0, 5) = lblpizza6.Text
        PizzaOrder(0, 6) = lblpizza7.Text
        PizzaOrder(0, 7) = lblpizza8.Text
        PizzaOrder(0, 8) = lblpizza9.Text
        PizzaOrder(0, 9) = lblpizza10.Text
        PizzaOrder(0, 10) = lblpizza11.Text
        PizzaOrder(0, 11) = lblpizza12.Text
        Form2.rtxreciept.Text = "Rotorua Dream Pizza" & vbCrLf & "Call us at 0800 696 9696" & vbCrLf & "12 Amohau Road" & vbCrLf & "**************************************************" & vbCrLf & TrimmedName & vbCrLf & TrimmedPH & vbCrLf & TrimmedCredit & vbCrLf & TrimmedAddress & vbCrLf & "**************************************************" & vbCrLf
        For x = 0 To 6
            If PizzaOrder(0, x).Length < 8 Then
                Form2.rtxreciept.Text += PizzaOrder(0, x) & vbTab & vbTab & PizzaOrder(1, x) & vbTab & (FormatCurrency(PizzaOrder(1, x) * 8.5)) & vbCrLf
            Else
                Form2.rtxreciept.Text += PizzaOrder(0, x) & vbTab & PizzaOrder(1, x) & vbTab & (FormatCurrency(PizzaOrder(1, x) * 8.5)) & vbCrLf
            End If
        Next
        For x = 7 To 11
            If PizzaOrder(0, x).Length < 8 Then
                Form2.rtxreciept.Text += PizzaOrder(0, x) & vbTab & vbTab & PizzaOrder(1, x) & vbTab & (FormatCurrency(PizzaOrder(1, x) * 13.5)) & vbCrLf
            Else
                Form2.rtxreciept.Text += PizzaOrder(0, x) & vbTab & PizzaOrder(1, x) & vbTab & (FormatCurrency(PizzaOrder(1, x) * 13.5)) & vbCrLf
            End If
        Next
        Form2.rtxreciept.Text += "**************************************************" & vbCrLf & "Thanks for shopping with us ^^"
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(Form2.rtxreciept.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 20)
    End Sub

    Private Sub lblpizza10_Click(sender As Object, e As EventArgs) Handles lblpizza10.Click

    End Sub
End Class

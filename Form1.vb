Public Class Form1
    Dim PizzaOrder(0, 11)
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
                Form2.txtname.Text = "Name: " & TrimmedName 'pushes name to form2
                Form2.txtaddress.Text = "Address: " & TrimmedAddress 'pushes address to form2
                Form2.txtph.Text = "Phone Number: " & TrimmedPH 'pushes phone number to form2
                Form2.txtcredit.Text = "Credit Card: " & TrimmedCredit 'pushes credit card to form2
                Form2.Show() 'show form 2
                Me.Hide() 'hide form 1
                Form2.txtcredit.Show() 'shows credit card text if hidden
                Form2.txtaddress.Show() 'shows address text if hidden
            End If
        Else
            If TrimmedName = "" Or TrimmedPH = 0 Then
                MessageBox.Show("Fill In All Fields For Pickup") 'fails if all requirements are not met
            Else
                Form2.txtph.Text = "Phone Number: " & TrimmedPH 'pushes phone number to form2
                Form2.txtname.Text = "Name: " & TrimmedName 'pushes name to form2
                Form2.txtcredit.Hide() 'hides credit text if shown
                Form2.txtaddress.Hide() 'hides address text if shown
                Form2.Show() 'shows form 2
                Me.Hide() 'hides form 1
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
End Class

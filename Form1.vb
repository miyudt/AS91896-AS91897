Public Class Form1
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
End Class

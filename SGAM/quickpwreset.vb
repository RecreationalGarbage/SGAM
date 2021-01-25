Public Class quickpwreset
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            pwresetpwbox.PasswordChar = vbNullChar
        Else checkbox1.Checked = False
            pwresetpwbox.PasswordChar = "O"
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class
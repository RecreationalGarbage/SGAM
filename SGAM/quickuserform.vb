Public Class quickuserform
    Private Sub quickuserbut_Click(sender As Object, e As EventArgs) Handles quickuserbut.Click
        Me.Hide()
    End Sub

    Private Sub quickuserform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userbox.Select()
    End Sub
End Class
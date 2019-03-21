Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Principal.Show()
        Me.Hide()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
End Class

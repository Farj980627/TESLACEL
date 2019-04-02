Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Try
            If consultas.login(txtUsuario.Text, txtPass.Text) = True Then
                Me.Hide()
                Principal.Show()
                txtPass.PasswordChar = ""
                txtPass.Text = "CONTRASEÑA.."
                txtUsuario.Text = "USUARIO.."
            Else
                MsgBox("Usuario o Contraseña Incorrectos")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = Label1
    End Sub

    Private Sub txtUsuario_Click(sender As Object, e As EventArgs) Handles txtUsuario.Click
        txtUsuario.Clear()
    End Sub

    Private Sub txtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If txtUsuario.Text = "" Then
            txtUsuario.Text = "USUARIO.."
        End If
    End Sub

    Private Sub txtPass_Click(sender As Object, e As EventArgs) Handles txtPass.Click
        txtPass.Clear()
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub txtPass_Leave(sender As Object, e As EventArgs) Handles txtPass.Leave
        If txtPass.Text = "" Then
            txtPass.PasswordChar = ""
            txtPass.Text = "CONTRASEÑA.."
        End If
    End Sub
End Class

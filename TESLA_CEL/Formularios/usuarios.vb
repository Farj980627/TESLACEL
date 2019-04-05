Public Class usuarios
    Dim newDt As New DataTable
    Dim lvl As String
    Private Sub usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbUsuarios.DataSource = consultas.getUsuarios
            cbUsuarios.DisplayMember = "user"
            cbNivel.DataSource = consultas.getLevel
            cbNivel.DisplayMember = "identifier"
            newDt = consultas.getUsuarios2(cbUsuarios.Text)
            txtPass.Text = newDt(0)("password").ToString
            txtUsuario.Text = newDt(0)("user").ToString
        Catch ex As Exception
            
        End Try

    End Sub

    Private Sub cbUsuarios_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbUsuarios.SelectionChangeCommitted
        Try
            newDt = consultas.getUsuarios2(cbUsuarios.GetItemText(Me.cbUsuarios.SelectedItem))
            txtPass.Text = newDt(0)("password").ToString
            txtUsuario.Text = newDt(0)("user").ToString
        Catch ex As Exception
            
        End Try

    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If cbNivel.Text = "Administrador" Then
                lvl = "1"
            ElseIf cbNivel.Text = "Cajero" Then
                lvl = "3"
            ElseIf cbNivel.Text = "Soporte" Then
                lvl = "4"
            End If
            consultas.updUser(newDt(0)("id_user"), txtUsuario.Text, txtPass.Text, lvl)
            cbUsuarios.DataSource = consultas.getUsuarios
            cbUsuarios.DisplayMember = "user"
            MessageBox.Show("Usuario Actualizado")
        Catch ex As Exception
            
        End Try

    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim lvl As String = ""
            If cbNivel.Text = "Administrador" Then
                lvl = "1"
            ElseIf cbNivel.Text = "Cajero" Then
                lvl = "3"
            ElseIf cbNivel.Text = "Soporte" Then
                lvl = "4"
            End If
            consultas.insUser(txtUsuario.Text, txtPass.Text, lvl)
            MessageBox.Show("Usuario Agregado")
            cbUsuarios.DataSource = consultas.getUsuarios
            cbUsuarios.DisplayMember = "user"
        Catch ex As Exception
            MsgBox("El nombre de usuario ya esta en uso")
        End Try

    End Sub
End Class
Public Class Registar_Proveedor
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            txtContacto.Text = ""
            txtDireccion.Text = ""
            txtProveedor.Text = ""
            txtTelefono.Text = ""
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            consultas.insProvider(txtProveedor.Text, txtContacto.Text, txtDireccion.Text, txtTelefono.Text)
            MsgBox("Proveedor Registrado")
            txtContacto.Text = ""
            txtDireccion.Text = ""
            txtProveedor.Text = ""
            txtTelefono.Text = ""
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
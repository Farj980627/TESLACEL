Public Class Registar_Proveedor
    Dim newDt As DataTable
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
            Inventario.Close()
        Catch ex As Exception
            MsgBox("El proveedor ya existe")
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

    Private Sub Registar_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            newDt = consultas.getProveedor
            cbProveedor.DataSource = newDt
            cbProveedor.DisplayMember = "provider"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (MessageBox.Show("Estas seguro que deseas eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            consultas.delProvider(cbProveedor.Text)
            Me.Close()
            Inventario.Close()
            MsgBox("Proveedor Eliminado Correctamente")
            MsgBox("Los productos quedaron sin proveedor asignado")
        End If
    End Sub
End Class
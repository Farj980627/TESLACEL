Public Class Eliminar_Prod

    Private Sub bntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        Me.Close()
    End Sub

    Private Sub Eliminar_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbProveedor.DataSource = consultas.getProovedor
            cbProveedor.DisplayMember = "provider"
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedor.SelectedIndexChanged
        Try
            cbProducto.DataSource = consultas.getProductoByProveedor(consultas.getProovedor(cbProveedor.SelectedIndex)("id_provider"))
            cbProducto.DisplayMember = "name"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (MessageBox.Show("Estas seguro que deseas eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                consultas.delProducto(cbProducto.Text)
                MsgBox("Producto Eliminado")
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
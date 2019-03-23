Public Class Eliminar_Prod

    Private Sub bntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        Me.Close()
    End Sub

    Private Sub Eliminar_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbProveedor.DataSource = consultas.getProovedor
        cbProveedor.DisplayMember = "provider"
    End Sub
    Private Sub cbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedor.SelectedIndexChanged
        cbProducto.DataSource = consultas.getProductoByProveedor(consultas.getProovedor(cbProveedor.SelectedIndex)("id_provider"))
        cbProducto.DisplayMember = "name"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (MessageBox.Show("Estas seguro que deseas eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            consultas.delProducto(cbProducto.Text)
        End If


    End Sub
End Class
Public Class Buscar_Prod
    Dim newDt As New DataTable

    Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click
        If txtNombre.Text = "NOMBRE PRODUCTO" Then
            txtNombre.Text = ""
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        newDt = consultas.getProductosByProductos(txtNombre.Text)
        dgvProducto.DataSource = newDt
    End Sub

    Private Sub bntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        Me.Close()
    End Sub

    Private Sub Buscar_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbProveedor.DataSource = consultas.getProovedor
        cbProveedor.DisplayMember = "provider"
    End Sub

    Private Sub cbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedor.SelectedIndexChanged
        newDt = consultas.getProductoByProveedor(consultas.getProovedor(cbProveedor.SelectedIndex)("id_provider"))
        dgvProducto.DataSource = newDt
    End Sub
End Class
Public Class Inventario
    Dim newDt As New DataTable
    Dim con As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Insertar_Prod.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar_Prod.ShowDialog()
    End Sub
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newDt = consultas.getCategoria
        cbCategoria.DataSource = newDt
        cbCategoria.DisplayMember = "category"
    End Sub
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        newDt = consultas.getProductos()
        dgvProducto.DataSource = newDt
    End Sub

    Private Sub cbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedIndexChanged

        newDt = consultas.getProductosByCategory(cbCategoria.Text)
        dgvProducto.DataSource = newDt
    End Sub

    Private Sub cbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedor.SelectedIndexChanged

    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            newDt = consultas.getProductosByProductos(txtNombre.Text)
            dgvProducto.DataSource = newDt
        End If
    End Sub

    Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click
        txtNombre.Clear()
    End Sub
End Class
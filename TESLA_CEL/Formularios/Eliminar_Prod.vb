Public Class Eliminar_Prod

    Private Sub bntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        Me.Close()
    End Sub

    Private Sub Eliminar_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbCategoria.DataSource = consultas.getProducType()
            cbCategoria.DisplayMember = "type"

        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (MessageBox.Show("Estas seguro que deseas eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                consultas.delProducto(cbCategoria.Text, cbProducto.Text, cbModelo.Text, cbColor.Text)
                Me.Close()
                cbProducto.DataSource = ""
                cbCategoria.DataSource = ""
                MsgBox("Producto Eliminado")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedIndexChanged
        Try
            cbProducto.DataSource = consultas.getProductosByCategoria(cbCategoria.Text)
            cbProducto.DisplayMember = "name"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModelo.SelectedIndexChanged
        Try
            cbColor.DataSource = consultas.getProductosByCategoriaModeloNombre(cbCategoria.Text, cbProducto.Text, cbModelo.Text)
            cbColor.DisplayMember = "color"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProducto.SelectedIndexChanged
        Try
            cbModelo.DataSource = consultas.getProductosByCategoriaModelo(cbCategoria.Text, cbProducto.Text)
            cbModelo.DisplayMember = "model"
        Catch ex As Exception

        End Try
    End Sub
End Class
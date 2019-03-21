Public Class Inventario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Insertar_Prod.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar_Prod.ShowDialog()
    End Sub
End Class
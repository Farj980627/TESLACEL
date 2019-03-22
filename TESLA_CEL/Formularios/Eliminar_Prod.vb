Public Class Eliminar_Prod

    Private Sub bntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        Me.Close()
    End Sub

    Private Sub Eliminar_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbProveedor.DataSource = consultas.getProovedor
        cbProveedor.DisplayMember = "provider"
    End Sub
    Private Sub cbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedor.SelectedIndexChanged

    End Sub
End Class
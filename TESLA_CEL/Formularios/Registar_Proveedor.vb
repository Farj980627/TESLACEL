Public Class Registar_Proveedor
    Dim newDt As DataTable
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            txtProductType.Clear()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            consultas.insProductTyper(txtProductType.Text)
            MsgBox("Tipo de producto Registrado", MsgBoxStyle.OkOnly, MsgBoxResult.Ok)
            txtProductType.Clear()
            cbProductType.DataSource = consultas.getProducType
            cbProductType.DisplayMember = "type"
        Catch ex As Exception
            MsgBox("El tipo ya existe", "AVISO", MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Registar_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbProductType.DataSource = consultas.getProducType
            cbProductType.DisplayMember = "type"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (MessageBox.Show("Estas seguro que deseas eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            consultas.delProductoType(cbProductType.Text)
            Me.Close()
            Inventario.Close()
            MsgBox("Tipo eliminado Correctamente", MsgBoxStyle.OkOnly, MsgBoxResult.Ok)

        End If
    End Sub
End Class
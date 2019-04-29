Public Class Eliminar_Prod
    Dim DTIDS, productType As New DataTable
    Dim vacio As New DataTable
    Private Sub bntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        cbCategoria.DataSource = vacio
        cbProducto.DataSource = vacio
        txtModelo.Clear()
        txtColor.Clear()

        Me.Close()
    End Sub

    Private Sub Eliminar_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            productType = consultas.getProducType()


        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (MessageBox.Show("Estas seguro que deseas eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                consultas.delProducto(DTIDS(cbProducto.SelectedIndex)("id_product"))
                Me.Close()
                cbCategoria.DataSource = vacio
                cbProducto.DataSource = vacio
                txtModelo.Clear()
                txtColor.Clear()

                MsgBox("Producto Eliminado")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedIndexChanged
        Try
            If consultas.getProductosByCategoria(cbCategoria.Text).Rows.Count = 0 Then
                cbProducto.DataSource = Nothing
                cbProducto.DisplayMember = ""
                txtColor.Clear()
                txtModelo.Clear()
            Else
                cbProducto.DataSource = consultas.getProductosByCategoria(cbCategoria.Text)
                cbProducto.DisplayMember = "name"
                DTIDS = consultas.getProductosByCategoria(cbCategoria.Text)
                txtModelo.Text = consultas.getProductosByProduct(DTIDS(cbProducto.SelectedIndex)("id_product"))(0)("model").ToString
                txtColor.Text = consultas.getProductosByProduct(DTIDS(cbProducto.SelectedIndex)("id_product"))(0)("color").ToString
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbCategoria_Click(sender As Object, e As EventArgs) Handles cbCategoria.Click
        cbCategoria.DataSource = productType
        cbCategoria.DisplayMember = "type"
    End Sub

    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If (MessageBox.Show("Estas seguro que deseas eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                consultas.delProducto(txtID.Text)
                Me.Close()
                cbCategoria.DataSource = vacio
                cbProducto.DataSource = vacio
                txtModelo.Clear()
                txtColor.Clear()
                txtID.Clear()

                MsgBox("Producto Eliminado")
            End If
        End If
    End Sub

    Private Sub cbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProducto.SelectedIndexChanged
        Try
            If DTIDS.Rows.Count = 0 Then
                txtColor.Clear()
                txtModelo.Clear()
            Else
                txtModelo.Text = consultas.getProductosByProduct(DTIDS(cbProducto.SelectedIndex)("id_product"))(0)("model").ToString
                txtColor.Text = consultas.getProductosByProduct(DTIDS(cbProducto.SelectedIndex)("id_product"))(0)("color").ToString
            End If

        Catch EX As Exception
        End Try
    End Sub
End Class
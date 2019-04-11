Public Class Actualizar_Prod
    Private Sub Actualizar_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbCatOrigen.DataSource = consultas.getProducType
            cbCatOrigen.DisplayMember = "type"

            cbCatDestino.DataSource = consultas.getProducType
            cbCatDestino.DisplayMember = "type"

            txtBarcode.Enabled = False
            txtCantidad.Enabled = False
            txtColor.Enabled = False
            txtMarca.Enabled = False
            txtModelo.Enabled = False
            dtpFecha.Enabled = False
            cbCatDestino.Enabled = False
            txtMinimo.Enabled = False
            txtNombre.Enabled = False
            txtPrecio.Enabled = False
            dtpFecha.Enabled = False
            btnActualizar.Enabled = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub bntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        Me.Close()
    End Sub



    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If txtNombre.Text = "" Or txtPrecio.Text = "" Or txtCantidad.Text = "" Then
                MsgBox("Alguno de los campos con asterisco contiene información no valida", MsgBoxStyle.Critical, MsgBoxResult.Ok)
            Else
                consultas.updInventarioAll(cbCatDestino.Text, txtNombre.Text, txtMarca.Text, txtModelo.Text, txtColor.Text, txtPrecio.Text, txtBarcode.Text, txtCantidad.Text, txtMinimo.Text, dtpFecha.Value.Date.ToString("yyyy-MM-ddd"), consultas.getProductosToUpdate(cbProducto.Text, cbCatOrigen.Text)(0)("id_product").ToString)
                MsgBox("Producto actualizado correctamente", MsgBoxStyle.OkOnly)
                txtCantidad.Clear()
                txtColor.Clear()
                txtMarca.Clear()
                txtMinimo.Clear()
                txtModelo.Clear()
                txtNombre.Clear()
                txtPrecio.Clear()
                txtBarcode.Enabled = False
                txtCantidad.Enabled = False
                txtColor.Enabled = False
                txtMarca.Enabled = False
                txtModelo.Enabled = False
                dtpFecha.Enabled = False
                cbCatDestino.Enabled = False
                txtMinimo.Enabled = False
                txtNombre.Enabled = False
                txtPrecio.Enabled = False
                dtpFecha.Enabled = False
                btnActualizar.Enabled = False
                cbCatOrigen.DataSource = consultas.getProducType
                cbCatOrigen.DisplayMember = "type"

                cbCatDestino.DataSource = consultas.getProducType
                cbCatDestino.DisplayMember = "type"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            txtBarcode.Text = consultas.getProductosToUpdate(cbProducto.Text, cbCatOrigen.Text)(0)("barcode")
            txtCantidad.Text = consultas.getProductosToUpdate(cbProducto.Text, cbCatOrigen.Text)(0)("quantity")
            txtColor.Text = consultas.getProductosToUpdate(cbProducto.Text, cbCatOrigen.Text)(0)("color")
            txtMarca.Text = consultas.getProductosToUpdate(cbProducto.Text, cbCatOrigen.Text)(0)("brand")
            txtMinimo.Text = consultas.getProductosToUpdate(cbProducto.Text, cbCatOrigen.Text)(0)("min")
            txtModelo.Text = consultas.getProductosToUpdate(cbProducto.Text, cbCatOrigen.Text)(0)("model")
            txtNombre.Text = consultas.getProductosToUpdate(cbProducto.Text, cbCatOrigen.Text)(0)("name")
            txtPrecio.Text = consultas.getProductosToUpdate(cbProducto.Text, cbCatOrigen.Text)(0)("price")
            cbCatDestino.SelectedIndex = cbCatOrigen.SelectedIndex
            txtBarcode.Enabled = True
            txtCantidad.Enabled = True
            txtColor.Enabled = True
            txtMarca.Enabled = True
            txtModelo.Enabled = True
            dtpFecha.Enabled = True
            cbCatDestino.Enabled = True
            txtMinimo.Enabled = True
            txtNombre.Enabled = True
            txtPrecio.Enabled = True
            dtpFecha.Enabled = True
            btnActualizar.Enabled = True

        Catch ex As Exception

        End Try
    End Sub
End Class
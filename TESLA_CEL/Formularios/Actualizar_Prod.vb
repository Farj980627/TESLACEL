Public Class Actualizar_Prod
    Private Sub Actualizar_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbProveedor.DataSource = consultas.getProveedor
            cbProveedor.DisplayMember = "provider"
            ComboBox1.DataSource = consultas.getProveedor
            ComboBox1.DisplayMember = "provider"
            cbProducto.DataSource = consultas.getProductoByProveedor(consultas.getProovedor(cbProveedor.SelectedIndex)("id_provider"))
            cbProducto.DisplayMember = "name"

            txtCantidad.Enabled = False
            txtCategoria.Enabled = False
            txtCodigo.Enabled = False
            txtDescripcion.Enabled = False
            txtMinimo.Enabled = False
            txtNombre.Enabled = False
            txtPrecio.Enabled = False
            dtpFecha.Enabled = False
            ComboBox1.Enabled = False
            btnActualizar.Enabled = False
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub cbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedor.SelectedIndexChanged
        Try
            cbProducto.DataSource = consultas.getProductoByProveedor(consultas.getProovedor(cbProveedor.SelectedIndex)("id_provider"))
            cbProducto.DisplayMember = "name"
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub


    Private Sub bntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        Me.Close()
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            txtNombre.Text = consultas.getProductosByProductos(cbProducto.Text)(0)("name")
            txtCantidad.Text = consultas.getProductosByProductos(cbProducto.Text)(0)("quantity")
            txtCategoria.Text = consultas.getProductosByProductos(cbProducto.Text)(0)("category")
            txtCodigo.Text = consultas.getProductosByProductos(cbProducto.Text)(0)("bar_code")
            txtDescripcion.Text = consultas.getProductosByProductos(cbProducto.Text)(0)("description")
            txtMinimo.Text = consultas.getProductosByProductos(cbProducto.Text)(0)("min")
            txtPrecio.Text = consultas.getProductosByProductos(cbProducto.Text)(0)("price")

            txtCantidad.Enabled = True
            txtCategoria.Enabled = True
            txtCodigo.Enabled = True
            txtDescripcion.Enabled = True
            txtMinimo.Enabled = True
            txtNombre.Enabled = True
            txtPrecio.Enabled = True
            dtpFecha.Enabled = True
            ComboBox1.Enabled = True
            btnActualizar.Enabled = True
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If (MessageBox.Show("Estas seguro que deseas Actualizar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                consultas.updInventarioAll(txtNombre.Text, txtDescripcion.Text, txtPrecio.Text, txtCodigo.Text, txtCantidad.Text, txtMinimo.Text, dtpFecha.Value.Date.ToString("yyyy-MM-dd"), txtCategoria.Text, consultas.getIDProvideer(ComboBox1.Text), consultas.getProductosByProductos(cbProducto.Text)(0)("id_product"))
                MsgBox("Producto Actualizado")

                txtCantidad.Text = "CANTIDAD"
                txtCategoria.Text = "CATEGORIA"
                txtCodigo.Text = "CODIGO"
                txtDescripcion.Text = "DESCRIPCION"
                txtMinimo.Text = "MINIMO"
                txtNombre.Text = "NUEVO NOMBRE"
                txtPrecio.Text = "PRECIO"

                txtCantidad.Enabled = False
                txtCategoria.Enabled = False
                txtCodigo.Enabled = False
                txtDescripcion.Enabled = False
                txtMinimo.Enabled = False
                txtNombre.Enabled = False
                txtPrecio.Enabled = False
                dtpFecha.Enabled = False
                ComboBox1.Enabled = False
                btnActualizar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        Try
           If Not Char.IsDigit( e.KeyChar ) And e.KeyChar <> vbBack Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        Try
           If Not Char.IsDigit( e.KeyChar ) And e.KeyChar <> vbBack Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        Try
           If Not Char.IsDigit( e.KeyChar ) And e.KeyChar <> vbBack Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
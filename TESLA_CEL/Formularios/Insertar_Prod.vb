Public Class Insertar_Prod
    Dim newDt As New DataTable
    Private Sub bntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        Me.Close()

    End Sub

    Private Sub Insertar_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newDt = consultas.getProovedor
        cbProveedor.DataSource = newDt
        cbProveedor.DisplayMember = "provider"
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        consultas.insProducto(txtNombre.Text, txtDescripcion.Text, txtPrecio.Text, txtCodigo.Text, txtCantidad.Text, txtMinimo.Text, dtpFecha.Value.Date.ToString("yyyy-MM-dd"), cbCategora.Text, cbProveedor.Text)
        MessageBox.Show("Articulo Arreglado")
    End Sub

    Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click
        txtNombre.Clear()
    End Sub
    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        If txtNombre.Text = "" Then
            txtNombre.Text = "NOMBRE PRODUCTO"
        End If
    End Sub
    Private Sub txtDescripcion_Click(sender As Object, e As EventArgs) Handles txtDescripcion.Click
        txtDescripcion.Clear()
    End Sub

    Private Sub txtPrecio_Click(sender As Object, e As EventArgs) Handles txtPrecio.Click
        txtPrecio.Clear()
    End Sub

    Private Sub txtPrecio_Leave(sender As Object, e As EventArgs) Handles txtPrecio.Leave
        If txtPrecio.Text = "" Then
            txtPrecio.Text = "PRECIO"
        End If
    End Sub

    Private Sub txtCantidad_Click(sender As Object, e As EventArgs) Handles txtCantidad.Click
        txtCantidad.Clear()

    End Sub

    Private Sub txtCantidad_Leave(sender As Object, e As EventArgs) Handles txtCantidad.Leave
        If txtCantidad.Text = "" Then
            txtCantidad.Text = "CANTIDAD"
        End If
    End Sub

    Private Sub txtMinimo_Click(sender As Object, e As EventArgs) Handles txtMinimo.Click
        txtMinimo.Clear()
    End Sub

    Private Sub txtMinimo_Leave(sender As Object, e As EventArgs) Handles txtMinimo.Leave
        If txtMinimo.Text = "" Then
            txtMinimo.Text = "MINIMO"
        End If
    End Sub

    Private Sub txtCodigo_Click(sender As Object, e As EventArgs) Handles txtCodigo.Click
        txtCodigo.Clear()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNombre.Text = "NOMBRE PRODUCTO"
        txtPrecio.Text = "PRECIO"
        txtMinimo.Text = "MINIMO"
        txtDescripcion.Text = "DESCRIPCION"
        txtCantidad.Text = "CANTIDAD"

    End Sub


End Class
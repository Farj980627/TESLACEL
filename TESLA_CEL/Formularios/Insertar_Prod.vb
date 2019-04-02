Public Class Insertar_Prod
    Dim newDt As New DataTable
    Dim desc, cod, min
    Private Sub bntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        Me.Close()

    End Sub

    Private Sub Insertar_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            newDt = consultas.getProovedor
            cbProveedor.DataSource = newDt
            cbProveedor.DisplayMember = "provider"
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If txtDescripcion.Text = "DESCRIPCIÓN" Or txtDescripcion.Text = "" Then
                desc = ""
            Else
                desc = txtDescripcion.Text
            End If
            If txtCodigo.Text = "CODIGO BARRAS" Or txtCodigo.Text = "" Then
                cod = ""
            Else
                cod = txtCodigo.Text
            End If
            If txtMinimo.Text = "MINIMO" Or txtMinimo.Text = "" Then
                min = ""
            Else
                min = txtMinimo.Text
            End If
            If txtPrecio.Text = "PRECIO" Or txtNombre.Text = "NOMBRE PRODUCTO" Or txtCantidad.Text = "CANTIDAD" Or txtCategoria.Text = "CATEGORIA" Or txtPrecio.Text = "PRECIO" Then
                MessageBox.Show("Alguno de los campos contiene informacion no valida")
            Else

                consultas.insProducto(txtNombre.Text, desc, txtPrecio.Text, cod, txtCantidad.Text, min, dtpFecha.Value.Date.ToString("yyyy-MM-dd"), txtCategoria.Text, newDt(cbProveedor.SelectedIndex)("id_provider").ToString)
                MessageBox.Show("Articulo Arreglado")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try

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

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        Try
            If Not Char.IsNumber(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        Try
            If Not Char.IsNumber(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception
            MsgBox(ex)

        End Try
    End Sub

    Private Sub txtMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinimo.KeyPress
        Try
            If Not Char.IsNumber(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub txtCategoria_Click(sender As Object, e As EventArgs) Handles txtCategoria.Click
        txtCategoria.Clear()
    End Sub

    Private Sub txtCategoria_Leave(sender As Object, e As EventArgs) Handles txtCategoria.Leave
        If txtCategoria.Text = "" Then
            txtCategoria.Text = "CATEGORIA"
        End If
    End Sub
End Class
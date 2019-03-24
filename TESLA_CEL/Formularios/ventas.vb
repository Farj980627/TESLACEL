Public Class ventas
    Dim carrito, carrito2 As New DataTable
    Dim cantidad As New DataColumn("cantidad", GetType(System.String))
    Dim total As New DataColumn("total", GetType(System.String))
    Dim producto, price As String
    Public Shared sumTot As String
    Private Sub txtProducto_Click(sender As Object, e As EventArgs) Handles txtProducto.Click
        txtProducto.Clear()
    End Sub

    Private Sub txtProducto_Leave(sender As Object, e As EventArgs) Handles txtProducto.Leave
        If txtProducto.Text = "" Then
            txtProducto.Text = "PRODUCTO"
        End If
    End Sub

    Private Sub txtProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If carrito.Rows.Count >= 1 Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    producto = consultas.getProductosByProduct(txtProducto.Text)(0)(0).ToString
                    price = consultas.getProductosByProduct(txtProducto.Text)(0)(1).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(producto, price, "1", 0)
                        Dim tot As String = carrito2.Rows(columnas - 1)("cantidad") * carrito2.Rows(columnas - 1)("price")
                        carrito2.Rows(columnas - 1)("total") = tot
                    Next
                    For i As Integer = 0 To carrito2.Rows.Count - 1 Step +1
                        Dim sumas As Double
                        sumas = sumas + carrito2(i)("total")
                        lblTotal.Text = sumas
                    Next
                    dgvProducto.DataSource = carrito2
                    carrito = carrito2
                Else
                    carrito2 = carrito
                    producto = consultas.getProductosByProduct(txtProducto.Text)(0)(0).ToString
                    price = consultas.getProductosByProduct(txtProducto.Text)(0)(1).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(producto, price, txtCantidad.Text, 0)
                        Dim tot As String = carrito2.Rows(columnas - 1)("cantidad") * carrito2.Rows(columnas - 1)("price")
                        carrito2.Rows(columnas - 1)("total") = tot
                    Next
                    dgvProducto.DataSource = carrito2
                    For i As Integer = 0 To carrito2.Rows.Count - 1 Step +1
                        Dim sumas As Double
                        sumas = sumas + carrito2(i)("total")
                        lblTotal.Text = sumas
                    Next
                    carrito = carrito2
                End If
            End If
            If carrito.Rows.Count = 0 Then
                If txtCantidad.Text = "" Then
                    carrito = consultas.getProductosByProduct(txtProducto.Text)
                    carrito.Columns.Add(cantidad)
                    carrito.Columns.Add(total)
                    carrito(0)("cantidad") = "1"
                    carrito(0)("total") = carrito(0)("cantidad") * carrito(0)("price")
                    dgvProducto.DataSource = carrito
                    lblTotal.Text = carrito(0)("total")
                Else
                    carrito = consultas.getProductosByProduct(txtProducto.Text)
                    carrito.Columns.Add(cantidad)
                    carrito.Columns.Add(total)
                    carrito(0)("cantidad") = txtCantidad.Text
                    carrito(0)("total") = carrito(0)("cantidad") * carrito(0)("price")
                    dgvProducto.DataSource = carrito
                    lblTotal.Text = carrito(0)("total")
                End If

            End If

        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        sumTot = lblTotal.Text
    End Sub

    Private Sub txtCodigo_Click(sender As Object, e As EventArgs) Handles txtCodigo.Click
        txtCodigo.Text = ""
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If carrito.Rows.Count >= 1 Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    producto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(0).ToString
                    price = consultas.getProductoByBarCode(txtCodigo.Text)(0)(1).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(producto, price, "1", 0)
                        Dim tot As String = carrito2.Rows(columnas - 1)("cantidad") * carrito2.Rows(columnas - 1)("price")
                        carrito2.Rows(columnas - 1)("total") = tot
                    Next
                    For i As Integer = 0 To carrito2.Rows.Count - 1 Step +1
                        Dim sumas As Double
                        sumas = sumas + carrito2(i)("total")
                        lblTotal.Text = sumas
                    Next
                    dgvProducto.DataSource = carrito2
                    carrito = carrito2
                Else
                    carrito2 = carrito
                    producto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(0).ToString
                    price = consultas.getProductoByBarCode(txtCodigo.Text)(0)(1).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(producto, price, txtCantidad.Text, 0)
                        Dim tot As String = carrito2.Rows(columnas - 1)("cantidad") * carrito2.Rows(columnas - 1)("price")
                        carrito2.Rows(columnas - 1)("total") = tot
                    Next
                    dgvProducto.DataSource = carrito2
                    For i As Integer = 0 To carrito2.Rows.Count - 1 Step +1
                        Dim sumas As Double
                        sumas = sumas + carrito2(i)("total")
                        lblTotal.Text = sumas
                    Next
                    carrito = carrito2
                End If
            End If
            If carrito.Rows.Count = 0 Then
                If txtCantidad.Text = "" Then
                    carrito = consultas.getProductoByBarCode(txtCodigo.Text)
                    carrito.Columns.Add(cantidad)
                    carrito.Columns.Add(total)
                    carrito(0)("cantidad") = "1"
                    carrito(0)("total") = carrito(0)("cantidad") * carrito(0)("price")
                    dgvProducto.DataSource = carrito
                    lblTotal.Text = carrito(0)("total")
                Else
                    carrito = consultas.getProductoByBarCode(txtCodigo.Text)
                    carrito.Columns.Add(cantidad)
                    carrito.Columns.Add(total)
                    carrito(0)("cantidad") = txtCantidad.Text
                    carrito(0)("total") = carrito(0)("cantidad") * carrito(0)("price")
                    dgvProducto.DataSource = carrito
                    lblTotal.Text = carrito(0)("total")
                End If

            End If

        End If
    End Sub
End Class
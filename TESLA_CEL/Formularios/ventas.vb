Imports LibPrintTicket
Public Class ventas
    Dim carrito, carrito2, vacio As New DataTable
    Dim cantidad As New DataColumn("cantidad", GetType(System.String))
    Dim total As New DataColumn("total", GetType(System.String))
    Dim producto, price As String
    Public Shared sumTot As String
    Public Shared dtTodo As New DataTable
    Public Shared orden As Boolean = False
    Private Sub txtProducto_Click(sender As Object, e As EventArgs) Handles txtProducto.Click
        txtProducto.Clear()
    End Sub

    Private Sub txtProducto_Leave(sender As Object, e As EventArgs) Handles txtProducto.Leave
        If txtProducto.Text = "" Then
            txtProducto.Text = "PRODUCTO"
        End If
    End Sub

    Private Sub txtProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProducto.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If carrito.Columns.Contains("cantidad") Then
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
                        dtTodo = carrito2
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
                        dtTodo = carrito2
                        carrito = carrito2
                    End If
                Else
                    carrito = consultas.getProductosByProduct(txtProducto.Text)
                    carrito.Columns.Add(cantidad)
                    carrito.Columns.Add(total)
                End If
                If carrito.Rows.Count = 1 Then
                    If txtCantidad.Text = "" Then
                        carrito(0)("cantidad") = "1"
                        carrito(0)("total") = carrito(0)("cantidad") * carrito(0)("price")
                        dgvProducto.DataSource = carrito
                        lblTotal.Text = carrito(0)("total")
                        dtTodo = carrito
                    Else
                        carrito(0)("cantidad") = txtCantidad.Text
                        carrito(0)("total") = carrito(0)("cantidad") * carrito(0)("price")
                        dgvProducto.DataSource = carrito
                        lblTotal.Text = carrito(0)("total")
                        dtTodo = carrito
                    End If
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If dgvProducto.Rows.Count = 0 Then
            MsgBox("No se a agregado ningun producto")
        Else
            sumTot = lblTotal.Text
            dgvProducto.DataSource = ""
            Conf_Venta.ShowDialog()
        End If

    End Sub

    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtOrden_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOrden.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                carrito = consultas.getOrden(txtOrden.Text)
                sumTot = Val(carrito(0)("total")) - Val(carrito(0)("advance_payment"))
                orden = True
                Conf_Venta.ShowDialog()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtOrden_Click(sender As Object, e As EventArgs) Handles txtOrden.Click
        txtOrden.Text = ""
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

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        If txtCodigo.Text = "" Then
            txtCodigo.Text = "CODIGO DE BARRAS"
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            dgvProducto.DataSource = vacio
            txtCantidad.Text = ""
            txtCodigo.Text = "CODIGO DE BARRAS"
            txtProducto.Text = "PRODUCTO"
            carrito.Columns.Remove("cantidad")
            carrito.Columns.Remove("total")
            lblTotal.Text = "0"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtOrden_Leave(sender As Object, e As EventArgs) Handles txtOrden.Leave
        txtOrden.Text = "ORDEN DE PAGO"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim ticket As Ticket = New Ticket()
            ticket.AddHeaderLine("TESLACEL")
            ticket.AddHeaderLine("Pino Suarez #2014")
            ticket.AddHeaderLine("DURANGO, DGO")
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() & " " + DateTime.Now.ToShortTimeString())
            Dim des As String = ""
            des = consultas.getLaastOrder(0)("description")
            ticket.AddItem("1", des, "")
            ticket.AddFooterLine("Total: $" & consultas.getLaastOrder(0)("total"))
            ticket.AddFooterLine("Anticipo: $" & consultas.getLaastOrder(0)("advance_payment"))
            ticket.AddFooterLine("Codigo de Orden: " & consultas.getLaastOrder(0)("code"))
            ticket.AddFooterLine("VUELVA PRONTO")
            ticket.PrintTicket("XP-58 (copy 1)")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ventas_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Try
            dgvProducto.DataSource = vacio
            txtCantidad.Text = ""
            txtCodigo.Text = "CODIGO DE BARRAS"
            txtProducto.Text = "PRODUCTO"
            carrito.Columns.Remove("cantidad")
            carrito.Columns.Remove("total")
            lblTotal.Text = "0"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtCodigo_Click(sender As Object, e As EventArgs) Handles txtCodigo.Click
        txtCodigo.Text = ""
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtCodigo.Text = "" Then

                Else
                    If carrito.Columns.Contains("cantidad") Then
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
                            dtTodo = carrito2
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
                            dtTodo = carrito2
                            carrito = carrito2
                        End If
                    Else
                        carrito = consultas.getProductoByBarCode(txtCodigo.Text)
                        carrito.Columns.Add(cantidad)
                        carrito.Columns.Add(total)
                    End If
                    If carrito.Rows.Count = 1 Then
                        If txtCantidad.Text = "" Then
                            carrito(0)("cantidad") = "1"
                            carrito(0)("total") = carrito(0)("cantidad") * carrito(0)("price")
                            dgvProducto.DataSource = carrito
                            lblTotal.Text = carrito(0)("total")
                            dtTodo = carrito
                        Else
                            carrito(0)("cantidad") = txtCantidad.Text
                            carrito(0)("total") = carrito(0)("cantidad") * carrito(0)("price")
                            dgvProducto.DataSource = carrito
                            lblTotal.Text = carrito(0)("total")
                            dtTodo = carrito
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
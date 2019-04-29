Imports LibPrintTicket
Imports WL
Public Class ventas
    Dim dtOrden As New DataTable
    Dim carrito, carrito2, vacio, busProducto As New DataTable
    Dim cantidad As New DataColumn("cantidad", GetType(System.String))
    Dim total As New DataColumn("total", GetType(System.String))
    Dim idproducto, producto, price, model, color, barcode As String
    Public Shared sumTot As String
    Public Shared dtTodo As New DataTable
    Public Shared orden As Boolean = False
    Public Shared garantia As Boolean = False
    Public Shared cobertura As String = ""
    Public Shared numeroOrden As String = ""

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            If dgvProducto.Rows.Count = 0 Then
                MsgBox("No se a agregado ningun producto")
            Else
                If chbSeñal.Checked = True Then
                    garantia = True
                Else
                    garantia = False
                End If
                If garantia = True Then
                    If txtCobertura.Text = "" Then
                        MsgBox("Especifica la cobertura")
                    Else
                        cobertura = txtCobertura.Text
                        sumTot = lblTotal.Text
                        dgvProducto.DataSource = ""
                        chbSeñal.Checked = False
                        txtCobertura.Text = ""
                        Conf_Venta.ShowDialog()
                    End If
                Else
                    sumTot = lblTotal.Text
                    dgvProducto.DataSource = ""
                    chbSeñal.Checked = False
                    txtCobertura.Text = ""
                    Conf_Venta.ShowDialog()
                End If

            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtOrden_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOrden.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                carrito = consultas.getOrdenAll(txtOrden.Text)
                sumTot = Val(carrito(0)("costoestimado")) - Val(carrito(0)("anticipo"))
                numeroOrden = carrito(0)("code")
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



    Private Sub dataBusProductos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataBusProductos.CellContentDoubleClick
        Try
            Dim prod As String
            prod = dataBusProductos.CurrentRow.Cells(0).Value.ToString

            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito

                    producto = consultas.getProductosByProduct(prod)(0)(1).ToString
                    price = consultas.getProductosByProduct(prod)(0)(2).ToString
                    model = consultas.getProductosByProduct(prod)(0)(3).ToString
                    color = consultas.getProductosByProduct(prod)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(prod)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(prod, producto, price, model, color, barcode, "1", 0)
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
                    producto = consultas.getProductosByProduct(prod)(0)(1).ToString
                    price = consultas.getProductosByProduct(prod)(0)(2).ToString
                    model = consultas.getProductosByProduct(prod)(0)(3).ToString
                    color = consultas.getProductosByProduct(prod)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(prod)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(prod, producto, price, model, color, barcode, txtCantidad.Text, 0)
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
                txtCantidad.Clear()
            Else
                carrito = consultas.getProductosByProduct(prod)
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
            txtCantidad.Clear()
            dataBusProductos.DataSource = vacio
            dataBusProductos.Visible = False
            dgvProducto.Visible = True
        Catch ex As Exception
        End Try
    End Sub

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
            busProducto = consultas.getProductosByProductosParaInv(txtProducto.Text)
            dataBusProductos.DataSource = busProducto
            dgvProducto.Visible = False
            dataBusProductos.Visible = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            dgvProducto.DataSource = vacio
            txtCantidad.Text = ""
            txtCodigo.Text = "CODIGO DE BARRAS"
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
            Dim ticketOrden As Tickets = New Tickets
            dtOrden = consultas.getLaastOrder
            If dtOrden(0)("anticipo").ToString = "0" Or dtOrden(0)("anticipo").ToString = "" Then

            Else
                consultas.insSale(24, 1, Date.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToShortTimeString, "Anticipo Orden", dtOrden(0)("anticipo").ToString)
            End If

            ticketOrden.Logo("logo nuevo.png")
            ticketOrden.Titulo("TESLACEL")
            ticketOrden.Encabezado("PINO SUAREZ #2014")
            ticketOrden.Encabezado("DURANGO,DGO CP:34270")
            ticketOrden.Encabezado("HORARIO 10:00 - 20:00")
            ticketOrden.Encabezado("TELEFONO: 618 195 1338")
            ticketOrden.Encabezado("RFC: HEGE940315HE6")
            ticketOrden.Encabezado("FECHA: " & Date.Today.ToShortDateString)
            ticketOrden.Encabezado("HORA: " & DateTime.Now.ToShortTimeString)
            ticketOrden.Encabezado("# ORDEN: " & dtOrden(0)("code"))
            ticketOrden.Encabezado("CLIENTE: " & dtOrden(0)("cliente"))
            ticketOrden.Encabezado("TELEFONO CLIENTE: " & dtOrden(0)("telefono"))
            ticketOrden.Encabezado("EQUIPO: " & dtOrden(0)("equipo"))
            ticketOrden.Encabezado("MODELO: " & dtOrden(0)("modelo"))
            ticketOrden.Encabezado("MARCA: " & dtOrden(0)("marca"))
            ticketOrden.Encabezado("COLOR: " & dtOrden(0)("color"))
            If dtOrden(0)("chip").ToString = "No" Then
                ticketOrden.Encabezado("CHIP: NO")
            Else
                ticketOrden.Encabezado("CHIP: SI")
            End If
            If dtOrden(0)("memoria").ToString = "No" Then
                ticketOrden.Encabezado("MEMORIA: NO")
            Else
                ticketOrden.Encabezado("MEMORIA: SI")
            End If
            If dtOrden(0)("pila").ToString = "No" Then
                ticketOrden.Encabezado("PILA: NO")
            Else
                ticketOrden.Encabezado("PILA: SI")
            End If
            If dtOrden(0)("cargador").ToString = "No" Then
                ticketOrden.Encabezado("CARGADOR: NO")
            Else
                ticketOrden.Encabezado("CARGADOR: SI")
            End If
            ticketOrden.Encabezado("FALLA: " & dtOrden(0)("falla"))
            ticketOrden.Encabezado("IMEI: " & dtOrden(0)("imei"))
            ticketOrden.Encabezado("OBSERVACIONES: " & dtOrden(0)("observaciones"))
            ticketOrden.Encabezado("FUNCIONES REVISADAS")
            If dtOrden(0)("microfono").ToString = "No" Then
                ticketOrden.Encabezado("MICROFONO: NO")
            Else
                ticketOrden.Encabezado("MICROFONO: SI")
            End If
            If dtOrden(0)("altavoz").ToString = "No" Then
                ticketOrden.Encabezado("ALTAVOZ: NO")
            Else
                ticketOrden.Encabezado("ALTAVOZ: SI")
            End If
            If dtOrden(0)("cc").ToString = "No" Then
                ticketOrden.Encabezado("C.C: NO")
            Else
                ticketOrden.Encabezado("C.C: SI")
            End If
            If dtOrden(0)("camaras").ToString = "No" Then
                ticketOrden.Encabezado("CAMARAS: NO")
            Else
                ticketOrden.Encabezado("CAMARAS: SI")
            End If
            If dtOrden(0)("wifi").ToString = "No" Then
                ticketOrden.Encabezado("WI-FI: NO")
            Else
                ticketOrden.Encabezado("WI-FI: SI")
            End If
            If dtOrden(0)("señal").ToString = "No" Then
                ticketOrden.Encabezado("SEÑAL: NO")
            Else
                ticketOrden.Encabezado("SEÑAL: SI")
            End If
            If dtOrden(0)("buzzer").ToString = "No" Then
                ticketOrden.Encabezado("BUZZER: NO")
            Else
                ticketOrden.Encabezado("BUZZER: SI")
            End If
            If dtOrden(0)("sensor").ToString = "No" Then
                ticketOrden.Encabezado("SENSOR: NO")
            Else
                ticketOrden.Encabezado("SENSOR: SI")
            End If
            ticketOrden.Encabezado("GARANTIA: " & dtOrden(0)("garantia"))
            ticketOrden.Encabezado("FECHA ENTREGA: " & dtOrden(0)("fechaentrega"))
            ticketOrden.Articulo("", "1", "ORDEN", dtOrden(0)("costoestimado").ToString, dtOrden(0)("costoestimado").ToString)
            ticketOrden.Total(dtOrden(0)("costoestimado"))
            ticketOrden.Pago("ANTICIPO", dtOrden(0)("anticipo").ToString)
            ticketOrden.Pago("RESTANTE", Val(dtOrden(0)("costoestimado").ToString) - Val(dtOrden(0)("anticipo").ToString))
            ticketOrden.Pie("1.- El cliente se hace responsable de la procedencia del equipo.")
            ticketOrden.Pie("2.- Toda resvisión genera honorarios minimos de $30 pesos.")
            ticketOrden.Pie("3.- Después de 30 días no nos hacemos responsables por ningún equipo.")
            ticketOrden.Pie("4.- No nos hacemos responsables por equipos que vengan apagados que puedan presentar fallas aleatorias.")
            ticketOrden.Pie("5.- No respondemos por ningún equipo después de 60 días (Basados en el artículo de la cámara de comercio, pudiendo disponer del equipo para los intereses que más le convengan al propietario del taller).")
            ticketOrden.Pie("6.- Todo equipo ya reparado que no sea retirado después de 10 días de comunicado su reparación se le sumara una multa de $80 pesos a la semana a la cantidad total que se estableció, por gastos de almacenamiento, hasta llegar a 60 días.")
            ticketOrden.Pie("7.- No nos hacemos responsables por memorias o chips olvidados en el taller.")
            ticketOrden.Pie("8.- Algunos equipos son reparados en otra de nuestras sucursales por motivos de espacio y seguridad.")
            ticketOrden.Pie("9.- No respondemos por equipo mojados que al ser intervenidos empeoren su estado o se apaguen (Todo equipo mojado tiene secuelas).")
            ticketOrden.Pie("GARANTIA: *El plazo de garantía es de 15 días (empieza a contar el día que se da aviso que el equipo está listo). 
            *El trámite de garantía es de 1 a 3 días hábiles. 
            *La garantía cubre únicamente defectos de fabrica de la pieza reparada o remplazada. 
            *En equipos golpeados y mojados no hay garantía. 
            *Secuelas de golpes y humedad no entran como garantía. 
            *La garantía se vuelve NULA si se pierde la póliza de garantía, el equipo es abierto por personas ajenas al taller tesla, sello de garantía alterado o roto, equipos golpeados o mojados. 
            *En caso de ser un cristal la pieza remplazada, esta no debe estar rallada ni estrellada.")
            ticketOrden.Pie("DESPUES DE 30 DIAS NO NOS HACEMOS RESPONSABLES DE NINGUN APARATO")
            ticketOrden.Pie("________________________________________________________________________________________________________________________________")
            ticketOrden.Pie("Al firmar acepta nuestros terminos y condiciones.")

            ticketOrden.Imprimir("(XP-58)", True)
            ticketOrden.Imprimir("(XP-58)", True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ventas_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Try
            dgvProducto.DataSource = vacio
            txtCantidad.Text = ""
            txtCodigo.Text = "CODIGO DE BARRAS"
            txtOrden.Text = "ORDEN DE PAGO"
            txtCobertura.Text = ""
            txtProducto.Text = "PRODUCTOS"
            dataBusProductos.DataSource = vacio
            dataBusProductos.Visible = False

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
                            idproducto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(0).ToString
                            producto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(1).ToString
                            price = consultas.getProductoByBarCode(txtCodigo.Text)(0)(2).ToString
                            model = consultas.getProductoByBarCode(txtCodigo.Text)(0)(3).ToString
                            color = consultas.getProductoByBarCode(txtCodigo.Text)(0)(4).ToString
                            barcode = consultas.getProductoByBarCode(txtCodigo.Text)(0)(5).ToString
                            Dim columnas As Integer = carrito2.Rows.Count + 1
                            For i As Integer = columnas - 1 To columnas - 1 Step +1
                                carrito2.Rows.Add(idproducto, producto, price, model, color, barcode, "1", 0)
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
                            idproducto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(0).ToString
                            producto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(1).ToString
                            price = consultas.getProductoByBarCode(txtCodigo.Text)(0)(2).ToString
                            model = consultas.getProductoByBarCode(txtCodigo.Text)(0)(3).ToString
                            color = consultas.getProductoByBarCode(txtCodigo.Text)(0)(4).ToString
                            barcode = consultas.getProductoByBarCode(txtCodigo.Text)(0)(5).ToString
                            Dim columnas As Integer = carrito2.Rows.Count + 1
                            For i As Integer = columnas - 1 To columnas - 1 Step +1
                                carrito2.Rows.Add(idproducto, producto, price, model, color, barcode, txtCantidad.Text, 0)
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
                        txtCantidad.Clear()
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
                txtCodigo.Clear()
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class
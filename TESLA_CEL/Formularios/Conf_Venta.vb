
Imports LibPrintTicket
Imports WL
Public Class Conf_Venta
    ' Dim id_product As New DataColumn("id_product", GetType(System.String))
    Dim cerrar As Boolean = False
    Dim venta As Boolean = False
    Private Sub Conf_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = ventas.sumTot
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            If ventas.orden = True Then
                If chBEfectivo.Checked = True And cbElectronico.Checked = False Then
                    consultas.insSale(24, 1, Date.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToShortTimeString, "Efectivo", ventas.sumTot)
                    Dim ticket1 As Tickets = New Tickets

                    ticket1.Logo("logo nuevo.png")
                    ticket1.Titulo("TESLACEL")
                    ticket1.Encabezado("PINO SUAREZ #2014")
                    ticket1.Encabezado("DURANGO,DGO CP:34270")
                    ticket1.Encabezado("HORARIO 10:00 - 20:00 LUN-VIE ")
                    ticket1.Encabezado("10:00 - 16:00 SABADO ")
                    ticket1.Encabezado("TELEFONO: 618 195 1338")
                    ticket1.Encabezado("RFC: HEGE940315HE6")
                    ticket1.Encabezado("FECHA: " & Date.Today.ToShortDateString)
                    ticket1.Articulo("CODE", "1", "Orden de Pago #" & ventas.numeroOrden, ventas.sumTot, ventas.sumTot)
                    ticket1.NumArticulos("1")
                    ticket1.Total(ventas.sumTot)
                    ticket1.Pago("RECIBI: ", txtPagar.Text)
                    ticket1.Pago("CAMBIO: ", Val(txtPagar.Text) - Val(ventas.sumTot))
                    ticket1.Pie("Este ticket solo es un comprobante de pago por compra de un artículo. En caso de que el cliente solicite un cambio de articulo, el producto debe estar en perfectas condiciones, sin haber retirado hules, protecciones o haber dañado el articulo comprado. El gerente tiene la autorización de negar cambio de artículo en base a su criterio.")
                    ticket1.Pie("En ningún caso hay devoluciones de efectivo.")
                    ticket1.Pie("Los artículos que se prueben al momento de la compra no tienen garantía.")
                    ticket1.Pie("Los siguientes artículos no tienen garantía por lo cual deben de ser probados al momento de la compra, Pilas, Cristales Templados, Cables, Cubos de Carga, Fundas.")
                    ticket1.Pie("GRACIAS POR SU COMPRA, VUELVA PRONTO")
                    ticket1.Imprimir("(XP-58)", True)
                    ticket1.Imprimir("(XP-58)", True)

                    MsgBox("Venta Realizada")
                    chBEfectivo.Checked = False
                    cbElectronico.Checked = False
                    ventas.orden = False
                    Me.Close()
                    ventas.Close()
                    txtPagar.Clear()
                ElseIf chBEfectivo.Checked = False And cbElectronico.Checked = False Then
                    MsgBox("Selecciona una Forma de Pago")
                ElseIf chBEfectivo.Checked = False And cbElectronico.Checked = True Then
                    consultas.insSale(24, 1, Date.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToShortTimeString, "Electrónico ", ventas.sumTot)
                    Dim ticket2 As Tickets = New Tickets

                    ticket2.Logo("logo nuevo.png")
                    ticket2.Titulo("TESLACEL")
                    ticket2.Encabezado("PINO SUAREZ #2014")
                    ticket2.Encabezado("DURANGO,DGO CP:34270")
                    ticket2.Encabezado("HORARIO 10:00 - 20:00 LUN-VIE ")
                    ticket2.Encabezado("10:00 - 16:00 SABADO ")
                    ticket2.Encabezado("TELEFONO: 618 195 1338")
                    ticket2.Encabezado("RFC: HEGE940315HE6")
                    ticket2.Encabezado("FECHA: " & Date.Today.ToShortDateString)
                    ticket2.Articulo("CODE", "1", "Orden de Pago #" & ventas.numeroOrden, ventas.sumTot, ventas.sumTot)
                    ticket2.NumArticulos("1")
                    ticket2.Total(ventas.sumTot)
                    ticket2.Pago("PAGO ELEC : ", ventas.sumTot)
                    ticket2.Pie("Este ticket solo es un comprobante de pago por compra de un artículo. En caso de que el cliente solicite un cambio de articulo, el producto debe estar en perfectas condiciones, sin haber retirado hules, protecciones o haber dañado el articulo comprado. El gerente tiene la autorización de negar cambio de artículo en base a su criterio.")
                    ticket2.Pie("En ningún caso hay devoluciones de efectivo.")
                    ticket2.Pie("Los artículos que se prueben al momento de la compra no tienen garantía.")
                    ticket2.Pie("Los siguientes artículos no tienen garantía por lo cual deben de ser probados al momento de la compra, Pilas, Cristales Templados, Cables, Cubos de Carga, Fundas.")
                    ticket2.Pie("GRACIAS POR SU COMPRA, VUELVA PRONTO")
                    ticket2.Imprimir("(XP-58)", True)
                    ticket2.Imprimir("(XP-58)", True)

                    MsgBox("Venta Realizada")
                    txtPagar.Clear()
                    chBEfectivo.Checked = False
                    cbElectronico.Checked = False
                    ventas.orden = False
                    Me.Close()
                    ventas.Close()
                ElseIf chBEfectivo.Checked = True And cbElectronico.Checked = True Then
                    MsgBox("Solo puedes seleccionar un tipo de pago")

                End If
            Else

                If chBEfectivo.Checked = True And cbElectronico.Checked = False Then
                    For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1

                        Dim a As String = ventas.dtTodo(i)("cantidad").ToString()
                        Dim b As String = consultas.getCantidadInventario(ventas.dtTodo(i)("barcode"))
                        If Val(a) > Val(b) Then
                            MsgBox("Cantidad de " & ventas.dtTodo(i)("name") & " en " & " Inventario es insuficiente para realizar la venta")
                            cerrar = True
                            venta = False
                            Me.Close()
                            ventas.Close()
                        Else
                            venta = True
                        End If
                    Next
                    If venta = True Then
                        For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1
                            Dim newCantidad As String
                            newCantidad = Val(consultas.getCantidadInventario(ventas.dtTodo(i)("barcode")) - Val(ventas.dtTodo(i)("cantidad")))
                            consultas.updInventario(newCantidad, ventas.dtTodo(i)("id_product"))
                            consultas.insSale(ventas.dtTodo(i)("id_product"), ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToShortTimeString, "Efectivo", ventas.dtTodo(i)("total"))
                        Next
                        cerrar = False
                    End If
                    If cerrar = False Then

                        Dim ticket3 As Tickets = New Tickets

                        ticket3.Logo("logo nuevo.png")
                        ticket3.Titulo("TESLACEL")
                        ticket3.Encabezado("PINO SUAREZ #2014")
                        ticket3.Encabezado("DURANGO,DGO CP:34270")
                        ticket3.Encabezado("HORARIO 10:00 - 20:00 LUN-VIE ")
                        ticket3.Encabezado("10:00 - 16:00 SABADO ")
                        ticket3.Encabezado("TELEFONO: 618 195 1338")
                        ticket3.Encabezado("RFC: HEGE940315HE6")
                        ticket3.Encabezado("FECHA: " & Date.Today.ToShortDateString)
                        For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1
                            ticket3.Articulo("CODE", ventas.dtTodo(i)("cantidad").ToString, ventas.dtTodo(i)("name").ToString & " " & ventas.dtTodo(i)("model").ToString, ventas.dtTodo(i)("price").ToString, ventas.dtTodo(i)("total").ToString)
                        Next
                        ticket3.NumArticulos(ventas.dtTodo.Rows.Count)
                        ticket3.Total(ventas.sumTot)
                        ticket3.Pago("RECIBI: ", txtPagar.Text)
                        ticket3.Pago("CAMBIO: ", Val(txtPagar.Text) - Val(ventas.sumTot))
                        If ventas.garantia = True Then
                            ticket3.Pie("GARANTIA: SI  COBERTURA:" & ventas.cobertura & " DIAS")
                        End If
                        ticket3.Pie("Este ticket solo es un comprobante de pago por compra de un artículo. En caso de que el cliente solicite un cambio de articulo, el producto debe estar en perfectas condiciones, sin haber retirado hules, protecciones o haber dañado el articulo comprado. El gerente tiene la autorización de negar cambio de artículo en base a su criterio.")
                        ticket3.Pie("En ningún caso hay devoluciones de efectivo.")
                        ticket3.Pie("Los artículos que se prueben al momento de la compra no tienen garantía.")
                        ticket3.Pie("Los siguientes artículos no tienen garantía por lo cual deben de ser probados al momento de la compra, Pilas, Cristales Templados, Cables, Cubos de Carga, Fundas.")
                        ticket3.Pie("GRACIAS POR SU COMPRA, VUELVA PRONTO")

                        ticket3.Imprimir("(XP-58)", True)

                        MsgBox("Venta Realizada")






                    End If
                    chBEfectivo.Checked = False
                    cbElectronico.Checked = False
                    txtPagar.Clear()
                    chBEfectivo.Checked = False
                    cbElectronico.Checked = False

                    Me.Close()
                    ventas.Close()
                ElseIf chBEfectivo.Checked = False And cbElectronico.Checked = False Then
                    MsgBox("Selecciona una Forma de Pago")

                ElseIf chBEfectivo.Checked = False And cbElectronico.Checked = True Then
                    For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1

                        Dim a As String = ventas.dtTodo(i)("cantidad").ToString()
                        Dim b As String = consultas.getCantidadInventario(ventas.dtTodo(i)("barcode"))
                        If Val(a) > Val(b) Then
                            MsgBox("Cantidad de " & ventas.dtTodo(i)("name") & " en " & " Inventario es insuficiente para realizar la venta")
                            cerrar = True
                            venta = False
                            Me.Close()
                            ventas.Close()
                        Else
                            venta = True
                        End If
                    Next
                    If venta = True Then
                        For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1
                            Dim newCantidad As String
                            newCantidad = Val(consultas.getCantidadInventario(ventas.dtTodo(i)("barcode")) - Val(ventas.dtTodo(i)("cantidad")))
                            consultas.updInventario(newCantidad, ventas.dtTodo(i)("id_product"))
                            consultas.insSale(ventas.dtTodo(i)("id_product"), ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToShortTimeString, "Electrónico ", ventas.dtTodo(i)("total"))
                        Next
                        cerrar = False
                    End If
                    If cerrar = False Then

                        Dim ticket4 As Tickets = New Tickets

                        ticket4.Logo("logo nuevo.png")
                        ticket4.Titulo("TESLACEL")
                        ticket4.Encabezado("PINO SUAREZ #2014")
                        ticket4.Encabezado("DURANGO,DGO CP:34270")
                        ticket4.Encabezado("HORARIO 10:00 - 20:00 LUN-VIE")
                        ticket4.Encabezado("10:00 - 16:00 SABADO")
                        ticket4.Encabezado("TELEFONO: 618 195 1338")
                        ticket4.Encabezado("RFC: HEGE940315HE6")
                        ticket4.Encabezado("FECHA: " & Date.Today.ToShortDateString)
                        For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1
                            ticket4.Articulo("CODE", ventas.dtTodo(i)("cantidad").ToString, ventas.dtTodo(i)("name").ToString & " " & ventas.dtTodo(i)("model").ToString, ventas.dtTodo(i)("price").ToString, ventas.dtTodo(i)("total").ToString)
                        Next
                        ticket4.NumArticulos(ventas.dtTodo.Rows.Count)
                        ticket4.Total(ventas.sumTot)
                        ticket4.Pago("PAGO ELEC : ", ventas.sumTot)
                        If ventas.garantia = True Then
                            ticket4.Pie("GARANTIA: SI  COBERTURA:" & ventas.cobertura & " DIAS")
                        End If
                        ticket4.Pie("Este ticket solo es un comprobante de pago por compra de un artículo. En caso de que el cliente solicite un cambio de articulo, el producto debe estar en perfectas condiciones, sin haber retirado hules, protecciones o haber dañado el articulo comprado. El gerente tiene la autorización de negar cambio de artículo en base a su criterio.")
                        ticket4.Pie("En ningún caso hay devoluciones de efectivo.")
                        ticket4.Pie("Los artículos que se prueben al momento de la compra no tienen garantía.")
                        ticket4.Pie("Los siguientes artículos no tienen garantía por lo cual deben de ser probados al momento de la compra, Pilas, Cristales Templados, Cables, Cubos de Carga, Fundas.")
                        ticket4.Pie("GRACIAS POR SU COMPRA, VUELVA PRONTO")

                        ticket4.Imprimir("(XP-58)", True)

                    End If
                    chBEfectivo.Checked = False
                    cbElectronico.Checked = False
                    txtPagar.Clear()
                    chBEfectivo.Checked = False
                    cbElectronico.Checked = False
                    Me.Close()
                    ventas.Close()
                ElseIf chBEfectivo.Checked = True And cbElectronico.Checked = True Then
                    MsgBox("Solo puedes seleccionar un tipo de pago")

                End If
            End If
        Catch ex As Exception
        End Try




    End Sub
    Private Sub txtPagar_TextChanged(sender As Object, e As EventArgs) Handles txtPagar.TextChanged
        Try
            If Val(txtPagar.Text) >= Val(lblTotal.Text) Then
                btnConfirmar.Enabled = True
            Else
                btnConfirmar.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPagar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagar.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then

                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception
            MsgBox(e)
        End Try
    End Sub

    Private Sub bntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        chBEfectivo.Checked = False
        cbElectronico.Checked = False
        txtPagar.Clear()
        ventas.Close()
        Me.Close()

    End Sub

    Private Sub cbElectronico_CheckedChanged(sender As Object, e As EventArgs) Handles cbElectronico.CheckedChanged
        If cbElectronico.Checked = True And chBEfectivo.Checked = False Then
            btnConfirmar.Enabled = True
        End If
    End Sub
End Class

Imports LibPrintTicket
Imports WL
Public Class Conf_Venta
    Dim id_product As New DataColumn("id_product", GetType(System.String))
    Dim cerrar As Boolean = False
    Dim venta As Boolean = False
    Private Sub Conf_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = ventas.sumTot
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            If ventas.orden = True Then
                If chBEfectivo.Checked = True And cbElectronico.Checked = False Then
                    consultas.insSale(24, 1, Date.Today.ToString("yyyy-MM-dd"), "Efectivo", ventas.sumTot)
                    Dim ticket1 As Tickets = New Tickets
                    ticket1.Logo("../../Resources/logo nuevo.png")
                    ticket1.Titulo("TESLACEL")
                    ticket1.Encabezado("PINO SUAREZ #2014")
                    ticket1.Encabezado("DURANGO,DGO CP:34220")
                    ticket1.Encabezado("HORARIO 10:00 - 20:00")
                    ticket1.Encabezado("TELEFONO: 618 195 1338")
                    ticket1.Encabezado("FECHA: " & Date.Today.ToShortDateString)
                    ticket1.Articulo("CODE", "1", "Orden de Pago", ventas.sumTot, ventas.sumTot)
                    ticket1.NumArticulos("1")
                    ticket1.Total(ventas.sumTot)
                    ticket1.Pago("RECIBI: ", txtPagar.Text)
                    ticket1.Pago("CAMBIO: ", Val(txtPagar.Text) - Val(ventas.sumTot))
                    ticket1.Pie("GRACIAS POR SU COMPRA, VUELVA PRONTO")
                    ticket1.Imprimir("(XP-58 (copy 1))", True)
                    MsgBox("Venta Realizada")
                    chBEfectivo.Checked = False
                    cbElectronico.Checked = False
                    Me.Close()
                    ventas.Close()
                    txtPagar.Clear()
                ElseIf chBEfectivo.Checked = False And cbElectronico.Checked = False Then
                    MsgBox("Selecciona una Forma de Pago")
                ElseIf chBEfectivo.Checked = False And cbElectronico.Checked = True Then
                    consultas.insSale(24, 1, Date.Today.ToString("yyyy-MM-dd"), "Electrónico ", ventas.sumTot)
                    Dim ticket1 As Tickets = New Tickets
                    ticket1.Logo("../../Resources/logo nuevo.png")
                    ticket1.Titulo("TESLACEL")
                    ticket1.Encabezado("PINO SUAREZ #2014")
                    ticket1.Encabezado("DURANGO,DGO CP:34220")
                    ticket1.Encabezado("HORARIO 10:00 - 20:00")
                    ticket1.Encabezado("TELEFONO: 618 195 1338")
                    ticket1.Encabezado("FECHA: " & Date.Today.ToShortDateString)
                    ticket1.Articulo("CODE", "1", "Orden de Pago", ventas.sumTot, ventas.sumTot)
                    ticket1.NumArticulos("1")
                    ticket1.Total(ventas.sumTot)
                    ticket1.Pago("RECIBI: ", "Pago Electrónico")
                    ticket1.Pago("CAMBIO: ", "N/A")
                    ticket1.Pie("GRACIAS POR SU COMPRA, VUELVA PRONTO")
                    ticket1.Imprimir("(XP-58 (copy 1))", True)
                    MsgBox("Venta Realizada")
                    txtPagar.Clear()
                    chBEfectivo.Checked = False
                    cbElectronico.Checked = False
                    Me.Close()
                    ventas.Close()
                ElseIf chBEfectivo.Checked = True And cbElectronico.Checked = True Then
                    MsgBox("Solo puedes seleccionar un tipo de pago")
                End If
            Else
                ventas.dtTodo.Columns.Add("id_product")
                If chBEfectivo.Checked = True And cbElectronico.Checked = False Then
                    For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1
                        ventas.dtTodo(i)("id_product") = (consultas.getIDByProducto(ventas.dtTodo(i)("name")))
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
                            consultas.insSale(ventas.dtTodo(i)("id_product"), ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), "Efectivo", ventas.dtTodo(i)("total"))
                        Next
                        cerrar = False
                    End If
                    If cerrar = False Then

                        Dim ticket1 As Tickets = New Tickets
                        ticket1.Logo("../../Resources/logo nuevo.png")
                        ticket1.Titulo("TESLACEL")
                        ticket1.Encabezado("PINO SUAREZ #2014")
                        ticket1.Encabezado("DURANGO,DGO CP:34220")
                        ticket1.Encabezado("HORARIO 10:00 - 20:00")
                        ticket1.Encabezado("TELEFONO: 618 195 1338")
                        ticket1.Encabezado("FECHA: " & Date.Today.ToShortDateString)
                        For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1
                            ticket1.Articulo("CODE", ventas.dtTodo(i)("cantidad").ToString, ventas.dtTodo(i)("name").ToString, ventas.dtTodo(i)("price").ToString, ventas.dtTodo(i)("total").ToString)
                        Next
                        ticket1.NumArticulos(ventas.dtTodo.Rows.Count)
                        ticket1.Total(ventas.sumTot)
                        ticket1.Pago("RECIBI: ", txtPagar.Text)
                        ticket1.Pago("CAMBIO: ", Val(txtPagar.Text) - Val(ventas.sumTot))
                        If ventas.garantia = True Then
                            ticket1.Pie("GARANTIA: SI  COBERTURA:" & ventas.cobertura & " MESES")
                        End If
                        ticket1.Pie("GRACIAS POR SU COMPRA, VUELVA PRONTO")
                        ticket1.Imprimir("(XP-58 (copy 1))", True)

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
                        ventas.dtTodo(i)("id_product") = (consultas.getIDByProducto(ventas.dtTodo(i)("name")))
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
                            consultas.insSale(ventas.dtTodo(i)("id_product"), ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), "Electrónico ", ventas.dtTodo(i)("total"))
                        Next
                        cerrar = False
                    End If
                    If cerrar = False Then

                        Dim ticket1 As Tickets = New Tickets
                        ticket1.Logo("../../Resources/logo nuevo.png")
                        ticket1.Titulo("TESLACEL")
                        ticket1.Encabezado("PINO SUAREZ #2014")
                        ticket1.Encabezado("DURANGO,DGO CP:34220")
                        ticket1.Encabezado("RFC: HEEWD2323DS2")
                        ticket1.Encabezado("FECHA: " & Date.Today.ToShortDateString)
                        For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1
                            ticket1.Articulo("CODE", ventas.dtTodo(i)("cantidad").ToString, ventas.dtTodo(i)("name").ToString, ventas.dtTodo(i)("price").ToString, ventas.dtTodo(i)("total").ToString)
                        Next
                        ticket1.NumArticulos(ventas.dtTodo.Rows.Count)
                        ticket1.Total(ventas.sumTot)
                        ticket1.Pago("PAGO ELEC : ", ventas.sumTot)
                        If ventas.garantia = True Then
                            ticket1.Pie("GARANTIA: SI  COBERTURA:" & ventas.cobertura & " MESES")
                        End If
                        ticket1.Pie("GRACIAS POR SU COMPRA, VUELVA PRONTO")
                        ticket1.Imprimir("(XP-58 (copy 1))", True)
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
        Me.Close()
    End Sub

    Private Sub cbElectronico_CheckedChanged(sender As Object, e As EventArgs) Handles cbElectronico.CheckedChanged
        If cbElectronico.Checked = True And chBEfectivo.Checked = False Then
            btnConfirmar.Enabled = True
        End If
    End Sub
End Class
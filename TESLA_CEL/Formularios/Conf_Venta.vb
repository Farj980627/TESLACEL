
Imports LibPrintTicket

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
                    Dim ticket As Ticket = New Ticket()
                    ticket.AddHeaderLine("TESLACEL")
                    ticket.AddHeaderLine("Pino Suarez #2014")
                    ticket.AddHeaderLine("DURANGO, DGO")
                    ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() & " " + DateTime.Now.ToShortTimeString())
                    ticket.AddItem("1", "Orden de Pago", "")
                    ticket.AddFooterLine("Total: $" & ventas.sumTot)
                    ticket.AddFooterLine("Recibido: $" & txtPagar.Text)
                    ticket.AddFooterLine("Cambio: $" & Val(txtPagar.Text) - Val(ventas.sumTot))
                    ticket.AddFooterLine("VUELVA PRONTO")
                    ticket.PrintTicket("XP-58 (copy 1)")
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
                    Dim ticket As Ticket = New Ticket()
                    ticket.AddHeaderLine("TESLACEL")
                    ticket.AddHeaderLine("Pino Suarez #2014")
                    ticket.AddHeaderLine("DURANGO, DGO")
                    ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() & " " + DateTime.Now.ToShortTimeString())
                    ticket.AddItem("1", "Orden de Pago", "")
                    ticket.AddFooterLine("Total: $" & ventas.sumTot)
                    ticket.AddFooterLine("Pago Electrónico")
                    ticket.AddFooterLine("-----")
                    ticket.AddFooterLine("VUELVA PRONTO")
                    ticket.PrintTicket("XP-58 (copy 1)")
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
                        Dim b As String = consultas.getProductosByProductos(ventas.dtTodo(i)("name"))(0)("quantity").ToString()
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
                            newCantidad = Val(consultas.getProductosByProductos(ventas.dtTodo(i)("name"))(0)("quantity")) - Val(ventas.dtTodo(i)("cantidad"))
                            consultas.updInventario(newCantidad, ventas.dtTodo(i)("id_product"))
                            consultas.insSale(ventas.dtTodo(i)("id_product"), ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), "Efectivo", ventas.dtTodo(i)("total"))
                        Next
                        cerrar = False
                    End If
                    If cerrar = False Then
                        Dim ticket As Ticket = New Ticket()
                        ticket.AddHeaderLine("TESLACEL")
                        ticket.AddHeaderLine("Pino Suarez #2014")
                        ticket.AddHeaderLine("DURANGO, DGO")
                        ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() & " " + DateTime.Now.ToShortTimeString())

                        For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1
                            ticket.AddItem(ventas.dtTodo(i)("cantidad"), ventas.dtTodo(i)("name"), ventas.dtTodo(i)("price"))
                        Next
                        ticket.AddFooterLine("Total: $" & ventas.sumTot)
                        ticket.AddFooterLine("Recibido: $" & txtPagar.Text)
                        ticket.AddFooterLine("Cambio: $" & Val(txtPagar.Text) - Val(ventas.sumTot))
                        ticket.AddFooterLine("VUELVA PRONTO")
                        ticket.PrintTicket("XP-58 (copy 1)")
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
                        Dim b As String = consultas.getProductosByProductos(ventas.dtTodo(i)("name"))(0)("quantity").ToString()
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
                            newCantidad = Val(consultas.getProductosByProductos(ventas.dtTodo(i)("name"))(0)("quantity")) - Val(ventas.dtTodo(i)("cantidad"))
                            consultas.updInventario(newCantidad, ventas.dtTodo(i)("id_product"))
                            consultas.insSale(ventas.dtTodo(i)("id_product"), ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), "Electrónico ", ventas.dtTodo(i)("total"))
                        Next
                        cerrar = False
                    End If
                    If cerrar = False Then
                        Dim ticket As Ticket = New Ticket()
                        ticket.AddHeaderLine("TESLACEL")
                        ticket.AddHeaderLine("Pino Suarez #2014")
                        ticket.AddHeaderLine("DURANGO, DGO")
                        ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() & " " + DateTime.Now.ToShortTimeString())
                        For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1
                            ticket.AddItem(ventas.dtTodo(i)("cantidad"), ventas.dtTodo(i)("name"), ventas.dtTodo(i)("price"))
                        Next
                        ticket.AddFooterLine("Total: $" & ventas.sumTot)
                        ticket.AddFooterLine("Pago Electrónico")
                        ticket.AddFooterLine("-----")
                        ticket.AddFooterLine("VUELVA PRONTO")
                        ticket.PrintTicket("XP-58 (copy 1)")
                        MsgBox("Venta Realizada")
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
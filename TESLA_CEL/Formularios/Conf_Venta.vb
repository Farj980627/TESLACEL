Public Class Conf_Venta
    Dim id_product As New DataColumn("id_product", GetType(System.String))
    Private Sub Conf_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = ventas.sumTot
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            If ventas.orden = True Then
                If chBEfectivo.Checked = True And cbElectronico.Checked = False Then
                    consultas.insSale(11, 1, Date.Today.ToString("yyyy-MM-dd"), "Efectivo", ventas.sumTot)
                    txtPagar.Clear()
                    Me.Close()
                    MsgBox("Favor de Regresar: $" & Val(txtPagar.Text) - Val(lblTotal.Text))
                ElseIf chBEfectivo.Checked = False And cbElectronico.Checked = False Then
                    MsgBox("Selecciona una Forma de Pago")
                ElseIf chBEfectivo.Checked = False And cbElectronico.Checked = True Then
                    consultas.insSale(11, 1, Date.Today.ToString("yyyy-MM-dd"), "Electrónico ", ventas.sumTot)
                    txtPagar.Clear()
                    Me.Close()
                ElseIf chBEfectivo.Checked = True And cbElectronico.Checked = True Then
                    MsgBox("Solo puedes seleccionar un tipo de pago")
                End If

            Else
                ventas.dtTodo.Columns.Add("id_product")
                If chBEfectivo.Checked = True And cbElectronico.Checked = False Then
                    For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1
                        ventas.dtTodo(i)("id_product") = (consultas.getIDByProducto(ventas.dtTodo(i)("name")))
                        Dim a As String = ventas.dtTodo(i)("cantidad").ToString()
                        Dim b As String = consultas.getProductosByProductos(ventas.dtTodo(i)("name"))(i)("quantity").ToString()
                        If Val(a) <= Val(b) Then
                            Dim newCantidad As String
                            newCantidad = Val(b) - Val(a)
                            consultas.updInventario(newCantidad, ventas.dtTodo(i)("id_product"))
                            consultas.insSale(ventas.dtTodo(i)("id_product"), ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), "Efectivo", ventas.dtTodo(i)("total"))
                        Else
                            MsgBox("Cantidad en Inventario es insuficiente para realizar la venta")
                        End If
                        txtPagar.Clear()
                        chBEfectivo.Checked = False
                        cbElectronico.Checked = False
                        Me.Close()
                    Next
                ElseIf chBEfectivo.Checked = False And cbElectronico.Checked = False Then
                    MsgBox("Selecciona una Forma de Pago")
                ElseIf chBEfectivo.Checked = False And cbElectronico.Checked = True Then
                    For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1
                        ventas.dtTodo(i)("id_product") = (consultas.getIDByProducto(ventas.dtTodo(i)("name")))
                        Dim a As String = ventas.dtTodo(i)("cantidad").ToString()
                        Dim b As String = consultas.getProductosByProductos(ventas.dtTodo(i)("name"))(i)("quantity").ToString()
                        If Val(a) <= Val(b) Then
                            Dim newCantidad As String
                            newCantidad = Val(b) - Val(a)
                            consultas.updInventario(newCantidad, ventas.dtTodo(i)("id_product"))
                            consultas.insSale(ventas.dtTodo(i)("id_product"), ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), "Electrónico ", ventas.dtTodo(i)("total"))
                        End If

                    Next
                    txtPagar.Clear()
                    chBEfectivo.Checked = False
                    cbElectronico.Checked = False
                    Me.Close()
                ElseIf chBEfectivo.Checked = True And cbElectronico.Checked = True Then
                    MsgBox("Solo puedes seleccionar un tipo de pago")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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
            MsgBox(ex)
        End Try
    End Sub

    Private Sub txtPagar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagar.KeyPress
        Try
            If Not Char.IsNumber(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception
            MsgBox(e)
        End Try
    End Sub
End Class
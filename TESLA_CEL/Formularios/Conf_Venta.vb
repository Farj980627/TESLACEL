Public Class Conf_Venta
    Dim id_product As New DataColumn("id_product", GetType(System.String))
    Private Sub Conf_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = ventas.sumTot
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        ventas.dtTodo.Columns.Add("id_product")
        If chBEfectivo.Checked = True And cbElectronico.Checked = False Then
            For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1
                ventas.dtTodo(i)("id_product") = (consultas.getIDByProducto(ventas.dtTodo(i)("name")))
                consultas.insSale(ventas.dtTodo(i)("id_product"), ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), "Efectivo", ventas.dtTodo(i)("total"))
                txtPagar.Clear()
                Me.Close()
            Next
            MsgBox("Favor de Regresar: $" & txtPagar.Text - lblTotal.Text)
        ElseIf chBEfectivo.Checked = False And cbElectronico.Checked = False Then
            MsgBox("Selecciona una Forma de Pago")
        ElseIf chBEfectivo.Checked = False And cbElectronico.Checked = True Then
            For i As Integer = 0 To ventas.dtTodo.Rows.Count - 1 Step +1
                ventas.dtTodo(i)("id_product") = (consultas.getIDByProducto(ventas.dtTodo(i)("name")))
                consultas.insSale(ventas.dtTodo(i)("id_product"), ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), "Electrónico ", ventas.dtTodo(i)("total"))
            Next
            MsgBox("Favor de Regresar: $" & txtPagar.Text - lblTotal.Text)
            txtPagar.Clear()
            Me.Close()
        ElseIf chBEfectivo.Checked = True And cbElectronico.Checked = True Then
            MsgBox("Solo puedes seleccionar un tipo de pago")
        End If
    End Sub
    Private Sub txtPagar_TextChanged(sender As Object, e As EventArgs) Handles txtPagar.TextChanged
        If Val(txtPagar.Text) > Val(lblTotal.Text) Then
            btnConfirmar.Enabled = True
        Else
            btnConfirmar.Enabled = False
        End If
    End Sub
End Class
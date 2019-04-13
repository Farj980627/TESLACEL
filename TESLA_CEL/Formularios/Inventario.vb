Public Class Inventario
    Dim newDt As New DataTable
    Dim con As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Insertar_Prod.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar_Prod.ShowDialog()
    End Sub
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtpFin.Value = Date.Today
            dtpInicio.Value = Date.Today
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            newDt = consultas.getProductosAll()
            newDt.Columns.Remove("id_product")
            dgvProducto.DataSource = newDt
        Catch ex As Exception

        End Try
    End Sub



    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                newDt = consultas.getProductosByProductosParaInv(txtNombre.Text)
                newDt.Columns.Remove("id_product")
                dgvProducto.DataSource = newDt
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click
        txtNombre.Clear()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Actualizar_Prod.ShowDialog()
    End Sub
    Private Sub btnBuscarFechas_Click(sender As Object, e As EventArgs) Handles btnBuscarFechas.Click
        ' Try
        If dtpFin.Value < dtpInicio.Value Then
                MsgBox("La Fecha de inicio es mayor que la final")
            Else
                dgvProducto.DataSource = consultas.getProductosByDate(dtpInicio.Value.Date.ToString("yyyy-MM-dd"), dtpFin.Value.Date.ToString("yyyy-MM-dd"))
            End If
        ' Catch ex As Exception

        ' End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Registar_Proveedor.ShowDialog()
    End Sub


End Class
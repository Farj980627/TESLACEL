Public Class Reportes
    Dim suma As String
    Sub totalreporte()
        suma = ""
        For Each row As DataGridViewRow In dgvProducto.Rows
            If row.Cells("total").Value.Equals("") Then
                suma = suma
            Else
                suma = Val(suma) + row.Cells("total").Value
            End If

        Next
        lblTotal.Text = suma
    End Sub
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try

            dgvProducto.DataSource = consultas.getReportsAll
            totalreporte()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub bntDiario_Click(sender As Object, e As EventArgs) Handles bntDiario.Click

        dgvProducto.DataSource = consultas.getDayliReport(Date.Today.ToString("yyyy-MM-dd"))
        totalreporte()
    End Sub

    Private Sub btnBuscarFechas_Click(sender As Object, e As EventArgs) Handles btnBuscarFechas.Click
        Try
            If dtpFin.Value < dtpInicio.Value Then
                MsgBox("La Fecha de inicio es mayor que la final")
            Else
                If cbTipo.Text = "Todos Los Pagos" Then
                    dgvProducto.DataSource = consultas.getDateReport(dtpInicio.Value.Date.ToString("yyyy-MM-dd"), dtpFin.Value.Date.ToString("yyyy-MM-dd"))
                    totalreporte()
                Else
                    dgvProducto.DataSource = consultas.getDateTypeReport(dtpInicio.Value.Date.ToString("yyyy-MM-dd"), dtpFin.Value.Date.ToString("yyyy-MM-dd"), cbTipo.Text)
                    totalreporte()
                End If
            End If
        Catch ex As Exception

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

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Try
            dgvProducto.DataSource = consultas.getProductReport(txtNombre.Text)
            totalreporte()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Reportes_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        dgvProducto.DataSource = ""
        lblTotal.Text = ""
    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFin.Value = Date.Today
        dtpInicio.Value = Date.Today
    End Sub
End Class
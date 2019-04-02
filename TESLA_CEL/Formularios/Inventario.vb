﻿Public Class Inventario
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
            newDt = consultas.getProveedor
            cbProveedor.DataSource = newDt
            cbProveedor.DisplayMember = "provider"
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            newDt = consultas.getProductos()
            dgvProducto.DataSource = newDt
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub cbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedor.SelectedIndexChanged
        newDt = consultas.getProductosByProveedor(cbProveedor.Text)
        dgvProducto.DataSource = newDt
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                newDt = consultas.getProductosByProductos(txtNombre.Text)
                dgvProducto.DataSource = newDt
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click
        txtNombre.Clear()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Actualizar_Prod.ShowDialog()
    End Sub
End Class
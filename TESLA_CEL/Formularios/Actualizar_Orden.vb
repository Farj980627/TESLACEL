Public Class Actualizar_Orden
    Dim newDt As DataTable
    Private Sub Actualizar_Orden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiartxt()
    End Sub
    Sub limpiartxt()
        For Each txt As Control In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
            End If
        Next
    End Sub


    Private Sub txtNum_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNum.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                newDt = consultas.getOrdenAll(txtNum.Text)
                If newDt.Rows.Count = 0 Then
                    MsgBox("Numero no encontrado")
                Else
                    txtCliente.Text = newDt(0)("cliente")
                    txtTelefono.Text = newDt(0)("telefono")
                    txtEquipo.Text = newDt(0)("equipo")
                    txtMarca.Text = newDt(0)("marca")
                    txtModelo.Text = newDt(0)("modelo")
                    txtColor.Text = newDt(0)("color")
                    txtActualizaciones.Text = newDt(0)("actualizaciones")

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscarFechas_Click(sender As Object, e As EventArgs) Handles btnBuscarFechas.Click
        Try
            consultas.updActualizaciones(txtNum.Text, txtActualizaciones.Text)
            limpiartxt()
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub
End Class
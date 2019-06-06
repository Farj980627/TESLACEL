Public Class Actualizar_Orden
    Dim newDt As DataTable
    Dim min As String = 0
    Dim max As String
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

    Private Sub txtTelefonosearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTelefonosearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            newDt = consultas.getOrdenAllCelular(txtTelefonosearch.Text)

            If newDt.Rows.Count = 0 Then
                MsgBox("Telefono no encontrado")
            ElseIf newDt.Rows.Count > 1 Then
                max = newDt.Rows.Count
                txtNum.Text = newDt(0)("code")
                txtCliente.Text = newDt(0)("cliente")
                txtTelefono.Text = newDt(0)("telefono")
                txtEquipo.Text = newDt(0)("equipo")
                txtMarca.Text = newDt(0)("marca")
                txtModelo.Text = newDt(0)("modelo")
                txtColor.Text = newDt(0)("color")
                txtActualizaciones.Text = newDt(0)("actualizaciones")
            Else
                txtNum.Text = newDt(0)("code")
                txtCliente.Text = newDt(0)("cliente")
                txtTelefono.Text = newDt(0)("telefono")
                txtEquipo.Text = newDt(0)("equipo")
                txtMarca.Text = newDt(0)("marca")
                txtModelo.Text = newDt(0)("modelo")
                txtColor.Text = newDt(0)("color")
                txtActualizaciones.Text = newDt(0)("actualizaciones")

            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        min = Val(min) + 1
        If min <= max - 1 Then
            txtCliente.Text = newDt(min)("cliente")
            txtTelefono.Text = newDt(min)("telefono")
            txtNum.Text = newDt(min)("code")
            txtEquipo.Text = newDt(min)("equipo")
            txtMarca.Text = newDt(min)("marca")
            txtModelo.Text = newDt(min)("modelo")
            txtColor.Text = newDt(min)("color")
            txtActualizaciones.Text = newDt(min)("actualizaciones")
        Else
            min = max - 1
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        min = Val(min) - 1
        If min >= 0 Then
            txtCliente.Text = newDt(min)("cliente")
            txtTelefono.Text = newDt(min)("telefono")
            txtNum.Text = newDt(min)("code")
            txtEquipo.Text = newDt(min)("equipo")
            txtMarca.Text = newDt(min)("marca")
            txtModelo.Text = newDt(min)("modelo")
            txtColor.Text = newDt(min)("color")
            txtActualizaciones.Text = newDt(min)("actualizaciones")
        Else
            min = 0
        End If
    End Sub
End Class
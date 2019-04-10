Imports LibPrintTicket



Public Class Soporte
    Dim newCode As String
    Private Sub Soporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            newCode = "300" & consultas.getContador
            txtCodigo.Text = newCode
        Catch ex As Exception
            
        End Try

    End Sub
    Private Sub btnBuscarFechas_Click(sender As Object, e As EventArgs) Handles btnBuscarFechas.Click
        Try


            consultas.insOrden(cbTipo.Text, txtDescripcion.Text, txtProblema.Text, txtAnticipo.Text, txtTotal.Text, newCode)



            consultas.insSale(24, 1, Date.Today.ToString("yyyy-MM-dd"), "Anticipo Orden", txtAnticipo.Text)

            txtTotal.Text = ""
            txtProblema.Text = "PROBLEMA"
            txtDescripcion.Text = "DESCRIPCIÓN"
            txtAnticipo.Text = ""
            MsgBox("Orden Generada Correctamente")

            consultas.insContador()
            newCode = "300" & consultas.getContador
            txtCodigo.Text = newCode


        Catch ex As Exception

        End Try

    End Sub
    Private Sub Soporte_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        txtDescripcion.Text = ""
        txtAnticipo.Text = ""
        txtProblema.Text = ""
        txtTotal.Text = ""
    End Sub
    Private Sub txtDescripcion_Click(sender As Object, e As EventArgs) Handles txtDescripcion.Click
        txtDescripcion.Text = ""
    End Sub
    Private Sub txtProblema_Click(sender As Object, e As EventArgs) Handles txtProblema.Click
        txtProblema.Text = ""
    End Sub
    Private Sub txtDescripcion_Leave(sender As Object, e As EventArgs) Handles txtDescripcion.Leave
        If txtDescripcion.Text = "" Then
            txtDescripcion.Text = "DESCRIPCIÓN"
        End If
    End Sub

    Private Sub txtProblema_Leave(sender As Object, e As EventArgs) Handles txtProblema.Leave
        If txtProblema.Text = "" Then
            txtProblema.Text = "PROBLEMA"
        End If
    End Sub

    Private Sub pCodigo_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub txtAnticipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnticipo.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception
            
        End Try
    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception
            
        End Try
    End Sub
End Class
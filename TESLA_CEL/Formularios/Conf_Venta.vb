Public Class Conf_Venta
    Private Sub Conf_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = ventas.sumTot
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        MsgBox("Favor de Regresar: $" & txtPagar.Text - lblTotal.Text)

    End Sub
End Class
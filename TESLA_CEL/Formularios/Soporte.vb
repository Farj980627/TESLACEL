Imports BarcodeLib
Public Class Soporte
    Dim newCode As String

    Private Sub Soporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newCode = "300" & consultas.getContador
        Dim Code As Barcode = New BarcodeLib.Barcode
        Code.IncludeLabel = True
        pCodigo.BackgroundImage = Code.Encode(BarcodeLib.TYPE.CODE11, newCode, Color.Black, Color.White, 400, 100)
    End Sub



    Private Sub btnBuscarFechas_Click(sender As Object, e As EventArgs) Handles btnBuscarFechas.Click
        consultas.insContador()
        newCode = "300" & consultas.getContador
        Dim Code As Barcode = New BarcodeLib.Barcode
        Code.IncludeLabel = True
        pCodigo.BackgroundImage = Code.Encode(BarcodeLib.TYPE.CODE11, newCode, Color.Black, Color.White, 400, 100)
    End Sub

    Private Sub Soporte_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        txtDescripcion.Text = ""
        txtAnticipo.Text = ""
        txtProblema.Text = ""
        txtTotal.Text = ""
    End Sub
End Class
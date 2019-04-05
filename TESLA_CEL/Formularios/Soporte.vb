Imports BarcodeLib
Imports itextsharp
Imports itextsharp.text
Imports itextsharp.text.pdf
Imports System.IO

Public Class Soporte
    Dim newCode As String
    Private Sub Soporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            newCode = "300" & consultas.getContador
            Dim Code As BarcodeLib.Barcode = New BarcodeLib.Barcode
            Code.IncludeLabel = True
            pCodigo.BackgroundImage = Code.Encode(BarcodeLib.TYPE.CODE11, newCode, Color.Black, Color.White, 400, 100)
        Catch ex As Exception
            
        End Try

    End Sub
    Private Sub btnBuscarFechas_Click(sender As Object, e As EventArgs) Handles btnBuscarFechas.Click
        Try
            consultas.insContador()
            newCode = "300" & consultas.getContador
            Dim Code As BarcodeLib.Barcode = New BarcodeLib.Barcode
            Code.IncludeLabel = True
            pCodigo.BackgroundImage = Code.Encode(BarcodeLib.TYPE.CODE11, newCode, Color.Black, Color.White, 400, 100)
            consultas.insOrden(cbTipo.Text, txtDescripcion.Text, txtProblema.Text, txtAnticipo.Text, txtTotal.Text, newCode)
            Dim ms As MemoryStream = New MemoryStream()
            pCodigo.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim buff As Byte() = ms.GetBuffer()
            SaveFileDialog1.DefaultExt = "pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    Dim DOCUMENTO As New Document
                    Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(SaveFileDialog1.FileName, FileMode.Create))
                    DOCUMENTO.Open()
                    DOCUMENTO.Add(New Paragraph("DESCRIPCIÓN: " & txtDescripcion.Text))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("PROBLEMA: " & txtProblema.Text))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("ANTICIPO: " & txtAnticipo.Text & "      " & "TOTAL: " & txtTotal.Text))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    Dim IMAGEN As Image = Image.GetInstance(buff)
                    DOCUMENTO.Add(IMAGEN)
                    DOCUMENTO.Close()
                    txtTotal.Text = ""
                    txtProblema.Text = ""
                    txtDescripcion.Text = "DESCRIPCIÓN"
                    txtAnticipo.Text = ""
                    MsgBox("Orden Generada Correctamente")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
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

    Private Sub pCodigo_Paint(sender As Object, e As PaintEventArgs) Handles pCodigo.Paint

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
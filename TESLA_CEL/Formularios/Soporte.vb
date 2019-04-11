Imports LibPrintTicket
Imports System.Text.RegularExpressions


Public Class Soporte
    Dim newCode As String
    Dim mic, alta, cc, camaras, wifi, señal, buzz, sensor As String



    Private Sub Soporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtpFecha.Value = Date.Today
            newCode = "300" & consultas.getContador
            txtCodigo.Text = newCode
            cbCargador.SelectedIndex = 0
            cbChip.SelectedIndex = 0
            cbEstado.SelectedIndex = 0
            cbFunciones.SelectedIndex = 0
            cbMemoria.SelectedIndex = 0
            cbPila.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnBuscarFechas_Click(sender As Object, e As EventArgs) Handles btnBuscarFechas.Click
        Try

            If chbAltavoz.Checked = True Then
                alta = "Si"
            Else
                alta = "No"
            End If
            If chbBuzzer.Checked = True Then
                buzz = "Si"
            Else
                buzz = "No"
            End If
            If chBCamaras.Checked = True Then
                camaras = "Si"
            Else
                camaras = "No"
            End If
            If chbCC.Checked = True Then
                cc = "Si"
            Else
                cc = "No"
            End If
            If chbMicrofono.Checked = True Then
                mic = "Si"
            Else
                mic = "No"
            End If
            If chbSensor.Checked = True Then
                sensor = "Si"
            Else
                sensor = "No"
            End If
            If chbSeñal.Checked = True Then
                señal = "Si"
            Else
                señal = "No"
            End If
            If chbWifi.Checked = True Then
                wifi = "Si"
            Else
                wifi = "No"
            End If
            consultas.insOrden(Date.Today.ToString("yyyy-MM-dd"), txtCliente.Text, txtTelefono.Text, txtEquipo.Text,
            txtMarca.Text, txtModelo.Text, txtColor.Text, cbEstado.Text, cbChip.Text, cbMemoria.Text, cbPila.Text, cbCargador.Text,
            txtFalla.Text, txtIMEI.Text, mic, alta, cc, camaras, wifi, señal, buzz, sensor, txtCoste.Text, txtAnticipo.Text, txtGarantia.Text,
            dtpFecha.Value.Date.ToString("yyyy-MM-dd"), txtEntrega.Text, txtCodigo.Text)

            consultas.insContador()
            newCode = "300" & consultas.getContador
            txtCodigo.Text = newCode

            cbCargador.SelectedIndex = 0
            cbChip.SelectedIndex = 0
            cbEstado.SelectedIndex = 0
            cbFunciones.SelectedIndex = 0
            cbMemoria.SelectedIndex = 0
            cbPila.SelectedIndex = 0
            For Each txt As Control In Me.Controls
                If TypeOf txt Is TextBox Then
                    txt.Text = ""
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub


    Private Sub txtAnticipo_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbFunciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFunciones.SelectedIndexChanged
        Try
            If cbFunciones.SelectedIndex = 1 Then
                chbAltavoz.Checked = True
                chbBuzzer.Checked = True
                chBCamaras.Checked = True
                chbCC.Checked = True
                chbMicrofono.Checked = True
                chbSensor.Checked = True
                chbSeñal.Checked = True
                chbWifi.Checked = True
            Else
                chbAltavoz.Checked = False
                chbBuzzer.Checked = False
                chBCamaras.Checked = False
                chbCC.Checked = False
                chbMicrofono.Checked = False
                chbSensor.Checked = False
                chbSeñal.Checked = False
                chbWifi.Checked = False
            End If
        Catch ex As Exception

        End Try
    End Sub


End Class
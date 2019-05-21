Imports LibPrintTicket
Imports System.Text.RegularExpressions
Imports WL

Public Class Soporte
    Dim newCode As String
    Dim mic, alta, cc, camaras, wifi, señal, buzz, sensor As String
    Public Shared anticipo As String
    Public Shared existicket As Boolean = False

    Private Sub txtCoste_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCoste.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then

            e.Handled = True
            MessageBox.Show("Introduzca sólo valores númericos")
        End If
    End Sub

    Private Sub txtAnticipo_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtAnticipo.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then

            e.Handled = True
            MessageBox.Show("Introduzca sólo valores númericos")
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then

            e.Handled = True
            MessageBox.Show("Introduzca sólo valores númericos")
        End If
    End Sub

    Private Sub txtCodigo_Click(sender As Object, e As EventArgs) Handles txtCodigo.Click
        newCode = DateTime.Today.ToString("ddMM") & DateTime.Now.ToString("hmss")
        txtCodigo.Text = newCode
    End Sub

    Public Shared ticketOrden As Tickets = New Tickets
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Buscar_Orden.ShowDialog()
    End Sub




    Private Sub Soporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtpFecha.Value = Date.Today
            newCode = DateTime.Today.ToString("ddMM") & DateTime.Now.ToString("hmss")
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
            txtFalla.Text, txtIMEI.Text, txtObservaciones.Text, mic, alta, cc, camaras, wifi, señal, buzz, sensor, txtCoste.Text, txtAnticipo.Text, txtGarantia.Text,
            dtpFecha.Value.Date.ToString("yyyy-MM-dd"), txtEntrega.Text, txtCodigo.Text)


            newCode = DateTime.Today.ToString("ddMM") & DateTime.Now.ToString("hmss")
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
            chbAltavoz.Checked = False
            chbBuzzer.Checked = False
            chBCamaras.Checked = False
            chbCC.Checked = False
            chbMicrofono.Checked = False
            chbSensor.Checked = False
            chbSeñal.Checked = False
            chbWifi.Checked = False

            MsgBox("Orden Generada, Favor de Imprimirla")
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
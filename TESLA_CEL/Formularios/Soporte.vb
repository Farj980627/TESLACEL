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

    Public Shared ticketOrden As Tickets = New Tickets
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Buscar_Orden.ShowDialog()
    End Sub




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
            txtFalla.Text, txtIMEI.Text, txtObservaciones.Text, mic, alta, cc, camaras, wifi, señal, buzz, sensor, txtCoste.Text, txtAnticipo.Text, txtGarantia.Text,
            dtpFecha.Value.Date.ToString("yyyy-MM-dd"), txtEntrega.Text, txtCodigo.Text)

            anticipo = txtAnticipo.Text

            ' ticketOrden.Logo("../../Resources/logo nuevo.png")
            'ticketOrden.Titulo("TESLACEL")
            'ticketOrden.Encabezado("PINO SUAREZ #2014")
            'ticketOrden.Encabezado("DURANGO,DGO CP:34270")
            'ticketOrden.Encabezado("HORARIO 10:00 - 20:00")
            'ticketOrden.Encabezado("TELEFONO: 618 195 1338")
            'ticketOrden.Encabezado("RFC: HEGE940315HE6")
            'ticketOrden.Encabezado("FECHA: " & Date.Today.ToShortDateString)
            'ticketOrden.Encabezado("# ORDEN: " & txtCodigo.Text)
            'ticketOrden.Encabezado("CLIENTE: " & txtCliente.Text)
            'ticketOrden.Encabezado("TELEFONO CLIENTE: " & txtTelefono.Text)
            'ticketOrden.Encabezado("EQUIPO: " & txtEquipo.Text)
            'ticketOrden.Encabezado("MODELO: " & txtModelo.Text)
            'ticketOrden.Encabezado("MARCA: " & txtMarca.Text)
            'ticketOrden.Encabezado("COLOR: " & txtColor.Text)
            'If cbChip.SelectedIndex = 0 Then
            'ticketOrden.Encabezado("CHIP: NO")
            'Else
            'ticketOrden.Encabezado("CHIP: SI")
            'End If
            'If cbMemoria.SelectedIndex = 0 Then
            'ticketOrden.Encabezado("MEMORIA: NO")
            'Else
            'ticketOrden.Encabezado("MEMORIA: SI")
            'End If
            'If cbPila.SelectedIndex = 0 Then
            'ticketOrden.Encabezado("PILA: NO")
            'Else
            'ticketOrden.Encabezado("PILA: SI")
            'End If
            'If cbCargador.SelectedIndex = 0 Then
            'ticketOrden.Encabezado("CARGADOR: NO")
            'Else
            'ticketOrden.Encabezado("CARGADOR: SI")
            'End If
            'ticketOrden.Encabezado("FALLA: " & txtFalla.Text)
            'ticketOrden.Encabezado("IMEI: " & txtIMEI.Text)
            'ticketOrden.Encabezado("OBSERVACIONES: " & txtObservaciones.Text)
            'ticketOrden.Encabezado("FUNCIONES REVISADAS")
            'If chbMicrofono.Checked = False Then
            'ticketOrden.Encabezado("MICROFONO: NO")
            'Else
            'ticketOrden.Encabezado("MICROFONO: SI")
            'End If
            'If chbAltavoz.Checked = False Then
            'ticketOrden.Encabezado("ALTAVOZ: NO")
            'Else
            'ticketOrden.Encabezado("ALTAVOZ: SI")
            'End If
            'If chbCC.Checked = False Then
            ' ticketOrden.Encabezado("C.C: NO")
            ' Else
            'ticketOrden.Encabezado("C.C: SI")
            'End If
            'If chBCamaras.Checked = False Then
            'ticketOrden.Encabezado("CAMARAS: NO")
            'Else
            ' ticketOrden.Encabezado("CAMARAS: SI")
            'End If
            'If chbWifi.Checked = False Then
            'ticketOrden.Encabezado("WI-FI: NO")
            'Else
            'ticketOrden.Encabezado("WI-FI: SI")
            'End If
            'If chbSeñal.Checked = False Then
            'ticketOrden.Encabezado("SEÑAL: NO")
            'Else
            'ticketOrden.Encabezado("SEÑAL: SI")
            'End If
            'If chbBuzzer.Checked = False Then
            'ticketOrden.Encabezado("BUZZER: NO")
            'Else
            'ticketOrden.Encabezado("BUZZER: SI")
            'End If
            'If chbSensor.Checked = False Then
            'ticketOrden.Encabezado("SENSOR: NO")
            'Else
            'ticketOrden.Encabezado("SENSOR: SI")
            'End If
            'ticketOrden.Encabezado("GARANTIA: " & txtGarantia.Text)
            'ticketOrden.Encabezado("FECHA ENTREGA: " & dtpFecha.Value.Date.ToShortDateString)
            'ticketOrden.Articulo("", "1", "ORDEN", txtCoste.Text, txtCoste.Text)
            'ticketOrden.Total(txtCoste.Text)
            'ticketOrden.Pago("ANTICIPO", txtAnticipo.Text)
            'ticketOrden.Pie("1.- El cliente se hace responsable de la procedencia del equipo.")
            'ticketOrden.Pie("2.- Toda resvisión genera honorarios minimos de $30 pesos.")
            'ticketOrden.Pie("3.- Después de 30 días no nos hacemos responsables por ningún equipo.")
            'ticketOrden.Pie("4.- No nos hacemos responsables por equipos que vengan apagados que puedan presentar fallas aleatorias.")
            'ticketOrden.Pie("5.- No respondemos por ningún equipo después de 60 días (Basados en el artículo de la cámara de comercio, pudiendo disponer del equipo para los intereses que más le convengan al propietario del taller).")
            'ticketOrden.Pie("6.- Todo equipo ya reparado que no sea retirado después de 10 días de comunicado su reparación se le sumara una multa de $80 pesos a la semana a la cantidad total que se estableció, por gastos de almacenamiento, hasta llegar a 60 días.")
            'ticketOrden.Pie("7.- No nos hacemos responsables por memorias o chips olvidados en el taller.")
            'ticketOrden.Pie("8.- Algunos equipos son reparados en otra de nuestras sucursales por motivos de espacio y seguridad.")
            'ticketOrden.Pie("9.- No respondemos por equipo mojados que al ser intervenidos empeoren su estado o se apaguen (Todo equipo mojado tiene secuelas).")
            'ticketOrden.Pie("GARANTIA: *El plazo de garantía es de 15 días (empieza a contar el día que se da aviso que el equipo está listo). 
            '*El trámite de garantía es de 1 a 3 días hábiles. 
            '*La garantía cubre únicamente defectos de fabrica de la pieza reparada o remplazada. 
            '*En equipos golpeados y mojados no hay garantía. 
            '*Secuelas de golpes y humedad no entran como garantía. 
            '*La garantía se vuelve NULA si se pierde la póliza de garantía, el equipo es abierto por personas ajenas al taller tesla, sello de garantía alterado o roto, equipos golpeados o mojados. 
            '*En caso de ser un cristal la pieza remplazada, esta no debe estar rallada ni estrellada.")
            'ticketOrden.Pie("DESPUES DE 30 DIAS NO NOS HACEMOS RESPONSABLES DE NINGUN APARATO")
            'ticketOrden.Pie("________________________________________________________________________________________________________________________________")
            'ticketOrden.Pie("Al firmar acepta nuestros terminos y condiciones.")
            'existicket = True


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
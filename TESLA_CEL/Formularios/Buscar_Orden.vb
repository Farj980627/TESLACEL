Public Class Buscar_Orden
    Dim newDt As DataTable
    Private Sub btnBuscarFechas_Click(sender As Object, e As EventArgs) Handles btnBuscarFechas.Click
        Try
            newDt = consultas.getOrdenAll(txtNum.Text)
            txtCliente.Text = newDt(0)("cliente")
            txtTelefono.Text = newDt(0)("telefono")
            txtEquipo.Text = newDt(0)("equipo")
            txtMarca.Text = newDt(0)("marca")
            txtModelo.Text = newDt(0)("modelo")
            txtColor.Text = newDt(0)("color")
            If newDt(0)("estado") = "Apagado" Then
                cbEstado.SelectedIndex = 0
            Else
                cbEstado.SelectedIndex = 1
            End If
            If newDt(0)("chip") = "No" Then
                cbChip.SelectedIndex = 0
            Else
                cbChip.SelectedIndex = 1
            End If
            If newDt(0)("memoria") = "No" Then
                cbMemoria.SelectedIndex = 0
            Else
                cbMemoria.SelectedIndex = 1
            End If
            If newDt(0)("pila") = "No" Then
                cbPila.SelectedIndex = 0
            Else
                cbPila.SelectedIndex = 1
            End If
            If newDt(0)("cargador") = "No" Then
                cbCargador.SelectedIndex = 0
            Else
                cbCargador.SelectedIndex = 1
            End If
            txtFalla.Text = newDt(0)("falla")
            txtIMEI.Text = newDt(0)("imei")
            If newDt(0)("microfono") = "Si" Then
                chbMicrofono.Checked = True
            End If
            If newDt(0)("altavoz") = "Si" Then
                chbAltavoz.Checked = True
            End If
            If newDt(0)("cc") = "Si" Then
                chbCC.Checked = True
            End If
            If newDt(0)("camaras") = "Si" Then
                chBCamaras.Checked = True
            End If
            If newDt(0)("wifi") = "Si" Then
                chbWifi.Checked = True
            End If
            If newDt(0)("señal") = "Si" Then
                chbSeñal.Checked = True
            End If
            If newDt(0)("sensor") = "Si" Then
                chbSensor.Checked = True
            End If
            txtCoste.Text = newDt(0)("costoestimado")
            txtAnticipo.Text = newDt(0)("anticipo")
            txtGarantia.Text = newDt(0)("garantia")
            dtpFecha.Value = newDt(0)("fechaentrega")
            txtEntrega.Text = newDt(0)("horaentrega")
        Catch ex As Exception
            MsgBox("Numero no encontrado")
        End Try
    End Sub

    Private Sub bntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        For Each txt As Control In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
            End If
        Next

        Me.Close()
    End Sub
End Class
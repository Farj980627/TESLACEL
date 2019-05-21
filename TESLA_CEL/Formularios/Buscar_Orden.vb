Public Class Buscar_Orden
    Dim newDt As DataTable
    Dim max As String
    Dim min As String = 0
    Private Sub btnBuscarFechas_Click(sender As Object, e As EventArgs) Handles btnBuscarFechas.Click
        Try
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
                txtObservaciones.Text = newDt(0)("observaciones")
            End If

        Catch ex As Exception

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

    Private Sub txtCelular_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCelular.KeyDown
        If e.KeyCode = Keys.Enter Then
            newDt = consultas.getOrdenAllCelular(txtCelular.Text)
            txtCelular.Clear()
            PictureBox1.Visible = True
            PictureBox2.Visible = True

            If newDt.Rows.Count > 1 Then
                max = newDt.Rows.Count

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
                txtObservaciones.Text = newDt(0)("observaciones")
            Else

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
                txtObservaciones.Text = newDt(0)("observaciones")
            End If

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        min = Val(min) + 1
        If min <= max - 1 Then
            txtCliente.Text = newDt(min)("cliente")
            txtTelefono.Text = newDt(min)("telefono")
            txtEquipo.Text = newDt(min)("equipo")
            txtMarca.Text = newDt(min)("marca")
            txtModelo.Text = newDt(min)("modelo")
            txtColor.Text = newDt(min)("color")
            If newDt(min)("estado") = "Apagado" Then
                cbEstado.SelectedIndex = 0
            Else
                cbEstado.SelectedIndex = 1
            End If
            If newDt(min)("chip") = "No" Then
                cbChip.SelectedIndex = 0
            Else
                cbChip.SelectedIndex = 1
            End If
            If newDt(min)("memoria") = "No" Then
                cbMemoria.SelectedIndex = 0
            Else
                cbMemoria.SelectedIndex = 1
            End If
            If newDt(min)("pila") = "No" Then
                cbPila.SelectedIndex = 0
            Else
                cbPila.SelectedIndex = 1
            End If
            If newDt(min)("cargador") = "No" Then
                cbCargador.SelectedIndex = 0
            Else
                cbCargador.SelectedIndex = 1
            End If
            txtFalla.Text = newDt(min)("falla")
            txtIMEI.Text = newDt(min)("imei")
            If newDt(min)("microfono") = "Si" Then
                chbMicrofono.Checked = True
            End If
            If newDt(min)("altavoz") = "Si" Then
                chbAltavoz.Checked = True
            End If
            If newDt(min)("cc") = "Si" Then
                chbCC.Checked = True
            End If
            If newDt(min)("camaras") = "Si" Then
                chBCamaras.Checked = True
            End If
            If newDt(min)("wifi") = "Si" Then
                chbWifi.Checked = True
            End If
            If newDt(min)("señal") = "Si" Then
                chbSeñal.Checked = True
            End If
            If newDt(min)("sensor") = "Si" Then
                chbSensor.Checked = True
            End If
            txtCoste.Text = newDt(min)("costoestimado")
            txtAnticipo.Text = newDt(min)("anticipo")
            txtGarantia.Text = newDt(min)("garantia")
            dtpFecha.Value = newDt(min)("fechaentrega")
            txtEntrega.Text = newDt(min)("horaentrega")
            txtObservaciones.Text = newDt(min)("observaciones")
        Else
            min = max - 1
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        min = Val(min) - 1
        If min >= 0 Then
            txtCliente.Text = newDt(min)("cliente")
            txtTelefono.Text = newDt(min)("telefono")
            txtEquipo.Text = newDt(min)("equipo")
            txtMarca.Text = newDt(min)("marca")
            txtModelo.Text = newDt(min)("modelo")
            txtColor.Text = newDt(min)("color")
            If newDt(min)("estado") = "Apagado" Then
                cbEstado.SelectedIndex = 0
            Else
                cbEstado.SelectedIndex = 1
            End If
            If newDt(min)("chip") = "No" Then
                cbChip.SelectedIndex = 0
            Else
                cbChip.SelectedIndex = 1
            End If
            If newDt(min)("memoria") = "No" Then
                cbMemoria.SelectedIndex = 0
            Else
                cbMemoria.SelectedIndex = 1
            End If
            If newDt(min)("pila") = "No" Then
                cbPila.SelectedIndex = 0
            Else
                cbPila.SelectedIndex = 1
            End If
            If newDt(min)("cargador") = "No" Then
                cbCargador.SelectedIndex = 0
            Else
                cbCargador.SelectedIndex = 1
            End If
            txtFalla.Text = newDt(min)("falla")
            txtIMEI.Text = newDt(min)("imei")
            If newDt(min)("microfono") = "Si" Then
                chbMicrofono.Checked = True
            End If
            If newDt(min)("altavoz") = "Si" Then
                chbAltavoz.Checked = True
            End If
            If newDt(min)("cc") = "Si" Then
                chbCC.Checked = True
            End If
            If newDt(min)("camaras") = "Si" Then
                chBCamaras.Checked = True
            End If
            If newDt(min)("wifi") = "Si" Then
                chbWifi.Checked = True
            End If
            If newDt(min)("señal") = "Si" Then
                chbSeñal.Checked = True
            End If
            If newDt(min)("sensor") = "Si" Then
                chbSensor.Checked = True
            End If
            txtCoste.Text = newDt(min)("costoestimado")
            txtAnticipo.Text = newDt(min)("anticipo")
            txtGarantia.Text = newDt(min)("garantia")
            dtpFecha.Value = newDt(min)("fechaentrega")
            txtEntrega.Text = newDt(min)("horaentrega")
            txtObservaciones.Text = newDt(min)("observaciones")
        Else
            min = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Actualizar_Orden.ShowDialog()

    End Sub
End Class
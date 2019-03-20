﻿Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub loadForm(ByVal form As Object)
        If Me.contenedor.Controls.Count > 0 Then
            Me.contenedor.Controls.RemoveAt(0)
        End If
        Dim opened As Form = TryCast(form, Form)
        opened.TopLevel = False
        opened.Dock = DockStyle.Fill
        Me.contenedor.Controls.Add(opened)
        Me.contenedor.Tag = opened
        opened.Show()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        loadForm(usuarios)
        lblTitulo.Text = "USUARIOS"
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Login.Show()
    End Sub
End Class
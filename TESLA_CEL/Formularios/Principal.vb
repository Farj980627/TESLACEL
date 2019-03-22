Public Class Principal
    Public Shared userLevel, username As String
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = PictureBox1
        If userLevel = "3" Then
            btnInventario.Enabled = False
            btnReportes.Enabled = False
            btnUsuarios.Enabled = False
        ElseIf userLevel = "4" Then
            btnInventario.Enabled = False
            btnReportes.Enabled = False
            btnUsuarios.Enabled = False
            btnVentas.Enabled = False
        End If
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

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        loadForm(Inventario)
        lblTitulo.Text = "INVENTARIOS"
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        loadForm(ventas)
        lblTitulo.Text = "VENTAS"
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        loadForm(Reportes)
        lblTitulo.Text = "REPORTES"
    End Sub
End Class
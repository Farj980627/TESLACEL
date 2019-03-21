<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cbNivel = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.cbUsuarios = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPass
        '
        Me.txtPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.txtPass.Location = New System.Drawing.Point(135, 44)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(288, 30)
        Me.txtPass.TabIndex = 1
        Me.txtPass.Text = "CONTRASEÑA"
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(87, 55)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(288, 30)
        Me.txtUsuario.TabIndex = 2
        Me.txtUsuario.Text = "USUARIO"
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 306)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1069, 304)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(537, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(529, 146)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.txtUsuario)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(528, 146)
        Me.Panel2.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnGuardar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(537, 155)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(529, 146)
        Me.Panel4.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cbNivel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 155)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(528, 146)
        Me.Panel5.TabIndex = 6
        '
        'cbNivel
        '
        Me.cbNivel.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cbNivel.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNivel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.cbNivel.FormattingEnabled = True
        Me.cbNivel.Location = New System.Drawing.Point(87, 51)
        Me.cbNivel.Name = "cbNivel"
        Me.cbNivel.Size = New System.Drawing.Size(288, 38)
        Me.cbNivel.TabIndex = 0
        Me.cbNivel.Text = "NIVEL"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblTitulo)
        Me.Panel3.Controls.Add(Me.cbUsuarios)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1069, 300)
        Me.Panel3.TabIndex = 4
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(462, 75)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitulo.Size = New System.Drawing.Size(144, 31)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "USUARIOS:"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbUsuarios
        '
        Me.cbUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cbUsuarios.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.cbUsuarios.FormattingEnabled = True
        Me.cbUsuarios.Location = New System.Drawing.Point(335, 122)
        Me.cbUsuarios.Name = "cbUsuarios"
        Me.cbUsuarios.Size = New System.Drawing.Size(387, 38)
        Me.cbUsuarios.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnGuardar.Image = Global.TESLA_CEL.My.Resources.Resources.guardar_color
        Me.btnGuardar.Location = New System.Drawing.Point(164, 33)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(229, 59)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1069, 609)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "usuarios"
        Me.Text = "usuarios"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cbNivel As ComboBox
    Friend WithEvents cbUsuarios As ComboBox
    Friend WithEvents lblTitulo As Label
End Class

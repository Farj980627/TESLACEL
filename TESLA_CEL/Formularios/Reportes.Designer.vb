<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.bntDiario = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 300)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1067, 306)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(536, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(528, 147)
        Me.Panel1.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(116, 33)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(286, 30)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Text = "NOMBRE PRODUCTO"
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.bntDiario)
        Me.Panel2.Controls.Add(Me.cbProveedor)
        Me.Panel2.Controls.Add(Me.cbCategoria)
        Me.Panel2.Controls.Add(Me.btnMostrar)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(527, 147)
        Me.Panel2.TabIndex = 4
        '
        'cbProveedor
        '
        Me.cbProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cbProveedor.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(244, 51)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(271, 38)
        Me.cbProveedor.TabIndex = 2
        Me.cbProveedor.Text = "PROVEEDOR"
        '
        'cbCategoria
        '
        Me.cbCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cbCategoria.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(244, 4)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(271, 38)
        Me.cbCategoria.TabIndex = 1
        Me.cbCategoria.Text = "CATEGORIA"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(536, 156)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(528, 147)
        Me.Panel4.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dtpFin)
        Me.Panel5.Controls.Add(Me.dtpInicio)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 156)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(527, 147)
        Me.Panel5.TabIndex = 6
        '
        'dtpFin
        '
        Me.dtpFin.CalendarFont = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFin.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dtpFin.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(352, 13)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(173, 37)
        Me.dtpFin.TabIndex = 1
        Me.dtpFin.Value = New Date(2019, 3, 20, 0, 0, 0, 0)
        '
        'dtpInicio
        '
        Me.dtpInicio.CalendarFont = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicio.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dtpInicio.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(9, 13)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(181, 37)
        Me.dtpInicio.TabIndex = 0
        Me.dtpInicio.Value = New Date(2019, 3, 20, 0, 0, 0, 0)
        '
        'dgvProducto
        '
        Me.dgvProducto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvProducto.Location = New System.Drawing.Point(0, 0)
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.RowTemplate.Height = 24
        Me.dgvProducto.Size = New System.Drawing.Size(1069, 300)
        Me.dgvProducto.TabIndex = 8
        '
        'bntDiario
        '
        Me.bntDiario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntDiario.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.bntDiario.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntDiario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.bntDiario.Image = Global.TESLA_CEL.My.Resources.Resources.reporte_color
        Me.bntDiario.Location = New System.Drawing.Point(10, 68)
        Me.bntDiario.Name = "bntDiario"
        Me.bntDiario.Size = New System.Drawing.Size(228, 59)
        Me.bntDiario.TabIndex = 6
        Me.bntDiario.Text = "Reporte Diario"
        Me.bntDiario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bntDiario.UseVisualStyleBackColor = False
        '
        'btnMostrar
        '
        Me.btnMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnMostrar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnMostrar.Image = Global.TESLA_CEL.My.Resources.Resources.mostrar_todo
        Me.btnMostrar.Location = New System.Drawing.Point(9, 3)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(228, 59)
        Me.btnMostrar.TabIndex = 5
        Me.btnMostrar.Text = "Mostrar Todo"
        Me.btnMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1069, 609)
        Me.Controls.Add(Me.dgvProducto)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbProveedor As ComboBox
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents bntDiario As Button
    Friend WithEvents dgvProducto As DataGridView
End Class

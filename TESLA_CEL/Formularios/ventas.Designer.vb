<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtCodigo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1069, 62)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 547)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1069, 62)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'dgvProducto
        '
        Me.dgvProducto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProducto.Location = New System.Drawing.Point(0, 62)
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.RowTemplate.Height = 24
        Me.dgvProducto.Size = New System.Drawing.Size(1069, 485)
        Me.dgvProducto.TabIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(3, 29)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(528, 30)
        Me.txtCodigo.TabIndex = 9
        Me.txtCodigo.Text = "CODIGO DE BARRAS"
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Location = New System.Drawing.Point(537, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(529, 56)
        Me.Panel1.TabIndex = 10
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCantidad.Location = New System.Drawing.Point(172, 14)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(57, 30)
        Me.txtCantidad.TabIndex = 13
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(53, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(113, 31)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "CANT  X"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.btnConfirmar)
        Me.Panel2.Location = New System.Drawing.Point(537, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(529, 56)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RadioButton1)
        Me.Panel3.Controls.Add(Me.lblTotal)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(528, 56)
        Me.Panel3.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(271, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(100, 31)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "TOTAL:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(377, 11)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotal.Size = New System.Drawing.Size(133, 31)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "mil pesitos"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelar.Image = Global.TESLA_CEL.My.Resources.Resources.salir_color
        Me.btnCancelar.Location = New System.Drawing.Point(21, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(230, 47)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnConfirmar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnConfirmar.Image = Global.TESLA_CEL.My.Resources.Resources.comprar_color
        Me.btnConfirmar.Location = New System.Drawing.Point(290, 3)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(230, 47)
        Me.btnConfirmar.TabIndex = 13
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnBuscar.Image = Global.TESLA_CEL.My.Resources.Resources.buscar_color
        Me.btnBuscar.Location = New System.Drawing.Point(301, 6)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(204, 47)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.RadioButton1.Location = New System.Drawing.Point(9, 9)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(229, 35)
        Me.RadioButton1.TabIndex = 17
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Pago Electronico"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1069, 609)
        Me.Controls.Add(Me.dgvProducto)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ventas"
        Me.Text = "ventas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dgvProducto As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton1 As RadioButton
End Class

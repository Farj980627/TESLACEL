<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-8, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1058, 104)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(382, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(263, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ACCESO AL SISTEMA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnAcceder)
        Me.Panel2.Controls.Add(Me.txtPass)
        Me.Panel2.Controls.Add(Me.txtUsuario)
        Me.Panel2.Location = New System.Drawing.Point(-8, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1058, 422)
        Me.Panel2.TabIndex = 1
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.txtPass.Location = New System.Drawing.Point(388, 189)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(257, 30)
        Me.txtPass.TabIndex = 1
        Me.txtPass.Text = "CONTRASEÑA..."
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(388, 103)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(257, 30)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.Text = "USUARIO..."
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAcceder
        '
        Me.btnAcceder.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnAcceder.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnAcceder.Image = CType(resources.GetObject("btnAcceder.Image"), System.Drawing.Image)
        Me.btnAcceder.Location = New System.Drawing.Point(416, 323)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(229, 58)
        Me.btnAcceder.TabIndex = 2
        Me.btnAcceder.Text = "ACCEDER"
        Me.btnAcceder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAcceder.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TESLA_CEL.My.Resources.Resources.salir_color
        Me.PictureBox1.Location = New System.Drawing.Point(1012, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 520)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAcceder As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsgBox))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.picCorrecto = New System.Windows.Forms.PictureBox()
        Me.picInformacion = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picAdvertencia = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.picCorrecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInformacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAdvertencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelContenedor.Controls.Add(Me.txtMensaje)
        Me.PanelContenedor.Controls.Add(Me.btnCancelar)
        Me.PanelContenedor.Controls.Add(Me.btnAceptar)
        Me.PanelContenedor.Controls.Add(Me.PanelTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(584, 140)
        Me.PanelContenedor.TabIndex = 4
        '
        'txtMensaje
        '
        Me.txtMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.ForeColor = System.Drawing.Color.Gold
        Me.txtMensaje.Location = New System.Drawing.Point(7, 47)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(563, 20)
        Me.txtMensaje.TabIndex = 6
        Me.txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(369, 88)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(48, 43)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(173, 88)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(48, 43)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.picCorrecto)
        Me.PanelTitulo.Controls.Add(Me.picInformacion)
        Me.PanelTitulo.Controls.Add(Me.Label1)
        Me.PanelTitulo.Controls.Add(Me.picAdvertencia)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(580, 40)
        Me.PanelTitulo.TabIndex = 1
        '
        'picCorrecto
        '
        Me.picCorrecto.Image = CType(resources.GetObject("picCorrecto.Image"), System.Drawing.Image)
        Me.picCorrecto.Location = New System.Drawing.Point(536, 3)
        Me.picCorrecto.Name = "picCorrecto"
        Me.picCorrecto.Size = New System.Drawing.Size(34, 34)
        Me.picCorrecto.TabIndex = 9
        Me.picCorrecto.TabStop = False
        Me.picCorrecto.Visible = False
        '
        'picInformacion
        '
        Me.picInformacion.Image = CType(resources.GetObject("picInformacion.Image"), System.Drawing.Image)
        Me.picInformacion.Location = New System.Drawing.Point(536, 1)
        Me.picInformacion.Name = "picInformacion"
        Me.picInformacion.Size = New System.Drawing.Size(34, 34)
        Me.picInformacion.TabIndex = 8
        Me.picInformacion.TabStop = False
        Me.picInformacion.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(199, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mensaje del Sistema"
        '
        'picAdvertencia
        '
        Me.picAdvertencia.Image = CType(resources.GetObject("picAdvertencia.Image"), System.Drawing.Image)
        Me.picAdvertencia.InitialImage = CType(resources.GetObject("picAdvertencia.InitialImage"), System.Drawing.Image)
        Me.picAdvertencia.Location = New System.Drawing.Point(537, 4)
        Me.picAdvertencia.Name = "picAdvertencia"
        Me.picAdvertencia.Size = New System.Drawing.Size(33, 33)
        Me.picAdvertencia.TabIndex = 7
        Me.picAdvertencia.TabStop = False
        Me.picAdvertencia.Visible = False
        '
        'frmMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 140)
        Me.Controls.Add(Me.PanelContenedor)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMsgBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMsgBox"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.picCorrecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInformacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAdvertencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents picAdvertencia As PictureBox
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents picInformacion As PictureBox
    Friend WithEvents picCorrecto As PictureBox
End Class

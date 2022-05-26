<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListaPadron
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaPadron))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.cmbOrden = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NUDyyyy = New System.Windows.Forms.NumericUpDown()
        Me.NUDmm = New System.Windows.Forms.NumericUpDown()
        Me.cmbLocal = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbDpto = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAFecha = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbProv = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDyyyy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDmm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(232, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 36)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Listado Padrón de Matriculados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(43, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "ESTADOS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(273, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "SEXOS:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(441, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 19)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "CATEGORÍAS:"
        '
        'btnSalir
        '
        Me.btnSalir.AutoSize = True
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(791, 173)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSalir.Size = New System.Drawing.Size(65, 56)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.AutoSize = True
        Me.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltrar.FlatAppearance.BorderSize = 0
        Me.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrar.ForeColor = System.Drawing.Color.White
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFiltrar.Location = New System.Drawing.Point(435, 173)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFiltrar.Size = New System.Drawing.Size(66, 56)
        Me.btnFiltrar.TabIndex = 11
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(13, 48)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(898, 110)
        Me.PictureBox4.TabIndex = 144
        Me.PictureBox4.TabStop = False
        '
        'cmbEstado
        '
        Me.cmbEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.ForeColor = System.Drawing.Color.White
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"TODOS", "ACTIVO", "BAJA", "CANCELADO", "SUSP MOROSO", "SUSPENDIDO"})
        Me.cmbEstado.Location = New System.Drawing.Point(130, 57)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(135, 25)
        Me.cmbEstado.TabIndex = 0
        '
        'cmbSexo
        '
        Me.cmbSexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSexo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSexo.ForeColor = System.Drawing.Color.White
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"TODOS", "M", "F"})
        Me.cmbSexo.Location = New System.Drawing.Point(342, 57)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(91, 25)
        Me.cmbSexo.TabIndex = 1
        '
        'cmbCategoria
        '
        Me.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategoria.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoria.ForeColor = System.Drawing.Color.White
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Items.AddRange(New Object() {"TODOS", "A", "B"})
        Me.cmbCategoria.Location = New System.Drawing.Point(555, 57)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(90, 25)
        Me.cmbCategoria.TabIndex = 2
        '
        'cmbOrden
        '
        Me.cmbOrden.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOrden.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrden.ForeColor = System.Drawing.Color.White
        Me.cmbOrden.FormattingEnabled = True
        Me.cmbOrden.Items.AddRange(New Object() {"MATRICULA", "APELLIDO"})
        Me.cmbOrden.Location = New System.Drawing.Point(130, 88)
        Me.cmbOrden.Name = "cmbOrden"
        Me.cmbOrden.Size = New System.Drawing.Size(135, 25)
        Me.cmbOrden.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label5.Location = New System.Drawing.Point(61, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = "ORDEN:"
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.White
        Me.txtFecha.Location = New System.Drawing.Point(807, 91)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(91, 23)
        Me.txtFecha.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label6.Location = New System.Drawing.Point(693, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 19)
        Me.Label6.TabIndex = 150
        Me.Label6.Text = "FECHA JUR.:"
        '
        'NUDyyyy
        '
        Me.NUDyyyy.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NUDyyyy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NUDyyyy.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUDyyyy.ForeColor = System.Drawing.Color.White
        Me.NUDyyyy.Location = New System.Drawing.Point(460, 91)
        Me.NUDyyyy.Name = "NUDyyyy"
        Me.NUDyyyy.Size = New System.Drawing.Size(41, 23)
        Me.NUDyyyy.TabIndex = 5
        '
        'NUDmm
        '
        Me.NUDmm.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NUDmm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NUDmm.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUDmm.ForeColor = System.Drawing.Color.White
        Me.NUDmm.Location = New System.Drawing.Point(555, 91)
        Me.NUDmm.Name = "NUDmm"
        Me.NUDmm.Size = New System.Drawing.Size(41, 23)
        Me.NUDmm.TabIndex = 6
        '
        'cmbLocal
        '
        Me.cmbLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLocal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLocal.ForeColor = System.Drawing.Color.White
        Me.cmbLocal.FormattingEnabled = True
        Me.cmbLocal.Location = New System.Drawing.Point(130, 119)
        Me.cmbLocal.Name = "cmbLocal"
        Me.cmbLocal.Size = New System.Drawing.Size(185, 25)
        Me.cmbLocal.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label8.Location = New System.Drawing.Point(25, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 19)
        Me.Label8.TabIndex = 155
        Me.Label8.Text = "LOCALIDAD:"
        '
        'cmbDpto
        '
        Me.cmbDpto.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbDpto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDpto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDpto.ForeColor = System.Drawing.Color.White
        Me.cmbDpto.FormattingEnabled = True
        Me.cmbDpto.Location = New System.Drawing.Point(412, 119)
        Me.cmbDpto.Name = "cmbDpto"
        Me.cmbDpto.Size = New System.Drawing.Size(185, 25)
        Me.cmbDpto.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label9.Location = New System.Drawing.Point(325, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 19)
        Me.Label9.TabIndex = 157
        Me.Label9.Text = "DEPART.:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label10.Location = New System.Drawing.Point(504, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 19)
        Me.Label10.TabIndex = 158
        Me.Label10.Text = "Años"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label11.Location = New System.Drawing.Point(602, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 19)
        Me.Label11.TabIndex = 159
        Me.Label11.Text = "Meses"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label7.Location = New System.Drawing.Point(273, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 19)
        Me.Label7.TabIndex = 161
        Me.Label7.Text = "A FECHA:"
        '
        'txtAFecha
        '
        Me.txtAFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtAFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAFecha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAFecha.ForeColor = System.Drawing.Color.White
        Me.txtAFecha.Location = New System.Drawing.Point(360, 91)
        Me.txtAFecha.Name = "txtAFecha"
        Me.txtAFecha.Size = New System.Drawing.Size(91, 23)
        Me.txtAFecha.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 164)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(899, 72)
        Me.PictureBox1.TabIndex = 162
        Me.PictureBox1.TabStop = False
        '
        'cmbProv
        '
        Me.cmbProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProv.ForeColor = System.Drawing.Color.White
        Me.cmbProv.FormattingEnabled = True
        Me.cmbProv.Location = New System.Drawing.Point(714, 119)
        Me.cmbProv.Name = "cmbProv"
        Me.cmbProv.Size = New System.Drawing.Size(185, 25)
        Me.cmbProv.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label12.Location = New System.Drawing.Point(609, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 19)
        Me.Label12.TabIndex = 164
        Me.Label12.Text = "PROVINCIA:"
        '
        'frmListaPadron
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1130, 417)
        Me.Controls.Add(Me.cmbProv)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAFecha)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbDpto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbLocal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NUDmm)
        Me.Controls.Add(Me.NUDyyyy)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.cmbOrden)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaPadron"
        Me.Text = "LISTADO PADRÓN DE MATRICULADOS"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDyyyy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDmm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents cmbOrden As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NUDyyyy As NumericUpDown
    Friend WithEvents NUDmm As NumericUpDown
    Friend WithEvents cmbLocal As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbDpto As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAFecha As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbProv As ComboBox
    Friend WithEvents Label12 As Label
End Class

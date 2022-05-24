<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrintLista
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
        Dim TribunalLisLabel As System.Windows.Forms.Label
        Dim YyyyLisLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintLista))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.cmbTribunal = New System.Windows.Forms.ComboBox()
        Me.cmbAaaa = New System.Windows.Forms.ComboBox()
        Me.rdbDistrito = New System.Windows.Forms.RadioButton()
        Me.rdbCircuito = New System.Windows.Forms.RadioButton()
        Me.rdbTasaciones = New System.Windows.Forms.RadioButton()
        Me.rdbConcursales = New System.Windows.Forms.RadioButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        TribunalLisLabel = New System.Windows.Forms.Label()
        YyyyLisLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TribunalLisLabel
        '
        TribunalLisLabel.AutoSize = True
        TribunalLisLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TribunalLisLabel.ForeColor = System.Drawing.Color.White
        TribunalLisLabel.Location = New System.Drawing.Point(156, 81)
        TribunalLisLabel.Name = "TribunalLisLabel"
        TribunalLisLabel.Size = New System.Drawing.Size(61, 17)
        TribunalLisLabel.TabIndex = 160
        TribunalLisLabel.Text = "Tribunal:"
        '
        'YyyyLisLabel
        '
        YyyyLisLabel.AutoSize = True
        YyyyLisLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        YyyyLisLabel.ForeColor = System.Drawing.Color.White
        YyyyLisLabel.Location = New System.Drawing.Point(26, 81)
        YyyyLisLabel.Name = "YyyyLisLabel"
        YyyyLisLabel.Size = New System.Drawing.Size(38, 17)
        YyyyLisLabel.TabIndex = 159
        YyyyLisLabel.Text = "Año:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(137, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(706, 36)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Impresión de Listas de Nombramientos de Oficio"
        '
        'btnProcesar
        '
        Me.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcesar.FlatAppearance.BorderSize = 0
        Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcesar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.ForeColor = System.Drawing.Color.White
        Me.btnProcesar.Image = CType(resources.GetObject("btnProcesar.Image"), System.Drawing.Image)
        Me.btnProcesar.Location = New System.Drawing.Point(946, 66)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(71, 55)
        Me.btnProcesar.TabIndex = 161
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.AutoSize = True
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(946, 295)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(71, 56)
        Me.BtnSalir.TabIndex = 158
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'cmbTribunal
        '
        Me.cmbTribunal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbTribunal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTribunal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTribunal.ForeColor = System.Drawing.Color.White
        Me.cmbTribunal.FormattingEnabled = True
        Me.cmbTribunal.ItemHeight = 17
        Me.cmbTribunal.Location = New System.Drawing.Point(223, 77)
        Me.cmbTribunal.Name = "cmbTribunal"
        Me.cmbTribunal.Size = New System.Drawing.Size(198, 25)
        Me.cmbTribunal.TabIndex = 152
        '
        'cmbAaaa
        '
        Me.cmbAaaa.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbAaaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAaaa.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAaaa.ForeColor = System.Drawing.Color.White
        Me.cmbAaaa.FormattingEnabled = True
        Me.cmbAaaa.ItemHeight = 17
        Me.cmbAaaa.Location = New System.Drawing.Point(70, 77)
        Me.cmbAaaa.Name = "cmbAaaa"
        Me.cmbAaaa.Size = New System.Drawing.Size(76, 25)
        Me.cmbAaaa.TabIndex = 162
        '
        'rdbDistrito
        '
        Me.rdbDistrito.AutoSize = True
        Me.rdbDistrito.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDistrito.ForeColor = System.Drawing.Color.DarkOrange
        Me.rdbDistrito.Location = New System.Drawing.Point(445, 80)
        Me.rdbDistrito.Name = "rdbDistrito"
        Me.rdbDistrito.Size = New System.Drawing.Size(70, 21)
        Me.rdbDistrito.TabIndex = 164
        Me.rdbDistrito.TabStop = True
        Me.rdbDistrito.Text = "Distrito"
        Me.rdbDistrito.UseVisualStyleBackColor = True
        '
        'rdbCircuito
        '
        Me.rdbCircuito.AutoSize = True
        Me.rdbCircuito.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCircuito.ForeColor = System.Drawing.Color.DarkOrange
        Me.rdbCircuito.Location = New System.Drawing.Point(540, 80)
        Me.rdbCircuito.Name = "rdbCircuito"
        Me.rdbCircuito.Size = New System.Drawing.Size(77, 21)
        Me.rdbCircuito.TabIndex = 165
        Me.rdbCircuito.TabStop = True
        Me.rdbCircuito.Text = "Circuito"
        Me.rdbCircuito.UseVisualStyleBackColor = True
        '
        'rdbTasaciones
        '
        Me.rdbTasaciones.AutoSize = True
        Me.rdbTasaciones.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTasaciones.ForeColor = System.Drawing.Color.DarkOrange
        Me.rdbTasaciones.Location = New System.Drawing.Point(642, 80)
        Me.rdbTasaciones.Name = "rdbTasaciones"
        Me.rdbTasaciones.Size = New System.Drawing.Size(95, 21)
        Me.rdbTasaciones.TabIndex = 166
        Me.rdbTasaciones.TabStop = True
        Me.rdbTasaciones.Text = "Tasaciones"
        Me.rdbTasaciones.UseVisualStyleBackColor = True
        '
        'rdbConcursales
        '
        Me.rdbConcursales.AutoSize = True
        Me.rdbConcursales.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbConcursales.ForeColor = System.Drawing.Color.DarkOrange
        Me.rdbConcursales.Location = New System.Drawing.Point(762, 80)
        Me.rdbConcursales.Name = "rdbConcursales"
        Me.rdbConcursales.Size = New System.Drawing.Size(104, 21)
        Me.rdbConcursales.TabIndex = 167
        Me.rdbConcursales.TabStop = True
        Me.rdbConcursales.Text = "Concursales"
        Me.rdbConcursales.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(15, 56)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1021, 72)
        Me.PictureBox4.TabIndex = 169
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(935, 134)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 413)
        Me.PictureBox1.TabIndex = 170
        Me.PictureBox1.TabStop = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ColMart.rptListaOficio.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(15, 135)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(914, 412)
        Me.ReportViewer1.TabIndex = 171
        '
        'frmPrintLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1075, 584)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.rdbConcursales)
        Me.Controls.Add(Me.rdbTasaciones)
        Me.Controls.Add(Me.rdbCircuito)
        Me.Controls.Add(Me.rdbDistrito)
        Me.Controls.Add(Me.cmbAaaa)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.cmbTribunal)
        Me.Controls.Add(TribunalLisLabel)
        Me.Controls.Add(YyyyLisLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrintLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMPRIMIR LISTAS DE NOMBRAMIENTOS DE OFICIO"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btnProcesar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents cmbTribunal As ComboBox
    Friend WithEvents cmbAaaa As ComboBox
    Friend WithEvents rdbDistrito As RadioButton
    Friend WithEvents rdbCircuito As RadioButton
    Friend WithEvents rdbTasaciones As RadioButton
    Friend WithEvents rdbConcursales As RadioButton
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class

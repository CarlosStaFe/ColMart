<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReciboB1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciboB1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.reciboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMatSoc = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtApagar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTarjeta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTransferencia = New System.Windows.Forms.TextBox()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDiferencia = New System.Windows.Forms.TextBox()
        Me.rdbNotaCredito = New System.Windows.Forms.RadioButton()
        Me.dgvCtasCtes = New System.Windows.Forms.DataGridView()
        Me.IdCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCbteCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCbteCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebeCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaberCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marcapago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.forma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtasctesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CtasctesTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.ctasctesTableAdapter()
        Me.reciboTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.reciboTableAdapter()
        CType(Me.reciboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCtasCtes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtasctesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reciboBindingSource
        '
        Me.reciboBindingSource.DataMember = "recibo"
        Me.reciboBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(178, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(524, 36)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Comprobante de Cobro de Boletas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 17)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Matrícula/Sociedad:"
        '
        'txtMatSoc
        '
        Me.txtMatSoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMatSoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMatSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatSoc.ForeColor = System.Drawing.Color.White
        Me.txtMatSoc.Location = New System.Drawing.Point(171, 69)
        Me.txtMatSoc.Name = "txtMatSoc"
        Me.txtMatSoc.Size = New System.Drawing.Size(57, 23)
        Me.txtMatSoc.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(231, 69)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(392, 23)
        Me.txtNombre.TabIndex = 1
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.ForeColor = System.Drawing.Color.White
        Me.txtObs.Location = New System.Drawing.Point(26, 518)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(578, 50)
        Me.txtObs.TabIndex = 6
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(838, 502)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 57)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label5.Location = New System.Drawing.Point(590, 456)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "SALDO ACTUAL:"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.Black
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtSaldo.Location = New System.Drawing.Point(702, 450)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(107, 27)
        Me.txtSaldo.TabIndex = 10
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtApagar
        '
        Me.txtApagar.BackColor = System.Drawing.Color.Black
        Me.txtApagar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApagar.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtApagar.Location = New System.Drawing.Point(702, 478)
        Me.txtApagar.Name = "txtApagar"
        Me.txtApagar.Size = New System.Drawing.Size(107, 27)
        Me.txtApagar.TabIndex = 11
        Me.txtApagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label6.Location = New System.Drawing.Point(569, 484)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 17)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "IMPORTE A PAGAR:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(26, 498)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 17)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "OBSERVACIONES DEL RECIBO"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(838, 320)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(71, 57)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(827, 109)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(91, 471)
        Me.PictureBox4.TabIndex = 145
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(9, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(812, 51)
        Me.PictureBox1.TabIndex = 146
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(9, 445)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(812, 135)
        Me.PictureBox2.TabIndex = 147
        Me.PictureBox2.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(838, 133)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(71, 57)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtFecha.Location = New System.Drawing.Point(647, 69)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 23)
        Me.txtFecha.TabIndex = 149
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(351, 461)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "TARJETA:"
        '
        'txtTarjeta
        '
        Me.txtTarjeta.BackColor = System.Drawing.Color.Black
        Me.txtTarjeta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarjeta.ForeColor = System.Drawing.Color.Lime
        Me.txtTarjeta.Location = New System.Drawing.Point(418, 458)
        Me.txtTarjeta.Name = "txtTarjeta"
        Me.txtTarjeta.Size = New System.Drawing.Size(83, 23)
        Me.txtTarjeta.TabIndex = 5
        Me.txtTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Lime
        Me.Label8.Location = New System.Drawing.Point(203, 461)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 190
        Me.Label8.Text = "TRANSF.:"
        '
        'txtTransferencia
        '
        Me.txtTransferencia.BackColor = System.Drawing.Color.Black
        Me.txtTransferencia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferencia.ForeColor = System.Drawing.Color.Lime
        Me.txtTransferencia.Location = New System.Drawing.Point(262, 458)
        Me.txtTransferencia.Name = "txtTransferencia"
        Me.txtTransferencia.Size = New System.Drawing.Size(83, 23)
        Me.txtTransferencia.TabIndex = 4
        Me.txtTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEfectivo
        '
        Me.txtEfectivo.BackColor = System.Drawing.Color.Black
        Me.txtEfectivo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectivo.ForeColor = System.Drawing.Color.Lime
        Me.txtEfectivo.Location = New System.Drawing.Point(105, 458)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(83, 23)
        Me.txtEfectivo.TabIndex = 3
        Me.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Lime
        Me.Label9.Location = New System.Drawing.Point(28, 461)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 17)
        Me.Label9.TabIndex = 189
        Me.Label9.Text = "EFECTIVO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label7.Location = New System.Drawing.Point(610, 512)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 17)
        Me.Label7.TabIndex = 193
        Me.Label7.Text = "DIFERENCIA:"
        '
        'txtDiferencia
        '
        Me.txtDiferencia.BackColor = System.Drawing.Color.Black
        Me.txtDiferencia.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferencia.ForeColor = System.Drawing.Color.Red
        Me.txtDiferencia.Location = New System.Drawing.Point(702, 506)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.Size = New System.Drawing.Size(107, 27)
        Me.txtDiferencia.TabIndex = 12
        Me.txtDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rdbNotaCredito
        '
        Me.rdbNotaCredito.AutoSize = True
        Me.rdbNotaCredito.Enabled = False
        Me.rdbNotaCredito.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNotaCredito.ForeColor = System.Drawing.Color.Red
        Me.rdbNotaCredito.Location = New System.Drawing.Point(831, 67)
        Me.rdbNotaCredito.Name = "rdbNotaCredito"
        Me.rdbNotaCredito.Size = New System.Drawing.Size(178, 26)
        Me.rdbNotaCredito.TabIndex = 194
        Me.rdbNotaCredito.TabStop = True
        Me.rdbNotaCredito.Text = "NOTA DE CRÉDITO"
        Me.rdbNotaCredito.UseVisualStyleBackColor = True
        '
        'dgvCtasCtes
        '
        Me.dgvCtasCtes.AllowUserToAddRows = False
        Me.dgvCtasCtes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCtasCtes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCtasCtes.AutoGenerateColumns = False
        Me.dgvCtasCtes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvCtasCtes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtasCtes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCtasCtes.ColumnHeadersHeight = 30
        Me.dgvCtasCtes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCtasCtes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCCDataGridViewTextBoxColumn, Me.NroCCDataGridViewTextBoxColumn, Me.FechaCCDataGridViewTextBoxColumn, Me.TipoCbteCCDataGridViewTextBoxColumn, Me.NroCbteCCDataGridViewTextBoxColumn, Me.ItemCCDataGridViewTextBoxColumn, Me.DetalleCCDataGridViewTextBoxColumn, Me.PeriodoCCDataGridViewTextBoxColumn, Me.DebeCCDataGridViewTextBoxColumn, Me.HaberCCDataGridViewTextBoxColumn, Me.SaldoCCDataGridViewTextBoxColumn, Me.EstadoCCDataGridViewTextBoxColumn, Me.PagadoCCDataGridViewTextBoxColumn, Me.RestoCCDataGridViewTextBoxColumn, Me.ObsCCDataGridViewTextBoxColumn, Me.marcapago, Me.saldo, Me.pago, Me.forma})
        Me.dgvCtasCtes.DataSource = Me.CtasctesBindingSource
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCtasCtes.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCtasCtes.EnableHeadersVisualStyles = False
        Me.dgvCtasCtes.GridColor = System.Drawing.Color.White
        Me.dgvCtasCtes.Location = New System.Drawing.Point(9, 111)
        Me.dgvCtasCtes.Name = "dgvCtasCtes"
        Me.dgvCtasCtes.ReadOnly = True
        Me.dgvCtasCtes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtasCtes.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvCtasCtes.Size = New System.Drawing.Size(812, 328)
        Me.dgvCtasCtes.TabIndex = 196
        '
        'IdCCDataGridViewTextBoxColumn
        '
        Me.IdCCDataGridViewTextBoxColumn.DataPropertyName = "id_CC"
        Me.IdCCDataGridViewTextBoxColumn.HeaderText = "id_CC"
        Me.IdCCDataGridViewTextBoxColumn.Name = "IdCCDataGridViewTextBoxColumn"
        Me.IdCCDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCCDataGridViewTextBoxColumn.Visible = False
        '
        'NroCCDataGridViewTextBoxColumn
        '
        Me.NroCCDataGridViewTextBoxColumn.DataPropertyName = "NroCC"
        Me.NroCCDataGridViewTextBoxColumn.HeaderText = "NroCC"
        Me.NroCCDataGridViewTextBoxColumn.Name = "NroCCDataGridViewTextBoxColumn"
        Me.NroCCDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroCCDataGridViewTextBoxColumn.Visible = False
        '
        'FechaCCDataGridViewTextBoxColumn
        '
        Me.FechaCCDataGridViewTextBoxColumn.DataPropertyName = "FechaCC"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaCCDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FechaCCDataGridViewTextBoxColumn.Name = "FechaCCDataGridViewTextBoxColumn"
        Me.FechaCCDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaCCDataGridViewTextBoxColumn.Width = 80
        '
        'TipoCbteCCDataGridViewTextBoxColumn
        '
        Me.TipoCbteCCDataGridViewTextBoxColumn.DataPropertyName = "TipoCbteCC"
        Me.TipoCbteCCDataGridViewTextBoxColumn.HeaderText = "TIPO"
        Me.TipoCbteCCDataGridViewTextBoxColumn.Name = "TipoCbteCCDataGridViewTextBoxColumn"
        Me.TipoCbteCCDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCbteCCDataGridViewTextBoxColumn.Width = 40
        '
        'NroCbteCCDataGridViewTextBoxColumn
        '
        Me.NroCbteCCDataGridViewTextBoxColumn.DataPropertyName = "NroCbteCC"
        Me.NroCbteCCDataGridViewTextBoxColumn.HeaderText = "NroCbteCC"
        Me.NroCbteCCDataGridViewTextBoxColumn.Name = "NroCbteCCDataGridViewTextBoxColumn"
        Me.NroCbteCCDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroCbteCCDataGridViewTextBoxColumn.Visible = False
        '
        'ItemCCDataGridViewTextBoxColumn
        '
        Me.ItemCCDataGridViewTextBoxColumn.DataPropertyName = "ItemCC"
        Me.ItemCCDataGridViewTextBoxColumn.HeaderText = "ItemCC"
        Me.ItemCCDataGridViewTextBoxColumn.Name = "ItemCCDataGridViewTextBoxColumn"
        Me.ItemCCDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemCCDataGridViewTextBoxColumn.Visible = False
        '
        'DetalleCCDataGridViewTextBoxColumn
        '
        Me.DetalleCCDataGridViewTextBoxColumn.DataPropertyName = "DetalleCC"
        Me.DetalleCCDataGridViewTextBoxColumn.HeaderText = "DETALLE"
        Me.DetalleCCDataGridViewTextBoxColumn.Name = "DetalleCCDataGridViewTextBoxColumn"
        Me.DetalleCCDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleCCDataGridViewTextBoxColumn.Width = 220
        '
        'PeriodoCCDataGridViewTextBoxColumn
        '
        Me.PeriodoCCDataGridViewTextBoxColumn.DataPropertyName = "PeriodoCC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PeriodoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PeriodoCCDataGridViewTextBoxColumn.HeaderText = "PERIODO"
        Me.PeriodoCCDataGridViewTextBoxColumn.Name = "PeriodoCCDataGridViewTextBoxColumn"
        Me.PeriodoCCDataGridViewTextBoxColumn.ReadOnly = True
        Me.PeriodoCCDataGridViewTextBoxColumn.Width = 80
        '
        'DebeCCDataGridViewTextBoxColumn
        '
        Me.DebeCCDataGridViewTextBoxColumn.DataPropertyName = "DebeCC"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DebeCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.DebeCCDataGridViewTextBoxColumn.HeaderText = "DEBE"
        Me.DebeCCDataGridViewTextBoxColumn.Name = "DebeCCDataGridViewTextBoxColumn"
        Me.DebeCCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HaberCCDataGridViewTextBoxColumn
        '
        Me.HaberCCDataGridViewTextBoxColumn.DataPropertyName = "HaberCC"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.HaberCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.HaberCCDataGridViewTextBoxColumn.HeaderText = "HABER"
        Me.HaberCCDataGridViewTextBoxColumn.Name = "HaberCCDataGridViewTextBoxColumn"
        Me.HaberCCDataGridViewTextBoxColumn.ReadOnly = True
        Me.HaberCCDataGridViewTextBoxColumn.Visible = False
        '
        'SaldoCCDataGridViewTextBoxColumn
        '
        Me.SaldoCCDataGridViewTextBoxColumn.DataPropertyName = "SaldoCC"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.SaldoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.SaldoCCDataGridViewTextBoxColumn.HeaderText = "SALDO"
        Me.SaldoCCDataGridViewTextBoxColumn.Name = "SaldoCCDataGridViewTextBoxColumn"
        Me.SaldoCCDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoCCDataGridViewTextBoxColumn.Visible = False
        '
        'EstadoCCDataGridViewTextBoxColumn
        '
        Me.EstadoCCDataGridViewTextBoxColumn.DataPropertyName = "EstadoCC"
        Me.EstadoCCDataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.EstadoCCDataGridViewTextBoxColumn.Name = "EstadoCCDataGridViewTextBoxColumn"
        Me.EstadoCCDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoCCDataGridViewTextBoxColumn.Visible = False
        Me.EstadoCCDataGridViewTextBoxColumn.Width = 90
        '
        'PagadoCCDataGridViewTextBoxColumn
        '
        Me.PagadoCCDataGridViewTextBoxColumn.DataPropertyName = "PagadoCC"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.PagadoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.PagadoCCDataGridViewTextBoxColumn.HeaderText = "PAGADO"
        Me.PagadoCCDataGridViewTextBoxColumn.Name = "PagadoCCDataGridViewTextBoxColumn"
        Me.PagadoCCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RestoCCDataGridViewTextBoxColumn
        '
        Me.RestoCCDataGridViewTextBoxColumn.DataPropertyName = "RestoCC"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.RestoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.RestoCCDataGridViewTextBoxColumn.HeaderText = "RESTO"
        Me.RestoCCDataGridViewTextBoxColumn.Name = "RestoCCDataGridViewTextBoxColumn"
        Me.RestoCCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObsCCDataGridViewTextBoxColumn
        '
        Me.ObsCCDataGridViewTextBoxColumn.DataPropertyName = "ObsCC"
        Me.ObsCCDataGridViewTextBoxColumn.HeaderText = "ObsCC"
        Me.ObsCCDataGridViewTextBoxColumn.Name = "ObsCCDataGridViewTextBoxColumn"
        Me.ObsCCDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsCCDataGridViewTextBoxColumn.Visible = False
        '
        'marcapago
        '
        Me.marcapago.HeaderText = "X"
        Me.marcapago.Name = "marcapago"
        Me.marcapago.ReadOnly = True
        Me.marcapago.Width = 20
        '
        'saldo
        '
        Me.saldo.HeaderText = "saldo"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Visible = False
        '
        'pago
        '
        Me.pago.HeaderText = "pago"
        Me.pago.Name = "pago"
        Me.pago.ReadOnly = True
        Me.pago.Visible = False
        '
        'forma
        '
        Me.forma.HeaderText = "forma"
        Me.forma.Name = "forma"
        Me.forma.ReadOnly = True
        Me.forma.Visible = False
        '
        'CtasctesBindingSource
        '
        Me.CtasctesBindingSource.DataMember = "ctasctes"
        Me.CtasctesBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.DocumentMapWidth = 83
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ColMart.rptRecCobroDeudas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(924, 109)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(85, 397)
        Me.ReportViewer1.TabIndex = 197
        Me.ReportViewer1.Visible = False
        '
        'CtasctesTableAdapter
        '
        Me.CtasctesTableAdapter.ClearBeforeFill = True
        '
        'reciboTableAdapter
        '
        Me.reciboTableAdapter.ClearBeforeFill = True
        '
        'frmReciboB1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1430, 595)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.dgvCtasCtes)
        Me.Controls.Add(Me.rdbNotaCredito)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDiferencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTarjeta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTransferencia)
        Me.Controls.Add(Me.txtEfectivo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtApagar)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtMatSoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReciboB1"
        Me.Text = "COMPROBANTE INTERNO DE PAGOS"
        CType(Me.reciboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCtasCtes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtasctesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMatSoc As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtObs As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtApagar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTarjeta As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTransferencia As TextBox
    Friend WithEvents txtEfectivo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDiferencia As TextBox
    Friend WithEvents rdbNotaCredito As RadioButton
    Friend WithEvents CtasctesTableAdapter As dbcolmartDataSetTableAdapters.ctasctesTableAdapter
    Friend WithEvents CtasctesBindingSource As BindingSource
    Friend WithEvents dgvCtasCtes As DataGridView
    Friend WithEvents IdCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCbteCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroCbteCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeriodoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DebeCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HaberCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagadoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents marcapago As DataGridViewTextBoxColumn
    Friend WithEvents saldo As DataGridViewTextBoxColumn
    Friend WithEvents pago As DataGridViewTextBoxColumn
    Friend WithEvents forma As DataGridViewTextBoxColumn
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents reciboBindingSource As BindingSource
    Friend WithEvents reciboTableAdapter As dbcolmartDataSetTableAdapters.reciboTableAdapter
End Class

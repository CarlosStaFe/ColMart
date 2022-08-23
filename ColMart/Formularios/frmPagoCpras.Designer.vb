<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPagoCpras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagoCpras))
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.reciboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDiferencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTarjeta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTransferencia = New System.Windows.Forms.TextBox()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CtacteproBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApagar = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.CtacteproTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.ctacteproTableAdapter()
        Me.dgvCtasCtes = New System.Windows.Forms.DataGridView()
        Me.IdCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCpraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCbteCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrefijoCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubfijoCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebeCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaberCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCCPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoCCPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestoCCPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.reciboTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.reciboTableAdapter()
        CType(Me.reciboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtacteproBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCtasCtes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label7.Location = New System.Drawing.Point(605, 435)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 17)
        Me.Label7.TabIndex = 246
        Me.Label7.Text = "DIFERENCIA:"
        '
        'txtDiferencia
        '
        Me.txtDiferencia.BackColor = System.Drawing.Color.Black
        Me.txtDiferencia.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferencia.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtDiferencia.Location = New System.Drawing.Point(697, 429)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.Size = New System.Drawing.Size(107, 27)
        Me.txtDiferencia.TabIndex = 233
        Me.txtDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(374, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 245
        Me.Label2.Text = "TARJETA:"
        '
        'txtTarjeta
        '
        Me.txtTarjeta.BackColor = System.Drawing.Color.Black
        Me.txtTarjeta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarjeta.ForeColor = System.Drawing.Color.Lime
        Me.txtTarjeta.Location = New System.Drawing.Point(441, 381)
        Me.txtTarjeta.Name = "txtTarjeta"
        Me.txtTarjeta.Size = New System.Drawing.Size(83, 23)
        Me.txtTarjeta.TabIndex = 226
        Me.txtTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Lime
        Me.Label8.Location = New System.Drawing.Point(226, 384)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 244
        Me.Label8.Text = "TRANSF.:"
        '
        'txtTransferencia
        '
        Me.txtTransferencia.BackColor = System.Drawing.Color.Black
        Me.txtTransferencia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferencia.ForeColor = System.Drawing.Color.Lime
        Me.txtTransferencia.Location = New System.Drawing.Point(285, 381)
        Me.txtTransferencia.Name = "txtTransferencia"
        Me.txtTransferencia.Size = New System.Drawing.Size(83, 23)
        Me.txtTransferencia.TabIndex = 225
        Me.txtTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEfectivo
        '
        Me.txtEfectivo.BackColor = System.Drawing.Color.Black
        Me.txtEfectivo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectivo.ForeColor = System.Drawing.Color.Lime
        Me.txtEfectivo.Location = New System.Drawing.Point(128, 381)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(83, 23)
        Me.txtEfectivo.TabIndex = 224
        Me.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Lime
        Me.Label9.Location = New System.Drawing.Point(51, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 17)
        Me.Label9.TabIndex = 243
        Me.Label9.Text = "EFECTIVO:"
        '
        'CtacteproBindingSource
        '
        Me.CtacteproBindingSource.DataMember = "ctactepro"
        Me.CtacteproBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtFecha.Location = New System.Drawing.Point(670, 66)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 23)
        Me.txtFecha.TabIndex = 242
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnImprimir.Location = New System.Drawing.Point(422, 515)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(71, 57)
        Me.btnImprimir.TabIndex = 228
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
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
        Me.btnLimpiar.Location = New System.Drawing.Point(103, 515)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(71, 57)
        Me.btnLimpiar.TabIndex = 229
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(49, 421)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 17)
        Me.Label4.TabIndex = 238
        Me.Label4.Text = "OBSERVACIONES DEL RECIBO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label6.Location = New System.Drawing.Point(564, 407)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 17)
        Me.Label6.TabIndex = 237
        Me.Label6.Text = "IMPORTE A PAGAR:"
        '
        'txtApagar
        '
        Me.txtApagar.BackColor = System.Drawing.Color.Black
        Me.txtApagar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApagar.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtApagar.Location = New System.Drawing.Point(697, 401)
        Me.txtApagar.Name = "txtApagar"
        Me.txtApagar.Size = New System.Drawing.Size(107, 27)
        Me.txtApagar.TabIndex = 232
        Me.txtApagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.Black
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtSaldo.Location = New System.Drawing.Point(697, 373)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(107, 27)
        Me.txtSaldo.TabIndex = 231
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label5.Location = New System.Drawing.Point(585, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 236
        Me.Label5.Text = "SALDO ACTUAL:"
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
        Me.btnSalir.Location = New System.Drawing.Point(793, 515)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 57)
        Me.btnSalir.TabIndex = 230
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.ForeColor = System.Drawing.Color.White
        Me.txtObs.Location = New System.Drawing.Point(49, 441)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(526, 50)
        Me.txtObs.TabIndex = 227
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(254, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(392, 23)
        Me.txtNombre.TabIndex = 222
        '
        'txtProveedor
        '
        Me.txtProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProveedor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.ForeColor = System.Drawing.Color.White
        Me.txtProveedor.Location = New System.Drawing.Point(194, 66)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(57, 23)
        Me.txtProveedor.TabIndex = 221
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(109, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 235
        Me.Label1.Text = "Proveedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(307, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(305, 36)
        Me.Label3.TabIndex = 234
        Me.Label3.Text = "Pago a Proveedores"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(32, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(879, 51)
        Me.PictureBox1.TabIndex = 240
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(32, 368)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(879, 135)
        Me.PictureBox2.TabIndex = 241
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(32, 509)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(879, 69)
        Me.PictureBox4.TabIndex = 239
        Me.PictureBox4.TabStop = False
        '
        'CtacteproTableAdapter
        '
        Me.CtacteproTableAdapter.ClearBeforeFill = True
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
        Me.dgvCtasCtes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCCProDataGridViewTextBoxColumn, Me.IdCpraDataGridViewTextBoxColumn, Me.NroCCProDataGridViewTextBoxColumn, Me.FechaCCProDataGridViewTextBoxColumn, Me.TipoCbteCCProDataGridViewTextBoxColumn, Me.PrefijoCCProDataGridViewTextBoxColumn, Me.SubfijoCCProDataGridViewTextBoxColumn, Me.DetalleCCProDataGridViewTextBoxColumn, Me.DebeCCProDataGridViewTextBoxColumn, Me.HaberCCProDataGridViewTextBoxColumn, Me.SaldoCCProDataGridViewTextBoxColumn, Me.EstadoCCPro, Me.ObsCCProDataGridViewTextBoxColumn, Me.PagadoCCPro, Me.RestoCCPro, Me.X})
        Me.dgvCtasCtes.DataSource = Me.CtacteproBindingSource
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
        Me.dgvCtasCtes.Location = New System.Drawing.Point(32, 109)
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
        Me.dgvCtasCtes.Size = New System.Drawing.Size(879, 256)
        Me.dgvCtasCtes.TabIndex = 247
        '
        'IdCCProDataGridViewTextBoxColumn
        '
        Me.IdCCProDataGridViewTextBoxColumn.DataPropertyName = "id_CCPro"
        Me.IdCCProDataGridViewTextBoxColumn.HeaderText = "id_CCPro"
        Me.IdCCProDataGridViewTextBoxColumn.Name = "IdCCProDataGridViewTextBoxColumn"
        Me.IdCCProDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCCProDataGridViewTextBoxColumn.Visible = False
        '
        'IdCpraDataGridViewTextBoxColumn
        '
        Me.IdCpraDataGridViewTextBoxColumn.DataPropertyName = "idCpra"
        Me.IdCpraDataGridViewTextBoxColumn.HeaderText = "idCpra"
        Me.IdCpraDataGridViewTextBoxColumn.Name = "IdCpraDataGridViewTextBoxColumn"
        Me.IdCpraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCpraDataGridViewTextBoxColumn.Visible = False
        '
        'NroCCProDataGridViewTextBoxColumn
        '
        Me.NroCCProDataGridViewTextBoxColumn.DataPropertyName = "NroCCPro"
        Me.NroCCProDataGridViewTextBoxColumn.HeaderText = "NroCCPro"
        Me.NroCCProDataGridViewTextBoxColumn.Name = "NroCCProDataGridViewTextBoxColumn"
        Me.NroCCProDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroCCProDataGridViewTextBoxColumn.Visible = False
        '
        'FechaCCProDataGridViewTextBoxColumn
        '
        Me.FechaCCProDataGridViewTextBoxColumn.DataPropertyName = "FechaCCPro"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaCCProDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaCCProDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FechaCCProDataGridViewTextBoxColumn.Name = "FechaCCProDataGridViewTextBoxColumn"
        Me.FechaCCProDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaCCProDataGridViewTextBoxColumn.Width = 80
        '
        'TipoCbteCCProDataGridViewTextBoxColumn
        '
        Me.TipoCbteCCProDataGridViewTextBoxColumn.DataPropertyName = "TipoCbteCCPro"
        Me.TipoCbteCCProDataGridViewTextBoxColumn.HeaderText = "TIPO"
        Me.TipoCbteCCProDataGridViewTextBoxColumn.Name = "TipoCbteCCProDataGridViewTextBoxColumn"
        Me.TipoCbteCCProDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCbteCCProDataGridViewTextBoxColumn.Width = 40
        '
        'PrefijoCCProDataGridViewTextBoxColumn
        '
        Me.PrefijoCCProDataGridViewTextBoxColumn.DataPropertyName = "PrefijoCCPro"
        Me.PrefijoCCProDataGridViewTextBoxColumn.HeaderText = "PREF."
        Me.PrefijoCCProDataGridViewTextBoxColumn.Name = "PrefijoCCProDataGridViewTextBoxColumn"
        Me.PrefijoCCProDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrefijoCCProDataGridViewTextBoxColumn.Width = 50
        '
        'SubfijoCCProDataGridViewTextBoxColumn
        '
        Me.SubfijoCCProDataGridViewTextBoxColumn.DataPropertyName = "SubfijoCCPro"
        Me.SubfijoCCProDataGridViewTextBoxColumn.HeaderText = "SUBFIJO"
        Me.SubfijoCCProDataGridViewTextBoxColumn.Name = "SubfijoCCProDataGridViewTextBoxColumn"
        Me.SubfijoCCProDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubfijoCCProDataGridViewTextBoxColumn.Width = 80
        '
        'DetalleCCProDataGridViewTextBoxColumn
        '
        Me.DetalleCCProDataGridViewTextBoxColumn.DataPropertyName = "DetalleCCPro"
        Me.DetalleCCProDataGridViewTextBoxColumn.HeaderText = "DetalleCCPro"
        Me.DetalleCCProDataGridViewTextBoxColumn.Name = "DetalleCCProDataGridViewTextBoxColumn"
        Me.DetalleCCProDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleCCProDataGridViewTextBoxColumn.Visible = False
        '
        'DebeCCProDataGridViewTextBoxColumn
        '
        Me.DebeCCProDataGridViewTextBoxColumn.DataPropertyName = "DebeCCPro"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DebeCCProDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.DebeCCProDataGridViewTextBoxColumn.HeaderText = "DEBE"
        Me.DebeCCProDataGridViewTextBoxColumn.Name = "DebeCCProDataGridViewTextBoxColumn"
        Me.DebeCCProDataGridViewTextBoxColumn.ReadOnly = True
        Me.DebeCCProDataGridViewTextBoxColumn.Width = 110
        '
        'HaberCCProDataGridViewTextBoxColumn
        '
        Me.HaberCCProDataGridViewTextBoxColumn.DataPropertyName = "HaberCCPro"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.HaberCCProDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.HaberCCProDataGridViewTextBoxColumn.HeaderText = "HABER"
        Me.HaberCCProDataGridViewTextBoxColumn.Name = "HaberCCProDataGridViewTextBoxColumn"
        Me.HaberCCProDataGridViewTextBoxColumn.ReadOnly = True
        Me.HaberCCProDataGridViewTextBoxColumn.Width = 110
        '
        'SaldoCCProDataGridViewTextBoxColumn
        '
        Me.SaldoCCProDataGridViewTextBoxColumn.DataPropertyName = "SaldoCCPro"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.SaldoCCProDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.SaldoCCProDataGridViewTextBoxColumn.HeaderText = "SALDO"
        Me.SaldoCCProDataGridViewTextBoxColumn.Name = "SaldoCCProDataGridViewTextBoxColumn"
        Me.SaldoCCProDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoCCProDataGridViewTextBoxColumn.Visible = False
        Me.SaldoCCProDataGridViewTextBoxColumn.Width = 110
        '
        'EstadoCCPro
        '
        Me.EstadoCCPro.DataPropertyName = "EstadoCCPro"
        Me.EstadoCCPro.HeaderText = "ESTADO"
        Me.EstadoCCPro.Name = "EstadoCCPro"
        Me.EstadoCCPro.ReadOnly = True
        '
        'ObsCCProDataGridViewTextBoxColumn
        '
        Me.ObsCCProDataGridViewTextBoxColumn.DataPropertyName = "ObsCCPro"
        Me.ObsCCProDataGridViewTextBoxColumn.HeaderText = "OBS."
        Me.ObsCCProDataGridViewTextBoxColumn.Name = "ObsCCProDataGridViewTextBoxColumn"
        Me.ObsCCProDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsCCProDataGridViewTextBoxColumn.Visible = False
        '
        'PagadoCCPro
        '
        Me.PagadoCCPro.DataPropertyName = "PagadoCCPro"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.PagadoCCPro.DefaultCellStyle = DataGridViewCellStyle7
        Me.PagadoCCPro.HeaderText = "PAGADO"
        Me.PagadoCCPro.Name = "PagadoCCPro"
        Me.PagadoCCPro.ReadOnly = True
        Me.PagadoCCPro.Width = 110
        '
        'RestoCCPro
        '
        Me.RestoCCPro.DataPropertyName = "RestoCCPro"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.RestoCCPro.DefaultCellStyle = DataGridViewCellStyle8
        Me.RestoCCPro.HeaderText = "RESTO"
        Me.RestoCCPro.Name = "RestoCCPro"
        Me.RestoCCPro.ReadOnly = True
        Me.RestoCCPro.Width = 110
        '
        'X
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.X.DefaultCellStyle = DataGridViewCellStyle9
        Me.X.HeaderText = "X"
        Me.X.Name = "X"
        Me.X.ReadOnly = True
        Me.X.Width = 30
        '
        'ReportViewer1
        '
        Me.ReportViewer1.DocumentMapWidth = 75
        ReportDataSource1.Name = "deReciboPago"
        ReportDataSource1.Value = Me.reciboBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ColMart.rptReciboPago.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(918, 52)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(77, 493)
        Me.ReportViewer1.TabIndex = 248
        Me.ReportViewer1.Visible = False
        '
        'reciboTableAdapter
        '
        Me.reciboTableAdapter.ClearBeforeFill = True
        '
        'frmPagoCpras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1046, 583)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.dgvCtasCtes)
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
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPagoCpras"
        Me.Text = "PAGOS A PROVEEDORES"
        CType(Me.reciboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtacteproBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCtasCtes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents txtDiferencia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTarjeta As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTransferencia As TextBox
    Friend WithEvents txtEfectivo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtApagar As TextBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtObs As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents CtacteproBindingSource As BindingSource
    Friend WithEvents CtacteproTableAdapter As dbcolmartDataSetTableAdapters.ctacteproTableAdapter
    Friend WithEvents dgvCtasCtes As DataGridView
    Friend WithEvents IdCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCpraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCbteCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrefijoCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubfijoCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DebeCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HaberCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCCPro As DataGridViewTextBoxColumn
    Friend WithEvents ObsCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagadoCCPro As DataGridViewTextBoxColumn
    Friend WithEvents RestoCCPro As DataGridViewTextBoxColumn
    Friend WithEvents X As DataGridViewTextBoxColumn
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents reciboBindingSource As BindingSource
    Friend WithEvents reciboTableAdapter As dbcolmartDataSetTableAdapters.reciboTableAdapter
End Class

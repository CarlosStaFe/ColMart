﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReciboPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciboPago))
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMatSoc = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.BoletasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.BoletasTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.boletasTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiferencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.CtasctesTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.ctasctesTableAdapter()
        CType(Me.BoletasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCtasCtes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtasctesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(192, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(472, 36)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Comprobante Interno de Pagos"
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
        'BoletasBindingSource
        '
        Me.BoletasBindingSource.DataMember = "boletas"
        Me.BoletasBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.ForeColor = System.Drawing.Color.White
        Me.txtObs.Location = New System.Drawing.Point(21, 402)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(504, 50)
        Me.txtObs.TabIndex = 2
        '
        'btnProcesar
        '
        Me.btnProcesar.FlatAppearance.BorderSize = 0
        Me.btnProcesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcesar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.ForeColor = System.Drawing.Color.White
        Me.btnProcesar.Image = CType(resources.GetObject("btnProcesar.Image"), System.Drawing.Image)
        Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProcesar.Location = New System.Drawing.Point(856, 257)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(71, 57)
        Me.btnProcesar.TabIndex = 5
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(856, 503)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 57)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'BoletasTableAdapter
        '
        Me.BoletasTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label5.Location = New System.Drawing.Point(562, 382)
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
        Me.txtSaldo.Location = New System.Drawing.Point(674, 376)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(107, 27)
        Me.txtSaldo.TabIndex = 102
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPago
        '
        Me.txtPago.BackColor = System.Drawing.Color.Black
        Me.txtPago.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtPago.Location = New System.Drawing.Point(674, 404)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(107, 27)
        Me.txtPago.TabIndex = 1
        Me.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label6.Location = New System.Drawing.Point(560, 410)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 17)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "IMPORTE PAGO:"
        '
        'txtDiferencia
        '
        Me.txtDiferencia.BackColor = System.Drawing.Color.Black
        Me.txtDiferencia.Enabled = False
        Me.txtDiferencia.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferencia.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtDiferencia.Location = New System.Drawing.Point(674, 432)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.Size = New System.Drawing.Size(107, 27)
        Me.txtDiferencia.TabIndex = 105
        Me.txtDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(564, 438)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "SALDO FUTURO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(21, 382)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 17)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "OBSERVACIONES DEL RECIBO"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ColMart.rptPrintRecibo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(9, 470)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(787, 126)
        Me.ReportViewer1.TabIndex = 108
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(856, 421)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(71, 57)
        Me.btnLimpiar.TabIndex = 109
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(810, 225)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(168, 372)
        Me.PictureBox4.TabIndex = 145
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(9, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(787, 51)
        Me.PictureBox1.TabIndex = 146
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(9, 371)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(787, 94)
        Me.PictureBox2.TabIndex = 147
        Me.PictureBox2.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(856, 339)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(71, 57)
        Me.btnImprimir.TabIndex = 148
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
        'cmbFormaPago
        '
        Me.cmbFormaPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFormaPago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormaPago.ForeColor = System.Drawing.Color.DarkOrange
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Items.AddRange(New Object() {"EFECTIVO", "TARJETA", "TRANSFERENCIA"})
        Me.cmbFormaPago.Location = New System.Drawing.Point(822, 171)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(143, 25)
        Me.cmbFormaPago.TabIndex = 150
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(810, 119)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(168, 100)
        Me.PictureBox3.TabIndex = 151
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label7.Location = New System.Drawing.Point(832, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 17)
        Me.Label7.TabIndex = 152
        Me.Label7.Text = "FORMA DE PAGO"
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
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
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
        Me.dgvCtasCtes.Location = New System.Drawing.Point(9, 110)
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
        Me.dgvCtasCtes.Size = New System.Drawing.Size(787, 259)
        Me.dgvCtasCtes.TabIndex = 153
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
        'CtasctesTableAdapter
        '
        Me.CtasctesTableAdapter.ClearBeforeFill = True
        '
        'frmReciboPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(999, 636)
        Me.Controls.Add(Me.dgvCtasCtes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbFormaPago)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDiferencia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPago)
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
        Me.Controls.Add(Me.PictureBox3)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReciboPago"
        Me.Text = "COMPROBANTE INTERNO DE PAGOS"
        CType(Me.BoletasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnProcesar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents BoletasBindingSource As BindingSource
    Friend WithEvents BoletasTableAdapter As dbcolmartDataSetTableAdapters.boletasTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtPago As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDiferencia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents cmbFormaPago As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvCtasCtes As DataGridView
    Friend WithEvents CtasctesBindingSource As BindingSource
    Friend WithEvents CtasctesTableAdapter As dbcolmartDataSetTableAdapters.ctasctesTableAdapter
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
End Class

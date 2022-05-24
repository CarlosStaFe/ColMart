<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtasCtesSoc
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtasCtesSoc))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSociedad = New System.Windows.Forms.TextBox()
        Me.txtNombSociedad = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvCtasCtes = New System.Windows.Forms.DataGridView()
        Me.CtactesocBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtactesocBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtactesocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CtactesocTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.ctactesocTableAdapter()
        Me.NroCCSocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCCSocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetCCSocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebeCCSocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaberCCSocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoCCSocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCCSocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCCSocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodoCCSocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoCCSocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCtasCtes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtactesocBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtactesocBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtactesocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sociedad:"
        '
        'txtSociedad
        '
        Me.txtSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSociedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSociedad.ForeColor = System.Drawing.Color.White
        Me.txtSociedad.Location = New System.Drawing.Point(132, 73)
        Me.txtSociedad.Name = "txtSociedad"
        Me.txtSociedad.Size = New System.Drawing.Size(62, 23)
        Me.txtSociedad.TabIndex = 1
        '
        'txtNombSociedad
        '
        Me.txtNombSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombSociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombSociedad.Enabled = False
        Me.txtNombSociedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombSociedad.ForeColor = System.Drawing.Color.White
        Me.txtNombSociedad.Location = New System.Drawing.Point(200, 73)
        Me.txtNombSociedad.Name = "txtNombSociedad"
        Me.txtNombSociedad.Size = New System.Drawing.Size(307, 23)
        Me.txtNombSociedad.TabIndex = 2
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.Black
        Me.txtSaldo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtSaldo.Location = New System.Drawing.Point(653, 70)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(107, 27)
        Me.txtSaldo.TabIndex = 4
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(582, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SALDO:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(21, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1005, 47)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
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
        Me.dgvCtasCtes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroCCSocDataGridViewTextBoxColumn, Me.FechaCCSocDataGridViewTextBoxColumn, Me.DetCCSocDataGridViewTextBoxColumn, Me.DebeCCSocDataGridViewTextBoxColumn, Me.HaberCCSocDataGridViewTextBoxColumn, Me.SaldoCCSocDataGridViewTextBoxColumn, Me.EstadoCCSocDataGridViewTextBoxColumn, Me.ObsCCSocDataGridViewTextBoxColumn, Me.PeriodoCCSocDataGridViewTextBoxColumn, Me.PagadoCCSocDataGridViewTextBoxColumn})
        Me.dgvCtasCtes.DataSource = Me.CtactesocBindingSource2
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
        Me.dgvCtasCtes.Location = New System.Drawing.Point(23, 119)
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
        Me.dgvCtasCtes.Size = New System.Drawing.Size(1003, 404)
        Me.dgvCtasCtes.TabIndex = 5
        '
        'CtactesocBindingSource2
        '
        Me.CtactesocBindingSource2.DataMember = "ctactesoc"
        Me.CtactesocBindingSource2.DataSource = Me.DbcolmartDataSet
        '
        'CtactesocBindingSource1
        '
        Me.CtactesocBindingSource1.DataMember = "ctactesoc"
        Me.CtactesocBindingSource1.DataSource = Me.DbcolmartDataSet
        '
        'CtactesocBindingSource
        '
        Me.CtactesocBindingSource.DataMember = "ctactesoc"
        Me.CtactesocBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(711, 538)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(99, 44)
        Me.btnSalir.TabIndex = 87
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(243, 538)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(99, 44)
        Me.btnLimpiar.TabIndex = 88
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(198, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(464, 36)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Cuentas Corrientes Sociedades"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(23, 529)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1003, 63)
        Me.PictureBox2.TabIndex = 90
        Me.PictureBox2.TabStop = False
        '
        'CtactesocTableAdapter
        '
        Me.CtactesocTableAdapter.ClearBeforeFill = True
        '
        'NroCCSocDataGridViewTextBoxColumn
        '
        Me.NroCCSocDataGridViewTextBoxColumn.DataPropertyName = "NroCCSoc"
        Me.NroCCSocDataGridViewTextBoxColumn.HeaderText = "NroCCSoc"
        Me.NroCCSocDataGridViewTextBoxColumn.Name = "NroCCSocDataGridViewTextBoxColumn"
        Me.NroCCSocDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroCCSocDataGridViewTextBoxColumn.Visible = False
        '
        'FechaCCSocDataGridViewTextBoxColumn
        '
        Me.FechaCCSocDataGridViewTextBoxColumn.DataPropertyName = "FechaCCSoc"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaCCSocDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaCCSocDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FechaCCSocDataGridViewTextBoxColumn.Name = "FechaCCSocDataGridViewTextBoxColumn"
        Me.FechaCCSocDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaCCSocDataGridViewTextBoxColumn.Width = 80
        '
        'DetCCSocDataGridViewTextBoxColumn
        '
        Me.DetCCSocDataGridViewTextBoxColumn.DataPropertyName = "DetCCSoc"
        Me.DetCCSocDataGridViewTextBoxColumn.HeaderText = "DETALLE"
        Me.DetCCSocDataGridViewTextBoxColumn.Name = "DetCCSocDataGridViewTextBoxColumn"
        Me.DetCCSocDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetCCSocDataGridViewTextBoxColumn.Width = 250
        '
        'DebeCCSocDataGridViewTextBoxColumn
        '
        Me.DebeCCSocDataGridViewTextBoxColumn.DataPropertyName = "DebeCCSoc"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DebeCCSocDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.DebeCCSocDataGridViewTextBoxColumn.HeaderText = "DEBE"
        Me.DebeCCSocDataGridViewTextBoxColumn.Name = "DebeCCSocDataGridViewTextBoxColumn"
        Me.DebeCCSocDataGridViewTextBoxColumn.ReadOnly = True
        Me.DebeCCSocDataGridViewTextBoxColumn.Width = 130
        '
        'HaberCCSocDataGridViewTextBoxColumn
        '
        Me.HaberCCSocDataGridViewTextBoxColumn.DataPropertyName = "HaberCCSoc"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.HaberCCSocDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.HaberCCSocDataGridViewTextBoxColumn.HeaderText = "HABER"
        Me.HaberCCSocDataGridViewTextBoxColumn.Name = "HaberCCSocDataGridViewTextBoxColumn"
        Me.HaberCCSocDataGridViewTextBoxColumn.ReadOnly = True
        Me.HaberCCSocDataGridViewTextBoxColumn.Width = 130
        '
        'SaldoCCSocDataGridViewTextBoxColumn
        '
        Me.SaldoCCSocDataGridViewTextBoxColumn.DataPropertyName = "SaldoCCSoc"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.SaldoCCSocDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.SaldoCCSocDataGridViewTextBoxColumn.HeaderText = "SALDO"
        Me.SaldoCCSocDataGridViewTextBoxColumn.Name = "SaldoCCSocDataGridViewTextBoxColumn"
        Me.SaldoCCSocDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoCCSocDataGridViewTextBoxColumn.Width = 130
        '
        'EstadoCCSocDataGridViewTextBoxColumn
        '
        Me.EstadoCCSocDataGridViewTextBoxColumn.DataPropertyName = "EstadoCCSoc"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.EstadoCCSocDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.EstadoCCSocDataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.EstadoCCSocDataGridViewTextBoxColumn.Name = "EstadoCCSocDataGridViewTextBoxColumn"
        Me.EstadoCCSocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObsCCSocDataGridViewTextBoxColumn
        '
        Me.ObsCCSocDataGridViewTextBoxColumn.DataPropertyName = "ObsCCSoc"
        Me.ObsCCSocDataGridViewTextBoxColumn.HeaderText = "Observación"
        Me.ObsCCSocDataGridViewTextBoxColumn.Name = "ObsCCSocDataGridViewTextBoxColumn"
        Me.ObsCCSocDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsCCSocDataGridViewTextBoxColumn.Width = 150
        '
        'PeriodoCCSocDataGridViewTextBoxColumn
        '
        Me.PeriodoCCSocDataGridViewTextBoxColumn.DataPropertyName = "PeriodoCCSoc"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PeriodoCCSocDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.PeriodoCCSocDataGridViewTextBoxColumn.HeaderText = "PERÍODO"
        Me.PeriodoCCSocDataGridViewTextBoxColumn.Name = "PeriodoCCSocDataGridViewTextBoxColumn"
        Me.PeriodoCCSocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PagadoCCSocDataGridViewTextBoxColumn
        '
        Me.PagadoCCSocDataGridViewTextBoxColumn.DataPropertyName = "PagadoCCSoc"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "d"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.PagadoCCSocDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.PagadoCCSocDataGridViewTextBoxColumn.HeaderText = "PAGADO"
        Me.PagadoCCSocDataGridViewTextBoxColumn.Name = "PagadoCCSocDataGridViewTextBoxColumn"
        Me.PagadoCCSocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmCtasCtesSoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1052, 616)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtNombSociedad)
        Me.Controls.Add(Me.txtSociedad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCtasCtes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCtasCtesSoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUENTAS CORRIENTES SOCIEDADES"
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCtasCtes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtactesocBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtactesocBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtactesocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSociedad As TextBox
    Friend WithEvents txtNombSociedad As TextBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvCtasCtes As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CtactesocBindingSource As BindingSource
    Friend WithEvents CtactesocTableAdapter As dbcolmartDataSetTableAdapters.ctactesocTableAdapter
    Friend WithEvents CtactesocBindingSource1 As BindingSource
    Friend WithEvents CtactesocBindingSource2 As BindingSource
    Friend WithEvents NroCCSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCCSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetCCSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DebeCCSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HaberCCSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoCCSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCCSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsCCSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeriodoCCSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagadoCCSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

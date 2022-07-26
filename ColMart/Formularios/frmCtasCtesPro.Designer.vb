<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtasCtesPro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtasCtesPro))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtNombProveedor = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCtasCtes = New System.Windows.Forms.DataGridView()
        Me.CtacteproBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CtacteproTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.ctacteproTableAdapter()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.EstadoCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCtasCtes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtacteproBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnActualizar
        '
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.Enabled = False
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(468, 532)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(119, 44)
        Me.btnActualizar.TabIndex = 104
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizar.UseVisualStyleBackColor = True
        Me.btnActualizar.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(269, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(474, 36)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Cuentas Corrientes Proveedores"
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
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(253, 532)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(99, 44)
        Me.btnLimpiar.TabIndex = 101
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
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
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(721, 532)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(99, 44)
        Me.btnSalir.TabIndex = 100
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(592, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "SALDO:"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.Black
        Me.txtSaldo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtSaldo.Location = New System.Drawing.Point(663, 64)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(157, 27)
        Me.txtSaldo.TabIndex = 97
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombProveedor
        '
        Me.txtNombProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombProveedor.Enabled = False
        Me.txtNombProveedor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombProveedor.ForeColor = System.Drawing.Color.White
        Me.txtNombProveedor.Location = New System.Drawing.Point(214, 68)
        Me.txtNombProveedor.Name = "txtNombProveedor"
        Me.txtNombProveedor.Size = New System.Drawing.Size(307, 23)
        Me.txtNombProveedor.TabIndex = 95
        '
        'txtProveedor
        '
        Me.txtProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProveedor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.ForeColor = System.Drawing.Color.White
        Me.txtProveedor.Location = New System.Drawing.Point(146, 68)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(62, 23)
        Me.txtProveedor.TabIndex = 94
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Proveedor:"
        '
        'dgvCtasCtes
        '
        Me.dgvCtasCtes.AllowUserToAddRows = False
        Me.dgvCtasCtes.AllowUserToDeleteRows = False
        Me.dgvCtasCtes.AllowUserToOrderColumns = True
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
        Me.dgvCtasCtes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCCProDataGridViewTextBoxColumn, Me.IdCpraDataGridViewTextBoxColumn, Me.NroCCProDataGridViewTextBoxColumn, Me.FechaCCProDataGridViewTextBoxColumn, Me.TipoCbteCCProDataGridViewTextBoxColumn, Me.PrefijoCCProDataGridViewTextBoxColumn, Me.SubfijoCCProDataGridViewTextBoxColumn, Me.DetalleCCProDataGridViewTextBoxColumn, Me.DebeCCProDataGridViewTextBoxColumn, Me.HaberCCProDataGridViewTextBoxColumn, Me.SaldoCCProDataGridViewTextBoxColumn, Me.EstadoCCProDataGridViewTextBoxColumn, Me.ObsCCProDataGridViewTextBoxColumn})
        Me.dgvCtasCtes.DataSource = Me.CtacteproBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCtasCtes.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCtasCtes.EnableHeadersVisualStyles = False
        Me.dgvCtasCtes.GridColor = System.Drawing.Color.White
        Me.dgvCtasCtes.Location = New System.Drawing.Point(33, 111)
        Me.dgvCtasCtes.Name = "dgvCtasCtes"
        Me.dgvCtasCtes.ReadOnly = True
        Me.dgvCtasCtes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtasCtes.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCtasCtes.Size = New System.Drawing.Size(1007, 404)
        Me.dgvCtasCtes.TabIndex = 98
        '
        'CtacteproBindingSource
        '
        Me.CtacteproBindingSource.DataMember = "ctactepro"
        Me.CtacteproBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(31, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1005, 47)
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(33, 523)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1003, 63)
        Me.PictureBox2.TabIndex = 103
        Me.PictureBox2.TabStop = False
        '
        'CtacteproTableAdapter
        '
        Me.CtacteproTableAdapter.ClearBeforeFill = True
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
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
        Me.TipoCbteCCProDataGridViewTextBoxColumn.Width = 50
        '
        'PrefijoCCProDataGridViewTextBoxColumn
        '
        Me.PrefijoCCProDataGridViewTextBoxColumn.DataPropertyName = "PrefijoCCPro"
        Me.PrefijoCCProDataGridViewTextBoxColumn.HeaderText = "PREFIJO"
        Me.PrefijoCCProDataGridViewTextBoxColumn.Name = "PrefijoCCProDataGridViewTextBoxColumn"
        Me.PrefijoCCProDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrefijoCCProDataGridViewTextBoxColumn.Width = 60
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
        Me.DebeCCProDataGridViewTextBoxColumn.Width = 120
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
        Me.HaberCCProDataGridViewTextBoxColumn.Width = 120
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
        Me.SaldoCCProDataGridViewTextBoxColumn.Width = 150
        '
        'EstadoCCProDataGridViewTextBoxColumn
        '
        Me.EstadoCCProDataGridViewTextBoxColumn.DataPropertyName = "EstadoCCPro"
        Me.EstadoCCProDataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.EstadoCCProDataGridViewTextBoxColumn.Name = "EstadoCCProDataGridViewTextBoxColumn"
        Me.EstadoCCProDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObsCCProDataGridViewTextBoxColumn
        '
        Me.ObsCCProDataGridViewTextBoxColumn.DataPropertyName = "ObsCCPro"
        Me.ObsCCProDataGridViewTextBoxColumn.HeaderText = "OBS."
        Me.ObsCCProDataGridViewTextBoxColumn.Name = "ObsCCProDataGridViewTextBoxColumn"
        Me.ObsCCProDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsCCProDataGridViewTextBoxColumn.Width = 200
        '
        'frmCtasCtesPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 593)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtNombProveedor)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCtasCtes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCtasCtesPro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUENTAS CORRIENTES PROVEEDORES"
        CType(Me.dgvCtasCtes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtacteproBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnActualizar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtNombProveedor As TextBox
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCtasCtes As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents CtacteproBindingSource As BindingSource
    Friend WithEvents CtacteproTableAdapter As dbcolmartDataSetTableAdapters.ctacteproTableAdapter
    Friend WithEvents ToolTipMsg As ToolTip
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
    Friend WithEvents EstadoCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovimCaja
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
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimCaja))
        Me.dgvMovim = New System.Windows.Forms.DataGridView()
        Me.X = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleCajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebeCajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaberCajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoCajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EfectivoCajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarjetaCajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransfeCajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.CajaTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.cajaTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTipoMovim = New System.Windows.Forms.ComboBox()
        Me.cmbFormaMov = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFechaHoy = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.txtTarjeta = New System.Windows.Forms.TextBox()
        Me.txtTransfer = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvMovim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMovim
        '
        Me.dgvMovim.AllowUserToAddRows = False
        Me.dgvMovim.AllowUserToDeleteRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White
        Me.dgvMovim.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvMovim.AutoGenerateColumns = False
        Me.dgvMovim.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvMovim.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMovim.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.dgvMovim.ColumnHeadersHeight = 30
        Me.dgvMovim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMovim.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.X, Me.FechaCajaDataGridViewTextBoxColumn, Me.DetalleCajaDataGridViewTextBoxColumn, Me.DebeCajaDataGridViewTextBoxColumn, Me.HaberCajaDataGridViewTextBoxColumn, Me.SaldoCajaDataGridViewTextBoxColumn, Me.EfectivoCajaDataGridViewTextBoxColumn, Me.TarjetaCajaDataGridViewTextBoxColumn, Me.TransfeCajaDataGridViewTextBoxColumn, Me.ObsCajaDataGridViewTextBoxColumn})
        Me.dgvMovim.DataSource = Me.CajaBindingSource
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMovim.DefaultCellStyle = DataGridViewCellStyle29
        Me.dgvMovim.EnableHeadersVisualStyles = False
        Me.dgvMovim.GridColor = System.Drawing.Color.White
        Me.dgvMovim.Location = New System.Drawing.Point(8, 161)
        Me.dgvMovim.Name = "dgvMovim"
        Me.dgvMovim.ReadOnly = True
        Me.dgvMovim.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMovim.RowHeadersDefaultCellStyle = DataGridViewCellStyle30
        Me.dgvMovim.Size = New System.Drawing.Size(984, 371)
        Me.dgvMovim.TabIndex = 9
        '
        'X
        '
        Me.X.HeaderText = "X"
        Me.X.Name = "X"
        Me.X.ReadOnly = True
        Me.X.Width = 20
        '
        'FechaCajaDataGridViewTextBoxColumn
        '
        Me.FechaCajaDataGridViewTextBoxColumn.DataPropertyName = "FechaCaja"
        Me.FechaCajaDataGridViewTextBoxColumn.HeaderText = "FechaCaja"
        Me.FechaCajaDataGridViewTextBoxColumn.Name = "FechaCajaDataGridViewTextBoxColumn"
        Me.FechaCajaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaCajaDataGridViewTextBoxColumn.Visible = False
        '
        'DetalleCajaDataGridViewTextBoxColumn
        '
        Me.DetalleCajaDataGridViewTextBoxColumn.DataPropertyName = "DetalleCaja"
        Me.DetalleCajaDataGridViewTextBoxColumn.HeaderText = "DETALLE MOVIMIENTO"
        Me.DetalleCajaDataGridViewTextBoxColumn.Name = "DetalleCajaDataGridViewTextBoxColumn"
        Me.DetalleCajaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleCajaDataGridViewTextBoxColumn.Width = 300
        '
        'DebeCajaDataGridViewTextBoxColumn
        '
        Me.DebeCajaDataGridViewTextBoxColumn.DataPropertyName = "DebeCaja"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "C2"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.DebeCajaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle23
        Me.DebeCajaDataGridViewTextBoxColumn.HeaderText = "DEBE"
        Me.DebeCajaDataGridViewTextBoxColumn.Name = "DebeCajaDataGridViewTextBoxColumn"
        Me.DebeCajaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HaberCajaDataGridViewTextBoxColumn
        '
        Me.HaberCajaDataGridViewTextBoxColumn.DataPropertyName = "HaberCaja"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "C2"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.HaberCajaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle24
        Me.HaberCajaDataGridViewTextBoxColumn.HeaderText = "HABER"
        Me.HaberCajaDataGridViewTextBoxColumn.Name = "HaberCajaDataGridViewTextBoxColumn"
        Me.HaberCajaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoCajaDataGridViewTextBoxColumn
        '
        Me.SaldoCajaDataGridViewTextBoxColumn.DataPropertyName = "SaldoCaja"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle25.Format = "C2"
        DataGridViewCellStyle25.NullValue = Nothing
        Me.SaldoCajaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle25
        Me.SaldoCajaDataGridViewTextBoxColumn.HeaderText = "SALDO"
        Me.SaldoCajaDataGridViewTextBoxColumn.Name = "SaldoCajaDataGridViewTextBoxColumn"
        Me.SaldoCajaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EfectivoCajaDataGridViewTextBoxColumn
        '
        Me.EfectivoCajaDataGridViewTextBoxColumn.DataPropertyName = "EfectivoCaja"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle26.Format = "C2"
        DataGridViewCellStyle26.NullValue = Nothing
        Me.EfectivoCajaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle26
        Me.EfectivoCajaDataGridViewTextBoxColumn.HeaderText = "EFECTIVO"
        Me.EfectivoCajaDataGridViewTextBoxColumn.Name = "EfectivoCajaDataGridViewTextBoxColumn"
        Me.EfectivoCajaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TarjetaCajaDataGridViewTextBoxColumn
        '
        Me.TarjetaCajaDataGridViewTextBoxColumn.DataPropertyName = "TarjetaCaja"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Format = "C2"
        DataGridViewCellStyle27.NullValue = Nothing
        Me.TarjetaCajaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle27
        Me.TarjetaCajaDataGridViewTextBoxColumn.HeaderText = "TARJETA"
        Me.TarjetaCajaDataGridViewTextBoxColumn.Name = "TarjetaCajaDataGridViewTextBoxColumn"
        Me.TarjetaCajaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransfeCajaDataGridViewTextBoxColumn
        '
        Me.TransfeCajaDataGridViewTextBoxColumn.DataPropertyName = "TransfeCaja"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.Format = "C2"
        DataGridViewCellStyle28.NullValue = Nothing
        Me.TransfeCajaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle28
        Me.TransfeCajaDataGridViewTextBoxColumn.HeaderText = "TRANSFER."
        Me.TransfeCajaDataGridViewTextBoxColumn.Name = "TransfeCajaDataGridViewTextBoxColumn"
        Me.TransfeCajaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObsCajaDataGridViewTextBoxColumn
        '
        Me.ObsCajaDataGridViewTextBoxColumn.DataPropertyName = "ObsCaja"
        Me.ObsCajaDataGridViewTextBoxColumn.HeaderText = "OBSERVACIÓN"
        Me.ObsCajaDataGridViewTextBoxColumn.Name = "ObsCajaDataGridViewTextBoxColumn"
        Me.ObsCajaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsCajaDataGridViewTextBoxColumn.Width = 150
        '
        'CajaBindingSource
        '
        Me.CajaBindingSource.DataMember = "caja"
        Me.CajaBindingSource.DataSource = Me.DbcolmartDataSet
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
        Me.Label3.Location = New System.Drawing.Point(315, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(325, 36)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Movimientos de Caja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(438, 561)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "TOTALES CAJA:"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.Black
        Me.txtSaldo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtSaldo.Location = New System.Drawing.Point(553, 555)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(113, 27)
        Me.txtSaldo.TabIndex = 92
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CajaTableAdapter
        '
        Me.CajaTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label7.Location = New System.Drawing.Point(29, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 17)
        Me.Label7.TabIndex = 154
        Me.Label7.Text = "TIPO MOVIMIENTO"
        '
        'cmbTipoMovim
        '
        Me.cmbTipoMovim.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbTipoMovim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoMovim.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoMovim.ForeColor = System.Drawing.Color.White
        Me.cmbTipoMovim.FormattingEnabled = True
        Me.cmbTipoMovim.Items.AddRange(New Object() {"INGRESO", "EGRESO"})
        Me.cmbTipoMovim.Location = New System.Drawing.Point(30, 87)
        Me.cmbTipoMovim.Name = "cmbTipoMovim"
        Me.cmbTipoMovim.Size = New System.Drawing.Size(129, 25)
        Me.cmbTipoMovim.TabIndex = 0
        '
        'cmbFormaMov
        '
        Me.cmbFormaMov.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbFormaMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFormaMov.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormaMov.ForeColor = System.Drawing.Color.White
        Me.cmbFormaMov.FormattingEnabled = True
        Me.cmbFormaMov.Items.AddRange(New Object() {"EFECTIVO", "TARJETA", "TRANSFERENCIA"})
        Me.cmbFormaMov.Location = New System.Drawing.Point(806, 87)
        Me.cmbFormaMov.Name = "cmbFormaMov"
        Me.cmbFormaMov.Size = New System.Drawing.Size(143, 25)
        Me.cmbFormaMov.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(828, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "FORMA MOV."
        '
        'txtDetalle
        '
        Me.txtDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalle.Enabled = False
        Me.txtDetalle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.ForeColor = System.Drawing.Color.White
        Me.txtDetalle.Location = New System.Drawing.Point(165, 88)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(522, 23)
        Me.txtDetalle.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(162, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 17)
        Me.Label4.TabIndex = 158
        Me.Label4.Text = "DETALLE DEL MOVIMIENTO"
        '
        'txtFechaHoy
        '
        Me.txtFechaHoy.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFechaHoy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaHoy.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaHoy.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtFechaHoy.Location = New System.Drawing.Point(892, 21)
        Me.txtFechaHoy.Name = "txtFechaHoy"
        Me.txtFechaHoy.Size = New System.Drawing.Size(100, 27)
        Me.txtFechaHoy.TabIndex = 159
        Me.txtFechaHoy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImporte
        '
        Me.txtImporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImporte.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.White
        Me.txtImporte.Location = New System.Drawing.Point(693, 88)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(107, 23)
        Me.txtImporte.TabIndex = 2
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label5.Location = New System.Drawing.Point(735, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 161
        Me.Label5.Text = "IMPORTE"
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.ForeColor = System.Drawing.Color.White
        Me.txtObs.Location = New System.Drawing.Point(165, 117)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(784, 23)
        Me.txtObs.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label6.Location = New System.Drawing.Point(55, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 17)
        Me.Label6.TabIndex = 163
        Me.Label6.Text = "OBSERVACIÓN:"
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
        Me.btnLimpiar.Location = New System.Drawing.Point(1009, 220)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(71, 57)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.UseVisualStyleBackColor = True
        Me.btnLimpiar.Visible = False
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
        Me.btnSalir.Location = New System.Drawing.Point(1009, 524)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 57)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(1009, 68)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(71, 57)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        Me.btnAgregar.Visible = False
        '
        'txtEfectivo
        '
        Me.txtEfectivo.BackColor = System.Drawing.Color.Red
        Me.txtEfectivo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectivo.ForeColor = System.Drawing.Color.Cyan
        Me.txtEfectivo.Location = New System.Drawing.Point(670, 555)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(99, 27)
        Me.txtEfectivo.TabIndex = 164
        Me.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTarjeta
        '
        Me.txtTarjeta.BackColor = System.Drawing.Color.Black
        Me.txtTarjeta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarjeta.ForeColor = System.Drawing.Color.Cyan
        Me.txtTarjeta.Location = New System.Drawing.Point(772, 555)
        Me.txtTarjeta.Name = "txtTarjeta"
        Me.txtTarjeta.Size = New System.Drawing.Size(99, 27)
        Me.txtTarjeta.TabIndex = 165
        Me.txtTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTransfer
        '
        Me.txtTransfer.BackColor = System.Drawing.Color.Black
        Me.txtTransfer.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransfer.ForeColor = System.Drawing.Color.Cyan
        Me.txtTransfer.Location = New System.Drawing.Point(873, 555)
        Me.txtTransfer.Name = "txtTransfer"
        Me.txtTransfer.Size = New System.Drawing.Size(99, 27)
        Me.txtTransfer.TabIndex = 166
        Me.txtTransfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(1009, 372)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(71, 57)
        Me.btnCerrar.TabIndex = 167
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCerrar.UseVisualStyleBackColor = True
        Me.btnCerrar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(8, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(984, 96)
        Me.PictureBox1.TabIndex = 168
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(8, 543)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(984, 53)
        Me.PictureBox2.TabIndex = 169
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(998, 57)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(94, 539)
        Me.PictureBox3.TabIndex = 170
        Me.PictureBox3.TabStop = False
        '
        'frmMovimCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1123, 605)
        Me.Controls.Add(Me.txtTransfer)
        Me.Controls.Add(Me.txtTarjeta)
        Me.Controls.Add(Me.txtEfectivo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.txtFechaHoy)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbFormaMov)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbTipoMovim)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvMovim)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.PictureBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimCaja"
        Me.Text = "MOVIMIENTOS DE CAJA DIARIA"
        CType(Me.dgvMovim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMovim As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents CajaBindingSource As BindingSource
    Friend WithEvents CajaTableAdapter As dbcolmartDataSetTableAdapters.cajaTableAdapter
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbTipoMovim As ComboBox
    Friend WithEvents cmbFormaMov As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFechaHoy As TextBox
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents X As DataGridViewTextBoxColumn
    Friend WithEvents FechaCajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleCajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DebeCajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HaberCajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoCajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EfectivoCajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarjetaCajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransfeCajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsCajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtEfectivo As TextBox
    Friend WithEvents txtTarjeta As TextBox
    Friend WithEvents txtTransfer As TextBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReciboGral
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
        Dim CodDebMatLabel As System.Windows.Forms.Label
        Dim DetDebMatLabel As System.Windows.Forms.Label
        Dim ImpDebMatLabel As System.Windows.Forms.Label
        Dim CategDebMatLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciboGral))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtMatSoc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.dgvRenglones = New System.Windows.Forms.DataGridView()
        Me.IdRenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoRenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleRenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteRenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadRenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalRenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaRenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RenglonesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.RenglonesTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.renglonesTableAdapter()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTarjeta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTransferencia = New System.Windows.Forms.TextBox()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtAntiguedad = New System.Windows.Forms.TextBox()
        Me.txtSaldoMat = New System.Windows.Forms.TextBox()
        Me.txtFianza = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.txtTipoRec = New System.Windows.Forms.TextBox()
        CodDebMatLabel = New System.Windows.Forms.Label()
        DetDebMatLabel = New System.Windows.Forms.Label()
        ImpDebMatLabel = New System.Windows.Forms.Label()
        CategDebMatLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRenglones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RenglonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodDebMatLabel
        '
        CodDebMatLabel.AutoSize = True
        CodDebMatLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodDebMatLabel.ForeColor = System.Drawing.Color.White
        CodDebMatLabel.Location = New System.Drawing.Point(34, 124)
        CodDebMatLabel.Name = "CodDebMatLabel"
        CodDebMatLabel.Size = New System.Drawing.Size(58, 17)
        CodDebMatLabel.TabIndex = 155
        CodDebMatLabel.Text = "Código"
        '
        'DetDebMatLabel
        '
        DetDebMatLabel.AutoSize = True
        DetDebMatLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DetDebMatLabel.ForeColor = System.Drawing.Color.White
        DetDebMatLabel.Location = New System.Drawing.Point(98, 124)
        DetDebMatLabel.Name = "DetDebMatLabel"
        DetDebMatLabel.Size = New System.Drawing.Size(54, 17)
        DetDebMatLabel.TabIndex = 156
        DetDebMatLabel.Text = "Detalle"
        '
        'ImpDebMatLabel
        '
        ImpDebMatLabel.AutoSize = True
        ImpDebMatLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImpDebMatLabel.ForeColor = System.Drawing.Color.White
        ImpDebMatLabel.Location = New System.Drawing.Point(423, 124)
        ImpDebMatLabel.Name = "ImpDebMatLabel"
        ImpDebMatLabel.Size = New System.Drawing.Size(59, 17)
        ImpDebMatLabel.TabIndex = 157
        ImpDebMatLabel.Text = "Importe"
        '
        'CategDebMatLabel
        '
        CategDebMatLabel.AutoSize = True
        CategDebMatLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategDebMatLabel.ForeColor = System.Drawing.Color.White
        CategDebMatLabel.Location = New System.Drawing.Point(490, 124)
        CategDebMatLabel.Name = "CategDebMatLabel"
        CategDebMatLabel.Size = New System.Drawing.Size(71, 17)
        CategDebMatLabel.TabIndex = 158
        CategDebMatLabel.Text = "Cantidad"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(596, 124)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(62, 17)
        Label2.TabIndex = 172
        Label2.Text = "SubTotal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(245, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(372, 36)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Recibo de Pago General"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtFecha.Location = New System.Drawing.Point(697, 66)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 23)
        Me.txtFecha.TabIndex = 16
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(231, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(427, 23)
        Me.txtNombre.TabIndex = 1
        '
        'txtMatSoc
        '
        Me.txtMatSoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMatSoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMatSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatSoc.ForeColor = System.Drawing.Color.White
        Me.txtMatSoc.Location = New System.Drawing.Point(168, 66)
        Me.txtMatSoc.Name = "txtMatSoc"
        Me.txtMatSoc.Size = New System.Drawing.Size(57, 23)
        Me.txtMatSoc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 17)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Matrícula/Sociedad:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(10, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(675, 54)
        Me.PictureBox1.TabIndex = 153
        Me.PictureBox1.TabStop = False
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(37, 145)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(55, 23)
        Me.txtCodigo.TabIndex = 2
        '
        'txtDetalle
        '
        Me.txtDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalle.Enabled = False
        Me.txtDetalle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.ForeColor = System.Drawing.Color.White
        Me.txtDetalle.Location = New System.Drawing.Point(98, 145)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(285, 23)
        Me.txtDetalle.TabIndex = 3
        '
        'txtImporte
        '
        Me.txtImporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImporte.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.White
        Me.txtImporte.Location = New System.Drawing.Point(389, 145)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(96, 23)
        Me.txtImporte.TabIndex = 4
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(491, 145)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(68, 23)
        Me.txtCantidad.TabIndex = 5
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvRenglones
        '
        Me.dgvRenglones.AllowUserToAddRows = False
        Me.dgvRenglones.AllowUserToDeleteRows = False
        Me.dgvRenglones.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRenglones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRenglones.AutoGenerateColumns = False
        Me.dgvRenglones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvRenglones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRenglones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRenglones.ColumnHeadersHeight = 30
        Me.dgvRenglones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRenglones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRenDataGridViewTextBoxColumn, Me.CodigoRenDataGridViewTextBoxColumn, Me.DetalleRenDataGridViewTextBoxColumn, Me.ImporteRenDataGridViewTextBoxColumn, Me.CantidadRenDataGridViewTextBoxColumn, Me.SubtotalRenDataGridViewTextBoxColumn, Me.CategoriaRenDataGridViewTextBoxColumn})
        Me.dgvRenglones.DataSource = Me.RenglonesBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRenglones.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvRenglones.EnableHeadersVisualStyles = False
        Me.dgvRenglones.GridColor = System.Drawing.Color.White
        Me.dgvRenglones.Location = New System.Drawing.Point(12, 191)
        Me.dgvRenglones.Name = "dgvRenglones"
        Me.dgvRenglones.ReadOnly = True
        Me.dgvRenglones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRenglones.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvRenglones.Size = New System.Drawing.Size(694, 222)
        Me.dgvRenglones.TabIndex = 163
        '
        'IdRenDataGridViewTextBoxColumn
        '
        Me.IdRenDataGridViewTextBoxColumn.DataPropertyName = "id_Ren"
        Me.IdRenDataGridViewTextBoxColumn.HeaderText = "id_Ren"
        Me.IdRenDataGridViewTextBoxColumn.Name = "IdRenDataGridViewTextBoxColumn"
        Me.IdRenDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdRenDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoRenDataGridViewTextBoxColumn
        '
        Me.CodigoRenDataGridViewTextBoxColumn.DataPropertyName = "CodigoRen"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CodigoRenDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CodigoRenDataGridViewTextBoxColumn.HeaderText = "CÓD."
        Me.CodigoRenDataGridViewTextBoxColumn.Name = "CodigoRenDataGridViewTextBoxColumn"
        Me.CodigoRenDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoRenDataGridViewTextBoxColumn.Width = 50
        '
        'DetalleRenDataGridViewTextBoxColumn
        '
        Me.DetalleRenDataGridViewTextBoxColumn.DataPropertyName = "DetalleRen"
        Me.DetalleRenDataGridViewTextBoxColumn.HeaderText = "DETALLE"
        Me.DetalleRenDataGridViewTextBoxColumn.Name = "DetalleRenDataGridViewTextBoxColumn"
        Me.DetalleRenDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleRenDataGridViewTextBoxColumn.Width = 300
        '
        'ImporteRenDataGridViewTextBoxColumn
        '
        Me.ImporteRenDataGridViewTextBoxColumn.DataPropertyName = "ImporteRen"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "-"
        Me.ImporteRenDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ImporteRenDataGridViewTextBoxColumn.HeaderText = "IMPORTE"
        Me.ImporteRenDataGridViewTextBoxColumn.Name = "ImporteRenDataGridViewTextBoxColumn"
        Me.ImporteRenDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteRenDataGridViewTextBoxColumn.Width = 110
        '
        'CantidadRenDataGridViewTextBoxColumn
        '
        Me.CantidadRenDataGridViewTextBoxColumn.DataPropertyName = "CantidadRen"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CantidadRenDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.CantidadRenDataGridViewTextBoxColumn.HeaderText = "CANT."
        Me.CantidadRenDataGridViewTextBoxColumn.Name = "CantidadRenDataGridViewTextBoxColumn"
        Me.CantidadRenDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadRenDataGridViewTextBoxColumn.Width = 70
        '
        'SubtotalRenDataGridViewTextBoxColumn
        '
        Me.SubtotalRenDataGridViewTextBoxColumn.DataPropertyName = "SubtotalRen"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = "-"
        Me.SubtotalRenDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.SubtotalRenDataGridViewTextBoxColumn.HeaderText = "SUBTOTAL"
        Me.SubtotalRenDataGridViewTextBoxColumn.Name = "SubtotalRenDataGridViewTextBoxColumn"
        Me.SubtotalRenDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubtotalRenDataGridViewTextBoxColumn.Width = 110
        '
        'CategoriaRenDataGridViewTextBoxColumn
        '
        Me.CategoriaRenDataGridViewTextBoxColumn.DataPropertyName = "CategoriaRen"
        Me.CategoriaRenDataGridViewTextBoxColumn.HeaderText = "CategoriaRen"
        Me.CategoriaRenDataGridViewTextBoxColumn.Name = "CategoriaRenDataGridViewTextBoxColumn"
        Me.CategoriaRenDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoriaRenDataGridViewTextBoxColumn.Visible = False
        '
        'RenglonesBindingSource
        '
        Me.RenglonesBindingSource.DataMember = "renglones"
        Me.RenglonesBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.btnImprimir.Location = New System.Drawing.Point(724, 477)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(71, 57)
        Me.btnImprimir.TabIndex = 15
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        Me.btnImprimir.Visible = False
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
        Me.btnLimpiar.Location = New System.Drawing.Point(724, 205)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(71, 57)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.UseVisualStyleBackColor = True
        Me.btnLimpiar.Visible = False
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
        Me.btnSalir.Location = New System.Drawing.Point(724, 341)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 57)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(712, 191)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(94, 352)
        Me.PictureBox4.TabIndex = 167
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(10, 110)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(796, 75)
        Me.PictureBox3.TabIndex = 170
        Me.PictureBox3.TabStop = False
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubtotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.ForeColor = System.Drawing.Color.White
        Me.txtSubtotal.Location = New System.Drawing.Point(565, 145)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(96, 23)
        Me.txtSubtotal.TabIndex = 6
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(719, 116)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(71, 64)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        Me.btnAgregar.Visible = False
        '
        'txtCategoria
        '
        Me.txtCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategoria.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.ForeColor = System.Drawing.Color.White
        Me.txtCategoria.Location = New System.Drawing.Point(667, 145)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(42, 23)
        Me.txtCategoria.TabIndex = 7
        Me.txtCategoria.Visible = False
        '
        'RenglonesTableAdapter
        '
        Me.RenglonesTableAdapter.ClearBeforeFill = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Black
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Yellow
        Me.txtTotal.Location = New System.Drawing.Point(586, 424)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(107, 27)
        Me.txtTotal.TabIndex = 176
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(21, 485)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 17)
        Me.Label4.TabIndex = 178
        Me.Label4.Text = "OBSERVACIONES DEL RECIBO"
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.ForeColor = System.Drawing.Color.White
        Me.txtObs.Location = New System.Drawing.Point(218, 488)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(469, 47)
        Me.txtObs.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(511, 424)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 23)
        Me.Label5.TabIndex = 179
        Me.Label5.Text = "TOTAL:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(340, 459)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 185
        Me.Label6.Text = "TARJETA:"
        '
        'txtTarjeta
        '
        Me.txtTarjeta.BackColor = System.Drawing.Color.Black
        Me.txtTarjeta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarjeta.ForeColor = System.Drawing.Color.Lime
        Me.txtTarjeta.Location = New System.Drawing.Point(407, 456)
        Me.txtTarjeta.Name = "txtTarjeta"
        Me.txtTarjeta.Size = New System.Drawing.Size(83, 23)
        Me.txtTarjeta.TabIndex = 13
        Me.txtTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Lime
        Me.Label8.Location = New System.Drawing.Point(192, 459)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 183
        Me.Label8.Text = "TRANSF.:"
        '
        'txtTransferencia
        '
        Me.txtTransferencia.BackColor = System.Drawing.Color.Black
        Me.txtTransferencia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferencia.ForeColor = System.Drawing.Color.Lime
        Me.txtTransferencia.Location = New System.Drawing.Point(251, 456)
        Me.txtTransferencia.Name = "txtTransferencia"
        Me.txtTransferencia.Size = New System.Drawing.Size(83, 23)
        Me.txtTransferencia.TabIndex = 12
        Me.txtTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEfectivo
        '
        Me.txtEfectivo.BackColor = System.Drawing.Color.Black
        Me.txtEfectivo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectivo.ForeColor = System.Drawing.Color.Lime
        Me.txtEfectivo.Location = New System.Drawing.Point(94, 456)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(83, 23)
        Me.txtEfectivo.TabIndex = 11
        Me.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Lime
        Me.Label9.Location = New System.Drawing.Point(17, 459)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 17)
        Me.Label9.TabIndex = 181
        Me.Label9.Text = "EFECTIVO:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(690, 51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(116, 55)
        Me.PictureBox2.TabIndex = 186
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Location = New System.Drawing.Point(10, 418)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(693, 126)
        Me.PictureBox5.TabIndex = 187
        Me.PictureBox5.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(504, 453)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 23)
        Me.Label7.TabIndex = 189
        Me.Label7.Text = "SALDO:"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.Black
        Me.txtSaldo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.Red
        Me.txtSaldo.Location = New System.Drawing.Point(586, 453)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(107, 27)
        Me.txtSaldo.TabIndex = 188
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAntiguedad
        '
        Me.txtAntiguedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtAntiguedad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAntiguedad.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntiguedad.ForeColor = System.Drawing.Color.Red
        Me.txtAntiguedad.Location = New System.Drawing.Point(836, 103)
        Me.txtAntiguedad.Name = "txtAntiguedad"
        Me.txtAntiguedad.Size = New System.Drawing.Size(146, 29)
        Me.txtAntiguedad.TabIndex = 190
        Me.txtAntiguedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSaldoMat
        '
        Me.txtSaldoMat.BackColor = System.Drawing.Color.Black
        Me.txtSaldoMat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoMat.ForeColor = System.Drawing.Color.Aqua
        Me.txtSaldoMat.Location = New System.Drawing.Point(850, 178)
        Me.txtSaldoMat.Name = "txtSaldoMat"
        Me.txtSaldoMat.Size = New System.Drawing.Size(124, 27)
        Me.txtSaldoMat.TabIndex = 191
        Me.txtSaldoMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFianza
        '
        Me.txtFianza.BackColor = System.Drawing.Color.Black
        Me.txtFianza.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFianza.ForeColor = System.Drawing.Color.Aqua
        Me.txtFianza.Location = New System.Drawing.Point(850, 251)
        Me.txtFianza.Name = "txtFianza"
        Me.txtFianza.Size = New System.Drawing.Size(124, 27)
        Me.txtFianza.TabIndex = 192
        Me.txtFianza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Lime
        Me.Label10.Location = New System.Drawing.Point(840, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 22)
        Me.Label10.TabIndex = 193
        Me.Label10.Text = "ANTIGUEDAD"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Lime
        Me.Label11.Location = New System.Drawing.Point(872, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 22)
        Me.Label11.TabIndex = 194
        Me.Label11.Text = "SALDO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Lime
        Me.Label12.Location = New System.Drawing.Point(872, 217)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 22)
        Me.Label12.TabIndex = 195
        Me.Label12.Text = "FIANZA"
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox6.Location = New System.Drawing.Point(812, 51)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(199, 247)
        Me.PictureBox6.TabIndex = 196
        Me.PictureBox6.TabStop = False
        '
        'txtTipoRec
        '
        Me.txtTipoRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTipoRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoRec.Enabled = False
        Me.txtTipoRec.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoRec.ForeColor = System.Drawing.Color.White
        Me.txtTipoRec.Location = New System.Drawing.Point(667, 118)
        Me.txtTipoRec.Name = "txtTipoRec"
        Me.txtTipoRec.Size = New System.Drawing.Size(42, 23)
        Me.txtTipoRec.TabIndex = 197
        '
        'frmReciboGral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1055, 604)
        Me.Controls.Add(Me.txtTipoRec)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtFianza)
        Me.Controls.Add(Me.txtSaldoMat)
        Me.Controls.Add(Me.txtAntiguedad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTarjeta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTransferencia)
        Me.Controls.Add(Me.txtEfectivo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.dgvRenglones)
        Me.Controls.Add(CodDebMatLabel)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(DetDebMatLabel)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(ImpDebMatLabel)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(CategDebMatLabel)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtMatSoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReciboGral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECIBO DE PAGO GENERAL"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRenglones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RenglonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtMatSoc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents dgvRenglones As DataGridView
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents RenglonesBindingSource As BindingSource
    Friend WithEvents RenglonesTableAdapter As dbcolmartDataSetTableAdapters.renglonesTableAdapter
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTarjeta As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTransferencia As TextBox
    Friend WithEvents txtEfectivo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents IdRenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoRenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleRenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteRenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadRenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalRenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaRenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtAntiguedad As TextBox
    Friend WithEvents txtSaldoMat As TextBox
    Friend WithEvents txtFianza As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents txtTipoRec As TextBox
End Class

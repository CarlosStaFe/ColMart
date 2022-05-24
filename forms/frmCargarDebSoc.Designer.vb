<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCargarDebSoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargarDebSoc))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSociedad = New System.Windows.Forms.TextBox()
        Me.txtNombSociedad = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvDebitoSoc = New System.Windows.Forms.DataGridView()
        Me.SocDebSocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodDebSocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDebSocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KgDebSocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategDebSoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitosocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager()
        Me.txtSocDebSoc = New System.Windows.Forms.TextBox()
        Me.txtCodDebSoc = New System.Windows.Forms.TextBox()
        Me.txtDetDebSoc = New System.Windows.Forms.TextBox()
        Me.txtKgDebSoc = New System.Windows.Forms.TextBox()
        Me.txtCategDebSoc = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DebitosocTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.debitosocTableAdapter()
        CodDebMatLabel = New System.Windows.Forms.Label()
        DetDebMatLabel = New System.Windows.Forms.Label()
        ImpDebMatLabel = New System.Windows.Forms.Label()
        CategDebMatLabel = New System.Windows.Forms.Label()
        CType(Me.dgvDebitoSoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DebitosocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodDebMatLabel
        '
        CodDebMatLabel.AutoSize = True
        CodDebMatLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodDebMatLabel.ForeColor = System.Drawing.Color.White
        CodDebMatLabel.Location = New System.Drawing.Point(21, 92)
        CodDebMatLabel.Name = "CodDebMatLabel"
        CodDebMatLabel.Size = New System.Drawing.Size(58, 17)
        CodDebMatLabel.TabIndex = 4
        CodDebMatLabel.Text = "Código"
        '
        'DetDebMatLabel
        '
        DetDebMatLabel.AutoSize = True
        DetDebMatLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DetDebMatLabel.ForeColor = System.Drawing.Color.White
        DetDebMatLabel.Location = New System.Drawing.Point(85, 92)
        DetDebMatLabel.Name = "DetDebMatLabel"
        DetDebMatLabel.Size = New System.Drawing.Size(54, 17)
        DetDebMatLabel.TabIndex = 5
        DetDebMatLabel.Text = "Detalle"
        '
        'ImpDebMatLabel
        '
        ImpDebMatLabel.AutoSize = True
        ImpDebMatLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImpDebMatLabel.ForeColor = System.Drawing.Color.White
        ImpDebMatLabel.Location = New System.Drawing.Point(408, 92)
        ImpDebMatLabel.Name = "ImpDebMatLabel"
        ImpDebMatLabel.Size = New System.Drawing.Size(36, 17)
        ImpDebMatLabel.TabIndex = 6
        ImpDebMatLabel.Text = "Kilos"
        '
        'CategDebMatLabel
        '
        CategDebMatLabel.AutoSize = True
        CategDebMatLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategDebMatLabel.ForeColor = System.Drawing.Color.White
        CategDebMatLabel.Location = New System.Drawing.Point(501, 92)
        CategDebMatLabel.Name = "CategDebMatLabel"
        CategDebMatLabel.Size = New System.Drawing.Size(75, 17)
        CategDebMatLabel.TabIndex = 7
        CategDebMatLabel.Text = "Categoría"
        '
        'txtSociedad
        '
        Me.txtSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSociedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSociedad.ForeColor = System.Drawing.Color.White
        Me.txtSociedad.Location = New System.Drawing.Point(118, 63)
        Me.txtSociedad.Name = "txtSociedad"
        Me.txtSociedad.Size = New System.Drawing.Size(66, 23)
        Me.txtSociedad.TabIndex = 1
        '
        'txtNombSociedad
        '
        Me.txtNombSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombSociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombSociedad.Enabled = False
        Me.txtNombSociedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombSociedad.ForeColor = System.Drawing.Color.White
        Me.txtNombSociedad.Location = New System.Drawing.Point(190, 63)
        Me.txtNombSociedad.Name = "txtNombSociedad"
        Me.txtNombSociedad.Size = New System.Drawing.Size(413, 23)
        Me.txtNombSociedad.TabIndex = 2
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(646, 181)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(119, 44)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvDebitoSoc
        '
        Me.dgvDebitoSoc.AllowUserToAddRows = False
        Me.dgvDebitoSoc.AllowUserToDeleteRows = False
        Me.dgvDebitoSoc.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvDebitoSoc.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDebitoSoc.AutoGenerateColumns = False
        Me.dgvDebitoSoc.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvDebitoSoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDebitoSoc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDebitoSoc.ColumnHeadersHeight = 30
        Me.dgvDebitoSoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDebitoSoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SocDebSocDataGridViewTextBoxColumn, Me.CodDebSocDataGridViewTextBoxColumn, Me.DetalleDebSocDataGridViewTextBoxColumn, Me.KgDebSocDataGridViewTextBoxColumn, Me.CategDebSoc})
        Me.dgvDebitoSoc.DataSource = Me.DebitosocBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDebitoSoc.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDebitoSoc.EnableHeadersVisualStyles = False
        Me.dgvDebitoSoc.GridColor = System.Drawing.Color.White
        Me.dgvDebitoSoc.Location = New System.Drawing.Point(17, 156)
        Me.dgvDebitoSoc.Name = "dgvDebitoSoc"
        Me.dgvDebitoSoc.ReadOnly = True
        Me.dgvDebitoSoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDebitoSoc.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDebitoSoc.Size = New System.Drawing.Size(611, 345)
        Me.dgvDebitoSoc.TabIndex = 17
        '
        'SocDebSocDataGridViewTextBoxColumn
        '
        Me.SocDebSocDataGridViewTextBoxColumn.DataPropertyName = "SocDebSoc"
        Me.SocDebSocDataGridViewTextBoxColumn.HeaderText = "SocDebSoc"
        Me.SocDebSocDataGridViewTextBoxColumn.Name = "SocDebSocDataGridViewTextBoxColumn"
        Me.SocDebSocDataGridViewTextBoxColumn.ReadOnly = True
        Me.SocDebSocDataGridViewTextBoxColumn.Visible = False
        '
        'CodDebSocDataGridViewTextBoxColumn
        '
        Me.CodDebSocDataGridViewTextBoxColumn.DataPropertyName = "CodDebSoc"
        Me.CodDebSocDataGridViewTextBoxColumn.HeaderText = "CÓDIGO"
        Me.CodDebSocDataGridViewTextBoxColumn.Name = "CodDebSocDataGridViewTextBoxColumn"
        Me.CodDebSocDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodDebSocDataGridViewTextBoxColumn.Width = 65
        '
        'DetalleDebSocDataGridViewTextBoxColumn
        '
        Me.DetalleDebSocDataGridViewTextBoxColumn.DataPropertyName = "DetalleDebSoc"
        Me.DetalleDebSocDataGridViewTextBoxColumn.HeaderText = "DETALLE"
        Me.DetalleDebSocDataGridViewTextBoxColumn.Name = "DetalleDebSocDataGridViewTextBoxColumn"
        Me.DetalleDebSocDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleDebSocDataGridViewTextBoxColumn.Width = 300
        '
        'KgDebSocDataGridViewTextBoxColumn
        '
        Me.KgDebSocDataGridViewTextBoxColumn.DataPropertyName = "KgDebSoc"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.KgDebSocDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.KgDebSocDataGridViewTextBoxColumn.HeaderText = "KILOS"
        Me.KgDebSocDataGridViewTextBoxColumn.Name = "KgDebSocDataGridViewTextBoxColumn"
        Me.KgDebSocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategDebSoc
        '
        Me.CategDebSoc.DataPropertyName = "CategDebSoc"
        Me.CategDebSoc.HeaderText = "CATEGORIA"
        Me.CategDebSoc.Name = "CategDebSoc"
        Me.CategDebSoc.ReadOnly = True
        '
        'DebitosocBindingSource
        '
        Me.DebitosocBindingSource.DataMember = "debitosoc"
        Me.DebitosocBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sociedad:"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.boletasTableAdapter = Nothing
        Me.TableAdapterManager.coddebitoTableAdapter = Nothing
        Me.TableAdapterManager.codpostalTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ctactematTableAdapter = Nothing
        Me.TableAdapterManager.ctacteprovTableAdapter = Nothing
        Me.TableAdapterManager.ctactesocTableAdapter = Nothing
        Me.TableAdapterManager.debitomatriTableAdapter = Nothing
        Me.TableAdapterManager.debitosocTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotebancoTableAdapter = Nothing
        Me.TableAdapterManager.matriculadosTableAdapter = Nothing
        Me.TableAdapterManager.nivelesTableAdapter = Nothing
        Me.TableAdapterManager.sociedadesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'txtSocDebSoc
        '
        Me.txtSocDebSoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSocDebSoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSocDebSoc.Enabled = False
        Me.txtSocDebSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSocDebSoc.Location = New System.Drawing.Point(640, 115)
        Me.txtSocDebSoc.Name = "txtSocDebSoc"
        Me.txtSocDebSoc.Size = New System.Drawing.Size(41, 16)
        Me.txtSocDebSoc.TabIndex = 12
        Me.txtSocDebSoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodDebSoc
        '
        Me.txtCodDebSoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCodDebSoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDebSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodDebSoc.ForeColor = System.Drawing.Color.White
        Me.txtCodDebSoc.Location = New System.Drawing.Point(24, 113)
        Me.txtCodDebSoc.Name = "txtCodDebSoc"
        Me.txtCodDebSoc.Size = New System.Drawing.Size(55, 23)
        Me.txtCodDebSoc.TabIndex = 8
        '
        'txtDetDebSoc
        '
        Me.txtDetDebSoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDetDebSoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetDebSoc.Enabled = False
        Me.txtDetDebSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetDebSoc.ForeColor = System.Drawing.Color.White
        Me.txtDetDebSoc.Location = New System.Drawing.Point(85, 113)
        Me.txtDetDebSoc.Name = "txtDetDebSoc"
        Me.txtDetDebSoc.Size = New System.Drawing.Size(285, 23)
        Me.txtDetDebSoc.TabIndex = 9
        '
        'txtKgDebSoc
        '
        Me.txtKgDebSoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtKgDebSoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKgDebSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgDebSoc.ForeColor = System.Drawing.Color.White
        Me.txtKgDebSoc.Location = New System.Drawing.Point(376, 113)
        Me.txtKgDebSoc.Name = "txtKgDebSoc"
        Me.txtKgDebSoc.Size = New System.Drawing.Size(96, 23)
        Me.txtKgDebSoc.TabIndex = 10
        Me.txtKgDebSoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCategDebSoc
        '
        Me.txtCategDebSoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCategDebSoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategDebSoc.Enabled = False
        Me.txtCategDebSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategDebSoc.ForeColor = System.Drawing.Color.White
        Me.txtCategDebSoc.Location = New System.Drawing.Point(478, 113)
        Me.txtCategDebSoc.Name = "txtCategDebSoc"
        Me.txtCategDebSoc.Size = New System.Drawing.Size(125, 23)
        Me.txtCategDebSoc.TabIndex = 11
        Me.txtCategDebSoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(646, 309)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(119, 44)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(646, 245)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(119, 44)
        Me.btnActualizar.TabIndex = 14
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(637, 156)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(138, 345)
        Me.PictureBox4.TabIndex = 33
        Me.PictureBox4.TabStop = False
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
        Me.btnLimpiar.Location = New System.Drawing.Point(646, 373)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(119, 44)
        Me.btnLimpiar.TabIndex = 16
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(107, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(456, 36)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Cargar Débitos de Sociedades"
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
        Me.btnSalir.Location = New System.Drawing.Point(646, 437)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(119, 44)
        Me.btnSalir.TabIndex = 86
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(17, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(611, 96)
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'DebitosocTableAdapter
        '
        Me.DebitosocTableAdapter.ClearBeforeFill = True
        '
        'frmCargarDebSoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 567)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSocDebSoc)
        Me.Controls.Add(CodDebMatLabel)
        Me.Controls.Add(Me.txtCodDebSoc)
        Me.Controls.Add(DetDebMatLabel)
        Me.Controls.Add(Me.txtDetDebSoc)
        Me.Controls.Add(ImpDebMatLabel)
        Me.Controls.Add(Me.txtKgDebSoc)
        Me.Controls.Add(CategDebMatLabel)
        Me.Controls.Add(Me.txtCategDebSoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDebitoSoc)
        Me.Controls.Add(Me.txtNombSociedad)
        Me.Controls.Add(Me.txtSociedad)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCargarDebSoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZACIÓN DE DÉBITOS A SOCIEDADES"
        CType(Me.dgvDebitoSoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DebitosocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSociedad As TextBox
    Friend WithEvents txtNombSociedad As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvDebitoSoc As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtSocDebSoc As TextBox
    Friend WithEvents txtCodDebSoc As TextBox
    Friend WithEvents txtDetDebSoc As TextBox
    Friend WithEvents txtKgDebSoc As TextBox
    Friend WithEvents txtCategDebSoc As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DebitosocBindingSource As BindingSource
    Friend WithEvents DebitosocTableAdapter As dbcolmartDataSetTableAdapters.debitosocTableAdapter
    Friend WithEvents ObsDebSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SocDebSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodDebSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleDebSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KgDebSocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategDebSoc As DataGridViewTextBoxColumn
End Class

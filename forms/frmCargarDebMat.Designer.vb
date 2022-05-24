<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCargarDebMat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargarDebMat))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.txtApelNombre = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvDebitoMat = New System.Windows.Forms.DataGridView()
        Me.MatDebMatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodDebMatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetDebMatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpDebMatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategDebMatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitomatriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DebitomatriTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.debitomatriTableAdapter()
        Me.TableAdapterManager = New ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager()
        Me.txtMatDebMat = New System.Windows.Forms.TextBox()
        Me.txtCodDebMat = New System.Windows.Forms.TextBox()
        Me.txtDetDebMat = New System.Windows.Forms.TextBox()
        Me.txtImpDebMat = New System.Windows.Forms.TextBox()
        Me.txtCategDebMat = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CodDebMatLabel = New System.Windows.Forms.Label()
        DetDebMatLabel = New System.Windows.Forms.Label()
        ImpDebMatLabel = New System.Windows.Forms.Label()
        CategDebMatLabel = New System.Windows.Forms.Label()
        CType(Me.dgvDebitoMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DebitomatriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        ImpDebMatLabel.Location = New System.Drawing.Point(393, 92)
        ImpDebMatLabel.Name = "ImpDebMatLabel"
        ImpDebMatLabel.Size = New System.Drawing.Size(59, 17)
        ImpDebMatLabel.TabIndex = 6
        ImpDebMatLabel.Text = "Importe"
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
        'txtMatricula
        '
        Me.txtMatricula.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMatricula.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.ForeColor = System.Drawing.Color.White
        Me.txtMatricula.Location = New System.Drawing.Point(118, 63)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(66, 23)
        Me.txtMatricula.TabIndex = 1
        '
        'txtApelNombre
        '
        Me.txtApelNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtApelNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApelNombre.Enabled = False
        Me.txtApelNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApelNombre.ForeColor = System.Drawing.Color.White
        Me.txtApelNombre.Location = New System.Drawing.Point(190, 63)
        Me.txtApelNombre.Name = "txtApelNombre"
        Me.txtApelNombre.Size = New System.Drawing.Size(413, 23)
        Me.txtApelNombre.TabIndex = 2
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
        Me.btnAgregar.Location = New System.Drawing.Point(628, 181)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(119, 44)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvDebitoMat
        '
        Me.dgvDebitoMat.AllowUserToAddRows = False
        Me.dgvDebitoMat.AllowUserToDeleteRows = False
        Me.dgvDebitoMat.AllowUserToOrderColumns = True
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dgvDebitoMat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDebitoMat.AutoGenerateColumns = False
        Me.dgvDebitoMat.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvDebitoMat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDebitoMat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvDebitoMat.ColumnHeadersHeight = 30
        Me.dgvDebitoMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDebitoMat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatDebMatDataGridViewTextBoxColumn, Me.CodDebMatDataGridViewTextBoxColumn, Me.DetDebMatDataGridViewTextBoxColumn, Me.ImpDebMatDataGridViewTextBoxColumn, Me.CategDebMatDataGridViewTextBoxColumn})
        Me.dgvDebitoMat.DataSource = Me.DebitomatriBindingSource
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDebitoMat.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvDebitoMat.EnableHeadersVisualStyles = False
        Me.dgvDebitoMat.GridColor = System.Drawing.Color.White
        Me.dgvDebitoMat.Location = New System.Drawing.Point(17, 156)
        Me.dgvDebitoMat.Name = "dgvDebitoMat"
        Me.dgvDebitoMat.ReadOnly = True
        Me.dgvDebitoMat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDebitoMat.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvDebitoMat.Size = New System.Drawing.Size(591, 345)
        Me.dgvDebitoMat.TabIndex = 17
        '
        'MatDebMatDataGridViewTextBoxColumn
        '
        Me.MatDebMatDataGridViewTextBoxColumn.DataPropertyName = "MatDebMat"
        Me.MatDebMatDataGridViewTextBoxColumn.HeaderText = "MatDebMat"
        Me.MatDebMatDataGridViewTextBoxColumn.Name = "MatDebMatDataGridViewTextBoxColumn"
        Me.MatDebMatDataGridViewTextBoxColumn.ReadOnly = True
        Me.MatDebMatDataGridViewTextBoxColumn.Visible = False
        '
        'CodDebMatDataGridViewTextBoxColumn
        '
        Me.CodDebMatDataGridViewTextBoxColumn.DataPropertyName = "CodDebMat"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CodDebMatDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.CodDebMatDataGridViewTextBoxColumn.HeaderText = "CODIGO"
        Me.CodDebMatDataGridViewTextBoxColumn.Name = "CodDebMatDataGridViewTextBoxColumn"
        Me.CodDebMatDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodDebMatDataGridViewTextBoxColumn.Width = 65
        '
        'DetDebMatDataGridViewTextBoxColumn
        '
        Me.DetDebMatDataGridViewTextBoxColumn.DataPropertyName = "DetDebMat"
        Me.DetDebMatDataGridViewTextBoxColumn.HeaderText = "DETALLE"
        Me.DetDebMatDataGridViewTextBoxColumn.Name = "DetDebMatDataGridViewTextBoxColumn"
        Me.DetDebMatDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetDebMatDataGridViewTextBoxColumn.Width = 300
        '
        'ImpDebMatDataGridViewTextBoxColumn
        '
        Me.ImpDebMatDataGridViewTextBoxColumn.DataPropertyName = "ImpDebMat"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.ImpDebMatDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.ImpDebMatDataGridViewTextBoxColumn.HeaderText = "IMPORTE"
        Me.ImpDebMatDataGridViewTextBoxColumn.Name = "ImpDebMatDataGridViewTextBoxColumn"
        Me.ImpDebMatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategDebMatDataGridViewTextBoxColumn
        '
        Me.CategDebMatDataGridViewTextBoxColumn.DataPropertyName = "CategDebMat"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CategDebMatDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.CategDebMatDataGridViewTextBoxColumn.HeaderText = "CATEGORIA"
        Me.CategDebMatDataGridViewTextBoxColumn.Name = "CategDebMatDataGridViewTextBoxColumn"
        Me.CategDebMatDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategDebMatDataGridViewTextBoxColumn.Width = 80
        '
        'DebitomatriBindingSource
        '
        Me.DebitomatriBindingSource.DataMember = "debitomatri"
        Me.DebitomatriBindingSource.DataSource = Me.DbcolmartDataSet
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
        Me.Label1.Location = New System.Drawing.Point(22, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matriculado:"
        '
        'DebitomatriTableAdapter
        '
        Me.DebitomatriTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.boletasTableAdapter = Nothing
        Me.TableAdapterManager.cajaTableAdapter = Nothing
        Me.TableAdapterManager.coddebitoTableAdapter = Nothing
        Me.TableAdapterManager.codpostalTableAdapter = Nothing
        Me.TableAdapterManager.comprobteTableAdapter = Nothing
        Me.TableAdapterManager.ctactematTableAdapter = Nothing
        Me.TableAdapterManager.ctacteprovTableAdapter = Nothing
        Me.TableAdapterManager.ctactesocTableAdapter = Nothing
        Me.TableAdapterManager.debitomatriTableAdapter = Me.DebitomatriTableAdapter
        Me.TableAdapterManager.debitosocTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotebancoTableAdapter = Nothing
        Me.TableAdapterManager.matriculadosTableAdapter = Nothing
        Me.TableAdapterManager.nivelesTableAdapter = Nothing
        Me.TableAdapterManager.saldomatTableAdapter = Nothing
        Me.TableAdapterManager.saldosocTableAdapter = Nothing
        Me.TableAdapterManager.sociedadesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'txtMatDebMat
        '
        Me.txtMatDebMat.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMatDebMat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMatDebMat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DebitomatriBindingSource, "MatDebMat", True))
        Me.txtMatDebMat.Enabled = False
        Me.txtMatDebMat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatDebMat.Location = New System.Drawing.Point(619, 115)
        Me.txtMatDebMat.Name = "txtMatDebMat"
        Me.txtMatDebMat.Size = New System.Drawing.Size(28, 16)
        Me.txtMatDebMat.TabIndex = 12
        Me.txtMatDebMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodDebMat
        '
        Me.txtCodDebMat.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCodDebMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDebMat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodDebMat.ForeColor = System.Drawing.Color.White
        Me.txtCodDebMat.Location = New System.Drawing.Point(24, 113)
        Me.txtCodDebMat.Name = "txtCodDebMat"
        Me.txtCodDebMat.Size = New System.Drawing.Size(55, 23)
        Me.txtCodDebMat.TabIndex = 8
        '
        'txtDetDebMat
        '
        Me.txtDetDebMat.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDetDebMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetDebMat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DebitomatriBindingSource, "DetDebMat", True))
        Me.txtDetDebMat.Enabled = False
        Me.txtDetDebMat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetDebMat.ForeColor = System.Drawing.Color.White
        Me.txtDetDebMat.Location = New System.Drawing.Point(85, 113)
        Me.txtDetDebMat.Name = "txtDetDebMat"
        Me.txtDetDebMat.Size = New System.Drawing.Size(285, 23)
        Me.txtDetDebMat.TabIndex = 9
        '
        'txtImpDebMat
        '
        Me.txtImpDebMat.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtImpDebMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImpDebMat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpDebMat.ForeColor = System.Drawing.Color.White
        Me.txtImpDebMat.Location = New System.Drawing.Point(376, 113)
        Me.txtImpDebMat.Name = "txtImpDebMat"
        Me.txtImpDebMat.Size = New System.Drawing.Size(96, 23)
        Me.txtImpDebMat.TabIndex = 10
        Me.txtImpDebMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCategDebMat
        '
        Me.txtCategDebMat.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCategDebMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategDebMat.Enabled = False
        Me.txtCategDebMat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategDebMat.ForeColor = System.Drawing.Color.White
        Me.txtCategDebMat.Location = New System.Drawing.Point(478, 113)
        Me.txtCategDebMat.Name = "txtCategDebMat"
        Me.txtCategDebMat.Size = New System.Drawing.Size(125, 23)
        Me.txtCategDebMat.TabIndex = 11
        Me.txtCategDebMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnEliminar.Location = New System.Drawing.Point(628, 309)
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
        Me.btnActualizar.Location = New System.Drawing.Point(628, 245)
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
        Me.PictureBox4.Location = New System.Drawing.Point(619, 156)
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
        Me.btnLimpiar.Location = New System.Drawing.Point(628, 373)
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
        Me.Label2.Size = New System.Drawing.Size(476, 36)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Cargar Débitos de Matriculados"
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
        Me.btnSalir.Location = New System.Drawing.Point(628, 437)
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
        Me.PictureBox1.Size = New System.Drawing.Size(596, 96)
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'frmCargarDebMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(789, 567)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMatDebMat)
        Me.Controls.Add(CodDebMatLabel)
        Me.Controls.Add(Me.txtCodDebMat)
        Me.Controls.Add(DetDebMatLabel)
        Me.Controls.Add(Me.txtDetDebMat)
        Me.Controls.Add(ImpDebMatLabel)
        Me.Controls.Add(Me.txtImpDebMat)
        Me.Controls.Add(CategDebMatLabel)
        Me.Controls.Add(Me.txtCategDebMat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDebitoMat)
        Me.Controls.Add(Me.txtApelNombre)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCargarDebMat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZACIÓN DE DÉBITOS A MATRICULADOS"
        CType(Me.dgvDebitoMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DebitomatriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents txtApelNombre As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvDebitoMat As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents DebitomatriBindingSource As BindingSource
    Friend WithEvents DebitomatriTableAdapter As dbcolmartDataSetTableAdapters.debitomatriTableAdapter
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtMatDebMat As TextBox
    Friend WithEvents txtCodDebMat As TextBox
    Friend WithEvents txtDetDebMat As TextBox
    Friend WithEvents txtImpDebMat As TextBox
    Friend WithEvents txtCategDebMat As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MatDebMatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodDebMatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetDebMatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpDebMatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategDebMatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

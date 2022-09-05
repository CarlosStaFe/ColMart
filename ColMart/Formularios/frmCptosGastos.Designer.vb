<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCptosGastos
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
        Dim DetalleCGLabel As System.Windows.Forms.Label
        Dim ObsCGLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCptosGastos))
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.CptosgastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CptosgastosTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.cptosgastosTableAdapter()
        Me.TableAdapterManager = New ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager()
        Me.txtId_CG = New System.Windows.Forms.TextBox()
        Me.txtDetalleCG = New System.Windows.Forms.TextBox()
        Me.txtObsCG = New System.Windows.Forms.TextBox()
        Me.dgvObras = New System.Windows.Forms.DataGridView()
        Me.IdCGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleCGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CptosgastosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CptosgastosBindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CptosgastosBindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviusItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CptosgastosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        DetalleCGLabel = New System.Windows.Forms.Label()
        ObsCGLabel = New System.Windows.Forms.Label()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CptosgastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvObras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CptosgastosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CptosgastosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DetalleCGLabel
        '
        DetalleCGLabel.AutoSize = True
        DetalleCGLabel.Location = New System.Drawing.Point(92, 60)
        DetalleCGLabel.Name = "DetalleCGLabel"
        DetalleCGLabel.Size = New System.Drawing.Size(65, 17)
        DetalleCGLabel.TabIndex = 3
        DetalleCGLabel.Text = "Nombre:"
        '
        'ObsCGLabel
        '
        ObsCGLabel.AutoSize = True
        ObsCGLabel.Location = New System.Drawing.Point(63, 89)
        ObsCGLabel.Name = "ObsCGLabel"
        ObsCGLabel.Size = New System.Drawing.Size(94, 17)
        ObsCGLabel.TabIndex = 5
        ObsCGLabel.Text = "Observación:"
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CptosgastosBindingSource
        '
        Me.CptosgastosBindingSource.DataMember = "cptosgastos"
        Me.CptosgastosBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'CptosgastosTableAdapter
        '
        Me.CptosgastosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bibliotecaTableAdapter = Nothing
        Me.TableAdapterManager.boletasTableAdapter = Nothing
        Me.TableAdapterManager.botonesTableAdapter = Nothing
        Me.TableAdapterManager.botonuserTableAdapter = Nothing
        Me.TableAdapterManager.cajamayorTableAdapter = Nothing
        Me.TableAdapterManager.cajaTableAdapter = Nothing
        Me.TableAdapterManager.categivaTableAdapter = Nothing
        Me.TableAdapterManager.coddebitoTableAdapter = Nothing
        Me.TableAdapterManager.codpostalTableAdapter = Nothing
        Me.TableAdapterManager.colegiadosTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.comprobteTableAdapter = Nothing
        Me.TableAdapterManager.cptosgastosTableAdapter = Me.CptosgastosTableAdapter
        Me.TableAdapterManager.ctacteproTableAdapter = Nothing
        Me.TableAdapterManager.ctasctesTableAdapter = Nothing
        Me.TableAdapterManager.debehaberTableAdapter = Nothing
        Me.TableAdapterManager.debitomatriTableAdapter = Nothing
        Me.TableAdapterManager.debitosocTableAdapter = Nothing
        Me.TableAdapterManager.departamentoTableAdapter = Nothing
        Me.TableAdapterManager.depositosTableAdapter = Nothing
        Me.TableAdapterManager.detallecpraTableAdapter = Nothing
        Me.TableAdapterManager.fianzasTableAdapter = Nothing
        Me.TableAdapterManager.impctacteTableAdapter = Nothing
        Me.TableAdapterManager.juzgadosTableAdapter = Nothing
        Me.TableAdapterManager.listaoficioTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.localidadTableAdapter = Nothing
        Me.TableAdapterManager.lotebancoTableAdapter = Nothing
        Me.TableAdapterManager.matriculadosTableAdapter = Nothing
        Me.TableAdapterManager.mesaentradaTableAdapter = Nothing
        Me.TableAdapterManager.nivelesTableAdapter = Nothing
        Me.TableAdapterManager.padronTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.provinciaTableAdapter = Nothing
        Me.TableAdapterManager.reciboTableAdapter = Nothing
        Me.TableAdapterManager.renglonesTableAdapter = Nothing
        Me.TableAdapterManager.saldomatTableAdapter = Nothing
        Me.TableAdapterManager.saldosocTableAdapter = Nothing
        Me.TableAdapterManager.sociedadesTableAdapter = Nothing
        Me.TableAdapterManager.tribunalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'txtId_CG
        '
        Me.txtId_CG.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_CG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_CG.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CptosgastosBindingSource, "id_CG", True))
        Me.txtId_CG.ForeColor = System.Drawing.Color.White
        Me.txtId_CG.Location = New System.Drawing.Point(570, 59)
        Me.txtId_CG.Name = "txtId_CG"
        Me.txtId_CG.Size = New System.Drawing.Size(68, 16)
        Me.txtId_CG.TabIndex = 2
        '
        'txtDetalleCG
        '
        Me.txtDetalleCG.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDetalleCG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalleCG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalleCG.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CptosgastosBindingSource, "DetalleCG", True))
        Me.txtDetalleCG.ForeColor = System.Drawing.Color.White
        Me.txtDetalleCG.Location = New System.Drawing.Point(163, 57)
        Me.txtDetalleCG.Name = "txtDetalleCG"
        Me.txtDetalleCG.Size = New System.Drawing.Size(364, 23)
        Me.txtDetalleCG.TabIndex = 4
        '
        'txtObsCG
        '
        Me.txtObsCG.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObsCG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsCG.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CptosgastosBindingSource, "ObsCG", True))
        Me.txtObsCG.ForeColor = System.Drawing.Color.White
        Me.txtObsCG.Location = New System.Drawing.Point(163, 86)
        Me.txtObsCG.Name = "txtObsCG"
        Me.txtObsCG.Size = New System.Drawing.Size(522, 23)
        Me.txtObsCG.TabIndex = 6
        '
        'dgvObras
        '
        Me.dgvObras.AllowUserToAddRows = False
        Me.dgvObras.AllowUserToDeleteRows = False
        Me.dgvObras.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvObras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvObras.AutoGenerateColumns = False
        Me.dgvObras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvObras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvObras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvObras.ColumnHeadersHeight = 30
        Me.dgvObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvObras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCGDataGridViewTextBoxColumn, Me.DetalleCGDataGridViewTextBoxColumn, Me.ObsCGDataGridViewTextBoxColumn})
        Me.dgvObras.DataSource = Me.CptosgastosBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvObras.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvObras.EnableHeadersVisualStyles = False
        Me.dgvObras.GridColor = System.Drawing.Color.White
        Me.dgvObras.Location = New System.Drawing.Point(52, 126)
        Me.dgvObras.Name = "dgvObras"
        Me.dgvObras.ReadOnly = True
        Me.dgvObras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvObras.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvObras.Size = New System.Drawing.Size(649, 367)
        Me.dgvObras.TabIndex = 105
        '
        'IdCGDataGridViewTextBoxColumn
        '
        Me.IdCGDataGridViewTextBoxColumn.DataPropertyName = "id_CG"
        Me.IdCGDataGridViewTextBoxColumn.HeaderText = "id_CG"
        Me.IdCGDataGridViewTextBoxColumn.Name = "IdCGDataGridViewTextBoxColumn"
        Me.IdCGDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCGDataGridViewTextBoxColumn.Visible = False
        '
        'DetalleCGDataGridViewTextBoxColumn
        '
        Me.DetalleCGDataGridViewTextBoxColumn.DataPropertyName = "DetalleCG"
        Me.DetalleCGDataGridViewTextBoxColumn.HeaderText = "NOMBRE CONCEPTO"
        Me.DetalleCGDataGridViewTextBoxColumn.Name = "DetalleCGDataGridViewTextBoxColumn"
        Me.DetalleCGDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleCGDataGridViewTextBoxColumn.Width = 300
        '
        'ObsCGDataGridViewTextBoxColumn
        '
        Me.ObsCGDataGridViewTextBoxColumn.DataPropertyName = "ObsCG"
        Me.ObsCGDataGridViewTextBoxColumn.HeaderText = "OBSERVACIÓN"
        Me.ObsCGDataGridViewTextBoxColumn.Name = "ObsCGDataGridViewTextBoxColumn"
        Me.ObsCGDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsCGDataGridViewTextBoxColumn.Width = 300
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(100, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(576, 36)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Actualización de Conceptos de Gastos"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(52, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(649, 72)
        Me.PictureBox2.TabIndex = 151
        Me.PictureBox2.TabStop = False
        '
        'CptosgastosBindingNavigator
        '
        Me.CptosgastosBindingNavigator.AddNewItem = Me.CptosgastosBindingNavigatorAddNewItem
        Me.CptosgastosBindingNavigator.AutoSize = False
        Me.CptosgastosBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CptosgastosBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CptosgastosBindingNavigator.BindingSource = Me.CptosgastosBindingSource
        Me.CptosgastosBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.CptosgastosBindingNavigator.DeleteItem = Me.CptosgastosBindingNavigatorDeleteItem
        Me.CptosgastosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.CptosgastosBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CptosgastosBindingNavigator.GripMargin = New System.Windows.Forms.Padding(0)
        Me.CptosgastosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CptosgastosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.BindingNavigatorMovePreviusItem, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.CptosgastosBindingNavigatorAddNewItem, Me.ToolStripSeparator4, Me.CptosgastosBindingNavigatorDeleteItem, Me.ToolStripSeparator5, Me.CptosgastosBindingNavigatorSaveItem, Me.ToolStripSeparator6, Me.btnSalir})
        Me.CptosgastosBindingNavigator.Location = New System.Drawing.Point(66, 507)
        Me.CptosgastosBindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.CptosgastosBindingNavigator.MoveLastItem = Me.ToolStripButton3
        Me.CptosgastosBindingNavigator.MoveNextItem = Me.ToolStripButton2
        Me.CptosgastosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviusItem
        Me.CptosgastosBindingNavigator.Name = "CptosgastosBindingNavigator"
        Me.CptosgastosBindingNavigator.Padding = New System.Windows.Forms.Padding(0)
        Me.CptosgastosBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.CptosgastosBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CptosgastosBindingNavigator.Size = New System.Drawing.Size(635, 40)
        Me.CptosgastosBindingNavigator.TabIndex = 152
        Me.CptosgastosBindingNavigator.Text = "BindingNavigator"
        '
        'CptosgastosBindingNavigatorAddNewItem
        '
        Me.CptosgastosBindingNavigatorAddNewItem.Image = CType(resources.GetObject("CptosgastosBindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.CptosgastosBindingNavigatorAddNewItem.Name = "CptosgastosBindingNavigatorAddNewItem"
        Me.CptosgastosBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.CptosgastosBindingNavigatorAddNewItem.Size = New System.Drawing.Size(87, 37)
        Me.CptosgastosBindingNavigatorAddNewItem.Text = "Agregar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(48, 37)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Número total de elementos"
        '
        'CptosgastosBindingNavigatorDeleteItem
        '
        Me.CptosgastosBindingNavigatorDeleteItem.Image = CType(resources.GetObject("CptosgastosBindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.CptosgastosBindingNavigatorDeleteItem.Name = "CptosgastosBindingNavigatorDeleteItem"
        Me.CptosgastosBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.CptosgastosBindingNavigatorDeleteItem.Size = New System.Drawing.Size(87, 37)
        Me.CptosgastosBindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(24, 37)
        Me.ToolStripButton1.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviusItem
        '
        Me.BindingNavigatorMovePreviusItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviusItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviusItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviusItem.Name = "BindingNavigatorMovePreviusItem"
        Me.BindingNavigatorMovePreviusItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviusItem.Size = New System.Drawing.Size(24, 37)
        Me.BindingNavigatorMovePreviusItem.Text = "Mover anterior"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posición"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.ForeColor = System.Drawing.Color.White
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 25)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 40)
        Me.ToolStripSeparator2.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(24, 37)
        Me.ToolStripButton2.Text = "Mover siguiente"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(24, 37)
        Me.ToolStripButton3.Text = "Mover último"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 34)
        '
        'CptosgastosBindingNavigatorSaveItem
        '
        Me.CptosgastosBindingNavigatorSaveItem.Image = CType(resources.GetObject("CptosgastosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CptosgastosBindingNavigatorSaveItem.Name = "CptosgastosBindingNavigatorSaveItem"
        Me.CptosgastosBindingNavigatorSaveItem.Size = New System.Drawing.Size(86, 37)
        Me.CptosgastosBindingNavigatorSaveItem.Text = "Guardar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 34)
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(62, 37)
        Me.btnSalir.Text = "Salir"
        '
        'frmCptosGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(770, 575)
        Me.Controls.Add(Me.CptosgastosBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvObras)
        Me.Controls.Add(Me.txtId_CG)
        Me.Controls.Add(DetalleCGLabel)
        Me.Controls.Add(Me.txtDetalleCG)
        Me.Controls.Add(ObsCGLabel)
        Me.Controls.Add(Me.txtObsCG)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCptosGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARGA DE CONCEPTOS DE GASTOS"
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CptosgastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvObras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CptosgastosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CptosgastosBindingNavigator.ResumeLayout(False)
        Me.CptosgastosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents CptosgastosBindingSource As BindingSource
    Friend WithEvents CptosgastosTableAdapter As dbcolmartDataSetTableAdapters.cptosgastosTableAdapter
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtId_CG As TextBox
    Friend WithEvents txtDetalleCG As TextBox
    Friend WithEvents txtObsCG As TextBox
    Friend WithEvents dgvObras As DataGridView
    Friend WithEvents IdCGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleCGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsCGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CptosgastosBindingNavigator As BindingNavigator
    Friend WithEvents CptosgastosBindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents CptosgastosBindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviusItem As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents CptosgastosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents btnSalir As ToolStripButton
End Class

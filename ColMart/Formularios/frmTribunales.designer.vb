<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTribunales
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
        Dim SedeTribuLabel As System.Windows.Forms.Label
        Dim ObsTribuLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTribunales))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.TribunalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TribunalesTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.tribunalesTableAdapter()
        Me.TableAdapterManager = New ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager()
        Me.TribunalesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TribunalesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.dgvTribunales = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_TribuTextBox = New System.Windows.Forms.TextBox()
        Me.txtSedeTribu = New System.Windows.Forms.TextBox()
        Me.cbxDistritoTribu = New System.Windows.Forms.CheckBox()
        Me.cbxCircuitoTribu = New System.Windows.Forms.CheckBox()
        Me.cbxTasacionesTribu = New System.Windows.Forms.CheckBox()
        Me.cbxConcursalesTribu = New System.Windows.Forms.CheckBox()
        Me.txtObsTribu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        SedeTribuLabel = New System.Windows.Forms.Label()
        ObsTribuLabel = New System.Windows.Forms.Label()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TribunalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TribunalesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TribunalesBindingNavigator.SuspendLayout()
        CType(Me.dgvTribunales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SedeTribuLabel
        '
        SedeTribuLabel.AutoSize = True
        SedeTribuLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SedeTribuLabel.ForeColor = System.Drawing.Color.DarkOrange
        SedeTribuLabel.Location = New System.Drawing.Point(34, 66)
        SedeTribuLabel.Name = "SedeTribuLabel"
        SedeTribuLabel.Size = New System.Drawing.Size(104, 20)
        SedeTribuLabel.TabIndex = 4
        SedeTribuLabel.Text = "Sede Tribunal"
        '
        'ObsTribuLabel
        '
        ObsTribuLabel.AutoSize = True
        ObsTribuLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsTribuLabel.ForeColor = System.Drawing.Color.DarkOrange
        ObsTribuLabel.Location = New System.Drawing.Point(34, 119)
        ObsTribuLabel.Name = "ObsTribuLabel"
        ObsTribuLabel.Size = New System.Drawing.Size(125, 20)
        ObsTribuLabel.TabIndex = 14
        ObsTribuLabel.Text = "Observaciones:"
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TribunalesBindingSource
        '
        Me.TribunalesBindingSource.DataMember = "tribunales"
        Me.TribunalesBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'TribunalesTableAdapter
        '
        Me.TribunalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bibliotecaTableAdapter = Nothing
        Me.TableAdapterManager.boletasTableAdapter = Nothing
        Me.TableAdapterManager.cajamayorTableAdapter = Nothing
        Me.TableAdapterManager.cajaTableAdapter = Nothing
        Me.TableAdapterManager.coddebitoTableAdapter = Nothing
        Me.TableAdapterManager.codpostalTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.comprobteTableAdapter = Nothing
        Me.TableAdapterManager.ctasctesTableAdapter = Nothing
        Me.TableAdapterManager.debehaberTableAdapter = Nothing
        Me.TableAdapterManager.debitomatriTableAdapter = Nothing
        Me.TableAdapterManager.debitosocTableAdapter = Nothing
        Me.TableAdapterManager.depositosTableAdapter = Nothing
        Me.TableAdapterManager.juzgadosTableAdapter = Nothing
        Me.TableAdapterManager.listaoficioTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotebancoTableAdapter = Nothing
        Me.TableAdapterManager.matriculadosTableAdapter = Nothing
        Me.TableAdapterManager.mesaentradaTableAdapter = Nothing
        Me.TableAdapterManager.nivelesTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.renglonesTableAdapter = Nothing
        Me.TableAdapterManager.saldomatTableAdapter = Nothing
        Me.TableAdapterManager.saldosocTableAdapter = Nothing
        Me.TableAdapterManager.sociedadesTableAdapter = Nothing
        Me.TableAdapterManager.tribunalesTableAdapter = Me.TribunalesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'TribunalesBindingNavigator
        '
        Me.TribunalesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TribunalesBindingNavigator.AutoSize = False
        Me.TribunalesBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TribunalesBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TribunalesBindingNavigator.BindingSource = Me.TribunalesBindingSource
        Me.TribunalesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TribunalesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TribunalesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TribunalesBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TribunalesBindingNavigator.GripMargin = New System.Windows.Forms.Padding(0)
        Me.TribunalesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TribunalesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator2, Me.TribunalesBindingNavigatorSaveItem, Me.ToolStripSeparator3, Me.ToolStripButton1})
        Me.TribunalesBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.TribunalesBindingNavigator.Location = New System.Drawing.Point(128, 560)
        Me.TribunalesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TribunalesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TribunalesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TribunalesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TribunalesBindingNavigator.Name = "TribunalesBindingNavigator"
        Me.TribunalesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TribunalesBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TribunalesBindingNavigator.Size = New System.Drawing.Size(635, 40)
        Me.TribunalesBindingNavigator.TabIndex = 0
        Me.TribunalesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(93, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(56, 18)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(90, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.AutoSize = False
        Me.BindingNavigatorSeparator.ForeColor = System.Drawing.Color.OrangeRed
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 34)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BindingNavigatorPositionItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 25)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.AutoSize = False
        Me.BindingNavigatorSeparator1.ForeColor = System.Drawing.Color.OrangeRed
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.AutoSize = False
        Me.BindingNavigatorSeparator2.ForeColor = System.Drawing.Color.OrangeRed
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.OrangeRed
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.OrangeRed
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'TribunalesBindingNavigatorSaveItem
        '
        Me.TribunalesBindingNavigatorSaveItem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TribunalesBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.White
        Me.TribunalesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TribunalesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TribunalesBindingNavigatorSaveItem.Name = "TribunalesBindingNavigatorSaveItem"
        Me.TribunalesBindingNavigatorSaveItem.Size = New System.Drawing.Size(94, 24)
        Me.TribunalesBindingNavigatorSaveItem.Text = "Guardar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.ForeColor = System.Drawing.Color.OrangeRed
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(63, 24)
        Me.ToolStripButton1.Text = "Salir"
        '
        'dgvTribunales
        '
        Me.dgvTribunales.AllowUserToAddRows = False
        Me.dgvTribunales.AllowUserToDeleteRows = False
        Me.dgvTribunales.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTribunales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTribunales.AutoGenerateColumns = False
        Me.dgvTribunales.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvTribunales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTribunales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTribunales.ColumnHeadersHeight = 30
        Me.dgvTribunales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTribunales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewTextBoxColumn3})
        Me.dgvTribunales.DataSource = Me.TribunalesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTribunales.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTribunales.EnableHeadersVisualStyles = False
        Me.dgvTribunales.GridColor = System.Drawing.Color.White
        Me.dgvTribunales.Location = New System.Drawing.Point(26, 211)
        Me.dgvTribunales.Name = "dgvTribunales"
        Me.dgvTribunales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTribunales.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTribunales.Size = New System.Drawing.Size(898, 346)
        Me.dgvTribunales.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_Tribu"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 25
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SedeTribu"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SEDE TRIBUNAL"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "DistritoTribu"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "DISTRITO"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "CircuitoTribu"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "CIRCUITO"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "TasacionesTribu"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "TASACIONES"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "ConcursalesTribu"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "CONCURSALES"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ObsTribu"
        Me.DataGridViewTextBoxColumn3.HeaderText = "OBS."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 225
        '
        'Id_TribuTextBox
        '
        Me.Id_TribuTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Id_TribuTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Id_TribuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TribunalesBindingSource, "id_Tribu", True))
        Me.Id_TribuTextBox.Enabled = False
        Me.Id_TribuTextBox.ForeColor = System.Drawing.Color.White
        Me.Id_TribuTextBox.Location = New System.Drawing.Point(869, 123)
        Me.Id_TribuTextBox.Name = "Id_TribuTextBox"
        Me.Id_TribuTextBox.Size = New System.Drawing.Size(34, 13)
        Me.Id_TribuTextBox.TabIndex = 3
        '
        'txtSedeTribu
        '
        Me.txtSedeTribu.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSedeTribu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSedeTribu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSedeTribu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TribunalesBindingSource, "SedeTribu", True))
        Me.txtSedeTribu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSedeTribu.ForeColor = System.Drawing.Color.White
        Me.txtSedeTribu.Location = New System.Drawing.Point(37, 91)
        Me.txtSedeTribu.Name = "txtSedeTribu"
        Me.txtSedeTribu.Size = New System.Drawing.Size(301, 23)
        Me.txtSedeTribu.TabIndex = 0
        '
        'cbxDistritoTribu
        '
        Me.cbxDistritoTribu.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TribunalesBindingSource, "DistritoTribu", True))
        Me.cbxDistritoTribu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDistritoTribu.ForeColor = System.Drawing.Color.DarkOrange
        Me.cbxDistritoTribu.Location = New System.Drawing.Point(366, 89)
        Me.cbxDistritoTribu.Name = "cbxDistritoTribu"
        Me.cbxDistritoTribu.Size = New System.Drawing.Size(104, 24)
        Me.cbxDistritoTribu.TabIndex = 1
        Me.cbxDistritoTribu.Text = "Distrito"
        Me.cbxDistritoTribu.UseVisualStyleBackColor = True
        '
        'cbxCircuitoTribu
        '
        Me.cbxCircuitoTribu.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TribunalesBindingSource, "CircuitoTribu", True))
        Me.cbxCircuitoTribu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCircuitoTribu.ForeColor = System.Drawing.Color.DarkOrange
        Me.cbxCircuitoTribu.Location = New System.Drawing.Point(479, 89)
        Me.cbxCircuitoTribu.Name = "cbxCircuitoTribu"
        Me.cbxCircuitoTribu.Size = New System.Drawing.Size(104, 24)
        Me.cbxCircuitoTribu.TabIndex = 2
        Me.cbxCircuitoTribu.Text = "Circuito"
        Me.cbxCircuitoTribu.UseVisualStyleBackColor = True
        '
        'cbxTasacionesTribu
        '
        Me.cbxTasacionesTribu.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TribunalesBindingSource, "TasacionesTribu", True))
        Me.cbxTasacionesTribu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTasacionesTribu.ForeColor = System.Drawing.Color.DarkOrange
        Me.cbxTasacionesTribu.Location = New System.Drawing.Point(592, 89)
        Me.cbxTasacionesTribu.Name = "cbxTasacionesTribu"
        Me.cbxTasacionesTribu.Size = New System.Drawing.Size(104, 24)
        Me.cbxTasacionesTribu.TabIndex = 3
        Me.cbxTasacionesTribu.Text = "Tasaciones"
        Me.cbxTasacionesTribu.UseVisualStyleBackColor = True
        '
        'cbxConcursalesTribu
        '
        Me.cbxConcursalesTribu.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TribunalesBindingSource, "ConcursalesTribu", True))
        Me.cbxConcursalesTribu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxConcursalesTribu.ForeColor = System.Drawing.Color.DarkOrange
        Me.cbxConcursalesTribu.Location = New System.Drawing.Point(705, 89)
        Me.cbxConcursalesTribu.Name = "cbxConcursalesTribu"
        Me.cbxConcursalesTribu.Size = New System.Drawing.Size(106, 24)
        Me.cbxConcursalesTribu.TabIndex = 4
        Me.cbxConcursalesTribu.Text = "Concursales"
        Me.cbxConcursalesTribu.UseVisualStyleBackColor = True
        '
        'txtObsTribu
        '
        Me.txtObsTribu.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObsTribu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsTribu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TribunalesBindingSource, "ObsTribu", True))
        Me.txtObsTribu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsTribu.ForeColor = System.Drawing.Color.White
        Me.txtObsTribu.Location = New System.Drawing.Point(37, 142)
        Me.txtObsTribu.Multiline = True
        Me.txtObsTribu.Name = "txtObsTribu"
        Me.txtObsTribu.Size = New System.Drawing.Size(866, 48)
        Me.txtObsTribu.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(255, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 36)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Actualización de Tribunales"
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(26, 54)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(898, 148)
        Me.PictureBox4.TabIndex = 144
        Me.PictureBox4.TabStop = False
        '
        'frmTribunales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1048, 617)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Id_TribuTextBox)
        Me.Controls.Add(SedeTribuLabel)
        Me.Controls.Add(Me.txtSedeTribu)
        Me.Controls.Add(Me.cbxDistritoTribu)
        Me.Controls.Add(Me.cbxCircuitoTribu)
        Me.Controls.Add(Me.cbxTasacionesTribu)
        Me.Controls.Add(Me.cbxConcursalesTribu)
        Me.Controls.Add(ObsTribuLabel)
        Me.Controls.Add(Me.txtObsTribu)
        Me.Controls.Add(Me.dgvTribunales)
        Me.Controls.Add(Me.TribunalesBindingNavigator)
        Me.Controls.Add(Me.PictureBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTribunales"
        Me.Text = "ACTUALIZACIÓN DE TRIBUNALES"
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TribunalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TribunalesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TribunalesBindingNavigator.ResumeLayout(False)
        Me.TribunalesBindingNavigator.PerformLayout()
        CType(Me.dgvTribunales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents TribunalesBindingSource As BindingSource
    Friend WithEvents TribunalesTableAdapter As dbcolmartDataSetTableAdapters.tribunalesTableAdapter
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TribunalesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TribunalesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents dgvTribunales As DataGridView
    Friend WithEvents Id_TribuTextBox As TextBox
    Friend WithEvents txtSedeTribu As TextBox
    Friend WithEvents cbxDistritoTribu As CheckBox
    Friend WithEvents cbxCircuitoTribu As CheckBox
    Friend WithEvents cbxTasacionesTribu As CheckBox
    Friend WithEvents cbxConcursalesTribu As CheckBox
    Friend WithEvents txtObsTribu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents PictureBox4 As PictureBox
End Class

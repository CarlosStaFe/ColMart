<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarMenues
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
        Dim NombreBtnLabel As System.Windows.Forms.Label
        Dim DetalleBtnLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargarMenues))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.BotonesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BotonesTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.botonesTableAdapter()
        Me.TableAdapterManager = New ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager()
        Me.BotonesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BotonesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.txtId_Btn = New System.Windows.Forms.TextBox()
        Me.txtNombreBtn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvBotones = New System.Windows.Forms.DataGridView()
        Me.IdBtnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreBtnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleBtn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DetalleBtnTextBox = New System.Windows.Forms.TextBox()
        NombreBtnLabel = New System.Windows.Forms.Label()
        DetalleBtnLabel = New System.Windows.Forms.Label()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BotonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BotonesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BotonesBindingNavigator.SuspendLayout()
        CType(Me.dgvBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreBtnLabel
        '
        NombreBtnLabel.AutoSize = True
        NombreBtnLabel.Location = New System.Drawing.Point(85, 61)
        NombreBtnLabel.Name = "NombreBtnLabel"
        NombreBtnLabel.Size = New System.Drawing.Size(107, 17)
        NombreBtnLabel.TabIndex = 3
        NombreBtnLabel.Text = "Nombre Botón:"
        '
        'DetalleBtnLabel
        '
        DetalleBtnLabel.AutoSize = True
        DetalleBtnLabel.Location = New System.Drawing.Point(92, 90)
        DetalleBtnLabel.Name = "DetalleBtnLabel"
        DetalleBtnLabel.Size = New System.Drawing.Size(100, 17)
        DetalleBtnLabel.TabIndex = 152
        DetalleBtnLabel.Text = "Detalle Botón:"
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BotonesBindingSource
        '
        Me.BotonesBindingSource.DataMember = "botones"
        Me.BotonesBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'BotonesTableAdapter
        '
        Me.BotonesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bibliotecaTableAdapter = Nothing
        Me.TableAdapterManager.boletasTableAdapter = Nothing
        Me.TableAdapterManager.botonesTableAdapter = Me.BotonesTableAdapter
        Me.TableAdapterManager.botonuserTableAdapter = Nothing
        Me.TableAdapterManager.cajamayorTableAdapter = Nothing
        Me.TableAdapterManager.cajaTableAdapter = Nothing
        Me.TableAdapterManager.categivaTableAdapter = Nothing
        Me.TableAdapterManager.coddebitoTableAdapter = Nothing
        Me.TableAdapterManager.codpostalTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.comprobteTableAdapter = Nothing
        Me.TableAdapterManager.cptosgastosTableAdapter = Nothing
        Me.TableAdapterManager.ctacteproTableAdapter = Nothing
        Me.TableAdapterManager.ctasctesTableAdapter = Nothing
        Me.TableAdapterManager.debehaberTableAdapter = Nothing
        Me.TableAdapterManager.debitomatriTableAdapter = Nothing
        Me.TableAdapterManager.debitosocTableAdapter = Nothing
        Me.TableAdapterManager.departamentoTableAdapter = Nothing
        Me.TableAdapterManager.depositosTableAdapter = Nothing
        Me.TableAdapterManager.detallecpraTableAdapter = Nothing
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
        Me.TableAdapterManager.renglonesTableAdapter = Nothing
        Me.TableAdapterManager.saldomatTableAdapter = Nothing
        Me.TableAdapterManager.saldosocTableAdapter = Nothing
        Me.TableAdapterManager.sociedadesTableAdapter = Nothing
        Me.TableAdapterManager.tribunalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'BotonesBindingNavigator
        '
        Me.BotonesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BotonesBindingNavigator.BindingSource = Me.BotonesBindingSource
        Me.BotonesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BotonesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BotonesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BotonesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BotonesBindingNavigatorSaveItem, Me.btnSalir})
        Me.BotonesBindingNavigator.Location = New System.Drawing.Point(0, 573)
        Me.BotonesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BotonesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BotonesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BotonesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BotonesBindingNavigator.Name = "BotonesBindingNavigator"
        Me.BotonesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BotonesBindingNavigator.Size = New System.Drawing.Size(913, 25)
        Me.BotonesBindingNavigator.TabIndex = 0
        Me.BotonesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BotonesBindingNavigatorSaveItem
        '
        Me.BotonesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BotonesBindingNavigatorSaveItem.Image = CType(resources.GetObject("BotonesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BotonesBindingNavigatorSaveItem.Name = "BotonesBindingNavigatorSaveItem"
        Me.BotonesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BotonesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'btnSalir
        '
        Me.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(23, 22)
        Me.btnSalir.Text = "ToolStripButton1"
        '
        'txtId_Btn
        '
        Me.txtId_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_Btn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_Btn.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BotonesBindingSource, "id_Btn", True))
        Me.txtId_Btn.Enabled = False
        Me.txtId_Btn.ForeColor = System.Drawing.Color.White
        Me.txtId_Btn.Location = New System.Drawing.Point(620, 62)
        Me.txtId_Btn.Name = "txtId_Btn"
        Me.txtId_Btn.Size = New System.Drawing.Size(69, 16)
        Me.txtId_Btn.TabIndex = 2
        '
        'txtNombreBtn
        '
        Me.txtNombreBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombreBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreBtn.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BotonesBindingSource, "NombreBtn", True))
        Me.txtNombreBtn.ForeColor = System.Drawing.Color.White
        Me.txtNombreBtn.Location = New System.Drawing.Point(198, 59)
        Me.txtNombreBtn.Name = "txtNombreBtn"
        Me.txtNombreBtn.Size = New System.Drawing.Size(375, 23)
        Me.txtNombreBtn.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(175, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(380, 36)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Actualización de Menúes"
        '
        'dgvBotones
        '
        Me.dgvBotones.AllowUserToAddRows = False
        Me.dgvBotones.AllowUserToDeleteRows = False
        Me.dgvBotones.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvBotones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBotones.AutoGenerateColumns = False
        Me.dgvBotones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvBotones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBotones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBotones.ColumnHeadersHeight = 30
        Me.dgvBotones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBotones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBtnDataGridViewTextBoxColumn, Me.NombreBtnDataGridViewTextBoxColumn, Me.DetalleBtn})
        Me.dgvBotones.DataSource = Me.BotonesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBotones.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBotones.EnableHeadersVisualStyles = False
        Me.dgvBotones.GridColor = System.Drawing.Color.White
        Me.dgvBotones.Location = New System.Drawing.Point(89, 130)
        Me.dgvBotones.Name = "dgvBotones"
        Me.dgvBotones.ReadOnly = True
        Me.dgvBotones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBotones.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBotones.Size = New System.Drawing.Size(590, 440)
        Me.dgvBotones.TabIndex = 106
        '
        'IdBtnDataGridViewTextBoxColumn
        '
        Me.IdBtnDataGridViewTextBoxColumn.DataPropertyName = "id_Btn"
        Me.IdBtnDataGridViewTextBoxColumn.HeaderText = "id_Btn"
        Me.IdBtnDataGridViewTextBoxColumn.Name = "IdBtnDataGridViewTextBoxColumn"
        Me.IdBtnDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdBtnDataGridViewTextBoxColumn.Visible = False
        '
        'NombreBtnDataGridViewTextBoxColumn
        '
        Me.NombreBtnDataGridViewTextBoxColumn.DataPropertyName = "NombreBtn"
        Me.NombreBtnDataGridViewTextBoxColumn.HeaderText = "NOMBRE DEL BOTÓN"
        Me.NombreBtnDataGridViewTextBoxColumn.Name = "NombreBtnDataGridViewTextBoxColumn"
        Me.NombreBtnDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreBtnDataGridViewTextBoxColumn.Width = 260
        '
        'DetalleBtn
        '
        Me.DetalleBtn.DataPropertyName = "DetalleBtn"
        Me.DetalleBtn.HeaderText = "DETALLE BOTÓN"
        Me.DetalleBtn.Name = "DetalleBtn"
        Me.DetalleBtn.ReadOnly = True
        Me.DetalleBtn.Width = 260
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(55, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(649, 76)
        Me.PictureBox2.TabIndex = 152
        Me.PictureBox2.TabStop = False
        '
        'DetalleBtnTextBox
        '
        Me.DetalleBtnTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetalleBtnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DetalleBtnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BotonesBindingSource, "DetalleBtn", True))
        Me.DetalleBtnTextBox.ForeColor = System.Drawing.Color.White
        Me.DetalleBtnTextBox.Location = New System.Drawing.Point(198, 88)
        Me.DetalleBtnTextBox.Name = "DetalleBtnTextBox"
        Me.DetalleBtnTextBox.Size = New System.Drawing.Size(375, 23)
        Me.DetalleBtnTextBox.TabIndex = 153
        '
        'frmCargarMenues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 598)
        Me.Controls.Add(DetalleBtnLabel)
        Me.Controls.Add(Me.DetalleBtnTextBox)
        Me.Controls.Add(Me.dgvBotones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtId_Btn)
        Me.Controls.Add(NombreBtnLabel)
        Me.Controls.Add(Me.txtNombreBtn)
        Me.Controls.Add(Me.BotonesBindingNavigator)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCargarMenues"
        Me.Text = "ACTUALIZACIÓN DE MENÚES"
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BotonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BotonesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BotonesBindingNavigator.ResumeLayout(False)
        Me.BotonesBindingNavigator.PerformLayout()
        CType(Me.dgvBotones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents BotonesBindingSource As BindingSource
    Friend WithEvents BotonesTableAdapter As dbcolmartDataSetTableAdapters.botonesTableAdapter
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BotonesBindingNavigator As BindingNavigator
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
    Friend WithEvents BotonesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtId_Btn As TextBox
    Friend WithEvents txtNombreBtn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvBotones As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents IdBtnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreBtnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleBtn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleBtnTextBox As TextBox
End Class

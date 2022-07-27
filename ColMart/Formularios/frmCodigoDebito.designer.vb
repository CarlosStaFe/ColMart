<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCodigoDebito
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
        Dim NroCodDebLabel As System.Windows.Forms.Label
        Dim DetalleCodDebLabel As System.Windows.Forms.Label
        Dim ImporteCodDebLabel As System.Windows.Forms.Label
        Dim CategCodDebLabel As System.Windows.Forms.Label
        Dim ObsCodDebLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCodigoDebito))
        Dim Label3 As System.Windows.Forms.Label
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.CoddebitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoddebitoTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.coddebitoTableAdapter()
        Me.TableAdapterManager = New ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager()
        Me.CoddebitoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CoddebitoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtId_CodDeb = New System.Windows.Forms.TextBox()
        Me.txtNroCodDeb = New System.Windows.Forms.TextBox()
        Me.txtDetalleCodDeb = New System.Windows.Forms.TextBox()
        Me.txtObsCodDeb = New System.Windows.Forms.TextBox()
        Me.txtCategCodDeb = New System.Windows.Forms.ComboBox()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnPrimer = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtImporteCodDeb = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtKgCodDeb = New System.Windows.Forms.TextBox()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbTipoRecCodDeb = New System.Windows.Forms.ComboBox()
        NroCodDebLabel = New System.Windows.Forms.Label()
        DetalleCodDebLabel = New System.Windows.Forms.Label()
        ImporteCodDebLabel = New System.Windows.Forms.Label()
        CategCodDebLabel = New System.Windows.Forms.Label()
        ObsCodDebLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoddebitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoddebitoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CoddebitoBindingNavigator.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NroCodDebLabel
        '
        NroCodDebLabel.AutoSize = True
        NroCodDebLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NroCodDebLabel.ForeColor = System.Drawing.Color.White
        NroCodDebLabel.Location = New System.Drawing.Point(44, 62)
        NroCodDebLabel.Name = "NroCodDebLabel"
        NroCodDebLabel.Size = New System.Drawing.Size(62, 17)
        NroCodDebLabel.TabIndex = 0
        NroCodDebLabel.Text = "Código:"
        '
        'DetalleCodDebLabel
        '
        DetalleCodDebLabel.AutoSize = True
        DetalleCodDebLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DetalleCodDebLabel.ForeColor = System.Drawing.Color.White
        DetalleCodDebLabel.Location = New System.Drawing.Point(48, 91)
        DetalleCodDebLabel.Name = "DetalleCodDebLabel"
        DetalleCodDebLabel.Size = New System.Drawing.Size(58, 17)
        DetalleCodDebLabel.TabIndex = 3
        DetalleCodDebLabel.Text = "Detalle:"
        '
        'ImporteCodDebLabel
        '
        ImporteCodDebLabel.AutoSize = True
        ImporteCodDebLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImporteCodDebLabel.ForeColor = System.Drawing.Color.White
        ImporteCodDebLabel.Location = New System.Drawing.Point(43, 120)
        ImporteCodDebLabel.Name = "ImporteCodDebLabel"
        ImporteCodDebLabel.Size = New System.Drawing.Size(63, 17)
        ImporteCodDebLabel.TabIndex = 5
        ImporteCodDebLabel.Text = "Importe:"
        '
        'CategCodDebLabel
        '
        CategCodDebLabel.AutoSize = True
        CategCodDebLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategCodDebLabel.ForeColor = System.Drawing.Color.White
        CategCodDebLabel.Location = New System.Drawing.Point(27, 150)
        CategCodDebLabel.Name = "CategCodDebLabel"
        CategCodDebLabel.Size = New System.Drawing.Size(79, 17)
        CategCodDebLabel.TabIndex = 7
        CategCodDebLabel.Text = "Categoría:"
        '
        'ObsCodDebLabel
        '
        ObsCodDebLabel.AutoSize = True
        ObsCodDebLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsCodDebLabel.ForeColor = System.Drawing.Color.White
        ObsCodDebLabel.Location = New System.Drawing.Point(12, 179)
        ObsCodDebLabel.Name = "ObsCodDebLabel"
        ObsCodDebLabel.Size = New System.Drawing.Size(94, 17)
        ObsCodDebLabel.TabIndex = 9
        ObsCodDebLabel.Text = "Observación:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(231, 120)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(40, 17)
        Label2.TabIndex = 88
        Label2.Text = "Kilos:"
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CoddebitoBindingSource
        '
        Me.CoddebitoBindingSource.DataMember = "coddebito"
        Me.CoddebitoBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'CoddebitoTableAdapter
        '
        Me.CoddebitoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bibliotecaTableAdapter = Nothing
        Me.TableAdapterManager.boletasTableAdapter = Nothing
        Me.TableAdapterManager.cajamayorTableAdapter = Nothing
        Me.TableAdapterManager.cajaTableAdapter = Nothing
        Me.TableAdapterManager.coddebitoTableAdapter = Me.CoddebitoTableAdapter
        Me.TableAdapterManager.codpostalTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.comprobteTableAdapter = Nothing
        Me.TableAdapterManager.ctasctesTableAdapter = Nothing
        Me.TableAdapterManager.debehaberTableAdapter = Nothing
        Me.TableAdapterManager.debitomatriTableAdapter = Nothing
        Me.TableAdapterManager.debitosocTableAdapter = Nothing
        Me.TableAdapterManager.departamentoTableAdapter = Nothing
        Me.TableAdapterManager.depositosTableAdapter = Nothing
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
        'CoddebitoBindingNavigator
        '
        Me.CoddebitoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CoddebitoBindingNavigator.BindingSource = Me.CoddebitoBindingSource
        Me.CoddebitoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CoddebitoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CoddebitoBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CoddebitoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CoddebitoBindingNavigatorSaveItem})
        Me.CoddebitoBindingNavigator.Location = New System.Drawing.Point(0, 542)
        Me.CoddebitoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CoddebitoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CoddebitoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CoddebitoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CoddebitoBindingNavigator.Name = "CoddebitoBindingNavigator"
        Me.CoddebitoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CoddebitoBindingNavigator.Size = New System.Drawing.Size(887, 25)
        Me.CoddebitoBindingNavigator.TabIndex = 0
        Me.CoddebitoBindingNavigator.Text = "BindingNavigator1"
        Me.CoddebitoBindingNavigator.Visible = False
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
        'CoddebitoBindingNavigatorSaveItem
        '
        Me.CoddebitoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CoddebitoBindingNavigatorSaveItem.Image = CType(resources.GetObject("CoddebitoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CoddebitoBindingNavigatorSaveItem.Name = "CoddebitoBindingNavigatorSaveItem"
        Me.CoddebitoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CoddebitoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'txtId_CodDeb
        '
        Me.txtId_CodDeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_CodDeb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_CodDeb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoddebitoBindingSource, "id_CodDeb", True))
        Me.txtId_CodDeb.Enabled = False
        Me.txtId_CodDeb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_CodDeb.ForeColor = System.Drawing.Color.White
        Me.txtId_CodDeb.Location = New System.Drawing.Point(180, 63)
        Me.txtId_CodDeb.Name = "txtId_CodDeb"
        Me.txtId_CodDeb.Size = New System.Drawing.Size(41, 16)
        Me.txtId_CodDeb.TabIndex = 1
        '
        'txtNroCodDeb
        '
        Me.txtNroCodDeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroCodDeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroCodDeb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoddebitoBindingSource, "NroCodDeb", True))
        Me.txtNroCodDeb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroCodDeb.ForeColor = System.Drawing.Color.White
        Me.txtNroCodDeb.Location = New System.Drawing.Point(113, 59)
        Me.txtNroCodDeb.Name = "txtNroCodDeb"
        Me.txtNroCodDeb.Size = New System.Drawing.Size(61, 23)
        Me.txtNroCodDeb.TabIndex = 0
        '
        'txtDetalleCodDeb
        '
        Me.txtDetalleCodDeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDetalleCodDeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalleCodDeb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoddebitoBindingSource, "DetalleCodDeb", True))
        Me.txtDetalleCodDeb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleCodDeb.ForeColor = System.Drawing.Color.White
        Me.txtDetalleCodDeb.Location = New System.Drawing.Point(113, 88)
        Me.txtDetalleCodDeb.MaxLength = 40
        Me.txtDetalleCodDeb.Name = "txtDetalleCodDeb"
        Me.txtDetalleCodDeb.Size = New System.Drawing.Size(511, 23)
        Me.txtDetalleCodDeb.TabIndex = 2
        '
        'txtObsCodDeb
        '
        Me.txtObsCodDeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObsCodDeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsCodDeb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoddebitoBindingSource, "ObsCodDeb", True))
        Me.txtObsCodDeb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsCodDeb.ForeColor = System.Drawing.Color.White
        Me.txtObsCodDeb.Location = New System.Drawing.Point(113, 176)
        Me.txtObsCodDeb.Name = "txtObsCodDeb"
        Me.txtObsCodDeb.Size = New System.Drawing.Size(511, 23)
        Me.txtObsCodDeb.TabIndex = 7
        '
        'txtCategCodDeb
        '
        Me.txtCategCodDeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCategCodDeb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoddebitoBindingSource, "CategCodDeb", True))
        Me.txtCategCodDeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtCategCodDeb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategCodDeb.ForeColor = System.Drawing.Color.White
        Me.txtCategCodDeb.FormattingEnabled = True
        Me.txtCategCodDeb.Items.AddRange(New Object() {"OS - Obra Social", "DM - Débito Mensual", "DS - Débito Sociedades", "DU - Débito Único"})
        Me.txtCategCodDeb.Location = New System.Drawing.Point(113, 146)
        Me.txtCategCodDeb.Name = "txtCategCodDeb"
        Me.txtCategCodDeb.Size = New System.Drawing.Size(176, 25)
        Me.txtCategCodDeb.TabIndex = 5
        '
        'BtnUltimo
        '
        Me.BtnUltimo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUltimo.FlatAppearance.BorderSize = 0
        Me.BtnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUltimo.ForeColor = System.Drawing.Color.White
        Me.BtnUltimo.Image = CType(resources.GetObject("BtnUltimo.Image"), System.Drawing.Image)
        Me.BtnUltimo.Location = New System.Drawing.Point(582, 224)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.Size = New System.Drawing.Size(34, 51)
        Me.BtnUltimo.TabIndex = 17
        Me.BtnUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUltimo.UseVisualStyleBackColor = True
        '
        'BtnPrimer
        '
        Me.BtnPrimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrimer.FlatAppearance.BorderSize = 0
        Me.BtnPrimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrimer.ForeColor = System.Drawing.Color.White
        Me.BtnPrimer.Image = CType(resources.GetObject("BtnPrimer.Image"), System.Drawing.Image)
        Me.BtnPrimer.Location = New System.Drawing.Point(462, 224)
        Me.BtnPrimer.Name = "BtnPrimer"
        Me.BtnPrimer.Size = New System.Drawing.Size(34, 51)
        Me.BtnPrimer.TabIndex = 14
        Me.BtnPrimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPrimer.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSiguiente.FlatAppearance.BorderSize = 0
        Me.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.ForeColor = System.Drawing.Color.White
        Me.BtnSiguiente.Image = CType(resources.GetObject("BtnSiguiente.Image"), System.Drawing.Image)
        Me.BtnSiguiente.Location = New System.Drawing.Point(542, 224)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(34, 51)
        Me.BtnSiguiente.TabIndex = 16
        Me.BtnSiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnterior.FlatAppearance.BorderSize = 0
        Me.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnterior.ForeColor = System.Drawing.Color.White
        Me.BtnAnterior.Image = CType(resources.GetObject("BtnAnterior.Image"), System.Drawing.Image)
        Me.BtnAnterior.Location = New System.Drawing.Point(502, 224)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(34, 51)
        Me.BtnAnterior.TabIndex = 15
        Me.BtnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActualizar.FlatAppearance.BorderSize = 0
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(351, 224)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(85, 51)
        Me.BtnActualizar.TabIndex = 13
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGrabar.FlatAppearance.BorderSize = 0
        Me.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrabar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.ForeColor = System.Drawing.Color.White
        Me.BtnGrabar.Image = CType(resources.GetObject("BtnGrabar.Image"), System.Drawing.Image)
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGrabar.Location = New System.Drawing.Point(81, 224)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(64, 51)
        Me.BtnGrabar.TabIndex = 9
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(660, 224)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(52, 51)
        Me.BtnSalir.TabIndex = 18
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnModificar.Location = New System.Drawing.Point(145, 224)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(78, 51)
        Me.BtnModificar.TabIndex = 10
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(223, 224)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(71, 51)
        Me.BtnEliminar.TabIndex = 11
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(294, 224)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(57, 51)
        Me.BtnBuscar.TabIndex = 12
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAgregar.Location = New System.Drawing.Point(16, 224)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(65, 51)
        Me.BtnAgregar.TabIndex = 8
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(9, 215)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(432, 69)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'txtImporteCodDeb
        '
        Me.txtImporteCodDeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtImporteCodDeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImporteCodDeb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoddebitoBindingSource, "ImporteCodDeb", True))
        Me.txtImporteCodDeb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteCodDeb.ForeColor = System.Drawing.Color.White
        Me.txtImporteCodDeb.Location = New System.Drawing.Point(113, 117)
        Me.txtImporteCodDeb.Name = "txtImporteCodDeb"
        Me.txtImporteCodDeb.Size = New System.Drawing.Size(100, 23)
        Me.txtImporteCodDeb.TabIndex = 3
        Me.txtImporteCodDeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(447, 215)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 69)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(645, 215)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(81, 69)
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(109, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(529, 36)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Actualización de Códigos a Debitar"
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CoddebitoBindingSource, "KgCodDeb", True))
        Me.PictureBox4.Location = New System.Drawing.Point(9, 51)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(629, 157)
        Me.PictureBox4.TabIndex = 86
        Me.PictureBox4.TabStop = False
        '
        'txtKgCodDeb
        '
        Me.txtKgCodDeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtKgCodDeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKgCodDeb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoddebitoBindingSource, "KgCodDeb", True))
        Me.txtKgCodDeb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgCodDeb.ForeColor = System.Drawing.Color.White
        Me.txtKgCodDeb.Location = New System.Drawing.Point(277, 117)
        Me.txtKgCodDeb.Name = "txtKgCodDeb"
        Me.txtKgCodDeb.Size = New System.Drawing.Size(100, 23)
        Me.txtKgCodDeb.TabIndex = 4
        Me.txtKgCodDeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(354, 150)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(87, 17)
        Label3.TabIndex = 90
        Label3.Text = "Tipo Recibo:"
        '
        'cmbTipoRecCodDeb
        '
        Me.cmbTipoRecCodDeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbTipoRecCodDeb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoddebitoBindingSource, "TipoRecCodDeb", True))
        Me.cmbTipoRecCodDeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoRecCodDeb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoRecCodDeb.ForeColor = System.Drawing.Color.White
        Me.cmbTipoRecCodDeb.FormattingEnabled = True
        Me.cmbTipoRecCodDeb.Items.AddRange(New Object() {"BOL", "REC"})
        Me.cmbTipoRecCodDeb.Location = New System.Drawing.Point(447, 146)
        Me.cmbTipoRecCodDeb.Name = "cmbTipoRecCodDeb"
        Me.cmbTipoRecCodDeb.Size = New System.Drawing.Size(71, 25)
        Me.cmbTipoRecCodDeb.TabIndex = 6
        '
        'frmCodigoDebito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(887, 567)
        Me.Controls.Add(Me.cmbTipoRecCodDeb)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtKgCodDeb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtImporteCodDeb)
        Me.Controls.Add(Me.BtnUltimo)
        Me.Controls.Add(Me.BtnPrimer)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.BtnAnterior)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.txtCategCodDeb)
        Me.Controls.Add(Me.txtId_CodDeb)
        Me.Controls.Add(NroCodDebLabel)
        Me.Controls.Add(Me.txtNroCodDeb)
        Me.Controls.Add(DetalleCodDebLabel)
        Me.Controls.Add(Me.txtDetalleCodDeb)
        Me.Controls.Add(ImporteCodDebLabel)
        Me.Controls.Add(CategCodDebLabel)
        Me.Controls.Add(ObsCodDebLabel)
        Me.Controls.Add(Me.txtObsCodDeb)
        Me.Controls.Add(Me.CoddebitoBindingNavigator)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCodigoDebito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZACIÓN DE CÓDIGOS A DEBITAR"
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoddebitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoddebitoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CoddebitoBindingNavigator.ResumeLayout(False)
        Me.CoddebitoBindingNavigator.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents CoddebitoBindingSource As BindingSource
    Friend WithEvents CoddebitoTableAdapter As dbcolmartDataSetTableAdapters.coddebitoTableAdapter
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CoddebitoBindingNavigator As BindingNavigator
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
    Friend WithEvents CoddebitoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtId_CodDeb As TextBox
    Friend WithEvents txtNroCodDeb As TextBox
    Friend WithEvents txtDetalleCodDeb As TextBox
    Friend WithEvents txtObsCodDeb As TextBox
    Friend WithEvents txtCategCodDeb As ComboBox
    Friend WithEvents BtnUltimo As Button
    Friend WithEvents BtnPrimer As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtImporteCodDeb As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtKgCodDeb As TextBox
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents cmbTipoRecCodDeb As ComboBox
End Class

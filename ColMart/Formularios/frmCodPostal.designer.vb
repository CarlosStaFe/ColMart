<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCodPostal
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
        Dim NroCodPosLabel As System.Windows.Forms.Label
        Dim LocalCodPosLabel As System.Windows.Forms.Label
        Dim DptoCodPosLabel As System.Windows.Forms.Label
        Dim ProvCodPosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCodPostal))
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.CodpostalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodpostalTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.codpostalTableAdapter()
        Me.TableAdapterManager = New ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager()
        Me.CodpostalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CodpostalBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Id_CodPosTextBox = New System.Windows.Forms.TextBox()
        Me.txtNroCodPos = New System.Windows.Forms.TextBox()
        Me.txtLocalCodPos = New System.Windows.Forms.TextBox()
        Me.txtDptoCodPos = New System.Windows.Forms.TextBox()
        Me.txtProvCodPos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        NroCodPosLabel = New System.Windows.Forms.Label()
        LocalCodPosLabel = New System.Windows.Forms.Label()
        DptoCodPosLabel = New System.Windows.Forms.Label()
        ProvCodPosLabel = New System.Windows.Forms.Label()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodpostalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodpostalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CodpostalBindingNavigator.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NroCodPosLabel
        '
        NroCodPosLabel.AutoSize = True
        NroCodPosLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NroCodPosLabel.ForeColor = System.Drawing.Color.White
        NroCodPosLabel.Location = New System.Drawing.Point(100, 67)
        NroCodPosLabel.Name = "NroCodPosLabel"
        NroCodPosLabel.Size = New System.Drawing.Size(62, 17)
        NroCodPosLabel.TabIndex = 3
        NroCodPosLabel.Text = "Código:"
        '
        'LocalCodPosLabel
        '
        LocalCodPosLabel.AutoSize = True
        LocalCodPosLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocalCodPosLabel.ForeColor = System.Drawing.Color.White
        LocalCodPosLabel.Location = New System.Drawing.Point(85, 93)
        LocalCodPosLabel.Name = "LocalCodPosLabel"
        LocalCodPosLabel.Size = New System.Drawing.Size(77, 17)
        LocalCodPosLabel.TabIndex = 5
        LocalCodPosLabel.Text = "Localidad:"
        '
        'DptoCodPosLabel
        '
        DptoCodPosLabel.AutoSize = True
        DptoCodPosLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DptoCodPosLabel.ForeColor = System.Drawing.Color.White
        DptoCodPosLabel.Location = New System.Drawing.Point(53, 119)
        DptoCodPosLabel.Name = "DptoCodPosLabel"
        DptoCodPosLabel.Size = New System.Drawing.Size(109, 17)
        DptoCodPosLabel.TabIndex = 7
        DptoCodPosLabel.Text = "Departamento:"
        '
        'ProvCodPosLabel
        '
        ProvCodPosLabel.AutoSize = True
        ProvCodPosLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProvCodPosLabel.ForeColor = System.Drawing.Color.White
        ProvCodPosLabel.Location = New System.Drawing.Point(90, 145)
        ProvCodPosLabel.Name = "ProvCodPosLabel"
        ProvCodPosLabel.Size = New System.Drawing.Size(72, 17)
        ProvCodPosLabel.TabIndex = 9
        ProvCodPosLabel.Text = "Provincia:"
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CodpostalBindingSource
        '
        Me.CodpostalBindingSource.DataMember = "codpostal"
        Me.CodpostalBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'CodpostalTableAdapter
        '
        Me.CodpostalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bibliotecaTableAdapter = Nothing
        Me.TableAdapterManager.boletasTableAdapter = Nothing
        Me.TableAdapterManager.cajamayorTableAdapter = Nothing
        Me.TableAdapterManager.cajaTableAdapter = Nothing
        Me.TableAdapterManager.coddebitoTableAdapter = Nothing
        Me.TableAdapterManager.codpostalTableAdapter = Me.CodpostalTableAdapter
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.comprobteTableAdapter = Nothing
        Me.TableAdapterManager.ctactematTableAdapter = Nothing
        Me.TableAdapterManager.ctacteprovTableAdapter = Nothing
        Me.TableAdapterManager.ctactesocTableAdapter = Nothing
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
        Me.TableAdapterManager.tribunalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'CodpostalBindingNavigator
        '
        Me.CodpostalBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CodpostalBindingNavigator.BindingSource = Me.CodpostalBindingSource
        Me.CodpostalBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CodpostalBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CodpostalBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CodpostalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CodpostalBindingNavigatorSaveItem, Me.ToolStripLabel1})
        Me.CodpostalBindingNavigator.Location = New System.Drawing.Point(0, 289)
        Me.CodpostalBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CodpostalBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CodpostalBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CodpostalBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CodpostalBindingNavigator.Name = "CodpostalBindingNavigator"
        Me.CodpostalBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CodpostalBindingNavigator.Size = New System.Drawing.Size(540, 25)
        Me.CodpostalBindingNavigator.TabIndex = 0
        Me.CodpostalBindingNavigator.Text = "BindingNavigator1"
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
        'CodpostalBindingNavigatorSaveItem
        '
        Me.CodpostalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CodpostalBindingNavigatorSaveItem.Image = CType(resources.GetObject("CodpostalBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CodpostalBindingNavigatorSaveItem.Name = "CodpostalBindingNavigatorSaveItem"
        Me.CodpostalBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CodpostalBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(212, 22)
        Me.ToolStripLabel1.Text = "Presione F1 en Código para consultar..."
        '
        'Id_CodPosTextBox
        '
        Me.Id_CodPosTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Id_CodPosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Id_CodPosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CodpostalBindingSource, "id_CodPos", True))
        Me.Id_CodPosTextBox.Enabled = False
        Me.Id_CodPosTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_CodPosTextBox.ForeColor = System.Drawing.Color.White
        Me.Id_CodPosTextBox.Location = New System.Drawing.Point(281, 68)
        Me.Id_CodPosTextBox.Name = "Id_CodPosTextBox"
        Me.Id_CodPosTextBox.Size = New System.Drawing.Size(52, 16)
        Me.Id_CodPosTextBox.TabIndex = 2
        '
        'txtNroCodPos
        '
        Me.txtNroCodPos.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroCodPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroCodPos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CodpostalBindingSource, "NroCodPos", True))
        Me.txtNroCodPos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroCodPos.ForeColor = System.Drawing.Color.White
        Me.txtNroCodPos.Location = New System.Drawing.Point(169, 64)
        Me.txtNroCodPos.Name = "txtNroCodPos"
        Me.txtNroCodPos.Size = New System.Drawing.Size(100, 23)
        Me.txtNroCodPos.TabIndex = 4
        '
        'txtLocalCodPos
        '
        Me.txtLocalCodPos.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtLocalCodPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalCodPos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocalCodPos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CodpostalBindingSource, "LocalCodPos", True))
        Me.txtLocalCodPos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalCodPos.ForeColor = System.Drawing.Color.White
        Me.txtLocalCodPos.Location = New System.Drawing.Point(169, 90)
        Me.txtLocalCodPos.Name = "txtLocalCodPos"
        Me.txtLocalCodPos.Size = New System.Drawing.Size(300, 23)
        Me.txtLocalCodPos.TabIndex = 6
        '
        'txtDptoCodPos
        '
        Me.txtDptoCodPos.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDptoCodPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDptoCodPos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDptoCodPos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CodpostalBindingSource, "DptoCodPos", True))
        Me.txtDptoCodPos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDptoCodPos.ForeColor = System.Drawing.Color.White
        Me.txtDptoCodPos.Location = New System.Drawing.Point(169, 116)
        Me.txtDptoCodPos.Name = "txtDptoCodPos"
        Me.txtDptoCodPos.Size = New System.Drawing.Size(300, 23)
        Me.txtDptoCodPos.TabIndex = 8
        '
        'txtProvCodPos
        '
        Me.txtProvCodPos.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtProvCodPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvCodPos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProvCodPos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CodpostalBindingSource, "ProvCodPos", True))
        Me.txtProvCodPos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvCodPos.ForeColor = System.Drawing.Color.White
        Me.txtProvCodPos.Location = New System.Drawing.Point(169, 142)
        Me.txtProvCodPos.Name = "txtProvCodPos"
        Me.txtProvCodPos.Size = New System.Drawing.Size(300, 23)
        Me.txtProvCodPos.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(507, 36)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Actualización de Códigos Postales"
        '
        'BtnSalir
        '
        Me.BtnSalir.AutoSize = True
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(223, 194)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(61, 52)
        Me.BtnSalir.TabIndex = 88
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(12, 185)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(493, 73)
        Me.PictureBox3.TabIndex = 89
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(493, 130)
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'frmCodPostal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(540, 314)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Id_CodPosTextBox)
        Me.Controls.Add(NroCodPosLabel)
        Me.Controls.Add(Me.txtNroCodPos)
        Me.Controls.Add(LocalCodPosLabel)
        Me.Controls.Add(Me.txtLocalCodPos)
        Me.Controls.Add(DptoCodPosLabel)
        Me.Controls.Add(Me.txtDptoCodPos)
        Me.Controls.Add(ProvCodPosLabel)
        Me.Controls.Add(Me.txtProvCodPos)
        Me.Controls.Add(Me.CodpostalBindingNavigator)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCodPostal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " ACTUALIZACIÓN DE CÓDIGOS POSTALES"
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodpostalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodpostalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CodpostalBindingNavigator.ResumeLayout(False)
        Me.CodpostalBindingNavigator.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents CodpostalBindingSource As BindingSource
    Friend WithEvents CodpostalTableAdapter As dbcolmartDataSetTableAdapters.codpostalTableAdapter
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CodpostalBindingNavigator As BindingNavigator
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
    Friend WithEvents CodpostalBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Id_CodPosTextBox As TextBox
    Public WithEvents txtNroCodPos As TextBox
    Public WithEvents txtLocalCodPos As TextBox
    Public WithEvents txtDptoCodPos As TextBox
    Public WithEvents txtProvCodPos As TextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTipMsg As ToolTip
End Class

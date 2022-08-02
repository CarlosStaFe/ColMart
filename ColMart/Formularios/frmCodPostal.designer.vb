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
        Me.Id_CodPosTextBox = New System.Windows.Forms.TextBox()
        Me.txtNroCodPos = New System.Windows.Forms.TextBox()
        Me.txtLocalCodPos = New System.Windows.Forms.TextBox()
        Me.txtDptoCodPos = New System.Windows.Forms.TextBox()
        Me.txtProvCodPos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.CodpostalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CodpostalBindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.CodpostalBindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
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
        Me.CodpostalBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        NroCodPosLabel = New System.Windows.Forms.Label()
        LocalCodPosLabel = New System.Windows.Forms.Label()
        DptoCodPosLabel = New System.Windows.Forms.Label()
        ProvCodPosLabel = New System.Windows.Forms.Label()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodpostalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodpostalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CodpostalBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NroCodPosLabel
        '
        NroCodPosLabel.AutoSize = True
        NroCodPosLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NroCodPosLabel.ForeColor = System.Drawing.Color.White
        NroCodPosLabel.Location = New System.Drawing.Point(163, 67)
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
        LocalCodPosLabel.Location = New System.Drawing.Point(148, 93)
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
        DptoCodPosLabel.Location = New System.Drawing.Point(116, 119)
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
        ProvCodPosLabel.Location = New System.Drawing.Point(153, 145)
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
        Me.TableAdapterManager.categivaTableAdapter = Nothing
        Me.TableAdapterManager.coddebitoTableAdapter = Nothing
        Me.TableAdapterManager.codpostalTableAdapter = Me.CodpostalTableAdapter
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
        'Id_CodPosTextBox
        '
        Me.Id_CodPosTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Id_CodPosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Id_CodPosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CodpostalBindingSource, "id_CodPos", True))
        Me.Id_CodPosTextBox.Enabled = False
        Me.Id_CodPosTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_CodPosTextBox.ForeColor = System.Drawing.Color.White
        Me.Id_CodPosTextBox.Location = New System.Drawing.Point(344, 68)
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
        Me.txtNroCodPos.Location = New System.Drawing.Point(232, 64)
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
        Me.txtLocalCodPos.Location = New System.Drawing.Point(232, 90)
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
        Me.txtDptoCodPos.Location = New System.Drawing.Point(232, 116)
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
        Me.txtProvCodPos.Location = New System.Drawing.Point(232, 142)
        Me.txtProvCodPos.Name = "txtProvCodPos"
        Me.txtProvCodPos.Size = New System.Drawing.Size(300, 23)
        Me.txtProvCodPos.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(75, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(507, 36)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Actualización de Códigos Postales"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(75, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(493, 130)
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'CodpostalBindingNavigator
        '
        Me.CodpostalBindingNavigator.AddNewItem = Me.CodpostalBindingNavigatorAddNewItem
        Me.CodpostalBindingNavigator.AutoSize = False
        Me.CodpostalBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CodpostalBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CodpostalBindingNavigator.BindingSource = Me.CodpostalBindingSource
        Me.CodpostalBindingNavigator.CountItem = Me.ToolStripLabel2
        Me.CodpostalBindingNavigator.DeleteItem = Me.CodpostalBindingNavigatorDeleteItem
        Me.CodpostalBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.CodpostalBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodpostalBindingNavigator.GripMargin = New System.Windows.Forms.Padding(0)
        Me.CodpostalBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CodpostalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.BindingNavigatorMovePreviusItem, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel2, Me.ToolStripSeparator2, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.CodpostalBindingNavigatorAddNewItem, Me.ToolStripSeparator4, Me.CodpostalBindingNavigatorDeleteItem, Me.ToolStripSeparator5, Me.CodpostalBindingNavigatorSaveItem, Me.ToolStripSeparator6, Me.ToolStripButton4})
        Me.CodpostalBindingNavigator.Location = New System.Drawing.Point(22, 206)
        Me.CodpostalBindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.CodpostalBindingNavigator.MoveLastItem = Me.ToolStripButton3
        Me.CodpostalBindingNavigator.MoveNextItem = Me.ToolStripButton2
        Me.CodpostalBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviusItem
        Me.CodpostalBindingNavigator.Name = "CodpostalBindingNavigator"
        Me.CodpostalBindingNavigator.Padding = New System.Windows.Forms.Padding(0)
        Me.CodpostalBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.CodpostalBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CodpostalBindingNavigator.Size = New System.Drawing.Size(635, 40)
        Me.CodpostalBindingNavigator.TabIndex = 153
        Me.CodpostalBindingNavigator.Text = "BindingNavigator"
        '
        'CodpostalBindingNavigatorAddNewItem
        '
        Me.CodpostalBindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.White
        Me.CodpostalBindingNavigatorAddNewItem.Image = CType(resources.GetObject("CodpostalBindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.CodpostalBindingNavigatorAddNewItem.Name = "CodpostalBindingNavigatorAddNewItem"
        Me.CodpostalBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.CodpostalBindingNavigatorAddNewItem.Size = New System.Drawing.Size(87, 37)
        Me.CodpostalBindingNavigatorAddNewItem.Text = "Agregar"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(48, 37)
        Me.ToolStripLabel2.Text = "de {0}"
        Me.ToolStripLabel2.ToolTipText = "Número total de elementos"
        '
        'CodpostalBindingNavigatorDeleteItem
        '
        Me.CodpostalBindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.White
        Me.CodpostalBindingNavigatorDeleteItem.Image = CType(resources.GetObject("CodpostalBindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.CodpostalBindingNavigatorDeleteItem.Name = "CodpostalBindingNavigatorDeleteItem"
        Me.CodpostalBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.CodpostalBindingNavigatorDeleteItem.Size = New System.Drawing.Size(87, 37)
        Me.CodpostalBindingNavigatorDeleteItem.Text = "Eliminar"
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
        'CodpostalBindingNavigatorSaveItem
        '
        Me.CodpostalBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.White
        Me.CodpostalBindingNavigatorSaveItem.Image = CType(resources.GetObject("CodpostalBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CodpostalBindingNavigatorSaveItem.Name = "CodpostalBindingNavigatorSaveItem"
        Me.CodpostalBindingNavigatorSaveItem.Size = New System.Drawing.Size(86, 37)
        Me.CodpostalBindingNavigatorSaveItem.Text = "Guardar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(62, 37)
        Me.ToolStripButton4.Text = "Salir"
        '
        'frmCodPostal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 357)
        Me.Controls.Add(Me.CodpostalBindingNavigator)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCodPostal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " ACTUALIZACIÓN DE CÓDIGOS POSTALES"
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodpostalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodpostalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CodpostalBindingNavigator.ResumeLayout(False)
        Me.CodpostalBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents CodpostalBindingSource As BindingSource
    Friend WithEvents CodpostalTableAdapter As dbcolmartDataSetTableAdapters.codpostalTableAdapter
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_CodPosTextBox As TextBox
    Public WithEvents txtNroCodPos As TextBox
    Public WithEvents txtLocalCodPos As TextBox
    Public WithEvents txtDptoCodPos As TextBox
    Public WithEvents txtProvCodPos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents CodpostalBindingNavigator As BindingNavigator
    Friend WithEvents CodpostalBindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents CodpostalBindingNavigatorDeleteItem As ToolStripButton
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
    Friend WithEvents CodpostalBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
End Class

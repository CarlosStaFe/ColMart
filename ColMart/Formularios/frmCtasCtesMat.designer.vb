<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCtasCtesMat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtasCtesMat))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.txtApelyNomb = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CtasctesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtasctesTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.ctasctesTableAdapter()
        Me.TableAdapterManager = New ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager()
        Me.dgvCtasctes = New System.Windows.Forms.DataGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lblApelyNomb = New System.Windows.Forms.Label()
        Me.IdCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCbteCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCbteCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebeCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaberCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecPagoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtasctesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCtasctes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matrícula:"
        '
        'txtMatricula
        '
        Me.txtMatricula.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMatricula.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.ForeColor = System.Drawing.Color.White
        Me.txtMatricula.Location = New System.Drawing.Point(125, 73)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(62, 23)
        Me.txtMatricula.TabIndex = 1
        '
        'txtApelyNomb
        '
        Me.txtApelyNomb.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtApelyNomb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApelyNomb.Enabled = False
        Me.txtApelyNomb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApelyNomb.ForeColor = System.Drawing.Color.White
        Me.txtApelyNomb.Location = New System.Drawing.Point(1032, 73)
        Me.txtApelyNomb.Name = "txtApelyNomb"
        Me.txtApelyNomb.Size = New System.Drawing.Size(48, 23)
        Me.txtApelyNomb.TabIndex = 2
        Me.txtApelyNomb.Visible = False
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.Black
        Me.txtSaldo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtSaldo.Location = New System.Drawing.Point(875, 70)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(117, 27)
        Me.txtSaldo.TabIndex = 4
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(804, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SALDO:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(14, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1085, 47)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
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
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(886, 580)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(99, 44)
        Me.btnSalir.TabIndex = 87
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
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
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(124, 580)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(99, 44)
        Me.btnLimpiar.TabIndex = 88
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(241, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(484, 36)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Cuentas Corrientes Matriculados"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(16, 572)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1083, 61)
        Me.PictureBox2.TabIndex = 90
        Me.PictureBox2.TabStop = False
        '
        'CtasctesBindingSource
        '
        Me.CtasctesBindingSource.DataMember = "ctasctes"
        Me.CtasctesBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'CtasctesTableAdapter
        '
        Me.CtasctesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.cptosgastosTableAdapter = Nothing
        Me.TableAdapterManager.ctacteproTableAdapter = Nothing
        Me.TableAdapterManager.ctasctesTableAdapter = Me.CtasctesTableAdapter
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
        'dgvCtasctes
        '
        Me.dgvCtasctes.AllowUserToAddRows = False
        Me.dgvCtasctes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCtasctes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCtasctes.AutoGenerateColumns = False
        Me.dgvCtasctes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvCtasctes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtasctes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCtasctes.ColumnHeadersHeight = 30
        Me.dgvCtasctes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCtasctes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCCDataGridViewTextBoxColumn, Me.NroCCDataGridViewTextBoxColumn, Me.FechaCCDataGridViewTextBoxColumn, Me.TipoCbteCCDataGridViewTextBoxColumn, Me.NroCbteCCDataGridViewTextBoxColumn, Me.ItemCCDataGridViewTextBoxColumn, Me.DetalleCCDataGridViewTextBoxColumn, Me.PeriodoCCDataGridViewTextBoxColumn, Me.DebeCCDataGridViewTextBoxColumn, Me.HaberCCDataGridViewTextBoxColumn, Me.PagadoCCDataGridViewTextBoxColumn, Me.FecPagoCCDataGridViewTextBoxColumn, Me.RestoCCDataGridViewTextBoxColumn, Me.EstadoCCDataGridViewTextBoxColumn, Me.SaldoCCDataGridViewTextBoxColumn, Me.ObsCCDataGridViewTextBoxColumn})
        Me.dgvCtasctes.DataSource = Me.CtasctesBindingSource
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCtasctes.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvCtasctes.EnableHeadersVisualStyles = False
        Me.dgvCtasctes.GridColor = System.Drawing.Color.White
        Me.dgvCtasctes.Location = New System.Drawing.Point(15, 114)
        Me.dgvCtasctes.Name = "dgvCtasctes"
        Me.dgvCtasctes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtasctes.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvCtasctes.Size = New System.Drawing.Size(1084, 452)
        Me.dgvCtasctes.TabIndex = 90
        '
        'btnActualizar
        '
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(370, 580)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(119, 44)
        Me.btnActualizar.TabIndex = 91
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Yellow
        Me.lblEstado.Location = New System.Drawing.Point(557, 73)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(16, 19)
        Me.lblEstado.TabIndex = 156
        Me.lblEstado.Text = "-"
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
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(636, 580)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(103, 44)
        Me.btnImprimir.TabIndex = 157
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'lblApelyNomb
        '
        Me.lblApelyNomb.AutoSize = True
        Me.lblApelyNomb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApelyNomb.ForeColor = System.Drawing.Color.White
        Me.lblApelyNomb.Location = New System.Drawing.Point(193, 73)
        Me.lblApelyNomb.Name = "lblApelyNomb"
        Me.lblApelyNomb.Size = New System.Drawing.Size(16, 19)
        Me.lblApelyNomb.TabIndex = 158
        Me.lblApelyNomb.Text = "-"
        '
        'IdCCDataGridViewTextBoxColumn
        '
        Me.IdCCDataGridViewTextBoxColumn.DataPropertyName = "id_CC"
        Me.IdCCDataGridViewTextBoxColumn.HeaderText = "id_CC"
        Me.IdCCDataGridViewTextBoxColumn.Name = "IdCCDataGridViewTextBoxColumn"
        Me.IdCCDataGridViewTextBoxColumn.Visible = False
        '
        'NroCCDataGridViewTextBoxColumn
        '
        Me.NroCCDataGridViewTextBoxColumn.DataPropertyName = "NroCC"
        Me.NroCCDataGridViewTextBoxColumn.HeaderText = "NroCC"
        Me.NroCCDataGridViewTextBoxColumn.Name = "NroCCDataGridViewTextBoxColumn"
        Me.NroCCDataGridViewTextBoxColumn.Visible = False
        '
        'FechaCCDataGridViewTextBoxColumn
        '
        Me.FechaCCDataGridViewTextBoxColumn.DataPropertyName = "FechaCC"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FechaCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaCCDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FechaCCDataGridViewTextBoxColumn.Name = "FechaCCDataGridViewTextBoxColumn"
        Me.FechaCCDataGridViewTextBoxColumn.Width = 80
        '
        'TipoCbteCCDataGridViewTextBoxColumn
        '
        Me.TipoCbteCCDataGridViewTextBoxColumn.DataPropertyName = "TipoCbteCC"
        Me.TipoCbteCCDataGridViewTextBoxColumn.HeaderText = "TIPO"
        Me.TipoCbteCCDataGridViewTextBoxColumn.Name = "TipoCbteCCDataGridViewTextBoxColumn"
        Me.TipoCbteCCDataGridViewTextBoxColumn.Width = 40
        '
        'NroCbteCCDataGridViewTextBoxColumn
        '
        Me.NroCbteCCDataGridViewTextBoxColumn.DataPropertyName = "NroCbteCC"
        Me.NroCbteCCDataGridViewTextBoxColumn.HeaderText = "COMPROB."
        Me.NroCbteCCDataGridViewTextBoxColumn.Name = "NroCbteCCDataGridViewTextBoxColumn"
        Me.NroCbteCCDataGridViewTextBoxColumn.Width = 75
        '
        'ItemCCDataGridViewTextBoxColumn
        '
        Me.ItemCCDataGridViewTextBoxColumn.DataPropertyName = "ItemCC"
        Me.ItemCCDataGridViewTextBoxColumn.HeaderText = "ItemCC"
        Me.ItemCCDataGridViewTextBoxColumn.Name = "ItemCCDataGridViewTextBoxColumn"
        Me.ItemCCDataGridViewTextBoxColumn.Visible = False
        '
        'DetalleCCDataGridViewTextBoxColumn
        '
        Me.DetalleCCDataGridViewTextBoxColumn.DataPropertyName = "DetalleCC"
        Me.DetalleCCDataGridViewTextBoxColumn.HeaderText = "DETALLE"
        Me.DetalleCCDataGridViewTextBoxColumn.Name = "DetalleCCDataGridViewTextBoxColumn"
        Me.DetalleCCDataGridViewTextBoxColumn.Width = 240
        '
        'PeriodoCCDataGridViewTextBoxColumn
        '
        Me.PeriodoCCDataGridViewTextBoxColumn.DataPropertyName = "PeriodoCC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PeriodoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PeriodoCCDataGridViewTextBoxColumn.HeaderText = "PDO."
        Me.PeriodoCCDataGridViewTextBoxColumn.Name = "PeriodoCCDataGridViewTextBoxColumn"
        Me.PeriodoCCDataGridViewTextBoxColumn.Width = 60
        '
        'DebeCCDataGridViewTextBoxColumn
        '
        Me.DebeCCDataGridViewTextBoxColumn.DataPropertyName = "DebeCC"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DebeCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.DebeCCDataGridViewTextBoxColumn.HeaderText = "DEBE"
        Me.DebeCCDataGridViewTextBoxColumn.Name = "DebeCCDataGridViewTextBoxColumn"
        Me.DebeCCDataGridViewTextBoxColumn.Width = 90
        '
        'HaberCCDataGridViewTextBoxColumn
        '
        Me.HaberCCDataGridViewTextBoxColumn.DataPropertyName = "HaberCC"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.HaberCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.HaberCCDataGridViewTextBoxColumn.HeaderText = "HABER"
        Me.HaberCCDataGridViewTextBoxColumn.Name = "HaberCCDataGridViewTextBoxColumn"
        Me.HaberCCDataGridViewTextBoxColumn.Width = 90
        '
        'PagadoCCDataGridViewTextBoxColumn
        '
        Me.PagadoCCDataGridViewTextBoxColumn.DataPropertyName = "PagadoCC"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.PagadoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.PagadoCCDataGridViewTextBoxColumn.HeaderText = "PAGADO"
        Me.PagadoCCDataGridViewTextBoxColumn.Name = "PagadoCCDataGridViewTextBoxColumn"
        Me.PagadoCCDataGridViewTextBoxColumn.Width = 90
        '
        'FecPagoCCDataGridViewTextBoxColumn
        '
        Me.FecPagoCCDataGridViewTextBoxColumn.DataPropertyName = "FecPagoCC"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.FecPagoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.FecPagoCCDataGridViewTextBoxColumn.HeaderText = "FEC.PAGO"
        Me.FecPagoCCDataGridViewTextBoxColumn.Name = "FecPagoCCDataGridViewTextBoxColumn"
        Me.FecPagoCCDataGridViewTextBoxColumn.Width = 80
        '
        'RestoCCDataGridViewTextBoxColumn
        '
        Me.RestoCCDataGridViewTextBoxColumn.DataPropertyName = "RestoCC"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.RestoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.RestoCCDataGridViewTextBoxColumn.HeaderText = "DEUDA"
        Me.RestoCCDataGridViewTextBoxColumn.Name = "RestoCCDataGridViewTextBoxColumn"
        Me.RestoCCDataGridViewTextBoxColumn.Width = 90
        '
        'EstadoCCDataGridViewTextBoxColumn
        '
        Me.EstadoCCDataGridViewTextBoxColumn.DataPropertyName = "EstadoCC"
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.EstadoCCDataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.EstadoCCDataGridViewTextBoxColumn.Name = "EstadoCCDataGridViewTextBoxColumn"
        '
        'SaldoCCDataGridViewTextBoxColumn
        '
        Me.SaldoCCDataGridViewTextBoxColumn.DataPropertyName = "SaldoCC"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.SaldoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.SaldoCCDataGridViewTextBoxColumn.HeaderText = "SALDO"
        Me.SaldoCCDataGridViewTextBoxColumn.Name = "SaldoCCDataGridViewTextBoxColumn"
        Me.SaldoCCDataGridViewTextBoxColumn.Visible = False
        '
        'ObsCCDataGridViewTextBoxColumn
        '
        Me.ObsCCDataGridViewTextBoxColumn.DataPropertyName = "ObsCC"
        Me.ObsCCDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES"
        Me.ObsCCDataGridViewTextBoxColumn.Name = "ObsCCDataGridViewTextBoxColumn"
        Me.ObsCCDataGridViewTextBoxColumn.Width = 200
        '
        'frmCtasCtesMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1130, 642)
        Me.Controls.Add(Me.lblApelyNomb)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.dgvCtasctes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtApelyNomb)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCtasCtesMat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUENTAS CORRIENTES MATRICULADOS"
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtasctesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCtasctes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents txtApelyNomb As TextBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CtasctesBindingSource As BindingSource
    Friend WithEvents CtasctesTableAdapter As dbcolmartDataSetTableAdapters.ctasctesTableAdapter
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvCtasctes As DataGridView
    Friend WithEvents btnActualizar As Button
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents lblEstado As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents lblApelyNomb As Label
    Friend WithEvents IdCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCbteCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroCbteCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeriodoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DebeCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HaberCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagadoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FecPagoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

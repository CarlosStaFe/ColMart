﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.dgvCtasctes2 = New System.Windows.Forms.DataGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.SaldoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecPagoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestoCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtasctesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCtasctes2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtApelyNomb.Location = New System.Drawing.Point(193, 73)
        Me.txtApelyNomb.Name = "txtApelyNomb"
        Me.txtApelyNomb.Size = New System.Drawing.Size(305, 23)
        Me.txtApelyNomb.TabIndex = 2
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.Black
        Me.txtSaldo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtSaldo.Location = New System.Drawing.Point(753, 70)
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
        Me.Label2.Location = New System.Drawing.Point(682, 76)
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
        Me.PictureBox1.Size = New System.Drawing.Size(975, 47)
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
        Me.btnSalir.Location = New System.Drawing.Point(660, 580)
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
        Me.btnLimpiar.Location = New System.Drawing.Point(215, 580)
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
        Me.PictureBox2.Size = New System.Drawing.Size(977, 61)
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
        Me.TableAdapterManager.cajamayorTableAdapter = Nothing
        Me.TableAdapterManager.cajaTableAdapter = Nothing
        Me.TableAdapterManager.categivaTableAdapter = Nothing
        Me.TableAdapterManager.coddebitoTableAdapter = Nothing
        Me.TableAdapterManager.codpostalTableAdapter = Nothing
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
        'dgvCtasctes2
        '
        Me.dgvCtasctes2.AllowUserToAddRows = False
        Me.dgvCtasctes2.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCtasctes2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCtasctes2.AutoGenerateColumns = False
        Me.dgvCtasctes2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvCtasctes2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtasctes2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCtasctes2.ColumnHeadersHeight = 30
        Me.dgvCtasctes2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCtasctes2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCCDataGridViewTextBoxColumn, Me.NroCCDataGridViewTextBoxColumn, Me.FechaCCDataGridViewTextBoxColumn, Me.TipoCbteCCDataGridViewTextBoxColumn, Me.NroCbteCCDataGridViewTextBoxColumn, Me.ItemCCDataGridViewTextBoxColumn, Me.DetalleCCDataGridViewTextBoxColumn, Me.PeriodoCCDataGridViewTextBoxColumn, Me.DebeCCDataGridViewTextBoxColumn, Me.HaberCCDataGridViewTextBoxColumn, Me.SaldoCCDataGridViewTextBoxColumn, Me.EstadoCCDataGridViewTextBoxColumn, Me.PagadoCCDataGridViewTextBoxColumn, Me.FecPagoCCDataGridViewTextBoxColumn, Me.RestoCCDataGridViewTextBoxColumn, Me.ObsCCDataGridViewTextBoxColumn})
        Me.dgvCtasctes2.DataSource = Me.CtasctesBindingSource
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCtasctes2.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvCtasctes2.EnableHeadersVisualStyles = False
        Me.dgvCtasctes2.GridColor = System.Drawing.Color.White
        Me.dgvCtasctes2.Location = New System.Drawing.Point(15, 114)
        Me.dgvCtasctes2.Name = "dgvCtasctes2"
        Me.dgvCtasctes2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtasctes2.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvCtasctes2.Size = New System.Drawing.Size(974, 452)
        Me.dgvCtasctes2.TabIndex = 90
        '
        'btnActualizar
        '
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.Enabled = False
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(447, 580)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(119, 44)
        Me.btnActualizar.TabIndex = 91
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizar.UseVisualStyleBackColor = True
        Me.btnActualizar.Visible = False
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
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
        Me.DetalleCCDataGridViewTextBoxColumn.Width = 250
        '
        'PeriodoCCDataGridViewTextBoxColumn
        '
        Me.PeriodoCCDataGridViewTextBoxColumn.DataPropertyName = "PeriodoCC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PeriodoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PeriodoCCDataGridViewTextBoxColumn.HeaderText = "PERÍODO"
        Me.PeriodoCCDataGridViewTextBoxColumn.Name = "PeriodoCCDataGridViewTextBoxColumn"
        Me.PeriodoCCDataGridViewTextBoxColumn.Width = 80
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
        '
        'SaldoCCDataGridViewTextBoxColumn
        '
        Me.SaldoCCDataGridViewTextBoxColumn.DataPropertyName = "SaldoCC"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.SaldoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.SaldoCCDataGridViewTextBoxColumn.HeaderText = "SALDO"
        Me.SaldoCCDataGridViewTextBoxColumn.Name = "SaldoCCDataGridViewTextBoxColumn"
        '
        'EstadoCCDataGridViewTextBoxColumn
        '
        Me.EstadoCCDataGridViewTextBoxColumn.DataPropertyName = "EstadoCC"
        Me.EstadoCCDataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.EstadoCCDataGridViewTextBoxColumn.Name = "EstadoCCDataGridViewTextBoxColumn"
        '
        'PagadoCCDataGridViewTextBoxColumn
        '
        Me.PagadoCCDataGridViewTextBoxColumn.DataPropertyName = "PagadoCC"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.PagadoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.PagadoCCDataGridViewTextBoxColumn.HeaderText = "PAGADO"
        Me.PagadoCCDataGridViewTextBoxColumn.Name = "PagadoCCDataGridViewTextBoxColumn"
        '
        'FecPagoCCDataGridViewTextBoxColumn
        '
        Me.FecPagoCCDataGridViewTextBoxColumn.DataPropertyName = "FecPagoCC"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "d"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.FecPagoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.FecPagoCCDataGridViewTextBoxColumn.HeaderText = "FEC.PAGO"
        Me.FecPagoCCDataGridViewTextBoxColumn.Name = "FecPagoCCDataGridViewTextBoxColumn"
        Me.FecPagoCCDataGridViewTextBoxColumn.Width = 80
        '
        'RestoCCDataGridViewTextBoxColumn
        '
        Me.RestoCCDataGridViewTextBoxColumn.DataPropertyName = "RestoCC"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.RestoCCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.RestoCCDataGridViewTextBoxColumn.HeaderText = "RESTO"
        Me.RestoCCDataGridViewTextBoxColumn.Name = "RestoCCDataGridViewTextBoxColumn"
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
        Me.ClientSize = New System.Drawing.Size(1031, 642)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.dgvCtasctes2)
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
        CType(Me.dgvCtasctes2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvCtasctes2 As DataGridView
    Friend WithEvents btnActualizar As Button
    Friend WithEvents ToolTipMsg As ToolTip
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
    Friend WithEvents SaldoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagadoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FecPagoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestoCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

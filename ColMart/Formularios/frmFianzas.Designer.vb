<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFianzas
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFianzas))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApelNombre = New System.Windows.Forms.TextBox()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.txtFecFirma1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFecFirma2 = New System.Windows.Forms.TextBox()
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.FianzasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FianzasTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.fianzasTableAdapter()
        Me.TableAdapterManager = New ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager()
        Me.dgvFianzas = New System.Windows.Forms.DataGridView()
        Me.IdFzaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatriFzaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoFzaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecPagoFzaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecFirma1FzaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserFirma1FzaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecFirma2FzaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserFirma2FzaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecVtoFzaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocFiadorFzaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomFiadorFzaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalleFiadorFzaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelFiadorFzaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDocFiador = New System.Windows.Forms.TextBox()
        Me.txtNombreFiador = New System.Windows.Forms.TextBox()
        Me.txtCalleFiador = New System.Windows.Forms.TextBox()
        Me.txtTelFiador = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FianzasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFianzas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(247, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(510, 36)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Actualizar Fianzas de Matriculados"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(187, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Matriculado:"
        '
        'txtApelNombre
        '
        Me.txtApelNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtApelNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApelNombre.Enabled = False
        Me.txtApelNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApelNombre.ForeColor = System.Drawing.Color.White
        Me.txtApelNombre.Location = New System.Drawing.Point(897, 67)
        Me.txtApelNombre.Name = "txtApelNombre"
        Me.txtApelNombre.Size = New System.Drawing.Size(55, 23)
        Me.txtApelNombre.TabIndex = 1
        Me.txtApelNombre.Visible = False
        '
        'txtMatricula
        '
        Me.txtMatricula.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMatricula.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.ForeColor = System.Drawing.Color.White
        Me.txtMatricula.Location = New System.Drawing.Point(283, 66)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(66, 23)
        Me.txtMatricula.TabIndex = 0
        '
        'txtFecFirma1
        '
        Me.txtFecFirma1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecFirma1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecFirma1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecFirma1.ForeColor = System.Drawing.Color.White
        Me.txtFecFirma1.Location = New System.Drawing.Point(176, 209)
        Me.txtFecFirma1.Name = "txtFecFirma1"
        Me.txtFecFirma1.Size = New System.Drawing.Size(100, 23)
        Me.txtFecFirma1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(47, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Fecha Firma Mat.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(360, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 17)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Fecha Firma Fiador:"
        '
        'txtFecFirma2
        '
        Me.txtFecFirma2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecFirma2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecFirma2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecFirma2.ForeColor = System.Drawing.Color.White
        Me.txtFecFirma2.Location = New System.Drawing.Point(500, 209)
        Me.txtFecFirma2.Name = "txtFecFirma2"
        Me.txtFecFirma2.Size = New System.Drawing.Size(100, 23)
        Me.txtFecFirma2.TabIndex = 7
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FianzasBindingSource
        '
        Me.FianzasBindingSource.DataMember = "fianzas"
        Me.FianzasBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'FianzasTableAdapter
        '
        Me.FianzasTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ctasctesTableAdapter = Nothing
        Me.TableAdapterManager.debehaberTableAdapter = Nothing
        Me.TableAdapterManager.debitomatriTableAdapter = Nothing
        Me.TableAdapterManager.debitosocTableAdapter = Nothing
        Me.TableAdapterManager.departamentoTableAdapter = Nothing
        Me.TableAdapterManager.depositosTableAdapter = Nothing
        Me.TableAdapterManager.detallecpraTableAdapter = Nothing
        Me.TableAdapterManager.fianzasTableAdapter = Me.FianzasTableAdapter
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
        'dgvFianzas
        '
        Me.dgvFianzas.AllowUserToAddRows = False
        Me.dgvFianzas.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.dgvFianzas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvFianzas.AutoGenerateColumns = False
        Me.dgvFianzas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvFianzas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFianzas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvFianzas.ColumnHeadersHeight = 30
        Me.dgvFianzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvFianzas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFzaDataGridViewTextBoxColumn, Me.MatriFzaDataGridViewTextBoxColumn, Me.EstadoFzaDataGridViewTextBoxColumn, Me.FecPagoFzaDataGridViewTextBoxColumn, Me.FecFirma1FzaDataGridViewTextBoxColumn, Me.UserFirma1FzaDataGridViewTextBoxColumn, Me.FecFirma2FzaDataGridViewTextBoxColumn, Me.UserFirma2FzaDataGridViewTextBoxColumn, Me.FecVtoFzaDataGridViewTextBoxColumn, Me.DocFiadorFzaDataGridViewTextBoxColumn, Me.NomFiadorFzaDataGridViewTextBoxColumn, Me.CalleFiadorFzaDataGridViewTextBoxColumn, Me.TelFiadorFzaDataGridViewTextBoxColumn})
        Me.dgvFianzas.DataSource = Me.FianzasBindingSource
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFianzas.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgvFianzas.EnableHeadersVisualStyles = False
        Me.dgvFianzas.GridColor = System.Drawing.Color.White
        Me.dgvFianzas.Location = New System.Drawing.Point(25, 260)
        Me.dgvFianzas.Name = "dgvFianzas"
        Me.dgvFianzas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFianzas.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvFianzas.Size = New System.Drawing.Size(939, 240)
        Me.dgvFianzas.TabIndex = 97
        '
        'IdFzaDataGridViewTextBoxColumn
        '
        Me.IdFzaDataGridViewTextBoxColumn.DataPropertyName = "id_Fza"
        Me.IdFzaDataGridViewTextBoxColumn.HeaderText = "id_Fza"
        Me.IdFzaDataGridViewTextBoxColumn.Name = "IdFzaDataGridViewTextBoxColumn"
        Me.IdFzaDataGridViewTextBoxColumn.Visible = False
        '
        'MatriFzaDataGridViewTextBoxColumn
        '
        Me.MatriFzaDataGridViewTextBoxColumn.DataPropertyName = "MatriFza"
        Me.MatriFzaDataGridViewTextBoxColumn.HeaderText = "MatriFza"
        Me.MatriFzaDataGridViewTextBoxColumn.Name = "MatriFzaDataGridViewTextBoxColumn"
        Me.MatriFzaDataGridViewTextBoxColumn.Visible = False
        '
        'EstadoFzaDataGridViewTextBoxColumn
        '
        Me.EstadoFzaDataGridViewTextBoxColumn.DataPropertyName = "EstadoFza"
        Me.EstadoFzaDataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.EstadoFzaDataGridViewTextBoxColumn.Name = "EstadoFzaDataGridViewTextBoxColumn"
        '
        'FecPagoFzaDataGridViewTextBoxColumn
        '
        Me.FecPagoFzaDataGridViewTextBoxColumn.DataPropertyName = "FecPagoFza"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Format = "d"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.FecPagoFzaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.FecPagoFzaDataGridViewTextBoxColumn.HeaderText = "FEC. PAGO"
        Me.FecPagoFzaDataGridViewTextBoxColumn.Name = "FecPagoFzaDataGridViewTextBoxColumn"
        Me.FecPagoFzaDataGridViewTextBoxColumn.Width = 120
        '
        'FecFirma1FzaDataGridViewTextBoxColumn
        '
        Me.FecFirma1FzaDataGridViewTextBoxColumn.DataPropertyName = "FecFirma1Fza"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.Format = "d"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.FecFirma1FzaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.FecFirma1FzaDataGridViewTextBoxColumn.HeaderText = "FIRMA MATRI."
        Me.FecFirma1FzaDataGridViewTextBoxColumn.Name = "FecFirma1FzaDataGridViewTextBoxColumn"
        Me.FecFirma1FzaDataGridViewTextBoxColumn.Width = 120
        '
        'UserFirma1FzaDataGridViewTextBoxColumn
        '
        Me.UserFirma1FzaDataGridViewTextBoxColumn.DataPropertyName = "UserFirma1Fza"
        Me.UserFirma1FzaDataGridViewTextBoxColumn.HeaderText = "UserFirma1Fza"
        Me.UserFirma1FzaDataGridViewTextBoxColumn.Name = "UserFirma1FzaDataGridViewTextBoxColumn"
        Me.UserFirma1FzaDataGridViewTextBoxColumn.Visible = False
        '
        'FecFirma2FzaDataGridViewTextBoxColumn
        '
        Me.FecFirma2FzaDataGridViewTextBoxColumn.DataPropertyName = "FecFirma2Fza"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.Format = "d"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.FecFirma2FzaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.FecFirma2FzaDataGridViewTextBoxColumn.HeaderText = "FIRMA FIADOR"
        Me.FecFirma2FzaDataGridViewTextBoxColumn.Name = "FecFirma2FzaDataGridViewTextBoxColumn"
        Me.FecFirma2FzaDataGridViewTextBoxColumn.Width = 120
        '
        'UserFirma2FzaDataGridViewTextBoxColumn
        '
        Me.UserFirma2FzaDataGridViewTextBoxColumn.DataPropertyName = "UserFirma2Fza"
        Me.UserFirma2FzaDataGridViewTextBoxColumn.HeaderText = "UserFirma2Fza"
        Me.UserFirma2FzaDataGridViewTextBoxColumn.Name = "UserFirma2FzaDataGridViewTextBoxColumn"
        Me.UserFirma2FzaDataGridViewTextBoxColumn.Visible = False
        '
        'FecVtoFzaDataGridViewTextBoxColumn
        '
        Me.FecVtoFzaDataGridViewTextBoxColumn.DataPropertyName = "FecVtoFza"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Format = "d"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.FecVtoFzaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.FecVtoFzaDataGridViewTextBoxColumn.HeaderText = "FECHA VTO."
        Me.FecVtoFzaDataGridViewTextBoxColumn.Name = "FecVtoFzaDataGridViewTextBoxColumn"
        Me.FecVtoFzaDataGridViewTextBoxColumn.Width = 120
        '
        'DocFiadorFzaDataGridViewTextBoxColumn
        '
        Me.DocFiadorFzaDataGridViewTextBoxColumn.DataPropertyName = "DocFiadorFza"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DocFiadorFzaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle16
        Me.DocFiadorFzaDataGridViewTextBoxColumn.HeaderText = "DOCUM."
        Me.DocFiadorFzaDataGridViewTextBoxColumn.Name = "DocFiadorFzaDataGridViewTextBoxColumn"
        '
        'NomFiadorFzaDataGridViewTextBoxColumn
        '
        Me.NomFiadorFzaDataGridViewTextBoxColumn.DataPropertyName = "NomFiadorFza"
        Me.NomFiadorFzaDataGridViewTextBoxColumn.HeaderText = "APELLIDO Y NOMBRE"
        Me.NomFiadorFzaDataGridViewTextBoxColumn.Name = "NomFiadorFzaDataGridViewTextBoxColumn"
        Me.NomFiadorFzaDataGridViewTextBoxColumn.Width = 200
        '
        'CalleFiadorFzaDataGridViewTextBoxColumn
        '
        Me.CalleFiadorFzaDataGridViewTextBoxColumn.DataPropertyName = "CalleFiadorFza"
        Me.CalleFiadorFzaDataGridViewTextBoxColumn.HeaderText = "DOMICILIO"
        Me.CalleFiadorFzaDataGridViewTextBoxColumn.Name = "CalleFiadorFzaDataGridViewTextBoxColumn"
        Me.CalleFiadorFzaDataGridViewTextBoxColumn.Width = 200
        '
        'TelFiadorFzaDataGridViewTextBoxColumn
        '
        Me.TelFiadorFzaDataGridViewTextBoxColumn.DataPropertyName = "TelFiadorFza"
        Me.TelFiadorFzaDataGridViewTextBoxColumn.HeaderText = "TELÉFONO"
        Me.TelFiadorFzaDataGridViewTextBoxColumn.Name = "TelFiadorFzaDataGridViewTextBoxColumn"
        '
        'txtDocFiador
        '
        Me.txtDocFiador.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDocFiador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocFiador.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocFiador.ForeColor = System.Drawing.Color.White
        Me.txtDocFiador.Location = New System.Drawing.Point(215, 114)
        Me.txtDocFiador.Name = "txtDocFiador"
        Me.txtDocFiador.Size = New System.Drawing.Size(100, 23)
        Me.txtDocFiador.TabIndex = 2
        '
        'txtNombreFiador
        '
        Me.txtNombreFiador.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombreFiador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreFiador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreFiador.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreFiador.ForeColor = System.Drawing.Color.White
        Me.txtNombreFiador.Location = New System.Drawing.Point(459, 114)
        Me.txtNombreFiador.Name = "txtNombreFiador"
        Me.txtNombreFiador.Size = New System.Drawing.Size(331, 23)
        Me.txtNombreFiador.TabIndex = 3
        '
        'txtCalleFiador
        '
        Me.txtCalleFiador.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCalleFiador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalleFiador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalleFiador.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalleFiador.ForeColor = System.Drawing.Color.White
        Me.txtCalleFiador.Location = New System.Drawing.Point(215, 143)
        Me.txtCalleFiador.Name = "txtCalleFiador"
        Me.txtCalleFiador.Size = New System.Drawing.Size(290, 23)
        Me.txtCalleFiador.TabIndex = 4
        '
        'txtTelFiador
        '
        Me.txtTelFiador.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTelFiador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelFiador.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelFiador.ForeColor = System.Drawing.Color.White
        Me.txtTelFiador.Location = New System.Drawing.Point(583, 143)
        Me.txtTelFiador.Name = "txtTelFiador"
        Me.txtTelFiador.Size = New System.Drawing.Size(207, 23)
        Me.txtTelFiador.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(122, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Doc. Fiador:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(321, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 17)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Apellido y Nombre:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(136, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Domicilio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(511, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Teléfono:"
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
        Me.btnSalir.Location = New System.Drawing.Point(818, 518)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(99, 44)
        Me.btnSalir.TabIndex = 106
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
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
        Me.btnLimpiar.Location = New System.Drawing.Point(322, 518)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(99, 44)
        Me.btnLimpiar.TabIndex = 107
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.AutoSize = True
        Me.BtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGrabar.FlatAppearance.BorderSize = 0
        Me.BtnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrabar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.ForeColor = System.Drawing.Color.White
        Me.BtnGrabar.Image = CType(resources.GetObject("BtnGrabar.Image"), System.Drawing.Image)
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGrabar.Location = New System.Drawing.Point(571, 518)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGrabar.Size = New System.Drawing.Size(97, 44)
        Me.BtnGrabar.TabIndex = 108
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Yellow
        Me.lblEstado.Location = New System.Drawing.Point(660, 208)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(16, 19)
        Me.lblEstado.TabIndex = 157
        Me.lblEstado.Text = "-"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(25, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(939, 41)
        Me.PictureBox1.TabIndex = 158
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(25, 104)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(939, 73)
        Me.PictureBox2.TabIndex = 159
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(25, 186)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(939, 68)
        Me.PictureBox3.TabIndex = 160
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(25, 505)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(939, 73)
        Me.PictureBox4.TabIndex = 161
        Me.PictureBox4.TabStop = False
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
        Me.btnImprimir.Location = New System.Drawing.Point(69, 518)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(103, 44)
        Me.btnImprimir.TabIndex = 162
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
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
        Me.btnActualizar.Location = New System.Drawing.Point(833, 197)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(119, 44)
        Me.btnActualizar.TabIndex = 163
        Me.btnActualizar.Text = "Blanquear"
        Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(355, 69)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(14, 17)
        Me.lblNombre.TabIndex = 164
        Me.lblNombre.Text = "-"
        '
        'frmFianzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 601)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTelFiador)
        Me.Controls.Add(Me.txtCalleFiador)
        Me.Controls.Add(Me.txtNombreFiador)
        Me.Controls.Add(Me.txtDocFiador)
        Me.Controls.Add(Me.dgvFianzas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFecFirma2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFecFirma1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtApelNombre)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmFianzas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZACIÓN DE FIANZAS"
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FianzasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFianzas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtApelNombre As TextBox
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents txtFecFirma1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFecFirma2 As TextBox
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents FianzasBindingSource As BindingSource
    Friend WithEvents FianzasTableAdapter As dbcolmartDataSetTableAdapters.fianzasTableAdapter
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvFianzas As DataGridView
    Friend WithEvents txtDocFiador As TextBox
    Friend WithEvents txtNombreFiador As TextBox
    Friend WithEvents txtCalleFiador As TextBox
    Friend WithEvents txtTelFiador As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents UserFecFirmaFzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents lblEstado As Label
    Friend WithEvents IdFzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatriFzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoFzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FecPagoFzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FecFirma1FzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserFirma1FzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FecFirma2FzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserFirma2FzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FecVtoFzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocFiadorFzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomFiadorFzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalleFiadorFzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelFiadorFzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents lblNombre As Label
End Class

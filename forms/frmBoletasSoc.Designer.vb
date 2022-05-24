<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoletasSoc
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBoletasSoc))
        Me.dbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.boletasTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.boletasTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSociedad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dgvBoletas = New System.Windows.Forms.DataGridView()
        Me.MatBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApelNomBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalleBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodPosBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecVtoBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodoBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecPagoBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaPagoBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concepto1BoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpCon1BoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concepto2BoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpCon2BoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concepto3BoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpCon3BoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concepto4BoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpCon4BoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MailBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroPagoBoleta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BoletasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnReliquidar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBoletas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoletasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbcolmartDataSet
        '
        Me.dbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.dbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.Gainsboro
        Me.ReportViewer1.ForeColor = System.Drawing.Color.White
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Nothing
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ColMart.rptBoletas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 417)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(618, 192)
        Me.ReportViewer1.TabIndex = 9
        Me.ReportViewer1.ZoomPercent = 80
        '
        'boletasTableAdapter
        '
        Me.boletasTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sociedad:"
        '
        'txtSociedad
        '
        Me.txtSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSociedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSociedad.ForeColor = System.Drawing.Color.White
        Me.txtSociedad.Location = New System.Drawing.Point(117, 56)
        Me.txtSociedad.Name = "txtSociedad"
        Me.txtSociedad.Size = New System.Drawing.Size(58, 23)
        Me.txtSociedad.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(181, 56)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(293, 23)
        Me.txtNombre.TabIndex = 2
        '
        'dgvBoletas
        '
        Me.dgvBoletas.AllowUserToAddRows = False
        Me.dgvBoletas.AllowUserToDeleteRows = False
        Me.dgvBoletas.AllowUserToOrderColumns = True
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.dgvBoletas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvBoletas.AutoGenerateColumns = False
        Me.dgvBoletas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvBoletas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBoletas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvBoletas.ColumnHeadersHeight = 30
        Me.dgvBoletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBoletas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatBoletaDataGridViewTextBoxColumn, Me.ApelNomBoletaDataGridViewTextBoxColumn, Me.CalleBoletaDataGridViewTextBoxColumn, Me.CodPosBoletaDataGridViewTextBoxColumn, Me.LocalBoletaDataGridViewTextBoxColumn, Me.ProvBoletaDataGridViewTextBoxColumn, Me.FecVtoBoletaDataGridViewTextBoxColumn, Me.PeriodoBoletaDataGridViewTextBoxColumn, Me.ImporteBoletaDataGridViewTextBoxColumn, Me.EstadoBoletaDataGridViewTextBoxColumn, Me.FecPagoBoletaDataGridViewTextBoxColumn, Me.FormaPagoBoletaDataGridViewTextBoxColumn, Me.Concepto1BoletaDataGridViewTextBoxColumn, Me.ImpCon1BoletaDataGridViewTextBoxColumn, Me.Concepto2BoletaDataGridViewTextBoxColumn, Me.ImpCon2BoletaDataGridViewTextBoxColumn, Me.Concepto3BoletaDataGridViewTextBoxColumn, Me.ImpCon3BoletaDataGridViewTextBoxColumn, Me.Concepto4BoletaDataGridViewTextBoxColumn, Me.ImpCon4BoletaDataGridViewTextBoxColumn, Me.MailBoletaDataGridViewTextBoxColumn, Me.CodigoBoletaDataGridViewTextBoxColumn, Me.NroPagoBoleta})
        Me.dgvBoletas.DataSource = Me.BoletasBindingSource
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBoletas.DefaultCellStyle = DataGridViewCellStyle29
        Me.dgvBoletas.EnableHeadersVisualStyles = False
        Me.dgvBoletas.GridColor = System.Drawing.Color.White
        Me.dgvBoletas.Location = New System.Drawing.Point(10, 98)
        Me.dgvBoletas.Name = "dgvBoletas"
        Me.dgvBoletas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBoletas.RowHeadersDefaultCellStyle = DataGridViewCellStyle30
        Me.dgvBoletas.Size = New System.Drawing.Size(620, 240)
        Me.dgvBoletas.TabIndex = 7
        '
        'MatBoletaDataGridViewTextBoxColumn
        '
        Me.MatBoletaDataGridViewTextBoxColumn.DataPropertyName = "MatBoleta"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.MatBoletaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle18
        Me.MatBoletaDataGridViewTextBoxColumn.HeaderText = "MAT"
        Me.MatBoletaDataGridViewTextBoxColumn.Name = "MatBoletaDataGridViewTextBoxColumn"
        Me.MatBoletaDataGridViewTextBoxColumn.Visible = False
        Me.MatBoletaDataGridViewTextBoxColumn.Width = 50
        '
        'ApelNomBoletaDataGridViewTextBoxColumn
        '
        Me.ApelNomBoletaDataGridViewTextBoxColumn.DataPropertyName = "ApelNomBoleta"
        Me.ApelNomBoletaDataGridViewTextBoxColumn.HeaderText = "APELLIDO Y NOMBRES"
        Me.ApelNomBoletaDataGridViewTextBoxColumn.Name = "ApelNomBoletaDataGridViewTextBoxColumn"
        Me.ApelNomBoletaDataGridViewTextBoxColumn.Visible = False
        Me.ApelNomBoletaDataGridViewTextBoxColumn.Width = 200
        '
        'CalleBoletaDataGridViewTextBoxColumn
        '
        Me.CalleBoletaDataGridViewTextBoxColumn.DataPropertyName = "CalleBoleta"
        Me.CalleBoletaDataGridViewTextBoxColumn.HeaderText = "CalleBoleta"
        Me.CalleBoletaDataGridViewTextBoxColumn.Name = "CalleBoletaDataGridViewTextBoxColumn"
        Me.CalleBoletaDataGridViewTextBoxColumn.Visible = False
        '
        'CodPosBoletaDataGridViewTextBoxColumn
        '
        Me.CodPosBoletaDataGridViewTextBoxColumn.DataPropertyName = "CodPosBoleta"
        Me.CodPosBoletaDataGridViewTextBoxColumn.HeaderText = "CodPosBoleta"
        Me.CodPosBoletaDataGridViewTextBoxColumn.Name = "CodPosBoletaDataGridViewTextBoxColumn"
        Me.CodPosBoletaDataGridViewTextBoxColumn.Visible = False
        '
        'LocalBoletaDataGridViewTextBoxColumn
        '
        Me.LocalBoletaDataGridViewTextBoxColumn.DataPropertyName = "LocalBoleta"
        Me.LocalBoletaDataGridViewTextBoxColumn.HeaderText = "LocalBoleta"
        Me.LocalBoletaDataGridViewTextBoxColumn.Name = "LocalBoletaDataGridViewTextBoxColumn"
        Me.LocalBoletaDataGridViewTextBoxColumn.Visible = False
        '
        'ProvBoletaDataGridViewTextBoxColumn
        '
        Me.ProvBoletaDataGridViewTextBoxColumn.DataPropertyName = "ProvBoleta"
        Me.ProvBoletaDataGridViewTextBoxColumn.HeaderText = "ProvBoleta"
        Me.ProvBoletaDataGridViewTextBoxColumn.Name = "ProvBoletaDataGridViewTextBoxColumn"
        Me.ProvBoletaDataGridViewTextBoxColumn.Visible = False
        '
        'FecVtoBoletaDataGridViewTextBoxColumn
        '
        Me.FecVtoBoletaDataGridViewTextBoxColumn.DataPropertyName = "FecVtoBoleta"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.Format = "d"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.FecVtoBoletaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle19
        Me.FecVtoBoletaDataGridViewTextBoxColumn.HeaderText = "VENCIMIENTO"
        Me.FecVtoBoletaDataGridViewTextBoxColumn.Name = "FecVtoBoletaDataGridViewTextBoxColumn"
        '
        'PeriodoBoletaDataGridViewTextBoxColumn
        '
        Me.PeriodoBoletaDataGridViewTextBoxColumn.DataPropertyName = "PeriodoBoleta"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PeriodoBoletaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle20
        Me.PeriodoBoletaDataGridViewTextBoxColumn.HeaderText = "PERIODO"
        Me.PeriodoBoletaDataGridViewTextBoxColumn.Name = "PeriodoBoletaDataGridViewTextBoxColumn"
        Me.PeriodoBoletaDataGridViewTextBoxColumn.Width = 65
        '
        'ImporteBoletaDataGridViewTextBoxColumn
        '
        Me.ImporteBoletaDataGridViewTextBoxColumn.DataPropertyName = "ImporteBoleta"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "C2"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.ImporteBoletaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle21
        Me.ImporteBoletaDataGridViewTextBoxColumn.HeaderText = "IMPORTE"
        Me.ImporteBoletaDataGridViewTextBoxColumn.Name = "ImporteBoletaDataGridViewTextBoxColumn"
        '
        'EstadoBoletaDataGridViewTextBoxColumn
        '
        Me.EstadoBoletaDataGridViewTextBoxColumn.DataPropertyName = "EstadoBoleta"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.EstadoBoletaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle22
        Me.EstadoBoletaDataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.EstadoBoletaDataGridViewTextBoxColumn.Name = "EstadoBoletaDataGridViewTextBoxColumn"
        '
        'FecPagoBoletaDataGridViewTextBoxColumn
        '
        Me.FecPagoBoletaDataGridViewTextBoxColumn.DataPropertyName = "FecPagoBoleta"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.Format = "d"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.FecPagoBoletaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle23
        Me.FecPagoBoletaDataGridViewTextBoxColumn.HeaderText = "FECHA PAGO"
        Me.FecPagoBoletaDataGridViewTextBoxColumn.Name = "FecPagoBoletaDataGridViewTextBoxColumn"
        '
        'FormaPagoBoletaDataGridViewTextBoxColumn
        '
        Me.FormaPagoBoletaDataGridViewTextBoxColumn.DataPropertyName = "FormaPagoBoleta"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FormaPagoBoletaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle24
        Me.FormaPagoBoletaDataGridViewTextBoxColumn.HeaderText = "FORMA PAGO"
        Me.FormaPagoBoletaDataGridViewTextBoxColumn.Name = "FormaPagoBoletaDataGridViewTextBoxColumn"
        Me.FormaPagoBoletaDataGridViewTextBoxColumn.Width = 105
        '
        'Concepto1BoletaDataGridViewTextBoxColumn
        '
        Me.Concepto1BoletaDataGridViewTextBoxColumn.DataPropertyName = "Concepto1Boleta"
        Me.Concepto1BoletaDataGridViewTextBoxColumn.HeaderText = "CONCEPTO 1"
        Me.Concepto1BoletaDataGridViewTextBoxColumn.Name = "Concepto1BoletaDataGridViewTextBoxColumn"
        Me.Concepto1BoletaDataGridViewTextBoxColumn.Width = 150
        '
        'ImpCon1BoletaDataGridViewTextBoxColumn
        '
        Me.ImpCon1BoletaDataGridViewTextBoxColumn.DataPropertyName = "ImpCon1Boleta"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle25.Format = "C2"
        DataGridViewCellStyle25.NullValue = Nothing
        Me.ImpCon1BoletaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle25
        Me.ImpCon1BoletaDataGridViewTextBoxColumn.HeaderText = "IMPORTE 1"
        Me.ImpCon1BoletaDataGridViewTextBoxColumn.Name = "ImpCon1BoletaDataGridViewTextBoxColumn"
        '
        'Concepto2BoletaDataGridViewTextBoxColumn
        '
        Me.Concepto2BoletaDataGridViewTextBoxColumn.DataPropertyName = "Concepto2Boleta"
        Me.Concepto2BoletaDataGridViewTextBoxColumn.HeaderText = "CONCEPTO 2"
        Me.Concepto2BoletaDataGridViewTextBoxColumn.Name = "Concepto2BoletaDataGridViewTextBoxColumn"
        Me.Concepto2BoletaDataGridViewTextBoxColumn.Width = 150
        '
        'ImpCon2BoletaDataGridViewTextBoxColumn
        '
        Me.ImpCon2BoletaDataGridViewTextBoxColumn.DataPropertyName = "ImpCon2Boleta"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle26.Format = "C2"
        DataGridViewCellStyle26.NullValue = Nothing
        Me.ImpCon2BoletaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle26
        Me.ImpCon2BoletaDataGridViewTextBoxColumn.HeaderText = "IMPORTE 2"
        Me.ImpCon2BoletaDataGridViewTextBoxColumn.Name = "ImpCon2BoletaDataGridViewTextBoxColumn"
        '
        'Concepto3BoletaDataGridViewTextBoxColumn
        '
        Me.Concepto3BoletaDataGridViewTextBoxColumn.DataPropertyName = "Concepto3Boleta"
        Me.Concepto3BoletaDataGridViewTextBoxColumn.HeaderText = "CONCEPTO 3"
        Me.Concepto3BoletaDataGridViewTextBoxColumn.Name = "Concepto3BoletaDataGridViewTextBoxColumn"
        Me.Concepto3BoletaDataGridViewTextBoxColumn.Width = 150
        '
        'ImpCon3BoletaDataGridViewTextBoxColumn
        '
        Me.ImpCon3BoletaDataGridViewTextBoxColumn.DataPropertyName = "ImpCon3Boleta"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Format = "C2"
        DataGridViewCellStyle27.NullValue = Nothing
        Me.ImpCon3BoletaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle27
        Me.ImpCon3BoletaDataGridViewTextBoxColumn.HeaderText = "IMPORTE 3"
        Me.ImpCon3BoletaDataGridViewTextBoxColumn.Name = "ImpCon3BoletaDataGridViewTextBoxColumn"
        '
        'Concepto4BoletaDataGridViewTextBoxColumn
        '
        Me.Concepto4BoletaDataGridViewTextBoxColumn.DataPropertyName = "Concepto4Boleta"
        Me.Concepto4BoletaDataGridViewTextBoxColumn.HeaderText = "CONCEPTO 4"
        Me.Concepto4BoletaDataGridViewTextBoxColumn.Name = "Concepto4BoletaDataGridViewTextBoxColumn"
        Me.Concepto4BoletaDataGridViewTextBoxColumn.Width = 150
        '
        'ImpCon4BoletaDataGridViewTextBoxColumn
        '
        Me.ImpCon4BoletaDataGridViewTextBoxColumn.DataPropertyName = "ImpCon4Boleta"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.Format = "C2"
        DataGridViewCellStyle28.NullValue = Nothing
        Me.ImpCon4BoletaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle28
        Me.ImpCon4BoletaDataGridViewTextBoxColumn.HeaderText = "IMPORTE 4"
        Me.ImpCon4BoletaDataGridViewTextBoxColumn.Name = "ImpCon4BoletaDataGridViewTextBoxColumn"
        '
        'MailBoletaDataGridViewTextBoxColumn
        '
        Me.MailBoletaDataGridViewTextBoxColumn.DataPropertyName = "MailBoleta"
        Me.MailBoletaDataGridViewTextBoxColumn.HeaderText = "MAIL"
        Me.MailBoletaDataGridViewTextBoxColumn.Name = "MailBoletaDataGridViewTextBoxColumn"
        Me.MailBoletaDataGridViewTextBoxColumn.Visible = False
        Me.MailBoletaDataGridViewTextBoxColumn.Width = 150
        '
        'CodigoBoletaDataGridViewTextBoxColumn
        '
        Me.CodigoBoletaDataGridViewTextBoxColumn.DataPropertyName = "CodigoBoleta"
        Me.CodigoBoletaDataGridViewTextBoxColumn.HeaderText = "CodigoBoleta"
        Me.CodigoBoletaDataGridViewTextBoxColumn.Name = "CodigoBoletaDataGridViewTextBoxColumn"
        Me.CodigoBoletaDataGridViewTextBoxColumn.Visible = False
        '
        'NroPagoBoleta
        '
        Me.NroPagoBoleta.DataPropertyName = "NroPagoBoleta"
        Me.NroPagoBoleta.HeaderText = "NroPagoBoleta"
        Me.NroPagoBoleta.Name = "NroPagoBoleta"
        '
        'BoletasBindingSource
        '
        Me.BoletasBindingSource.DataMember = "boletas"
        Me.BoletasBindingSource.DataSource = Me.dbcolmartDataSet
        '
        'btnReliquidar
        '
        Me.btnReliquidar.Enabled = False
        Me.btnReliquidar.FlatAppearance.BorderSize = 0
        Me.btnReliquidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReliquidar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReliquidar.ForeColor = System.Drawing.Color.White
        Me.btnReliquidar.Image = CType(resources.GetObject("btnReliquidar.Image"), System.Drawing.Image)
        Me.btnReliquidar.Location = New System.Drawing.Point(142, 350)
        Me.btnReliquidar.Name = "btnReliquidar"
        Me.btnReliquidar.Size = New System.Drawing.Size(92, 55)
        Me.btnReliquidar.TabIndex = 13
        Me.btnReliquidar.Text = "RE-Liquidar"
        Me.btnReliquidar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReliquidar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnReliquidar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(47, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(521, 36)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Consulta de Boletas de Sociedades"
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(418, 350)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(92, 55)
        Me.btnSalir.TabIndex = 86
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(11, 343)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(619, 69)
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(10, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(620, 42)
        Me.PictureBox2.TabIndex = 88
        Me.PictureBox2.TabStop = False
        '
        'frmBoletasSoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(639, 619)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnReliquidar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtSociedad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.dgvBoletas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBoletasSoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REIMPRESIÓN DE BOLETAS SOCIEDADES"
        CType(Me.dbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBoletas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoletasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents boletasTableAdapter As dbcolmartDataSetTableAdapters.boletasTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSociedad As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents dgvBoletas As DataGridView
    Friend WithEvents btnReliquidar As Button
    Friend WithEvents BoletasBindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MatBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApelNomBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalleBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodPosBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FecVtoBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeriodoBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FecPagoBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormaPagoBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Concepto1BoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpCon1BoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Concepto2BoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpCon2BoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Concepto3BoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpCon3BoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Concepto4BoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpCon4BoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MailBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroPagoBoleta As DataGridViewTextBoxColumn
End Class

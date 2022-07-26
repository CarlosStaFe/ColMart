<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsMatri
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsMatri))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.dgvMatriculados = New System.Windows.Forms.DataGridView()
        Me.IdMatriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroMatriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApelNombMatriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApelMatMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecNacMatriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LugarNacMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NacionNacMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocMatriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroDocMatriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoMatriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstCivilMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuitMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecJurMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatAporteMatriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecEstadoMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalleRealMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPRealMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CeluRealMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FijoRealMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalleLegalMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPLegalMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CeluLegalMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FijoLegalMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FianzaMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocFiadorMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiadorMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalleFiadorMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsMatri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatriculadosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MatriculadosTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.matriculadosTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvMatriculados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatriculadosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellido Matriculado:"
        '
        'txtApellido
        '
        Me.txtApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.ForeColor = System.Drawing.Color.White
        Me.txtApellido.Location = New System.Drawing.Point(184, 58)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(491, 23)
        Me.txtApellido.TabIndex = 1
        '
        'dgvMatriculados
        '
        Me.dgvMatriculados.AllowUserToAddRows = False
        Me.dgvMatriculados.AllowUserToDeleteRows = False
        Me.dgvMatriculados.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvMatriculados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMatriculados.AutoGenerateColumns = False
        Me.dgvMatriculados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvMatriculados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMatriculados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMatriculados.ColumnHeadersHeight = 40
        Me.dgvMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMatriculados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMatriDataGridViewTextBoxColumn, Me.NroMatriDataGridViewTextBoxColumn, Me.ApelNombMatriDataGridViewTextBoxColumn, Me.ApelMatMatri, Me.FecNacMatriDataGridViewTextBoxColumn, Me.LugarNacMatri, Me.NacionNacMatri, Me.TipoDocMatriDataGridViewTextBoxColumn, Me.NroDocMatriDataGridViewTextBoxColumn, Me.SexoMatriDataGridViewTextBoxColumn, Me.EstCivilMatri, Me.CuitMatri, Me.FecJurMatri, Me.CatAporteMatriDataGridViewTextBoxColumn, Me.EstadoMatri, Me.FecEstadoMatri, Me.CalleRealMatri, Me.CPRealMatri, Me.EmailMatri, Me.CeluRealMatri, Me.FijoRealMatri, Me.CalleLegalMatri, Me.CPLegalMatri, Me.CeluLegalMatri, Me.FijoLegalMatri, Me.FianzaMatri, Me.DocFiadorMatri, Me.FiadorMatri, Me.CalleFiadorMatri, Me.ObsMatri})
        Me.dgvMatriculados.DataSource = Me.MatriculadosBindingSource1
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMatriculados.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvMatriculados.EnableHeadersVisualStyles = False
        Me.dgvMatriculados.GridColor = System.Drawing.Color.White
        Me.dgvMatriculados.Location = New System.Drawing.Point(14, 100)
        Me.dgvMatriculados.Name = "dgvMatriculados"
        Me.dgvMatriculados.ReadOnly = True
        Me.dgvMatriculados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMatriculados.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvMatriculados.Size = New System.Drawing.Size(771, 367)
        Me.dgvMatriculados.TabIndex = 2
        '
        'IdMatriDataGridViewTextBoxColumn
        '
        Me.IdMatriDataGridViewTextBoxColumn.DataPropertyName = "id_Matri"
        Me.IdMatriDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdMatriDataGridViewTextBoxColumn.Name = "IdMatriDataGridViewTextBoxColumn"
        Me.IdMatriDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdMatriDataGridViewTextBoxColumn.Visible = False
        Me.IdMatriDataGridViewTextBoxColumn.Width = 50
        '
        'NroMatriDataGridViewTextBoxColumn
        '
        Me.NroMatriDataGridViewTextBoxColumn.DataPropertyName = "NroMatri"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NroMatriDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.NroMatriDataGridViewTextBoxColumn.HeaderText = "MAT."
        Me.NroMatriDataGridViewTextBoxColumn.Name = "NroMatriDataGridViewTextBoxColumn"
        Me.NroMatriDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroMatriDataGridViewTextBoxColumn.Width = 50
        '
        'ApelNombMatriDataGridViewTextBoxColumn
        '
        Me.ApelNombMatriDataGridViewTextBoxColumn.DataPropertyName = "ApelNombMatri"
        Me.ApelNombMatriDataGridViewTextBoxColumn.HeaderText = "APELLIDO Y NOMBRES"
        Me.ApelNombMatriDataGridViewTextBoxColumn.Name = "ApelNombMatriDataGridViewTextBoxColumn"
        Me.ApelNombMatriDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApelNombMatriDataGridViewTextBoxColumn.Width = 280
        '
        'ApelMatMatri
        '
        Me.ApelMatMatri.DataPropertyName = "ApelMatMatri"
        Me.ApelMatMatri.HeaderText = "ApelMatMatri"
        Me.ApelMatMatri.Name = "ApelMatMatri"
        Me.ApelMatMatri.ReadOnly = True
        Me.ApelMatMatri.Visible = False
        '
        'FecNacMatriDataGridViewTextBoxColumn
        '
        Me.FecNacMatriDataGridViewTextBoxColumn.DataPropertyName = "FecNacMatri"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.FecNacMatriDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.FecNacMatriDataGridViewTextBoxColumn.HeaderText = "FECHA NACIM."
        Me.FecNacMatriDataGridViewTextBoxColumn.Name = "FecNacMatriDataGridViewTextBoxColumn"
        Me.FecNacMatriDataGridViewTextBoxColumn.ReadOnly = True
        Me.FecNacMatriDataGridViewTextBoxColumn.Visible = False
        Me.FecNacMatriDataGridViewTextBoxColumn.Width = 90
        '
        'LugarNacMatri
        '
        Me.LugarNacMatri.DataPropertyName = "LugarNacMatri"
        Me.LugarNacMatri.HeaderText = "LugarNacMatri"
        Me.LugarNacMatri.Name = "LugarNacMatri"
        Me.LugarNacMatri.ReadOnly = True
        Me.LugarNacMatri.Visible = False
        '
        'NacionNacMatri
        '
        Me.NacionNacMatri.DataPropertyName = "NacionNacMatri"
        Me.NacionNacMatri.HeaderText = "NacionNacMatri"
        Me.NacionNacMatri.Name = "NacionNacMatri"
        Me.NacionNacMatri.ReadOnly = True
        Me.NacionNacMatri.Visible = False
        '
        'TipoDocMatriDataGridViewTextBoxColumn
        '
        Me.TipoDocMatriDataGridViewTextBoxColumn.DataPropertyName = "TipoDocMatri"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TipoDocMatriDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.TipoDocMatriDataGridViewTextBoxColumn.HeaderText = "TIPO DOCUM."
        Me.TipoDocMatriDataGridViewTextBoxColumn.Name = "TipoDocMatriDataGridViewTextBoxColumn"
        Me.TipoDocMatriDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDocMatriDataGridViewTextBoxColumn.Width = 60
        '
        'NroDocMatriDataGridViewTextBoxColumn
        '
        Me.NroDocMatriDataGridViewTextBoxColumn.DataPropertyName = "NroDocMatri"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NroDocMatriDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.NroDocMatriDataGridViewTextBoxColumn.HeaderText = "NRO. DOCUM."
        Me.NroDocMatriDataGridViewTextBoxColumn.Name = "NroDocMatriDataGridViewTextBoxColumn"
        Me.NroDocMatriDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroDocMatriDataGridViewTextBoxColumn.Width = 70
        '
        'SexoMatriDataGridViewTextBoxColumn
        '
        Me.SexoMatriDataGridViewTextBoxColumn.DataPropertyName = "SexoMatri"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SexoMatriDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.SexoMatriDataGridViewTextBoxColumn.HeaderText = "SEXO"
        Me.SexoMatriDataGridViewTextBoxColumn.Name = "SexoMatriDataGridViewTextBoxColumn"
        Me.SexoMatriDataGridViewTextBoxColumn.ReadOnly = True
        Me.SexoMatriDataGridViewTextBoxColumn.Width = 50
        '
        'EstCivilMatri
        '
        Me.EstCivilMatri.DataPropertyName = "EstCivilMatri"
        Me.EstCivilMatri.HeaderText = "EstCivilMatri"
        Me.EstCivilMatri.Name = "EstCivilMatri"
        Me.EstCivilMatri.ReadOnly = True
        Me.EstCivilMatri.Visible = False
        '
        'CuitMatri
        '
        Me.CuitMatri.DataPropertyName = "CuitMatri"
        Me.CuitMatri.HeaderText = "CuitMatri"
        Me.CuitMatri.Name = "CuitMatri"
        Me.CuitMatri.ReadOnly = True
        Me.CuitMatri.Visible = False
        '
        'FecJurMatri
        '
        Me.FecJurMatri.DataPropertyName = "FecJurMatri"
        Me.FecJurMatri.HeaderText = "FecJurMatri"
        Me.FecJurMatri.Name = "FecJurMatri"
        Me.FecJurMatri.ReadOnly = True
        Me.FecJurMatri.Visible = False
        '
        'CatAporteMatriDataGridViewTextBoxColumn
        '
        Me.CatAporteMatriDataGridViewTextBoxColumn.DataPropertyName = "CatAporteMatri"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CatAporteMatriDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.CatAporteMatriDataGridViewTextBoxColumn.HeaderText = "APORTE"
        Me.CatAporteMatriDataGridViewTextBoxColumn.Name = "CatAporteMatriDataGridViewTextBoxColumn"
        Me.CatAporteMatriDataGridViewTextBoxColumn.ReadOnly = True
        Me.CatAporteMatriDataGridViewTextBoxColumn.Width = 60
        '
        'EstadoMatri
        '
        Me.EstadoMatri.DataPropertyName = "EstadoMatri"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.EstadoMatri.DefaultCellStyle = DataGridViewCellStyle9
        Me.EstadoMatri.HeaderText = "ESTADO"
        Me.EstadoMatri.Name = "EstadoMatri"
        Me.EstadoMatri.ReadOnly = True
        Me.EstadoMatri.Width = 150
        '
        'FecEstadoMatri
        '
        Me.FecEstadoMatri.DataPropertyName = "FecEstadoMatri"
        Me.FecEstadoMatri.HeaderText = "FecEstadoMatri"
        Me.FecEstadoMatri.Name = "FecEstadoMatri"
        Me.FecEstadoMatri.ReadOnly = True
        Me.FecEstadoMatri.Visible = False
        '
        'CalleRealMatri
        '
        Me.CalleRealMatri.DataPropertyName = "CalleRealMatri"
        Me.CalleRealMatri.HeaderText = "CalleRealMatri"
        Me.CalleRealMatri.Name = "CalleRealMatri"
        Me.CalleRealMatri.ReadOnly = True
        Me.CalleRealMatri.Visible = False
        '
        'CPRealMatri
        '
        Me.CPRealMatri.DataPropertyName = "CPRealMatri"
        Me.CPRealMatri.HeaderText = "CPRealMatri"
        Me.CPRealMatri.Name = "CPRealMatri"
        Me.CPRealMatri.ReadOnly = True
        Me.CPRealMatri.Visible = False
        '
        'EmailMatri
        '
        Me.EmailMatri.DataPropertyName = "EmailMatri"
        Me.EmailMatri.HeaderText = "EmailMatri"
        Me.EmailMatri.Name = "EmailMatri"
        Me.EmailMatri.ReadOnly = True
        Me.EmailMatri.Visible = False
        '
        'CeluRealMatri
        '
        Me.CeluRealMatri.DataPropertyName = "CeluRealMatri"
        Me.CeluRealMatri.HeaderText = "CeluRealMatri"
        Me.CeluRealMatri.Name = "CeluRealMatri"
        Me.CeluRealMatri.ReadOnly = True
        Me.CeluRealMatri.Visible = False
        '
        'FijoRealMatri
        '
        Me.FijoRealMatri.DataPropertyName = "FijoRealMatri"
        Me.FijoRealMatri.HeaderText = "FijoRealMatri"
        Me.FijoRealMatri.Name = "FijoRealMatri"
        Me.FijoRealMatri.ReadOnly = True
        Me.FijoRealMatri.Visible = False
        '
        'CalleLegalMatri
        '
        Me.CalleLegalMatri.DataPropertyName = "CalleLegalMatri"
        Me.CalleLegalMatri.HeaderText = "CalleLegalMatri"
        Me.CalleLegalMatri.Name = "CalleLegalMatri"
        Me.CalleLegalMatri.ReadOnly = True
        Me.CalleLegalMatri.Visible = False
        '
        'CPLegalMatri
        '
        Me.CPLegalMatri.DataPropertyName = "CPLegalMatri"
        Me.CPLegalMatri.HeaderText = "CPLegalMatri"
        Me.CPLegalMatri.Name = "CPLegalMatri"
        Me.CPLegalMatri.ReadOnly = True
        Me.CPLegalMatri.Visible = False
        '
        'CeluLegalMatri
        '
        Me.CeluLegalMatri.DataPropertyName = "CeluLegalMatri"
        Me.CeluLegalMatri.HeaderText = "CeluLegalMatri"
        Me.CeluLegalMatri.Name = "CeluLegalMatri"
        Me.CeluLegalMatri.ReadOnly = True
        Me.CeluLegalMatri.Visible = False
        '
        'FijoLegalMatri
        '
        Me.FijoLegalMatri.DataPropertyName = "FijoLegalMatri"
        Me.FijoLegalMatri.HeaderText = "FijoLegalMatri"
        Me.FijoLegalMatri.Name = "FijoLegalMatri"
        Me.FijoLegalMatri.ReadOnly = True
        Me.FijoLegalMatri.Visible = False
        '
        'FianzaMatri
        '
        Me.FianzaMatri.DataPropertyName = "FianzaMatri"
        Me.FianzaMatri.HeaderText = "FianzaMatri"
        Me.FianzaMatri.Name = "FianzaMatri"
        Me.FianzaMatri.ReadOnly = True
        Me.FianzaMatri.Visible = False
        '
        'DocFiadorMatri
        '
        Me.DocFiadorMatri.DataPropertyName = "DocFiadorMatri"
        Me.DocFiadorMatri.HeaderText = "DocFiadorMatri"
        Me.DocFiadorMatri.Name = "DocFiadorMatri"
        Me.DocFiadorMatri.ReadOnly = True
        Me.DocFiadorMatri.Visible = False
        '
        'FiadorMatri
        '
        Me.FiadorMatri.DataPropertyName = "FiadorMatri"
        Me.FiadorMatri.HeaderText = "FiadorMatri"
        Me.FiadorMatri.Name = "FiadorMatri"
        Me.FiadorMatri.ReadOnly = True
        Me.FiadorMatri.Visible = False
        '
        'CalleFiadorMatri
        '
        Me.CalleFiadorMatri.DataPropertyName = "CalleFiadorMatri"
        Me.CalleFiadorMatri.HeaderText = "CalleFiadorMatri"
        Me.CalleFiadorMatri.Name = "CalleFiadorMatri"
        Me.CalleFiadorMatri.ReadOnly = True
        Me.CalleFiadorMatri.Visible = False
        '
        'ObsMatri
        '
        Me.ObsMatri.DataPropertyName = "ObsMatri"
        Me.ObsMatri.HeaderText = "ObsMatri"
        Me.ObsMatri.Name = "ObsMatri"
        Me.ObsMatri.ReadOnly = True
        Me.ObsMatri.Visible = False
        '
        'MatriculadosBindingSource1
        '
        Me.MatriculadosBindingSource1.DataMember = "matriculados"
        Me.MatriculadosBindingSource1.DataSource = Me.DbcolmartDataSet
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(12, 470)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(414, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Haga doble clic en el renglón seleccionado..."
        '
        'MatriculadosTableAdapter
        '
        Me.MatriculadosTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(194, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(384, 36)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Consulta de Matriculados"
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
        Me.BtnSalir.Location = New System.Drawing.Point(710, 28)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(57, 56)
        Me.BtnSalir.TabIndex = 87
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(14, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(674, 41)
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(696, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 69)
        Me.PictureBox2.TabIndex = 89
        Me.PictureBox2.TabStop = False
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'frmConsMatri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(832, 496)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvMatriculados)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsMatri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE MATRICULADOS"
        CType(Me.dgvMatriculados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatriculadosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents dgvMatriculados As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents MatriculadosTableAdapter As dbcolmartDataSetTableAdapters.matriculadosTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MatriculadosBindingSource1 As BindingSource
    Friend WithEvents IdMatriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroMatriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApelNombMatriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApelMatMatri As DataGridViewTextBoxColumn
    Friend WithEvents FecNacMatriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LugarNacMatri As DataGridViewTextBoxColumn
    Friend WithEvents NacionNacMatri As DataGridViewTextBoxColumn
    Friend WithEvents TipoDocMatriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroDocMatriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoMatriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstCivilMatri As DataGridViewTextBoxColumn
    Friend WithEvents CuitMatri As DataGridViewTextBoxColumn
    Friend WithEvents FecJurMatri As DataGridViewTextBoxColumn
    Friend WithEvents CatAporteMatriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoMatri As DataGridViewTextBoxColumn
    Friend WithEvents FecEstadoMatri As DataGridViewTextBoxColumn
    Friend WithEvents CalleRealMatri As DataGridViewTextBoxColumn
    Friend WithEvents CPRealMatri As DataGridViewTextBoxColumn
    Friend WithEvents EmailMatri As DataGridViewTextBoxColumn
    Friend WithEvents CeluRealMatri As DataGridViewTextBoxColumn
    Friend WithEvents FijoRealMatri As DataGridViewTextBoxColumn
    Friend WithEvents CalleLegalMatri As DataGridViewTextBoxColumn
    Friend WithEvents CPLegalMatri As DataGridViewTextBoxColumn
    Friend WithEvents CeluLegalMatri As DataGridViewTextBoxColumn
    Friend WithEvents FijoLegalMatri As DataGridViewTextBoxColumn
    Friend WithEvents FianzaMatri As DataGridViewTextBoxColumn
    Friend WithEvents DocFiadorMatri As DataGridViewTextBoxColumn
    Friend WithEvents FiadorMatri As DataGridViewTextBoxColumn
    Friend WithEvents CalleFiadorMatri As DataGridViewTextBoxColumn
    Friend WithEvents ObsMatri As DataGridViewTextBoxColumn
    Friend WithEvents ToolTipMsg As ToolTip
End Class

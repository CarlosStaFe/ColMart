<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListaOficio
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
        Dim NroMatriLabel As System.Windows.Forms.Label
        Dim ApelNombMatriLabel As System.Windows.Forms.Label
        Dim CuitMatriLabel As System.Windows.Forms.Label
        Dim CalleRealMatriLabel As System.Windows.Forms.Label
        Dim CPRealMatriLabel As System.Windows.Forms.Label
        Dim EmailMatriLabel As System.Windows.Forms.Label
        Dim CeluRealMatriLabel As System.Windows.Forms.Label
        Dim FijoRealMatriLabel As System.Windows.Forms.Label
        Dim YyyyLisLabel As System.Windows.Forms.Label
        Dim TribunalLisLabel As System.Windows.Forms.Label
        Dim DomicilioLisLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim FecJurMatriLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaOficio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.txtApelNomb = New System.Windows.Forms.TextBox()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtCodPostal = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelFijo = New System.Windows.Forms.TextBox()
        Me.txtAaaa = New System.Windows.Forms.TextBox()
        Me.cbxDistrito = New System.Windows.Forms.CheckBox()
        Me.cbxCircuito = New System.Windows.Forms.CheckBox()
        Me.cbxTasaciones = New System.Windows.Forms.CheckBox()
        Me.cbxConcursales = New System.Windows.Forms.CheckBox()
        Me.txtDomLocal = New System.Windows.Forms.TextBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.cmbTribunal = New System.Windows.Forms.ComboBox()
        Me.dgvListaOficio = New System.Windows.Forms.DataGridView()
        Me.IdLisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatriLisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApelNombLisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YyyyLisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TribunalLisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistritoLisDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CircuitoLisDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TasacionesLisDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ConcursalesLisDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DomicilioLisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaoficioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.ListaoficioTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.listaoficioTableAdapter()
        Me.TableAdapterManager = New ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager()
        Me.MatriculadosTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.matriculadosTableAdapter()
        Me.txtNroDoc = New System.Windows.Forms.TextBox()
        Me.txtFechaJur = New System.Windows.Forms.TextBox()
        Me.btnListados = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        NroMatriLabel = New System.Windows.Forms.Label()
        ApelNombMatriLabel = New System.Windows.Forms.Label()
        CuitMatriLabel = New System.Windows.Forms.Label()
        CalleRealMatriLabel = New System.Windows.Forms.Label()
        CPRealMatriLabel = New System.Windows.Forms.Label()
        EmailMatriLabel = New System.Windows.Forms.Label()
        CeluRealMatriLabel = New System.Windows.Forms.Label()
        FijoRealMatriLabel = New System.Windows.Forms.Label()
        YyyyLisLabel = New System.Windows.Forms.Label()
        TribunalLisLabel = New System.Windows.Forms.Label()
        DomicilioLisLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        FecJurMatriLabel = New System.Windows.Forms.Label()
        CType(Me.dgvListaOficio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaoficioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NroMatriLabel
        '
        NroMatriLabel.AutoSize = True
        NroMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NroMatriLabel.ForeColor = System.Drawing.Color.White
        NroMatriLabel.Location = New System.Drawing.Point(68, 64)
        NroMatriLabel.Name = "NroMatriLabel"
        NroMatriLabel.Size = New System.Drawing.Size(72, 17)
        NroMatriLabel.TabIndex = 88
        NroMatriLabel.Text = "Matrícula:"
        '
        'ApelNombMatriLabel
        '
        ApelNombMatriLabel.AutoSize = True
        ApelNombMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApelNombMatriLabel.ForeColor = System.Drawing.Color.White
        ApelNombMatriLabel.Location = New System.Drawing.Point(225, 64)
        ApelNombMatriLabel.Name = "ApelNombMatriLabel"
        ApelNombMatriLabel.Size = New System.Drawing.Size(137, 17)
        ApelNombMatriLabel.TabIndex = 89
        ApelNombMatriLabel.Text = "Apellido y Nombres:"
        '
        'CuitMatriLabel
        '
        CuitMatriLabel.AutoSize = True
        CuitMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CuitMatriLabel.ForeColor = System.Drawing.Color.White
        CuitMatriLabel.Location = New System.Drawing.Point(715, 64)
        CuitMatriLabel.Name = "CuitMatriLabel"
        CuitMatriLabel.Size = New System.Drawing.Size(55, 17)
        CuitMatriLabel.TabIndex = 90
        CuitMatriLabel.Text = "C.U.I.T.:"
        '
        'CalleRealMatriLabel
        '
        CalleRealMatriLabel.AutoSize = True
        CalleRealMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CalleRealMatriLabel.ForeColor = System.Drawing.Color.White
        CalleRealMatriLabel.Location = New System.Drawing.Point(67, 93)
        CalleRealMatriLabel.Name = "CalleRealMatriLabel"
        CalleRealMatriLabel.Size = New System.Drawing.Size(73, 17)
        CalleRealMatriLabel.TabIndex = 91
        CalleRealMatriLabel.Text = "Domicilio:"
        '
        'CPRealMatriLabel
        '
        CPRealMatriLabel.AutoSize = True
        CPRealMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPRealMatriLabel.ForeColor = System.Drawing.Color.White
        CPRealMatriLabel.Location = New System.Drawing.Point(35, 122)
        CPRealMatriLabel.Name = "CPRealMatriLabel"
        CPRealMatriLabel.Size = New System.Drawing.Size(105, 17)
        CPRealMatriLabel.TabIndex = 92
        CPRealMatriLabel.Text = "Código Postal:"
        '
        'EmailMatriLabel
        '
        EmailMatriLabel.AutoSize = True
        EmailMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailMatriLabel.ForeColor = System.Drawing.Color.White
        EmailMatriLabel.Location = New System.Drawing.Point(93, 179)
        EmailMatriLabel.Name = "EmailMatriLabel"
        EmailMatriLabel.Size = New System.Drawing.Size(47, 17)
        EmailMatriLabel.TabIndex = 93
        EmailMatriLabel.Text = "Email:"
        '
        'CeluRealMatriLabel
        '
        CeluRealMatriLabel.AutoSize = True
        CeluRealMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CeluRealMatriLabel.ForeColor = System.Drawing.Color.White
        CeluRealMatriLabel.Location = New System.Drawing.Point(315, 151)
        CeluRealMatriLabel.Name = "CeluRealMatriLabel"
        CeluRealMatriLabel.Size = New System.Drawing.Size(74, 17)
        CeluRealMatriLabel.TabIndex = 94
        CeluRealMatriLabel.Text = "Celu Real:"
        '
        'FijoRealMatriLabel
        '
        FijoRealMatriLabel.AutoSize = True
        FijoRealMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FijoRealMatriLabel.ForeColor = System.Drawing.Color.White
        FijoRealMatriLabel.Location = New System.Drawing.Point(75, 151)
        FijoRealMatriLabel.Name = "FijoRealMatriLabel"
        FijoRealMatriLabel.Size = New System.Drawing.Size(65, 17)
        FijoRealMatriLabel.TabIndex = 95
        FijoRealMatriLabel.Text = "Fijo Real:"
        '
        'YyyyLisLabel
        '
        YyyyLisLabel.AutoSize = True
        YyyyLisLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        YyyyLisLabel.Location = New System.Drawing.Point(102, 229)
        YyyyLisLabel.Name = "YyyyLisLabel"
        YyyyLisLabel.Size = New System.Drawing.Size(38, 17)
        YyyyLisLabel.TabIndex = 96
        YyyyLisLabel.Text = "Año:"
        '
        'TribunalLisLabel
        '
        TribunalLisLabel.AutoSize = True
        TribunalLisLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TribunalLisLabel.Location = New System.Drawing.Point(207, 229)
        TribunalLisLabel.Name = "TribunalLisLabel"
        TribunalLisLabel.Size = New System.Drawing.Size(61, 17)
        TribunalLisLabel.TabIndex = 97
        TribunalLisLabel.Text = "Tribunal:"
        '
        'DomicilioLisLabel
        '
        DomicilioLisLabel.AutoSize = True
        DomicilioLisLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DomicilioLisLabel.Location = New System.Drawing.Point(28, 258)
        DomicilioLisLabel.Name = "DomicilioLisLabel"
        DomicilioLisLabel.Size = New System.Drawing.Size(112, 17)
        DomicilioLisLabel.TabIndex = 102
        DomicilioLisLabel.Text = "Domicilio Local:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(696, 93)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(74, 17)
        Label2.TabIndex = 147
        Label2.Text = "Nro. Doc.:"
        '
        'FecJurMatriLabel
        '
        FecJurMatriLabel.AutoSize = True
        FecJurMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FecJurMatriLabel.ForeColor = System.Drawing.Color.White
        FecJurMatriLabel.Location = New System.Drawing.Point(574, 151)
        FecJurMatriLabel.Name = "FecJurMatriLabel"
        FecJurMatriLabel.Size = New System.Drawing.Size(112, 17)
        FecJurMatriLabel.TabIndex = 149
        FecJurMatriLabel.Text = "Fec. Juramento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(252, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 36)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Lista de Nombramientos de Oficio"
        '
        'txtMatricula
        '
        Me.txtMatricula.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMatricula.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.ForeColor = System.Drawing.Color.White
        Me.txtMatricula.Location = New System.Drawing.Point(146, 61)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(73, 23)
        Me.txtMatricula.TabIndex = 0
        '
        'txtApelNomb
        '
        Me.txtApelNomb.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtApelNomb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApelNomb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApelNomb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApelNomb.ForeColor = System.Drawing.Color.White
        Me.txtApelNomb.Location = New System.Drawing.Point(364, 61)
        Me.txtApelNomb.Name = "txtApelNomb"
        Me.txtApelNomb.Size = New System.Drawing.Size(326, 23)
        Me.txtApelNomb.TabIndex = 1
        '
        'txtCuit
        '
        Me.txtCuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit.ForeColor = System.Drawing.Color.White
        Me.txtCuit.Location = New System.Drawing.Point(776, 61)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(128, 23)
        Me.txtCuit.TabIndex = 2
        '
        'txtDomicilio
        '
        Me.txtDomicilio.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.ForeColor = System.Drawing.Color.White
        Me.txtDomicilio.Location = New System.Drawing.Point(146, 90)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(544, 23)
        Me.txtDomicilio.TabIndex = 3
        '
        'txtCodPostal
        '
        Me.txtCodPostal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPostal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPostal.ForeColor = System.Drawing.Color.White
        Me.txtCodPostal.Location = New System.Drawing.Point(146, 119)
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.Size = New System.Drawing.Size(73, 23)
        Me.txtCodPostal.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(146, 177)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(416, 23)
        Me.txtEmail.TabIndex = 11
        '
        'txtCelular
        '
        Me.txtCelular.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCelular.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.ForeColor = System.Drawing.Color.White
        Me.txtCelular.Location = New System.Drawing.Point(395, 148)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(167, 23)
        Me.txtCelular.TabIndex = 9
        '
        'txtTelFijo
        '
        Me.txtTelFijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTelFijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelFijo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelFijo.ForeColor = System.Drawing.Color.White
        Me.txtTelFijo.Location = New System.Drawing.Point(146, 148)
        Me.txtTelFijo.Name = "txtTelFijo"
        Me.txtTelFijo.Size = New System.Drawing.Size(162, 23)
        Me.txtTelFijo.TabIndex = 8
        '
        'txtAaaa
        '
        Me.txtAaaa.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtAaaa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAaaa.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAaaa.ForeColor = System.Drawing.Color.White
        Me.txtAaaa.Location = New System.Drawing.Point(146, 226)
        Me.txtAaaa.Name = "txtAaaa"
        Me.txtAaaa.Size = New System.Drawing.Size(55, 23)
        Me.txtAaaa.TabIndex = 13
        '
        'cbxDistrito
        '
        Me.cbxDistrito.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDistrito.ForeColor = System.Drawing.Color.DarkOrange
        Me.cbxDistrito.Location = New System.Drawing.Point(509, 226)
        Me.cbxDistrito.Name = "cbxDistrito"
        Me.cbxDistrito.Size = New System.Drawing.Size(104, 24)
        Me.cbxDistrito.TabIndex = 15
        Me.cbxDistrito.Text = "Distrito"
        Me.cbxDistrito.UseVisualStyleBackColor = True
        '
        'cbxCircuito
        '
        Me.cbxCircuito.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCircuito.ForeColor = System.Drawing.Color.DarkOrange
        Me.cbxCircuito.Location = New System.Drawing.Point(627, 226)
        Me.cbxCircuito.Name = "cbxCircuito"
        Me.cbxCircuito.Size = New System.Drawing.Size(104, 24)
        Me.cbxCircuito.TabIndex = 16
        Me.cbxCircuito.Text = "Circuito"
        Me.cbxCircuito.UseVisualStyleBackColor = True
        '
        'cbxTasaciones
        '
        Me.cbxTasaciones.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTasaciones.ForeColor = System.Drawing.Color.DarkOrange
        Me.cbxTasaciones.Location = New System.Drawing.Point(746, 226)
        Me.cbxTasaciones.Name = "cbxTasaciones"
        Me.cbxTasaciones.Size = New System.Drawing.Size(119, 24)
        Me.cbxTasaciones.TabIndex = 17
        Me.cbxTasaciones.Text = "Tasaciones"
        Me.cbxTasaciones.UseVisualStyleBackColor = True
        '
        'cbxConcursales
        '
        Me.cbxConcursales.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxConcursales.ForeColor = System.Drawing.Color.DarkOrange
        Me.cbxConcursales.Location = New System.Drawing.Point(879, 226)
        Me.cbxConcursales.Name = "cbxConcursales"
        Me.cbxConcursales.Size = New System.Drawing.Size(131, 24)
        Me.cbxConcursales.TabIndex = 18
        Me.cbxConcursales.Text = "Concursales"
        Me.cbxConcursales.UseVisualStyleBackColor = True
        '
        'txtDomLocal
        '
        Me.txtDomLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDomLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomLocal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomLocal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomLocal.ForeColor = System.Drawing.Color.White
        Me.txtDomLocal.Location = New System.Drawing.Point(146, 255)
        Me.txtDomLocal.Name = "txtDomLocal"
        Me.txtDomLocal.Size = New System.Drawing.Size(423, 23)
        Me.txtDomLocal.TabIndex = 19
        '
        'txtLocalidad
        '
        Me.txtLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalidad.Enabled = False
        Me.txtLocalidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.ForeColor = System.Drawing.Color.White
        Me.txtLocalidad.Location = New System.Drawing.Point(225, 119)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(325, 23)
        Me.txtLocalidad.TabIndex = 6
        '
        'txtProvincia
        '
        Me.txtProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvincia.Enabled = False
        Me.txtProvincia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.ForeColor = System.Drawing.Color.White
        Me.txtProvincia.Location = New System.Drawing.Point(556, 119)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(329, 23)
        Me.txtProvincia.TabIndex = 7
        '
        'cmbTribunal
        '
        Me.cmbTribunal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbTribunal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTribunal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTribunal.ForeColor = System.Drawing.Color.White
        Me.cmbTribunal.FormattingEnabled = True
        Me.cmbTribunal.ItemHeight = 17
        Me.cmbTribunal.Location = New System.Drawing.Point(274, 225)
        Me.cmbTribunal.Name = "cmbTribunal"
        Me.cmbTribunal.Size = New System.Drawing.Size(198, 25)
        Me.cmbTribunal.TabIndex = 14
        '
        'dgvListaOficio
        '
        Me.dgvListaOficio.AllowUserToAddRows = False
        Me.dgvListaOficio.AllowUserToDeleteRows = False
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White
        Me.dgvListaOficio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle31
        Me.dgvListaOficio.AutoGenerateColumns = False
        Me.dgvListaOficio.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvListaOficio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.DarkSalmon
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaOficio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.dgvListaOficio.ColumnHeadersHeight = 30
        Me.dgvListaOficio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListaOficio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLisDataGridViewTextBoxColumn, Me.MatriLisDataGridViewTextBoxColumn, Me.ApelNombLisDataGridViewTextBoxColumn, Me.YyyyLisDataGridViewTextBoxColumn, Me.TribunalLisDataGridViewTextBoxColumn, Me.DistritoLisDataGridViewCheckBoxColumn, Me.CircuitoLisDataGridViewCheckBoxColumn, Me.TasacionesLisDataGridViewCheckBoxColumn, Me.ConcursalesLisDataGridViewCheckBoxColumn, Me.DomicilioLisDataGridViewTextBoxColumn})
        Me.dgvListaOficio.DataSource = Me.ListaoficioBindingSource
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle34.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaOficio.DefaultCellStyle = DataGridViewCellStyle34
        Me.dgvListaOficio.EnableHeadersVisualStyles = False
        Me.dgvListaOficio.GridColor = System.Drawing.Color.White
        Me.dgvListaOficio.Location = New System.Drawing.Point(13, 322)
        Me.dgvListaOficio.Name = "dgvListaOficio"
        Me.dgvListaOficio.ReadOnly = True
        Me.dgvListaOficio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaOficio.RowHeadersDefaultCellStyle = DataGridViewCellStyle35
        Me.dgvListaOficio.Size = New System.Drawing.Size(1001, 321)
        Me.dgvListaOficio.TabIndex = 103
        '
        'IdLisDataGridViewTextBoxColumn
        '
        Me.IdLisDataGridViewTextBoxColumn.DataPropertyName = "id_Lis"
        Me.IdLisDataGridViewTextBoxColumn.HeaderText = "id_Lis"
        Me.IdLisDataGridViewTextBoxColumn.Name = "IdLisDataGridViewTextBoxColumn"
        Me.IdLisDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdLisDataGridViewTextBoxColumn.Visible = False
        '
        'MatriLisDataGridViewTextBoxColumn
        '
        Me.MatriLisDataGridViewTextBoxColumn.DataPropertyName = "MatriLis"
        Me.MatriLisDataGridViewTextBoxColumn.HeaderText = "MatriLis"
        Me.MatriLisDataGridViewTextBoxColumn.Name = "MatriLisDataGridViewTextBoxColumn"
        Me.MatriLisDataGridViewTextBoxColumn.ReadOnly = True
        Me.MatriLisDataGridViewTextBoxColumn.Visible = False
        '
        'ApelNombLisDataGridViewTextBoxColumn
        '
        Me.ApelNombLisDataGridViewTextBoxColumn.DataPropertyName = "ApelNombLis"
        Me.ApelNombLisDataGridViewTextBoxColumn.HeaderText = "ApelNombLis"
        Me.ApelNombLisDataGridViewTextBoxColumn.Name = "ApelNombLisDataGridViewTextBoxColumn"
        Me.ApelNombLisDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApelNombLisDataGridViewTextBoxColumn.Visible = False
        '
        'YyyyLisDataGridViewTextBoxColumn
        '
        Me.YyyyLisDataGridViewTextBoxColumn.DataPropertyName = "yyyyLis"
        Me.YyyyLisDataGridViewTextBoxColumn.HeaderText = "AÑO"
        Me.YyyyLisDataGridViewTextBoxColumn.Name = "YyyyLisDataGridViewTextBoxColumn"
        Me.YyyyLisDataGridViewTextBoxColumn.ReadOnly = True
        Me.YyyyLisDataGridViewTextBoxColumn.Width = 40
        '
        'TribunalLisDataGridViewTextBoxColumn
        '
        Me.TribunalLisDataGridViewTextBoxColumn.DataPropertyName = "TribunalLis"
        Me.TribunalLisDataGridViewTextBoxColumn.HeaderText = "TRIBUNAL"
        Me.TribunalLisDataGridViewTextBoxColumn.Name = "TribunalLisDataGridViewTextBoxColumn"
        Me.TribunalLisDataGridViewTextBoxColumn.ReadOnly = True
        Me.TribunalLisDataGridViewTextBoxColumn.Width = 250
        '
        'DistritoLisDataGridViewCheckBoxColumn
        '
        Me.DistritoLisDataGridViewCheckBoxColumn.DataPropertyName = "DistritoLis"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle33.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle33.NullValue = False
        Me.DistritoLisDataGridViewCheckBoxColumn.DefaultCellStyle = DataGridViewCellStyle33
        Me.DistritoLisDataGridViewCheckBoxColumn.HeaderText = "DISTRITO"
        Me.DistritoLisDataGridViewCheckBoxColumn.Name = "DistritoLisDataGridViewCheckBoxColumn"
        Me.DistritoLisDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'CircuitoLisDataGridViewCheckBoxColumn
        '
        Me.CircuitoLisDataGridViewCheckBoxColumn.DataPropertyName = "CircuitoLis"
        Me.CircuitoLisDataGridViewCheckBoxColumn.HeaderText = "CIRCUITO"
        Me.CircuitoLisDataGridViewCheckBoxColumn.Name = "CircuitoLisDataGridViewCheckBoxColumn"
        Me.CircuitoLisDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'TasacionesLisDataGridViewCheckBoxColumn
        '
        Me.TasacionesLisDataGridViewCheckBoxColumn.DataPropertyName = "TasacionesLis"
        Me.TasacionesLisDataGridViewCheckBoxColumn.HeaderText = "TASACIONES"
        Me.TasacionesLisDataGridViewCheckBoxColumn.Name = "TasacionesLisDataGridViewCheckBoxColumn"
        Me.TasacionesLisDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ConcursalesLisDataGridViewCheckBoxColumn
        '
        Me.ConcursalesLisDataGridViewCheckBoxColumn.DataPropertyName = "ConcursalesLis"
        Me.ConcursalesLisDataGridViewCheckBoxColumn.HeaderText = "CONCURSALES"
        Me.ConcursalesLisDataGridViewCheckBoxColumn.Name = "ConcursalesLisDataGridViewCheckBoxColumn"
        Me.ConcursalesLisDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'DomicilioLisDataGridViewTextBoxColumn
        '
        Me.DomicilioLisDataGridViewTextBoxColumn.DataPropertyName = "DomicilioLis"
        Me.DomicilioLisDataGridViewTextBoxColumn.HeaderText = "DOMICILIO LOCAL"
        Me.DomicilioLisDataGridViewTextBoxColumn.Name = "DomicilioLisDataGridViewTextBoxColumn"
        Me.DomicilioLisDataGridViewTextBoxColumn.ReadOnly = True
        Me.DomicilioLisDataGridViewTextBoxColumn.Width = 250
        '
        'ListaoficioBindingSource
        '
        Me.ListaoficioBindingSource.DataMember = "listaoficio"
        Me.ListaoficioBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListaoficioTableAdapter
        '
        Me.ListaoficioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.boletasTableAdapter = Nothing
        Me.TableAdapterManager.cajaTableAdapter = Nothing
        Me.TableAdapterManager.coddebitoTableAdapter = Nothing
        Me.TableAdapterManager.codpostalTableAdapter = Nothing
        Me.TableAdapterManager.comprobteTableAdapter = Nothing
        Me.TableAdapterManager.ctactematTableAdapter = Nothing
        Me.TableAdapterManager.ctacteprovTableAdapter = Nothing
        Me.TableAdapterManager.ctactesocTableAdapter = Nothing
        Me.TableAdapterManager.ctasctesTableAdapter = Nothing
        Me.TableAdapterManager.debehaberTableAdapter = Nothing
        Me.TableAdapterManager.debitomatriTableAdapter = Nothing
        Me.TableAdapterManager.debitosocTableAdapter = Nothing
        Me.TableAdapterManager.listaoficioTableAdapter = Me.ListaoficioTableAdapter
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotebancoTableAdapter = Nothing
        Me.TableAdapterManager.matriculadosTableAdapter = Nothing
        Me.TableAdapterManager.nivelesTableAdapter = Nothing
        Me.TableAdapterManager.renglonesTableAdapter = Nothing
        Me.TableAdapterManager.saldomatTableAdapter = Nothing
        Me.TableAdapterManager.saldosocTableAdapter = Nothing
        Me.TableAdapterManager.sociedadesTableAdapter = Nothing
        Me.TableAdapterManager.tribunalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'MatriculadosTableAdapter
        '
        Me.MatriculadosTableAdapter.ClearBeforeFill = True
        '
        'txtNroDoc
        '
        Me.txtNroDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroDoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDoc.ForeColor = System.Drawing.Color.White
        Me.txtNroDoc.Location = New System.Drawing.Point(776, 90)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(128, 23)
        Me.txtNroDoc.TabIndex = 4
        '
        'txtFechaJur
        '
        Me.txtFechaJur.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFechaJur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaJur.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaJur.ForeColor = System.Drawing.Color.White
        Me.txtFechaJur.Location = New System.Drawing.Point(692, 148)
        Me.txtFechaJur.MaxLength = 10
        Me.txtFechaJur.Name = "txtFechaJur"
        Me.txtFechaJur.Size = New System.Drawing.Size(100, 23)
        Me.txtFechaJur.TabIndex = 10
        '
        'btnListados
        '
        Me.btnListados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListados.FlatAppearance.BorderSize = 0
        Me.btnListados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListados.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListados.ForeColor = System.Drawing.Color.White
        Me.btnListados.Image = CType(resources.GetObject("btnListados.Image"), System.Drawing.Image)
        Me.btnListados.Location = New System.Drawing.Point(934, 61)
        Me.btnListados.Name = "btnListados"
        Me.btnListados.Size = New System.Drawing.Size(71, 55)
        Me.btnListados.TabIndex = 150
        Me.btnListados.Text = "Listados"
        Me.btnListados.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnListados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnListados.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.AutoSize = True
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.FlatAppearance.BorderSize = 0
        Me.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnLimpiar.Location = New System.Drawing.Point(849, 254)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnLimpiar.Size = New System.Drawing.Size(66, 56)
        Me.BtnLimpiar.TabIndex = 23
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLimpiar.UseVisualStyleBackColor = True
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
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGrabar.Location = New System.Drawing.Point(939, 147)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGrabar.Size = New System.Drawing.Size(66, 56)
        Me.BtnGrabar.TabIndex = 12
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGrabar.UseVisualStyleBackColor = True
        Me.BtnGrabar.Visible = False
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
        Me.BtnSalir.Location = New System.Drawing.Point(933, 254)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(71, 56)
        Me.BtnSalir.TabIndex = 24
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.AutoSize = True
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnModificar.Location = New System.Drawing.Point(660, 254)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnModificar.Size = New System.Drawing.Size(80, 56)
        Me.BtnModificar.TabIndex = 21
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnModificar.UseVisualStyleBackColor = True
        Me.BtnModificar.Visible = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.AutoSize = True
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(758, 254)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEliminar.Size = New System.Drawing.Size(73, 56)
        Me.BtnEliminar.TabIndex = 22
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEliminar.UseVisualStyleBackColor = True
        Me.BtnEliminar.Visible = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.AutoSize = True
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAgregar.Location = New System.Drawing.Point(576, 254)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAgregar.Size = New System.Drawing.Size(66, 56)
        Me.BtnAgregar.TabIndex = 20
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregar.UseVisualStyleBackColor = True
        Me.BtnAgregar.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(13, 51)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1001, 157)
        Me.PictureBox4.TabIndex = 144
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(13, 215)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1001, 101)
        Me.PictureBox1.TabIndex = 145
        Me.PictureBox1.TabStop = False
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'frmListaOficio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1082, 655)
        Me.Controls.Add(Me.btnListados)
        Me.Controls.Add(Me.txtFechaJur)
        Me.Controls.Add(FecJurMatriLabel)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtNroDoc)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.dgvListaOficio)
        Me.Controls.Add(Me.cmbTribunal)
        Me.Controls.Add(Me.txtProvincia)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(DomicilioLisLabel)
        Me.Controls.Add(Me.txtDomLocal)
        Me.Controls.Add(Me.cbxConcursales)
        Me.Controls.Add(Me.cbxTasaciones)
        Me.Controls.Add(Me.cbxCircuito)
        Me.Controls.Add(Me.cbxDistrito)
        Me.Controls.Add(TribunalLisLabel)
        Me.Controls.Add(YyyyLisLabel)
        Me.Controls.Add(Me.txtAaaa)
        Me.Controls.Add(FijoRealMatriLabel)
        Me.Controls.Add(Me.txtTelFijo)
        Me.Controls.Add(CeluRealMatriLabel)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(EmailMatriLabel)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(CPRealMatriLabel)
        Me.Controls.Add(Me.txtCodPostal)
        Me.Controls.Add(CalleRealMatriLabel)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(CuitMatriLabel)
        Me.Controls.Add(Me.txtCuit)
        Me.Controls.Add(ApelNombMatriLabel)
        Me.Controls.Add(Me.txtApelNomb)
        Me.Controls.Add(NroMatriLabel)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaOficio"
        Me.Text = "LISTA DE NOMBRAMIENTOS DE OFICIOS"
        CType(Me.dgvListaOficio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaoficioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents ListaoficioTableAdapter As dbcolmartDataSetTableAdapters.listaoficioTableAdapter
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MatriculadosTableAdapter As dbcolmartDataSetTableAdapters.matriculadosTableAdapter
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents txtApelNomb As TextBox
    Friend WithEvents txtCuit As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtCodPostal As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtTelFijo As TextBox
    Friend WithEvents txtAaaa As TextBox
    Friend WithEvents cbxDistrito As CheckBox
    Friend WithEvents cbxCircuito As CheckBox
    Friend WithEvents cbxTasaciones As CheckBox
    Friend WithEvents cbxConcursales As CheckBox
    Friend WithEvents txtDomLocal As TextBox
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents cmbTribunal As ComboBox
    Friend WithEvents dgvListaOficio As DataGridView
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents ListaoficioBindingSource As BindingSource
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNroDoc As TextBox
    Friend WithEvents txtFechaJur As TextBox
    Friend WithEvents btnListados As Button
    Friend WithEvents IdLisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatriLisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApelNombLisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YyyyLisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TribunalLisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DistritoLisDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CircuitoLisDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TasacionesLisDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ConcursalesLisDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DomicilioLisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolTipMsg As ToolTip
End Class

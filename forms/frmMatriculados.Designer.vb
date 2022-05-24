<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMatriculados
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
        Dim Id_MatriLabel As System.Windows.Forms.Label
        Dim ApelMatriLabel As System.Windows.Forms.Label
        Dim ApelMatMatriLabel As System.Windows.Forms.Label
        Dim FecNacMatriLabel As System.Windows.Forms.Label
        Dim LugarNacMatriLabel As System.Windows.Forms.Label
        Dim NacionNacMatriLabel As System.Windows.Forms.Label
        Dim TipoDocMatriLabel As System.Windows.Forms.Label
        Dim NroDocMatriLabel As System.Windows.Forms.Label
        Dim SexoMatriLabel As System.Windows.Forms.Label
        Dim EstCivilMatriLabel As System.Windows.Forms.Label
        Dim CuitMatriLabel As System.Windows.Forms.Label
        Dim FecJurMatriLabel As System.Windows.Forms.Label
        Dim CatAporteMatriLabel As System.Windows.Forms.Label
        Dim EstadoMatriLabel As System.Windows.Forms.Label
        Dim FecEstadoMatriLabel As System.Windows.Forms.Label
        Dim CalleRealMatriLabel As System.Windows.Forms.Label
        Dim CPRealMatriLabel As System.Windows.Forms.Label
        Dim EmailMatriLabel As System.Windows.Forms.Label
        Dim CeluRealMatriLabel As System.Windows.Forms.Label
        Dim FijoRealMatriLabel As System.Windows.Forms.Label
        Dim CalleLegalMatriLabel As System.Windows.Forms.Label
        Dim CPLegalMatriLabel As System.Windows.Forms.Label
        Dim CeluLegalMatriLabel As System.Windows.Forms.Label
        Dim FijoLegalMatriLabel As System.Windows.Forms.Label
        Dim FianzaMatriLabel As System.Windows.Forms.Label
        Dim FiadorMatriLabel As System.Windows.Forms.Label
        Dim DocFiadorMatriLabel As System.Windows.Forms.Label
        Dim CalleFiadorMatriLabel As System.Windows.Forms.Label
        Dim ObsMatriLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatriculados))
        Me.txtId_Matri = New System.Windows.Forms.TextBox()
        Me.MatriculadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.txtApelNombMatri = New System.Windows.Forms.TextBox()
        Me.txtApelMatMatri = New System.Windows.Forms.TextBox()
        Me.txtLugarNacMatri = New System.Windows.Forms.TextBox()
        Me.txtNacionNacMatri = New System.Windows.Forms.TextBox()
        Me.txtNroDocMatri = New System.Windows.Forms.TextBox()
        Me.txtCuitMatri = New System.Windows.Forms.TextBox()
        Me.txtCalleRealMatri = New System.Windows.Forms.TextBox()
        Me.txtCPRealMatri = New System.Windows.Forms.TextBox()
        Me.txtEmailMatri = New System.Windows.Forms.TextBox()
        Me.txtCeluRealMatri = New System.Windows.Forms.TextBox()
        Me.txtFijoRealMatri = New System.Windows.Forms.TextBox()
        Me.txtCalleLegalMatri = New System.Windows.Forms.TextBox()
        Me.txtCPLegalMatri = New System.Windows.Forms.TextBox()
        Me.txtCeluLegalMatri = New System.Windows.Forms.TextBox()
        Me.txtFijoLegalMatri = New System.Windows.Forms.TextBox()
        Me.txtDocFiadorMatri = New System.Windows.Forms.TextBox()
        Me.txtCalleFiadorMatri = New System.Windows.Forms.TextBox()
        Me.txtObsMatri = New System.Windows.Forms.TextBox()
        Me.txtLocalReal = New System.Windows.Forms.TextBox()
        Me.txtProvReal = New System.Windows.Forms.TextBox()
        Me.txtLocalLegal = New System.Windows.Forms.TextBox()
        Me.txtProvLegal = New System.Windows.Forms.TextBox()
        Me.cmbTipoDocMatri = New System.Windows.Forms.ComboBox()
        Me.cmbSexoMatri = New System.Windows.Forms.ComboBox()
        Me.cmbEstCivilMatri = New System.Windows.Forms.ComboBox()
        Me.cmbCatAporteMatri = New System.Windows.Forms.ComboBox()
        Me.cmbEstadoMatri = New System.Windows.Forms.ComboBox()
        Me.txtNroMatri = New System.Windows.Forms.TextBox()
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
        Me.lblAtencion1 = New System.Windows.Forms.Label()
        Me.lblAtencion2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.MatriculadosTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.matriculadosTableAdapter()
        Me.TableAdapterManager = New ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager()
        Me.MatriculadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MatriculadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtFecNacMatri = New System.Windows.Forms.TextBox()
        Me.txtFecJurMatri = New System.Windows.Forms.TextBox()
        Me.txtFecEstadoMatri = New System.Windows.Forms.TextBox()
        Me.txtFianzaMatri = New System.Windows.Forms.TextBox()
        Me.txtFiadorMatri = New System.Windows.Forms.TextBox()
        Me.txtTelFiadorMatri = New System.Windows.Forms.TextBox()
        Id_MatriLabel = New System.Windows.Forms.Label()
        ApelMatriLabel = New System.Windows.Forms.Label()
        ApelMatMatriLabel = New System.Windows.Forms.Label()
        FecNacMatriLabel = New System.Windows.Forms.Label()
        LugarNacMatriLabel = New System.Windows.Forms.Label()
        NacionNacMatriLabel = New System.Windows.Forms.Label()
        TipoDocMatriLabel = New System.Windows.Forms.Label()
        NroDocMatriLabel = New System.Windows.Forms.Label()
        SexoMatriLabel = New System.Windows.Forms.Label()
        EstCivilMatriLabel = New System.Windows.Forms.Label()
        CuitMatriLabel = New System.Windows.Forms.Label()
        FecJurMatriLabel = New System.Windows.Forms.Label()
        CatAporteMatriLabel = New System.Windows.Forms.Label()
        EstadoMatriLabel = New System.Windows.Forms.Label()
        FecEstadoMatriLabel = New System.Windows.Forms.Label()
        CalleRealMatriLabel = New System.Windows.Forms.Label()
        CPRealMatriLabel = New System.Windows.Forms.Label()
        EmailMatriLabel = New System.Windows.Forms.Label()
        CeluRealMatriLabel = New System.Windows.Forms.Label()
        FijoRealMatriLabel = New System.Windows.Forms.Label()
        CalleLegalMatriLabel = New System.Windows.Forms.Label()
        CPLegalMatriLabel = New System.Windows.Forms.Label()
        CeluLegalMatriLabel = New System.Windows.Forms.Label()
        FijoLegalMatriLabel = New System.Windows.Forms.Label()
        FianzaMatriLabel = New System.Windows.Forms.Label()
        FiadorMatriLabel = New System.Windows.Forms.Label()
        DocFiadorMatriLabel = New System.Windows.Forms.Label()
        CalleFiadorMatriLabel = New System.Windows.Forms.Label()
        ObsMatriLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.MatriculadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatriculadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MatriculadosBindingNavigator.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_MatriLabel
        '
        Id_MatriLabel.AutoSize = True
        Id_MatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_MatriLabel.ForeColor = System.Drawing.Color.White
        Id_MatriLabel.Location = New System.Drawing.Point(66, 59)
        Id_MatriLabel.Name = "Id_MatriLabel"
        Id_MatriLabel.Size = New System.Drawing.Size(72, 17)
        Id_MatriLabel.TabIndex = 0
        Id_MatriLabel.Text = "Matrícula:"
        '
        'ApelMatriLabel
        '
        ApelMatriLabel.AutoSize = True
        ApelMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApelMatriLabel.ForeColor = System.Drawing.Color.White
        ApelMatriLabel.Location = New System.Drawing.Point(217, 59)
        ApelMatriLabel.Name = "ApelMatriLabel"
        ApelMatriLabel.Size = New System.Drawing.Size(137, 17)
        ApelMatriLabel.TabIndex = 1
        ApelMatriLabel.Text = "Apellido y Nombres:"
        '
        'ApelMatMatriLabel
        '
        ApelMatMatriLabel.AutoSize = True
        ApelMatMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApelMatMatriLabel.ForeColor = System.Drawing.Color.White
        ApelMatMatriLabel.Location = New System.Drawing.Point(765, 59)
        ApelMatMatriLabel.Name = "ApelMatMatriLabel"
        ApelMatMatriLabel.Size = New System.Drawing.Size(123, 17)
        ApelMatMatriLabel.TabIndex = 3
        ApelMatMatriLabel.Text = "Apellido Materno:"
        '
        'FecNacMatriLabel
        '
        FecNacMatriLabel.AutoSize = True
        FecNacMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FecNacMatriLabel.ForeColor = System.Drawing.Color.White
        FecNacMatriLabel.Location = New System.Drawing.Point(7, 88)
        FecNacMatriLabel.Name = "FecNacMatriLabel"
        FecNacMatriLabel.Size = New System.Drawing.Size(131, 17)
        FecNacMatriLabel.TabIndex = 8
        FecNacMatriLabel.Text = "Fecha Nacimiento:"
        '
        'LugarNacMatriLabel
        '
        LugarNacMatriLabel.AutoSize = True
        LugarNacMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LugarNacMatriLabel.ForeColor = System.Drawing.Color.White
        LugarNacMatriLabel.Location = New System.Drawing.Point(255, 88)
        LugarNacMatriLabel.Name = "LugarNacMatriLabel"
        LugarNacMatriLabel.Size = New System.Drawing.Size(99, 17)
        LugarNacMatriLabel.TabIndex = 10
        LugarNacMatriLabel.Text = "Lugar Nacim.:"
        '
        'NacionNacMatriLabel
        '
        NacionNacMatriLabel.AutoSize = True
        NacionNacMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NacionNacMatriLabel.ForeColor = System.Drawing.Color.White
        NacionNacMatriLabel.Location = New System.Drawing.Point(787, 88)
        NacionNacMatriLabel.Name = "NacionNacMatriLabel"
        NacionNacMatriLabel.Size = New System.Drawing.Size(101, 17)
        NacionNacMatriLabel.TabIndex = 12
        NacionNacMatriLabel.Text = "Nacionalidad:"
        '
        'TipoDocMatriLabel
        '
        TipoDocMatriLabel.AutoSize = True
        TipoDocMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoDocMatriLabel.ForeColor = System.Drawing.Color.White
        TipoDocMatriLabel.Location = New System.Drawing.Point(44, 118)
        TipoDocMatriLabel.Name = "TipoDocMatriLabel"
        TipoDocMatriLabel.Size = New System.Drawing.Size(94, 17)
        TipoDocMatriLabel.TabIndex = 14
        TipoDocMatriLabel.Text = "Tipo Docum.:"
        '
        'NroDocMatriLabel
        '
        NroDocMatriLabel.AutoSize = True
        NroDocMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NroDocMatriLabel.ForeColor = System.Drawing.Color.White
        NroDocMatriLabel.Location = New System.Drawing.Point(259, 117)
        NroDocMatriLabel.Name = "NroDocMatriLabel"
        NroDocMatriLabel.Size = New System.Drawing.Size(95, 17)
        NroDocMatriLabel.TabIndex = 16
        NroDocMatriLabel.Text = "Nro. Docum.:"
        '
        'SexoMatriLabel
        '
        SexoMatriLabel.AutoSize = True
        SexoMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SexoMatriLabel.ForeColor = System.Drawing.Color.White
        SexoMatriLabel.Location = New System.Drawing.Point(485, 118)
        SexoMatriLabel.Name = "SexoMatriLabel"
        SexoMatriLabel.Size = New System.Drawing.Size(41, 17)
        SexoMatriLabel.TabIndex = 18
        SexoMatriLabel.Text = "Sexo:"
        '
        'EstCivilMatriLabel
        '
        EstCivilMatriLabel.AutoSize = True
        EstCivilMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstCivilMatriLabel.ForeColor = System.Drawing.Color.White
        EstCivilMatriLabel.Location = New System.Drawing.Point(600, 118)
        EstCivilMatriLabel.Name = "EstCivilMatriLabel"
        EstCivilMatriLabel.Size = New System.Drawing.Size(88, 17)
        EstCivilMatriLabel.TabIndex = 20
        EstCivilMatriLabel.Text = "Estado Civil:"
        '
        'CuitMatriLabel
        '
        CuitMatriLabel.AutoSize = True
        CuitMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CuitMatriLabel.ForeColor = System.Drawing.Color.White
        CuitMatriLabel.Location = New System.Drawing.Point(833, 117)
        CuitMatriLabel.Name = "CuitMatriLabel"
        CuitMatriLabel.Size = New System.Drawing.Size(55, 17)
        CuitMatriLabel.TabIndex = 22
        CuitMatriLabel.Text = "C.U.I.T.:"
        '
        'FecJurMatriLabel
        '
        FecJurMatriLabel.AutoSize = True
        FecJurMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FecJurMatriLabel.ForeColor = System.Drawing.Color.White
        FecJurMatriLabel.Location = New System.Drawing.Point(26, 148)
        FecJurMatriLabel.Name = "FecJurMatriLabel"
        FecJurMatriLabel.Size = New System.Drawing.Size(112, 17)
        FecJurMatriLabel.TabIndex = 24
        FecJurMatriLabel.Text = "Fec. Juramento:"
        '
        'CatAporteMatriLabel
        '
        CatAporteMatriLabel.AutoSize = True
        CatAporteMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CatAporteMatriLabel.ForeColor = System.Drawing.Color.White
        CatAporteMatriLabel.Location = New System.Drawing.Point(248, 148)
        CatAporteMatriLabel.Name = "CatAporteMatriLabel"
        CatAporteMatriLabel.Size = New System.Drawing.Size(106, 17)
        CatAporteMatriLabel.TabIndex = 26
        CatAporteMatriLabel.Text = "Categ. Aporte:"
        '
        'EstadoMatriLabel
        '
        EstadoMatriLabel.AutoSize = True
        EstadoMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoMatriLabel.ForeColor = System.Drawing.Color.White
        EstadoMatriLabel.Location = New System.Drawing.Point(470, 148)
        EstadoMatriLabel.Name = "EstadoMatriLabel"
        EstadoMatriLabel.Size = New System.Drawing.Size(56, 17)
        EstadoMatriLabel.TabIndex = 28
        EstadoMatriLabel.Text = "Estado:"
        '
        'FecEstadoMatriLabel
        '
        FecEstadoMatriLabel.AutoSize = True
        FecEstadoMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FecEstadoMatriLabel.ForeColor = System.Drawing.Color.White
        FecEstadoMatriLabel.Location = New System.Drawing.Point(789, 148)
        FecEstadoMatriLabel.Name = "FecEstadoMatriLabel"
        FecEstadoMatriLabel.Size = New System.Drawing.Size(99, 17)
        FecEstadoMatriLabel.TabIndex = 30
        FecEstadoMatriLabel.Text = "Fecha Estado:"
        '
        'CalleRealMatriLabel
        '
        CalleRealMatriLabel.AutoSize = True
        CalleRealMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CalleRealMatriLabel.ForeColor = System.Drawing.Color.White
        CalleRealMatriLabel.Location = New System.Drawing.Point(33, 228)
        CalleRealMatriLabel.Name = "CalleRealMatriLabel"
        CalleRealMatriLabel.Size = New System.Drawing.Size(105, 17)
        CalleRealMatriLabel.TabIndex = 34
        CalleRealMatriLabel.Text = "Domicilio Real:"
        '
        'CPRealMatriLabel
        '
        CPRealMatriLabel.AutoSize = True
        CPRealMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPRealMatriLabel.ForeColor = System.Drawing.Color.White
        CPRealMatriLabel.Location = New System.Drawing.Point(451, 228)
        CPRealMatriLabel.Name = "CPRealMatriLabel"
        CPRealMatriLabel.Size = New System.Drawing.Size(107, 17)
        CPRealMatriLabel.TabIndex = 36
        CPRealMatriLabel.Text = "Cod. Pos. Real:"
        '
        'EmailMatriLabel
        '
        EmailMatriLabel.AutoSize = True
        EmailMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailMatriLabel.ForeColor = System.Drawing.Color.White
        EmailMatriLabel.Location = New System.Drawing.Point(87, 177)
        EmailMatriLabel.Name = "EmailMatriLabel"
        EmailMatriLabel.Size = New System.Drawing.Size(51, 17)
        EmailMatriLabel.TabIndex = 32
        EmailMatriLabel.Text = "E-mail:"
        '
        'CeluRealMatriLabel
        '
        CeluRealMatriLabel.AutoSize = True
        CeluRealMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CeluRealMatriLabel.ForeColor = System.Drawing.Color.White
        CeluRealMatriLabel.Location = New System.Drawing.Point(48, 257)
        CeluRealMatriLabel.Name = "CeluRealMatriLabel"
        CeluRealMatriLabel.Size = New System.Drawing.Size(90, 17)
        CeluRealMatriLabel.TabIndex = 40
        CeluRealMatriLabel.Text = "Celular Real:"
        '
        'FijoRealMatriLabel
        '
        FijoRealMatriLabel.AutoSize = True
        FijoRealMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FijoRealMatriLabel.ForeColor = System.Drawing.Color.White
        FijoRealMatriLabel.Location = New System.Drawing.Point(500, 257)
        FijoRealMatriLabel.Name = "FijoRealMatriLabel"
        FijoRealMatriLabel.Size = New System.Drawing.Size(65, 17)
        FijoRealMatriLabel.TabIndex = 42
        FijoRealMatriLabel.Text = "Fijo Real:"
        '
        'CalleLegalMatriLabel
        '
        CalleLegalMatriLabel.AutoSize = True
        CalleLegalMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CalleLegalMatriLabel.ForeColor = System.Drawing.Color.White
        CalleLegalMatriLabel.Location = New System.Drawing.Point(26, 286)
        CalleLegalMatriLabel.Name = "CalleLegalMatriLabel"
        CalleLegalMatriLabel.Size = New System.Drawing.Size(112, 17)
        CalleLegalMatriLabel.TabIndex = 44
        CalleLegalMatriLabel.Text = "Domicilio Legal:"
        '
        'CPLegalMatriLabel
        '
        CPLegalMatriLabel.AutoSize = True
        CPLegalMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPLegalMatriLabel.ForeColor = System.Drawing.Color.White
        CPLegalMatriLabel.Location = New System.Drawing.Point(451, 286)
        CPLegalMatriLabel.Name = "CPLegalMatriLabel"
        CPLegalMatriLabel.Size = New System.Drawing.Size(114, 17)
        CPLegalMatriLabel.TabIndex = 46
        CPLegalMatriLabel.Text = "Cod. Pos. Legal:"
        '
        'CeluLegalMatriLabel
        '
        CeluLegalMatriLabel.AutoSize = True
        CeluLegalMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CeluLegalMatriLabel.ForeColor = System.Drawing.Color.White
        CeluLegalMatriLabel.Location = New System.Drawing.Point(41, 315)
        CeluLegalMatriLabel.Name = "CeluLegalMatriLabel"
        CeluLegalMatriLabel.Size = New System.Drawing.Size(97, 17)
        CeluLegalMatriLabel.TabIndex = 50
        CeluLegalMatriLabel.Text = "Celular Legal:"
        '
        'FijoLegalMatriLabel
        '
        FijoLegalMatriLabel.AutoSize = True
        FijoLegalMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FijoLegalMatriLabel.ForeColor = System.Drawing.Color.White
        FijoLegalMatriLabel.Location = New System.Drawing.Point(493, 315)
        FijoLegalMatriLabel.Name = "FijoLegalMatriLabel"
        FijoLegalMatriLabel.Size = New System.Drawing.Size(72, 17)
        FijoLegalMatriLabel.TabIndex = 52
        FijoLegalMatriLabel.Text = "Fijo Legal:"
        '
        'FianzaMatriLabel
        '
        FianzaMatriLabel.AutoSize = True
        FianzaMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FianzaMatriLabel.ForeColor = System.Drawing.Color.White
        FianzaMatriLabel.Location = New System.Drawing.Point(42, 372)
        FianzaMatriLabel.Name = "FianzaMatriLabel"
        FianzaMatriLabel.Size = New System.Drawing.Size(96, 17)
        FianzaMatriLabel.TabIndex = 54
        FianzaMatriLabel.Text = "Fecha Fianza:"
        '
        'FiadorMatriLabel
        '
        FiadorMatriLabel.AutoSize = True
        FiadorMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FiadorMatriLabel.ForeColor = System.Drawing.Color.White
        FiadorMatriLabel.Location = New System.Drawing.Point(276, 372)
        FiadorMatriLabel.Name = "FiadorMatriLabel"
        FiadorMatriLabel.Size = New System.Drawing.Size(109, 17)
        FiadorMatriLabel.TabIndex = 56
        FiadorMatriLabel.Text = "Nombre Fiador:"
        '
        'DocFiadorMatriLabel
        '
        DocFiadorMatriLabel.AutoSize = True
        DocFiadorMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DocFiadorMatriLabel.ForeColor = System.Drawing.Color.White
        DocFiadorMatriLabel.Location = New System.Drawing.Point(804, 371)
        DocFiadorMatriLabel.Name = "DocFiadorMatriLabel"
        DocFiadorMatriLabel.Size = New System.Drawing.Size(87, 17)
        DocFiadorMatriLabel.TabIndex = 58
        DocFiadorMatriLabel.Text = "Doc. Fiador:"
        '
        'CalleFiadorMatriLabel
        '
        CalleFiadorMatriLabel.AutoSize = True
        CalleFiadorMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CalleFiadorMatriLabel.ForeColor = System.Drawing.Color.White
        CalleFiadorMatriLabel.Location = New System.Drawing.Point(21, 401)
        CalleFiadorMatriLabel.Name = "CalleFiadorMatriLabel"
        CalleFiadorMatriLabel.Size = New System.Drawing.Size(117, 17)
        CalleFiadorMatriLabel.TabIndex = 60
        CalleFiadorMatriLabel.Text = "Domicilio Fiador:"
        '
        'ObsMatriLabel
        '
        ObsMatriLabel.AutoSize = True
        ObsMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsMatriLabel.ForeColor = System.Drawing.Color.White
        ObsMatriLabel.Location = New System.Drawing.Point(31, 430)
        ObsMatriLabel.Name = "ObsMatriLabel"
        ObsMatriLabel.Size = New System.Drawing.Size(107, 17)
        ObsMatriLabel.TabIndex = 62
        ObsMatriLabel.Text = "Observaciones:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(781, 400)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(110, 17)
        Label2.TabIndex = 145
        Label2.Text = "Teléfono Fiador:"
        '
        'txtId_Matri
        '
        Me.txtId_Matri.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtId_Matri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_Matri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "id_Matri", True))
        Me.txtId_Matri.Enabled = False
        Me.txtId_Matri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_Matri.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtId_Matri.Location = New System.Drawing.Point(712, 177)
        Me.txtId_Matri.Name = "txtId_Matri"
        Me.txtId_Matri.Size = New System.Drawing.Size(50, 16)
        Me.txtId_Matri.TabIndex = 66
        '
        'MatriculadosBindingSource
        '
        Me.MatriculadosBindingSource.DataMember = "matriculados"
        Me.MatriculadosBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtApelNombMatri
        '
        Me.txtApelNombMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtApelNombMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApelNombMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApelNombMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "ApelNombMatri", True))
        Me.txtApelNombMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApelNombMatri.ForeColor = System.Drawing.Color.White
        Me.txtApelNombMatri.Location = New System.Drawing.Point(360, 56)
        Me.txtApelNombMatri.MaxLength = 50
        Me.txtApelNombMatri.Name = "txtApelNombMatri"
        Me.txtApelNombMatri.Size = New System.Drawing.Size(353, 23)
        Me.txtApelNombMatri.TabIndex = 1
        '
        'txtApelMatMatri
        '
        Me.txtApelMatMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtApelMatMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApelMatMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApelMatMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "ApelMatMatri", True))
        Me.txtApelMatMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApelMatMatri.ForeColor = System.Drawing.Color.White
        Me.txtApelMatMatri.Location = New System.Drawing.Point(894, 56)
        Me.txtApelMatMatri.MaxLength = 30
        Me.txtApelMatMatri.Name = "txtApelMatMatri"
        Me.txtApelMatMatri.Size = New System.Drawing.Size(188, 23)
        Me.txtApelMatMatri.TabIndex = 2
        '
        'txtLugarNacMatri
        '
        Me.txtLugarNacMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtLugarNacMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLugarNacMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLugarNacMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "LugarNacMatri", True))
        Me.txtLugarNacMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarNacMatri.ForeColor = System.Drawing.Color.White
        Me.txtLugarNacMatri.Location = New System.Drawing.Point(360, 85)
        Me.txtLugarNacMatri.MaxLength = 40
        Me.txtLugarNacMatri.Name = "txtLugarNacMatri"
        Me.txtLugarNacMatri.Size = New System.Drawing.Size(273, 23)
        Me.txtLugarNacMatri.TabIndex = 4
        '
        'txtNacionNacMatri
        '
        Me.txtNacionNacMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNacionNacMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNacionNacMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNacionNacMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "NacionNacMatri", True))
        Me.txtNacionNacMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNacionNacMatri.ForeColor = System.Drawing.Color.White
        Me.txtNacionNacMatri.Location = New System.Drawing.Point(894, 85)
        Me.txtNacionNacMatri.MaxLength = 30
        Me.txtNacionNacMatri.Name = "txtNacionNacMatri"
        Me.txtNacionNacMatri.Size = New System.Drawing.Size(188, 23)
        Me.txtNacionNacMatri.TabIndex = 5
        '
        'txtNroDocMatri
        '
        Me.txtNroDocMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroDocMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroDocMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "NroDocMatri", True))
        Me.txtNroDocMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocMatri.ForeColor = System.Drawing.Color.White
        Me.txtNroDocMatri.Location = New System.Drawing.Point(360, 114)
        Me.txtNroDocMatri.MaxLength = 8
        Me.txtNroDocMatri.Name = "txtNroDocMatri"
        Me.txtNroDocMatri.Size = New System.Drawing.Size(116, 23)
        Me.txtNroDocMatri.TabIndex = 7
        '
        'txtCuitMatri
        '
        Me.txtCuitMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCuitMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuitMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CuitMatri", True))
        Me.txtCuitMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuitMatri.ForeColor = System.Drawing.Color.White
        Me.txtCuitMatri.Location = New System.Drawing.Point(894, 114)
        Me.txtCuitMatri.MaxLength = 13
        Me.txtCuitMatri.Name = "txtCuitMatri"
        Me.txtCuitMatri.Size = New System.Drawing.Size(188, 23)
        Me.txtCuitMatri.TabIndex = 10
        '
        'txtCalleRealMatri
        '
        Me.txtCalleRealMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCalleRealMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalleRealMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalleRealMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CalleRealMatri", True))
        Me.txtCalleRealMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalleRealMatri.ForeColor = System.Drawing.Color.White
        Me.txtCalleRealMatri.Location = New System.Drawing.Point(144, 225)
        Me.txtCalleRealMatri.MaxLength = 30
        Me.txtCalleRealMatri.Name = "txtCalleRealMatri"
        Me.txtCalleRealMatri.Size = New System.Drawing.Size(303, 23)
        Me.txtCalleRealMatri.TabIndex = 16
        '
        'txtCPRealMatri
        '
        Me.txtCPRealMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCPRealMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCPRealMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CPRealMatri", True))
        Me.txtCPRealMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPRealMatri.ForeColor = System.Drawing.Color.White
        Me.txtCPRealMatri.Location = New System.Drawing.Point(571, 225)
        Me.txtCPRealMatri.MaxLength = 5
        Me.txtCPRealMatri.Name = "txtCPRealMatri"
        Me.txtCPRealMatri.Size = New System.Drawing.Size(67, 23)
        Me.txtCPRealMatri.TabIndex = 17
        '
        'txtEmailMatri
        '
        Me.txtEmailMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtEmailMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmailMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "EmailMatri", True))
        Me.txtEmailMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailMatri.ForeColor = System.Drawing.Color.White
        Me.txtEmailMatri.Location = New System.Drawing.Point(144, 174)
        Me.txtEmailMatri.MaxLength = 80
        Me.txtEmailMatri.Name = "txtEmailMatri"
        Me.txtEmailMatri.Size = New System.Drawing.Size(563, 23)
        Me.txtEmailMatri.TabIndex = 15
        '
        'txtCeluRealMatri
        '
        Me.txtCeluRealMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCeluRealMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCeluRealMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CeluRealMatri", True))
        Me.txtCeluRealMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCeluRealMatri.ForeColor = System.Drawing.Color.White
        Me.txtCeluRealMatri.Location = New System.Drawing.Point(144, 254)
        Me.txtCeluRealMatri.MaxLength = 15
        Me.txtCeluRealMatri.Name = "txtCeluRealMatri"
        Me.txtCeluRealMatri.Size = New System.Drawing.Size(266, 23)
        Me.txtCeluRealMatri.TabIndex = 20
        '
        'txtFijoRealMatri
        '
        Me.txtFijoRealMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFijoRealMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFijoRealMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FijoRealMatri", True))
        Me.txtFijoRealMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFijoRealMatri.ForeColor = System.Drawing.Color.White
        Me.txtFijoRealMatri.Location = New System.Drawing.Point(571, 254)
        Me.txtFijoRealMatri.MaxLength = 15
        Me.txtFijoRealMatri.Name = "txtFijoRealMatri"
        Me.txtFijoRealMatri.Size = New System.Drawing.Size(200, 23)
        Me.txtFijoRealMatri.TabIndex = 21
        '
        'txtCalleLegalMatri
        '
        Me.txtCalleLegalMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCalleLegalMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalleLegalMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalleLegalMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CalleLegalMatri", True))
        Me.txtCalleLegalMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalleLegalMatri.ForeColor = System.Drawing.Color.White
        Me.txtCalleLegalMatri.Location = New System.Drawing.Point(144, 283)
        Me.txtCalleLegalMatri.MaxLength = 30
        Me.txtCalleLegalMatri.Name = "txtCalleLegalMatri"
        Me.txtCalleLegalMatri.Size = New System.Drawing.Size(303, 23)
        Me.txtCalleLegalMatri.TabIndex = 22
        '
        'txtCPLegalMatri
        '
        Me.txtCPLegalMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCPLegalMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCPLegalMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CPLegalMatri", True))
        Me.txtCPLegalMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPLegalMatri.ForeColor = System.Drawing.Color.White
        Me.txtCPLegalMatri.Location = New System.Drawing.Point(571, 283)
        Me.txtCPLegalMatri.MaxLength = 5
        Me.txtCPLegalMatri.Name = "txtCPLegalMatri"
        Me.txtCPLegalMatri.Size = New System.Drawing.Size(67, 23)
        Me.txtCPLegalMatri.TabIndex = 23
        '
        'txtCeluLegalMatri
        '
        Me.txtCeluLegalMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCeluLegalMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCeluLegalMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CeluLegalMatri", True))
        Me.txtCeluLegalMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCeluLegalMatri.ForeColor = System.Drawing.Color.White
        Me.txtCeluLegalMatri.Location = New System.Drawing.Point(144, 312)
        Me.txtCeluLegalMatri.MaxLength = 15
        Me.txtCeluLegalMatri.Name = "txtCeluLegalMatri"
        Me.txtCeluLegalMatri.Size = New System.Drawing.Size(266, 23)
        Me.txtCeluLegalMatri.TabIndex = 26
        '
        'txtFijoLegalMatri
        '
        Me.txtFijoLegalMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFijoLegalMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFijoLegalMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FijoLegalMatri", True))
        Me.txtFijoLegalMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFijoLegalMatri.ForeColor = System.Drawing.Color.White
        Me.txtFijoLegalMatri.Location = New System.Drawing.Point(571, 312)
        Me.txtFijoLegalMatri.MaxLength = 15
        Me.txtFijoLegalMatri.Name = "txtFijoLegalMatri"
        Me.txtFijoLegalMatri.Size = New System.Drawing.Size(200, 23)
        Me.txtFijoLegalMatri.TabIndex = 27
        '
        'txtDocFiadorMatri
        '
        Me.txtDocFiadorMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDocFiadorMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocFiadorMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "DocFiadorMatri", True))
        Me.txtDocFiadorMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocFiadorMatri.ForeColor = System.Drawing.Color.White
        Me.txtDocFiadorMatri.Location = New System.Drawing.Point(897, 369)
        Me.txtDocFiadorMatri.MaxLength = 8
        Me.txtDocFiadorMatri.Name = "txtDocFiadorMatri"
        Me.txtDocFiadorMatri.Size = New System.Drawing.Size(185, 23)
        Me.txtDocFiadorMatri.TabIndex = 30
        '
        'txtCalleFiadorMatri
        '
        Me.txtCalleFiadorMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCalleFiadorMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalleFiadorMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalleFiadorMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CalleFiadorMatri", True))
        Me.txtCalleFiadorMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalleFiadorMatri.ForeColor = System.Drawing.Color.White
        Me.txtCalleFiadorMatri.Location = New System.Drawing.Point(144, 398)
        Me.txtCalleFiadorMatri.MaxLength = 30
        Me.txtCalleFiadorMatri.Name = "txtCalleFiadorMatri"
        Me.txtCalleFiadorMatri.Size = New System.Drawing.Size(407, 23)
        Me.txtCalleFiadorMatri.TabIndex = 31
        '
        'txtObsMatri
        '
        Me.txtObsMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObsMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "ObsMatri", True))
        Me.txtObsMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsMatri.ForeColor = System.Drawing.Color.White
        Me.txtObsMatri.Location = New System.Drawing.Point(144, 427)
        Me.txtObsMatri.MaxLength = 100
        Me.txtObsMatri.Name = "txtObsMatri"
        Me.txtObsMatri.Size = New System.Drawing.Size(938, 23)
        Me.txtObsMatri.TabIndex = 33
        '
        'txtLocalReal
        '
        Me.txtLocalReal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtLocalReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalReal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocalReal.Enabled = False
        Me.txtLocalReal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalReal.ForeColor = System.Drawing.Color.White
        Me.txtLocalReal.Location = New System.Drawing.Point(644, 225)
        Me.txtLocalReal.Name = "txtLocalReal"
        Me.txtLocalReal.Size = New System.Drawing.Size(207, 23)
        Me.txtLocalReal.TabIndex = 18
        '
        'txtProvReal
        '
        Me.txtProvReal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtProvReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvReal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProvReal.Enabled = False
        Me.txtProvReal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvReal.ForeColor = System.Drawing.Color.White
        Me.txtProvReal.Location = New System.Drawing.Point(855, 225)
        Me.txtProvReal.Name = "txtProvReal"
        Me.txtProvReal.Size = New System.Drawing.Size(227, 23)
        Me.txtProvReal.TabIndex = 19
        '
        'txtLocalLegal
        '
        Me.txtLocalLegal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtLocalLegal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalLegal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocalLegal.Enabled = False
        Me.txtLocalLegal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalLegal.ForeColor = System.Drawing.Color.White
        Me.txtLocalLegal.Location = New System.Drawing.Point(644, 283)
        Me.txtLocalLegal.Name = "txtLocalLegal"
        Me.txtLocalLegal.Size = New System.Drawing.Size(207, 23)
        Me.txtLocalLegal.TabIndex = 24
        '
        'txtProvLegal
        '
        Me.txtProvLegal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtProvLegal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvLegal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProvLegal.Enabled = False
        Me.txtProvLegal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvLegal.ForeColor = System.Drawing.Color.White
        Me.txtProvLegal.Location = New System.Drawing.Point(855, 283)
        Me.txtProvLegal.Name = "txtProvLegal"
        Me.txtProvLegal.Size = New System.Drawing.Size(227, 23)
        Me.txtProvLegal.TabIndex = 25
        '
        'cmbTipoDocMatri
        '
        Me.cmbTipoDocMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbTipoDocMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "TipoDocMatri", True))
        Me.cmbTipoDocMatri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoDocMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDocMatri.ForeColor = System.Drawing.Color.White
        Me.cmbTipoDocMatri.FormattingEnabled = True
        Me.cmbTipoDocMatri.Items.AddRange(New Object() {"DNI", "CI", "LE", "LC", "PAS"})
        Me.cmbTipoDocMatri.Location = New System.Drawing.Point(144, 114)
        Me.cmbTipoDocMatri.Name = "cmbTipoDocMatri"
        Me.cmbTipoDocMatri.Size = New System.Drawing.Size(66, 25)
        Me.cmbTipoDocMatri.TabIndex = 6
        '
        'cmbSexoMatri
        '
        Me.cmbSexoMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbSexoMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "SexoMatri", True))
        Me.cmbSexoMatri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSexoMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSexoMatri.ForeColor = System.Drawing.Color.White
        Me.cmbSexoMatri.FormattingEnabled = True
        Me.cmbSexoMatri.Items.AddRange(New Object() {"M", "F"})
        Me.cmbSexoMatri.Location = New System.Drawing.Point(532, 114)
        Me.cmbSexoMatri.Name = "cmbSexoMatri"
        Me.cmbSexoMatri.Size = New System.Drawing.Size(57, 25)
        Me.cmbSexoMatri.TabIndex = 8
        '
        'cmbEstCivilMatri
        '
        Me.cmbEstCivilMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbEstCivilMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "EstCivilMatri", True))
        Me.cmbEstCivilMatri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEstCivilMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstCivilMatri.ForeColor = System.Drawing.Color.White
        Me.cmbEstCivilMatri.FormattingEnabled = True
        Me.cmbEstCivilMatri.Items.AddRange(New Object() {"SOLTERO", "CASADO", "SEPARADO", "DIVORCIADO", "VIUDO"})
        Me.cmbEstCivilMatri.Location = New System.Drawing.Point(694, 114)
        Me.cmbEstCivilMatri.Name = "cmbEstCivilMatri"
        Me.cmbEstCivilMatri.Size = New System.Drawing.Size(135, 25)
        Me.cmbEstCivilMatri.TabIndex = 9
        '
        'cmbCatAporteMatri
        '
        Me.cmbCatAporteMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbCatAporteMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CatAporteMatri", True))
        Me.cmbCatAporteMatri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCatAporteMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCatAporteMatri.ForeColor = System.Drawing.Color.White
        Me.cmbCatAporteMatri.FormattingEnabled = True
        Me.cmbCatAporteMatri.Items.AddRange(New Object() {"A", "B"})
        Me.cmbCatAporteMatri.Location = New System.Drawing.Point(360, 143)
        Me.cmbCatAporteMatri.Name = "cmbCatAporteMatri"
        Me.cmbCatAporteMatri.Size = New System.Drawing.Size(61, 25)
        Me.cmbCatAporteMatri.TabIndex = 12
        '
        'cmbEstadoMatri
        '
        Me.cmbEstadoMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbEstadoMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "EstadoMatri", True))
        Me.cmbEstadoMatri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEstadoMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstadoMatri.ForeColor = System.Drawing.Color.White
        Me.cmbEstadoMatri.FormattingEnabled = True
        Me.cmbEstadoMatri.Items.AddRange(New Object() {"ACTIVO", "BAJA", "CANCELADO", "SUSPENDIDO", "SUSP. MOROSO"})
        Me.cmbEstadoMatri.Location = New System.Drawing.Point(532, 145)
        Me.cmbEstadoMatri.Name = "cmbEstadoMatri"
        Me.cmbEstadoMatri.Size = New System.Drawing.Size(135, 25)
        Me.cmbEstadoMatri.TabIndex = 13
        '
        'txtNroMatri
        '
        Me.txtNroMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "NroMatri", True))
        Me.txtNroMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroMatri.ForeColor = System.Drawing.Color.White
        Me.txtNroMatri.Location = New System.Drawing.Point(144, 56)
        Me.txtNroMatri.MaxLength = 5
        Me.txtNroMatri.Name = "txtNroMatri"
        Me.txtNroMatri.Size = New System.Drawing.Size(49, 23)
        Me.txtNroMatri.TabIndex = 0
        '
        'BtnUltimo
        '
        Me.BtnUltimo.AutoSize = True
        Me.BtnUltimo.FlatAppearance.BorderSize = 0
        Me.BtnUltimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUltimo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUltimo.ForeColor = System.Drawing.Color.White
        Me.BtnUltimo.Image = CType(resources.GetObject("BtnUltimo.Image"), System.Drawing.Image)
        Me.BtnUltimo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnUltimo.Location = New System.Drawing.Point(871, 487)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnUltimo.Size = New System.Drawing.Size(38, 38)
        Me.BtnUltimo.TabIndex = 79
        Me.BtnUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUltimo.UseVisualStyleBackColor = True
        '
        'BtnPrimer
        '
        Me.BtnPrimer.AutoSize = True
        Me.BtnPrimer.FlatAppearance.BorderSize = 0
        Me.BtnPrimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnPrimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrimer.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrimer.ForeColor = System.Drawing.Color.White
        Me.BtnPrimer.Image = CType(resources.GetObject("BtnPrimer.Image"), System.Drawing.Image)
        Me.BtnPrimer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPrimer.Location = New System.Drawing.Point(736, 487)
        Me.BtnPrimer.Name = "BtnPrimer"
        Me.BtnPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPrimer.Size = New System.Drawing.Size(38, 38)
        Me.BtnPrimer.TabIndex = 76
        Me.BtnPrimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPrimer.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.AutoSize = True
        Me.BtnSiguiente.FlatAppearance.BorderSize = 0
        Me.BtnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSiguiente.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.ForeColor = System.Drawing.Color.White
        Me.BtnSiguiente.Image = CType(resources.GetObject("BtnSiguiente.Image"), System.Drawing.Image)
        Me.BtnSiguiente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSiguiente.Location = New System.Drawing.Point(826, 487)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSiguiente.Size = New System.Drawing.Size(38, 38)
        Me.BtnSiguiente.TabIndex = 78
        Me.BtnSiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.AutoSize = True
        Me.BtnAnterior.FlatAppearance.BorderSize = 0
        Me.BtnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnterior.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnterior.ForeColor = System.Drawing.Color.White
        Me.BtnAnterior.Image = CType(resources.GetObject("BtnAnterior.Image"), System.Drawing.Image)
        Me.BtnAnterior.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAnterior.Location = New System.Drawing.Point(781, 487)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAnterior.Size = New System.Drawing.Size(38, 38)
        Me.BtnAnterior.TabIndex = 77
        Me.BtnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.AutoSize = True
        Me.BtnActualizar.FlatAppearance.BorderSize = 0
        Me.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(596, 479)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnActualizar.Size = New System.Drawing.Size(87, 56)
        Me.BtnActualizar.TabIndex = 75
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.AutoSize = True
        Me.BtnGrabar.FlatAppearance.BorderSize = 0
        Me.BtnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrabar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.ForeColor = System.Drawing.Color.White
        Me.BtnGrabar.Image = CType(resources.GetObject("BtnGrabar.Image"), System.Drawing.Image)
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGrabar.Location = New System.Drawing.Point(245, 479)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGrabar.Size = New System.Drawing.Size(59, 56)
        Me.BtnGrabar.TabIndex = 74
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.AutoSize = True
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(947, 479)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(87, 56)
        Me.BtnSalir.TabIndex = 80
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.AutoSize = True
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnModificar.Location = New System.Drawing.Point(328, 479)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnModificar.Size = New System.Drawing.Size(80, 56)
        Me.BtnModificar.TabIndex = 73
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.AutoSize = True
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(424, 479)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEliminar.Size = New System.Drawing.Size(73, 56)
        Me.BtnEliminar.TabIndex = 72
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.AutoSize = True
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(516, 479)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnBuscar.Size = New System.Drawing.Size(59, 56)
        Me.BtnBuscar.TabIndex = 71
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.AutoSize = True
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAgregar.Location = New System.Drawing.Point(162, 479)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAgregar.Size = New System.Drawing.Size(66, 56)
        Me.BtnAgregar.TabIndex = 70
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'lblAtencion1
        '
        Me.lblAtencion1.AutoSize = True
        Me.lblAtencion1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblAtencion1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtencion1.ForeColor = System.Drawing.Color.Red
        Me.lblAtencion1.Location = New System.Drawing.Point(653, 228)
        Me.lblAtencion1.Name = "lblAtencion1"
        Me.lblAtencion1.Size = New System.Drawing.Size(234, 17)
        Me.lblAtencion1.TabIndex = 82
        Me.lblAtencion1.Text = "F1 para consultar Códigos Postales"
        Me.lblAtencion1.Visible = False
        '
        'lblAtencion2
        '
        Me.lblAtencion2.AutoSize = True
        Me.lblAtencion2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblAtencion2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtencion2.ForeColor = System.Drawing.Color.Red
        Me.lblAtencion2.Location = New System.Drawing.Point(653, 285)
        Me.lblAtencion2.Name = "lblAtencion2"
        Me.lblAtencion2.Size = New System.Drawing.Size(234, 17)
        Me.lblAtencion2.TabIndex = 83
        Me.lblAtencion2.Text = "F1 para consultar Códigos Postales"
        Me.lblAtencion2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(308, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 36)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Actualización de Matriculados"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(144, 471)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(563, 73)
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(713, 471)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(222, 73)
        Me.PictureBox2.TabIndex = 86
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(941, 471)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(99, 73)
        Me.PictureBox3.TabIndex = 87
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Location = New System.Drawing.Point(5, 214)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1089, 133)
        Me.PictureBox5.TabIndex = 89
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox6.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.MatriculadosBindingSource, "TelFiadorMatri", True))
        Me.PictureBox6.Location = New System.Drawing.Point(5, 356)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(1089, 106)
        Me.PictureBox6.TabIndex = 90
        Me.PictureBox6.TabStop = False
        '
        'MatriculadosTableAdapter
        '
        Me.MatriculadosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.debehaberTableAdapter = Nothing
        Me.TableAdapterManager.debitomatriTableAdapter = Nothing
        Me.TableAdapterManager.debitosocTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotebancoTableAdapter = Nothing
        Me.TableAdapterManager.matriculadosTableAdapter = Me.MatriculadosTableAdapter
        Me.TableAdapterManager.nivelesTableAdapter = Nothing
        Me.TableAdapterManager.saldomatTableAdapter = Nothing
        Me.TableAdapterManager.saldosocTableAdapter = Nothing
        Me.TableAdapterManager.sociedadesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'MatriculadosBindingNavigator
        '
        Me.MatriculadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MatriculadosBindingNavigator.BindingSource = Me.MatriculadosBindingSource
        Me.MatriculadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MatriculadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MatriculadosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MatriculadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MatriculadosBindingNavigatorSaveItem})
        Me.MatriculadosBindingNavigator.Location = New System.Drawing.Point(0, 564)
        Me.MatriculadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MatriculadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MatriculadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MatriculadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MatriculadosBindingNavigator.Name = "MatriculadosBindingNavigator"
        Me.MatriculadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MatriculadosBindingNavigator.Size = New System.Drawing.Size(1212, 25)
        Me.MatriculadosBindingNavigator.TabIndex = 91
        Me.MatriculadosBindingNavigator.Text = "BindingNavigator1"
        Me.MatriculadosBindingNavigator.Visible = False
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
        'MatriculadosBindingNavigatorSaveItem
        '
        Me.MatriculadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MatriculadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("MatriculadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MatriculadosBindingNavigatorSaveItem.Name = "MatriculadosBindingNavigatorSaveItem"
        Me.MatriculadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MatriculadosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(5, 48)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1089, 157)
        Me.PictureBox4.TabIndex = 143
        Me.PictureBox4.TabStop = False
        '
        'txtFecNacMatri
        '
        Me.txtFecNacMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecNacMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecNacMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FecNacMatri", True))
        Me.txtFecNacMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecNacMatri.ForeColor = System.Drawing.Color.White
        Me.txtFecNacMatri.Location = New System.Drawing.Point(144, 85)
        Me.txtFecNacMatri.MaxLength = 10
        Me.txtFecNacMatri.Name = "txtFecNacMatri"
        Me.txtFecNacMatri.Size = New System.Drawing.Size(100, 23)
        Me.txtFecNacMatri.TabIndex = 3
        '
        'txtFecJurMatri
        '
        Me.txtFecJurMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecJurMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecJurMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FecJurMatri", True))
        Me.txtFecJurMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecJurMatri.ForeColor = System.Drawing.Color.White
        Me.txtFecJurMatri.Location = New System.Drawing.Point(144, 145)
        Me.txtFecJurMatri.MaxLength = 10
        Me.txtFecJurMatri.Name = "txtFecJurMatri"
        Me.txtFecJurMatri.Size = New System.Drawing.Size(100, 23)
        Me.txtFecJurMatri.TabIndex = 11
        '
        'txtFecEstadoMatri
        '
        Me.txtFecEstadoMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecEstadoMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecEstadoMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FecEstadoMatri", True))
        Me.txtFecEstadoMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecEstadoMatri.ForeColor = System.Drawing.Color.White
        Me.txtFecEstadoMatri.Location = New System.Drawing.Point(894, 143)
        Me.txtFecEstadoMatri.MaxLength = 10
        Me.txtFecEstadoMatri.Name = "txtFecEstadoMatri"
        Me.txtFecEstadoMatri.Size = New System.Drawing.Size(100, 23)
        Me.txtFecEstadoMatri.TabIndex = 14
        '
        'txtFianzaMatri
        '
        Me.txtFianzaMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFianzaMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFianzaMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FianzaMatri", True))
        Me.txtFianzaMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFianzaMatri.ForeColor = System.Drawing.Color.White
        Me.txtFianzaMatri.Location = New System.Drawing.Point(144, 369)
        Me.txtFianzaMatri.MaxLength = 10
        Me.txtFianzaMatri.Name = "txtFianzaMatri"
        Me.txtFianzaMatri.Size = New System.Drawing.Size(100, 23)
        Me.txtFianzaMatri.TabIndex = 28
        '
        'txtFiadorMatri
        '
        Me.txtFiadorMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFiadorMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiadorMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiadorMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FiadorMatri", True))
        Me.txtFiadorMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiadorMatri.ForeColor = System.Drawing.Color.White
        Me.txtFiadorMatri.Location = New System.Drawing.Point(391, 369)
        Me.txtFiadorMatri.MaxLength = 30
        Me.txtFiadorMatri.Name = "txtFiadorMatri"
        Me.txtFiadorMatri.Size = New System.Drawing.Size(393, 23)
        Me.txtFiadorMatri.TabIndex = 29
        '
        'txtTelFiadorMatri
        '
        Me.txtTelFiadorMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTelFiadorMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelFiadorMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "TelFiadorMatri", True))
        Me.txtTelFiadorMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelFiadorMatri.Location = New System.Drawing.Point(897, 398)
        Me.txtTelFiadorMatri.MaxLength = 15
        Me.txtTelFiadorMatri.Name = "txtTelFiadorMatri"
        Me.txtTelFiadorMatri.Size = New System.Drawing.Size(185, 23)
        Me.txtTelFiadorMatri.TabIndex = 32
        '
        'frmMatriculados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1104, 574)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtTelFiadorMatri)
        Me.Controls.Add(Me.txtFiadorMatri)
        Me.Controls.Add(Me.txtFianzaMatri)
        Me.Controls.Add(Me.txtFecEstadoMatri)
        Me.Controls.Add(Me.txtFecJurMatri)
        Me.Controls.Add(Me.txtFecNacMatri)
        Me.Controls.Add(Me.MatriculadosBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAtencion2)
        Me.Controls.Add(Me.lblAtencion1)
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
        Me.Controls.Add(Me.txtNroMatri)
        Me.Controls.Add(Me.cmbEstadoMatri)
        Me.Controls.Add(Me.cmbCatAporteMatri)
        Me.Controls.Add(Me.cmbEstCivilMatri)
        Me.Controls.Add(Me.cmbSexoMatri)
        Me.Controls.Add(Me.cmbTipoDocMatri)
        Me.Controls.Add(Me.txtProvLegal)
        Me.Controls.Add(Me.txtLocalLegal)
        Me.Controls.Add(Me.txtProvReal)
        Me.Controls.Add(Me.txtLocalReal)
        Me.Controls.Add(Id_MatriLabel)
        Me.Controls.Add(Me.txtId_Matri)
        Me.Controls.Add(ApelMatriLabel)
        Me.Controls.Add(Me.txtApelNombMatri)
        Me.Controls.Add(ApelMatMatriLabel)
        Me.Controls.Add(Me.txtApelMatMatri)
        Me.Controls.Add(FecNacMatriLabel)
        Me.Controls.Add(LugarNacMatriLabel)
        Me.Controls.Add(Me.txtLugarNacMatri)
        Me.Controls.Add(NacionNacMatriLabel)
        Me.Controls.Add(Me.txtNacionNacMatri)
        Me.Controls.Add(TipoDocMatriLabel)
        Me.Controls.Add(NroDocMatriLabel)
        Me.Controls.Add(Me.txtNroDocMatri)
        Me.Controls.Add(SexoMatriLabel)
        Me.Controls.Add(EstCivilMatriLabel)
        Me.Controls.Add(CuitMatriLabel)
        Me.Controls.Add(Me.txtCuitMatri)
        Me.Controls.Add(FecJurMatriLabel)
        Me.Controls.Add(CatAporteMatriLabel)
        Me.Controls.Add(EstadoMatriLabel)
        Me.Controls.Add(FecEstadoMatriLabel)
        Me.Controls.Add(CalleRealMatriLabel)
        Me.Controls.Add(Me.txtCalleRealMatri)
        Me.Controls.Add(CPRealMatriLabel)
        Me.Controls.Add(Me.txtCPRealMatri)
        Me.Controls.Add(EmailMatriLabel)
        Me.Controls.Add(Me.txtEmailMatri)
        Me.Controls.Add(CeluRealMatriLabel)
        Me.Controls.Add(Me.txtCeluRealMatri)
        Me.Controls.Add(FijoRealMatriLabel)
        Me.Controls.Add(Me.txtFijoRealMatri)
        Me.Controls.Add(CalleLegalMatriLabel)
        Me.Controls.Add(Me.txtCalleLegalMatri)
        Me.Controls.Add(CPLegalMatriLabel)
        Me.Controls.Add(Me.txtCPLegalMatri)
        Me.Controls.Add(CeluLegalMatriLabel)
        Me.Controls.Add(Me.txtCeluLegalMatri)
        Me.Controls.Add(FijoLegalMatriLabel)
        Me.Controls.Add(Me.txtFijoLegalMatri)
        Me.Controls.Add(FianzaMatriLabel)
        Me.Controls.Add(FiadorMatriLabel)
        Me.Controls.Add(DocFiadorMatriLabel)
        Me.Controls.Add(Me.txtDocFiadorMatri)
        Me.Controls.Add(CalleFiadorMatriLabel)
        Me.Controls.Add(Me.txtCalleFiadorMatri)
        Me.Controls.Add(ObsMatriLabel)
        Me.Controls.Add(Me.txtObsMatri)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMatriculados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZACIÓN DE MATRICULADOS"
        CType(Me.MatriculadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatriculadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MatriculadosBindingNavigator.ResumeLayout(False)
        Me.MatriculadosBindingNavigator.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtId_Matri As TextBox
    Friend WithEvents txtApelNombMatri As TextBox
    Friend WithEvents txtApelMatMatri As TextBox
    Friend WithEvents txtLugarNacMatri As TextBox
    Friend WithEvents txtNacionNacMatri As TextBox
    Friend WithEvents txtNroDocMatri As TextBox
    Friend WithEvents txtCuitMatri As TextBox
    Friend WithEvents txtCalleRealMatri As TextBox
    Friend WithEvents txtCPRealMatri As TextBox
    Friend WithEvents txtEmailMatri As TextBox
    Friend WithEvents txtCeluRealMatri As TextBox
    Friend WithEvents txtFijoRealMatri As TextBox
    Friend WithEvents txtCalleLegalMatri As TextBox
    Friend WithEvents txtCPLegalMatri As TextBox
    Friend WithEvents txtCeluLegalMatri As TextBox
    Friend WithEvents txtFijoLegalMatri As TextBox
    Friend WithEvents txtDocFiadorMatri As TextBox
    Friend WithEvents txtCalleFiadorMatri As TextBox
    Friend WithEvents txtObsMatri As TextBox
    Friend WithEvents txtLocalReal As TextBox
    Friend WithEvents txtProvReal As TextBox
    Friend WithEvents txtLocalLegal As TextBox
    Friend WithEvents txtProvLegal As TextBox
    Friend WithEvents cmbSexoMatri As ComboBox
    Friend WithEvents cmbEstCivilMatri As ComboBox
    Friend WithEvents cmbCatAporteMatri As ComboBox
    Friend WithEvents cmbEstadoMatri As ComboBox
    Friend WithEvents txtNroMatri As TextBox
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
    Friend WithEvents lblAtencion1 As Label
    Friend WithEvents lblAtencion2 As Label
    Public WithEvents cmbTipoDocMatri As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents MatriculadosBindingSource As BindingSource
    Friend WithEvents MatriculadosTableAdapter As dbcolmartDataSetTableAdapters.matriculadosTableAdapter
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MatriculadosBindingNavigator As BindingNavigator
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
    Friend WithEvents MatriculadosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtFecNacMatri As TextBox
    Friend WithEvents txtFecJurMatri As TextBox
    Friend WithEvents txtFecEstadoMatri As TextBox
    Friend WithEvents txtFianzaMatri As TextBox
    Friend WithEvents txtFiadorMatri As TextBox
    Friend WithEvents txtTelFiadorMatri As TextBox
End Class

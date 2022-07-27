<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSociedades
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
        Dim NroSociedadLabel As System.Windows.Forms.Label
        Dim NombSociedadLabel As System.Windows.Forms.Label
        Dim CalleSociedadLabel As System.Windows.Forms.Label
        Dim CodPosSociedadLabel As System.Windows.Forms.Label
        Dim LocalSociedadLabel As System.Windows.Forms.Label
        Dim DptoSociedadLabel As System.Windows.Forms.Label
        Dim ProvSociedadLabel As System.Windows.Forms.Label
        Dim TelSociedadLabel As System.Windows.Forms.Label
        Dim EmailSociedadLabel As System.Windows.Forms.Label
        Dim EstadoSociedadLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSociedades))
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.SociedadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SociedadesTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.sociedadesTableAdapter()
        Me.TableAdapterManager = New ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager()
        Me.SociedadesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SociedadesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtId_Soc = New System.Windows.Forms.TextBox()
        Me.txtNroSociedad = New System.Windows.Forms.TextBox()
        Me.txtNombSociedad = New System.Windows.Forms.TextBox()
        Me.txtCalleSociedad = New System.Windows.Forms.TextBox()
        Me.txtCodPosSociedad = New System.Windows.Forms.TextBox()
        Me.txtLocalSociedad = New System.Windows.Forms.TextBox()
        Me.txtDptoSociedad = New System.Windows.Forms.TextBox()
        Me.txtProvSociedad = New System.Windows.Forms.TextBox()
        Me.txtTelSociedad = New System.Windows.Forms.TextBox()
        Me.txtEmailSociedad = New System.Windows.Forms.TextBox()
        Me.cmbClaseSoc = New System.Windows.Forms.ComboBox()
        Me.txtMartilleroSoc = New System.Windows.Forms.TextBox()
        Me.cmbEstadoSociedad = New System.Windows.Forms.ComboBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        NroSociedadLabel = New System.Windows.Forms.Label()
        NombSociedadLabel = New System.Windows.Forms.Label()
        CalleSociedadLabel = New System.Windows.Forms.Label()
        CodPosSociedadLabel = New System.Windows.Forms.Label()
        LocalSociedadLabel = New System.Windows.Forms.Label()
        DptoSociedadLabel = New System.Windows.Forms.Label()
        ProvSociedadLabel = New System.Windows.Forms.Label()
        TelSociedadLabel = New System.Windows.Forms.Label()
        EmailSociedadLabel = New System.Windows.Forms.Label()
        EstadoSociedadLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociedadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociedadesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SociedadesBindingNavigator.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NroSociedadLabel
        '
        NroSociedadLabel.AutoSize = True
        NroSociedadLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NroSociedadLabel.ForeColor = System.Drawing.Color.White
        NroSociedadLabel.Location = New System.Drawing.Point(34, 83)
        NroSociedadLabel.Name = "NroSociedadLabel"
        NroSociedadLabel.Size = New System.Drawing.Size(104, 17)
        NroSociedadLabel.TabIndex = 1
        NroSociedadLabel.Text = "Nro. Sociedad:"
        '
        'NombSociedadLabel
        '
        NombSociedadLabel.AutoSize = True
        NombSociedadLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombSociedadLabel.ForeColor = System.Drawing.Color.White
        NombSociedadLabel.Location = New System.Drawing.Point(234, 83)
        NombSociedadLabel.Name = "NombSociedadLabel"
        NombSociedadLabel.Size = New System.Drawing.Size(65, 17)
        NombSociedadLabel.TabIndex = 3
        NombSociedadLabel.Text = "Nombre:"
        '
        'CalleSociedadLabel
        '
        CalleSociedadLabel.AutoSize = True
        CalleSociedadLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CalleSociedadLabel.ForeColor = System.Drawing.Color.White
        CalleSociedadLabel.Location = New System.Drawing.Point(65, 112)
        CalleSociedadLabel.Name = "CalleSociedadLabel"
        CalleSociedadLabel.Size = New System.Drawing.Size(73, 17)
        CalleSociedadLabel.TabIndex = 5
        CalleSociedadLabel.Text = "Domicilio:"
        '
        'CodPosSociedadLabel
        '
        CodPosSociedadLabel.AutoSize = True
        CodPosSociedadLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodPosSociedadLabel.ForeColor = System.Drawing.Color.White
        CodPosSociedadLabel.Location = New System.Drawing.Point(50, 141)
        CodPosSociedadLabel.Name = "CodPosSociedadLabel"
        CodPosSociedadLabel.Size = New System.Drawing.Size(88, 17)
        CodPosSociedadLabel.TabIndex = 7
        CodPosSociedadLabel.Text = "Cod. Postal:"
        '
        'LocalSociedadLabel
        '
        LocalSociedadLabel.AutoSize = True
        LocalSociedadLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocalSociedadLabel.ForeColor = System.Drawing.Color.White
        LocalSociedadLabel.Location = New System.Drawing.Point(222, 141)
        LocalSociedadLabel.Name = "LocalSociedadLabel"
        LocalSociedadLabel.Size = New System.Drawing.Size(77, 17)
        LocalSociedadLabel.TabIndex = 9
        LocalSociedadLabel.Text = "Localidad:"
        '
        'DptoSociedadLabel
        '
        DptoSociedadLabel.AutoSize = True
        DptoSociedadLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DptoSociedadLabel.ForeColor = System.Drawing.Color.White
        DptoSociedadLabel.Location = New System.Drawing.Point(190, 170)
        DptoSociedadLabel.Name = "DptoSociedadLabel"
        DptoSociedadLabel.Size = New System.Drawing.Size(109, 17)
        DptoSociedadLabel.TabIndex = 11
        DptoSociedadLabel.Text = "Departamento:"
        '
        'ProvSociedadLabel
        '
        ProvSociedadLabel.AutoSize = True
        ProvSociedadLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProvSociedadLabel.ForeColor = System.Drawing.Color.White
        ProvSociedadLabel.Location = New System.Drawing.Point(227, 198)
        ProvSociedadLabel.Name = "ProvSociedadLabel"
        ProvSociedadLabel.Size = New System.Drawing.Size(72, 17)
        ProvSociedadLabel.TabIndex = 13
        ProvSociedadLabel.Text = "Provincia:"
        '
        'TelSociedadLabel
        '
        TelSociedadLabel.AutoSize = True
        TelSociedadLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelSociedadLabel.ForeColor = System.Drawing.Color.White
        TelSociedadLabel.Location = New System.Drawing.Point(72, 227)
        TelSociedadLabel.Name = "TelSociedadLabel"
        TelSociedadLabel.Size = New System.Drawing.Size(66, 17)
        TelSociedadLabel.TabIndex = 15
        TelSociedadLabel.Text = "Teléfono:"
        '
        'EmailSociedadLabel
        '
        EmailSociedadLabel.AutoSize = True
        EmailSociedadLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailSociedadLabel.ForeColor = System.Drawing.Color.White
        EmailSociedadLabel.Location = New System.Drawing.Point(378, 227)
        EmailSociedadLabel.Name = "EmailSociedadLabel"
        EmailSociedadLabel.Size = New System.Drawing.Size(51, 17)
        EmailSociedadLabel.TabIndex = 17
        EmailSociedadLabel.Text = "E-mail:"
        '
        'EstadoSociedadLabel
        '
        EstadoSociedadLabel.AutoSize = True
        EstadoSociedadLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoSociedadLabel.ForeColor = System.Drawing.Color.White
        EstadoSociedadLabel.Location = New System.Drawing.Point(82, 288)
        EstadoSociedadLabel.Name = "EstadoSociedadLabel"
        EstadoSociedadLabel.Size = New System.Drawing.Size(56, 17)
        EstadoSociedadLabel.TabIndex = 19
        EstadoSociedadLabel.Text = "Estado:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(90, 257)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(48, 17)
        Label2.TabIndex = 108
        Label2.Text = "Clase:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(358, 255)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(71, 17)
        Label3.TabIndex = 109
        Label3.Text = "Martillero:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(219, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 36)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Actualización de Sociedades"
        '
        'BtnUltimo
        '
        Me.BtnUltimo.AutoSize = True
        Me.BtnUltimo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUltimo.FlatAppearance.BorderSize = 0
        Me.BtnUltimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUltimo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUltimo.ForeColor = System.Drawing.Color.White
        Me.BtnUltimo.Image = CType(resources.GetObject("BtnUltimo.Image"), System.Drawing.Image)
        Me.BtnUltimo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnUltimo.Location = New System.Drawing.Point(741, 349)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnUltimo.Size = New System.Drawing.Size(38, 38)
        Me.BtnUltimo.TabIndex = 97
        Me.BtnUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUltimo.UseVisualStyleBackColor = True
        '
        'BtnPrimer
        '
        Me.BtnPrimer.AutoSize = True
        Me.BtnPrimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrimer.FlatAppearance.BorderSize = 0
        Me.BtnPrimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnPrimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrimer.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrimer.ForeColor = System.Drawing.Color.White
        Me.BtnPrimer.Image = CType(resources.GetObject("BtnPrimer.Image"), System.Drawing.Image)
        Me.BtnPrimer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPrimer.Location = New System.Drawing.Point(606, 349)
        Me.BtnPrimer.Name = "BtnPrimer"
        Me.BtnPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPrimer.Size = New System.Drawing.Size(38, 38)
        Me.BtnPrimer.TabIndex = 94
        Me.BtnPrimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPrimer.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.AutoSize = True
        Me.BtnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSiguiente.FlatAppearance.BorderSize = 0
        Me.BtnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSiguiente.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.ForeColor = System.Drawing.Color.White
        Me.BtnSiguiente.Image = CType(resources.GetObject("BtnSiguiente.Image"), System.Drawing.Image)
        Me.BtnSiguiente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSiguiente.Location = New System.Drawing.Point(696, 349)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSiguiente.Size = New System.Drawing.Size(38, 38)
        Me.BtnSiguiente.TabIndex = 96
        Me.BtnSiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.AutoSize = True
        Me.BtnAnterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnterior.FlatAppearance.BorderSize = 0
        Me.BtnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnterior.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnterior.ForeColor = System.Drawing.Color.White
        Me.BtnAnterior.Image = CType(resources.GetObject("BtnAnterior.Image"), System.Drawing.Image)
        Me.BtnAnterior.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAnterior.Location = New System.Drawing.Point(651, 349)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAnterior.Size = New System.Drawing.Size(38, 38)
        Me.BtnAnterior.TabIndex = 95
        Me.BtnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.AutoSize = True
        Me.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActualizar.FlatAppearance.BorderSize = 0
        Me.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(466, 341)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnActualizar.Size = New System.Drawing.Size(87, 56)
        Me.BtnActualizar.TabIndex = 93
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActualizar.UseVisualStyleBackColor = True
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
        Me.BtnGrabar.Location = New System.Drawing.Point(115, 341)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGrabar.Size = New System.Drawing.Size(59, 56)
        Me.BtnGrabar.TabIndex = 92
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGrabar.UseVisualStyleBackColor = True
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
        Me.BtnSalir.Location = New System.Drawing.Point(817, 341)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(87, 56)
        Me.BtnSalir.TabIndex = 98
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
        Me.BtnModificar.Location = New System.Drawing.Point(198, 341)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnModificar.Size = New System.Drawing.Size(80, 56)
        Me.BtnModificar.TabIndex = 91
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnModificar.UseVisualStyleBackColor = True
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
        Me.BtnEliminar.Location = New System.Drawing.Point(294, 341)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEliminar.Size = New System.Drawing.Size(73, 56)
        Me.BtnEliminar.TabIndex = 90
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.AutoSize = True
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(386, 341)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnBuscar.Size = New System.Drawing.Size(59, 56)
        Me.BtnBuscar.TabIndex = 89
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
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
        Me.BtnAgregar.Location = New System.Drawing.Point(32, 341)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAgregar.Size = New System.Drawing.Size(66, 56)
        Me.BtnAgregar.TabIndex = 88
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(14, 333)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(563, 73)
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(583, 333)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(222, 73)
        Me.PictureBox2.TabIndex = 100
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(811, 333)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(99, 73)
        Me.PictureBox3.TabIndex = 101
        Me.PictureBox3.TabStop = False
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SociedadesBindingSource
        '
        Me.SociedadesBindingSource.DataMember = "sociedades"
        Me.SociedadesBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'SociedadesTableAdapter
        '
        Me.SociedadesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bibliotecaTableAdapter = Nothing
        Me.TableAdapterManager.boletasTableAdapter = Nothing
        Me.TableAdapterManager.cajamayorTableAdapter = Nothing
        Me.TableAdapterManager.cajaTableAdapter = Nothing
        Me.TableAdapterManager.coddebitoTableAdapter = Nothing
        Me.TableAdapterManager.codpostalTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.comprobteTableAdapter = Nothing
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
        Me.TableAdapterManager.sociedadesTableAdapter = Me.SociedadesTableAdapter
        Me.TableAdapterManager.tribunalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'SociedadesBindingNavigator
        '
        Me.SociedadesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SociedadesBindingNavigator.BindingSource = Me.SociedadesBindingSource
        Me.SociedadesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SociedadesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SociedadesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SociedadesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.SociedadesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SociedadesBindingNavigatorSaveItem})
        Me.SociedadesBindingNavigator.Location = New System.Drawing.Point(0, 451)
        Me.SociedadesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SociedadesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SociedadesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SociedadesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SociedadesBindingNavigator.Name = "SociedadesBindingNavigator"
        Me.SociedadesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SociedadesBindingNavigator.Size = New System.Drawing.Size(1068, 25)
        Me.SociedadesBindingNavigator.TabIndex = 110
        Me.SociedadesBindingNavigator.Text = "BindingNavigator1"
        Me.SociedadesBindingNavigator.Visible = False
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
        'SociedadesBindingNavigatorSaveItem
        '
        Me.SociedadesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SociedadesBindingNavigatorSaveItem.Image = CType(resources.GetObject("SociedadesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SociedadesBindingNavigatorSaveItem.Name = "SociedadesBindingNavigatorSaveItem"
        Me.SociedadesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SociedadesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'txtId_Soc
        '
        Me.txtId_Soc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_Soc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_Soc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociedadesBindingSource, "id_Soc", True))
        Me.txtId_Soc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_Soc.ForeColor = System.Drawing.Color.White
        Me.txtId_Soc.Location = New System.Drawing.Point(791, 83)
        Me.txtId_Soc.Name = "txtId_Soc"
        Me.txtId_Soc.Size = New System.Drawing.Size(64, 16)
        Me.txtId_Soc.TabIndex = 111
        '
        'txtNroSociedad
        '
        Me.txtNroSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroSociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroSociedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociedadesBindingSource, "NroSociedad", True))
        Me.txtNroSociedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroSociedad.ForeColor = System.Drawing.Color.White
        Me.txtNroSociedad.Location = New System.Drawing.Point(144, 81)
        Me.txtNroSociedad.MaxLength = 5
        Me.txtNroSociedad.Name = "txtNroSociedad"
        Me.txtNroSociedad.Size = New System.Drawing.Size(83, 23)
        Me.txtNroSociedad.TabIndex = 113
        '
        'txtNombSociedad
        '
        Me.txtNombSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombSociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombSociedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociedadesBindingSource, "NombSociedad", True))
        Me.txtNombSociedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombSociedad.ForeColor = System.Drawing.Color.White
        Me.txtNombSociedad.Location = New System.Drawing.Point(305, 81)
        Me.txtNombSociedad.MaxLength = 50
        Me.txtNombSociedad.Name = "txtNombSociedad"
        Me.txtNombSociedad.Size = New System.Drawing.Size(480, 23)
        Me.txtNombSociedad.TabIndex = 115
        '
        'txtCalleSociedad
        '
        Me.txtCalleSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCalleSociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalleSociedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociedadesBindingSource, "CalleSociedad", True))
        Me.txtCalleSociedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalleSociedad.ForeColor = System.Drawing.Color.White
        Me.txtCalleSociedad.Location = New System.Drawing.Point(144, 110)
        Me.txtCalleSociedad.MaxLength = 30
        Me.txtCalleSociedad.Name = "txtCalleSociedad"
        Me.txtCalleSociedad.Size = New System.Drawing.Size(641, 23)
        Me.txtCalleSociedad.TabIndex = 117
        '
        'txtCodPosSociedad
        '
        Me.txtCodPosSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCodPosSociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPosSociedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociedadesBindingSource, "CodPosSociedad", True))
        Me.txtCodPosSociedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPosSociedad.ForeColor = System.Drawing.Color.White
        Me.txtCodPosSociedad.Location = New System.Drawing.Point(144, 139)
        Me.txtCodPosSociedad.MaxLength = 5
        Me.txtCodPosSociedad.Name = "txtCodPosSociedad"
        Me.txtCodPosSociedad.Size = New System.Drawing.Size(72, 23)
        Me.txtCodPosSociedad.TabIndex = 119
        '
        'txtLocalSociedad
        '
        Me.txtLocalSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtLocalSociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalSociedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociedadesBindingSource, "LocalSociedad", True))
        Me.txtLocalSociedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalSociedad.ForeColor = System.Drawing.Color.White
        Me.txtLocalSociedad.Location = New System.Drawing.Point(305, 139)
        Me.txtLocalSociedad.MaxLength = 30
        Me.txtLocalSociedad.Name = "txtLocalSociedad"
        Me.txtLocalSociedad.Size = New System.Drawing.Size(480, 23)
        Me.txtLocalSociedad.TabIndex = 121
        '
        'txtDptoSociedad
        '
        Me.txtDptoSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDptoSociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDptoSociedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociedadesBindingSource, "DptoSociedad", True))
        Me.txtDptoSociedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDptoSociedad.ForeColor = System.Drawing.Color.White
        Me.txtDptoSociedad.Location = New System.Drawing.Point(305, 168)
        Me.txtDptoSociedad.MaxLength = 30
        Me.txtDptoSociedad.Name = "txtDptoSociedad"
        Me.txtDptoSociedad.Size = New System.Drawing.Size(480, 23)
        Me.txtDptoSociedad.TabIndex = 123
        '
        'txtProvSociedad
        '
        Me.txtProvSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtProvSociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvSociedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociedadesBindingSource, "ProvSociedad", True))
        Me.txtProvSociedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvSociedad.ForeColor = System.Drawing.Color.White
        Me.txtProvSociedad.Location = New System.Drawing.Point(305, 196)
        Me.txtProvSociedad.MaxLength = 30
        Me.txtProvSociedad.Name = "txtProvSociedad"
        Me.txtProvSociedad.Size = New System.Drawing.Size(480, 23)
        Me.txtProvSociedad.TabIndex = 125
        '
        'txtTelSociedad
        '
        Me.txtTelSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTelSociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelSociedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociedadesBindingSource, "TelSociedad", True))
        Me.txtTelSociedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelSociedad.ForeColor = System.Drawing.Color.White
        Me.txtTelSociedad.Location = New System.Drawing.Point(144, 225)
        Me.txtTelSociedad.MaxLength = 20
        Me.txtTelSociedad.Name = "txtTelSociedad"
        Me.txtTelSociedad.Size = New System.Drawing.Size(228, 23)
        Me.txtTelSociedad.TabIndex = 127
        '
        'txtEmailSociedad
        '
        Me.txtEmailSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtEmailSociedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailSociedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociedadesBindingSource, "EmailSociedad", True))
        Me.txtEmailSociedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailSociedad.ForeColor = System.Drawing.Color.White
        Me.txtEmailSociedad.Location = New System.Drawing.Point(435, 225)
        Me.txtEmailSociedad.MaxLength = 60
        Me.txtEmailSociedad.Name = "txtEmailSociedad"
        Me.txtEmailSociedad.Size = New System.Drawing.Size(452, 23)
        Me.txtEmailSociedad.TabIndex = 129
        '
        'cmbClaseSoc
        '
        Me.cmbClaseSoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbClaseSoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociedadesBindingSource, "ClaseSoc", True))
        Me.cmbClaseSoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbClaseSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClaseSoc.ForeColor = System.Drawing.Color.White
        Me.cmbClaseSoc.FormattingEnabled = True
        Me.cmbClaseSoc.Items.AddRange(New Object() {"OTRAS", "FERIAS", "INDUSTRIALES", "HIPICAS"})
        Me.cmbClaseSoc.Location = New System.Drawing.Point(144, 254)
        Me.cmbClaseSoc.Name = "cmbClaseSoc"
        Me.cmbClaseSoc.Size = New System.Drawing.Size(208, 25)
        Me.cmbClaseSoc.TabIndex = 131
        '
        'txtMartilleroSoc
        '
        Me.txtMartilleroSoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMartilleroSoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMartilleroSoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociedadesBindingSource, "MartilleroSoc", True))
        Me.txtMartilleroSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMartilleroSoc.ForeColor = System.Drawing.Color.White
        Me.txtMartilleroSoc.Location = New System.Drawing.Point(435, 255)
        Me.txtMartilleroSoc.MaxLength = 80
        Me.txtMartilleroSoc.Name = "txtMartilleroSoc"
        Me.txtMartilleroSoc.Size = New System.Drawing.Size(452, 23)
        Me.txtMartilleroSoc.TabIndex = 133
        '
        'cmbEstadoSociedad
        '
        Me.cmbEstadoSociedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbEstadoSociedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociedadesBindingSource, "EstadoSociedad", True))
        Me.cmbEstadoSociedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEstadoSociedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstadoSociedad.ForeColor = System.Drawing.Color.White
        Me.cmbEstadoSociedad.FormattingEnabled = True
        Me.cmbEstadoSociedad.Items.AddRange(New Object() {"ACTIVA", "BAJA", "SUSPENDIDA"})
        Me.cmbEstadoSociedad.Location = New System.Drawing.Point(144, 285)
        Me.cmbEstadoSociedad.Name = "cmbEstadoSociedad"
        Me.cmbEstadoSociedad.Size = New System.Drawing.Size(208, 25)
        Me.cmbEstadoSociedad.TabIndex = 135
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(13, 63)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(896, 264)
        Me.PictureBox4.TabIndex = 136
        Me.PictureBox4.TabStop = False
        '
        'frmSociedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1068, 476)
        Me.Controls.Add(Me.txtId_Soc)
        Me.Controls.Add(Me.txtNroSociedad)
        Me.Controls.Add(Me.txtNombSociedad)
        Me.Controls.Add(Me.txtCalleSociedad)
        Me.Controls.Add(Me.txtCodPosSociedad)
        Me.Controls.Add(Me.txtLocalSociedad)
        Me.Controls.Add(Me.txtDptoSociedad)
        Me.Controls.Add(Me.txtProvSociedad)
        Me.Controls.Add(Me.txtTelSociedad)
        Me.Controls.Add(Me.txtEmailSociedad)
        Me.Controls.Add(Me.cmbClaseSoc)
        Me.Controls.Add(Me.txtMartilleroSoc)
        Me.Controls.Add(Me.cmbEstadoSociedad)
        Me.Controls.Add(Me.SociedadesBindingNavigator)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(NroSociedadLabel)
        Me.Controls.Add(NombSociedadLabel)
        Me.Controls.Add(CalleSociedadLabel)
        Me.Controls.Add(CodPosSociedadLabel)
        Me.Controls.Add(LocalSociedadLabel)
        Me.Controls.Add(DptoSociedadLabel)
        Me.Controls.Add(ProvSociedadLabel)
        Me.Controls.Add(TelSociedadLabel)
        Me.Controls.Add(EmailSociedadLabel)
        Me.Controls.Add(EstadoSociedadLabel)
        Me.Controls.Add(Me.PictureBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSociedades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ACTUALIZACIÓN DE SOCIEDADES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociedadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociedadesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SociedadesBindingNavigator.ResumeLayout(False)
        Me.SociedadesBindingNavigator.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents SociedadesBindingSource As BindingSource
    Friend WithEvents SociedadesTableAdapter As dbcolmartDataSetTableAdapters.sociedadesTableAdapter
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SociedadesBindingNavigator As BindingNavigator
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
    Friend WithEvents SociedadesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtId_Soc As TextBox
    Friend WithEvents txtNroSociedad As TextBox
    Friend WithEvents txtNombSociedad As TextBox
    Friend WithEvents txtCalleSociedad As TextBox
    Friend WithEvents txtCodPosSociedad As TextBox
    Friend WithEvents txtLocalSociedad As TextBox
    Friend WithEvents txtDptoSociedad As TextBox
    Friend WithEvents txtProvSociedad As TextBox
    Friend WithEvents txtTelSociedad As TextBox
    Friend WithEvents txtEmailSociedad As TextBox
    Friend WithEvents cmbClaseSoc As ComboBox
    Friend WithEvents txtMartilleroSoc As TextBox
    Friend WithEvents cmbEstadoSociedad As ComboBox
    Friend WithEvents PictureBox4 As PictureBox
End Class

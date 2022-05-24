<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPpal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPpal))
        Me.PanelBotonesMenu = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SubMenuSistema = New System.Windows.Forms.Panel()
        Me.btnPasaje = New System.Windows.Forms.Button()
        Me.btnBackupRestore = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnNiveles = New System.Windows.Forms.Button()
        Me.btnSistema = New System.Windows.Forms.Button()
        Me.SubMenuParametros = New System.Windows.Forms.Panel()
        Me.btnTribunal = New System.Windows.Forms.Button()
        Me.btnCodDebitar = New System.Windows.Forms.Button()
        Me.btnCodPostales = New System.Windows.Forms.Button()
        Me.btnParametros = New System.Windows.Forms.Button()
        Me.SubMenuProveedores = New System.Windows.Forms.Panel()
        Me.btnCajaMayor = New System.Windows.Forms.Button()
        Me.btnSaldoDeudor = New System.Windows.Forms.Button()
        Me.btnCtaCteProv = New System.Windows.Forms.Button()
        Me.btnRecibo = New System.Windows.Forms.Button()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnActualizarProv = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.SubMenuMesa = New System.Windows.Forms.Panel()
        Me.btnListadoMesa = New System.Windows.Forms.Button()
        Me.btnActualizarMesa = New System.Windows.Forms.Button()
        Me.btnMesaEntrada = New System.Windows.Forms.Button()
        Me.SubMenuCaja = New System.Windows.Forms.Panel()
        Me.btnImportarBanco = New System.Windows.Forms.Button()
        Me.btnReciboGral = New System.Windows.Forms.Button()
        Me.btnReciboPago = New System.Windows.Forms.Button()
        Me.btnMovimCaja = New System.Windows.Forms.Button()
        Me.btnCaja = New System.Windows.Forms.Button()
        Me.SubMenuSociedades = New System.Windows.Forms.Panel()
        Me.btnSaldoPagoSoc = New System.Windows.Forms.Button()
        Me.btnListaPadronSoc = New System.Windows.Forms.Button()
        Me.btnCtasCtesSoc = New System.Windows.Forms.Button()
        Me.btnLiquidarSoc = New System.Windows.Forms.Button()
        Me.btnDebitosSoc = New System.Windows.Forms.Button()
        Me.btnActualizarSoc = New System.Windows.Forms.Button()
        Me.btnSociedades = New System.Windows.Forms.Button()
        Me.SubMenuMatriculados = New System.Windows.Forms.Panel()
        Me.btnListaOficio = New System.Windows.Forms.Button()
        Me.btnSaldoPago = New System.Windows.Forms.Button()
        Me.btnListadosMat = New System.Windows.Forms.Button()
        Me.btnMailMat = New System.Windows.Forms.Button()
        Me.btnCtasCtesMat = New System.Windows.Forms.Button()
        Me.btnLiquidarMat = New System.Windows.Forms.Button()
        Me.btnDebitosMat = New System.Windows.Forms.Button()
        Me.btnActualizarMat = New System.Windows.Forms.Button()
        Me.btnMatriculados = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelBotonesMenu.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.SubMenuSistema.SuspendLayout()
        Me.SubMenuParametros.SuspendLayout()
        Me.SubMenuProveedores.SuspendLayout()
        Me.SubMenuMesa.SuspendLayout()
        Me.SubMenuCaja.SuspendLayout()
        Me.SubMenuSociedades.SuspendLayout()
        Me.SubMenuMatriculados.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBotonesMenu
        '
        Me.PanelBotonesMenu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PanelBotonesMenu.Controls.Add(Me.PanelFormularios)
        Me.PanelBotonesMenu.Controls.Add(Me.PanelMenu)
        Me.PanelBotonesMenu.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelBotonesMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotonesMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelBotonesMenu.Name = "PanelBotonesMenu"
        Me.PanelBotonesMenu.Size = New System.Drawing.Size(1430, 750)
        Me.PanelBotonesMenu.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelFormularios.Controls.Add(Me.PictureBox2)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(250, 40)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1180, 710)
        Me.PanelFormularios.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(394, 102)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(349, 518)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.Black
        Me.PanelMenu.Controls.Add(Me.btnSalir)
        Me.PanelMenu.Controls.Add(Me.SubMenuSistema)
        Me.PanelMenu.Controls.Add(Me.btnSistema)
        Me.PanelMenu.Controls.Add(Me.SubMenuParametros)
        Me.PanelMenu.Controls.Add(Me.btnParametros)
        Me.PanelMenu.Controls.Add(Me.SubMenuProveedores)
        Me.PanelMenu.Controls.Add(Me.btnProveedores)
        Me.PanelMenu.Controls.Add(Me.SubMenuMesa)
        Me.PanelMenu.Controls.Add(Me.btnMesaEntrada)
        Me.PanelMenu.Controls.Add(Me.SubMenuCaja)
        Me.PanelMenu.Controls.Add(Me.btnCaja)
        Me.PanelMenu.Controls.Add(Me.SubMenuSociedades)
        Me.PanelMenu.Controls.Add(Me.btnSociedades)
        Me.PanelMenu.Controls.Add(Me.SubMenuMatriculados)
        Me.PanelMenu.Controls.Add(Me.btnMatriculados)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 710)
        Me.PanelMenu.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(0, 1297)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnSalir.Size = New System.Drawing.Size(233, 50)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir del Sistema"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'SubMenuSistema
        '
        Me.SubMenuSistema.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuSistema.Controls.Add(Me.btnPasaje)
        Me.SubMenuSistema.Controls.Add(Me.btnBackupRestore)
        Me.SubMenuSistema.Controls.Add(Me.btnUsuarios)
        Me.SubMenuSistema.Controls.Add(Me.btnNiveles)
        Me.SubMenuSistema.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuSistema.Location = New System.Drawing.Point(0, 1187)
        Me.SubMenuSistema.Name = "SubMenuSistema"
        Me.SubMenuSistema.Size = New System.Drawing.Size(233, 110)
        Me.SubMenuSistema.TabIndex = 24
        '
        'btnPasaje
        '
        Me.btnPasaje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPasaje.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPasaje.FlatAppearance.BorderSize = 0
        Me.btnPasaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPasaje.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasaje.ForeColor = System.Drawing.Color.Red
        Me.btnPasaje.Location = New System.Drawing.Point(0, 75)
        Me.btnPasaje.Name = "btnPasaje"
        Me.btnPasaje.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnPasaje.Size = New System.Drawing.Size(233, 25)
        Me.btnPasaje.TabIndex = 10
        Me.btnPasaje.Text = "PASAJE"
        Me.btnPasaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPasaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPasaje.UseVisualStyleBackColor = True
        '
        'btnBackupRestore
        '
        Me.btnBackupRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackupRestore.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBackupRestore.FlatAppearance.BorderSize = 0
        Me.btnBackupRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackupRestore.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackupRestore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBackupRestore.Location = New System.Drawing.Point(0, 50)
        Me.btnBackupRestore.Name = "btnBackupRestore"
        Me.btnBackupRestore.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnBackupRestore.Size = New System.Drawing.Size(233, 25)
        Me.btnBackupRestore.TabIndex = 9
        Me.btnBackupRestore.Text = "Backup y Restore"
        Me.btnBackupRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackupRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBackupRestore.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 25)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnUsuarios.Size = New System.Drawing.Size(233, 25)
        Me.btnUsuarios.TabIndex = 8
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnNiveles
        '
        Me.btnNiveles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNiveles.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNiveles.FlatAppearance.BorderSize = 0
        Me.btnNiveles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNiveles.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNiveles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNiveles.Location = New System.Drawing.Point(0, 0)
        Me.btnNiveles.Name = "btnNiveles"
        Me.btnNiveles.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnNiveles.Size = New System.Drawing.Size(233, 25)
        Me.btnNiveles.TabIndex = 2
        Me.btnNiveles.Text = "Niveles"
        Me.btnNiveles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNiveles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNiveles.UseVisualStyleBackColor = True
        '
        'btnSistema
        '
        Me.btnSistema.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSistema.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSistema.FlatAppearance.BorderSize = 0
        Me.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSistema.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSistema.ForeColor = System.Drawing.Color.White
        Me.btnSistema.Image = CType(resources.GetObject("btnSistema.Image"), System.Drawing.Image)
        Me.btnSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSistema.Location = New System.Drawing.Point(0, 1137)
        Me.btnSistema.Name = "btnSistema"
        Me.btnSistema.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnSistema.Size = New System.Drawing.Size(233, 50)
        Me.btnSistema.TabIndex = 23
        Me.btnSistema.Text = "Sistema"
        Me.btnSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSistema.UseVisualStyleBackColor = True
        '
        'SubMenuParametros
        '
        Me.SubMenuParametros.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuParametros.Controls.Add(Me.btnTribunal)
        Me.SubMenuParametros.Controls.Add(Me.btnCodDebitar)
        Me.SubMenuParametros.Controls.Add(Me.btnCodPostales)
        Me.SubMenuParametros.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuParametros.Location = New System.Drawing.Point(0, 1054)
        Me.SubMenuParametros.Name = "SubMenuParametros"
        Me.SubMenuParametros.Size = New System.Drawing.Size(233, 83)
        Me.SubMenuParametros.TabIndex = 22
        '
        'btnTribunal
        '
        Me.btnTribunal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTribunal.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTribunal.FlatAppearance.BorderSize = 0
        Me.btnTribunal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTribunal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTribunal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTribunal.Location = New System.Drawing.Point(0, 50)
        Me.btnTribunal.Name = "btnTribunal"
        Me.btnTribunal.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnTribunal.Size = New System.Drawing.Size(233, 25)
        Me.btnTribunal.TabIndex = 9
        Me.btnTribunal.Text = "Tribunales"
        Me.btnTribunal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTribunal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTribunal.UseVisualStyleBackColor = True
        '
        'btnCodDebitar
        '
        Me.btnCodDebitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCodDebitar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCodDebitar.FlatAppearance.BorderSize = 0
        Me.btnCodDebitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCodDebitar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCodDebitar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCodDebitar.Location = New System.Drawing.Point(0, 25)
        Me.btnCodDebitar.Name = "btnCodDebitar"
        Me.btnCodDebitar.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCodDebitar.Size = New System.Drawing.Size(233, 25)
        Me.btnCodDebitar.TabIndex = 8
        Me.btnCodDebitar.Text = "Códigos a Debitar"
        Me.btnCodDebitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCodDebitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCodDebitar.UseVisualStyleBackColor = True
        '
        'btnCodPostales
        '
        Me.btnCodPostales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCodPostales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCodPostales.FlatAppearance.BorderSize = 0
        Me.btnCodPostales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCodPostales.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCodPostales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCodPostales.Location = New System.Drawing.Point(0, 0)
        Me.btnCodPostales.Name = "btnCodPostales"
        Me.btnCodPostales.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCodPostales.Size = New System.Drawing.Size(233, 25)
        Me.btnCodPostales.TabIndex = 2
        Me.btnCodPostales.Text = "Códigos Postales"
        Me.btnCodPostales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCodPostales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCodPostales.UseVisualStyleBackColor = True
        '
        'btnParametros
        '
        Me.btnParametros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnParametros.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnParametros.FlatAppearance.BorderSize = 0
        Me.btnParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParametros.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParametros.ForeColor = System.Drawing.Color.White
        Me.btnParametros.Image = CType(resources.GetObject("btnParametros.Image"), System.Drawing.Image)
        Me.btnParametros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParametros.Location = New System.Drawing.Point(0, 1004)
        Me.btnParametros.Name = "btnParametros"
        Me.btnParametros.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnParametros.Size = New System.Drawing.Size(233, 50)
        Me.btnParametros.TabIndex = 21
        Me.btnParametros.Text = "Parámetros"
        Me.btnParametros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnParametros.UseVisualStyleBackColor = True
        '
        'SubMenuProveedores
        '
        Me.SubMenuProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuProveedores.Controls.Add(Me.btnCajaMayor)
        Me.SubMenuProveedores.Controls.Add(Me.btnSaldoDeudor)
        Me.SubMenuProveedores.Controls.Add(Me.btnCtaCteProv)
        Me.SubMenuProveedores.Controls.Add(Me.btnRecibo)
        Me.SubMenuProveedores.Controls.Add(Me.btnCompras)
        Me.SubMenuProveedores.Controls.Add(Me.btnActualizarProv)
        Me.SubMenuProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuProveedores.Location = New System.Drawing.Point(0, 843)
        Me.SubMenuProveedores.Name = "SubMenuProveedores"
        Me.SubMenuProveedores.Size = New System.Drawing.Size(233, 161)
        Me.SubMenuProveedores.TabIndex = 20
        '
        'btnCajaMayor
        '
        Me.btnCajaMayor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCajaMayor.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCajaMayor.FlatAppearance.BorderSize = 0
        Me.btnCajaMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCajaMayor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCajaMayor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCajaMayor.Location = New System.Drawing.Point(0, 125)
        Me.btnCajaMayor.Name = "btnCajaMayor"
        Me.btnCajaMayor.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCajaMayor.Size = New System.Drawing.Size(233, 25)
        Me.btnCajaMayor.TabIndex = 14
        Me.btnCajaMayor.Text = "Caja Mayor"
        Me.btnCajaMayor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCajaMayor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCajaMayor.UseVisualStyleBackColor = True
        '
        'btnSaldoDeudor
        '
        Me.btnSaldoDeudor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaldoDeudor.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSaldoDeudor.FlatAppearance.BorderSize = 0
        Me.btnSaldoDeudor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaldoDeudor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaldoDeudor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaldoDeudor.Location = New System.Drawing.Point(0, 100)
        Me.btnSaldoDeudor.Name = "btnSaldoDeudor"
        Me.btnSaldoDeudor.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnSaldoDeudor.Size = New System.Drawing.Size(233, 25)
        Me.btnSaldoDeudor.TabIndex = 13
        Me.btnSaldoDeudor.Text = "Saldos Deudor"
        Me.btnSaldoDeudor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaldoDeudor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaldoDeudor.UseVisualStyleBackColor = True
        '
        'btnCtaCteProv
        '
        Me.btnCtaCteProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCtaCteProv.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCtaCteProv.FlatAppearance.BorderSize = 0
        Me.btnCtaCteProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCtaCteProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCtaCteProv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCtaCteProv.Location = New System.Drawing.Point(0, 75)
        Me.btnCtaCteProv.Name = "btnCtaCteProv"
        Me.btnCtaCteProv.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCtaCteProv.Size = New System.Drawing.Size(233, 25)
        Me.btnCtaCteProv.TabIndex = 12
        Me.btnCtaCteProv.Text = "Cuentas Corrientes"
        Me.btnCtaCteProv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCtaCteProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCtaCteProv.UseVisualStyleBackColor = True
        '
        'btnRecibo
        '
        Me.btnRecibo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecibo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRecibo.FlatAppearance.BorderSize = 0
        Me.btnRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecibo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecibo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRecibo.Location = New System.Drawing.Point(0, 50)
        Me.btnRecibo.Name = "btnRecibo"
        Me.btnRecibo.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnRecibo.Size = New System.Drawing.Size(233, 25)
        Me.btnRecibo.TabIndex = 11
        Me.btnRecibo.Text = "Recibo de Pago"
        Me.btnRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecibo.UseVisualStyleBackColor = True
        '
        'btnCompras
        '
        Me.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCompras.Location = New System.Drawing.Point(0, 25)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCompras.Size = New System.Drawing.Size(233, 25)
        Me.btnCompras.TabIndex = 8
        Me.btnCompras.Text = "Carga de Compras"
        Me.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCompras.UseVisualStyleBackColor = True
        '
        'btnActualizarProv
        '
        Me.btnActualizarProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarProv.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnActualizarProv.FlatAppearance.BorderSize = 0
        Me.btnActualizarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarProv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizarProv.Location = New System.Drawing.Point(0, 0)
        Me.btnActualizarProv.Name = "btnActualizarProv"
        Me.btnActualizarProv.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnActualizarProv.Size = New System.Drawing.Size(233, 25)
        Me.btnActualizarProv.TabIndex = 2
        Me.btnActualizarProv.Text = "Actualizar"
        Me.btnActualizarProv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizarProv.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProveedores.FlatAppearance.BorderSize = 0
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.ForeColor = System.Drawing.Color.White
        Me.btnProveedores.Image = CType(resources.GetObject("btnProveedores.Image"), System.Drawing.Image)
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedores.Location = New System.Drawing.Point(0, 793)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnProveedores.Size = New System.Drawing.Size(233, 50)
        Me.btnProveedores.TabIndex = 19
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'SubMenuMesa
        '
        Me.SubMenuMesa.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuMesa.Controls.Add(Me.btnListadoMesa)
        Me.SubMenuMesa.Controls.Add(Me.btnActualizarMesa)
        Me.SubMenuMesa.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuMesa.Location = New System.Drawing.Point(0, 736)
        Me.SubMenuMesa.Name = "SubMenuMesa"
        Me.SubMenuMesa.Size = New System.Drawing.Size(233, 57)
        Me.SubMenuMesa.TabIndex = 18
        '
        'btnListadoMesa
        '
        Me.btnListadoMesa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListadoMesa.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListadoMesa.FlatAppearance.BorderSize = 0
        Me.btnListadoMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListadoMesa.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoMesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnListadoMesa.Location = New System.Drawing.Point(0, 25)
        Me.btnListadoMesa.Name = "btnListadoMesa"
        Me.btnListadoMesa.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnListadoMesa.Size = New System.Drawing.Size(233, 25)
        Me.btnListadoMesa.TabIndex = 8
        Me.btnListadoMesa.Text = "Listados Mesa"
        Me.btnListadoMesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListadoMesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnListadoMesa.UseVisualStyleBackColor = True
        '
        'btnActualizarMesa
        '
        Me.btnActualizarMesa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarMesa.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnActualizarMesa.FlatAppearance.BorderSize = 0
        Me.btnActualizarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarMesa.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarMesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizarMesa.Location = New System.Drawing.Point(0, 0)
        Me.btnActualizarMesa.Name = "btnActualizarMesa"
        Me.btnActualizarMesa.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnActualizarMesa.Size = New System.Drawing.Size(233, 25)
        Me.btnActualizarMesa.TabIndex = 2
        Me.btnActualizarMesa.Text = "Actualizar"
        Me.btnActualizarMesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarMesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizarMesa.UseVisualStyleBackColor = True
        '
        'btnMesaEntrada
        '
        Me.btnMesaEntrada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMesaEntrada.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMesaEntrada.FlatAppearance.BorderSize = 0
        Me.btnMesaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMesaEntrada.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMesaEntrada.ForeColor = System.Drawing.Color.White
        Me.btnMesaEntrada.Image = CType(resources.GetObject("btnMesaEntrada.Image"), System.Drawing.Image)
        Me.btnMesaEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMesaEntrada.Location = New System.Drawing.Point(0, 686)
        Me.btnMesaEntrada.Name = "btnMesaEntrada"
        Me.btnMesaEntrada.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnMesaEntrada.Size = New System.Drawing.Size(233, 50)
        Me.btnMesaEntrada.TabIndex = 17
        Me.btnMesaEntrada.Text = "Mesa de Entrada"
        Me.btnMesaEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMesaEntrada.UseVisualStyleBackColor = True
        '
        'SubMenuCaja
        '
        Me.SubMenuCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuCaja.Controls.Add(Me.btnImportarBanco)
        Me.SubMenuCaja.Controls.Add(Me.btnReciboGral)
        Me.SubMenuCaja.Controls.Add(Me.btnReciboPago)
        Me.SubMenuCaja.Controls.Add(Me.btnMovimCaja)
        Me.SubMenuCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuCaja.Location = New System.Drawing.Point(0, 578)
        Me.SubMenuCaja.Name = "SubMenuCaja"
        Me.SubMenuCaja.Size = New System.Drawing.Size(233, 108)
        Me.SubMenuCaja.TabIndex = 16
        '
        'btnImportarBanco
        '
        Me.btnImportarBanco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportarBanco.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImportarBanco.FlatAppearance.BorderSize = 0
        Me.btnImportarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportarBanco.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportarBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnImportarBanco.Location = New System.Drawing.Point(0, 75)
        Me.btnImportarBanco.Name = "btnImportarBanco"
        Me.btnImportarBanco.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnImportarBanco.Size = New System.Drawing.Size(233, 25)
        Me.btnImportarBanco.TabIndex = 13
        Me.btnImportarBanco.Text = "Importar Banco"
        Me.btnImportarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportarBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportarBanco.UseVisualStyleBackColor = True
        '
        'btnReciboGral
        '
        Me.btnReciboGral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReciboGral.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReciboGral.FlatAppearance.BorderSize = 0
        Me.btnReciboGral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReciboGral.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReciboGral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReciboGral.Location = New System.Drawing.Point(0, 50)
        Me.btnReciboGral.Name = "btnReciboGral"
        Me.btnReciboGral.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnReciboGral.Size = New System.Drawing.Size(233, 25)
        Me.btnReciboGral.TabIndex = 12
        Me.btnReciboGral.Text = "Recibo General"
        Me.btnReciboGral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReciboGral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReciboGral.UseVisualStyleBackColor = True
        '
        'btnReciboPago
        '
        Me.btnReciboPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReciboPago.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReciboPago.FlatAppearance.BorderSize = 0
        Me.btnReciboPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReciboPago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReciboPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReciboPago.Location = New System.Drawing.Point(0, 25)
        Me.btnReciboPago.Name = "btnReciboPago"
        Me.btnReciboPago.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnReciboPago.Size = New System.Drawing.Size(233, 25)
        Me.btnReciboPago.TabIndex = 10
        Me.btnReciboPago.Text = "Recibo Boletas"
        Me.btnReciboPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReciboPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReciboPago.UseVisualStyleBackColor = True
        '
        'btnMovimCaja
        '
        Me.btnMovimCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMovimCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMovimCaja.FlatAppearance.BorderSize = 0
        Me.btnMovimCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMovimCaja.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovimCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMovimCaja.Location = New System.Drawing.Point(0, 0)
        Me.btnMovimCaja.Name = "btnMovimCaja"
        Me.btnMovimCaja.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnMovimCaja.Size = New System.Drawing.Size(233, 25)
        Me.btnMovimCaja.TabIndex = 9
        Me.btnMovimCaja.Text = "Movimientos Caja"
        Me.btnMovimCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovimCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMovimCaja.UseVisualStyleBackColor = True
        '
        'btnCaja
        '
        Me.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCaja.FlatAppearance.BorderSize = 0
        Me.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaja.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaja.ForeColor = System.Drawing.Color.White
        Me.btnCaja.Image = CType(resources.GetObject("btnCaja.Image"), System.Drawing.Image)
        Me.btnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCaja.Location = New System.Drawing.Point(0, 528)
        Me.btnCaja.Name = "btnCaja"
        Me.btnCaja.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnCaja.Size = New System.Drawing.Size(233, 50)
        Me.btnCaja.TabIndex = 15
        Me.btnCaja.Text = "Caja"
        Me.btnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCaja.UseVisualStyleBackColor = True
        '
        'SubMenuSociedades
        '
        Me.SubMenuSociedades.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuSociedades.Controls.Add(Me.btnSaldoPagoSoc)
        Me.SubMenuSociedades.Controls.Add(Me.btnListaPadronSoc)
        Me.SubMenuSociedades.Controls.Add(Me.btnCtasCtesSoc)
        Me.SubMenuSociedades.Controls.Add(Me.btnLiquidarSoc)
        Me.SubMenuSociedades.Controls.Add(Me.btnDebitosSoc)
        Me.SubMenuSociedades.Controls.Add(Me.btnActualizarSoc)
        Me.SubMenuSociedades.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuSociedades.Location = New System.Drawing.Point(0, 370)
        Me.SubMenuSociedades.Name = "SubMenuSociedades"
        Me.SubMenuSociedades.Size = New System.Drawing.Size(233, 158)
        Me.SubMenuSociedades.TabIndex = 14
        '
        'btnSaldoPagoSoc
        '
        Me.btnSaldoPagoSoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaldoPagoSoc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSaldoPagoSoc.FlatAppearance.BorderSize = 0
        Me.btnSaldoPagoSoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaldoPagoSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaldoPagoSoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaldoPagoSoc.Location = New System.Drawing.Point(0, 125)
        Me.btnSaldoPagoSoc.Name = "btnSaldoPagoSoc"
        Me.btnSaldoPagoSoc.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnSaldoPagoSoc.Size = New System.Drawing.Size(233, 25)
        Me.btnSaldoPagoSoc.TabIndex = 7
        Me.btnSaldoPagoSoc.Text = "Saldos Sociedades"
        Me.btnSaldoPagoSoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaldoPagoSoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaldoPagoSoc.UseVisualStyleBackColor = True
        '
        'btnListaPadronSoc
        '
        Me.btnListaPadronSoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListaPadronSoc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListaPadronSoc.FlatAppearance.BorderSize = 0
        Me.btnListaPadronSoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaPadronSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaPadronSoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnListaPadronSoc.Location = New System.Drawing.Point(0, 100)
        Me.btnListaPadronSoc.Name = "btnListaPadronSoc"
        Me.btnListaPadronSoc.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnListaPadronSoc.Size = New System.Drawing.Size(233, 25)
        Me.btnListaPadronSoc.TabIndex = 6
        Me.btnListaPadronSoc.Text = "Listador Padrón"
        Me.btnListaPadronSoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListaPadronSoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnListaPadronSoc.UseVisualStyleBackColor = True
        '
        'btnCtasCtesSoc
        '
        Me.btnCtasCtesSoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCtasCtesSoc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCtasCtesSoc.FlatAppearance.BorderSize = 0
        Me.btnCtasCtesSoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCtasCtesSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCtasCtesSoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCtasCtesSoc.Location = New System.Drawing.Point(0, 75)
        Me.btnCtasCtesSoc.Name = "btnCtasCtesSoc"
        Me.btnCtasCtesSoc.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCtasCtesSoc.Size = New System.Drawing.Size(233, 25)
        Me.btnCtasCtesSoc.TabIndex = 4
        Me.btnCtasCtesSoc.Text = "Cuentas Corrientes"
        Me.btnCtasCtesSoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCtasCtesSoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCtasCtesSoc.UseVisualStyleBackColor = True
        '
        'btnLiquidarSoc
        '
        Me.btnLiquidarSoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLiquidarSoc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLiquidarSoc.FlatAppearance.BorderSize = 0
        Me.btnLiquidarSoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLiquidarSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiquidarSoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLiquidarSoc.Location = New System.Drawing.Point(0, 50)
        Me.btnLiquidarSoc.Name = "btnLiquidarSoc"
        Me.btnLiquidarSoc.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnLiquidarSoc.Size = New System.Drawing.Size(233, 25)
        Me.btnLiquidarSoc.TabIndex = 3
        Me.btnLiquidarSoc.Text = "Liquidar Sociedades"
        Me.btnLiquidarSoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLiquidarSoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLiquidarSoc.UseVisualStyleBackColor = True
        '
        'btnDebitosSoc
        '
        Me.btnDebitosSoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDebitosSoc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDebitosSoc.FlatAppearance.BorderSize = 0
        Me.btnDebitosSoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebitosSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebitosSoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDebitosSoc.Location = New System.Drawing.Point(0, 25)
        Me.btnDebitosSoc.Name = "btnDebitosSoc"
        Me.btnDebitosSoc.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnDebitosSoc.Size = New System.Drawing.Size(233, 25)
        Me.btnDebitosSoc.TabIndex = 2
        Me.btnDebitosSoc.Text = "Cargar Débitos"
        Me.btnDebitosSoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDebitosSoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDebitosSoc.UseVisualStyleBackColor = True
        '
        'btnActualizarSoc
        '
        Me.btnActualizarSoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarSoc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnActualizarSoc.FlatAppearance.BorderSize = 0
        Me.btnActualizarSoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarSoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarSoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizarSoc.Location = New System.Drawing.Point(0, 0)
        Me.btnActualizarSoc.Name = "btnActualizarSoc"
        Me.btnActualizarSoc.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnActualizarSoc.Size = New System.Drawing.Size(233, 25)
        Me.btnActualizarSoc.TabIndex = 1
        Me.btnActualizarSoc.Text = "Actualizar"
        Me.btnActualizarSoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarSoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizarSoc.UseVisualStyleBackColor = True
        '
        'btnSociedades
        '
        Me.btnSociedades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSociedades.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSociedades.FlatAppearance.BorderSize = 0
        Me.btnSociedades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSociedades.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSociedades.ForeColor = System.Drawing.Color.White
        Me.btnSociedades.Image = CType(resources.GetObject("btnSociedades.Image"), System.Drawing.Image)
        Me.btnSociedades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSociedades.Location = New System.Drawing.Point(0, 320)
        Me.btnSociedades.Name = "btnSociedades"
        Me.btnSociedades.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnSociedades.Size = New System.Drawing.Size(233, 50)
        Me.btnSociedades.TabIndex = 13
        Me.btnSociedades.Text = "Sociedades"
        Me.btnSociedades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSociedades.UseVisualStyleBackColor = True
        '
        'SubMenuMatriculados
        '
        Me.SubMenuMatriculados.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuMatriculados.Controls.Add(Me.btnListaOficio)
        Me.SubMenuMatriculados.Controls.Add(Me.btnSaldoPago)
        Me.SubMenuMatriculados.Controls.Add(Me.btnListadosMat)
        Me.SubMenuMatriculados.Controls.Add(Me.btnMailMat)
        Me.SubMenuMatriculados.Controls.Add(Me.btnCtasCtesMat)
        Me.SubMenuMatriculados.Controls.Add(Me.btnLiquidarMat)
        Me.SubMenuMatriculados.Controls.Add(Me.btnDebitosMat)
        Me.SubMenuMatriculados.Controls.Add(Me.btnActualizarMat)
        Me.SubMenuMatriculados.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuMatriculados.Location = New System.Drawing.Point(0, 112)
        Me.SubMenuMatriculados.Name = "SubMenuMatriculados"
        Me.SubMenuMatriculados.Size = New System.Drawing.Size(233, 208)
        Me.SubMenuMatriculados.TabIndex = 12
        '
        'btnListaOficio
        '
        Me.btnListaOficio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListaOficio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListaOficio.FlatAppearance.BorderSize = 0
        Me.btnListaOficio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaOficio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaOficio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnListaOficio.Location = New System.Drawing.Point(0, 175)
        Me.btnListaOficio.Name = "btnListaOficio"
        Me.btnListaOficio.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnListaOficio.Size = New System.Drawing.Size(233, 25)
        Me.btnListaOficio.TabIndex = 11
        Me.btnListaOficio.Text = "Lista Desig. de Oficio"
        Me.btnListaOficio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListaOficio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnListaOficio.UseVisualStyleBackColor = True
        '
        'btnSaldoPago
        '
        Me.btnSaldoPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaldoPago.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSaldoPago.FlatAppearance.BorderSize = 0
        Me.btnSaldoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaldoPago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaldoPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaldoPago.Location = New System.Drawing.Point(0, 150)
        Me.btnSaldoPago.Name = "btnSaldoPago"
        Me.btnSaldoPago.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnSaldoPago.Size = New System.Drawing.Size(233, 25)
        Me.btnSaldoPago.TabIndex = 10
        Me.btnSaldoPago.Text = "Saldos/Pagos Detallados"
        Me.btnSaldoPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaldoPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaldoPago.UseVisualStyleBackColor = True
        '
        'btnListadosMat
        '
        Me.btnListadosMat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListadosMat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListadosMat.FlatAppearance.BorderSize = 0
        Me.btnListadosMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListadosMat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadosMat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnListadosMat.Location = New System.Drawing.Point(0, 125)
        Me.btnListadosMat.Name = "btnListadosMat"
        Me.btnListadosMat.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnListadosMat.Size = New System.Drawing.Size(233, 25)
        Me.btnListadosMat.TabIndex = 8
        Me.btnListadosMat.Text = "Listador Padrón"
        Me.btnListadosMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListadosMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnListadosMat.UseVisualStyleBackColor = True
        '
        'btnMailMat
        '
        Me.btnMailMat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMailMat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMailMat.FlatAppearance.BorderSize = 0
        Me.btnMailMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMailMat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMailMat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMailMat.Location = New System.Drawing.Point(0, 100)
        Me.btnMailMat.Name = "btnMailMat"
        Me.btnMailMat.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnMailMat.Size = New System.Drawing.Size(233, 25)
        Me.btnMailMat.TabIndex = 7
        Me.btnMailMat.Text = "Enviar por Mail"
        Me.btnMailMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMailMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMailMat.UseVisualStyleBackColor = True
        '
        'btnCtasCtesMat
        '
        Me.btnCtasCtesMat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCtasCtesMat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCtasCtesMat.FlatAppearance.BorderSize = 0
        Me.btnCtasCtesMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCtasCtesMat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCtasCtesMat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCtasCtesMat.Location = New System.Drawing.Point(0, 75)
        Me.btnCtasCtesMat.Name = "btnCtasCtesMat"
        Me.btnCtasCtesMat.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCtasCtesMat.Size = New System.Drawing.Size(233, 25)
        Me.btnCtasCtesMat.TabIndex = 5
        Me.btnCtasCtesMat.Text = "Cuentas Corrientes"
        Me.btnCtasCtesMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCtasCtesMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCtasCtesMat.UseVisualStyleBackColor = True
        '
        'btnLiquidarMat
        '
        Me.btnLiquidarMat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLiquidarMat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLiquidarMat.FlatAppearance.BorderSize = 0
        Me.btnLiquidarMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLiquidarMat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiquidarMat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLiquidarMat.Location = New System.Drawing.Point(0, 50)
        Me.btnLiquidarMat.Name = "btnLiquidarMat"
        Me.btnLiquidarMat.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnLiquidarMat.Size = New System.Drawing.Size(233, 25)
        Me.btnLiquidarMat.TabIndex = 4
        Me.btnLiquidarMat.Text = "Liquidar Matriculados"
        Me.btnLiquidarMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLiquidarMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLiquidarMat.UseVisualStyleBackColor = True
        '
        'btnDebitosMat
        '
        Me.btnDebitosMat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDebitosMat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDebitosMat.FlatAppearance.BorderSize = 0
        Me.btnDebitosMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebitosMat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebitosMat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDebitosMat.Location = New System.Drawing.Point(0, 25)
        Me.btnDebitosMat.Name = "btnDebitosMat"
        Me.btnDebitosMat.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnDebitosMat.Size = New System.Drawing.Size(233, 25)
        Me.btnDebitosMat.TabIndex = 3
        Me.btnDebitosMat.Text = "Cargar Débitos"
        Me.btnDebitosMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDebitosMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDebitosMat.UseVisualStyleBackColor = True
        '
        'btnActualizarMat
        '
        Me.btnActualizarMat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarMat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnActualizarMat.FlatAppearance.BorderSize = 0
        Me.btnActualizarMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarMat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarMat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizarMat.Location = New System.Drawing.Point(0, 0)
        Me.btnActualizarMat.Name = "btnActualizarMat"
        Me.btnActualizarMat.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnActualizarMat.Size = New System.Drawing.Size(233, 25)
        Me.btnActualizarMat.TabIndex = 2
        Me.btnActualizarMat.Text = "Actualizar"
        Me.btnActualizarMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizarMat.UseVisualStyleBackColor = True
        '
        'btnMatriculados
        '
        Me.btnMatriculados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMatriculados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMatriculados.FlatAppearance.BorderSize = 0
        Me.btnMatriculados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatriculados.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatriculados.ForeColor = System.Drawing.Color.White
        Me.btnMatriculados.Image = CType(resources.GetObject("btnMatriculados.Image"), System.Drawing.Image)
        Me.btnMatriculados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMatriculados.Location = New System.Drawing.Point(0, 62)
        Me.btnMatriculados.Name = "btnMatriculados"
        Me.btnMatriculados.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnMatriculados.Size = New System.Drawing.Size(233, 50)
        Me.btnMatriculados.TabIndex = 11
        Me.btnMatriculados.Text = "Matriculados"
        Me.btnMatriculados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMatriculados.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.Black
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Controls.Add(Me.Label1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(233, 62)
        Me.PanelLogo.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(76, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Colegio de Martilleros" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y Corredores Públicos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " de Santa Fe"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.Black
        Me.PanelBarraTitulo.Controls.Add(Me.Label6)
        Me.PanelBarraTitulo.Controls.Add(Me.txtUsuario)
        Me.PanelBarraTitulo.Controls.Add(Me.Label2)
        Me.PanelBarraTitulo.Controls.Add(Me.Label5)
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.Label4)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.Label3)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1430, 40)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(1170, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "sector"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.Black
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(1168, 11)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(138, 18)
        Me.txtUsuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(639, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Menú General Sistema Administrativo Colegio de Martilleros de Santa Fe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(1092, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "SECTOR:"
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(1371, 10)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(20, 20)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(899, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "USUARIO:"
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(1371, 10)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(20, 20)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximizar.TabIndex = 2
        Me.btnMaximizar.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(986, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "usuario"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1345, 10)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(20, 20)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1397, 10)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(20, 20)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'MenuPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1430, 750)
        Me.Controls.Add(Me.PanelBotonesMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "MenuPpal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPpal"
        Me.PanelBotonesMenu.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.SubMenuSistema.ResumeLayout(False)
        Me.SubMenuParametros.ResumeLayout(False)
        Me.SubMenuProveedores.ResumeLayout(False)
        Me.SubMenuMesa.ResumeLayout(False)
        Me.SubMenuCaja.ResumeLayout(False)
        Me.SubMenuSociedades.ResumeLayout(False)
        Me.SubMenuMatriculados.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBotonesMenu As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SubMenuMesa As Panel
    Friend WithEvents btnListadoMesa As Button
    Friend WithEvents btnActualizarMesa As Button
    Friend WithEvents btnMesaEntrada As Button
    Friend WithEvents SubMenuCaja As Panel
    Friend WithEvents btnCaja As Button
    Friend WithEvents SubMenuSociedades As Panel
    Friend WithEvents btnListaPadronSoc As Button
    Friend WithEvents btnCtasCtesSoc As Button
    Friend WithEvents btnLiquidarSoc As Button
    Friend WithEvents btnDebitosSoc As Button
    Friend WithEvents btnActualizarSoc As Button
    Friend WithEvents btnSociedades As Button
    Friend WithEvents SubMenuMatriculados As Panel
    Friend WithEvents btnListadosMat As Button
    Friend WithEvents btnMailMat As Button
    Friend WithEvents btnCtasCtesMat As Button
    Friend WithEvents btnLiquidarMat As Button
    Friend WithEvents btnDebitosMat As Button
    Friend WithEvents btnActualizarMat As Button
    Friend WithEvents btnMatriculados As Button
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSaldoPagoSoc As Button
    Friend WithEvents btnMovimCaja As Button
    Friend WithEvents btnReciboPago As Button
    Friend WithEvents btnSaldoPago As Button
    Friend WithEvents btnListaOficio As Button
    Friend WithEvents btnReciboGral As Button
    Friend WithEvents btnImportarBanco As Button
    Friend WithEvents SubMenuProveedores As Panel
    Friend WithEvents btnCompras As Button
    Friend WithEvents btnActualizarProv As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents SubMenuSistema As Panel
    Friend WithEvents btnBackupRestore As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnNiveles As Button
    Friend WithEvents btnSistema As Button
    Friend WithEvents SubMenuParametros As Panel
    Friend WithEvents btnTribunal As Button
    Friend WithEvents btnCodDebitar As Button
    Friend WithEvents btnCodPostales As Button
    Friend WithEvents btnParametros As Button
    Friend WithEvents btnRecibo As Button
    Friend WithEvents btnSaldoDeudor As Button
    Friend WithEvents btnCtaCteProv As Button
    Friend WithEvents btnCajaMayor As Button
    Friend WithEvents btnPasaje As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsuario As TextBox
End Class

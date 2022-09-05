<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Dim NroProvCpraLabel As System.Windows.Forms.Label
        Dim TitularCpraLabel As System.Windows.Forms.Label
        Dim FechaCpraLabel As System.Windows.Forms.Label
        Dim TipoCbteCpraLabel As System.Windows.Forms.Label
        Dim PrefijoCpraLabel As System.Windows.Forms.Label
        Dim SubfijoCpraLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompras))
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
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cbxTipoCbteCpra = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFechaCpra = New System.Windows.Forms.TextBox()
        Me.txtId_Cpra = New System.Windows.Forms.TextBox()
        Me.txtNroProvCpra = New System.Windows.Forms.TextBox()
        Me.txtTitularCpra = New System.Windows.Forms.TextBox()
        Me.txtPrefijoCpra = New System.Windows.Forms.TextBox()
        Me.txtSubfijoCpra = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgvDetCompras = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtIdSRubDetCpra = New System.Windows.Forms.TextBox()
        Me.txtUnitDetCpra = New System.Windows.Forms.TextBox()
        Me.txtDetalleDetCpra = New System.Windows.Forms.TextBox()
        Me.txtId_DetCpra = New System.Windows.Forms.TextBox()
        Me.txtItemDetCpra = New System.Windows.Forms.TextBox()
        Me.txtCantDetCpra = New System.Windows.Forms.TextBox()
        Me.txtNetoDetCpra = New System.Windows.Forms.TextBox()
        Me.txtImpIntDetCpra = New System.Windows.Forms.TextBox()
        Me.txtTotalDetCpra = New System.Windows.Forms.TextBox()
        Me.txtSRubDetCpra = New System.Windows.Forms.TextBox()
        Me.txtNetoCpra = New System.Windows.Forms.TextBox()
        Me.txtImpIntCpra = New System.Windows.Forms.TextBox()
        Me.txtTotalCpra = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        NroProvCpraLabel = New System.Windows.Forms.Label()
        TitularCpraLabel = New System.Windows.Forms.Label()
        FechaCpraLabel = New System.Windows.Forms.Label()
        TipoCbteCpraLabel = New System.Windows.Forms.Label()
        PrefijoCpraLabel = New System.Windows.Forms.Label()
        SubfijoCpraLabel = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NroProvCpraLabel
        '
        NroProvCpraLabel.AutoSize = True
        NroProvCpraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NroProvCpraLabel.Location = New System.Drawing.Point(23, 64)
        NroProvCpraLabel.Name = "NroProvCpraLabel"
        NroProvCpraLabel.Size = New System.Drawing.Size(76, 17)
        NroProvCpraLabel.TabIndex = 164
        NroProvCpraLabel.Text = "Nro. Prov.:"
        '
        'TitularCpraLabel
        '
        TitularCpraLabel.AutoSize = True
        TitularCpraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitularCpraLabel.Location = New System.Drawing.Point(231, 64)
        TitularCpraLabel.Name = "TitularCpraLabel"
        TitularCpraLabel.Size = New System.Drawing.Size(49, 17)
        TitularCpraLabel.TabIndex = 168
        TitularCpraLabel.Text = "Titular:"
        '
        'FechaCpraLabel
        '
        FechaCpraLabel.AutoSize = True
        FechaCpraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaCpraLabel.Location = New System.Drawing.Point(48, 93)
        FechaCpraLabel.Name = "FechaCpraLabel"
        FechaCpraLabel.Size = New System.Drawing.Size(51, 17)
        FechaCpraLabel.TabIndex = 170
        FechaCpraLabel.Text = "Fecha:"
        '
        'TipoCbteCpraLabel
        '
        TipoCbteCpraLabel.AutoSize = True
        TipoCbteCpraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoCbteCpraLabel.Location = New System.Drawing.Point(201, 93)
        TipoCbteCpraLabel.Name = "TipoCbteCpraLabel"
        TipoCbteCpraLabel.Size = New System.Drawing.Size(79, 17)
        TipoCbteCpraLabel.TabIndex = 171
        TipoCbteCpraLabel.Text = "Tipo Cbte.:"
        '
        'PrefijoCpraLabel
        '
        PrefijoCpraLabel.AutoSize = True
        PrefijoCpraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrefijoCpraLabel.Location = New System.Drawing.Point(425, 93)
        PrefijoCpraLabel.Name = "PrefijoCpraLabel"
        PrefijoCpraLabel.Size = New System.Drawing.Size(51, 17)
        PrefijoCpraLabel.TabIndex = 172
        PrefijoCpraLabel.Text = "Prefijo:"
        '
        'SubfijoCpraLabel
        '
        SubfijoCpraLabel.AutoSize = True
        SubfijoCpraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubfijoCpraLabel.Location = New System.Drawing.Point(540, 93)
        SubfijoCpraLabel.Name = "SubfijoCpraLabel"
        SubfijoCpraLabel.Size = New System.Drawing.Size(54, 17)
        SubfijoCpraLabel.TabIndex = 173
        SubfijoCpraLabel.Text = "Subfijo:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.Color.YellowGreen
        Label10.Location = New System.Drawing.Point(765, 135)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(87, 17)
        Label10.TabIndex = 205
        Label10.Text = "IMPUTACIÓN"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.Color.YellowGreen
        Label9.Location = New System.Drawing.Point(565, 135)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(65, 17)
        Label9.TabIndex = 204
        Label9.Text = "SUBTOTAL"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.Color.YellowGreen
        Label8.Location = New System.Drawing.Point(459, 135)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(84, 17)
        Label8.TabIndex = 203
        Label8.Text = "IMP. VARIOS"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.YellowGreen
        Label5.Location = New System.Drawing.Point(367, 135)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(71, 17)
        Label5.TabIndex = 200
        Label5.Text = "IMP. NETO"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.YellowGreen
        Label4.Location = New System.Drawing.Point(281, 135)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(68, 17)
        Label4.TabIndex = 199
        Label4.Text = "IMP. UNIT."
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.YellowGreen
        Label2.Location = New System.Drawing.Point(63, 135)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(58, 17)
        Label2.TabIndex = 198
        Label2.Text = "DETALLE"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.YellowGreen
        Label1.Location = New System.Drawing.Point(9, 135)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(47, 17)
        Label1.TabIndex = 197
        Label1.Text = "CANT."
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
        Me.btnActualizar.Location = New System.Drawing.Point(1020, 262)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(119, 44)
        Me.btnActualizar.TabIndex = 179
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizar.UseVisualStyleBackColor = True
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
        Me.btnLimpiar.Location = New System.Drawing.Point(1033, 354)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(96, 44)
        Me.btnLimpiar.TabIndex = 177
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(1033, 170)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(96, 44)
        Me.btnAgregar.TabIndex = 176
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cbxTipoCbteCpra
        '
        Me.cbxTipoCbteCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cbxTipoCbteCpra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxTipoCbteCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoCbteCpra.ForeColor = System.Drawing.Color.White
        Me.cbxTipoCbteCpra.FormattingEnabled = True
        Me.cbxTipoCbteCpra.Items.AddRange(New Object() {"FAA", "FAB", "FAC", "NCA", "NCB", "NCC", "REM", "X"})
        Me.cbxTipoCbteCpra.Location = New System.Drawing.Point(286, 90)
        Me.cbxTipoCbteCpra.Name = "cbxTipoCbteCpra"
        Me.cbxTipoCbteCpra.Size = New System.Drawing.Size(77, 25)
        Me.cbxTipoCbteCpra.TabIndex = 166
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(308, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(508, 36)
        Me.Label3.TabIndex = 174
        Me.Label3.Text = "Carga de Compras a Proveedores"
        '
        'txtFechaCpra
        '
        Me.txtFechaCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFechaCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaCpra.ForeColor = System.Drawing.Color.White
        Me.txtFechaCpra.Location = New System.Drawing.Point(105, 91)
        Me.txtFechaCpra.Name = "txtFechaCpra"
        Me.txtFechaCpra.Size = New System.Drawing.Size(88, 23)
        Me.txtFechaCpra.TabIndex = 165
        '
        'txtId_Cpra
        '
        Me.txtId_Cpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_Cpra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_Cpra.Enabled = False
        Me.txtId_Cpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_Cpra.ForeColor = System.Drawing.Color.White
        Me.txtId_Cpra.Location = New System.Drawing.Point(698, 64)
        Me.txtId_Cpra.Name = "txtId_Cpra"
        Me.txtId_Cpra.Size = New System.Drawing.Size(59, 16)
        Me.txtId_Cpra.TabIndex = 163
        '
        'txtNroProvCpra
        '
        Me.txtNroProvCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroProvCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroProvCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroProvCpra.ForeColor = System.Drawing.Color.White
        Me.txtNroProvCpra.Location = New System.Drawing.Point(105, 62)
        Me.txtNroProvCpra.Name = "txtNroProvCpra"
        Me.txtNroProvCpra.Size = New System.Drawing.Size(77, 23)
        Me.txtNroProvCpra.TabIndex = 161
        '
        'txtTitularCpra
        '
        Me.txtTitularCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTitularCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitularCpra.Enabled = False
        Me.txtTitularCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitularCpra.ForeColor = System.Drawing.Color.White
        Me.txtTitularCpra.Location = New System.Drawing.Point(286, 62)
        Me.txtTitularCpra.Name = "txtTitularCpra"
        Me.txtTitularCpra.Size = New System.Drawing.Size(403, 23)
        Me.txtTitularCpra.TabIndex = 162
        '
        'txtPrefijoCpra
        '
        Me.txtPrefijoCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPrefijoCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrefijoCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefijoCpra.ForeColor = System.Drawing.Color.White
        Me.txtPrefijoCpra.Location = New System.Drawing.Point(482, 91)
        Me.txtPrefijoCpra.Name = "txtPrefijoCpra"
        Me.txtPrefijoCpra.Size = New System.Drawing.Size(50, 23)
        Me.txtPrefijoCpra.TabIndex = 167
        '
        'txtSubfijoCpra
        '
        Me.txtSubfijoCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSubfijoCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubfijoCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubfijoCpra.ForeColor = System.Drawing.Color.White
        Me.txtSubfijoCpra.Location = New System.Drawing.Point(600, 91)
        Me.txtSubfijoCpra.Name = "txtSubfijoCpra"
        Me.txtSubfijoCpra.Size = New System.Drawing.Size(88, 23)
        Me.txtSubfijoCpra.TabIndex = 169
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(9, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1141, 73)
        Me.PictureBox1.TabIndex = 175
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(1011, 155)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 253)
        Me.PictureBox2.TabIndex = 178
        Me.PictureBox2.TabStop = False
        '
        'dgvDetCompras
        '
        Me.dgvDetCompras.AllowUserToAddRows = False
        Me.dgvDetCompras.AllowUserToDeleteRows = False
        Me.dgvDetCompras.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvDetCompras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetCompras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvDetCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetCompras.ColumnHeadersHeight = 40
        Me.dgvDetCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDetCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetCompras.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvDetCompras.EnableHeadersVisualStyles = False
        Me.dgvDetCompras.GridColor = System.Drawing.Color.White
        Me.dgvDetCompras.Location = New System.Drawing.Point(9, 184)
        Me.dgvDetCompras.Name = "dgvDetCompras"
        Me.dgvDetCompras.ReadOnly = True
        Me.dgvDetCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetCompras.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvDetCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetCompras.Size = New System.Drawing.Size(996, 224)
        Me.dgvDetCompras.TabIndex = 214
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column3
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "ITEM"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 45
        '
        'Column4
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "CANT."
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "DETALLE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 250
        '
        'Column6
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column6.HeaderText = "IMP. UNIT."
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column7.HeaderText = "IMP. NETO"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column8.HeaderText = "I.V.A. REPONS."
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'Column9
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column9.HeaderText = "I.V.A. NO RESPONS."
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column10
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column10.HeaderText = "IMPUESTOS VARIOS"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column11.HeaderText = "SUBTOTAL"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Column12"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Visible = False
        '
        'Column13
        '
        Me.Column13.HeaderText = "IMPUTACIÓN"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 200
        '
        'Column14
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column14.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column14.HeaderText = "OBRA"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Visible = False
        Me.Column14.Width = 50
        '
        'btnGrabar
        '
        Me.btnGrabar.AutoSize = True
        Me.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGrabar.FlatAppearance.BorderSize = 0
        Me.btnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.ForeColor = System.Drawing.Color.White
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrabar.Location = New System.Drawing.Point(151, 479)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGrabar.Size = New System.Drawing.Size(59, 56)
        Me.btnGrabar.TabIndex = 208
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.AutoSize = True
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(903, 479)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSalir.Size = New System.Drawing.Size(87, 56)
        Me.btnSalir.TabIndex = 211
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.AutoSize = True
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(390, 479)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnModificar.Size = New System.Drawing.Size(80, 56)
        Me.btnModificar.TabIndex = 209
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(650, 479)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEliminar.Size = New System.Drawing.Size(73, 56)
        Me.btnEliminar.TabIndex = 210
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtIdSRubDetCpra
        '
        Me.txtIdSRubDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIdSRubDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdSRubDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSRubDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtIdSRubDetCpra.Location = New System.Drawing.Point(194, 429)
        Me.txtIdSRubDetCpra.Name = "txtIdSRubDetCpra"
        Me.txtIdSRubDetCpra.Size = New System.Drawing.Size(74, 16)
        Me.txtIdSRubDetCpra.TabIndex = 207
        Me.txtIdSRubDetCpra.Visible = False
        '
        'txtUnitDetCpra
        '
        Me.txtUnitDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtUnitDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnitDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtUnitDetCpra.Location = New System.Drawing.Point(276, 155)
        Me.txtUnitDetCpra.Name = "txtUnitDetCpra"
        Me.txtUnitDetCpra.Size = New System.Drawing.Size(73, 23)
        Me.txtUnitDetCpra.TabIndex = 182
        Me.txtUnitDetCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDetalleDetCpra
        '
        Me.txtDetalleDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDetalleDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalleDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtDetalleDetCpra.Location = New System.Drawing.Point(65, 155)
        Me.txtDetalleDetCpra.Name = "txtDetalleDetCpra"
        Me.txtDetalleDetCpra.Size = New System.Drawing.Size(207, 23)
        Me.txtDetalleDetCpra.TabIndex = 181
        '
        'txtId_DetCpra
        '
        Me.txtId_DetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_DetCpra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_DetCpra.Enabled = False
        Me.txtId_DetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_DetCpra.ForeColor = System.Drawing.Color.White
        Me.txtId_DetCpra.Location = New System.Drawing.Point(34, 429)
        Me.txtId_DetCpra.Name = "txtId_DetCpra"
        Me.txtId_DetCpra.Size = New System.Drawing.Size(74, 16)
        Me.txtId_DetCpra.TabIndex = 195
        Me.txtId_DetCpra.Visible = False
        '
        'txtItemDetCpra
        '
        Me.txtItemDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtItemDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemDetCpra.Enabled = False
        Me.txtItemDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtItemDetCpra.Location = New System.Drawing.Point(114, 429)
        Me.txtItemDetCpra.Name = "txtItemDetCpra"
        Me.txtItemDetCpra.Size = New System.Drawing.Size(74, 16)
        Me.txtItemDetCpra.TabIndex = 196
        Me.txtItemDetCpra.Visible = False
        '
        'txtCantDetCpra
        '
        Me.txtCantDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCantDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtCantDetCpra.Location = New System.Drawing.Point(10, 155)
        Me.txtCantDetCpra.Name = "txtCantDetCpra"
        Me.txtCantDetCpra.Size = New System.Drawing.Size(51, 23)
        Me.txtCantDetCpra.TabIndex = 180
        Me.txtCantDetCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetoDetCpra
        '
        Me.txtNetoDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNetoDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetoDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetoDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtNetoDetCpra.Location = New System.Drawing.Point(353, 155)
        Me.txtNetoDetCpra.Name = "txtNetoDetCpra"
        Me.txtNetoDetCpra.Size = New System.Drawing.Size(95, 23)
        Me.txtNetoDetCpra.TabIndex = 183
        Me.txtNetoDetCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpIntDetCpra
        '
        Me.txtImpIntDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtImpIntDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImpIntDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpIntDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtImpIntDetCpra.Location = New System.Drawing.Point(452, 155)
        Me.txtImpIntDetCpra.Name = "txtImpIntDetCpra"
        Me.txtImpIntDetCpra.Size = New System.Drawing.Size(95, 23)
        Me.txtImpIntDetCpra.TabIndex = 186
        Me.txtImpIntDetCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDetCpra
        '
        Me.txtTotalDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTotalDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtTotalDetCpra.Location = New System.Drawing.Point(551, 155)
        Me.txtTotalDetCpra.Name = "txtTotalDetCpra"
        Me.txtTotalDetCpra.Size = New System.Drawing.Size(95, 23)
        Me.txtTotalDetCpra.TabIndex = 187
        Me.txtTotalDetCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSRubDetCpra
        '
        Me.txtSRubDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSRubDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSRubDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSRubDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtSRubDetCpra.Location = New System.Drawing.Point(650, 155)
        Me.txtSRubDetCpra.Name = "txtSRubDetCpra"
        Me.txtSRubDetCpra.Size = New System.Drawing.Size(340, 23)
        Me.txtSRubDetCpra.TabIndex = 188
        '
        'txtNetoCpra
        '
        Me.txtNetoCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNetoCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetoCpra.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetoCpra.ForeColor = System.Drawing.Color.Yellow
        Me.txtNetoCpra.Location = New System.Drawing.Point(497, 427)
        Me.txtNetoCpra.Name = "txtNetoCpra"
        Me.txtNetoCpra.Size = New System.Drawing.Size(95, 26)
        Me.txtNetoCpra.TabIndex = 190
        Me.txtNetoCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpIntCpra
        '
        Me.txtImpIntCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtImpIntCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImpIntCpra.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpIntCpra.ForeColor = System.Drawing.Color.Yellow
        Me.txtImpIntCpra.Location = New System.Drawing.Point(596, 427)
        Me.txtImpIntCpra.Name = "txtImpIntCpra"
        Me.txtImpIntCpra.Size = New System.Drawing.Size(95, 26)
        Me.txtImpIntCpra.TabIndex = 193
        Me.txtImpIntCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCpra
        '
        Me.txtTotalCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTotalCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalCpra.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCpra.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalCpra.Location = New System.Drawing.Point(695, 427)
        Me.txtTotalCpra.Name = "txtTotalCpra"
        Me.txtTotalCpra.Size = New System.Drawing.Size(95, 26)
        Me.txtTotalCpra.TabIndex = 194
        Me.txtTotalCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(9, 414)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1141, 51)
        Me.PictureBox3.TabIndex = 212
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(9, 471)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1141, 71)
        Me.PictureBox4.TabIndex = 213
        Me.PictureBox4.TabStop = False
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1173, 575)
        Me.Controls.Add(Me.dgvDetCompras)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtIdSRubDetCpra)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtUnitDetCpra)
        Me.Controls.Add(Me.txtDetalleDetCpra)
        Me.Controls.Add(Me.txtId_DetCpra)
        Me.Controls.Add(Me.txtItemDetCpra)
        Me.Controls.Add(Me.txtCantDetCpra)
        Me.Controls.Add(Me.txtNetoDetCpra)
        Me.Controls.Add(Me.txtImpIntDetCpra)
        Me.Controls.Add(Me.txtTotalDetCpra)
        Me.Controls.Add(Me.txtSRubDetCpra)
        Me.Controls.Add(Me.txtNetoCpra)
        Me.Controls.Add(Me.txtImpIntCpra)
        Me.Controls.Add(Me.txtTotalCpra)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cbxTipoCbteCpra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFechaCpra)
        Me.Controls.Add(Me.txtId_Cpra)
        Me.Controls.Add(NroProvCpraLabel)
        Me.Controls.Add(Me.txtNroProvCpra)
        Me.Controls.Add(TitularCpraLabel)
        Me.Controls.Add(Me.txtTitularCpra)
        Me.Controls.Add(FechaCpraLabel)
        Me.Controls.Add(TipoCbteCpraLabel)
        Me.Controls.Add(PrefijoCpraLabel)
        Me.Controls.Add(Me.txtPrefijoCpra)
        Me.Controls.Add(SubfijoCpraLabel)
        Me.Controls.Add(Me.txtSubfijoCpra)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCompras"
        Me.Text = "CARGA DE COMPRAS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cbxTipoCbteCpra As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFechaCpra As TextBox
    Friend WithEvents txtId_Cpra As TextBox
    Friend WithEvents txtNroProvCpra As TextBox
    Friend WithEvents txtTitularCpra As TextBox
    Friend WithEvents txtPrefijoCpra As TextBox
    Friend WithEvents txtSubfijoCpra As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgvDetCompras As DataGridView
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtIdSRubDetCpra As TextBox
    Friend WithEvents txtUnitDetCpra As TextBox
    Friend WithEvents txtDetalleDetCpra As TextBox
    Friend WithEvents txtId_DetCpra As TextBox
    Friend WithEvents txtItemDetCpra As TextBox
    Friend WithEvents txtCantDetCpra As TextBox
    Friend WithEvents txtNetoDetCpra As TextBox
    Friend WithEvents txtImpIntDetCpra As TextBox
    Friend WithEvents txtTotalDetCpra As TextBox
    Friend WithEvents txtSRubDetCpra As TextBox
    Friend WithEvents txtNetoCpra As TextBox
    Friend WithEvents txtImpIntCpra As TextBox
    Friend WithEvents txtTotalCpra As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents ToolTipMsg As ToolTip
End Class

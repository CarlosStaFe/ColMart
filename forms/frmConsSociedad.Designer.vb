<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsSociedad
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsSociedad))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvSociedades = New System.Windows.Forms.DataGridView()
        Me.NroSociedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombSociedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalleSociedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodPosSociedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalSociedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DptoSociedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvSociedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelSociedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailSociedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoSociedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaseSoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MartilleroSoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SociedadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.SociedadesTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.sociedadesTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvSociedades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociedadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(167, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(364, 36)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Consulta de Sociedades"
        '
        'dgvSociedades
        '
        Me.dgvSociedades.AllowUserToAddRows = False
        Me.dgvSociedades.AllowUserToDeleteRows = False
        Me.dgvSociedades.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvSociedades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSociedades.AutoGenerateColumns = False
        Me.dgvSociedades.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvSociedades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSociedades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSociedades.ColumnHeadersHeight = 40
        Me.dgvSociedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSociedades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroSociedadDataGridViewTextBoxColumn, Me.NombSociedadDataGridViewTextBoxColumn, Me.CalleSociedadDataGridViewTextBoxColumn, Me.CodPosSociedadDataGridViewTextBoxColumn, Me.LocalSociedadDataGridViewTextBoxColumn, Me.DptoSociedadDataGridViewTextBoxColumn, Me.ProvSociedadDataGridViewTextBoxColumn, Me.TelSociedadDataGridViewTextBoxColumn, Me.EmailSociedadDataGridViewTextBoxColumn, Me.EstadoSociedadDataGridViewTextBoxColumn, Me.ClaseSoc, Me.MartilleroSoc})
        Me.dgvSociedades.DataSource = Me.SociedadesBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSociedades.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvSociedades.EnableHeadersVisualStyles = False
        Me.dgvSociedades.GridColor = System.Drawing.Color.White
        Me.dgvSociedades.Location = New System.Drawing.Point(10, 113)
        Me.dgvSociedades.Name = "dgvSociedades"
        Me.dgvSociedades.ReadOnly = True
        Me.dgvSociedades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSociedades.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSociedades.Size = New System.Drawing.Size(722, 408)
        Me.dgvSociedades.TabIndex = 88
        '
        'NroSociedadDataGridViewTextBoxColumn
        '
        Me.NroSociedadDataGridViewTextBoxColumn.DataPropertyName = "NroSociedad"
        Me.NroSociedadDataGridViewTextBoxColumn.HeaderText = "NRO."
        Me.NroSociedadDataGridViewTextBoxColumn.Name = "NroSociedadDataGridViewTextBoxColumn"
        Me.NroSociedadDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroSociedadDataGridViewTextBoxColumn.Width = 50
        '
        'NombSociedadDataGridViewTextBoxColumn
        '
        Me.NombSociedadDataGridViewTextBoxColumn.DataPropertyName = "NombSociedad"
        Me.NombSociedadDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NombSociedadDataGridViewTextBoxColumn.Name = "NombSociedadDataGridViewTextBoxColumn"
        Me.NombSociedadDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombSociedadDataGridViewTextBoxColumn.Width = 200
        '
        'CalleSociedadDataGridViewTextBoxColumn
        '
        Me.CalleSociedadDataGridViewTextBoxColumn.DataPropertyName = "CalleSociedad"
        Me.CalleSociedadDataGridViewTextBoxColumn.HeaderText = "CALLE"
        Me.CalleSociedadDataGridViewTextBoxColumn.Name = "CalleSociedadDataGridViewTextBoxColumn"
        Me.CalleSociedadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CalleSociedadDataGridViewTextBoxColumn.Width = 200
        '
        'CodPosSociedadDataGridViewTextBoxColumn
        '
        Me.CodPosSociedadDataGridViewTextBoxColumn.DataPropertyName = "CodPosSociedad"
        Me.CodPosSociedadDataGridViewTextBoxColumn.HeaderText = "COD. POSTAL"
        Me.CodPosSociedadDataGridViewTextBoxColumn.Name = "CodPosSociedadDataGridViewTextBoxColumn"
        Me.CodPosSociedadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodPosSociedadDataGridViewTextBoxColumn.Width = 50
        '
        'LocalSociedadDataGridViewTextBoxColumn
        '
        Me.LocalSociedadDataGridViewTextBoxColumn.DataPropertyName = "LocalSociedad"
        Me.LocalSociedadDataGridViewTextBoxColumn.HeaderText = "LOCALIDAD"
        Me.LocalSociedadDataGridViewTextBoxColumn.Name = "LocalSociedadDataGridViewTextBoxColumn"
        Me.LocalSociedadDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocalSociedadDataGridViewTextBoxColumn.Width = 160
        '
        'DptoSociedadDataGridViewTextBoxColumn
        '
        Me.DptoSociedadDataGridViewTextBoxColumn.DataPropertyName = "DptoSociedad"
        Me.DptoSociedadDataGridViewTextBoxColumn.HeaderText = "DEPARTAMENTO"
        Me.DptoSociedadDataGridViewTextBoxColumn.Name = "DptoSociedadDataGridViewTextBoxColumn"
        Me.DptoSociedadDataGridViewTextBoxColumn.ReadOnly = True
        Me.DptoSociedadDataGridViewTextBoxColumn.Width = 150
        '
        'ProvSociedadDataGridViewTextBoxColumn
        '
        Me.ProvSociedadDataGridViewTextBoxColumn.DataPropertyName = "ProvSociedad"
        Me.ProvSociedadDataGridViewTextBoxColumn.HeaderText = "PROVINCIA"
        Me.ProvSociedadDataGridViewTextBoxColumn.Name = "ProvSociedadDataGridViewTextBoxColumn"
        Me.ProvSociedadDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProvSociedadDataGridViewTextBoxColumn.Width = 150
        '
        'TelSociedadDataGridViewTextBoxColumn
        '
        Me.TelSociedadDataGridViewTextBoxColumn.DataPropertyName = "TelSociedad"
        Me.TelSociedadDataGridViewTextBoxColumn.HeaderText = "TELÉFONO"
        Me.TelSociedadDataGridViewTextBoxColumn.Name = "TelSociedadDataGridViewTextBoxColumn"
        Me.TelSociedadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailSociedadDataGridViewTextBoxColumn
        '
        Me.EmailSociedadDataGridViewTextBoxColumn.DataPropertyName = "EmailSociedad"
        Me.EmailSociedadDataGridViewTextBoxColumn.HeaderText = "E-MAIL"
        Me.EmailSociedadDataGridViewTextBoxColumn.Name = "EmailSociedadDataGridViewTextBoxColumn"
        Me.EmailSociedadDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailSociedadDataGridViewTextBoxColumn.Width = 150
        '
        'EstadoSociedadDataGridViewTextBoxColumn
        '
        Me.EstadoSociedadDataGridViewTextBoxColumn.DataPropertyName = "EstadoSociedad"
        Me.EstadoSociedadDataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.EstadoSociedadDataGridViewTextBoxColumn.Name = "EstadoSociedadDataGridViewTextBoxColumn"
        Me.EstadoSociedadDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoSociedadDataGridViewTextBoxColumn.Width = 50
        '
        'ClaseSoc
        '
        Me.ClaseSoc.DataPropertyName = "ClaseSoc"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ClaseSoc.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClaseSoc.HeaderText = "CLASE"
        Me.ClaseSoc.Name = "ClaseSoc"
        Me.ClaseSoc.ReadOnly = True
        '
        'MartilleroSoc
        '
        Me.MartilleroSoc.DataPropertyName = "MartilleroSoc"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.MartilleroSoc.DefaultCellStyle = DataGridViewCellStyle4
        Me.MartilleroSoc.HeaderText = "MARTILLEROS"
        Me.MartilleroSoc.Name = "MartilleroSoc"
        Me.MartilleroSoc.ReadOnly = True
        '
        'SociedadesBindingSource
        '
        Me.SociedadesBindingSource.DataMember = "sociedades"
        Me.SociedadesBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SociedadesTableAdapter
        '
        Me.SociedadesTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(15, 524)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(414, 19)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Haga doble clic en el renglón seleccionado..."
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
        Me.BtnSalir.Location = New System.Drawing.Point(627, 31)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(87, 56)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(606, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(126, 78)
        Me.PictureBox2.TabIndex = 91
        Me.PictureBox2.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(184, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(378, 23)
        Me.txtNombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(48, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 17)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Nombre Sociedad:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(587, 41)
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'frmConsSociedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(781, 571)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvSociedades)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsSociedad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE SOCIEDADES"
        CType(Me.dgvSociedades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociedadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents dgvSociedades As DataGridView
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents SociedadesBindingSource As BindingSource
    Friend WithEvents SociedadesTableAdapter As dbcolmartDataSetTableAdapters.sociedadesTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NroSociedadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombSociedadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalleSociedadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodPosSociedadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalSociedadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DptoSociedadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvSociedadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelSociedadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailSociedadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoSociedadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClaseSoc As DataGridViewTextBoxColumn
    Friend WithEvents MartilleroSoc As DataGridViewTextBoxColumn
End Class

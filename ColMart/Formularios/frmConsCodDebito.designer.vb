<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsCodDebito
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsCodDebito))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtDetalleDebito = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCodDebito = New System.Windows.Forms.DataGridView()
        Me.CoddebitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CoddebitoTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.coddebitoTableAdapter()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.IdCodDebDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCodDebDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleCodDebDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteCodDebDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KgCodDebDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategCodDebDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoRecCodDeb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCodDebDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCodDebito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoddebitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDetalleDebito
        '
        Me.txtDetalleDebito.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDetalleDebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalleDebito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalleDebito.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleDebito.ForeColor = System.Drawing.Color.White
        Me.txtDetalleDebito.Location = New System.Drawing.Point(215, 57)
        Me.txtDetalleDebito.Name = "txtDetalleDebito"
        Me.txtDetalleDebito.Size = New System.Drawing.Size(323, 23)
        Me.txtDetalleDebito.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(103, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Detalle Débito:"
        '
        'dgvCodDebito
        '
        Me.dgvCodDebito.AllowUserToAddRows = False
        Me.dgvCodDebito.AllowUserToDeleteRows = False
        Me.dgvCodDebito.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCodDebito.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCodDebito.AutoGenerateColumns = False
        Me.dgvCodDebito.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvCodDebito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCodDebito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCodDebito.ColumnHeadersHeight = 30
        Me.dgvCodDebito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCodDebito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCodDebDataGridViewTextBoxColumn, Me.NroCodDebDataGridViewTextBoxColumn, Me.DetalleCodDebDataGridViewTextBoxColumn, Me.ImporteCodDebDataGridViewTextBoxColumn, Me.KgCodDebDataGridViewTextBoxColumn, Me.CategCodDebDataGridViewTextBoxColumn, Me.TipoRecCodDeb, Me.ObsCodDebDataGridViewTextBoxColumn})
        Me.dgvCodDebito.DataSource = Me.CoddebitoBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCodDebito.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCodDebito.EnableHeadersVisualStyles = False
        Me.dgvCodDebito.GridColor = System.Drawing.Color.White
        Me.dgvCodDebito.Location = New System.Drawing.Point(9, 98)
        Me.dgvCodDebito.Name = "dgvCodDebito"
        Me.dgvCodDebito.ReadOnly = True
        Me.dgvCodDebito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCodDebito.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCodDebito.Size = New System.Drawing.Size(898, 313)
        Me.dgvCodDebito.TabIndex = 4
        '
        'CoddebitoBindingSource
        '
        Me.CoddebitoBindingSource.DataMember = "coddebito"
        Me.CoddebitoBindingSource.DataSource = Me.DbcolmartDataSet
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
        Me.Label2.Location = New System.Drawing.Point(14, 416)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(414, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Haga doble clic en el renglón seleccionado..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(170, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(459, 36)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Consulta de Códigos a Debitar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(9, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(898, 39)
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'CoddebitoTableAdapter
        '
        Me.CoddebitoTableAdapter.ClearBeforeFill = True
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
        Me.BtnSalir.Location = New System.Drawing.Point(773, 429)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(57, 56)
        Me.BtnSalir.TabIndex = 92
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(758, 423)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 69)
        Me.PictureBox2.TabIndex = 93
        Me.PictureBox2.TabStop = False
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'IdCodDebDataGridViewTextBoxColumn
        '
        Me.IdCodDebDataGridViewTextBoxColumn.DataPropertyName = "id_CodDeb"
        Me.IdCodDebDataGridViewTextBoxColumn.HeaderText = "id_CodDeb"
        Me.IdCodDebDataGridViewTextBoxColumn.Name = "IdCodDebDataGridViewTextBoxColumn"
        Me.IdCodDebDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCodDebDataGridViewTextBoxColumn.Visible = False
        '
        'NroCodDebDataGridViewTextBoxColumn
        '
        Me.NroCodDebDataGridViewTextBoxColumn.DataPropertyName = "NroCodDeb"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NroCodDebDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.NroCodDebDataGridViewTextBoxColumn.HeaderText = "CÓDIGO"
        Me.NroCodDebDataGridViewTextBoxColumn.Name = "NroCodDebDataGridViewTextBoxColumn"
        Me.NroCodDebDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroCodDebDataGridViewTextBoxColumn.Width = 80
        '
        'DetalleCodDebDataGridViewTextBoxColumn
        '
        Me.DetalleCodDebDataGridViewTextBoxColumn.DataPropertyName = "DetalleCodDeb"
        Me.DetalleCodDebDataGridViewTextBoxColumn.HeaderText = "DETALLE"
        Me.DetalleCodDebDataGridViewTextBoxColumn.Name = "DetalleCodDebDataGridViewTextBoxColumn"
        Me.DetalleCodDebDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleCodDebDataGridViewTextBoxColumn.Width = 220
        '
        'ImporteCodDebDataGridViewTextBoxColumn
        '
        Me.ImporteCodDebDataGridViewTextBoxColumn.DataPropertyName = "ImporteCodDeb"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ImporteCodDebDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ImporteCodDebDataGridViewTextBoxColumn.HeaderText = "IMPORTE"
        Me.ImporteCodDebDataGridViewTextBoxColumn.Name = "ImporteCodDebDataGridViewTextBoxColumn"
        Me.ImporteCodDebDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KgCodDebDataGridViewTextBoxColumn
        '
        Me.KgCodDebDataGridViewTextBoxColumn.DataPropertyName = "KgCodDeb"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.KgCodDebDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.KgCodDebDataGridViewTextBoxColumn.HeaderText = "KILOS"
        Me.KgCodDebDataGridViewTextBoxColumn.Name = "KgCodDebDataGridViewTextBoxColumn"
        Me.KgCodDebDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategCodDebDataGridViewTextBoxColumn
        '
        Me.CategCodDebDataGridViewTextBoxColumn.DataPropertyName = "CategCodDeb"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.CategCodDebDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.CategCodDebDataGridViewTextBoxColumn.HeaderText = "CATEGORÍA"
        Me.CategCodDebDataGridViewTextBoxColumn.Name = "CategCodDebDataGridViewTextBoxColumn"
        Me.CategCodDebDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategCodDebDataGridViewTextBoxColumn.Width = 150
        '
        'TipoRecCodDeb
        '
        Me.TipoRecCodDeb.DataPropertyName = "TipoRecCodDeb"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TipoRecCodDeb.DefaultCellStyle = DataGridViewCellStyle7
        Me.TipoRecCodDeb.HeaderText = "TIPO"
        Me.TipoRecCodDeb.Name = "TipoRecCodDeb"
        Me.TipoRecCodDeb.ReadOnly = True
        Me.TipoRecCodDeb.Width = 50
        '
        'ObsCodDebDataGridViewTextBoxColumn
        '
        Me.ObsCodDebDataGridViewTextBoxColumn.DataPropertyName = "ObsCodDeb"
        Me.ObsCodDebDataGridViewTextBoxColumn.HeaderText = "OBSERVACIÓN"
        Me.ObsCodDebDataGridViewTextBoxColumn.Name = "ObsCodDebDataGridViewTextBoxColumn"
        Me.ObsCodDebDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsCodDebDataGridViewTextBoxColumn.Width = 150
        '
        'frmConsCodDebito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(955, 511)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvCodDebito)
        Me.Controls.Add(Me.txtDetalleDebito)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsCodDebito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE CÓDIGOS A DEBITAR"
        CType(Me.dgvCodDebito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoddebitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDetalleDebito As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCodDebito As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents CoddebitoBindingSource As BindingSource
    Friend WithEvents CoddebitoTableAdapter As dbcolmartDataSetTableAdapters.coddebitoTableAdapter
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents IdCodDebDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroCodDebDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleCodDebDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteCodDebDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KgCodDebDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategCodDebDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoRecCodDeb As DataGridViewTextBoxColumn
    Friend WithEvents ObsCodDebDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

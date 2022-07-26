<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsCptosGastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsCptosGastos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvCptosGastos = New System.Windows.Forms.DataGridView()
        Me.IdCGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleCGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CptosgastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.txtNombreCpto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CptosgastosTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.cptosgastosTableAdapter()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCptosGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CptosgastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnSalir.Location = New System.Drawing.Point(564, 421)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(57, 56)
        Me.BtnSalir.TabIndex = 100
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(549, 414)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 69)
        Me.PictureBox2.TabIndex = 101
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(85, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(506, 36)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Consulta de Conceptos de Gastos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(38, 414)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(414, 19)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Haga doble clic en el renglón seleccionado..."
        '
        'dgvCptosGastos
        '
        Me.dgvCptosGastos.AllowUserToAddRows = False
        Me.dgvCptosGastos.AllowUserToDeleteRows = False
        Me.dgvCptosGastos.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCptosGastos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCptosGastos.AutoGenerateColumns = False
        Me.dgvCptosGastos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvCptosGastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCptosGastos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCptosGastos.ColumnHeadersHeight = 30
        Me.dgvCptosGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCptosGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCGDataGridViewTextBoxColumn, Me.DetalleCGDataGridViewTextBoxColumn, Me.ObsCGDataGridViewTextBoxColumn})
        Me.dgvCptosGastos.DataSource = Me.CptosgastosBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCptosGastos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCptosGastos.EnableHeadersVisualStyles = False
        Me.dgvCptosGastos.GridColor = System.Drawing.Color.White
        Me.dgvCptosGastos.Location = New System.Drawing.Point(33, 96)
        Me.dgvCptosGastos.Name = "dgvCptosGastos"
        Me.dgvCptosGastos.ReadOnly = True
        Me.dgvCptosGastos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCptosGastos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCptosGastos.Size = New System.Drawing.Size(651, 313)
        Me.dgvCptosGastos.TabIndex = 96
        '
        'IdCGDataGridViewTextBoxColumn
        '
        Me.IdCGDataGridViewTextBoxColumn.DataPropertyName = "id_CG"
        Me.IdCGDataGridViewTextBoxColumn.HeaderText = "id_CG"
        Me.IdCGDataGridViewTextBoxColumn.Name = "IdCGDataGridViewTextBoxColumn"
        Me.IdCGDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCGDataGridViewTextBoxColumn.Visible = False
        '
        'DetalleCGDataGridViewTextBoxColumn
        '
        Me.DetalleCGDataGridViewTextBoxColumn.DataPropertyName = "DetalleCG"
        Me.DetalleCGDataGridViewTextBoxColumn.HeaderText = "NOMBRE DEL CONCEPTO"
        Me.DetalleCGDataGridViewTextBoxColumn.Name = "DetalleCGDataGridViewTextBoxColumn"
        Me.DetalleCGDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleCGDataGridViewTextBoxColumn.Width = 300
        '
        'ObsCGDataGridViewTextBoxColumn
        '
        Me.ObsCGDataGridViewTextBoxColumn.DataPropertyName = "ObsCG"
        Me.ObsCGDataGridViewTextBoxColumn.HeaderText = "OBSERVACIÓN"
        Me.ObsCGDataGridViewTextBoxColumn.Name = "ObsCGDataGridViewTextBoxColumn"
        Me.ObsCGDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsCGDataGridViewTextBoxColumn.Width = 300
        '
        'CptosgastosBindingSource
        '
        Me.CptosgastosBindingSource.DataMember = "cptosgastos"
        Me.CptosgastosBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNombreCpto
        '
        Me.txtNombreCpto.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombreCpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCpto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCpto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCpto.ForeColor = System.Drawing.Color.White
        Me.txtNombreCpto.Location = New System.Drawing.Point(194, 56)
        Me.txtNombreCpto.Name = "txtNombreCpto"
        Me.txtNombreCpto.Size = New System.Drawing.Size(461, 23)
        Me.txtNombreCpto.TabIndex = 95
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(52, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Nombre Concepto:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(33, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(651, 39)
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'CptosgastosTableAdapter
        '
        Me.CptosgastosTableAdapter.ClearBeforeFill = True
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'frmConsCptosGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(724, 494)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvCptosGastos)
        Me.Controls.Add(Me.txtNombreCpto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmConsCptosGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE CONCEPTOS DE GASTOS"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCptosGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CptosgastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvCptosGastos As DataGridView
    Friend WithEvents txtNombreCpto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents CptosgastosBindingSource As BindingSource
    Friend WithEvents CptosgastosTableAdapter As dbcolmartDataSetTableAdapters.cptosgastosTableAdapter
    Friend WithEvents IdCGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleCGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsCGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolTipMsg As ToolTip
End Class

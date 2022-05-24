<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLiquidarMat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLiquidarMat))
        Me.txtDesdeMat = New System.Windows.Forms.TextBox()
        Me.txtHastaMat = New System.Windows.Forms.TextBox()
        Me.cbxOS = New System.Windows.Forms.CheckBox()
        Me.cbxDM = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxDU = New System.Windows.Forms.CheckBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtYYPeriodo = New System.Windows.Forms.TextBox()
        Me.txtMMPeriodo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.BoletasTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.boletasTableAdapter()
        Me.boletasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rdbSi = New System.Windows.Forms.RadioButton()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boletasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDesdeMat
        '
        Me.txtDesdeMat.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDesdeMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesdeMat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesdeMat.ForeColor = System.Drawing.Color.White
        Me.txtDesdeMat.Location = New System.Drawing.Point(165, 96)
        Me.txtDesdeMat.MaxLength = 5
        Me.txtDesdeMat.Name = "txtDesdeMat"
        Me.txtDesdeMat.Size = New System.Drawing.Size(53, 23)
        Me.txtDesdeMat.TabIndex = 0
        '
        'txtHastaMat
        '
        Me.txtHastaMat.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtHastaMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHastaMat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHastaMat.ForeColor = System.Drawing.Color.White
        Me.txtHastaMat.Location = New System.Drawing.Point(285, 96)
        Me.txtHastaMat.MaxLength = 5
        Me.txtHastaMat.Name = "txtHastaMat"
        Me.txtHastaMat.Size = New System.Drawing.Size(53, 23)
        Me.txtHastaMat.TabIndex = 1
        '
        'cbxOS
        '
        Me.cbxOS.AutoSize = True
        Me.cbxOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxOS.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOS.ForeColor = System.Drawing.Color.White
        Me.cbxOS.Location = New System.Drawing.Point(153, 327)
        Me.cbxOS.Name = "cbxOS"
        Me.cbxOS.Size = New System.Drawing.Size(131, 21)
        Me.cbxOS.TabIndex = 5
        Me.cbxOS.Text = "OS - Obra Social"
        Me.cbxOS.UseVisualStyleBackColor = True
        '
        'cbxDM
        '
        Me.cbxDM.AutoSize = True
        Me.cbxDM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxDM.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDM.ForeColor = System.Drawing.Color.White
        Me.cbxDM.Location = New System.Drawing.Point(153, 354)
        Me.cbxDM.Name = "cbxDM"
        Me.cbxDM.Size = New System.Drawing.Size(160, 21)
        Me.cbxDM.TabIndex = 6
        Me.cbxDM.Text = "DM - Débito Mensual"
        Me.cbxDM.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(107, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(230, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta:"
        '
        'cbxDU
        '
        Me.cbxDU.AutoSize = True
        Me.cbxDU.Enabled = False
        Me.cbxDU.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDU.ForeColor = System.Drawing.Color.White
        Me.cbxDU.Location = New System.Drawing.Point(153, 381)
        Me.cbxDU.Name = "cbxDU"
        Me.cbxDU.Size = New System.Drawing.Size(141, 21)
        Me.cbxDU.TabIndex = 7
        Me.cbxDU.Text = "DU - Débito Único"
        Me.cbxDU.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcesar.FlatAppearance.BorderSize = 0
        Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcesar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.ForeColor = System.Drawing.Color.White
        Me.btnProcesar.Image = CType(resources.GetObject("btnProcesar.Image"), System.Drawing.Image)
        Me.btnProcesar.Location = New System.Drawing.Point(123, 476)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(72, 62)
        Me.btnProcesar.TabIndex = 10
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label3.Location = New System.Drawing.Point(163, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "VENCIMIENTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(221, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "YYYY:"
        '
        'dtpVencimiento
        '
        Me.dtpVencimiento.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpVencimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpVencimiento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpVencimiento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpVencimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpVencimiento.CustomFormat = "dd/MM/yyyy"
        Me.dtpVencimiento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVencimiento.Location = New System.Drawing.Point(175, 168)
        Me.dtpVencimiento.Name = "dtpVencimiento"
        Me.dtpVencimiento.Size = New System.Drawing.Size(101, 23)
        Me.dtpVencimiento.TabIndex = 2
        '
        'txtYYPeriodo
        '
        Me.txtYYPeriodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtYYPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYYPeriodo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYYPeriodo.ForeColor = System.Drawing.Color.White
        Me.txtYYPeriodo.Location = New System.Drawing.Point(267, 243)
        Me.txtYYPeriodo.Name = "txtYYPeriodo"
        Me.txtYYPeriodo.Size = New System.Drawing.Size(47, 23)
        Me.txtYYPeriodo.TabIndex = 4
        '
        'txtMMPeriodo
        '
        Me.txtMMPeriodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMMPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMMPeriodo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMMPeriodo.ForeColor = System.Drawing.Color.White
        Me.txtMMPeriodo.Location = New System.Drawing.Point(184, 243)
        Me.txtMMPeriodo.Name = "txtMMPeriodo"
        Me.txtMMPeriodo.Size = New System.Drawing.Size(30, 23)
        Me.txtMMPeriodo.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(144, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "MM:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label6.Location = New System.Drawing.Point(182, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "PERÍODO"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(85, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 66)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(85, 135)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(294, 67)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(85, 208)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(294, 68)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(85, 282)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(294, 131)
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label7.Location = New System.Drawing.Point(167, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "CATEGORIAS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label8.Location = New System.Drawing.Point(168, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 19)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "MATRÍCULAS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Green
        Me.Label9.Location = New System.Drawing.Point(35, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(407, 36)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Liquidación a Matriculados"
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
        Me.btnSalir.Location = New System.Drawing.Point(267, 479)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSalir.Size = New System.Drawing.Size(87, 56)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Location = New System.Drawing.Point(85, 470)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(294, 73)
        Me.PictureBox5.TabIndex = 89
        Me.PictureBox5.TabStop = False
        '
        'txtMsg
        '
        Me.txtMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMsg.ForeColor = System.Drawing.Color.Red
        Me.txtMsg.Location = New System.Drawing.Point(32, 550)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(388, 16)
        Me.txtMsg.TabIndex = 90
        Me.txtMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMsg.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.DocumentMapWidth = 51
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ColMart.rptBoletas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 62)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(53, 30)
        Me.ReportViewer1.TabIndex = 91
        Me.ReportViewer1.Visible = False
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BoletasTableAdapter
        '
        Me.BoletasTableAdapter.ClearBeforeFill = True
        '
        'boletasBindingSource
        '
        Me.boletasBindingSource.DataMember = "boletas"
        Me.boletasBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox6.Location = New System.Drawing.Point(85, 419)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(294, 45)
        Me.PictureBox6.TabIndex = 92
        Me.PictureBox6.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label10.Location = New System.Drawing.Point(94, 431)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 19)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "PENDIENTE?"
        '
        'rdbSi
        '
        Me.rdbSi.AutoSize = True
        Me.rdbSi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbSi.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSi.ForeColor = System.Drawing.Color.White
        Me.rdbSi.Location = New System.Drawing.Point(294, 432)
        Me.rdbSi.Name = "rdbSi"
        Me.rdbSi.Size = New System.Drawing.Size(35, 21)
        Me.rdbSi.TabIndex = 9
        Me.rdbSi.Text = "SI"
        Me.rdbSi.UseVisualStyleBackColor = True
        '
        'rdbNo
        '
        Me.rdbNo.AutoSize = True
        Me.rdbNo.Checked = True
        Me.rdbNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNo.ForeColor = System.Drawing.Color.White
        Me.rdbNo.Location = New System.Drawing.Point(214, 432)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(47, 21)
        Me.rdbNo.TabIndex = 8
        Me.rdbNo.TabStop = True
        Me.rdbNo.Text = "NO"
        Me.rdbNo.UseVisualStyleBackColor = True
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'frmLiquidarMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(504, 576)
        Me.Controls.Add(Me.rdbNo)
        Me.Controls.Add(Me.rdbSi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMMPeriodo)
        Me.Controls.Add(Me.dtpVencimiento)
        Me.Controls.Add(Me.txtYYPeriodo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.cbxDU)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxDM)
        Me.Controls.Add(Me.cbxOS)
        Me.Controls.Add(Me.txtHastaMat)
        Me.Controls.Add(Me.txtDesdeMat)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLiquidarMat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIQUIDACIÓN BOLETAS MATRICULADOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boletasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDesdeMat As TextBox
    Friend WithEvents txtHastaMat As TextBox
    Friend WithEvents cbxOS As CheckBox
    Friend WithEvents cbxDM As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxDU As CheckBox
    Friend WithEvents btnProcesar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpVencimiento As DateTimePicker
    Friend WithEvents txtYYPeriodo As TextBox
    Friend WithEvents txtMMPeriodo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txtMsg As TextBox
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents BoletasTableAdapter As dbcolmartDataSetTableAdapters.boletasTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents boletasBindingSource As BindingSource
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents rdbSi As RadioButton
    Friend WithEvents rdbNo As RadioButton
    Friend WithEvents ToolTipMsg As ToolTip
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMesaEntrada
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
        Dim FechaMELabel As System.Windows.Forms.Label
        Dim HoraMELabel As System.Windows.Forms.Label
        Dim lblNroIngreso As System.Windows.Forms.Label
        Dim lblDeQuien As System.Windows.Forms.Label
        Dim lblNroSalida As System.Windows.Forms.Label
        Dim lblAquien As System.Windows.Forms.Label
        Dim MatriMELabel As System.Windows.Forms.Label
        Dim AsuntoMELabel As System.Windows.Forms.Label
        Dim ReferidoMELabel As System.Windows.Forms.Label
        Dim MatriRefMELabel As System.Windows.Forms.Label
        Dim ActorMELabel As System.Windows.Forms.Label
        Dim DemandadoMELabel As System.Windows.Forms.Label
        Dim SobreMELabel As System.Windows.Forms.Label
        Dim ExpedienteMELabel As System.Windows.Forms.Label
        Dim JuzgadoMELabel As System.Windows.Forms.Label
        Dim CertJudMELabel As System.Windows.Forms.Label
        Dim NoJudicialMELabel As System.Windows.Forms.Label
        Dim NotaMELabel As System.Windows.Forms.Label
        Dim BienesSubastaMELabel As System.Windows.Forms.Label
        Dim DiaSemanaMELabel As System.Windows.Forms.Label
        Dim DdMELabel As System.Windows.Forms.Label
        Dim MmMELabel As System.Windows.Forms.Label
        Dim YyyyMELabel As System.Windows.Forms.Label
        Dim HoraSubastaMELabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMesaEntrada))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.MesaentradaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MesaentradaTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.mesaentradaTableAdapter()
        Me.TableAdapterManager = New ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager()
        Me.MesaentradaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MesaentradaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtId_ME = New System.Windows.Forms.TextBox()
        Me.dtpFechaME = New System.Windows.Forms.DateTimePicker()
        Me.txtHoraME = New System.Windows.Forms.TextBox()
        Me.txtNroIngresoME = New System.Windows.Forms.TextBox()
        Me.txtDeME = New System.Windows.Forms.TextBox()
        Me.txtNroSalidaME = New System.Windows.Forms.TextBox()
        Me.txtAquienME = New System.Windows.Forms.TextBox()
        Me.txtMatriME = New System.Windows.Forms.TextBox()
        Me.txtAsuntoME = New System.Windows.Forms.TextBox()
        Me.ChbDelegacion = New System.Windows.Forms.CheckBox()
        Me.txtReferidoME = New System.Windows.Forms.TextBox()
        Me.txtMatriRefME = New System.Windows.Forms.TextBox()
        Me.txtActorME = New System.Windows.Forms.TextBox()
        Me.txtDemandadoME = New System.Windows.Forms.TextBox()
        Me.txtSobreME = New System.Windows.Forms.TextBox()
        Me.txtExpedienteME = New System.Windows.Forms.TextBox()
        Me.txtJuzgadoME = New System.Windows.Forms.TextBox()
        Me.txtCertJudME = New System.Windows.Forms.TextBox()
        Me.txtNoJudicialME = New System.Windows.Forms.TextBox()
        Me.txtNotaME = New System.Windows.Forms.TextBox()
        Me.txtBienesSubastaME = New System.Windows.Forms.TextBox()
        Me.txtDdME = New System.Windows.Forms.TextBox()
        Me.txtYyyyME = New System.Windows.Forms.TextBox()
        Me.txtHoraSubastaME = New System.Windows.Forms.TextBox()
        Me.cbxIngresoEgreso = New System.Windows.Forms.ComboBox()
        Me.cbxDiaSemana = New System.Windows.Forms.ComboBox()
        Me.cbxMes = New System.Windows.Forms.ComboBox()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.picImagenME = New System.Windows.Forms.PictureBox()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtOrigenIMG = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        FechaMELabel = New System.Windows.Forms.Label()
        HoraMELabel = New System.Windows.Forms.Label()
        lblNroIngreso = New System.Windows.Forms.Label()
        lblDeQuien = New System.Windows.Forms.Label()
        lblNroSalida = New System.Windows.Forms.Label()
        lblAquien = New System.Windows.Forms.Label()
        MatriMELabel = New System.Windows.Forms.Label()
        AsuntoMELabel = New System.Windows.Forms.Label()
        ReferidoMELabel = New System.Windows.Forms.Label()
        MatriRefMELabel = New System.Windows.Forms.Label()
        ActorMELabel = New System.Windows.Forms.Label()
        DemandadoMELabel = New System.Windows.Forms.Label()
        SobreMELabel = New System.Windows.Forms.Label()
        ExpedienteMELabel = New System.Windows.Forms.Label()
        JuzgadoMELabel = New System.Windows.Forms.Label()
        CertJudMELabel = New System.Windows.Forms.Label()
        NoJudicialMELabel = New System.Windows.Forms.Label()
        NotaMELabel = New System.Windows.Forms.Label()
        BienesSubastaMELabel = New System.Windows.Forms.Label()
        DiaSemanaMELabel = New System.Windows.Forms.Label()
        DdMELabel = New System.Windows.Forms.Label()
        MmMELabel = New System.Windows.Forms.Label()
        YyyyMELabel = New System.Windows.Forms.Label()
        HoraSubastaMELabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesaentradaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesaentradaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MesaentradaBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagenME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaMELabel
        '
        FechaMELabel.AutoSize = True
        FechaMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaMELabel.ForeColor = System.Drawing.Color.White
        FechaMELabel.Location = New System.Drawing.Point(91, 74)
        FechaMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaMELabel.Name = "FechaMELabel"
        FechaMELabel.Size = New System.Drawing.Size(51, 17)
        FechaMELabel.TabIndex = 95
        FechaMELabel.Text = "Fecha:"
        '
        'HoraMELabel
        '
        HoraMELabel.AutoSize = True
        HoraMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HoraMELabel.ForeColor = System.Drawing.Color.White
        HoraMELabel.Location = New System.Drawing.Point(269, 74)
        HoraMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HoraMELabel.Name = "HoraMELabel"
        HoraMELabel.Size = New System.Drawing.Size(43, 17)
        HoraMELabel.TabIndex = 97
        HoraMELabel.Text = "Hora:"
        '
        'lblNroIngreso
        '
        lblNroIngreso.AutoSize = True
        lblNroIngreso.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblNroIngreso.ForeColor = System.Drawing.Color.White
        lblNroIngreso.Location = New System.Drawing.Point(400, 74)
        lblNroIngreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblNroIngreso.Name = "lblNroIngreso"
        lblNroIngreso.Size = New System.Drawing.Size(89, 17)
        lblNroIngreso.TabIndex = 99
        lblNroIngreso.Text = "Nro. Ingreso:"
        '
        'lblDeQuien
        '
        lblDeQuien.AutoSize = True
        lblDeQuien.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDeQuien.ForeColor = System.Drawing.Color.White
        lblDeQuien.Location = New System.Drawing.Point(72, 104)
        lblDeQuien.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblDeQuien.Name = "lblDeQuien"
        lblDeQuien.Size = New System.Drawing.Size(70, 17)
        lblDeQuien.TabIndex = 101
        lblDeQuien.Text = "De quien:"
        '
        'lblNroSalida
        '
        lblNroSalida.AutoSize = True
        lblNroSalida.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblNroSalida.ForeColor = System.Drawing.Color.White
        lblNroSalida.Location = New System.Drawing.Point(577, 74)
        lblNroSalida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblNroSalida.Name = "lblNroSalida"
        lblNroSalida.Size = New System.Drawing.Size(82, 17)
        lblNroSalida.TabIndex = 103
        lblNroSalida.Text = "Nro. Salida:"
        '
        'lblAquien
        '
        lblAquien.AutoSize = True
        lblAquien.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAquien.ForeColor = System.Drawing.Color.White
        lblAquien.Location = New System.Drawing.Point(81, 136)
        lblAquien.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblAquien.Name = "lblAquien"
        lblAquien.Size = New System.Drawing.Size(61, 17)
        lblAquien.TabIndex = 105
        lblAquien.Text = "A quien:"
        '
        'MatriMELabel
        '
        MatriMELabel.AutoSize = True
        MatriMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriMELabel.ForeColor = System.Drawing.Color.White
        MatriMELabel.Location = New System.Drawing.Point(566, 105)
        MatriMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MatriMELabel.Name = "MatriMELabel"
        MatriMELabel.Size = New System.Drawing.Size(72, 17)
        MatriMELabel.TabIndex = 107
        MatriMELabel.Text = "Matrícula:"
        '
        'AsuntoMELabel
        '
        AsuntoMELabel.AutoSize = True
        AsuntoMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AsuntoMELabel.ForeColor = System.Drawing.Color.White
        AsuntoMELabel.Location = New System.Drawing.Point(86, 169)
        AsuntoMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AsuntoMELabel.Name = "AsuntoMELabel"
        AsuntoMELabel.Size = New System.Drawing.Size(56, 17)
        AsuntoMELabel.TabIndex = 109
        AsuntoMELabel.Text = "Asunto:"
        '
        'ReferidoMELabel
        '
        ReferidoMELabel.AutoSize = True
        ReferidoMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReferidoMELabel.ForeColor = System.Drawing.Color.White
        ReferidoMELabel.Location = New System.Drawing.Point(77, 200)
        ReferidoMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ReferidoMELabel.Name = "ReferidoMELabel"
        ReferidoMELabel.Size = New System.Drawing.Size(65, 17)
        ReferidoMELabel.TabIndex = 113
        ReferidoMELabel.Text = "Referido:"
        '
        'MatriRefMELabel
        '
        MatriRefMELabel.AutoSize = True
        MatriRefMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriRefMELabel.ForeColor = System.Drawing.Color.White
        MatriRefMELabel.Location = New System.Drawing.Point(44, 230)
        MatriRefMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MatriRefMELabel.Name = "MatriRefMELabel"
        MatriRefMELabel.Size = New System.Drawing.Size(98, 17)
        MatriRefMELabel.TabIndex = 115
        MatriRefMELabel.Text = "Mat. Referido:"
        '
        'ActorMELabel
        '
        ActorMELabel.AutoSize = True
        ActorMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ActorMELabel.ForeColor = System.Drawing.Color.White
        ActorMELabel.Location = New System.Drawing.Point(232, 230)
        ActorMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ActorMELabel.Name = "ActorMELabel"
        ActorMELabel.Size = New System.Drawing.Size(47, 17)
        ActorMELabel.TabIndex = 117
        ActorMELabel.Text = "Actor:"
        '
        'DemandadoMELabel
        '
        DemandadoMELabel.AutoSize = True
        DemandadoMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DemandadoMELabel.ForeColor = System.Drawing.Color.White
        DemandadoMELabel.Location = New System.Drawing.Point(46, 260)
        DemandadoMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DemandadoMELabel.Name = "DemandadoMELabel"
        DemandadoMELabel.Size = New System.Drawing.Size(96, 17)
        DemandadoMELabel.TabIndex = 119
        DemandadoMELabel.Text = "Demandado:"
        '
        'SobreMELabel
        '
        SobreMELabel.AutoSize = True
        SobreMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SobreMELabel.ForeColor = System.Drawing.Color.White
        SobreMELabel.Location = New System.Drawing.Point(94, 292)
        SobreMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SobreMELabel.Name = "SobreMELabel"
        SobreMELabel.Size = New System.Drawing.Size(48, 17)
        SobreMELabel.TabIndex = 121
        SobreMELabel.Text = "Sobre:"
        '
        'ExpedienteMELabel
        '
        ExpedienteMELabel.AutoSize = True
        ExpedienteMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ExpedienteMELabel.ForeColor = System.Drawing.Color.White
        ExpedienteMELabel.Location = New System.Drawing.Point(59, 323)
        ExpedienteMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ExpedienteMELabel.Name = "ExpedienteMELabel"
        ExpedienteMELabel.Size = New System.Drawing.Size(83, 17)
        ExpedienteMELabel.TabIndex = 123
        ExpedienteMELabel.Text = "Expediente:"
        '
        'JuzgadoMELabel
        '
        JuzgadoMELabel.AutoSize = True
        JuzgadoMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JuzgadoMELabel.ForeColor = System.Drawing.Color.White
        JuzgadoMELabel.Location = New System.Drawing.Point(74, 354)
        JuzgadoMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        JuzgadoMELabel.Name = "JuzgadoMELabel"
        JuzgadoMELabel.Size = New System.Drawing.Size(68, 17)
        JuzgadoMELabel.TabIndex = 125
        JuzgadoMELabel.Text = "Juzgado:"
        '
        'CertJudMELabel
        '
        CertJudMELabel.AutoSize = True
        CertJudMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CertJudMELabel.ForeColor = System.Drawing.Color.White
        CertJudMELabel.Location = New System.Drawing.Point(38, 384)
        CertJudMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CertJudMELabel.Name = "CertJudMELabel"
        CertJudMELabel.Size = New System.Drawing.Size(104, 17)
        CertJudMELabel.TabIndex = 127
        CertJudMELabel.Text = "Certif. Judicial:"
        '
        'NoJudicialMELabel
        '
        NoJudicialMELabel.AutoSize = True
        NoJudicialMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoJudicialMELabel.ForeColor = System.Drawing.Color.White
        NoJudicialMELabel.Location = New System.Drawing.Point(58, 415)
        NoJudicialMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NoJudicialMELabel.Name = "NoJudicialMELabel"
        NoJudicialMELabel.Size = New System.Drawing.Size(84, 17)
        NoJudicialMELabel.TabIndex = 129
        NoJudicialMELabel.Text = "No Judicial:"
        '
        'NotaMELabel
        '
        NotaMELabel.AutoSize = True
        NotaMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotaMELabel.ForeColor = System.Drawing.Color.White
        NotaMELabel.Location = New System.Drawing.Point(97, 447)
        NotaMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NotaMELabel.Name = "NotaMELabel"
        NotaMELabel.Size = New System.Drawing.Size(45, 17)
        NotaMELabel.TabIndex = 131
        NotaMELabel.Text = "Nota:"
        '
        'BienesSubastaMELabel
        '
        BienesSubastaMELabel.AutoSize = True
        BienesSubastaMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BienesSubastaMELabel.ForeColor = System.Drawing.Color.White
        BienesSubastaMELabel.Location = New System.Drawing.Point(19, 477)
        BienesSubastaMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BienesSubastaMELabel.Name = "BienesSubastaMELabel"
        BienesSubastaMELabel.Size = New System.Drawing.Size(123, 17)
        BienesSubastaMELabel.TabIndex = 133
        BienesSubastaMELabel.Text = "Bienes a Subastar:"
        '
        'DiaSemanaMELabel
        '
        DiaSemanaMELabel.AutoSize = True
        DiaSemanaMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DiaSemanaMELabel.ForeColor = System.Drawing.Color.White
        DiaSemanaMELabel.Location = New System.Drawing.Point(51, 509)
        DiaSemanaMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DiaSemanaMELabel.Name = "DiaSemanaMELabel"
        DiaSemanaMELabel.Size = New System.Drawing.Size(91, 17)
        DiaSemanaMELabel.TabIndex = 135
        DiaSemanaMELabel.Text = "Día Semana:"
        '
        'DdMELabel
        '
        DdMELabel.AutoSize = True
        DdMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DdMELabel.ForeColor = System.Drawing.Color.White
        DdMELabel.Location = New System.Drawing.Point(288, 509)
        DdMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DdMELabel.Name = "DdMELabel"
        DdMELabel.Size = New System.Drawing.Size(34, 17)
        DdMELabel.TabIndex = 137
        DdMELabel.Text = "Día:"
        '
        'MmMELabel
        '
        MmMELabel.AutoSize = True
        MmMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MmMELabel.ForeColor = System.Drawing.Color.White
        MmMELabel.Location = New System.Drawing.Point(383, 508)
        MmMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MmMELabel.Name = "MmMELabel"
        MmMELabel.Size = New System.Drawing.Size(36, 17)
        MmMELabel.TabIndex = 139
        MmMELabel.Text = "Mes:"
        '
        'YyyyMELabel
        '
        YyyyMELabel.AutoSize = True
        YyyyMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        YyyyMELabel.ForeColor = System.Drawing.Color.White
        YyyyMELabel.Location = New System.Drawing.Point(569, 509)
        YyyyMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        YyyyMELabel.Name = "YyyyMELabel"
        YyyyMELabel.Size = New System.Drawing.Size(38, 17)
        YyyyMELabel.TabIndex = 141
        YyyyMELabel.Text = "Año:"
        '
        'HoraSubastaMELabel
        '
        HoraSubastaMELabel.AutoSize = True
        HoraSubastaMELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HoraSubastaMELabel.ForeColor = System.Drawing.Color.White
        HoraSubastaMELabel.Location = New System.Drawing.Point(676, 508)
        HoraSubastaMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HoraSubastaMELabel.Name = "HoraSubastaMELabel"
        HoraSubastaMELabel.Size = New System.Drawing.Size(98, 17)
        HoraSubastaMELabel.TabIndex = 143
        HoraSubastaMELabel.Text = "Hora Subasta:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(13, 16)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(38, 17)
        Label1.TabIndex = 147
        Label1.Text = "Tipo:"
        Label1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(367, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(423, 36)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Actualizar Mesa de Entradas"
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MesaentradaBindingSource
        '
        Me.MesaentradaBindingSource.DataMember = "mesaentrada"
        Me.MesaentradaBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'MesaentradaTableAdapter
        '
        Me.MesaentradaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ctactematTableAdapter = Nothing
        Me.TableAdapterManager.ctacteprovTableAdapter = Nothing
        Me.TableAdapterManager.ctactesocTableAdapter = Nothing
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
        Me.TableAdapterManager.mesaentradaTableAdapter = Me.MesaentradaTableAdapter
        Me.TableAdapterManager.nivelesTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.renglonesTableAdapter = Nothing
        Me.TableAdapterManager.saldomatTableAdapter = Nothing
        Me.TableAdapterManager.saldosocTableAdapter = Nothing
        Me.TableAdapterManager.sociedadesTableAdapter = Nothing
        Me.TableAdapterManager.tribunalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'MesaentradaBindingNavigator
        '
        Me.MesaentradaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MesaentradaBindingNavigator.BindingSource = Me.MesaentradaBindingSource
        Me.MesaentradaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MesaentradaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MesaentradaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MesaentradaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MesaentradaBindingNavigatorSaveItem})
        Me.MesaentradaBindingNavigator.Location = New System.Drawing.Point(0, 643)
        Me.MesaentradaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MesaentradaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MesaentradaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MesaentradaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MesaentradaBindingNavigator.Name = "MesaentradaBindingNavigator"
        Me.MesaentradaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MesaentradaBindingNavigator.Size = New System.Drawing.Size(1212, 25)
        Me.MesaentradaBindingNavigator.TabIndex = 93
        Me.MesaentradaBindingNavigator.Text = "BindingNavigator1"
        Me.MesaentradaBindingNavigator.Visible = False
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 23)
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
        'MesaentradaBindingNavigatorSaveItem
        '
        Me.MesaentradaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MesaentradaBindingNavigatorSaveItem.Image = CType(resources.GetObject("MesaentradaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MesaentradaBindingNavigatorSaveItem.Name = "MesaentradaBindingNavigatorSaveItem"
        Me.MesaentradaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MesaentradaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'txtId_ME
        '
        Me.txtId_ME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_ME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_ME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "id_ME", True))
        Me.txtId_ME.Enabled = False
        Me.txtId_ME.ForeColor = System.Drawing.Color.White
        Me.txtId_ME.Location = New System.Drawing.Point(772, 74)
        Me.txtId_ME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId_ME.Name = "txtId_ME"
        Me.txtId_ME.Size = New System.Drawing.Size(61, 16)
        Me.txtId_ME.TabIndex = 5
        '
        'dtpFechaME
        '
        Me.dtpFechaME.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpFechaME.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpFechaME.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpFechaME.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpFechaME.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaME.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaME.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MesaentradaBindingSource, "FechaME", True))
        Me.dtpFechaME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaME.Location = New System.Drawing.Point(150, 71)
        Me.dtpFechaME.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaME.Name = "dtpFechaME"
        Me.dtpFechaME.Size = New System.Drawing.Size(109, 23)
        Me.dtpFechaME.TabIndex = 0
        '
        'txtHoraME
        '
        Me.txtHoraME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtHoraME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoraME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "HoraME", True))
        Me.txtHoraME.ForeColor = System.Drawing.Color.White
        Me.txtHoraME.Location = New System.Drawing.Point(320, 71)
        Me.txtHoraME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoraME.Name = "txtHoraME"
        Me.txtHoraME.Size = New System.Drawing.Size(63, 23)
        Me.txtHoraME.TabIndex = 1
        '
        'txtNroIngresoME
        '
        Me.txtNroIngresoME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroIngresoME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroIngresoME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "NroIngresoME", True))
        Me.txtNroIngresoME.ForeColor = System.Drawing.Color.White
        Me.txtNroIngresoME.Location = New System.Drawing.Point(497, 71)
        Me.txtNroIngresoME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroIngresoME.Name = "txtNroIngresoME"
        Me.txtNroIngresoME.Size = New System.Drawing.Size(72, 23)
        Me.txtNroIngresoME.TabIndex = 3
        '
        'txtDeME
        '
        Me.txtDeME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDeME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDeME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "DeME", True))
        Me.txtDeME.ForeColor = System.Drawing.Color.White
        Me.txtDeME.Location = New System.Drawing.Point(150, 102)
        Me.txtDeME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeME.Name = "txtDeME"
        Me.txtDeME.Size = New System.Drawing.Size(408, 23)
        Me.txtDeME.TabIndex = 5
        '
        'txtNroSalidaME
        '
        Me.txtNroSalidaME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroSalidaME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroSalidaME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "NroSalidaME", True))
        Me.txtNroSalidaME.ForeColor = System.Drawing.Color.White
        Me.txtNroSalidaME.Location = New System.Drawing.Point(667, 71)
        Me.txtNroSalidaME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroSalidaME.Name = "txtNroSalidaME"
        Me.txtNroSalidaME.Size = New System.Drawing.Size(72, 23)
        Me.txtNroSalidaME.TabIndex = 4
        '
        'txtAquienME
        '
        Me.txtAquienME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtAquienME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAquienME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "AquienME", True))
        Me.txtAquienME.ForeColor = System.Drawing.Color.White
        Me.txtAquienME.Location = New System.Drawing.Point(150, 133)
        Me.txtAquienME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAquienME.Name = "txtAquienME"
        Me.txtAquienME.Size = New System.Drawing.Size(408, 23)
        Me.txtAquienME.TabIndex = 8
        '
        'txtMatriME
        '
        Me.txtMatriME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMatriME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMatriME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "MatriME", True))
        Me.txtMatriME.ForeColor = System.Drawing.Color.White
        Me.txtMatriME.Location = New System.Drawing.Point(646, 102)
        Me.txtMatriME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMatriME.Name = "txtMatriME"
        Me.txtMatriME.Size = New System.Drawing.Size(71, 23)
        Me.txtMatriME.TabIndex = 6
        '
        'txtAsuntoME
        '
        Me.txtAsuntoME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtAsuntoME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsuntoME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "AsuntoME", True))
        Me.txtAsuntoME.ForeColor = System.Drawing.Color.White
        Me.txtAsuntoME.Location = New System.Drawing.Point(150, 165)
        Me.txtAsuntoME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAsuntoME.Multiline = True
        Me.txtAsuntoME.Name = "txtAsuntoME"
        Me.txtAsuntoME.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAsuntoME.Size = New System.Drawing.Size(683, 23)
        Me.txtAsuntoME.TabIndex = 9
        '
        'ChbDelegacion
        '
        Me.ChbDelegacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChbDelegacion.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MesaentradaBindingSource, "DelegacionME", True))
        Me.ChbDelegacion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbDelegacion.ForeColor = System.Drawing.Color.White
        Me.ChbDelegacion.Location = New System.Drawing.Point(729, 98)
        Me.ChbDelegacion.Margin = New System.Windows.Forms.Padding(4)
        Me.ChbDelegacion.Name = "ChbDelegacion"
        Me.ChbDelegacion.Size = New System.Drawing.Size(105, 31)
        Me.ChbDelegacion.TabIndex = 7
        Me.ChbDelegacion.Text = "Delegación"
        Me.ChbDelegacion.UseVisualStyleBackColor = True
        '
        'txtReferidoME
        '
        Me.txtReferidoME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtReferidoME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReferidoME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "ReferidoME", True))
        Me.txtReferidoME.ForeColor = System.Drawing.Color.White
        Me.txtReferidoME.Location = New System.Drawing.Point(150, 196)
        Me.txtReferidoME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReferidoME.Name = "txtReferidoME"
        Me.txtReferidoME.Size = New System.Drawing.Size(683, 23)
        Me.txtReferidoME.TabIndex = 10
        '
        'txtMatriRefME
        '
        Me.txtMatriRefME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMatriRefME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMatriRefME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "MatriRefME", True))
        Me.txtMatriRefME.ForeColor = System.Drawing.Color.White
        Me.txtMatriRefME.Location = New System.Drawing.Point(150, 227)
        Me.txtMatriRefME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMatriRefME.Name = "txtMatriRefME"
        Me.txtMatriRefME.Size = New System.Drawing.Size(67, 23)
        Me.txtMatriRefME.TabIndex = 11
        '
        'txtActorME
        '
        Me.txtActorME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtActorME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtActorME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "ActorME", True))
        Me.txtActorME.ForeColor = System.Drawing.Color.White
        Me.txtActorME.Location = New System.Drawing.Point(287, 227)
        Me.txtActorME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtActorME.Name = "txtActorME"
        Me.txtActorME.Size = New System.Drawing.Size(546, 23)
        Me.txtActorME.TabIndex = 12
        '
        'txtDemandadoME
        '
        Me.txtDemandadoME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDemandadoME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDemandadoME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "DemandadoME", True))
        Me.txtDemandadoME.ForeColor = System.Drawing.Color.White
        Me.txtDemandadoME.Location = New System.Drawing.Point(150, 258)
        Me.txtDemandadoME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDemandadoME.Name = "txtDemandadoME"
        Me.txtDemandadoME.Size = New System.Drawing.Size(683, 23)
        Me.txtDemandadoME.TabIndex = 13
        '
        'txtSobreME
        '
        Me.txtSobreME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSobreME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSobreME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "SobreME", True))
        Me.txtSobreME.ForeColor = System.Drawing.Color.White
        Me.txtSobreME.Location = New System.Drawing.Point(150, 289)
        Me.txtSobreME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSobreME.Name = "txtSobreME"
        Me.txtSobreME.Size = New System.Drawing.Size(683, 23)
        Me.txtSobreME.TabIndex = 14
        '
        'txtExpedienteME
        '
        Me.txtExpedienteME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtExpedienteME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExpedienteME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "ExpedienteME", True))
        Me.txtExpedienteME.ForeColor = System.Drawing.Color.White
        Me.txtExpedienteME.Location = New System.Drawing.Point(150, 320)
        Me.txtExpedienteME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExpedienteME.Name = "txtExpedienteME"
        Me.txtExpedienteME.Size = New System.Drawing.Size(683, 23)
        Me.txtExpedienteME.TabIndex = 15
        '
        'txtJuzgadoME
        '
        Me.txtJuzgadoME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtJuzgadoME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJuzgadoME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "JuzgadoME", True))
        Me.txtJuzgadoME.ForeColor = System.Drawing.Color.White
        Me.txtJuzgadoME.Location = New System.Drawing.Point(150, 351)
        Me.txtJuzgadoME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJuzgadoME.Name = "txtJuzgadoME"
        Me.txtJuzgadoME.Size = New System.Drawing.Size(683, 23)
        Me.txtJuzgadoME.TabIndex = 16
        '
        'txtCertJudME
        '
        Me.txtCertJudME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCertJudME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCertJudME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "CertJudME", True))
        Me.txtCertJudME.ForeColor = System.Drawing.Color.White
        Me.txtCertJudME.Location = New System.Drawing.Point(150, 382)
        Me.txtCertJudME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCertJudME.Name = "txtCertJudME"
        Me.txtCertJudME.Size = New System.Drawing.Size(683, 23)
        Me.txtCertJudME.TabIndex = 17
        '
        'txtNoJudicialME
        '
        Me.txtNoJudicialME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNoJudicialME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoJudicialME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "NoJudicialME", True))
        Me.txtNoJudicialME.ForeColor = System.Drawing.Color.White
        Me.txtNoJudicialME.Location = New System.Drawing.Point(150, 413)
        Me.txtNoJudicialME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoJudicialME.Name = "txtNoJudicialME"
        Me.txtNoJudicialME.Size = New System.Drawing.Size(683, 23)
        Me.txtNoJudicialME.TabIndex = 18
        '
        'txtNotaME
        '
        Me.txtNotaME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNotaME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNotaME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "NotaME", True))
        Me.txtNotaME.ForeColor = System.Drawing.Color.White
        Me.txtNotaME.Location = New System.Drawing.Point(150, 444)
        Me.txtNotaME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNotaME.Multiline = True
        Me.txtNotaME.Name = "txtNotaME"
        Me.txtNotaME.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotaME.Size = New System.Drawing.Size(683, 23)
        Me.txtNotaME.TabIndex = 19
        '
        'txtBienesSubastaME
        '
        Me.txtBienesSubastaME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtBienesSubastaME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBienesSubastaME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "BienesSubastaME", True))
        Me.txtBienesSubastaME.ForeColor = System.Drawing.Color.White
        Me.txtBienesSubastaME.Location = New System.Drawing.Point(150, 475)
        Me.txtBienesSubastaME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBienesSubastaME.Multiline = True
        Me.txtBienesSubastaME.Name = "txtBienesSubastaME"
        Me.txtBienesSubastaME.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBienesSubastaME.Size = New System.Drawing.Size(683, 23)
        Me.txtBienesSubastaME.TabIndex = 20
        '
        'txtDdME
        '
        Me.txtDdME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDdME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDdME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "ddME", True))
        Me.txtDdME.ForeColor = System.Drawing.Color.White
        Me.txtDdME.Location = New System.Drawing.Point(330, 507)
        Me.txtDdME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDdME.Name = "txtDdME"
        Me.txtDdME.Size = New System.Drawing.Size(47, 23)
        Me.txtDdME.TabIndex = 22
        '
        'txtYyyyME
        '
        Me.txtYyyyME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtYyyyME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYyyyME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "yyyyME", True))
        Me.txtYyyyME.ForeColor = System.Drawing.Color.White
        Me.txtYyyyME.Location = New System.Drawing.Point(615, 506)
        Me.txtYyyyME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYyyyME.Name = "txtYyyyME"
        Me.txtYyyyME.Size = New System.Drawing.Size(54, 23)
        Me.txtYyyyME.TabIndex = 24
        '
        'txtHoraSubastaME
        '
        Me.txtHoraSubastaME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtHoraSubastaME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoraSubastaME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "HoraSubastaME", True))
        Me.txtHoraSubastaME.ForeColor = System.Drawing.Color.White
        Me.txtHoraSubastaME.Location = New System.Drawing.Point(782, 505)
        Me.txtHoraSubastaME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoraSubastaME.Name = "txtHoraSubastaME"
        Me.txtHoraSubastaME.Size = New System.Drawing.Size(52, 23)
        Me.txtHoraSubastaME.TabIndex = 25
        '
        'cbxIngresoEgreso
        '
        Me.cbxIngresoEgreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cbxIngresoEgreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxIngresoEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxIngresoEgreso.ForeColor = System.Drawing.Color.White
        Me.cbxIngresoEgreso.FormattingEnabled = True
        Me.cbxIngresoEgreso.Items.AddRange(New Object() {"INGRESO", "EGRESO"})
        Me.cbxIngresoEgreso.Location = New System.Drawing.Point(58, 12)
        Me.cbxIngresoEgreso.Name = "cbxIngresoEgreso"
        Me.cbxIngresoEgreso.Size = New System.Drawing.Size(121, 25)
        Me.cbxIngresoEgreso.TabIndex = 2
        Me.cbxIngresoEgreso.Visible = False
        '
        'cbxDiaSemana
        '
        Me.cbxDiaSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cbxDiaSemana.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxDiaSemana.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "DiaSemanaME", True))
        Me.cbxDiaSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxDiaSemana.ForeColor = System.Drawing.Color.White
        Me.cbxDiaSemana.FormattingEnabled = True
        Me.cbxDiaSemana.Items.AddRange(New Object() {"LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO", "DOMINGO"})
        Me.cbxDiaSemana.Location = New System.Drawing.Point(150, 505)
        Me.cbxDiaSemana.Name = "cbxDiaSemana"
        Me.cbxDiaSemana.Size = New System.Drawing.Size(133, 25)
        Me.cbxDiaSemana.TabIndex = 21
        '
        'cbxMes
        '
        Me.cbxMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cbxMes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxMes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesaentradaBindingSource, "mmME", True))
        Me.cbxMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxMes.ForeColor = System.Drawing.Color.White
        Me.cbxMes.FormattingEnabled = True
        Me.cbxMes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cbxMes.Location = New System.Drawing.Point(426, 505)
        Me.cbxMes.Name = "cbxMes"
        Me.cbxMes.Size = New System.Drawing.Size(137, 25)
        Me.cbxMes.TabIndex = 23
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
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
        Me.BtnUltimo.Location = New System.Drawing.Point(181, 567)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnUltimo.Size = New System.Drawing.Size(38, 38)
        Me.BtnUltimo.TabIndex = 37
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
        Me.BtnPrimer.Location = New System.Drawing.Point(25, 567)
        Me.BtnPrimer.Name = "BtnPrimer"
        Me.BtnPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPrimer.Size = New System.Drawing.Size(38, 38)
        Me.BtnPrimer.TabIndex = 34
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
        Me.BtnSiguiente.Location = New System.Drawing.Point(129, 567)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSiguiente.Size = New System.Drawing.Size(38, 38)
        Me.BtnSiguiente.TabIndex = 36
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
        Me.BtnAnterior.Location = New System.Drawing.Point(77, 567)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAnterior.Size = New System.Drawing.Size(38, 38)
        Me.BtnAnterior.TabIndex = 35
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
        Me.BtnActualizar.Location = New System.Drawing.Point(659, 560)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnActualizar.Size = New System.Drawing.Size(87, 56)
        Me.BtnActualizar.TabIndex = 32
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
        Me.BtnGrabar.Location = New System.Drawing.Point(336, 560)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGrabar.Size = New System.Drawing.Size(59, 56)
        Me.BtnGrabar.TabIndex = 27
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
        Me.BtnSalir.Location = New System.Drawing.Point(780, 560)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(52, 56)
        Me.BtnSalir.TabIndex = 33
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
        Me.BtnModificar.Location = New System.Drawing.Point(408, 560)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnModificar.Size = New System.Drawing.Size(80, 56)
        Me.BtnModificar.TabIndex = 29
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
        Me.BtnEliminar.Location = New System.Drawing.Point(501, 560)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEliminar.Size = New System.Drawing.Size(73, 56)
        Me.BtnEliminar.TabIndex = 30
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
        Me.BtnBuscar.Location = New System.Drawing.Point(587, 560)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnBuscar.Size = New System.Drawing.Size(59, 56)
        Me.BtnBuscar.TabIndex = 31
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
        Me.BtnAgregar.Location = New System.Drawing.Point(257, 560)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAgregar.Size = New System.Drawing.Size(66, 56)
        Me.BtnAgregar.TabIndex = 28
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(247, 552)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(517, 73)
        Me.PictureBox1.TabIndex = 159
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(11, 551)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(230, 73)
        Me.PictureBox2.TabIndex = 160
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(770, 552)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(73, 73)
        Me.PictureBox3.TabIndex = 161
        Me.PictureBox3.TabStop = False
        '
        'picImagenME
        '
        Me.picImagenME.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.MesaentradaBindingSource, "ImagenME", True))
        Me.picImagenME.InitialImage = CType(resources.GetObject("picImagenME.InitialImage"), System.Drawing.Image)
        Me.picImagenME.Location = New System.Drawing.Point(858, 124)
        Me.picImagenME.Name = "picImagenME"
        Me.picImagenME.Size = New System.Drawing.Size(294, 454)
        Me.picImagenME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picImagenME.TabIndex = 145
        Me.picImagenME.TabStop = False
        '
        'btnImagen
        '
        Me.btnImagen.AutoSize = True
        Me.btnImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImagen.FlatAppearance.BorderSize = 0
        Me.btnImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImagen.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImagen.ForeColor = System.Drawing.Color.White
        Me.btnImagen.Image = CType(resources.GetObject("btnImagen.Image"), System.Drawing.Image)
        Me.btnImagen.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImagen.Location = New System.Drawing.Point(858, 62)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnImagen.Size = New System.Drawing.Size(61, 56)
        Me.btnImagen.TabIndex = 26
        Me.btnImagen.Text = "Imagen"
        Me.btnImagen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Location = New System.Drawing.Point(848, 57)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(315, 568)
        Me.PictureBox5.TabIndex = 164
        Me.PictureBox5.TabStop = False
        '
        'txtOrigenIMG
        '
        Me.txtOrigenIMG.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtOrigenIMG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigenIMG.Location = New System.Drawing.Point(916, 75)
        Me.txtOrigenIMG.Name = "txtOrigenIMG"
        Me.txtOrigenIMG.Size = New System.Drawing.Size(201, 23)
        Me.txtOrigenIMG.TabIndex = 165
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(13, 57)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(829, 488)
        Me.PictureBox4.TabIndex = 168
        Me.PictureBox4.TabStop = False
        '
        'frmMesaEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1176, 644)
        Me.Controls.Add(Me.picImagenME)
        Me.Controls.Add(Me.txtOrigenIMG)
        Me.Controls.Add(Me.btnImagen)
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
        Me.Controls.Add(Me.cbxMes)
        Me.Controls.Add(Me.cbxDiaSemana)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.cbxIngresoEgreso)
        Me.Controls.Add(Me.txtId_ME)
        Me.Controls.Add(FechaMELabel)
        Me.Controls.Add(Me.dtpFechaME)
        Me.Controls.Add(HoraMELabel)
        Me.Controls.Add(Me.txtHoraME)
        Me.Controls.Add(lblNroIngreso)
        Me.Controls.Add(Me.txtNroIngresoME)
        Me.Controls.Add(lblDeQuien)
        Me.Controls.Add(Me.txtDeME)
        Me.Controls.Add(lblNroSalida)
        Me.Controls.Add(Me.txtNroSalidaME)
        Me.Controls.Add(lblAquien)
        Me.Controls.Add(Me.txtAquienME)
        Me.Controls.Add(MatriMELabel)
        Me.Controls.Add(Me.txtMatriME)
        Me.Controls.Add(AsuntoMELabel)
        Me.Controls.Add(Me.txtAsuntoME)
        Me.Controls.Add(Me.ChbDelegacion)
        Me.Controls.Add(ReferidoMELabel)
        Me.Controls.Add(Me.txtReferidoME)
        Me.Controls.Add(MatriRefMELabel)
        Me.Controls.Add(Me.txtMatriRefME)
        Me.Controls.Add(ActorMELabel)
        Me.Controls.Add(Me.txtActorME)
        Me.Controls.Add(DemandadoMELabel)
        Me.Controls.Add(Me.txtDemandadoME)
        Me.Controls.Add(SobreMELabel)
        Me.Controls.Add(Me.txtSobreME)
        Me.Controls.Add(ExpedienteMELabel)
        Me.Controls.Add(Me.txtExpedienteME)
        Me.Controls.Add(JuzgadoMELabel)
        Me.Controls.Add(Me.txtJuzgadoME)
        Me.Controls.Add(CertJudMELabel)
        Me.Controls.Add(Me.txtCertJudME)
        Me.Controls.Add(NoJudicialMELabel)
        Me.Controls.Add(Me.txtNoJudicialME)
        Me.Controls.Add(NotaMELabel)
        Me.Controls.Add(Me.txtNotaME)
        Me.Controls.Add(BienesSubastaMELabel)
        Me.Controls.Add(Me.txtBienesSubastaME)
        Me.Controls.Add(DiaSemanaMELabel)
        Me.Controls.Add(DdMELabel)
        Me.Controls.Add(Me.txtDdME)
        Me.Controls.Add(MmMELabel)
        Me.Controls.Add(YyyyMELabel)
        Me.Controls.Add(Me.txtYyyyME)
        Me.Controls.Add(HoraSubastaMELabel)
        Me.Controls.Add(Me.txtHoraSubastaME)
        Me.Controls.Add(Me.MesaentradaBindingNavigator)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMesaEntrada"
        Me.Text = "ACTUALIZAR MESA DE ENTRADAS"
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesaentradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesaentradaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MesaentradaBindingNavigator.ResumeLayout(False)
        Me.MesaentradaBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagenME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents MesaentradaBindingSource As BindingSource
    Friend WithEvents MesaentradaTableAdapter As dbcolmartDataSetTableAdapters.mesaentradaTableAdapter
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MesaentradaBindingNavigator As BindingNavigator
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
    Friend WithEvents MesaentradaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtId_ME As TextBox
    Friend WithEvents dtpFechaME As DateTimePicker
    Friend WithEvents txtHoraME As TextBox
    Friend WithEvents txtNroIngresoME As TextBox
    Friend WithEvents txtDeME As TextBox
    Friend WithEvents txtNroSalidaME As TextBox
    Friend WithEvents txtAquienME As TextBox
    Friend WithEvents txtMatriME As TextBox
    Friend WithEvents txtAsuntoME As TextBox
    Friend WithEvents ChbDelegacion As CheckBox
    Friend WithEvents txtReferidoME As TextBox
    Friend WithEvents txtMatriRefME As TextBox
    Friend WithEvents txtActorME As TextBox
    Friend WithEvents txtDemandadoME As TextBox
    Friend WithEvents txtSobreME As TextBox
    Friend WithEvents txtExpedienteME As TextBox
    Friend WithEvents txtJuzgadoME As TextBox
    Friend WithEvents txtCertJudME As TextBox
    Friend WithEvents txtNoJudicialME As TextBox
    Friend WithEvents txtNotaME As TextBox
    Friend WithEvents txtBienesSubastaME As TextBox
    Friend WithEvents txtDdME As TextBox
    Friend WithEvents txtYyyyME As TextBox
    Friend WithEvents txtHoraSubastaME As TextBox
    Friend WithEvents picImagenME As PictureBox
    Friend WithEvents cbxIngresoEgreso As ComboBox
    Friend WithEvents cbxDiaSemana As ComboBox
    Friend WithEvents cbxMes As ComboBox
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
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents btnImagen As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txtOrigenIMG As TextBox
    Friend WithEvents PictureBox4 As PictureBox
End Class

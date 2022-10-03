<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColegiados
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
        Dim Id_MatriLabel As System.Windows.Forms.Label
        Dim ApelMatriLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim Label31 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmColegiados))
        Me.DbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.MatriculadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MatriculadosTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.matriculadosTableAdapter()
        Me.TableAdapterManager = New ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager()
        Me.txtId_Matri = New System.Windows.Forms.TextBox()
        Me.txtNroMatri = New System.Windows.Forms.TextBox()
        Me.txtApelNombMatri = New System.Windows.Forms.TextBox()
        Me.txtApelMatMatri = New System.Windows.Forms.TextBox()
        Me.txtFecNacMatri = New System.Windows.Forms.TextBox()
        Me.txtLugarNacMatri = New System.Windows.Forms.TextBox()
        Me.txtNacionNacMatri = New System.Windows.Forms.TextBox()
        Me.txtNroDocMatri = New System.Windows.Forms.TextBox()
        Me.txtCuitMatri = New System.Windows.Forms.TextBox()
        Me.txtFecJurMatri = New System.Windows.Forms.TextBox()
        Me.txtFecEstadoMatri = New System.Windows.Forms.TextBox()
        Me.txtCalleRealMatri = New System.Windows.Forms.TextBox()
        Me.txtIdLocalRMatri = New System.Windows.Forms.TextBox()
        Me.txtIdDptoRMatri = New System.Windows.Forms.TextBox()
        Me.txtIdProvRMatri = New System.Windows.Forms.TextBox()
        Me.txtEmailMatri = New System.Windows.Forms.TextBox()
        Me.txtCeluRealMatri = New System.Windows.Forms.TextBox()
        Me.txtFijoRealMatri = New System.Windows.Forms.TextBox()
        Me.txtCalleLegalMatri = New System.Windows.Forms.TextBox()
        Me.txtIdLocalLMatri = New System.Windows.Forms.TextBox()
        Me.txtIdDptoLMatri = New System.Windows.Forms.TextBox()
        Me.txtIdProvLMatri = New System.Windows.Forms.TextBox()
        Me.txtCeluLegalMatri = New System.Windows.Forms.TextBox()
        Me.txtFijoLegalMatri = New System.Windows.Forms.TextBox()
        Me.txtFianzaMatri = New System.Windows.Forms.TextBox()
        Me.txtDocFiadorMatri = New System.Windows.Forms.TextBox()
        Me.txtFiadorMatri = New System.Windows.Forms.TextBox()
        Me.txtCalleFiadorMatri = New System.Windows.Forms.TextBox()
        Me.txtTelFiadorMatri = New System.Windows.Forms.TextBox()
        Me.txtObsMatri = New System.Windows.Forms.TextBox()
        Me.txtTomoMatri = New System.Windows.Forms.TextBox()
        Me.txtFolioMatri = New System.Windows.Forms.TextBox()
        Me.cmbTipoDocMatri = New System.Windows.Forms.ComboBox()
        Me.cmbSexoMatri = New System.Windows.Forms.ComboBox()
        Me.cmbEstCivilMatri = New System.Windows.Forms.ComboBox()
        Me.cmbCatAporteMatri = New System.Windows.Forms.ComboBox()
        Me.cmbEstadoMatri = New System.Windows.Forms.ComboBox()
        Me.lblVenceFianza = New System.Windows.Forms.Label()
        Me.lblLocalReal = New System.Windows.Forms.Label()
        Me.lblDptoReal = New System.Windows.Forms.Label()
        Me.lblProvReal = New System.Windows.Forms.Label()
        Me.lblProvLegal = New System.Windows.Forms.Label()
        Me.lblDptoLegal = New System.Windows.Forms.Label()
        Me.lblLocalLegal = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.txtNuevaMatricula = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.btnSinMatricula = New System.Windows.Forms.Button()
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
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCodPosReal = New System.Windows.Forms.TextBox()
        Me.txtCodPosLegal = New System.Windows.Forms.TextBox()
        Me.lblDocFiadorMatri = New System.Windows.Forms.Label()
        Me.lblFiadorMatri = New System.Windows.Forms.Label()
        Me.lblCalleFiadorMatri = New System.Windows.Forms.Label()
        Me.lblTelFiadorMatri = New System.Windows.Forms.Label()
        Me.lblFianzaMatri = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Id_MatriLabel = New System.Windows.Forms.Label()
        ApelMatriLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        Label30 = New System.Windows.Forms.Label()
        Label31 = New System.Windows.Forms.Label()
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatriculadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_MatriLabel
        '
        Id_MatriLabel.AutoSize = True
        Id_MatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_MatriLabel.ForeColor = System.Drawing.Color.White
        Id_MatriLabel.Location = New System.Drawing.Point(98, 74)
        Id_MatriLabel.Name = "Id_MatriLabel"
        Id_MatriLabel.Size = New System.Drawing.Size(72, 17)
        Id_MatriLabel.TabIndex = 79
        Id_MatriLabel.Text = "Matrícula:"
        '
        'ApelMatriLabel
        '
        ApelMatriLabel.AutoSize = True
        ApelMatriLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApelMatriLabel.ForeColor = System.Drawing.Color.White
        ApelMatriLabel.Location = New System.Drawing.Point(233, 74)
        ApelMatriLabel.Name = "ApelMatriLabel"
        ApelMatriLabel.Size = New System.Drawing.Size(137, 17)
        ApelMatriLabel.TabIndex = 80
        ApelMatriLabel.Text = "Apellido y Nombres:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(635, 74)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(123, 17)
        Label1.TabIndex = 81
        Label1.Text = "Apellido Materno:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(39, 103)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(131, 17)
        Label2.TabIndex = 82
        Label2.Text = "Fecha Nacimiento:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(271, 103)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(99, 17)
        Label3.TabIndex = 83
        Label3.Text = "Lugar Nacim.:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.White
        Label4.Location = New System.Drawing.Point(657, 103)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(101, 17)
        Label4.TabIndex = 84
        Label4.Text = "Nacionalidad:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.White
        Label5.Location = New System.Drawing.Point(76, 132)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(94, 17)
        Label5.TabIndex = 85
        Label5.Text = "Tipo Docum.:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.White
        Label6.Location = New System.Drawing.Point(275, 132)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(95, 17)
        Label6.TabIndex = 86
        Label6.Text = "Nro. Docum.:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.Color.White
        Label7.Location = New System.Drawing.Point(480, 132)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(41, 17)
        Label7.TabIndex = 87
        Label7.Text = "Sexo:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.Color.White
        Label8.Location = New System.Drawing.Point(586, 132)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(88, 17)
        Label8.TabIndex = 88
        Label8.Text = "Estado Civil:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.Color.White
        Label9.Location = New System.Drawing.Point(809, 132)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(55, 17)
        Label9.TabIndex = 89
        Label9.Text = "C.U.I.T.:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.Color.White
        Label10.Location = New System.Drawing.Point(58, 162)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(112, 17)
        Label10.TabIndex = 93
        Label10.Text = "Fec. Juramento:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.Color.White
        Label11.Location = New System.Drawing.Point(264, 162)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(106, 17)
        Label11.TabIndex = 94
        Label11.Text = "Categ. Aporte:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.ForeColor = System.Drawing.Color.White
        Label12.Location = New System.Drawing.Point(465, 162)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(56, 17)
        Label12.TabIndex = 95
        Label12.Text = "Estado:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.ForeColor = System.Drawing.Color.White
        Label13.Location = New System.Drawing.Point(765, 162)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(99, 17)
        Label13.TabIndex = 96
        Label13.Text = "Fecha Estado:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.ForeColor = System.Drawing.Color.White
        Label14.Location = New System.Drawing.Point(822, 191)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(42, 17)
        Label14.TabIndex = 163
        Label14.Text = "Folio:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.ForeColor = System.Drawing.Color.White
        Label15.Location = New System.Drawing.Point(699, 191)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(48, 17)
        Label15.TabIndex = 162
        Label15.Text = "Tomo:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.ForeColor = System.Drawing.Color.White
        Label16.Location = New System.Drawing.Point(119, 191)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(51, 17)
        Label16.TabIndex = 161
        Label16.Text = "E-mail:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label17.ForeColor = System.Drawing.Color.White
        Label17.Location = New System.Drawing.Point(65, 236)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(105, 17)
        Label17.TabIndex = 164
        Label17.Text = "Domicilio Real:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label18.ForeColor = System.Drawing.Color.White
        Label18.Location = New System.Drawing.Point(530, 236)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(107, 17)
        Label18.TabIndex = 165
        Label18.Text = "Cod. Pos. Real:"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label19.ForeColor = System.Drawing.Color.White
        Label19.Location = New System.Drawing.Point(80, 265)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(90, 17)
        Label19.TabIndex = 166
        Label19.Text = "Celular Real:"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label20.ForeColor = System.Drawing.Color.White
        Label20.Location = New System.Drawing.Point(105, 294)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(65, 17)
        Label20.TabIndex = 167
        Label20.Text = "Fijo Real:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label21.ForeColor = System.Drawing.Color.White
        Label21.Location = New System.Drawing.Point(58, 339)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(112, 17)
        Label21.TabIndex = 168
        Label21.Text = "Domicilio Legal:"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label22.ForeColor = System.Drawing.Color.White
        Label22.Location = New System.Drawing.Point(523, 339)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(114, 17)
        Label22.TabIndex = 169
        Label22.Text = "Cod. Pos. Legal:"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label23.ForeColor = System.Drawing.Color.White
        Label23.Location = New System.Drawing.Point(73, 368)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(97, 17)
        Label23.TabIndex = 170
        Label23.Text = "Celular Legal:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label24.ForeColor = System.Drawing.Color.White
        Label24.Location = New System.Drawing.Point(98, 397)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(72, 17)
        Label24.TabIndex = 171
        Label24.Text = "Fijo Legal:"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label25.ForeColor = System.Drawing.Color.White
        Label25.Location = New System.Drawing.Point(626, 475)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(110, 17)
        Label25.TabIndex = 179
        Label25.Text = "Teléfono Fiador:"
        '
        'Label26
        '
        Label26.AutoSize = True
        Label26.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label26.ForeColor = System.Drawing.Color.White
        Label26.Location = New System.Drawing.Point(74, 446)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(96, 17)
        Label26.TabIndex = 174
        Label26.Text = "Fecha Fianza:"
        '
        'Label27
        '
        Label27.AutoSize = True
        Label27.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label27.ForeColor = System.Drawing.Color.White
        Label27.Location = New System.Drawing.Point(627, 446)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(109, 17)
        Label27.TabIndex = 175
        Label27.Text = "Nombre Fiador:"
        '
        'Label28
        '
        Label28.AutoSize = True
        Label28.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label28.ForeColor = System.Drawing.Color.White
        Label28.Location = New System.Drawing.Point(440, 446)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(87, 17)
        Label28.TabIndex = 176
        Label28.Text = "Doc. Fiador:"
        '
        'Label29
        '
        Label29.AutoSize = True
        Label29.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label29.ForeColor = System.Drawing.Color.White
        Label29.Location = New System.Drawing.Point(53, 475)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(117, 17)
        Label29.TabIndex = 177
        Label29.Text = "Domicilio Fiador:"
        '
        'Label30
        '
        Label30.AutoSize = True
        Label30.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label30.ForeColor = System.Drawing.Color.White
        Label30.Location = New System.Drawing.Point(63, 504)
        Label30.Name = "Label30"
        Label30.Size = New System.Drawing.Size(107, 17)
        Label30.TabIndex = 178
        Label30.Text = "Observaciones:"
        '
        'Label31
        '
        Label31.AutoSize = True
        Label31.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label31.ForeColor = System.Drawing.Color.Yellow
        Label31.Location = New System.Drawing.Point(260, 446)
        Label31.Name = "Label31"
        Label31.Size = New System.Drawing.Size(52, 16)
        Label31.TabIndex = 180
        Label31.Text = "VENC.:"
        '
        'DbcolmartDataSet
        '
        Me.DbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.DbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MatriculadosBindingSource
        '
        Me.MatriculadosBindingSource.DataMember = "matriculados"
        Me.MatriculadosBindingSource.DataSource = Me.DbcolmartDataSet
        '
        'MatriculadosTableAdapter
        '
        Me.MatriculadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bibliotecaTableAdapter = Nothing
        Me.TableAdapterManager.boletasTableAdapter = Nothing
        Me.TableAdapterManager.botonesTableAdapter = Nothing
        Me.TableAdapterManager.botonuserTableAdapter = Nothing
        Me.TableAdapterManager.cajamayorTableAdapter = Nothing
        Me.TableAdapterManager.cajaTableAdapter = Nothing
        Me.TableAdapterManager.categivaTableAdapter = Nothing
        Me.TableAdapterManager.coddebitoTableAdapter = Nothing
        Me.TableAdapterManager.codpostalTableAdapter = Nothing
        Me.TableAdapterManager.colegiadosTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.comprobteTableAdapter = Nothing
        Me.TableAdapterManager.cptosgastosTableAdapter = Nothing
        Me.TableAdapterManager.ctacteproTableAdapter = Nothing
        Me.TableAdapterManager.ctasctesTableAdapter = Nothing
        Me.TableAdapterManager.debehaberTableAdapter = Nothing
        Me.TableAdapterManager.debitomatriTableAdapter = Nothing
        Me.TableAdapterManager.debitosocTableAdapter = Nothing
        Me.TableAdapterManager.departamentoTableAdapter = Nothing
        Me.TableAdapterManager.depositosTableAdapter = Nothing
        Me.TableAdapterManager.detallecpraTableAdapter = Nothing
        Me.TableAdapterManager.fianzasTableAdapter = Nothing
        Me.TableAdapterManager.impctacteTableAdapter = Nothing
        Me.TableAdapterManager.juzgadosTableAdapter = Nothing
        Me.TableAdapterManager.listaoficioTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.localidadTableAdapter = Nothing
        Me.TableAdapterManager.lotebancoTableAdapter = Nothing
        Me.TableAdapterManager.matriculadosTableAdapter = Me.MatriculadosTableAdapter
        Me.TableAdapterManager.mesaentradaTableAdapter = Nothing
        Me.TableAdapterManager.nivelesTableAdapter = Nothing
        Me.TableAdapterManager.padronTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.provinciaTableAdapter = Nothing
        Me.TableAdapterManager.reciboTableAdapter = Nothing
        Me.TableAdapterManager.renglonesTableAdapter = Nothing
        Me.TableAdapterManager.saldomatTableAdapter = Nothing
        Me.TableAdapterManager.saldosocTableAdapter = Nothing
        Me.TableAdapterManager.sociedadesTableAdapter = Nothing
        Me.TableAdapterManager.tribunalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ColMart.dbcolmartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'txtId_Matri
        '
        Me.txtId_Matri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_Matri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_Matri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "id_Matri", True))
        Me.txtId_Matri.Enabled = False
        Me.txtId_Matri.ForeColor = System.Drawing.Color.White
        Me.txtId_Matri.Location = New System.Drawing.Point(976, 74)
        Me.txtId_Matri.Name = "txtId_Matri"
        Me.txtId_Matri.Size = New System.Drawing.Size(50, 16)
        Me.txtId_Matri.TabIndex = 2
        '
        'txtNroMatri
        '
        Me.txtNroMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "NroMatri", True))
        Me.txtNroMatri.ForeColor = System.Drawing.Color.White
        Me.txtNroMatri.Location = New System.Drawing.Point(176, 72)
        Me.txtNroMatri.Name = "txtNroMatri"
        Me.txtNroMatri.Size = New System.Drawing.Size(49, 23)
        Me.txtNroMatri.TabIndex = 0
        '
        'txtApelNombMatri
        '
        Me.txtApelNombMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtApelNombMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApelNombMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApelNombMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "ApelNombMatri", True))
        Me.txtApelNombMatri.ForeColor = System.Drawing.Color.White
        Me.txtApelNombMatri.Location = New System.Drawing.Point(376, 72)
        Me.txtApelNombMatri.Name = "txtApelNombMatri"
        Me.txtApelNombMatri.Size = New System.Drawing.Size(253, 23)
        Me.txtApelNombMatri.TabIndex = 1
        '
        'txtApelMatMatri
        '
        Me.txtApelMatMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtApelMatMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApelMatMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApelMatMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "ApelMatMatri", True))
        Me.txtApelMatMatri.ForeColor = System.Drawing.Color.White
        Me.txtApelMatMatri.Location = New System.Drawing.Point(764, 72)
        Me.txtApelMatMatri.Name = "txtApelMatMatri"
        Me.txtApelMatMatri.Size = New System.Drawing.Size(206, 23)
        Me.txtApelMatMatri.TabIndex = 2
        '
        'txtFecNacMatri
        '
        Me.txtFecNacMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecNacMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecNacMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FecNacMatri", True))
        Me.txtFecNacMatri.ForeColor = System.Drawing.Color.White
        Me.txtFecNacMatri.Location = New System.Drawing.Point(176, 101)
        Me.txtFecNacMatri.Name = "txtFecNacMatri"
        Me.txtFecNacMatri.Size = New System.Drawing.Size(75, 23)
        Me.txtFecNacMatri.TabIndex = 3
        '
        'txtLugarNacMatri
        '
        Me.txtLugarNacMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtLugarNacMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLugarNacMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLugarNacMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "LugarNacMatri", True))
        Me.txtLugarNacMatri.ForeColor = System.Drawing.Color.White
        Me.txtLugarNacMatri.Location = New System.Drawing.Point(376, 101)
        Me.txtLugarNacMatri.Name = "txtLugarNacMatri"
        Me.txtLugarNacMatri.Size = New System.Drawing.Size(253, 23)
        Me.txtLugarNacMatri.TabIndex = 4
        '
        'txtNacionNacMatri
        '
        Me.txtNacionNacMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNacionNacMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNacionNacMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNacionNacMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "NacionNacMatri", True))
        Me.txtNacionNacMatri.ForeColor = System.Drawing.Color.White
        Me.txtNacionNacMatri.Location = New System.Drawing.Point(764, 101)
        Me.txtNacionNacMatri.Name = "txtNacionNacMatri"
        Me.txtNacionNacMatri.Size = New System.Drawing.Size(206, 23)
        Me.txtNacionNacMatri.TabIndex = 5
        '
        'txtNroDocMatri
        '
        Me.txtNroDocMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroDocMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroDocMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "NroDocMatri", True))
        Me.txtNroDocMatri.ForeColor = System.Drawing.Color.White
        Me.txtNroDocMatri.Location = New System.Drawing.Point(376, 130)
        Me.txtNroDocMatri.Name = "txtNroDocMatri"
        Me.txtNroDocMatri.Size = New System.Drawing.Size(100, 23)
        Me.txtNroDocMatri.TabIndex = 7
        '
        'txtCuitMatri
        '
        Me.txtCuitMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCuitMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuitMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CuitMatri", True))
        Me.txtCuitMatri.ForeColor = System.Drawing.Color.White
        Me.txtCuitMatri.Location = New System.Drawing.Point(870, 130)
        Me.txtCuitMatri.Name = "txtCuitMatri"
        Me.txtCuitMatri.Size = New System.Drawing.Size(100, 23)
        Me.txtCuitMatri.TabIndex = 10
        '
        'txtFecJurMatri
        '
        Me.txtFecJurMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecJurMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecJurMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FecJurMatri", True))
        Me.txtFecJurMatri.ForeColor = System.Drawing.Color.White
        Me.txtFecJurMatri.Location = New System.Drawing.Point(176, 160)
        Me.txtFecJurMatri.Name = "txtFecJurMatri"
        Me.txtFecJurMatri.Size = New System.Drawing.Size(75, 23)
        Me.txtFecJurMatri.TabIndex = 11
        '
        'txtFecEstadoMatri
        '
        Me.txtFecEstadoMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecEstadoMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecEstadoMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FecEstadoMatri", True))
        Me.txtFecEstadoMatri.Enabled = False
        Me.txtFecEstadoMatri.ForeColor = System.Drawing.Color.White
        Me.txtFecEstadoMatri.Location = New System.Drawing.Point(870, 160)
        Me.txtFecEstadoMatri.Name = "txtFecEstadoMatri"
        Me.txtFecEstadoMatri.Size = New System.Drawing.Size(82, 23)
        Me.txtFecEstadoMatri.TabIndex = 14
        '
        'txtCalleRealMatri
        '
        Me.txtCalleRealMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCalleRealMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalleRealMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalleRealMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CalleRealMatri", True))
        Me.txtCalleRealMatri.ForeColor = System.Drawing.Color.White
        Me.txtCalleRealMatri.Location = New System.Drawing.Point(176, 234)
        Me.txtCalleRealMatri.Name = "txtCalleRealMatri"
        Me.txtCalleRealMatri.Size = New System.Drawing.Size(303, 23)
        Me.txtCalleRealMatri.TabIndex = 18
        '
        'txtIdLocalRMatri
        '
        Me.txtIdLocalRMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIdLocalRMatri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdLocalRMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "idLocalRMatri", True))
        Me.txtIdLocalRMatri.Enabled = False
        Me.txtIdLocalRMatri.ForeColor = System.Drawing.Color.White
        Me.txtIdLocalRMatri.Location = New System.Drawing.Point(1093, 337)
        Me.txtIdLocalRMatri.Name = "txtIdLocalRMatri"
        Me.txtIdLocalRMatri.Size = New System.Drawing.Size(33, 16)
        Me.txtIdLocalRMatri.TabIndex = 38
        '
        'txtIdDptoRMatri
        '
        Me.txtIdDptoRMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIdDptoRMatri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdDptoRMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "idDptoRMatri", True))
        Me.txtIdDptoRMatri.Enabled = False
        Me.txtIdDptoRMatri.ForeColor = System.Drawing.Color.White
        Me.txtIdDptoRMatri.Location = New System.Drawing.Point(1093, 366)
        Me.txtIdDptoRMatri.Name = "txtIdDptoRMatri"
        Me.txtIdDptoRMatri.Size = New System.Drawing.Size(33, 16)
        Me.txtIdDptoRMatri.TabIndex = 40
        '
        'txtIdProvRMatri
        '
        Me.txtIdProvRMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIdProvRMatri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdProvRMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "idProvRMatri", True))
        Me.txtIdProvRMatri.Enabled = False
        Me.txtIdProvRMatri.ForeColor = System.Drawing.Color.White
        Me.txtIdProvRMatri.Location = New System.Drawing.Point(1093, 395)
        Me.txtIdProvRMatri.Name = "txtIdProvRMatri"
        Me.txtIdProvRMatri.Size = New System.Drawing.Size(33, 16)
        Me.txtIdProvRMatri.TabIndex = 42
        '
        'txtEmailMatri
        '
        Me.txtEmailMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtEmailMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmailMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "EmailMatri", True))
        Me.txtEmailMatri.ForeColor = System.Drawing.Color.White
        Me.txtEmailMatri.Location = New System.Drawing.Point(176, 189)
        Me.txtEmailMatri.Name = "txtEmailMatri"
        Me.txtEmailMatri.Size = New System.Drawing.Size(510, 23)
        Me.txtEmailMatri.TabIndex = 15
        '
        'txtCeluRealMatri
        '
        Me.txtCeluRealMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCeluRealMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCeluRealMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CeluRealMatri", True))
        Me.txtCeluRealMatri.ForeColor = System.Drawing.Color.White
        Me.txtCeluRealMatri.Location = New System.Drawing.Point(176, 263)
        Me.txtCeluRealMatri.Name = "txtCeluRealMatri"
        Me.txtCeluRealMatri.Size = New System.Drawing.Size(303, 23)
        Me.txtCeluRealMatri.TabIndex = 20
        '
        'txtFijoRealMatri
        '
        Me.txtFijoRealMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFijoRealMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFijoRealMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FijoRealMatri", True))
        Me.txtFijoRealMatri.ForeColor = System.Drawing.Color.White
        Me.txtFijoRealMatri.Location = New System.Drawing.Point(176, 292)
        Me.txtFijoRealMatri.Name = "txtFijoRealMatri"
        Me.txtFijoRealMatri.Size = New System.Drawing.Size(303, 23)
        Me.txtFijoRealMatri.TabIndex = 21
        '
        'txtCalleLegalMatri
        '
        Me.txtCalleLegalMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCalleLegalMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalleLegalMatri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalleLegalMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CalleLegalMatri", True))
        Me.txtCalleLegalMatri.ForeColor = System.Drawing.Color.White
        Me.txtCalleLegalMatri.Location = New System.Drawing.Point(176, 337)
        Me.txtCalleLegalMatri.Name = "txtCalleLegalMatri"
        Me.txtCalleLegalMatri.Size = New System.Drawing.Size(303, 23)
        Me.txtCalleLegalMatri.TabIndex = 22
        '
        'txtIdLocalLMatri
        '
        Me.txtIdLocalLMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIdLocalLMatri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdLocalLMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "idLocalLMatri", True))
        Me.txtIdLocalLMatri.Enabled = False
        Me.txtIdLocalLMatri.ForeColor = System.Drawing.Color.White
        Me.txtIdLocalLMatri.Location = New System.Drawing.Point(1134, 337)
        Me.txtIdLocalLMatri.Name = "txtIdLocalLMatri"
        Me.txtIdLocalLMatri.Size = New System.Drawing.Size(33, 16)
        Me.txtIdLocalLMatri.TabIndex = 54
        '
        'txtIdDptoLMatri
        '
        Me.txtIdDptoLMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIdDptoLMatri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdDptoLMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "idDptoLMatri", True))
        Me.txtIdDptoLMatri.Enabled = False
        Me.txtIdDptoLMatri.ForeColor = System.Drawing.Color.White
        Me.txtIdDptoLMatri.Location = New System.Drawing.Point(1134, 366)
        Me.txtIdDptoLMatri.Name = "txtIdDptoLMatri"
        Me.txtIdDptoLMatri.Size = New System.Drawing.Size(33, 16)
        Me.txtIdDptoLMatri.TabIndex = 56
        '
        'txtIdProvLMatri
        '
        Me.txtIdProvLMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIdProvLMatri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdProvLMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "idProvLMatri", True))
        Me.txtIdProvLMatri.Enabled = False
        Me.txtIdProvLMatri.ForeColor = System.Drawing.Color.White
        Me.txtIdProvLMatri.Location = New System.Drawing.Point(1134, 395)
        Me.txtIdProvLMatri.Name = "txtIdProvLMatri"
        Me.txtIdProvLMatri.Size = New System.Drawing.Size(33, 16)
        Me.txtIdProvLMatri.TabIndex = 58
        '
        'txtCeluLegalMatri
        '
        Me.txtCeluLegalMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCeluLegalMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCeluLegalMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CeluLegalMatri", True))
        Me.txtCeluLegalMatri.ForeColor = System.Drawing.Color.White
        Me.txtCeluLegalMatri.Location = New System.Drawing.Point(176, 366)
        Me.txtCeluLegalMatri.Name = "txtCeluLegalMatri"
        Me.txtCeluLegalMatri.Size = New System.Drawing.Size(303, 23)
        Me.txtCeluLegalMatri.TabIndex = 24
        '
        'txtFijoLegalMatri
        '
        Me.txtFijoLegalMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFijoLegalMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFijoLegalMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FijoLegalMatri", True))
        Me.txtFijoLegalMatri.ForeColor = System.Drawing.Color.White
        Me.txtFijoLegalMatri.Location = New System.Drawing.Point(176, 395)
        Me.txtFijoLegalMatri.Name = "txtFijoLegalMatri"
        Me.txtFijoLegalMatri.Size = New System.Drawing.Size(303, 23)
        Me.txtFijoLegalMatri.TabIndex = 25
        '
        'txtFianzaMatri
        '
        Me.txtFianzaMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFianzaMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFianzaMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FianzaMatri", True))
        Me.txtFianzaMatri.ForeColor = System.Drawing.Color.White
        Me.txtFianzaMatri.Location = New System.Drawing.Point(1083, 419)
        Me.txtFianzaMatri.Name = "txtFianzaMatri"
        Me.txtFianzaMatri.Size = New System.Drawing.Size(14, 23)
        Me.txtFianzaMatri.TabIndex = 64
        '
        'txtDocFiadorMatri
        '
        Me.txtDocFiadorMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDocFiadorMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocFiadorMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "DocFiadorMatri", True))
        Me.txtDocFiadorMatri.ForeColor = System.Drawing.Color.White
        Me.txtDocFiadorMatri.Location = New System.Drawing.Point(1103, 419)
        Me.txtDocFiadorMatri.Name = "txtDocFiadorMatri"
        Me.txtDocFiadorMatri.Size = New System.Drawing.Size(14, 23)
        Me.txtDocFiadorMatri.TabIndex = 66
        '
        'txtFiadorMatri
        '
        Me.txtFiadorMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFiadorMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiadorMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FiadorMatri", True))
        Me.txtFiadorMatri.ForeColor = System.Drawing.Color.White
        Me.txtFiadorMatri.Location = New System.Drawing.Point(1123, 419)
        Me.txtFiadorMatri.Name = "txtFiadorMatri"
        Me.txtFiadorMatri.Size = New System.Drawing.Size(14, 23)
        Me.txtFiadorMatri.TabIndex = 68
        '
        'txtCalleFiadorMatri
        '
        Me.txtCalleFiadorMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCalleFiadorMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalleFiadorMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CalleFiadorMatri", True))
        Me.txtCalleFiadorMatri.ForeColor = System.Drawing.Color.White
        Me.txtCalleFiadorMatri.Location = New System.Drawing.Point(1143, 419)
        Me.txtCalleFiadorMatri.Name = "txtCalleFiadorMatri"
        Me.txtCalleFiadorMatri.Size = New System.Drawing.Size(14, 23)
        Me.txtCalleFiadorMatri.TabIndex = 70
        '
        'txtTelFiadorMatri
        '
        Me.txtTelFiadorMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTelFiadorMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelFiadorMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "TelFiadorMatri", True))
        Me.txtTelFiadorMatri.ForeColor = System.Drawing.Color.White
        Me.txtTelFiadorMatri.Location = New System.Drawing.Point(1163, 419)
        Me.txtTelFiadorMatri.Name = "txtTelFiadorMatri"
        Me.txtTelFiadorMatri.Size = New System.Drawing.Size(14, 23)
        Me.txtTelFiadorMatri.TabIndex = 72
        '
        'txtObsMatri
        '
        Me.txtObsMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObsMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "ObsMatri", True))
        Me.txtObsMatri.ForeColor = System.Drawing.Color.White
        Me.txtObsMatri.Location = New System.Drawing.Point(176, 502)
        Me.txtObsMatri.Name = "txtObsMatri"
        Me.txtObsMatri.Size = New System.Drawing.Size(873, 23)
        Me.txtObsMatri.TabIndex = 26
        '
        'txtTomoMatri
        '
        Me.txtTomoMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTomoMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTomoMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "TomoMatri", True))
        Me.txtTomoMatri.ForeColor = System.Drawing.Color.White
        Me.txtTomoMatri.Location = New System.Drawing.Point(753, 189)
        Me.txtTomoMatri.Name = "txtTomoMatri"
        Me.txtTomoMatri.Size = New System.Drawing.Size(37, 23)
        Me.txtTomoMatri.TabIndex = 16
        '
        'txtFolioMatri
        '
        Me.txtFolioMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFolioMatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFolioMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "FolioMatri", True))
        Me.txtFolioMatri.ForeColor = System.Drawing.Color.White
        Me.txtFolioMatri.Location = New System.Drawing.Point(870, 189)
        Me.txtFolioMatri.Name = "txtFolioMatri"
        Me.txtFolioMatri.Size = New System.Drawing.Size(39, 23)
        Me.txtFolioMatri.TabIndex = 17
        '
        'cmbTipoDocMatri
        '
        Me.cmbTipoDocMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbTipoDocMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "TipoDocMatri", True))
        Me.cmbTipoDocMatri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoDocMatri.ForeColor = System.Drawing.Color.White
        Me.cmbTipoDocMatri.FormattingEnabled = True
        Me.cmbTipoDocMatri.Items.AddRange(New Object() {"DNI", "CI", "LE", "LC", "PAS"})
        Me.cmbTipoDocMatri.Location = New System.Drawing.Point(176, 129)
        Me.cmbTipoDocMatri.Name = "cmbTipoDocMatri"
        Me.cmbTipoDocMatri.Size = New System.Drawing.Size(62, 25)
        Me.cmbTipoDocMatri.TabIndex = 6
        '
        'cmbSexoMatri
        '
        Me.cmbSexoMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbSexoMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "SexoMatri", True))
        Me.cmbSexoMatri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSexoMatri.ForeColor = System.Drawing.Color.White
        Me.cmbSexoMatri.FormattingEnabled = True
        Me.cmbSexoMatri.Items.AddRange(New Object() {"M", "F"})
        Me.cmbSexoMatri.Location = New System.Drawing.Point(527, 129)
        Me.cmbSexoMatri.Name = "cmbSexoMatri"
        Me.cmbSexoMatri.Size = New System.Drawing.Size(53, 25)
        Me.cmbSexoMatri.TabIndex = 8
        '
        'cmbEstCivilMatri
        '
        Me.cmbEstCivilMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbEstCivilMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "EstCivilMatri", True))
        Me.cmbEstCivilMatri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEstCivilMatri.ForeColor = System.Drawing.Color.White
        Me.cmbEstCivilMatri.FormattingEnabled = True
        Me.cmbEstCivilMatri.Items.AddRange(New Object() {"SOLTERO", "CASADO", "DIVORCIADO", "VIUDO"})
        Me.cmbEstCivilMatri.Location = New System.Drawing.Point(680, 129)
        Me.cmbEstCivilMatri.Name = "cmbEstCivilMatri"
        Me.cmbEstCivilMatri.Size = New System.Drawing.Size(121, 25)
        Me.cmbEstCivilMatri.TabIndex = 9
        '
        'cmbCatAporteMatri
        '
        Me.cmbCatAporteMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbCatAporteMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "CatAporteMatri", True))
        Me.cmbCatAporteMatri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCatAporteMatri.ForeColor = System.Drawing.Color.White
        Me.cmbCatAporteMatri.FormattingEnabled = True
        Me.cmbCatAporteMatri.Items.AddRange(New Object() {"A", "B"})
        Me.cmbCatAporteMatri.Location = New System.Drawing.Point(376, 159)
        Me.cmbCatAporteMatri.Name = "cmbCatAporteMatri"
        Me.cmbCatAporteMatri.Size = New System.Drawing.Size(59, 25)
        Me.cmbCatAporteMatri.TabIndex = 12
        '
        'cmbEstadoMatri
        '
        Me.cmbEstadoMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbEstadoMatri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "EstadoMatri", True))
        Me.cmbEstadoMatri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEstadoMatri.ForeColor = System.Drawing.Color.White
        Me.cmbEstadoMatri.FormattingEnabled = True
        Me.cmbEstadoMatri.Items.AddRange(New Object() {"ACTIVO", "BAJA", "CANCELADO", "SUSPENDIDO", "SUSP. MOROSO"})
        Me.cmbEstadoMatri.Location = New System.Drawing.Point(527, 159)
        Me.cmbEstadoMatri.Name = "cmbEstadoMatri"
        Me.cmbEstadoMatri.Size = New System.Drawing.Size(159, 25)
        Me.cmbEstadoMatri.TabIndex = 13
        '
        'lblVenceFianza
        '
        Me.lblVenceFianza.AutoSize = True
        Me.lblVenceFianza.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenceFianza.ForeColor = System.Drawing.Color.Lime
        Me.lblVenceFianza.Location = New System.Drawing.Point(318, 443)
        Me.lblVenceFianza.Name = "lblVenceFianza"
        Me.lblVenceFianza.Size = New System.Drawing.Size(16, 19)
        Me.lblVenceFianza.TabIndex = 181
        Me.lblVenceFianza.Text = "-"
        '
        'lblLocalReal
        '
        Me.lblLocalReal.AutoSize = True
        Me.lblLocalReal.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblLocalReal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalReal.ForeColor = System.Drawing.Color.White
        Me.lblLocalReal.Location = New System.Drawing.Point(702, 236)
        Me.lblLocalReal.Name = "lblLocalReal"
        Me.lblLocalReal.Size = New System.Drawing.Size(12, 17)
        Me.lblLocalReal.TabIndex = 188
        Me.lblLocalReal.Text = "-"
        Me.lblLocalReal.Visible = False
        '
        'lblDptoReal
        '
        Me.lblDptoReal.AutoSize = True
        Me.lblDptoReal.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblDptoReal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDptoReal.ForeColor = System.Drawing.Color.White
        Me.lblDptoReal.Location = New System.Drawing.Point(702, 265)
        Me.lblDptoReal.Name = "lblDptoReal"
        Me.lblDptoReal.Size = New System.Drawing.Size(12, 17)
        Me.lblDptoReal.TabIndex = 189
        Me.lblDptoReal.Text = "-"
        Me.lblDptoReal.Visible = False
        '
        'lblProvReal
        '
        Me.lblProvReal.AutoSize = True
        Me.lblProvReal.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblProvReal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvReal.ForeColor = System.Drawing.Color.White
        Me.lblProvReal.Location = New System.Drawing.Point(702, 294)
        Me.lblProvReal.Name = "lblProvReal"
        Me.lblProvReal.Size = New System.Drawing.Size(12, 17)
        Me.lblProvReal.TabIndex = 190
        Me.lblProvReal.Text = "-"
        Me.lblProvReal.Visible = False
        '
        'lblProvLegal
        '
        Me.lblProvLegal.AutoSize = True
        Me.lblProvLegal.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblProvLegal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvLegal.ForeColor = System.Drawing.Color.White
        Me.lblProvLegal.Location = New System.Drawing.Point(702, 397)
        Me.lblProvLegal.Name = "lblProvLegal"
        Me.lblProvLegal.Size = New System.Drawing.Size(12, 17)
        Me.lblProvLegal.TabIndex = 193
        Me.lblProvLegal.Text = "-"
        Me.lblProvLegal.Visible = False
        '
        'lblDptoLegal
        '
        Me.lblDptoLegal.AutoSize = True
        Me.lblDptoLegal.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblDptoLegal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDptoLegal.ForeColor = System.Drawing.Color.White
        Me.lblDptoLegal.Location = New System.Drawing.Point(702, 368)
        Me.lblDptoLegal.Name = "lblDptoLegal"
        Me.lblDptoLegal.Size = New System.Drawing.Size(12, 17)
        Me.lblDptoLegal.TabIndex = 192
        Me.lblDptoLegal.Text = "-"
        Me.lblDptoLegal.Visible = False
        '
        'lblLocalLegal
        '
        Me.lblLocalLegal.AutoSize = True
        Me.lblLocalLegal.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblLocalLegal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalLegal.ForeColor = System.Drawing.Color.White
        Me.lblLocalLegal.Location = New System.Drawing.Point(702, 339)
        Me.lblLocalLegal.Name = "lblLocalLegal"
        Me.lblLocalLegal.Size = New System.Drawing.Size(12, 17)
        Me.lblLocalLegal.TabIndex = 191
        Me.lblLocalLegal.Text = "-"
        Me.lblLocalLegal.Visible = False
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblMatricula.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.ForeColor = System.Drawing.Color.Yellow
        Me.lblMatricula.Location = New System.Drawing.Point(36, 27)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(134, 16)
        Me.lblMatricula.TabIndex = 195
        Me.lblMatricula.Text = "NUEVA MATRÍCULA:"
        Me.lblMatricula.Visible = False
        '
        'txtNuevaMatricula
        '
        Me.txtNuevaMatricula.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNuevaMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNuevaMatricula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculadosBindingSource, "NroMatri", True))
        Me.txtNuevaMatricula.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevaMatricula.ForeColor = System.Drawing.Color.Yellow
        Me.txtNuevaMatricula.Location = New System.Drawing.Point(176, 25)
        Me.txtNuevaMatricula.MaxLength = 5
        Me.txtNuevaMatricula.Name = "txtNuevaMatricula"
        Me.txtNuevaMatricula.Size = New System.Drawing.Size(73, 23)
        Me.txtNuevaMatricula.TabIndex = 194
        Me.txtNuevaMatricula.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Green
        Me.Label32.Location = New System.Drawing.Point(293, 9)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(454, 36)
        Me.Label32.TabIndex = 196
        Me.Label32.Text = "Actualización de Matriculados"
        '
        'btnCambiar
        '
        Me.btnCambiar.AutoSize = True
        Me.btnCambiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCambiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambiar.FlatAppearance.BorderSize = 0
        Me.btnCambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiar.ForeColor = System.Drawing.Color.White
        Me.btnCambiar.Image = CType(resources.GetObject("btnCambiar.Image"), System.Drawing.Image)
        Me.btnCambiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCambiar.Location = New System.Drawing.Point(128, 548)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCambiar.Size = New System.Drawing.Size(66, 56)
        Me.btnCambiar.TabIndex = 212
        Me.btnCambiar.Text = "Cambiar"
        Me.btnCambiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCambiar.UseVisualStyleBackColor = False
        '
        'btnSinMatricula
        '
        Me.btnSinMatricula.AutoSize = True
        Me.btnSinMatricula.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSinMatricula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSinMatricula.FlatAppearance.BorderSize = 0
        Me.btnSinMatricula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSinMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSinMatricula.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSinMatricula.ForeColor = System.Drawing.Color.White
        Me.btnSinMatricula.Image = CType(resources.GetObject("btnSinMatricula.Image"), System.Drawing.Image)
        Me.btnSinMatricula.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSinMatricula.Location = New System.Drawing.Point(26, 548)
        Me.btnSinMatricula.Name = "btnSinMatricula"
        Me.btnSinMatricula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSinMatricula.Size = New System.Drawing.Size(94, 56)
        Me.btnSinMatricula.TabIndex = 211
        Me.btnSinMatricula.Text = "S/Matricula"
        Me.btnSinMatricula.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnSinMatricula.UseVisualStyleBackColor = False
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
        Me.BtnUltimo.Location = New System.Drawing.Point(895, 556)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnUltimo.Size = New System.Drawing.Size(38, 38)
        Me.BtnUltimo.TabIndex = 206
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
        Me.BtnPrimer.Location = New System.Drawing.Point(760, 556)
        Me.BtnPrimer.Name = "BtnPrimer"
        Me.BtnPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPrimer.Size = New System.Drawing.Size(38, 38)
        Me.BtnPrimer.TabIndex = 203
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
        Me.BtnSiguiente.Location = New System.Drawing.Point(850, 556)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSiguiente.Size = New System.Drawing.Size(38, 38)
        Me.BtnSiguiente.TabIndex = 205
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
        Me.BtnAnterior.Location = New System.Drawing.Point(805, 556)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAnterior.Size = New System.Drawing.Size(38, 38)
        Me.BtnAnterior.TabIndex = 204
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
        Me.BtnActualizar.Location = New System.Drawing.Point(630, 548)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnActualizar.Size = New System.Drawing.Size(87, 56)
        Me.BtnActualizar.TabIndex = 202
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
        Me.BtnGrabar.Location = New System.Drawing.Point(299, 548)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGrabar.Size = New System.Drawing.Size(59, 56)
        Me.BtnGrabar.TabIndex = 201
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
        Me.BtnSalir.Location = New System.Drawing.Point(971, 548)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(87, 56)
        Me.BtnSalir.TabIndex = 207
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
        Me.BtnModificar.Location = New System.Drawing.Point(369, 548)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnModificar.Size = New System.Drawing.Size(80, 56)
        Me.BtnModificar.TabIndex = 200
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
        Me.BtnEliminar.Location = New System.Drawing.Point(461, 548)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEliminar.Size = New System.Drawing.Size(73, 56)
        Me.BtnEliminar.TabIndex = 199
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
        Me.BtnBuscar.Location = New System.Drawing.Point(551, 548)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnBuscar.Size = New System.Drawing.Size(59, 56)
        Me.BtnBuscar.TabIndex = 198
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
        Me.BtnAgregar.Location = New System.Drawing.Point(222, 548)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAgregar.Size = New System.Drawing.Size(66, 56)
        Me.BtnAgregar.TabIndex = 197
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(211, 540)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(520, 73)
        Me.PictureBox1.TabIndex = 208
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(737, 540)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(222, 73)
        Me.PictureBox2.TabIndex = 209
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(965, 540)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(99, 73)
        Me.PictureBox3.TabIndex = 210
        Me.PictureBox3.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox7.Location = New System.Drawing.Point(18, 540)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(187, 73)
        Me.PictureBox7.TabIndex = 213
        Me.PictureBox7.TabStop = False
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'txtCodPosReal
        '
        Me.txtCodPosReal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCodPosReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPosReal.ForeColor = System.Drawing.Color.White
        Me.txtCodPosReal.Location = New System.Drawing.Point(643, 234)
        Me.txtCodPosReal.Name = "txtCodPosReal"
        Me.txtCodPosReal.Size = New System.Drawing.Size(53, 23)
        Me.txtCodPosReal.TabIndex = 19
        '
        'txtCodPosLegal
        '
        Me.txtCodPosLegal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCodPosLegal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPosLegal.ForeColor = System.Drawing.Color.White
        Me.txtCodPosLegal.Location = New System.Drawing.Point(643, 337)
        Me.txtCodPosLegal.Name = "txtCodPosLegal"
        Me.txtCodPosLegal.Size = New System.Drawing.Size(53, 23)
        Me.txtCodPosLegal.TabIndex = 23
        '
        'lblDocFiadorMatri
        '
        Me.lblDocFiadorMatri.AutoSize = True
        Me.lblDocFiadorMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblDocFiadorMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocFiadorMatri.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblDocFiadorMatri.Location = New System.Drawing.Point(533, 446)
        Me.lblDocFiadorMatri.Name = "lblDocFiadorMatri"
        Me.lblDocFiadorMatri.Size = New System.Drawing.Size(12, 17)
        Me.lblDocFiadorMatri.TabIndex = 216
        Me.lblDocFiadorMatri.Text = "-"
        Me.lblDocFiadorMatri.Visible = False
        '
        'lblFiadorMatri
        '
        Me.lblFiadorMatri.AutoSize = True
        Me.lblFiadorMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblFiadorMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiadorMatri.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblFiadorMatri.Location = New System.Drawing.Point(742, 446)
        Me.lblFiadorMatri.Name = "lblFiadorMatri"
        Me.lblFiadorMatri.Size = New System.Drawing.Size(12, 17)
        Me.lblFiadorMatri.TabIndex = 217
        Me.lblFiadorMatri.Text = "-"
        Me.lblFiadorMatri.Visible = False
        '
        'lblCalleFiadorMatri
        '
        Me.lblCalleFiadorMatri.AutoSize = True
        Me.lblCalleFiadorMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblCalleFiadorMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalleFiadorMatri.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblCalleFiadorMatri.Location = New System.Drawing.Point(176, 475)
        Me.lblCalleFiadorMatri.Name = "lblCalleFiadorMatri"
        Me.lblCalleFiadorMatri.Size = New System.Drawing.Size(12, 17)
        Me.lblCalleFiadorMatri.TabIndex = 218
        Me.lblCalleFiadorMatri.Text = "-"
        Me.lblCalleFiadorMatri.Visible = False
        '
        'lblTelFiadorMatri
        '
        Me.lblTelFiadorMatri.AutoSize = True
        Me.lblTelFiadorMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblTelFiadorMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelFiadorMatri.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTelFiadorMatri.Location = New System.Drawing.Point(742, 475)
        Me.lblTelFiadorMatri.Name = "lblTelFiadorMatri"
        Me.lblTelFiadorMatri.Size = New System.Drawing.Size(12, 17)
        Me.lblTelFiadorMatri.TabIndex = 219
        Me.lblTelFiadorMatri.Text = "-"
        Me.lblTelFiadorMatri.Visible = False
        '
        'lblFianzaMatri
        '
        Me.lblFianzaMatri.AutoSize = True
        Me.lblFianzaMatri.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblFianzaMatri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFianzaMatri.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblFianzaMatri.Location = New System.Drawing.Point(176, 446)
        Me.lblFianzaMatri.Name = "lblFianzaMatri"
        Me.lblFianzaMatri.Size = New System.Drawing.Size(12, 17)
        Me.lblFianzaMatri.TabIndex = 220
        Me.lblFianzaMatri.Text = "-"
        Me.lblFianzaMatri.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(1070, 321)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(115, 142)
        Me.PictureBox4.TabIndex = 221
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.MatriculadosBindingSource, "TomoMatri", True))
        Me.PictureBox5.Location = New System.Drawing.Point(18, 63)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1046, 157)
        Me.PictureBox5.TabIndex = 222
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox6.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.MatriculadosBindingSource, "TomoMatri", True))
        Me.PictureBox6.Location = New System.Drawing.Point(18, 226)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(1046, 97)
        Me.PictureBox6.TabIndex = 223
        Me.PictureBox6.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox8.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.MatriculadosBindingSource, "TomoMatri", True))
        Me.PictureBox8.Location = New System.Drawing.Point(18, 329)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(1046, 97)
        Me.PictureBox8.TabIndex = 224
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox9.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.MatriculadosBindingSource, "TomoMatri", True))
        Me.PictureBox9.Location = New System.Drawing.Point(18, 432)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(1046, 102)
        Me.PictureBox9.TabIndex = 225
        Me.PictureBox9.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.Enabled = False
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(991, 440)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(65, 55)
        Me.btnLimpiar.TabIndex = 226
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'frmColegiados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1186, 630)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblFianzaMatri)
        Me.Controls.Add(Me.lblTelFiadorMatri)
        Me.Controls.Add(Me.lblCalleFiadorMatri)
        Me.Controls.Add(Me.lblFiadorMatri)
        Me.Controls.Add(Me.lblDocFiadorMatri)
        Me.Controls.Add(Me.txtCodPosLegal)
        Me.Controls.Add(Me.txtCodPosReal)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.btnSinMatricula)
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
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.txtNuevaMatricula)
        Me.Controls.Add(Me.lblProvLegal)
        Me.Controls.Add(Me.lblDptoLegal)
        Me.Controls.Add(Me.lblLocalLegal)
        Me.Controls.Add(Me.lblProvReal)
        Me.Controls.Add(Me.lblDptoReal)
        Me.Controls.Add(Me.lblLocalReal)
        Me.Controls.Add(Me.lblVenceFianza)
        Me.Controls.Add(Label31)
        Me.Controls.Add(Label25)
        Me.Controls.Add(Label26)
        Me.Controls.Add(Label27)
        Me.Controls.Add(Label28)
        Me.Controls.Add(Label29)
        Me.Controls.Add(Label30)
        Me.Controls.Add(Label17)
        Me.Controls.Add(Label18)
        Me.Controls.Add(Label19)
        Me.Controls.Add(Label20)
        Me.Controls.Add(Label21)
        Me.Controls.Add(Label22)
        Me.Controls.Add(Label23)
        Me.Controls.Add(Label24)
        Me.Controls.Add(Label14)
        Me.Controls.Add(Label15)
        Me.Controls.Add(Label16)
        Me.Controls.Add(Me.cmbEstadoMatri)
        Me.Controls.Add(Me.cmbCatAporteMatri)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Label13)
        Me.Controls.Add(Me.cmbEstCivilMatri)
        Me.Controls.Add(Me.cmbSexoMatri)
        Me.Controls.Add(Me.cmbTipoDocMatri)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label1)
        Me.Controls.Add(ApelMatriLabel)
        Me.Controls.Add(Id_MatriLabel)
        Me.Controls.Add(Me.txtId_Matri)
        Me.Controls.Add(Me.txtNroMatri)
        Me.Controls.Add(Me.txtApelNombMatri)
        Me.Controls.Add(Me.txtApelMatMatri)
        Me.Controls.Add(Me.txtFecNacMatri)
        Me.Controls.Add(Me.txtLugarNacMatri)
        Me.Controls.Add(Me.txtNacionNacMatri)
        Me.Controls.Add(Me.txtNroDocMatri)
        Me.Controls.Add(Me.txtCuitMatri)
        Me.Controls.Add(Me.txtFecJurMatri)
        Me.Controls.Add(Me.txtFecEstadoMatri)
        Me.Controls.Add(Me.txtCalleRealMatri)
        Me.Controls.Add(Me.txtEmailMatri)
        Me.Controls.Add(Me.txtCeluRealMatri)
        Me.Controls.Add(Me.txtFijoRealMatri)
        Me.Controls.Add(Me.txtCalleLegalMatri)
        Me.Controls.Add(Me.txtCeluLegalMatri)
        Me.Controls.Add(Me.txtFijoLegalMatri)
        Me.Controls.Add(Me.txtTomoMatri)
        Me.Controls.Add(Me.txtFolioMatri)
        Me.Controls.Add(Me.txtObsMatri)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.txtIdLocalRMatri)
        Me.Controls.Add(Me.txtIdDptoRMatri)
        Me.Controls.Add(Me.txtIdProvRMatri)
        Me.Controls.Add(Me.txtIdLocalLMatri)
        Me.Controls.Add(Me.txtIdDptoLMatri)
        Me.Controls.Add(Me.txtIdProvLMatri)
        Me.Controls.Add(Me.txtFianzaMatri)
        Me.Controls.Add(Me.txtDocFiadorMatri)
        Me.Controls.Add(Me.txtFiadorMatri)
        Me.Controls.Add(Me.txtCalleFiadorMatri)
        Me.Controls.Add(Me.txtTelFiadorMatri)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox6)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmColegiados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZACIÓN DE COLEGIADOS"
        CType(Me.DbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatriculadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents MatriculadosBindingSource As BindingSource
    Friend WithEvents MatriculadosTableAdapter As dbcolmartDataSetTableAdapters.matriculadosTableAdapter
    Friend WithEvents TableAdapterManager As dbcolmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtId_Matri As TextBox
    Friend WithEvents txtNroMatri As TextBox
    Friend WithEvents txtApelNombMatri As TextBox
    Friend WithEvents txtApelMatMatri As TextBox
    Friend WithEvents txtFecNacMatri As TextBox
    Friend WithEvents txtLugarNacMatri As TextBox
    Friend WithEvents txtNacionNacMatri As TextBox
    Friend WithEvents txtNroDocMatri As TextBox
    Friend WithEvents txtCuitMatri As TextBox
    Friend WithEvents txtFecJurMatri As TextBox
    Friend WithEvents txtFecEstadoMatri As TextBox
    Friend WithEvents txtCalleRealMatri As TextBox
    Friend WithEvents txtIdLocalRMatri As TextBox
    Friend WithEvents txtIdDptoRMatri As TextBox
    Friend WithEvents txtIdProvRMatri As TextBox
    Friend WithEvents txtEmailMatri As TextBox
    Friend WithEvents txtCeluRealMatri As TextBox
    Friend WithEvents txtFijoRealMatri As TextBox
    Friend WithEvents txtCalleLegalMatri As TextBox
    Friend WithEvents txtIdLocalLMatri As TextBox
    Friend WithEvents txtIdDptoLMatri As TextBox
    Friend WithEvents txtIdProvLMatri As TextBox
    Friend WithEvents txtCeluLegalMatri As TextBox
    Friend WithEvents txtFijoLegalMatri As TextBox
    Friend WithEvents txtFianzaMatri As TextBox
    Friend WithEvents txtDocFiadorMatri As TextBox
    Friend WithEvents txtFiadorMatri As TextBox
    Friend WithEvents txtCalleFiadorMatri As TextBox
    Friend WithEvents txtTelFiadorMatri As TextBox
    Friend WithEvents txtObsMatri As TextBox
    Friend WithEvents txtTomoMatri As TextBox
    Friend WithEvents txtFolioMatri As TextBox
    Friend WithEvents cmbTipoDocMatri As ComboBox
    Friend WithEvents cmbSexoMatri As ComboBox
    Friend WithEvents cmbEstCivilMatri As ComboBox
    Friend WithEvents cmbCatAporteMatri As ComboBox
    Friend WithEvents cmbEstadoMatri As ComboBox
    Friend WithEvents lblVenceFianza As Label
    Friend WithEvents lblLocalReal As Label
    Friend WithEvents lblDptoReal As Label
    Friend WithEvents lblProvReal As Label
    Friend WithEvents lblProvLegal As Label
    Friend WithEvents lblDptoLegal As Label
    Friend WithEvents lblLocalLegal As Label
    Friend WithEvents lblMatricula As Label
    Friend WithEvents txtNuevaMatricula As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents btnCambiar As Button
    Friend WithEvents btnSinMatricula As Button
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
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents txtCodPosReal As TextBox
    Friend WithEvents txtCodPosLegal As TextBox
    Friend WithEvents lblDocFiadorMatri As Label
    Friend WithEvents lblFiadorMatri As Label
    Friend WithEvents lblCalleFiadorMatri As Label
    Friend WithEvents lblTelFiadorMatri As Label
    Friend WithEvents lblFianzaMatri As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents btnLimpiar As Button
End Class

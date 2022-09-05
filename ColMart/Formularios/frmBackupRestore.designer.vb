<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackupRestore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackupRestore))
        Me.txtArchivoBac = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtArchivoRes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscarRes = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.btnBuscarBac = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtArchivoBac
        '
        Me.txtArchivoBac.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtArchivoBac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArchivoBac.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchivoBac.ForeColor = System.Drawing.Color.White
        Me.txtArchivoBac.Location = New System.Drawing.Point(112, 93)
        Me.txtArchivoBac.Name = "txtArchivoBac"
        Me.txtArchivoBac.Size = New System.Drawing.Size(565, 24)
        Me.txtArchivoBac.TabIndex = 7
        '
        'txtArchivoRes
        '
        Me.txtArchivoRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtArchivoRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArchivoRes.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchivoRes.ForeColor = System.Drawing.Color.White
        Me.txtArchivoRes.Location = New System.Drawing.Point(112, 191)
        Me.txtArchivoRes.Name = "txtArchivoRes"
        Me.txtArchivoRes.Size = New System.Drawing.Size(565, 24)
        Me.txtArchivoRes.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(164, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(478, 36)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Copias y recupero de seguridad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label4.Location = New System.Drawing.Point(281, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 21)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "BACKUP DE BASE DE DATOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(281, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 21)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "RECUPERAR BASE DE DATOS"
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
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(173, 266)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(71, 57)
        Me.btnLimpiar.TabIndex = 151
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscarRes
        '
        Me.btnBuscarRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarRes.FlatAppearance.BorderSize = 0
        Me.btnBuscarRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarRes.ForeColor = System.Drawing.Color.White
        Me.btnBuscarRes.Image = CType(resources.GetObject("btnBuscarRes.Image"), System.Drawing.Image)
        Me.btnBuscarRes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscarRes.Location = New System.Drawing.Point(42, 170)
        Me.btnBuscarRes.Name = "btnBuscarRes"
        Me.btnBuscarRes.Size = New System.Drawing.Size(64, 57)
        Me.btnBuscarRes.TabIndex = 13
        Me.btnBuscarRes.Text = "Buscar"
        Me.btnBuscarRes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscarRes.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(548, 266)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(66, 57)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackup.FlatAppearance.BorderSize = 0
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.ForeColor = System.Drawing.Color.White
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBackup.Location = New System.Drawing.Point(683, 73)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(66, 57)
        Me.btnBackup.TabIndex = 10
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBackup.UseVisualStyleBackColor = True
        Me.btnBackup.Visible = False
        '
        'btnRestore
        '
        Me.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestore.FlatAppearance.BorderSize = 0
        Me.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.ForeColor = System.Drawing.Color.White
        Me.btnRestore.Image = CType(resources.GetObject("btnRestore.Image"), System.Drawing.Image)
        Me.btnRestore.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRestore.Location = New System.Drawing.Point(683, 170)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(66, 57)
        Me.btnRestore.TabIndex = 9
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRestore.UseVisualStyleBackColor = True
        Me.btnRestore.Visible = False
        '
        'btnBuscarBac
        '
        Me.btnBuscarBac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarBac.FlatAppearance.BorderSize = 0
        Me.btnBuscarBac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarBac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarBac.ForeColor = System.Drawing.Color.White
        Me.btnBuscarBac.Image = CType(resources.GetObject("btnBuscarBac.Image"), System.Drawing.Image)
        Me.btnBuscarBac.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscarBac.Location = New System.Drawing.Point(42, 73)
        Me.btnBuscarBac.Name = "btnBuscarBac"
        Me.btnBuscarBac.Size = New System.Drawing.Size(64, 57)
        Me.btnBuscarBac.TabIndex = 8
        Me.btnBuscarBac.Text = "Buscar"
        Me.btnBuscarBac.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscarBac.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(779, 80)
        Me.PictureBox1.TabIndex = 147
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(12, 158)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(779, 80)
        Me.PictureBox2.TabIndex = 149
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(12, 254)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(779, 80)
        Me.PictureBox3.TabIndex = 152
        Me.PictureBox3.TabStop = False
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.BackColor = System.Drawing.Color.DimGray
        Me.ToolTipMsg.ForeColor = System.Drawing.Color.White
        Me.ToolTipMsg.IsBalloon = True
        Me.ToolTipMsg.OwnerDraw = True
        '
        'frmBackupRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(836, 597)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBuscarRes)
        Me.Controls.Add(Me.txtArchivoRes)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnBuscarBac)
        Me.Controls.Add(Me.txtArchivoBac)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBackupRestore"
        Me.Text = "COPIAS DE SEGURIDAD Y RESTAURACIÓN DE BASE DE DATOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtArchivoBac As TextBox
    Friend WithEvents btnBuscarBac As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnRestore As Button
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtArchivoRes As TextBox
    Friend WithEvents btnBuscarRes As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ToolTipMsg As ToolTip
End Class

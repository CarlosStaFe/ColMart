<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetallado
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetallado))
        Me.debehaberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsDebeHaber = New ColMart.dsDebeHaber()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.debehaberTableAdapter = New ColMart.dsDebeHaberTableAdapters.debehaberTableAdapter()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        CType(Me.debehaberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsDebeHaber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'debehaberBindingSource
        '
        Me.debehaberBindingSource.DataMember = "debehaber"
        Me.debehaberBindingSource.DataSource = Me.dsDebeHaber
        '
        'dsDebeHaber
        '
        Me.dsDebeHaber.DataSetName = "dsDebeHaber"
        Me.dsDebeHaber.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsDebeHaber"
        ReportDataSource1.Value = Me.debehaberBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ColMart.rptDetallado.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(841, 566)
        Me.ReportViewer1.TabIndex = 0
        '
        'debehaberTableAdapter
        '
        Me.debehaberTableAdapter.ClearBeforeFill = True
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(715, 12)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(100, 20)
        Me.txtDetalle.TabIndex = 1
        Me.txtDetalle.Visible = False
        '
        'frmDetallado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(841, 566)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDetallado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INFORME DETALLADO DE PAGOS Y SALDOS"
        CType(Me.debehaberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsDebeHaber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents debehaberBindingSource As BindingSource
    Friend WithEvents dsDebeHaber As dsDebeHaber
    Friend WithEvents debehaberTableAdapter As dsDebeHaberTableAdapters.debehaberTableAdapter
    Friend WithEvents txtDetalle As TextBox
End Class

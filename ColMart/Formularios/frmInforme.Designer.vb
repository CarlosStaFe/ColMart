<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInforme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInforme))
        Me.debehaberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.debehaberTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.debehaberTableAdapter()
        Me.txtUser = New System.Windows.Forms.TextBox()
        CType(Me.debehaberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'debehaberBindingSource
        '
        Me.debehaberBindingSource.DataMember = "debehaber"
        Me.debehaberBindingSource.DataSource = Me.dbcolmartDataSet
        '
        'dbcolmartDataSet
        '
        Me.dbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.dbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(267, 12)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(100, 20)
        Me.txtDetalle.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsDebeHaber"
        ReportDataSource1.Value = Me.debehaberBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ColMart.rptInforme.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 469)
        Me.ReportViewer1.TabIndex = 1
        '
        'debehaberTableAdapter
        '
        Me.debehaberTableAdapter.ClearBeforeFill = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(373, 12)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 2
        '
        'frmInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 469)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtDetalle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInforme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADO DE SALDO Y PAGOS"
        CType(Me.debehaberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents debehaberBindingSource As BindingSource
    Friend WithEvents dbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents debehaberTableAdapter As dbcolmartDataSetTableAdapters.debehaberTableAdapter
    Friend WithEvents txtUser As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPadronMatri
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPadronMatri))
        Me.padronBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.padronTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.padronTableAdapter()
        CType(Me.padronBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'padronBindingSource
        '
        Me.padronBindingSource.DataMember = "padron"
        Me.padronBindingSource.DataSource = Me.dbcolmartDataSet
        '
        'dbcolmartDataSet
        '
        Me.dbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.dbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsPadron"
        ReportDataSource1.Value = Me.padronBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ColMart.rptPadronMatri.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1088, 537)
        Me.ReportViewer1.TabIndex = 0
        '
        'padronTableAdapter
        '
        Me.padronTableAdapter.ClearBeforeFill = True
        '
        'frmPadronMatri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 537)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPadronMatri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTAR PADRÓN DE MATRICULADOS"
        CType(Me.padronBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents padronBindingSource As BindingSource
    Friend WithEvents dbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents padronTableAdapter As dbcolmartDataSetTableAdapters.padronTableAdapter
End Class

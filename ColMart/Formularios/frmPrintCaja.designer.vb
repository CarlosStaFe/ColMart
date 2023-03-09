<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintCaja))
        Me.cajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbcolmartDataSet = New ColMart.dbcolmartDataSet()
        Me.cajaTableAdapter = New ColMart.dbcolmartDataSetTableAdapters.cajaTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.cajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbcolmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cajaBindingSource
        '
        Me.cajaBindingSource.DataMember = "caja"
        Me.cajaBindingSource.DataSource = Me.dbcolmartDataSet
        '
        'dbcolmartDataSet
        '
        Me.dbcolmartDataSet.DataSetName = "dbcolmartDataSet"
        Me.dbcolmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cajaTableAdapter
        '
        Me.cajaTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dbcolmartDataSet"
        ReportDataSource1.Value = Me.cajaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ColMart.rptPrintCaja.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(845, 550)
        Me.ReportViewer1.TabIndex = 0
        '
        'SaveFileDialog1
        '
        '
        'frmPrintCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 550)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrintCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "IMPRESIÓN CIERRE DE CAJA"
        CType(Me.cajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbcolmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cajaBindingSource As BindingSource
    Friend WithEvents dbcolmartDataSet As dbcolmartDataSet
    Friend WithEvents cajaTableAdapter As dbcolmartDataSetTableAdapters.cajaTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class

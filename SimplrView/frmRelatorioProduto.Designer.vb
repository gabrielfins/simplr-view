<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorioProduto
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelatorioProduto))
        Me.tbprodutoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_finalstopDataSet = New SimplrView.db_finalstopDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbprodutoTableAdapter = New SimplrView.db_finalstopDataSetTableAdapters.tbprodutoTableAdapter()
        CType(Me.tbprodutoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_finalstopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbprodutoBindingSource
        '
        Me.tbprodutoBindingSource.DataMember = "tbproduto"
        Me.tbprodutoBindingSource.DataSource = Me.db_finalstopDataSet
        '
        'db_finalstopDataSet
        '
        Me.db_finalstopDataSet.DataSetName = "db_finalstopDataSet"
        Me.db_finalstopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DbFinalStopDataSet"
        ReportDataSource1.Value = Me.tbprodutoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SimplrView.RelatorioProdutos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(634, 661)
        Me.ReportViewer1.TabIndex = 0
        '
        'tbprodutoTableAdapter
        '
        Me.tbprodutoTableAdapter.ClearBeforeFill = True
        '
        'frmRelatorioProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 661)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelatorioProduto"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simplr View"
        CType(Me.tbprodutoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_finalstopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbprodutoBindingSource As BindingSource
    Friend WithEvents db_finalstopDataSet As db_finalstopDataSet
    Friend WithEvents tbprodutoTableAdapter As db_finalstopDataSetTableAdapters.tbprodutoTableAdapter
End Class

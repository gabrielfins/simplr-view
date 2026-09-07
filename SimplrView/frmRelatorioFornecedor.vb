Public Class frmRelatorioFornecedor
    Private Sub frmRelatorioFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'db_finalstopDataSet.tbfornecedor'. Você pode movê-la ou removê-la conforme necessário.
        Me.tbfornecedorTableAdapter.Fill(Me.db_finalstopDataSet.tbfornecedor)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
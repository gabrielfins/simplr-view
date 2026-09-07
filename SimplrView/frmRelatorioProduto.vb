Public Class frmRelatorioProduto
    Private Sub frmRelatorioProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'db_finalstopDataSet.tbproduto'. Você pode movê-la ou removê-la conforme necessário.
        Me.tbprodutoTableAdapter.Fill(Me.db_finalstopDataSet.tbproduto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
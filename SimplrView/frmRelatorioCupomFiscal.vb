Public Class frmRelatorioCupomFiscal
    Private Sub frmRelatorioCupomFiscal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'db_finalstopDataSet.tbvenda'. Você pode movê-la ou removê-la conforme necessário.
        Me.tbvendaTableAdapter.FillLastSale(Me.db_finalstopDataSet.tbvenda)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
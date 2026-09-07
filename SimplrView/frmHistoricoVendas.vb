Public Class frmHistoricoVendas
    Private Sub frmHistoricoVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'db_finalstopDataSet.tbvenda'. Você pode movê-la ou removê-la conforme necessário.
        tbvendaTableAdapter.Fill(db_finalstopDataSet.tbvenda)

        ReportViewer1.RefreshReport()
    End Sub
End Class
Public Class frmRelatorioCliente
    Private Sub frmRelatorioCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'db_finalstopDataSet.tbcliente'. Você pode movê-la ou removê-la conforme necessário.
        Me.tbclienteTableAdapter.Fill(Me.db_finalstopDataSet.tbcliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
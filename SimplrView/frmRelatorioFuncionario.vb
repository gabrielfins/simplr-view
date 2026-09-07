Public Class frmRelatorioFuncionario
    Private Sub frmRelatorioFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'db_finalstopDataSet.tbfuncionario'. Você pode movê-la ou removê-la conforme necessário.
        Me.tbfuncionarioTableAdapter.Fill(Me.db_finalstopDataSet.tbfuncionario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
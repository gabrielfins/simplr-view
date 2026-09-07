Public Class frmCadastroFornecedor

    Dim isCnpjValid As Boolean
    Dim moveFrm As MoveForm

    Public Structure MoveForm
        Dim x As Integer
        Dim y As Integer
    End Structure

    Private Sub ControlMouseDown(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseDown, PictureBox1.MouseDown, MyBase.MouseDown, Label1.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        moveFrm.x = Left - MousePosition.X
        moveFrm.y = Top - MousePosition.Y
    End Sub

    Private Sub ControlMouseMove(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseMove, PictureBox1.MouseMove, MyBase.MouseMove, Label1.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Left = moveFrm.x + MousePosition.X
        Top = moveFrm.y + MousePosition.Y
    End Sub

    Private Sub frmFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Db_finalstopDataSet.tbfornecedor'. Você pode movê-la ou removê-la conforme necessário.
        TbfornecedorTableAdapter.Fill(Db_finalstopDataSet.tbfornecedor)

        Dim funcs As New Functions
        For Each control In Controls
            If TypeOf control Is Panel And control IsNot pnlContent Then
                Dim pnl As Panel = DirectCast(control, Panel)
                pnl.BackColor = sysColor
            End If
        Next
        For Each btn As Button In gpbAcoes.Controls
            If btn.BackgroundImage IsNot Nothing Then
                Dim img = btn.BackgroundImage
                btn.BackgroundImage = funcs.SetImageColor(img)
            End If
        Next
    End Sub

    Public Sub AtivarCampos()
        For Each control In pnlContent.Controls
            If TypeOf control IsNot Label Then
                control.enabled = True
            End If
        Next
    End Sub

    Public Sub DesativarCampos()
        For Each control In pnlContent.Controls
            If TypeOf control IsNot Label Then
                control.enabled = False
            End If
        Next
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        TbfornecedorBindingSource.MovePrevious()
    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        TbfornecedorBindingSource.MoveNext()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        AtivarCampos()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim myMessage As New MyMessageBox
        If myMessage.ShowMessage("Deseja realmente apagar o registro?", "Simplr View", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
            Try
                TbfornecedorTableAdapter.Update(Db_finalstopDataSet.tbfornecedor)
                TbfornecedorBindingSource.RemoveCurrent()
                TbfornecedorTableAdapter.Update(Db_finalstopDataSet.tbfornecedor)
            Catch ex As Exception
                myMessage.ShowMessage("Não há registros para serem excluídos.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim myMessage As New MyMessageBox
        If Nome_fantasiaTextBox.Text.Trim = Nothing Or Nome_contatoTextBox.Text.Trim = Nothing Or Razao_socialTextBox.Text.Trim = Nothing Or Not isCnpjValid Or CepMaskedTextBox.MaskFull = False Or EstadoComboBox.Text.Trim = Nothing Or CidadeTextBox.Text.Trim = Nothing Or EnderecoTextBox.Text.Trim = Nothing Or Telefone1MaskedTextBox.MaskFull = False Or Telefone2MaskedTextBox.MaskFull = False Or EmailTextBox.Text.Trim = Nothing Then
            myMessage.ShowMessage("Preencha todos os campos corretamente para realizar o cadastro.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            TbfornecedorBindingSource.EndEdit()
            TbfornecedorTableAdapter.Update(Db_finalstopDataSet.tbfornecedor)
            TbfornecedorTableAdapter.Fill(Db_finalstopDataSet.tbfornecedor)
            myMessage.ShowMessage("Fornecedor salvo com sucesso!", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DesativarCampos()
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        TbfornecedorBindingSource.AddNew()
        AtivarCampos()
    End Sub

    Private Sub CnpjMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles CnpjMaskedTextBox.TextChanged
        Dim validacao As New Valida_CPF_CNPJ
        If CnpjMaskedTextBox.MaskFull Then
            validacao.cnpj = CnpjMaskedTextBox.Text
            If validacao.isCnpjValido And
               CnpjMaskedTextBox.Text <> "00,000,000/0000-00" And
               CnpjMaskedTextBox.Text <> "11,111,111/1111-11" And
               CnpjMaskedTextBox.Text <> "22,222,222/2222-22" And
               CnpjMaskedTextBox.Text <> "33,333,333/3333-33" And
               CnpjMaskedTextBox.Text <> "44,444,444/4444-44" And
               CnpjMaskedTextBox.Text <> "55,555,555/5555-55" And
               CnpjMaskedTextBox.Text <> "66,666,666/6666-66" And
               CnpjMaskedTextBox.Text <> "77,777,777/7777-77" And
               CnpjMaskedTextBox.Text <> "88,888,888/8888-88" And
               CnpjMaskedTextBox.Text <> "99,999,999/9999-99" Then
                lblValidador.Text = "CNPJ válido."
                lblValidador.ForeColor = Color.Green
                isCnpjValid = True
            Else
                lblValidador.Text = "CNPJ inválido."
                lblValidador.ForeColor = Color.DarkRed
                isCnpjValid = False
            End If
        Else
            lblValidador.Text = "..."
            lblValidador.ForeColor = Color.White
            isCnpjValid = False
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Dispose()
    End Sub
End Class
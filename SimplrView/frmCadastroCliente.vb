Public Class frmCadastroCliente

    Dim isCpfValid As Boolean
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

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Db_finalstopDataSet.tbcliente'. Você pode movê-la ou removê-la conforme necessário.
        TbclienteTableAdapter.Fill(Me.Db_finalstopDataSet.tbcliente)

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

    Private Sub CpfMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles CpfMaskedTextBox.TextChanged
        Dim validacao As New Valida_CPF_CNPJ
        If CpfMaskedTextBox.MaskFull Then
            validacao.cpf = CpfMaskedTextBox.Text
            If validacao.isCpfValido And
               CpfMaskedTextBox.Text <> "000,000,000-00" And
               CpfMaskedTextBox.Text <> "111,111,111-11" And
               CpfMaskedTextBox.Text <> "222,222,222-22" And
               CpfMaskedTextBox.Text <> "333,333,333-33" And
               CpfMaskedTextBox.Text <> "444,444,444-44" And
               CpfMaskedTextBox.Text <> "555,555,555-55" And
               CpfMaskedTextBox.Text <> "666,666,666-66" And
               CpfMaskedTextBox.Text <> "777,777,777-77" And
               CpfMaskedTextBox.Text <> "888,888,888-88" And
               CpfMaskedTextBox.Text <> "999,999,999-99" Then
                lblValidador.Text = "CPF válido."
                lblValidador.ForeColor = Color.Green
                isCpfValid = True
            Else
                lblValidador.Text = "CPF inválido."
                lblValidador.ForeColor = Color.DarkRed
                isCpfValid = False
            End If
        Else
            lblValidador.Text = "..."
            lblValidador.ForeColor = Color.White
            isCpfValid = False
        End If
    End Sub

    Public Sub AtivarCampos()
        For Each control In pnlContent.Controls
            If TypeOf control IsNot Label Then
                control.Enabled = True
            End If
        Next
    End Sub

    Public Sub DesativarCampos()
        For Each control In pnlContent.Controls
            If TypeOf control IsNot Label Then
                control.Enabled = False
            End If
        Next
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        TbclienteBindingSource.MovePrevious()
    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        TbclienteBindingSource.MoveNext()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        AtivarCampos()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim myMessage As New MyMessageBox
        Try
            If myMessage.ShowMessage("Deseja realmente apagar o registro?", "Simplr View", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
                TbclienteBindingSource.RemoveCurrent()
                TbclienteTableAdapter.Update(Db_finalstopDataSet.tbcliente)
            End If
        Catch ex As Exception
            myMessage.ShowMessage("Não há registros para serem excluídos.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim myMessage As New MyMessageBox
        If NomeTextBox.Text.Trim = Nothing Or Not isCpfValid Or TelefoneMaskedTextBox.MaskFull = False Or EmailTextBox.Text.Trim = Nothing Or CepMaskedTextBox.MaskFull = False Or EstadoComboBox.Text.Trim = Nothing Or CidadeTextBox.Text.Trim = Nothing Or EnderecoTextBox.Text.Trim = Nothing Then
            myMessage.ShowMessage("Preencha todos os campos corretamente para realizar o cadastro.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            TbclienteBindingSource.EndEdit()
            TbclienteTableAdapter.Update(Db_finalstopDataSet.tbcliente)
            myMessage.ShowMessage("Cliente salvo com sucesso!", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TbclienteTableAdapter.Fill(Db_finalstopDataSet.tbcliente)
            DesativarCampos()
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        TbclienteBindingSource.AddNew()
        AtivarCampos()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Dispose()
    End Sub
End Class
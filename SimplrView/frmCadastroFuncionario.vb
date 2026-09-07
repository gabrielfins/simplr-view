Public Class frmCadastroFuncionario

    Dim salvar(2) As Boolean
    Dim pasep, pasep2 As String
    Dim numeros(10), multiplicador As Integer
    Dim soma As Double
    Dim res As Integer
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

    Private Sub frmFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Db_finalstopDataSet.tbfuncionario'. Você pode movê-la ou removê-la conforme necessário.
        TbfuncionarioTableAdapter.Fill(Db_finalstopDataSet.tbfuncionario)

        Dim funcs As New Functions
        For Each control In Controls
            If TypeOf control Is Panel Then
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

    Private Sub CpfMaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles CpfMaskedTextBox.TextChanged
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
                salvar(0) = True
            Else
                lblValidador.Text = "CPF inválido."
                lblValidador.ForeColor = Color.Red
                salvar(0) = False
            End If
        Else
            lblValidador.Text = "..."
            lblValidador.ForeColor = Color.White
            salvar(0) = False
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        TbfuncionarioBindingSource.MovePrevious()
    End Sub
    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        TbfuncionarioBindingSource.MoveNext()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        AtivarCampos()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim myMessage As New MyMessageBox
        If myMessage.ShowMessage("Deseja realmente apagar o registro?", "Apagando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
            Try
                TbfuncionarioBindingSource.RemoveCurrent()
                TbfuncionarioTableAdapter.Update(Db_finalstopDataSet.tbfuncionario)
            Catch ex As Exception
                myMessage.ShowMessage("Não há registros para serem excluídos.", "Nenhum registro encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DesativarCampos()
            End Try
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim myMessage As New MyMessageBox
        If NomeTextBox1.Text.Trim = Nothing Or
           LoginTextBox1.Text.Trim = Nothing Or
           SenhaTextBox1.Text.Trim = Nothing Or
           TelefoneMaskedTextBox1.MaskFull = False Or
           EmailTextBox1.Text.Trim = Nothing Or
           NivelComboBox1.Text.Trim = Nothing Or
           GeneroComboBox1.Text.Trim = Nothing Or
           salvar(0) = False Or
           RgMaskedTextBox1.Text.Trim = Nothing Or
           salvar(1) = False Or
           Estado_civilComboBox1.Text.Trim = Nothing Or
           CepMaskedTextBox1.MaskFull = False Or
           EnderecoTextBox1.Text.Trim = Nothing Or
           CidadeTextBox1.Text.Trim = Nothing Or
           EstadoComboBox1.Text.Trim = Nothing Or
           BairroTextBox.Text.Trim = Nothing Or
           CargoComboBox1.Text.Trim = Nothing Or
           salvar(2) = False Or
           Data_admissaoMaskedTextBox1.MaskFull = False Then
            myMessage.ShowMessage("Preencha todos os campos obrigatrórios corretamente para realizar o cadastro.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            TbfuncionarioBindingSource.EndEdit()
            TbfuncionarioTableAdapter.Update(Db_finalstopDataSet.tbfuncionario)
            TbfuncionarioTableAdapter.Fill(Db_finalstopDataSet.tbfuncionario)
            myMessage.ShowMessage("Funcionário salvo com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DesativarCampos()
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        TbfuncionarioBindingSource.AddNew()
        AtivarCampos()
    End Sub

    Private Sub SalarioMaskedTextBox1_Leave(sender As Object, e As EventArgs) Handles SalarioMaskedTextBox1.Leave
        Try
            If SalarioMaskedTextBox1.Text <> Nothing And SalarioMaskedTextBox1.Text.ToLower = SalarioMaskedTextBox1.Text.ToUpper Or SalarioMaskedTextBox1.Text <> Nothing And SalarioMaskedTextBox1.Text = FormatCurrency(SalarioMaskedTextBox1.Text) Then
                SalarioMaskedTextBox1.Text = FormatCurrency(SalarioMaskedTextBox1.Text)
                salvar(2) = True
            Else
                salvar(2) = False
            End If
        Catch ex As Exception
            salvar(2) = False
        End Try
    End Sub

    Private Sub SalarioMaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles SalarioMaskedTextBox1.TextChanged
        Try
            If SalarioMaskedTextBox1.Text <> Nothing And SalarioMaskedTextBox1.Text.ToLower = SalarioMaskedTextBox1.Text.ToUpper Or SalarioMaskedTextBox1.Text <> Nothing And SalarioMaskedTextBox1.Text = FormatCurrency(SalarioMaskedTextBox1.Text) Then
                salvar(2) = True
            Else
                salvar(2) = False
            End If
        Catch ex As Exception
            salvar(2) = False
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Dispose()
    End Sub

    Private Sub PisMaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles PisMaskedTextBox1.TextChanged
        If PisMaskedTextBox1.MaskFull Then
            pasep = PisMaskedTextBox1.Text
            pasep2 = pasep.Substring(0, 3) + pasep.Substring(4, 5) + pasep.Substring(10, 2)

            multiplicador = 3
            soma = Nothing

            For i = 0 To 9
                numeros(i) = pasep2.Substring(i, 1)
                res = numeros(i) * multiplicador
                soma = soma + res
                res = 0
                multiplicador -= 1
                If multiplicador < 2 Then
                    multiplicador = 9
                End If
            Next
            soma = soma Mod 11
            soma = 11 - soma
            If soma = 10 Or soma = 11 Then
                soma = 0
            End If

            If soma = pasep.Substring(13, 1) Then
                lblValidadorPis.Text = "Pis/Pasep Válido"
                lblValidadorPis.ForeColor = Color.Green
                salvar(1) = True
            Else
                lblValidadorPis.Text = "Pis/Pasep Inválido"
                lblValidadorPis.ForeColor = Color.Red
                salvar(1) = False
            End If
        Else
            lblValidadorPis.Text = "..."
            lblValidadorPis.ForeColor = Color.White
            salvar(1) = False
        End If
    End Sub

    Private Sub pnlTop_Paint(sender As Object, e As PaintEventArgs) Handles pnlTop.Paint

    End Sub

    Public Sub AtivarCampos()
        For Each tbp As TabPage In tbcDados.TabPages
            For Each control In tbp.Controls
                If TypeOf control IsNot Label Then
                    control.Enabled = True
                End If
            Next
        Next
    End Sub

    Public Sub DesativarCampos()
        For Each tbp As TabPage In tbcDados.TabPages
            For Each control In tbp.Controls
                If TypeOf control IsNot Label Then
                    control.Enabled = False
                End If
            Next
        Next
    End Sub
End Class
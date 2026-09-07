Public Class frmCadastroProduto

    Dim salvar(2) As Boolean
    Dim foto, selectableImg As Image
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

    Private Sub frmProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Db_finalstopDataSet.tbfornecedor'. Você pode movê-la ou removê-la conforme necessário.
        TbfornecedorTableAdapter.Fill(Db_finalstopDataSet.tbfornecedor)
        'TODO: esta linha de código carrega dados na tabela 'Db_finalstopDataSet.tbproduto'. Você pode movê-la ou removê-la conforme necessário.
        TbprodutoTableAdapter.Fill(Db_finalstopDataSet.tbproduto)

        Dim funcs As New Functions
        selectableImg = funcs.SetImageColor(My.Resources.select_photo_2)

        FotoPictureBox.AllowDrop = True
        CheckImage()

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

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        TbprodutoBindingSource.MovePrevious()
    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        TbprodutoBindingSource.MoveNext()
    End Sub

    Private Sub btnRemoverFoto_Click(sender As Object, e As EventArgs) Handles btnRemoverFoto.Click
        FotoPictureBox.Image = Nothing
        CheckImage()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        AtivarCampos()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim myMessage As New MyMessageBox
        Try
            If myMessage.ShowMessage("Deseja realmente apagar o registro?", "Simplr View", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
                TbprodutoBindingSource.RemoveCurrent()
                TbprodutoTableAdapter.Update(Db_finalstopDataSet.tbproduto)
            End If
        Catch ex As Exception
            myMessage.ShowMessage("Não há registros para serem excluídos.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim myMessage As New MyMessageBox
        If NomeTextBox.Text.Trim = Nothing Or TipoComboBox.Text.Trim = Nothing Or FornecedorComboBox.Text.Trim = Nothing Or salvar(0) = False Or salvar(1) = False Or salvar(2) = False Or Numero_serieTextBox.Text.Trim = Nothing Then
            myMessage.ShowMessage("Preencha todos os campos corretamente para realizar o cadastro.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                TbprodutoBindingSource.EndEdit()
                TbprodutoTableAdapter.Update(Db_finalstopDataSet.tbproduto)
                TbprodutoTableAdapter.Fill(Db_finalstopDataSet.tbproduto)
                myMessage.ShowMessage("Produto salvo com sucesso!", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DesativarCampos()
            Catch ex As Exception
                myMessage.ShowMessage("A imagem inserida é muito grande. Tente com uma menor.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        TbprodutoBindingSource.AddNew()
        AtivarCampos()
    End Sub

    Private Sub CheckImage()
        foto = FotoPictureBox.Image
        If FotoPictureBox.Image Is Nothing Then
            FotoPictureBox.BackgroundImage = selectableImg
        Else
            FotoPictureBox.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub Preco_unitarioTextBox_TextChanged(sender As Object, e As EventArgs)
        Try
            If Preco_unitarioTextBox.Text <> Nothing And Preco_unitarioTextBox.Text = FormatCurrency(Preco_unitarioTextBox.Text) Or Preco_unitarioTextBox.Text <> Nothing And Preco_unitarioTextBox.Text.ToLower = Preco_unitarioTextBox.Text.ToUpper Then
                salvar(0) = True
            Else
                salvar(0) = False
            End If
        Catch ex As Exception
            salvar(0) = False
        End Try
    End Sub

    Private Sub Preco_vendaTextBox_TextChanged(sender As Object, e As EventArgs)
        Try
            If Preco_vendaTextBox.Text <> Nothing And Preco_vendaTextBox.Text = FormatCurrency(Preco_vendaTextBox.Text) Or Preco_vendaTextBox.Text <> Nothing And Preco_vendaTextBox.Text.ToLower = Preco_vendaTextBox.Text.ToUpper Then
                salvar(1) = True
            Else
                salvar(1) = False
            End If
        Catch ex As Exception
            salvar(1) = False
        End Try
    End Sub

    Private Sub QuantidadeTextBox_TextChanged(sender As Object, e As EventArgs) Handles QuantidadeTextBox.TextChanged
        If QuantidadeTextBox.Text.ToLower = QuantidadeTextBox.Text.ToUpper Then
            salvar(2) = True
        Else
            salvar(2) = False
        End If
    End Sub

    Private Sub cmbPesquisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPesquisa.SelectedIndexChanged
        tmrCheck.Start()
    End Sub

    Private Sub tmrCheck_Tick(sender As Object, e As EventArgs) Handles tmrCheck.Tick
        CheckImage()
        tmrCheck.Stop()
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

    Private Sub Preco_unitarioTextBox_Leave(sender As Object, e As EventArgs) Handles Preco_unitarioTextBox.Leave
        Try
            If Preco_unitarioTextBox.Text <> Nothing And Preco_unitarioTextBox.Text = FormatCurrency(Preco_unitarioTextBox.Text) Or Preco_unitarioTextBox.Text <> Nothing And Preco_unitarioTextBox.Text.ToLower = Preco_unitarioTextBox.Text.ToUpper Then
                Preco_unitarioTextBox.Text = FormatCurrency(Preco_unitarioTextBox.Text)
                salvar(0) = True
            Else
                salvar(0) = False
            End If
        Catch ex As Exception
            salvar(0) = False
        End Try

    End Sub

    Private Sub Preco_vendaTextBox_Leave(sender As Object, e As EventArgs) Handles Preco_vendaTextBox.Leave
        Try
            If Preco_vendaTextBox.Text <> Nothing And Preco_vendaTextBox.Text = FormatCurrency(Preco_vendaTextBox.Text) Or Preco_vendaTextBox.Text <> Nothing And Preco_vendaTextBox.Text.ToLower = Preco_vendaTextBox.Text.ToUpper Then
                Preco_vendaTextBox.Text = FormatCurrency(Preco_vendaTextBox.Text)
                salvar(1) = True
            Else
                salvar(1) = False
            End If
        Catch ex As Exception
            salvar(1) = False
        End Try
    End Sub

    Private Sub FotoPictureBox_DragDrop(sender As Object, e As DragEventArgs) Handles FotoPictureBox.DragDrop
        Dim myMessage As New MyMessageBox
        Dim data = e.Data.GetData(DataFormats.FileDrop)
        If data IsNot Nothing Then
            Try
                Dim filenames() As String = data
                If filenames.Length > 0 Then
                    FotoPictureBox.Image = Image.FromFile(filenames(0))
                    CheckImage()
                End If
            Catch ex As Exception
                myMessage.ShowMessage("O arquivo arrastado não é uma imagem válida. Verifique a extensão do arquivo e tente novamente.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CheckImage()
            End Try
        End If
    End Sub

    Private Sub FotoPictureBox_DragEnter(sender As Object, e As DragEventArgs) Handles FotoPictureBox.DragEnter
        e.Effect = DragDropEffects.Copy
        FotoPictureBox.BackgroundImage = selectableImg
        FotoPictureBox.Image = Nothing
    End Sub

    Private Sub FotoPictureBox_DragLeave(sender As Object, e As EventArgs) Handles FotoPictureBox.DragLeave
        FotoPictureBox.BackgroundImage = selectableImg
        FotoPictureBox.Image = foto
        CheckImage()
    End Sub

    Private Sub Preco_unitarioTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles Preco_unitarioTextBox.TextChanged
        Try
            If Preco_unitarioTextBox.Text <> Nothing And Preco_unitarioTextBox.Text = FormatCurrency(Preco_unitarioTextBox.Text) Or Preco_unitarioTextBox.Text <> Nothing And Preco_unitarioTextBox.Text.ToLower = Preco_unitarioTextBox.Text.ToUpper Then
                salvar(0) = True
            Else
                salvar(0) = False
            End If
        Catch ex As Exception
            salvar(0) = False
        End Try
    End Sub

    Private Sub Preco_vendaTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles Preco_vendaTextBox.TextChanged
        Try
            If Preco_vendaTextBox.Text <> Nothing And Preco_vendaTextBox.Text = FormatCurrency(Preco_vendaTextBox.Text) Or Preco_vendaTextBox.Text <> Nothing And Preco_vendaTextBox.Text.ToLower = Preco_vendaTextBox.Text.ToUpper Then
                salvar(1) = True
            Else
                salvar(1) = False
            End If
        Catch ex As Exception
            salvar(1) = False
        End Try
    End Sub

    Private Sub FotoPictureBox_Click(sender As Object, e As EventArgs) Handles FotoPictureBox.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = 1 Then
            FotoPictureBox.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Dispose()
    End Sub
End Class
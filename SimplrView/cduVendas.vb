Public Class cduVendas

    Dim cadastro As Boolean = False
    Dim relatorio As Boolean = False
    Dim sobre As Boolean = False
    Dim projetosFuturos As Boolean = False
    Dim mouseClicked As Boolean
    Dim total As Double
    Dim currentItem As Integer = 0
    Dim nomeProduto, quantidadeProduto, preco_unit As String
    Dim id_produto As String = Nothing

    Dim produtos(,) As String

    Private Sub cduVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbprodutoTableAdapter.Fill(Db_finalstopDataSet.tbproduto)
        TbclienteTableAdapter.Fill(Db_finalstopDataSet.tbcliente)
        cmbPagamento.SelectedIndex = 0
        Dim funcs As New Functions
        For Each control In Controls
            If TypeOf control Is Button Then
                Dim btn = DirectCast(control, Button)
                If btn.BackgroundImage IsNot Nothing Then
                    Dim img = btn.BackgroundImage
                    btn.BackgroundImage = funcs.SetImageColor(img)
                End If
            End If
        Next
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Dim myMessage As New MyMessageBox
        Try
            Dim id As Integer = cbbProdutos.SelectedValue
            Dim quantidade As Integer = nudQuantidade.Value
            TbprodutoTableAdapter.ConsultaProduto(Db_finalstopDataSet.tbproduto, id)
            Dim limite As Integer = Db_finalstopDataSet.Tables("tbProduto").Rows(0)("quantidade")
            If quantidade > limite Then
                myMessage.ShowMessage("A quantidade disponível em estoque desse produto é " + limite.ToString, "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TbprodutoTableAdapter.FillQuantidade(Db_finalstopDataSet.tbproduto)
                cbbProdutos.SelectedValue = id
                nudQuantidade.Value = 1
            Else
                lsvProdutos.Items.Add(Db_finalstopDataSet.Tables("tbProduto").Rows(0)("nome"))
                lsvProdutos.Items(currentItem).SubItems.Add(quantidade)
                lsvProdutos.Items(currentItem).SubItems.Add(Db_finalstopDataSet.Tables("tbProduto").Rows(0)("preco_venda"))
                lsvProdutos.Items(currentItem).SubItems.Add(id)
                Dim multiplicacao As Double = Double.Parse(CDec(lsvProdutos.Items(currentItem).SubItems(1).Text)) * Double.Parse(CDec(lsvProdutos.Items(currentItem).SubItems(2).Text))
                lsvProdutos.Items(currentItem).SubItems.Add(FormatCurrency(multiplicacao))


                Dim newQuantidade = Db_finalstopDataSet.Tables("tbProduto").Rows(0)("quantidade") - quantidade
                TbprodutoTableAdapter.UpdateQuantidade(newQuantidade, id)
                TbprodutoTableAdapter.FillQuantidade(Db_finalstopDataSet.tbproduto)
                cbbProdutos.SelectedValue = id
                nudQuantidade.Value = 1

                currentItem += 1
                tmrTotal.Start()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tmrTotal_Tick(sender As Object, e As EventArgs) Handles tmrTotal.Tick
        Dim precoTotal As Double
        For Each lstItem As ListViewItem In lsvProdutos.Items
            precoTotal += Double.Parse(CDec(lstItem.SubItems(4).Text))
            lblPrecoTotal.Text = FormatCurrency(precoTotal)
        Next
        tmrTotal.Stop()
    End Sub



    Private Sub btnFecharVenda_Click(sender As Object, e As EventArgs) Handles btnFecharVenda.Click
        Dim myMessage As New MyMessageBox
        If cmbCliente.Text.Trim = Nothing Or cmbPagamento.Text.Trim = Nothing Then
            myMessage.ShowMessage("Selecione cliente e forma de pagamento para continuar.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim linha As Integer = currentItem - 1
                Dim vetor(linha, 4) As String
                Dim sub_total_complete As String = Nothing

                nomeProduto = Nothing
                quantidadeProduto = Nothing
                preco_unit = Nothing

                For Each lstItem As ListViewItem In lsvProdutos.Items
                    Dim nome = lstItem.SubItems(0).Text
                    If nome.Length > 20 Then
                        nomeProduto += nome.Substring(0, 20) + "..." + vbCrLf
                    Else
                        nomeProduto += nome + vbCrLf
                    End If
                Next
                For Each lstItem As ListViewItem In lsvProdutos.Items
                    quantidadeProduto += lstItem.SubItems(1).Text + vbCrLf
                Next
                For Each lstItem As ListViewItem In lsvProdutos.Items
                    preco_unit += lstItem.SubItems(2).Text + vbCrLf
                Next
                For Each lstItem As ListViewItem In lsvProdutos.Items
                    id_produto += lstItem.SubItems(3).Text + vbCrLf
                Next
                For Each lstItem As ListViewItem In lsvProdutos.Items
                    sub_total_complete += lstItem.SubItems(4).Text + vbCrLf
                Next

                TbvendaTableAdapter.NewSale(userName, cmbCliente.Text, lblPrecoTotal.Text, cmbPagamento.Text, nomeProduto, quantidadeProduto, preco_unit, sub_total_complete, id_produto)
                lsvProdutos.Items.Clear()
                currentItem = 0
                myMessage.ShowMessage("Venda realizada com sucesso!", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Using frm As New frmRelatorioCupomFiscal
                    frm.ShowDialog()
                End Using
                lblPrecoTotal.Text = "R$ 0,00"
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        TbprodutoTableAdapter.FillQuantidade(Db_finalstopDataSet.tbproduto)
        TbclienteTableAdapter.Fill(Db_finalstopDataSet.tbcliente)
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        Try
            Dim id = lsvProdutos.SelectedItems(0).SubItems(3).Text
            TbprodutoTableAdapter.ConsultaProduto(Db_finalstopDataSet.tbproduto, id)
            Dim quantidade = Db_finalstopDataSet.Tables("tbProduto").Rows(0)("quantidade") + Integer.Parse(lsvProdutos.SelectedItems(0).SubItems(1).Text)
            TbprodutoTableAdapter.UpdateQuantidade(quantidade, id)

            lsvProdutos.Items.RemoveAt(lsvProdutos.SelectedIndices(0))
            currentItem -= 1

            TbprodutoTableAdapter.FillQuantidade(Db_finalstopDataSet.tbproduto)
            cbbProdutos.SelectedValue = id

            tmrTotal.Start()
            If lsvProdutos.Items.Count = 0 Then
                lblPrecoTotal.Text = "R$ 0,00"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub nudQuantidade_ValueChanged(sender As Object, e As EventArgs)
        Dim limite As Integer
        Try
            Dim id As Integer = cbbProdutos.SelectedValue
            TbprodutoTableAdapter.ConsultaProduto(Db_finalstopDataSet.tbproduto, id)
            limite =
            nudQuantidade.Maximum = limite
        Catch ex As Exception

        End Try
    End Sub

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cduVendas
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lsvProdutos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbbProdutos = New System.Windows.Forms.ComboBox()
        Me.TbprodutoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_finalstopDataSet = New SimplrView.db_finalstopDataSet()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.TbclienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.TbprodutoTableAdapter = New SimplrView.db_finalstopDataSetTableAdapters.tbprodutoTableAdapter()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnFecharVenda = New System.Windows.Forms.Button()
        Me.lblPrecoTotal = New System.Windows.Forms.Label()
        Me.tmrTotal = New System.Windows.Forms.Timer(Me.components)
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.TbclienteTableAdapter = New SimplrView.db_finalstopDataSetTableAdapters.tbclienteTableAdapter()
        Me.cmbPagamento = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbvendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbvendaTableAdapter = New SimplrView.db_finalstopDataSetTableAdapters.tbvendaTableAdapter()
        Me.TableAdapterManager = New SimplrView.db_finalstopDataSetTableAdapters.TableAdapterManager()
        Me.nudQuantidade = New System.Windows.Forms.NumericUpDown()
        Me.tltButtons = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.TbprodutoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbclienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbvendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lsvProdutos
        '
        Me.lsvProdutos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsvProdutos.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.lsvProdutos.FullRowSelect = True
        Me.lsvProdutos.HideSelection = False
        Me.lsvProdutos.Location = New System.Drawing.Point(87, 145)
        Me.lsvProdutos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lsvProdutos.MultiSelect = False
        Me.lsvProdutos.Name = "lsvProdutos"
        Me.lsvProdutos.Size = New System.Drawing.Size(521, 236)
        Me.lsvProdutos.TabIndex = 8
        Me.lsvProdutos.UseCompatibleStateImageBehavior = False
        Me.lsvProdutos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Produto"
        Me.ColumnHeader1.Width = 203
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Quantidade"
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Preço"
        Me.ColumnHeader3.Width = 99
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 4
        Me.ColumnHeader4.Text = "ID"
        Me.ColumnHeader4.Width = 54
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 3
        Me.ColumnHeader5.Text = "SubTotal"
        Me.ColumnHeader5.Width = 90
        '
        'cbbProdutos
        '
        Me.cbbProdutos.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.cbbProdutos.DataSource = Me.TbprodutoBindingSource
        Me.cbbProdutos.DisplayMember = "nome"
        Me.cbbProdutos.DropDownHeight = 102
        Me.cbbProdutos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbProdutos.ForeColor = System.Drawing.Color.White
        Me.cbbProdutos.FormattingEnabled = True
        Me.cbbProdutos.IntegralHeight = False
        Me.cbbProdutos.Location = New System.Drawing.Point(148, 104)
        Me.cbbProdutos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbbProdutos.Name = "cbbProdutos"
        Me.cbbProdutos.Size = New System.Drawing.Size(316, 25)
        Me.cbbProdutos.TabIndex = 5
        Me.cbbProdutos.ValueMember = "id_produto"
        '
        'TbprodutoBindingSource
        '
        Me.TbprodutoBindingSource.DataMember = "tbproduto"
        Me.TbprodutoBindingSource.DataSource = Me.Db_finalstopDataSet
        '
        'Db_finalstopDataSet
        '
        Me.Db_finalstopDataSet.DataSetName = "db_finalstopDataSet"
        Me.Db_finalstopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbCliente
        '
        Me.cmbCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.cmbCliente.DataSource = Me.TbclienteBindingSource
        Me.cmbCliente.DisplayMember = "nome"
        Me.cmbCliente.DropDownHeight = 102
        Me.cmbCliente.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.ForeColor = System.Drawing.Color.White
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.IntegralHeight = False
        Me.cmbCliente.Location = New System.Drawing.Point(85, 44)
        Me.cmbCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(265, 25)
        Me.cmbCliente.TabIndex = 1
        Me.cmbCliente.ValueMember = "nome"
        '
        'TbclienteBindingSource
        '
        Me.TbclienteBindingSource.DataMember = "tbcliente"
        Me.TbclienteBindingSource.DataSource = Me.Db_finalstopDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Produto"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackgroundImage = Global.SimplrView.My.Resources.Resources.add_circle_yellow
        Me.btnAdicionar.FlatAppearance.BorderSize = 0
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Location = New System.Drawing.Point(571, 98)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(36, 36)
        Me.btnAdicionar.TabIndex = 7
        Me.tltButtons.SetToolTip(Me.btnAdicionar, "Adicionar Produto")
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'TbprodutoTableAdapter
        '
        Me.TbprodutoTableAdapter.ClearBeforeFill = True
        '
        'btnRemover
        '
        Me.btnRemover.BackgroundImage = Global.SimplrView.My.Resources.Resources.remove_yellow
        Me.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemover.FlatAppearance.BorderSize = 0
        Me.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemover.Location = New System.Drawing.Point(129, 409)
        Me.btnRemover.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(36, 36)
        Me.btnRemover.TabIndex = 10
        Me.tltButtons.SetToolTip(Me.btnRemover, "Remover Produto")
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'btnFecharVenda
        '
        Me.btnFecharVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFecharVenda.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFecharVenda.Location = New System.Drawing.Point(269, 407)
        Me.btnFecharVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFecharVenda.Name = "btnFecharVenda"
        Me.btnFecharVenda.Size = New System.Drawing.Size(156, 41)
        Me.btnFecharVenda.TabIndex = 11
        Me.btnFecharVenda.Text = "Fechar Venda"
        Me.btnFecharVenda.UseVisualStyleBackColor = True
        '
        'lblPrecoTotal
        '
        Me.lblPrecoTotal.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecoTotal.Location = New System.Drawing.Point(501, 425)
        Me.lblPrecoTotal.Name = "lblPrecoTotal"
        Me.lblPrecoTotal.Size = New System.Drawing.Size(107, 20)
        Me.lblPrecoTotal.TabIndex = 13
        Me.lblPrecoTotal.Text = "R$ 0,00"
        Me.lblPrecoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrTotal
        '
        '
        'btnAtualizar
        '
        Me.btnAtualizar.BackgroundImage = Global.SimplrView.My.Resources.Resources.refresh_yellow
        Me.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtualizar.FlatAppearance.BorderSize = 0
        Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizar.Location = New System.Drawing.Point(87, 409)
        Me.btnAtualizar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(36, 36)
        Me.btnAtualizar.TabIndex = 9
        Me.tltButtons.SetToolTip(Me.btnAtualizar, "Atualizar Lista")
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'TbclienteTableAdapter
        '
        Me.TbclienteTableAdapter.ClearBeforeFill = True
        '
        'cmbPagamento
        '
        Me.cmbPagamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPagamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.cmbPagamento.DropDownHeight = 102
        Me.cmbPagamento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPagamento.ForeColor = System.Drawing.Color.White
        Me.cmbPagamento.FormattingEnabled = True
        Me.cmbPagamento.IntegralHeight = False
        Me.cmbPagamento.Items.AddRange(New Object() {"Dinheiro", "Cartão de débito", "Cartão de crédito"})
        Me.cmbPagamento.Location = New System.Drawing.Point(383, 44)
        Me.cmbPagamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbPagamento.Name = "cmbPagamento"
        Me.cmbPagamento.Size = New System.Drawing.Size(225, 25)
        Me.cmbPagamento.TabIndex = 3
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(380, 23)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(152, 17)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Forma de Pagamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(533, 400)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total"
        '
        'TbvendaBindingSource
        '
        Me.TbvendaBindingSource.DataMember = "tbvenda"
        Me.TbvendaBindingSource.DataSource = Me.Db_finalstopDataSet
        '
        'TbvendaTableAdapter
        '
        Me.TbvendaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbclienteTableAdapter = Me.TbclienteTableAdapter
        Me.TableAdapterManager.tbfornecedorTableAdapter = Nothing
        Me.TableAdapterManager.tbfuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.tbpersonalizacaoTableAdapter = Nothing
        Me.TableAdapterManager.tbprodutoTableAdapter = Me.TbprodutoTableAdapter
        Me.TableAdapterManager.tbvendaTableAdapter = Me.TbvendaTableAdapter
        Me.TableAdapterManager.UpdateOrder = SimplrView.db_finalstopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'nudQuantidade
        '
        Me.nudQuantidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.nudQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudQuantidade.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.nudQuantidade.ForeColor = System.Drawing.Color.White
        Me.nudQuantidade.Location = New System.Drawing.Point(481, 105)
        Me.nudQuantidade.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudQuantidade.Name = "nudQuantidade"
        Me.nudQuantidade.Size = New System.Drawing.Size(61, 23)
        Me.nudQuantidade.TabIndex = 6
        Me.nudQuantidade.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cduVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Controls.Add(Me.nudQuantidade)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.cmbPagamento)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.lblPrecoTotal)
        Me.Controls.Add(Me.btnFecharVenda)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.cbbProdutos)
        Me.Controls.Add(Me.lsvProdutos)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "cduVendas"
        Me.Size = New System.Drawing.Size(690, 470)
        CType(Me.TbprodutoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbclienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbvendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvProdutos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents cbbProdutos As ComboBox
    Friend WithEvents TbprodutoBindingSource As BindingSource
    Friend WithEvents Db_finalstopDataSet As db_finalstopDataSet
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents TbprodutoTableAdapter As db_finalstopDataSetTableAdapters.tbprodutoTableAdapter
    Friend WithEvents btnRemover As Button
    Friend WithEvents btnFecharVenda As Button
    Friend WithEvents lblPrecoTotal As Label
    Friend WithEvents tmrTotal As Timer
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents TbclienteBindingSource As BindingSource
    Friend WithEvents TbclienteTableAdapter As db_finalstopDataSetTableAdapters.tbclienteTableAdapter
    Friend WithEvents cmbPagamento As ComboBox
    Friend WithEvents label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbvendaBindingSource As BindingSource
    Friend WithEvents TbvendaTableAdapter As db_finalstopDataSetTableAdapters.tbvendaTableAdapter
    Friend WithEvents TableAdapterManager As db_finalstopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents nudQuantidade As NumericUpDown
    Friend WithEvents tltButtons As ToolTip
End Class

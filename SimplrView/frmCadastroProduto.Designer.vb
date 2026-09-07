<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroProduto
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NomeLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim FornecedorLabel As System.Windows.Forms.Label
        Dim Preco_unitarioLabel As System.Windows.Forms.Label
        Dim Preco_vendaLabel As System.Windows.Forms.Label
        Dim QuantidadeLabel As System.Windows.Forms.Label
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim Numero_serieLabel As System.Windows.Forms.Label
        Dim FotoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroProduto))
        Me.Db_finalstopDataSet = New SimplrView.db_finalstopDataSet()
        Me.TbprodutoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbprodutoTableAdapter = New SimplrView.db_finalstopDataSetTableAdapters.tbprodutoTableAdapter()
        Me.TableAdapterManager = New SimplrView.db_finalstopDataSetTableAdapters.TableAdapterManager()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cmbPesquisa = New System.Windows.Forms.ComboBox()
        Me.btnRemoverFoto = New System.Windows.Forms.Button()
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.TbfornecedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbfornecedorTableAdapter = New SimplrView.db_finalstopDataSetTableAdapters.tbfornecedorTableAdapter()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.TipoComboBox = New System.Windows.Forms.ComboBox()
        Me.FornecedorComboBox = New System.Windows.Forms.ComboBox()
        Me.Preco_unitarioTextBox = New System.Windows.Forms.TextBox()
        Me.Preco_vendaTextBox = New System.Windows.Forms.TextBox()
        Me.QuantidadeTextBox = New System.Windows.Forms.TextBox()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.Numero_serieTextBox = New System.Windows.Forms.TextBox()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpbAcoes = New System.Windows.Forms.GroupBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        NomeLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        FornecedorLabel = New System.Windows.Forms.Label()
        Preco_unitarioLabel = New System.Windows.Forms.Label()
        Preco_vendaLabel = New System.Windows.Forms.Label()
        QuantidadeLabel = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        Numero_serieLabel = New System.Windows.Forms.Label()
        FotoLabel = New System.Windows.Forms.Label()
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbprodutoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbfornecedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbAcoes.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(27, 12)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(44, 17)
        NomeLabel.TabIndex = 0
        NomeLabel.Text = "Nome"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(259, 68)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(32, 17)
        TipoLabel.TabIndex = 6
        TipoLabel.Text = "Tipo"
        '
        'FornecedorLabel
        '
        FornecedorLabel.AutoSize = True
        FornecedorLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FornecedorLabel.Location = New System.Drawing.Point(27, 68)
        FornecedorLabel.Name = "FornecedorLabel"
        FornecedorLabel.Size = New System.Drawing.Size(77, 17)
        FornecedorLabel.TabIndex = 4
        FornecedorLabel.Text = "Fornecedor"
        '
        'Preco_unitarioLabel
        '
        Preco_unitarioLabel.AutoSize = True
        Preco_unitarioLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Preco_unitarioLabel.Location = New System.Drawing.Point(28, 132)
        Preco_unitarioLabel.Name = "Preco_unitarioLabel"
        Preco_unitarioLabel.Size = New System.Drawing.Size(92, 17)
        Preco_unitarioLabel.TabIndex = 8
        Preco_unitarioLabel.Text = "Preço Unitário"
        '
        'Preco_vendaLabel
        '
        Preco_vendaLabel.AutoSize = True
        Preco_vendaLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Preco_vendaLabel.Location = New System.Drawing.Point(169, 132)
        Preco_vendaLabel.Name = "Preco_vendaLabel"
        Preco_vendaLabel.Size = New System.Drawing.Size(105, 17)
        Preco_vendaLabel.TabIndex = 10
        Preco_vendaLabel.Text = "Preço de Venda"
        '
        'QuantidadeLabel
        '
        QuantidadeLabel.AutoSize = True
        QuantidadeLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantidadeLabel.Location = New System.Drawing.Point(314, 12)
        QuantidadeLabel.Name = "QuantidadeLabel"
        QuantidadeLabel.Size = New System.Drawing.Size(80, 17)
        QuantidadeLabel.TabIndex = 2
        QuantidadeLabel.Text = "Quantidade"
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescricaoLabel.Location = New System.Drawing.Point(27, 197)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(69, 17)
        DescricaoLabel.TabIndex = 14
        DescricaoLabel.Text = "Descrição"
        '
        'Numero_serieLabel
        '
        Numero_serieLabel.AutoSize = True
        Numero_serieLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Numero_serieLabel.Location = New System.Drawing.Point(310, 132)
        Numero_serieLabel.Name = "Numero_serieLabel"
        Numero_serieLabel.Size = New System.Drawing.Size(107, 17)
        Numero_serieLabel.TabIndex = 12
        Numero_serieLabel.Text = "Número de Série"
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        FotoLabel.Location = New System.Drawing.Point(309, 197)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(35, 17)
        FotoLabel.TabIndex = 16
        FotoLabel.Text = "Foto"
        '
        'Db_finalstopDataSet
        '
        Me.Db_finalstopDataSet.DataSetName = "db_finalstopDataSet"
        Me.Db_finalstopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbprodutoBindingSource
        '
        Me.TbprodutoBindingSource.DataMember = "tbproduto"
        Me.TbprodutoBindingSource.DataSource = Me.Db_finalstopDataSet
        '
        'TbprodutoTableAdapter
        '
        Me.TbprodutoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbclienteTableAdapter = Nothing
        Me.TableAdapterManager.tbfornecedorTableAdapter = Nothing
        Me.TableAdapterManager.tbfuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.tbpersonalizacaoTableAdapter = Nothing
        Me.TableAdapterManager.tbprodutoTableAdapter = Me.TbprodutoTableAdapter
        Me.TableAdapterManager.tbvendaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SimplrView.db_finalstopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(141, 128)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 17)
        Me.label2.TabIndex = 5
        Me.label2.Text = "Pesquisa"
        '
        'cmbPesquisa
        '
        Me.cmbPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.cmbPesquisa.DataSource = Me.TbprodutoBindingSource
        Me.cmbPesquisa.DisplayMember = "nome"
        Me.cmbPesquisa.DropDownHeight = 102
        Me.cmbPesquisa.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPesquisa.ForeColor = System.Drawing.Color.White
        Me.cmbPesquisa.FormattingEnabled = True
        Me.cmbPesquisa.IntegralHeight = False
        Me.cmbPesquisa.Location = New System.Drawing.Point(144, 148)
        Me.cmbPesquisa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbPesquisa.Name = "cmbPesquisa"
        Me.cmbPesquisa.Size = New System.Drawing.Size(286, 25)
        Me.cmbPesquisa.TabIndex = 6
        Me.cmbPesquisa.ValueMember = "id_produto"
        '
        'btnRemoverFoto
        '
        Me.btnRemoverFoto.BackgroundImage = Global.SimplrView.My.Resources.Resources.remove
        Me.btnRemoverFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemoverFoto.Enabled = False
        Me.btnRemoverFoto.FlatAppearance.BorderSize = 0
        Me.btnRemoverFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRemoverFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoverFoto.Location = New System.Drawing.Point(438, 302)
        Me.btnRemoverFoto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemoverFoto.Name = "btnRemoverFoto"
        Me.btnRemoverFoto.Size = New System.Drawing.Size(36, 36)
        Me.btnRemoverFoto.TabIndex = 17
        Me.btnRemoverFoto.UseVisualStyleBackColor = True
        '
        'tmrCheck
        '
        Me.tmrCheck.Interval = 1
        '
        'TbfornecedorBindingSource
        '
        Me.TbfornecedorBindingSource.DataMember = "tbfornecedor"
        Me.TbfornecedorBindingSource.DataSource = Me.Db_finalstopDataSet
        '
        'TbfornecedorTableAdapter
        '
        Me.TbfornecedorTableAdapter.ClearBeforeFill = True
        '
        'NomeTextBox
        '
        Me.NomeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbprodutoBindingSource, "nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.ForeColor = System.Drawing.Color.White
        Me.NomeTextBox.Location = New System.Drawing.Point(30, 33)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(256, 22)
        Me.NomeTextBox.TabIndex = 1
        '
        'TipoComboBox
        '
        Me.TipoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TipoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TipoComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.TipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbprodutoBindingSource, "tipo", True))
        Me.TipoComboBox.DropDownHeight = 102
        Me.TipoComboBox.Enabled = False
        Me.TipoComboBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoComboBox.ForeColor = System.Drawing.Color.White
        Me.TipoComboBox.FormattingEnabled = True
        Me.TipoComboBox.IntegralHeight = False
        Me.TipoComboBox.Items.AddRange(New Object() {"Eletrodoméstico", "Eletroeletrônico", "Eletroportátil"})
        Me.TipoComboBox.Location = New System.Drawing.Point(262, 89)
        Me.TipoComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TipoComboBox.Name = "TipoComboBox"
        Me.TipoComboBox.Size = New System.Drawing.Size(171, 25)
        Me.TipoComboBox.TabIndex = 7
        '
        'FornecedorComboBox
        '
        Me.FornecedorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FornecedorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FornecedorComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.FornecedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbprodutoBindingSource, "fornecedor", True))
        Me.FornecedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbprodutoBindingSource, "fornecedor", True))
        Me.FornecedorComboBox.DataSource = Me.TbfornecedorBindingSource
        Me.FornecedorComboBox.DisplayMember = "nome_fantasia"
        Me.FornecedorComboBox.DropDownHeight = 102
        Me.FornecedorComboBox.Enabled = False
        Me.FornecedorComboBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FornecedorComboBox.ForeColor = System.Drawing.Color.White
        Me.FornecedorComboBox.FormattingEnabled = True
        Me.FornecedorComboBox.IntegralHeight = False
        Me.FornecedorComboBox.Location = New System.Drawing.Point(30, 89)
        Me.FornecedorComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FornecedorComboBox.Name = "FornecedorComboBox"
        Me.FornecedorComboBox.Size = New System.Drawing.Size(200, 25)
        Me.FornecedorComboBox.TabIndex = 5
        Me.FornecedorComboBox.ValueMember = "nome_fantasia"
        '
        'Preco_unitarioTextBox
        '
        Me.Preco_unitarioTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Preco_unitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbprodutoBindingSource, "preco_unitario", True))
        Me.Preco_unitarioTextBox.Enabled = False
        Me.Preco_unitarioTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Preco_unitarioTextBox.ForeColor = System.Drawing.Color.White
        Me.Preco_unitarioTextBox.Location = New System.Drawing.Point(30, 153)
        Me.Preco_unitarioTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Preco_unitarioTextBox.Name = "Preco_unitarioTextBox"
        Me.Preco_unitarioTextBox.Size = New System.Drawing.Size(116, 22)
        Me.Preco_unitarioTextBox.TabIndex = 9
        '
        'Preco_vendaTextBox
        '
        Me.Preco_vendaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Preco_vendaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbprodutoBindingSource, "preco_venda", True))
        Me.Preco_vendaTextBox.Enabled = False
        Me.Preco_vendaTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Preco_vendaTextBox.ForeColor = System.Drawing.Color.White
        Me.Preco_vendaTextBox.Location = New System.Drawing.Point(172, 153)
        Me.Preco_vendaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Preco_vendaTextBox.Name = "Preco_vendaTextBox"
        Me.Preco_vendaTextBox.Size = New System.Drawing.Size(114, 22)
        Me.Preco_vendaTextBox.TabIndex = 11
        '
        'QuantidadeTextBox
        '
        Me.QuantidadeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.QuantidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbprodutoBindingSource, "quantidade", True))
        Me.QuantidadeTextBox.Enabled = False
        Me.QuantidadeTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantidadeTextBox.ForeColor = System.Drawing.Color.White
        Me.QuantidadeTextBox.Location = New System.Drawing.Point(317, 33)
        Me.QuantidadeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QuantidadeTextBox.Name = "QuantidadeTextBox"
        Me.QuantidadeTextBox.Size = New System.Drawing.Size(116, 22)
        Me.QuantidadeTextBox.TabIndex = 3
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbprodutoBindingSource, "descricao", True))
        Me.DescricaoTextBox.Enabled = False
        Me.DescricaoTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescricaoTextBox.ForeColor = System.Drawing.Color.White
        Me.DescricaoTextBox.Location = New System.Drawing.Point(30, 218)
        Me.DescricaoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DescricaoTextBox.Multiline = True
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescricaoTextBox.Size = New System.Drawing.Size(256, 88)
        Me.DescricaoTextBox.TabIndex = 15
        '
        'Numero_serieTextBox
        '
        Me.Numero_serieTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Numero_serieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbprodutoBindingSource, "numero_serie", True))
        Me.Numero_serieTextBox.Enabled = False
        Me.Numero_serieTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero_serieTextBox.ForeColor = System.Drawing.Color.White
        Me.Numero_serieTextBox.Location = New System.Drawing.Point(313, 153)
        Me.Numero_serieTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Numero_serieTextBox.Name = "Numero_serieTextBox"
        Me.Numero_serieTextBox.Size = New System.Drawing.Size(120, 22)
        Me.Numero_serieTextBox.TabIndex = 13
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.BackgroundImage = Global.SimplrView.My.Resources.Resources.select_photo_2
        Me.FotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TbprodutoBindingSource, "foto", True))
        Me.FotoPictureBox.Enabled = False
        Me.FotoPictureBox.Location = New System.Drawing.Point(312, 218)
        Me.FotoPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(120, 120)
        Me.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FotoPictureBox.TabIndex = 52
        Me.FotoPictureBox.TabStop = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.btnFechar)
        Me.pnlTop.Controls.Add(Me.PictureBox1)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(570, 100)
        Me.pnlTop.TabIndex = 0
        '
        'btnFechar
        '
        Me.btnFechar.BackgroundImage = Global.SimplrView.My.Resources.Resources.close
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Location = New System.Drawing.Point(540, 0)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(30, 30)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.TabStop = False
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SimplrView.My.Resources.Resources.produto
        Me.PictureBox1.Location = New System.Drawing.Point(14, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(92, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastro de Produtos"
        '
        'gpbAcoes
        '
        Me.gpbAcoes.Controls.Add(Me.btnAdicionar)
        Me.gpbAcoes.Controls.Add(Me.btnExcluir)
        Me.gpbAcoes.Controls.Add(Me.btnProximo)
        Me.gpbAcoes.Controls.Add(Me.btnSalvar)
        Me.gpbAcoes.Controls.Add(Me.btnEditar)
        Me.gpbAcoes.Controls.Add(Me.btnAnterior)
        Me.gpbAcoes.ForeColor = System.Drawing.Color.White
        Me.gpbAcoes.Location = New System.Drawing.Point(154, 551)
        Me.gpbAcoes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbAcoes.Name = "gpbAcoes"
        Me.gpbAcoes.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbAcoes.Size = New System.Drawing.Size(262, 76)
        Me.gpbAcoes.TabIndex = 8
        Me.gpbAcoes.TabStop = False
        Me.gpbAcoes.Text = "Ações"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackgroundImage = Global.SimplrView.My.Resources.Resources.add
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdicionar.FlatAppearance.BorderSize = 0
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Location = New System.Drawing.Point(219, 25)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(36, 36)
        Me.btnAdicionar.TabIndex = 5
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.SimplrView.My.Resources.Resources.trash
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Location = New System.Drawing.Point(133, 25)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(36, 36)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnProximo
        '
        Me.btnProximo.BackgroundImage = Global.SimplrView.My.Resources.Resources.arrow_right
        Me.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProximo.FlatAppearance.BorderSize = 0
        Me.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProximo.Location = New System.Drawing.Point(49, 25)
        Me.btnProximo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(36, 36)
        Me.btnProximo.TabIndex = 1
        Me.btnProximo.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.SimplrView.My.Resources.Resources.save
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(177, 25)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(36, 36)
        Me.btnSalvar.TabIndex = 4
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.SimplrView.My.Resources.Resources.edit
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(91, 25)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(36, 36)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.BackgroundImage = Global.SimplrView.My.Resources.Resources.arrow_left
        Me.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAnterior.FlatAppearance.BorderSize = 0
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Location = New System.Drawing.Point(7, 25)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(36, 36)
        Me.btnAnterior.TabIndex = 0
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(FotoLabel)
        Me.pnlContent.Controls.Add(Me.FotoPictureBox)
        Me.pnlContent.Controls.Add(Numero_serieLabel)
        Me.pnlContent.Controls.Add(Me.Numero_serieTextBox)
        Me.pnlContent.Controls.Add(DescricaoLabel)
        Me.pnlContent.Controls.Add(Me.DescricaoTextBox)
        Me.pnlContent.Controls.Add(QuantidadeLabel)
        Me.pnlContent.Controls.Add(Me.QuantidadeTextBox)
        Me.pnlContent.Controls.Add(Preco_vendaLabel)
        Me.pnlContent.Controls.Add(Me.Preco_vendaTextBox)
        Me.pnlContent.Controls.Add(Preco_unitarioLabel)
        Me.pnlContent.Controls.Add(Me.Preco_unitarioTextBox)
        Me.pnlContent.Controls.Add(FornecedorLabel)
        Me.pnlContent.Controls.Add(Me.FornecedorComboBox)
        Me.pnlContent.Controls.Add(TipoLabel)
        Me.pnlContent.Controls.Add(Me.TipoComboBox)
        Me.pnlContent.Controls.Add(NomeLabel)
        Me.pnlContent.Controls.Add(Me.NomeTextBox)
        Me.pnlContent.Controls.Add(Me.btnRemoverFoto)
        Me.pnlContent.Location = New System.Drawing.Point(35, 188)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(501, 351)
        Me.pnlContent.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(1, 639)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(568, 1)
        Me.Panel4.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(569, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 540)
        Me.Panel3.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 540)
        Me.Panel2.TabIndex = 2
        '
        'frmCadastroProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 640)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.gpbAcoes)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.cmbPesquisa)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCadastroProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simplr View"
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbprodutoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbfornecedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbAcoes.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_finalstopDataSet As db_finalstopDataSet
    Friend WithEvents TbprodutoBindingSource As BindingSource
    Friend WithEvents TbprodutoTableAdapter As db_finalstopDataSetTableAdapters.tbprodutoTableAdapter
    Friend WithEvents TableAdapterManager As db_finalstopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents label2 As Label
    Friend WithEvents cmbPesquisa As ComboBox
    Friend WithEvents btnRemoverFoto As Button
    Friend WithEvents tmrCheck As Timer
    Friend WithEvents TbfornecedorBindingSource As BindingSource
    Friend WithEvents TbfornecedorTableAdapter As db_finalstopDataSetTableAdapters.tbfornecedorTableAdapter
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents TipoComboBox As ComboBox
    Friend WithEvents FornecedorComboBox As ComboBox
    Friend WithEvents Preco_unitarioTextBox As TextBox
    Friend WithEvents Preco_vendaTextBox As TextBox
    Friend WithEvents QuantidadeTextBox As TextBox
    Friend WithEvents DescricaoTextBox As TextBox
    Friend WithEvents Numero_serieTextBox As TextBox
    Friend WithEvents FotoPictureBox As PictureBox
    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnFechar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gpbAcoes As GroupBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnProximo As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroCliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
        Dim CepLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim CpfLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroCliente))
        Me.Db_finalstopDataSet = New SimplrView.db_finalstopDataSet()
        Me.TbclienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbclienteTableAdapter = New SimplrView.db_finalstopDataSetTableAdapters.tbclienteTableAdapter()
        Me.TableAdapterManager = New SimplrView.db_finalstopDataSetTableAdapters.TableAdapterManager()
        Me.CepMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TelefoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.gpbAcoes = New System.Windows.Forms.GroupBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cmbPesquisa = New System.Windows.Forms.ComboBox()
        Me.lblValidador = New System.Windows.Forms.Label()
        Me.CpfMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnlContent = New System.Windows.Forms.Panel()
        CepLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        CpfLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbclienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbAcoes.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'CepLabel
        '
        CepLabel.AutoSize = True
        CepLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CepLabel.Location = New System.Drawing.Point(59, 141)
        CepLabel.Name = "CepLabel"
        CepLabel.Size = New System.Drawing.Size(30, 17)
        CepLabel.TabIndex = 9
        CepLabel.Text = "CEP"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.Location = New System.Drawing.Point(59, 79)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(59, 17)
        TelefoneLabel.TabIndex = 5
        TelefoneLabel.Text = "Telefone"
        '
        'CpfLabel
        '
        CpfLabel.AutoSize = True
        CpfLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CpfLabel.Location = New System.Drawing.Point(322, 18)
        CpfLabel.Name = "CpfLabel"
        CpfLabel.Size = New System.Drawing.Size(30, 17)
        CpfLabel.TabIndex = 2
        CpfLabel.Text = "CPF"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(356, 200)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(48, 17)
        EstadoLabel.TabIndex = 15
        EstadoLabel.Text = "Estado"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CidadeLabel.Location = New System.Drawing.Point(59, 203)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(52, 17)
        CidadeLabel.TabIndex = 13
        CidadeLabel.Text = "Cidade"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EnderecoLabel.Location = New System.Drawing.Point(163, 141)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(65, 17)
        EnderecoLabel.TabIndex = 11
        EnderecoLabel.Text = "Endereço"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(193, 79)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(43, 17)
        EmailLabel.TabIndex = 7
        EmailLabel.Text = "E-mail"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(58, 18)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(44, 17)
        NomeLabel.TabIndex = 0
        NomeLabel.Text = "Nome"
        '
        'Db_finalstopDataSet
        '
        Me.Db_finalstopDataSet.DataSetName = "db_finalstopDataSet"
        Me.Db_finalstopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbclienteBindingSource
        '
        Me.TbclienteBindingSource.DataMember = "tbcliente"
        Me.TbclienteBindingSource.DataSource = Me.Db_finalstopDataSet
        '
        'TbclienteTableAdapter
        '
        Me.TbclienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbclienteTableAdapter = Me.TbclienteTableAdapter
        Me.TableAdapterManager.tbfornecedorTableAdapter = Nothing
        Me.TableAdapterManager.tbfuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.tbpersonalizacaoTableAdapter = Nothing
        Me.TableAdapterManager.tbprodutoTableAdapter = Nothing
        Me.TableAdapterManager.tbvendaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SimplrView.db_finalstopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CepMaskedTextBox
        '
        Me.CepMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.CepMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclienteBindingSource, "cep", True))
        Me.CepMaskedTextBox.Enabled = False
        Me.CepMaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CepMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.CepMaskedTextBox.Location = New System.Drawing.Point(62, 162)
        Me.CepMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CepMaskedTextBox.Mask = "00000-000"
        Me.CepMaskedTextBox.Name = "CepMaskedTextBox"
        Me.CepMaskedTextBox.Size = New System.Drawing.Size(73, 22)
        Me.CepMaskedTextBox.TabIndex = 10
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclienteBindingSource, "telefone", True))
        Me.TelefoneMaskedTextBox.Enabled = False
        Me.TelefoneMaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefoneMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(62, 100)
        Me.TelefoneMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TelefoneMaskedTextBox.Mask = "(00) 00000-0000"
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(105, 22)
        Me.TelefoneMaskedTextBox.TabIndex = 6
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
        Me.gpbAcoes.Location = New System.Drawing.Point(154, 501)
        Me.gpbAcoes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbAcoes.Name = "gpbAcoes"
        Me.gpbAcoes.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbAcoes.Size = New System.Drawing.Size(262, 76)
        Me.gpbAcoes.TabIndex = 7
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
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(141, 128)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 17)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Pesquisa"
        '
        'cmbPesquisa
        '
        Me.cmbPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.cmbPesquisa.DataSource = Me.TbclienteBindingSource
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
        Me.cmbPesquisa.TabIndex = 5
        Me.cmbPesquisa.ValueMember = "id_cliente"
        '
        'lblValidador
        '
        Me.lblValidador.AutoSize = True
        Me.lblValidador.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidador.Location = New System.Drawing.Point(322, 65)
        Me.lblValidador.Name = "lblValidador"
        Me.lblValidador.Size = New System.Drawing.Size(17, 17)
        Me.lblValidador.TabIndex = 4
        Me.lblValidador.Text = "..."
        '
        'CpfMaskedTextBox
        '
        Me.CpfMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.CpfMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclienteBindingSource, "cpf", True))
        Me.CpfMaskedTextBox.Enabled = False
        Me.CpfMaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpfMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.CpfMaskedTextBox.Location = New System.Drawing.Point(325, 39)
        Me.CpfMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CpfMaskedTextBox.Mask = "000,000,000-00"
        Me.CpfMaskedTextBox.Name = "CpfMaskedTextBox"
        Me.CpfMaskedTextBox.Size = New System.Drawing.Size(104, 22)
        Me.CpfMaskedTextBox.TabIndex = 3
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EstadoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EstadoComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclienteBindingSource, "estado", True))
        Me.EstadoComboBox.DropDownHeight = 102
        Me.EstadoComboBox.Enabled = False
        Me.EstadoComboBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoComboBox.ForeColor = System.Drawing.Color.White
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.IntegralHeight = False
        Me.EstadoComboBox.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.EstadoComboBox.Location = New System.Drawing.Point(359, 221)
        Me.EstadoComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(70, 25)
        Me.EstadoComboBox.TabIndex = 16
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclienteBindingSource, "cidade", True))
        Me.CidadeTextBox.Enabled = False
        Me.CidadeTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTextBox.ForeColor = System.Drawing.Color.White
        Me.CidadeTextBox.Location = New System.Drawing.Point(62, 224)
        Me.CidadeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(278, 22)
        Me.CidadeTextBox.TabIndex = 14
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclienteBindingSource, "endereco", True))
        Me.EnderecoTextBox.Enabled = False
        Me.EnderecoTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnderecoTextBox.ForeColor = System.Drawing.Color.White
        Me.EnderecoTextBox.Location = New System.Drawing.Point(166, 162)
        Me.EnderecoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(263, 22)
        Me.EnderecoTextBox.TabIndex = 12
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclienteBindingSource, "email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.ForeColor = System.Drawing.Color.White
        Me.EmailTextBox.Location = New System.Drawing.Point(196, 100)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(233, 22)
        Me.EmailTextBox.TabIndex = 8
        '
        'NomeTextBox
        '
        Me.NomeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclienteBindingSource, "nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.ForeColor = System.Drawing.Color.White
        Me.NomeTextBox.Location = New System.Drawing.Point(61, 39)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(243, 22)
        Me.NomeTextBox.TabIndex = 1
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.btnFechar)
        Me.pnlTop.Controls.Add(Me.PictureBox1)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
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
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(30, 30)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.TabStop = False
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SimplrView.My.Resources.Resources.cliente
        Me.PictureBox1.Location = New System.Drawing.Point(14, 14)
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
        Me.Label1.Size = New System.Drawing.Size(379, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastro de Clientes"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 490)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(569, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 490)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(1, 589)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(568, 1)
        Me.Panel4.TabIndex = 3
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.CpfMaskedTextBox)
        Me.pnlContent.Controls.Add(Me.NomeTextBox)
        Me.pnlContent.Controls.Add(NomeLabel)
        Me.pnlContent.Controls.Add(Me.EmailTextBox)
        Me.pnlContent.Controls.Add(CepLabel)
        Me.pnlContent.Controls.Add(EmailLabel)
        Me.pnlContent.Controls.Add(Me.CepMaskedTextBox)
        Me.pnlContent.Controls.Add(Me.EnderecoTextBox)
        Me.pnlContent.Controls.Add(TelefoneLabel)
        Me.pnlContent.Controls.Add(EnderecoLabel)
        Me.pnlContent.Controls.Add(Me.TelefoneMaskedTextBox)
        Me.pnlContent.Controls.Add(Me.CidadeTextBox)
        Me.pnlContent.Controls.Add(CidadeLabel)
        Me.pnlContent.Controls.Add(Me.EstadoComboBox)
        Me.pnlContent.Controls.Add(EstadoLabel)
        Me.pnlContent.Controls.Add(Me.lblValidador)
        Me.pnlContent.Controls.Add(CpfLabel)
        Me.pnlContent.Location = New System.Drawing.Point(42, 190)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(487, 264)
        Me.pnlContent.TabIndex = 6
        '
        'frmCadastroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 590)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.gpbAcoes)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.cmbPesquisa)
        Me.Controls.Add(Me.pnlContent)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCadastroCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simplr View"
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbclienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbAcoes.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_finalstopDataSet As db_finalstopDataSet
    Friend WithEvents TbclienteBindingSource As BindingSource
    Friend WithEvents TbclienteTableAdapter As db_finalstopDataSetTableAdapters.tbclienteTableAdapter
    Friend WithEvents TableAdapterManager As db_finalstopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CepMaskedTextBox As MaskedTextBox
    Friend WithEvents TelefoneMaskedTextBox As MaskedTextBox
    Friend WithEvents gpbAcoes As GroupBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnProximo As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents label2 As Label
    Friend WithEvents cmbPesquisa As ComboBox
    Friend WithEvents lblValidador As Label
    Friend WithEvents CpfMaskedTextBox As MaskedTextBox
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents EnderecoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents pnlTop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFechar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnlContent As Panel
End Class

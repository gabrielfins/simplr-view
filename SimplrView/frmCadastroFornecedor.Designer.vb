<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroFornecedor
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
        Dim Nome_contatoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Telefone2Label As System.Windows.Forms.Label
        Dim Telefone1Label As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CepLabel As System.Windows.Forms.Label
        Dim CnpjLabel As System.Windows.Forms.Label
        Dim Razao_socialLabel As System.Windows.Forms.Label
        Dim Nome_fantasiaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroFornecedor))
        Me.Db_finalstopDataSet = New SimplrView.db_finalstopDataSet()
        Me.TbfornecedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbfornecedorTableAdapter = New SimplrView.db_finalstopDataSetTableAdapters.tbfornecedorTableAdapter()
        Me.TableAdapterManager = New SimplrView.db_finalstopDataSetTableAdapters.TableAdapterManager()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cmbPesquisa = New System.Windows.Forms.ComboBox()
        Me.Nome_contatoTextBox = New System.Windows.Forms.TextBox()
        Me.lblValidador = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Telefone2MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Telefone1MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.CepMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CnpjMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Razao_socialTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_fantasiaTextBox = New System.Windows.Forms.TextBox()
        Me.gpbAcoes = New System.Windows.Forms.GroupBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Nome_contatoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Telefone2Label = New System.Windows.Forms.Label()
        Telefone1Label = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CepLabel = New System.Windows.Forms.Label()
        CnpjLabel = New System.Windows.Forms.Label()
        Razao_socialLabel = New System.Windows.Forms.Label()
        Nome_fantasiaLabel = New System.Windows.Forms.Label()
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbfornecedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbAcoes.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nome_contatoLabel
        '
        Nome_contatoLabel.AutoSize = True
        Nome_contatoLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_contatoLabel.Location = New System.Drawing.Point(53, 138)
        Nome_contatoLabel.Name = "Nome_contatoLabel"
        Nome_contatoLabel.Size = New System.Drawing.Size(116, 17)
        Nome_contatoLabel.TabIndex = 7
        Nome_contatoLabel.Text = "Nome do Contato"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(299, 254)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(43, 17)
        EmailLabel.TabIndex = 21
        EmailLabel.Text = "E-mail"
        '
        'Telefone2Label
        '
        Telefone2Label.AutoSize = True
        Telefone2Label.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telefone2Label.Location = New System.Drawing.Point(173, 254)
        Telefone2Label.Name = "Telefone2Label"
        Telefone2Label.Size = New System.Drawing.Size(50, 17)
        Telefone2Label.TabIndex = 19
        Telefone2Label.Text = "Celular"
        '
        'Telefone1Label
        '
        Telefone1Label.AutoSize = True
        Telefone1Label.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telefone1Label.Location = New System.Drawing.Point(53, 254)
        Telefone1Label.Name = "Telefone1Label"
        Telefone1Label.Size = New System.Drawing.Size(85, 17)
        Telefone1Label.TabIndex = 17
        Telefone1Label.Text = "Telefone Fixo"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EnderecoLabel.Location = New System.Drawing.Point(156, 195)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(65, 17)
        EnderecoLabel.TabIndex = 13
        EnderecoLabel.Text = "Endereço"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CidadeLabel.Location = New System.Drawing.Point(293, 138)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(52, 17)
        CidadeLabel.TabIndex = 9
        CidadeLabel.Text = "Cidade"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(53, 195)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(48, 17)
        EstadoLabel.TabIndex = 11
        EstadoLabel.Text = "Estado"
        '
        'CepLabel
        '
        CepLabel.AutoSize = True
        CepLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CepLabel.Location = New System.Drawing.Point(391, 195)
        CepLabel.Name = "CepLabel"
        CepLabel.Size = New System.Drawing.Size(30, 17)
        CepLabel.TabIndex = 15
        CepLabel.Text = "CEP"
        '
        'CnpjLabel
        '
        CnpjLabel.AutoSize = True
        CnpjLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CnpjLabel.Location = New System.Drawing.Point(345, 13)
        CnpjLabel.Name = "CnpjLabel"
        CnpjLabel.Size = New System.Drawing.Size(39, 17)
        CnpjLabel.TabIndex = 2
        CnpjLabel.Text = "CNPJ"
        '
        'Razao_socialLabel
        '
        Razao_socialLabel.AutoSize = True
        Razao_socialLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Razao_socialLabel.Location = New System.Drawing.Point(53, 75)
        Razao_socialLabel.Name = "Razao_socialLabel"
        Razao_socialLabel.Size = New System.Drawing.Size(84, 17)
        Razao_socialLabel.TabIndex = 5
        Razao_socialLabel.Text = "Razão Social"
        '
        'Nome_fantasiaLabel
        '
        Nome_fantasiaLabel.AutoSize = True
        Nome_fantasiaLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_fantasiaLabel.Location = New System.Drawing.Point(53, 13)
        Nome_fantasiaLabel.Name = "Nome_fantasiaLabel"
        Nome_fantasiaLabel.Size = New System.Drawing.Size(97, 17)
        Nome_fantasiaLabel.TabIndex = 0
        Nome_fantasiaLabel.Text = "Nome Fantasia"
        '
        'Db_finalstopDataSet
        '
        Me.Db_finalstopDataSet.DataSetName = "db_finalstopDataSet"
        Me.Db_finalstopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbclienteTableAdapter = Nothing
        Me.TableAdapterManager.tbfornecedorTableAdapter = Me.TbfornecedorTableAdapter
        Me.TableAdapterManager.tbfuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.tbpersonalizacaoTableAdapter = Nothing
        Me.TableAdapterManager.tbprodutoTableAdapter = Nothing
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
        Me.label2.TabIndex = 4
        Me.label2.Text = "Pesquisa"
        '
        'cmbPesquisa
        '
        Me.cmbPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.cmbPesquisa.DataSource = Me.TbfornecedorBindingSource
        Me.cmbPesquisa.DisplayMember = "nome_fantasia"
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
        Me.cmbPesquisa.ValueMember = "id_Fornecedor"
        '
        'Nome_contatoTextBox
        '
        Me.Nome_contatoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Nome_contatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecedorBindingSource, "nome_contato", True))
        Me.Nome_contatoTextBox.Enabled = False
        Me.Nome_contatoTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_contatoTextBox.ForeColor = System.Drawing.Color.White
        Me.Nome_contatoTextBox.Location = New System.Drawing.Point(56, 159)
        Me.Nome_contatoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_contatoTextBox.Name = "Nome_contatoTextBox"
        Me.Nome_contatoTextBox.Size = New System.Drawing.Size(219, 22)
        Me.Nome_contatoTextBox.TabIndex = 8
        '
        'lblValidador
        '
        Me.lblValidador.AutoSize = True
        Me.lblValidador.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidador.Location = New System.Drawing.Point(345, 60)
        Me.lblValidador.Name = "lblValidador"
        Me.lblValidador.Size = New System.Drawing.Size(17, 17)
        Me.lblValidador.TabIndex = 4
        Me.lblValidador.Text = "..."
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecedorBindingSource, "email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.ForeColor = System.Drawing.Color.White
        Me.EmailTextBox.Location = New System.Drawing.Point(302, 275)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(173, 22)
        Me.EmailTextBox.TabIndex = 22
        '
        'Telefone2MaskedTextBox
        '
        Me.Telefone2MaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Telefone2MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecedorBindingSource, "telefone2", True))
        Me.Telefone2MaskedTextBox.Enabled = False
        Me.Telefone2MaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefone2MaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.Telefone2MaskedTextBox.Location = New System.Drawing.Point(176, 275)
        Me.Telefone2MaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Telefone2MaskedTextBox.Mask = "(00) 00000-0000"
        Me.Telefone2MaskedTextBox.Name = "Telefone2MaskedTextBox"
        Me.Telefone2MaskedTextBox.Size = New System.Drawing.Size(102, 22)
        Me.Telefone2MaskedTextBox.TabIndex = 20
        '
        'Telefone1MaskedTextBox
        '
        Me.Telefone1MaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Telefone1MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecedorBindingSource, "telefone1", True))
        Me.Telefone1MaskedTextBox.Enabled = False
        Me.Telefone1MaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefone1MaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.Telefone1MaskedTextBox.Location = New System.Drawing.Point(56, 275)
        Me.Telefone1MaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Telefone1MaskedTextBox.Mask = "(00) 0000-0000"
        Me.Telefone1MaskedTextBox.Name = "Telefone1MaskedTextBox"
        Me.Telefone1MaskedTextBox.Size = New System.Drawing.Size(96, 22)
        Me.Telefone1MaskedTextBox.TabIndex = 18
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecedorBindingSource, "endereco", True))
        Me.EnderecoTextBox.Enabled = False
        Me.EnderecoTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnderecoTextBox.ForeColor = System.Drawing.Color.White
        Me.EnderecoTextBox.Location = New System.Drawing.Point(159, 216)
        Me.EnderecoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(216, 22)
        Me.EnderecoTextBox.TabIndex = 14
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecedorBindingSource, "cidade", True))
        Me.CidadeTextBox.Enabled = False
        Me.CidadeTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTextBox.ForeColor = System.Drawing.Color.White
        Me.CidadeTextBox.Location = New System.Drawing.Point(296, 159)
        Me.CidadeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(179, 22)
        Me.CidadeTextBox.TabIndex = 10
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EstadoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EstadoComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecedorBindingSource, "estado", True))
        Me.EstadoComboBox.DropDownHeight = 102
        Me.EstadoComboBox.Enabled = False
        Me.EstadoComboBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoComboBox.ForeColor = System.Drawing.Color.White
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.IntegralHeight = False
        Me.EstadoComboBox.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.EstadoComboBox.Location = New System.Drawing.Point(56, 213)
        Me.EstadoComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(75, 25)
        Me.EstadoComboBox.TabIndex = 12
        '
        'CepMaskedTextBox
        '
        Me.CepMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.CepMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecedorBindingSource, "cep", True))
        Me.CepMaskedTextBox.Enabled = False
        Me.CepMaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CepMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.CepMaskedTextBox.Location = New System.Drawing.Point(394, 216)
        Me.CepMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CepMaskedTextBox.Mask = "00000-000"
        Me.CepMaskedTextBox.Name = "CepMaskedTextBox"
        Me.CepMaskedTextBox.Size = New System.Drawing.Size(81, 22)
        Me.CepMaskedTextBox.TabIndex = 16
        '
        'CnpjMaskedTextBox
        '
        Me.CnpjMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.CnpjMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecedorBindingSource, "cnpj", True))
        Me.CnpjMaskedTextBox.Enabled = False
        Me.CnpjMaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CnpjMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.CnpjMaskedTextBox.Location = New System.Drawing.Point(348, 34)
        Me.CnpjMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CnpjMaskedTextBox.Mask = "00,000,000/0000-00"
        Me.CnpjMaskedTextBox.Name = "CnpjMaskedTextBox"
        Me.CnpjMaskedTextBox.Size = New System.Drawing.Size(127, 22)
        Me.CnpjMaskedTextBox.TabIndex = 3
        '
        'Razao_socialTextBox
        '
        Me.Razao_socialTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Razao_socialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecedorBindingSource, "razao_social", True))
        Me.Razao_socialTextBox.Enabled = False
        Me.Razao_socialTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Razao_socialTextBox.ForeColor = System.Drawing.Color.White
        Me.Razao_socialTextBox.Location = New System.Drawing.Point(56, 96)
        Me.Razao_socialTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Razao_socialTextBox.Name = "Razao_socialTextBox"
        Me.Razao_socialTextBox.Size = New System.Drawing.Size(263, 22)
        Me.Razao_socialTextBox.TabIndex = 6
        '
        'Nome_fantasiaTextBox
        '
        Me.Nome_fantasiaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Nome_fantasiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecedorBindingSource, "nome_fantasia", True))
        Me.Nome_fantasiaTextBox.Enabled = False
        Me.Nome_fantasiaTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_fantasiaTextBox.ForeColor = System.Drawing.Color.White
        Me.Nome_fantasiaTextBox.Location = New System.Drawing.Point(56, 34)
        Me.Nome_fantasiaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_fantasiaTextBox.Name = "Nome_fantasiaTextBox"
        Me.Nome_fantasiaTextBox.Size = New System.Drawing.Size(263, 22)
        Me.Nome_fantasiaTextBox.TabIndex = 1
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
        Me.gpbAcoes.Location = New System.Drawing.Point(154, 536)
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
        Me.PictureBox1.Image = Global.SimplrView.My.Resources.Resources.fornecedor
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
        Me.Label1.Size = New System.Drawing.Size(444, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastro de Fornecedor"
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Nome_contatoLabel)
        Me.pnlContent.Controls.Add(Me.Nome_contatoTextBox)
        Me.pnlContent.Controls.Add(Me.lblValidador)
        Me.pnlContent.Controls.Add(EmailLabel)
        Me.pnlContent.Controls.Add(Me.EmailTextBox)
        Me.pnlContent.Controls.Add(Telefone2Label)
        Me.pnlContent.Controls.Add(Me.Telefone2MaskedTextBox)
        Me.pnlContent.Controls.Add(Telefone1Label)
        Me.pnlContent.Controls.Add(Me.Telefone1MaskedTextBox)
        Me.pnlContent.Controls.Add(EnderecoLabel)
        Me.pnlContent.Controls.Add(Me.EnderecoTextBox)
        Me.pnlContent.Controls.Add(CidadeLabel)
        Me.pnlContent.Controls.Add(Me.CidadeTextBox)
        Me.pnlContent.Controls.Add(EstadoLabel)
        Me.pnlContent.Controls.Add(Me.EstadoComboBox)
        Me.pnlContent.Controls.Add(CepLabel)
        Me.pnlContent.Controls.Add(Me.CepMaskedTextBox)
        Me.pnlContent.Controls.Add(CnpjLabel)
        Me.pnlContent.Controls.Add(Me.CnpjMaskedTextBox)
        Me.pnlContent.Controls.Add(Razao_socialLabel)
        Me.pnlContent.Controls.Add(Me.Razao_socialTextBox)
        Me.pnlContent.Controls.Add(Nome_fantasiaLabel)
        Me.pnlContent.Controls.Add(Me.Nome_fantasiaTextBox)
        Me.pnlContent.Location = New System.Drawing.Point(21, 194)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(529, 311)
        Me.pnlContent.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(1, 624)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(568, 1)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(569, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 525)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 525)
        Me.Panel2.TabIndex = 1
        '
        'frmCadastroFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 625)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.gpbAcoes)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.cmbPesquisa)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCadastroFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simplr View"
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbfornecedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TbfornecedorBindingSource As BindingSource
    Friend WithEvents TbfornecedorTableAdapter As db_finalstopDataSetTableAdapters.tbfornecedorTableAdapter
    Friend WithEvents TableAdapterManager As db_finalstopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents label2 As Label
    Friend WithEvents cmbPesquisa As ComboBox
    Friend WithEvents Nome_contatoTextBox As TextBox
    Friend WithEvents lblValidador As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Telefone2MaskedTextBox As MaskedTextBox
    Friend WithEvents Telefone1MaskedTextBox As MaskedTextBox
    Friend WithEvents EnderecoTextBox As TextBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents CepMaskedTextBox As MaskedTextBox
    Friend WithEvents CnpjMaskedTextBox As MaskedTextBox
    Friend WithEvents Razao_socialTextBox As TextBox
    Friend WithEvents Nome_fantasiaTextBox As TextBox
    Friend WithEvents gpbAcoes As GroupBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnProximo As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnFechar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
End Class

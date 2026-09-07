<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroFuncionario
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
        Dim GeneroLabel1 As System.Windows.Forms.Label
        Dim NivelLabel1 As System.Windows.Forms.Label
        Dim EmailLabel1 As System.Windows.Forms.Label
        Dim TelefoneLabel1 As System.Windows.Forms.Label
        Dim SenhaLabel1 As System.Windows.Forms.Label
        Dim LoginLabel1 As System.Windows.Forms.Label
        Dim NomeLabel1 As System.Windows.Forms.Label
        Dim Estado_civilLabel1 As System.Windows.Forms.Label
        Dim Serie_carteiraLabel1 As System.Windows.Forms.Label
        Dim Numero_carteiraLabel1 As System.Windows.Forms.Label
        Dim PisLabel1 As System.Windows.Forms.Label
        Dim Certificado_reservistaLabel1 As System.Windows.Forms.Label
        Dim Titulo_eleitoralLabel1 As System.Windows.Forms.Label
        Dim RgLabel1 As System.Windows.Forms.Label
        Dim CpfLabel1 As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim EstadoLabel1 As System.Windows.Forms.Label
        Dim CidadeLabel1 As System.Windows.Forms.Label
        Dim Ponto_refLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim NumeroLabel1 As System.Windows.Forms.Label
        Dim EnderecoLabel1 As System.Windows.Forms.Label
        Dim CepLabel1 As System.Windows.Forms.Label
        Dim ObsLabel1 As System.Windows.Forms.Label
        Dim FeriasLabel1 As System.Windows.Forms.Label
        Dim Data_demissaoLabel1 As System.Windows.Forms.Label
        Dim Data_admissaoLabel1 As System.Windows.Forms.Label
        Dim SalarioLabel1 As System.Windows.Forms.Label
        Dim FuncaoLabel1 As System.Windows.Forms.Label
        Dim CargoLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroFuncionario))
        Me.Db_finalstopDataSet = New SimplrView.db_finalstopDataSet()
        Me.TbfuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbfuncionarioTableAdapter = New SimplrView.db_finalstopDataSetTableAdapters.tbfuncionarioTableAdapter()
        Me.TableAdapterManager = New SimplrView.db_finalstopDataSetTableAdapters.TableAdapterManager()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cmbPesquisa = New System.Windows.Forms.ComboBox()
        Me.tbcDados = New System.Windows.Forms.TabControl()
        Me.tbpDadosPrincipais = New System.Windows.Forms.TabPage()
        Me.GeneroComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NivelComboBox1 = New System.Windows.Forms.ComboBox()
        Me.EmailTextBox1 = New System.Windows.Forms.TextBox()
        Me.TelefoneMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.SenhaTextBox1 = New System.Windows.Forms.TextBox()
        Me.LoginTextBox1 = New System.Windows.Forms.TextBox()
        Me.NomeTextBox1 = New System.Windows.Forms.TextBox()
        Me.tbpDocumentos = New System.Windows.Forms.TabPage()
        Me.lblValidadorPis = New System.Windows.Forms.Label()
        Me.lblValidador = New System.Windows.Forms.Label()
        Me.Estado_civilComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Serie_carteiraMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Numero_carteiraMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.PisMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Certificado_reservistaMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Titulo_eleitoralMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.RgMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.CpfMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.tbpEndereco = New System.Windows.Forms.TabPage()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CidadeTextBox1 = New System.Windows.Forms.TextBox()
        Me.Ponto_refTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox1 = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox1 = New System.Windows.Forms.TextBox()
        Me.CepMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.tbpOutrasInformacoes = New System.Windows.Forms.TabPage()
        Me.ObsTextBox1 = New System.Windows.Forms.TextBox()
        Me.FeriasTextBox1 = New System.Windows.Forms.TextBox()
        Me.Data_demissaoMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Data_admissaoMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.SalarioMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.FuncaoTextBox1 = New System.Windows.Forms.TextBox()
        Me.CargoComboBox1 = New System.Windows.Forms.ComboBox()
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        GeneroLabel1 = New System.Windows.Forms.Label()
        NivelLabel1 = New System.Windows.Forms.Label()
        EmailLabel1 = New System.Windows.Forms.Label()
        TelefoneLabel1 = New System.Windows.Forms.Label()
        SenhaLabel1 = New System.Windows.Forms.Label()
        LoginLabel1 = New System.Windows.Forms.Label()
        NomeLabel1 = New System.Windows.Forms.Label()
        Estado_civilLabel1 = New System.Windows.Forms.Label()
        Serie_carteiraLabel1 = New System.Windows.Forms.Label()
        Numero_carteiraLabel1 = New System.Windows.Forms.Label()
        PisLabel1 = New System.Windows.Forms.Label()
        Certificado_reservistaLabel1 = New System.Windows.Forms.Label()
        Titulo_eleitoralLabel1 = New System.Windows.Forms.Label()
        RgLabel1 = New System.Windows.Forms.Label()
        CpfLabel1 = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        EstadoLabel1 = New System.Windows.Forms.Label()
        CidadeLabel1 = New System.Windows.Forms.Label()
        Ponto_refLabel = New System.Windows.Forms.Label()
        ComplementoLabel = New System.Windows.Forms.Label()
        NumeroLabel1 = New System.Windows.Forms.Label()
        EnderecoLabel1 = New System.Windows.Forms.Label()
        CepLabel1 = New System.Windows.Forms.Label()
        ObsLabel1 = New System.Windows.Forms.Label()
        FeriasLabel1 = New System.Windows.Forms.Label()
        Data_demissaoLabel1 = New System.Windows.Forms.Label()
        Data_admissaoLabel1 = New System.Windows.Forms.Label()
        SalarioLabel1 = New System.Windows.Forms.Label()
        FuncaoLabel1 = New System.Windows.Forms.Label()
        CargoLabel1 = New System.Windows.Forms.Label()
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbfuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcDados.SuspendLayout()
        Me.tbpDadosPrincipais.SuspendLayout()
        Me.tbpDocumentos.SuspendLayout()
        Me.tbpEndereco.SuspendLayout()
        Me.tbpOutrasInformacoes.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbAcoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'GeneroLabel1
        '
        GeneroLabel1.AutoSize = True
        GeneroLabel1.Location = New System.Drawing.Point(30, 189)
        GeneroLabel1.Name = "GeneroLabel1"
        GeneroLabel1.Size = New System.Drawing.Size(59, 17)
        GeneroLabel1.TabIndex = 12
        GeneroLabel1.Text = "Gênero*"
        '
        'NivelLabel1
        '
        NivelLabel1.AutoSize = True
        NivelLabel1.Location = New System.Drawing.Point(311, 132)
        NivelLabel1.Name = "NivelLabel1"
        NivelLabel1.Size = New System.Drawing.Size(45, 17)
        NivelLabel1.TabIndex = 10
        NivelLabel1.Text = "Nível*"
        '
        'EmailLabel1
        '
        EmailLabel1.AutoSize = True
        EmailLabel1.Location = New System.Drawing.Point(30, 132)
        EmailLabel1.Name = "EmailLabel1"
        EmailLabel1.Size = New System.Drawing.Size(49, 17)
        EmailLabel1.TabIndex = 8
        EmailLabel1.Text = "E-mail*"
        '
        'TelefoneLabel1
        '
        TelefoneLabel1.AutoSize = True
        TelefoneLabel1.Location = New System.Drawing.Point(219, 77)
        TelefoneLabel1.Name = "TelefoneLabel1"
        TelefoneLabel1.Size = New System.Drawing.Size(65, 17)
        TelefoneLabel1.TabIndex = 6
        TelefoneLabel1.Text = "Telefone*"
        '
        'SenhaLabel1
        '
        SenhaLabel1.AutoSize = True
        SenhaLabel1.Location = New System.Drawing.Point(30, 77)
        SenhaLabel1.Name = "SenhaLabel1"
        SenhaLabel1.Size = New System.Drawing.Size(51, 17)
        SenhaLabel1.TabIndex = 4
        SenhaLabel1.Text = "Senha*"
        '
        'LoginLabel1
        '
        LoginLabel1.AutoSize = True
        LoginLabel1.Location = New System.Drawing.Point(298, 22)
        LoginLabel1.Name = "LoginLabel1"
        LoginLabel1.Size = New System.Drawing.Size(46, 17)
        LoginLabel1.TabIndex = 2
        LoginLabel1.Text = "Login*"
        '
        'NomeLabel1
        '
        NomeLabel1.AutoSize = True
        NomeLabel1.Location = New System.Drawing.Point(30, 23)
        NomeLabel1.Name = "NomeLabel1"
        NomeLabel1.Size = New System.Drawing.Size(50, 17)
        NomeLabel1.TabIndex = 0
        NomeLabel1.Text = "Nome*"
        '
        'Estado_civilLabel1
        '
        Estado_civilLabel1.AutoSize = True
        Estado_civilLabel1.Location = New System.Drawing.Point(167, 175)
        Estado_civilLabel1.Name = "Estado_civilLabel1"
        Estado_civilLabel1.Size = New System.Drawing.Size(83, 17)
        Estado_civilLabel1.TabIndex = 14
        Estado_civilLabel1.Text = "Estado Civil*"
        '
        'Serie_carteiraLabel1
        '
        Serie_carteiraLabel1.AutoSize = True
        Serie_carteiraLabel1.Location = New System.Drawing.Point(25, 175)
        Serie_carteiraLabel1.Name = "Serie_carteiraLabel1"
        Serie_carteiraLabel1.Size = New System.Drawing.Size(69, 17)
        Serie_carteiraLabel1.TabIndex = 12
        Serie_carteiraLabel1.Text = "Série CTPS"
        '
        'Numero_carteiraLabel1
        '
        Numero_carteiraLabel1.AutoSize = True
        Numero_carteiraLabel1.Location = New System.Drawing.Point(336, 103)
        Numero_carteiraLabel1.Name = "Numero_carteiraLabel1"
        Numero_carteiraLabel1.Size = New System.Drawing.Size(86, 17)
        Numero_carteiraLabel1.TabIndex = 10
        Numero_carteiraLabel1.Text = "Número CTPS"
        '
        'PisLabel1
        '
        PisLabel1.AutoSize = True
        PisLabel1.Location = New System.Drawing.Point(213, 103)
        PisLabel1.Name = "PisLabel1"
        PisLabel1.Size = New System.Drawing.Size(72, 17)
        PisLabel1.TabIndex = 8
        PisLabel1.Text = "PIS/Pasep*"
        '
        'Certificado_reservistaLabel1
        '
        Certificado_reservistaLabel1.AutoSize = True
        Certificado_reservistaLabel1.Location = New System.Drawing.Point(25, 103)
        Certificado_reservistaLabel1.Name = "Certificado_reservistaLabel1"
        Certificado_reservistaLabel1.Size = New System.Drawing.Size(159, 17)
        Certificado_reservistaLabel1.TabIndex = 6
        Certificado_reservistaLabel1.Text = "Certificado de Reservista"
        '
        'Titulo_eleitoralLabel1
        '
        Titulo_eleitoralLabel1.AutoSize = True
        Titulo_eleitoralLabel1.Location = New System.Drawing.Point(303, 22)
        Titulo_eleitoralLabel1.Name = "Titulo_eleitoralLabel1"
        Titulo_eleitoralLabel1.Size = New System.Drawing.Size(90, 17)
        Titulo_eleitoralLabel1.TabIndex = 4
        Titulo_eleitoralLabel1.Text = "Título Eleitoral"
        '
        'RgLabel1
        '
        RgLabel1.AutoSize = True
        RgLabel1.Location = New System.Drawing.Point(159, 22)
        RgLabel1.Name = "RgLabel1"
        RgLabel1.Size = New System.Drawing.Size(31, 17)
        RgLabel1.TabIndex = 2
        RgLabel1.Text = "RG*"
        '
        'CpfLabel1
        '
        CpfLabel1.AutoSize = True
        CpfLabel1.Location = New System.Drawing.Point(25, 22)
        CpfLabel1.Name = "CpfLabel1"
        CpfLabel1.Size = New System.Drawing.Size(36, 17)
        CpfLabel1.TabIndex = 0
        CpfLabel1.Text = "CPF*"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(34, 192)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(48, 17)
        BairroLabel.TabIndex = 14
        BairroLabel.Text = "Bairro*"
        '
        'EstadoLabel1
        '
        EstadoLabel1.AutoSize = True
        EstadoLabel1.Location = New System.Drawing.Point(287, 137)
        EstadoLabel1.Name = "EstadoLabel1"
        EstadoLabel1.Size = New System.Drawing.Size(54, 17)
        EstadoLabel1.TabIndex = 12
        EstadoLabel1.Text = "Estado*"
        '
        'CidadeLabel1
        '
        CidadeLabel1.AutoSize = True
        CidadeLabel1.Location = New System.Drawing.Point(34, 137)
        CidadeLabel1.Name = "CidadeLabel1"
        CidadeLabel1.Size = New System.Drawing.Size(58, 17)
        CidadeLabel1.TabIndex = 10
        CidadeLabel1.Text = "Cidade*"
        '
        'Ponto_refLabel
        '
        Ponto_refLabel.AutoSize = True
        Ponto_refLabel.Location = New System.Drawing.Point(242, 82)
        Ponto_refLabel.Name = "Ponto_refLabel"
        Ponto_refLabel.Size = New System.Drawing.Size(73, 17)
        Ponto_refLabel.TabIndex = 8
        Ponto_refLabel.Text = "Referência"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Location = New System.Drawing.Point(34, 82)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(94, 17)
        ComplementoLabel.TabIndex = 6
        ComplementoLabel.Text = "Complemento"
        '
        'NumeroLabel1
        '
        NumeroLabel1.AutoSize = True
        NumeroLabel1.Location = New System.Drawing.Point(354, 26)
        NumeroLabel1.Name = "NumeroLabel1"
        NumeroLabel1.Size = New System.Drawing.Size(21, 17)
        NumeroLabel1.TabIndex = 4
        NumeroLabel1.Text = "Nº"
        '
        'EnderecoLabel1
        '
        EnderecoLabel1.AutoSize = True
        EnderecoLabel1.Location = New System.Drawing.Point(138, 26)
        EnderecoLabel1.Name = "EnderecoLabel1"
        EnderecoLabel1.Size = New System.Drawing.Size(71, 17)
        EnderecoLabel1.TabIndex = 2
        EnderecoLabel1.Text = "Endereço*"
        '
        'CepLabel1
        '
        CepLabel1.AutoSize = True
        CepLabel1.Location = New System.Drawing.Point(34, 26)
        CepLabel1.Name = "CepLabel1"
        CepLabel1.Size = New System.Drawing.Size(36, 17)
        CepLabel1.TabIndex = 0
        CepLabel1.Text = "CEP*"
        '
        'ObsLabel1
        '
        ObsLabel1.AutoSize = True
        ObsLabel1.Location = New System.Drawing.Point(179, 153)
        ObsLabel1.Name = "ObsLabel1"
        ObsLabel1.Size = New System.Drawing.Size(91, 17)
        ObsLabel1.TabIndex = 12
        ObsLabel1.Text = "Observações:"
        '
        'FeriasLabel1
        '
        FeriasLabel1.AutoSize = True
        FeriasLabel1.Location = New System.Drawing.Point(311, 91)
        FeriasLabel1.Name = "FeriasLabel1"
        FeriasLabel1.Size = New System.Drawing.Size(42, 17)
        FeriasLabel1.TabIndex = 10
        FeriasLabel1.Text = "Férias"
        '
        'Data_demissaoLabel1
        '
        Data_demissaoLabel1.AutoSize = True
        Data_demissaoLabel1.Location = New System.Drawing.Point(33, 153)
        Data_demissaoLabel1.Name = "Data_demissaoLabel1"
        Data_demissaoLabel1.Size = New System.Drawing.Size(117, 17)
        Data_demissaoLabel1.TabIndex = 8
        Data_demissaoLabel1.Text = "Data de Demissão"
        '
        'Data_admissaoLabel1
        '
        Data_admissaoLabel1.AutoSize = True
        Data_admissaoLabel1.Location = New System.Drawing.Point(171, 91)
        Data_admissaoLabel1.Name = "Data_admissaoLabel1"
        Data_admissaoLabel1.Size = New System.Drawing.Size(123, 17)
        Data_admissaoLabel1.TabIndex = 6
        Data_admissaoLabel1.Text = "Data de Admissão*"
        '
        'SalarioLabel1
        '
        SalarioLabel1.AutoSize = True
        SalarioLabel1.Location = New System.Drawing.Point(33, 91)
        SalarioLabel1.Name = "SalarioLabel1"
        SalarioLabel1.Size = New System.Drawing.Size(55, 17)
        SalarioLabel1.TabIndex = 4
        SalarioLabel1.Text = "Salário*"
        '
        'FuncaoLabel1
        '
        FuncaoLabel1.AutoSize = True
        FuncaoLabel1.Location = New System.Drawing.Point(275, 27)
        FuncaoLabel1.Name = "FuncaoLabel1"
        FuncaoLabel1.Size = New System.Drawing.Size(52, 17)
        FuncaoLabel1.TabIndex = 2
        FuncaoLabel1.Text = "Função"
        '
        'CargoLabel1
        '
        CargoLabel1.AutoSize = True
        CargoLabel1.Location = New System.Drawing.Point(33, 27)
        CargoLabel1.Name = "CargoLabel1"
        CargoLabel1.Size = New System.Drawing.Size(51, 17)
        CargoLabel1.TabIndex = 0
        CargoLabel1.Text = "Cargo*"
        '
        'Db_finalstopDataSet
        '
        Me.Db_finalstopDataSet.DataSetName = "db_finalstopDataSet"
        Me.Db_finalstopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbfuncionarioBindingSource
        '
        Me.TbfuncionarioBindingSource.DataMember = "tbfuncionario"
        Me.TbfuncionarioBindingSource.DataSource = Me.Db_finalstopDataSet
        '
        'TbfuncionarioTableAdapter
        '
        Me.TbfuncionarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbclienteTableAdapter = Nothing
        Me.TableAdapterManager.tbfornecedorTableAdapter = Nothing
        Me.TableAdapterManager.tbfuncionarioTableAdapter = Me.TbfuncionarioTableAdapter
        Me.TableAdapterManager.tbpersonalizacaoTableAdapter = Nothing
        Me.TableAdapterManager.tbprodutoTableAdapter = Nothing
        Me.TableAdapterManager.tbvendaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SimplrView.db_finalstopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.label2.Location = New System.Drawing.Point(141, 128)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 17)
        Me.label2.TabIndex = 62
        Me.label2.Text = "Pesquisa"
        '
        'cmbPesquisa
        '
        Me.cmbPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.cmbPesquisa.DataSource = Me.TbfuncionarioBindingSource
        Me.cmbPesquisa.DisplayMember = "nome"
        Me.cmbPesquisa.DropDownHeight = 102
        Me.cmbPesquisa.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbPesquisa.ForeColor = System.Drawing.Color.White
        Me.cmbPesquisa.FormattingEnabled = True
        Me.cmbPesquisa.IntegralHeight = False
        Me.cmbPesquisa.Location = New System.Drawing.Point(144, 148)
        Me.cmbPesquisa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbPesquisa.Name = "cmbPesquisa"
        Me.cmbPesquisa.Size = New System.Drawing.Size(286, 25)
        Me.cmbPesquisa.TabIndex = 61
        Me.cmbPesquisa.ValueMember = "id_funcionario"
        '
        'tbcDados
        '
        Me.tbcDados.Controls.Add(Me.tbpDadosPrincipais)
        Me.tbcDados.Controls.Add(Me.tbpDocumentos)
        Me.tbcDados.Controls.Add(Me.tbpEndereco)
        Me.tbcDados.Controls.Add(Me.tbpOutrasInformacoes)
        Me.tbcDados.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.tbcDados.Location = New System.Drawing.Point(58, 203)
        Me.tbcDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbcDados.Multiline = True
        Me.tbcDados.Name = "tbcDados"
        Me.tbcDados.SelectedIndex = 0
        Me.tbcDados.Size = New System.Drawing.Size(455, 303)
        Me.tbcDados.TabIndex = 59
        '
        'tbpDadosPrincipais
        '
        Me.tbpDadosPrincipais.AutoScroll = True
        Me.tbpDadosPrincipais.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.tbpDadosPrincipais.Controls.Add(GeneroLabel1)
        Me.tbpDadosPrincipais.Controls.Add(Me.GeneroComboBox1)
        Me.tbpDadosPrincipais.Controls.Add(NivelLabel1)
        Me.tbpDadosPrincipais.Controls.Add(Me.NivelComboBox1)
        Me.tbpDadosPrincipais.Controls.Add(EmailLabel1)
        Me.tbpDadosPrincipais.Controls.Add(Me.EmailTextBox1)
        Me.tbpDadosPrincipais.Controls.Add(TelefoneLabel1)
        Me.tbpDadosPrincipais.Controls.Add(Me.TelefoneMaskedTextBox1)
        Me.tbpDadosPrincipais.Controls.Add(SenhaLabel1)
        Me.tbpDadosPrincipais.Controls.Add(Me.SenhaTextBox1)
        Me.tbpDadosPrincipais.Controls.Add(LoginLabel1)
        Me.tbpDadosPrincipais.Controls.Add(Me.LoginTextBox1)
        Me.tbpDadosPrincipais.Controls.Add(NomeLabel1)
        Me.tbpDadosPrincipais.Controls.Add(Me.NomeTextBox1)
        Me.tbpDadosPrincipais.Location = New System.Drawing.Point(4, 26)
        Me.tbpDadosPrincipais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpDadosPrincipais.Name = "tbpDadosPrincipais"
        Me.tbpDadosPrincipais.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpDadosPrincipais.Size = New System.Drawing.Size(447, 273)
        Me.tbpDadosPrincipais.TabIndex = 0
        Me.tbpDadosPrincipais.Text = "Dados Principais"
        '
        'GeneroComboBox1
        '
        Me.GeneroComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GeneroComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GeneroComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.GeneroComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "genero", True))
        Me.GeneroComboBox1.Enabled = False
        Me.GeneroComboBox1.ForeColor = System.Drawing.Color.White
        Me.GeneroComboBox1.FormattingEnabled = True
        Me.GeneroComboBox1.Items.AddRange(New Object() {"Masculino", "Feminino", "Outros"})
        Me.GeneroComboBox1.Location = New System.Drawing.Point(33, 210)
        Me.GeneroComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GeneroComboBox1.Name = "GeneroComboBox1"
        Me.GeneroComboBox1.Size = New System.Drawing.Size(140, 25)
        Me.GeneroComboBox1.TabIndex = 13
        '
        'NivelComboBox1
        '
        Me.NivelComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NivelComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NivelComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.NivelComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "nivel", True))
        Me.NivelComboBox1.Enabled = False
        Me.NivelComboBox1.ForeColor = System.Drawing.Color.White
        Me.NivelComboBox1.FormattingEnabled = True
        Me.NivelComboBox1.Items.AddRange(New Object() {"0", "1", "2"})
        Me.NivelComboBox1.Location = New System.Drawing.Point(316, 150)
        Me.NivelComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NivelComboBox1.Name = "NivelComboBox1"
        Me.NivelComboBox1.Size = New System.Drawing.Size(101, 25)
        Me.NivelComboBox1.TabIndex = 11
        '
        'EmailTextBox1
        '
        Me.EmailTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.EmailTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "email", True))
        Me.EmailTextBox1.Enabled = False
        Me.EmailTextBox1.ForeColor = System.Drawing.Color.White
        Me.EmailTextBox1.Location = New System.Drawing.Point(33, 153)
        Me.EmailTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmailTextBox1.Name = "EmailTextBox1"
        Me.EmailTextBox1.Size = New System.Drawing.Size(252, 22)
        Me.EmailTextBox1.TabIndex = 9
        '
        'TelefoneMaskedTextBox1
        '
        Me.TelefoneMaskedTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.TelefoneMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "telefone", True))
        Me.TelefoneMaskedTextBox1.Enabled = False
        Me.TelefoneMaskedTextBox1.ForeColor = System.Drawing.Color.White
        Me.TelefoneMaskedTextBox1.Location = New System.Drawing.Point(222, 98)
        Me.TelefoneMaskedTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TelefoneMaskedTextBox1.Mask = "(00) 00000-0000"
        Me.TelefoneMaskedTextBox1.Name = "TelefoneMaskedTextBox1"
        Me.TelefoneMaskedTextBox1.Size = New System.Drawing.Size(116, 22)
        Me.TelefoneMaskedTextBox1.TabIndex = 7
        '
        'SenhaTextBox1
        '
        Me.SenhaTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.SenhaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "senha", True))
        Me.SenhaTextBox1.Enabled = False
        Me.SenhaTextBox1.ForeColor = System.Drawing.Color.White
        Me.SenhaTextBox1.Location = New System.Drawing.Point(33, 98)
        Me.SenhaTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SenhaTextBox1.Name = "SenhaTextBox1"
        Me.SenhaTextBox1.Size = New System.Drawing.Size(158, 22)
        Me.SenhaTextBox1.TabIndex = 5
        '
        'LoginTextBox1
        '
        Me.LoginTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.LoginTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "login", True))
        Me.LoginTextBox1.Enabled = False
        Me.LoginTextBox1.ForeColor = System.Drawing.Color.White
        Me.LoginTextBox1.Location = New System.Drawing.Point(301, 43)
        Me.LoginTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LoginTextBox1.Name = "LoginTextBox1"
        Me.LoginTextBox1.Size = New System.Drawing.Size(116, 22)
        Me.LoginTextBox1.TabIndex = 3
        '
        'NomeTextBox1
        '
        Me.NomeTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.NomeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "nome", True))
        Me.NomeTextBox1.Enabled = False
        Me.NomeTextBox1.ForeColor = System.Drawing.Color.White
        Me.NomeTextBox1.Location = New System.Drawing.Point(33, 43)
        Me.NomeTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NomeTextBox1.Name = "NomeTextBox1"
        Me.NomeTextBox1.Size = New System.Drawing.Size(241, 22)
        Me.NomeTextBox1.TabIndex = 1
        '
        'tbpDocumentos
        '
        Me.tbpDocumentos.AutoScroll = True
        Me.tbpDocumentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.tbpDocumentos.Controls.Add(Me.lblValidadorPis)
        Me.tbpDocumentos.Controls.Add(Me.lblValidador)
        Me.tbpDocumentos.Controls.Add(Estado_civilLabel1)
        Me.tbpDocumentos.Controls.Add(Me.Estado_civilComboBox1)
        Me.tbpDocumentos.Controls.Add(Serie_carteiraLabel1)
        Me.tbpDocumentos.Controls.Add(Me.Serie_carteiraMaskedTextBox1)
        Me.tbpDocumentos.Controls.Add(Numero_carteiraLabel1)
        Me.tbpDocumentos.Controls.Add(Me.Numero_carteiraMaskedTextBox1)
        Me.tbpDocumentos.Controls.Add(PisLabel1)
        Me.tbpDocumentos.Controls.Add(Me.PisMaskedTextBox1)
        Me.tbpDocumentos.Controls.Add(Certificado_reservistaLabel1)
        Me.tbpDocumentos.Controls.Add(Me.Certificado_reservistaMaskedTextBox1)
        Me.tbpDocumentos.Controls.Add(Titulo_eleitoralLabel1)
        Me.tbpDocumentos.Controls.Add(Me.Titulo_eleitoralMaskedTextBox1)
        Me.tbpDocumentos.Controls.Add(RgLabel1)
        Me.tbpDocumentos.Controls.Add(Me.RgMaskedTextBox1)
        Me.tbpDocumentos.Controls.Add(CpfLabel1)
        Me.tbpDocumentos.Controls.Add(Me.CpfMaskedTextBox)
        Me.tbpDocumentos.Location = New System.Drawing.Point(4, 26)
        Me.tbpDocumentos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpDocumentos.Name = "tbpDocumentos"
        Me.tbpDocumentos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpDocumentos.Size = New System.Drawing.Size(447, 273)
        Me.tbpDocumentos.TabIndex = 1
        Me.tbpDocumentos.Text = "Documentação"
        '
        'lblValidadorPis
        '
        Me.lblValidadorPis.AutoSize = True
        Me.lblValidadorPis.Location = New System.Drawing.Point(213, 150)
        Me.lblValidadorPis.Name = "lblValidadorPis"
        Me.lblValidadorPis.Size = New System.Drawing.Size(17, 17)
        Me.lblValidadorPis.TabIndex = 17
        Me.lblValidadorPis.Text = "..."
        '
        'lblValidador
        '
        Me.lblValidador.AutoSize = True
        Me.lblValidador.Location = New System.Drawing.Point(25, 69)
        Me.lblValidador.Name = "lblValidador"
        Me.lblValidador.Size = New System.Drawing.Size(17, 17)
        Me.lblValidador.TabIndex = 16
        Me.lblValidador.Text = "..."
        '
        'Estado_civilComboBox1
        '
        Me.Estado_civilComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Estado_civilComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Estado_civilComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Estado_civilComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "estado_civil", True))
        Me.Estado_civilComboBox1.Enabled = False
        Me.Estado_civilComboBox1.ForeColor = System.Drawing.Color.White
        Me.Estado_civilComboBox1.FormattingEnabled = True
        Me.Estado_civilComboBox1.Items.AddRange(New Object() {"Solteiro(a)", "Casado(a)", "Divorciado(a)", "Viúvo(a)"})
        Me.Estado_civilComboBox1.Location = New System.Drawing.Point(170, 193)
        Me.Estado_civilComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Estado_civilComboBox1.Name = "Estado_civilComboBox1"
        Me.Estado_civilComboBox1.Size = New System.Drawing.Size(140, 25)
        Me.Estado_civilComboBox1.TabIndex = 15
        '
        'Serie_carteiraMaskedTextBox1
        '
        Me.Serie_carteiraMaskedTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Serie_carteiraMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "serie_carteira", True))
        Me.Serie_carteiraMaskedTextBox1.Enabled = False
        Me.Serie_carteiraMaskedTextBox1.ForeColor = System.Drawing.Color.White
        Me.Serie_carteiraMaskedTextBox1.Location = New System.Drawing.Point(28, 196)
        Me.Serie_carteiraMaskedTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Serie_carteiraMaskedTextBox1.Name = "Serie_carteiraMaskedTextBox1"
        Me.Serie_carteiraMaskedTextBox1.Size = New System.Drawing.Size(116, 22)
        Me.Serie_carteiraMaskedTextBox1.TabIndex = 13
        '
        'Numero_carteiraMaskedTextBox1
        '
        Me.Numero_carteiraMaskedTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Numero_carteiraMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "numero_carteira", True))
        Me.Numero_carteiraMaskedTextBox1.Enabled = False
        Me.Numero_carteiraMaskedTextBox1.ForeColor = System.Drawing.Color.White
        Me.Numero_carteiraMaskedTextBox1.Location = New System.Drawing.Point(339, 124)
        Me.Numero_carteiraMaskedTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Numero_carteiraMaskedTextBox1.Name = "Numero_carteiraMaskedTextBox1"
        Me.Numero_carteiraMaskedTextBox1.Size = New System.Drawing.Size(83, 22)
        Me.Numero_carteiraMaskedTextBox1.TabIndex = 11
        '
        'PisMaskedTextBox1
        '
        Me.PisMaskedTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.PisMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "pis", True))
        Me.PisMaskedTextBox1.Enabled = False
        Me.PisMaskedTextBox1.ForeColor = System.Drawing.Color.White
        Me.PisMaskedTextBox1.Location = New System.Drawing.Point(216, 124)
        Me.PisMaskedTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PisMaskedTextBox1.Mask = "999,99999,99-9"
        Me.PisMaskedTextBox1.Name = "PisMaskedTextBox1"
        Me.PisMaskedTextBox1.Size = New System.Drawing.Size(104, 22)
        Me.PisMaskedTextBox1.TabIndex = 9
        '
        'Certificado_reservistaMaskedTextBox1
        '
        Me.Certificado_reservistaMaskedTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Certificado_reservistaMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "certificado_reservista", True))
        Me.Certificado_reservistaMaskedTextBox1.Enabled = False
        Me.Certificado_reservistaMaskedTextBox1.ForeColor = System.Drawing.Color.White
        Me.Certificado_reservistaMaskedTextBox1.Location = New System.Drawing.Point(28, 124)
        Me.Certificado_reservistaMaskedTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Certificado_reservistaMaskedTextBox1.Name = "Certificado_reservistaMaskedTextBox1"
        Me.Certificado_reservistaMaskedTextBox1.Size = New System.Drawing.Size(156, 22)
        Me.Certificado_reservistaMaskedTextBox1.TabIndex = 7
        '
        'Titulo_eleitoralMaskedTextBox1
        '
        Me.Titulo_eleitoralMaskedTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Titulo_eleitoralMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "titulo_eleitoral", True))
        Me.Titulo_eleitoralMaskedTextBox1.Enabled = False
        Me.Titulo_eleitoralMaskedTextBox1.ForeColor = System.Drawing.Color.White
        Me.Titulo_eleitoralMaskedTextBox1.Location = New System.Drawing.Point(306, 43)
        Me.Titulo_eleitoralMaskedTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Titulo_eleitoralMaskedTextBox1.Name = "Titulo_eleitoralMaskedTextBox1"
        Me.Titulo_eleitoralMaskedTextBox1.Size = New System.Drawing.Size(116, 22)
        Me.Titulo_eleitoralMaskedTextBox1.TabIndex = 5
        '
        'RgMaskedTextBox1
        '
        Me.RgMaskedTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.RgMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "rg", True))
        Me.RgMaskedTextBox1.Enabled = False
        Me.RgMaskedTextBox1.ForeColor = System.Drawing.Color.White
        Me.RgMaskedTextBox1.Location = New System.Drawing.Point(162, 43)
        Me.RgMaskedTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RgMaskedTextBox1.Name = "RgMaskedTextBox1"
        Me.RgMaskedTextBox1.Size = New System.Drawing.Size(121, 22)
        Me.RgMaskedTextBox1.TabIndex = 3
        '
        'CpfMaskedTextBox
        '
        Me.CpfMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.CpfMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "cpf", True))
        Me.CpfMaskedTextBox.Enabled = False
        Me.CpfMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.CpfMaskedTextBox.Location = New System.Drawing.Point(28, 43)
        Me.CpfMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CpfMaskedTextBox.Mask = "000,000,000-00"
        Me.CpfMaskedTextBox.Name = "CpfMaskedTextBox"
        Me.CpfMaskedTextBox.Size = New System.Drawing.Size(108, 22)
        Me.CpfMaskedTextBox.TabIndex = 1
        '
        'tbpEndereco
        '
        Me.tbpEndereco.AutoScroll = True
        Me.tbpEndereco.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.tbpEndereco.Controls.Add(BairroLabel)
        Me.tbpEndereco.Controls.Add(Me.BairroTextBox)
        Me.tbpEndereco.Controls.Add(EstadoLabel1)
        Me.tbpEndereco.Controls.Add(Me.EstadoComboBox1)
        Me.tbpEndereco.Controls.Add(CidadeLabel1)
        Me.tbpEndereco.Controls.Add(Me.CidadeTextBox1)
        Me.tbpEndereco.Controls.Add(Ponto_refLabel)
        Me.tbpEndereco.Controls.Add(Me.Ponto_refTextBox)
        Me.tbpEndereco.Controls.Add(ComplementoLabel)
        Me.tbpEndereco.Controls.Add(Me.ComplementoTextBox)
        Me.tbpEndereco.Controls.Add(NumeroLabel1)
        Me.tbpEndereco.Controls.Add(Me.NumeroTextBox1)
        Me.tbpEndereco.Controls.Add(EnderecoLabel1)
        Me.tbpEndereco.Controls.Add(Me.EnderecoTextBox1)
        Me.tbpEndereco.Controls.Add(CepLabel1)
        Me.tbpEndereco.Controls.Add(Me.CepMaskedTextBox1)
        Me.tbpEndereco.Location = New System.Drawing.Point(4, 26)
        Me.tbpEndereco.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpEndereco.Name = "tbpEndereco"
        Me.tbpEndereco.Size = New System.Drawing.Size(447, 273)
        Me.tbpEndereco.TabIndex = 2
        Me.tbpEndereco.Text = "Endereço"
        '
        'BairroTextBox
        '
        Me.BairroTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "bairro", True))
        Me.BairroTextBox.Enabled = False
        Me.BairroTextBox.ForeColor = System.Drawing.Color.White
        Me.BairroTextBox.Location = New System.Drawing.Point(37, 213)
        Me.BairroTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(204, 22)
        Me.BairroTextBox.TabIndex = 15
        '
        'EstadoComboBox1
        '
        Me.EstadoComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EstadoComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EstadoComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.EstadoComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "estado", True))
        Me.EstadoComboBox1.DropDownHeight = 102
        Me.EstadoComboBox1.Enabled = False
        Me.EstadoComboBox1.ForeColor = System.Drawing.Color.White
        Me.EstadoComboBox1.FormattingEnabled = True
        Me.EstadoComboBox1.IntegralHeight = False
        Me.EstadoComboBox1.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.EstadoComboBox1.Location = New System.Drawing.Point(285, 155)
        Me.EstadoComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EstadoComboBox1.Name = "EstadoComboBox1"
        Me.EstadoComboBox1.Size = New System.Drawing.Size(69, 25)
        Me.EstadoComboBox1.TabIndex = 13
        '
        'CidadeTextBox1
        '
        Me.CidadeTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.CidadeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "cidade", True))
        Me.CidadeTextBox1.Enabled = False
        Me.CidadeTextBox1.ForeColor = System.Drawing.Color.White
        Me.CidadeTextBox1.Location = New System.Drawing.Point(37, 158)
        Me.CidadeTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CidadeTextBox1.Name = "CidadeTextBox1"
        Me.CidadeTextBox1.Size = New System.Drawing.Size(224, 22)
        Me.CidadeTextBox1.TabIndex = 11
        '
        'Ponto_refTextBox
        '
        Me.Ponto_refTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Ponto_refTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "ponto_ref", True))
        Me.Ponto_refTextBox.Enabled = False
        Me.Ponto_refTextBox.ForeColor = System.Drawing.Color.White
        Me.Ponto_refTextBox.Location = New System.Drawing.Point(245, 103)
        Me.Ponto_refTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ponto_refTextBox.Name = "Ponto_refTextBox"
        Me.Ponto_refTextBox.Size = New System.Drawing.Size(169, 22)
        Me.Ponto_refTextBox.TabIndex = 9
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "complemento", True))
        Me.ComplementoTextBox.Enabled = False
        Me.ComplementoTextBox.ForeColor = System.Drawing.Color.White
        Me.ComplementoTextBox.Location = New System.Drawing.Point(37, 103)
        Me.ComplementoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(182, 22)
        Me.ComplementoTextBox.TabIndex = 7
        '
        'NumeroTextBox1
        '
        Me.NumeroTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.NumeroTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "numero", True))
        Me.NumeroTextBox1.Enabled = False
        Me.NumeroTextBox1.ForeColor = System.Drawing.Color.White
        Me.NumeroTextBox1.Location = New System.Drawing.Point(357, 47)
        Me.NumeroTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumeroTextBox1.Name = "NumeroTextBox1"
        Me.NumeroTextBox1.Size = New System.Drawing.Size(57, 22)
        Me.NumeroTextBox1.TabIndex = 5
        '
        'EnderecoTextBox1
        '
        Me.EnderecoTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.EnderecoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "endereco", True))
        Me.EnderecoTextBox1.Enabled = False
        Me.EnderecoTextBox1.ForeColor = System.Drawing.Color.White
        Me.EnderecoTextBox1.Location = New System.Drawing.Point(141, 47)
        Me.EnderecoTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EnderecoTextBox1.Name = "EnderecoTextBox1"
        Me.EnderecoTextBox1.Size = New System.Drawing.Size(191, 22)
        Me.EnderecoTextBox1.TabIndex = 3
        '
        'CepMaskedTextBox1
        '
        Me.CepMaskedTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.CepMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "cep", True))
        Me.CepMaskedTextBox1.Enabled = False
        Me.CepMaskedTextBox1.ForeColor = System.Drawing.Color.White
        Me.CepMaskedTextBox1.Location = New System.Drawing.Point(37, 47)
        Me.CepMaskedTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CepMaskedTextBox1.Mask = "00000-000"
        Me.CepMaskedTextBox1.Name = "CepMaskedTextBox1"
        Me.CepMaskedTextBox1.Size = New System.Drawing.Size(77, 22)
        Me.CepMaskedTextBox1.TabIndex = 1
        '
        'tbpOutrasInformacoes
        '
        Me.tbpOutrasInformacoes.AutoScroll = True
        Me.tbpOutrasInformacoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.tbpOutrasInformacoes.Controls.Add(ObsLabel1)
        Me.tbpOutrasInformacoes.Controls.Add(Me.ObsTextBox1)
        Me.tbpOutrasInformacoes.Controls.Add(FeriasLabel1)
        Me.tbpOutrasInformacoes.Controls.Add(Me.FeriasTextBox1)
        Me.tbpOutrasInformacoes.Controls.Add(Data_demissaoLabel1)
        Me.tbpOutrasInformacoes.Controls.Add(Me.Data_demissaoMaskedTextBox1)
        Me.tbpOutrasInformacoes.Controls.Add(Data_admissaoLabel1)
        Me.tbpOutrasInformacoes.Controls.Add(Me.Data_admissaoMaskedTextBox1)
        Me.tbpOutrasInformacoes.Controls.Add(SalarioLabel1)
        Me.tbpOutrasInformacoes.Controls.Add(Me.SalarioMaskedTextBox1)
        Me.tbpOutrasInformacoes.Controls.Add(FuncaoLabel1)
        Me.tbpOutrasInformacoes.Controls.Add(Me.FuncaoTextBox1)
        Me.tbpOutrasInformacoes.Controls.Add(CargoLabel1)
        Me.tbpOutrasInformacoes.Controls.Add(Me.CargoComboBox1)
        Me.tbpOutrasInformacoes.Location = New System.Drawing.Point(4, 26)
        Me.tbpOutrasInformacoes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpOutrasInformacoes.Name = "tbpOutrasInformacoes"
        Me.tbpOutrasInformacoes.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpOutrasInformacoes.Size = New System.Drawing.Size(447, 273)
        Me.tbpOutrasInformacoes.TabIndex = 3
        Me.tbpOutrasInformacoes.Text = "Outras informações"
        '
        'ObsTextBox1
        '
        Me.ObsTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ObsTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "obs", True))
        Me.ObsTextBox1.Enabled = False
        Me.ObsTextBox1.ForeColor = System.Drawing.Color.White
        Me.ObsTextBox1.Location = New System.Drawing.Point(182, 174)
        Me.ObsTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ObsTextBox1.Multiline = True
        Me.ObsTextBox1.Name = "ObsTextBox1"
        Me.ObsTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ObsTextBox1.Size = New System.Drawing.Size(231, 75)
        Me.ObsTextBox1.TabIndex = 13
        '
        'FeriasTextBox1
        '
        Me.FeriasTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.FeriasTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "ferias", True))
        Me.FeriasTextBox1.Enabled = False
        Me.FeriasTextBox1.ForeColor = System.Drawing.Color.White
        Me.FeriasTextBox1.Location = New System.Drawing.Point(310, 112)
        Me.FeriasTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FeriasTextBox1.Name = "FeriasTextBox1"
        Me.FeriasTextBox1.Size = New System.Drawing.Size(103, 22)
        Me.FeriasTextBox1.TabIndex = 11
        '
        'Data_demissaoMaskedTextBox1
        '
        Me.Data_demissaoMaskedTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Data_demissaoMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "data_demissao", True))
        Me.Data_demissaoMaskedTextBox1.Enabled = False
        Me.Data_demissaoMaskedTextBox1.ForeColor = System.Drawing.Color.White
        Me.Data_demissaoMaskedTextBox1.Location = New System.Drawing.Point(36, 174)
        Me.Data_demissaoMaskedTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Data_demissaoMaskedTextBox1.Mask = "00/00/0000"
        Me.Data_demissaoMaskedTextBox1.Name = "Data_demissaoMaskedTextBox1"
        Me.Data_demissaoMaskedTextBox1.Size = New System.Drawing.Size(116, 22)
        Me.Data_demissaoMaskedTextBox1.TabIndex = 9
        '
        'Data_admissaoMaskedTextBox1
        '
        Me.Data_admissaoMaskedTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Data_admissaoMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "data_admissao", True))
        Me.Data_admissaoMaskedTextBox1.Enabled = False
        Me.Data_admissaoMaskedTextBox1.ForeColor = System.Drawing.Color.White
        Me.Data_admissaoMaskedTextBox1.Location = New System.Drawing.Point(174, 112)
        Me.Data_admissaoMaskedTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Data_admissaoMaskedTextBox1.Mask = "00/00/0000"
        Me.Data_admissaoMaskedTextBox1.Name = "Data_admissaoMaskedTextBox1"
        Me.Data_admissaoMaskedTextBox1.Size = New System.Drawing.Size(116, 22)
        Me.Data_admissaoMaskedTextBox1.TabIndex = 7
        '
        'SalarioMaskedTextBox1
        '
        Me.SalarioMaskedTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.SalarioMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "salario", True))
        Me.SalarioMaskedTextBox1.Enabled = False
        Me.SalarioMaskedTextBox1.ForeColor = System.Drawing.Color.White
        Me.SalarioMaskedTextBox1.Location = New System.Drawing.Point(36, 112)
        Me.SalarioMaskedTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SalarioMaskedTextBox1.Name = "SalarioMaskedTextBox1"
        Me.SalarioMaskedTextBox1.Size = New System.Drawing.Size(110, 22)
        Me.SalarioMaskedTextBox1.TabIndex = 5
        '
        'FuncaoTextBox1
        '
        Me.FuncaoTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.FuncaoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "funcao", True))
        Me.FuncaoTextBox1.Enabled = False
        Me.FuncaoTextBox1.ForeColor = System.Drawing.Color.White
        Me.FuncaoTextBox1.Location = New System.Drawing.Point(278, 48)
        Me.FuncaoTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FuncaoTextBox1.Name = "FuncaoTextBox1"
        Me.FuncaoTextBox1.Size = New System.Drawing.Size(135, 22)
        Me.FuncaoTextBox1.TabIndex = 3
        '
        'CargoComboBox1
        '
        Me.CargoComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CargoComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CargoComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.CargoComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfuncionarioBindingSource, "cargo", True))
        Me.CargoComboBox1.DropDownHeight = 102
        Me.CargoComboBox1.Enabled = False
        Me.CargoComboBox1.ForeColor = System.Drawing.Color.White
        Me.CargoComboBox1.FormattingEnabled = True
        Me.CargoComboBox1.IntegralHeight = False
        Me.CargoComboBox1.Items.AddRange(New Object() {"Administrador", "Atendente", "Consultor", "Analista de Eletrodomésticos", "Analista de Eletroeletrônicos", "Analista de Eletroportáteis", "Gerente de Estoque", "Gerente Geral", "Operador de Caixa"})
        Me.CargoComboBox1.Location = New System.Drawing.Point(36, 48)
        Me.CargoComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CargoComboBox1.Name = "CargoComboBox1"
        Me.CargoComboBox1.Size = New System.Drawing.Size(206, 25)
        Me.CargoComboBox1.TabIndex = 1
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
        Me.pnlTop.TabIndex = 63
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
        Me.PictureBox1.Image = Global.SimplrView.My.Resources.Resources.funcionario
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
        Me.Label1.Size = New System.Drawing.Size(434, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastro de Funcinários"
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
        Me.gpbAcoes.TabIndex = 103
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(1, 639)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(568, 1)
        Me.Panel4.TabIndex = 106
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(569, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 540)
        Me.Panel3.TabIndex = 105
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 540)
        Me.Panel2.TabIndex = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 519)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 16)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "* Campos Obrigatórios"
        '
        'frmCadastroFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 640)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gpbAcoes)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.cmbPesquisa)
        Me.Controls.Add(Me.tbcDados)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCadastroFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simplr View"
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbfuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcDados.ResumeLayout(False)
        Me.tbpDadosPrincipais.ResumeLayout(False)
        Me.tbpDadosPrincipais.PerformLayout()
        Me.tbpDocumentos.ResumeLayout(False)
        Me.tbpDocumentos.PerformLayout()
        Me.tbpEndereco.ResumeLayout(False)
        Me.tbpEndereco.PerformLayout()
        Me.tbpOutrasInformacoes.ResumeLayout(False)
        Me.tbpOutrasInformacoes.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbAcoes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_finalstopDataSet As db_finalstopDataSet
    Friend WithEvents TbfuncionarioBindingSource As BindingSource
    Friend WithEvents TbfuncionarioTableAdapter As db_finalstopDataSetTableAdapters.tbfuncionarioTableAdapter
    Friend WithEvents TableAdapterManager As db_finalstopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents label2 As Label
    Friend WithEvents cmbPesquisa As ComboBox
    Friend WithEvents tbcDados As TabControl
    Friend WithEvents tbpDadosPrincipais As TabPage
    Friend WithEvents GeneroComboBox1 As ComboBox
    Friend WithEvents NivelComboBox1 As ComboBox
    Friend WithEvents EmailTextBox1 As TextBox
    Friend WithEvents TelefoneMaskedTextBox1 As MaskedTextBox
    Friend WithEvents SenhaTextBox1 As TextBox
    Friend WithEvents LoginTextBox1 As TextBox
    Friend WithEvents NomeTextBox1 As TextBox
    Friend WithEvents tbpDocumentos As TabPage
    Friend WithEvents lblValidadorPis As Label
    Friend WithEvents lblValidador As Label
    Friend WithEvents Estado_civilComboBox1 As ComboBox
    Friend WithEvents Serie_carteiraMaskedTextBox1 As MaskedTextBox
    Friend WithEvents Numero_carteiraMaskedTextBox1 As MaskedTextBox
    Friend WithEvents PisMaskedTextBox1 As MaskedTextBox
    Friend WithEvents Certificado_reservistaMaskedTextBox1 As MaskedTextBox
    Friend WithEvents Titulo_eleitoralMaskedTextBox1 As MaskedTextBox
    Friend WithEvents RgMaskedTextBox1 As MaskedTextBox
    Friend WithEvents CpfMaskedTextBox As MaskedTextBox
    Friend WithEvents tbpEndereco As TabPage
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents EstadoComboBox1 As ComboBox
    Friend WithEvents CidadeTextBox1 As TextBox
    Friend WithEvents Ponto_refTextBox As TextBox
    Friend WithEvents ComplementoTextBox As TextBox
    Friend WithEvents NumeroTextBox1 As TextBox
    Friend WithEvents EnderecoTextBox1 As TextBox
    Friend WithEvents CepMaskedTextBox1 As MaskedTextBox
    Friend WithEvents tbpOutrasInformacoes As TabPage
    Friend WithEvents ObsTextBox1 As TextBox
    Friend WithEvents FeriasTextBox1 As TextBox
    Friend WithEvents Data_demissaoMaskedTextBox1 As MaskedTextBox
    Friend WithEvents Data_admissaoMaskedTextBox1 As MaskedTextBox
    Friend WithEvents SalarioMaskedTextBox1 As MaskedTextBox
    Friend WithEvents FuncaoTextBox1 As TextBox
    Friend WithEvents CargoComboBox1 As ComboBox
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
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
End Class

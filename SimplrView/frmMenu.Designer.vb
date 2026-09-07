<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pcbLogo = New System.Windows.Forms.PictureBox()
        Me.btnCadastros = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnSobre = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnRelatorios = New System.Windows.Forms.Button()
        Me.pnlBotoes = New System.Windows.Forms.Panel()
        Me.btnProdutos = New System.Windows.Forms.Button()
        Me.btnFuncionarios = New System.Windows.Forms.Button()
        Me.btnFornecedores = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.lblBemVindo = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.tmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.CduOpcoes = New SimplrView.cduOpcoes()
        Me.CduVendas = New SimplrView.cduVendas()
        Me.CduSobre = New SimplrView.cduSobre()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.pcbLogo)
        Me.pnlSidebar.Controls.Add(Me.btnCadastros)
        Me.pnlSidebar.Controls.Add(Me.btnOptions)
        Me.pnlSidebar.Controls.Add(Me.btnSobre)
        Me.pnlSidebar.Controls.Add(Me.btnHistory)
        Me.pnlSidebar.Controls.Add(Me.btnRelatorios)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(190, 550)
        Me.pnlSidebar.TabIndex = 0
        '
        'pcbLogo
        '
        Me.pcbLogo.Location = New System.Drawing.Point(45, 45)
        Me.pcbLogo.Name = "pcbLogo"
        Me.pcbLogo.Size = New System.Drawing.Size(100, 100)
        Me.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbLogo.TabIndex = 9
        Me.pcbLogo.TabStop = False
        '
        'btnCadastros
        '
        Me.btnCadastros.FlatAppearance.BorderSize = 0
        Me.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastros.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnCadastros.Image = Global.SimplrView.My.Resources.Resources.seta_yellow
        Me.btnCadastros.Location = New System.Drawing.Point(0, 190)
        Me.btnCadastros.Name = "btnCadastros"
        Me.btnCadastros.Size = New System.Drawing.Size(190, 50)
        Me.btnCadastros.TabIndex = 0
        Me.btnCadastros.Tag = "0"
        Me.btnCadastros.Text = "Cadastros"
        Me.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCadastros.UseVisualStyleBackColor = False
        '
        'btnOptions
        '
        Me.btnOptions.FlatAppearance.BorderSize = 0
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.ForeColor = System.Drawing.Color.White
        Me.btnOptions.Location = New System.Drawing.Point(0, 450)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(190, 50)
        Me.btnOptions.TabIndex = 3
        Me.btnOptions.Tag = "3"
        Me.btnOptions.Text = "Opções"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnSobre
        '
        Me.btnSobre.FlatAppearance.BorderSize = 0
        Me.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSobre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSobre.ForeColor = System.Drawing.Color.White
        Me.btnSobre.Location = New System.Drawing.Point(0, 500)
        Me.btnSobre.Name = "btnSobre"
        Me.btnSobre.Size = New System.Drawing.Size(190, 50)
        Me.btnSobre.TabIndex = 3
        Me.btnSobre.Tag = "3"
        Me.btnSobre.Text = "Sobre"
        Me.btnSobre.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.FlatAppearance.BorderSize = 0
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnHistory.Location = New System.Drawing.Point(0, 290)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(190, 50)
        Me.btnHistory.TabIndex = 2
        Me.btnHistory.Tag = "2"
        Me.btnHistory.Text = "Histórico de Vendas"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnRelatorios
        '
        Me.btnRelatorios.FlatAppearance.BorderSize = 0
        Me.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelatorios.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelatorios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnRelatorios.Image = Global.SimplrView.My.Resources.Resources.seta_yellow
        Me.btnRelatorios.Location = New System.Drawing.Point(0, 240)
        Me.btnRelatorios.Name = "btnRelatorios"
        Me.btnRelatorios.Size = New System.Drawing.Size(190, 50)
        Me.btnRelatorios.TabIndex = 1
        Me.btnRelatorios.Tag = "1"
        Me.btnRelatorios.Text = "Relatórios"
        Me.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRelatorios.UseVisualStyleBackColor = True
        '
        'pnlBotoes
        '
        Me.pnlBotoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlBotoes.Controls.Add(Me.btnProdutos)
        Me.pnlBotoes.Controls.Add(Me.btnFuncionarios)
        Me.pnlBotoes.Controls.Add(Me.btnFornecedores)
        Me.pnlBotoes.Controls.Add(Me.btnCliente)
        Me.pnlBotoes.Location = New System.Drawing.Point(190, 190)
        Me.pnlBotoes.Name = "pnlBotoes"
        Me.pnlBotoes.Size = New System.Drawing.Size(150, 200)
        Me.pnlBotoes.TabIndex = 1
        Me.pnlBotoes.Visible = False
        '
        'btnProdutos
        '
        Me.btnProdutos.FlatAppearance.BorderSize = 0
        Me.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdutos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdutos.Location = New System.Drawing.Point(0, 150)
        Me.btnProdutos.Name = "btnProdutos"
        Me.btnProdutos.Size = New System.Drawing.Size(150, 50)
        Me.btnProdutos.TabIndex = 3
        Me.btnProdutos.Text = "Produtos"
        Me.btnProdutos.UseVisualStyleBackColor = True
        '
        'btnFuncionarios
        '
        Me.btnFuncionarios.FlatAppearance.BorderSize = 0
        Me.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFuncionarios.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFuncionarios.Location = New System.Drawing.Point(0, 100)
        Me.btnFuncionarios.Name = "btnFuncionarios"
        Me.btnFuncionarios.Size = New System.Drawing.Size(150, 50)
        Me.btnFuncionarios.TabIndex = 2
        Me.btnFuncionarios.Text = "Funcionários"
        Me.btnFuncionarios.UseVisualStyleBackColor = True
        '
        'btnFornecedores
        '
        Me.btnFornecedores.FlatAppearance.BorderSize = 0
        Me.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFornecedores.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFornecedores.Location = New System.Drawing.Point(0, 50)
        Me.btnFornecedores.Name = "btnFornecedores"
        Me.btnFornecedores.Size = New System.Drawing.Size(150, 50)
        Me.btnFornecedores.TabIndex = 1
        Me.btnFornecedores.Text = "Fornecedores"
        Me.btnFornecedores.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.FlatAppearance.BorderSize = 0
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliente.Location = New System.Drawing.Point(0, 0)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(150, 50)
        Me.btnCliente.TabIndex = 0
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'lblBemVindo
        '
        Me.lblBemVindo.AutoSize = True
        Me.lblBemVindo.Location = New System.Drawing.Point(206, 517)
        Me.lblBemVindo.Name = "lblBemVindo"
        Me.lblBemVindo.Size = New System.Drawing.Size(124, 17)
        Me.lblBemVindo.TabIndex = 5
        Me.lblBemVindo.Text = "Bem vindo, NOME"
        '
        'lblHora
        '
        Me.lblHora.Location = New System.Drawing.Point(794, 517)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(74, 17)
        Me.lblHora.TabIndex = 6
        Me.lblHora.Text = "00:00:00"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrHora
        '
        Me.tmrHora.Enabled = True
        Me.tmrHora.Interval = 1000
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackgroundImage = Global.SimplrView.My.Resources.Resources.minimize
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(820, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(30, 28)
        Me.btnMinimizar.TabIndex = 3
        Me.btnMinimizar.TabStop = False
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.BackgroundImage = Global.SimplrView.My.Resources.Resources.close
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Location = New System.Drawing.Point(850, 0)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(30, 28)
        Me.btnFechar.TabIndex = 4
        Me.btnFechar.TabStop = False
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'CduOpcoes
        '
        Me.CduOpcoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.CduOpcoes.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CduOpcoes.ForeColor = System.Drawing.Color.White
        Me.CduOpcoes.Location = New System.Drawing.Point(190, 0)
        Me.CduOpcoes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CduOpcoes.Name = "CduOpcoes"
        Me.CduOpcoes.Size = New System.Drawing.Size(690, 550)
        Me.CduOpcoes.TabIndex = 8
        Me.CduOpcoes.Visible = False
        '
        'CduVendas
        '
        Me.CduVendas.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.CduVendas.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CduVendas.ForeColor = System.Drawing.Color.White
        Me.CduVendas.Location = New System.Drawing.Point(190, 30)
        Me.CduVendas.Margin = New System.Windows.Forms.Padding(4)
        Me.CduVendas.Name = "CduVendas"
        Me.CduVendas.Size = New System.Drawing.Size(690, 470)
        Me.CduVendas.TabIndex = 7
        '
        'CduSobre
        '
        Me.CduSobre.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.CduSobre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CduSobre.ForeColor = System.Drawing.Color.White
        Me.CduSobre.Location = New System.Drawing.Point(190, 0)
        Me.CduSobre.Margin = New System.Windows.Forms.Padding(4)
        Me.CduSobre.Name = "CduSobre"
        Me.CduSobre.Size = New System.Drawing.Size(690, 550)
        Me.CduSobre.TabIndex = 2
        Me.CduSobre.Visible = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 550)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.CduOpcoes)
        Me.Controls.Add(Me.CduVendas)
        Me.Controls.Add(Me.CduSobre)
        Me.Controls.Add(Me.pnlBotoes)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblBemVindo)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simplr View"
        Me.pnlSidebar.ResumeLayout(False)
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pcbLogo As PictureBox
    Friend WithEvents btnCadastros As Button
    Friend WithEvents btnSobre As Button
    Friend WithEvents btnRelatorios As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents pnlBotoes As Panel
    Friend WithEvents btnProdutos As Button
    Friend WithEvents btnFuncionarios As Button
    Friend WithEvents btnFornecedores As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents lblBemVindo As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents tmrHora As Timer
    Friend WithEvents CduSobre As cduSobre
    Friend WithEvents CduVendas As cduVendas
    Friend WithEvents CduOpcoes As cduOpcoes
    Friend WithEvents btnOptions As Button
End Class

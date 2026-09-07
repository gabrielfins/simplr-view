<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewUser
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
        Dim LoginLabel As System.Windows.Forms.Label
        Dim SenhaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewUser))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Db_finalstopDataSet = New SimplrView.db_finalstopDataSet()
        Me.TbfuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbfuncionarioTableAdapter = New SimplrView.db_finalstopDataSetTableAdapters.tbfuncionarioTableAdapter()
        Me.TableAdapterManager = New SimplrView.db_finalstopDataSetTableAdapters.TableAdapterManager()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.LoginTextBox = New System.Windows.Forms.TextBox()
        Me.SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.btnViewPass = New System.Windows.Forms.Button()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btnPular = New System.Windows.Forms.Button()
        NomeLabel = New System.Windows.Forms.Label()
        LoginLabel = New System.Windows.Forms.Label()
        SenhaLabel = New System.Windows.Forms.Label()
        Me.pnlTop.SuspendLayout()
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbfuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(26, 119)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(44, 17)
        NomeLabel.TabIndex = 1
        NomeLabel.Text = "Nome"
        '
        'LoginLabel
        '
        LoginLabel.AutoSize = True
        LoginLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LoginLabel.Location = New System.Drawing.Point(244, 119)
        LoginLabel.Name = "LoginLabel"
        LoginLabel.Size = New System.Drawing.Size(40, 17)
        LoginLabel.TabIndex = 3
        LoginLabel.Text = "Login"
        '
        'SenhaLabel
        '
        SenhaLabel.AutoSize = True
        SenhaLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SenhaLabel.Location = New System.Drawing.Point(26, 179)
        SenhaLabel.Name = "SenhaLabel"
        SenhaLabel.Size = New System.Drawing.Size(45, 17)
        SenhaLabel.TabIndex = 5
        SenhaLabel.Text = "Senha"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.btnFechar)
        Me.pnlTop.Controls.Add(Me.Label3)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(469, 72)
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
        Me.btnFechar.Location = New System.Drawing.Point(439, 0)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(30, 30)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.TabStop = False
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Crie um usuário"
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
        'NomeTextBox
        '
        Me.NomeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.NomeTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.ForeColor = System.Drawing.Color.White
        Me.NomeTextBox.Location = New System.Drawing.Point(29, 139)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(195, 22)
        Me.NomeTextBox.TabIndex = 2
        '
        'LoginTextBox
        '
        Me.LoginTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.LoginTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginTextBox.ForeColor = System.Drawing.Color.White
        Me.LoginTextBox.Location = New System.Drawing.Point(247, 139)
        Me.LoginTextBox.Name = "LoginTextBox"
        Me.LoginTextBox.Size = New System.Drawing.Size(195, 22)
        Me.LoginTextBox.TabIndex = 4
        '
        'SenhaTextBox
        '
        Me.SenhaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.SenhaTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SenhaTextBox.ForeColor = System.Drawing.Color.White
        Me.SenhaTextBox.Location = New System.Drawing.Point(29, 199)
        Me.SenhaTextBox.Name = "SenhaTextBox"
        Me.SenhaTextBox.Size = New System.Drawing.Size(220, 22)
        Me.SenhaTextBox.TabIndex = 6
        Me.SenhaTextBox.UseSystemPasswordChar = True
        '
        'btnViewPass
        '
        Me.btnViewPass.BackgroundImage = Global.SimplrView.My.Resources.Resources.baseline_visibility_off_white_36dp
        Me.btnViewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewPass.FlatAppearance.BorderSize = 0
        Me.btnViewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewPass.Location = New System.Drawing.Point(256, 196)
        Me.btnViewPass.Name = "btnViewPass"
        Me.btnViewPass.Size = New System.Drawing.Size(28, 28)
        Me.btnViewPass.TabIndex = 7
        Me.btnViewPass.TabStop = False
        Me.btnViewPass.UseVisualStyleBackColor = True
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.Color.White
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnCadastrar.Location = New System.Drawing.Point(94, 304)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(137, 41)
        Me.btnCadastrar.TabIndex = 8
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        '
        'btnPular
        '
        Me.btnPular.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnPular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPular.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPular.ForeColor = System.Drawing.Color.White
        Me.btnPular.Location = New System.Drawing.Point(237, 304)
        Me.btnPular.Name = "btnPular"
        Me.btnPular.Size = New System.Drawing.Size(137, 41)
        Me.btnPular.TabIndex = 9
        Me.btnPular.Text = "Pular"
        Me.btnPular.UseVisualStyleBackColor = False
        '
        'frmNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(469, 383)
        Me.Controls.Add(Me.btnPular)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.btnViewPass)
        Me.Controls.Add(SenhaLabel)
        Me.Controls.Add(Me.SenhaTextBox)
        Me.Controls.Add(LoginLabel)
        Me.Controls.Add(Me.LoginTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNewUser"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbfuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnFechar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Db_finalstopDataSet As db_finalstopDataSet
    Friend WithEvents TbfuncionarioBindingSource As BindingSource
    Friend WithEvents TbfuncionarioTableAdapter As db_finalstopDataSetTableAdapters.tbfuncionarioTableAdapter
    Friend WithEvents TableAdapterManager As db_finalstopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents LoginTextBox As TextBox
    Friend WithEvents SenhaTextBox As TextBox
    Friend WithEvents btnViewPass As Button
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents btnPular As Button
End Class

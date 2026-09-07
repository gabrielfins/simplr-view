<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.pcbLogo = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Db_finalstopDataSet = New SimplrView.db_finalstopDataSet()
        Me.TbfuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbfuncionarioTableAdapter = New SimplrView.db_finalstopDataSetTableAdapters.tbfuncionarioTableAdapter()
        Me.TableAdapterManager = New SimplrView.db_finalstopDataSetTableAdapters.TableAdapterManager()
        Me.ckbLembrar = New System.Windows.Forms.CheckBox()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.btnViewPass = New System.Windows.Forms.Button()
        Me.pnlSide.SuspendLayout()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbfuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.pnlSide.Controls.Add(Me.pcbLogo)
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Size = New System.Drawing.Size(230, 400)
        Me.pnlSide.TabIndex = 0
        '
        'pcbLogo
        '
        Me.pcbLogo.Location = New System.Drawing.Point(10, 95)
        Me.pcbLogo.Name = "pcbLogo"
        Me.pcbLogo.Size = New System.Drawing.Size(210, 210)
        Me.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbLogo.TabIndex = 0
        Me.pcbLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(332, 51)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(117, 44)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Login"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(259, 180)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(263, 1)
        Me.Panel3.TabIndex = 5
        '
        'txtLogin
        '
        Me.txtLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLogin.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtLogin.ForeColor = System.Drawing.Color.White
        Me.txtLogin.Location = New System.Drawing.Point(301, 153)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(221, 19)
        Me.txtLogin.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(259, 238)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(263, 1)
        Me.Panel2.TabIndex = 8
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.ForeColor = System.Drawing.Color.White
        Me.txtSenha.Location = New System.Drawing.Point(301, 212)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(187, 19)
        Me.txtSenha.TabIndex = 6
        Me.txtSenha.UseSystemPasswordChar = True
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
        'ckbLembrar
        '
        Me.ckbLembrar.AutoSize = True
        Me.ckbLembrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbLembrar.Location = New System.Drawing.Point(259, 261)
        Me.ckbLembrar.Name = "ckbLembrar"
        Me.ckbLembrar.Size = New System.Drawing.Size(105, 21)
        Me.ckbLembrar.TabIndex = 9
        Me.ckbLembrar.TabStop = False
        Me.ckbLembrar.Text = "Lembrar-me"
        Me.ckbLembrar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackgroundImage = Global.SimplrView.My.Resources.Resources.minimize
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(490, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimizar.TabIndex = 1
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
        Me.btnFechar.Location = New System.Drawing.Point(520, 0)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(30, 30)
        Me.btnFechar.TabIndex = 2
        Me.btnFechar.TabStop = False
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SimplrView.My.Resources.Resources.pass
        Me.PictureBox3.Location = New System.Drawing.Point(259, 202)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SimplrView.My.Resources.Resources.user
        Me.PictureBox2.Location = New System.Drawing.Point(259, 144)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnEntrar.Image = Global.SimplrView.My.Resources.Resources.seta_yellow
        Me.btnEntrar.Location = New System.Drawing.Point(340, 331)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(100, 35)
        Me.btnEntrar.TabIndex = 10
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'btnViewPass
        '
        Me.btnViewPass.BackgroundImage = Global.SimplrView.My.Resources.Resources.baseline_visibility_off_white_36dp
        Me.btnViewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewPass.FlatAppearance.BorderSize = 0
        Me.btnViewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewPass.Location = New System.Drawing.Point(494, 206)
        Me.btnViewPass.Name = "btnViewPass"
        Me.btnViewPass.Size = New System.Drawing.Size(28, 28)
        Me.btnViewPass.TabIndex = 7
        Me.btnViewPass.TabStop = False
        Me.btnViewPass.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(550, 400)
        Me.Controls.Add(Me.ckbLembrar)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.pnlSide)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnViewPass)
        Me.Controls.Add(Me.txtSenha)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simplr View"
        Me.pnlSide.ResumeLayout(False)
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbfuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_finalstopDataSet As db_finalstopDataSet
    Friend WithEvents TbfuncionarioBindingSource As BindingSource
    Friend WithEvents TbfuncionarioTableAdapter As db_finalstopDataSetTableAdapters.tbfuncionarioTableAdapter
    Friend WithEvents TableAdapterManager As db_finalstopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents pnlSide As Panel
    Friend WithEvents pcbLogo As PictureBox
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents btnViewPass As Button
    Friend WithEvents btnEntrar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ckbLembrar As CheckBox
End Class

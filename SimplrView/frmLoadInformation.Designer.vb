<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoadInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoadInformation))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bgwImportInfo = New System.ComponentModel.BackgroundWorker()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Db_finalstopDataSet = New SimplrView.db_finalstopDataSet()
        Me.TbpersonalizacaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbpersonalizacaoTableAdapter = New SimplrView.db_finalstopDataSetTableAdapters.tbpersonalizacaoTableAdapter()
        Me.TableAdapterManager = New SimplrView.db_finalstopDataSetTableAdapters.TableAdapterManager()
        Me.TbfuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbfuncionarioTableAdapter = New SimplrView.db_finalstopDataSetTableAdapters.tbfuncionarioTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbpersonalizacaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbfuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SimplrView.My.Resources.Resources.simplr_view_logo
        Me.PictureBox1.Location = New System.Drawing.Point(81, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(405, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'bgwImportInfo
        '
        Me.bgwImportInfo.WorkerReportsProgress = True
        '
        'tmrLoad
        '
        Me.tmrLoad.Enabled = True
        Me.tmrLoad.Interval = 450
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "•"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Db_finalstopDataSet
        '
        Me.Db_finalstopDataSet.DataSetName = "db_finalstopDataSet"
        Me.Db_finalstopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbpersonalizacaoBindingSource
        '
        Me.TbpersonalizacaoBindingSource.DataMember = "tbpersonalizacao"
        Me.TbpersonalizacaoBindingSource.DataSource = Me.Db_finalstopDataSet
        '
        'TbpersonalizacaoTableAdapter
        '
        Me.TbpersonalizacaoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbclienteTableAdapter = Nothing
        Me.TableAdapterManager.tbfornecedorTableAdapter = Nothing
        Me.TableAdapterManager.tbfuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.tbpersonalizacaoTableAdapter = Me.TbpersonalizacaoTableAdapter
        Me.TableAdapterManager.tbprodutoTableAdapter = Nothing
        Me.TableAdapterManager.tbvendaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SimplrView.db_finalstopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'frmLoadInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(566, 376)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoadInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simplr View"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_finalstopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbpersonalizacaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbfuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Db_finalstopDataSet As db_finalstopDataSet
    Friend WithEvents TbpersonalizacaoBindingSource As BindingSource
    Friend WithEvents TbpersonalizacaoTableAdapter As db_finalstopDataSetTableAdapters.tbpersonalizacaoTableAdapter
    Friend WithEvents TableAdapterManager As db_finalstopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents bgwImportInfo As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents TbfuncionarioBindingSource As BindingSource
    Friend WithEvents TbfuncionarioTableAdapter As db_finalstopDataSetTableAdapters.tbfuncionarioTableAdapter
End Class

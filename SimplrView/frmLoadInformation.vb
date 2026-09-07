Imports System.IO
Imports System.Threading

Public Class frmLoadInformation

    Dim moveFrm As MoveForm

    Public Structure MoveForm
        Dim x As Integer
        Dim y As Integer
    End Structure

    Private Sub frmLoadInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Db_finalstopDataSet.tbfuncionario'. Você pode movê-la ou removê-la conforme necessário.
        Dim myMessage As New MyMessageBox
        Try
            Me.TbfuncionarioTableAdapter.Fill(Me.Db_finalstopDataSet.tbfuncionario)
            'TODO: esta linha de código carrega dados na tabela 'Db_finalstopDataSet.tbpersonalizacao'. Você pode movê-la ou removê-la conforme necessário.
            Me.TbpersonalizacaoTableAdapter.Fill(Me.Db_finalstopDataSet.tbpersonalizacao)
        Catch ex As Exception
            myMessage.ShowMessage("Falha ao tentar conectar com o banco de dados.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try

        My.Settings.startup = 2
        My.Settings.Save()
        bgwImportInfo.RunWorkerAsync()

    End Sub

    Public Function GetImage(ByVal byteArrayIn As Byte()) As Image
        Using mStream As New MemoryStream(byteArrayIn)
            Dim img As Image = Nothing
            If byteArrayIn.Length <> 0 Then
                img = Image.FromStream(mStream)
            End If
            Return img
        End Using
    End Function

    Private Sub bgwImportInfo_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwImportInfo.DoWork
        Dim myMessage As New MyMessageBox
        Try
            Dim importOptions = TbpersonalizacaoTableAdapter.SelectAll(Db_finalstopDataSet.tbpersonalizacao)
            Dim importUsers = TbfuncionarioTableAdapter.SelectEmployee(Db_finalstopDataSet.tbfuncionario)
            If importOptions = 0 And importUsers = 0 Then
                My.Settings.startup = 0
                My.Settings.Save()
                Application.Exit()
            ElseIf importOptions = 0 Then
                My.Settings.startup = 0
                My.Settings.Save()
                Application.Exit()
            ElseIf importUsers = 0 Then
                My.Settings.startup = 1
                My.Settings.Save()
                Application.Exit()
            Else
                nomeEmpresa = Db_finalstopDataSet.Tables("tbpersonalizacao").Rows(0)("companyName")
                Dim bytes = Db_finalstopDataSet.Tables("tbpersonalizacao").Rows(0)("logo")
                logo = GetImage(bytes)
                Dim colorR = Db_finalstopDataSet.Tables("tbpersonalizacao").Rows(0)("colorRed")
                Dim colorG = Db_finalstopDataSet.Tables("tbpersonalizacao").Rows(0)("colorGreen")
                Dim colorB = Db_finalstopDataSet.Tables("tbpersonalizacao").Rows(0)("colorBlue")
                sysColor = Color.FromArgb(colorR, colorG, colorB)
                Thread.Sleep(1750)
            End If
        Catch ex As Exception
            myMessage.ShowMessage("Não foi possível estabelecer a conexão com o banco de dados.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bgwImportInfo_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwImportInfo.RunWorkerCompleted
        tmrLoad.Stop()
        Hide()
        Using frm As New frmLogin
            frm.ShowDialog()
        End Using
        Dispose()
    End Sub

    Private Sub tmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        Label1.Text += "•"
        If Label1.Text = "••••" Then
            Label1.Text = "•"
        End If
    End Sub

    Private Sub ControlMouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown, Label1.MouseDown, MyBase.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        moveFrm.x = Left - MousePosition.X
        moveFrm.y = Top - MousePosition.Y
    End Sub

    Private Sub ControlMouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove, Label1.MouseMove, MyBase.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Left = moveFrm.x + MousePosition.X
        Top = moveFrm.y + MousePosition.Y
    End Sub
End Class
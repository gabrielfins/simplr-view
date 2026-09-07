Public Class frmNewUser

    Dim showPass As Boolean = False
    Dim moveFrm As MoveForm

    Public Structure MoveForm
        Dim x As Integer
        Dim y As Integer
    End Structure

    Private Sub ControlMouseDown(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseDown, MyBase.MouseDown, Label3.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        moveFrm.x = Left - MousePosition.X
        moveFrm.y = Top - MousePosition.Y
    End Sub

    Private Sub ControlMouseMove(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseMove, MyBase.MouseMove, Label3.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Left = moveFrm.x + MousePosition.X
        Top = moveFrm.y + MousePosition.Y
    End Sub

    Private Sub frmNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Db_finalstopDataSet.tbfuncionario'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbfuncionarioTableAdapter.Fill(Me.Db_finalstopDataSet.tbfuncionario)
        My.Settings.startup = 1
        My.Settings.Save()
        pnlTop.BackColor = sysColor
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Dispose()
    End Sub

    Private Sub btnViewPass_Click(sender As Object, e As EventArgs) Handles btnViewPass.Click
        If showPass = False Then
            SenhaTextBox.UseSystemPasswordChar = False
            showPass = True
            btnViewPass.BackgroundImage = My.Resources.baseline_visibility_white_36dp
        Else
            SenhaTextBox.UseSystemPasswordChar = True
            showPass = False
            btnViewPass.BackgroundImage = My.Resources.baseline_visibility_off_white_36dp
        End If
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Dim myMessage As New MyMessageBox
        If NomeTextBox.Text.Trim = Nothing Or LoginTextBox.Text.Trim = Nothing Or SenhaTextBox.Text.Trim = Nothing Then
            myMessage.ShowMessage("Complete todos os campos para realizar o cadastro.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            TbfuncionarioTableAdapter.InsertFirstEmployee(NomeTextBox.Text, LoginTextBox.Text, SenhaTextBox.Text, 2)
            Hide()
            Using frm As New frmLoadInformation
                frm.ShowDialog()
            End Using
            Dispose()
        End If
    End Sub

    Private Sub btnPular_Click(sender As Object, e As EventArgs) Handles btnPular.Click
        Dim myMessage As New MyMessageBox
        If myMessage.ShowMessage("Deseja realmente continuar sem cadastrar?", "Simplr View", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Hide()
            Using frm As New frmLoadInformation
                frm.ShowDialog()
            End Using
            Dispose()
        End If
    End Sub

    Private Sub frmNewUser_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim logins = TbfuncionarioTableAdapter.SelectEmployee(Db_finalstopDataSet.tbfuncionario)
        If logins <> 0 Then
            Hide()
            Using frm As New frmLoadInformation
                frm.ShowDialog()
            End Using
            Dispose()
        End If
    End Sub
End Class
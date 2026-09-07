Public Class frmLogin

    Dim showPass As Boolean = False
    Dim moveFrm As MoveForm

    Public Structure MoveForm
        Dim x As Integer
        Dim y As Integer
    End Structure

    Private Sub ControlMouseDown(sender As Object, e As MouseEventArgs) Handles pnlSide.MouseDown, pcbLogo.MouseDown, lblTitle.MouseDown, MyBase.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        moveFrm.x = Left - MousePosition.X
        moveFrm.y = Top - MousePosition.Y
    End Sub

    Private Sub ControlMouseMove(sender As Object, e As MouseEventArgs) Handles pnlSide.MouseMove, pcbLogo.MouseMove, lblTitle.MouseMove, MyBase.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Left = moveFrm.x + MousePosition.X
        Top = moveFrm.y + MousePosition.Y
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Db_finalstopDataSet.tbfuncionario'. Você pode movê-la ou removê-la conforme necessário.
        TbfuncionarioTableAdapter.Fill(Db_finalstopDataSet.tbfuncionario)

        Dim funcs As New Functions
        If logo IsNot Nothing Then
            pcbLogo.Image = logo
        Else
            pcbLogo.Image = My.Resources.simplr_view_icon_png
        End If

        For Each control In Controls
            If TypeOf control Is Panel And control IsNot pnlSide Then
                Dim pnl = DirectCast(control, Panel)
                pnl.BackColor = sysColor
            End If
        Next
        Dim img = btnEntrar.Image
        btnEntrar.Image = funcs.SetImageColor(img)
        btnEntrar.ForeColor = sysColor
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim myMessage As New MyMessageBox
        Dim user As String = txtLogin.Text
        Dim pass As String = txtSenha.Text
        Dim login = TbfuncionarioTableAdapter.Login(Db_finalstopDataSet.tbfuncionario, txtLogin.Text, txtSenha.Text)
        If login = 0 Then
            myMessage.ShowMessage("Usuário ou senha inválidos.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            userName = Db_finalstopDataSet.Tables("tbFuncionario").Rows(0)("nome")
            userLevel = Db_finalstopDataSet.Tables("tbFuncionario").Rows(0)("nivel")
            Dim id = Db_finalstopDataSet.Tables("tbFuncionario").Rows(0)("id_funcionario")
            If ckbLembrar.Checked Then
                My.Settings.id = id
                My.Settings.Save()
            End If
            Hide()
            Using frm As New frmMenu
                frm.ShowDialog()
            End Using
            Dispose()
        End If
    End Sub

    Private Sub btnViewPass_Click(sender As Object, e As EventArgs) Handles btnViewPass.Click
        If txtSenha.UseSystemPasswordChar Then
            txtSenha.UseSystemPasswordChar = False
            btnViewPass.BackgroundImage = My.Resources.baseline_visibility_white_36dp
        Else
            txtSenha.UseSystemPasswordChar = True
            btnViewPass.BackgroundImage = My.Resources.baseline_visibility_off_white_36dp
        End If
    End Sub

    Private Sub txtEnter(sender As Object, e As EventArgs)
        Dim txt = DirectCast(sender, TextBox)
        txt.SelectAll()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim id = My.Settings.id
        If id <> Nothing Then
            Dim login = TbfuncionarioTableAdapter.LoginSavedUser(Db_finalstopDataSet.tbfuncionario, id)
            If login <> 0 Then
                userName = Db_finalstopDataSet.Tables("tbFuncionario").Rows(0)("nome")
                userLevel = Db_finalstopDataSet.Tables("tbfuncionario").Rows(0)("nivel")
                Hide()
                Using frm As New frmMenu
                    frm.ShowDialog()
                End Using
                Dispose()
            End If
        End If
    End Sub
End Class

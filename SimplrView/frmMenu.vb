Public Class frmMenu

    Dim moveFrm As MoveForm
    Dim cadastro, relatorio As Boolean

    Public Structure MoveForm
        Dim x As Integer
        Dim y As Integer
    End Structure

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Application.Exit()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funcs As New Functions
        lblBemVindo.Text = "Bem vindo, " + userName
        lblHora.Text = TimeOfDay
        If userLevel <> 2 Then
            btnHistory.Visible = False
        End If

        If logo IsNot Nothing Then
            pcbLogo.Image = logo
        Else
            pcbLogo.Image = My.Resources.simplr_view_icon_png
        End If

        For Each control In pnlSidebar.Controls
            If TypeOf control Is Button And control IsNot btnSobre And control IsNot btnOptions Then
                Dim btn = DirectCast(control, Button)
                btn.ForeColor = sysColor
                If btn.Image IsNot Nothing Then
                    Dim img = btn.Image
                    btn.Image = funcs.SetImageColor(img)
                End If
            End If
        Next
    End Sub

    Private Sub tmrHora_Tick(sender As Object, e As EventArgs) Handles tmrHora.Tick
        lblHora.Text = TimeOfDay
    End Sub

    Private Sub btnCadastros_Click(sender As Object, e As EventArgs) Handles btnCadastros.Click
        Dim btn = DirectCast(sender, Button)
        For Each control In pnlSidebar.Controls
            If TypeOf control Is Button Then
                If control IsNot btn And control IsNot btnSobre And control IsNot btnOptions Then
                    control.BackColor = Color.FromArgb(16, 16, 16)
                End If
            End If
        Next
        If cadastro = False Then
            cadastro = True
            relatorio = False
            pnlBotoes.Top = btn.Top
            pnlBotoes.Visible = True
            pnlBotoes.BringToFront()
            btn.BackColor = Color.FromArgb(30, 30, 30)
        Else
            cadastro = False
            relatorio = False
            pnlBotoes.Visible = False
            btn.BackColor = Color.FromArgb(16, 16, 16)
        End If
        If userLevel = 0 Then
            btnFuncionarios.Visible = False
            btnProdutos.Visible = False
            pnlBotoes.Size = New Size(150, 100)
        ElseIf userLevel = 1 Then
            btnFuncionarios.Visible = False
            btnProdutos.Location = New Point(0, 100)
            pnlBotoes.Size = New Size(150, 150)
        End If
    End Sub

    Private Sub btnRelatorios_Click(sender As Object, e As EventArgs) Handles btnRelatorios.Click
        Dim btn = DirectCast(sender, Button)
        For Each control In pnlSidebar.Controls
            If TypeOf control Is Button Then
                If control IsNot btn And control IsNot btnSobre And control IsNot btnOptions Then
                    control.BackColor = Color.FromArgb(16, 16, 16)
                End If
            End If
        Next
        If relatorio = False Then
            cadastro = False
            relatorio = True
            pnlBotoes.Top = btnRelatorios.Top
            pnlBotoes.Visible = True
            pnlBotoes.BringToFront()
            btn.BackColor = Color.FromArgb(30, 30, 30)
        Else
            cadastro = False
            relatorio = False
            pnlBotoes.Visible = False
            btn.BackColor = Color.FromArgb(16, 16, 16)
        End If
        If userLevel = 2 Then
            btnFuncionarios.Visible = True
            btnProdutos.Location = New Point(0, 150)
            pnlBotoes.Size = New Size(150, 200)
        Else
            btnFuncionarios.Visible = False
            btnProdutos.Location = New Point(0, 100)
            pnlBotoes.Size = New Size(150, 150)
        End If
        btnProdutos.Visible = True
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Using frm As New frmHistoricoVendas
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Dim btn = DirectCast(sender, Button)
        CduVendas.SendToBack()
        btnSobre.BackColor = Color.FromArgb(16, 16, 16)
        If CduOpcoes.Visible = False Then
            btn.BackColor = Color.FromArgb(1, 1, 1)
            CduOpcoes.Visible = True
            CduSobre.Visible = False
        Else
            btn.BackColor = Color.FromArgb(16, 16, 16)
            CduOpcoes.Visible = False
        End If
    End Sub

    Private Sub btnSobre_Click(sender As Object, e As EventArgs) Handles btnSobre.Click
        Dim btn = DirectCast(sender, Button)
        CduVendas.SendToBack()
        btnOptions.BackColor = Color.FromArgb(16, 16, 16)
        If CduSobre.Visible = False Then
            btn.BackColor = Color.FromArgb(1, 1, 1)
            CduSobre.Visible = True
            CduOpcoes.Visible = False
        Else
            btn.BackColor = Color.FromArgb(16, 16, 16)
            CduSobre.Visible = False
        End If
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        If cadastro = True Then
            Dim frm As New frmCadastroCliente
            frm.ShowDialog()
        ElseIf relatorio = True Then
            Dim frm As New frmRelatorioCliente
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnFornecedores_Click(sender As Object, e As EventArgs) Handles btnFornecedores.Click
        If cadastro = True Then
            Dim frm As New frmCadastroFornecedor
            frm.ShowDialog()
        ElseIf relatorio = True Then
            Dim frm As New frmRelatorioFornecedor
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnFuncionarios_Click(sender As Object, e As EventArgs) Handles btnFuncionarios.Click
        If cadastro = True Then
            Dim frm As New frmCadastroFuncionario
            frm.ShowDialog()
        ElseIf relatorio = True Then
            Dim frm As New frmRelatorioFuncionario
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnProdutos_Click(sender As Object, e As EventArgs) Handles btnProdutos.Click
        If cadastro = True Then
            Dim frm As New frmCadastroProduto
            frm.ShowDialog()
        ElseIf relatorio = True Then
            Dim frm = New frmRelatorioProduto
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnDeslogar_Click(sender As Object, e As EventArgs)
        Dim myMessage As New MyMessageBox
        If myMessage.ShowMessage("Deseja realmente deslogar?", "Simplr View", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            My.Settings.id = Nothing
            My.Settings.Save()
            Hide()
            Using frm As New frmLogin
                frm.ShowDialog()
            End Using
            Dispose()
        End If
    End Sub

    Private Sub ControlMouseDown(sender As Object, e As MouseEventArgs) Handles CduOpcoes.MouseDown, pnlSidebar.MouseDown, pcbLogo.MouseDown, CduVendas.MouseDown, CduSobre.MouseDown, MyBase.MouseDown, lblHora.MouseDown, lblBemVindo.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        moveFrm.x = Left - MousePosition.X
        moveFrm.y = Top - MousePosition.Y
    End Sub

    Private Sub ControlMouseMove(sender As Object, e As MouseEventArgs) Handles CduOpcoes.MouseMove, pnlSidebar.MouseMove, pcbLogo.MouseMove, CduVendas.MouseMove, CduSobre.MouseMove, MyBase.MouseMove, lblHora.MouseMove, lblBemVindo.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Left = moveFrm.x + MousePosition.X
        Top = moveFrm.y + MousePosition.Y
    End Sub

    Public Function SetImageColor(img As Bitmap)
        Dim x As Integer
        Dim y As Integer

        For x = 0 To img.Width - 1
            For y = 0 To img.Height - 1
                img.SetPixel(x, y, sysColor)
            Next
        Next

        Return img
    End Function
End Class
Public Class cduOpcoes

    Dim colorRed, colorGreen, colorBlue As Integer
    Dim foto, selectableImg As Image

    Private Sub pcbColorClick(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox9.Click, PictureBox8.Click, PictureBox7.Click, PictureBox6.Click, PictureBox5.Click, PictureBox4.Click, PictureBox3.Click, PictureBox2.Click, PictureBox10.Click
        Dim pcb As PictureBox = DirectCast(sender, PictureBox)
        pcb.Image = My.Resources.selected_color
        For Each picture As PictureBox In pnlCores.Controls
            If picture IsNot pcb Then
                picture.Image = Nothing
            End If
        Next
        colorRed = pcb.BackColor.R
        colorGreen = pcb.BackColor.G
        colorBlue = pcb.BackColor.B
    End Sub

    Private Sub CheckImage()
        foto = pcbLogo.Image
        If pcbLogo.Image Is Nothing Then
            pcbLogo.BackgroundImage = selectableImg
        Else
            pcbLogo.BackgroundImage = Nothing
        End If
    End Sub

    Public Function imageToByteArray(ByVal Imagem As Image) As Byte()
        Dim ms As New IO.MemoryStream()
        If Imagem IsNot Nothing Then
            Imagem.Save(ms, Imaging.ImageFormat.Png)
        End If
        Return ms.ToArray()
    End Function

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Application.Exit()
    End Sub

    Private Sub cduOpcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pcbLogo.AllowDrop = True
        pnlTop.BackColor = sysColor
        pcbLogo.Image = logo
        colorRed = sysColor.R
        colorGreen = sysColor.G
        colorBlue = sysColor.B

        txtNome.Text = nomeEmpresa

        If userLevel <> 2 Then
            btnSalvar.Enabled = False
            For Each control In pnlContent.Controls
                If TypeOf control IsNot Label Then
                    control.enabled = False
                End If
            Next
        End If

        Dim funcs As New Functions
        selectableImg = funcs.SetImageColor(My.Resources.select_photo_2)
        For Each pcb As PictureBox In pnlCores.Controls
            If pcb.BackColor = sysColor Then
                pcb.Image = My.Resources.selected_color
            Else
                pcb.Image = Nothing
            End If
        Next
        CheckImage()
    End Sub

    Private Sub pcbLogo_Click(sender As Object, e As EventArgs) Handles pcbLogo.Click
        Dim myMessage As New MyMessageBox
        Dim pcb As PictureBox = DirectCast(sender, PictureBox)
        Dim ofd As New OpenFileDialog
        Try
            If ofd.ShowDialog = 1 Then
                pcb.Image = New Bitmap(Image.FromFile(ofd.FileName))
                CheckImage()
            End If
        Catch ex As Exception
            myMessage.ShowMessage("O arquivo selecionado não é uma imagem válida. Verifique a extensão do arquivo e tente novamente.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pcbLogo_DragDrop(sender As Object, e As DragEventArgs) Handles pcbLogo.DragDrop
        Dim myMessage As New MyMessageBox
        Dim data = e.Data.GetData(DataFormats.FileDrop)
        If data IsNot Nothing Then
            Try
                Dim filenames() As String = data
                If filenames.Length > 0 Then
                    pcbLogo.Image = New Bitmap(Image.FromFile(filenames(0)))
                    CheckImage()
                End If
            Catch ex As Exception
                myMessage.ShowMessage("O arquivo arrastado não é uma imagem válida. Verifique a extensão do arquivo e tente novamente.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CheckImage()
            End Try
        End If
    End Sub

    Private Sub pcbLogo_DragEnter(sender As Object, e As DragEventArgs) Handles pcbLogo.DragEnter
        e.Effect = DragDropEffects.Copy
        pcbLogo.BackgroundImage = My.Resources.drop_image
        pcbLogo.Image = Nothing
    End Sub

    Private Sub pcbLogo_DragLeave(sender As Object, e As EventArgs) Handles pcbLogo.DragLeave
        pcbLogo.BackgroundImage = selectableImg
        pcbLogo.Image = foto
        CheckImage()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim myMessage As New MyMessageBox
        Dim image = imageToByteArray(pcbLogo.Image)
        If txtNome.Text = Nothing Then
            myMessage.ShowMessage("Insira o nome de sua empresa para poder continuar.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                TbpersonalizacaoTableAdapter.UpdateConfig(txtNome.Text, image, colorRed, colorGreen, colorBlue)
                If myMessage.ShowMessage("Suas alterações serão carregadas na próxima vez que o programa for reiniciado. Deseja reiniciar o programa agora?", "Simplr View", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Dim parentForm As Form = FindForm()
                    parentForm.Hide()
                    Using frm As New frmLoadInformation
                        frm.ShowDialog()
                    End Using
                    parentForm.Dispose()
                End If
            Catch ex As Exception
                myMessage.ShowMessage("A imagem inserida é muito grande. Tente com uma menor.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRemoverFoto_Click(sender As Object, e As EventArgs) Handles btnRemoverFoto.Click
        pcbLogo.Image = Nothing
        CheckImage()
    End Sub

    Private Sub btnDeslogar_Click(sender As Object, e As EventArgs) Handles btnDeslogar.Click
        Dim myMessage As New MyMessageBox
        Dim nome = txtNome.Text
        Dim cor = Color.FromArgb(colorRed, colorGreen, colorBlue)
        Dim imagem = pcbLogo.Image
        Dim imageBytes = imageToByteArray(imagem)
        If nome <> nomeEmpresa Or cor <> sysColor Or imagem IsNot logo Then
            Dim dlgResult = myMessage.ShowMessage("Deseja salvar suas alterações antes de deslogar?", "Simplr View", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
            Select Case dlgResult
                Case DialogResult.Yes
                    TbpersonalizacaoTableAdapter.UpdateConfig(nome, imageBytes, colorRed, colorGreen, colorBlue)
                    Deslogar(dlgResult)
                Case DialogResult.No
                    Deslogar(dlgResult)
                Case DialogResult.Cancel
            End Select
        Else
            If myMessage.ShowMessage("Deseja realmente deslogar?", "Simplr View", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Deslogar(DialogResult.No)
            End If
        End If
    End Sub

    Private Sub Deslogar(caso As DialogResult)
        My.Settings.id = Nothing
        My.Settings.Save()
        Dim parentForm As Form = FindForm()
        parentForm.Hide()
        Using frm = SelectLogoutForm(caso)
            frm.ShowDialog()
        End Using
        parentForm.Dispose()
    End Sub

    Private Function SelectLogoutForm(caso As DialogResult)
        Dim frm As Form = Nothing

        Select Case caso
            Case DialogResult.Yes
                frm = New frmLoadInformation
            Case DialogResult.No
                frm = New frmLogin
            Case Else
        End Select
        Return frm
    End Function
End Class

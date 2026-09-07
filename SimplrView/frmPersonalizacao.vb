Public Class frmPersonalizacao

    Dim colorRed As Integer
    Dim colorGreen As Integer
    Dim colorBlue As Integer
    Dim foto, selectableImg As Image
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
        sysColor = Color.FromArgb(colorRed, colorGreen, colorBlue)
        pnlTop.BackColor = sysColor
        Dim funcs As New Functions
        selectableImg = funcs.SetImageColor(My.Resources.select_photo)
        pcbLogo.BackgroundImage = selectableImg
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
        Dispose()
    End Sub

    Private Sub pcbLogo_Click(sender As Object, e As EventArgs) Handles pcbLogo.Click
        Dim myMessage As New MyMessageBox
        Dim pcb As PictureBox = DirectCast(sender, PictureBox)
        Dim ofd As New OpenFileDialog
        Try
            If ofd.ShowDialog = 1 Then
                pcb.Image = Image.FromFile(ofd.FileName)
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
                    pcbLogo.Image = Image.FromFile(filenames(0))
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
        pcbLogo.BackgroundImage = My.Resources.select_image_newer
        pcbLogo.Image = foto
        CheckImage()
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Dim myMessage As New MyMessageBox
        Dim image = imageToByteArray(pcbLogo.Image)
        If txtNome.Text = Nothing Then
            myMessage.ShowMessage("Insira o nome de sua empresa para poder continuar.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If pcbLogo.Image Is Nothing Then
                If myMessage.ShowMessage("Deseja realmente continuar sem uma logo? Você poderá adiconar depois nas opções.", "Simplr View", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    TbpersonalizacaoTableAdapter.CadastrarOpcoes(txtNome.Text, image, colorRed, colorGreen, colorBlue)
                End If
            Else
                Try
                    TbpersonalizacaoTableAdapter.CadastrarOpcoes(txtNome.Text, image, colorRed, colorGreen, colorBlue)
                Catch ex As Exception
                    myMessage.ShowMessage("A imagem inserida é muito grande. Tente com uma menor.", "Simplr View", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            Hide()
            Using frm As New frmNewUser
                frm.ShowDialog
            End Using
            Dispose()
        End If
    End Sub

    Private Sub frmPersonalização_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Db_finalstopDataSet.tbpersonalizacao'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbpersonalizacaoTableAdapter.Fill(Me.Db_finalstopDataSet.tbpersonalizacao)
        pcbLogo.AllowDrop = True
        colorRed = PictureBox1.BackColor.R
        colorGreen = PictureBox1.BackColor.G
        colorBlue = PictureBox1.BackColor.B

        sysColor = Color.FromArgb(colorRed, colorGreen, colorBlue)
        pnlTop.BackColor = sysColor
        Dim funcs As New Functions
        selectableImg = funcs.SetImageColor(My.Resources.select_photo_2)
        pcbLogo.BackgroundImage = selectableImg

        CheckImage()
    End Sub

    Private Sub frmPersonalizacao_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If TbpersonalizacaoTableAdapter.SelectAll(Db_finalstopDataSet.tbpersonalizacao) <> 0 Then
            Hide()
            Using frm As New frmNewUser
                frm.ShowDialog()
            End Using
            Dispose()
        End If
    End Sub

    Private Sub btnRemoverFoto_Click(sender As Object, e As EventArgs) Handles btnRemoverFoto.Click
        pcbLogo.Image = Nothing
        CheckImage()
    End Sub
End Class
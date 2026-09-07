Public Class cduSobre
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Application.Exit()
    End Sub

    Private Sub cduSobre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If logo IsNot Nothing Then
            pcbLogo.Image = logo
        Else
            pcbLogo.Image = My.Resources.simplr_view_icon_png
        End If

    End Sub
End Class

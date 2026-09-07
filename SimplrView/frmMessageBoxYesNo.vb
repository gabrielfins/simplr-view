Public Class frmMessageBoxYesNo

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property

    Public Property MessageIcon() As Image
        Get
            Return pcbIcon.Image
        End Get
        Set(value As Image)
            pcbIcon.Image = value
        End Set
    End Property

    Public Property Message() As String
        Get
            Return lblMessage.Text
        End Get
        Set(value As String)
            lblMessage.Text = value
        End Set
    End Property

End Class
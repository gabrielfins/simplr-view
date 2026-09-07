Public Class MyMessageBox

    Public Function ShowMessage(message As String, caption As String, Optional button As MessageBoxButtons = MessageBoxButtons.OK, Optional icon As MessageBoxIcon = MessageBoxIcon.Information) As DialogResult
        Dim dlgResult As DialogResult = DialogResult.None
        Select Case button
            Case MessageBoxButtons.OK
                Using msgOK As New frmMessageBoxOK
                    msgOK.Text = caption
                    msgOK.Message = message
                    Select Case icon
                        Case MessageBoxIcon.Information
                            msgOK.MessageIcon = My.Resources.information_icon
                        Case MessageBoxIcon.Warning
                            msgOK.MessageIcon = My.Resources.warning_icon
                        Case MessageBoxIcon.Error
                            msgOK.MessageIcon = My.Resources.error_icon
                    End Select
                    dlgResult = msgOK.ShowDialog
                End Using
            Case MessageBoxButtons.YesNo
                Using msgYesNo As New frmMessageBoxYesNo
                    msgYesNo.Text = caption
                    msgYesNo.Message = message
                    Select Case icon
                        Case MessageBoxIcon.Information
                            msgYesNo.MessageIcon = My.Resources.information_icon
                        Case MessageBoxIcon.Warning
                            msgYesNo.MessageIcon = My.Resources.warning_icon
                        Case MessageBoxIcon.Error
                            msgYesNo.MessageIcon = My.Resources.error_icon
                    End Select
                    dlgResult = msgYesNo.ShowDialog
                End Using
            Case MessageBoxButtons.YesNoCancel
                Using msgYesNoCancel As New frmMessageBoxYesNoCancel
                    msgYesNoCancel.Text = caption
                    msgYesNoCancel.Message = message
                    Select Case icon
                        Case MessageBoxIcon.Information
                            msgYesNoCancel.MessageIcon = My.Resources.information_icon
                        Case MessageBoxIcon.Warning
                            msgYesNoCancel.MessageIcon = My.Resources.warning_icon
                        Case MessageBoxIcon.Error
                            msgYesNoCancel.MessageIcon = My.Resources.error_icon
                    End Select
                    dlgResult = msgYesNoCancel.ShowDialog
                End Using
        End Select
        Return dlgResult
    End Function
End Class

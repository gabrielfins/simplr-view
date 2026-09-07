Public Class Functions
    Public Function SetImageColor(img As Bitmap)
        Dim x As Integer
        Dim y As Integer
        Dim alpha As Byte
        Dim red As Byte
        Dim green As Byte
        Dim blue As Byte

        For x = 0 To img.Width - 1
            For y = 0 To img.Height - 1
                alpha = img.GetPixel(x, y).A
                red = img.GetPixel(x, y).R
                green = img.GetPixel(x, y).G
                blue = img.GetPixel(x, y).B
                If alpha > 0 Then
                    Dim newColor As Color = Color.FromArgb(alpha, sysColor.R, sysColor.G, sysColor.B)
                    img.SetPixel(x, y, newColor)
                End If
            Next
        Next

        Return img
    End Function

    Public Function SetImagePredefinedColor(img As Bitmap, color As Color)
        Dim x As Integer
        Dim y As Integer
        Dim alpha As Byte = color.A
        Dim red As Byte = color.R
        Dim green As Byte
        Dim blue As Byte

        For x = 0 To img.Width - 1
            For y = 0 To img.Height - 1
                alpha = img.GetPixel(x, y).A
                red = img.GetPixel(x, y).R
                green = img.GetPixel(x, y).G
                blue = img.GetPixel(x, y).B
                If alpha > 0 Then
                    Dim newColor As Color = Color.FromArgb(alpha, color.R, color.G, color.B)
                    img.SetPixel(x, y, newColor)
                End If
            Next
        Next

        Return img
    End Function
End Class

Public Class MainWindow

    Private Sub versionLabel_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles versionLabel.BackColorChanged
        versionLabel.Parent = SplashBox
        versionLabel.BackColor = Color.FromArgb(128, 0, 0, 0)
    End Sub
End Class

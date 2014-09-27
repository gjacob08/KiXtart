Public Class MainWindow

    Private Sub versionLabel_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles versionLabel.BackColorChanged
        versionLabel.Parent = SplashBox
        versionLabel.BackColor = Color.FromArgb(128, 0, 0, 0)
    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripStatusLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub settingskixButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingskixButton.Click

    End Sub
End Class

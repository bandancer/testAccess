Public Class mainForm
    Private Sub openImport_Click(sender As Object, e As EventArgs) Handles openImport.Click
        importPage.ShowDialog()
    End Sub

    Private Sub openSearchDpcode_Click(sender As Object, e As EventArgs) Handles openSearchDpcode.Click
        searchDpcodePage.Show()
    End Sub

    Private Sub settingBtn_Click(sender As Object, e As EventArgs) Handles settingBtn.Click
        settingPage.ShowDialog()
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '显示初期设定值
        accessPathLbl.Text = settingPage.accessPath.Text
        defaultFilePathLbl.Text = settingPage.defaultFilePath.Text
    End Sub
End Class
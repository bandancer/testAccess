Public Class settingPage

    Private operationFile As OperationFile

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        operationFile = New OperationFile()

    End Sub
    Private Sub selectAccessBtn_Click(sender As Object, e As EventArgs) Handles selectAccessBtn.Click
        operationFile.selectFile_Click(accessPath)
        refreshMainFormSettingLbl()
    End Sub

    Private Sub selDefaultFilePathBtn_Click(sender As Object, e As EventArgs) Handles selDefaultFilePathBtn.Click
        operationFile.selectFolder_Click(defaultFilePath)
        refreshMainFormSettingLbl()
    End Sub

    Private Sub refreshMainFormSettingLbl()

        '刷新主页面的label文字内容
        mainForm.accessPathLbl.Text = accessPath.Text
        mainForm.defaultFilePathLbl.Text = defaultFilePath.Text

    End Sub

End Class
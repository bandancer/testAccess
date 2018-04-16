Public Class OperationFile

    Private openFileDialog1

    Public Sub New()
        openFileDialog1 = New OpenFileDialog()
        openFileDialog1.InitialDirectory = "C:\"
        openFileDialog1.Filter = "txt files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
    End Sub

    Public Sub selectFile_Click(textBox As TextBox)
        openFileDialog1.InitialDirectory = settingPage.defaultFilePath.Text
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            textBox.Text = openFileDialog1.FileName
        End If
    End Sub

    Public Sub selectFolder_Click(textBox As TextBox)
        textBox.Text = SelectFolder("请选择目录", True)
    End Sub

    Private Function SelectFolder(ByVal Describe As String, Optional ByVal ShowNewFolder As Boolean = True) As String
        Using nOpen As New System.Windows.Forms.FolderBrowserDialog()
            nOpen.Description = Describe
            nOpen.ShowNewFolderButton = ShowNewFolder
            nOpen.ShowDialog()
            Return nOpen.SelectedPath
        End Using
    End Function

End Class

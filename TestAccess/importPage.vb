Public Class importPage

    Private operationFile As OperationFile

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        operationFile = New OperationFile()

    End Sub

    Private Sub selectFile_Click(sender As Object, e As EventArgs) Handles selectFile1Btn.Click
        operationFile.selectFile_Click(TextBox1)
    End Sub

    Private Sub selectFile2_Click(sender As Object, e As EventArgs) Handles selectFile2Btn.Click
        operationFile.selectFile_Click(TextBox2)
    End Sub

    Private Sub addImport1_Click(sender As Object, e As EventArgs) Handles addImport1.Click



    End Sub
End Class

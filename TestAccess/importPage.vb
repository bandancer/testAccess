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

    Private Sub addImport1_Click(sender As Object, e As EventArgs) Handles addImport1Btn.Click



    End Sub

    ''' <summary>
    ''' 导入excel
    ''' </summary>
    ''' <param name="fileName">文件名</param>
    ''' <param name="sheetNum">sheet名</param>
    ''' <param name="excelTitle">excel数据标题List</param>
    Private Sub import(ByVal fileName As String, ByVal sheetNum As String, ByVal excelTitle As List(Of String))
        Dim opeExcel As New OperationExcel
        opeExcel.importExcel(fileName, sheetNum, excelTitle, New DpCodeTable, Nothing)
    End Sub
End Class

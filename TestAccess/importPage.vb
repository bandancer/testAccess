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

        Dim excelTitle As New List(Of String)
        excelTitle.Add("InterfaceType")
        excelTitle.Add("COnumber")
        excelTitle.Add("SLA")
        excelTitle.Add("ShipDate")
        excelTitle.Add("Bill-ToCustomer")
        excelTitle.Add("CustomerPONumber")
        excelTitle.Add("Site")
        excelTitle.Add("Job")
        excelTitle.Add("MPCode")
        excelTitle.Add("Project")
        excelTitle.Add("ItemNumber")
        excelTitle.Add("QuantitytoWork")
        excelTitle.Add("Remarks")
        excelTitle.Add("SeqNo")
        excelTitle.Add("SONbr")
        excelTitle.Add("SOLine")
        excelTitle.Add("Sales/Job")
        excelTitle.Add("NetPrice")
        excelTitle.Add("SubItem")
        excelTitle.Add("CustomerItemComment")
        excelTitle.Add("Transactionnumber")
        excelTitle.Add("UserID")
        excelTitle.Add("Timestamp")
        excelTitle.Add("FileName")
        excelTitle.Add("InvoiceGroup")
        excelTitle.Add("Originalbillingsite")
        excelTitle.Add("InvPeriod")
        excelTitle.Add("InvDate")
        excelTitle.Add("WW_DPCM2_CHR07")
        excelTitle.Add("WW_DPCM2_CHR08")
        excelTitle.Add("WW_DPCM2_CHR09")
        excelTitle.Add("WW_DPCM2_CHR10")
        excelTitle.Add("WW_DPCM2_PT_DESC1")
        excelTitle.Add("WW_DPCM2_PT_DESC2")
        excelTitle.Add("WW_DPCM2_DTE02")
        excelTitle.Add("WW_DPCM2_DTE03")
        excelTitle.Add("WW_DPCM2_DTE04")
        excelTitle.Add("WW_DPCM2_DTE05")
        excelTitle.Add("WW_DPCM2_DEC01")
        excelTitle.Add("WW_DPCM2_DEC02")
        excelTitle.Add("WW_DPCM2_DEC03")
        excelTitle.Add("WW_DPCM2_DEC04")
        excelTitle.Add("WW_DPCM2_DEC05")
        excelTitle.Add("WW_DPCM2_LOG01")
        excelTitle.Add("WW_DPCM2_LOG02")
        excelTitle.Add("WW_DPCM2_LOG03")
        excelTitle.Add("WW_DPCM2_LOG04")
        excelTitle.Add("WW_DPCM2_LOG05")
        excelTitle.Add("SO/INVPrice")
        excelTitle.Add("InvoiceNumber")

        import(TextBox1.Text, "Data", excelTitle)

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

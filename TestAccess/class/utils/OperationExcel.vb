Imports System.Data.OleDb

Public Class OperationExcel

    Private myDataset1

    Private Sub connectToExcel(ByVal fileName As String, ByVal sheetNum As String)

        'Use below code to retrieve data from an Excel file. 
        'Code to open the file here. 
        Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & fileName & "';Extended Properties=Excel 8.0;"

        'Now using the OledbDataAdapter you can query the excel sheet. 
        myDataset1 = New DataSet

        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM [" & sheetNum & "]", strConn)
        da.TableMappings.Clear()
        da.TableMappings.Add("Table", "ExcelTest")
        da.Fill(myDataset1)

    End Sub

    ''' <summary>
    ''' 把excel数据导入数据库中
    ''' </summary>
    ''' <param name="fileName">excel文件名</param>
    ''' <param name="sheetNum">sheet名</param>
    ''' <param name="excelTitle">excel数据标题List</param>
    ''' <param name="table">数据库表</param>
    ''' <param name="tableTitle">数据库表字段名List</param>
    Public Sub importExcel(ByVal fileName As String, ByVal sheetNum As String, ByVal excelTitle As List(Of String), ByVal table As BaseSql, ByVal tableTitle As List(Of String))

        '读取excel
        If fileName Is Nothing Or fileName = "" Then
            MsgBox("请选择文件！")
            Return
        End If
        '默认取得sheet1的数据
        If sheetNum Is Nothing Then sheetNum = "sheet1"
        connectToExcel(fileName, sheetNum)

        If tableTitle.Count = 0 Then
            MsgBox("excel列数与表不一致，请确认！")
        End If

        If tableTitle.Count <> excelTitle.Count Then
            MsgBox("excel列数与表不一致，请确认！")
        End If

        Dim dpCodeTable As DpCodeTable = New DpCodeTable
        Dim dataList As List(Of String) = New List(Of String)

        '插入数据库
        For s = 0 To myDataset1.Tables(0).Rows.Count - 1

            '拼接值
            dataList = New List(Of String)
            For n = 0 To excelTitle.Count - 1
                dataList.Add(myDataset1.Tables(0).Rows(s).Item(excelTitle.ElementAt(n)))
            Next

            '拼接成sql
            table.insertByTitle(tableTitle, dataList)
        Next
        MsgBox("导入成功！")
    End Sub
    ''' <summary>
    ''' 把datagrid数据导出到excel
    ''' </summary>
    ''' <param name="x">datagrid</param>
    ''' <param name="sheetName">sheet名</param>
    ''' <returns></returns>
    Public Function exportExcel(ByVal x As DataGridView, ByVal sheetName As String) As Boolean '导出到Excel函数
        Try
            If x.Rows.Count <= 0 Then '判断记录数,如果没有记录就退出
                MessageBox.Show("没有记录可以导出", "没有可以导出的项目", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            Else '如果有记录就导出到Excel
                Dim xx As Object : Dim yy As Object
                xx = CreateObject("Excel.Application") '创建Excel对象
                yy = xx.workbooks.add()
                '删除后两sheet页
                yy.worksheets(2).delete()
                yy.worksheets(3).delete()
                '设定sheet1名称
                'yy.worksheets(1).Name = sheetName
                Dim i As Integer, u As Integer = 0, v As Integer = 0 '定义循环变量,行列变量
                For i = 1 To x.Columns.Count '把表头写入Excel
                    yy.worksheets(1).cells(1, i) = x.Columns(i - 1).HeaderCell.Value
                Next
                Dim str(x.Rows.Count - 1, x.Columns.Count - 1) '定义一个二维数组
                For u = 1 To x.Rows.Count '行循环
                    For v = 1 To x.Columns.Count '列循环
                        If x.Item(v - 1, u - 1).Value.GetType.ToString <> "System.Guid" Then
                            str(u - 1, v - 1) = x.Item(v - 1, u - 1).Value
                        Else
                            str(u - 1, v - 1) = x.Item(v - 1, u - 1).Value.ToString
                        End If
                    Next
                Next
                yy.worksheets(1).range("A2").Resize(x.Rows.Count, x.Columns.Count).Value = str '把数组一起写入Excel
                yy.worksheets(1).Cells.EntireColumn.AutoFit() '自动调整Excel列
                ' yy.worksheets(1).name = x.TopLeftHeaderCell.Value.ToString '表标题写入作为Excel工作表名称
                xx.visible = True '设置Excel可见
                yy = Nothing '销毁组建释放资源
                xx = Nothing '销毁组建释放资源
            End If
            Return True
        Catch ex As Exception '错误处理
            MessageBox.Show(Err.Description.ToString, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error) '出错提示
            Return False
        End Try
    End Function
End Class

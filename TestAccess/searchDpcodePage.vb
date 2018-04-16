Public Class searchDpcodePage
    Private Sub searchPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“TestAccessDataSet.statementAndDpcode”中。您可以根据需要移动或删除它。
        Me.StatementAndDpcodeTableAdapter.Fill(Me.TestAccessDataSet.statementAndDpcode)

    End Sub

    Private Sub export_Click(sender As Object, e As EventArgs) Handles export.Click
        Dim op As OperationExcel = New OperationExcel
        op.exportExcel(dpcodeGrid, "Detail")
    End Sub

    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy2ToolStripButton.Click
        Try
            Me.StatementAndDpcodeTableAdapter.FillBy2(Me.TestAccessDataSet.statementAndDpcode)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
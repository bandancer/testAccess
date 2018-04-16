Public Class BaseSql

    '列信息
    Public columns As List(Of String)
    Public tableName As String

    Public Sub New()
        tableName = ""
        columns = New List(Of String)
    End Sub
    ''' <summary>
    ''' 根据自定义字段名插入数据库表
    ''' </summary>
    ''' <param name="titleList">自定义字段名List</param>
    ''' <param name="dataList">数据</param>
    Public Sub insertByTitle(ByVal titleList As List(Of String), ByVal dataList As List(Of Object))
        columns = New List(Of String)
        If titleList IsNot Nothing Then
            columns = titleList
        End If
        insert(dataList)
    End Sub

    ''' <summary>
    ''' 插入数据库
    ''' </summary>
    ''' <param name="dataList">数据</param>
    Public Sub insert(ByVal dataList As List(Of Object))
        insertIntoTable(dataList)
    End Sub

    Protected Sub insertIntoTable(ByVal dataList As List(Of Object))

        If columns.Count = 0 Then
            MsgBox("列数与表不一致，请确认！")
        End If

        If columns.Count <> dataList.Count Then
            MsgBox("列数与表不一致，请确认！")
        End If

        Dim sql, column, value As String
        '拼接字段
        column = "insert into " & tableName & "(" & ""
        For m = 0 To columns.Count - 1

            column = column & columns.ElementAt(m) & ""
            If m = columns.Count - 1 Then
                column = column & ") " & ""
            Else
                column = column & ", " & ""
            End If
        Next

        Dim cn As ConnectionAccess = New ConnectionAccess

        '拼接值
        value = " VALUES('"
        For n = 0 To dataList.Count - 1
            value = value & dataList.ElementAt(n) & ""
            If n = dataList.Count - 1 Then
                value = value & "')" & ""
            Else
                value = value & "','" & ""
            End If
        Next

        '拼接成sql
        sql = column & value
        '插入数据库
        cn.excuteSql(sql)
    End Sub

End Class

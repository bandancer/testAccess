Imports System.Data.OleDb

Public Class ConnectionAccess

    '定义一个OLEDB命令并实例化他
    Dim cmd As New OleDbCommand
    '定义一个OLEDB连接并实例化它
    Dim con As New OleDbConnection
    '定义一个OLEDBReader方法来读取数据库
    Dim dr As OleDbDataReader

    Sub connectToAccess()

        '初始化con的连接属性，使用OLEDB模式，数据源为：你指定下路径，我的是在D盘
        'Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\dataSample.mdb
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\testAccess.accdb"
        '打开OLEDB数据连接
        con.Open()
        '初始化OLEDB命令的连接属性为con,这个需要你理解下
        cmd.Connection = con

    End Sub

    Sub closeConnection()
        '完成后关闭dr.con等释放资源
        dr.Close()
        con.Close()
    End Sub

    Function excuteSql(ByRef sql As String)
        '连接数据库
        connectToAccess()

        Dim ret As Object
        '初始化OLEDB命令的语句  就是查询 什么字段从什么表 条件是ID等于你在t1中输入的内容
        cmd.CommandText = sql
        '执行OLEDB命令以ExecuteReader()方式，并返回一个OLEDBReader，赋值给dr
        dr = cmd.ExecuteReader()
        '判断下dr中是否有数据。如果有就把第一个值赋值给t2的值
        If dr.Read() Then
            ret = dr(0)
        Else
            ret = ""
        End If

        '关闭连接
        closeConnection()

        Return ret
    End Function

    Sub deleteTableDpCode()


        'cmd.CommandText = "select keyss from table1 where ID=" & t1.Text & ""
    End Sub

    Function selectDpCode()

        Dim sql As String
        sql = "select * from dpcode"
        Return excuteSql(sql)

    End Function


End Class

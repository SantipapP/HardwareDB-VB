Imports System.Data.OleDb
Module Connector
    Public cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\HW_DB.accdb; Persist Security Info = false;")

    Public Function ConnectDB() As Boolean
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Return True
        Catch ex As Exception
            _Error("")
            Return False
        End Try
    End Function

    Public Function _QueryAsDataTable(ByVal sql As String) As DataTable
        Dim da As New OleDbDataAdapter(sql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "Result")
        Return ds.Tables("Result")
    End Function

    Public Function _InsertAdd(ByVal sql As String) As Boolean
        ConnectDB()
        Dim cmd As New OleDbCommand(sql, cn)
        Return cmd.ExecuteNonQuery() > 0

    End Function
    Public Function _Delete(ByVal sql As String) As Boolean
        ConnectDB()
        Dim cmd As New OleDbCommand(sql, cn)
        Return cmd.ExecuteNonQuery() > 0

    End Function


End Module

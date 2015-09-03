Imports System.Data.OleDb

Module modul_refresh
    Public Sub refreshData(ByVal v As Object, ByVal tbl As String)
        If Not conn.State = ConnectionState.Open Then
            conn.Open()
        End If
        da = New OleDbDataAdapter("select * from " + tbl, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        v.DataSource = dt
        conn.Close()
    End Sub
End Module

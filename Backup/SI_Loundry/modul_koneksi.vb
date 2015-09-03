Imports System.Data.OleDb

Module modul_koneksi
    Public conn As OleDbConnection

    ' Public kon As OleDbConnection
    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public rd As OleDbDataReader

    Public lokasidb As String

    Public nama As String
    Public id_petugas As String




    Sub koneksi()
        lokasidb = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=dbLoundry.accdb"
        conn = New OleDbConnection(lokasidb)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module

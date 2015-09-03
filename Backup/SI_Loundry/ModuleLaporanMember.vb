Imports System.Data.OleDb

Module ModuleLaporanMember
    Public acscmd As New OleDbCommand   'Perintah SQLnya
    Public acsconn As New OleDbConnection
    Public acsda As New OleDbDataAdapter
    Public acsds As New DataSet
    Public strsql As String
    Public strreportname As String

    Sub connect() 'Khusus untuk MS Access accdb kalo mdb jet.oledb.4.0
        If acsconn.State = ConnectionState.Closed Then
            acsconn.ConnectionString = "provider = microsoft.ace.oledb.12.0; data source = dbLoundry.accdb;"
            acsconn.Open()
            If acsconn.State = ConnectionState.Open Then
                MsgBox("Connected")
            End If
        End If
    End Sub
End Module

Public Class FormLaporanMember

    
    Private Sub FormLaporanMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        strsql = "select * from tblMember"
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsda.Fill(acsds)
        strreportname = "laporanMember"
        Dim strreportpath As String = Application.StartupPath & "\" & strreportname & ".rpt"
        If Not IO.File.Exists(strreportpath) Then
            Throw (New Exception("unable to locate report file: " & vbCrLf & strreportpath))
        End If
        Dim rptdocument As New CrystalDecisions.CrystalReports.Engine.ReportClass
        rptdocument.FileName = strreportpath
        rptdocument.Load(strreportpath)
        rptdocument.SetDataSource(acsds.Tables(0))
        reportMember.ShowRefreshButton = False 'sesuai dengan nama report viewernya
        reportMember.ShowCloseButton = False
        reportMember.ShowGroupTreeButton = False
        reportMember.ReportSource = rptdocument
    End Sub


End Class
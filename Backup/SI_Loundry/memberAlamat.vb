Public Class memberAlamat

    Private Sub memberAlamat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        reportAlamat.ReportSource = Nothing
        reportAlamat.Refresh()
        strsql = "select * from tblMember where alamat like '%" & FormLmember.txtKeyword.Text & "%'"
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsda.Fill(acsds)
        strreportname = "LapMemAlamat"
        Dim strreportpath As String = Application.StartupPath & "\" & strreportname & ".rpt"
        If Not IO.File.Exists(strreportpath) Then
            Throw (New Exception("unable to locate report file: " & vbCrLf & strreportpath))
        End If
        Dim rptdocument As New CrystalDecisions.CrystalReports.Engine.ReportClass
        rptdocument.FileName = strreportpath
        rptdocument.Load(strreportpath)
        rptdocument.SetDataSource(acsds.Tables(0))
        reportAlamat.ShowRefreshButton = False 'sesuai dengan nama report viewernya
        reportAlamat.ShowCloseButton = False
        reportAlamat.ShowGroupTreeButton = False
        reportAlamat.ReportSource = rptdocument
    End Sub

    Private Sub reportAlamat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reportAlamat.Load

    End Sub
End Class
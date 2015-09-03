Public Class formLAmbil

    
    Private Sub formLAmbil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        strsql = "select * from tblAmbilCucian"
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsda.Fill(acsds)
        strreportname = "lapDetailAmbil"
        Dim strreportpath As String = Application.StartupPath & "\" & strreportname & ".rpt"
        If Not IO.File.Exists(strreportpath) Then
            Throw (New Exception("unable to locate report file: " & vbCrLf & strreportpath))
        End If
        Dim rptdocument As New CrystalDecisions.CrystalReports.Engine.ReportClass
        rptdocument.FileName = strreportpath
        rptdocument.Load(strreportpath)
        rptdocument.SetDataSource(acsds.Tables(0))
        cvAmbil.ShowRefreshButton = False 'sesuai dengan nama report viewernya
        cvAmbil.ShowCloseButton = False
        cvAmbil.ShowGroupTreeButton = False
        cvAmbil.ReportSource = rptdocument
    End Sub
End Class
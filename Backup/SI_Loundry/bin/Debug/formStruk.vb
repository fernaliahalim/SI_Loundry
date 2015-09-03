Public Class formStruk
    Public nostruk As String
    Private Sub formStruk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        strsql = "select * from tblTransaksi where no_nota like '" & nostruk & "'" '& formTerimaCucian.txtNoNota.Text & "'"
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsda.Fill(acsds)
        strreportname = "lapStruk"
        Dim strreportpath As String = Application.StartupPath & "\" & strreportname & ".rpt"
        If Not IO.File.Exists(strreportpath) Then
            Throw (New Exception("unable to locate report file: " & vbCrLf & strreportpath))
        End If
        Dim rptdocument As New CrystalDecisions.CrystalReports.Engine.ReportClass
        rptdocument.FileName = strreportpath
        rptdocument.Load(strreportpath)
        rptdocument.SetDataSource(acsds.Tables(0))
        cvStruk.ShowRefreshButton = False 'sesuai dengan nama report viewernya
        cvStruk.ShowCloseButton = False
        cvStruk.ShowGroupTreeButton = False
        cvStruk.ReportSource = rptdocument
    End Sub
End Class
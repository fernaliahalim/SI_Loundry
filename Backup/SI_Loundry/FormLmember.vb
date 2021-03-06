Imports System.DBNull

Public Class FormLmember

    Private Sub btnLmember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLmember.Click
        FormLaporanMember.Show()
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        memberAlamat.reportAlamat.ReportSource = Nothing
        memberAlamat.reportAlamat.Refresh()
        If cmbFilter.SelectedItem = "Alamat" Then
            memberAlamat.Show()
        End If
    End Sub

    Private Sub FormLmember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUser.Text = nama
    End Sub

    Private Sub lblKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKeluar.Click
        formLogin.Show()
        Me.Close()

    End Sub

    Private Sub BeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeToolStripMenuItem.Click
        formHome.Show()
        Me.Close()

    End Sub

    Private Sub KasirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KasirToolStripMenuItem.Click
        formKasir.Show()
        Me.Close()

    End Sub

    Private Sub KonsumenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KonsumenToolStripMenuItem.Click
        formKonsumenMember.Show()
        Me.Close()

    End Sub

    Private Sub TerimaCucianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerimaCucianToolStripMenuItem.Click
        formTerimaCucian.Show()
        Me.Close()

    End Sub

    Private Sub AmbilCucianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmbilCucianToolStripMenuItem.Click
        fromAmbilCucian.Show()
        Me.Close()

    End Sub

    Private Sub LaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem.Click
        FormLaporan.Show()
        Me.Close()

    End Sub
End Class
Imports System.Data.OleDb

Public Class formHome

    Private Sub formHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        lblUser.Text = nama

    End Sub

    Private Sub btnKasir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKasir.Click
        formKasir.Show()
        Me.Close()
    End Sub

    Private Sub btnKonsumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKonsumen.Click
        formKonsumenMember.Show()
        Me.Close()
    End Sub

    Private Sub btnTerimaCucian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerimaCucian.Click
        formTerimaCucian.Show()
        Me.Close()

    End Sub

    Private Sub btnAmbilCucian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmbilCucian.Click
        fromAmbilCucian.Show()
        Me.Close()
    End Sub

    Private Sub MemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        formKonsumenMember.Show()
        Me.Close()
    End Sub

    Private Sub BeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub KasirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KasirToolStripMenuItem.Click
        formKasir.Show()
        Me.Close()
    End Sub

    Private Sub KonsumenToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KonsumenToolStripMenuItem.Click
        formKonsumenMember.Show()
        Me.Close()
    End Sub

    Private Sub TerimaCucianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerimaCucianToolStripMenuItem.Click
        formTerimaCucian.Show()
        Me.Close()
    End Sub

    Private Sub AmbilCucianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmbilCucianToolStripMenuItem.Click
        FormLaporan.Show()
        Me.Close()
    End Sub

    Private Sub lblKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKeluar.Click
        formLogin.Show()
        Me.Close()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem.Click
        FormLaporan.Show()
        Me.Close()
    End Sub
End Class
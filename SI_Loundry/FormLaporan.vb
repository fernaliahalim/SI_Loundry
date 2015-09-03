Public Class FormLaporan

    Private Sub btnLmember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLmember.Click
        FormLmember.Show()
        Me.Close()
    End Sub

    Private Sub btnLambil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLambil.Click
        'FormLAmbilLoundry.Show
        formLAmbil.Show()

    End Sub

    Private Sub btnLsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLsimpan.Click
        formLTerimaCucian.Show()

    End Sub

    Private Sub FormLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnLkasir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLkasir.Click
        formLKasir.Show()
    End Sub
End Class
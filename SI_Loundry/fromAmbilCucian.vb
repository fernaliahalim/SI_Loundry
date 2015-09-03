Imports System.Data.OleDb
Public Class fromAmbilCucian

    Dim id As String
    Dim id_ksr As String
    Dim no_nota As String
    Dim total As Double
    Dim sisa As Double
    Dim byr As Double

    Dim notran As Single

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

    End Sub

    Private Sub lblKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKeluar.Click
        formLogin.Show()
        Me.Close()

    End Sub

    Sub setnotrans()
        cmd = New OleDbCommand("select transaksi_kembali from autonumb", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        notran = rd.Item("transaksi_kembali")
        If notran < 9 Then
            txtNoNota.Text = "A00" & notran
        ElseIf notran < 99 Then
            txtNoNota.Text = "A0" & notran
        Else
            txtNoNota.Text = "A" & notran
        End If
    End Sub

    Sub updatenotrans()
        koneksi()
        cmd = New OleDbCommand("update autonumb set transaksi_kembali = transaksi_kembali + 1", conn)
        cmd.ExecuteNonQuery()

    End Sub

    Sub inputtransaksi()
        cmd = New OleDbCommand("select * from tblAmbilCucian where id_pengembalian = '" & txtNoNota.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            MsgBox("no nota telah terpakai")
            Exit Sub
        Else
            ' cmd = New OleDbCommand("insert into tbltransaksi (no_nota,id_petugas) values ('" & txtNoNota.Text & "','" & txtidkasir.Text & "')", conn)

            cmd = New OleDbCommand("insert into tblAmbilCucian(id_pengembalian, id_kasir, no_nota, total_harga, sisa, bayar) values('" & "')", conn)
            cmd.ExecuteNonQuery()

            MsgBox("data berhasil disimpan")
            Call varnol()

        End If
    End Sub

        Sub itungkembalian()
        Try

            If txtBayar.Text < 0 Then
                MsgBox("Data Tidak Valid")
            Else
                txtkembalian.Text = txtBayar.Text - txtSisa.Text

            End If


        Catch ex As Exception

        End Try
    End Sub

    Sub varnol()
        txtBayar.Text = 0
        txtkembalian.Text = 0
    End Sub

    Private Sub fromAmbilCucian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call varnol()
        Call koneksi()
        lblUser.Text = nama
        txtidkasir.Text = id_petugas
        Call setnotrans()
        txtBayar.Enabled = True

        da = New OleDbDataAdapter("select * from tblTransaksi", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tblTransaksi")
        dgvTransaksi.DataSource = (ds.Tables("tblTransaksi"))

        da = New OleDbDataAdapter("select * from tblAmbilCucian", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tblAmbilCucian")
        dgvAmbil.DataSource = (ds.Tables("tblAmbilCucian"))
    End Sub

    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        If Me.dgvTransaksi.RowCount > 0 Then
            If Me.dgvTransaksi.SelectedRows.Count > 0 Then
                Dim strStdID As String = Me.dgvTransaksi.SelectedRows(0).Cells("no_nota").Value
                If Not conn.State = ConnectionState.Open Then
                    conn.Open()
                End If
                Dim da As New OleDb.OleDbDataAdapter("select * from tblTransaksi where no_nota='" & strStdID & "'", conn)
                Dim dt As New DataTable
                da.Fill(dt)

                Me.txtNota.Text = dt.Rows(0).Item("no_nota")
                Me.txtSisa.Text = dt.Rows(0).Item("sisa")
                Me.txtTotal.Text = dt.Rows(0).Item("totalharga")

                txtNota.Enabled = False
                txtSisa.Enabled = False
                txtTotal.Enabled = False
                txtBayar.Enabled = True

                If txtSisa.Text <= 0 Then
                    txtBayar.Enabled = False
                    txtSisa.Enabled = False
                Else
                    txtBayar.Focus()
                End If

            End If

            txtCari.Text = ""

        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim cmd As New OleDb.OleDbCommand
        If Not conn.State = ConnectionState.Open Then
            conn.Open()
        End If


        'add data info table
        cmd.Connection = conn
        cmd.CommandText = "insert into tblAmbilCucian(id_pengambilan, tgl_ambil, id_kasir, no_nota, total_harga, sisa, bayar) values ('" & Me.txtNoNota.Text & " ',' " & Me.dtp.Text & " ',' " & Me.txtidkasir.Text & " ',' " & Me.txtNota.Text & " ',' " & Me.txtTotal.Text & "','" & Me.txtSisa.Text & "','" & Me.txtBayar.Text & "' )"
        cmd.ExecuteNonQuery()

        refreshData(dgvAmbil, "tblAmbilCucian")
        conn.Close()

        'Call inputtransaksi()
        Call updatenotrans()
        Call setnotrans()

        MsgBox("Data Berhasil Disimpan")
        txtNota.Text = ""
        txtTotal.Text = ""
        txtSisa.Text = ""
        txtBayar.Text = 0
        txtkembalian.Text = 0
        txtCari.Focus()
    End Sub

    Private Sub txtBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar.TextChanged
        Call itungkembalian()
        If txtBayar.Text = "" Then
            txtkembalian.Text = 0
        End If
    End Sub

    Sub cari()
        da = New OleDbDataAdapter("select * from tbltransaksi where no_nota like '%" & txtCari.Text & "%'", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbltransaksi")
        dgvTransaksi.DataSource = (ds.Tables("tbltransaksi"))

    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        Call cari()
    End Sub

    Private Sub dtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp.ValueChanged

    End Sub
End Class
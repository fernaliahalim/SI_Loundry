Imports System.Data.OleDb

Public Class formTerimaCucian
    Dim harga As Single

    Dim b_baju As Single
    Dim j_baju As Single
    Dim h_baju As Single

    Dim sepre As Single
    Dim boneka As Single
    Dim selimut As Single
    Dim gorden As Single

    Dim subtotal As Single
    Dim total As Single
    Dim diskon As Single
    Dim bayar As Single
    Dim kembalian As Single

    Dim paket As String
    Dim ket As String
    Dim id_pel As String
    Dim txtstruk As String
    Dim notran As Single

    Sub setnotrans()
        cmd = New OleDbCommand("select transaksi from autonumb", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        notran = rd.Item("transaksi")
        If notran < 9 Then
            txtNoNota.Text = "T00" & notran
        ElseIf notran < 99 Then
            txtNoNota.Text = "T0" & notran
        Else
            txtNoNota.Text = "T" & notran
        End If
    End Sub

    Sub updatenotrans()
        cmd = New OleDbCommand("update autonumb set transaksi = transaksi + 1", conn)
        cmd.ExecuteNonQuery()

    End Sub
    Sub inputtransaksi()
        cmd = New OleDbCommand("select * from tbltransaksi where no_nota = '" & txtNoNota.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            MsgBox("no nota telah terpakai")
            Exit Sub
        Else
            ' cmd = New OleDbCommand("insert into tbltransaksi (no_nota,id_petugas) values ('" & txtNoNota.Text & "','" & txtidkasir.Text & "')", conn)

            If txtketerangan.Text = "" Then
                ket = "-"
            Else
                ket = txtketerangan.Text
            End If
            If txtidpelanggan.Text = "" Then
                id_pel = "-"
            Else
                id_pel = txtidpelanggan.Text
            End If

            cmd = New OleDbCommand("insert into tbltransaksi(no_nota, id_petugas, id_member, nama_pelanggan, tgl_transaksi, tgl_ambil, paket, subtotal, diskon, totalharga, bayar, sisa, kembalian, keterangan) values('" & txtNoNota.Text & "','" & txtidkasir.Text & "','" & id_pel & "','" & txtnamapelanggan.Text & "','" & dtp.Value & "','" & dtp2.Value & "','" & paket & "','" & txttotaldll.Text & "','" & subtotal * diskon & "','" & total & "','" & txtuangmuka.Text & "','" & txtsisanya.Text & "','" & txtSisa.Text & "','" & ket & "')", conn)
            cmd.ExecuteNonQuery()


            If txtberat.Text = "" Then
                b_baju = 0
            Else
                b_baju = txtberat.Text
            End If
            If txtjmlbaju.Text = "" Then
                j_baju = 0
            Else
                j_baju = txtjmlbaju.Text

            End If
            If txtspre.Text = "" Then
                sepre = 0
            Else
                sepre = txtspre.Text

            End If
            If txtboneka.Text = "" Then
                boneka = 0
            Else
                boneka = txtboneka.Text
            End If
            If txtslimut.Text = "" Then
                selimut = 0
            Else
                selimut = txtslimut.Text
            End If
            If txtgorden.Text = "" Then
                gorden = 0
            Else
                gorden = txtgorden.Text
            End If

            cmd = New OleDbCommand("insert into detail_transaksi (no_nota, berat_baju, jumlah_baju, jumlah_sprei, jumlah_boneka,  jumlah_selimut, jumlah_gorden) values('" & txtNoNota.Text & "'," & b_baju & "," & j_baju & "," & sepre & "," & boneka & "," & selimut & "," & gorden & ")", conn)
            cmd.ExecuteNonQuery()

            MsgBox("data berhasil disimpan")
            Call varnol()

        End If


    End Sub

    Sub itungkembalian()
        Try
            'ini revisi
            Dim sisa
            If txtuangmuka.Text < 0 Then
                MsgBox("Data Tidak Valid")
            Else
                If txtuangmuka.Text < txttotalkurangdiskon.Text Then
                    'txtsisanya.Text = txttotalkurangdiskon.Text - txtuangmuka.Text
                    sisa = txttotalkurangdiskon.Text - txtuangmuka.Text
                    txtsisanya.Text = sisa
                    txtSisa.Text = 0
                ElseIf txtuangmuka.Text > txttotalkurangdiskon.Text Then
                    txtsisanya.Text = 0
                    'txtSisa.Text = txtuangmuka.Text - txttotalkurangdiskon.Text
                    sisa = txtuangmuka.Text - txttotalkurangdiskon.Text
                    txtSisa.Text = sisa
                End If

            End If


        Catch ex As Exception

        End Try
    End Sub

    Sub datamember()
        If cebokmember.Checked Then
            cmd = New OleDbCommand("select * from tblmember where id_member='" & txtidpelanggan.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtnamapelanggan.Text = rd.Item("nama")
                txtdiskon.Text = rd.Item("diskon")
                diskon = txtdiskon.Text / 100
            Else
                txtnamapelanggan.Clear()
                txtdiskon.Text = 0

            End If

        End If
    End Sub
    Sub itungharga()
        'baju
        If txtberat.Text = "" Then
            b_baju = 0
        Else
            b_baju = txtberat.Text
        End If

        'spre
        If txtspre.Text = "" Then
            sepre = 0
        Else
            sepre = txtspre.Text
        End If

        'boneka
        If txtboneka.Text = "" Then
            boneka = 0
        Else
            boneka = txtboneka.Text
        End If

        'selimut
        If txtslimut.Text = "" Then
            selimut = 0
        Else
            selimut = txtslimut.Text
        End If

        'gorden
        If txtgorden.Text = "" Then
            gorden = 0
        Else
            gorden = txtgorden.Text
        End If

        h_baju = b_baju * harga
        txttotalbju.Text = h_baju

        subtotal = h_baju + (sepre * harga) + (boneka * harga) + (selimut * harga) + (gorden * harga)
        txttotaldll.Text = subtotal
        total = subtotal - (subtotal * diskon)
        txttotalkurangdiskon.Text = total

    End Sub

    Sub varnol()
        harga = 0
        b_baju = 0
        j_baju = 0
        h_baju = 0
        sepre = 0
        boneka = 0
        selimut = 0
        gorden = 0

        subtotal = 0
        total = 0
        diskon = 0
        bayar = 0
        kembalian = 0

    End Sub
    Sub ceboknyala()
        cebokbaju.Enabled = True
        cebokboneka.Enabled = True
        cebokgorden.Enabled = True
        cebokselimut.Enabled = True
        ceboksepre.Enabled = True
    End Sub

    Private Sub formTerimaCucian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call varnol()
        Call koneksi()
        lblUser.Text = nama
        txtidkasir.Text = id_petugas
        Call setnotrans()
        txtsisanya.Enabled = False

    End Sub

    Private Sub rbkilat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbkilat.CheckedChanged
        If rbkilat.Checked Then
            Call ceboknyala()
            dtp2.Value = DateAdd("d", +3, dtp.Value)
            harga = 15000
            Call itungharga()
            paket = "Kilat"
        End If
    End Sub

    Private Sub rbreguler_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbreguler.CheckedChanged
        Call ceboknyala()
        dtp2.Value = DateAdd("d", +5, dtp.Value)
        harga = 7000
        Call itungharga()
        paket = "reguler"
    End Sub

    Private Sub cebokbaju_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cebokbaju.CheckedChanged
        If cebokbaju.Checked Then
            txtberat.Enabled = True
            txtjmlbaju.Enabled = True
            txtberat.Focus()

        Else
            txtberat.Clear()
            txtjmlbaju.Clear()
            txttotalbju.Text = 0
            txtberat.Enabled = False
            txtjmlbaju.Enabled = False


        End If
    End Sub

    Private Sub ceboksepre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ceboksepre.CheckedChanged
        If ceboksepre.Checked = True Then
            txtspre.Enabled = True
            txtspre.Clear()
            txtspre.Focus()
        Else
            txtspre.Text = 0
            txtspre.Enabled = False
        End If
    End Sub

    Private Sub cebokboneka_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cebokboneka.CheckedChanged
        If cebokboneka.Checked = True Then
            txtboneka.Enabled = True
            txtboneka.Clear()
            txtboneka.Focus()
        Else
            txtboneka.Text = 0
            txtboneka.Enabled = False
        End If
    End Sub

    Private Sub cebokselimut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cebokselimut.CheckedChanged
        If cebokselimut.Checked = True Then
            txtslimut.Enabled = True
            txtslimut.Clear()
            txtslimut.Focus()
        Else
            txtslimut.Text = 0
            txtslimut.Enabled = False
        End If
    End Sub

    Private Sub cebokgorden_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cebokgorden.CheckedChanged
        If cebokgorden.Checked = True Then
            txtgorden.Enabled = True
            txtgorden.Clear()
            txtgorden.Focus()
        Else
            txtgorden.Text = 0
            txtgorden.Enabled = False
        End If
    End Sub

    Private Sub txtberat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtberat.TextChanged
        Call itungharga()

    End Sub


    Private Sub txtspre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtspre.TextChanged
        Call itungharga()

    End Sub

    Private Sub txtboneka_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboneka.TextChanged
        Call itungharga()

    End Sub

    Private Sub txtslimut_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtslimut.TextChanged
        Call itungharga()

    End Sub

    Private Sub txtgorden_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgorden.TextChanged
        Call itungharga()

    End Sub

    Private Sub cebokmember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cebokmember.CheckedChanged

        If cebokmember.Checked Then
            txtidpelanggan.Enabled = True
            txtnamapelanggan.Enabled = False
            Call itungharga()

        Else
            txtidpelanggan.Text = ""
            txtnamapelanggan.Clear()
            txtdiskon.Text = 0
            diskon = 0
            txtidpelanggan.Enabled = False
            txtnamapelanggan.Enabled = True
            Call itungharga()
        End If
    End Sub

    Private Sub txtidpelanggan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtidpelanggan.TextChanged
        Call cari()
        Call datamember()
        Call itungharga()

    End Sub

    Private Sub txtuangmuka_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuangmuka.Click
        txtuangmuka.Text = ""
    End Sub

    Private Sub txtuangmuka_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuangmuka.TextChanged
        Call itungkembalian()
        If txtuangmuka.Text = "" Then
            txtSisa.Text = 0
        End If
    End Sub



    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        txtstruk = txtNoNota.Text
        If txtNoNota.Text = "" Or txtnamapelanggan.Text = "" Then
            MsgBox("no nota atau nama pelanggan belum dimasukkan")
            Exit Sub
        End If
        If txtSisa.Text < 0 Then
            MsgBox("Pembayaran yang dimasukkan tidak mencukupi")
            Exit Sub
        End If

        Call inputtransaksi()
        Call updatenotrans()
        Call setnotrans()

        txtNoNota.Text = ""
        txtberat.Text = ""
        txtjmlbaju.Text = ""
        txttotalbju.Text = "0"
        txtspre.Text = "0"
        txtboneka.Text = "0"
        txtslimut.Text = "0"
        txtgorden.Text = "0"
        txtidpelanggan.Text = ""
        txtnamapelanggan.Text = ""
        txtdiskon.Text = "0"
        txttotalkurangdiskon.Text = "0"
        txtuangmuka.Text = "0"
        txtketerangan.Text = ""
        txtSisa.Text = "0"
        txtsisanya.Text = ""
        txtsisanya.Enabled = False
        rbkilat.Checked = False
        rbreguler.Checked = False
        cebokbaju.Checked = False
        cebokboneka.Checked = False
        cebokgorden.Checked = False
        cebokmember.Checked = False
        cebokselimut.Checked = False
        ceboksepre.Checked = False

        formStruk.nostruk = txtstruk

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

    End Sub

    Private Sub AmbilCucianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmbilCucianToolStripMenuItem.Click
        fromAmbilCucian.Show()
        Me.Close()

    End Sub

    Private Sub lblKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKeluar.Click
        formLogin.Show()
        Me.Close()

    End Sub

    Private Sub txtSisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSisa.TextChanged

    End Sub


    Private Sub txtnamapelanggan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnamapelanggan.KeyPress
        If e.KeyChar = Chr(13) Then
            txtuangmuka.Focus()
        End If
    End Sub

    Sub cari()
        da = New OleDbDataAdapter("select * from tblMember where id_member like '%" & txtidpelanggan.Text & "%'", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tblMember")
        dgvMember.DataSource = (ds.Tables("tblMember"))

    End Sub
    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnStruk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStruk.Click

        formStruk.Show()
    End Sub
End Class
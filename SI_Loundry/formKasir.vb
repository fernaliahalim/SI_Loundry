Imports System.Data.OleDb

Public Class formKasir
    Dim nokas
    'prosedur kosongin smua texbox
    Sub kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox1.Focus()

    End Sub

    Sub setnotrans()
        cmd = New OleDbCommand("select kasir from autonumb", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        nokas = rd.Item("kasir")
        If nokas < 9 Then
            TextBox1.Text = "P00" & nokas
        ElseIf nokas < 99 Then
            TextBox1.Text = "P0" & nokas
        Else
            TextBox1.Text = "P" & nokas
        End If
    End Sub

    Sub updatenotrans()
        cmd = New OleDbCommand("update autonumb set kasir = kasir + 1", conn)
        cmd.ExecuteNonQuery()

    End Sub

    'prosedur nampilin database di DGV
    Sub tampilkan()
        da = New OleDbDataAdapter("select * from tblpetugas", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tblpetugas")
        DataGridView1.DataSource = (ds.Tables("tblpetugas"))
    End Sub
    'prosedur tambah data
    Sub tambah()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("silahkan mengisi data dengan lengkap")
            Exit Sub
        End If
        Try

            cmd = New OleDbCommand("select * from tblpetugas where id_petugas = '" & TextBox1.Text & "' and username = '" & TextBox5.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If rd.HasRows Then
            MsgBox("ID atau username sudah terpakai")
            Exit Sub
        Else
            cmd = New OleDbCommand("insert into tblpetugas(id_petugas,nama,alamat, no_hp, username, pass) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data telah ditambahkan")
            Call tampilkan()
            Call kosongkan()

        End If

    End Sub
    'prosedur hapus data
    Sub hapus()
        If TextBox1.Text = "" Then
            MsgBox("ID belum dimasukkan")
            Exit Sub
        End If
        If MsgBox("Yakin ingin menghapus data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cmd = New OleDbCommand("delete from tblpetugas where id_petugas = '" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("data behasil dihapus")
            Call tampilkan()
            Call kosongkan()
        End If
    End Sub
    'prosedur edit data
    Sub edit()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("silahkan mengisi data dengan lengkap")
            Exit Sub
        End If

        cmd = New OleDbCommand("select * from tblpetugas where id_petugas = '" & TextBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            'update nama
            cmd = New OleDbCommand("update tblpetugas set nama = '" & TextBox2.Text & "' where id_petugas = '" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            'update alamat
            cmd = New OleDbCommand("update tblpetugas set alamat = '" & TextBox3.Text & "' where id_petugas = '" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            'update no_hp
            cmd = New OleDbCommand("update tblpetugas set no_hp = '" & TextBox4.Text & "' where id_petugas = '" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            'update username
            cmd = New OleDbCommand("update tblpetugas set username = '" & TextBox5.Text & "' where id_petugas = '" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            'update pass
            cmd = New OleDbCommand("update tblpetugas set pass = '" & TextBox6.Text & "' where id_petugas = '" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dirubah")
            Call tampilkan()
            Call kosongkan()

        Else
            MsgBox("ID tidak terdaftar")
        End If


    End Sub
    'prosedur cari
    Sub cari()
        da = New OleDbDataAdapter("select * from tblpetugas where nama like '%" & TextBox7.Text & "%'", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tblpetugas")
        DataGridView1.DataSource = (ds.Tables("tblpetugas"))

    End Sub


    Private Sub formKasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampilkan()
        lblUser.Text = nama

        Call setnotrans()
        TextBox1.Enabled = False
        TextBox2.Focus()
        DateTimePicker1.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call tambah()
        Call updatenotrans()
        Call setnotrans()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call hapus()
        Call setnotrans()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox6.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call edit()
        Call setnotrans()
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Call cari()
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            TextBox5.Focus()
        End If
    End Sub

    Private Sub BeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BeToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeToolStripMenuItem.Click
        formHome.Show()
        Me.Close()
    End Sub


    Private Sub KasirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KasirToolStripMenuItem.Click
        Me.Show()
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

    Private Sub lblKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKeluar.Click
        formLogin.Show()
        Me.Close()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem.Click
        FormLaporan.Show()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox6.Focus()
        End If
    End Sub
End Class
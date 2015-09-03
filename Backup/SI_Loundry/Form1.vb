Imports System.Data.OleDb

Public Class formLogin

    Sub login()


        cmd = New OleDbCommand("select * from tblpetugas where username = '" & txtUname.Text & "' and pass ='" & txtPassword.Text & "'", conn)

        rd = cmd.ExecuteReader

        rd.Read()
        
        If rd.HasRows Then
            nama = rd.Item("nama")
            id_petugas = rd.Item("id_petugas")
            MsgBox("Selamat Datang di Aplikasi ini")
            formHome.Show()
            Me.Hide()
        Else
            MsgBox("Maaf Nama Pengguna atau Password anda Salah")
        End If

    End Sub
    Private Sub formLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load     
        Call koneksi()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Call login()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        If MsgBox("Anda yakin ingin keluar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        Else

        End If
    End Sub

    Private Sub txtUname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUname.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPassword.Focus()

        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin.Focus()
        End If
    End Sub
End Class

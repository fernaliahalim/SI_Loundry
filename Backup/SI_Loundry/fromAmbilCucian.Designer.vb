<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromAmbilCucian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fromAmbilCucian))
        Me.dgvAmbil = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblKeluar = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.BeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KonsumenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TerimaCucianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AmbilCucianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtNoNota = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtp = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtidkasir = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.txtkembalian = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.dgvTransaksi = New System.Windows.Forms.DataGridView
        Me.txtBayar = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnPilih = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNota = New System.Windows.Forms.TextBox
        Me.txtSisa = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCari = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.dgvAmbil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAmbil
        '
        Me.dgvAmbil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAmbil.Location = New System.Drawing.Point(37, 517)
        Me.dgvAmbil.Name = "dgvAmbil"
        Me.dgvAmbil.Size = New System.Drawing.Size(709, 215)
        Me.dgvAmbil.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(705, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(9, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "|"
        '
        'lblKeluar
        '
        Me.lblKeluar.AutoSize = True
        Me.lblKeluar.Location = New System.Drawing.Point(715, 148)
        Me.lblKeluar.Name = "lblKeluar"
        Me.lblKeluar.Size = New System.Drawing.Size(37, 13)
        Me.lblKeluar.TabIndex = 67
        Me.lblKeluar.Text = "Keluar"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(630, 148)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(55, 13)
        Me.lblUser.TabIndex = 66
        Me.lblUser.Text = "Username"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.BarangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 80
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BeToolStripMenuItem
        '
        Me.BeToolStripMenuItem.Name = "BeToolStripMenuItem"
        Me.BeToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.BeToolStripMenuItem.Text = "Beranda"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KasirToolStripMenuItem, Me.KonsumenToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.TransaksiToolStripMenuItem.Text = "Manajemen Data"
        '
        'KasirToolStripMenuItem
        '
        Me.KasirToolStripMenuItem.Name = "KasirToolStripMenuItem"
        Me.KasirToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.KasirToolStripMenuItem.Text = "Kasir"
        '
        'KonsumenToolStripMenuItem
        '
        Me.KonsumenToolStripMenuItem.Name = "KonsumenToolStripMenuItem"
        Me.KonsumenToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.KonsumenToolStripMenuItem.Text = "Konsumen"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TerimaCucianToolStripMenuItem, Me.AmbilCucianToolStripMenuItem})
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.BarangToolStripMenuItem.Text = "Transaksi"
        '
        'TerimaCucianToolStripMenuItem
        '
        Me.TerimaCucianToolStripMenuItem.Name = "TerimaCucianToolStripMenuItem"
        Me.TerimaCucianToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TerimaCucianToolStripMenuItem.Text = "Terima Cucian"
        '
        'AmbilCucianToolStripMenuItem
        '
        Me.AmbilCucianToolStripMenuItem.Name = "AmbilCucianToolStripMenuItem"
        Me.AmbilCucianToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AmbilCucianToolStripMenuItem.Text = "Ambil Cucian"
        '
        'txtNoNota
        '
        Me.txtNoNota.Enabled = False
        Me.txtNoNota.Location = New System.Drawing.Point(116, 28)
        Me.txtNoNota.Name = "txtNoNota"
        Me.txtNoNota.Size = New System.Drawing.Size(169, 20)
        Me.txtNoNota.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp)
        Me.GroupBox1.Controls.Add(Me.txtNoNota)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 93)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Umum"
        '
        'dtp
        '
        Me.dtp.Enabled = False
        Me.dtp.Location = New System.Drawing.Point(116, 56)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(169, 20)
        Me.dtp.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tanggal Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No. Nota Ambil"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtidkasir)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Location = New System.Drawing.Point(28, 287)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(291, 56)
        Me.GroupBox4.TabIndex = 82
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Data Kasir"
        '
        'txtidkasir
        '
        Me.txtidkasir.Enabled = False
        Me.txtidkasir.Location = New System.Drawing.Point(116, 28)
        Me.txtidkasir.Name = "txtidkasir"
        Me.txtidkasir.Size = New System.Drawing.Size(151, 20)
        Me.txtidkasir.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "ID Kasir"
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(646, 423)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(91, 47)
        Me.btnSimpan.TabIndex = 86
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'txtkembalian
        '
        Me.txtkembalian.Enabled = False
        Me.txtkembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkembalian.Location = New System.Drawing.Point(407, 460)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.Size = New System.Drawing.Size(209, 26)
        Me.txtkembalian.TabIndex = 85
        Me.txtkembalian.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(299, 460)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 20)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "Kembalian"
        '
        'dgvTransaksi
        '
        Me.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaksi.Location = New System.Drawing.Point(403, 205)
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.Size = New System.Drawing.Size(354, 158)
        Me.dgvTransaksi.TabIndex = 87
        '
        'txtBayar
        '
        Me.txtBayar.Enabled = False
        Me.txtBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar.Location = New System.Drawing.Point(408, 418)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(208, 26)
        Me.txtBayar.TabIndex = 89
        Me.txtBayar.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(299, 418)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Bayar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 466)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Sisa "
        '
        'btnPilih
        '
        Me.btnPilih.Location = New System.Drawing.Point(682, 369)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(75, 23)
        Me.btnPilih.TabIndex = 92
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 412)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "No. Nota"
        '
        'txtNota
        '
        Me.txtNota.Enabled = False
        Me.txtNota.Location = New System.Drawing.Point(132, 412)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(151, 20)
        Me.txtNota.TabIndex = 4
        '
        'txtSisa
        '
        Me.txtSisa.Enabled = False
        Me.txtSisa.Location = New System.Drawing.Point(133, 468)
        Me.txtSisa.Name = "txtSisa"
        Me.txtSisa.Size = New System.Drawing.Size(151, 20)
        Me.txtSisa.TabIndex = 94
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(132, 438)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(151, 20)
        Me.txtTotal.TabIndex = 96
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 436)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Total"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(606, 179)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(151, 20)
        Me.txtCari.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(77, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 105)
        Me.Panel1.TabIndex = 98
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(131, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(432, 42)
        Me.Label16.TabIndex = 69
        Me.Label16.Text = "Transaksi Ambil Cucian"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Location = New System.Drawing.Point(12, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 92)
        Me.Button2.TabIndex = 70
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(529, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Cari No. Nota"
        '
        'fromAmbilCucian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 742)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSisa)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvTransaksi)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtkembalian)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvAmbil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblKeluar)
        Me.Controls.Add(Me.lblUser)
        Me.Name = "fromAmbilCucian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fromAmbilCucian"
        CType(Me.dgvAmbil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAmbil As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblKeluar As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KasirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KonsumenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerimaCucianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmbilCucianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtNoNota As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtidkasir As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtkembalian As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dgvTransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents txtBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnPilih As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents txtSisa As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class

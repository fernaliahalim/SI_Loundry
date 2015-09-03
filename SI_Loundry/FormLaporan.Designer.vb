<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporan))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.BeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KonsumenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TerimaCucianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AmbilCucianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.lblKeluar = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.btnLkasir = New System.Windows.Forms.Button
        Me.btnLmember = New System.Windows.Forms.Button
        Me.btnLsimpan = New System.Windows.Forms.Button
        Me.btnLambil = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.BarangToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(561, 24)
        Me.MenuStrip1.TabIndex = 1
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
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 105)
        Me.Panel1.TabIndex = 101
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(213, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(163, 42)
        Me.Label16.TabIndex = 69
        Me.Label16.Text = "Laporan"
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
        'lblKeluar
        '
        Me.lblKeluar.AutoSize = True
        Me.lblKeluar.Location = New System.Drawing.Point(507, 148)
        Me.lblKeluar.Name = "lblKeluar"
        Me.lblKeluar.Size = New System.Drawing.Size(37, 13)
        Me.lblKeluar.TabIndex = 104
        Me.lblKeluar.Text = "Keluar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(497, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(9, 13)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "|"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(428, 148)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(55, 13)
        Me.lblUser.TabIndex = 102
        Me.lblUser.Text = "Username"
        '
        'btnLkasir
        '
        Me.btnLkasir.Location = New System.Drawing.Point(41, 188)
        Me.btnLkasir.Name = "btnLkasir"
        Me.btnLkasir.Size = New System.Drawing.Size(132, 49)
        Me.btnLkasir.TabIndex = 105
        Me.btnLkasir.Text = "Laporan Kasir"
        Me.btnLkasir.UseVisualStyleBackColor = True
        '
        'btnLmember
        '
        Me.btnLmember.Location = New System.Drawing.Point(41, 252)
        Me.btnLmember.Name = "btnLmember"
        Me.btnLmember.Size = New System.Drawing.Size(132, 49)
        Me.btnLmember.TabIndex = 106
        Me.btnLmember.Text = "Laporan Member"
        Me.btnLmember.UseVisualStyleBackColor = True
        '
        'btnLsimpan
        '
        Me.btnLsimpan.Location = New System.Drawing.Point(208, 188)
        Me.btnLsimpan.Name = "btnLsimpan"
        Me.btnLsimpan.Size = New System.Drawing.Size(132, 49)
        Me.btnLsimpan.TabIndex = 107
        Me.btnLsimpan.Text = "Laporan Transaksi Simpan Loundry"
        Me.btnLsimpan.UseVisualStyleBackColor = True
        '
        'btnLambil
        '
        Me.btnLambil.Location = New System.Drawing.Point(208, 252)
        Me.btnLambil.Name = "btnLambil"
        Me.btnLambil.Size = New System.Drawing.Size(132, 49)
        Me.btnLambil.TabIndex = 108
        Me.btnLambil.Text = "Laporan Transaksi Ambil Loundry"
        Me.btnLambil.UseVisualStyleBackColor = True
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(561, 345)
        Me.Controls.Add(Me.btnLambil)
        Me.Controls.Add(Me.btnLsimpan)
        Me.Controls.Add(Me.btnLmember)
        Me.Controls.Add(Me.btnLkasir)
        Me.Controls.Add(Me.lblKeluar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KasirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KonsumenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerimaCucianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmbilCucianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblKeluar As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents btnLkasir As System.Windows.Forms.Button
    Friend WithEvents btnLmember As System.Windows.Forms.Button
    Friend WithEvents btnLsimpan As System.Windows.Forms.Button
    Friend WithEvents btnLambil As System.Windows.Forms.Button
End Class

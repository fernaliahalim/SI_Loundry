<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formHome))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.BeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KonsumenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TerimaCucianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AmbilCucianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnKonsumen = New System.Windows.Forms.Button
        Me.btnKasir = New System.Windows.Forms.Button
        Me.btnTerimaCucian = New System.Windows.Forms.Button
        Me.btnAmbilCucian = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblUser = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblKeluar = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.BarangToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(556, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'btnKonsumen
        '
        Me.btnKonsumen.Location = New System.Drawing.Point(100, 37)
        Me.btnKonsumen.Name = "btnKonsumen"
        Me.btnKonsumen.Size = New System.Drawing.Size(75, 45)
        Me.btnKonsumen.TabIndex = 1
        Me.btnKonsumen.Text = "Member"
        Me.btnKonsumen.UseVisualStyleBackColor = True
        '
        'btnKasir
        '
        Me.btnKasir.Location = New System.Drawing.Point(16, 37)
        Me.btnKasir.Name = "btnKasir"
        Me.btnKasir.Size = New System.Drawing.Size(75, 45)
        Me.btnKasir.TabIndex = 2
        Me.btnKasir.Text = "Kasir"
        Me.btnKasir.UseVisualStyleBackColor = True
        '
        'btnTerimaCucian
        '
        Me.btnTerimaCucian.Location = New System.Drawing.Point(20, 37)
        Me.btnTerimaCucian.Name = "btnTerimaCucian"
        Me.btnTerimaCucian.Size = New System.Drawing.Size(75, 45)
        Me.btnTerimaCucian.TabIndex = 3
        Me.btnTerimaCucian.Text = "Terima Cucian"
        Me.btnTerimaCucian.UseVisualStyleBackColor = True
        '
        'btnAmbilCucian
        '
        Me.btnAmbilCucian.Location = New System.Drawing.Point(103, 37)
        Me.btnAmbilCucian.Name = "btnAmbilCucian"
        Me.btnAmbilCucian.Size = New System.Drawing.Size(75, 45)
        Me.btnAmbilCucian.TabIndex = 4
        Me.btnAmbilCucian.Text = "Ambil Cucian"
        Me.btnAmbilCucian.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnKasir)
        Me.GroupBox1.Controls.Add(Me.btnKonsumen)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 98)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manajemen Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnTerimaCucian)
        Me.GroupBox2.Controls.Add(Me.btnAmbilCucian)
        Me.GroupBox2.Location = New System.Drawing.Point(321, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 98)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(424, 141)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(55, 13)
        Me.lblUser.TabIndex = 9
        Me.lblUser.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(493, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(9, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "|"
        '
        'lblKeluar
        '
        Me.lblKeluar.AutoSize = True
        Me.lblKeluar.Location = New System.Drawing.Point(503, 141)
        Me.lblKeluar.Name = "lblKeluar"
        Me.lblKeluar.Size = New System.Drawing.Size(37, 13)
        Me.lblKeluar.TabIndex = 11
        Me.lblKeluar.Text = "Keluar"
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
        Me.Panel1.TabIndex = 99
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(218, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(167, 42)
        Me.Label16.TabIndex = 69
        Me.Label16.Text = "Beranda"
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
        'formHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(556, 353)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblKeluar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formHome"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KasirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerimaCucianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmbilCucianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnKonsumen As System.Windows.Forms.Button
    Friend WithEvents btnKasir As System.Windows.Forms.Button
    Friend WithEvents btnTerimaCucian As System.Windows.Forms.Button
    Friend WithEvents btnAmbilCucian As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblKeluar As System.Windows.Forms.Label
    Friend WithEvents KonsumenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

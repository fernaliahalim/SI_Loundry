<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLmember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLmember))
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.btnLmember = New System.Windows.Forms.Button
        Me.lblKeluar = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KonsumenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AmbilCucianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TerimaCucianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnTampil = New System.Windows.Forms.Button
        Me.txtKeyword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbFilter = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(165, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(316, 42)
        Me.Label16.TabIndex = 69
        Me.Label16.Text = "Laporan Member"
        '
        'btnLmember
        '
        Me.btnLmember.Location = New System.Drawing.Point(61, 224)
        Me.btnLmember.Name = "btnLmember"
        Me.btnLmember.Size = New System.Drawing.Size(132, 100)
        Me.btnLmember.TabIndex = 115
        Me.btnLmember.Text = "Laporan Detail Member"
        Me.btnLmember.UseVisualStyleBackColor = True
        '
        'lblKeluar
        '
        Me.lblKeluar.AutoSize = True
        Me.lblKeluar.Location = New System.Drawing.Point(506, 146)
        Me.lblKeluar.Name = "lblKeluar"
        Me.lblKeluar.Size = New System.Drawing.Size(37, 13)
        Me.lblKeluar.TabIndex = 113
        Me.lblKeluar.Text = "Keluar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(496, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(9, 13)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "|"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(427, 146)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(55, 13)
        Me.lblUser.TabIndex = 111
        Me.lblUser.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(11, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 105)
        Me.Panel1.TabIndex = 110
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
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'BeToolStripMenuItem
        '
        Me.BeToolStripMenuItem.Name = "BeToolStripMenuItem"
        Me.BeToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.BeToolStripMenuItem.Text = "Beranda"
        '
        'AmbilCucianToolStripMenuItem
        '
        Me.AmbilCucianToolStripMenuItem.Name = "AmbilCucianToolStripMenuItem"
        Me.AmbilCucianToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AmbilCucianToolStripMenuItem.Text = "Ambil Cucian"
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.BarangToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(555, 24)
        Me.MenuStrip1.TabIndex = 109
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTampil)
        Me.GroupBox1.Controls.Add(Me.txtKeyword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbFilter)
        Me.GroupBox1.Location = New System.Drawing.Point(249, 224)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 116)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Laporan"
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(203, 82)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(75, 23)
        Me.btnTampil.TabIndex = 3
        Me.btnTampil.Text = "Tampilkan"
        Me.btnTampil.UseVisualStyleBackColor = True
        '
        'txtKeyword
        '
        Me.txtKeyword.Location = New System.Drawing.Point(77, 56)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(201, 20)
        Me.txtKeyword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Keyword"
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"Nama", "Alamat"})
        Me.cmbFilter.Location = New System.Drawing.Point(157, 19)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 21)
        Me.cmbFilter.TabIndex = 0
        '
        'FormLmember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(555, 379)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLmember)
        Me.Controls.Add(Me.lblKeluar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormLmember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLmember"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnLmember As System.Windows.Forms.Button
    Friend WithEvents lblKeluar As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KasirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KonsumenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmbilCucianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerimaCucianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents txtKeyword As System.Windows.Forms.TextBox
    Friend WithEvents btnTampil As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanMember
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
        Me.reportMember = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'reportMember
        '
        Me.reportMember.ActiveViewIndex = -1
        Me.reportMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reportMember.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportMember.Location = New System.Drawing.Point(0, 0)
        Me.reportMember.Name = "reportMember"
        Me.reportMember.SelectionFormula = ""
        Me.reportMember.Size = New System.Drawing.Size(755, 461)
        Me.reportMember.TabIndex = 0
        Me.reportMember.ViewTimeSelectionFormula = ""
        '
        'FormLaporanMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 461)
        Me.Controls.Add(Me.reportMember)
        Me.Name = "FormLaporanMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporanMember"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reportMember As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

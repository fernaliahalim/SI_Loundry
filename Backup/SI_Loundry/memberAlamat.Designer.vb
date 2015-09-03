<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class memberAlamat
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
        Me.reportAlamat = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'reportAlamat
        '
        Me.reportAlamat.ActiveViewIndex = -1
        Me.reportAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reportAlamat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportAlamat.Location = New System.Drawing.Point(0, 0)
        Me.reportAlamat.Name = "reportAlamat"
        Me.reportAlamat.SelectionFormula = ""
        Me.reportAlamat.Size = New System.Drawing.Size(916, 363)
        Me.reportAlamat.TabIndex = 0
        Me.reportAlamat.ViewTimeSelectionFormula = ""
        '
        'memberAlamat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 363)
        Me.Controls.Add(Me.reportAlamat)
        Me.Name = "memberAlamat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "memberAlamat"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reportAlamat As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

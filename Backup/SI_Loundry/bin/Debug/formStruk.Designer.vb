<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStruk
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
        Me.cvStruk = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'cvStruk
        '
        Me.cvStruk.ActiveViewIndex = -1
        Me.cvStruk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cvStruk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cvStruk.Location = New System.Drawing.Point(0, 0)
        Me.cvStruk.Name = "cvStruk"
        Me.cvStruk.SelectionFormula = ""
        Me.cvStruk.Size = New System.Drawing.Size(598, 369)
        Me.cvStruk.TabIndex = 0
        Me.cvStruk.ViewTimeSelectionFormula = ""
        '
        'formStruk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 369)
        Me.Controls.Add(Me.cvStruk)
        Me.Name = "formStruk"
        Me.Text = "formStruk"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cvStruk As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

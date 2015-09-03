<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLKasir
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
        Me.cvKasir = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'cvKasir
        '
        Me.cvKasir.ActiveViewIndex = -1
        Me.cvKasir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cvKasir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cvKasir.Location = New System.Drawing.Point(0, 0)
        Me.cvKasir.Name = "cvKasir"
        Me.cvKasir.SelectionFormula = ""
        Me.cvKasir.Size = New System.Drawing.Size(873, 427)
        Me.cvKasir.TabIndex = 0
        Me.cvKasir.ViewTimeSelectionFormula = ""
        '
        'formLKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 427)
        Me.Controls.Add(Me.cvKasir)
        Me.Name = "formLKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formLKasir"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cvKasir As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

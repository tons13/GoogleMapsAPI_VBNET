<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGoogleMaps
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
        Me.WbBrowser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'WbBrowser
        '
        Me.WbBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WbBrowser.Location = New System.Drawing.Point(0, 0)
        Me.WbBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WbBrowser.Name = "WbBrowser"
        Me.WbBrowser.Size = New System.Drawing.Size(496, 444)
        Me.WbBrowser.TabIndex = 0
        '
        'frmGoogleMaps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 444)
        Me.Controls.Add(Me.WbBrowser)
        Me.Name = "frmGoogleMaps"
        Me.Text = "Google Maps"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WbBrowser As System.Windows.Forms.WebBrowser
End Class

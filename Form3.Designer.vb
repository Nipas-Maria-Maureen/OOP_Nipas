<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.StudentInfo = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.student1 = New OOP_Nipas.student()
        Me.SuspendLayout()
        '
        'StudentInfo
        '
        Me.StudentInfo.ActiveViewIndex = -1
        Me.StudentInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.StudentInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StudentInfo.Location = New System.Drawing.Point(0, 0)
        Me.StudentInfo.Name = "StudentInfo"
        Me.StudentInfo.Size = New System.Drawing.Size(800, 450)
        Me.StudentInfo.TabIndex = 0
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StudentInfo)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentInfo As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents student1 As student
End Class

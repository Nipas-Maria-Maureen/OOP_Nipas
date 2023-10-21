<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.cbocourse = New System.Windows.Forms.ComboBox()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.btnback = New System.Windows.Forms.Button()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbocourse
        '
        Me.cbocourse.FormattingEnabled = True
        Me.cbocourse.Location = New System.Drawing.Point(89, 69)
        Me.cbocourse.Name = "cbocourse"
        Me.cbocourse.Size = New System.Drawing.Size(200, 21)
        Me.cbocourse.TabIndex = 0
        '
        'btndisplay
        '
        Me.btndisplay.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btndisplay.Location = New System.Drawing.Point(324, 59)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(138, 39)
        Me.btndisplay.TabIndex = 1
        Me.btndisplay.Text = "Display"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'dgvdata
        '
        Me.dgvdata.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Location = New System.Drawing.Point(69, 146)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.Size = New System.Drawing.Size(654, 309)
        Me.dgvdata.TabIndex = 2
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnback.Location = New System.Drawing.Point(585, 502)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(138, 41)
        Me.btnback.TabIndex = 3
        Me.btnback.Text = "Home"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.dgvdata)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.cbocourse)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbocourse As ComboBox
    Friend WithEvents btndisplay As Button
    Friend WithEvents dgvdata As DataGridView
    Friend WithEvents btnback As Button
End Class

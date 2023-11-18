<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim GroupBox1 As System.Windows.Forms.GroupBox
        Dim GroupBox2 As System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtcourse = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtstudcourse = New System.Windows.Forms.TextBox()
        Me.txtlast = New System.Windows.Forms.TextBox()
        Me.txtfirst = New System.Windows.Forms.TextBox()
        Me.btnDesign = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        GroupBox1 = New System.Windows.Forms.GroupBox()
        GroupBox2 = New System.Windows.Forms.GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        GroupBox1.Controls.Add(Me.Label3)
        GroupBox1.Controls.Add(Me.Label2)
        GroupBox1.Controls.Add(Me.Label1)
        GroupBox1.Controls.Add(Me.btnInsert)
        GroupBox1.Controls.Add(Me.txtcourse)
        GroupBox1.Controls.Add(Me.txtlname)
        GroupBox1.Controls.Add(Me.txtfname)
        GroupBox1.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        GroupBox1.Location = New System.Drawing.Point(87, 87)
        GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        GroupBox1.Size = New System.Drawing.Size(441, 456)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Save Record"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(91, 178)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Course:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(91, 130)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lastname:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(91, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Firstname:"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(213, 230)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(171, 30)
        Me.btnInsert.TabIndex = 3
        Me.btnInsert.Text = "INSERT RECORD"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtcourse
        '
        Me.txtcourse.Location = New System.Drawing.Point(223, 178)
        Me.txtcourse.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.Size = New System.Drawing.Size(148, 27)
        Me.txtcourse.TabIndex = 2
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(223, 127)
        Me.txtlname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(148, 27)
        Me.txtlname.TabIndex = 1
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(223, 76)
        Me.txtfname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(148, 27)
        Me.txtfname.TabIndex = 0
        '
        'GroupBox2
        '
        GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        GroupBox2.Controls.Add(Me.btnupdate)
        GroupBox2.Controls.Add(Me.btndelete)
        GroupBox2.Controls.Add(Me.txtuserid)
        GroupBox2.Controls.Add(Me.Label7)
        GroupBox2.Controls.Add(Me.Label4)
        GroupBox2.Controls.Add(Me.Label5)
        GroupBox2.Controls.Add(Me.Label6)
        GroupBox2.Controls.Add(Me.btnsearch)
        GroupBox2.Controls.Add(Me.txtstudcourse)
        GroupBox2.Controls.Add(Me.txtlast)
        GroupBox2.Controls.Add(Me.txtfirst)
        GroupBox2.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        GroupBox2.Location = New System.Drawing.Point(569, 87)
        GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        GroupBox2.Size = New System.Drawing.Size(441, 456)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Save Record"
        AddHandler GroupBox2.Enter, AddressOf Me.GroupBox2_Enter
        '
        'txtuserid
        '
        Me.txtuserid.Location = New System.Drawing.Point(223, 41)
        Me.txtuserid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(148, 27)
        Me.txtuserid.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(91, 40)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Student ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(91, 178)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Course:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(91, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Lastname:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(91, 76)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Firstname:"
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(213, 230)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(171, 30)
        Me.btnsearch.TabIndex = 3
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtstudcourse
        '
        Me.txtstudcourse.Enabled = False
        Me.txtstudcourse.Location = New System.Drawing.Point(223, 178)
        Me.txtstudcourse.Margin = New System.Windows.Forms.Padding(4)
        Me.txtstudcourse.Name = "txtstudcourse"
        Me.txtstudcourse.Size = New System.Drawing.Size(148, 27)
        Me.txtstudcourse.TabIndex = 2
        '
        'txtlast
        '
        Me.txtlast.Enabled = False
        Me.txtlast.Location = New System.Drawing.Point(223, 127)
        Me.txtlast.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlast.Name = "txtlast"
        Me.txtlast.Size = New System.Drawing.Size(148, 27)
        Me.txtlast.TabIndex = 1
        '
        'txtfirst
        '
        Me.txtfirst.Enabled = False
        Me.txtfirst.Location = New System.Drawing.Point(223, 76)
        Me.txtfirst.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfirst.Name = "txtfirst"
        Me.txtfirst.Size = New System.Drawing.Size(148, 27)
        Me.txtfirst.TabIndex = 0
        '
        'btnDesign
        '
        Me.btnDesign.AutoEllipsis = True
        Me.btnDesign.Location = New System.Drawing.Point(467, 576)
        Me.btnDesign.Name = "btnDesign"
        Me.btnDesign.Size = New System.Drawing.Size(193, 43)
        Me.btnDesign.TabIndex = 2
        Me.btnDesign.Text = "Display by Course"
        Me.btnDesign.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(80, 359)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(86, 41)
        Me.btnupdate.TabIndex = 3
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(250, 359)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(109, 41)
        Me.btndelete.TabIndex = 4
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1157, 642)
        Me.Controls.Add(Me.btnDesign)
        Me.Controls.Add(GroupBox2)
        Me.Controls.Add(GroupBox1)
        Me.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "b"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtcourse As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtuserid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtstudcourse As TextBox
    Friend WithEvents txtlast As TextBox
    Friend WithEvents txtfirst As TextBox
    Friend WithEvents btnDesign As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
End Class

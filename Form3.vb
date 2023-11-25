Public Class Form3
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles StudentInfo.Load
        StudentInfo.ReportSource = student1
        StudentInfo.Refresh()
    End Sub
End Class
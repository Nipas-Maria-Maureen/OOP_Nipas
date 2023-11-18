Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDbase()
        txtfirst.Enabled = False
        txtlast.Enabled = False
        txtstudcourse.Enabled = False
        btnUpdate.Enabled = False
        btndelete.Enabled = False
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        SaveRecord()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        SearchData()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDesign_Click(sender As Object, e As EventArgs) Handles btnDesign.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim ans As DialogResult = MessageBox.Show("Do you want to save changes?",
                   "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            UpdateRecord(txtuserid.Text, txtfirst.Text, txtlast.Text, txtcourse.Text)

            MsgBox("Update successfull!")
        Else
            MsgBox("Update cancelled!")
            
        End If

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim ans As DialogResult = MessageBox.Show("Do you want to delete record?",
                 "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            Delete(txtuserid.Text)

            MsgBox("Delete successfull!")
        Else
            MsgBox("Delete cancelled!")

        End If
    End Sub
End Class

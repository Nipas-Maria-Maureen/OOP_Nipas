Imports System.Runtime.Versioning
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient

Module Module1
    Dim con As New MySqlConnection
    Dim Reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String
    Dim dtTable As New DataTable
    Dim adapter As New MySqlDataAdapter

    Public Sub ConnectDbase()
        host = "127.0.0.1"
        dbname = "it2boop"
        uname = "root"
        pwd = "password"
        'check the connection is open
        If Not con Is Nothing Then
            con.Close() ' close dbconnection
            'connection string signature
            con.ConnectionString = "server =" & host & "; user id=" & uname & ";password=" & pwd & ";database=" & dbname & ""

            Try
                'open the connection
                con.Open()
                MessageBox.Show("Connected!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub
    Public Sub SaveRecord()
        sqlquery = "INSERT INTO student(studFname,studLname,course)
         VALUES (@fname,@lname,@course)"
        Dim fname, lname, course As String
        fname = Form1.txtfname.Text 'get the value from form1 textboxes
        lname = Form1.txtlname.Text
        course = Form1.txtcourse.Text
        'pass the query and connection to mysqlcommand
        mysqlcmd = New MySqlCommand(sqlquery, con)
        'add the parameter value
        mysqlcmd.Parameters.AddWithValue("fname", fname)
        mysqlcmd.Parameters.AddWithValue("lname", lname)
        mysqlcmd.Parameters.AddWithValue("course", course)

        Try
            'execute the sql query command
            mysqlcmd.ExecuteNonQuery()
            MsgBox("Record Save Successfully!")
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        Finally
            TextClear()
        End Try
    End Sub

    Public Sub TextClear()
        Form1.txtfname.Clear()
        Form1.txtlname.Clear()
        Form1.txtcourse.Clear()
    End Sub

    Public Sub SearchData()
        Dim uid As String
        uid = Form1.txtuserid.text
        sqlquery = "SELECT * FROM student where studID = @uid"
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd.Parameters.AddWithValue("@uid", uid)

        Try
            Reader = mysqlcmd.ExecuteReader()
            If Reader.Read Then
                Form1.txtfirst.text = Reader("studfname").ToString()
                Form1.txtlast.text = Reader("studlname").ToString()
                Form1.txtstudcourse.Text = Reader("course").ToString()
                Form1.btndelete.Enabled = True
                Form1.btnupdate.Enabled = True
                Form1.txtfirst.Enabled = True
                Form1.txtlast.Enabled = True
                Form1.txtstudcourse.Enabled = True

            Else
                MsgBox("No Record!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
        End Try
    End Sub
    Public Sub LoadAllData()
        sqlquery = "SELECT * FROM student"
        Try

            adapter = New MySqlDataAdapter(sqlquery, con)
            'display the record in your datagridview
            dtTable = New DataTable
            adapter.Fill(dtTable) 'pass the record from mysql to data table
            With Form2.dgvdata
                .DataSource = dtTable 'set the source of datagridview
                .AutoResizeColumns()


            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try




    End Sub
    Public Sub LoadCourse()
        sqlquery = "select course from student"
        Try
            mysqlcmd = New MySqlCommand(sqlquery, con)
            Reader = mysqlcmd.ExecuteReader
            While Reader.Read
                Form2.cbocourse.Items.Add(Reader("course").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Public Sub DisplayData()
        sqlquery = "SELECT * FROM student"
        Try

            adapter = New MySqlDataAdapter(sqlquery, con)
            'display the record in your datagridview
            dtTable = New DataTable
            adapter.Fill(dtTable) 'pass the record from mysql to data table
            With Form2.dgvdata
                .DataSource = dtTable 'set the source of datagridview
                .AutoResizeColumns()


            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try




    End Sub
    Public Sub DisplayData(kurso As String)
        sqlquery = "SELECT * FROM student where course =  @kurso"
        adapter = New MySqlDataAdapter(sqlquery, con)
        adapter.SelectCommand.Parameters.AddWithValue("@kurso", kurso)

        Try
            mysqlcmd = New MySqlCommand(sqlquery, con)
            Reader = mysqlcmd.ExecuteReader
            While Reader.Read
                Form2.cbocourse.Items.Add(Reader("course").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Public Sub UpdateRecord(studID As String, fname As String,
                            lname As String, course As String)
        sqlquery = "UPDATE studenbt set studFname = @fname,
        studLname = @lname, course, = @course 
        where studID = @studId"

        Try
            Using cmd As New MySqlCommand(sqlquery, con)
                cmd.Parameters.AddWithValue("@fname", fname)
                cmd.Parameters.AddWithValue("@lname", lname)
                cmd.Parameters.AddWithValue("@couse", course)
                cmd.Parameters.AddWithValue("@studID", studID)

            End Using
            MsgBox("UPDATE SUCCESSFULL!", vbInformation, "UPDATE MESSAGE")


        Catch ex As Exception
            MsgBox("Error:" & ex.Message, vbInformation, "Error Message")
        Finally
            Form1.txtfirst.Clear()
            Form1.txtlast.Clear()
            Form1.txtstudcourse.Clear()
            Form1.txtuserid.Clear()
        End Try
    End Sub
    Public Sub Delete(studID As String)
        sqlquery = "DELETE from student where studID = @studId"

        Try
            Using cmd As New MySqlCommand(sqlquery, con)
                cmd.Parameters.AddWithValue("@studID", studID)
                cmd.ExecuteNonQuery()

            End Using
            MsgBox("DELETE SUCCESSFULL!", vbInformation, "DELETE MESSAGE")
        Catch ex As Exception
            MsgBox("Error:" & ex.Message, vbInformation, "Error Message")
        Finally
            Form1.txtfirst.Clear()
            Form1.txtlast.Clear()
            Form1.txtstudcourse.Clear()
            Form1.txtuserid.Clear()
        End Try


    End Sub


End Module

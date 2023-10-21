﻿Imports System.Runtime.Versioning
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient

Module Module1
    Dim con As New MySqlConnection
    Dim Reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String

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
            Else
                MsgBox("No Record!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
        End Try
    End Sub
End Module

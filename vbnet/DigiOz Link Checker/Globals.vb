Imports System
Imports System.IO
Imports System.Data
Imports System.Data.OleDb

Module Globals
    ' ******************* Global Variable Declaration **********************
    Dim strConnect As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sites.mdb;"

    ' Global Database Connectivity Variables for Functions -----------------

    Dim myConnection As OleDbConnection
    Dim myOleCommand As OleDbCommand
    Dim myDataReader As OleDbDataReader

    Dim cn As ADODB.Connection              ' Add reference to ActiveX 2.7 Data Object
    Dim rs As ADODB.Recordset

    ' ************ Function to Execute SQL Command (no return OLEDB) *************

    Public Function commandToDB(ByVal DBCommand As String)

        ' strConnect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strPathToDB & ";"
        myConnection = New OleDbConnection(strConnect)
        myOleCommand = New OleDbCommand(DBCommand, myConnection)
        Try
            myConnection.Open()
            myOleCommand.ExecuteNonQuery()
        Catch myException As Exception
            MsgBox("Couldn't insert record: " + myException.ToString())
        Finally
            myConnection.Close()
            myConnection = Nothing
        End Try

    End Function

    ' ************ Function to Query Database (with return ADODB) ****************

    Public Function queryToDB(ByVal DBQuery As String)

        cn = New ADODB.Connection
        cn.Open(strConnect)

        rs = cn.Execute(DBQuery)
        Return rs
        cn.Close()
        cn = Nothing

    End Function

    ' ************ Function to Command Database (no return ADODB) ****************

    Public Function comToDB(ByVal DBCom As String)

        cn = New ADODB.Connection
        cn.Open(strConnect)

        cn.Execute(DBCom)
        cn.Close()
        cn = Nothing

    End Function

    ' ****************************** Read from Text File Function *****************************

    Public Function GetFileContents(ByVal FullPath As String, _
           Optional ByRef ErrInfo As String = "") As String

        Dim strContents As String
        Dim objReader As StreamReader
        Try

            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
            Return strContents
        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try
    End Function

    ' *************************** Write to Text File Function ********************************

    Public Function SaveTextToFile(ByVal strData As String, _
     ByVal FullPath As String, _
       Optional ByVal ErrInfo As String = "") As Boolean

        Dim Contents As String
        Dim bAns As Boolean = False
        Dim objReader As StreamWriter
        Try


            objReader = New StreamWriter(FullPath)
            objReader.Write(strData)
            objReader.Close()
            bAns = True
        Catch Ex As Exception
            ErrInfo = Ex.Message

        End Try
        Return bAns
    End Function

    ' ****************** Append to Text File Function ***********************

    Function AppendTextToFile(ByVal strData As String, ByVal path As String, Optional ByVal ErrInfo As String = "")
        Dim sw As StreamWriter

        ' Create the file if it does not exist
        If File.Exists(path) = False Then
            sw = File.CreateText(path)
            sw.Flush()
            sw.Close()
        End If

        Try
            sw = File.AppendText(path)          ' Open the file for append
            sw.Write(strData)
            'sw.WriteLine("Write text line by line")
        Catch Ex As Exception
            ErrInfo = Ex.Message
        Finally
            sw.Flush()
            sw.Close()
        End Try

        ' Optional Stream Reader for returning contents of the file
        'Dim sr As StreamReader = File.OpenText(path)
        'Dim s As String
        'Do While sr.Peek() >= 0
        's = sr.ReadLine()
        'txtOut.Text &= (s)
        'Loop
        'sr.Close()
    End Function

End Module

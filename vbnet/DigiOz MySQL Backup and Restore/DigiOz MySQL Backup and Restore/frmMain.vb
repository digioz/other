Imports System
Imports System.Data
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmMain
    Dim conn As MySqlConnection
    Dim data As DataTable
    Dim da As MySqlDataAdapter
    Dim cb As MySqlCommandBuilder
    Dim pathMySQL As String
    Dim pathExport As String

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFile.Text = Application.StartupPath.ToString() & "\backup.sql"

    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        If Not conn Is Nothing Then conn.Close()

        Dim connStr As String
        connStr = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", txtHost.Text, txtUsername.Text, txtPassword.Text, txtDatabase.Text)

        Try
            conn = New MySqlConnection(connStr)
            conn.Open()

            GetDatabases()
        Catch ex As MySqlException
            MessageBox.Show("Error connecting to the server: " + ex.Message)
        End Try
    End Sub

    Private Sub GetDatabases()
        Dim reader As MySqlDataReader
        reader = Nothing

        Dim cmd As New MySqlCommand("SHOW DATABASES", conn)
        Try
            reader = cmd.ExecuteReader()
            cmbSelectedDatabase.Items.Clear()

            While (reader.Read())
                cmbSelectedDatabase.Items.Add(reader.GetString(0))
            End While
        Catch ex As MySqlException
            MessageBox.Show("Failed to populate database list: " + ex.Message)
        Finally
            If Not reader Is Nothing Then reader.Close()
        End Try

        cmbSelectedDatabase.SelectedItem = txtDatabase.Text
        GetTables()

    End Sub

    Private Sub GetTables()
        Dim reader As MySqlDataReader

        conn.ChangeDatabase(cmbSelectedDatabase.SelectedItem.ToString())

        Dim cmd As New MySqlCommand("SHOW TABLES", conn)

        Try
            reader = cmd.ExecuteReader()
            lstSelectedTables.Items.Clear()

            While (reader.Read())
                lstSelectedTables.Items.Add(reader.GetString(0))
            End While

        Catch ex As MySqlException
            MessageBox.Show("Failed to populate table list: " + ex.Message)
        Finally
            If Not reader Is Nothing Then reader.Close()
        End Try
    End Sub

    Private Sub cmbSelectedDatabase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSelectedDatabase.SelectedIndexChanged
        GetTables()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuMySQLPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMySQLPath.Click
        fb.ShowDialog()
        pathMySQL = fb.SelectedPath
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        fb.ShowDialog()
        txtFile.Text = fb.SelectedPath & "\backup.sql"
        pathExport = fb.SelectedPath
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        Dim myProcess As New Process()
        Dim strCommand As String

        Me.TextBox1.Clear()

        myProcess.StartInfo.FileName = "cmd"
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.UseShellExecute = False
        myProcess.Start()

        myProcess.StandardInput.WriteLine("cd c:\")

        If pathMySQL <> "" Then
            myProcess.StandardInput.WriteLine("cd " & pathMySQL)
        End If

        strCommand = "mysqldump -h" & txtHost.Text & " -u" & txtUsername.Text & " -p" & txtPassword.Text & " " & cmbSelectedDatabase.SelectedItem & " > " & Chr(34) & txtFile.Text & Chr(34)

        myProcess.StandardInput.WriteLine(strCommand)

        myProcess.StandardInput.Close()
        Me.TextBox1.Text = myProcess.StandardOutput.ReadToEnd()
        myProcess.WaitForExit()
        MessageBox.Show("Done!")

    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        Dim myProcess As New Process()
        Dim strCommand As String

        Me.TextBox1.Clear()

        myProcess.StartInfo.FileName = "cmd"
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.UseShellExecute = False
        myProcess.Start()

        myProcess.StandardInput.WriteLine("cd c:\")

        If pathMySQL <> "" Then
            myProcess.StandardInput.WriteLine("cd " & pathMySQL)
        End If

        strCommand = "mysql -h" & txtHost.Text & " -u" & txtUsername.Text & " -p" & txtPassword.Text & " " & cmbSelectedDatabase.SelectedItem & " < " & Chr(34) & txtFile.Text & Chr(34)

        myProcess.StandardInput.WriteLine(strCommand)

        myProcess.StandardInput.Close()
        Me.TextBox1.Text = myProcess.StandardOutput.ReadToEnd()
        myProcess.WaitForExit()
        MessageBox.Show("Done!")
    End Sub
End Class



' ---------------------------------- '
'Dim p As New Process
'p.StartInfo.UseShellExecute = False
'p.StartInfo.RedirectStandardOutput = True
'p.StartInfo.Arguments = vbNewLine & "dir" & vbNewLine
'p.StartInfo.WorkingDirectory = "C:\"
'p.StartInfo.FileName = "cmd.exe"

'p.Start()

'Dim sr As IO.StreamReader = p.StandardOutput
'Dim sb As New System.Text.StringBuilder("")
'Dim input As Integer = sr.Read
'Do Until input = -1
'    sb.Append(ChrW(input))
'    input = sr.Read
'Loop
'Me.TextBox1.Text = sb.ToString


'Dim myProcessStartInfo As New ProcessStartInfo("cmd.exe")
'myProcessStartInfo.UseShellExecute = False
'myProcessStartInfo.RedirectStandardOutput = True
'myProcess.StartInfo = myProcessStartInfo
'myProcess.Start()

'Dim myStreamReader As IO.StreamReader = myProcess.StandardOutput
'' Read the standard output of the spawned process.
'Dim myString As String = myStreamReader.ReadToEnd()
'myProcess.WaitForExit()
'Console.WriteLine(myString)
'myProcess.Close()
'Me.TextBox1.Text = myString

' ---------------------------------- '

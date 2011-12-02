Imports System                                  ' For Webpage download
Imports System.Web
Imports System.Xml.Serialization
Imports System.Net
Imports System.IO

Imports System.Text                             ' For MD5 Hash
Imports System.Security.Cryptography

Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtOut As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnGetWebpage As System.Windows.Forms.Button
    Friend WithEvents btnStripTags As System.Windows.Forms.Button
    Friend WithEvents btnMD5Hash As System.Windows.Forms.Button
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents btnAddToDatabase As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lstDB As System.Windows.Forms.ListBox
    Friend WithEvents lstChanged As System.Windows.Forms.ListBox
    Friend WithEvents btnCheckForUpdateDB As System.Windows.Forms.Button
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.txtOut = New System.Windows.Forms.TextBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnGetWebpage = New System.Windows.Forms.Button
        Me.btnStripTags = New System.Windows.Forms.Button
        Me.btnMD5Hash = New System.Windows.Forms.Button
        Me.txtURL = New System.Windows.Forms.TextBox
        Me.btnAddToDatabase = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.lstDB = New System.Windows.Forms.ListBox
        Me.lstChanged = New System.Windows.Forms.ListBox
        Me.btnCheckForUpdateDB = New System.Windows.Forms.Button
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtOut
        '
        Me.txtOut.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtOut.Location = New System.Drawing.Point(24, 16)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOut.Size = New System.Drawing.Size(776, 216)
        Me.txtOut.TabIndex = 0
        Me.txtOut.Text = ""
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Silver
        Me.btnExit.Location = New System.Drawing.Point(56, 616)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        '
        'btnGetWebpage
        '
        Me.btnGetWebpage.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnGetWebpage.ForeColor = System.Drawing.Color.Black
        Me.btnGetWebpage.Location = New System.Drawing.Point(624, 552)
        Me.btnGetWebpage.Name = "btnGetWebpage"
        Me.btnGetWebpage.Size = New System.Drawing.Size(176, 23)
        Me.btnGetWebpage.TabIndex = 2
        Me.btnGetWebpage.Text = "Get Webpage Content"
        '
        'btnStripTags
        '
        Me.btnStripTags.BackColor = System.Drawing.Color.Silver
        Me.btnStripTags.Location = New System.Drawing.Point(344, 616)
        Me.btnStripTags.Name = "btnStripTags"
        Me.btnStripTags.Size = New System.Drawing.Size(128, 23)
        Me.btnStripTags.TabIndex = 3
        Me.btnStripTags.Text = "Strip Tags"
        '
        'btnMD5Hash
        '
        Me.btnMD5Hash.BackColor = System.Drawing.Color.Silver
        Me.btnMD5Hash.Location = New System.Drawing.Point(200, 616)
        Me.btnMD5Hash.Name = "btnMD5Hash"
        Me.btnMD5Hash.Size = New System.Drawing.Size(128, 23)
        Me.btnMD5Hash.TabIndex = 4
        Me.btnMD5Hash.Text = "MD5 Hash"
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(56, 552)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(560, 20)
        Me.txtURL.TabIndex = 5
        Me.txtURL.Text = ""
        '
        'btnAddToDatabase
        '
        Me.btnAddToDatabase.BackColor = System.Drawing.Color.IndianRed
        Me.btnAddToDatabase.ForeColor = System.Drawing.Color.Black
        Me.btnAddToDatabase.Location = New System.Drawing.Point(624, 584)
        Me.btnAddToDatabase.Name = "btnAddToDatabase"
        Me.btnAddToDatabase.Size = New System.Drawing.Size(176, 23)
        Me.btnAddToDatabase.TabIndex = 6
        Me.btnAddToDatabase.Text = "Add To Database"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 552)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "URL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 584)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(56, 584)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(560, 20)
        Me.txtName.TabIndex = 9
        Me.txtName.Text = ""
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(24, 520)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(776, 23)
        Me.ProgressBar1.TabIndex = 10
        '
        'lstDB
        '
        Me.lstDB.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lstDB.Location = New System.Drawing.Point(24, 248)
        Me.lstDB.Name = "lstDB"
        Me.lstDB.Size = New System.Drawing.Size(368, 225)
        Me.lstDB.TabIndex = 11
        '
        'lstChanged
        '
        Me.lstChanged.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lstChanged.Location = New System.Drawing.Point(416, 248)
        Me.lstChanged.Name = "lstChanged"
        Me.lstChanged.Size = New System.Drawing.Size(384, 225)
        Me.lstChanged.TabIndex = 12
        '
        'btnCheckForUpdateDB
        '
        Me.btnCheckForUpdateDB.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnCheckForUpdateDB.ForeColor = System.Drawing.Color.Black
        Me.btnCheckForUpdateDB.Location = New System.Drawing.Point(624, 616)
        Me.btnCheckForUpdateDB.Name = "btnCheckForUpdateDB"
        Me.btnCheckForUpdateDB.Size = New System.Drawing.Size(176, 23)
        Me.btnCheckForUpdateDB.TabIndex = 13
        Me.btnCheckForUpdateDB.Text = "Check Sites In DB For Change"
        '
        'StatusBar1
        '
        Me.StatusBar1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.StatusBar1.Font = New System.Drawing.Font("MS Mincho", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 655)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusBar1.Size = New System.Drawing.Size(824, 22)
        Me.StatusBar1.SizingGrip = False
        Me.StatusBar1.TabIndex = 14
        Me.StatusBar1.Text = "  Welcome to DigiOz Link Update Checker!"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(317, 484)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(416, 484)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.TabIndex = 16
        Me.btnExport.Text = "Export"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Silver
        Me.btnClear.Location = New System.Drawing.Point(488, 616)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(128, 23)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.ClientSize = New System.Drawing.Size(824, 677)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.btnCheckForUpdateDB)
        Me.Controls.Add(Me.lstChanged)
        Me.Controls.Add(Me.lstDB)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddToDatabase)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.btnMD5Hash)
        Me.Controls.Add(Me.btnStripTags)
        Me.Controls.Add(Me.btnGetWebpage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtOut)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DigiOz Link Update Checker"
        Me.ResumeLayout(False)

    End Sub

#End Region
    ' Function for loading list of sites in the database --------------------------------------

    Public Function dbSitesLoad()
        Dim rsSitesDB As New ADODB.Recordset
        lstDB.Items.Clear()

        Try
            rsSitesDB = queryToDB("Select * FROM tblsites")
            While Not rsSitesDB.EOF
                lstDB.Items.Add(Replace(rsSitesDB.Fields("sites_name").Value.ToString(), "&#39;", "'"))
                rsSitesDB.MoveNext()
            End While
        Catch ex As Exception
            MessageBox.Show("Could Not Load the Lis of Existing Sites In the Database!")
        End Try
    End Function

    ' Function to grab web page content remotely and output it as a screen --------------------

    Public Function GetWebPageResult(ByVal webPG As String) As String
        Dim myHttpWebRequest As HttpWebRequest = CType(WebRequest.Create(webPG), HttpWebRequest)

        Dim myHttpWebResponse As HttpWebResponse = CType(myHttpWebRequest.GetResponse(), HttpWebResponse)

        Dim receiveStream As Stream = myHttpWebResponse.GetResponseStream()

        Dim encode As System.Text.Encoding = System.Text.Encoding.GetEncoding("utf-8")

        Dim readStream As New StreamReader(receiveStream, encode)
        GetWebPageResult = readStream.ReadToEnd() ' Use this 'readStream' where ever you want.

    End Function

    ' Function to Strip the HTML tags ---------------------------------------------------------

    Public Function StripTags(ByVal HTML As String) As String
        ' Removes tags from passed HTML
        Dim objRegEx As _
            System.Text.RegularExpressions.Regex
        Return objRegEx.Replace(HTML, "<[^>]*>", "")
    End Function

    Private Function GenerateHash(ByVal SourceText As String) As String
        'Create an encoding object to ensure the encoding standard for the source text
        Dim Ue As New UnicodeEncoding
        'Retrieve a byte array based on the source text
        Dim ByteSourceText() As Byte = Ue.GetBytes(SourceText)
        'Instantiate an MD5 Provider object
        Dim Md5 As New MD5CryptoServiceProvider
        'Compute the hash value from the source
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
        'And convert it to String format for return
        Return Convert.ToBase64String(ByteHash)
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGetWebpage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetWebpage.Click
        Dim tmpSTR As String
        tmpSTR = ""
        txtOut.Text = ""
        Try
            txtOut.Text = GetWebPageResult(txtURL.Text)
        Catch ex As Exception
            MessageBox.Show("Could Note Obtain Web Page Code!")
        End Try
    End Sub

    Private Sub btnStripTags_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStripTags.Click
        Dim tmpSTR As String

        tmpSTR = txtOut.Text
        txtOut.Text = ""
        tmpSTR = StripTags(tmpSTR)
        txtOut.Text = tmpSTR
    End Sub

    Private Sub btnMD5Hash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMD5Hash.Click
        txtOut.Text = GenerateHash(txtOut.Text)
    End Sub

    Private Sub btnAddToDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToDatabase.Click
        Dim strContent As String
        Dim strName As String = txtName.Text
        Dim strURL As String = txtURL.Text
        Dim strHash As String

        ProgressBar1.Value = 0

        If strName = "" Or strURL = "" Then
            MessageBox.Show("Invalid Site Name or URL!")
            Exit Sub
        End If

        strName = Replace(strName, "'", "&#39;")

        Try
            strContent = GetWebPageResult(txtURL.Text)
            strHash = GenerateHash(strContent)

            comToDB("INSERT INTO tblsites ([sites_name],[sites_url],[sites_hash]) Values ('" & strName & "','" & strURL & "','" & strHash & "')")
            MessageBox.Show("Site " & strName & " was successfully added to database!")
        Catch ex As Exception
            MessageBox.Show("Could Not Connect to Remote Site!" & vbCrLf & "Site was not Added to list!")
        End Try

        dbSitesLoad()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dbSitesLoad()
        Catch ex As Exception
            MessageBox.Show("Could Note Load List of Existing Sites from Database!")
        End Try
    End Sub

    Private Sub btnCheckForUpdateDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckForUpdateDB.Click
        Dim rsSitesDB As New ADODB.Recordset
        Dim tmpID As String
        Dim tmpName As String
        Dim tmpURL As String
        Dim tmpHash As String

        txtOut.Text = ""
        lstChanged.Items.Clear()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

        Try
            rsSitesDB = queryToDB("Select * FROM tblsites")
            While Not rsSitesDB.EOF
                ProgressBar1.Value += 5
                If ProgressBar1.Value = 100 Then
                    ProgressBar1.Value = 0
                End If

                tmpID = rsSitesDB.Fields("sites_id").Value.ToString()
                tmpURL = rsSitesDB.Fields("sites_url").Value.ToString()
                tmpName = rsSitesDB.Fields("sites_name").Value.ToString()

                tmpHash = GenerateHash(GetWebPageResult(tmpURL))

                If tmpHash <> rsSitesDB.Fields("sites_hash").Value.ToString() Then
                    txtOut.Text &= "Site " & Replace(tmpName, "&#39;", "'") & " has changed!" & vbCrLf
                    comToDB("Update tblSites SET [sites_hash]='" & tmpHash & "' WHERE [sites_id]=" & tmpID & "")
                    lstChanged.Items.Add(Replace(tmpName, "&#39;", "'"))
                End If
                rsSitesDB.MoveNext()
                Me.Refresh()
            End While
        Catch ex As Exception
            txtOut.Text &= "Could Not Check for Update for the site " & rsSitesDB.Fields("sites_name").Value.ToString() & vbCrLf
        End Try

        txtOut.Text &= "Site change check was completed successfully!" & vbCrLf
        ProgressBar1.Value = 100
    End Sub


    Private Sub txtURL_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtURL.Validating
        If txtURL.Text = "" Then
            MessageBox.Show("Please Enter a Valid URL")
            e.Cancel = True
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtOut.Text = ""
        lstChanged.Items.Clear()
        ProgressBar1.Value = 0
        txtURL.Text = ""
        txtName.Text = ""
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim j As Integer
        Dim strName As String
        j = lstDB.SelectedIndex

        If j >= 0 Then
            strName = Replace(lstDB.Items(j), "'", "&#39;")
            Try
                comToDB("DELETE * FROM tblSites WHERE [sites_name]='" & strName & "'")
                dbSitesLoad()
            Catch ex As Exception
                MessageBox.Show("Could Not Remove Selected Site From Database!")
            End Try
        End If
    End Sub
End Class

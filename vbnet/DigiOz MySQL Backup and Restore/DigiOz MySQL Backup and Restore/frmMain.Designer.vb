<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpConnection = New System.Windows.Forms.GroupBox
        Me.btnConnect = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.txtDatabase = New System.Windows.Forms.TextBox
        Me.txtHost = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpDatabases = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lstSelectedTables = New System.Windows.Forms.ListBox
        Me.cmbSelectedDatabase = New System.Windows.Forms.ComboBox
        Me.grpImportExportFile = New System.Windows.Forms.GroupBox
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnRestore = New System.Windows.Forms.Button
        Me.btnBackup = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMySQLPath = New System.Windows.Forms.ToolStripMenuItem
        Me.fb = New System.Windows.Forms.FolderBrowserDialog
        Me.grpConnection.SuspendLayout()
        Me.grpDatabases.SuspendLayout()
        Me.grpImportExportFile.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpConnection
        '
        Me.grpConnection.Controls.Add(Me.btnConnect)
        Me.grpConnection.Controls.Add(Me.txtPassword)
        Me.grpConnection.Controls.Add(Me.txtUsername)
        Me.grpConnection.Controls.Add(Me.txtDatabase)
        Me.grpConnection.Controls.Add(Me.txtHost)
        Me.grpConnection.Controls.Add(Me.Label4)
        Me.grpConnection.Controls.Add(Me.Label3)
        Me.grpConnection.Controls.Add(Me.Label2)
        Me.grpConnection.Controls.Add(Me.Label1)
        Me.grpConnection.Location = New System.Drawing.Point(23, 33)
        Me.grpConnection.Name = "grpConnection"
        Me.grpConnection.Size = New System.Drawing.Size(293, 168)
        Me.grpConnection.TabIndex = 0
        Me.grpConnection.TabStop = False
        Me.grpConnection.Text = "Database Connection"
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(92, 129)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(185, 25)
        Me.btnConnect.TabIndex = 8
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(92, 103)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(186, 20)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.Text = "myroot"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(92, 76)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(186, 20)
        Me.txtUsername.TabIndex = 6
        Me.txtUsername.Text = "root"
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(92, 49)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(186, 20)
        Me.txtDatabase.TabIndex = 5
        Me.txtDatabase.Text = "pedram1"
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(92, 22)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(186, 20)
        Me.txtHost.TabIndex = 4
        Me.txtHost.Text = "localhost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Host"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database"
        '
        'grpDatabases
        '
        Me.grpDatabases.Controls.Add(Me.Label6)
        Me.grpDatabases.Controls.Add(Me.Label5)
        Me.grpDatabases.Controls.Add(Me.lstSelectedTables)
        Me.grpDatabases.Controls.Add(Me.cmbSelectedDatabase)
        Me.grpDatabases.Location = New System.Drawing.Point(322, 33)
        Me.grpDatabases.Name = "grpDatabases"
        Me.grpDatabases.Size = New System.Drawing.Size(313, 168)
        Me.grpDatabases.TabIndex = 1
        Me.grpDatabases.TabStop = False
        Me.grpDatabases.Text = "Database Selection"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tables"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Database"
        '
        'lstSelectedTables
        '
        Me.lstSelectedTables.FormattingEnabled = True
        Me.lstSelectedTables.Location = New System.Drawing.Point(75, 67)
        Me.lstSelectedTables.Name = "lstSelectedTables"
        Me.lstSelectedTables.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSelectedTables.Size = New System.Drawing.Size(221, 82)
        Me.lstSelectedTables.TabIndex = 1
        '
        'cmbSelectedDatabase
        '
        Me.cmbSelectedDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectedDatabase.FormattingEnabled = True
        Me.cmbSelectedDatabase.Location = New System.Drawing.Point(74, 29)
        Me.cmbSelectedDatabase.Name = "cmbSelectedDatabase"
        Me.cmbSelectedDatabase.Size = New System.Drawing.Size(222, 21)
        Me.cmbSelectedDatabase.TabIndex = 0
        '
        'grpImportExportFile
        '
        Me.grpImportExportFile.Controls.Add(Me.btnBrowse)
        Me.grpImportExportFile.Controls.Add(Me.txtFile)
        Me.grpImportExportFile.Location = New System.Drawing.Point(24, 214)
        Me.grpImportExportFile.Name = "grpImportExportFile"
        Me.grpImportExportFile.Size = New System.Drawing.Size(611, 69)
        Me.grpImportExportFile.TabIndex = 2
        Me.grpImportExportFile.TabStop = False
        Me.grpImportExportFile.Text = "Import / Export File"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(505, 25)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(89, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'txtFile
        '
        Me.txtFile.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFile.Location = New System.Drawing.Point(12, 28)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(487, 20)
        Me.txtFile.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(24, 300)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(611, 219)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Please Connect To Database!"
        '
        'btnRestore
        '
        Me.btnRestore.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnRestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.Location = New System.Drawing.Point(310, 533)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(75, 23)
        Me.btnRestore.TabIndex = 4
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = False
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Location = New System.Drawing.Point(225, 533)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(75, 23)
        Me.btnBackup.TabIndex = 5
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuSettings})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(660, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(103, 22)
        Me.mnuExit.Text = "&Exit"
        '
        'mnuSettings
        '
        Me.mnuSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMySQLPath})
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(58, 20)
        Me.mnuSettings.Text = "&Settings"
        '
        'mnuMySQLPath
        '
        Me.mnuMySQLPath.Name = "mnuMySQLPath"
        Me.mnuMySQLPath.Size = New System.Drawing.Size(143, 22)
        Me.mnuMySQLPath.Text = "MySQL Path"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 568)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.grpImportExportFile)
        Me.Controls.Add(Me.grpDatabases)
        Me.Controls.Add(Me.grpConnection)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DigiOz MySQL Backup and Restore"
        Me.grpConnection.ResumeLayout(False)
        Me.grpConnection.PerformLayout()
        Me.grpDatabases.ResumeLayout(False)
        Me.grpDatabases.PerformLayout()
        Me.grpImportExportFile.ResumeLayout(False)
        Me.grpImportExportFile.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpConnection As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents grpDatabases As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstSelectedTables As System.Windows.Forms.ListBox
    Friend WithEvents cmbSelectedDatabase As System.Windows.Forms.ComboBox
    Friend WithEvents grpImportExportFile As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMySQLPath As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fb As System.Windows.Forms.FolderBrowserDialog

End Class

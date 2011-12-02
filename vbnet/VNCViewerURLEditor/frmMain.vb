Imports Microsoft
Imports Microsoft.Win32
Imports Microsoft.Win32.Registry

' ===== Create a new key under HKEY_LOCAL_MACHINE\Software as DigiOz ====== 
' =========================================================================
' Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software", True)
' =========================== Add one more sub key ========================
' Dim newkey As RegistryKey = key.CreateSubKey("DigiOz")
' =========================== Set value of sub key ========================
' newkey.SetValue("DigiOz", "NET Developer")
' =========================== Delete the key value ======================== 
'Dim delKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software", True)
'delKey.DeleteSubKey("DigiOz")
' =========================================================================

' ===== Create a new key under HKEY_LOCAL_MACHINE\Software as MCBInc ====== 
' Dim key As RegistryKey = Registry.LocalMachine.OpenSubKey("Software", True)
' ========================== Add one more sub key =========================
' Dim newkey As RegistryKey = key.CreateSubKey("MCBInc")
' ========================== Set value of sub key =========================
' newkey.SetValue("MCBInc", "NET Developer")
' ================ Retrieve data from other part of the registry ==========
' ========================== find out your processor ====================== 
' Dim pRegKey As RegistryKey = Registry.LocalMachine
' pRegKey = pRegKey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0")
' Dim val As Object = pRegKey.GetValue("VendorIdentifier")
' Console.WriteLine("The central processor of this machine is:" + val)
' ========================== Delete the key value =========================
' Dim delKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software", True)
' delKey.DeleteSubKey("MCBInc")
' =========================================================================


' ====== Retrieving a single property value from the registry =============
' =========================================================================
' ===================== Define and Select Registry section ================
' Dim pRegKey As RegistryKey = Registry.CurrentUser
' ===================== Browse to registry location =======================
' pRegKey = pRegKey.OpenSubKey("Software\\RealVNC\\VNCViewer4\\MRU")
' ============= Create Object to hold the value of a property =============
' Dim val As Object = pRegKey.GetValue("02")
' MessageBox.Show("The URL Value of this entry is:" + val)
' =========================================================================

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstURL As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstURL = New System.Windows.Forms.CheckedListBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VNC Viewer URL Editor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstURL
        '
        Me.lstURL.Location = New System.Drawing.Point(40, 64)
        Me.lstURL.Name = "lstURL"
        Me.lstURL.Size = New System.Drawing.Size(328, 289)
        Me.lstURL.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(119, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(215, 376)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        '
        'lblCopyright
        '
        Me.lblCopyright.ForeColor = System.Drawing.Color.Blue
        Me.lblCopyright.Location = New System.Drawing.Point(128, 424)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(152, 24)
        Me.lblCopyright.TabIndex = 4
        Me.lblCopyright.Text = "Copyright Digioz Multimedia  www.digioz.com"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 461)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstURL)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VNC Viewer URL Editor"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        Dim pRegKey As RegistryKey = Registry.CurrentUser
        pRegKey = pRegKey.OpenSubKey("Software\\RealVNC\\VNCViewer4\\MRU")
        Dim valName As Object = pRegKey.GetValueNames() ' .GetValue()
        Dim valValue As Object
        Dim valCount As Integer = pRegKey.ValueCount
        Dim i As Integer = 0
        Dim tmpName As String
        Dim tmpRemoveName As String

        ' MessageBox.Show("Value Count: " & valCount)

        For i = 0 To valCount - 1
            tmpName = valName(i).ToString()

            If tmpName <> "Order" And tmpName <> "" Then
                valValue = pRegKey.GetValue(tmpName)
                If lstURL.SelectedItem = valValue Then
                    tmpRemoveName = tmpName
                End If
            End If
            ' MessageBox.Show(valValue)
        Next

        Dim delKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\\RealVNC\\VNCViewer4\\MRU", True)
        delKey.DeleteValue(tmpRemoveName, True)

        Dim j As Integer
        j = lstURL.SelectedIndex

        lstURL.Items.Remove(lstURL.SelectedItem)

        Me.lstURL.Refresh()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim pRegKey As RegistryKey = Registry.CurrentUser
        pRegKey = pRegKey.OpenSubKey("Software\\RealVNC\\VNCViewer4\\MRU")
        Dim valName As Object = pRegKey.GetValueNames() ' .GetValue()
        Dim valValue As Object
        Dim valCount As Integer = pRegKey.ValueCount
        Dim i As Integer = 0
        Dim tmpName As String

        ' MessageBox.Show("Value Count: " & valCount)

        For i = 0 To valCount - 1
            tmpName = valName(i).ToString()

            If tmpName <> "Order" And tmpName <> "" Then
                valValue = pRegKey.GetValue(tmpName)
                lstURL.Items.Add(valValue)
            End If
            ' MessageBox.Show(valValue)
        Next

    End Sub
End Class

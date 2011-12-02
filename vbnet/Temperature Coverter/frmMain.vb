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
    Friend WithEvents lstType As System.Windows.Forms.ComboBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents txtTemp As System.Windows.Forms.TextBox
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblOut1 As System.Windows.Forms.Label
    Friend WithEvents lblOut2 As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDisplaySettings As System.Windows.Forms.MenuItem
    Friend WithEvents mnuShowEquation As System.Windows.Forms.MenuItem
    Friend WithEvents mnuShowText As System.Windows.Forms.MenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.lstType = New System.Windows.Forms.ComboBox
        Me.lblType = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnConvert = New System.Windows.Forms.Button
        Me.txtTemp = New System.Windows.Forms.TextBox
        Me.lblTemp = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.lblOut1 = New System.Windows.Forms.Label
        Me.lblOut2 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuExit = New System.Windows.Forms.MenuItem
        Me.mnuDisplaySettings = New System.Windows.Forms.MenuItem
        Me.mnuShowEquation = New System.Windows.Forms.MenuItem
        Me.mnuShowText = New System.Windows.Forms.MenuItem
        Me.mnuClear = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'lstType
        '
        Me.lstType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstType.Items.AddRange(New Object() {"Fahrenheit to Celsius", "Celsius to Fahrenheit", "Fahrenheit to Kelvin", "Kelvin to Fahrenheit", "Celsius to Kelvin", "Kelvin to Celsius"})
        Me.lstType.Location = New System.Drawing.Point(192, 40)
        Me.lstType.Name = "lstType"
        Me.lstType.Size = New System.Drawing.Size(208, 21)
        Me.lstType.TabIndex = 0
        '
        'lblType
        '
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(16, 40)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(176, 23)
        Me.lblType.TabIndex = 1
        Me.lblType.Text = "Please Select Coversion Type"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(16, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(192, 272)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.TabIndex = 3
        Me.btnConvert.Text = "Convert"
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(192, 96)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(208, 20)
        Me.txtTemp.TabIndex = 4
        Me.txtTemp.Text = ""
        '
        'lblTemp
        '
        Me.lblTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp.Location = New System.Drawing.Point(16, 96)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(168, 23)
        Me.lblTemp.TabIndex = 5
        Me.lblTemp.Text = "Enter Temperature Here"
        Me.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(104, 272)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        '
        'lblOut1
        '
        Me.lblOut1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.lblOut1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOut1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOut1.Location = New System.Drawing.Point(24, 136)
        Me.lblOut1.Name = "lblOut1"
        Me.lblOut1.Size = New System.Drawing.Size(376, 48)
        Me.lblOut1.TabIndex = 7
        Me.lblOut1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOut2
        '
        Me.lblOut2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.lblOut2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOut2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOut2.Location = New System.Drawing.Point(24, 200)
        Me.lblOut2.Name = "lblOut2"
        Me.lblOut2.Size = New System.Drawing.Size(376, 48)
        Me.lblOut2.TabIndex = 8
        Me.lblOut2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuDisplaySettings, Me.mnuClear})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuExit})
        Me.mnuFile.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 0
        Me.mnuExit.Text = "Exit"
        '
        'mnuDisplaySettings
        '
        Me.mnuDisplaySettings.Index = 1
        Me.mnuDisplaySettings.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowEquation, Me.mnuShowText})
        Me.mnuDisplaySettings.Text = "Display Settings"
        '
        'mnuShowEquation
        '
        Me.mnuShowEquation.Checked = True
        Me.mnuShowEquation.Index = 0
        Me.mnuShowEquation.Text = "Show Equation"
        '
        'mnuShowText
        '
        Me.mnuShowText.Checked = True
        Me.mnuShowText.Index = 1
        Me.mnuShowText.Text = "Show Value and Text"
        '
        'mnuClear
        '
        Me.mnuClear.Index = 2
        Me.mnuClear.Text = "Clear"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 309)
        Me.Controls.Add(Me.lblOut2)
        Me.Controls.Add(Me.lblOut1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lstType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temperature Converter Application - By DigiOz.com"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Sub clrForm()
        txtTemp.Text = ""
        lblOut1.Text = ""
        lblOut2.Text = ""
        lstType.SelectedIndex = -1
        lstType.Focus()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clrForm()
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Dim j = lstType.SelectedIndex
        Dim Temp As Double
        Dim Temp2 As String

        If mnuShowText.Checked Then
            Temp2 = "The desired temperature converted is: "
        Else
            Temp2 = ""
        End If

        If j = 0 Then
            lblOut1.Text = "Equation Used: C = 5/9 * (F - 32)"
            Temp = 5 / 9 * (CDec(txtTemp.Text) - 32)
            lblOut2.Text = Temp2 & FormatNumber(Temp, 2) & " C"
        ElseIf j = 1 Then
            lblOut1.Text = "Equation Used: F = (C * 1.8) + 32"
            Temp = (CDec(txtTemp.Text) * 1.8) + 32
            lblOut2.Text = Temp2 & FormatNumber(Temp, 2) & " F"
        ElseIf j = 2 Then
            lblOut1.Text = "Equation Used: K = ((F-32) * 0.5555) + 273.15"
            Temp = ((CDec(txtTemp.Text) - 32) * 0.5555) + 273.15
            lblOut2.Text = Temp2 & FormatNumber(Temp, 2) & " K"
        ElseIf j = 3 Then
            lblOut1.Text = "Equation Used: F = ((K-273.15) * 1.8) + 32"
            Temp = ((CDec(txtTemp.Text) - 273.15) * 1.8) + 32
            lblOut2.Text = Temp2 & FormatNumber(Temp, 2) & " F"
        ElseIf j = 4 Then
            lblOut1.Text = "Equation Used: K = C + 273.15"
            Temp = CDec(txtTemp.Text) + 273.15
            lblOut2.Text = Temp2 & FormatNumber(Temp, 2) & " K"
        ElseIf j = 5 Then
            lblOut1.Text = "Equation Used: C = K - 273.15"
            Temp = CDec(txtTemp.Text) - 273.15
            lblOut2.Text = Temp2 & FormatNumber(Temp, 2) & " C"
        ElseIf j = -1 Then
            MessageBox.Show("Please select a conversion type and try again!", "Select Conversion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuShowEquation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowEquation.Click
        mnuShowEquation.Checked = Not mnuShowEquation.Checked
        lblOut1.Visible = Not lblOut1.Visible
    End Sub

    Private Sub mnuShowText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowText.Click
        mnuShowText.Checked = Not mnuShowText.Checked
    End Sub

    Private Sub txtTemp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTemp.Validating
        If Not IsNumeric(txtTemp.Text) Then
            MessageBox.Show("Invalid Temperature. Please enter a valid numeric value and try again", "Invalid Temperature", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuClear.Click
        clrForm()
    End Sub
End Class

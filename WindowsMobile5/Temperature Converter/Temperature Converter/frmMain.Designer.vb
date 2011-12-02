<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
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
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.txtFromUnit = New System.Windows.Forms.TextBox
        Me.txtOutput = New System.Windows.Forms.TextBox
        Me.mnuExit = New System.Windows.Forms.MenuItem
        Me.btnConvert = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.mnuExit)
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.AliceBlue
        Me.cmbType.Items.Add("Fahrenheit to Celsius")
        Me.cmbType.Items.Add("Celsius to Fahrenheit")
        Me.cmbType.Items.Add("Fahrenheit to Kelvin")
        Me.cmbType.Items.Add("Kelvin to Fahrenheit")
        Me.cmbType.Items.Add("Celsius to Kelvin")
        Me.cmbType.Items.Add("Kelvin to Celsius")
        Me.cmbType.Location = New System.Drawing.Point(25, 25)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(197, 22)
        Me.cmbType.TabIndex = 0
        '
        'txtFromUnit
        '
        Me.txtFromUnit.BackColor = System.Drawing.Color.AliceBlue
        Me.txtFromUnit.Location = New System.Drawing.Point(25, 63)
        Me.txtFromUnit.Name = "txtFromUnit"
        Me.txtFromUnit.Size = New System.Drawing.Size(197, 21)
        Me.txtFromUnit.TabIndex = 1
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOutput.Location = New System.Drawing.Point(25, 101)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(197, 88)
        Me.txtOutput.TabIndex = 2
        '
        'mnuExit
        '
        Me.mnuExit.Text = "Exit"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(25, 207)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(197, 20)
        Me.btnConvert.TabIndex = 3
        Me.btnConvert.Text = "Convert"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtFromUnit)
        Me.Controls.Add(Me.cmbType)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmMain"
        Me.Text = "DigiOz Temperature Converter"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtFromUnit As System.Windows.Forms.TextBox
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button

End Class

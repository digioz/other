VERSION 5.00
Begin VB.MDIForm frmMDI 
   BackColor       =   &H8000000C&
   Caption         =   "CRM Application"
   ClientHeight    =   5430
   ClientLeft      =   60
   ClientTop       =   630
   ClientWidth     =   7395
   LinkTopic       =   "MDIForm1"
   StartUpPosition =   2  'CenterScreen
   WindowState     =   2  'Maximized
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      Begin VB.Menu mnuNewAddressBookEntry 
         Caption         =   "New &Address Book Entry"
      End
      Begin VB.Menu mnuNewDepreciationCalculation 
         Caption         =   "New &Depreciation Calculation"
      End
      Begin VB.Menu mnuClose 
         Caption         =   "&Close"
      End
      Begin VB.Menu mnudivider1 
         Caption         =   "-"
      End
      Begin VB.Menu mnuExit 
         Caption         =   "E&xit"
      End
   End
   Begin VB.Menu mnuWindow 
      Caption         =   "&Window"
   End
End
Attribute VB_Name = "frmMDI"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub MDIForm_Load()
    Dim a As New frmMain                        ' Declare the form object
    a.Top = (Screen.Height - a.Height) / 2      ' Code to center the form on the MDI
    a.Left = (Screen.Width - a.Width) / 2
    a.Show                                      ' Display form object
End Sub

Private Sub mnuClose_Click()                    ' This Sub closes any open child forms
On Error GoTo ExitSub
        Unload ActiveForm
ExitSub:
        Exit Sub
End Sub

Private Sub mnuExit_Click()                     ' Sub to exit the application
    End
End Sub

Private Sub mnuNewAddressBookEntry_Click()
    Dim a As New frmMain                        ' Declare the form object
    a.Top = (Screen.Height - a.Height) / 2      ' Code to center the form on the MDI
    a.Left = (Screen.Width - a.Width) / 2
    a.Show
End Sub

Private Sub mnuNewDepreciationCalculation_Click()
    Dim a As New frmDepreciation                        ' Declare the form object
    a.Top = (Screen.Height - a.Height) / 2      ' Code to center the form on the MDI
    a.Left = (Screen.Width - a.Width) / 2
    a.Show                                      ' Display form object
End Sub

Private Sub mnuNewInvestmentCalculation_Click()

End Sub

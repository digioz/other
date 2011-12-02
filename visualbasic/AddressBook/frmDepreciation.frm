VERSION 5.00
Object = "{C932BA88-4374-101B-A56C-00AA003668DC}#1.1#0"; "MSMASK32.OCX"
Begin VB.Form frmDepreciation 
   BackColor       =   &H00E0E0E0&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Calculate Depreciation"
   ClientHeight    =   4110
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6180
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   4110
   ScaleWidth      =   6180
   Begin MSMask.MaskEdBox mskInitialCost 
      Height          =   255
      Left            =   2640
      TabIndex        =   0
      Top             =   240
      Width           =   3135
      _ExtentX        =   5530
      _ExtentY        =   450
      _Version        =   393216
      Format          =   "$#,##0.00;($#,##0.00)"
      PromptChar      =   "_"
   End
   Begin MSMask.MaskEdBox mskFinalValue 
      Height          =   255
      Left            =   2640
      TabIndex        =   1
      Top             =   720
      Width           =   3135
      _ExtentX        =   5530
      _ExtentY        =   450
      _Version        =   393216
      Format          =   "$#,##0.00;($#,##0.00)"
      PromptChar      =   "_"
   End
   Begin VB.CommandButton cmdExit 
      Caption         =   "Exit"
      Height          =   495
      Left            =   4560
      TabIndex        =   6
      Top             =   3480
      Width           =   1215
   End
   Begin VB.CommandButton cmdCalculate 
      Caption         =   "Calculate"
      Height          =   495
      Left            =   3120
      TabIndex        =   4
      Top             =   3480
      Width           =   1215
   End
   Begin VB.ListBox lstDepreciation 
      Height          =   1425
      Left            =   360
      TabIndex        =   3
      Top             =   1800
      Width           =   5415
   End
   Begin VB.ComboBox cboLife 
      Height          =   315
      Left            =   2640
      TabIndex        =   2
      Top             =   1200
      Width           =   3135
   End
   Begin VB.Label Label4 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Life of Asset in Years"
      Height          =   255
      Left            =   840
      TabIndex        =   8
      Top             =   1200
      Width           =   1695
   End
   Begin VB.Label Label3 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Final Value of Asset"
      Height          =   255
      Left            =   840
      TabIndex        =   7
      Top             =   720
      Width           =   1695
   End
   Begin VB.Label Label2 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Initial Cost of Asset"
      Height          =   255
      Left            =   960
      TabIndex        =   5
      Top             =   240
      Width           =   1575
   End
End
Attribute VB_Name = "frmDepreciation"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdCalculate_Click()
    Dim i As Integer
    lstDepreciation.Clear
    For i = 1 To cboLife
        lstDepreciation.AddItem ("Year " & i & ":    " _
        & FormatCurrency(SYD(mskInitialCost, mskFinalValue, cboLife, i)))
    Next i
End Sub

Private Sub cmdExit_Click()
    Unload Me
End Sub

Private Sub Form_Load()
    ' Fills the Combo Box with Values for asset in years
    Dim i As Integer
    For i = 1 To 40
        cboLife.AddItem (i)
    Next i
End Sub

Private Sub mskInitialCost_Validate(Cancel As Boolean)
    If Val(mskInitialCost) <= 0 Then
        MsgBox ("You Must Enter a Positive Number!")
        Cancel = True
    End If
End Sub

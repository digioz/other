VERSION 5.00
Begin VB.Form frmMain 
   BackColor       =   &H00E0E0E0&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Main "
   ClientHeight    =   4995
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6930
   LinkTopic       =   "frmMain"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   4995
   ScaleWidth      =   6930
   Begin VB.CommandButton cmdDep 
      Caption         =   "Dep"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3720
      TabIndex        =   13
      Top             =   4320
      Width           =   615
   End
   Begin VB.CommandButton cmdClear 
      BackColor       =   &H0080C0FF&
      Caption         =   "Clear"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5160
      MaskColor       =   &H0080C0FF&
      TabIndex        =   12
      Top             =   4320
      Width           =   615
   End
   Begin VB.CommandButton cmdAdd 
      BackColor       =   &H0080C0FF&
      Caption         =   "Add"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5880
      MaskColor       =   &H0080C0FF&
      TabIndex        =   6
      Top             =   4320
      Width           =   615
   End
   Begin VB.CommandButton cmdExit 
      BackColor       =   &H0080C0FF&
      Caption         =   "Exit"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4440
      MaskColor       =   &H0080C0FF&
      TabIndex        =   5
      Top             =   4320
      Width           =   615
   End
   Begin VB.TextBox txtCountry 
      Height          =   375
      Left            =   1920
      TabIndex        =   4
      Top             =   3120
      Width           =   4695
   End
   Begin VB.TextBox txtCityStateZip 
      Height          =   375
      Left            =   1920
      TabIndex        =   3
      Top             =   2520
      Width           =   4695
   End
   Begin VB.TextBox txtAddress 
      Height          =   375
      Left            =   1920
      TabIndex        =   2
      Top             =   1920
      Width           =   4695
   End
   Begin VB.TextBox txtLastName 
      Height          =   375
      Left            =   1920
      TabIndex        =   1
      Top             =   1320
      Width           =   4695
   End
   Begin VB.TextBox txtFirstName 
      Height          =   375
      Left            =   1920
      TabIndex        =   0
      Top             =   720
      Width           =   4695
   End
   Begin VB.Label Label5 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Country"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   600
      TabIndex        =   11
      Top             =   3240
      Width           =   1215
   End
   Begin VB.Label Label4 
      BackColor       =   &H00E0E0E0&
      Caption         =   "City/State/Zip"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   600
      TabIndex        =   10
      Top             =   2640
      Width           =   1215
   End
   Begin VB.Label Label3 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Address"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   600
      TabIndex        =   9
      Top             =   2040
      Width           =   1215
   End
   Begin VB.Label Label2 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Last Name"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   600
      TabIndex        =   8
      Top             =   1440
      Width           =   1095
   End
   Begin VB.Label Label1 
      BackColor       =   &H00E0E0E0&
      Caption         =   "First Name"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   600
      TabIndex        =   7
      Top             =   840
      Width           =   1215
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdAdd_Click()
    gFirstName = txtFirstName.Text
    gLastName = txtLastName.Text
    gAddress = txtAddress.Text
    gCityStateZip = txtCityStateZip.Text
    gCountry = txtCountry.Text

    MsgBox ("Your Message Has Been Added" & vbCrLf & vbCrLf & "First Name:      " _
    & gFirstName & vbCrLf & "Last Name:      " & gLastName & vbCrLf & "Address:         " _
    & gAddress & vbCrLf & "City/State/Zip: " & gCityStateZip & vbCrLf & "Country:          " & gCountry)
End Sub

Private Sub cmdClear_Click()
    txtFirstName.Text = ""
    txtLastName.Text = ""
    txtAddress.Text = ""
    txtCityStateZip.Text = ""
    txtCountry.Text = ""
End Sub

Private Sub cmdDep_Click()
    Dim a As New frmDepreciation
    a.Top = (Screen.Height - a.Height) / 2      ' Code to center the form on the MDI
    a.Left = (Screen.Width - a.Width) / 2
    a.Show
End Sub

Private Sub cmdExit_Click()
    Unload Me
End Sub

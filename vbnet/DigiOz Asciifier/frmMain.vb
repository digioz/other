Imports System.Drawing.Printing

Public Class frmMain

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtString.Clear()
        txtOutput.Clear()
    End Sub

    Private Sub btnAsciify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsciify.Click
        Dim sIn As String = txtString.Text
        Dim sASC As String = ""
        Dim iASC As Integer
        Dim chArray As Char()
        Dim i As Integer

        chArray = sIn.ToCharArray()

        For i = 0 To chArray.GetLength(0) - 1
            iASC = Asc(chArray(i).ToString())
            sASC &= "&#" & iASC.ToString & ";"
        Next

        txtOutput.Text = sASC
    End Sub

    Private Sub btnDeAsciify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeAsciify.Click
        Dim sIn As String = txtString.Text
        Dim aDeASC() As String
        Dim sDeASC As String = ""
        Dim i As Integer

        sIn = sIn.Replace("&#", "")
        sIn = LTrim(sIn)
        sIn = RTrim(sIn)
        aDeASC = Split(sIn, ";")

        For i = 0 To aDeASC.Length - 2
            sDeASC &= Chr(CInt(aDeASC(i)))
        Next

        txtOutput.Text = sDeASC

    End Sub
End Class

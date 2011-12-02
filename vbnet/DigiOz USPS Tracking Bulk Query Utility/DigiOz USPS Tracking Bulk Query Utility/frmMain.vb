Imports System
Imports System.Web
Imports System.Xml.Serialization
Imports System.Net
Imports System.IO
Imports System.Xml

Public Class frmMain
    Dim strTracking As String
    Dim strTrackSummary As String
    Dim strTrackDetail As String

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuCopyright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyright.Click
        MessageBox.Show("Copyright DigiOz Multimedia 2006")
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StatusPanel1.Text = "Please Enter the USPS Tracking Number in the Left Panel and hit Query Button."
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtManualEntry.Text = ""
        txtOutput.Text = ""
        ProgressBar1.Value = 0
        StatusPanel1.Text = "Please Enter the USPS Tracking Number in the Left Panel and hit Query Button."
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnQueryUSPSTracking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQueryUSPSTracking.Click
        Dim strTMPResponse As String = ""
        Dim icount As Integer = 0       ' Progress Bar Count
        Dim scount As Integer = 0       ' Record Count
        Dim j As Integer = 0
        Dim k As Integer = 0
        Dim sOUTPUT As String = ""
        Dim xFile As String = ""

        strTracking = ""
        strTrackSummary = ""
        strTrackDetail = ""
        aListTracking.Clear()

        StatusPanel1.Text = "Querying the USPS API through your internet connection ...."
        StatusStrip1.Refresh()

        Dim str1 As String
        chopItUp(txtManualEntry.Text)

        icount = aListTracking.Count
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = icount
        ProgressBar1.Value = ProgressBar1.Minimum

        Dim aResults(icount, 2) As String

        For Each str1 In aListTracking
            ProgressBar1.Value += 1

            strTMPResponse = GetWebPageResult("http://production.shippingapis.com/ShippingAPI.dll?API=TrackV2&XML=<TrackRequest%20USERID=""572PARCE1383""><TrackID%20ID=""" & str1 & """></TrackID></TrackRequest>")
            xmlParseResponse(strTMPResponse, strTracking, strTrackSummary, strTrackDetail)

            ' ------------ Place USPS Response Into 2D Array -------------
            aResults(scount, 0) = str1
            aResults(scount, 1) = getUSPSStatus(strTrackSummary)
            aResults(scount, 2) = getUSPSDateTime(strTrackSummary)
            scount = scount + 1
        Next

        ProgressBar1.Value = ProgressBar1.Maximum

        If scount > 0 Then
            For k = 0 To scount - 1
                For j = 0 To 2
                    sOUTPUT &= aResults(k, j).PadRight(28)
                Next
                sOUTPUT &= vbNewLine
            Next
        Else
            MessageBox.Show("No Results Found!")
            StatusPanel1.Text = "No Results were Found!"
        End If

        txtOutput.Text = sOUTPUT
        StatusPanel1.Text = "Query Completed! See Results in the Right panel. "

    End Sub
End Class

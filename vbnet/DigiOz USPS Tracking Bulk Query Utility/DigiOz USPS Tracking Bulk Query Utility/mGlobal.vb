Imports System
Imports System.Web
Imports System.Xml.Serialization
Imports System.Net
Imports System.IO
Imports System.Xml

Module mGlobal

    Public aPath As String = Application.StartupPath
    Public aMonth() As String = {"", "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"}
    Public aKeywords() As String = {"DELIVERED", "NOT CLAIMED", "ARRIVED", "ACCEPTED/PICKED UP", "PROCESSED", "NOTICE WAS LEFT", "UNDELIVERABLE AS ADDRESSED", "FORWARDED", "MISROUTED"}
    Public aListTracking As New ArrayList

    ' ---------------------------------- '
    ' Function to Determine USPS Staus   '
    ' ---------------------------------- '

    Public Function getUSPSStatus(ByVal strStatus As String)
        Dim sNewStatus As String = ""
        Dim i As Integer

        strStatus = UCase(strStatus)

        For i = 0 To aKeywords.Length - 1
            If strStatus.IndexOf(aKeywords(i)) > 0 Then
                sNewStatus = aKeywords(i)
                Exit For
            Else
                sNewStatus = "N/A"
            End If
        Next

        Return sNewStatus
    End Function

    ' ------------------------------------- '
    ' Function to Determine USPS Date/Time  '
    ' ------------------------------------- '

    Public Function getUSPSDateTime(ByVal strStatus As String)
        Dim strNewDateTime As String = ""
        Dim tmpDate As String = ""
        Dim tmpTime As String = ""
        Dim sSizeMonth As Integer = 0
        Dim sSelectedMonth As Integer = 0
        Dim iStart As Integer
        Dim iEnd As Integer

        strStatus = UCase(strStatus)

        If strStatus.IndexOf(aMonth(1)) > 0 Then
            sSizeMonth = 7
            sSelectedMonth = 1
        ElseIf strStatus.IndexOf(aMonth(2)) > 0 Then
            sSizeMonth = 8
            sSelectedMonth = 2
        ElseIf strStatus.IndexOf(aMonth(3)) > 0 Then
            sSizeMonth = 5
            sSelectedMonth = 3
        ElseIf strStatus.IndexOf(aMonth(4)) > 0 Then
            sSizeMonth = 5
            sSelectedMonth = 4
        ElseIf strStatus.IndexOf(aMonth(5)) > 0 Then
            sSizeMonth = 3
            sSelectedMonth = 5
        ElseIf strStatus.IndexOf(aMonth(6)) > 0 Then
            sSizeMonth = 4
            sSelectedMonth = 6
        ElseIf strStatus.IndexOf(aMonth(7)) > 0 Then
            sSizeMonth = 4
            sSelectedMonth = 7
        ElseIf strStatus.IndexOf(aMonth(8)) > 0 Then
            sSizeMonth = 6
            sSelectedMonth = 8
        ElseIf strStatus.IndexOf(aMonth(9)) > 0 Then
            sSizeMonth = 9
            sSelectedMonth = 9
        ElseIf strStatus.IndexOf(aMonth(10)) > 0 Then
            sSizeMonth = 7
            sSelectedMonth = 10
        ElseIf strStatus.IndexOf(aMonth(11)) > 0 Then
            sSizeMonth = 8
            sSelectedMonth = 11
        ElseIf strStatus.IndexOf(aMonth(12)) > 0 Then
            sSizeMonth = 8
            sSelectedMonth = 12
        Else
            ' No Date Found
        End If

        If sSelectedMonth > 0 Then
            iStart = strStatus.IndexOf(":") - 1

            If iStart <= -1 Then
                tmpTime = ""
            Else
                tmpTime = strStatus.Substring(iStart, 7)
            End If

            iStart = strStatus.IndexOf(aMonth(sSelectedMonth))

            If iStart <= -1 Then
                tmpDate = ""
            Else
                iEnd = sSizeMonth + 10
                tmpDate = strStatus.Substring(iStart, iEnd)
            End If

            strNewDateTime = tmpDate & " " & tmpTime
        Else
            strNewDateTime = ""
        End If

        Return strNewDateTime
    End Function

    ' ------------------------------------------------ '
    ' Function to break up new line delimited string   '
    ' ------------------------------------------------ '

    Public Sub chopItUp(ByVal strTracking)
        Dim arrTMP() As String
        Dim i As Integer

        arrTMP = Split(strTracking, vbNewLine)

        For i = 0 To arrTMP.Length - 1
            If arrTMP(i) <> "" Then
                aListTracking.Add(Trim(arrTMP(i)))
            End If
        Next
    End Sub

    ' ----------------------------------- '
    ' Function to grab web page content   '
    ' ----------------------------------- '

    Public Function GetWebPageResult(ByVal webPG As String) As String
        Dim myHttpWebRequest As HttpWebRequest = CType(WebRequest.Create(webPG), HttpWebRequest)
        Dim myHttpWebResponse As HttpWebResponse = CType(myHttpWebRequest.GetResponse(), HttpWebResponse)
        Dim receiveStream As Stream = myHttpWebResponse.GetResponseStream()
        Dim encode As System.Text.Encoding = System.Text.Encoding.GetEncoding("utf-8")
        Dim readStream As New StreamReader(receiveStream, encode)
        GetWebPageResult = readStream.ReadToEnd()
    End Function

    ' -------------------------------------------------- '
    ' Subroutine to parse XML response and return values '
    ' -------------------------------------------------- '

    Public Sub xmlParseResponse(ByVal strXML As String, ByRef strTracking As String, ByRef strTrackSummary As String, ByRef strTrackDetail As String)
        Try
            Dim oXMLString As String = strXML
            Dim oXMLReader As StringReader = New StringReader(oXMLString)
            Dim oReader As XmlTextReader = New XmlTextReader(oXMLReader)
            Dim pos As Integer = -1

            oReader.WhitespaceHandling = WhitespaceHandling.None
            oReader.Read()
            oReader.Read()

            While Not oReader.EOF
                oReader.Read()

                If Not oReader.IsStartElement() Then
                    Exit While
                End If

                strTracking = oReader.GetAttribute("ID")
                oReader.Read()
                strTrackSummary = oReader.ReadElementString("TrackSummary")

                pos = strXML.IndexOf("TrackDetail")

                If pos >= 1 Then
                    strTrackDetail = oReader.ReadElementString("TrackDetail")
                Else
                    strTrackDetail = ""
                End If

            End While

        Catch ex As Exception
            ' MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Module

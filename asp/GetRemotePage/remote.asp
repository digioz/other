<%
  Response.Buffer = True
  Dim objXMLHTTP, xml

  ' Create an xmlhttp object:
  Set xml = Server.CreateObject("Microsoft.XMLHTTP")
  ' Or, for version 3.0 of XMLHTTP, use:
  ' Set xml = Server.CreateObject("MSXML2.ServerXMLHTTP")

  ' Opens the connection to the remote server
  xml.Open "GET", "http://www.digioz.com/", False
	
  ' Actually Sends the request and returns the data:
  xml.Send

  ' Change </xmp> to <xmp> to get HTML source code
  Response.Write "</xmp>"

  Response.Write xml.responseText

  Set xml = Nothing
%>



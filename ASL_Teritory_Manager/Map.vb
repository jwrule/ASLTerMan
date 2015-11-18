Module Map
    Public Sub CreateMap(ByVal lat As Decimal, ByVal lon As Decimal, ByVal terNo As String)

        'check if there are deaf in the territory and get the GPS coord and address
        Dim coord As New Generic.List(Of String)
        Dim count As Integer
        For Each row As DataRow In ASLTerriroryManager.DS.Contacts
            If Not String.IsNullOrWhiteSpace(row.Item("Lat").ToString) Then
                coord.Add(row.Item("Lat").ToString.Trim)
                coord.Add(row.Item("Long").ToString.Trim)
                coord.Add(row.Item("Address").ToString.Trim)
            End If
        Next
        Try
            count = coord.Count
        Catch ex As Exception
        End Try

        'draw the map
        Dim page As New RichTextBox
        page.AppendText("<!DOCTYPE html>" & Environment.NewLine)
        page.AppendText("<html>" & Environment.NewLine)
        page.AppendText("<meta http-equiv='X-UA-Compatible' content='IE=8' />")
        page.AppendText("<head>" & Environment.NewLine)
        page.AppendText(" <style type='text/css'>" & Environment.NewLine)
        page.AppendText(" html, body, #map-canvas { height: 100%; margin: 0; padding: 0;}" & Environment.NewLine)
        page.AppendText("  </style>" & Environment.NewLine)
        page.AppendText("  <script type='text/javascript'" & Environment.NewLine)
        page.AppendText("   src='https://maps.googleapis.com/maps/api/js?key=AIzaSyAfdpzCvn1vqc3qXhWkT6ab_oLpVAX1AV8'>" & Environment.NewLine)
        page.AppendText(" </script>" & Environment.NewLine)
        page.AppendText("  <script type='text/javascript'>" & Environment.NewLine)
        page.AppendText("  function initialize() {" & Environment.NewLine)
        page.AppendText("     var mapOptions = {" & Environment.NewLine)
        page.AppendText("     center:new google.maps.LatLng" & "(" & lat & "," & lon & ")," & Environment.NewLine)
        page.AppendText("      zoom: 15" & Environment.NewLine)
        page.AppendText("    };" & Environment.NewLine)
        page.AppendText("        var map = new google.maps.Map(document.getElementById('map-canvas')," & Environment.NewLine)
        page.AppendText("     mapOptions);" & Environment.NewLine)
        'code for adding marker
        If count > 0 Then
            For I = 0 To count - 1 Step 3
                page.AppendText("var myLatlng = new google.maps.LatLng(" & coord(I) & "," & coord(I + 1) & ");" & Environment.NewLine)
                page.AppendText("var marker = new google.maps.Marker({" & Environment.NewLine)
                page.AppendText("position: myLatlng," & Environment.NewLine)
                page.AppendText("map: map," & Environment.NewLine)
                page.AppendText("title: '" & coord(I + 2) & "'" & Environment.NewLine)
                page.AppendText("});" & Environment.NewLine)
            Next
        End If
        ' end of code for adding marker
        page.AppendText("	}" & Environment.NewLine)
        page.AppendText("  google.maps.event.addDomListener(window, 'load', initialize);" & Environment.NewLine)
        page.AppendText(" </script>" & Environment.NewLine)
        page.AppendText(" </head>" & Environment.NewLine)
        page.AppendText("<body>" & Environment.NewLine)
        page.AppendText("<div id='map-canvas'></div>" & Environment.NewLine)
        page.AppendText("</body>" & Environment.NewLine)
        page.AppendText("</html>")

        ASLTerriroryManager.WebBrowser.ScriptErrorsSuppressed = True
        ASLTerriroryManager.WebBrowser.DocumentText = page.Text

    End Sub
End Module

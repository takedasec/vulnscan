Public Sub getreq(ByVal site)
        ServicePointManager.ServerCertificateValidationCallback = (Function(sender, certificate, chain, sslPolicyErrors) True)
        Dim tempcookies As New CookieContainer
        Dim encoding As New UTF8Encoding
        Dim postreq As HttpWebRequest = DirectCast(HttpWebRequest.Create("http://" & site), HttpWebRequest)
        postreq.Method = "GET"
        postreq.KeepAlive = True
        postreq.CookieContainer = tempcookies
        postreq.UserAgent = "plzbevuln bot"
        postreq.ContentType = "application/x-www-form-urlencoded"
        Dim postresponse As HttpWebResponse
        On Error Resume Next
        postresponse = DirectCast(postreq.GetResponse, HttpWebResponse)
        On Error Resume Next
        tempcookies.Add(postresponse.Cookies)
        Dim postreqreader As New StreamReader(postresponse.GetResponseStream())
        Dim thepage As String = postreqreader.ReadToEnd
        RichTextBox1.Text = thepage

        identify(site)
    End Sub
    Private Sub identify(ByVal site)
        wordpress(site)
        revslider(site)
        symposium(site)
        ezcart(site)
        downloadmanager(site)
        wpdatatables(site)
        showbiz(site)
    End Sub
    Private Sub revslider(ByVal site)
        If RichTextBox1.Text.Contains("rs-plugin") Then
            txtOutput.AppendText(Environment.NewLine)
            txtOutput.AppendText(site & "  -  rs-plugin")
        End If
    End Sub
    Private Sub symposium(ByVal site)
        If RichTextBox1.Text.Contains("wp-symposium") Then
            txtOutput.AppendText(Environment.NewLine)
            txtOutput.AppendText(site & "  -  wp-symposium")
        End If
    End Sub

    Private Sub wordpress(ByVal site)
        If RichTextBox1.Text.Contains("wp-content") Then
            txtOutput.AppendText(Environment.NewLine)
            txtOutput.AppendText(site & "  -  running wordpress")
        End If
    End Sub
    Private Sub ezcart(ByVal site)
        If RichTextBox1.Text.Contains("wp-easycart") Then
            txtOutput.AppendText(Environment.NewLine)
            txtOutput.AppendText(site & "  -  wp-easycart")
        End If
    End Sub
    Private Sub downloadmanager(ByVal site)
        If RichTextBox1.Text.Contains("download-manager") Then
            txtOutput.AppendText(Environment.NewLine)
            txtOutput.AppendText(site & "  -  download-manager")
        End If
    End Sub
    Private Sub wpdatatables(ByVal site)
        If RichTextBox1.Text.Contains("wpdatatables") Then
            txtOutput.AppendText(Environment.NewLine)
            txtOutput.AppendText(site & "  -  wpdatatables")
        End If
    End Sub
    Private Sub showbiz(ByVal site)
        If RichTextBox1.Text.Contains("showbiz") Then
            txtOutput.AppendText(Environment.NewLine)
            txtOutput.AppendText(site & "  -  showbiz")
        End If
    End Sub

Public Class frmInitiate
    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub
    Private Sub tbIP_TextChanged(sender As Object, e As EventArgs) Handles tbIP.TextChanged
        If (Len(tbIP.Text) >= 8) And tbIP.Text.EndsWith(".") = False Then
            If My.Computer.Network.Ping(tbIP.Text) Then
                My.Settings.IP = tbIP.Text
                My.Settings.Save()
                tbIP.BackColor = Color.MediumSpringGreen
                btnConnect.Enabled = True
            Else
                tbIP.BackColor = Color.LightCoral
                btnConnect.Enabled = False
            End If
        Else
            tbIP.BackColor = Color.LightCoral
            btnConnect.Enabled = False
        End If
    End Sub

    Private Sub frmInitiate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Process.Start("C:\Users\Tiaan-LT\Desktop\Start hosted network.bat")
        btnInitiate.Enabled = False
        tbIP.Text = My.Settings.IP
        lblConnectionStatus.Text = "Connection Status:  Disconnected"
        If (Len(tbIP.Text) >= 8) And tbIP.Text.EndsWith(".") = False Then
            If My.Computer.Network.Ping(tbIP.Text) Then
                My.Settings.IP = tbIP.Text
                tbIP.BackColor = Color.MediumSpringGreen
                btnConnect.Enabled = True
            Else
                tbIP.BackColor = Color.LightCoral
                btnConnect.Enabled = False
            End If
        Else
            tbIP.BackColor = Color.LightCoral
            btnConnect.Enabled = False
        End If
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        lblConnectionStatus.Text = "Connection Status:  connecting..."
        tbIP.Enabled = False
        btnConnect.Enabled = False
        wbConnected.Navigate("http://" & tbIP.Text & "/cgi-bin/robot_code/robot.py?Connected=Connect")
        wait(2000)
        If wbConnected.DocumentText.Contains("Connected!") = True Then
            lblConnectionStatus.Text = "Connection Status:  Connected"
            btnInitiate.Enabled = True

        Else
            lblConnectionStatus.Text = "Connection Status:  Disconnected"
            MsgBox("Cannot connect to this IP")
            btnConnect.Enabled = True
            tbIP.Enabled = True

        End If



    End Sub

    Private Sub wbConnected_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles wbConnected.ProgressChanged

    End Sub

    Private Sub wbConnected_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbConnected.DocumentCompleted

    End Sub

    Private Sub btnInitiate_Click(sender As Object, e As EventArgs) Handles btnInitiate.Click
        wbConnected.Navigate("http://" & tbIP.Text & "/cgi-bin/robot_code/robot.py?Connected=int")
        wait(1000)
        frmRobotController.Show()
        Me.Close()
    End Sub
End Class
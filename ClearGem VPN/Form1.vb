Public Class Form1
    Shared rand As New Random()
    Dim connectdelay As Integer
    Public VPNOn As Boolean = True
    Dim newlabel As String
    Dim chosencountry As String = "Ireland"
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If VPNOn = True Then
            PictureBox2.Image = My.Resources.Off
            VPNOn = False
            newlabel = "VPN Inactive" + Environment.NewLine + "IP Exposed"
            Label1.Text = (newlabel)
            Process.Start("C:\Program Files (x86)\Cleargem VPN\disable.bat")
            ToastNotif.Show()
            Me.Text = "Cleargem VPN - Not Connected"
            NotifyIcon1.Text = "Cleargem VPN - Not Connected"
        Else
            PictureBox2.Image = My.Resources.Connecting
            Me.Text = "Cleargem VPN - Connecting"
            NotifyIcon1.Text = "Cleargem VPN - Connecting"
            Application.DoEvents()
            connectdelay = rand.Next(500, 5001)
            Threading.Thread.Sleep(connectdelay)
            PictureBox2.Image = My.Resources._On
            VPNOn = True
            newlabel = "Et Voila !" + Environment.NewLine + "You are in " + chosencountry
            Label1.Text = (newlabel)
            Process.Start("C:\Program Files (x86)\Cleargem VPN\enable.bat")
            ToastNotif.Show()
            Me.Text = "Cleargem VPN - Protection Active"
            NotifyIcon1.Text = "Cleargem VPN - Protection Active"
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.DoubleClick
        If ComboBox1.Visible = True Then
            ComboBox1.Hide()
        Else
            ComboBox1.Show()
        End If
    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        chosencountry = ComboBox1.Text
        If VPNOn = True Then
            newlabel = "Et Voila !" + Environment.NewLine + "You are in " + chosencountry
            Label1.Text = (newlabel)
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Process.Start("C:\Program Files (x86)\Cleargem VPN\Help.html")
    End Sub

    Private Sub AboutCleargemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutCleargemToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
End Class

Public Class ToastNotif

    Private Sub ToastNotif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form1.VPNOn = True Then
            PictureBox1.Image = My.Resources.Toast1
        Else
            PictureBox1.Image = My.Resources.Toast2
        End If
    End Sub

    Private Sub ToastNotif_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.Windows_Notify_System_Generic, AudioPlayMode.Background)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        PictureBox1.Size = New Size(473, 150)
        PictureBox1.Location = New Point(PictureBox1.Location.X + 10, PictureBox1.Location.Y + 10)
        Application.DoEvents()
    End Sub


    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        PictureBox1.Size = New Size(483, 160)
        PictureBox1.Location = New Point(PictureBox1.Location.X - 10, PictureBox1.Location.Y - 10)
        Application.DoEvents()
    End Sub
End Class
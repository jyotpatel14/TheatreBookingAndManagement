Public Class ScreenCreator
    Private Sub ScreenCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        screen1.TopLevel = False
        screen1.TopMost = True
        Me.Panel1.Controls.Add(screen1)
        screen1.Show()

        Me.pb1.BackColor = Color.Transparent

        PictureBox3.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("https://tinyurl.com/mvkcfsz7")))


        Dim dt As New Date(Label1.Text.Remove(0, 6), Label1.Text.Substring(3, 2), Label1.Text.Substring(0, 2))
        MsgBox(Label1.Text.Remove(0, 6) & Label1.Text.Substring(3, 2) & Label1.Text.Substring(0, 2))
        Label2.Text = dt.ToString("dddd")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pb1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

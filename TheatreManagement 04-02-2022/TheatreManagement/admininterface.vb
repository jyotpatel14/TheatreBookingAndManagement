Public Class admininterface
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub admininterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        movielistupdate.TopMost = True
        movielistupdate.TopLevel = False
        Me.tabmovielist.Controls.Add(movielistupdate)
        movielistupdate.Show()

        timetableupdate.TopMost = True
        timetableupdate.TopLevel = False
        Me.tabtimetable.Controls.Add(timetableupdate)
        timetableupdate.Show()

        movieSeatCostUpdate.TopMost = True
        movieSeatCostUpdate.TopLevel = False
        Me.tabprice.Controls.Add(movieSeatCostUpdate)
        movieSeatCostUpdate.Show()

        adminconsole.TopMost = True
        adminconsole.TopLevel = False
        Me.tabconsole.Controls.Add(adminconsole)
        adminconsole.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Home.Show()
        Me.Hide()
    End Sub


End Class
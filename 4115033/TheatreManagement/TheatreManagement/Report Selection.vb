Public Class Report_Selection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReportSeats.ReportViewer1.RefreshReport()
        ReportSeats.Show()
        ReportCash.Hide()
        ReportCash.Dispose()
    End Sub

    Private Sub Report_Selection_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ReportCash.ReportViewer1.RefreshReport()
        ReportCash.Show()
        ReportSeats.Hide()
        ReportSeats.Dispose()
    End Sub
End Class
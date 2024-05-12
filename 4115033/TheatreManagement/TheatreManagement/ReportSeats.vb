Public Class ReportSeats
    Private Sub ReportSeats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.transaction_master' table. You can move, or remove it, as needed.
        Me.transaction_masterTableAdapter.Fill(Me.DataSet1.transaction_master)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
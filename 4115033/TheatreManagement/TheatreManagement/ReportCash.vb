Public Class ReportCash
    Private Sub ReportCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.cash_master' table. You can move, or remove it, as needed.
        Me.cash_masterTableAdapter.Fill(Me.DataSet1.cash_master)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
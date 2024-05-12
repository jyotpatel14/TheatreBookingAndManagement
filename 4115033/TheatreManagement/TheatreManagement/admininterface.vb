Imports System.Data.SqlClient
Imports System.IO


Public Class admininterface

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlClient.SqlDataReader

    Dim transid As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub admininterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Net\TheatreManagement\TheatreManagement\Database1.mdf;Integrated Security=True"


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

        'adminconsole.TopMost = True
        'adminconsole.TopLevel = False
        'Me.tabconsole.Controls.Add(adminconsole)
        'adminconsole.Show()

        txtcounterbalance.Enabled = False
        GetBalance()
        txtcounterbalance.Text = PaymentInteraction.totalcashamount



    End Sub

    Public Function GetBalance()
        con.Close()
        con.Open()
        cmd = New SqlCommand("select total from cash_master where transid = (select max(transid) from cash_master)", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            PaymentInteraction.totalcashamount = dr(0)
        Loop
        Return 0
        con.Close()
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Home.Dispose()
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Report_Selection.Show()
    End Sub

    Private Sub btnwithdraw_Click(sender As Object, e As EventArgs) Handles btnwithdraw.Click


        con.Close()
        con.Open()
        cmd = New SqlCommand("select max(transid) from cash_master", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            transid = dr(0)
        Loop

        con.Close()
        con.Open()
        cmd = New SqlCommand("insert into cash_master values(" & transid + 1 & "," & txtvalue.Text & "," & "0" & ",'" & txtdes.Text & "','" & DateTime.Parse(Now.Date).ToString("dd-MMM-yyyy") & "'," & PaymentInteraction.totalcashamount - CInt(txtvalue.Text) & ")", con)
        cmd.ExecuteNonQuery()
        con.Close()

        GetBalance()
        txtcounterbalance.Text = PaymentInteraction.totalcashamount

    End Sub

    Private Sub btndeposit_Click(sender As Object, e As EventArgs) Handles btndeposit.Click
        con.Close()
        con.Open()
        cmd = New SqlCommand("select max(transid) from cash_master", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            transid = dr(0)
        Loop

        con.Close()
        con.Open()
        cmd = New SqlCommand("insert into cash_master values(" & transid + 1 & "," & "0" & "," & txtvalue.Text & ",'" & txtdes.Text & "','" & DateTime.Parse(Now.Date).ToString("dd-MMM-yyyy") & "'," & PaymentInteraction.totalcashamount + CInt(txtvalue.Text) & ")", con)
        cmd.ExecuteNonQuery()
        con.Close()

        GetBalance()
        txtcounterbalance.Text = PaymentInteraction.totalcashamount

    End Sub
End Class
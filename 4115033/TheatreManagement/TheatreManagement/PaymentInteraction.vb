Imports System.Data.SqlClient
Imports System.IO

Public Class PaymentInteraction

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlClient.SqlDataReader

    Dim transid As Integer
    Public totalcashamount As Double



    Private Sub PaymentInteraction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Net\TheatreManagement\TheatreManagement\Database1.mdf;Integrated Security=True"


        labErr1.Visible = False

        con.Close()
        con.Open()
        cmd = New SqlCommand("select * from movie_master where mid = '" & showSelection.MovieId & "'", con)
        Dim data As DataSet = New DataSet()
        Dim dataadp As New SqlDataAdapter()
        dataadp.SelectCommand = cmd
        dataadp.Fill(data, "poster")
        Dim postertable As DataTable = data.Tables("poster")
        Dim dataimage As Byte() = DirectCast(postertable.Rows(0).Item("poster"), Byte())
        Dim ms As New MemoryStream(dataimage)
        Dim img As Image = Image.FromStream(ms)

        movieimage.Image = img

        labmovietitle.Text = showSelection.labmovietitle.Text
        labDateTime.Text = showSelection.SelDate & " : " & showSelection.SelTime
        labDescription.Text = showSelection.labDescription.Text
        labCast.Text = showSelection.labCast.Text

        Dim priceclassic, pricegold, pricepremium As Integer
        con.Close()
        con.Open()
        cmd = New SqlCommand("select classic,gold,premium from movie_seat_cost where mid = '" & showSelection.MovieId & "'", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            priceclassic = dr(0)
            pricegold = dr(1)
            pricepremium = dr(2)
        Loop
        LabPrice.Text = "Premium : " & pricepremium & vbNewLine & "Gold : " & pricegold & vbNewLine & "Classic : " & priceclassic
        con.Close()


        Dim Screenname As String = " "
        con.Open()
        cmd = New SqlCommand("select scrname from screen_detail where scrid = " & showSelection.Screenid, con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            Screenname = dr(0)
        Loop

        con.Close()

        LabClassicSeats.Text = screen1.ClassicSelSeats.Remove(0, 10)
        LabGoldSeats.Text = screen1.GoldSelSeats.Remove(0, 7)
        labPremiumSeats.Text = screen1.PremiumSelSeats.Remove(0, 10)

        labPremiumPrice.Text = "₹ " & pricepremium
        labGoldPrice.Text = "₹ " & pricegold
        labClassicPrice.Text = "₹ " & priceclassic

        labPremiumCount.Text = screen1.CountPremium
        labGoldCount.Text = screen1.CountGold
        labClassicCount.Text = screen1.CountClassic

        labTotalPremium.Text = "₹ " & pricepremium * screen1.CountPremium
        labTotalGold.Text = "₹ " & pricegold * screen1.CountGold
        labTotalClassic.Text = "₹ " & priceclassic * screen1.CountClassic
        labTotalAmount.Text = "₹ " & CInt(labTotalPremium.Text.Remove(0, 2)) + CInt(labTotalGold.Text.Remove(0, 2)) + CInt(labTotalClassic.Text.Remove(0, 2))



        'Ticket Details
        TicMovieTitle1.Text = labmovietitle.Text
        TicMovieTitle2.Text = labmovietitle.Text

        TicScreen1.Text = Screenname
        TicScreen2.Text = Screenname

        TicDate1.Text = showSelection.SelDate
        TicDate2.Text = showSelection.SelDate

        TicDay1.Text = DateAndTime.WeekdayName(DateAndTime.Weekday(showSelection.SelDate, FirstDayOfWeek.System))
        TicDay2.Text = DateAndTime.WeekdayName(DateAndTime.Weekday(showSelection.SelDate, FirstDayOfWeek.System))

        TicTime1.Text = showSelection.SelTime
        TicTime2.Text = showSelection.SelTime

        TicSeats1.Text = screen1.SelSeats
        TicSeats2.Text = screen1.SelSeats

        TicSeatCount1.Text = showSelection.txtSeatCount.Text
        TicSeatCount2.Text = showSelection.txtSeatCount.Text

        TicTotalAmount1.Text = labTotalAmount.Text.Remove(0, 2)
        TicTotalAmount2.Text = labTotalAmount.Text.Remove(0, 2)

        GetBalance()

        con.Close()
        con.Open()
        cmd = New SqlCommand("select max(transid) from transaction_master", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            transid = dr(0)
        Loop

        transid += 1

        con.Close()
        con.Open()
        cmd = New SqlCommand("insert into transaction_master values(" & transid & ",'" & showSelection.PhoneNo & "','" & labmovietitle.Text & "','" & showSelection.SelDate & "','" & showSelection.SelTime & "','" & screen1.SelSeats & "'," & screen1.CountClassic & "," & screen1.CountGold & "," & screen1.CountPremium & "," & labTotalAmount.Text.Remove(0, 2) & ")", con)
        cmd.ExecuteNonQuery()
        con.Close()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click


        Home.Show()
        showSelection.Dispose()
        Me.Dispose()
        Me.Hide()


    End Sub

    Dim TransactionStatus As Boolean = False
    Public Bid As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button2.Click
        TakeScreenShot(Ticket).Save("D:\.Net\TheatreManagement\Tickets\ticket " & showSelection.PhoneNo & ".png", System.Drawing.Imaging.ImageFormat.Png)
    End Sub

    Private Function TakeScreenShot(ByVal Control As Control) As Bitmap
        Dim tmpImg As New Bitmap(Control.Width, Control.Height)
        Using g As Graphics = Graphics.FromImage(tmpImg)
            g.CopyFromScreen(Ticket.PointToScreen(New Point(0, 0)), New Point(0, 0), New Size(Ticket.Width, Ticket.Height))
        End Using
        Return tmpImg
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'TakeScreenShot(Ticket).Save("D:\.Net\TheatreManagement\Tickets\ticket" & showSelection.PhoneNo & ".png", System.Drawing.Imaging.ImageFormat.Png)

        Dim depositcash As Double = 0
        Dim withdrawcash As Double = 0
        Try
            depositcash = CDbl(txtAmountReceived.Text)
            withdrawcash = CDbl(txtChange.Text)

        Catch ex As Exception
            depositcash = 0
            withdrawcash = 0
        End Try



        Dim flag As Integer = 0
        If depositcash = 0 Then
            flag += 1
        End If

        If flag = 1 Then
            labErr1.Visible = True
        Else
            flag = 0
            labErr1.Visible = False
        End If

        If flag = 0 Then


            TransactionStatus = True


            For i As Integer = 0 To screen1.seatselected.Count - 1
                con.Close()
                con.Open()
                cmd = New SqlCommand("select sid from seat_detail where sname = '" & screen1.seatselected(i) & "'", con)
                cmd.ExecuteNonQuery()
                dr = cmd.ExecuteReader()
                Do While dr.Read = True
                    screen1.SelSeatid.Add(dr(0))
                Loop
                con.Close()
            Next

            For i As Integer = 0 To screen1.seatselected.Count - 1
                con.Close()
                con.Open()
                cmd = New SqlCommand("insert into booking_master values(" & Bid + 1 & "," & showSelection.Showid & "," & screen1.SelSeatid(i) & ")", con)
                cmd.ExecuteNonQuery()
                con.Close()
            Next


            GetBalance()

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
            cmd = New SqlCommand("insert into cash_master values(" & transid + 1 & "," & depositcash & "," & withdrawcash & ",'Ticket Booked','" & DateTime.Parse(Now.Date).ToString("dd-MMM-yyyy") & "'," & totalcashamount + depositcash - withdrawcash & ")", con)
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Ticket Is Exported, Loading Home Screen...")
            Home.Show()
            showSelection.Dispose()
            Me.Dispose()
            Me.Hide()

        End If




    End Sub

    Public Function GetBalance()
        con.Close()
        con.Open()
        cmd = New SqlCommand("select total from cash_master where transid = (select max(transid) from cash_master)", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            totalcashamount = dr(0)
        Loop
        Return 0
        con.Close()
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Payment Canceled, Loading Home Screen...")
        Home.Show()
        showSelection.Dispose()
        Me.Dispose()
        Me.Hide()


    End Sub

    Private Sub txtAmountReceived_LostFocus(sender As Object, e As EventArgs) Handles txtAmountReceived.LostFocus
        txtChange.Text = CDbl(txtAmountReceived.Text) - CDbl(labTotalAmount.Text)
    End Sub
End Class
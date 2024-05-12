Imports System.Data.SqlClient
Imports System.IO

Public Class showSelection

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim BtnArray() As Button

    Public MovieName As String
    Public MovieId As String
    Public SelDate As String
    Public SelTime As String
    Public Tid As Integer
    Public SeatCountNo As Integer = 0
    Public tempSeatCountNo As Integer
    Public Description As String
    Public Cast As String
    Public Showid As Integer
    Public Screenid As Integer
    Public PhoneNo As String




    Public title As String = ""

    Private Sub showSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Net\TheatreManagement\TheatreManagement\Database1.mdf;Integrated Security=True"

        DatePicker.MinDate = Today

        screen1.TopLevel = False
        screen1.TopMost = True
        Me.SeatLayoutPanel.Controls.Add(screen1)
        screen1.Show()

        screen1.lab1.Text = "Screen"
        labDateTime.Text = "Date : Time"





        labmovietitle.Text = title

        btnlist.RowCount = 10

        cmd = New SqlCommand("select mname from movie_master where status = 'Active'", con)
        Dim data As DataSet = New DataSet()
        Dim dataadp As New SqlDataAdapter()
        dataadp.SelectCommand = cmd
        dataadp.Fill(data, "mname")
        Dim movienametable As DataTable = data.Tables("mname")

        Dim NRow As Integer = movienametable.Rows.Count
        btnlist.RowCount = NRow

        ReDim BtnArray(NRow - 1)


        For i As Integer = 0 To movienametable.Rows.Count - 1
            Dim listtitle As String = movienametable.Rows(i).Item("mname")
            BtnArray(i) = New Button()

            BtnArray(i).AutoSize = False

            BtnArray(i).Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

            Me.BtnArray(i).BackColor = System.Drawing.SystemColors.Control
            Me.BtnArray(i).BackgroundImageLayout = System.Windows.Forms.ImageLayout.None

            Me.BtnArray(i).Size = New System.Drawing.Size(100, 70)
            Me.BtnArray(i).Padding = New System.Windows.Forms.Padding(5, 10, 10, 5)



            Me.BtnArray(i).Name = listtitle
            Me.BtnArray(i).Text = listtitle

            Me.BtnArray(i).Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnArray(i).TextAlign = System.Drawing.ContentAlignment.MiddleLeft

            btnlist.Controls.Add(BtnArray(i), 0, i)

            AddHandler BtnArray(i).MouseDown, AddressOf btnlist_MouseDown

        Next



        btnlist.AutoScroll = False
        btnlist.HorizontalScroll.Enabled = False
        btnlist.HorizontalScroll.Visible = False
        btnlist.HorizontalScroll.Maximum = 0
        btnlist.AutoScroll = True

        MovieId = GetMovieId(labmovietitle)
        SelDate = DatePicker.Value.Date.ToString("dd-MM-yyyy").ToUpper
        GetPrice()

        'Dim temp As String = InputBox("Enter the No. Of Seats", , 1)
        'If temp = "" Or Char.IsLetter(temp) = True Then
        '    SeatCountNo = 1
        'Else
        '    SeatCountNo = CInt(temp)
        'End If



        tempSeatCountNo = SeatCountNo
        txtSeatCount.Text = SeatCountNo

        FillTimeCombobox()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub btnlist_MouseDown(sender As Object, e As MouseEventArgs) Handles btnlist.MouseDown
        Try

            labmovietitle.Text = CType(sender, Button).Name
            MovieId = GetMovieId(labmovietitle)
            FillTimeCombobox()
            GetPrice()

        Catch ex As Exception

        End Try
    End Sub

    Private Function GetMovieId(lab As Label) As String
        Dim mid As String = ""


        con.Close()
        con.Open()
        cmd = New SqlCommand("select mid from movie_master where mname = '" & labmovietitle.Text & "'", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader()
        Do While dr.Read = True
            mid = dr(0)
        Loop
        con.Close()
        con.Open()
        cmd = New SqlCommand("select description,cast from movie_master where mid = '" & mid & "'", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            Description = dr(0)
            Cast = dr(1)
        Loop

        labDescription.Text = "Description : " & Description
        labCast.Text = "Cast : " & Cast

        con.Close()

        Return mid
    End Function

    Public Function FillTimeCombobox()

        TimePicker.Items.Clear()
        con.Close()
        con.Open()
        cmd = New SqlCommand("select * from timetable where movieid = '" & MovieId & "' and date = '" & DateTime.Parse(SelDate).ToString("dd-MMM-yyyy") & "'", con)
        Dim data As DataSet = New DataSet()
        Dim dataadp As New SqlDataAdapter()
        dataadp.SelectCommand = cmd
        dataadp.Fill(data, "timeid")
        Dim selectedtimeid As DataTable = data.Tables("timeid")

        Dim TimeIdArray(selectedtimeid.Rows.Count - 1) As Integer

        For i As Integer = 0 To selectedtimeid.Rows.Count - 1
            TimeIdArray(i) = selectedtimeid.Rows(i).Item("timeid")
        Next

        For i As Integer = 0 To TimeIdArray.Count - 1

            con.Close()
            con.Open()
            cmd = New SqlCommand("select * from time_detail where tid = " & TimeIdArray(i), con)
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader()
            Do While dr.Read = True
                TimePicker.Items.Add(dr(2))
            Loop
            con.Close()

        Next
        con.Close()

        TimePicker.SelectedItem = 0

        Return 0
    End Function

    Public Function FillScreenCombobox()

        ScreenPicker.Items.Clear()
        con.Close()
        con.Open()
        cmd = New SqlCommand("select * from timetable where movieid = '" & MovieId & "' and date = '" & DateTime.Parse(SelDate).ToString("dd-MMM-yyyy") & "' and timeid = " & Tid, con)
        Dim data As DataSet = New DataSet()
        Dim dataadp As New SqlDataAdapter()
        dataadp.SelectCommand = cmd
        dataadp.Fill(data, "screenid")
        Dim selectedscreenid As DataTable = data.Tables("screenid")

        Dim ScreenIdArray(selectedscreenid.Rows.Count - 1) As Integer

        For i As Integer = 0 To selectedscreenid.Rows.Count - 1
            ScreenIdArray(i) = selectedscreenid.Rows(i).Item("screenid")
        Next

        For i As Integer = 0 To ScreenIdArray.Count - 1

            con.Close()
            con.Open()
            cmd = New SqlCommand("select * from screen_detail where scrid = " & ScreenIdArray(i), con)
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader()
            Do While dr.Read = True
                ScreenPicker.Items.Add(dr(1))
            Loop
            con.Close()

        Next
        con.Close()

        ScreenPicker.SelectedIndex = 0
        screen1.lab1.Text = ScreenPicker.Items(0)

        Return 0
    End Function

    Public Function GetPrice()

        con.Close()
        con.Open()
        cmd = New SqlCommand("select * from movie_seat_cost where mid = '" & MovieId & "'", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader()
        Do While dr.Read = True
            screen1.labPricePremium.Text = "Premium : ₹ " & dr(3)
            screen1.labPriceGold.Text = "Gold : ₹ " & dr(2)
            screen1.labPriceClassic.Text = "Classic : ₹ " & dr(1)
        Loop
        con.Close()
        Return 0
    End Function

    Private Sub DatePicker_ValueChanged(sender As Object, e As EventArgs) Handles DatePicker.ValueChanged
        SelDate = DatePicker.Value.Date.ToString("dd-MMM-yyyy").ToUpper
        FillTimeCombobox()
        labDateTime.Text = SelDate & " : " & SelTime

    End Sub

    Private Sub TimePicker_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TimePicker.SelectedIndexChanged
        SelTime = TimePicker.Items(TimePicker.SelectedIndex)

        con.Close()
        con.Open()
        cmd = New SqlCommand("select tid from time_detail where time = '" & SelTime & "'", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            Tid = dr(0)
        Loop
        con.Close()
        labDateTime.Text = SelDate & " : " & SelTime

        con.Open()
        cmd = New SqlCommand("select showid from timetable where movieid = '" & MovieId & "' and date = '" & SelDate & "' and timeid = " & Tid, con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            Showid = dr(0)
        Loop

        con.Close()

        'dt = New Date(SelDate.Remove(0, 6), SelDate.Substring(3, 2), SelDate.Substring(0, 2))

        FillScreenCombobox()
        GetShowid()
        ResetSeats()
        FetchPreBookedSeats()

    End Sub


    Private Sub btnSettingsConfirm_Click(sender As Object, e As EventArgs)
        FillScreenCombobox()
        PhoneNo = CInt(txtPhoneNo.Text)
        GetShowid()
        ResetSeats()
        FetchPreBookedSeats()

    End Sub

    Public Function FetchPreBookedSeats()
        Dim selseatid(10) As Integer

        con.Close()
        con.Open()
        cmd = New SqlCommand("select seatid from booking_master where showid = " & Showid, con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Do While dr.Read = True

            screen1.BtnArray(dr(0)).Image = My.Resources._50grey_armchair
            screen1.BtnArray(dr(0)).Enabled = False


        Loop
        con.Close()

        Return 0
    End Function

    Public Function ResetSeats()

        con.Close()
        con.Open()
        cmd = New SqlCommand("select max(sid) from seat_detail", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Dim maxsid As Integer
        Do Until dr.Read = True
            maxsid = dr(0)
        Loop
        con.Close()

        txtSelAmount.Text = ""

        For i As Integer = 0 To 199

            screen1.BtnArray(i).Enabled = True
            If i < 20 Then
                screen1.BtnArray(i).Image = My.Resources._50red_armchair
            ElseIf i < 80 Then
                screen1.BtnArray(i).Image = My.Resources._50yellow_armchair
            Else
                screen1.BtnArray(i).Image = My.Resources._50white_armchair
            End If

        Next

        GetPrice()


        Return 0
    End Function

    Private Sub ScreenPicker_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ScreenPicker.SelectedIndexChanged
        screen1.lab1.Text = ScreenPicker.SelectedItem
        con.Close()
        con.Open()
        cmd = New SqlCommand("select scrid from screen_detail where scrname = '" & ScreenPicker.SelectedItem.ToString & "'", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            Screenid = dr(0)
        Loop

        screen1.SelBillAmount = 0
        txtSelAmount.Text = screen1.SelBillAmount

        GetShowid()

        screen1.Close()

        screen1.TopLevel = False
        screen1.TopMost = True
        Me.SeatLayoutPanel.Controls.Add(screen1)
        screen1.Show()


        ResetSeats()
        FetchPreBookedSeats()

    End Sub

    Public Function GetShowid()
        con.Close()
        con.Open()
        cmd = New SqlCommand("select showid from timetable where movieid = '" & MovieId & "' and date = '" & SelDate & "' and timeid = " & Tid & " and screenid = " & Screenid, con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            Showid = dr(0)
        Loop
        con.Close()
        Return 0
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Home.Show()
        Me.Dispose()
        Me.Hide()
    End Sub


End Class
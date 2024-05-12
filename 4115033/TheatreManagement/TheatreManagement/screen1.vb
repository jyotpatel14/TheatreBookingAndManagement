Imports System.Data.SqlClient
Imports System.IO

Public Class screen1

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlClient.SqlDataReader

    'Use 0 based array
    Dim NRow As Integer = 9
    Dim NCol As Integer = 19
    Public BtnArray((NRow + 1) * (NCol + 1) - 1) As PictureBox
    Dim rowIndex(10) As Label
    Dim colIndex(20) As Label
    Public seatcollection As New List(Of String)
    Public SelBillAmount As Double

    Dim imagex As Image

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Net\TheatreManagement\TheatreManagement\Database1.mdf;Integrated Security=True"


        Dim labposx As Integer = TableLayoutPanel1.Location.X
        Dim labposy As Integer = TableLayoutPanel1.Location.Y


        lab1.Text = "Screen 1"
        lab1.Location = New System.Drawing.Point(labposx + 495, labposy - 100)

        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent

        'sending back panel 4
        Panel4.SendToBack()



        Dim lineX As Integer
        lineX = labposx - 60
        line1.Location = New Point(lineX, labposy + 5)
        line2.Location = New Point(lineX, labposy + 85)
        line3.Location = New Point(lineX, labposy + 285)

        labPricePremium.Location = New Point(lineX + 1200, labposy - 10)
        labPriceGold.Location = New Point(lineX + 1200, labposy + 70)
        labPriceClassic.Location = New Point(lineX + 1200, labposy + 270)





        TableLayoutPanel1.BackColor = Color.Transparent


        'Dim temp As Integer = 0
        'For i As Integer = 1 To rowIndex.Length - 1
        '    Me.rowIndex(i) = New Label()
        '    Me.rowIndex(i).AutoSize = True
        '    Me.rowIndex(i).Location = New System.Drawing.Point(labposx - 40, labposy + 20 + temp)
        '    Me.rowIndex(i).Name = "labRow"
        '    Me.rowIndex(i).Size = New System.Drawing.Size(40, 40)
        '    Me.rowIndex(i).TabIndex = 4
        '    Me.rowIndex(i).Text = Chr(i + 64)
        '    Me.rowIndex(i).BringToFront()
        '    Me.Controls.Add(Me.rowIndex(i))

        '    temp += 56
        'Next
        'temp = 0
        'For i As Integer = 1 To colIndex.Length - 1
        '    Me.colIndex(i) = New Label()
        '    Me.colIndex(i).AutoSize = True
        '    Me.colIndex(i).Location = New System.Drawing.Point(labposx + temp + 15, labposy - 25)
        '    Me.colIndex(i).Name = "labCol"
        '    Me.colIndex(i).Size = New System.Drawing.Size(40, 40)
        '    Me.colIndex(i).TabIndex = 4
        '    Me.colIndex(i).Text = i.ToString()
        '    Me.Controls.Add(Me.colIndex(i))

        '    temp += 56
        'Next

        ' rowlab.Text = "J" & vbNewLine & vbNewLine & vbNewLine & vbNewLine & "I" & vbNewLine & vbNewLine & "H" & vbNewLine & vbNewLine & "G" & vbNewLine & vbNewLine & "F" & vbNewLine & vbNewLine & "E" & vbNewLine & vbNewLine & "D" & vbNewLine & vbNewLine & "C" & vbNewLine & vbNewLine & "B" & vbNewLine & vbNewLine & "A"
        Dim xchr As Integer = 75
        Me.rowlab.Location = New System.Drawing.Point(labposx - 40, labposy + 25)
        'For i As Integer = 1 To 10
        '    xchr -= 1
        '    rowlab.Text = rowlab.Text & Chr(xchr) & vbCrLf & vbCrLf & vbCrLf & vbCrLf
        'Next
        Me.collab.Location = New System.Drawing.Point(labposx + 20, labposy - 40)
        Dim xspa As String = "               "
        'collab.Text = "1  " & xspa & "2   " & xspa & "3   " & xspa & "4   " & xspa & "5   " & xspa & "6   " & xspa & "7   " & xspa & "8   " & xspa & "9" & xspa & "10" & xspa & xspa & "11" & xspa & "12" & xspa & " 13" & xspa & "14" & xspa & "15" & xspa & "16" & xspa & "17 " & xspa & "18" & xspa & "19" & xspa & "20"


        'seat counter
        Dim rowChar As Integer = 74
        Dim countCol As Integer = 0


        'seat picture box creater
        For i As Integer = 0 To BtnArray.Length - 1
            BtnArray(i) = New PictureBox()

            CType(Me.BtnArray(i), System.ComponentModel.ISupportInitialize).BeginInit()
            BtnArray(i).Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

            Me.BtnArray(i).BackColor = System.Drawing.SystemColors.Control
            Me.BtnArray(i).BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.BtnArray(i).Image = Global.TheatreManagement.My.Resources.Resources._50white_armchair


            con.Close()
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text


            If i < 20 Then
                Me.BtnArray(i).Image = My.Resources._50red_armchair
                cmd.CommandText = "update seat_detail set type = 'premium' where sid = " & i & ";"
            ElseIf i < 80 Then
                Me.BtnArray(i).Image = My.Resources._50yellow_armchair
                cmd.CommandText = "update seat_detail set type = 'gold' where sid = " & i & ";"
            Else
                cmd.CommandText = "update seat_detail set type = 'classic' where sid = " & i & ";"
            End If

            cmd.ExecuteNonQuery()

            Me.BtnArray(i).Name = "seat " & Chr(rowChar) & (countCol + 1).ToString()

            seatcollection.Add("seat " & Chr(rowChar) & (countCol + 1).ToString())

            Me.BtnArray(i).Size = New System.Drawing.Size(50, 50)
            Me.BtnArray(i).Padding = New System.Windows.Forms.Padding(5, 10, 10, 5)

            Me.BtnArray(i).SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
            'Me.BtnArray(i).BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.BtnArray(i).TabIndex = 1
            Me.BtnArray(i).TabStop = False

            Me.BtnArray(i).BackColor = Color.Transparent



            countCol += 1
            If countCol = 20 Then
                rowChar -= 1
                countCol = 0
            End If



            TableLayoutPanel1.Controls.Add(BtnArray(i), i Mod (NCol + 1), i \ (NCol + 1))
            'addhandler btnarray(i).click, addressof clickhandler
            AddHandler BtnArray(i).MouseDown, AddressOf TableLayoutPanel1_MouseDown

        Next



    End Sub

    Public seatselected As New List(Of String)
    Public SelSeatid As New List(Of Integer)
    Dim selectedPicBox As New List(Of PictureBox)
    Dim msg As String
    Public PremiumSelSeats As String = "Premium - "
    Public CountPremium As Integer = 0
    Public GoldSelSeats As String = "Gold - "
    Public CountGold As Integer = 0
    Public ClassicSelSeats As String = "Classic - "
    Public CountClassic As Integer = 0
    Public SelSeats As String
    Public CountSelectedSeats As Integer = 0


    Public bid As Integer

    Public Sub ClickHandler(ByVal sender As Object, ByVal e As _
    System.EventArgs)



        If AreSameImage(CType(sender, PictureBox).Image, Global.TheatreManagement.My.Resources.Resources._50white_armchair) Then


            CType(sender, PictureBox).Image = Global.TheatreManagement.My.Resources.Resources._50pink_armchair

            'seatselected {CType(sender, PictureBox).Name}
            'ReDim Preserve seatselected(seatselected.Length)
            seatselected.Add(CType(sender, PictureBox).Name)

            'ReDim Preserve selectedPicBox(selectedPicBox.Length)
            selectedPicBox.Add(CType(sender, PictureBox))

            CType(sender, PictureBox).Refresh()



            msg = "if"

        Else

            CType(sender, PictureBox).Image = Global.TheatreManagement.My.Resources.Resources._50white_armchair
            CType(sender, PictureBox).Refresh()



            msg = "else"

        End If





        'MsgBox("I am button #" & CType(sender, PictureBox).Name & msg)


    End Sub

    'imagecomparator
    Public Function AreSameImage(ByVal I1 As Image, ByVal I2 As Image) As Boolean
        Dim BM1 As Bitmap = I1
        Dim BM2 As Bitmap = I2
        For X = 0 To BM1.Width - 1
            For y = 0 To BM2.Height - 1
                If BM1.GetPixel(X, y) <> BM2.GetPixel(X, y) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function



    Private Sub btnconf_Click(ByVal sender As Object, ByVal e As _
    System.EventArgs) Handles btnconf.Click
        ClassicSelSeats = "Classic - "
        GoldSelSeats = "Gold - "
        PremiumSelSeats = "Premium - "
        SelSeats = ""

        For i As Integer = 0 To selectedPicBox.Count - 1
            'Dim tempPicBox As PictureBox = Me.Controls.Find(seatselected(i), True)
            'Dim tempPicBox As PictureBox = CallByName(CType(sender, PictureBox), seatselected(i), Microsoft.VisualBasic.CallType.Get, Nothing)
            selectedPicBox(i).Image = My.Resources._50grey_armchair
            Me.selectedPicBox(i).Enabled = False
            con.Close()
            con.Open()
            cmd = New SqlCommand("select type from seat_detail where sname = '" & selectedPicBox(i).Name & "'", con)
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader()
            Do While dr.Read = True
                If dr(0) = "classic" Then
                    ClassicSelSeats += selectedPicBox(i).Name.Remove(0, 5) & " "
                    CountClassic += 1
                ElseIf dr(0) = "gold" Then
                    GoldSelSeats += selectedPicBox(i).Name.Remove(0, 5) & " "
                    CountGold += 1
                ElseIf dr(0) = "premium" Then
                    PremiumSelSeats += selectedPicBox(i).Name.Remove(0, 5) & " "
                    CountPremium += 1
                End If

                SelSeats += selectedPicBox(i).Name.Remove(0, 5) & " "
                CountSelectedSeats += 1
            Loop
            con.Close()

        Next
        'MsgBox(SelSeats & vbNewLine & ClassicSelSeats & vbNewLine & GoldSelSeats & vbNewLine & PremiumSelSeats)


        con.Close()
        con.Open()
        cmd = New SqlCommand("select max(bid) from booking_master", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader()
        Do While dr.Read = True
            bid = dr(0)
        Loop
        PaymentInteraction.Bid = bid
        con.Close()



        showSelection.PhoneNo = showSelection.txtPhoneNo.Text




        PaymentInteraction.Show()
        showSelection.Hide()




    End Sub



    Private Sub TableLayoutPanel1_MouseDown(ByVal sender As Object, ByVal e As _
    MouseEventArgs) Handles TableLayoutPanel1.MouseDown

        If e.Button = MouseButtons.Left Then
            Try

                If AreSameImage(CType(sender, PictureBox).Image, Global.TheatreManagement.My.Resources.Resources._50white_armchair) Or
                    AreSameImage(CType(sender, PictureBox).Image, Global.TheatreManagement.My.Resources.Resources._50red_armchair) Or
                    AreSameImage(CType(sender, PictureBox).Image, Global.TheatreManagement.My.Resources.Resources._50yellow_armchair) Then

                    imagex = CType(sender, PictureBox).Image

                    CType(sender, PictureBox).Image = Global.TheatreManagement.My.Resources.Resources._50blue_armchair
                    'seatselected {CType(sender, PictureBox).Name}
                    'ReDim Preserve seatselected(seatselected.Length)
                    seatselected.Add(CType(sender, PictureBox).Name)



                    'ReDim Preserve selectedPicBox(selectedPicBox.Length)
                    selectedPicBox.Add(CType(sender, PictureBox))
                    CType(sender, PictureBox).Refresh()

                    Dim temptype As String = ""

                    con.Close()
                    con.Open()
                    cmd = New SqlCommand("select type from seat_detail where sname = '" & CType(sender, PictureBox).Name & "'", con)
                    cmd.ExecuteNonQuery()
                    dr = cmd.ExecuteReader
                    Do While dr.Read = True
                        temptype = dr(0)
                    Loop
                    con.Close()
                    If temptype = "premium" Then
                        SelBillAmount += CDbl(labPricePremium.Text.Remove(0, 12))
                    ElseIf temptype = "gold" Then
                        SelBillAmount += CDbl(labPriceGold.Text.Remove(0, 9))
                    ElseIf temptype = "classic" Then
                        SelBillAmount += CDbl(labPriceClassic.Text.Remove(0, 12))
                    End If

                    showSelection.txtSelAmount.Text = SelBillAmount
                    CountSelectedSeats += 1
                    showSelection.txtSeatCount.Text = CountSelectedSeats

                    msg = "if"

                Else
                    CType(sender, PictureBox).Image = imagex

                    CType(sender, PictureBox).Refresh()

                    Dim temptype As String = ""
                    seatselected.Remove(CType(sender, PictureBox).Name)
                    selectedPicBox.Remove(CType(sender, PictureBox))
                    con.Close()
                    con.Open()
                    cmd = New SqlCommand("select type from seat_detail where sname = '" & CType(sender, PictureBox).Name & "'", con)
                    cmd.ExecuteNonQuery()
                    dr = cmd.ExecuteReader
                    Do While dr.Read = True
                        temptype = dr(0)
                    Loop
                    con.Close()
                    If temptype = "premium" Then
                        SelBillAmount -= CDbl(labPricePremium.Text.Remove(0, 12))
                    ElseIf temptype = "gold" Then
                        SelBillAmount -= CDbl(labPriceGold.Text.Remove(0, 9))
                    ElseIf temptype = "classic" Then
                        SelBillAmount -= CDbl(labPriceClassic.Text.Remove(0, 12))
                    End If

                    showSelection.txtSelAmount.Text = SelBillAmount
                    CountSelectedSeats -= 1
                    showSelection.txtSeatCount.Text = CountSelectedSeats

                    msg = "else"
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If



        'If e.Button = MouseButtons.Right Then


        '    CType(sender, PictureBox).Image = imagex
        '    CType(sender, PictureBox).Refresh()
        '    msg = "else"

        '    seatselected.Remove(CType(sender, PictureBox).Name)
        '    selectedPicBox.Remove(CType(sender, PictureBox))

        '    Dim temptype As String = ""
        '    seatselected.Remove(CType(sender, PictureBox).Name)
        '    selectedPicBox.Remove(CType(sender, PictureBox))
        '    con.Close()
        '    con.Open()
        '    cmd = New SqlCommand("select type from seat_detail where sname = '" & CType(sender, PictureBox).Name & "'", con)
        '    cmd.ExecuteNonQuery()
        '    dr = cmd.ExecuteReader
        '    Do While dr.Read = True
        '        temptype = dr(0)
        '    Loop
        '    con.Close()
        '    If temptype = "premium" Then
        '        SelBillAmount -= CDbl(labPricePremium.Text.Remove(0, 12))
        '    ElseIf temptype = "gold" Then
        '        SelBillAmount -= CDbl(labPriceGold.Text.Remove(0, 9))
        '    ElseIf temptype = "classic" Then
        '        SelBillAmount -= CDbl(labPriceClassic.Text.Remove(0, 12))
        '    End If

        '    showSelection.txtSelAmount.Text = SelBillAmount
        '    CountSelectedSeats -= 1
        '    showSelection.txtSeatCount.Text = CountSelectedSeats

        'End If

        Try
            'MsgBox("I am button #" & CType(sender, PictureBox).Name & msg)
        Catch ex As Exception

        End Try


    End Sub


End Class
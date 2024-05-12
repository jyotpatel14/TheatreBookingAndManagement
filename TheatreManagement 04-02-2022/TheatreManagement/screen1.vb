Imports System.Data.SqlClient
Imports System.IO

Public Class screen1

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlClient.SqlDataReader

    'Use 0 based array
    Dim NRow As Integer = 9
    Dim NCol As Integer = 19
    Dim BtnArray((NRow + 1) * (NCol + 1) - 1) As PictureBox
    Dim rowIndex(10) As Label
    Dim colIndex(20) As Label
    Public seatcollection As New List(Of String)

    Dim imagex As Image

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Net\TheatreManagement\TheatreManagement\Database1.mdf;Integrated Security=True"


        Dim labposx As Integer = TableLayoutPanel1.Location.X
        Dim labposy As Integer = TableLayoutPanel1.Location.Y


        lab1.Text = "Screen 1"
        lab1.Location = New System.Drawing.Point(labposx + 495, labposy - 80)

        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent

        'sending back panel 4
        Panel4.SendToBack()



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

        rowlab.Text = ""
        Dim xchr As Integer = 75
        Me.rowlab.Location = New System.Drawing.Point(labposx - 40, labposy + 25)
        For i As Integer = 1 To 10
            xchr -= 1
            rowlab.Text = rowlab.Text & Chr(xchr) & vbCrLf & vbCrLf & vbCrLf & vbCrLf
        Next
        Me.collab.Location = New System.Drawing.Point(labposx + 20, labposy - 25)
        Dim xspa As String = "               "
        collab.Text = "1  " & xspa & "2   " & xspa & "3   " & xspa & "4   " & xspa & "5   " & xspa & "6   " & xspa & "7   " & xspa & "8   " & xspa & "9" & xspa & "10" & xspa & "11" & xspa & "12" & xspa & " 13" & xspa & "14" & xspa & "15" & xspa & "16" & xspa & "17 " & xspa & "18" & xspa & "19" & xspa & "20"


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
            Me.BtnArray(i).Image = Global.TheatreManagement.My.Resources.Resources.armchair


            con.Close()
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text


            If i < 20 Then
                Me.BtnArray(i).Image = My.Resources.red_armchair
                cmd.CommandText = "update seat_detail set type = 'premium' where sid = " & i & ";"
            ElseIf i < 80 Then
                Me.BtnArray(i).Image = My.Resources.yellow_armchair
                cmd.CommandText = "update seat_detail set type = 'gold' where sid = " & i & ";"
            Else
                cmd.CommandText = "update seat_detail set type = 'classic' where sid = " & i & ";"
            End If

            cmd.ExecuteNonQuery()

            Me.BtnArray(i).Name = "seat " & Chr(rowChar) & (countCol + 1).ToString()

            seatcollection.Add("seat " & Chr(rowChar) & (countCol + 1).ToString())

            Me.BtnArray(i).Size = New System.Drawing.Size(50, 50)
            Me.BtnArray(i).Padding = New System.Windows.Forms.Padding(5, 10, 10, 5)

            Me.BtnArray(i).SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
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

    Dim seatselected As New List(Of String)
    Dim selectedPicBox As New List(Of PictureBox)
    Dim msg As String
    Public PremiumSelSeats As String = "Premium - "
    Public GoldSelSeats As String = "Gold - "
    Public ClassicSelSeats As String = "Classic - "
    Public SelSeats As String

    Public Sub ClickHandler(ByVal sender As Object, ByVal e As _
    System.EventArgs)



        If AreSameImage(CType(sender, PictureBox).Image, Global.TheatreManagement.My.Resources.Resources.armchair) Then


            CType(sender, PictureBox).Image = Global.TheatreManagement.My.Resources.Resources.pink_armchair

            'seatselected {CType(sender, PictureBox).Name}
            'ReDim Preserve seatselected(seatselected.Length)
            seatselected.Add(CType(sender, PictureBox).Name)

            'ReDim Preserve selectedPicBox(selectedPicBox.Length)
            selectedPicBox.Add(CType(sender, PictureBox))

            CType(sender, PictureBox).Refresh()

            msg = "if"

        Else

            CType(sender, PictureBox).Image = Global.TheatreManagement.My.Resources.Resources.armchair
            CType(sender, PictureBox).Refresh()

            msg = "else"

        End If





        MsgBox("I am button #" & CType(sender, PictureBox).Name & msg)


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
            selectedPicBox(i).Image = My.Resources.grey_armchair
            Me.selectedPicBox(i).Enabled = False
            con.Close()
            con.Open()
            cmd = New SqlCommand("select type from seat_detail where sname = '" & selectedPicBox(i).Name & "'", con)
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader()
            Do While dr.Read = True
                If dr(0) = "classic" Then
                    ClassicSelSeats += selectedPicBox(i).Name.Remove(0, 5) & " "
                ElseIf dr(0) = "gold" Then
                    GoldSelSeats += selectedPicBox(i).Name.Remove(0, 5) & " "
                ElseIf dr(0) = "premium" Then
                    PremiumSelSeats += selectedPicBox(i).Name.Remove(0, 5) & " "
                End If

                SelSeats += selectedPicBox(i).Name.Remove(0, 5) & " "

            Loop
            con.Close()

        Next
        MsgBox(SelSeats & vbNewLine & ClassicSelSeats & vbNewLine & GoldSelSeats & vbNewLine & PremiumSelSeats)


    End Sub



    Private Sub TableLayoutPanel1_MouseDown(ByVal sender As Object, ByVal e As _
    MouseEventArgs) Handles TableLayoutPanel1.MouseDown

        If e.Button = MouseButtons.Left Then
            Try

                If AreSameImage(CType(sender, PictureBox).Image, Global.TheatreManagement.My.Resources.Resources.armchair) Or
                    AreSameImage(CType(sender, PictureBox).Image, Global.TheatreManagement.My.Resources.Resources.red_armchair) Or
                    AreSameImage(CType(sender, PictureBox).Image, Global.TheatreManagement.My.Resources.Resources.yellow_armchair) Then

                    imagex = CType(sender, PictureBox).Image

                    CType(sender, PictureBox).Image = Global.TheatreManagement.My.Resources.Resources.blue_armchair
                    'seatselected {CType(sender, PictureBox).Name}
                    'ReDim Preserve seatselected(seatselected.Length)
                    seatselected.Add(CType(sender, PictureBox).Name)



                    'ReDim Preserve selectedPicBox(selectedPicBox.Length)
                    selectedPicBox.Add(CType(sender, PictureBox))
                    CType(sender, PictureBox).Refresh()
                    msg = "if"

                Else
                    CType(sender, PictureBox).Image = imagex

                    CType(sender, PictureBox).Refresh()

                    seatselected.Remove(CType(sender, PictureBox).Name)
                    selectedPicBox.Remove(CType(sender, PictureBox))

                    msg = "else"
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If



        If e.Button = MouseButtons.Right Then


            CType(sender, PictureBox).Image = imagex
            CType(sender, PictureBox).Refresh()
            msg = "else"

            seatselected.Remove(CType(sender, PictureBox).Name)
            selectedPicBox.Remove(CType(sender, PictureBox))

        End If

        Try
            MsgBox("I am button #" & CType(sender, PictureBox).Name & msg)
        Catch ex As Exception

        End Try


    End Sub


End Class
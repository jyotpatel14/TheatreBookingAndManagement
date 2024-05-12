Imports System.Data.SqlClient
Imports System.IO

Public Class timetableupdate

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlClient.SqlDataReader

    Dim showid, screenid, timeid As Integer
    Dim movieid, dt As String


    Private Sub timetableupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1time_details.time_detail' table. You can move, or remove it, as needed.
        Me.Time_detailTableAdapter.Fill(Me.Database1time_details.time_detail)
        'TODO: This line of code loads data into the 'Database1DataSet.screen_detail' table. You can move, or remove it, as needed.
        Me.Screen_detailTableAdapter.Fill(Me.Database1DataSet.screen_detail)
        'TODO: This line of code loads data into the 'Database1MovieList.movie_master' table. You can move, or remove it, as needed.
        Me.Movie_masterTableAdapter.Fill(Me.Database1MovieList.movie_master)

        Me.AutoScroll = True
        DataGridView1.AutoSize = False

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd-MMM-yyyy"


        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Net\TheatreManagement\TheatreManagement\Database1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Display_data()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_newShowid.Click
        con.Close()
        con.Open()
        cmd = New SqlCommand("select max(showid) from timetable", con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            TextBox1.Text = dr(0) + 1
        End If
    End Sub



    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Enter Numeric Show Id")
            Exit Sub
        End If
        con.Close()
        con.Open()
        cmd = New SqlCommand("delete from timetable where showid = " & CInt(TextBox1.Text), con)
        cmd.ExecuteNonQuery()

        con.Close()
        Display_data()

    End Sub

    Public Sub Display_data()
        con.Close()
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from timetable"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Movie_masterTableAdapter.FillBy(Me.Database1MovieList.movie_master)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        con.Close()
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        'read mid
        con.Close()
        con.Open()
        cmd.CommandText = "select mid from movie_master where mname = '" & ComboBox1.Text & "'"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        dr.Read()
        movieid = dr.Item(0)

        'read screenid
        con.Close()
        con.Open()
        cmd.CommandText = "select scrid from screen_detail where scrname = '" & ComboBox2.Text & "'"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        dr.Read()
        screenid = dr.Item(0)

        'read timeid
        con.Close()
        con.Open()
        cmd.CommandText = "select tid from time_detail where time = '" & ComboBox3.Text & "'"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        dr.Read()
        timeid = dr.Item(0)


        dt = DateTimePicker1.Value.Date.ToString("dd-MMM-yyyy").ToUpper
        Try


            con.Close()
            con.Open()
            cmd.CommandText = "insert into timetable values('" & TextBox1.Text & "','" & movieid & "'," & screenid & ",'" & dt & "'," & timeid & ")"
            cmd.ExecuteNonQuery()



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        MsgBox(movieid & screenid & dt & timeid)

        Display_data()
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.IO


Public Class movielistupdate

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlClient.SqlDataReader

    Dim mid As String = ""
    Dim i As Integer = 1



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1MovieList.movie_master' table. You can move, or remove it, as needed.
        Me.Movie_masterTableAdapter.Fill(Me.Database1MovieList.movie_master)
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Net\TheatreManagement\TheatreManagement\Database1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        ''fetching mid
        'con.Close()
        'cmd = con.CreateCommand()
        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = "select max(mid) from movie_master"
        'con.Open()
        'cmd.ExecuteNonQuery()
        'dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        'Try
        '    mid = dr.GetString(1).ToString()
        'Catch ex As Exception
        'End Try
        Display_data()

        GrpUpdate.Visible = False
        GrpUpdate.Location = GrpInsert.Location
        GrpDelete.Visible = False
        GrpDelete.Location = GrpInsert.Location

        cmbupdstatus.SelectedIndex = 0
        FillDelCombo()

        cmbdelname.SelectedIndex = 0
        cmbdelmid.SelectedIndex = 0

    End Sub

    Public Sub Display_data()
        con.Close()
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from movie_master"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.fill(dt)
        DataGridView1.DataSource = dt
        con.Close()

    End Sub

    Private Sub btnopen_Click(sender As Object, e As EventArgs) Handles btnopen.Click

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub




    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click

        Try


            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into movie_master(mid, mname, duration, cast, description, poster) values('" & TextBox1.Text & "','" & TextBox2.Text & "'," & CInt(TextBox3.Text) & ",'" & TextBox4.Text & "','" & TextBox5.Text & "',@ph)"

            Dim ms As New MemoryStream
            Dim bmpimg As New Bitmap(PictureBox1.Image)
            bmpimg.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer

            Dim p As New SqlParameter("@ph", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            con.Close()
            con.Open()
            cmd.ExecuteNonQuery()

            MsgBox("Insert Successful...")
            con.Close()

            Display_data()

        Catch ex As Exception
            MsgBox("Insert Not Successful : Error " & ex.ToString())
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Close()
        con.Open()
        cmd = New SqlCommand("select max(mid) from movie_master", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Dim tempmaxid As String = ""
        Do While dr.Read = True
            tempmaxid = dr(0)
        Loop
        TextBox1.Text = "M" & CInt(tempmaxid.Remove(0, 1)) + 1
        con.Close()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click



        If txtupdname.Text IsNot "" Then
            con.Close()
            con.Open()
            cmd = New SqlCommand("update movie_master set mname = '" & txtupdname.Text & "' where mid = '" & txtupdmid.Text, con)
            cmd.ExecuteNonQuery()
            con.Close()
        End If
        If txtupdduration.Text IsNot "" Then
            con.Close()
            con.Open()
            cmd = New SqlCommand("update movie_master set duration = '" & txtupdduration.Text & "' where mid = '" & txtupdmid.Text & "'", con)
            cmd.ExecuteNonQuery()
            con.Close()
        End If
        If txtupdcast.Text IsNot "" Then
            con.Close()
            con.Open()
            cmd = New SqlCommand("update movie_master set cast = '" & txtupdcast.Text & "' where mid = '" & txtupdmid.Text & "'", con)
            cmd.ExecuteNonQuery()
            con.Close()
        End If
        If txtupddescription.Text IsNot "" Then
            con.Close()
            con.Open()
            cmd = New SqlCommand("update movie_master set description = '" & txtupddescription.Text & "' where mid = '" & txtupdmid.Text & "'", con)
            cmd.ExecuteNonQuery()
            con.Close()
        End If
        If cmbupdstatus.SelectedItem IsNot "" Or cmbupdstatus.SelectedItem IsNot "None" Then
            con.Close()
            con.Open()
            cmd = New SqlCommand("update movie_master set status = '" & cmbupdstatus.SelectedItem & "' where mid = '" & txtupdmid.Text & "'", con)
            cmd.ExecuteNonQuery()
            con.Close()
        End If


        If radupdimg.Checked = True Then

            con.Close()
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update movie_master set poster = @ph where mid = '" & txtupdmid.Text & "'"


            Dim ms As New MemoryStream
            Dim bmpimg As New Bitmap(PictureBox1.Image)
            bmpimg.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer

            Dim p As New SqlParameter("@ph", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        End If




        MsgBox("Update Complete...")
        Display_data()
        radupdimg.Checked = False
        cmbupdstatus.SelectedIndex = 0


    End Sub

    Private Sub btnMinsert_Click(sender As Object, e As EventArgs) Handles btnMinsert.Click
        GrpInsert.Visible = True
        GrpUpdate.Visible = False
        GrpDelete.Visible = False
    End Sub

    Private Sub btnMupdate_Click(sender As Object, e As EventArgs) Handles btnMupdate.Click
        GrpInsert.Visible = False
        GrpUpdate.Visible = True
        GrpDelete.Visible = False
        GrpUpdate.Location = GrpInsert.Location
    End Sub

    Private Sub btnMdelete_Click(sender As Object, e As EventArgs) Handles btnMdelete.Click
        GrpInsert.Visible = False
        GrpUpdate.Visible = False
        GrpDelete.Visible = True
        GrpDelete.Location = GrpInsert.Location
    End Sub

    Private Sub btnupdopen_Click(sender As Object, e As EventArgs) Handles btnupdopen.Click

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        con.Close()
        con.Open()
        cmd = New SqlCommand("delete from movie_master where mid = '" & cmbdelmid.Items(cmbdelmid.SelectedIndex).ToString & "'", con)
        cmd.ExecuteNonQuery()

        con.Close()


        FillDelCombo()
        Display_data()

    End Sub

    Private Sub cmbdelmid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdelmid.SelectedIndexChanged
        cmbdelname.SelectedIndex = cmbdelmid.SelectedIndex
        Dim temp As String = " "
        temp = cmbdelmid.Items(cmbdelmid.SelectedIndex).ToString
        con.Close()
        con.Open()

        cmd = New SqlCommand("select * from movie_master where mid = '" & temp & "'", con)
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        delgridview.DataSource = dt
        con.Close()
    End Sub

    Private Sub cmddelname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdelname.SelectedIndexChanged
        cmbdelmid.SelectedIndex = cmbdelname.SelectedIndex
        Dim temp As String = " "
        temp = cmbdelname.Items(cmbdelname.SelectedIndex).ToString
        con.Close()
        con.Open()

        cmd = New SqlCommand("select * from movie_master where mname = '" & temp & "'", con)
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        delgridview.DataSource = dt
        con.Close()
    End Sub

    Public Function FillDelCombo()

        con.Close()
        con.Open()
        cmd = New SqlCommand("select mid from movie_master", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        cmbdelmid.Items.Clear()
        Do While dr.Read = True
            cmbdelmid.Items.Add(dr(0))
        Loop
        con.Close()
        con.Open()
        cmd = New SqlCommand("select mname from movie_master", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        cmbdelname.Items.Clear()
        Do While dr.Read = True
            cmbdelname.Items.Add(dr(0))
        Loop
        con.Close()
        Return 0
    End Function


End Class
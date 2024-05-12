Imports System.Data.SqlClient
Imports System.IO


Public Class movielistupdate

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlClient.SqlDataReader

    Dim mid As String = ""
    Dim i As Integer = 1



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub

    Private Sub btnopen_Click(sender As Object, e As EventArgs) Handles btnopen.Click

        Me.PictureBox1.Size = New System.Drawing.Size(200, 350)

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
End Class
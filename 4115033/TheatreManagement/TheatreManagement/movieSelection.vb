Imports System.Data.SqlClient
Imports System.IO

Public Class movieSelection

    Dim selectedMovie As String = ""


    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlClient.SqlDataReader

    Dim username As String
    Dim adminstatus As Boolean

    Dim NRow As Integer = 2
    Dim NCol As Integer = 5
    Dim BtnArray((NRow + 1) * (NCol + 1) - 1) As PictureBox
    'Dim movielinks As String() = {"https://tinyurl.com/mvkcfsz7", "https://tinyurl.com/4yandwh5", "https://tinyurl.com/yckpu8av", "https://tinyurl.com/2p899kcf", "https://tinyurl.com/442xe4y4", "https://tinyurl.com/4r374ss2", "https://tinyurl.com/yc7wvnn9", "https://tinyurl.com/yturjm93"}

    Private Sub movieSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Net\TheatreManagement\TheatreManagement\Database1.mdf;Integrated Security=True"

        'cmd = New SqlCommand("Select Student_Name from student", con)
        'Dim data As DataSet = New DataSet()
        'Dim dataAdp As New SqlDataAdapter()
        'dataAdp.SelectCommand = cmd
        'dataAdp.Fill(data, "Student_Name")
        'Dim datable As DataTable = data.Tables("Student_Name")
        'For x = 0 To datable.Rows.Count - 1
        '    ComboBox1.Items.Add(datable.Rows(x).Item("Student_Name"))
        'Next

        Me.AutoScroll = False
        Me.HorizontalScroll.Enabled = False
        Me.HorizontalScroll.Visible = False
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True


        con.Close()
        con.Open()

        cmd = New SqlCommand("select poster,mname from movie_master where status = 'Active'", con)
        Dim data As DataSet = New DataSet()
        Dim dataadp As New SqlDataAdapter()
        dataadp.SelectCommand = cmd
        dataadp.Fill(data, "poster")
        dataadp.Fill(data, "mname")
        Dim postertable As DataTable = data.Tables("poster")
        Dim nametable As DataTable = data.Tables("mname")

        'con.Close()
        'con.Open()
        'cmd.ExecuteNonQuery()

        'dr = cmd.ExecuteReader

        For i As Integer = 0 To postertable.Rows.Count - 1

            Dim dataimage As Byte() = DirectCast(postertable.Rows(i).Item("poster"), Byte())
            Dim ms As New MemoryStream(dataimage)
            Dim img As Image = Image.FromStream(ms)
            Dim mname As String = nametable.Rows(i).Item("mname")

            con.Close()
            BtnArray(i) = New PictureBox()

            CType(Me.BtnArray(i), System.ComponentModel.ISupportInitialize).BeginInit()
            BtnArray(i).Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

            Me.BtnArray(i).BackColor = System.Drawing.SystemColors.Control
            Me.BtnArray(i).BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            'Me.BtnArray(i).Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(movielinks(i))))
            Me.BtnArray(i).Image = img
            Me.BtnArray(i).SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage

            'Me.BtnArray(i).Name = movielinks(i)
            Me.BtnArray(i).Size = New System.Drawing.Size(300, 500)
            Me.BtnArray(i).Padding = New System.Windows.Forms.Padding(5, 10, 10, 5)

            'Me.BtnArray(i).SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.BtnArray(i).TabIndex = 1
            Me.BtnArray(i).TabStop = False
            Me.BtnArray(i).Name = mname

            Me.BtnArray(i).BackColor = Color.Transparent


            TableLayoutPanel1.Controls.Add(BtnArray(i), i Mod (NCol + 1), i \ (NCol + 1))
            'AddHandler BtnArray(i).Click, AddressOf ClickHandler
            AddHandler BtnArray(i).MouseDown, AddressOf TableLayoutPanel1_MouseDown

        Next

        'cmd = New SqlCommand("select admin from login_details where username = '" & loginform.txtuser.Text & "'", con)

        'con.Close()
        'con.Open()
        'cmd.ExecuteNonQuery()
        'dr = cmd.ExecuteReader()
        'adminstatus = dr.Read()
        'con.Close()



    End Sub

    Private Sub TableLayoutPanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel1.MouseDown

        Try

            'MsgBox(CType(sender, PictureBox).Name)

            showSelection.title = CType(sender, PictureBox).Name


        Catch ex As Exception

        End Try


        showSelection.Show()
        Home.Hide()


    End Sub


End Class
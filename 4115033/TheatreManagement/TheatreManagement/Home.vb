Imports System.Data.SqlClient
Imports System.IO

Public Class Home

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlClient.SqlDataReader


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Net\TheatreManagement\TheatreManagement\Database1.mdf;Integrated Security=True"


        movieSelection.TopLevel = False
        movieSelection.TopMost = True
        Me.Panel1.Controls.Add(movieSelection)
        movieSelection.Show()

        admpopup.Location = New System.Drawing.Point(1930, 55)

        'Panel1.AutoScroll = False
        'Panel1.HorizontalScroll.Enabled = False
        'Panel1.HorizontalScroll.Visible = False
        'Panel1.HorizontalScroll.Maximum = 0
        'Panel1.AutoScroll = True





        'working code

        If loginform.adminstatus = "True" Then
            btnemplogoff.Visible = False
            adminButton.Visible = True

        Else
            adminButton.Visible = False
            btnemplogoff.Visible = True
        End If
        'adminButton.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles adminButton.Click


        Timer1.Start()
        admpopup.Visible = True



    End Sub


    Private Sub btnadmint_Click(sender As Object, e As EventArgs) Handles btnadmint.Click
        admininterface.Show()
        admpopup.Location = New System.Drawing.Point(1930, 55)
        admpopup.Visible = False
        Me.Hide()
    End Sub

    Private Sub btnlogoff_Click(sender As Object, e As EventArgs) Handles btnlogoff.Click
        loginform.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        admpopup.Location = New System.Drawing.Point(admpopup.Location.X - 1, 55)
        If admpopup.Location.X = 1710 Then
            Timer1.Stop()
        End If

    End Sub

    Private Sub btnemplogoff_Click(sender As Object, e As EventArgs) Handles btnemplogoff.Click
        loginform.Show()
        Me.Close()
    End Sub


End Class
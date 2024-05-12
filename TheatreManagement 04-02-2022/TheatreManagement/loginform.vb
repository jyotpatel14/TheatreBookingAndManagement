Imports System.Data.SqlClient
Imports System.IO



Public Class loginform



    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim usernametable As DataTable
    Public adminstatus As String

    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Net\TheatreManagement\TheatreManagement\Database1.mdf;Integrated Security=True"






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        cmd = New SqlCommand("select username,password from login_details", con)
        Dim data As DataSet = New DataSet()
        Dim dataadp As New SqlDataAdapter()
        dataadp.SelectCommand = cmd
        dataadp.Fill(data, "username")
        dataadp.Fill(data, "password")
        usernametable = data.Tables("username")
        Dim passwordtable As DataTable = data.Tables("password")
        Dim temp As String = txtuser.Text

        'cmd = New SqlCommand("select admin from login_details where username = 'emp'", con)
        con.Close()
        con.Open()
        cmd = New SqlCommand("select admin from login_details where username = '" & txtuser.Text & "'", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader()
        Do While dr.Read = True
            adminstatus = dr(0)
        Loop



        con.Close()


        Dim count As Integer = 0

        If txtuser.Text = "" Then
            MsgBox("Username Empty")
        ElseIf txtpass.Text = "" Then
            MsgBox("Password Empty")
        Else
            For i As Integer = 0 To usernametable.Rows.Count - 1
                Dim username As String = usernametable.Rows(i).Item("username")
                Dim password As String = passwordtable.Rows(i).Item("password")
                If txtuser.Text = username And txtpass.Text = password Then
                    count += 1
                End If

            Next
            If count > 0 Then
                Home.Show()
                Me.Hide()
                count = 0
            Else
                MsgBox("Invalid Credentials")
            End If
        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cmd = New SqlCommand("select username from login_details", con)
        Dim data As DataSet = New DataSet()
        Dim dataadp As New SqlDataAdapter()
        dataadp.SelectCommand = cmd
        dataadp.Fill(data, "username")
        usernametable = data.Tables("username")

        Dim count As Integer = 0

        For i As Integer = 0 To usernametable.Rows.Count - 1
            If txtuser.Text = usernametable.Rows(i).Item("username") Then
                count += 1
            End If
        Next
        If count > 0 Then
            MsgBox("Username Already Exists")
            count = 0
        Else
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into login_details(username,password) values('" & txtuser.Text & "','" & txtpass.Text & "')"

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            Dim result As DialogResult = MessageBox.Show("Is this an Admin Signup?",
                              "Admin Confirmation",
                              MessageBoxButtons.YesNo)

            If (result = DialogResult.Yes) Then

                cmd.CommandText = "update login_details set admin = 'True' where username = '" & txtuser.Text & "'"

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MsgBox("Admin Sign Up Sucessful")

            Else
                MsgBox("Employee Sign Up Sucessful")
            End If



        End If






    End Sub
End Class
Imports System.Data.SqlClient
Imports System.IO

Public Class movieSeatCostUpdate

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlClient.SqlDataReader

    Dim mid As String
    Dim classicCost, goldCost, premiumCost As Double

    Private Sub movieSeatCostUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Net\TheatreManagement\TheatreManagement\Database1.mdf;Integrated Security=True"


        con.Close()
        con.Open()

        cmd = New SqlCommand("select mname from movie_master", con)

        dr = cmd.ExecuteReader
        Do While dr.Read = True
            ComboBox1.Items.Add(dr(0))
        Loop
        con.Close()
        con.Open()

        cmd = New SqlCommand("select mid from movie_seat_cost", con)

        dr = cmd.ExecuteReader
        Do While dr.Read = True
            ComboBox2.Items.Add(dr(0))
        Loop
        con.Close()

        Display_Data()


    End Sub

    Private Sub Display_Data()
        con.Close()
        con.Open()
        cmd = New SqlCommand("select * from movie_seat_cost", con)
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt



    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        con.Close()
        con.Open()


        If txtClassic.Text <> "" Then
            con.Close()
            con.Open()
            cmd = New SqlCommand("update movie_seat_cost set classic = " & txtClassicupd.Text & " where mid = '" & mid & "'", con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Update Sucessful...")
        End If
        If txtGold.Text <> "" Then
            con.Close()
            con.Open()
            cmd = New SqlCommand("update movie_seat_cost gold = " & txtGoldupd.Text & " where mid = '" & mid & "'", con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Update Sucessful...")
        End If
        If txtPremium.Text <> "" Then
            con.Close()
            con.Open()
            cmd = New SqlCommand("update movie_seat_cost set premium = " & txtPremiumupd.Text & " where mid = '" & mid & "'", con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Update Sucessful...")
        End If


        Display_Data()


    End Sub



    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        con.Close()
        con.Open()
        cmd = New SqlCommand("select mid from movie_master where mname = '" & ComboBox2.Text & "'", con)
        dr = cmd.ExecuteReader()
        If dr.Read = True Then
            mid = dr(0)
        End If
        con.Close()

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        If txtClassic.Text = "" Or txtGold.Text = "" Or txtPremium.Text = "" Then
            MsgBox("Value Required")
        Else
            con.Close()
            con.Open()
            cmd = New SqlCommand("insert into movie_seat_cost values('" & mid & "'," & txtClassic.Text & "," & txtGold.Text & "," & txtPremium.Text & ")", con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Insert Sucessful")
        End If

        Display_Data()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        con.Close()
        con.Open()
        cmd = New SqlCommand("select mid from movie_master where mname = '" & ComboBox1.SelectedItem & "'", con)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader()
        Do While dr.Read = True
            mid = dr(0)
        Loop
        con.Close()
        MsgBox(mid)
    End Sub


End Class
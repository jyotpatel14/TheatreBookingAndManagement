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


        'TODO: This line of code loads data into the 'Database1DataSet1.movie_master' table. You can move, or remove it, as needed.
        Me.Movie_masterTableAdapter.Fill(Me.Database1DataSet1.movie_master)

        cmd = New SqlCommand("select mname from movie_master", con)
        Dim data As DataSet = New DataSet()
        Dim dataadp As New SqlDataAdapter()
        dataadp.SelectCommand = cmd
        dataadp.Fill(data, "mname")
        Dim movienametable As DataTable = data.Tables("mname")

        For i As Integer = 0 To movienametable.Rows.Count - 1

            ComboBox1.Items.Add(movienametable.Rows(i).Item("mname"))

        Next




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
Imports System.Data.SqlClient


Public Class adminconsole

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand


    Public Sub Display_data()
        con.Close()
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = TextBox1.Text
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub adminconcole_Load(sender As Object, e As EventArgs) Handles Me.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Net\TheatreManagement\TheatreManagement\Database1.mdf;Integrated Security=True"



        'creating seat table
        'For i As Integer = 0 To screen1.seatcollection.Count - 1
        '    con.Close()
        '    con.Open()
        '    cmd = con.CreateCommand()
        '    Dim temp As String = screen1.seatcollection.Item(i)
        '    cmd.CommandType = CommandType.Text
        '    cmd.CommandText = "insert into seat_detail values(" & Chr(39) & i & Chr(39) & ", " & Chr(39) & temp & Chr(39) & ")"
        '    cmd.ExecuteNonQuery()
        'Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Display_data()

    End Sub
End Class
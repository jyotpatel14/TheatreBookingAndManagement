<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class showSelection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSelAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labmovietitle = New System.Windows.Forms.Label()
        Me.btnlist = New System.Windows.Forms.TableLayoutPanel()
        Me.SeatLayoutPanel = New System.Windows.Forms.Panel()
        Me.ScreenPicker = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.TimePicker = New System.Windows.Forms.ComboBox()
        Me.labTimePicker = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSeatCount = New System.Windows.Forms.TextBox()
        Me.labDateTime = New System.Windows.Forms.Label()
        Me.labDescription = New System.Windows.Forms.Label()
        Me.labCast = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SeatLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1940, 50)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.TheatreManagement.My.Resources.Resources.home_outline1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(11, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("PenultimateLight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(57, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("PenultimateLight", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(788, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(327, 32)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Show And Seat Selection"
        '
        'txtSelAmount
        '
        Me.txtSelAmount.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtSelAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSelAmount.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelAmount.Location = New System.Drawing.Point(180, 3)
        Me.txtSelAmount.Name = "txtSelAmount"
        Me.txtSelAmount.ReadOnly = True
        Me.txtSelAmount.Size = New System.Drawing.Size(241, 34)
        Me.txtSelAmount.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Bill Amount : ₹"
        '
        'labmovietitle
        '
        Me.labmovietitle.AutoSize = True
        Me.labmovietitle.Font = New System.Drawing.Font("PenultimateLight", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labmovietitle.Location = New System.Drawing.Point(532, 68)
        Me.labmovietitle.Name = "labmovietitle"
        Me.labmovietitle.Size = New System.Drawing.Size(127, 43)
        Me.labmovietitle.TabIndex = 2
        Me.labmovietitle.Text = "Label1"
        '
        'btnlist
        '
        Me.btnlist.AutoScroll = True
        Me.btnlist.ColumnCount = 1
        Me.btnlist.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.btnlist.Location = New System.Drawing.Point(12, 71)
        Me.btnlist.Name = "btnlist"
        Me.btnlist.RowCount = 10
        Me.btnlist.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.btnlist.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.btnlist.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.btnlist.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.btnlist.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.btnlist.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.btnlist.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.btnlist.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.btnlist.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.btnlist.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.btnlist.Size = New System.Drawing.Size(467, 953)
        Me.btnlist.TabIndex = 3
        '
        'SeatLayoutPanel
        '
        Me.SeatLayoutPanel.AutoSize = True
        Me.SeatLayoutPanel.Controls.Add(Me.txtSelAmount)
        Me.SeatLayoutPanel.Controls.Add(Me.ScreenPicker)
        Me.SeatLayoutPanel.Controls.Add(Me.Label3)
        Me.SeatLayoutPanel.Controls.Add(Me.Label6)
        Me.SeatLayoutPanel.Location = New System.Drawing.Point(516, 269)
        Me.SeatLayoutPanel.Name = "SeatLayoutPanel"
        Me.SeatLayoutPanel.Size = New System.Drawing.Size(1344, 783)
        Me.SeatLayoutPanel.TabIndex = 4
        '
        'ScreenPicker
        '
        Me.ScreenPicker.Font = New System.Drawing.Font("PenultimateLight", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScreenPicker.FormattingEnabled = True
        Me.ScreenPicker.Location = New System.Drawing.Point(932, 3)
        Me.ScreenPicker.Name = "ScreenPicker"
        Me.ScreenPicker.Size = New System.Drawing.Size(316, 33)
        Me.ScreenPicker.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(836, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Screen  : "
        '
        'DatePicker
        '
        Me.DatePicker.Font = New System.Drawing.Font("PenultimateLight", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePicker.Location = New System.Drawing.Point(1448, 119)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(316, 34)
        Me.DatePicker.TabIndex = 2
        '
        'TimePicker
        '
        Me.TimePicker.Font = New System.Drawing.Font("PenultimateLight", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimePicker.FormattingEnabled = True
        Me.TimePicker.Location = New System.Drawing.Point(1448, 159)
        Me.TimePicker.Name = "TimePicker"
        Me.TimePicker.Size = New System.Drawing.Size(316, 33)
        Me.TimePicker.TabIndex = 5
        '
        'labTimePicker
        '
        Me.labTimePicker.AutoSize = True
        Me.labTimePicker.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTimePicker.Location = New System.Drawing.Point(1352, 162)
        Me.labTimePicker.Name = "labTimePicker"
        Me.labTimePicker.Size = New System.Drawing.Size(71, 25)
        Me.labTimePicker.TabIndex = 6
        Me.labTimePicker.Text = "Time  : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1352, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mobile No. : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1352, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "No. Of Seats : "
        '
        'txtSeatCount
        '
        Me.txtSeatCount.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtSeatCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeatCount.Font = New System.Drawing.Font("PenultimateLight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeatCount.Location = New System.Drawing.Point(1494, 198)
        Me.txtSeatCount.Name = "txtSeatCount"
        Me.txtSeatCount.ReadOnly = True
        Me.txtSeatCount.Size = New System.Drawing.Size(270, 33)
        Me.txtSeatCount.TabIndex = 7
        '
        'labDateTime
        '
        Me.labDateTime.AutoSize = True
        Me.labDateTime.Font = New System.Drawing.Font("PenultimateLight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDateTime.Location = New System.Drawing.Point(534, 116)
        Me.labDateTime.Name = "labDateTime"
        Me.labDateTime.Size = New System.Drawing.Size(89, 32)
        Me.labDateTime.TabIndex = 9
        Me.labDateTime.Text = "Label4"
        '
        'labDescription
        '
        Me.labDescription.Font = New System.Drawing.Font("PenultimateLight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDescription.Location = New System.Drawing.Point(534, 153)
        Me.labDescription.Name = "labDescription"
        Me.labDescription.Size = New System.Drawing.Size(800, 35)
        Me.labDescription.TabIndex = 10
        Me.labDescription.Text = "Description :"
        '
        'labCast
        '
        Me.labCast.Font = New System.Drawing.Font("PenultimateLight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCast.Location = New System.Drawing.Point(534, 191)
        Me.labCast.Name = "labCast"
        Me.labCast.Size = New System.Drawing.Size(800, 35)
        Me.labCast.TabIndex = 11
        Me.labCast.Text = "Cast :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1352, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date : "
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhoneNo.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.Location = New System.Drawing.Point(1483, 80)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(281, 34)
        Me.txtPhoneNo.TabIndex = 12
        Me.txtPhoneNo.Text = "+91 "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("PenultimateLight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(142, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 21)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Select Show Details .. !!!"
        '
        'showSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.txtPhoneNo)
        Me.Controls.Add(Me.labCast)
        Me.Controls.Add(Me.labDescription)
        Me.Controls.Add(Me.labDateTime)
        Me.Controls.Add(Me.txtSeatCount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labTimePicker)
        Me.Controls.Add(Me.TimePicker)
        Me.Controls.Add(Me.DatePicker)
        Me.Controls.Add(Me.btnlist)
        Me.Controls.Add(Me.SeatLayoutPanel)
        Me.Controls.Add(Me.labmovietitle)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "showSelection"
        Me.Text = "Show Selection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SeatLayoutPanel.ResumeLayout(False)
        Me.SeatLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents labmovietitle As Label
    Friend WithEvents btnlist As TableLayoutPanel
    Friend WithEvents SeatLayoutPanel As Panel
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents TimePicker As ComboBox
    Friend WithEvents labTimePicker As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSeatCount As TextBox
    Friend WithEvents ScreenPicker As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents labDateTime As Label
    Friend WithEvents labDescription As Label
    Friend WithEvents labCast As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSelAmount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

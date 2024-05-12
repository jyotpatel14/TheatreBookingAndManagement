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
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.btnSettingsConfirm = New System.Windows.Forms.PictureBox()
        Me.btnSeatCountReset = New System.Windows.Forms.PictureBox()
        Me.btnSeatCountAdd = New System.Windows.Forms.PictureBox()
        Me.btnSeatCountSub = New System.Windows.Forms.PictureBox()
        Me.labDateTime = New System.Windows.Forms.Label()
        Me.labDescription = New System.Windows.Forms.Label()
        Me.labCast = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.SeatLayoutPanel.SuspendLayout()
        CType(Me.btnSettingsConfirm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSeatCountReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSeatCountAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSeatCountSub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1904, 50)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("PenultimateLight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(73, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'labmovietitle
        '
        Me.labmovietitle.AutoSize = True
        Me.labmovietitle.Font = New System.Drawing.Font("PenultimateLight", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labmovietitle.Location = New System.Drawing.Point(534, 90)
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
        Me.SeatLayoutPanel.Controls.Add(Me.ScreenPicker)
        Me.SeatLayoutPanel.Controls.Add(Me.Label3)
        Me.SeatLayoutPanel.Location = New System.Drawing.Point(516, 269)
        Me.SeatLayoutPanel.Name = "SeatLayoutPanel"
        Me.SeatLayoutPanel.Size = New System.Drawing.Size(1344, 783)
        Me.SeatLayoutPanel.TabIndex = 4
        '
        'ScreenPicker
        '
        Me.ScreenPicker.Font = New System.Drawing.Font("PenultimateLight", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScreenPicker.FormattingEnabled = True
        Me.ScreenPicker.Location = New System.Drawing.Point(934, 22)
        Me.ScreenPicker.Name = "ScreenPicker"
        Me.ScreenPicker.Size = New System.Drawing.Size(316, 33)
        Me.ScreenPicker.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(838, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Screen  : "
        '
        'DatePicker
        '
        Me.DatePicker.Font = New System.Drawing.Font("PenultimateLight", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePicker.Location = New System.Drawing.Point(1450, 95)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(316, 34)
        Me.DatePicker.TabIndex = 2
        '
        'TimePicker
        '
        Me.TimePicker.Font = New System.Drawing.Font("PenultimateLight", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimePicker.FormattingEnabled = True
        Me.TimePicker.Location = New System.Drawing.Point(1450, 135)
        Me.TimePicker.Name = "TimePicker"
        Me.TimePicker.Size = New System.Drawing.Size(316, 33)
        Me.TimePicker.TabIndex = 5
        '
        'labTimePicker
        '
        Me.labTimePicker.AutoSize = True
        Me.labTimePicker.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTimePicker.Location = New System.Drawing.Point(1354, 138)
        Me.labTimePicker.Name = "labTimePicker"
        Me.labTimePicker.Size = New System.Drawing.Size(71, 25)
        Me.labTimePicker.TabIndex = 6
        Me.labTimePicker.Text = "Time  : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1354, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Date : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1354, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "No. Of Seats :"
        '
        'txtSeatCount
        '
        Me.txtSeatCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeatCount.Font = New System.Drawing.Font("PenultimateLight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeatCount.Location = New System.Drawing.Point(1496, 174)
        Me.txtSeatCount.Name = "txtSeatCount"
        Me.txtSeatCount.Size = New System.Drawing.Size(270, 33)
        Me.txtSeatCount.TabIndex = 7
        '
        'btnSettingsConfirm
        '
        Me.btnSettingsConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnSettingsConfirm.BackgroundImage = Global.TheatreManagement.My.Resources.Resources.checkmark_done_outline
        Me.btnSettingsConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettingsConfirm.Location = New System.Drawing.Point(1687, 213)
        Me.btnSettingsConfirm.Name = "btnSettingsConfirm"
        Me.btnSettingsConfirm.Size = New System.Drawing.Size(72, 72)
        Me.btnSettingsConfirm.TabIndex = 8
        Me.btnSettingsConfirm.TabStop = False
        '
        'btnSeatCountReset
        '
        Me.btnSeatCountReset.BackColor = System.Drawing.Color.White
        Me.btnSeatCountReset.BackgroundImage = Global.TheatreManagement.My.Resources.Resources.refresh_outline
        Me.btnSeatCountReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSeatCountReset.Location = New System.Drawing.Point(1729, 177)
        Me.btnSeatCountReset.Name = "btnSeatCountReset"
        Me.btnSeatCountReset.Size = New System.Drawing.Size(30, 25)
        Me.btnSeatCountReset.TabIndex = 8
        Me.btnSeatCountReset.TabStop = False
        '
        'btnSeatCountAdd
        '
        Me.btnSeatCountAdd.BackColor = System.Drawing.Color.White
        Me.btnSeatCountAdd.BackgroundImage = Global.TheatreManagement.My.Resources.Resources.chevron_up_outline
        Me.btnSeatCountAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSeatCountAdd.Location = New System.Drawing.Point(1657, 177)
        Me.btnSeatCountAdd.Name = "btnSeatCountAdd"
        Me.btnSeatCountAdd.Size = New System.Drawing.Size(30, 25)
        Me.btnSeatCountAdd.TabIndex = 8
        Me.btnSeatCountAdd.TabStop = False
        '
        'btnSeatCountSub
        '
        Me.btnSeatCountSub.BackColor = System.Drawing.Color.White
        Me.btnSeatCountSub.BackgroundImage = Global.TheatreManagement.My.Resources.Resources.chevron_down_outline
        Me.btnSeatCountSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSeatCountSub.Location = New System.Drawing.Point(1693, 177)
        Me.btnSeatCountSub.Name = "btnSeatCountSub"
        Me.btnSeatCountSub.Size = New System.Drawing.Size(30, 25)
        Me.btnSeatCountSub.TabIndex = 8
        Me.btnSeatCountSub.TabStop = False
        '
        'labDateTime
        '
        Me.labDateTime.AutoSize = True
        Me.labDateTime.Font = New System.Drawing.Font("PenultimateLight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDateTime.Location = New System.Drawing.Point(536, 138)
        Me.labDateTime.Name = "labDateTime"
        Me.labDateTime.Size = New System.Drawing.Size(89, 32)
        Me.labDateTime.TabIndex = 9
        Me.labDateTime.Text = "Label4"
        '
        'labDescription
        '
        Me.labDescription.Font = New System.Drawing.Font("PenultimateLight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDescription.Location = New System.Drawing.Point(536, 175)
        Me.labDescription.Name = "labDescription"
        Me.labDescription.Size = New System.Drawing.Size(800, 35)
        Me.labDescription.TabIndex = 10
        Me.labDescription.Text = "Description :"
        '
        'labCast
        '
        Me.labCast.Font = New System.Drawing.Font("PenultimateLight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCast.Location = New System.Drawing.Point(536, 213)
        Me.labCast.Name = "labCast"
        Me.labCast.Size = New System.Drawing.Size(800, 35)
        Me.labCast.TabIndex = 11
        Me.labCast.Text = "Cast :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.TheatreManagement.My.Resources.Resources.home_outline1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 44)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'showSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.labCast)
        Me.Controls.Add(Me.labDescription)
        Me.Controls.Add(Me.labDateTime)
        Me.Controls.Add(Me.btnSettingsConfirm)
        Me.Controls.Add(Me.btnSeatCountReset)
        Me.Controls.Add(Me.btnSeatCountAdd)
        Me.Controls.Add(Me.btnSeatCountSub)
        Me.Controls.Add(Me.txtSeatCount)
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
        Me.SeatLayoutPanel.ResumeLayout(False)
        Me.SeatLayoutPanel.PerformLayout()
        CType(Me.btnSettingsConfirm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSeatCountReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSeatCountAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSeatCountSub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSeatCountSub As PictureBox
    Friend WithEvents btnSeatCountAdd As PictureBox
    Friend WithEvents btnSeatCountReset As PictureBox
    Friend WithEvents btnSettingsConfirm As PictureBox
    Friend WithEvents ScreenPicker As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents labDateTime As Label
    Friend WithEvents labDescription As Label
    Friend WithEvents labCast As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

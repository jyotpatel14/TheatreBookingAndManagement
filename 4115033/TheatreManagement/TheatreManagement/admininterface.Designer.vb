<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admininterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabmovielist = New System.Windows.Forms.TabPage()
        Me.tabtimetable = New System.Windows.Forms.TabPage()
        Me.tabprice = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btndeposit = New System.Windows.Forms.Button()
        Me.btnwithdraw = New System.Windows.Forms.Button()
        Me.txtdes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtvalue = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcounterbalance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1920, 1080)
        Me.Panel2.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabmovielist)
        Me.TabControl1.Controls.Add(Me.tabtimetable)
        Me.TabControl1.Controls.Add(Me.tabprice)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("PenultimateLight", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 53)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1914, 1003)
        Me.TabControl1.TabIndex = 5
        '
        'tabmovielist
        '
        Me.tabmovielist.AutoScroll = True
        Me.tabmovielist.BackColor = System.Drawing.SystemColors.Control
        Me.tabmovielist.Location = New System.Drawing.Point(4, 27)
        Me.tabmovielist.Name = "tabmovielist"
        Me.tabmovielist.Padding = New System.Windows.Forms.Padding(3)
        Me.tabmovielist.Size = New System.Drawing.Size(1906, 972)
        Me.tabmovielist.TabIndex = 0
        Me.tabmovielist.Text = "Movie List"
        '
        'tabtimetable
        '
        Me.tabtimetable.AutoScroll = True
        Me.tabtimetable.BackColor = System.Drawing.SystemColors.Control
        Me.tabtimetable.Location = New System.Drawing.Point(4, 27)
        Me.tabtimetable.Name = "tabtimetable"
        Me.tabtimetable.Padding = New System.Windows.Forms.Padding(3)
        Me.tabtimetable.Size = New System.Drawing.Size(1906, 972)
        Me.tabtimetable.TabIndex = 1
        Me.tabtimetable.Text = "Time Table"
        '
        'tabprice
        '
        Me.tabprice.BackColor = System.Drawing.SystemColors.Control
        Me.tabprice.Location = New System.Drawing.Point(4, 27)
        Me.tabprice.Name = "tabprice"
        Me.tabprice.Padding = New System.Windows.Forms.Padding(3)
        Me.tabprice.Size = New System.Drawing.Size(1906, 972)
        Me.tabprice.TabIndex = 2
        Me.tabprice.Text = "Seat Cost Details"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btndeposit)
        Me.TabPage1.Controls.Add(Me.btnwithdraw)
        Me.TabPage1.Controls.Add(Me.txtdes)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtvalue)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtcounterbalance)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1906, 972)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Cash Counter Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btndeposit
        '
        Me.btndeposit.Location = New System.Drawing.Point(291, 213)
        Me.btndeposit.Name = "btndeposit"
        Me.btndeposit.Size = New System.Drawing.Size(181, 53)
        Me.btndeposit.TabIndex = 2
        Me.btndeposit.Text = "Deposit"
        Me.btndeposit.UseVisualStyleBackColor = True
        '
        'btnwithdraw
        '
        Me.btnwithdraw.Location = New System.Drawing.Point(98, 213)
        Me.btnwithdraw.Name = "btnwithdraw"
        Me.btnwithdraw.Size = New System.Drawing.Size(181, 53)
        Me.btnwithdraw.TabIndex = 2
        Me.btnwithdraw.Text = "Withdraw"
        Me.btnwithdraw.UseVisualStyleBackColor = True
        '
        'txtdes
        '
        Me.txtdes.Location = New System.Drawing.Point(291, 118)
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(249, 28)
        Me.txtdes.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Description :"
        '
        'txtvalue
        '
        Me.txtvalue.Location = New System.Drawing.Point(291, 69)
        Me.txtvalue.Name = "txtvalue"
        Me.txtvalue.Size = New System.Drawing.Size(249, 28)
        Me.txtvalue.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Enter Value :"
        '
        'txtcounterbalance
        '
        Me.txtcounterbalance.Location = New System.Drawing.Point(291, 168)
        Me.txtcounterbalance.Name = "txtcounterbalance"
        Me.txtcounterbalance.Size = New System.Drawing.Size(249, 28)
        Me.txtcounterbalance.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Counter Balance : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "console. movie list update, timetable update, pricing update"
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("PenultimateLight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(260, 100)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 30)
        Me.Button3.TabIndex = 2
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1920, 51)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("PenultimateLightItal", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1733, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 45)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Reports"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.TheatreManagement.My.Resources.Resources.home_outline1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 44)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("PenultimateLight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.TheatreManagement.My.Resources.Resources.home_outline1
        Me.Button1.Location = New System.Drawing.Point(61, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("PenultimateLight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(855, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Admin Interface"
        '
        'admininterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "admininterface"
        Me.Text = "Admin Interface"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabmovielist As TabPage
    Friend WithEvents tabtimetable As TabPage
    Friend WithEvents tabprice As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btndeposit As Button
    Friend WithEvents btnwithdraw As Button
    Friend WithEvents txtdes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtvalue As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcounterbalance As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScreenCreator
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
        Me.txtRow = New System.Windows.Forms.TextBox()
        Me.txtCol = New System.Windows.Forms.TextBox()
        Me.labRow = New System.Windows.Forms.Label()
        Me.labCol = New System.Windows.Forms.Label()
        Me.Conf = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRow
        '
        Me.txtRow.Location = New System.Drawing.Point(114, 27)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.Size = New System.Drawing.Size(100, 20)
        Me.txtRow.TabIndex = 2
        '
        'txtCol
        '
        Me.txtCol.Location = New System.Drawing.Point(268, 27)
        Me.txtCol.Name = "txtCol"
        Me.txtCol.Size = New System.Drawing.Size(100, 20)
        Me.txtCol.TabIndex = 3
        '
        'labRow
        '
        Me.labRow.AutoSize = True
        Me.labRow.Location = New System.Drawing.Point(71, 30)
        Me.labRow.Name = "labRow"
        Me.labRow.Size = New System.Drawing.Size(37, 13)
        Me.labRow.TabIndex = 4
        Me.labRow.Text = "Rows:"
        '
        'labCol
        '
        Me.labCol.AutoSize = True
        Me.labCol.Location = New System.Drawing.Point(232, 30)
        Me.labCol.Name = "labCol"
        Me.labCol.Size = New System.Drawing.Size(27, 13)
        Me.labCol.TabIndex = 5
        Me.labCol.Text = "Cols"
        '
        'Conf
        '
        Me.Conf.Image = Global.TheatreManagement.My.Resources.Resources.armchair
        Me.Conf.Location = New System.Drawing.Point(21, 121)
        Me.Conf.Name = "Conf"
        Me.Conf.Size = New System.Drawing.Size(10, 10)
        Me.Conf.TabIndex = 6
        Me.Conf.Text = "Confirm"
        Me.Conf.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(526, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TheatreManagement.My.Resources.Resources.grey_armchair
        Me.PictureBox2.Location = New System.Drawing.Point(55, 185)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 83)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.TheatreManagement.My.Resources.Resources.pink_armchair
        Me.PictureBox1.Location = New System.Drawing.Point(328, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pb1.Image = Global.TheatreManagement.My.Resources.Resources.armchair
        Me.pb1.Location = New System.Drawing.Point(217, 161)
        Me.pb1.Name = "pb1"
        Me.pb1.Padding = New System.Windows.Forms.Padding(20, 20, 40, 20)
        Me.pb1.Size = New System.Drawing.Size(92, 85)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb1.TabIndex = 1
        Me.pb1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(546, 166)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(180, 272)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 335)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "01-02-2022"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Label2"
        '
        'ScreenCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Conf)
        Me.Controls.Add(Me.labCol)
        Me.Controls.Add(Me.labRow)
        Me.Controls.Add(Me.txtCol)
        Me.Controls.Add(Me.txtRow)
        Me.Controls.Add(Me.pb1)
        Me.Name = "ScreenCreator"
        Me.Text = "ScreenCreator"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents txtRow As TextBox
    Friend WithEvents txtCol As TextBox
    Friend WithEvents labRow As Label
    Friend WithEvents labCol As Label
    Friend WithEvents Conf As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

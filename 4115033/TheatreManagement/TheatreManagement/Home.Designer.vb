<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.admpopup = New System.Windows.Forms.Panel()
        Me.btnlogoff = New System.Windows.Forms.Button()
        Me.btnadmint = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnemplogoff = New System.Windows.Forms.PictureBox()
        Me.adminButton = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.admpopup.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnemplogoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adminButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.admpopup)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1920, 1080)
        Me.Panel1.TabIndex = 0
        '
        'admpopup
        '
        Me.admpopup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.admpopup.Controls.Add(Me.btnlogoff)
        Me.admpopup.Controls.Add(Me.btnadmint)
        Me.admpopup.Location = New System.Drawing.Point(1701, 54)
        Me.admpopup.Name = "admpopup"
        Me.admpopup.Size = New System.Drawing.Size(190, 111)
        Me.admpopup.TabIndex = 2
        Me.admpopup.Visible = False
        '
        'btnlogoff
        '
        Me.btnlogoff.FlatAppearance.BorderSize = 0
        Me.btnlogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogoff.Font = New System.Drawing.Font("PenultimateLight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogoff.Location = New System.Drawing.Point(18, 56)
        Me.btnlogoff.Name = "btnlogoff"
        Me.btnlogoff.Size = New System.Drawing.Size(157, 35)
        Me.btnlogoff.TabIndex = 1
        Me.btnlogoff.Text = "Log Off"
        Me.btnlogoff.UseVisualStyleBackColor = True
        '
        'btnadmint
        '
        Me.btnadmint.FlatAppearance.BorderSize = 0
        Me.btnadmint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadmint.Font = New System.Drawing.Font("PenultimateLight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadmint.Location = New System.Drawing.Point(18, 15)
        Me.btnadmint.Name = "btnadmint"
        Me.btnadmint.Size = New System.Drawing.Size(157, 35)
        Me.btnadmint.TabIndex = 0
        Me.btnadmint.Text = "Admin Portal"
        Me.btnadmint.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnemplogoff)
        Me.Panel2.Controls.Add(Me.adminButton)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1935, 50)
        Me.Panel2.TabIndex = 0
        '
        'btnemplogoff
        '
        Me.btnemplogoff.BackColor = System.Drawing.Color.Transparent
        Me.btnemplogoff.BackgroundImage = Global.TheatreManagement.My.Resources.Resources.log_out_outline
        Me.btnemplogoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnemplogoff.Location = New System.Drawing.Point(1838, 3)
        Me.btnemplogoff.Name = "btnemplogoff"
        Me.btnemplogoff.Size = New System.Drawing.Size(54, 44)
        Me.btnemplogoff.TabIndex = 3
        Me.btnemplogoff.TabStop = False
        Me.btnemplogoff.Visible = False
        '
        'adminButton
        '
        Me.adminButton.BackColor = System.Drawing.Color.Transparent
        Me.adminButton.BackgroundImage = Global.TheatreManagement.My.Resources.Resources.person_sharp
        Me.adminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.adminButton.Location = New System.Drawing.Point(1838, 3)
        Me.adminButton.Name = "adminButton"
        Me.adminButton.Size = New System.Drawing.Size(54, 44)
        Me.adminButton.TabIndex = 0
        Me.adminButton.TabStop = False
        Me.adminButton.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PenultimateLight", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(876, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Movie Selection"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("PenultimateLight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("PenultimateLight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Click On Poster To Procede .. !!!"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.Text = "Theatre Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.admpopup.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnemplogoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adminButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents adminButton As PictureBox
    Friend WithEvents admpopup As Panel
    Friend WithEvents btnlogoff As Button
    Friend WithEvents btnadmint As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnemplogoff As PictureBox
    Friend WithEvents Label2 As Label
End Class

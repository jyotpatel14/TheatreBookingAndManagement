<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class movieSeatCostUpdate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClassic = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGold = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPremium = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MovieseatcostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtClassicupd = New System.Windows.Forms.TextBox()
        Me.txtGoldupd = New System.Windows.Forms.TextBox()
        Me.txtPremiumupd = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieseatcostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Movie :"
        '
        'txtClassic
        '
        Me.txtClassic.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClassic.Location = New System.Drawing.Point(226, 109)
        Me.txtClassic.Name = "txtClassic"
        Me.txtClassic.Size = New System.Drawing.Size(252, 34)
        Me.txtClassic.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Classic :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Gold :"
        '
        'txtGold
        '
        Me.txtGold.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGold.Location = New System.Drawing.Point(226, 149)
        Me.txtGold.Name = "txtGold"
        Me.txtGold.Size = New System.Drawing.Size(252, 34)
        Me.txtGold.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Premium :"
        '
        'txtPremium
        '
        Me.txtPremium.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremium.Location = New System.Drawing.Point(226, 189)
        Me.txtPremium.Name = "txtPremium"
        Me.txtPremium.Size = New System.Drawing.Size(252, 34)
        Me.txtPremium.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(157, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Cost In Rupees (₹)"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(226, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(252, 33)
        Me.ComboBox1.TabIndex = 3
        '
        'btnInsert
        '
        Me.btnInsert.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(162, 259)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(182, 71)
        Me.btnInsert.TabIndex = 4
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPremium)
        Me.GroupBox1.Controls.Add(Me.btnInsert)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtClassic)
        Me.GroupBox1.Controls.Add(Me.txtGold)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 359)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 436)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1071, 470)
        Me.DataGridView1.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Premium :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Gold :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(174, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 25)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Cost In Rupees (₹)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 25)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Classic :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Mid :"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(170, 259)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(182, 71)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(206, 30)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(252, 33)
        Me.ComboBox2.TabIndex = 3
        '
        'MovieseatcostBindingSource
        '
        Me.MovieseatcostBindingSource.DataMember = "movie_seat_cost"
        '
        'txtClassicupd
        '
        Me.txtClassicupd.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClassicupd.Location = New System.Drawing.Point(206, 109)
        Me.txtClassicupd.Name = "txtClassicupd"
        Me.txtClassicupd.Size = New System.Drawing.Size(252, 34)
        Me.txtClassicupd.TabIndex = 6
        '
        'txtGoldupd
        '
        Me.txtGoldupd.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGoldupd.Location = New System.Drawing.Point(206, 146)
        Me.txtGoldupd.Name = "txtGoldupd"
        Me.txtGoldupd.Size = New System.Drawing.Size(252, 34)
        Me.txtGoldupd.TabIndex = 6
        '
        'txtPremiumupd
        '
        Me.txtPremiumupd.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremiumupd.Location = New System.Drawing.Point(206, 183)
        Me.txtPremiumupd.Name = "txtPremiumupd"
        Me.txtPremiumupd.Size = New System.Drawing.Size(252, 34)
        Me.txtPremiumupd.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPremiumupd)
        Me.GroupBox2.Controls.Add(Me.txtGoldupd)
        Me.GroupBox2.Controls.Add(Me.txtClassicupd)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(604, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(503, 359)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'movieSeatCostUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 945)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "movieSeatCostUpdate"
        Me.Text = "movieSeatCostUpdate"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieseatcostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtClassic As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGold As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPremium As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents txtClassicupd As TextBox
    Friend WithEvents txtGoldupd As TextBox
    Friend WithEvents txtPremiumupd As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Database1DataSet2 As Database1DataSet2
    Friend WithEvents MovieseatcostBindingSource As BindingSource
    Friend WithEvents Movie_seat_costTableAdapter As Database1DataSet2TableAdapters.movie_seat_costTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class movielistupdate
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnopen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.GrpInsert = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GrpSelection = New System.Windows.Forms.GroupBox()
        Me.btnMdelete = New System.Windows.Forms.Button()
        Me.btnMupdate = New System.Windows.Forms.Button()
        Me.btnMinsert = New System.Windows.Forms.Button()
        Me.GrpUpdate = New System.Windows.Forms.GroupBox()
        Me.radupdimg = New System.Windows.Forms.CheckBox()
        Me.cmbupdstatus = New System.Windows.Forms.ComboBox()
        Me.btnupdopen = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.txtupdmid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtupddescription = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtupdname = New System.Windows.Forms.TextBox()
        Me.txtupdcast = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtupdduration = New System.Windows.Forms.TextBox()
        Me.GrpDelete = New System.Windows.Forms.GroupBox()
        Me.cmbdelname = New System.Windows.Forms.ComboBox()
        Me.cmbdelmid = New System.Windows.Forms.ComboBox()
        Me.delgridview = New System.Windows.Forms.DataGridView()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MoviemasterBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1MovieList = New TheatreManagement.Database1MovieList()
        Me.MoviemasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Movie_masterTableAdapter = New TheatreManagement.Database1MovieListTableAdapters.movie_masterTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpInsert.SuspendLayout()
        Me.GrpSelection.SuspendLayout()
        Me.GrpUpdate.SuspendLayout()
        Me.GrpDelete.SuspendLayout()
        CType(Me.delgridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoviemasterBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1MovieList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoviemasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 451)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1836, 466)
        Me.DataGridView1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(369, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 34)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Movie ID :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(369, 97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(320, 34)
        Me.TextBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name :"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(369, 144)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(320, 34)
        Me.TextBox3.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Duration :"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(369, 188)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(320, 34)
        Me.TextBox4.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cast :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Description :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(369, 234)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(320, 34)
        Me.TextBox5.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 25)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Poster"
        '
        'btnopen
        '
        Me.btnopen.Location = New System.Drawing.Point(369, 322)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.Size = New System.Drawing.Size(172, 39)
        Me.btnopen.TabIndex = 6
        Me.btnopen.Text = "Open Image"
        Me.btnopen.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1567, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 393)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btninsert
        '
        Me.btninsert.Location = New System.Drawing.Point(747, 160)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(138, 33)
        Me.btninsert.TabIndex = 7
        Me.btninsert.Text = "INSERT"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'GrpInsert
        '
        Me.GrpInsert.Controls.Add(Me.Button1)
        Me.GrpInsert.Controls.Add(Me.btninsert)
        Me.GrpInsert.Controls.Add(Me.btnopen)
        Me.GrpInsert.Controls.Add(Me.TextBox1)
        Me.GrpInsert.Controls.Add(Me.Label1)
        Me.GrpInsert.Controls.Add(Me.TextBox5)
        Me.GrpInsert.Controls.Add(Me.Label5)
        Me.GrpInsert.Controls.Add(Me.Label6)
        Me.GrpInsert.Controls.Add(Me.Label4)
        Me.GrpInsert.Controls.Add(Me.TextBox2)
        Me.GrpInsert.Controls.Add(Me.TextBox4)
        Me.GrpInsert.Controls.Add(Me.Label2)
        Me.GrpInsert.Controls.Add(Me.Label3)
        Me.GrpInsert.Controls.Add(Me.TextBox3)
        Me.GrpInsert.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpInsert.Location = New System.Drawing.Point(282, 22)
        Me.GrpInsert.Name = "GrpInsert"
        Me.GrpInsert.Size = New System.Drawing.Size(1259, 410)
        Me.GrpInsert.TabIndex = 9
        Me.GrpInsert.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("PenultimateLightItal", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(695, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 34)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GrpSelection
        '
        Me.GrpSelection.Controls.Add(Me.btnMdelete)
        Me.GrpSelection.Controls.Add(Me.btnMupdate)
        Me.GrpSelection.Controls.Add(Me.btnMinsert)
        Me.GrpSelection.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSelection.Location = New System.Drawing.Point(12, 22)
        Me.GrpSelection.Name = "GrpSelection"
        Me.GrpSelection.Size = New System.Drawing.Size(231, 410)
        Me.GrpSelection.TabIndex = 10
        Me.GrpSelection.TabStop = False
        '
        'btnMdelete
        '
        Me.btnMdelete.Location = New System.Drawing.Point(27, 274)
        Me.btnMdelete.Name = "btnMdelete"
        Me.btnMdelete.Size = New System.Drawing.Size(172, 102)
        Me.btnMdelete.TabIndex = 6
        Me.btnMdelete.Text = "Delete Record"
        Me.btnMdelete.UseVisualStyleBackColor = True
        '
        'btnMupdate
        '
        Me.btnMupdate.Location = New System.Drawing.Point(27, 150)
        Me.btnMupdate.Name = "btnMupdate"
        Me.btnMupdate.Size = New System.Drawing.Size(172, 102)
        Me.btnMupdate.TabIndex = 6
        Me.btnMupdate.Text = "Update Record"
        Me.btnMupdate.UseVisualStyleBackColor = True
        '
        'btnMinsert
        '
        Me.btnMinsert.Location = New System.Drawing.Point(27, 29)
        Me.btnMinsert.Name = "btnMinsert"
        Me.btnMinsert.Size = New System.Drawing.Size(172, 102)
        Me.btnMinsert.TabIndex = 6
        Me.btnMinsert.Text = "Insert Record"
        Me.btnMinsert.UseVisualStyleBackColor = True
        '
        'GrpUpdate
        '
        Me.GrpUpdate.Controls.Add(Me.radupdimg)
        Me.GrpUpdate.Controls.Add(Me.cmbupdstatus)
        Me.GrpUpdate.Controls.Add(Me.btnupdopen)
        Me.GrpUpdate.Controls.Add(Me.btnupdate)
        Me.GrpUpdate.Controls.Add(Me.txtupdmid)
        Me.GrpUpdate.Controls.Add(Me.Label7)
        Me.GrpUpdate.Controls.Add(Me.txtupddescription)
        Me.GrpUpdate.Controls.Add(Me.Label19)
        Me.GrpUpdate.Controls.Add(Me.Label8)
        Me.GrpUpdate.Controls.Add(Me.Label9)
        Me.GrpUpdate.Controls.Add(Me.Label10)
        Me.GrpUpdate.Controls.Add(Me.txtupdname)
        Me.GrpUpdate.Controls.Add(Me.txtupdcast)
        Me.GrpUpdate.Controls.Add(Me.Label11)
        Me.GrpUpdate.Controls.Add(Me.Label12)
        Me.GrpUpdate.Controls.Add(Me.txtupdduration)
        Me.GrpUpdate.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpUpdate.Location = New System.Drawing.Point(125, 438)
        Me.GrpUpdate.Name = "GrpUpdate"
        Me.GrpUpdate.Size = New System.Drawing.Size(1259, 410)
        Me.GrpUpdate.TabIndex = 9
        Me.GrpUpdate.TabStop = False
        '
        'radupdimg
        '
        Me.radupdimg.AutoSize = True
        Me.radupdimg.Location = New System.Drawing.Point(538, 326)
        Me.radupdimg.Name = "radupdimg"
        Me.radupdimg.Size = New System.Drawing.Size(151, 29)
        Me.radupdimg.TabIndex = 11
        Me.radupdimg.Text = "Update Image"
        Me.radupdimg.UseVisualStyleBackColor = True
        '
        'cmbupdstatus
        '
        Me.cmbupdstatus.FormattingEnabled = True
        Me.cmbupdstatus.Items.AddRange(New Object() {"Active", "Offline", "None"})
        Me.cmbupdstatus.Location = New System.Drawing.Point(369, 277)
        Me.cmbupdstatus.Name = "cmbupdstatus"
        Me.cmbupdstatus.Size = New System.Drawing.Size(320, 33)
        Me.cmbupdstatus.TabIndex = 9
        '
        'btnupdopen
        '
        Me.btnupdopen.Location = New System.Drawing.Point(369, 322)
        Me.btnupdopen.Name = "btnupdopen"
        Me.btnupdopen.Size = New System.Drawing.Size(151, 39)
        Me.btnupdopen.TabIndex = 6
        Me.btnupdopen.Text = "Open Image"
        Me.btnupdopen.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(748, 178)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(138, 33)
        Me.btnupdate.TabIndex = 8
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'txtupdmid
        '
        Me.txtupdmid.Location = New System.Drawing.Point(369, 51)
        Me.txtupdmid.Name = "txtupdmid"
        Me.txtupdmid.Size = New System.Drawing.Size(320, 34)
        Me.txtupdmid.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 25)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Movie ID :"
        '
        'txtupddescription
        '
        Me.txtupddescription.Location = New System.Drawing.Point(369, 234)
        Me.txtupddescription.Name = "txtupddescription"
        Me.txtupddescription.Size = New System.Drawing.Size(320, 34)
        Me.txtupddescription.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(91, 285)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 25)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(91, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 25)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Description :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(91, 327)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 25)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Poster"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(91, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 25)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Cast :"
        '
        'txtupdname
        '
        Me.txtupdname.Location = New System.Drawing.Point(369, 97)
        Me.txtupdname.Name = "txtupdname"
        Me.txtupdname.Size = New System.Drawing.Size(320, 34)
        Me.txtupdname.TabIndex = 2
        '
        'txtupdcast
        '
        Me.txtupdcast.Location = New System.Drawing.Point(369, 188)
        Me.txtupdcast.Name = "txtupdcast"
        Me.txtupdcast.Size = New System.Drawing.Size(320, 34)
        Me.txtupdcast.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(91, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 25)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Name :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(91, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 25)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Duration :"
        '
        'txtupdduration
        '
        Me.txtupdduration.Location = New System.Drawing.Point(369, 144)
        Me.txtupdduration.Name = "txtupdduration"
        Me.txtupdduration.Size = New System.Drawing.Size(320, 34)
        Me.txtupdduration.TabIndex = 3
        '
        'GrpDelete
        '
        Me.GrpDelete.Controls.Add(Me.cmbdelname)
        Me.GrpDelete.Controls.Add(Me.cmbdelmid)
        Me.GrpDelete.Controls.Add(Me.delgridview)
        Me.GrpDelete.Controls.Add(Me.btndelete)
        Me.GrpDelete.Controls.Add(Me.Label13)
        Me.GrpDelete.Controls.Add(Me.Label17)
        Me.GrpDelete.Font = New System.Drawing.Font("PenultimateLight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDelete.Location = New System.Drawing.Point(249, 197)
        Me.GrpDelete.Name = "GrpDelete"
        Me.GrpDelete.Size = New System.Drawing.Size(1259, 410)
        Me.GrpDelete.TabIndex = 9
        Me.GrpDelete.TabStop = False
        '
        'cmbdelname
        '
        Me.cmbdelname.FormattingEnabled = True
        Me.cmbdelname.Location = New System.Drawing.Point(369, 97)
        Me.cmbdelname.Name = "cmbdelname"
        Me.cmbdelname.Size = New System.Drawing.Size(320, 33)
        Me.cmbdelname.TabIndex = 12
        '
        'cmbdelmid
        '
        Me.cmbdelmid.FormattingEnabled = True
        Me.cmbdelmid.Location = New System.Drawing.Point(369, 55)
        Me.cmbdelmid.Name = "cmbdelmid"
        Me.cmbdelmid.Size = New System.Drawing.Size(320, 33)
        Me.cmbdelmid.TabIndex = 12
        '
        'delgridview
        '
        Me.delgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.delgridview.Location = New System.Drawing.Point(24, 170)
        Me.delgridview.Name = "delgridview"
        Me.delgridview.Size = New System.Drawing.Size(1212, 222)
        Me.delgridview.TabIndex = 10
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(886, 79)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(138, 33)
        Me.btndelete.TabIndex = 8
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(91, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 25)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Movie ID :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(91, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 25)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Name :"
        '
        'MoviemasterBindingSource1
        '
        Me.MoviemasterBindingSource1.DataMember = "movie_master"
        Me.MoviemasterBindingSource1.DataSource = Me.Database1MovieList
        '
        'Database1MovieList
        '
        Me.Database1MovieList.DataSetName = "Database1MovieList"
        Me.Database1MovieList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MoviemasterBindingSource
        '
        Me.MoviemasterBindingSource.DataMember = "movie_master"
        Me.MoviemasterBindingSource.DataSource = Me.Database1MovieList
        '
        'Movie_masterTableAdapter
        '
        Me.Movie_masterTableAdapter.ClearBeforeFill = True
        '
        'movielistupdate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1895, 945)
        Me.Controls.Add(Me.GrpSelection)
        Me.Controls.Add(Me.GrpDelete)
        Me.Controls.Add(Me.GrpUpdate)
        Me.Controls.Add(Me.GrpInsert)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "movielistupdate"
        Me.Text = "MovieListUpdate"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpInsert.ResumeLayout(False)
        Me.GrpInsert.PerformLayout()
        Me.GrpSelection.ResumeLayout(False)
        Me.GrpUpdate.ResumeLayout(False)
        Me.GrpUpdate.PerformLayout()
        Me.GrpDelete.ResumeLayout(False)
        Me.GrpDelete.PerformLayout()
        CType(Me.delgridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoviemasterBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1MovieList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoviemasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnopen As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btninsert As Button
    Friend WithEvents GrpInsert As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GrpSelection As GroupBox
    Friend WithEvents btnMdelete As Button
    Friend WithEvents btnMupdate As Button
    Friend WithEvents btnMinsert As Button
    Friend WithEvents GrpUpdate As GroupBox
    Friend WithEvents btnupdopen As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents txtupdmid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtupddescription As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtupdname As TextBox
    Friend WithEvents txtupdcast As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtupdduration As TextBox
    Friend WithEvents GrpDelete As GroupBox
    Friend WithEvents btndelete As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbupdstatus As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents radupdimg As CheckBox
    Friend WithEvents Database1MovieList As Database1MovieList
    Friend WithEvents MoviemasterBindingSource As BindingSource
    Friend WithEvents Movie_masterTableAdapter As Database1MovieListTableAdapters.movie_masterTableAdapter
    Friend WithEvents delgridview As DataGridView
    Friend WithEvents MoviemasterBindingSource1 As BindingSource
    Friend WithEvents cmbdelname As ComboBox
    Friend WithEvents cmbdelmid As ComboBox
End Class

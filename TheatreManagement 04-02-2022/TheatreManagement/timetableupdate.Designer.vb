﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class timetableupdate
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MoviemasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1MovieList = New TheatreManagement.Database1MovieList()
        Me.Movie_masterTableAdapter = New TheatreManagement.Database1MovieListTableAdapters.movie_masterTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ScreendetailBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New TheatreManagement.Database1DataSet()
        Me.ScreendetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Screen_detailTableAdapter = New TheatreManagement.Database1DataSetTableAdapters.screen_detailTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TimedetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1time_details = New TheatreManagement.Database1time_details()
        Me.Time_detailTableAdapter = New TheatreManagement.Database1time_detailsTableAdapters.time_detailTableAdapter()
        Me.ScreendetailBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btninsert = New System.Windows.Forms.Button()
        CType(Me.MoviemasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1MovieList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScreendetailBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScreendetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimedetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1time_details, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScreendetailBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Show Id :"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.MoviemasterBindingSource
        Me.ComboBox1.DisplayMember = "mname"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(130, 86)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'MoviemasterBindingSource
        '
        Me.MoviemasterBindingSource.DataMember = "movie_master"
        Me.MoviemasterBindingSource.DataSource = Me.Database1MovieList
        '
        'Database1MovieList
        '
        Me.Database1MovieList.DataSetName = "Database1MovieList"
        Me.Database1MovieList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Movie_masterTableAdapter
        '
        Me.Movie_masterTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Select Movie : "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(130, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Select Screen : "
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ScreendetailBindingSource2
        Me.ComboBox2.DisplayMember = "scrname"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(130, 113)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'ScreendetailBindingSource2
        '
        Me.ScreendetailBindingSource2.DataMember = "screen_detail"
        Me.ScreendetailBindingSource2.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScreendetailBindingSource
        '
        Me.ScreendetailBindingSource.DataMember = "screen_detail"
        Me.ScreendetailBindingSource.DataSource = Me.Database1DataSet
        '
        'Screen_detailTableAdapter
        '
        Me.Screen_detailTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Select Date : "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(130, 140)
        Me.DateTimePicker1.MinDate = New Date(2022, 1, 9, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Select Time : "
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.TimedetailBindingSource
        Me.ComboBox3.DisplayMember = "time"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(130, 166)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 5
        '
        'TimedetailBindingSource
        '
        Me.TimedetailBindingSource.DataMember = "time_detail"
        Me.TimedetailBindingSource.DataSource = Me.Database1time_details
        '
        'Database1time_details
        '
        Me.Database1time_details.DataSetName = "Database1time_details"
        Me.Database1time_details.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Time_detailTableAdapter
        '
        Me.Time_detailTableAdapter.ClearBeforeFill = True
        '
        'ScreendetailBindingSource1
        '
        Me.ScreendetailBindingSource1.DataMember = "screen_detail"
        Me.ScreendetailBindingSource1.DataSource = Me.Database1DataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(283, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(485, 307)
        Me.DataGridView1.TabIndex = 4
        '
        'btninsert
        '
        Me.btninsert.Location = New System.Drawing.Point(49, 216)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(75, 23)
        Me.btninsert.TabIndex = 5
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'timetableupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "timetableupdate"
        Me.Text = "timetableupdate"
        CType(Me.MoviemasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1MovieList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScreendetailBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScreendetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimedetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1time_details, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScreendetailBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Database1MovieList As Database1MovieList
    Friend WithEvents MoviemasterBindingSource As BindingSource
    Friend WithEvents Movie_masterTableAdapter As Database1MovieListTableAdapters.movie_masterTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents ScreendetailBindingSource As BindingSource
    Friend WithEvents Screen_detailTableAdapter As Database1DataSetTableAdapters.screen_detailTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Database1time_details As Database1time_details
    Friend WithEvents TimedetailBindingSource As BindingSource
    Friend WithEvents Time_detailTableAdapter As Database1time_detailsTableAdapters.time_detailTableAdapter
    Friend WithEvents ScreendetailBindingSource2 As BindingSource
    Friend WithEvents ScreendetailBindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btninsert As Button
End Class

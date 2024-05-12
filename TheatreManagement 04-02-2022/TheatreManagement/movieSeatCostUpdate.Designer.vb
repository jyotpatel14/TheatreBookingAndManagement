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
        Me.Database1DataSet1 = New TheatreManagement.Database1DataSet1()
        Me.MoviemasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Movie_masterTableAdapter = New TheatreManagement.Database1DataSet1TableAdapters.movie_masterTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoviemasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PenultimateLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Movie :"
        '
        'txtClassic
        '
        Me.txtClassic.Font = New System.Drawing.Font("PenultimateLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClassic.Location = New System.Drawing.Point(175, 142)
        Me.txtClassic.Name = "txtClassic"
        Me.txtClassic.Size = New System.Drawing.Size(121, 28)
        Me.txtClassic.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("PenultimateLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Classic :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("PenultimateLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Gold :"
        '
        'txtGold
        '
        Me.txtGold.Font = New System.Drawing.Font("PenultimateLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGold.Location = New System.Drawing.Point(175, 176)
        Me.txtGold.Name = "txtGold"
        Me.txtGold.Size = New System.Drawing.Size(121, 28)
        Me.txtGold.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("PenultimateLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Premium :"
        '
        'txtPremium
        '
        Me.txtPremium.Font = New System.Drawing.Font("PenultimateLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremium.Location = New System.Drawing.Point(175, 210)
        Me.txtPremium.Name = "txtPremium"
        Me.txtPremium.Size = New System.Drawing.Size(121, 28)
        Me.txtPremium.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("PenultimateLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(122, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Cost In Rupees (₹)"
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MoviemasterBindingSource
        '
        Me.MoviemasterBindingSource.DataMember = "movie_master"
        Me.MoviemasterBindingSource.DataSource = Me.Database1DataSet1
        '
        'Movie_masterTableAdapter
        '
        Me.Movie_masterTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("PenultimateLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(175, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 26)
        Me.ComboBox1.TabIndex = 3
        '
        'btnInsert
        '
        Me.btnInsert.Font = New System.Drawing.Font("PenultimateLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(59, 264)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(98, 35)
        Me.btnInsert.TabIndex = 4
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'movieSeatCostUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 343)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtPremium)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGold)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClassic)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "movieSeatCostUpdate"
        Me.Text = "movieSeatCostUpdate"
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoviemasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtClassic As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGold As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPremium As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Database1DataSet1 As Database1DataSet1
    Friend WithEvents MoviemasterBindingSource As BindingSource
    Friend WithEvents Movie_masterTableAdapter As Database1DataSet1TableAdapters.movie_masterTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnInsert As Button
End Class

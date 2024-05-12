<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report_Selection
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
        Me.cash_masterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New TheatreManagement.DataSet1()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.transaction_masterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.transaction_masterTableAdapter = New TheatreManagement.DataSet1TableAdapters.transaction_masterTableAdapter()
        Me.cash_masterTableAdapter = New TheatreManagement.DataSet1TableAdapters.cash_masterTableAdapter()
        CType(Me.cash_masterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transaction_masterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cash_masterBindingSource
        '
        Me.cash_masterBindingSource.DataMember = "cash_master"
        Me.cash_masterBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("PenultimateLightItal", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(35, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 37)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cash Counter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("PenultimateLightItal", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(226, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Seat Sold"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'transaction_masterBindingSource
        '
        Me.transaction_masterBindingSource.DataMember = "transaction_master"
        Me.transaction_masterBindingSource.DataSource = Me.DataSet1
        '
        'transaction_masterTableAdapter
        '
        Me.transaction_masterTableAdapter.ClearBeforeFill = True
        '
        'cash_masterTableAdapter
        '
        Me.cash_masterTableAdapter.ClearBeforeFill = True
        '
        'Report_Selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 94)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Report_Selection"
        Me.Text = "Report_Selection"
        CType(Me.cash_masterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transaction_masterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents transaction_masterBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents transaction_masterTableAdapter As DataSet1TableAdapters.transaction_masterTableAdapter
    Friend WithEvents cash_masterBindingSource As BindingSource
    Friend WithEvents cash_masterTableAdapter As DataSet1TableAdapters.cash_masterTableAdapter
End Class

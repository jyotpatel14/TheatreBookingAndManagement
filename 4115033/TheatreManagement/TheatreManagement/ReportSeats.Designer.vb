<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportSeats
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1 = New TheatreManagement.DataSet1()
        Me.cash_masterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cash_masterTableAdapter = New TheatreManagement.DataSet1TableAdapters.cash_masterTableAdapter()
        Me.transaction_masterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.transaction_masterTableAdapter = New TheatreManagement.DataSet1TableAdapters.transaction_masterTableAdapter()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cash_masterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transaction_masterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.transaction_masterBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TheatreManagement.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1124, 547)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cash_masterBindingSource
        '
        Me.cash_masterBindingSource.DataMember = "cash_master"
        Me.cash_masterBindingSource.DataSource = Me.DataSet1
        '
        'cash_masterTableAdapter
        '
        Me.cash_masterTableAdapter.ClearBeforeFill = True
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
        'ReportSeats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1124, 547)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportSeats"
        Me.Text = "ReportSeats"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cash_masterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transaction_masterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cash_masterBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents cash_masterTableAdapter As DataSet1TableAdapters.cash_masterTableAdapter
    Friend WithEvents transaction_masterBindingSource As BindingSource
    Friend WithEvents transaction_masterTableAdapter As DataSet1TableAdapters.transaction_masterTableAdapter
End Class

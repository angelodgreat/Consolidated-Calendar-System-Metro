<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportViewer
    Inherits MetroFramework.Forms.MetroForm

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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportViewer))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.mcb_filtercollege = New MetroFramework.Controls.MetroComboBox()
        Me.mdtp_filter1 = New MetroFramework.Controls.MetroDateTime()
        Me.mdtp_filter2 = New MetroFramework.Controls.MetroDateTime()
        Me.ml_search = New MetroFramework.Controls.MetroLink()
        Me.ml_minimize = New MetroFramework.Controls.MetroLink()
        Me.ml_exit = New MetroFramework.Controls.MetroLink()
        Me.SAOEventBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Consolidated_Calendar_System.DataSet1()
        Me.mb_refresh = New MetroFramework.Controls.MetroButton()
        CType(Me.SAOEventBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SAOEventBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Consolidated_Calendar_System.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(20, 60)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1214, 379)
        Me.ReportViewer1.TabIndex = 0
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(754, 35)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(132, 19)
        Me.MetroLabel3.TabIndex = 19
        Me.MetroLabel3.Text = "School/Organization:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(135, 35)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel2.TabIndex = 18
        Me.MetroLabel2.Text = "Date:"
        '
        'mcb_filtercollege
        '
        Me.mcb_filtercollege.FormattingEnabled = True
        Me.mcb_filtercollege.ItemHeight = 23
        Me.mcb_filtercollege.Location = New System.Drawing.Point(889, 25)
        Me.mcb_filtercollege.Name = "mcb_filtercollege"
        Me.mcb_filtercollege.Size = New System.Drawing.Size(274, 29)
        Me.mcb_filtercollege.TabIndex = 17
        Me.mcb_filtercollege.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mcb_filtercollege.UseSelectable = True
        '
        'mdtp_filter1
        '
        Me.mdtp_filter1.Location = New System.Drawing.Point(177, 25)
        Me.mdtp_filter1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtp_filter1.Name = "mdtp_filter1"
        Me.mdtp_filter1.Size = New System.Drawing.Size(230, 29)
        Me.mdtp_filter1.TabIndex = 15
        '
        'mdtp_filter2
        '
        Me.mdtp_filter2.Location = New System.Drawing.Point(413, 25)
        Me.mdtp_filter2.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtp_filter2.Name = "mdtp_filter2"
        Me.mdtp_filter2.Size = New System.Drawing.Size(230, 29)
        Me.mdtp_filter2.TabIndex = 20
        '
        'ml_search
        '
        Me.ml_search.Image = CType(resources.GetObject("ml_search.Image"), System.Drawing.Image)
        Me.ml_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_search.ImageSize = 32
        Me.ml_search.Location = New System.Drawing.Point(649, 15)
        Me.ml_search.Name = "ml_search"
        Me.ml_search.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.Search_2
        Me.ml_search.Size = New System.Drawing.Size(99, 39)
        Me.ml_search.TabIndex = 87
        Me.ml_search.Text = "Search"
        Me.ml_search.UseSelectable = True
        '
        'ml_minimize
        '
        Me.ml_minimize.Image = CType(resources.GetObject("ml_minimize.Image"), System.Drawing.Image)
        Me.ml_minimize.ImageSize = 32
        Me.ml_minimize.Location = New System.Drawing.Point(1169, 6)
        Me.ml_minimize.Name = "ml_minimize"
        Me.ml_minimize.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.minimize_2
        Me.ml_minimize.Size = New System.Drawing.Size(41, 39)
        Me.ml_minimize.TabIndex = 101
        Me.ml_minimize.UseSelectable = True
        '
        'ml_exit
        '
        Me.ml_exit.Image = CType(resources.GetObject("ml_exit.Image"), System.Drawing.Image)
        Me.ml_exit.ImageSize = 32
        Me.ml_exit.Location = New System.Drawing.Point(1213, 6)
        Me.ml_exit.Name = "ml_exit"
        Me.ml_exit.NoFocusImage = Global.Consolidated_Calendar_System.My.Resources.Resources.power_2
        Me.ml_exit.Size = New System.Drawing.Size(41, 39)
        Me.ml_exit.TabIndex = 100
        Me.ml_exit.UseSelectable = True
        '
        'SAOEventBindingSource
        '
        Me.SAOEventBindingSource.DataMember = "SAOEvent"
        Me.SAOEventBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mb_refresh
        '
        Me.mb_refresh.Location = New System.Drawing.Point(23, 31)
        Me.mb_refresh.Name = "mb_refresh"
        Me.mb_refresh.Size = New System.Drawing.Size(75, 23)
        Me.mb_refresh.TabIndex = 102
        Me.mb_refresh.Text = "Refresh"
        Me.mb_refresh.UseSelectable = True
        '
        'FrmReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 459)
        Me.ControlBox = False
        Me.Controls.Add(Me.mb_refresh)
        Me.Controls.Add(Me.ml_minimize)
        Me.Controls.Add(Me.ml_exit)
        Me.Controls.Add(Me.ml_search)
        Me.Controls.Add(Me.mdtp_filter2)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.mcb_filtercollege)
        Me.Controls.Add(Me.mdtp_filter1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReportViewer"
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        CType(Me.SAOEventBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SAOEventBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcb_filtercollege As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mdtp_filter1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mdtp_filter2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents ml_search As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_minimize As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_exit As MetroFramework.Controls.MetroLink
    Friend WithEvents mb_refresh As MetroFramework.Controls.MetroButton
End Class
